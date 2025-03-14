using GestionReserva.Application.Commands.Objects;
using GestionReserva.Application.Servicios.Command;
using Microsoft.AspNetCore.Mvc;

namespace ApiSurisCode.Controllers.Escritura.GestionReserva
{
    [ApiController]
    [Route("api/gestion-reserva/crear-reserva")]
    public class CrearReservaController : ControllerBase
    {
        private readonly ServicioCreacionReserva _servicioCreacionReserva;

        public CrearReservaController(ServicioCreacionReserva servicioCreacionReserva)
        {
            _servicioCreacionReserva = servicioCreacionReserva;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CrearReservaCommandObject commandObject)
        {
            if (commandObject.FechaReserva == null || commandObject.HoraReserva == null)
                return BadRequest("La fecha y la hora de la reserva son obligatorias.");

            // Llamada al servicio
            var resultado = await _servicioCreacionReserva.CrearReservaAsync(commandObject);

            if (resultado.Contains("Error al intentar crear la reserva."))
                return BadRequest(resultado); 

            return Ok(resultado);
        }
    }
}