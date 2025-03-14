using GestionReserva.Application.Servicios.Queries;
using GestionReserva.Domain.Entidades.Servicio;

namespace GestionReserva.Application.Queries.Handlers
{
    public class ObtenerServiciosQueryHandler
    {
        private readonly ServicioConsultaServicios _servicioConsultaServicios;

        public ObtenerServiciosQueryHandler(ServicioConsultaServicios servicioConsultaServicios)
        {
            _servicioConsultaServicios = servicioConsultaServicios;
        }

        public async Task<List<Servicio>> HandleAsync()
        {
            return await _servicioConsultaServicios.ObtenerColeccionServiciosAsync();
        }
    }
}