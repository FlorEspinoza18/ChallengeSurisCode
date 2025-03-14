using GestionReserva.Application.Servicios.Queries;
using GestionReserva.Domain.Entidades.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace ApiSurisCode.Controllers.Lectura.GestionReserva
{
    [ApiController]
    [Route("api/gestion-reservas/servicios-obtener")]
    public class ConsultaServiciosController : ControllerBase
    {
        private readonly ServicioConsultaServicios _servicioConsultaServicios;

        public ConsultaServiciosController(ServicioConsultaServicios servicioConsultaServicios)
        {
            _servicioConsultaServicios = servicioConsultaServicios;
        }

        [HttpGet]
        public async Task<ActionResult<List<Servicio>>> Get()
        {
            var servicios = await _servicioConsultaServicios.ObtenerColeccionServiciosAsync();
            return Ok(servicios);
        }
    }
}