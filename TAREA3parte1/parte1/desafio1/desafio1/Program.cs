namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarResultados();
        }
        static void MostrarResultados()
        {
            Console.Write("Ingresa tu nombre: ");
            string nombreUsuario = Console.ReadLine();

            double[] ingresos = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Ingresos del mes {i + 1}: ");
                ingresos[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sumaIngresos = 0;
            foreach (double ingreso in ingresos)
            {
                sumaIngresos += ingreso;
            }
            double promedioIngresos = sumaIngresos / 3;
            Console.WriteLine($"Hola {nombreUsuario}, en total ganaste {sumaIngresos} y promediaste {promedioIngresos}.");
        }
    }
}