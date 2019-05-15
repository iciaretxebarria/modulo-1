using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Finanzas finanza1 = new Finanzas(40);
             
            Console.WriteLine(finanza1.GetDinero() + " euros son "+ finanza1.EurostoDolares()+" dólares.");

            Finanzas nuevaDolares = new Finanzas(100);
            Console.WriteLine(nuevaDolares.GetDinero() + " dólares son "+ nuevaDolares.DolaresToEuros()+" euros.");

        }
    }
}
