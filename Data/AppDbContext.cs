using Microsoft.EntityFrameworkCore;
using pruebahotel.Data.Models;

namespace pruebahotel.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<detalles_reserva>()
                .HasOne(b => b.Reservaciones)
                .WithMany(ba => ba.detalles_Reservas)
                .HasForeignKey(bi => bi.id_reservacion);

            modelBuilder.Entity<detalles_reserva>()
                .HasOne(b => b.Habitacion)
                .WithMany(ba => ba.detalles_Reservas)
                .HasForeignKey(bi => bi.Id_habitacion);
        }

        //utilizamos este metodo para obtener y enviar BD.
        public DbSet<Hotel> hotels { get; set; }
        public DbSet<Habitacion> habitaciones { get ;set; }
        public DbSet<reservaciones> Reservaciones { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<detalles_reserva> detalles_Reservas { get; set; }
    }
}
