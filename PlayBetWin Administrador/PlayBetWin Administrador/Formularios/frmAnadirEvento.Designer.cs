namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAnadirEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnadirEvento));
            this.label2 = new System.Windows.Forms.Label();
            this.equipoCasa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipoVisi = new System.Windows.Forms.ComboBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.combCompeticion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Equipo local";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // equipoCasa
            // 
            this.equipoCasa.FormattingEnabled = true;
            this.equipoCasa.Location = new System.Drawing.Point(11, 25);
            this.equipoCasa.Name = "equipoCasa";
            this.equipoCasa.Size = new System.Drawing.Size(324, 21);
            this.equipoCasa.TabIndex = 10;
            this.equipoCasa.SelectedIndexChanged += new System.EventHandler(this.equipoCasa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "EquipoVisitante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // equipoVisi
            // 
            this.equipoVisi.FormattingEnabled = true;
            this.equipoVisi.Location = new System.Drawing.Point(11, 65);
            this.equipoVisi.Name = "equipoVisi";
            this.equipoVisi.Size = new System.Drawing.Size(324, 21);
            this.equipoVisi.TabIndex = 12;
            this.equipoVisi.SelectedIndexChanged += new System.EventHandler(this.equipoVisi_SelectedIndexChanged);
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(11, 150);
            this.fecha.Name = "fecha";
            this.fecha.ShowUpDown = true;
            this.fecha.Size = new System.Drawing.Size(324, 20);
            this.fecha.TabIndex = 14;
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Apuestas";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(11, 213);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(87, 20);
            this.text1.TabIndex = 20;
            this.text1.Text = "0";
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            this.text1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "1";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textX
            // 
            this.textX.Location = new System.Drawing.Point(128, 213);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(87, 20);
            this.textX.TabIndex = 22;
            this.textX.Text = "0";
            this.textX.TextChanged += new System.EventHandler(this.textX_TextChanged);
            this.textX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textX_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(165, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(248, 213);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(87, 20);
            this.text2.TabIndex = 24;
            this.text2.Text = "0";
            this.text2.TextChanged += new System.EventHandler(this.text2_TextChanged);
            this.text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text2_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "2";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(260, 242);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 27;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.BackColor = System.Drawing.Color.White;
            this.btEnviar.Location = new System.Drawing.Point(179, 242);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(75, 23);
            this.btEnviar.TabIndex = 28;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = false;
            this.btEnviar.Click += new System.EventHandler(this.btEnviar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Competición";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // combCompeticion
            // 
            this.combCompeticion.FormattingEnabled = true;
            this.combCompeticion.Location = new System.Drawing.Point(11, 110);
            this.combCompeticion.Name = "combCompeticion";
            this.combCompeticion.Size = new System.Drawing.Size(324, 21);
            this.combCompeticion.TabIndex = 29;
            this.combCompeticion.SelectedIndexChanged += new System.EventHandler(this.combCompeticion_SelectedIndexChanged);
            // 
            // frmAnadirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(348, 277);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combCompeticion);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipoVisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipoCasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnadirEvento";
            this.Text = "Añadir Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipoCasa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipoVisi;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combCompeticion;
    }
}