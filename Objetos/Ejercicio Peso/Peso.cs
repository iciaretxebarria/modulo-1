using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Peso
{
    class Peso
    {
        //ATRIBUTO
        private double peso;
        private string medida;

        //CONSTRUCTORES

        public Peso(double peso)
        {
            this.peso = peso;
        }

        public Peso(double peso, string medida)
        {
            this.peso = peso;
            this.medida = medida;
        }


        //MÉTODOS

        public double GetLibras()

        {
            switch (medida)
            {
                case "Li":
                    return peso * 32.17;
                    break;

                case "Oz":
                    return peso * 0.0625;
                    break;

                case "P":
                    return peso / 100;
                    break;

                case "Q":
                    return peso * 100;
                    break;

                case "G":
                    return peso / 453;
                    break;

                case "K":
                    return peso / 4.53;
                    break;

                default:
                    return 0;
                    break;

            }
            
        }

        public double GetLingotes()

        {
            switch (medida)
            {
                case "Lb":
                    return peso / 32.17;
                    break;

                case "Oz":
                    return peso / 400 ;
                    break;

                case "P":
                    return peso  / 32170;
                    break;

                case "Q":
                    return peso / 3217;
                    break;

                case "G":
                    return peso / 14590;
                    break;

                case "K":
                    return peso / 14.59 ;
                    break;

                default:
                    return 0;
                    break;
            }

        }

        public double GetPeso()

        {
            return peso;
        }

    }
}
