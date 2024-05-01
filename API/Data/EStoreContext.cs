using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class EStoreContext : DbContext
{
    public EStoreContext(DbContextOptions<EStoreContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }


    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);
    }
}


