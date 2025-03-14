using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entities;
using GestionReserva.Domain.Repositorios;

namespace GestionReserva.Infraestructure.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly List<Cliente> _clientes = new List<Cliente>();

        public Task<List<Cliente>> ObtenerColeccionClientesAsync()
        {
            return Task.FromResult(_clientes);
        }

        public Task<Cliente> ObtenerClientePorIdAsync(IdCliente idCliente)
        {
            var cliente = _clientes.FirstOrDefault(c => c.IdCliente == idCliente);
            return Task.FromResult(cliente);
        }

        public Task<Cliente> CrearClienteAsync(Cliente nuevoCliente)
        {
            _clientes.Add(nuevoCliente);
            return Task.FromResult(nuevoCliente);
        }
    }
}