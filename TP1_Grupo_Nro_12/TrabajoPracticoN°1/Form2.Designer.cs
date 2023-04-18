
namespace TrabajoPracticoN_1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIngNombre = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbNombre1 = new System.Windows.Forms.ListBox();
            this.lbNombre2 = new System.Windows.Forms.ListBox();
            this.btnPasarIndividual = new System.Windows.Forms.Button();
            this.btnPasarMultiple = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngNombre
            // 
            this.lblIngNombre.AutoSize = true;
            this.lblIngNombre.BackColor = System.Drawing.Color.Black;
            this.lblIngNombre.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngNombre.ForeColor = System.Drawing.Color.White;
            this.lblIngNombre.Location = new System.Drawing.Point(12, 102);
            this.lblIngNombre.Name = "lblIngNombre";
            this.lblIngNombre.Size = new System.Drawing.Size(222, 31);
            this.lblIngNombre.TabIndex = 0;
            this.lblIngNombre.Text = "Ingrese un nombre:";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(240, 112);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(245, 20);
            this.txt1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(565, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 31);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lbNombre1
            // 
            this.lbNombre1.FormattingEnabled = true;
            this.lbNombre1.Location = new System.Drawing.Point(28, 223);
            this.lbNombre1.Name = "lbNombre1";
            this.lbNombre1.Size = new System.Drawing.Size(253, 329);
            this.lbNombre1.TabIndex = 3;
            // 
            // lbNombre2
            // 
            this.lbNombre2.FormattingEnabled = true;
            this.lbNombre2.Location = new System.Drawing.Point(449, 223);
            this.lbNombre2.Name = "lbNombre2";
            this.lbNombre2.Size = new System.Drawing.Size(253, 329);
            this.lbNombre2.TabIndex = 4;
            // 
            // btnPasarIndividual
            // 
            this.btnPasarIndividual.Location = new System.Drawing.Point(329, 348);
            this.btnPasarIndividual.Name = "btnPasarIndividual";
            this.btnPasarIndividual.Size = new System.Drawing.Size(75, 23);
            this.btnPasarIndividual.TabIndex = 5;
            this.btnPasarIndividual.Text = ">";
            this.btnPasarIndividual.UseVisualStyleBackColor = true;
            this.btnPasarIndividual.Click += new System.EventHandler(this.btnPasarIndividual_Click);
            // 
            // btnPasarMultiple
            // 
            this.btnPasarMultiple.Location = new System.Drawing.Point(329, 420);
            this.btnPasarMultiple.Name = "btnPasarMultiple";
            this.btnPasarMultiple.Size = new System.Drawing.Size(75, 23);
            this.btnPasarMultiple.TabIndex = 6;
            this.btnPasarMultiple.Text = ">>";
            this.btnPasarMultiple.UseVisualStyleBackColor = true;
            this.btnPasarMultiple.Click += new System.EventHandler(this.btnPasarMultiple_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(767, 617);
            this.Controls.Add(this.btnPasarMultiple);
            this.Controls.Add(this.btnPasarIndividual);
            this.Controls.Add(this.lbNombre2);
            this.Controls.Add(this.lbNombre1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblIngNombre);
            this.Name = "Form2";
            this.Text = "EJERCICIO 1 - Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngNombre;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lbNombre1;
        private System.Windows.Forms.ListBox lbNombre2;
        private System.Windows.Forms.Button btnPasarIndividual;
        private System.Windows.Forms.Button btnPasarMultiple;
    }
}