namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAbrirParticipante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirParticipante));
            this.btGuardar = new System.Windows.Forms.Button();
            this.chectActivado = new System.Windows.Forms.CheckBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDeportes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(196, 126);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 22;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // chectActivado
            // 
            this.chectActivado.AutoSize = true;
            this.chectActivado.Enabled = false;
            this.chectActivado.Location = new System.Drawing.Point(13, 98);
            this.chectActivado.Name = "chectActivado";
            this.chectActivado.Size = new System.Drawing.Size(68, 17);
            this.chectActivado.TabIndex = 21;
            this.chectActivado.Text = "Activado";
            this.chectActivado.UseVisualStyleBackColor = true;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(116, 227);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 20;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(197, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Deporte";
            // 
            // comboDeportes
            // 
            this.comboDeportes.Enabled = false;
            this.comboDeportes.FormattingEnabled = true;
            this.comboDeportes.Location = new System.Drawing.Point(14, 70);
            this.comboDeportes.Name = "comboDeportes";
            this.comboDeportes.Size = new System.Drawing.Size(260, 21);
            this.comboDeportes.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(14, 27);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(260, 20);
            this.textNombre.TabIndex = 14;
            // 
            // frmAbrirParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.chectActivado);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDeportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirParticipante";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Abrir participante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.CheckBox chectActivado;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDeportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
    }
}