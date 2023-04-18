
namespace TrabajoPracticoN_1
{
    partial class Form4
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
            this.bnSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSoltero = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.clbDatos = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.bnSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnSexo
            // 
            this.bnSexo.BackColor = System.Drawing.Color.Black;
            this.bnSexo.Controls.Add(this.rbtnMasculino);
            this.bnSexo.Controls.Add(this.rbtnFemenino);
            this.bnSexo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSexo.ForeColor = System.Drawing.Color.White;
            this.bnSexo.Location = new System.Drawing.Point(62, 72);
            this.bnSexo.Name = "bnSexo";
            this.bnSexo.Size = new System.Drawing.Size(241, 127);
            this.bnSexo.TabIndex = 0;
            this.bnSexo.TabStop = false;
            this.bnSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMasculino.Location = new System.Drawing.Point(20, 78);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(82, 19);
            this.rbtnMasculino.TabIndex = 7;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Checked = true;
            this.rbtnFemenino.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemenino.Location = new System.Drawing.Point(20, 41);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(77, 19);
            this.rbtnFemenino.TabIndex = 4;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.rbtnSoltero);
            this.groupBox1.Controls.Add(this.rbtnCasado);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(454, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Civil";
            // 
            // rbtnSoltero
            // 
            this.rbtnSoltero.AutoSize = true;
            this.rbtnSoltero.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSoltero.Location = new System.Drawing.Point(34, 78);
            this.rbtnSoltero.Name = "rbtnSoltero";
            this.rbtnSoltero.Size = new System.Drawing.Size(63, 19);
            this.rbtnSoltero.TabIndex = 6;
            this.rbtnSoltero.Text = "Soltero";
            this.rbtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCasado.Location = new System.Drawing.Point(34, 41);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(65, 19);
            this.rbtnCasado.TabIndex = 5;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // clbDatos
            // 
            this.clbDatos.BackColor = System.Drawing.SystemColors.MenuText;
            this.clbDatos.CheckOnClick = true;
            this.clbDatos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbDatos.ForeColor = System.Drawing.Color.White;
            this.clbDatos.FormattingEnabled = true;
            this.clbDatos.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbDatos.Location = new System.Drawing.Point(262, 230);
            this.clbDatos.Name = "clbDatos";
            this.clbDatos.Size = new System.Drawing.Size(238, 106);
            this.clbDatos.TabIndex = 2;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Black;
            this.btnMostrar.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(262, 358);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(238, 40);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(767, 617);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.clbDatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bnSexo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form4";
            this.Text = "Ejercicio 3";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.bnSexo.ResumeLayout(false);
            this.bnSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox bnSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbDatos;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnSoltero;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.Button btnMostrar;
    }
}