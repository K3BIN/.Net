using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K_nine
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl1.Text = "Bienvenido"; 
                lbl2.Text = "Selecciona una opción";

                lnkb1.Text = "Ventas";
                lnkb2.Text = "Compra de mascotas";
                lnkb3.Text = "Inventario";
                lnkb4.Text = "Ver historial de ventas";

            }
        }

        public void lnk_Click1(object sender, EventArgs e)  //Home
        {
            Response.Redirect("MainMenu.aspx");
        }

        public void lnk_Click2(object sender, EventArgs e)  //Home
        {
            Response.Redirect("MainMenu.aspx");
        }

        public void lnk_Click3(object sender, EventArgs e)  //Home
        {
            Response.Redirect("MainMenu.aspx");
        }

        public void lnk_Click4(object sender, EventArgs e)  //Home
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}