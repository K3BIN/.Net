using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K_nine
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbl1.Text = "Llena el formulario con los datos correspondientes";
                lbl2.Text = "Correo";
                lbl3.Text = "@";
                lbl4.Text = "Teléfono";
                lbl5.Text = "Contraseña";
                lbl6.Text = "Edad";
                lbl7.Text = "Nombre del Admin";
                lbl8.Text = "CURP";
                lbl9.Text = "Nombre de la Sucursal";
                lbl10.Text = "Dirección";

                list1.Items.Add("outlook.com");
                list1.Items.Add("outlook.es");
                list1.Items.Add("hotmail.com");
                list1.Items.Add("gmail.com");
                list1.Items.Add("yahoo.com");
            }
        }
        public void lnk_Click1(object sender, EventArgs e)  //Home
        {
            Response.Redirect("MainMenu.aspx");
        }
    }
}