using GestionReserva.Application.Commands.Objects;
using GestionReserva.Domain.Entidades.Reserva;
using GestionReserva.Domain.Repositorios;
using GestionReserva.Domain.Servicios.Queries;

namespace GestionReserva.Application.Servicios.Command
{
    public class ServicioCreacionReserva
    {
        private readonly IRepositorioReserva _repositorioReserva;
        private readonly HelperConsultaGestionReserva _helperConsultaGestion;

        public ServicioCreacionReserva(IRepositorioReserva repositorioReserva, HelperConsultaGestionReserva helperConsultaGestion)
        {
            _repositorioReserva = repositorioReserva;
            _helperConsultaGestion = helperConsultaGestion;
        }

        public async Task<string> CrearReservaAsync(CrearReservaCommandObject commandObject)
        {
            try
            {
                // Validaciones previas usando el helper
                await _helperConsultaGestion.ValidarExistenciaClienteAsync(commandObject.IdCliente);
                await _helperConsultaGestion.ValidarExistenciaServicioAsync(commandObject.IdServicio);
                await _helperConsultaGestion.ValidarClienteSinReservaAsync(commandObject.IdCliente, commandObject.FechaReserva, commandObject.HoraReserva);
                await _helperConsultaGestion.ValidarServicioSinReservaAsync(commandObject.IdServicio, commandObject.FechaReserva, commandObject.HoraReserva);

                // Generar un nuevo ID para la reserva
                var nuevoIdReserva = await _helperConsultaGestion.GenerarNuevoIdReservaAsync();

                // Crear reserva
                var nuevaReserva = new Reserva(
                    commandObject.IdCliente,
                    nuevoIdReserva,
                    commandObject.FechaReserva,
                    commandObject.HoraReserva,
                    commandObject.IdServicio
                );

                // Si pasó las validaciones, guardar en el repositorio
                await _repositorioReserva.CrearReservaAsync(nuevaReserva);

                return $"Reserva creada exitosamente con ID: {nuevoIdReserva}";
            }
            catch (Exception ex)
            {
                return $"Error al crear la reserva: {ex.Message}";
            }
        }
    }
}