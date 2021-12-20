using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace AgenciaViagens.Models
{
  public class DataBaseContext : DbContext
  {
    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Viagem> Viagens { get; set; }
    public DbSet<Passagem> Passagens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(connectionString: "Data Source=DESKTOP-3PLJOV1;Initial Catalog=AgenciaViagens; Integrated Security=true;");
    }
  }
}