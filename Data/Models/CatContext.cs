using Microsoft.EntityFrameworkCore;

namespace catsapi.Models;

public class CatContext : DbContext
{
    public CatContext(DbContextOptions<CatContext> options)
        : base(options)
    {
    }

    public DbSet<Cat> Gatos { get; set; } = null!;
}