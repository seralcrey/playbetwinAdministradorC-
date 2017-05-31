namespace PlayBetWin_Administrador.Formularios
{
    partial class frmRealizarPagos
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.totalApostado = new System.Windows.Forms.Label();
            this.resC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btRepartir = new System.Windows.Forms.Button();
            this.partiCa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.partiVi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(202, 211);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 0;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // totalApostado
            // 
            this.totalApostado.AutoSize = true;
            this.totalApostado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalApostado.Location = new System.Drawing.Point(13, 13);
            this.totalApostado.Name = "totalApostado";
            this.totalApostado.Size = new System.Drawing.Size(175, 24);
            this.totalApostado.TabIndex = 1;
            this.totalApostado.Text = "Total de apuestas";
            // 
            // resC
            // 
            this.resC.Location = new System.Drawing.Point(140, 136);
            this.resC.Name = "resC";
            this.resC.Size = new System.Drawing.Size(48, 20);
            this.resC.TabIndex = 2;
            this.resC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resC_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "vs";
            // 
            // resV
            // 
            this.resV.Location = new System.Drawing.Point(218, 136);
            this.resV.Name = "resV";
            this.resV.Size = new System.Drawing.Size(48, 20);
            this.resV.TabIndex = 4;
            this.resV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resV_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultado";
            // 
            // btRepartir
            // 
            this.btRepartir.BackColor = System.Drawing.Color.White;
            this.btRepartir.Location = new System.Drawing.Point(121, 211);
            this.btRepartir.Name = "btRepartir";
            this.btRepartir.Size = new System.Drawing.Size(75, 23);
            this.btRepartir.TabIndex = 6;
            this.btRepartir.Text = "Repartir coins";
            this.btRepartir.UseVisualStyleBackColor = false;
            this.btRepartir.Click += new System.EventHandler(this.btRepartir_Click);
            // 
            // partiCa
            // 
            this.partiCa.AutoSize = true;
            this.partiCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partiCa.Location = new System.Drawing.Point(13, 61);
            this.partiCa.Name = "partiCa";
            this.partiCa.Size = new System.Drawing.Size(55, 17);
            this.partiCa.TabIndex = 7;
            this.partiCa.Text = "partiVi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "vs";
            // 
            // partiVi
            // 
            this.partiVi.AutoSize = true;
            this.partiVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partiVi.Location = new System.Drawing.Point(12, 91);
            this.partiVi.Name = "partiVi";
            this.partiVi.Size = new System.Drawing.Size(55, 17);
            this.partiVi.TabIndex = 9;
            this.partiVi.Text = "partiVi";
            // 
            // frmRealizarPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(289, 246);
            this.Controls.Add(this.partiVi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partiCa);
            this.Controls.Add(this.btRepartir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resC);
            this.Controls.Add(this.totalApostado);
            this.Controls.Add(this.btCancelar);
            this.Name = "frmRealizarPagos";
            this.Text = "Repartir coins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label totalApostado;
        private System.Windows.Forms.TextBox resC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRepartir;
        private System.Windows.Forms.Label partiCa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label partiVi;
    }
}