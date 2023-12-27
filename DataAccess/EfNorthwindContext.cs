using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EfNorthwindContext : DbContext
    {
        public EfNorthwindContext(DbContextOptions<EfNorthwindContext> options) : base(options)
        {

        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
    }
}
