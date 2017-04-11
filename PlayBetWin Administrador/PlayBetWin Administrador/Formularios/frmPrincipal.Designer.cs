namespace PlayBetWin_Administrador
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btAbrirDeporte = new System.Windows.Forms.Button();
            this.btAnadirDeporte = new System.Windows.Forms.Button();
            this.tablaDeportes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btAbrirCompeticion = new System.Windows.Forms.Button();
            this.btAnadirCompeticion = new System.Windows.Forms.Button();
            this.tablaCompeticion = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompeticion)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1025, 514);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1025, 538);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 514);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.tabPage1.Controls.Add(this.btAbrirDeporte);
            this.tabPage1.Controls.Add(this.btAnadirDeporte);
            this.tabPage1.Controls.Add(this.tablaDeportes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Deportes";
            // 
            // btAbrirDeporte
            // 
            this.btAbrirDeporte.BackColor = System.Drawing.Color.White;
            this.btAbrirDeporte.Location = new System.Drawing.Point(553, 36);
            this.btAbrirDeporte.Name = "btAbrirDeporte";
            this.btAbrirDeporte.Size = new System.Drawing.Size(456, 23);
            this.btAbrirDeporte.TabIndex = 2;
            this.btAbrirDeporte.Text = "Abrir deporte selecionado";
            this.btAbrirDeporte.UseVisualStyleBackColor = false;
            this.btAbrirDeporte.Click += new System.EventHandler(this.btAbrirDeporte_Click);
            // 
            // btAnadirDeporte
            // 
            this.btAnadirDeporte.BackColor = System.Drawing.Color.White;
            this.btAnadirDeporte.Location = new System.Drawing.Point(552, 6);
            this.btAnadirDeporte.Name = "btAnadirDeporte";
            this.btAnadirDeporte.Size = new System.Drawing.Size(457, 23);
            this.btAnadirDeporte.TabIndex = 1;
            this.btAnadirDeporte.Text = "Añadir deporte";
            this.btAnadirDeporte.UseVisualStyleBackColor = false;
            this.btAnadirDeporte.Click += new System.EventHandler(this.btAnadirDeporte_Click);
            // 
            // tablaDeportes
            // 
            this.tablaDeportes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaDeportes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDeportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tablaDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDeportes.DefaultCellStyle = dataGridViewCellStyle10;
            this.tablaDeportes.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaDeportes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tablaDeportes.Location = new System.Drawing.Point(3, 3);
            this.tablaDeportes.Name = "tablaDeportes";
            this.tablaDeportes.Size = new System.Drawing.Size(543, 482);
            this.tablaDeportes.TabIndex = 0;
            this.tablaDeportes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaDeportes_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.tabPage2.Controls.Add(this.btAbrirCompeticion);
            this.tabPage2.Controls.Add(this.btAnadirCompeticion);
            this.tabPage2.Controls.Add(this.tablaCompeticion);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Competición";
            // 
            // btAbrirCompeticion
            // 
            this.btAbrirCompeticion.Location = new System.Drawing.Point(553, 36);
            this.btAbrirCompeticion.Name = "btAbrirCompeticion";
            this.btAbrirCompeticion.Size = new System.Drawing.Size(456, 23);
            this.btAbrirCompeticion.TabIndex = 4;
            this.btAbrirCompeticion.Text = "Abrir competición selecionada";
            this.btAbrirCompeticion.UseVisualStyleBackColor = true;
            // 
            // btAnadirCompeticion
            // 
            this.btAnadirCompeticion.Location = new System.Drawing.Point(552, 6);
            this.btAnadirCompeticion.Name = "btAnadirCompeticion";
            this.btAnadirCompeticion.Size = new System.Drawing.Size(457, 23);
            this.btAnadirCompeticion.TabIndex = 3;
            this.btAnadirCompeticion.Text = "Añadir competición";
            this.btAnadirCompeticion.UseVisualStyleBackColor = true;
            this.btAnadirCompeticion.Click += new System.EventHandler(this.btAnadirCompeticion_Click);
            // 
            // tablaCompeticion
            // 
            this.tablaCompeticion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCompeticion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tablaCompeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCompeticion.DefaultCellStyle = dataGridViewCellStyle12;
            this.tablaCompeticion.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaCompeticion.Location = new System.Drawing.Point(3, 3);
            this.tablaCompeticion.Name = "tablaCompeticion";
            this.tablaCompeticion.Size = new System.Drawing.Size(543, 482);
            this.tablaCompeticion.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalir});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1025, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // toolStripSalir
            // 
            this.toolStripSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripSalir.Name = "toolStripSalir";
            this.toolStripSalir.Size = new System.Drawing.Size(43, 20);
            this.toolStripSalir.Text = "Salir";
            this.toolStripSalir.Click += new System.EventHandler(this.toolStripSalir_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 538);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompeticion)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripSalir;
        private System.Windows.Forms.DataGridView tablaDeportes;
        private System.Windows.Forms.Button btAbrirCompeticion;
        private System.Windows.Forms.Button btAnadirCompeticion;
        private System.Windows.Forms.DataGridView tablaCompeticion;
        private System.Windows.Forms.Button btAbrirDeporte;
        private System.Windows.Forms.Button btAnadirDeporte;
    }
}