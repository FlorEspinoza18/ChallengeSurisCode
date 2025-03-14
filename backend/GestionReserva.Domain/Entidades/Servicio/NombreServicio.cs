namespace GestionReserva.Domain.Entidades.Servicio
{
    public class NombreServicio
    {
        public string ValorNombreServicio { get; private set; }

        private NombreServicio(string valorNombreArticulo)
        {
            ValorNombreServicio = valorNombreArticulo;
        }

        public static NombreServicio Instanciar(string valor)
        {
            return new NombreServicio(valor);
        }

        public string ObtenerValor() => ValorNombreServicio;
    }
}