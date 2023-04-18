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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool repetido = false;

            foreach (string p in lbNombre1.Items)
            {
                if (p.Trim().ToUpper() == txt1.Text.ToUpper().Trim())
                {
                    repetido = true;
                }
            }
            if (txt1.Text.Trim() != "" && repetido == false)
            {

                lbNombre1.Items.Add(txt1.Text);
                txt1.Text = "";

            }

            txt1.Text = "";
        }

        private void btnPasarIndividual_Click(object sender, EventArgs e)
        {
            bool repetido = false;
            if (lbNombre1.SelectedIndex == -1)
            {
                MessageBox.Show("Se debe seleccionar un elemento de la lista", "Importante");
            }
            else
            {
                if (lbNombre2.Items.Count == 0)
                {
                    lbNombre2.Items.Add(lbNombre1.SelectedItem);
                }
                else
                {
                    foreach (string item in lbNombre2.Items)
                    {
                        if (item.Contains(lbNombre1.SelectedItem.ToString()))
                        {
                            repetido = true;

                        }
                    }
                    if (!repetido) { lbNombre2.Items.Add(lbNombre1.SelectedItem); }
                }
            }
        }

        private void btnPasarMultiple_Click(object sender, EventArgs e)
        {
            
            bool repetido = false;
            if(lbNombre1.Items.Count > 0) { 
            foreach (string item in lbNombre1.Items)
            {
                    if  (lbNombre2.Items.Contains(item.ToString()))
                    {
                        repetido = true;
                    }

                if (repetido == false)
                {
                    lbNombre2.Items.Add(item);
                }
                repetido = false;
            }
            lbNombre1.Items.Clear();
        }
    }
    }
}

