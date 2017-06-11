namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAbrirCompeticion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirCompeticion));
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDeportes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.chectActivado = new System.Windows.Forms.CheckBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(197, 226);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deporte";
            // 
            // comboDeportes
            // 
            this.comboDeportes.Enabled = false;
            this.comboDeportes.FormattingEnabled = true;
            this.comboDeportes.Location = new System.Drawing.Point(14, 69);
            this.comboDeportes.Name = "comboDeportes";
            this.comboDeportes.Size = new System.Drawing.Size(260, 21);
            this.comboDeportes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(14, 26);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(260, 20);
            this.textNombre.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(116, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chectActivado
            // 
            this.chectActivado.AutoSize = true;
            this.chectActivado.Enabled = false;
            this.chectActivado.Location = new System.Drawing.Point(13, 97);
            this.chectActivado.Name = "chectActivado";
            this.chectActivado.Size = new System.Drawing.Size(68, 17);
            this.chectActivado.TabIndex = 12;
            this.chectActivado.Text = "Activado";
            this.chectActivado.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(196, 125);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // frmAbrirCompeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.chectActivado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDeportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirCompeticion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Abrir Competicion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDeportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chectActivado;
        private System.Windows.Forms.Button btGuardar;
    }
}