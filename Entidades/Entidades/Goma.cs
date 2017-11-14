using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{ /*
           *-*-*--*-*-*-*-*-*-*--*-*-*-*---*-*-*-
        Goma : utiles

        *-soloLapiz

        ToString

        *-*-*--*-*-*-*-*-*-*--*-*-*-*---*-*-*-
   */
    public class Goma : Utiles
    {
        protected bool soloLapiz;

        public Goma(string text) : base(text) { }

        public Goma() : base("Sin marca")
        {

        }

        public override string ToString()
        {
            string datos = "Solo lapiz: ";

            if (this.soloLapiz)
                datos += "Si";
            else
                datos += "No";

            datos += " | " + base.UtilesToString();
            return datos;
        }
    }
}
