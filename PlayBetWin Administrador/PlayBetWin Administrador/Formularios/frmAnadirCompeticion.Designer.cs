namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAnadirCompeticion
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
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboDeportes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAnadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(12, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(260, 20);
            this.textNombre.TabIndex = 0;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboDeportes
            // 
            this.comboDeportes.FormattingEnabled = true;
            this.comboDeportes.Location = new System.Drawing.Point(12, 68);
            this.comboDeportes.Name = "comboDeportes";
            this.comboDeportes.Size = new System.Drawing.Size(260, 21);
            this.comboDeportes.TabIndex = 2;
            this.comboDeportes.SelectedIndexChanged += new System.EventHandler(this.comboDeportes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Deporte";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // btAnadir
            // 
            this.btAnadir.BackColor = System.Drawing.Color.White;
            this.btAnadir.Location = new System.Drawing.Point(197, 226);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(75, 23);
            this.btAnadir.TabIndex = 5;
            this.btAnadir.Text = "Añadir";
            this.btAnadir.UseVisualStyleBackColor = false;
            this.btAnadir.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmAnadirCompeticion
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
            this.Name = "frmAnadirCompeticion";
            this.ShowIcon = false;
            this.Text = "Añadir competición";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDeportes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAnadir;
    }
}