using Microsoft.EntityFrameworkCore;
using OgrenciKayit.Models;

public class OgrDbContext : DbContext
{
    public OgrDbContext(DbContextOptions<OgrDbContext> options) : base(options)
    {
    }

    public DbSet<Ogreciler> Ogrenciler { get; set; }
}
