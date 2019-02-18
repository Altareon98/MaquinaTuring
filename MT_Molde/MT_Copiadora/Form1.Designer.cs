namespace MT_Copiadora
{
	partial class Main
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.grpMT = new System.Windows.Forms.GroupBox();
            this.grpCabezal = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numCabezal = new System.Windows.Forms.NumericUpDown();
            this.grpEntrada = new System.Windows.Forms.GroupBox();
            this.btnAleatoria = new System.Windows.Forms.Button();
            this.txtCinta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpCinta = new System.Windows.Forms.GroupBox();
            this.chkCEspecial3 = new System.Windows.Forms.CheckBox();
            this.chkCEspecial2 = new System.Windows.Forms.CheckBox();
            this.chkCEspecial1 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgCinta = new System.Windows.Forms.DataGridView();
            this.tabCreadorInstruccion = new System.Windows.Forms.TabControl();
            this.tabMovimiento = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.radDerechaM = new System.Windows.Forms.RadioButton();
            this.radIzquierdaM = new System.Windows.Forms.RadioButton();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.tabAlmacenamiento = new System.Windows.Forms.TabPage();
            this.btnAgregarA = new System.Windows.Forms.Button();
            this.tabEscritura = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEscritura = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.radDerechaB = new System.Windows.Forms.RadioButton();
            this.radIzquierdaB = new System.Windows.Forms.RadioButton();
            this.cmbBusqueda = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgregarB = new System.Windows.Forms.Button();
            this.tabIrA = new System.Windows.Forms.TabPage();
            this.txtCaracteresIrA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numPaso = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAgregarI = new System.Windows.Forms.Button();
            this.lstInstrucciones = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.chkDiferenteB = new System.Windows.Forms.CheckBox();
            this.tmrEjecucion = new System.Windows.Forms.Timer(this.components);
            this.grpMT.SuspendLayout();
            this.grpCabezal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCabezal)).BeginInit();
            this.grpEntrada.SuspendLayout();
            this.grpCinta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCinta)).BeginInit();
            this.tabCreadorInstruccion.SuspendLayout();
            this.tabMovimiento.SuspendLayout();
            this.tabAlmacenamiento.SuspendLayout();
            this.tabEscritura.SuspendLayout();
            this.tabBusqueda.SuspendLayout();
            this.tabIrA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaso)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMT
            // 
            this.grpMT.Controls.Add(this.grpCabezal);
            this.grpMT.Controls.Add(this.grpEntrada);
            this.grpMT.Controls.Add(this.btnNuevo);
            this.grpMT.Controls.Add(this.btnAceptar);
            this.grpMT.Controls.Add(this.grpCinta);
            this.grpMT.Location = new System.Drawing.Point(12, 58);
            this.grpMT.Name = "grpMT";
            this.grpMT.Size = new System.Drawing.Size(560, 115);
            this.grpMT.TabIndex = 0;
            this.grpMT.TabStop = false;
            this.grpMT.Text = "Máquina de Turing";
            // 
            // grpCabezal
            // 
            this.grpCabezal.Controls.Add(this.label7);
            this.grpCabezal.Controls.Add(this.numCabezal);
            this.grpCabezal.Location = new System.Drawing.Point(468, 19);
            this.grpCabezal.Name = "grpCabezal";
            this.grpCabezal.Size = new System.Drawing.Size(86, 62);
            this.grpCabezal.TabIndex = 10;
            this.grpCabezal.TabStop = false;
            this.grpCabezal.Text = "Cabezal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Posición:";
            // 
            // numCabezal
            // 
            this.numCabezal.Location = new System.Drawing.Point(27, 32);
            this.numCabezal.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numCabezal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCabezal.Name = "numCabezal";
            this.numCabezal.ReadOnly = true;
            this.numCabezal.Size = new System.Drawing.Size(32, 20);
            this.numCabezal.TabIndex = 1;
            this.numCabezal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCabezal.ValueChanged += new System.EventHandler(this.numCabezal_ValueChanged);
            // 
            // grpEntrada
            // 
            this.grpEntrada.Controls.Add(this.btnAleatoria);
            this.grpEntrada.Controls.Add(this.txtCinta);
            this.grpEntrada.Controls.Add(this.label11);
            this.grpEntrada.Controls.Add(this.label9);
            this.grpEntrada.Controls.Add(this.txtEntrada);
            this.grpEntrada.Controls.Add(this.label10);
            this.grpEntrada.Location = new System.Drawing.Point(192, 19);
            this.grpEntrada.Name = "grpEntrada";
            this.grpEntrada.Size = new System.Drawing.Size(270, 90);
            this.grpEntrada.TabIndex = 9;
            this.grpEntrada.TabStop = false;
            this.grpEntrada.Text = "Cadena de Entrada";
            // 
            // btnAleatoria
            // 
            this.btnAleatoria.Location = new System.Drawing.Point(193, 66);
            this.btnAleatoria.Name = "btnAleatoria";
            this.btnAleatoria.Size = new System.Drawing.Size(57, 20);
            this.btnAleatoria.TabIndex = 12;
            this.btnAleatoria.Text = "Aleatoria";
            this.btnAleatoria.UseVisualStyleBackColor = true;
            this.btnAleatoria.Click += new System.EventHandler(this.btnAleatoria_Click);
            // 
            // txtCinta
            // 
            this.txtCinta.Location = new System.Drawing.Point(70, 19);
            this.txtCinta.Name = "txtCinta";
            this.txtCinta.ReadOnly = true;
            this.txtCinta.Size = new System.Drawing.Size(180, 20);
            this.txtCinta.TabIndex = 11;
            this.txtCinta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Entrada =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Γ = {";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(70, 45);
            this.txtEntrada.MaxLength = 25;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(180, 20);
            this.txtEntrada.TabIndex = 13;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEntrada.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEntrada_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(256, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "}";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(504, 87);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(50, 22);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(468, 87);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(30, 22);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Ok";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpCinta
            // 
            this.grpCinta.Controls.Add(this.chkCEspecial3);
            this.grpCinta.Controls.Add(this.chkCEspecial2);
            this.grpCinta.Controls.Add(this.chkCEspecial1);
            this.grpCinta.Controls.Add(this.label8);
            this.grpCinta.Controls.Add(this.txtAlfabeto);
            this.grpCinta.Controls.Add(this.label1);
            this.grpCinta.Controls.Add(this.label3);
            this.grpCinta.Controls.Add(this.label2);
            this.grpCinta.Location = new System.Drawing.Point(6, 19);
            this.grpCinta.Name = "grpCinta";
            this.grpCinta.Size = new System.Drawing.Size(180, 90);
            this.grpCinta.TabIndex = 0;
            this.grpCinta.TabStop = false;
            this.grpCinta.Text = "Γ = { Σ + _ + Especiales }";
            // 
            // chkCEspecial3
            // 
            this.chkCEspecial3.AutoSize = true;
            this.chkCEspecial3.Location = new System.Drawing.Point(143, 66);
            this.chkCEspecial3.Name = "chkCEspecial3";
            this.chkCEspecial3.Size = new System.Drawing.Size(32, 17);
            this.chkCEspecial3.TabIndex = 8;
            this.chkCEspecial3.Text = "$";
            this.chkCEspecial3.UseVisualStyleBackColor = true;
            this.chkCEspecial3.CheckedChanged += new System.EventHandler(this.chkCEspecial3_CheckedChanged);
            // 
            // chkCEspecial2
            // 
            this.chkCEspecial2.AutoSize = true;
            this.chkCEspecial2.Location = new System.Drawing.Point(104, 66);
            this.chkCEspecial2.Name = "chkCEspecial2";
            this.chkCEspecial2.Size = new System.Drawing.Size(33, 17);
            this.chkCEspecial2.TabIndex = 7;
            this.chkCEspecial2.Text = "#";
            this.chkCEspecial2.UseVisualStyleBackColor = true;
            this.chkCEspecial2.CheckedChanged += new System.EventHandler(this.chkCEspecial2_CheckedChanged);
            // 
            // chkCEspecial1
            // 
            this.chkCEspecial1.AutoSize = true;
            this.chkCEspecial1.Location = new System.Drawing.Point(68, 66);
            this.chkCEspecial1.Name = "chkCEspecial1";
            this.chkCEspecial1.Size = new System.Drawing.Size(30, 17);
            this.chkCEspecial1.TabIndex = 6;
            this.chkCEspecial1.Text = "*";
            this.chkCEspecial1.UseVisualStyleBackColor = true;
            this.chkCEspecial1.CheckedChanged += new System.EventHandler(this.chkCEspecial1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "}";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(75, 19);
            this.txtAlfabeto.MaxLength = 10;
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(75, 20);
            this.txtAlfabeto.TabIndex = 3;
            this.txtAlfabeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAlfabeto.TextChanged += new System.EventHandler(this.txtAlfabeto_TextChanged);
            this.txtAlfabeto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlfabeto_KeyDown);
            this.txtAlfabeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlfabeto_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Σ = {";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Especial =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blanco = _";
            // 
            // dtgCinta
            // 
            this.dtgCinta.AllowUserToAddRows = false;
            this.dtgCinta.AllowUserToDeleteRows = false;
            this.dtgCinta.AllowUserToResizeColumns = false;
            this.dtgCinta.AllowUserToResizeRows = false;
            this.dtgCinta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgCinta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCinta.ColumnHeadersVisible = false;
            this.dtgCinta.Location = new System.Drawing.Point(12, 12);
            this.dtgCinta.MultiSelect = false;
            this.dtgCinta.Name = "dtgCinta";
            this.dtgCinta.ReadOnly = true;
            this.dtgCinta.RowHeadersVisible = false;
            this.dtgCinta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dtgCinta.Size = new System.Drawing.Size(560, 40);
            this.dtgCinta.TabIndex = 2;
            // 
            // tabCreadorInstruccion
            // 
            this.tabCreadorInstruccion.Controls.Add(this.tabMovimiento);
            this.tabCreadorInstruccion.Controls.Add(this.tabAlmacenamiento);
            this.tabCreadorInstruccion.Controls.Add(this.tabEscritura);
            this.tabCreadorInstruccion.Controls.Add(this.tabBusqueda);
            this.tabCreadorInstruccion.Controls.Add(this.tabIrA);
            this.tabCreadorInstruccion.Location = new System.Drawing.Point(12, 179);
            this.tabCreadorInstruccion.Name = "tabCreadorInstruccion";
            this.tabCreadorInstruccion.SelectedIndex = 0;
            this.tabCreadorInstruccion.Size = new System.Drawing.Size(290, 135);
            this.tabCreadorInstruccion.TabIndex = 3;
            // 
            // tabMovimiento
            // 
            this.tabMovimiento.Controls.Add(this.label6);
            this.tabMovimiento.Controls.Add(this.radDerechaM);
            this.tabMovimiento.Controls.Add(this.radIzquierdaM);
            this.tabMovimiento.Controls.Add(this.btnAgregarM);
            this.tabMovimiento.Location = new System.Drawing.Point(4, 22);
            this.tabMovimiento.Name = "tabMovimiento";
            this.tabMovimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabMovimiento.Size = new System.Drawing.Size(282, 109);
            this.tabMovimiento.TabIndex = 0;
            this.tabMovimiento.Text = "Movimiento";
            this.tabMovimiento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hacia la..";
            // 
            // radDerechaM
            // 
            this.radDerechaM.AutoSize = true;
            this.radDerechaM.Checked = true;
            this.radDerechaM.Location = new System.Drawing.Point(6, 19);
            this.radDerechaM.Name = "radDerechaM";
            this.radDerechaM.Size = new System.Drawing.Size(66, 17);
            this.radDerechaM.TabIndex = 2;
            this.radDerechaM.TabStop = true;
            this.radDerechaM.Text = "Derecha";
            this.radDerechaM.UseVisualStyleBackColor = true;
            // 
            // radIzquierdaM
            // 
            this.radIzquierdaM.AutoSize = true;
            this.radIzquierdaM.Location = new System.Drawing.Point(6, 42);
            this.radIzquierdaM.Name = "radIzquierdaM";
            this.radIzquierdaM.Size = new System.Drawing.Size(68, 17);
            this.radIzquierdaM.TabIndex = 1;
            this.radIzquierdaM.Text = "Izquierda";
            this.radIzquierdaM.UseVisualStyleBackColor = true;
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Location = new System.Drawing.Point(220, 81);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(56, 22);
            this.btnAgregarM.TabIndex = 0;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // tabAlmacenamiento
            // 
            this.tabAlmacenamiento.Controls.Add(this.btnAgregarA);
            this.tabAlmacenamiento.Location = new System.Drawing.Point(4, 22);
            this.tabAlmacenamiento.Name = "tabAlmacenamiento";
            this.tabAlmacenamiento.Size = new System.Drawing.Size(282, 109);
            this.tabAlmacenamiento.TabIndex = 4;
            this.tabAlmacenamiento.Text = "Almacenamiento";
            this.tabAlmacenamiento.UseVisualStyleBackColor = true;
            // 
            // btnAgregarA
            // 
            this.btnAgregarA.Location = new System.Drawing.Point(220, 81);
            this.btnAgregarA.Name = "btnAgregarA";
            this.btnAgregarA.Size = new System.Drawing.Size(56, 22);
            this.btnAgregarA.TabIndex = 1;
            this.btnAgregarA.Text = "Agregar";
            this.btnAgregarA.UseVisualStyleBackColor = true;
            this.btnAgregarA.Click += new System.EventHandler(this.btnAgregarA_Click);
            // 
            // tabEscritura
            // 
            this.tabEscritura.Controls.Add(this.label4);
            this.tabEscritura.Controls.Add(this.cmbEscritura);
            this.tabEscritura.Controls.Add(this.label5);
            this.tabEscritura.Controls.Add(this.btnAgregarE);
            this.tabEscritura.Location = new System.Drawing.Point(4, 22);
            this.tabEscritura.Name = "tabEscritura";
            this.tabEscritura.Padding = new System.Windows.Forms.Padding(3);
            this.tabEscritura.Size = new System.Drawing.Size(282, 109);
            this.tabEscritura.TabIndex = 1;
            this.tabEscritura.Text = "Escritura";
            this.tabEscritura.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Variable = { ? }";
            // 
            // cmbEscritura
            // 
            this.cmbEscritura.FormattingEnabled = true;
            this.cmbEscritura.Location = new System.Drawing.Point(61, 6);
            this.cmbEscritura.Name = "cmbEscritura";
            this.cmbEscritura.Size = new System.Drawing.Size(33, 21);
            this.cmbEscritura.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Símbolo:";
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Location = new System.Drawing.Point(220, 81);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(56, 22);
            this.btnAgregarE.TabIndex = 1;
            this.btnAgregarE.Text = "Agregar";
            this.btnAgregarE.UseVisualStyleBackColor = true;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.chkDiferenteB);
            this.tabBusqueda.Controls.Add(this.radDerechaB);
            this.tabBusqueda.Controls.Add(this.radIzquierdaB);
            this.tabBusqueda.Controls.Add(this.cmbBusqueda);
            this.tabBusqueda.Controls.Add(this.label13);
            this.tabBusqueda.Controls.Add(this.label12);
            this.tabBusqueda.Controls.Add(this.btnAgregarB);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Size = new System.Drawing.Size(282, 109);
            this.tabBusqueda.TabIndex = 2;
            this.tabBusqueda.Text = "Búsqueda";
            this.tabBusqueda.UseVisualStyleBackColor = true;
            // 
            // radDerechaB
            // 
            this.radDerechaB.AutoSize = true;
            this.radDerechaB.Checked = true;
            this.radDerechaB.Location = new System.Drawing.Point(6, 19);
            this.radDerechaB.Name = "radDerechaB";
            this.radDerechaB.Size = new System.Drawing.Size(66, 17);
            this.radDerechaB.TabIndex = 10;
            this.radDerechaB.TabStop = true;
            this.radDerechaB.Text = "Derecha";
            this.radDerechaB.UseVisualStyleBackColor = true;
            // 
            // radIzquierdaB
            // 
            this.radIzquierdaB.AutoSize = true;
            this.radIzquierdaB.Location = new System.Drawing.Point(6, 42);
            this.radIzquierdaB.Name = "radIzquierdaB";
            this.radIzquierdaB.Size = new System.Drawing.Size(68, 17);
            this.radIzquierdaB.TabIndex = 9;
            this.radIzquierdaB.Text = "Izquierda";
            this.radIzquierdaB.UseVisualStyleBackColor = true;
            // 
            // cmbBusqueda
            // 
            this.cmbBusqueda.FormattingEnabled = true;
            this.cmbBusqueda.Location = new System.Drawing.Point(136, 3);
            this.cmbBusqueda.Name = "cmbBusqueda";
            this.cmbBusqueda.Size = new System.Drawing.Size(33, 21);
            this.cmbBusqueda.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Símbolo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Hacia la..";
            // 
            // btnAgregarB
            // 
            this.btnAgregarB.Location = new System.Drawing.Point(220, 81);
            this.btnAgregarB.Name = "btnAgregarB";
            this.btnAgregarB.Size = new System.Drawing.Size(56, 22);
            this.btnAgregarB.TabIndex = 2;
            this.btnAgregarB.Text = "Agregar";
            this.btnAgregarB.UseVisualStyleBackColor = true;
            this.btnAgregarB.Click += new System.EventHandler(this.btnAgregarB_Click);
            // 
            // tabIrA
            // 
            this.tabIrA.Controls.Add(this.txtCaracteresIrA);
            this.tabIrA.Controls.Add(this.label15);
            this.tabIrA.Controls.Add(this.numPaso);
            this.tabIrA.Controls.Add(this.label14);
            this.tabIrA.Controls.Add(this.btnAgregarI);
            this.tabIrA.Location = new System.Drawing.Point(4, 22);
            this.tabIrA.Name = "tabIrA";
            this.tabIrA.Size = new System.Drawing.Size(282, 109);
            this.tabIrA.TabIndex = 3;
            this.tabIrA.Text = "Ir a..";
            this.tabIrA.UseVisualStyleBackColor = true;
            // 
            // txtCaracteresIrA
            // 
            this.txtCaracteresIrA.Location = new System.Drawing.Point(7, 42);
            this.txtCaracteresIrA.Name = "txtCaracteresIrA";
            this.txtCaracteresIrA.Size = new System.Drawing.Size(103, 20);
            this.txtCaracteresIrA.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Si se encuentra con..";
            // 
            // numPaso
            // 
            this.numPaso.Location = new System.Drawing.Point(44, 3);
            this.numPaso.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numPaso.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPaso.Name = "numPaso";
            this.numPaso.ReadOnly = true;
            this.numPaso.Size = new System.Drawing.Size(32, 20);
            this.numPaso.TabIndex = 5;
            this.numPaso.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Paso:";
            // 
            // btnAgregarI
            // 
            this.btnAgregarI.Location = new System.Drawing.Point(220, 81);
            this.btnAgregarI.Name = "btnAgregarI";
            this.btnAgregarI.Size = new System.Drawing.Size(56, 22);
            this.btnAgregarI.TabIndex = 3;
            this.btnAgregarI.Text = "Agregar";
            this.btnAgregarI.UseVisualStyleBackColor = true;
            this.btnAgregarI.Click += new System.EventHandler(this.btnAgregarI_Click);
            // 
            // lstInstrucciones
            // 
            this.lstInstrucciones.FormattingEnabled = true;
            this.lstInstrucciones.Location = new System.Drawing.Point(308, 201);
            this.lstInstrucciones.Name = "lstInstrucciones";
            this.lstInstrucciones.Size = new System.Drawing.Size(264, 108);
            this.lstInstrucciones.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(308, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(125, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Listado de Instrucciones:";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(454, 315);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(56, 22);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(516, 315);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(56, 22);
            this.btnReiniciar.TabIndex = 7;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // chkDiferenteB
            // 
            this.chkDiferenteB.AutoSize = true;
            this.chkDiferenteB.Location = new System.Drawing.Point(82, 30);
            this.chkDiferenteB.Name = "chkDiferenteB";
            this.chkDiferenteB.Size = new System.Drawing.Size(87, 17);
            this.chkDiferenteB.TabIndex = 11;
            this.chkDiferenteB.Text = "Diferente a ↑";
            this.chkDiferenteB.UseVisualStyleBackColor = true;
            // 
            // tmrEjecucion
            // 
            this.tmrEjecucion.Interval = 3000;
            this.tmrEjecucion.Tick += new System.EventHandler(this.tmrEjecucion_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 346);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lstInstrucciones);
            this.Controls.Add(this.tabCreadorInstruccion);
            this.Controls.Add(this.dtgCinta);
            this.Controls.Add(this.grpMT);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máquina de Turing";
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpMT.ResumeLayout(false);
            this.grpCabezal.ResumeLayout(false);
            this.grpCabezal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCabezal)).EndInit();
            this.grpEntrada.ResumeLayout(false);
            this.grpEntrada.PerformLayout();
            this.grpCinta.ResumeLayout(false);
            this.grpCinta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCinta)).EndInit();
            this.tabCreadorInstruccion.ResumeLayout(false);
            this.tabMovimiento.ResumeLayout(false);
            this.tabMovimiento.PerformLayout();
            this.tabAlmacenamiento.ResumeLayout(false);
            this.tabEscritura.ResumeLayout(false);
            this.tabEscritura.PerformLayout();
            this.tabBusqueda.ResumeLayout(false);
            this.tabBusqueda.PerformLayout();
            this.tabIrA.ResumeLayout(false);
            this.tabIrA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpMT;
		private System.Windows.Forms.DataGridView dtgCinta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAlfabeto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.NumericUpDown numCabezal;
        private System.Windows.Forms.GroupBox grpCinta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabCreadorInstruccion;
        private System.Windows.Forms.TabPage tabMovimiento;
        private System.Windows.Forms.TabPage tabEscritura;
        private System.Windows.Forms.ListBox lstInstrucciones;
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.TabPage tabIrA;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.RadioButton radIzquierdaM;
        private System.Windows.Forms.RadioButton radDerechaM;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.Button btnAgregarB;
        private System.Windows.Forms.Button btnAgregarI;
        private System.Windows.Forms.ComboBox cmbEscritura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabAlmacenamiento;
        private System.Windows.Forms.Button btnAgregarA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbBusqueda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numPaso;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCaracteresIrA;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox grpEntrada;
        private System.Windows.Forms.Button btnAleatoria;
        private System.Windows.Forms.TextBox txtCinta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.GroupBox grpCabezal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox chkCEspecial3;
        private System.Windows.Forms.CheckBox chkCEspecial2;
        private System.Windows.Forms.CheckBox chkCEspecial1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radDerechaB;
        private System.Windows.Forms.RadioButton radIzquierdaB;
        private System.Windows.Forms.CheckBox chkDiferenteB;
        private System.Windows.Forms.Timer tmrEjecucion;
    }
}

