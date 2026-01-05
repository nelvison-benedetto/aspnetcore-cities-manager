using CitiesManager.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.Web.DatabaseContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }

    public virtual DbSet<City> Cities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<City>().HasData(new City() { CityId= Guid.Parse("CDBE0726 - BAFB - 4D1F - 8B14 - 12364CF2E139"), CityName="New York" });
        modelBuilder.Entity<City>().HasData(new City() { CityId = Guid.Parse("FF968DC0-1BC0-4A77-9BDC-8BDA6A91106B"), CityName="Shenzo" });
    }
    //tools>create guid>select 4 registry format> copy generated guid
}
