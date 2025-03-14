using GestionReserva.Domain.Entidades.Compartidos;

namespace GestionReserva.Domain.Entidades.Reserva
{
    public class Reserva
    {
        public Reserva(IdCliente idCliente, IdReserva idReserva, FechaReserva fechaReserva, HoraReserva horaReserva, IdServicio idServicio)
        {
            IdCliente = idCliente;
            IdReserva = idReserva;
            FechaReserva = fechaReserva;
            HoraReserva = horaReserva;
            IdServicio = idServicio;
        }

        public IdCliente IdCliente { get; private set; }
        public IdReserva IdReserva { get; private set; }
        public FechaReserva FechaReserva { get; private set;}
        public HoraReserva HoraReserva { get; private set;}
        public IdServicio IdServicio { get; private set; }
    }
}