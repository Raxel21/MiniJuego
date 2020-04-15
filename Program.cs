using System;

namespace MiniJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia de Random
            Random numero = new Random();
            // Genera un numero aleatorio entre 0 y sin incluir el 101
            int numeroAleatorio = numero.Next(1, 101);

            Console.WriteLine("Adivina el numero");
            // Almacenamos la respuesta del usuario y convertimos el string a int
            int respuesta = Int32.Parse(Console.ReadLine());
            
            while (respuesta != numeroAleatorio)
            {
                Console.WriteLine($"Respuesta incorrecta. Intenta de nuevo {numeroAleatorio}");
                respuesta = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
