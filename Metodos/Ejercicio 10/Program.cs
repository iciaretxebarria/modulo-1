using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una frase:");
            string frase = Console.ReadLine();
            int palabras = NumeroPalabras(frase);

            Console.WriteLine("Tu frase tiene "+palabras+" palabras");

        }



        public static int NumeroPalabras(string frase)

        {

            int contador = 1;

            for (int i = 0; i < frase.Length; i++)
            {

                if (frase[i]==' ')
                {
                    contador++;
                }

            }


            return contador;
        }
    }
}
