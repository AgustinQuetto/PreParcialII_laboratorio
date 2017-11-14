using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Archivos
{
    public class Archivos
    {
        public void Escribir(string nombre, EventArgs o) {
            TextWriter sw = new StreamWriter(nombre, true);
            sw.WriteLine(DateTime.Now.ToString()+" | "+o.ToString());
            sw.Close();
        }
    }
}
