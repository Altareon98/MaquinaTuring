using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Copiadora
{
	class MT
	{
		//Constructor
		public MT(char rCaracter1, char rCaracter2)
		{
			Caracter1 = rCaracter1;
			Caracter2 = rCaracter2;
			Pasos = new List<char[]>();
		}

		//Alfabeto
		private char alfCaracter1;

		public char Caracter1
		{
			get { return alfCaracter1; }
			set { alfCaracter1 = value; }
		}

		private char alfCaracter2;

		public char Caracter2
		{
			get { return alfCaracter2; }
			set { alfCaracter2 = value; }
		}

		private const char Blanco = '_';

		//Cabezal (Posición)
		private int intCabezal;

		public int Cabezal
		{
			get { return intCabezal; }
			set { intCabezal = value; }
		}

		//Tamaño de Cadena
		private int intCadenaSize;

		public int CadenaSize
		{
			get { return intCadenaSize; }
			set { intCadenaSize = value; }
		}

		//Cadena de Entrada
		private char[] arrEntrada;

		public char[] Entrada
		{
			get { return arrEntrada; }
			set { arrEntrada = value; }
		}

		//Cadena Resultante
		private char[] arrResultante;

		public char[] Resultante
		{
			get { return arrResultante; }
			set { arrResultante = value; }
		}

		//Listado de Pasos
		private List<char[]> lstPasos;

		public List<char[]> Pasos
		{
			get { return lstPasos; }
			set { lstPasos = value; }
		}

		//Estados de MT Eliminadora de Símbolos contrarios al actual hacia la derecha | Prueba de MT
		//Q = {q0, q1, q2, q3}

		//Inicializar Cadena General
		public void InicializarCadenaGeneral()
		{
			//Inicializar Cadena General/Resultante
			char[] arrCadenaGeneral = new char[25];
			for (int i = 0; i < 25; i++)
			{
				arrCadenaGeneral[i] = '_';
			}
			Resultante = arrCadenaGeneral;

			//Se añade la Cadena de Entrada a la Cadena General/Resultante
			for (int i = 2; i < CadenaSize + 2; i++)
			{
				Resultante[i] = Entrada[i - 2];
			}

			//Se crea un Paso
			CrearPaso();

			return;
		}

		//Estado q0
		public bool Q0()
		{

			return true;
		}

		public void Q1()
		{

			return;
		}

		public void Q2()
		{

			return;
		}

		private void CrearPaso()
		{
			//Crear String donde se almacene la Cadena General Actual
			string strCadenaGeneralMomentanea = new string(Resultante);

			//Crear Array donde se almacenen los caracteres de la Cadena General Actual
			char[] arrCadenaGeneralMomentanea = new char[25];
			for (int i = 0; i < 25; i++)
			{
				arrCadenaGeneralMomentanea[i] = strCadenaGeneralMomentanea[i];
			}

			//Agregar Array a la Lista de Pasos
			Pasos.Add(arrCadenaGeneralMomentanea);
		}
	}
}
