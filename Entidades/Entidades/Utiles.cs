using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    [XmlInclude(typeof(Lapicera))]
    [XmlInclude(typeof(Goma))]
    [Serializable]
    public abstract class Utiles
    {
        public double precio;
        public string marca;

        protected double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        protected string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }

        }

        protected Utiles(string marca) {
            this.Marca = marca;
        }

        public virtual string UtilesToString() {
            return "Marca: "+this.marca+" | Precio: "+this.precio;
        }
    }
}
