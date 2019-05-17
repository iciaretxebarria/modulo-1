using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_6_Coche
{
    class Coche
    {
        //Atributos

        private string marca;
        private string modelo;

        //Constructores
        public Coche()
        {
            marca = "Renault";
            modelo = "Laguna";

        }

        public Coche(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;

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

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }

        //OTROS MÉTODOS

        public void MostrarInfo()
        {
            Console.WriteLine("La marca del coche es " + marca + " y el modelo es " + modelo);
        }
    }
}
