using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace pruebahotel.Data.Models
{
    public class reservaciones
    {
        [Key]
        public int id_reservacion { get; set; }
        public int id_habitacion { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_final { get; set; }
        public string estado { get; set; }
        public int total_pagado { get; set; }

        //propiedades de navegación
        public int id_usuario { get; set; }
        public Usuario usuario { get; set; }
        public List<detalles_reserva> detalles_Reservas {  get; set; }
    }
}