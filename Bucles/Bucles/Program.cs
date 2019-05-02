using System;

namespace Bucles
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 1

            //int numero = 10;

            //while (numero <= 20)
            //{
            //    Console.WriteLine(numero++);
            //    Console.WriteLine();
            //}


            //Ejercicio 2

            //int numero = 20;

            //while (numero >= 10)
            //{
            //    Console.WriteLine(numero);
            //    Console.WriteLine();
            //    numero--;
            //}

            //for (int i = 20; i >= 10; i--)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine();

            //}



            //Ejercicio 3

            //int suma = 0;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Introduce un valor:");
            //    int valor = Convert.ToInt32(Console.ReadLine());
            //    suma = suma + valor;
            //}

            //Console.WriteLine("La media de tus números es: "+(suma / 10));


            //Ejercicio 4


            int valor;
            int suma = 0;
            int negativo;


            do
            {
                Console.WriteLine("Introduce un valor:");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor < 0)
                {
                    Console.WriteLine("Se ignoran los valores negativos");
                    negativo= Convert.ToInt32(Console.ReadLine());
                    negativo = 0;
                }

                suma = suma + valor;


            } while (valor != 0);

            Console.WriteLine("La suma de tus números es " + suma);



            //Ejercicio 5










        }
    }
}
