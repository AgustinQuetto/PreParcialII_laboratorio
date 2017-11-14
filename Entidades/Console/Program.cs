using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Programita
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartuchera<Utiles> miCartuchera = new Cartuchera<Utiles>("Faber Castell", 50);
            Goma goma1 = new Goma("Goma 1");
            Goma goma2 = new Goma("Goma 2");
            Lapicera lapicera1 = new Lapicera("Lapicera 1");
            Lapicera lapicera2 = new Lapicera("Lapicera 2");

            miCartuchera.Agregar(goma1);
            miCartuchera.Agregar(goma2);
            miCartuchera.Agregar(lapicera1);
            miCartuchera.Agregar(lapicera2);
            
            Console.WriteLine(miCartuchera.ToString());
            Console.ReadLine();
        }
    }
}
