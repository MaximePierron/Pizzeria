using Microsoft.EntityFrameworkCore;
using pizzas_mama.Models;

namespace pizzas_mama.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
