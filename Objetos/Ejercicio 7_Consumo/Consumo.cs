using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_7_Consumo
{
    class Consumo
    {

        //ATRIBUTOS

        private double kms;
        private double litros;
        private double vmed;
        private string tipo;

        //CONSTRUCTORES
        public Consumo()
        {

        }

        public Consumo(double kms, double litros, double vmed, string tipo)

        {
            this.kms = kms;
            this.litros = litros;
            this.vmed = vmed;
            this.tipo = tipo;
        }

        //MÉTODOS EJERCICIO 7

        public double GetTiempo()

        {
            return kms / vmed;
        }

        public double ConsumoMedio()

        {
            return (litros / kms)*100;

        }


        //MÉTODOS EJERCICIO 8

        public double ConsumoEuros()

        {
            switch (tipo)
            {
                case "Gasolina 95":
                    return (ConsumoMedio()*1.14);
                    break;

                case "Gasolina 98":
                    return (ConsumoMedio()*1.25);
                    break;

                case "Diesel":
                    return (ConsumoMedio()*1.04);
                    break;

                default:
                    return 0;
                    break;
            }
        }

        public void



    }
}
