using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entidades.Servicio;

namespace GestionReserva.Domain.Repositorios
{
    public interface IRepositorioServicio
    {
        Task<List<Servicio>> ObtenerColeccionServiciosAsync();
        Task<Servicio> ObtenerServicioPorIdAsync(IdServicio idServicio);
        Task<Servicio> CrearServicioAsync(Servicio nuevoServicio);
    }
}
