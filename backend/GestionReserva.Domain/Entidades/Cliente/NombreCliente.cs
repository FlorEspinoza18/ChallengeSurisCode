namespace GestionReserva.Domain.Entidades.Cliente
{
    public class NombreCliente
    {
        public string ValorNombreCliente { get; private set; }

        private NombreCliente(string valorNombreArticulo)
        {
            ValorNombreCliente = valorNombreArticulo;
        }

        public static NombreCliente Instanciar(string valor)
        {
            return new NombreCliente(valor);
        }

        public string ObtenerValor() => ValorNombreCliente;
    }
}