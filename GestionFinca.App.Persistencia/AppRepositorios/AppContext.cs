using Microsoft.EntityFrameworkCore;
using GestionFinca.App.Dominio;
namespace GestionFinca.App.Persistencia 
{
    public class AppContext : DbContext 
    {
        public DbSet<Finca> Fincas {get; set;}
        public DbSet<Lote> Lotes {get; set;}
        public DbSet<Transaccion> Transacciones {get; set;}
        public DbSet<FertilizanteEnmienda> FestilizantesEnmiendas {get; set;}
        public DbSet<Material> Materiales {get; set;}
        public DbSet<Agroquimico> Agroquimicos {get; set;}
        public DbSet<Inventario> Inventarios {get; set;}
               
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GestionFinca.Data");
            }
        }

    }
}