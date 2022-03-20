using Firma.Data.Data.CMS;
using Firma.Data.Data.Sklep;
using Microsoft.EntityFrameworkCore;

namespace Firma.Data.Data;

public class FirmaContext : DbContext
{
    public FirmaContext(DbContextOptions<FirmaContext> options)
        : base(options)
    {
    }

    public DbSet<Aktualnosc> Aktualnosc { get; set; }

    public DbSet<Strona> Strona { get; set; }

    public DbSet<Parametr> Parametr { get; set; }

    public DbSet<Rodzaj> Rodzaj { get; set; }

    public DbSet<Towar> Towar { get; set; }
}