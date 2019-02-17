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
			this.grpAlfabeto = new System.Windows.Forms.GroupBox();
			this.txtAlfBlanco = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAlfC2 = new System.Windows.Forms.TextBox();
			this.txtAlfC1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.grpEntrada = new System.Windows.Forms.GroupBox();
			this.btnAleatoria = new System.Windows.Forms.Button();
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.dtgProcedimiento = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grpComparacion = new System.Windows.Forms.GroupBox();
			this.txtCadenaFinal = new System.Windows.Forms.TextBox();
			this.txtCadenaInicial = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.btnReiniciar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.grpCabezal = new System.Windows.Forms.GroupBox();
			this.numCabezal = new System.Windows.Forms.NumericUpDown();
			this.label7 = new System.Windows.Forms.Label();
			this.grpAlfabeto.SuspendLayout();
			this.grpEntrada.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgProcedimiento)).BeginInit();
			this.grpComparacion.SuspendLayout();
			this.grpCabezal.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCabezal)).BeginInit();
			this.SuspendLayout();
			// 
			// grpAlfabeto
			// 
			this.grpAlfabeto.Controls.Add(this.txtAlfBlanco);
			this.grpAlfabeto.Controls.Add(this.label3);
			this.grpAlfabeto.Controls.Add(this.txtAlfC2);
			this.grpAlfabeto.Controls.Add(this.txtAlfC1);
			this.grpAlfabeto.Controls.Add(this.label2);
			this.grpAlfabeto.Controls.Add(this.label1);
			this.grpAlfabeto.Location = new System.Drawing.Point(12, 12);
			this.grpAlfabeto.Name = "grpAlfabeto";
			this.grpAlfabeto.Size = new System.Drawing.Size(115, 97);
			this.grpAlfabeto.TabIndex = 0;
			this.grpAlfabeto.TabStop = false;
			this.grpAlfabeto.Text = "Alfabeto";
			// 
			// txtAlfBlanco
			// 
			this.txtAlfBlanco.Location = new System.Drawing.Point(75, 65);
			this.txtAlfBlanco.MaxLength = 1;
			this.txtAlfBlanco.Name = "txtAlfBlanco";
			this.txtAlfBlanco.ReadOnly = true;
			this.txtAlfBlanco.Size = new System.Drawing.Size(34, 20);
			this.txtAlfBlanco.TabIndex = 5;
			this.txtAlfBlanco.Text = "_";
			this.txtAlfBlanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Blanco:";
			// 
			// txtAlfC2
			// 
			this.txtAlfC2.Location = new System.Drawing.Point(75, 39);
			this.txtAlfC2.MaxLength = 1;
			this.txtAlfC2.Name = "txtAlfC2";
			this.txtAlfC2.Size = new System.Drawing.Size(34, 20);
			this.txtAlfC2.TabIndex = 3;
			this.txtAlfC2.Text = "1";
			this.txtAlfC2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAlfC2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAlfC2_MouseClick);
			this.txtAlfC2.TextChanged += new System.EventHandler(this.txtAlfC2_TextChanged);
			// 
			// txtAlfC1
			// 
			this.txtAlfC1.Location = new System.Drawing.Point(75, 13);
			this.txtAlfC1.MaxLength = 1;
			this.txtAlfC1.Name = "txtAlfC1";
			this.txtAlfC1.Size = new System.Drawing.Size(34, 20);
			this.txtAlfC1.TabIndex = 3;
			this.txtAlfC1.Text = "0";
			this.txtAlfC1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtAlfC1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAlfC1_MouseClick);
			this.txtAlfC1.TextChanged += new System.EventHandler(this.txtAlfC1_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "2º Caracter:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "1º Caracter:";
			// 
			// grpEntrada
			// 
			this.grpEntrada.Controls.Add(this.btnAleatoria);
			this.grpEntrada.Controls.Add(this.txtEntrada);
			this.grpEntrada.Location = new System.Drawing.Point(133, 12);
			this.grpEntrada.Name = "grpEntrada";
			this.grpEntrada.Size = new System.Drawing.Size(148, 50);
			this.grpEntrada.TabIndex = 1;
			this.grpEntrada.TabStop = false;
			this.grpEntrada.Text = "Cadena de Entrada";
			// 
			// btnAleatoria
			// 
			this.btnAleatoria.Location = new System.Drawing.Point(85, 17);
			this.btnAleatoria.Name = "btnAleatoria";
			this.btnAleatoria.Size = new System.Drawing.Size(57, 23);
			this.btnAleatoria.TabIndex = 4;
			this.btnAleatoria.Text = "Aleatoria";
			this.btnAleatoria.UseVisualStyleBackColor = true;
			this.btnAleatoria.Click += new System.EventHandler(this.btnAleatoria_Click);
			// 
			// txtEntrada
			// 
			this.txtEntrada.Location = new System.Drawing.Point(6, 19);
			this.txtEntrada.MaxLength = 10;
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.Size = new System.Drawing.Size(73, 20);
			this.txtEntrada.TabIndex = 6;
			this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// dtgProcedimiento
			// 
			this.dtgProcedimiento.AllowUserToAddRows = false;
			this.dtgProcedimiento.AllowUserToDeleteRows = false;
			this.dtgProcedimiento.AllowUserToResizeColumns = false;
			this.dtgProcedimiento.AllowUserToResizeRows = false;
			this.dtgProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dtgProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgProcedimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17,
            this.Column18,
            this.Column19,
            this.Column20,
            this.Column21,
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25});
			this.dtgProcedimiento.Location = new System.Drawing.Point(12, 128);
			this.dtgProcedimiento.Name = "dtgProcedimiento";
			this.dtgProcedimiento.ReadOnly = true;
			this.dtgProcedimiento.RowHeadersVisible = false;
			this.dtgProcedimiento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
			this.dtgProcedimiento.Size = new System.Drawing.Size(560, 150);
			this.dtgProcedimiento.TabIndex = 2;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "_";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "_";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "0";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "1";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "2";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "3";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText = "4";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column8.HeaderText = "5";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Column9
			// 
			this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column9.HeaderText = "6";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column10.HeaderText = "7";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			// 
			// Column11
			// 
			this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column11.HeaderText = "8";
			this.Column11.Name = "Column11";
			this.Column11.ReadOnly = true;
			// 
			// Column12
			// 
			this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column12.HeaderText = "9";
			this.Column12.Name = "Column12";
			this.Column12.ReadOnly = true;
			// 
			// Column13
			// 
			this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column13.HeaderText = "_";
			this.Column13.Name = "Column13";
			this.Column13.ReadOnly = true;
			// 
			// Column14
			// 
			this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column14.HeaderText = "_";
			this.Column14.Name = "Column14";
			this.Column14.ReadOnly = true;
			// 
			// Column15
			// 
			this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column15.HeaderText = "_";
			this.Column15.Name = "Column15";
			this.Column15.ReadOnly = true;
			// 
			// Column16
			// 
			this.Column16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column16.HeaderText = "_";
			this.Column16.Name = "Column16";
			this.Column16.ReadOnly = true;
			// 
			// Column17
			// 
			this.Column17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column17.HeaderText = "_";
			this.Column17.Name = "Column17";
			this.Column17.ReadOnly = true;
			// 
			// Column18
			// 
			this.Column18.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column18.HeaderText = "_";
			this.Column18.Name = "Column18";
			this.Column18.ReadOnly = true;
			// 
			// Column19
			// 
			this.Column19.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column19.HeaderText = "_";
			this.Column19.Name = "Column19";
			this.Column19.ReadOnly = true;
			// 
			// Column20
			// 
			this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column20.HeaderText = "_";
			this.Column20.Name = "Column20";
			this.Column20.ReadOnly = true;
			// 
			// Column21
			// 
			this.Column21.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column21.HeaderText = "_";
			this.Column21.Name = "Column21";
			this.Column21.ReadOnly = true;
			// 
			// Column22
			// 
			this.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column22.HeaderText = "_";
			this.Column22.Name = "Column22";
			this.Column22.ReadOnly = true;
			// 
			// Column23
			// 
			this.Column23.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column23.HeaderText = "_";
			this.Column23.Name = "Column23";
			this.Column23.ReadOnly = true;
			// 
			// Column24
			// 
			this.Column24.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column24.HeaderText = "_";
			this.Column24.Name = "Column24";
			this.Column24.ReadOnly = true;
			// 
			// Column25
			// 
			this.Column25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column25.HeaderText = "_";
			this.Column25.Name = "Column25";
			this.Column25.ReadOnly = true;
			// 
			// grpComparacion
			// 
			this.grpComparacion.Controls.Add(this.txtCadenaFinal);
			this.grpComparacion.Controls.Add(this.txtCadenaInicial);
			this.grpComparacion.Controls.Add(this.label6);
			this.grpComparacion.Controls.Add(this.label5);
			this.grpComparacion.Location = new System.Drawing.Point(287, 12);
			this.grpComparacion.Name = "grpComparacion";
			this.grpComparacion.Size = new System.Drawing.Size(269, 65);
			this.grpComparacion.TabIndex = 3;
			this.grpComparacion.TabStop = false;
			this.grpComparacion.Text = "Comparación";
			// 
			// txtCadenaFinal
			// 
			this.txtCadenaFinal.Location = new System.Drawing.Point(89, 39);
			this.txtCadenaFinal.MaxLength = 25;
			this.txtCadenaFinal.Name = "txtCadenaFinal";
			this.txtCadenaFinal.ReadOnly = true;
			this.txtCadenaFinal.Size = new System.Drawing.Size(174, 20);
			this.txtCadenaFinal.TabIndex = 2;
			this.txtCadenaFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCadenaInicial
			// 
			this.txtCadenaInicial.Location = new System.Drawing.Point(89, 13);
			this.txtCadenaInicial.MaxLength = 25;
			this.txtCadenaInicial.Name = "txtCadenaInicial";
			this.txtCadenaInicial.ReadOnly = true;
			this.txtCadenaInicial.Size = new System.Drawing.Size(174, 20);
			this.txtCadenaInicial.TabIndex = 1;
			this.txtCadenaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Cadena Final:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Cadena Inicial:";
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(287, 83);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(45, 23);
			this.btnIniciar.TabIndex = 4;
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// btnReiniciar
			// 
			this.btnReiniciar.Location = new System.Drawing.Point(338, 84);
			this.btnReiniciar.Name = "btnReiniciar";
			this.btnReiniciar.Size = new System.Drawing.Size(103, 22);
			this.btnReiniciar.TabIndex = 5;
			this.btnReiniciar.Text = "Reiniciar controles";
			this.btnReiniciar.UseVisualStyleBackColor = true;
			this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Procedimiento:";
			// 
			// grpCabezal
			// 
			this.grpCabezal.Controls.Add(this.numCabezal);
			this.grpCabezal.Controls.Add(this.label7);
			this.grpCabezal.Location = new System.Drawing.Point(133, 68);
			this.grpCabezal.Name = "grpCabezal";
			this.grpCabezal.Size = new System.Drawing.Size(148, 41);
			this.grpCabezal.TabIndex = 7;
			this.grpCabezal.TabStop = false;
			this.grpCabezal.Text = "Cabezal";
			// 
			// numCabezal
			// 
			this.numCabezal.Location = new System.Drawing.Point(110, 15);
			this.numCabezal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numCabezal.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numCabezal.Name = "numCabezal";
			this.numCabezal.ReadOnly = true;
			this.numCabezal.Size = new System.Drawing.Size(32, 20);
			this.numCabezal.TabIndex = 1;
			this.numCabezal.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(108, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Posición del Cabezal:";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 288);
			this.Controls.Add(this.grpCabezal);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnReiniciar);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.grpComparacion);
			this.Controls.Add(this.dtgProcedimiento);
			this.Controls.Add(this.grpEntrada);
			this.Controls.Add(this.grpAlfabeto);
			this.Name = "Main";
			this.Text = "MT Copiadora";
			this.Load += new System.EventHandler(this.Main_Load);
			this.grpAlfabeto.ResumeLayout(false);
			this.grpAlfabeto.PerformLayout();
			this.grpEntrada.ResumeLayout(false);
			this.grpEntrada.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgProcedimiento)).EndInit();
			this.grpComparacion.ResumeLayout(false);
			this.grpComparacion.PerformLayout();
			this.grpCabezal.ResumeLayout(false);
			this.grpCabezal.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCabezal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpAlfabeto;
		private System.Windows.Forms.GroupBox grpEntrada;
		private System.Windows.Forms.DataGridView dtgProcedimiento;
		private System.Windows.Forms.GroupBox grpComparacion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAlfC2;
		private System.Windows.Forms.TextBox txtAlfC1;
		private System.Windows.Forms.TextBox txtAlfBlanco;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEntrada;
		private System.Windows.Forms.Button btnAleatoria;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Button btnReiniciar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCadenaFinal;
		private System.Windows.Forms.TextBox txtCadenaInicial;
		private System.Windows.Forms.GroupBox grpCabezal;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numCabezal;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column21;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column22;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column23;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
	}
}

