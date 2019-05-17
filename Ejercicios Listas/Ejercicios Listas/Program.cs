using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicios_Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> iciar = new List<string>();
            iciar = CrearLista(iciar);

            //MostrarLista(iciar);

            iciar = OrdenarLista(iciar);
            MostrarLista(iciar);

            List<string> NuevaLista = BorrarDeLaLista("arroz", iciar);
            MostrarLista(NuevaLista);

            Console.WriteLine(NuevaLista.Count());

        }



        public static List<string> CrearLista(List<string> lista)
        {

            lista.Add("peras");
            lista.Add("manzanas");
            lista.Add("arroz");

            return lista;
            }

        public static void MostrarLista(List<string> lista)

        {
            foreach (string palabra in lista)
            {
                Console.WriteLine(palabra);   
            }
        }

        public static List<string> OrdenarLista(List<string> lista)
        {
            lista.Sort();  //No puedo guardar la lista ordenada en una nueva lista ¿? 
            return lista;   //return lista.sort(); directamente ¿?¿?
        }

        public static List<string> BorrarDeLaLista(string elemento, List<string> lista)

        {
            if (lista.Contains(elemento))
            {
                lista.Remove(elemento);
            }

            return lista;
        }

        public static int ContarElementos(List<string> lista)

        {
            return lista.Count();
        }

    }
}
