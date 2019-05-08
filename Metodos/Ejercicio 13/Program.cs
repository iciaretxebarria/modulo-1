using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 5 };

            bool alto = true;

            MostrarArray(numeros, alto);

            alto = false;
            Console.WriteLine("");

            MostrarArray(numeros, alto);
        }

        public static void MostrarArray(int[] cadena, bool verdad)

        {
            if (verdad)
            {
                for (int i = 0; i < cadena.Length; i++)
                {
                    Console.WriteLine(cadena[i]);
                }
            }

            else
            {
                for (int i = cadena.Length; i>0; i--)
                {
                    Console.WriteLine(cadena[i-1]);
                }
            }
            

        }
    }
}
