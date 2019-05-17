using System;
using System.Collections.Generic;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> ListaDecimales = new List<double>();
            List<int> ListaEnteros = new List<int>();

            double numero;
            do
            {
                Console.WriteLine("Introduce un número (entero o decimal):");
                Console.WriteLine("Para salir, introduce un número negativo.");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero.ToString().Contains(","))
                {
                    ListaDecimales.Add(numero);
                }
                else
                {
                    ListaEnteros.Add(Convert.ToInt32(numero));
                }

            } while (!numero.ToString().Contains("-"));


            Console.WriteLine("Lista de números enteros:");
            Console.WriteLine("*************************");
            foreach (int cifra in ListaEnteros)
            {
                Console.WriteLine(cifra);
            }

            Console.WriteLine("Lista de números decimales:");
            Console.WriteLine("**************************");
            foreach (double cifra in ListaDecimales)
            {
                Console.WriteLine(cifra);
            }

            Console.WriteLine("Suma de números enteros:");
            Console.WriteLine("**************************");




        }
    }
}
