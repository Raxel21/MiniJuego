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
            Console.WriteLine(numeroAleatorio);
        }
    }
}
