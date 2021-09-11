using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace testSerializacion
{
    class Program
    {
        static bool t = false;
        static void Main(string[] args)
        {

            ArrayList ob = new ArrayList();
            byte[] buffer = LeeArchivoBin("Animal1.ttf");
            byte[] buffer1 = LeeArchivoBin("Animal2.ttf");
            byte[] buffer2 = LeeArchivoBin("Animal3.ttf");

            ob.Add(Obj(buffer));
            ob.Add(Obj(buffer1));
            ob.Add(Obj(buffer2));

            Thread t1 = new Thread(() => Carrera((Animal)ob[1])); //función flecha 
            Thread t2 = new Thread(() => Carrera((Animal)ob[2]));
            t1.Start();
            t2.Start();
        }

        public static byte[] LeeArchivoBin(string nomArch)
        {
            byte[] buffer = new byte[256];
            IFormatter formateador = new BinaryFormatter();
            Stream canal = new FileStream(nomArch, FileMode.Open, FileAccess.Read, FileShare.None);
            canal.Read(buffer, 0, buffer.Length);
            canal.Close();
            canal.Dispose();
            return buffer;
        }

        public static Animal Obj(byte[] buffer)
        {
            Stream canal = new MemoryStream(buffer, true);
            IFormatter formateador = new BinaryFormatter();
            Animal otro = (Animal)formateador.Deserialize(canal);
            canal.Close();
            canal.Dispose();
            return otro;
        }

        public static void Carrera(Animal a)
        {
            int i = 1;

            Console.WriteLine("Participante:{0} ", a);
            for (i = 1; i <= 800; i++)
            {
                if (t == false)
                {
                    Thread.Sleep(100 - a.Velocidad);
                    Console.WriteLine(a.Nombre.Substring(0, 1));

                    if (i == 400 & a.SeDuerme)
                    {
                        Console.WriteLine("{0} Se ha dormido ", a.Nombre);
                        Thread.Sleep(a.Velocidad * 10);
                        Console.WriteLine("{0} Despertó", a.Nombre);
                        a.SeDuerme = false;
                    }
                    if (i == 800)
                    {
                        t = true;
                        Console.WriteLine("{0} Ganador: ", a.Nombre);
                    }
                }

            }
        }
    }
}
