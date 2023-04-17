using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoP_N_2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String nombre = "";

            nombre += Request.QueryString["Nom"];

            lblTextogen.Font.Name = "Arial";
            lblTextogen.Font.Size = FontUnit.XXLarge;
            lblTextogen.Text += "Bienvenido a mi página web Sr/a " + nombre;
        }   
    }
}