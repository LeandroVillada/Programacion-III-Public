using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace trabajo_practico_4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {if (!IsPostBack)
            {
                // Cargar provincias
                ddlProvinciaInicio.DataSource = ObtenerProvincias();
                ddlProvinciaInicio.DataBind();
                ddlProvinciaFinal.SelectedIndex = 0;

                ddlLocalidadInicio.DataSource = ObtenerLocalidades(ddlProvinciaInicio.SelectedValue);
                ddlLocalidadInicio.DataBind();
                ddlLocalidadInicio.SelectedIndex = 0;

                ddlProvinciaFinal.DataSource = ObtenerProvincias();
                ddlProvinciaFinal.DataBind();
                ddlProvinciaFinal.SelectedIndex = 0;

                ddlLocalidadFinal.DataSource = ObtenerLocalidades(ddlProvinciaFinal.SelectedValue);
                ddlLocalidadFinal.DataBind();
                ddlLocalidadFinal.SelectedIndex = 0;
            }

        }

        public List<string> ObtenerProvincias()
        {
            List<string> provincias = new List<string>();
            provincias.Add("--Seleccionar--");
            string rutaBD = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";

            using (SqlConnection conexion = new SqlConnection(rutaBD))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT DISTINCT NombreProvincia FROM Provincias ORDER BY NombreProvincia ASC";
                    SqlCommand comando = new SqlCommand(consulta, conexion);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string provincia = reader["NombreProvincia"].ToString();
                        provincias.Add(provincia);
                    }
                }
                catch (Exception)
                {
                    // Manejar excepciones
                }
            }

            return provincias;
        }

        public List<string> ObtenerLocalidades(string provincia)
        {
            List<string> localidades = new List<string>();
            localidades.Add("--Seleccionar--");
            string rutaBD = "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";

            using (SqlConnection conexion = new SqlConnection(rutaBD))
            {
                try
                {
                    conexion.Open();

                    string consulta = "SELECT NombreLocalidad FROM Localidades INNER JOIN Provincias ON Localidades.IdProvincia = Provincias.IdProvincia WHERE NombreProvincia = @provincia ORDER BY NombreLocalidad ASC";
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@provincia", provincia);

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        string localidad = reader["NombreLocalidad"].ToString();
                        localidades.Add(localidad);
                    }
                }
                catch (Exception)
                {
                    // Manejar excepciones
                }
            }

            return localidades;
        }

        protected void ddlProvinciaInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar localidades de la provincia de INICIO
            ddlLocalidadInicio.DataSource = ObtenerLocalidades(ddlProvinciaInicio.SelectedValue);
            ddlLocalidadInicio.DataBind();

            // Ocultar opciones de destino final correspondientes a la misma provincia
            PonerVisibleItems(ddlProvinciaFinal);
            ddlProvinciaFinal.Items.FindByValue(ddlProvinciaInicio.SelectedValue).Enabled = false;
        }

        protected void ddlProvinciaFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cargar localidades de la provincia seleccionada
            ddlLocalidadFinal.DataSource = ObtenerLocalidades(ddlProvinciaFinal.SelectedValue);
            ddlLocalidadFinal.DataBind();

            // Ocultar opciones de destino inicio correspondientes a la misma provincia
            PonerVisibleItems(ddlProvinciaInicio);
            ddlProvinciaInicio.Items.FindByValue(ddlProvinciaFinal.SelectedValue).Enabled = false;
        }

        public void PonerVisibleItems(DropDownList ddl)
        {
            foreach (ListItem item in ddl.Items)
            {
                item.Enabled = true;
            }
        }
    }
}