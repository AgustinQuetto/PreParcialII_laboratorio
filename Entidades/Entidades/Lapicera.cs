using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    /*
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
    public class Lapicera : Utiles
    {
        protected ConsoleColor color;
        protected double trazo;

        public ConsoleColor Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Lapicera() : base("Sin marca")
        {

        }

        public Lapicera(string text) : base(text) { }

        public double Trazo
        {
            get { return this.trazo; }
            set { this.trazo = value; }
        }

        public override string ToString()
        {
            return "Color: " + this.Color + " | Trazo " + this.Trazo + " | " + base.UtilesToString();
        }
    }
}
