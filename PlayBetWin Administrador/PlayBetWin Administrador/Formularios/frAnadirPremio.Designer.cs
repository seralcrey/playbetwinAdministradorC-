namespace PlayBetWin_Administrador.Formularios
{
    partial class frAnadirPremio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frAnadirPremio));
            this.label1 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textCoins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.abrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.btSelecionarImagen = new System.Windows.Forms.Button();
            this.nombreImagen = new System.Windows.Forms.Label();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(15, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(257, 20);
            this.textNombre.TabIndex = 1;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // textCoins
            // 
            this.textCoins.Location = new System.Drawing.Point(15, 64);
            this.textCoins.Name = "textCoins";
            this.textCoins.Size = new System.Drawing.Size(257, 20);
            this.textCoins.TabIndex = 3;
            this.textCoins.TextChanged += new System.EventHandler(this.textCoins_TextChanged);
            this.textCoins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCoins_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coins";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(197, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(113, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // abrirImagen
            // 
            this.abrirImagen.FileName = "openFileDialog1";
            // 
            // btSelecionarImagen
            // 
            this.btSelecionarImagen.BackColor = System.Drawing.Color.White;
            this.btSelecionarImagen.Location = new System.Drawing.Point(15, 90);
            this.btSelecionarImagen.Name = "btSelecionarImagen";
            this.btSelecionarImagen.Size = new System.Drawing.Size(257, 23);
            this.btSelecionarImagen.TabIndex = 7;
            this.btSelecionarImagen.Text = "Selecionar imagen";
            this.btSelecionarImagen.UseVisualStyleBackColor = false;
            this.btSelecionarImagen.Click += new System.EventHandler(this.btSelecionarImagen_Click);
            // 
            // nombreImagen
            // 
            this.nombreImagen.AutoSize = true;
            this.nombreImagen.Location = new System.Drawing.Point(12, 116);
            this.nombreImagen.Name = "nombreImagen";
            this.nombreImagen.Size = new System.Drawing.Size(59, 13);
            this.nombreImagen.TabIndex = 8;
            this.nombreImagen.Text = "Sin imagen";
            this.nombreImagen.Click += new System.EventHandler(this.nombreImagen_Click);
            // 
            // frAnadirPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 234);
            this.Controls.Add(this.nombreImagen);
            this.Controls.Add(this.btSelecionarImagen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frAnadirPremio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Añadir premio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog abrirImagen;
        private System.Windows.Forms.Button btSelecionarImagen;
        private System.Windows.Forms.Label nombreImagen;
    }
}