using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Copiadora
{
    class Instruccion
    {
        // CONSTRUCTORES //
        public Instruccion()
        {
            VecesEjecutado = 0;
        }
        public Instruccion(string cinta, int posicionCabezal)
        {
            Cinta = cinta;
            PosicionCabezal = posicionCabezal;
        }

        // PROPIEDADES //
        public int InstruccionId { get; set; }
        public int Tipo { get; set; }
        public char Simbolo { get; set; }
        public char SimboloAEscribir { get; set; }
        public char SimboloBuscado { get; set; }
        public string Cinta { get; set; }
        //private string strCinta;

        //public string Cinta
        //{
        //    get { return strCinta; }
        //    set { strCinta = value; }
        //}

        public int PosicionCabezal { get; set; }
        public int InstruccionSiguiente { get; set; }

        public string ParametrosAlmacenamiento { get; set; }

        public string ParametrosIrA { get; set; }
        public int InstruccionIrA { get; set; }

        public int VecesEjecutado { get; set; }

        // INSTRUCCIONES //
        public int MoverDerecha ()
        {
            PosicionCabezal++;
            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int MoverIzquierda ()
        {
            if (VerificarMovimientoIzquierda(PosicionCabezal))
                PosicionCabezal--;
            else
                throw new Exception("Se ha generado un problema de terminación anormal!");
            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int Escribir()
        {
            char[] cadena = Cinta.ToCharArray();
            cadena[PosicionCabezal - 1] = SimboloAEscribir;
            Cinta = "";
            for(int i = 0; i < cadena.Length; i++)
            {
                Cinta = Cinta + cadena[i];
            }
            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int Escribir(char rchrVariable)
        {
            char[] cadena = Cinta.ToCharArray();
            cadena[PosicionCabezal - 1] = rchrVariable;
            Cinta = "";
            for (int i = 0; i < cadena.Length; i++)
            {
                Cinta = Cinta + cadena[i];
            }
            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int BuscarDerecha()
        {
            char[] cadena = Cinta.ToCharArray();

            do
            {
                PosicionCabezal++;
                if (cadena[PosicionCabezal - 1] == SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int BuscarIzquierda()
        {
            char[] cadena = Cinta.ToCharArray();

            do
            {
                if (VerificarMovimientoIzquierda(PosicionCabezal))
                    PosicionCabezal--;
                else
                    throw new Exception("Se ha generado un problema de terminación anormal!");

                if (cadena[PosicionCabezal - 1] == SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int BuscarDiferenteDerecha()
        {
            char[] cadena = Cinta.ToCharArray();

            do
            {
                PosicionCabezal++;
                if (cadena[PosicionCabezal - 1] != SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        public int BuscarDiferenteIzquierda()
        {
            char[] cadena = Cinta.ToCharArray();

            do
            {
                if (VerificarMovimientoIzquierda(PosicionCabezal))
                    PosicionCabezal--;
                else
                    throw new Exception("Se ha generado un problema de terminación anormal!");

                if (cadena[PosicionCabezal - 1] != SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return InstruccionSiguiente;
        }
        
        public string Almacenar(ref int rintInstruccionSiguiente)
        {
            char[] parametros = ParametrosAlmacenamiento.ToCharArray();
            char[] cadena = Cinta.ToCharArray();
            string strSimboloAlmacenado = "";

            for (int i = 0; i < parametros.Length; i++)
            {
                if (parametros[i] == cadena[PosicionCabezal - 1])
                {
                    strSimboloAlmacenado = parametros[i].ToString();
                }
            }

            rintInstruccionSiguiente = InstruccionId + 1;
            VecesEjecutado++;
            return strSimboloAlmacenado;
        }

        public int IrA ()
        {
            char[] parametros = ParametrosIrA.ToCharArray();
            char[] cadena = Cinta.ToCharArray();

            InstruccionSiguiente = InstruccionId + 1;

            for (int i = 0; i < parametros.Length; i++)
            {
                if (parametros[i] == cadena[PosicionCabezal - 1])
                {
                    InstruccionSiguiente = InstruccionIrA;
                    break;
                }
            }
            VecesEjecutado++;
            return InstruccionSiguiente;
        }

        // VERIFICACIONES //
        private bool VerificarMovimientoIzquierda (int posCabezal)
        {
            if (posCabezal == 1)
            {
                return false;
            }
            return true;
        }

        // METODOS //
        public override string ToString()
        {
            string cadena = "";
            switch (Tipo)
            {
                case 1:
                    cadena = "Moverse a la derecha.";
                    break;
                case 2:
                    cadena = "Moverse a la izquierda.";
                    break;
                case 3:
                    cadena = "Escribir símbolo: " + SimboloAEscribir;
                    break;
                case 4:
                    cadena = "Buscar símbolo a la derecha: " + SimboloBuscado;
                    break;
                case 5:
                    cadena = "Buscar símbolo a la izquierda: " + SimboloBuscado;
                    break;
                case 6:
                    cadena = "Buscar símbolo diferente a " + SimboloBuscado + " hacia la derecha.";
                    break;
                case 7:
                    cadena = "Buscar símbolo diferente a " + SimboloBuscado + " hacia la izquierda.";
                    break;
                case 8:
                    cadena = "Ir a " + InstruccionIrA + ", bajo: " + ParametrosIrA;
                    break;
                case 9:
                    cadena = "Almacenar en variable.";
                    break;
            }
            return InstruccionId.ToString() + ".- " + cadena;
        }
    }
}
