using System;
using System.Collections.Generic;
using System.Text;

namespace Objetos
{
    class Coche
    {
        //ATRIBUTOS
        private string marca;
        private string modelo;
        private int puertas;
        private int caballos;
        private string tipo;

        //Constructor vacío
        public Coche()
        {

        }

        public Coche(string marca, string modelo, int puertas, int caballos, string tipo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.puertas = puertas;
            this.caballos = caballos;
            this.tipo = tipo;

        }
        
        //GETTERS Y SETTERS

        public string GetMarca()
        {
            return marca;

        }

        public string GetModelo()
        {
            return modelo;

        }

        public int GetPuertas()
        {
            return puertas;
        }

        public int GetCaballos()
        {
            return caballos;
        }

        public string GetTipo()
        {
            return tipo;
        }

        //SETTERS

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        public void SetPuertas(int puertas)
        {
            this.puertas = puertas;
        }

        public void SetCaballos(int caballos)
        {
            this.puertas = caballos;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void GirarDerecha()
        {
            Console.WriteLine("El coche: " + marca + modelo + " gira a la derecha");

        }




    }
}
