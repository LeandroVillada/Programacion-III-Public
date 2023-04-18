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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
               
                
                var lblTextoGenerado = new Label
                {
                    Location = new Point(62, 415),
                    AutoSize = true,
                    ForeColor = Color.White,
                    BackColor = Color.Black,
                    Font = new Font("Times New Roman", 13, FontStyle.Regular, GraphicsUnit.Point, (byte)0)
                };

            string salida = "";
            
            
            salida = "Usted seleccionó los siguientes elementos: " + "\r\n";

           
            salida += "Sexo: " + (string)(rbtnFemenino.Checked ? "Femenino" : "Masculino ") + "\r\n";
            salida += "Estado Civil: " + (string)(rbtnCasado.Checked ? "Casado" : "Soltero ") + "\r\n";
            salida += "Oficio: " + "\r\n";
                        
            foreach (string s in clbDatos.CheckedItems)
            {

                salida += "   -" + s + "\r\n";
            }



            /*
             for (int x = 0; x < clbDatos.Items.Count; x++)
            {
                if (clbDatos.GetItemChecked(x))
                {
                    salida += "   -" + clbDatos.Items[x].ToString() + "\r\n";
                }
                else
                {
                    salida.Replace("   -" + clbDatos.Items[x].ToString() + ,"");
                    
                }
            }*/

            lblTextoGenerado.Text = salida;
            lblTextoGenerado.Refresh();
            lblTextoGenerado.Update();
            Controls.Add(lblTextoGenerado);
           


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
