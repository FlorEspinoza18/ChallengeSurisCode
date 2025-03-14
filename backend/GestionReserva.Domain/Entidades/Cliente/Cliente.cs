using GestionReserva.Domain.Entidades.Cliente;
using GestionReserva.Domain.Entidades.Compartidos;

namespace GestionReserva.Domain.Entities
{
    public class Cliente
    {
        public NombreCliente NombreCliente {  get; private set; }

        public IdCliente IdCliente { get; private set; }
    }
}