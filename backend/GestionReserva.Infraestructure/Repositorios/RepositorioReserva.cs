using GestionReserva.Domain.Entidades.Reserva;
using GestionReserva.Domain.Repositorios;

namespace GestionReserva.Infrastructure.Repositorios
{
    public class RepositorioReserva : IRepositorioReserva
    {
        private readonly List<Reserva> _reservas = new List<Reserva>();

        public Task<Reserva> ObtenerReservaPorIdAsync(IdReserva idReserva)
        {
            var reserva = _reservas.FirstOrDefault(r => r.IdReserva == idReserva);
            return Task.FromResult(reserva);
        }

        public Task<Reserva> CrearReservaAsync(Reserva nuevaReserva)
        {
            _reservas.Add(nuevaReserva);
            return Task.FromResult(nuevaReserva);
        }

        public Task<List<Reserva>> ObtenerColeccionReservasAsync()
        {
            throw new NotImplementedException();
        }
    }
}