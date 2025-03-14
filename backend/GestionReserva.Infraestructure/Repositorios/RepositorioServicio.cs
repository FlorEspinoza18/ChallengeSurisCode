using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entidades.Servicio;
using GestionReserva.Domain.Repositorios;

namespace GestionReserva.Infrastructure.Repositorios
{
    public class RepositorioServicio : IRepositorioServicio
    {
        private readonly List<Servicio> _servicios = new List<Servicio>();

        public Task<List<Servicio>> ObtenerColeccionServiciosAsync()
        {
            return Task.FromResult(_servicios);
        }

        public Task<Servicio> ObtenerServicioPorIdAsync(IdServicio idServicio)
        {
            var servicio = _servicios.FirstOrDefault(s => s.IdServicio == idServicio);
            return Task.FromResult(servicio);
        }

        public Task<Servicio> CrearServicioAsync(Servicio nuevoServicio)
        {
            _servicios.Add(nuevoServicio);
            return Task.FromResult(nuevoServicio);
        }
    }
}