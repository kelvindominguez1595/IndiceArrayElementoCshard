using System;

namespace IndiceArrayElementoCshard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buscar información en un array");
            string palabra = "";
            string[] arrayString = new string[3];
            arrayString[0] = "uno";
            arrayString[1] = "dos";
            arrayString[2] = "tres";
            Console.WriteLine("Escriba la palabra a buscar");
            palabra = Console.ReadLine();
            for (int i = 0; i < arrayString.Length; i++)
            {
                if (arrayString[i] == palabra)
                {
                    Console.WriteLine("Posicion [" + i + "] --> " + arrayString[i]);
                }
            }
        }
    }
}
