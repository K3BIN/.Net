using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K_nine
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                lbl1.Text = "Bienvenido a tu tienda de mascotas";
                lbl2.Text = "Correo";
                lbl3.Text = "@";
                lbl4.Text = "Contraseña";

                LinkButton1.Text = "Iniciar Sesión";
                LinkButton2.Text = "¿No tienes cuenta aún? Regístrate";

                list1.Items.Add("outlook.com");
                list1.Items.Add("outlook.es");
                list1.Items.Add("hotmail.com");
                list1.Items.Add("gmail.com");
                list1.Items.Add("yahoo.com");
            
            }
        }

       
    }
}