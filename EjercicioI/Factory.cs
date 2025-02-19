namespace EjercicioI
{
    public class Factory
    {
        public static IMetodo CreaAnimal(int respuesta)
        {
            if (respuesta == 1)
            {
                return new Cuadrupedo();
            }
            else if (respuesta == 2)
            {
                return new Ave();
            }
            else if (respuesta == 3)
            {
                return new Pez();
            }
            else
            {
                return null;
            }
        }
    }
}
