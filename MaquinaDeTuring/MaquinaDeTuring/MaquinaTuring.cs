using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaDeTuring
{
    class MaquinaTuring
    {
        private string strAlfabeto;

        public string Alfabeto
        {
            get { return strAlfabeto; }
            set { strAlfabeto = value; }
        }

        private string strCinta;

        public string Cinta
        {
            get { return strCinta; }
            set { strCinta = value; }
        }

        private int intPosicionCabezal;

        public int PosicionCabezal
        {
            get { return intPosicionCabezal; }
            set { intPosicionCabezal = value; }
        }

        private string strLenguaje;

        public string Lenguaje
        {
            get { return strLenguaje; }
            set { strLenguaje = value; }
        }

        public string EstadoActual { get; set; }

        public override string ToString()
        {
            return EstadoActual;
        }
    }
}
