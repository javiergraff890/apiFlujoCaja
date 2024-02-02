using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class FlujoCajaContext : DbContext
    {
        public FlujoCajaContext(DbContextOptions<FlujoCajaContext> options)
        :base (options)
        {
            
        }
        
        public DbSet<Caja> Cajas { get; set; }  
        public DbSet<Movimiento> Movimientos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Caja>().ToTable("Caja");
            modelBuilder.Entity<Movimiento>().ToTable("Movimiento");
        }

    }
}
