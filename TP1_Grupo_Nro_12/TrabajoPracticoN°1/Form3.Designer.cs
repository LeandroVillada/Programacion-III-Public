
namespace TrabajoPracticoN_1
{
    partial class Form3
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
            this.gbIngreso = new System.Windows.Forms.GroupBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.lbElementos = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.gbIngreso.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngreso
            // 
            this.gbIngreso.BackColor = System.Drawing.Color.Black;
            this.gbIngreso.Controls.Add(this.btnAgregar);
            this.gbIngreso.Controls.Add(this.txtApellido);
            this.gbIngreso.Controls.Add(this.txtNombre);
            this.gbIngreso.Controls.Add(this.lbApellido);
            this.gbIngreso.Controls.Add(this.lbNombre);
            this.gbIngreso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbIngreso.ForeColor = System.Drawing.Color.White;
            this.gbIngreso.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbIngreso.Location = new System.Drawing.Point(22, 34);
            this.gbIngreso.Name = "gbIngreso";
            this.gbIngreso.Padding = new System.Windows.Forms.Padding(0);
            this.gbIngreso.Size = new System.Drawing.Size(349, 558);
            this.gbIngreso.TabIndex = 2;
            this.gbIngreso.TabStop = false;
            this.gbIngreso.Text = "Ingreso de datos:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(68, 362);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(209, 38);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(98, 287);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(204, 26);
            this.txtApellido.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 247);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(204, 26);
            this.txtNombre.TabIndex = 2;
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(17, 289);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(77, 21);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(17, 247);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(75, 21);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // gbElementos
            // 
            this.gbElementos.BackColor = System.Drawing.Color.Black;
            this.gbElementos.Controls.Add(this.lbElementos);
            this.gbElementos.Controls.Add(this.btnBorrar);
            this.gbElementos.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElementos.ForeColor = System.Drawing.Color.White;
            this.gbElementos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gbElementos.Location = new System.Drawing.Point(385, 34);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(0);
            this.gbElementos.Size = new System.Drawing.Size(349, 558);
            this.gbElementos.TabIndex = 3;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // lbElementos
            // 
            this.lbElementos.FormattingEnabled = true;
            this.lbElementos.ItemHeight = 19;
            this.lbElementos.Location = new System.Drawing.Point(21, 38);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(310, 441);
            this.lbElementos.TabIndex = 6;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.ForeColor = System.Drawing.Color.Black;
            this.btnBorrar.Location = new System.Drawing.Point(77, 499);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(200, 38);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(767, 617);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbIngreso);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form3";
            this.Text = "Ejercicio 2 - Nombre y Apellido";
            this.gbIngreso.ResumeLayout(false);
            this.gbIngreso.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngreso;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.ListBox lbElementos;
        private System.Windows.Forms.Button btnBorrar;
    }
}