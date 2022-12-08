using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

namespace Pokemon.Data
{
    public class AppC : DbContext
    {
        public AppC(DbContextOptions<AppC> options) : base(options)
        {

        }

        public DbSet<Pokedex> Pokedex { get; set; }
    }
}
