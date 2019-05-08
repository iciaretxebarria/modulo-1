using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 3
            //int resultado = SumaDos(4, 5);
            //Console.WriteLine(resultado);

            //Ejercicio 4
            Console.WriteLine("Introduce un número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultado = SumaDos(num1, num2);
            Console.WriteLine(resultado);

        }



        //Ejercicio 3
        //public static int SumaDos(int num1, int num2)
        //{
        //    return num1 + num2;

        //}

        //Ejercicio 4
        public static int SumaDos(int num1, int num2)
        {
            return num1 + num2;

        }





    }
}
