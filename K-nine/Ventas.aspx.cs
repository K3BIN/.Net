using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace K_nine
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        static ArrayList producto = new ArrayList();
        static DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                producto.Add(new Productos(2483194, "Mordedera", 2, "Peldi", 49));
                producto.Add(new Productos(4832834, "Pelota", 3, "Dog Chow", 39));
                producto.Add(new Productos(18432111, "Croquetas Raza pequeña", 1, "Pedegree", 300));

                lbl1.Text = "Ventas";
                lbl2.Text = "Producto";
                lbl3.Text = "Cantidad";

                lnkb1.Text = "< Menú";
                lnkb2.Text = "+";
                lnkb3.Text = "Cobrar";
                

                list1.Items.Add("Mordedera");
                list1.Items.Add("Pelota");
                list1.Items.Add("Correa");
                list1.Items.Add("Croquetas Raza pequeña");
                list1.Items.Add("Croquetas Adulto");

                dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Id", typeof(int)),
                            new DataColumn("Product", typeof(string)),
                            new DataColumn("Amount",typeof(int)),
                            new DataColumn("Brand",typeof(string)),
                            new DataColumn("Price",typeof(int)),
                            new DataColumn("Remove",typeof(Button))});

                for (int i = 0; i < producto.Count; i++)
                {
                    dt.Rows.Add(((Productos)(producto[i])).Id, ((Productos)(producto[i])).Producto,
                        ((Productos)(producto[i])).Cantidad, ((Productos)(producto[i])).Marca,
                        ((Productos)(producto[i])).Precio);
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
                
            }
        }
        public void lnk_Click(object sender, EventArgs e)  //MainMenu
        {
            Response.Redirect("MainMenu.aspx");
        }
        public void lnk_Click1(object sender, EventArgs e)  //MainMenu
        {
            Response.Redirect("MainMenu.aspx");
        }
        public void lnk_Click2(object sender, EventArgs e)  //MainMenu
        {
            Response.Redirect("MainMenu.aspx");
        }
        public void lnk_Click3(object sender, EventArgs e)  //MainMenu
        {
            Response.Redirect("MainMenu.aspx");
        }

    }
}