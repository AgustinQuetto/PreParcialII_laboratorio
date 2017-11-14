using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /*
    utiles (abstract)
        *-precio
        *-marca

        *-Precio (get;set) - abstract
        *-Marca (get; set) - abstract

        utilesToString (virtual)

        *-*-*--*-*-*-*-*-*-*--*-*-*-*---*-*-*-
        lapicera : utiles
        *-color
        *-trazo

        ToString

        *-*-*--*-*-*-*-*-*-*--*-*-*-*---*-*-*-
        Goma : utiles

        *-soloLapiz

        ToString

        *-*-*--*-*-*-*-*-*-*--*-*-*-*---*-*-*-
        Cartuchera<T>

        *-marca
        *-capacidad

        *-list<T>

        *-Agregar(T):void

        ToString
    */
    public abstract class Utiles
    {
        protected double precio;
        protected string marca;

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
