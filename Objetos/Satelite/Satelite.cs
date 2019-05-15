using System;
using System.Collections.Generic;
using System.Text;

namespace Satelite
{
    public class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;

        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }

        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }

        public void PrintPosicion()
        {
            Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo +
                "Meridiano " + meridiano + " a una distancia de la tierra de " + distancia_tierra + "Kilómetros");

            Console.ReadLine();
        }

        //MÉTODOS EJERCICIO

        public void VariaAltura(double desplazamiento)

        {
            distancia_tierra += desplazamiento;
            if (distancia_tierra < 0)
            {
                Console.WriteLine("No puede bajar tanto");
                distancia_tierra = 0;

            }
        }


        public bool EnOrbita()

        {
            if (distancia_tierra == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        public void VariaPosicion(double variap, double variam)

        {
            paralelo += variap;
            meridiano += variam;
        }


    }
}
