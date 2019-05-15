using System;

namespace Ejercicio_Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso primerPeso = new Peso(100, "Li");

            Console.WriteLine(primerPeso.GetPeso()+ " lingotes son " + primerPeso.GetLibras() + " libras.");

            Peso segundoPeso = new Peso(1000, "G");

            Console.WriteLine(segundoPeso.GetPeso() +" gramos son " + segundoPeso.GetLingotes() + " lingotes.");


        }
    }
}
