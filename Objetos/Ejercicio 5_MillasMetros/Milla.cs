using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5_MillasMetros
{
    class Milla
    {
        //atributo
        private double valor;

        //constructor vacío

        public Milla()
        {
        }

        //constructor con parámetro
        public Milla(int valor)
        {
            this.valor = valor;
        }

        //GETTER
        public double GetValor()
        {
            return valor;
        }

        //MÉTODOS

        public double MillasAMetros()

        {

            return valor * 1852;
        }

        public double MillasAKilometros()

        {
            return valor * 1.852;
        }
    }
}
