namespace MaquinaDeTuring
{
    partial class Form1
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
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.numPosicionCabezal = new System.Windows.Forms.NumericUpDown();
            this.txtLenguaje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpAcciones = new System.Windows.Forms.GroupBox();
            this.btnMoverDch = new System.Windows.Forms.Button();
            this.btnBuscarDch = new System.Windows.Forms.Button();
            this.btnBuscarInversoDch = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnMoverIzq = new System.Windows.Forms.Button();
            this.btnBuscarIzq = new System.Windows.Forms.Button();
            this.btnBuscarInversoIzq = new System.Windows.Forms.Button();
            this.grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicionCabezal)).BeginInit();
            this.grpAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.txtLenguaje);
            this.grpDatos.Controls.Add(this.numPosicionCabezal);
            this.grpDatos.Controls.Add(this.txtCadena);
            this.grpDatos.Controls.Add(this.txtAlfabeto);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Location = new System.Drawing.Point(13, 13);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(245, 130);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alfabeto:";
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(62, 17);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(177, 20);
            this.txtAlfabeto.TabIndex = 1;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(62, 44);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(177, 20);
            this.txtCadena.TabIndex = 2;
            // 
            // numPosicionCabezal
            // 
            this.numPosicionCabezal.Location = new System.Drawing.Point(62, 71);
            this.numPosicionCabezal.Name = "numPosicionCabezal";
            this.numPosicionCabezal.Size = new System.Drawing.Size(47, 20);
            this.numPosicionCabezal.TabIndex = 3;
            // 
            // txtLenguaje
            // 
            this.txtLenguaje.Location = new System.Drawing.Point(62, 98);
            this.txtLenguaje.Name = "txtLenguaje";
            this.txtLenguaje.Size = new System.Drawing.Size(177, 20);
            this.txtLenguaje.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cabezal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lenguaje:";
            // 
            // grpAcciones
            // 
            this.grpAcciones.Controls.Add(this.btnBuscarInversoIzq);
            this.grpAcciones.Controls.Add(this.btnBuscarIzq);
            this.grpAcciones.Controls.Add(this.btnMoverIzq);
            this.grpAcciones.Controls.Add(this.btnEscribir);
            this.grpAcciones.Controls.Add(this.btnBuscarInversoDch);
            this.grpAcciones.Controls.Add(this.btnBuscarDch);
            this.grpAcciones.Controls.Add(this.btnMoverDch);
            this.grpAcciones.Location = new System.Drawing.Point(265, 13);
            this.grpAcciones.Name = "grpAcciones";
            this.grpAcciones.Size = new System.Drawing.Size(200, 130);
            this.grpAcciones.TabIndex = 1;
            this.grpAcciones.TabStop = false;
            this.grpAcciones.Text = "Acciones";
            // 
            // btnMoverDch
            // 
            this.btnMoverDch.Location = new System.Drawing.Point(7, 20);
            this.btnMoverDch.Name = "btnMoverDch";
            this.btnMoverDch.Size = new System.Drawing.Size(39, 39);
            this.btnMoverDch.TabIndex = 0;
            this.btnMoverDch.Text = "D";
            this.btnMoverDch.UseVisualStyleBackColor = true;
            // 
            // btnBuscarDch
            // 
            this.btnBuscarDch.Location = new System.Drawing.Point(52, 20);
            this.btnBuscarDch.Name = "btnBuscarDch";
            this.btnBuscarDch.Size = new System.Drawing.Size(39, 39);
            this.btnBuscarDch.TabIndex = 1;
            this.btnBuscarDch.Text = "Ds";
            this.btnBuscarDch.UseVisualStyleBackColor = true;
            // 
            // btnBuscarInversoDch
            // 
            this.btnBuscarInversoDch.Location = new System.Drawing.Point(97, 20);
            this.btnBuscarInversoDch.Name = "btnBuscarInversoDch";
            this.btnBuscarInversoDch.Size = new System.Drawing.Size(39, 39);
            this.btnBuscarInversoDch.TabIndex = 2;
            this.btnBuscarInversoDch.Text = "D¬s";
            this.btnBuscarInversoDch.UseVisualStyleBackColor = true;
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(142, 20);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(39, 39);
            this.btnEscribir.TabIndex = 3;
            this.btnEscribir.Text = "S";
            this.btnEscribir.UseVisualStyleBackColor = true;
            // 
            // btnMoverIzq
            // 
            this.btnMoverIzq.Location = new System.Drawing.Point(7, 65);
            this.btnMoverIzq.Name = "btnMoverIzq";
            this.btnMoverIzq.Size = new System.Drawing.Size(39, 39);
            this.btnMoverIzq.TabIndex = 4;
            this.btnMoverIzq.Text = "I";
            this.btnMoverIzq.UseVisualStyleBackColor = true;
            // 
            // btnBuscarIzq
            // 
            this.btnBuscarIzq.Location = new System.Drawing.Point(52, 65);
            this.btnBuscarIzq.Name = "btnBuscarIzq";
            this.btnBuscarIzq.Size = new System.Drawing.Size(39, 39);
            this.btnBuscarIzq.TabIndex = 5;
            this.btnBuscarIzq.Text = "Is";
            this.btnBuscarIzq.UseVisualStyleBackColor = true;
            // 
            // btnBuscarInversoIzq
            // 
            this.btnBuscarInversoIzq.Location = new System.Drawing.Point(97, 65);
            this.btnBuscarInversoIzq.Name = "btnBuscarInversoIzq";
            this.btnBuscarInversoIzq.Size = new System.Drawing.Size(39, 39);
            this.btnBuscarInversoIzq.TabIndex = 6;
            this.btnBuscarInversoIzq.Text = "I¬s";
            this.btnBuscarInversoIzq.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.grpAcciones);
            this.Controls.Add(this.grpDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPosicionCabezal)).EndInit();
            this.grpAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLenguaje;
        private System.Windows.Forms.NumericUpDown numPosicionCabezal;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAcciones;
        private System.Windows.Forms.Button btnBuscarInversoIzq;
        private System.Windows.Forms.Button btnBuscarIzq;
        private System.Windows.Forms.Button btnMoverIzq;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnBuscarInversoDch;
        private System.Windows.Forms.Button btnBuscarDch;
        private System.Windows.Forms.Button btnMoverDch;
    }
}

