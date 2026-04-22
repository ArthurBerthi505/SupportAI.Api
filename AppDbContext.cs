using Microsoft.EntityFrameworkCore;

namespace SupportAI.Api;

public class AppDbContext : DbContext
{
    // Isso diz ao EF Core para criar uma tabela chamada 'Tickets' baseada na nossa classe
    public DbSet<Ticket> Tickets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Define que usaremos o SQLite e o nome do arquivo será 'suporte.db'
        optionsBuilder.UseSqlite("Data Source=suporte.db");
    }
}