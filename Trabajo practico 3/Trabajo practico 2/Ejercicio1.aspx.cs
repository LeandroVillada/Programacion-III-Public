using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_practico_2
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
             //   ddlLocalidades.Items.Add("-Seleccione Localidad-");
            //}
           
        }
        protected void btnLocalidad_Click(object sender, EventArgs e)
        {
            bool existe = false;
            foreach (ListItem n in ddlLocalidades.Items)
            {
                if (n.Text == txtLocalidad.Text) { existe = true; }

            }
            if (!existe)
            {
                ddlLocalidades.Items.Add(txtLocalidad.Text);
                txtLocalidad.Text = "";

            }
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            lblExito.Text = "Bienvenido " + txtUsuario.Text;
        }
    }
}