using System;

namespace MiniJuego
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia de Random
            Random numero = new Random();
            // Genera un numero aleatorio entre 1 y sin incluir el 101
            int numeroAleatorio = numero.Next(1, 101);

            Console.WriteLine("Adivina el numero");
            // Almacenamos la respuesta del usuario y convertimos el string a int
            int respuesta = Int32.Parse(Console.ReadLine());

            int intentos = 1;
            while (respuesta != numeroAleatorio)
            {
                intentos++;                
                Console.WriteLine("Respuesta incorrecta, Vuelve a intertarlo.");
                respuesta = Int32.Parse(Console.ReadLine());
                if ( respuesta < numeroAleatorio )
                {
                    Console.WriteLine("Es un número mas alto!");                    
                } else if ( respuesta > numeroAleatorio )
                {
                    Console.WriteLine("Es un número mas bajo!");                    
                }
            }    
            // Utilizamos interpolacion para mostrar los intentos que hizo el usuario
            Console.WriteLine($"Felicidades ganaste!. Número de intentos {intentos}");
        }
    }
}
