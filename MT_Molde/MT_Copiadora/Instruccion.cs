using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_Copiadora
{
    class Instruccion
    {
        public int InstruccionId { get; set; }
        public int Tipo { get; set; }
        public string Simbolo { get; set; }
        public int PosicionCabezal { get; set; }
        public int InstruccionSiguiente { get; set; }

        // METODOS //
        public int MoverDerecha (int posCabezal)
        {
            PosicionCabezal = posCabezal++;
            return PosicionCabezal;
        }

        public int MoverIzquierda (int posCabezal)
        {
            if (VerificarMovimientoIzquierda(posCabezal))
                PosicionCabezal = posCabezal--;
            else
                return PosicionCabezal;
            return PosicionCabezal;
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
