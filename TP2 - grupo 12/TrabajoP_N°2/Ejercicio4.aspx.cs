using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoP_N_2
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            bool esCorrecto = false;
            
            if (txtUsuario.Text.ToString().Trim() == "claudio"   && txtClave.Text.ToString().Trim() == "casas"  ){
                esCorrecto = true;
            }
            else { esCorrecto = false; }

            if (esCorrecto) {
                Response.Redirect("Ejercicio4b.aspx?Nom="+txtUsuario.Text);
            }
            else
            {
                Response.Redirect("Ejercicio4c.aspx");
            }

            
        }

        protected void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}