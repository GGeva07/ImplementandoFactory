using EjercicioI;
using EjercicioII;
using EjercicioIII;


namespace Interfaz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta;

            Console.WriteLine("Ejericicio I - Crear Animales aplicando Factory" +
                "\n Ingrese un numero dependiendo de la opcion" +
                "\n 1. Cuadrupedo" +
                "\n 2. Ave" +
                "\n 3. Pez");
            respuesta = Convert.ToInt32(Console.ReadLine());

            IMetodo Animal = Factory.CreaAnimal(respuesta);
            Animal.MostrarInfo();

            LimpiarConsola();

            Console.WriteLine("Ejericicio II - Crear Figuras aplicando Factory y Singleton" +
                "\n Ingrese un numero dependiendo de la opcion" +
                "\n 1. Cuadrado" +
                "\n 2. Triangulo" +
                "\n 3. Circulo");

            respuesta = Convert.ToInt32(Console.ReadLine());
            IMetodo2 Figura = Factory2.CrearFigura(respuesta);
            Figura.MostrarFigura();


            LimpiarConsola();

            Console.WriteLine("Ejericicio III - Conversor de monedas aplicando Factory" +
                "\n Ingrese un numero para convertir" +
                "\n 1. Dolar a Peso Dominicano" +
                "\n 2. Dolar a Euro" +
                "\n 3. Dolar a Yen");

            respuesta = Convert.ToInt32(Console.ReadLine());
            IMetodo3 conversor = Factory3.crearConversor(respuesta);

            Console.WriteLine("Ingrese el monto a convertir");

            double monto = Convert.ToDouble(Console.ReadLine());
            conversor.Convertir(monto);

            LimpiarConsola();

            Main(args);

        }
        static void LimpiarConsola()
        {
            Console.WriteLine("Click para ir al siguiente ejercicio");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
