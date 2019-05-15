using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Seat", "Ibiza", 5, 98, "Gasolina");
            Coche coche3 = new Coche();

            coche1.SetModelo("León");
            coche1.GirarDerecha();

            coche3.SetMarca("Ferrari");
            coche3.SetModelo("F40");
            coche3.SetPuertas(2);
            coche3.SetCaballos(150);
            coche3.SetTipo("Gasolina");


            //Console.WriteLine("Coche: " + coche1.GetMarca() + " " + coche1.GetModelo());
            //Console.WriteLine("********************************");
            //Console.WriteLine("Puertas: " + coche1.GetPuertas());
            //Console.WriteLine("Caballos: " + coche1.GetCaballos());
            //Console.WriteLine("Tipo: " + coche1.GetTipo());



        }
    }
}
