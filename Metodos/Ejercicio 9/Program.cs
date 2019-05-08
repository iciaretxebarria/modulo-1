using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static int Vocales(string palabra)

        {
            int sumaVocales = 0;

            for (int i = 0; i < palabra.Length; i++)
            {
                char letra = (palabra[i]);  //palabra[i] siempre es Char?? 

                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    sumaVocales++;

                }

            }

            return sumaVocales;

        }

    }
}
