using System;

namespace IndiceArrayElementoCshard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buscar información en un array");

            string palabra = ""; // Declaramos una variable para buscar
            string[] arrayString = new string[3]; // creamos un array
            // llenamos de información el array
            arrayString[0] = "uno";
            arrayString[1] = "dos";
            arrayString[2] = "tres";
            // pedimo que palabra buscar
            Console.WriteLine("Escriba la palabra a buscar");
            palabra = Console.ReadLine();
            // utilizamos el ciclo for para saber el indice del elemento
            for (int i = 0; i < arrayString.Length; i++)
            {
                // comparamos si se encuentra la palabra
                if (arrayString[i] == palabra)
                {
                    // Mostramos el indice que en este caso seria la variable i + el contenido
                    Console.WriteLine("Posicion [" + i + "] --> " + arrayString[i]);
                }
            }
        }
    }
}
