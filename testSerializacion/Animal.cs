using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSerializacion
{
    [Serializable]
    class Animal
    {
        private string nombre;  private int velocidad;  private bool seDuerme;

        public Animal()
        {
        }

        public Animal(string nombre, int velocidad, bool seDuerme)
        {
            this.nombre = nombre;
            this.velocidad = velocidad;
            this.seDuerme = seDuerme;
        }

        public override string ToString()
        {
            const string Format = "[Animal:  Nombre ={0}, Velocidad ={1}, seDuerme ={2}]";
            return string.Format(Format, nombre, velocidad, seDuerme);

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Velocidad
        {
            get { return velocidad; }
            set { velocidad = value; }
        }


        public bool SeDuerme
        {
            get { return seDuerme; }
            set { seDuerme = value; }
        }

    }
}
