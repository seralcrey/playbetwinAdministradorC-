namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAbrirDeporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.checActivado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(15, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(257, 20);
            this.textNombre.TabIndex = 1;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(15, 226);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(95, 23);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Habilitar editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(116, 226);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(197, 226);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Enabled = false;
            this.btGuardar.Location = new System.Drawing.Point(197, 103);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 5;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // checActivado
            // 
            this.checActivado.AutoSize = true;
            this.checActivado.Checked = true;
            this.checActivado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checActivado.Enabled = false;
            this.checActivado.Location = new System.Drawing.Point(15, 51);
            this.checActivado.Name = "checActivado";
            this.checActivado.Size = new System.Drawing.Size(68, 17);
            this.checActivado.TabIndex = 6;
            this.checActivado.Text = "Activado";
            this.checActivado.UseVisualStyleBackColor = true;
            // 
            // frmAbrirDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checActivado);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmAbrirDeporte";
            this.Text = "Editar deporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.CheckBox checActivado;
    }
}