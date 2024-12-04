using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pruebahotel.Data.Services;
using pruebahotel.Data.ViewModels;
using pruebahotel.Data.Models;

namespace pruebahotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservacionController : ControllerBase
    {
        public ReservacionServices _reservacionService;
        public ReservacionController(ReservacionServices reservacionServices)
        {
            _reservacionService = reservacionServices;
        }

        //listar reservaciones
        [HttpGet("Listar todas las reservaciones")]
        public IActionResult Getallreservacion()
        {
            var allreservaciones = _reservacionService.GetReservacion();
            return Ok(allreservaciones);
        }

        //buscar reservacion
        [HttpGet("Buscar reservacion/{id}")]
        public IActionResult GetreservacionById(int id)
        {
            var reservacion = _reservacionService.GetReservacionById(id);
            return Ok(reservacion);
        }

        //agregar reservacion
        [HttpPost("Agregar reservacion")]
        public IActionResult Addreservacion([FromBody] ReservaVM reservacion)
        {
            _reservacionService.AddReservacion(reservacion);
            return Ok();
        }

        //Editar reservacion
        [HttpPut("Modificar reservacion/{id}")]
        public IActionResult UpdatereservacionById(int id, [FromBody] ReservaVM reservacion)
        {
            var updatereservacion = _reservacionService.UpdateReservacionById(id, reservacion);
            return Ok(updatereservacion);
        }

        //Eliminar reservacion
        [HttpDelete("Eliminar reservacion/{id}")]
        public IActionResult DeletereservacionById(int id)
        {
            _reservacionService.DeletereservaById(id);
            return Ok();
        }
    }
}
