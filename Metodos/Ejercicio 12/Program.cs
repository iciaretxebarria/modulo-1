using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 5 };

            //MostrarArray(numeros);
            MostrarArrayInvertido(numeros);

        }


        public static void MostrarArray(int [] cadena)

        {
            for (int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }
            
        }

        public static void MostrarArrayInvertido (int[]cadena)

        {
            for (int i = cadena.Length; i >0; i--)
            {
                Console.WriteLine(cadena[i-1]);
            }


        }





    }
}
