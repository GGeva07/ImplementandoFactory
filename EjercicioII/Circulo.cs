namespace EjercicioII
{
    public class Circulo : IMetodo2
    {
        private static Circulo InstanciaCirculo;

        private Circulo()
        {

        }

        public static Circulo GetCirculo()
        {
            if (InstanciaCirculo == null)
            {
                InstanciaCirculo = new Circulo();
            }

            return InstanciaCirculo;

        }
        public void MostrarFigura()
        {
            Console.WriteLine("Soy un circulo");
        }
    }
}
