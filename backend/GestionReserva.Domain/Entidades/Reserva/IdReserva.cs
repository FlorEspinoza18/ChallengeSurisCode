namespace GestionReserva.Domain.Entidades.Reserva
{
    public class IdReserva
    {
        public int ValorIdReserva { get; private set; }

        private IdReserva(int valorIdReserva)
        {
            ValorIdReserva = valorIdReserva;
        }

        public static IdReserva Instanciar(int valor)
        {
            return new IdReserva(valor);
        }

        public int ObtenerValor() => ValorIdReserva;
    }
}