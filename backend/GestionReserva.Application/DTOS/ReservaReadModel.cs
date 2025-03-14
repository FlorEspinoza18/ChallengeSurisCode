using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entidades.Reserva;

namespace GestionReserva.Application.DTOS
{
    public class ReservaReadModel
    {
        public IdReserva IdReserva { get; private set; }
        public FechaReserva FechaReserva { get; private set; }
        public HoraReserva HoraReserva { get; private set; }
        public IdServicio IdServicio { get; private set; }
        public IdCliente IdCliente { get; private set; }
    }
}