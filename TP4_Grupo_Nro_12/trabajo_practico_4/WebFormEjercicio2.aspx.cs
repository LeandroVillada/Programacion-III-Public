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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonFiltrar_Click(object sender, EventArgs e)
        {

            // Se comienza con una consulta para seleccionar todos los productos
            String rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
            String query = "SELECT * FROM Productos WHERE 1=1";

        
            // Si se ingresa un valor en el id de producto, se agrega al filtro correspondiente a la consulta
            if (!String.IsNullOrEmpty(TextBoxProducto.Text))
            {
                if (DropDownListProducto.SelectedValue == "igual a")
                {
                    query += " AND IdProducto = " + TextBoxProducto.Text;
                }
                else if (DropDownListProducto.SelectedValue == "mayor a")
                {
                    query += " AND IdProducto > " + TextBoxProducto.Text;
                }
                else if (DropDownListProducto.SelectedValue == "menor a")
                {
                    query += " AND IdProducto < " + TextBoxProducto.Text;
                }
            }


            // Si se ingresa un valor en el id de categoria, se agrega al filtro correspondiente a la consulta
            if (!String.IsNullOrEmpty(TextBoxCategoria.Text))
            {
                if (DropDownListCategoria.SelectedValue == "igual a")
                {
                    query += " AND IdCategoría = " + TextBoxCategoria.Text;
                }
                else if (DropDownListCategoria.SelectedValue == "mayor a")
                {
                    query += " AND IdCategoría > " + TextBoxCategoria.Text;
                }
                else if (DropDownListCategoria.SelectedValue == "menor a")
                {
                    query += " AND IdCategoría < " + TextBoxCategoria.Text;
                }
            }

            // Si se ingresan valores en ambos Id, se agregan ambos filtros a la consulta
            if (!String.IsNullOrEmpty(TextBoxProducto.Text) && !String.IsNullOrEmpty(TextBoxCategoria.Text))
            {
                if(DropDownListProducto.SelectedValue == "igual a" && DropDownListCategoria.SelectedValue == "igual a")
                {
                    query += " AND IdProducto = " + TextBoxProducto.Text + " AND IdCategoría = " + TextBoxCategoria.Text;
                }
                else if (DropDownListProducto.SelectedValue == "igual a" && DropDownListCategoria.SelectedValue == "mayor a")
                {
                    query += " AND IdProducto = " + TextBoxProducto.Text + " AND IdCategoría > " + TextBoxCategoria.Text;
                }
                else if (DropDownListProducto.SelectedValue == "igual a" && DropDownListCategoria.SelectedValue == "menor a")
                {
                    query += " AND IdProducto = " + TextBoxProducto.Text + " AND IdCategoría < " + TextBoxCategoria.Text;
                }

                //---------------------------------------------------------------------------------------------------------
                else if (DropDownListProducto.SelectedValue == "mayor a" && DropDownListCategoria.SelectedValue == "igual a")
                {
                    query += " AND IdProducto > " + TextBoxProducto.Text + " AND IdCategoría = " + TextBoxCategoria.Text;
                }
                else if (DropDownListProducto.SelectedValue == "mayor a" && DropDownListCategoria.SelectedValue == "mayor a")
                {
                    query += " AND IdProducto > " + TextBoxProducto.Text + " AND IdCategoría > " + TextBoxCategoria.Text;
                }
                else if (DropDownListProducto.SelectedValue == "mayor a" && DropDownListCategoria.SelectedValue == "menor a")
                {
                    query += " AND IdProducto > " + TextBoxProducto.Text + " AND IdCategoría < " + TextBoxCategoria.Text;
                }

                //---------------------------------------------------------------------------------------------------------
                else if (DropDownListProducto.SelectedValue == "menor a" && DropDownListCategoria.SelectedValue == "igual a")
                {
                    query += " AND IdProducto < " + TextBoxProducto.Text + " AND IdCategoría = " + TextBoxCategoria.Text;
                }
                else if (DropDownListProducto.SelectedValue == "menor a" && DropDownListCategoria.SelectedValue == "mayor a")
                {
                    query += " AND IdProducto < " + TextBoxProducto.Text + " AND IdCategoría > " + TextBoxCategoria.Text;
                }
                else if (DropDownListProducto.SelectedValue == "menor a" && DropDownListCategoria.SelectedValue == "menor a")
                {
                    query += " AND IdProducto < " + TextBoxProducto.Text + " AND IdCategoría < " + TextBoxCategoria.Text;
                }




            }


            // se establece una conexión con la base de datos se encarga de obtener los datos y los muestra en un GridView
            using (SqlConnection mi_conexion = new SqlConnection(rutaNeptunoSQL))
            {
                mi_conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, mi_conexion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable data_tableProductos = new DataTable();
                        adaptador.Fill(data_tableProductos);
                        gridWiewProductos_Categorias.DataSource = data_tableProductos;
                        gridWiewProductos_Categorias.DataBind();
                    }
                }
            }
        


            // se limpian los cuadros de texto y los valores seleccionados de los DropDownList
            TextBoxProducto.Text = "";
            TextBoxCategoria.Text = "";
            DropDownListProducto.SelectedIndex = 0;
            DropDownListCategoria.SelectedIndex = 0;
        }

        protected void ButtonQuitar_filtro_Click(object sender, EventArgs e)
        {
            // Conectamos a la base de datos y realizamos una consulta para seleccionar todos los productos.
            // Seleccionamos todos los productos sin filtros
            string rutaNeptunoSQL = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";
            string query = "SELECT * FROM Productos";

            // se establece una conexión con la base de datos se encarga de obtener los datos y los muestra en un GridView
            using (SqlConnection mi_conexcion = new SqlConnection(rutaNeptunoSQL))
            {
                mi_conexcion.Open();
                using (SqlCommand comando = new SqlCommand(query, mi_conexcion))
                {
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        DataTable data_tableProductos = new DataTable();
                        adaptador.Fill(data_tableProductos);
                        gridWiewProductos_Categorias.DataSource = data_tableProductos;
                        gridWiewProductos_Categorias.DataBind();
                    }
                }
            }

            // se limpian los cuadros de texto y los valores seleccionados de los DropDownList
            TextBoxProducto.Text = "";
            TextBoxCategoria.Text = "";
            DropDownListProducto.SelectedIndex = 0;
            DropDownListCategoria.SelectedIndex = 0;
        }
    }
}