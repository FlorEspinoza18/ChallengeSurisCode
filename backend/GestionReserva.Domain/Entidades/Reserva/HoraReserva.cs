namespace GestionReserva.Domain.Entidades.Reserva
{
    public class HoraReserva
    {
        public DateTime? ValorHoraReserva { get; private set; }
        private HoraReserva(DateTime? hora)
        {
            ValorHoraReserva = hora;
        }
        public static HoraReserva Instanciar(DateTime? hora)
        {
            return new HoraReserva(hora.HasValue ? hora.Value : null);
        }
        public DateTime? ObtenerValor() => ValorHoraReserva;
    }
}