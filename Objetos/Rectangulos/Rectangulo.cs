using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangulos
{
    class Rectangulo

    {   // Atributos
        private double altura;
        private double anchura;



        //CONSTRUCTORES

                            //constructor vacío
        public Rectangulo()

        {
            Console.WriteLine("Introduce la altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce la anchura:");
            anchura = Convert.ToDouble(Console.ReadLine());
        }

        // Constructor lleno

        public Rectangulo(double anchura, double altura)
        {
            this.anchura = anchura;
            this.altura = altura;
        }

        //GETTERS Y SETTERS (métodos, uno q devuelve y otro que no)

        public double GetAltura()

        {
            return altura;
        }

        public void SetAltura(double altura)
        {

            this.altura = altura;
        }

        public double GetAnchura()

        {
            return anchura;
        }

        public void SetAnchura(double anchura)
        {

            this.altura = anchura;
        }


        //OTROS MÉTODOS


        public bool EsAlargado()

        {
            if (altura >= 2 * anchura)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Dibuja()
        {
            for (int i = 0; i < altura; i++)
            {

                for (int j = 0; j < anchura; j++)
                {

                Console.Write("*");
                }

                Console.WriteLine();

            }

        }


    }
}
