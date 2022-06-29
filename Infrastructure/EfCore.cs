using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class EfCore:DbContext
{
    public DbSet<Model> DbModel { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "DbContextRider");
        base.OnConfiguring(optionsBuilder);
    }
}