using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos números quieres generar?");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidadNumeros ; i++)
            {

            Console.WriteLine("Introduce el límite mínimo");
                int rangoMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el límite máximo");
                int rangoMax = Convert.ToInt32(Console.ReadLine());

                int numeroAleatorio = Aleatorio(rangoMin, rangoMax);
                Console.WriteLine(numeroAleatorio);
            }
        }



        public static int Aleatorio (int rangoMin, int rangoMax)

        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(rangoMin, rangoMax);

            return numeroAleatorio;


        }
    }
}
