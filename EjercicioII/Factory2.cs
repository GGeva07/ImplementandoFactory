namespace EjercicioII
{
    public class Factory2
    {
        public static IMetodo2 CrearFigura(int respuesta)
        {
            if (respuesta == 1)
            {
                return new Cuadrado();
            }
            else if (respuesta == 2)
            {
                return new Triangulo();
            }
            else if (respuesta == 3)
            {
                return Circulo.GetCirculo();
            }
            else
            {
                return null;
            }
        }
    }
}
