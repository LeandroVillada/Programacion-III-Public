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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEj1_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Show();

        }


        private void btnEj1_MouseHover(object sender, EventArgs e)
        {
            btnEj1.BackColor = Color.DarkBlue;
            btnEj1.ForeColor = Color.White;
            btnEj1.FlatStyle = FlatStyle.Flat;
            btnEj1.FlatAppearance.BorderSize = 0;
            btnEj2.BackColor = Color.Transparent;
            btnEj2.ForeColor = Color.Black;
            btnEj2.FlatStyle = FlatStyle.Standard;
            btnEj3.BackColor = Color.Transparent;
            btnEj3.ForeColor = Color.Black;
            btnEj3.FlatStyle = FlatStyle.Standard;

        
        }

      

        private void Form1_MouseHover(object sender, EventArgs e)
        {
            btnEj1.BackColor = Color.Transparent;
            btnEj1.ForeColor = Color.Black;
            btnEj1.FlatStyle = FlatStyle.Standard;
            btnEj3.BackColor = Color.Transparent;
            btnEj3.ForeColor = Color.Black;
            btnEj3.FlatStyle = FlatStyle.Standard;
            btnEj2.BackColor = Color.Transparent;
            btnEj2.ForeColor = Color.Black;
            btnEj2.FlatStyle = FlatStyle.Standard;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           btnEj3.BackColor = Color.Transparent;
           btnEj1.BackColor = Color.Transparent;
           btnEj2.BackColor = Color.Transparent;
            
        }

      

        private void btnEj2_MouseHover(object sender, EventArgs e)
        {
            btnEj1.BackColor = Color.Transparent;
            btnEj1.ForeColor = Color.Black;
            btnEj1.FlatStyle = FlatStyle.Standard;
            btnEj2.FlatStyle = FlatStyle.Flat;
            btnEj2.FlatAppearance.BorderSize = 0;
            btnEj2.BackColor = Color.DarkMagenta;
            btnEj2.ForeColor = Color.White;
            btnEj3.FlatStyle = FlatStyle.Standard;
            btnEj3.BackColor = Color.Transparent;
            btnEj3.ForeColor = Color.Black;

        }

        private void btnEj3_MouseHover(object sender, EventArgs e)
        {
            btnEj1.BackColor = Color.Transparent;
            btnEj1.ForeColor = Color.Black;
            btnEj1.FlatStyle = FlatStyle.Standard;
            btnEj2.BackColor = Color.Transparent;
            btnEj2.ForeColor = Color.Black;
            btnEj2.FlatStyle = FlatStyle.Standard;
            btnEj3.FlatStyle = FlatStyle.Flat;
            btnEj3.FlatAppearance.BorderSize = 0;
            btnEj3.BackColor = Color.DarkGoldenrod;
            btnEj3.ForeColor = Color.White;
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
        }

        private void btnEj3_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
        }
    }
}
