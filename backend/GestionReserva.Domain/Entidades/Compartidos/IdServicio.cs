namespace GestionReserva.Domain.Entidades.Compartidos
{
    public class IdServicio
    {
        public string ValorIdServicio { get; private set; }

        private IdServicio(string valorIdServicio)
        {
            ValorIdServicio = valorIdServicio;
        }

        public static IdServicio Instanciar(string valor)
        {
            return new IdServicio(valor);
        }

        public string ObtenerValor() => ValorIdServicio;
    }
}
