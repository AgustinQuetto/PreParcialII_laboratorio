using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Entidades
{
    //public delegate void EventHandler(object a);
    public class Cartuchera<T>
    {
        protected string marca;
        protected int capacidad;
        protected List<T> lista;
        public T ultimoAgregado;
        public event EventHandler eventEscribir;

        public Cartuchera(string marca, int capacidad) {
            this.marca = marca;
            this.capacidad = capacidad;
            this.lista = new List<T>();
            eventEscribir += new EventHandler(Archivos.Escribir);
        }

        public void Agregar(T item)
        {
            try
            {
                if (this.lista.Count < this.capacidad)
                    lista.Add(item);
                ultimoAgregado = item;
                eventEscribir(this,EventArgs.Empty);
            }
            catch (ListaExcedida l)
            {
                
                throw l;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in this.lista)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

    }
}
