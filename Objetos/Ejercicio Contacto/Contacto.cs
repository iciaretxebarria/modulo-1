using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Contacto
{
    class Contacto
    {
        //Atributos
        private string nombre;
        private int telefono;
        private DateTime fechaNacimiento;

        //CONSTRUCTORES

        public Contacto(string nombre, int telefono, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Contacto(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;

            if (fechaNacimiento > DateTime.Today)
            {
                this.fechaNacimiento = DateTime.Today;
            }
        }

        public Contacto(string nombre, int telefono)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = DateTime.Today;
        }



        //MÉTODOS

        public void SetNombre(string nombre)

        {
            this.nombre = nombre;
        }

        public string DevolverNombre()
        {
            return nombre;
        }

        public void SetTelefono (int telefono)

        {
            this.telefono = telefono;
        }

        public int DevolverTelefono()
        {
            return telefono;
        }

        public int ObtenerEdad()

        {
            return DateTime.Today.Year - fechaNacimiento.Year;

        }

        public void Felicitar()

        {
            Console.WriteLine("ZORIONAAAK! ES tu cumple! Hoy cumples "+ ObtenerEdad() + " años.");
        }

        public void MostrarDatos()
        {
            Console.WriteLine(nombre);
            Console.WriteLine(telefono);
            Console.WriteLine(fechaNacimiento);
        }









    }




}
