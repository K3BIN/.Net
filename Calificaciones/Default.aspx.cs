using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calificaciones
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Alumno[] alumnos = new Alumno[] {
            new Alumno("2015120502", "Hernández Diaz Kevin Daniel", 0),
            new Alumno("2015120503", "Del Castillo Luna José", 0),
            new Alumno("2015120504", "Palacios Magos Uriel", 0),
            new Alumno("2015120505", "Armando Torres Ernesto", 0),
            new Alumno("2015120506", "Luna Rojas Cheche", 0),
            new Alumno("2015120507", "Paladin Arcos Hugo", 0),
            new Alumno("2015120508", "Faros Tiago Humberto", 0),
            new Alumno("2015120509", "Menchaca Penelope", 0),
            new Alumno("2015120510", "Lagos Verdes Ariel", 0),
            new Alumno("2015120511", "Zepeda Huerta Carlos", 0),
        };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                LB1.Text = alumnos[0].Boleta;
                LN1.Text = alumnos[0].Nombre;

                LB2.Text = alumnos[1].Boleta;
                LN2.Text = alumnos[1].Nombre;

                LB3.Text = alumnos[2].Boleta;
                LN3.Text = alumnos[2].Nombre;

                LB4.Text = alumnos[3].Boleta;
                LN4.Text = alumnos[3].Nombre;

                LB5.Text = alumnos[4].Boleta;
                LN5.Text = alumnos[4].Nombre;

                LB6.Text = alumnos[5].Boleta;
                LN6.Text = alumnos[5].Nombre;

                LB7.Text = alumnos[6].Boleta;
                LN7.Text = alumnos[6].Nombre;

                LB8.Text = alumnos[7].Boleta;
                LN8.Text = alumnos[7].Nombre;

                LB9.Text = alumnos[8].Boleta;
                LN9.Text = alumnos[8].Nombre;

                LB10.Text = alumnos[9].Boleta;
                LN10.Text = alumnos[9].Nombre;
                for (int i = 0; i <= 10; i++)
                {
                    Cal1.Items.Add(i.ToString());
                    Cal2.Items.Add(i.ToString());
                    Cal3.Items.Add(i.ToString());
                    Cal4.Items.Add(i.ToString());
                    Cal5.Items.Add(i.ToString());
                    Cal6.Items.Add(i.ToString());
                    Cal7.Items.Add(i.ToString());
                    Cal8.Items.Add(i.ToString());
                    Cal9.Items.Add(i.ToString());
                    Cal10.Items.Add(i.ToString());

                }
            }
        }
        public void btn_Click(object sender, EventArgs e)
        {
            alumnos[0].Calificacion = Int32.Parse(Cal1.SelectedItem.Value);
            alumnos[1].Calificacion = Int32.Parse(Cal2.SelectedItem.Value);
            alumnos[2].Calificacion = Int32.Parse(Cal3.SelectedItem.Value);
            alumnos[3].Calificacion = Int32.Parse(Cal4.SelectedItem.Value);
            alumnos[4].Calificacion = Int32.Parse(Cal5.SelectedItem.Value);
            alumnos[5].Calificacion = Int32.Parse(Cal6.SelectedItem.Value);
            alumnos[6].Calificacion = Int32.Parse(Cal7.SelectedItem.Value);
            alumnos[7].Calificacion = Int32.Parse(Cal8.SelectedItem.Value);
            alumnos[8].Calificacion = Int32.Parse(Cal9.SelectedItem.Value);
            alumnos[9].Calificacion = Int32.Parse(Cal10.SelectedItem.Value);

            Estadisticas estadistica = new Estadisticas(alumnos);
            AP.Text = estadistica.NumAprobados().ToString();
            RP.Text = estadistica.NumReprobados().ToString();
            PR.Text = estadistica.Promedio().ToString();
            CMN.Text = estadistica.CalificacionMinima().ToString();
            CMX.Text = estadistica.CalificacionMaxima().ToString();
        }
    }
}