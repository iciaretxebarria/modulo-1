using System;

namespace Ejercicio_Contacto
{
    class Program
    {
        static void Main(string[] args)
        {

            //CREAR FECHAS DE NACIMIENTO
            Fecha FechaMiren = new Fecha(new DateTime(1990, 04, 02));
            Fecha FechaAne = new Fecha(new DateTime(1995, 05, 05));
            Fecha FechaJulen = new Fecha(new DateTime(1992, 04, 02));


            //CREAR CONTACTOS
            Contacto Miren = new Contacto("Miren", 944123456, FechaMiren.GetFecha());

            Contacto Jon = new Contacto("Jon", 931212123);

            Contacto Ane = new Contacto("Ane", FechaAne.GetFecha());

            Contacto Julen = new Contacto("Julen", FechaJulen.GetFecha());


            //MOSTRAR DATOS
            //Miren.MostrarDatos();
            //Jon.MostrarDatos();
            //Ane.MostrarDatos();
            //Julen.MostrarDatos();


            //MOSTRAR EDAD
            //Console.WriteLine("Miren: " + Miren.ObtenerEdad());
            //Console.WriteLine("Jon: " + Jon.ObtenerEdad());
            //Console.WriteLine("Ane: " + Ane.ObtenerEdad());
            //Console.WriteLine("Julen: " + Julen.ObtenerEdad());

            //FELICITAR A LOS CONTACTOS
            Miren.Felicitar();
            Jon.Felicitar();
            Ane.Felicitar();
            Julen.Felicitar();










        }
    }
}
