using GestionReserva.Domain.Entidades.Reserva;

namespace GestionReserva.Domain.Repositorios
{
    public interface IRepositorioReserva
    {
        Task<List<Reserva>> ObtenerColeccionReservasAsync();
        Task<Reserva> ObtenerReservaPorIdAsync(IdReserva idReserva);
        Task<Reserva> CrearReservaAsync(Reserva nuevaReserva);
    }
}