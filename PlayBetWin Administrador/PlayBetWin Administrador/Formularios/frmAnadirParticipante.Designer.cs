namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAnadirParticipante
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
            this.btAnadir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDeportes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAnadir
            // 
            this.btAnadir.BackColor = System.Drawing.Color.White;
            this.btAnadir.Location = new System.Drawing.Point(199, 227);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 11;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = false;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(118, 227);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 10;
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
            this.label2.TabIndex = 9;
            this.label2.Text = "Deporte";
            // 
            // comboDeportes
            // 
            this.comboDeportes.FormattingEnabled = true;
            this.comboDeportes.Location = new System.Drawing.Point(14, 69);
            this.comboDeportes.Name = "comboDeportes";
            this.comboDeportes.Size = new System.Drawing.Size(260, 21);
            this.comboDeportes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(14, 26);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(260, 20);
            this.textNombre.TabIndex = 6;
            // 
            // frmAnadirParticipante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDeportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnadirParticipante";
            this.Text = "Añadir participante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDeportes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
    }
}