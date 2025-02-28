using System;

namespace ManejadorPuntajes3
{
    class Program
    {
        static int puntajeRecord = 0;
        static string jugadorRecord = "Sin récord aún";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- Manejador de Puntajes ---");
                Console.WriteLine("1. Ingresar puntaje");
                Console.WriteLine("2. Mostrar récord actual");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        IngresarPuntaje();
                        break;
                    case "2":
                        MostrarRecord();
                        break;
                    case "3":
                        Console.WriteLine("¡Gracias por jugar!");
                        return; 
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void IngresarPuntaje()
        {
            Console.Write("Ingresa el nombre del jugador: ");
            string nombreJugador = Console.ReadLine();

            int puntaje;
            while (true) 
            {
                Console.Write("Ingresa el puntaje obtenido: ");
                if (int.TryParse(Console.ReadLine(), out puntaje))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Ingresa un número entero.");
                }
            }

            ActualizarRecord(puntaje, nombreJugador);
        }

        static void ActualizarRecord(int puntaje, string nombreJugador)
        {
            if (puntaje > puntajeRecord)
            {
                int puntajeAnterior = puntajeRecord;
                string jugadorAnterior = jugadorRecord;

                puntajeRecord = puntaje;
                jugadorRecord = nombreJugador;

                Console.WriteLine($"¡Nuevo récord! {jugadorRecord} con {puntajeRecord} puntos.");
                if (puntajeAnterior > 0)
                {
                    Console.WriteLine($"Récord anterior: {jugadorAnterior} con {puntajeAnterior} puntos.");
                }
            }
            else
            {
                Console.WriteLine($"{nombreJugador} obtuvo {puntaje} puntos.");
                Console.WriteLine($"El récord actual es de {jugadorRecord} con {puntajeRecord} puntos.");
            }
        }

        static void MostrarRecord()
        {
            Console.WriteLine($"\n--- Récord Actual ---");
            Console.WriteLine($"Jugador: {jugadorRecord}");
            Console.WriteLine($"Puntaje: {puntajeRecord}");
        }
    }
}