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

        public string GetTiempo()

        {
            double horas = kms / vmed;
            double minutos = Convert.ToInt32(horas / 60);
            int segundos = Convert.ToInt32(minutos % 60);
            int h = Convert.ToInt32(kms / vmed);

            return h + ": " + minutos + ": " + segundos;
        }

        public double ConsumoMedio()

        {
            return (litros / kms) * 100;

        }


        //MÉTODOS EJERCICIO 8

        public double ConsumoEuros()

        {
            switch (tipo.ToLower())
            {
                case "Gasolina 95":
                    return (ConsumoMedio() * 1.14);
                    break;

                case "Gasolina 98":
                    return (ConsumoMedio() * 1.25);
                    break;

                default:
                    return (ConsumoMedio() * 1.04);
                    break;
            }
        }

        public void MostrarInfo()

        {
            Console.WriteLine("Kms realizados: " + kms);
            Console.WriteLine("Listros consumidos: " + litros);
            Console.WriteLine("Velocidad media: " + vmed);
            Console.WriteLine("Tipo de combustible: " + tipo);
            Console.WriteLine("Consumo Medio en Litros: " + ConsumoMedio());
            Console.WriteLine("Consumo Medio en Euros: " + ConsumoEuros());
        }



    }
}
