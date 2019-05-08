using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una palabra:");
            string palabra = Console.ReadLine().ToLower();
            int vocales = Vocales(palabra);

            Console.WriteLine("La palabra tiene "+vocales+ " vocales.");
        }


        public static int Vocales(string palabra)

        {
            int sumaVocales = 0;

            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = palabra[i]; 

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    sumaVocales++;
                }
            }

            return sumaVocales;

        }

    }
}
