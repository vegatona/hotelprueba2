using System.ComponentModel.DataAnnotations;

namespace pruebahotel.Data.Models
{
    public class detalles_reserva
    {
        [Key]
        public int id { get; set; }
        public int id_reservacion { get; set; }
        public reservaciones Reservaciones { get; set; }
        public int Id_habitacion { get; set; }
        public Habitacion Habitacion { get; set; }
    }
}
