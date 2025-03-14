using GestionReserva.Application.Servicios.Queries;
using GestionReserva.Domain.Entidades.Reserva;

namespace GestionReserva.Application.Queries.Handlers
{
    public class ObtenerReservasQueryHandler
    {
        private readonly ServicioConsultaReservas _servicioConsultaReservas;

        public ObtenerReservasQueryHandler(ServicioConsultaReservas servicioConsultaReservas)
        {
            _servicioConsultaReservas = servicioConsultaReservas;
        }

        public async Task<List<Reserva>> HandleAsync()
        {
            return await _servicioConsultaReservas.ObtenerColeccionReservasAsync();
        }
    }
}