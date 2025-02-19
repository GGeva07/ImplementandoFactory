namespace EjercicioIII
{
    public class Factory3
    {
        public static IMetodo3 crearConversor(int respuesta)
        {
            if (respuesta == 1)
            {
                return new ConversorPeso();
            }
            else if (respuesta == 2)
            {
                return new ConversorEuro();
            }
            else if (respuesta == 3)
            {
                return new ConversorYen();
            }
            else
            {
                return null;
            }
        }
    }
}
