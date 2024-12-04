using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace pruebahotel.Data.Models
{
    public class Hotel
    {
        [Key]
        public int id_hotel { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }
        public DateTime horarios { get; set; }
        public string descripcion { get; set; }

        //propiedades de navegación
        public List<Habitacion> habitaciones { get; set; }
    }
}
