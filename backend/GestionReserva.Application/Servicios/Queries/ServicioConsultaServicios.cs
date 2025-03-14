using GestionReserva.Domain.Entidades.Servicio;
using GestionReserva.Domain.Servicios.Queries;

namespace GestionReserva.Application.Servicios.Queries
{
    public class ServicioConsultaServicios
    {
        private readonly HelperConsultaGestionReserva _helperConsultaGestionReserva;
        public ServicioConsultaServicios(HelperConsultaGestionReserva helperConsultaGestionReserva)
        {
            _helperConsultaGestionReserva = helperConsultaGestionReserva;
        }

        public async Task<List<Servicio>> ObtenerColeccionServiciosAsync()
        {
            return await _helperConsultaGestionReserva.ObtenerColeccionServiciosAsync();
        }
    }
}