using System;

namespace Caso_Teresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Proveedor p = new Proveedor();
            Comprobante p_c = new Comprobante();

            Console.WriteLine(Menu(p.PMotor, p.PCarroceria, p.PLlantas,p.PAdorno));    //mandamos los datos necesarios desde Proveedores hacia Menu

            Console.WriteLine(p.IDPedido());
            p.Pedido();

            p_c.Costo(p.PMotor, p.PCarroceria, p.PLlantas, p.PAdorno, p.CMotor, p.CCarroceria, p.CLlantas, p.CAdorno);
            Console.WriteLine("#Coches que se pueden armar:"+p_c.CantidadCoches(p.CCarroceria, p.CMotor, p.CAdorno, p.CLlantas));
        }
        
        public static string Menu(float pm, float pc, float pll, float pa)
        {
            Console.WriteLine("Motor        -  "+pm);
            Console.WriteLine("Carrocería   -  "+pc);
            Console.WriteLine("Llanta       -  "+pll);
            Console.WriteLine("Adorno       -  "+pa);
            return "Precios en dólares \n\n";
        }
    }
}
