using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using System.Xml.Serialization;
using System.IO;

namespace Entidades
{
    //public delegate void EventHandler(object a);
    public class Cartuchera<T>
    {
        public string marca;
        public int capacidad;
        public List<T> lista;
        public T ultimoAgregado;
        public event EventHandler eventEscribir;

        public Cartuchera(string marca, int capacidad)
        {
            this.marca = marca;
            this.capacidad = capacidad;
            this.lista = new List<T>();
            eventEscribir += new EventHandler(Archivos.Escribir);
        }

        public Cartuchera()
        {
            this.marca = "Sin marca";
            this.capacidad = 5;
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
                eventEscribir(this, EventArgs.Empty);
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

        /*
        public void ListarBD()
        {
            try
            {
                sqlconexion.Open();
                sqlcomander = new SqlCommand();
                sqlcomander.Connection = sqlconexion;
                sqlcomander.CommandType = System.Data.CommandType.Text;
                sqlcomander.CommandText = "SELECT TOP 1000 [id],[marca],[precio],[color],[trazo],[soloLapiz],[tipo] FROM elementos";
                SqlDataReader reader = sqlcomander.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        Console.Write(reader[i].ToString() + " ");
                    }
                    Console.Write("\n");
                }
                reader.Close();
                sqlconexion.Close();
            }
            catch (Exception e)
            {
            }
        }
        */

        public bool Guardar()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\cartuchera.xml"), false))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Cartuchera<T>));
                    xmls.Serialize(sw, this);
                }
                return true;
            }
            catch (ArchivosException)
            {

                throw;
            }
        }

        public bool Leer()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\cartuchera.xml"))
                {
                    XmlSerializer xmls = new XmlSerializer(typeof(Cartuchera<T>));
                    //List<T> lista = new List<T>();

                    //lista = (List<T>)xmls.Deserialize(sr);

                    xmls.ToString();

                    /*foreach (T p in lista)
                    {
                        Console.WriteLine(p.ToString());
                    }*/
                    return true;
                }
            }
            catch (ArchivosException)
            {

                throw;
            }

        }
    }
}
