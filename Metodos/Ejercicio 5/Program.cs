using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)


        {
            double num1;
            double num2;
        
            do
            {
                Console.WriteLine("Introduce un número:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Introduce otro número:");
                num2 = Convert.ToDouble(Console.ReadLine());

                if (num2!=0)
                {
                    Console.WriteLine(Division(num1, num2));
                } 

            } while (num2!=0);


        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }


    }
}
