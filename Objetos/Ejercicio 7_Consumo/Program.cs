using System;

namespace Ejercicio_7_Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumo viajeIciar = new Consumo(200, 20.5, 80, "Diesel");

            //Console.WriteLine("El tiempo que ha tardado Iciar en el viaje es: " + viajeIciar.GetTiempo() + " horas.");
            //Console.WriteLine("El consumo medio de Iciar en el viaje es: " + viajeIciar.ConsumoMedio() + " litros.");
            //Console.WriteLine("El consumo en euros de Iciar en el viaje es: " + viajeIciar.ConsumoEuros() + " euros.");

            viajeIciar.MostrarInfo();
            


        }
    }
}
