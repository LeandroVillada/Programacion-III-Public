using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoN_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            if(txtNombre.Text.Trim() != "" && txtApellido.Text.Trim() != "")
            {
                if (lbElementos.Items.Count == 0) {
                    lbElementos.Items.Add(txtNombre.Text.ToString().ToUpper() + " " + txtApellido.Text.ToString().ToUpper());
                    txtApellido.Text = "";
                    txtNombre.Text = "";
                }
                
                else { 
                foreach(string s in lbElementos.Items)
                {

                        if (s.Contains(txtNombre.Text.ToString().ToUpper() + " " + txtApellido.Text.ToString().ToUpper())) {
                            existe = true;
                    }
                   
                
                            
                }
                    if (!existe) { 
                        lbElementos.Items.Add(txtNombre.Text.ToString().ToUpper() + " " + txtApellido.Text.ToString().ToUpper());
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                    }
                    if (existe)
                    {
                        txtApellido.Text = "";
                        txtNombre.Text = "";
                    }


                }
            }
            lbElementos.Sorted = true;
           
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lbElementos.Items.Clear();
        }
    }
}
