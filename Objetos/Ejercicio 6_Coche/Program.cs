using System;

namespace Ejercicio_6_Coche
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche fantastico = new Coche("nissan", "primera");
            fantastico.MostrarInfo();

            Coche coche2 = new Coche();
            coche2.MostrarInfo();

        }
    }
}
