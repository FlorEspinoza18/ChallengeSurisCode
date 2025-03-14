namespace GestionReserva.Domain.Entidades.Reserva
{
    public class FechaReserva
    {
        public DateTime? ValorFechaReserva { get; private set; }
        private FechaReserva(DateTime? fecha)
        {
            ValorFechaReserva = fecha;
        }
        public static FechaReserva Instanciar(DateTime? fecha)
        {
            return new FechaReserva(fecha.HasValue ? fecha.Value.Date : null);
        }
        public DateTime? ObtenerValor() => ValorFechaReserva;
    }
}