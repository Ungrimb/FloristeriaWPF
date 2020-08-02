using System;
using System.Collections.Generic;
using System.Text;
using WpfFloristeria.Components;

namespace WpfFloristeria.Models
{
    class Arbre : Element
    {

        private double altura;
        public Arbre(double precio, double altura)
        {
            base.getPrecio();
            this.altura = altura;
        }
        public override string ToString()
        {
            return "Altura: " + altura + ", Precio: " + getPrecio();
        }
    }
}
