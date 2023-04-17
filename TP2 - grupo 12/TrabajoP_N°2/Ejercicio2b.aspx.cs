using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoP_N_2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string Nombre = "";
            string Apellido = "";
            ListItem ciudad = new ListItem();
            string ciudadValor = "";
            CheckBoxList temas = new CheckBoxList();
            string aux = "";
            //Datos para enviar al otro formulario
            Nombre = Request["txtNombre"].ToString();
            Apellido = Request["txtApellido"].ToString();

            ciudad = ((DropDownList)PreviousPage.FindControl("ddlCiudad")).SelectedItem ;
            ciudadValor = ((DropDownList)PreviousPage.FindControl("ddlCiudad")).SelectedValue;
            temas = ((CheckBoxList)PreviousPage.FindControl("cblTemas"));
            
            foreach (ListItem s in temas.Items)
            {
                if (s.Selected)
                {
                    aux += "&nbsp&nbsp&nbsp&nbsp" + s + "<br/>";
                }
            }
            lblTextoGenerado.Text = "<br/>" + "Nombre: " + Nombre + "<br/>";
            lblTextoGenerado.Text += "Apellido: " + Apellido + "<br/>";
            lblTextoGenerado.Text += "Zona: " + ciudadValor + "<br/>";
            lblTextoGenerado.Text += "<br/>"+ "Los temas elegidos son: " + "<br/>";

            lblTextoGenerado.Text += aux;

        }
    }
}