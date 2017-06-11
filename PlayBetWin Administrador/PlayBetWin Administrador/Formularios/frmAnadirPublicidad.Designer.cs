namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAnadirPublicidad
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
            this.nombreImagen = new System.Windows.Forms.Label();
            this.btSelecionarImagen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textCoins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.abrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // nombreImagen
            // 
            this.nombreImagen.AutoSize = true;
            this.nombreImagen.Location = new System.Drawing.Point(12, 173);
            this.nombreImagen.Name = "nombreImagen";
            this.nombreImagen.Size = new System.Drawing.Size(59, 13);
            this.nombreImagen.TabIndex = 16;
            this.nombreImagen.Text = "Sin imagen";
            // 
            // btSelecionarImagen
            // 
            this.btSelecionarImagen.BackColor = System.Drawing.Color.White;
            this.btSelecionarImagen.Location = new System.Drawing.Point(15, 147);
            this.btSelecionarImagen.Name = "btSelecionarImagen";
            this.btSelecionarImagen.Size = new System.Drawing.Size(257, 23);
            this.btSelecionarImagen.TabIndex = 15;
            this.btSelecionarImagen.Text = "Selecionar imagen";
            this.btSelecionarImagen.UseVisualStyleBackColor = false;
            this.btSelecionarImagen.Click += new System.EventHandler(this.btSelecionarImagen_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(113, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(197, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textCoins
            // 
            this.textCoins.Location = new System.Drawing.Point(15, 121);
            this.textCoins.Name = "textCoins";
            this.textCoins.Size = new System.Drawing.Size(257, 20);
            this.textCoins.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coins";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(15, 40);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(257, 20);
            this.textNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // textURL
            // 
            this.textURL.Location = new System.Drawing.Point(15, 82);
            this.textURL.Name = "textURL";
            this.textURL.Size = new System.Drawing.Size(257, 20);
            this.textURL.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "URL";
            // 
            // abrirImagen
            // 
            this.abrirImagen.FileName = "openFileDialog1";
            // 
            // frmAnadirPublicidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreImagen);
            this.Controls.Add(this.btSelecionarImagen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Name = "frmAnadirPublicidad";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Anadir publicidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreImagen;
        private System.Windows.Forms.Button btSelecionarImagen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog abrirImagen;
    }
}