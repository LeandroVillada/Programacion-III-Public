using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoP_N_2
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTabla_Click(object sender, EventArgs e)
        {        
            int numero = 0;
            bool producto1 = false;
            bool producto2 = false;
            if(!string.IsNullOrWhiteSpace(txtProducto1.Text) && !string.IsNullOrWhiteSpace(txtCantidad1.Text))
            {
                numero += int.Parse(txtCantidad1.Text);
                producto1 = true;
            }
            if(!string.IsNullOrWhiteSpace(txtProducto2.Text)  && !string.IsNullOrWhiteSpace(txtCantidad2.Text) ) { 
                
               numero += int.Parse(txtCantidad2.Text);
                producto2 = true;

            }
            
            string tabla = "<table border = '1' >";
            tabla += "<tr>";
            tabla += "<td>Producto</td><td>Cantidad</td>";
            tabla+="</tr>";

            if (producto1 && producto2)
            {
                tabla += "<tr>";
                tabla += "<td>" + txtProducto1.Text + "</td><td>" + txtCantidad1.Text + "</td>";
                tabla += "</tr>";

                tabla += "<tr>";
                tabla += "<td>" + txtProducto2.Text + "</td><td>" + txtCantidad2.Text + "</td>";
                tabla += "</tr>";

                tabla += "<tr>";
                tabla += "<td>" + "TOTAL" + "</td><td>" + numero.ToString() + "</td>";
                tabla += "</tr>";
            }else if (producto1)
            {
                tabla += "<tr>";
                tabla += "<td>" + txtProducto1.Text + "</td><td>" + txtCantidad1.Text + "</td>";
                tabla += "</tr>";
                tabla += "<tr>";
                tabla += "<td>" + "TOTAL" + "</td><td>" + numero.ToString() + "</td>";
                tabla += "</tr>";

            }
            else if (producto2)
            {

                tabla += "<tr>";
                tabla += "<td>" + txtProducto2.Text + "</td><td>" + txtCantidad2.Text + "</td>";
                tabla += "</tr>";

                tabla += "<tr>";
                tabla += "<td>" + "TOTAL" + "</td><td>" + numero.ToString() + "</td>";
                tabla += "</tr>";
            }
            


            lblTablaGenerada.Text = tabla;
            txtCantidad1.Text = "";
            txtCantidad2.Text = "";
            txtProducto1.Text = "";
            txtProducto2.Text = "";
            
        }
    }
}