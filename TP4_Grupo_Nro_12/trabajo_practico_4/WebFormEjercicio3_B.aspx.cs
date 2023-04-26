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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String rutaLibreriaSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
                using (SqlConnection mi_conexion = new SqlConnection(rutaLibreriaSQL))
                {
                    mi_conexion.Open();

                    String TemaId_libros = Request.QueryString["IdTema"];
                    SqlCommand comando = new SqlCommand("SELECT * FROM Libros WHERE IdTema = @IdTema", mi_conexion);
                    comando.Parameters.AddWithValue("@IdTema", TemaId_libros);
                    SqlDataReader lectura = comando.ExecuteReader();

                    gridWiewListado_Libros.DataSource = lectura;
                    gridWiewListado_Libros.DataBind();
                }
            }
        }
    }
}