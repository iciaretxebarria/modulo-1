using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (EsPar(numero))
            {
            Console.WriteLine("El número es par.");

            }

            else
            {
            Console.WriteLine("El número es impar.");

            }
        }


        public static bool EsPar(int numero)

        {

            if (numero%2==0)

            {
                return true;
            }

            else
            {
                return false;
            }


        }
    }
}
