using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Personaje
{
    public class Personaje
    {
        public String clase { get; set; }
        public int HP { get; set; }     //Vida 
        
        public int AT { get; set; }    //Atack

    }

    public class Enemigo : Personaje
    {
        Duelo mensajero = new Duelo();
        public int PM { get; set; }     //Poder mágico (reserva)
        public int ES { get; set; }    //Especial Atack

        
        public string Enemy()
        {
             //--------------------------------------------------------------Enemigo--------------------------------------------------------------
            var CEnemigo = new List<Enemigo>    //List<T>
            {
                new Enemigo() { clase="Ogro", HP=850, PM=1000, AT=80, ES=90},
                new Enemigo() { clase="Espiritu", HP=350, PM=2000, AT=30, ES=70},
                new Enemigo() { clase="Muerto", HP=500, PM=1400, AT=50, ES=90},
                new Enemigo() { clase="Demonio", HP=1100, PM=2500, AT=100, ES=200},
                new Enemigo() { clase="Angel", HP=1300, PM=2500, AT=120, ES=250}
            };

            //----------------LINQ Query on List----------------
            var result = from a in CEnemigo
                         where a.clase == "Ogro"
                         select a;
            foreach (var enemigo in result)
            {
             EGuardado(enemigo.clase, enemigo.HP, enemigo.PM, enemigo.AT, enemigo.ES);   
            }
            //----------------LINQ Query on List----------------
            //--------------------------------------------------------------Enemigo--------------------------------------------------------------
            return "";
        }


        public string EGuardado(string Eclase, int EHP, int EPM, int EAT, int EES)
        {
            //Console.WriteLine(Eclase);

            var CPersonaje = new List<Personaje>    //List<T>
            {
                new Personaje() { clase="Milicia", HP=300, AT=40},
                new Personaje() { clase="Caballero", HP=800, AT=80 },
                new Personaje() { clase="Mago", HP=500, AT=60},
                new Personaje() { clase="Hada", HP=700, AT=70},
                new Personaje() { clase="Verdugo", HP=1500, AT=120}
            };

            //----------------LINQ Query on List----------------
            var result = from a in CPersonaje
                         where a.clase == "Verdugo"
                         select a;
            foreach (var player in result)
            {
                mensajero.Batalla(Eclase, EHP, EPM, EAT, EES, player.clase, player.HP, player.AT);
            }
            //----------------LINQ Query on List----------------
            return "";
        }
    }

}
