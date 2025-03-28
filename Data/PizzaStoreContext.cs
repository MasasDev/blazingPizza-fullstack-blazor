using BlazingPizza;
using Microsoft.EntityFrameworkCore;
namespace BlazingPizza.Data;

public class PizzaStoreContext: DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<PizzaSpecial> PizzaSpecials { get; set; }
}