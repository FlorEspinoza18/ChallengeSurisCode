using GestionReserva.Application.Servicios.Queries;
using GestionReserva.Domain.Entidades.Reserva;
using Microsoft.AspNetCore.Mvc;

namespace ApiSurisCode.Controllers.Lectura.GestionReserva
{
    [ApiController]
    [Route("api/gestion-reserva/reservas-obtener")]
    public class ConsultaReservaController : ControllerBase
    {
        private readonly ServicioConsultaReservas _servicioConsultaReserva;

        public ConsultaReservaController(ServicioConsultaReservas servicioConsultaReserva)
        {
            _servicioConsultaReserva = servicioConsultaReserva;
        }

        [HttpGet]
        public async Task<ActionResult<List<Reserva>>> Get()
        {
            var reservas = await _servicioConsultaReserva.ObtenerColeccionReservasAsync();
            return Ok(reservas);
        }
    }
}