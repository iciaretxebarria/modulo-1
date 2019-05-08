using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            

            if (PrimerNumeroMayor(num1, num2))
            {
                Console.WriteLine("El primer número es más grande");
            }

            else
            {

                Console.WriteLine("El primer número NO es más grande");
            }


        }

        public static bool PrimerNumeroMayor(int num1, int num2)
        {

            if (num1>num2)
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
