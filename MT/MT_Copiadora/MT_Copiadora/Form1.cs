using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_Copiadora
{
	public partial class Main : Form
	{
		//Declaración de MT
		MT miInversora;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//Creación de MT
			miInversora = new MT(txtAlfC1.Text[0], txtAlfC2.Text[0]);
		}

		private void btnAleatoria_Click(object sender, EventArgs e)
		{
			Random rndEntrada = new Random();
			string strAlfabeto = miInversora.Caracter1.ToString() + miInversora.Caracter2.ToString() + "_";
			int intLong = strAlfabeto.Length;
			char chrCaracter;
			int intLongEntrada = 10;
			string strEntrada = "";
			for (int i = 0; i < intLongEntrada; i++)
			{
				chrCaracter = strAlfabeto[rndEntrada.Next(intLong)];
				strEntrada += chrCaracter.ToString();
			}

			txtEntrada.Text = strEntrada;
		}

		private void txtAlfC1_MouseClick(object sender, MouseEventArgs e)
		{
			txtAlfC1.SelectAll();
		}

		private void txtAlfC2_MouseClick(object sender, MouseEventArgs e)
		{
			txtAlfC2.SelectAll();
		}

		private void txtAlfC1_TextChanged(object sender, EventArgs e)
		{
			if(txtAlfC1.Text != txtAlfC2.Text && txtAlfC1.Text != "_")
			{
				miInversora.Caracter1 = txtAlfC1.Text[0];
				txtEntrada.Clear();
			}
			else
			{
				MessageBox.Show("El caracter que se introdujo ya se encuentra en el Alfabeto actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtAlfC1.Text = miInversora.Caracter1.ToString();
				txtAlfC1.Focus();
			}
		}

		private void txtAlfC2_TextChanged(object sender, EventArgs e)
		{
			if (txtAlfC2.Text != txtAlfC1.Text && txtAlfC2.Text != "_")
			{
				miInversora.Caracter2 = txtAlfC2.Text[0];
				txtEntrada.Clear();
			}
			else
			{
				MessageBox.Show("El caracter que se introdujo ya se encuentra en el Alfabeto actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtAlfC2.Text = miInversora.Caracter2.ToString();
				txtAlfC2.Focus();
			}
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			//Ingresar Texto de Entrada a la Propiedad de Entrada
			miInversora.Entrada = txtEntrada.Text.ToCharArray();

			//Definir el tamaño de la Cadena de Entrada
			int intCadenaSize = 10;
			miInversora.CadenaSize = intCadenaSize;

			//Inicializar Cadena
			miInversora.InicializarCadenaGeneral();

			//Asignar Posición al Cabezal
			miInversora.Cabezal = int.Parse(numCabezal.Value.ToString());

			//Se Inicializa la Lista de Pasos
			miInversora.Pasos.Clear();

			//Iniciar MT
			if (miInversora.Q0())
			{
				//Limpiar/Preparar DataGrid
				dtgProcedimiento.Rows.Clear();

				//Se llena la DataGrid con los Pasos del Procedimiento
				foreach(char[] miPaso in miInversora.Pasos)
				{
					dtgProcedimiento.Rows.Add(
						miPaso[0], miPaso[1], miPaso[2], miPaso[3], miPaso[4],
						miPaso[5], miPaso[6], miPaso[7], miPaso[8], miPaso[9],
						miPaso[10], miPaso[11], miPaso[12], miPaso[13], miPaso[14],
						miPaso[15], miPaso[16], miPaso[17], miPaso[18], miPaso[19],
						miPaso[20], miPaso[21], miPaso[22], miPaso[23], miPaso[24]
						);
				}

				txtCadenaInicial.Text = new string(ObtenerCadenaGeneral(intCadenaSize));
				txtCadenaFinal.Text = new string(miInversora.Resultante);
				MessageBox.Show("Procedimiento terminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private char[] ObtenerCadenaGeneral(int intCadenaSize)
		{
			//Inicializar Cadena General/Inicial
			char[] arrCadenaGeneral = new char[25];
			char[] arrInicial = new char[25];

			for (int i = 0; i < 25; i++)
			{
				arrCadenaGeneral[i] = '_';
			}
			arrInicial = arrCadenaGeneral;

			//Se añade la Cadena de Entrada a la Cadena General/Inicial
			for (int i = 2; i < intCadenaSize + 2; i++)
			{
				arrInicial[i] = miInversora.Entrada[i - 2];
			}

			return arrInicial;
		}

		private void btnReiniciar_Click(object sender, EventArgs e)
		{
			//Limpiar Cadena de Entrada
			txtEntrada.Clear();

			//Limpiar DataGrid
			dtgProcedimiento.Rows.Clear();

			//Limpiar Textbox de Grupo de Comparación
			txtCadenaInicial.Clear();
			txtCadenaFinal.Clear();

			//Establecer Posición Inicial del Cabezal
			numCabezal.Value = 2;
		}
	}
}
