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
        public int PosicionCabezal { get; set; }
        public int InstruccionSiguiente { get; set; }

        // INSTRUCCIONES //
        public int MoverDerecha ()
        {
            PosicionCabezal++;
            InstruccionSiguiente = InstruccionId++;
            return InstruccionSiguiente;
        }

        public int MoverIzquierda ()
        {
            if (VerificarMovimientoIzquierda(PosicionCabezal))
                PosicionCabezal--;
            else
                throw new Exception("Se ha generado un problema de terminación anormal!");
            InstruccionSiguiente = InstruccionId++;
            return InstruccionSiguiente;
        }

        public int Escribir()
        {
            char[] cadena = Cinta.ToCharArray();
            cadena[PosicionCabezal] = SimboloAEscribir;
            Cinta = cadena.ToString();
            return InstruccionSiguiente;
        }

        public int BuscarDerecha()
        {
            char[] cadena = Cinta.ToCharArray();

            do
            {
                PosicionCabezal++;
                if (cadena[PosicionCabezal] == SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId++;
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

                if (cadena[PosicionCabezal] == SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId++;
            return InstruccionSiguiente;
        }

        public int BuscarDiferenteDerecha()
        {
            char[] cadena = Cinta.ToCharArray();

            do
            {
                PosicionCabezal++;
                if (cadena[PosicionCabezal] != SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId++;
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

                if (cadena[PosicionCabezal] != SimboloBuscado)
                    break;
            } while (true);

            InstruccionSiguiente = InstruccionId++;
            return InstruccionSiguiente;
        }

        // agregar metodo IR A //

        // VERIFICACIONES //
        private bool VerificarMovimientoIzquierda (int posCabezal)
        {
            if (posCabezal == 1)
            {
                return false;
            }
            return true;
        }
    }
}
