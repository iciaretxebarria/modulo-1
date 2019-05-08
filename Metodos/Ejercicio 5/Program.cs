using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)


        {
            int num1;
            int num2;
        
            do
            {
                Console.WriteLine("Introduce un número:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce otro número:");
                num2 = Convert.ToInt32(Console.ReadLine());

                if (num2!=0)
                {
                    Console.WriteLine(Division(num1, num2));
                } 

            } while (num2!=0);


        }

        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }


    }
}
