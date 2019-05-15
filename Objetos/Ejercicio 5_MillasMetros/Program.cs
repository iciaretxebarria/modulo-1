using System;

namespace Ejercicio_5_MillasMetros
{
    class Program
    {
        static void Main(string[] args)
        {

            Milla primeraMilla = new Milla(50);

            Console.WriteLine(primeraMilla.GetValor() + " millas son " + primeraMilla.MillasAMetros() + " metros.");

            Milla segundaMilla = new Milla(100);

            Console.WriteLine(segundaMilla.GetValor() + " millas son " + segundaMilla.MillasAKilometros() + " km.");


        }
    }
}
