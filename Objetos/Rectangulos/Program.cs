using System;

namespace Rectangulos
{
    class Program
    {
        static void Main(string[] args)

        {

            //Rectangulo misisipi = new Rectangulo();

            Rectangulo donald = new Rectangulo(2, 2);

            //Console.WriteLine("Anchura: " + misisipi.GetAnchura());
            //Console.WriteLine("Altura: " + misisipi.GetAltura());


            //if (donald.EsAlargado())
            //{
            //    Console.WriteLine("La altura es igual o mayor que el doble de la anchura.");
            //}
            //else
            //{
            //    Console.WriteLine("La altura NO es igual o mayor que el doble de la anchura.");
            //}


            donald.Dibuja();

        }
    }
}
