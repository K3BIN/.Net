using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// __________________________________________________________________________________________________________________________
/// |                    PRECIO DEL DOLAR AL DÍA DE HOY 27/08/2021 = 20.22 PESOS MEXICANOS                                   |
/// |________________________________________________________________________________________________________________________|
namespace Caso_Teresa
{
    public class Comprobante
    {
        private float DCarroceria;          private float TCarroceria;      //D como Descuento y T como Total
        private float DMotor;               private float TMotor;
        private float DLlanta;              private float TLlanta;
        private float DAdorno;              private float TAdorno;
        private float TCompra;
        int[] componentesCant = new int[4];

        public string Costo(float pm, float pc, float pll, float pa, float cm, float cc, float cll, float ca)
        {
            //------------------------------------------------------------Carroceria--------------------------------------------------------------
            if (cc>= 100)
            { 
                DCarroceria = (cc * pc) * 0.05f; 
                TCarroceria = (cc * pc) - DCarroceria; 
            }

            if (cc >= 500)
            { 
                DCarroceria = (cc * pc) * 0.10f; 
                TCarroceria = (cc *pc) - DCarroceria; 
            }
            else TCarroceria = (cc * pc);
            float DCarroceriaMXN = DCarroceria * 20.22f;
            float TCarroceriaMXN = TCarroceria * 20.22f;
            //------------------------------------------------------------Carroceria--------------------------------------------------------------
            //--------------------------------------------------------------Motores---------------------------------------------------------------
            if (cm>= 100)
            { 
                DMotor = (cm * pm) * 0.05f;
                TMotor = (cm * pm) - DMotor; 
            } 
            if(cm>= 500)
            { 
                DMotor = (cm * pm) * 0.10f;
                TMotor = (cm * pm) - DMotor; 
            } 
            else TMotor = (cm * pm); 
            float DMotoresMXN = DMotor * 20.22f; 
            float TMotoresMXN = TMotor * 20.22f;

            //Console.WriteLine(DCarroceriaMXN+" "+TCarroceriaMXN+" "+TCarroceria+" "+DCarroceria+" "+DMotoresMXN+" "+ TMotoresMXN);

            TLlanta = cll * pll;
            TAdorno = ca * pa;
            TCompra = TCarroceria + TMotor + TLlanta + TAdorno;
            //--------------------------------------------------------------Motores---------------------------------------------------------------
            //---------------------------------------------------------Llantas y Adornos----------------------------------------------------------
            if (TCompra >= 1000)
            {
                int tempTLlanta = (int)(cll/3);      //Dividimos la cantidad de llantas /3 y el resultado son las piezas que no vamos a pagar por la promoción 3x2 (afortunadamente, aunque el decimal sea >.5 no sube, lo cual nos ayuda a sacar las piezas reales que no pagamos)
                int temp1TLlanta = (int)(cll - tempTLlanta);   //Las piezas que no vamos a pagar las restamos de la cantidad solicitada
                TLlanta = temp1TLlanta * pll;       //Una vez teniendo las piezas "reales" por pagar simplemente las multiplicamos por el precio del artículo
                DLlanta = (tempTLlanta * pll);      //Ahorro en la compra de llantas

                //Console.WriteLine(tempTLlanta+" "+temp1TLlanta);

                int tempTAdorno = (int)(ca / 3);      
                int temp1TAdorno = (int)(ca - tempTAdorno);   
                TAdorno = temp1TAdorno * pa;
                DAdorno = (tempTAdorno * pa);      //Ahorro en la compra de llantas
            }
            float DLlantaMXN = DLlanta * 20.22f;
            float DAdornosMXN = DAdorno * 20.22f;
            float TLlantasMXN = TLlanta * 20.22f;
            float TAdornosMXN = TAdorno * 20.22f;

            TCompra = TCarroceria + TMotor + TLlanta + TAdorno;
            float TCompraMXN = TCompra * 20.22f;

            float TD = DMotor + DCarroceria + DLlanta + DAdorno;
            float TDMXN = TD * 20.22f;
            //Console.WriteLine(TLlanta+" "+DLlanta+" "+TAdorno+" "+DAdorno);
            //---------------------------------------------------------Llantas y Adornos----------------------------------------------------------
            Console.WriteLine("\n\t\t\t\t\t\tComprobante");
            Console.WriteLine("\t\t\t\tUSD\t\t\t\tMXN");
            Console.WriteLine("Total Motor:\t\t\t" + TMotor+ "\t\t\t\t" + TMotoresMXN);
            Console.WriteLine("Descuento Motor:\t\t" + DMotor + "\t\t\t\t" + DMotoresMXN+"\n");
            Console.WriteLine("Total Carroceria:\t\t" + TCarroceria + "\t\t\t\t" + TCarroceriaMXN);
            Console.WriteLine("Descuento Carroceria:\t\t" + DCarroceria + "\t\t\t\t" + DCarroceriaMXN+"\n");
            Console.WriteLine("Total Llanta:\t\t\t" + TLlanta + "\t\t\t\t" + TLlantasMXN);
            Console.WriteLine("Descuento Llanta:\t\t" + DLlanta + "\t\t\t\t" + DLlantaMXN + "\n");
            Console.WriteLine("Total Llanta:\t\t\t" + TAdorno + "\t\t\t\t" + TAdornosMXN);
            Console.WriteLine("Descuento Llanta:\t\t" + DAdorno + "\t\t\t\t" + DAdornosMXN + "\n");
            Console.WriteLine("Total A Pagar:\t\t\t" + TCompra + "\t\t\t\t" + TCompraMXN);
            Console.WriteLine("Usted Ahorró:\t\t\t" + TD + "\t\t\t\t" + TDMXN + "\n");

            return "";
        }

        public int CantidadCoches(float cc, float cm, float ca, float cll) 
        {
            componentesCant[0] = (Convert.ToInt32(cc)); 
            componentesCant[1] = (Convert.ToInt32(cm)); 
            componentesCant[2] = (Convert.ToInt32(cll)) / 4;
            componentesCant[3] = (Convert.ToInt32(ca)) / 2;
            int min = componentesCant[0]; 
            for (int i = 0; i < 4; i++) 
            {
                if (componentesCant[i] <= min) 
                    min = componentesCant[i]; 
            } 
            int cantidadCoches = min;
            return cantidadCoches; 
        }
           
    }
}
