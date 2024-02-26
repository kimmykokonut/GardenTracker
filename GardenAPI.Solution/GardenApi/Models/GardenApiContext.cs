using Microsoft.EntityFrameworkCore;

namespace GardenApi.Models
{
  public class GardenApiContext : DbContext
  {
    public DbSet<Garden> Gardens { get; set; }
    public DbSet<Grid> Grids { get; set; }
    public DbSet<Seed> Seeds { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<GridSeed> GridSeeds { get; set; }
    public DbSet<SeedTag> SeedTags { get; set; }

    public GardenApiContext(DbContextOptions<GardenApiContext> options) : base(options)
    {
    }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Seed>()
            .HasData(
              new Seed { 
                SeedId = 1,
                Type = "vegetable",
                Name = "Hakurei Turnip",
                Quantity = 10,
                Information = "The Hakurei Turnip (a.k.a Tokyo Turnip) variety is usually stark white and has an unmatched crispness and tender sweetness. This turnip is commonly eaten raw which has led to it being given the nickname of 'Salad Turnip'.",
                PlantingDates = "spring, fall, winter",
                DaysToGerminate = "5-10",
                DepthToSow = "1/4-1/2 in",
                SeedSpacing = "2 in",
                RowSpacing = "12-24in",
                DaysToHarvest = 45, 
                PhotoUrl = "https://cdn.mos.cms.futurecdn.net/HMr9ceyW7Sc2kuz2S3dNF5.jpg",
                Status = "planted",
                Results = "n/a",
                Yield = "n/a"
                }
            );
        }
    }
}