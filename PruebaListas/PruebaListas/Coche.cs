using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaListas
{
    class Coche
    {
        //ATRIBUTOS
        public string Marca { get; set; }
        public string Modelo { get; set; }

        //CONSTRUCTOR
        public Coche(string marca, string modelo)

        {
            this.Marca = marca;
            this.Modelo = modelo;
        }
        
    }
}
