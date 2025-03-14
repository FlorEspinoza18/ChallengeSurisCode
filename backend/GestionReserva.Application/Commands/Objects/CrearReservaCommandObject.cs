using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entidades.Reserva;

namespace GestionReserva.Application.Commands.Objects
{
    public class CrearReservaCommandObject
    {
        public IdCliente IdCliente { get; set; }
        public IdServicio IdServicio { get; set; }
        public FechaReserva FechaReserva { get; set; }
        public HoraReserva HoraReserva { get; set; }
    }
}