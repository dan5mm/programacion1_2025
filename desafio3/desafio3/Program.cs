using System;

namespace SumaConExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            SumarConExcepciones();
        }

        static void SumarConExcepciones()
        {
            try
            {
                Console.Write("Ingresa el primer valor: ");
                string valor1 = Console.ReadLine();

                Console.Write("Ingresa el segundo valor: ");
                string valor2 = Console.ReadLine();

                int num1 = Convert.ToInt32(valor1);
                int num2 = Convert.ToInt32(valor2);

                int suma = num1 + num2;

                Console.WriteLine($"La suma es: {suma}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingresa valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Fin del programa.");
            }
        }
    }
}