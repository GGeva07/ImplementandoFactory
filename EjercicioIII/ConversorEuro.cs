namespace EjercicioIII
{
    public class ConversorEuro : IMetodo3
    {
        public void Convertir(double monto)
        {
            Console.WriteLine(monto * 0.96);
        }
    }
}
