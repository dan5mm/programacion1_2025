using System;

namespace CalculadoraBasica
{
    class Calculadora
    {
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                return 0;
            }
            return num1 / num2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.Write("Ingresa el primer número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Suma: {calculadora.Sumar(num1, num2)}");
            Console.WriteLine($"Resta: {calculadora.Restar(num1, num2)}");
            Console.WriteLine($"Multiplicación: {calculadora.Multiplicar(num1, num2)}");
            Console.WriteLine($"División: {calculadora.Dividir(num1, num2)}");
        }
    }
}
