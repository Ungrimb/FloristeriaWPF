using System;
using System.Collections.Generic;
using System.Text;
using WpfFloristeria.Components;

namespace WpfFloristeria.Models
{
    class Element : IPrecio
    {
        private double precio;
        private int i = 0;
        private List<Element> featureList;

        public Element()
        {
            featureList = new List<Element>();
        }

        public void addElement (Element elem)
        {
            featureList[i] = elem;
            i++;
        }

        public Element getElement (int i)
        {
            return featureList[i];
        }

        public double getPrecio()
        {
            return precio;
        }
    }
}
