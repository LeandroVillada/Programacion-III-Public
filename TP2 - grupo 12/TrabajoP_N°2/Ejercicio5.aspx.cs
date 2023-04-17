using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoP_N_2
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMemoria.Items.Add(new ListItem("2 GB", "200,00"));
                ddlMemoria.Items.Add(new ListItem("4 GB", "375,00"));
                ddlMemoria.Items.Add(new ListItem("6 GB", "500,00"));
                
                

                cblAccesorios.Items.Add(new ListItem("Monitor LCD", "2000,50"));
                cblAccesorios.Items.Add(new ListItem("HD 500GB", "550,50"));
                cblAccesorios.Items.Add(new ListItem("Grabador DVD", "1200,00"));
          

            }

        }

        protected void ddlMemoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            float total = 0;
            
            foreach(ListItem s in cblAccesorios.Items)
            {
                if (s.Selected)
                {
                    total += float.Parse(s.Value);
                }
            }
            foreach(ListItem s in ddlMemoria.Items)
            {
                if (s.Selected)
                {
                    total += float.Parse(s.Value);
                }
            }
            lblResultado.Text = "El precio final es de: " + "$ " + total.ToString("0.00");

        }
    }
}