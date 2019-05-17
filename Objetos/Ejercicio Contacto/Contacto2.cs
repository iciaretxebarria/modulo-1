using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_Contacto
{
    class Contacto2
    {
        //Atributos
        private string nombre;
        private int telefono;
        private DateTime fechaNacimiento;

        //Nuevos atributos
        private string tipo;
        
        //CONSTRUCTORES

        public Contacto2(string nombre, int telefono, DateTime fechaNacimiento, string tipo)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.fechaNacimiento = fechaNacimiento;
            this.tipo = tipo;
        }

        public Contacto2(string nombre, int telefono, string tipo)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.tipo = tipo;
        }

        public Contacto2(string nombre, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;

            if (fechaNacimiento > DateTime.Today)
            {
                this.fechaNacimiento = DateTime.Today;
            }
        }

        public Contacto2(string nombre, int telefono)
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
            Console.WriteLine(tipo);
        }

        //Nuevos métodos

        public void CambiarTipo(string tipo)

        {
            this.tipo = tipo;
        }

        public string ObtenerTipo()

        {
            if (tipo ==" ")
            {
                return "Amigos";
            }

            return tipo;
        }
    }




}
