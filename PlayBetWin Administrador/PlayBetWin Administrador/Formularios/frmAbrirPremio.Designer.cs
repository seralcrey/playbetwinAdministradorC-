namespace PlayBetWin_Administrador.Formularios
{
    partial class frmAbrirPremio
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
            this.textCoins = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.abrirImagen = new System.Windows.Forms.OpenFileDialog();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.checkActivado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nombreImagen
            // 
            this.nombreImagen.AutoSize = true;
            this.nombreImagen.Location = new System.Drawing.Point(9, 113);
            this.nombreImagen.Name = "nombreImagen";
            this.nombreImagen.Size = new System.Drawing.Size(59, 13);
            this.nombreImagen.TabIndex = 14;
            this.nombreImagen.Text = "Sin imagen";
            // 
            // btSelecionarImagen
            // 
            this.btSelecionarImagen.BackColor = System.Drawing.Color.White;
            this.btSelecionarImagen.Enabled = false;
            this.btSelecionarImagen.Location = new System.Drawing.Point(12, 87);
            this.btSelecionarImagen.Name = "btSelecionarImagen";
            this.btSelecionarImagen.Size = new System.Drawing.Size(257, 23);
            this.btSelecionarImagen.TabIndex = 13;
            this.btSelecionarImagen.Text = "Selecionar imagen";
            this.btSelecionarImagen.UseVisualStyleBackColor = false;
            this.btSelecionarImagen.Click += new System.EventHandler(this.btSelecionarImagen_Click);
            // 
            // textCoins
            // 
            this.textCoins.Enabled = false;
            this.textCoins.Location = new System.Drawing.Point(12, 61);
            this.textCoins.Name = "textCoins";
            this.textCoins.Size = new System.Drawing.Size(257, 20);
            this.textCoins.TabIndex = 12;
            this.textCoins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCoins_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Coins";
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(12, 22);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(257, 20);
            this.textNombre.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre";
            // 
            // abrirImagen
            // 
            this.abrirImagen.FileName = "openFileDialog1";
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.White;
            this.btEditar.Location = new System.Drawing.Point(124, 226);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 15;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(205, 226);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 17;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.White;
            this.btGuardar.Enabled = false;
            this.btGuardar.Location = new System.Drawing.Point(204, 146);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 18;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // checkActivado
            // 
            this.checkActivado.AutoSize = true;
            this.checkActivado.Enabled = false;
            this.checkActivado.Location = new System.Drawing.Point(12, 130);
            this.checkActivado.Name = "checkActivado";
            this.checkActivado.Size = new System.Drawing.Size(68, 17);
            this.checkActivado.TabIndex = 19;
            this.checkActivado.Text = "Activado";
            this.checkActivado.UseVisualStyleBackColor = true;
            // 
            // frmAbrirPremio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkActivado);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.nombreImagen);
            this.Controls.Add(this.btSelecionarImagen);
            this.Controls.Add(this.textCoins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirPremio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Abrir Premio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreImagen;
        private System.Windows.Forms.Button btSelecionarImagen;
        private System.Windows.Forms.TextBox textCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog abrirImagen;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.CheckBox checkActivado;
    }
}