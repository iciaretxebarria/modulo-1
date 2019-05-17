using System;
using System.Collections.Generic;
using System.Linq;

namespace PruebaListas
{
    class Program
    {
        static void Main(string[] args)

        //CREAR SIN CONSTRUCTOR 

        //coche c1 = new Coche()

        //{ Marca = "Peugeot",
        //  Modelo = "308" 
        //};


        {


            List<Coche> ListaCoches = new List<Coche>();

            {
                Coche c1 = new Coche("Nissan", "Primera");  //ESTOS NECESITAN CONSTRUCTOR, PORQUE ABSORBEN PARÁMETROS.
                Coche c2 = new Coche("Seat", "Ibiza");
                Coche c3 = new Coche("Toyota", "Yaris");
            }

            //Console.WriteLine(ListaCoches.ElementAt(0).Modelo);
            //Console.WriteLine(ListaCoches.ElementAt(1).Modelo);
            //Console.WriteLine(ListaCoches.ElementAt(2).Modelo);

            foreach (Coche X in ListaCoches)
            {
            Console.WriteLine(X.Modelo);
            }






        }
    }
}
