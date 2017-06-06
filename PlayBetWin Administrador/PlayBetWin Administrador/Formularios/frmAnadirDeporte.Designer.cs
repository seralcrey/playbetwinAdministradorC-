namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAnadirDeporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnadirDeporte));
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.checkActivado = new System.Windows.Forms.CheckBox();
            this.btGuradar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(16, 29);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(256, 20);
            this.textNombre.TabIndex = 1;
            // 
            // checkActivado
            // 
            this.checkActivado.AutoSize = true;
            this.checkActivado.Checked = true;
            this.checkActivado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivado.Location = new System.Drawing.Point(16, 56);
            this.checkActivado.Name = "checkActivado";
            this.checkActivado.Size = new System.Drawing.Size(68, 17);
            this.checkActivado.TabIndex = 2;
            this.checkActivado.Text = "Activado";
            this.checkActivado.UseVisualStyleBackColor = true;
            // 
            // btGuradar
            // 
            this.btGuradar.BackColor = System.Drawing.Color.White;
            this.btGuradar.Location = new System.Drawing.Point(197, 226);
            this.btGuradar.Name = "btGuradar";
            this.btGuradar.Size = new System.Drawing.Size(75, 23);
            this.btGuradar.TabIndex = 3;
            this.btGuradar.Text = "Añadir";
            this.btGuradar.UseVisualStyleBackColor = false;
            this.btGuradar.Click += new System.EventHandler(this.btGuradar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(116, 226);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // frmAnadirDeporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 266);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuradar);
            this.Controls.Add(this.checkActivado);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnadirDeporte";
            this.ShowIcon = false;
            this.Text = "Añadir deporte";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAnadirDeporte_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.CheckBox checkActivado;
        private System.Windows.Forms.Button btGuradar;
        private System.Windows.Forms.Button btCancelar;
    }
}