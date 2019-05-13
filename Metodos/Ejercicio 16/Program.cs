using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para calcular su factorial:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(number));


        }

        public static int Factorial(int numero)

        {
            int siguienteNumero = numero - 1;

            for (int i = 0; i < numero-1; i++)
            {
                numero *= siguienteNumero;
            }

            return numero;
        }



    }
}
