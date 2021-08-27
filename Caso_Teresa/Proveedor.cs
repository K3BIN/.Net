using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso_Teresa
{
    public class Proveedor
    {

        private int id;               private float cCarroceria; 
        private float pCarroceria=15;    private float cMotor;         //p como precio y c como cantidad
        private float pMotor=20;         private float cLlantas; 
        private float pLlantas=1;       private float cAdorno; 
        private float pAdorno=1.5f;

        public int Id { get { return id; }  set { id = value; } }
        //------------------------------------------------------------precio--------------------------------------------------------------
        public float PMotor { get {return pMotor;} set { pMotor = value;} }
        public float PCarroceria { get { return pCarroceria; } set {pCarroceria = value; } }
        public float PLlantas { get { return pLlantas; } set {pLlantas = value;} }
        public float PAdorno { get { return pAdorno; } set {pAdorno = value; } }
        //------------------------------------------------------------cantidad------------------------------------------------------------
        public float CMotor { get { return cMotor; } set { cMotor = value; } }
        public float CCarroceria { get { return cCarroceria; } set { cCarroceria = value; } }
        public float CLlantas { get { return cLlantas; } set { cLlantas = value; } }
        public float CAdorno { get { return cAdorno; } set { cAdorno = value; } }
        //--------------------------------------------------------------------------------------------------------------------------------
       

        public override string ToString()
        {
            return string.Format("[Proveedor: id={0}, cCarroceria={1}, pCarroceria={2}, cMotor={3}, pMotor={4}, cLlantas={5}, pLlantas={6}, cAdorno={7}, pAdorno={8}",id,cCarroceria, pCarroceria, cMotor, pMotor, cLlantas, pLlantas, cAdorno, pAdorno);
        }

        public string IDPedido()
        {
            char[] simbolos = new char[10];
            for (int i = 48, j = 0; i <= 57; i++, j++)
                simbolos[j] = (char)i;
            string code = string.Empty;
            Random rnd = new Random();
            code = string.Format("{0}{1}{2}{3}", simbolos[rnd.Next(0, 10)], simbolos[rnd.Next(0, 10)], simbolos[rnd.Next(0, 10)], simbolos[rnd.Next(0, 10)]);
            return "ID Pedido:"+code;
        }

        public string Pedido()
        {
            Console.WriteLine("Pzas. de motores: "); 
            cMotor = float.Parse(Console.ReadLine());
            Console.WriteLine("Pzas. de carrocería: ");
            cCarroceria = float.Parse(Console.ReadLine());
            Console.WriteLine("Pzas. de llantas: "); 
            cLlantas = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Pzas. de adornos: "); 
            cAdorno = float.Parse(Console.ReadLine());
            return "";
        }

        
    }
}
