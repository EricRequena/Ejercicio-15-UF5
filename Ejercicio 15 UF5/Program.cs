using System;

namespace Ejercicio_15_UF5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu correo electrónico: ");
            string correo = Console.ReadLine();
            if (correo.Contains("@") && correo.Contains("."))
            {
                Console.WriteLine("El correo es válido");
            }
            else
            {
                Console.WriteLine("El correo no es válido");
            }
        }
    }
}