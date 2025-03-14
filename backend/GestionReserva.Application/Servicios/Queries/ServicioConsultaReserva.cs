using GestionReserva.Domain.Entidades.Reserva;
using GestionReserva.Domain.Servicios.Queries;

namespace GestionReserva.Application.Servicios.Queries
{
    public class ServicioConsultaReservas
    {
        private readonly HelperConsultaGestionReserva _helperConsulta;

        public ServicioConsultaReservas(HelperConsultaGestionReserva helperConsulta)
        {
            _helperConsulta = helperConsulta;
        }

        public async Task<List<Reserva>> ObtenerColeccionReservasAsync()
        {
            return await _helperConsulta.ObtenerTodasLasReservasAsync();
        }
    }
}