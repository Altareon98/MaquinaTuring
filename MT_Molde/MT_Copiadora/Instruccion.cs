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
        public string ParametrosIrA { get; set; }

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
        
        public int IrA (int irA)
        {
            char[] parametros = ParametrosIrA.ToCharArray();
            char[] cadena = Cinta.ToCharArray();

            InstruccionSiguiente = InstruccionId++;
            for (int i = 0; i < parametros.Length; i++)
            {
                if (parametros[i] == cadena[PosicionCabezal])
                {
                    InstruccionSiguiente = irA;
                    break;
                }
            }

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
                    cadena = "Ir a " + InstruccionSiguiente + ", bajo: " + ParametrosIrA;
                    break;
            }
            return Tipo.ToString() + cadena;
        }
    }
}
