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
		MT miCopiadora;

		public Main()
		{
			InitializeComponent();
		}

		private void Main_Load(object sender, EventArgs e)
		{
			//Creación de MT
			miCopiadora = new MT(txtAlfC1.Text[0], txtAlfC2.Text[0]);
		}

		private void btnAleatoria_Click(object sender, EventArgs e)
		{
			Random rndEntrada = new Random();
			string strAlfabeto = miCopiadora.Caracter1.ToString() + miCopiadora.Caracter2.ToString() + "_";
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
				miCopiadora.Caracter1 = txtAlfC1.Text[0];
			}
			else
			{
				MessageBox.Show("El caracter que se introdujo ya se encuentra en el Alfabeto actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtAlfC1.Text = miCopiadora.Caracter1.ToString();
				txtAlfC1.Focus();
			}
		}

		private void txtAlfC2_TextChanged(object sender, EventArgs e)
		{
			if (txtAlfC2.Text != txtAlfC1.Text && txtAlfC2.Text != "_")
			{
				miCopiadora.Caracter2 = txtAlfC2.Text[0];
			}
			else
			{
				MessageBox.Show("El caracter que se introdujo ya se encuentra en el Alfabeto actual.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				txtAlfC2.Text = miCopiadora.Caracter2.ToString();
				txtAlfC2.Focus();
			}
		}

		private void btnIniciar_Click(object sender, EventArgs e)
		{
			//Ingresar Texto de Entrada a la Propiedad de Entrada
			miCopiadora.Entrada = txtEntrada.Text.ToCharArray();

			//Inicializar Cadena
			miCopiadora.InicializarCadenaGeneral();

			//Asignar Posición al Cabezal
			miCopiadora.Cabezal = int.Parse(numCabezal.Value.ToString());

			//Iniciar MT
			if (miCopiadora.Q0())
			{
				txtCadenaInicial.Text = new string(ObtenerCadenaGeneral());
				txtCadenaFinal.Text = new string(miCopiadora.Resultante);
				MessageBox.Show("Procedimiento terminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private char[] ObtenerCadenaGeneral()
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
			for (int i = 2; i < 12; i++)
			{
				arrInicial[i] = miCopiadora.Entrada[i - 2];
			}

			return arrInicial;
		}
	}
}
