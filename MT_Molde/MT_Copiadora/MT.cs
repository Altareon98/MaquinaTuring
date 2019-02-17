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
		public MT(int rintCabezal, string rstrAlfabeto, string rstrCinta, string rstrEntrada)
		{
            Cabezal = rintCabezal;
            Alfabeto = rstrAlfabeto;
            Cinta = rstrCinta;
            Entrada = rstrEntrada;
            Resultante = rstrEntrada;
		}

        //Cabezal (Posición)
        private int intCabezal;

        public int Cabezal
        {
            get { return intCabezal; }
            set { intCabezal = value; }
        }

        //Cinta/////////////
        //Alfabeto
        private string strAlfabeto;

        public string Alfabeto
        {
            get { return strAlfabeto; }
            set { strAlfabeto = value; }
        }

        //Blanco
        private const char Blanco = '_';

        //Caracteres Especiales
        private const char Especial1 = '*';
        private const char Especial2 = '#';
        private const char Especial3 = '$';

        //Variable
        private char chrVariable;

        public char Variable
        {
            get { return chrVariable; }
            set { chrVariable = value; }
        }

        //Cinta (General)
        private string strCinta;

        public string Cinta
        {
            get { return strCinta; }
            set { strCinta = value; }
        }
        ////////////////////

        //Cadena de Entrada
        private string strEntrada;

        public string Entrada
        {
            get { return strEntrada; }
            set { strEntrada = value; }
        }

        //Cadena Resultante
        private string strResultante;

        public string Resultante
        {
            get { return strResultante; }
            set { strResultante = value; }
        }
	}
}
