using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entities;

namespace GestionReserva.Domain.Repositorios
{
    public interface IRepositorioCliente
    {
        Task<Cliente> ObtenerClientePorIdAsync(IdCliente idCliente);
        Task<List<Cliente>> ObtenerColeccionClientesAsync();
        Task<Cliente> CrearClienteAsync(Cliente nuevoCliente);
    }
}
