using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace trabajo_practico_4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
                using (SqlConnection mi_conexion = new SqlConnection(rutaLibreriaSQL))
                {
                    mi_conexion.Open();
                    SqlCommand comando = new SqlCommand("SELECT * FROM Temas", mi_conexion);
                    SqlDataReader lectura = comando.ExecuteReader();
                    
                    DropDownListTemas.DataSource = lectura;
                    DropDownListTemas.DataTextField = "Tema";
                    DropDownListTemas.DataValueField = "IdTema";
                    DropDownListTemas.DataBind();
                }
            }
        }

        protected void LinkButtonVer_Libros_Click(object sender, EventArgs e)
        {
            String ver_TemaId = DropDownListTemas.SelectedValue;

            Response.Redirect("WebFormEjercicio3_B.aspx?IdTema= " + ver_TemaId);
        }
    }
}