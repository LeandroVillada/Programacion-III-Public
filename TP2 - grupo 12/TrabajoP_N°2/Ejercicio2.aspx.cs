using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoP_N_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Ciudades
                ListItem pacheco = new ListItem();
                pacheco.Text = "Gral. Pacheco";
                pacheco.Value = "zona norte";
                ddlCiudad.Items.Add(pacheco);

                ListItem SanMiguel = new ListItem();
                SanMiguel.Text = "San Miguel";
                SanMiguel.Value = "zona oeste";
                ddlCiudad.Items.Add(SanMiguel);

                ListItem Boedo = new ListItem();
                Boedo.Text = "Boedo";
                Boedo.Value = "zona sur";
                ddlCiudad.Items.Add(Boedo);

                //Temas
                cblTemas.Items.Add("Ciencias");
                cblTemas.Items.Add("Literatura");
                cblTemas.Items.Add("Historia");
                

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtNombre.Text.ToString().Trim()) && !string.IsNullOrEmpty(txtApellido.Text.ToString().Trim()))
            {   
               
                //tranfiero los archivos
                Server.Transfer("Ejercicio2b.aspx");

                //Borro los nombres y apellido cargados
                txtNombre.Text = "";
                txtApellido.Text = "";

            }
            else
            {
                txtApellido.Text = "";
                txtNombre.Text = "";
            }
        }

        protected void ddlCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}