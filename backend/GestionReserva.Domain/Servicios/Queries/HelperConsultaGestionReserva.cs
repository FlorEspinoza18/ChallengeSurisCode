using GestionReserva.Domain.Entidades.Compartidos;
using GestionReserva.Domain.Entidades.Reserva;
using GestionReserva.Domain.Entidades.Servicio;
using GestionReserva.Domain.Repositorios;

namespace GestionReserva.Domain.Servicios.Queries
{
    public class HelperConsultaGestionReserva
    {
        private readonly IRepositorioReserva _repositorioReserva;
        private readonly IRepositorioServicio _repositorioServicio;
        private readonly IRepositorioCliente _repositorioCliente;

        public HelperConsultaGestionReserva(
            IRepositorioReserva repositorioReserva,
            IRepositorioServicio repositorioServicio,
            IRepositorioCliente repositorioCliente)
        {
            _repositorioReserva = repositorioReserva;
            _repositorioServicio = repositorioServicio;
            _repositorioCliente = repositorioCliente;
        }

        // Verificar existencia del cliente
        public async Task ValidarExistenciaClienteAsync(IdCliente idCliente)
        {
            var cliente = await _repositorioCliente.ObtenerClientePorIdAsync(idCliente);
            if (cliente == null)
                throw new Exception($"El cliente con ID {idCliente.ObtenerValor()} no existe.");
        }

        // Verificar existencia del servicio
        public async Task ValidarExistenciaServicioAsync(IdServicio idServicio)
        {
            var servicio = await _repositorioServicio.ObtenerServicioPorIdAsync(idServicio);
            if (servicio == null)
                throw new Exception($"El servicio con ID {idServicio.ObtenerValor()} no existe.");
        }

        // Verifica si un cliente ya tiene una reserva en la misma fecha
        public async Task<bool> ClienteTieneReservaEnFechaAsync(IdCliente idCliente, FechaReserva fechaReserva)
        {
            var reservas = await _repositorioReserva.ObtenerColeccionReservasAsync();
            return reservas.Any(r => r.IdCliente == idCliente && r.FechaReserva == fechaReserva);
        }

        // Verifica si existe una reserva para un servicio en la misma fecha
        public async Task<bool> ExisteReservaParaServicioEnFechaAsync(IdServicio idServicio, FechaReserva fechaReserva)
        {
            var reservas = await _repositorioReserva.ObtenerColeccionReservasAsync();
            return reservas.Any(r => r.IdServicio == idServicio && r.FechaReserva == fechaReserva);
        }

        // Obtener todos los servicios
        public async Task<List<Servicio>> ObtenerColeccionServiciosAsync()
        {
            return await _repositorioServicio.ObtenerColeccionServiciosAsync();
        }

        // Obtener todas las reservas
        public async Task<List<Reserva>> ObtenerTodasLasReservasAsync()
        {
            return await _repositorioReserva.ObtenerColeccionReservasAsync();
        }
        // Verificar si el cliente ya tiene una reserva en la misma fecha y hora
        public async Task ValidarClienteSinReservaAsync(IdCliente idCliente, FechaReserva fechaReserva, HoraReserva horaReserva)
        {
            var reservas = await _repositorioReserva.ObtenerColeccionReservasAsync();
            if (reservas.Any(r => r.IdCliente == idCliente && r.FechaReserva == fechaReserva && r.HoraReserva == horaReserva))
                throw new Exception($"El cliente con ID {idCliente.ObtenerValor()} ya tiene una reserva en esa fecha y hora.");
        }

        // Verificar si ya existe una reserva para el servicio en la misma fecha y hora
        public async Task ValidarServicioSinReservaAsync(IdServicio idServicio, FechaReserva fechaReserva, HoraReserva horaReserva)
        {
            var reservas = await _repositorioReserva.ObtenerColeccionReservasAsync();
            if (reservas.Any(r => r.IdServicio == idServicio && r.FechaReserva == fechaReserva && r.HoraReserva == horaReserva))
                throw new Exception($"El servicio con ID {idServicio.ObtenerValor()} ya está reservado en esa fecha y hora.");
        }
        public async Task<IdReserva> GenerarNuevoIdReservaAsync()
        {
            int id = 0;
            var reservasExistentes = await _repositorioReserva.ObtenerColeccionReservasAsync();
            if (reservasExistentes.Count > 0)
                id = reservasExistentes.LastOrDefault().IdReserva.ObtenerValor() + 1;
            else
                id = 1;

            IdReserva idReserva = IdReserva.Instanciar(id);
            return idReserva;
        }

    }
}