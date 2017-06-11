namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAnadirProducto
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.textCoins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.abrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nombreImagen
            // 
            this.nombreImagen.AutoSize = true;
            this.nombreImagen.Location = new System.Drawing.Point(12, 195);
            this.nombreImagen.Name = "nombreImagen";
            this.nombreImagen.Size = new System.Drawing.Size(59, 13);
            this.nombreImagen.TabIndex = 16;
            this.nombreImagen.Text = "Sin imagen";
            // 
            // btSelecionarImagen
            // 
            this.btSelecionarImagen.BackColor = System.Drawing.Color.White;
            this.btSelecionarImagen.Location = new System.Drawing.Point(15, 169);
            this.btSelecionarImagen.Name = "btSelecionarImagen";
            this.btSelecionarImagen.Size = new System.Drawing.Size(257, 23);
            this.btSelecionarImagen.TabIndex = 15;
            this.btSelecionarImagen.Text = "Selecionar imagen";
            this.btSelecionarImagen.UseVisualStyleBackColor = false;
            this.btSelecionarImagen.Click += new System.EventHandler(this.btSelecionarImagen_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(116, 226);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 14;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.Location = new System.Drawing.Point(197, 226);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // textCoins
            // 
            this.textCoins.Location = new System.Drawing.Point(15, 99);
            this.textCoins.Name = "textCoins";
            this.textCoins.Size = new System.Drawing.Size(257, 20);
            this.textCoins.TabIndex = 12;
            this.textCoins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCoins_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coins";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(15, 21);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(257, 20);
            this.textNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(15, 60);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(257, 20);
            this.textPrecio.TabIndex = 18;
            this.textPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textPrecio_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Precio";
            // 
            // abrirImagen
            // 
            this.abrirImagen.FileName = "openFileDialog1";
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(15, 138);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(257, 20);
            this.textStock.TabIndex = 20;
            this.textStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textStock_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Stock";
            // 
            // frmAnadirProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textStock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nombreImagen);
            this.Controls.Add(this.btSelecionarImagen);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.textCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAnadirProducto";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Añadir Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreImagen;
        private System.Windows.Forms.Button btSelecionarImagen;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox textCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog abrirImagen;
        private System.Windows.Forms.TextBox textStock;
        private System.Windows.Forms.Label label4;
    }
}