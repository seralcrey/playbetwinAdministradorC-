namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAbrirEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirEvento));
            this.label10 = new System.Windows.Forms.Label();
            this.combCompeticion = new System.Windows.Forms.ComboBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.equipoVisi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipoCasa = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkActivado = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resCasa = new System.Windows.Forms.TextBox();
            this.resVisi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "Competición";
            // 
            // combCompeticion
            // 
            this.combCompeticion.Enabled = false;
            this.combCompeticion.FormattingEnabled = true;
            this.combCompeticion.Location = new System.Drawing.Point(14, 111);
            this.combCompeticion.Name = "combCompeticion";
            this.combCompeticion.Size = new System.Drawing.Size(324, 21);
            this.combCompeticion.TabIndex = 46;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(182, 343);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 45;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(263, 343);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 44;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "X";
            // 
            // text2
            // 
            this.text2.Enabled = false;
            this.text2.Location = new System.Drawing.Point(251, 240);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(87, 20);
            this.text2.TabIndex = 41;
            this.text2.Text = "0";
            this.text2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "1";
            // 
            // textX
            // 
            this.textX.Enabled = false;
            this.textX.Location = new System.Drawing.Point(131, 240);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(87, 20);
            this.textX.TabIndex = 39;
            this.textX.Text = "0";
            this.textX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textX_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Apuestas";
            // 
            // text1
            // 
            this.text1.Enabled = false;
            this.text1.Location = new System.Drawing.Point(14, 240);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(87, 20);
            this.text1.TabIndex = 37;
            this.text1.Text = "0";
            this.text1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha";
            // 
            // fecha
            // 
            this.fecha.Enabled = false;
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(14, 151);
            this.fecha.Name = "fecha";
            this.fecha.ShowUpDown = true;
            this.fecha.Size = new System.Drawing.Size(324, 20);
            this.fecha.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "EquipoVisitante";
            // 
            // equipoVisi
            // 
            this.equipoVisi.Enabled = false;
            this.equipoVisi.FormattingEnabled = true;
            this.equipoVisi.Location = new System.Drawing.Point(14, 66);
            this.equipoVisi.Name = "equipoVisi";
            this.equipoVisi.Size = new System.Drawing.Size(324, 21);
            this.equipoVisi.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Equipo local";
            // 
            // equipoCasa
            // 
            this.equipoCasa.Enabled = false;
            this.equipoCasa.FormattingEnabled = true;
            this.equipoCasa.Location = new System.Drawing.Point(14, 26);
            this.equipoCasa.Name = "equipoCasa";
            this.equipoCasa.Size = new System.Drawing.Size(324, 21);
            this.equipoCasa.TabIndex = 31;
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.Enabled = false;
            this.btGuardar.Location = new System.Drawing.Point(263, 314);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 48;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(101, 343);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "Borrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkActivado
            // 
            this.checkActivado.AutoSize = true;
            this.checkActivado.Enabled = false;
            this.checkActivado.Location = new System.Drawing.Point(14, 267);
            this.checkActivado.Name = "checkActivado";
            this.checkActivado.Size = new System.Drawing.Size(68, 17);
            this.checkActivado.TabIndex = 50;
            this.checkActivado.Text = "Activado";
            this.checkActivado.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Resutado";
            // 
            // resCasa
            // 
            this.resCasa.Enabled = false;
            this.resCasa.Location = new System.Drawing.Point(71, 177);
            this.resCasa.Name = "resCasa";
            this.resCasa.Size = new System.Drawing.Size(60, 20);
            this.resCasa.TabIndex = 52;
            this.resCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resCasa_KeyPress);
            // 
            // resVisi
            // 
            this.resVisi.Enabled = false;
            this.resVisi.Location = new System.Drawing.Point(171, 177);
            this.resVisi.Name = "resVisi";
            this.resVisi.Size = new System.Drawing.Size(60, 20);
            this.resVisi.TabIndex = 53;
            this.resVisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resVisi_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "vs";
            // 
            // frmAbrirEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(348, 380);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resVisi);
            this.Controls.Add(this.resCasa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkActivado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.combCompeticion);
            this.Controls.Add(this.btEditar);
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
            this.Name = "frmAbrirEvento";
            this.Text = "Evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combCompeticion;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipoVisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipoCasa;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkActivado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resCasa;
        private System.Windows.Forms.TextBox resVisi;
        private System.Windows.Forms.Label label5;
    }
}