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
            for (int i = palabra.Length; i > 0; i--)
            {
                reves += palabra.Substring(i - 1, 1);   //NO puedo añadirle directamente palabra[i]¿? 

                //Substring(palabra[i - 1], 1)

            }

            return reves;
        }
    }
}
