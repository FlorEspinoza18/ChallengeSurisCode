using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entidades.Reserva;

namespace GestionReserva.Application.Queries
{
    public class ObtenerReservasQuery
    {
        public IdCliente IdCliente { get; set; }
        public FechaReserva FechaReserva { get; set; }
    }
}