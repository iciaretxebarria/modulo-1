using System;

namespace Ejercicio_1y2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            //TresHolas();

            //Ejercicio 2
            Hola(5);
            Hola(3);
        }

        //Ejercicio 1

        //public static void TresHolas()

        //{
        //    for (int i = 0; i < 3; i++)
        //    {
        //    Console.WriteLine("Hola");

        //    }
        //}

        //Ejercicio 2
        public static void Hola(int numero)
        {

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("Hola");
            }
        }

    }
}
