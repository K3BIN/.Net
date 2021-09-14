using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Personaje
{
    public class Duelo
    {
        public string Batalla(string Eclase, int EHP, int EPM, int EAT, int EES, string Pclase, int PHP, int PA)
        {
            Console.WriteLine("Enemigo: " +Eclase+ "\n Vida: " +EHP+ "\n Ataque: " + EAT + "\n Ataque especial: " + EES);
            Console.WriteLine("Jugador: " + Pclase + "\n Vida: " + PHP + "\n Ataque: " + PA);
            for(int i=0; i <=5; i++)
            {
                Thread t1 = new Thread(() => Console.WriteLine(HiloEnemigo(EAT, PHP-=EAT)));
                Thread t2 = new Thread(() => Console.WriteLine(HiloPlayer(PA, EHP-=PA)));
                t1.Start();
                t2.Start();
            }
            return "";
        }

        public string HiloEnemigo(int EAT,int PHP)
        {
            
                
                Thread.Sleep(20);
                Console.WriteLine("\n\n");
               
               // Console.WriteLine("Vida Jugador: "+PHP);
               // if (PHP < 0) Console.WriteLine("Moriste"); 
                return "Enemigo Atacó";
                
        }

        public string HiloPlayer(int PA, int EHP)
        {
            
                
                Thread.Sleep(20);
                Console.WriteLine("\n\n");
                
                //Console.WriteLine("Vida Enemigo: "+EHP);
                //if (EHP < 0) Console.WriteLine("Ganaste"); 
                return "Atacaste";
        }
    }
}
