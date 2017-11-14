using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    class Archivos
    {
        public static void Escribir(object o, EventArgs sender)
        {
            TextWriter sw = new StreamWriter("Escritura.txt", true);
            sw.WriteLine(DateTime.Now.ToString() + " | " + ((Cartuchera<Utiles>)o).ultimoAgregado.ToString());
            sw.Close();
        }
    }
}
