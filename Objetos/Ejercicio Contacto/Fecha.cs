using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Contacto
{
    class Fecha
    {

        //atributo
        private DateTime fecha;


        //constructor
        public Fecha (DateTime fecha)
        {
            this.fecha = fecha;
        }


        //metodos

        public DateTime GetFecha()
        {
            return fecha;
        }
        public int DevolverDia()

        {
            return fecha.Day;
        }

        public int DevolverMes()
        {

            return fecha.Month;
        }

        public int DevolverYear()

        {

            return fecha.Year;
        }





    }
}
