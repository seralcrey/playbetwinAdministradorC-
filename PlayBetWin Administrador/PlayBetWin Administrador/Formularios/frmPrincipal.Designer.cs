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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.pestanas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btAbrirDeporte = new System.Windows.Forms.Button();
            this.btAnadirDeporte = new System.Windows.Forms.Button();
            this.tablaDeportes = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btMasCompe = new System.Windows.Forms.Button();
            this.btMenosCompe = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkVerDesactivados = new System.Windows.Forms.CheckBox();
            this.checkTodos = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkMas = new System.Windows.Forms.CheckBox();
            this.checkSpo = new System.Windows.Forms.CheckBox();
            this.checkTen = new System.Windows.Forms.CheckBox();
            this.checkBal = new System.Windows.Forms.CheckBox();
            this.checkFut = new System.Windows.Forms.CheckBox();
            this.btAbrirCompeticion = new System.Windows.Forms.Button();
            this.btAnadirCompeticion = new System.Windows.Forms.Button();
            this.tablaCompeticion = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.toolStripSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tabParticipantes = new System.Windows.Forms.TabPage();
            this.tablaParticipante = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btAnadirParticipante = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.desactPart = new System.Windows.Forms.CheckBox();
            this.todosPart = new System.Windows.Forms.CheckBox();
            this.btBorrarParti = new System.Windows.Forms.Button();
            this.btBuscarParti = new System.Windows.Forms.Button();
            this.textIDPar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNompar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btMasPar = new System.Windows.Forms.CheckBox();
            this.btESPar = new System.Windows.Forms.CheckBox();
            this.btTePar = new System.Windows.Forms.CheckBox();
            this.btBaPar = new System.Windows.Forms.CheckBox();
            this.btFuPar = new System.Windows.Forms.CheckBox();
            this.btMasPart = new System.Windows.Forms.Button();
            this.btmenosPart = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.pestanas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompeticion)).BeginInit();
            this.menu.SuspendLayout();
            this.tabParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaParticipante)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(63)))), ((int)(((byte)(83)))));
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pestanas);
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
            // pestanas
            // 
            this.pestanas.Controls.Add(this.tabPage1);
            this.pestanas.Controls.Add(this.tabPage2);
            this.pestanas.Controls.Add(this.tabParticipantes);
            this.pestanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pestanas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pestanas.Location = new System.Drawing.Point(0, 0);
            this.pestanas.Name = "pestanas";
            this.pestanas.SelectedIndex = 0;
            this.pestanas.Size = new System.Drawing.Size(1025, 514);
            this.pestanas.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaDeportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaDeportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaDeportes.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.tabPage2.Controls.Add(this.btMasCompe);
            this.tabPage2.Controls.Add(this.btMenosCompe);
            this.tabPage2.Controls.Add(this.groupBox1);
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
            // btMasCompe
            // 
            this.btMasCompe.BackColor = System.Drawing.Color.White;
            this.btMasCompe.Location = new System.Drawing.Point(606, 461);
            this.btMasCompe.Name = "btMasCompe";
            this.btMasCompe.Size = new System.Drawing.Size(50, 23);
            this.btMasCompe.TabIndex = 7;
            this.btMasCompe.Text = ">";
            this.btMasCompe.UseVisualStyleBackColor = false;
            this.btMasCompe.Click += new System.EventHandler(this.btMasCompe_Click);
            // 
            // btMenosCompe
            // 
            this.btMenosCompe.BackColor = System.Drawing.Color.White;
            this.btMenosCompe.Location = new System.Drawing.Point(552, 461);
            this.btMenosCompe.Name = "btMenosCompe";
            this.btMenosCompe.Size = new System.Drawing.Size(50, 23);
            this.btMenosCompe.TabIndex = 6;
            this.btMenosCompe.Text = "<";
            this.btMenosCompe.UseVisualStyleBackColor = false;
            this.btMenosCompe.Click += new System.EventHandler(this.btMenosCompe_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkVerDesactivados);
            this.groupBox1.Controls.Add(this.checkTodos);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkMas);
            this.groupBox1.Controls.Add(this.checkSpo);
            this.groupBox1.Controls.Add(this.checkTen);
            this.groupBox1.Controls.Add(this.checkBal);
            this.groupBox1.Controls.Add(this.checkFut);
            this.groupBox1.Location = new System.Drawing.Point(552, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 235);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // checkVerDesactivados
            // 
            this.checkVerDesactivados.AutoSize = true;
            this.checkVerDesactivados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkVerDesactivados.Location = new System.Drawing.Point(163, 159);
            this.checkVerDesactivados.Name = "checkVerDesactivados";
            this.checkVerDesactivados.Size = new System.Drawing.Size(152, 21);
            this.checkVerDesactivados.TabIndex = 12;
            this.checkVerDesactivados.Text = "Ver desactivados";
            this.checkVerDesactivados.UseVisualStyleBackColor = true;
            // 
            // checkTodos
            // 
            this.checkTodos.AutoSize = true;
            this.checkTodos.Checked = true;
            this.checkTodos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTodos.Location = new System.Drawing.Point(25, 159);
            this.checkTodos.Name = "checkTodos";
            this.checkTodos.Size = new System.Drawing.Size(56, 17);
            this.checkTodos.TabIndex = 11;
            this.checkTodos.Text = "Todos";
            this.checkTodos.UseVisualStyleBackColor = true;
            this.checkTodos.CheckedChanged += new System.EventHandler(this.checkTodos_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(295, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Borrar busqueda";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(376, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(163, 112);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(288, 20);
            this.textID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(163, 43);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(288, 20);
            this.textNombre.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deportes";
            // 
            // checkMas
            // 
            this.checkMas.AutoSize = true;
            this.checkMas.Location = new System.Drawing.Point(25, 135);
            this.checkMas.Name = "checkMas";
            this.checkMas.Size = new System.Drawing.Size(90, 17);
            this.checkMas.TabIndex = 4;
            this.checkMas.Text = "Mas deportes";
            this.checkMas.UseVisualStyleBackColor = true;
            this.checkMas.CheckedChanged += new System.EventHandler(this.marcadoCompeticion);
            // 
            // checkSpo
            // 
            this.checkSpo.AutoSize = true;
            this.checkSpo.Location = new System.Drawing.Point(25, 112);
            this.checkSpo.Name = "checkSpo";
            this.checkSpo.Size = new System.Drawing.Size(59, 17);
            this.checkSpo.TabIndex = 3;
            this.checkSpo.Text = "E-sport";
            this.checkSpo.UseVisualStyleBackColor = true;
            this.checkSpo.CheckedChanged += new System.EventHandler(this.marcadoCompeticion);
            // 
            // checkTen
            // 
            this.checkTen.AutoSize = true;
            this.checkTen.Location = new System.Drawing.Point(25, 89);
            this.checkTen.Name = "checkTen";
            this.checkTen.Size = new System.Drawing.Size(52, 17);
            this.checkTen.TabIndex = 2;
            this.checkTen.Text = "Tenis";
            this.checkTen.UseVisualStyleBackColor = true;
            this.checkTen.CheckedChanged += new System.EventHandler(this.marcadoCompeticion);
            // 
            // checkBal
            // 
            this.checkBal.AutoSize = true;
            this.checkBal.Location = new System.Drawing.Point(25, 66);
            this.checkBal.Name = "checkBal";
            this.checkBal.Size = new System.Drawing.Size(79, 17);
            this.checkBal.TabIndex = 1;
            this.checkBal.Text = "Baloncesto";
            this.checkBal.UseVisualStyleBackColor = true;
            this.checkBal.CheckedChanged += new System.EventHandler(this.marcadoCompeticion);
            // 
            // checkFut
            // 
            this.checkFut.AutoSize = true;
            this.checkFut.Location = new System.Drawing.Point(25, 43);
            this.checkFut.Name = "checkFut";
            this.checkFut.Size = new System.Drawing.Size(55, 17);
            this.checkFut.TabIndex = 0;
            this.checkFut.Text = "Fútbol";
            this.checkFut.UseVisualStyleBackColor = true;
            this.checkFut.CheckedChanged += new System.EventHandler(this.marcadoCompeticion);
            // 
            // btAbrirCompeticion
            // 
            this.btAbrirCompeticion.BackColor = System.Drawing.Color.White;
            this.btAbrirCompeticion.Location = new System.Drawing.Point(553, 36);
            this.btAbrirCompeticion.Name = "btAbrirCompeticion";
            this.btAbrirCompeticion.Size = new System.Drawing.Size(456, 23);
            this.btAbrirCompeticion.TabIndex = 4;
            this.btAbrirCompeticion.Text = "Abrir competición selecionada";
            this.btAbrirCompeticion.UseVisualStyleBackColor = false;
            this.btAbrirCompeticion.Click += new System.EventHandler(this.btAbrirCompeticion_Click);
            // 
            // btAnadirCompeticion
            // 
            this.btAnadirCompeticion.BackColor = System.Drawing.Color.White;
            this.btAnadirCompeticion.Location = new System.Drawing.Point(552, 6);
            this.btAnadirCompeticion.Name = "btAnadirCompeticion";
            this.btAnadirCompeticion.Size = new System.Drawing.Size(457, 23);
            this.btAnadirCompeticion.TabIndex = 3;
            this.btAnadirCompeticion.Text = "Añadir competición";
            this.btAnadirCompeticion.UseVisualStyleBackColor = false;
            this.btAnadirCompeticion.Click += new System.EventHandler(this.btAnadirCompeticion_Click);
            // 
            // tablaCompeticion
            // 
            this.tablaCompeticion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCompeticion.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCompeticion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCompeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCompeticion.DefaultCellStyle = dataGridViewCellStyle4;
            this.tablaCompeticion.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaCompeticion.Location = new System.Drawing.Point(3, 3);
            this.tablaCompeticion.Name = "tablaCompeticion";
            this.tablaCompeticion.Size = new System.Drawing.Size(543, 482);
            this.tablaCompeticion.TabIndex = 0;
            this.tablaCompeticion.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tablaCompeticion_CellMouseDoubleClick);
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
            // tabParticipantes
            // 
            this.tabParticipantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(164)))), ((int)(((byte)(216)))));
            this.tabParticipantes.Controls.Add(this.btMasPart);
            this.tabParticipantes.Controls.Add(this.btmenosPart);
            this.tabParticipantes.Controls.Add(this.groupBox2);
            this.tabParticipantes.Controls.Add(this.button3);
            this.tabParticipantes.Controls.Add(this.btAnadirParticipante);
            this.tabParticipantes.Controls.Add(this.tablaParticipante);
            this.tabParticipantes.Location = new System.Drawing.Point(4, 22);
            this.tabParticipantes.Name = "tabParticipantes";
            this.tabParticipantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabParticipantes.Size = new System.Drawing.Size(1017, 488);
            this.tabParticipantes.TabIndex = 2;
            this.tabParticipantes.Text = "Participante";
            // 
            // tablaParticipante
            // 
            this.tablaParticipante.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaParticipante.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaParticipante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaParticipante.DefaultCellStyle = dataGridViewCellStyle6;
            this.tablaParticipante.Dock = System.Windows.Forms.DockStyle.Left;
            this.tablaParticipante.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.tablaParticipante.Location = new System.Drawing.Point(3, 3);
            this.tablaParticipante.Name = "tablaParticipante";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaParticipante.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.tablaParticipante.Size = new System.Drawing.Size(543, 482);
            this.tablaParticipante.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(553, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Abrir participante selecionada";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btAnadirParticipante
            // 
            this.btAnadirParticipante.BackColor = System.Drawing.Color.White;
            this.btAnadirParticipante.Location = new System.Drawing.Point(552, 6);
            this.btAnadirParticipante.Name = "btAnadirParticipante";
            this.btAnadirParticipante.Size = new System.Drawing.Size(457, 23);
            this.btAnadirParticipante.TabIndex = 5;
            this.btAnadirParticipante.Text = "Añadir participante";
            this.btAnadirParticipante.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.desactPart);
            this.groupBox2.Controls.Add(this.todosPart);
            this.groupBox2.Controls.Add(this.btBorrarParti);
            this.groupBox2.Controls.Add(this.btBuscarParti);
            this.groupBox2.Controls.Add(this.textIDPar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textNompar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btMasPar);
            this.groupBox2.Controls.Add(this.btESPar);
            this.groupBox2.Controls.Add(this.btTePar);
            this.groupBox2.Controls.Add(this.btBaPar);
            this.groupBox2.Controls.Add(this.btFuPar);
            this.groupBox2.Location = new System.Drawing.Point(552, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 235);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // desactPart
            // 
            this.desactPart.AutoSize = true;
            this.desactPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desactPart.Location = new System.Drawing.Point(163, 159);
            this.desactPart.Name = "desactPart";
            this.desactPart.Size = new System.Drawing.Size(152, 21);
            this.desactPart.TabIndex = 12;
            this.desactPart.Text = "Ver desactivados";
            this.desactPart.UseVisualStyleBackColor = true;
            // 
            // todosPart
            // 
            this.todosPart.AutoSize = true;
            this.todosPart.Checked = true;
            this.todosPart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.todosPart.Location = new System.Drawing.Point(25, 159);
            this.todosPart.Name = "todosPart";
            this.todosPart.Size = new System.Drawing.Size(56, 17);
            this.todosPart.TabIndex = 11;
            this.todosPart.Text = "Todos";
            this.todosPart.UseVisualStyleBackColor = true;
            // 
            // btBorrarParti
            // 
            this.btBorrarParti.BackColor = System.Drawing.Color.White;
            this.btBorrarParti.Location = new System.Drawing.Point(295, 206);
            this.btBorrarParti.Name = "btBorrarParti";
            this.btBorrarParti.Size = new System.Drawing.Size(75, 23);
            this.btBorrarParti.TabIndex = 10;
            this.btBorrarParti.Text = "Borrar busqueda";
            this.btBorrarParti.UseVisualStyleBackColor = false;
            // 
            // btBuscarParti
            // 
            this.btBuscarParti.BackColor = System.Drawing.Color.White;
            this.btBuscarParti.Location = new System.Drawing.Point(376, 206);
            this.btBuscarParti.Name = "btBuscarParti";
            this.btBuscarParti.Size = new System.Drawing.Size(75, 23);
            this.btBuscarParti.TabIndex = 6;
            this.btBuscarParti.Text = "Buscar";
            this.btBuscarParti.UseVisualStyleBackColor = false;
            // 
            // textIDPar
            // 
            this.textIDPar.Location = new System.Drawing.Point(163, 112);
            this.textIDPar.Name = "textIDPar";
            this.textIDPar.Size = new System.Drawing.Size(288, 20);
            this.textIDPar.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(159, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "ID";
            // 
            // textNompar
            // 
            this.textNompar.Location = new System.Drawing.Point(163, 43);
            this.textNompar.Name = "textNompar";
            this.textNompar.Size = new System.Drawing.Size(288, 20);
            this.textNompar.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deportes";
            // 
            // btMasPar
            // 
            this.btMasPar.AutoSize = true;
            this.btMasPar.Location = new System.Drawing.Point(25, 135);
            this.btMasPar.Name = "btMasPar";
            this.btMasPar.Size = new System.Drawing.Size(90, 17);
            this.btMasPar.TabIndex = 4;
            this.btMasPar.Text = "Mas deportes";
            this.btMasPar.UseVisualStyleBackColor = true;
            // 
            // btESPar
            // 
            this.btESPar.AutoSize = true;
            this.btESPar.Location = new System.Drawing.Point(25, 112);
            this.btESPar.Name = "btESPar";
            this.btESPar.Size = new System.Drawing.Size(59, 17);
            this.btESPar.TabIndex = 3;
            this.btESPar.Text = "E-sport";
            this.btESPar.UseVisualStyleBackColor = true;
            // 
            // btTePar
            // 
            this.btTePar.AutoSize = true;
            this.btTePar.Location = new System.Drawing.Point(25, 89);
            this.btTePar.Name = "btTePar";
            this.btTePar.Size = new System.Drawing.Size(52, 17);
            this.btTePar.TabIndex = 2;
            this.btTePar.Text = "Tenis";
            this.btTePar.UseVisualStyleBackColor = true;
            // 
            // btBaPar
            // 
            this.btBaPar.AutoSize = true;
            this.btBaPar.Location = new System.Drawing.Point(25, 66);
            this.btBaPar.Name = "btBaPar";
            this.btBaPar.Size = new System.Drawing.Size(79, 17);
            this.btBaPar.TabIndex = 1;
            this.btBaPar.Text = "Baloncesto";
            this.btBaPar.UseVisualStyleBackColor = true;
            // 
            // btFuPar
            // 
            this.btFuPar.AutoSize = true;
            this.btFuPar.Location = new System.Drawing.Point(25, 43);
            this.btFuPar.Name = "btFuPar";
            this.btFuPar.Size = new System.Drawing.Size(55, 17);
            this.btFuPar.TabIndex = 0;
            this.btFuPar.Text = "Fútbol";
            this.btFuPar.UseVisualStyleBackColor = true;
            // 
            // btMasPart
            // 
            this.btMasPart.BackColor = System.Drawing.Color.White;
            this.btMasPart.Location = new System.Drawing.Point(606, 457);
            this.btMasPart.Name = "btMasPart";
            this.btMasPart.Size = new System.Drawing.Size(50, 23);
            this.btMasPart.TabIndex = 9;
            this.btMasPart.Text = ">";
            this.btMasPart.UseVisualStyleBackColor = false;
            // 
            // btmenosPart
            // 
            this.btmenosPart.BackColor = System.Drawing.Color.White;
            this.btmenosPart.Location = new System.Drawing.Point(552, 457);
            this.btmenosPart.Name = "btmenosPart";
            this.btmenosPart.Size = new System.Drawing.Size(50, 23);
            this.btmenosPart.TabIndex = 8;
            this.btmenosPart.Text = "<";
            this.btmenosPart.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1025, 538);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.pestanas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaDeportes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCompeticion)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tabParticipantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaParticipante)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl pestanas;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkMas;
        private System.Windows.Forms.CheckBox checkSpo;
        private System.Windows.Forms.CheckBox checkTen;
        private System.Windows.Forms.CheckBox checkBal;
        private System.Windows.Forms.CheckBox checkFut;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkTodos;
        private System.Windows.Forms.CheckBox checkVerDesactivados;
        private System.Windows.Forms.Button btMasCompe;
        private System.Windows.Forms.Button btMenosCompe;
        private System.Windows.Forms.TabPage tabParticipantes;
        private System.Windows.Forms.DataGridView tablaParticipante;
        private System.Windows.Forms.Button btMasPart;
        private System.Windows.Forms.Button btmenosPart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox desactPart;
        private System.Windows.Forms.CheckBox todosPart;
        private System.Windows.Forms.Button btBorrarParti;
        private System.Windows.Forms.Button btBuscarParti;
        private System.Windows.Forms.TextBox textIDPar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNompar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox btMasPar;
        private System.Windows.Forms.CheckBox btESPar;
        private System.Windows.Forms.CheckBox btTePar;
        private System.Windows.Forms.CheckBox btBaPar;
        private System.Windows.Forms.CheckBox btFuPar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btAnadirParticipante;
    }
}