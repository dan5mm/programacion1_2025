using System;

namespace InicioSesionUsuario
{
    class Program
    {
        static string nombreUsuarioRegistrado = "";
        static string contraseñaRegistrada = "";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Registrarse");
                Console.WriteLine("2. Iniciar sesión");
                Console.WriteLine("3. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Registrarse();
                        break;
                    case "2":
                        IniciarSesion();
                        break;
                    case "3":
                        return; 
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void Registrarse()
        {
            Console.Write("Ingresa un nombre de usuario: ");
            nombreUsuarioRegistrado = Console.ReadLine();

            Console.Write("Ingresa una contraseña: ");
            contraseñaRegistrada = Console.ReadLine();

            Console.WriteLine("Registro completado.");
        }

        static void IniciarSesion()
        {
            Console.Write("Ingresa tu nombre de usuario: ");
            string nombreUsuario = Console.ReadLine();

            Console.Write("Ingresa tu contraseña: ");
            string contraseña = Console.ReadLine();

            if (nombreUsuario == nombreUsuarioRegistrado && contraseña == contraseñaRegistrada)
            {
                Console.WriteLine("Inicio de sesión exitoso.");
            }
            else
            {
                Console.WriteLine("Nombre de usuario o contraseña incorrectos.");
            }
        }
    }
}