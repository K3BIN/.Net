using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calificaciones
{
    public class Alumno
    {
        private string boleta;
        private string nombre;
        private int calificacion;
        public string Boleta { get { return boleta; } set { boleta = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public int Calificacion { get { return calificacion; } set { calificacion = value; } }
        public Alumno(string boleta, string nombre, int calificacion)
        {
            this.Boleta = boleta;
            this.Nombre = nombre;
            this.Calificacion = calificacion;
        }

        public override string ToString()
        {
            return string.Format("[Alumno: boleta={0}, nombre={1}, calificacion={2}]", boleta, nombre, calificacion);
        }

    }
}