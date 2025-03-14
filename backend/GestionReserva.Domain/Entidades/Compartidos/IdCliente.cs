namespace GestionReserva.Domain.Entidades.Compartidos
{
    public class IdCliente
    {
        public string ValorIdCliente { get; private set; }

        private IdCliente(string valorIdCliente)
        {
            ValorIdCliente = valorIdCliente;
        }

        public static IdCliente Instanciar(string valor)
        {
            return new IdCliente(valor);
        }

        public string ObtenerValor() => ValorIdCliente;
    }
}