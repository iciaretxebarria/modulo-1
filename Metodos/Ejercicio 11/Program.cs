using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine();
            string reves = Vuelta(palabra);
            Console.WriteLine(reves);
        }


        public static string Vuelta(string palabra)

        {

            string reves = "";
            for (int i = palabra.Length-1; i >= 0; i--)
            {
                reves += palabra[i];  
            }

            return reves;
        }
    }
}
