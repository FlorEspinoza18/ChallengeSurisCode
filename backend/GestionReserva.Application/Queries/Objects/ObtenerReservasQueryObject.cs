using GestionReserva.Domain.Entidades.Reserva;

namespace GestionReserva.Application.Queries.Objects
{
    public class ObtenerReservasQueryObject
    {
        public IdReserva IdReserva { get; private set; }
        public DateTime FechaReserva { get; private set; }
        public DateTime HoraReserva { get; private set; }
        public int IdServicio { get; private set; }
        public int IdCliente { get; private set; }
    }
}