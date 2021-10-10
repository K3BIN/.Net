using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calificaciones
{
    public class Estadisticas
    {
        private Alumno[] alumno;

        public Estadisticas(Alumno[] alumno)
        {
            this.Alumno = alumno;
        }

        public Alumno[] Alumno { get => alumno; set => alumno = value; }
        
        public int NumAprobados()
        {
            int NA = 0;
            foreach(Alumno a in alumno)
            {
                if(a.Calificacion >= 6)
                {
                    NA++;
                }
            }
            return NA*10;
        }
        public int NumReprobados()
        {
            int NR = 0;
            foreach (Alumno a in alumno)
            {
                if (a.Calificacion < 6)
                {
                    NR++;
                }
            }
            return NR * 10;
        }
        public float Promedio()
        {
            float prom = 0;
            foreach (Alumno a in alumno)
            {
                prom+=a.Calificacion;
            }
            return prom/10;
        }
        public  float CalificacionMinima()
        {
            int[] arr= new int[10];
            int i = 0;
            foreach (Alumno a in alumno){
                arr[i] = a.Calificacion;
                i++;
            }

            return arr.Min();
        }
        public float CalificacionMaxima()
        {
            int[] arr = new int[10];
            int i = 0;
            foreach (Alumno a in alumno)
            {
                arr[i] = a.Calificacion;
                i++;
            }

            return arr.Max();
        }
    }
}