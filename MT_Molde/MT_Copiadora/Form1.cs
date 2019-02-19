using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Máquina de Turing
//Por Lázaro y Jareth

namespace MT_Copiadora
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

        //Declaración de MT
        MT miMT;

        //Declaracion de lista de instrucciones
        List<Instruccion> misInstrucciones;
        bool blnListaCreada = false;

        //Variables globales Problema de la parada
        int problemaParada = 0;

        private void Main_Load(object sender, EventArgs e)
		{
            btnNuevo.Enabled = false;
            btnIniciar.Enabled = false;
            btnReiniciar.Enabled = false;

            btnAceptar.Enabled = false;
		}

		private void btnAleatoria_Click(object sender, EventArgs e)
		{
            try
            {
                Random rndEntrada = new Random();
                string strAlfabeto = txtCinta.Text;
                int intLong = strAlfabeto.Length;
                char chrCaracter;
                int intLongEntrada = 30;
                string strEntrada = "";
                for (int i = 0; i < intLongEntrada; i++)
                {
                    chrCaracter = strAlfabeto[rndEntrada.Next(intLong)];
                    strEntrada += chrCaracter.ToString();
                }

                txtEntrada.Text = strEntrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
		}

        private void ActualizarCinta()
        {
            string strCaracteresEspeciales = "_";
            if (chkCEspecial1.Checked)
            {
                strCaracteresEspeciales += "*";
            }
            if (chkCEspecial2.Checked)
            {
                strCaracteresEspeciales += "#";
            }
            if (chkCEspecial3.Checked)
            {
                strCaracteresEspeciales += "$";
            }
            string strCinta = txtAlfabeto.Text + strCaracteresEspeciales;
            txtCinta.Text = strCinta;
        }

        private void txtAlfabeto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizarCinta();
            }
        }

        bool blnInEntrada = false;
        private void txtEntrada_MouseClick(object sender, MouseEventArgs e)
        {
            if (blnInEntrada)
            {
                blnInEntrada = false;
            }
            else
            {
                txtEntrada.SelectAll();
                blnInEntrada = true;
            }
        }

        private bool ValidarAlfabeto()
        {
            for (int e = 0; e < txtEntrada.Text.Length; e++)
            {
                if (!txtCinta.Text.Contains(txtEntrada.Text[e]))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarAlfabeto())
                {
                    intInstruccionSiguiente = 1;

                    //Creación de MT
                    miMT = new MT(int.Parse(numCabezal.Value.ToString()), txtAlfabeto.Text, txtCinta.Text, txtEntrada.Text);

                    if (miMT.Alfabeto != "" && miMT.Cinta != "" && miMT.Entrada != "")
                    {
                        //Bloqueo y Desbloqueo de controles
                        grpCinta.Enabled = false;
                        grpEntrada.Enabled = false;
                        grpCabezal.Enabled = false;
                        btnAceptar.Enabled = false;
                        btnReiniciar.Enabled = true;
                        btnNuevo.Enabled = true;
                    }

                    //Crear columnas y Colocar datos en la cinta (DataGrid)
                    dtgCinta.ColumnCount = miMT.Entrada.Length;
                    string[] celdas = new string[miMT.Entrada.Length];
                    char[] cinta = miMT.Entrada.ToCharArray();
                    for (int i = 0; i < miMT.Entrada.Length; i++)
                    {
                        celdas[i] = cinta[i].ToString();
                    }
                    dtgCinta.Rows.Add(celdas);

                    //Limitar numCabezal a la Cantidad de Columnas
                    numCabezal.Maximum = dtgCinta.ColumnCount;

                    //Indicar la posicion del cabezal en la DTG
                    ActualizarCabezal();

                    //Agregar Lista de Caracteres a controles de tabCrearInstrucción
                    //Creación de Lista de Caracteres con Variable
                    List<char> lstCintaConVariable = new List<char>();

                    for (int i = 0; i < miMT.Cinta.Length; i++)
                    {
                        lstCintaConVariable.Add(miMT.Cinta[i]);
                    }
                    lstCintaConVariable.Add('?');

                    //Escritura
                    cmbEscritura.DataSource = lstCintaConVariable;

                    //Creación de Lista de Caracteres Sin Variable
                    List<char> lstCintaSinVariable = new List<char>();

                    for (int i = 0; i < miMT.Cinta.Length; i++)
                    {
                        lstCintaSinVariable.Add(miMT.Cinta[i]);
                    }

                    //Búsqueda
                    cmbBusqueda.DataSource = lstCintaSinVariable;

                    ////////////////////////////////////////////////////////////////
                }
                else
                {
                    throw new Exception("Error en la Cadena de Entrada");
                }

                if (lstInstrucciones.Items.Count != 0)
                {
                    blnIniciado = false;
                    btnIniciar.Enabled = true;
                }
                else
                {
                    btnIniciar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (txtEntrada.Text == "" || !ValidarAlfabeto())
                {
                    txtEntrada.Focus();
                }
                if (txtCinta.Text == "")
                {
                    txtCinta.Focus();
                }
                if (txtAlfabeto.Text == "")
                {
                    txtAlfabeto.Focus();
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;

            dtgCinta.Rows.Clear();

            grpEntrada.Enabled = true;
            grpCinta.Enabled = true;
            grpCabezal.Enabled = true;
            tabCreadorInstruccion.Enabled = true;

            intInstruccionSiguiente = 1;
            problemaParada = 0;

            blnIniciado = false;
            btnIniciar.Enabled = false;

            btnBorrarInstrucciones.Enabled = true;

            if (txtEntrada.Text != null)
            {
                btnAceptar.Enabled = true;
            }
        }

        private void txtAlfabeto_TextChanged(object sender, EventArgs e)
        {
            ActualizarCinta();
            txtEntrada.Clear();
        }

        private void chkCEspecial1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCinta();
            txtEntrada.Clear();
        }

        private void chkCEspecial2_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCinta();
            txtEntrada.Clear();
        }

        private void chkCEspecial3_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarCinta();
            txtEntrada.Clear();
        }

        private void txtAlfabeto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ActualizarCabezal()
        {
            if (numCabezal.Value <= dtgCinta.ColumnCount && dtgCinta.CurrentCell != null)
            {
                dtgCinta.CurrentCell.Style.BackColor = Color.White;
                dtgCinta.CurrentCell.Style.ForeColor = Color.Black;
                miMT.Cabezal = int.Parse(numCabezal.Value.ToString());
                dtgCinta.CurrentCell = dtgCinta[miMT.Cabezal - 1, 0];
                dtgCinta.CurrentCell.Style.BackColor = Color.FromArgb(61, 165, 206);
                dtgCinta.CurrentCell.Style.ForeColor = Color.White;
                dtgCinta.CurrentCell.Selected = false;
            }
        }

        private void numCabezal_ValueChanged(object sender, EventArgs e)
        {
            ActualizarCabezal();
        }

        private void ActualizarListadoInstrucciones(Instruccion rmiInstruccion)
        {
            //Añadir instrucción a la lista genérica
            misInstrucciones.Add(rmiInstruccion);

            //Actualizar Listado de Instrucciones en lstInstrucciones
            lstInstrucciones.Items.Add(rmiInstruccion);
        }

        //Instrucción: Movimiento
        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            if (!blnListaCreada)
            {
                misInstrucciones = new List<Instruccion>();
                blnListaCreada = true;
                btnIniciar.Enabled = true;
                btnBorrarInstrucciones.Enabled = true;
            }

            Instruccion InstruccionMovimiento = new Instruccion();
            InstruccionMovimiento.InstruccionId = misInstrucciones.Count + 1;
            if (radIzquierdaM.Checked)
                InstruccionMovimiento.Tipo = 2;
            else
                InstruccionMovimiento.Tipo = 1;

            ActualizarListadoInstrucciones(InstruccionMovimiento);

            radDerechaM.Checked = true;
        }

        //Instrucción: Almacenar
        private void btnAgregarA_Click(object sender, EventArgs e)
        {
            if (!blnListaCreada)
            {
                misInstrucciones = new List<Instruccion>();
                blnListaCreada = true;
                btnIniciar.Enabled = true;
                btnBorrarInstrucciones.Enabled = true;
            }

            Instruccion InstruccionAlmacenar = new Instruccion();
            InstruccionAlmacenar.InstruccionId = misInstrucciones.Count + 1;
            InstruccionAlmacenar.Tipo = 9;

            InstruccionAlmacenar.ParametrosAlmacenamiento = txtCaracteresA.Text;

            ActualizarListadoInstrucciones(InstruccionAlmacenar);

            txtCaracteresA.Clear();
        }

        //Instrucción: Escritura
        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            if (!blnListaCreada)
            {
                misInstrucciones = new List<Instruccion>();
                blnListaCreada = true;
                btnIniciar.Enabled = true;
                btnBorrarInstrucciones.Enabled = true;
            }

            Instruccion InstruccionEscritura = new Instruccion();
            InstruccionEscritura.InstruccionId = misInstrucciones.Count + 1;
            InstruccionEscritura.Tipo = 3;

            InstruccionEscritura.SimboloAEscribir = cmbEscritura.SelectedValue.ToString()[0];

            ActualizarListadoInstrucciones(InstruccionEscritura);

            cmbEscritura.SelectedIndex = 0;
        }

        //Instrucción: Búsqueda
        private void btnAgregarB_Click(object sender, EventArgs e)
        {
            if (!blnListaCreada)
            {
                misInstrucciones = new List<Instruccion>();
                blnListaCreada = true;
                btnIniciar.Enabled = true;
                btnBorrarInstrucciones.Enabled = true;
            }

            Instruccion InstruccionBusqueda = new Instruccion();
            InstruccionBusqueda.InstruccionId = misInstrucciones.Count + 1;

            if (radDerechaB.Checked && chkDiferenteB.Checked)
            {
                InstruccionBusqueda.Tipo = 6;
            }
            else
            {
                if(radIzquierdaB.Checked && chkDiferenteB.Checked)
                {
                    InstruccionBusqueda.Tipo = 7;
                }
                else
                {
                    if (radDerechaB.Checked)
                        InstruccionBusqueda.Tipo = 4;
                    else
                        InstruccionBusqueda.Tipo = 5;
                }
            }

            InstruccionBusqueda.SimboloBuscado = cmbBusqueda.SelectedItem.ToString()[0];

            ActualizarListadoInstrucciones(InstruccionBusqueda);

            radDerechaB.Checked = true;
            cmbBusqueda.SelectedIndex = 0;
            chkDiferenteB.Checked = false;
        }

        //Instrucción: Ir A
        private void btnAgregarI_Click(object sender, EventArgs e)
        {
            if (!blnListaCreada)
            {
                misInstrucciones = new List<Instruccion>();
                blnListaCreada = true;
                btnIniciar.Enabled = true;
                btnBorrarInstrucciones.Enabled = true;
            }

            Instruccion InstruccionIrA = new Instruccion();
            InstruccionIrA.InstruccionId = misInstrucciones.Count + 1;
            InstruccionIrA.Tipo = 8;

            InstruccionIrA.InstruccionIrA = int.Parse(numPaso.Value.ToString());
            InstruccionIrA.ParametrosIrA = txtCaracteresIrA.Text;

            ActualizarListadoInstrucciones(InstruccionIrA);

            numPaso.Value = 1;
            txtCaracteresIrA.Clear();
        }

        //Ejecución de Tareas
        int intInstruccionSiguiente = 1;

        private void EjecutarAcciones(Instruccion miInstruccion)
        {
            switch (miInstruccion.Tipo)
            {
                case 1:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.MoverDerecha();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 2:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.MoverIzquierda();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 3:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;

                    string strCaracterActual = miMT.Resultante[miMT.Cabezal - 1].ToString();
                    if (strCaracterActual == "*" || strCaracterActual == "#" || strCaracterActual == "$" || strCaracterActual == "_")
                    {
                        intInstruccionSiguiente = miInstruccion.Escribir(miMT.Variable);
                    }
                    else
                    {
                        intInstruccionSiguiente = miInstruccion.Escribir();
                    }
                    
                    miMT.Resultante = miInstruccion.Cinta;
                    break;
                case 4:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.BuscarDerecha();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 5:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.BuscarIzquierda();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 6:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.BuscarDiferenteDerecha();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 7:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.BuscarDiferenteIzquierda();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 8:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    intInstruccionSiguiente = miInstruccion.IrA();
                    miMT.Cabezal = miInstruccion.PosicionCabezal;
                    break;
                case 9:
                    miInstruccion.Cinta = miMT.Resultante;
                    miInstruccion.PosicionCabezal = miMT.Cabezal;
                    miMT.Variable = miInstruccion.Almacenar(ref intInstruccionSiguiente)[0];
                    //miMT.Variable = miMT.Resultante[miMT.Cabezal];
                    //miMT.Cabezal++;
                    break;
            }
            problemaParada = miInstruccion.VecesEjecutado;

            dtgCinta.Rows.Clear();
            string[] celdas = new string[miMT.Resultante.Length];
            char[] cinta = miMT.Resultante.ToCharArray();
            for (int i = 0; i < miMT.Resultante.Length; i++)
            {
                celdas[i] = cinta[i].ToString();
            }
            dtgCinta.Rows.Add(celdas);

            //Actualizar Cabezal
            dtgCinta.CurrentCell.Style.BackColor = Color.White;
            dtgCinta.CurrentCell.Style.ForeColor = Color.Black;
            dtgCinta.CurrentCell = dtgCinta[miMT.Cabezal - 1, 0];
            dtgCinta.CurrentCell.Style.BackColor = Color.FromArgb(61, 165, 206);
            dtgCinta.CurrentCell.Style.ForeColor = Color.White;
            dtgCinta.CurrentCell.Selected = false;
        }

        private void ActualizarDTG()
        {
            Instruccion miInstruccionActual = new Instruccion();
            bool blnEncontrado = false;

            foreach(Instruccion miInstruccionLocal in misInstrucciones)
            {
                if(miInstruccionLocal.InstruccionId == intInstruccionSiguiente)
                {
                    miInstruccionActual = miInstruccionLocal;
                    blnEncontrado = true;
                    break;
                }
            }

            if (blnEncontrado)
            {
                EjecutarAcciones(miInstruccionActual);
            }
            else
            {
                MessageBox.Show("Ha concluido el procedimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnIniciar.Enabled = false;
            }
        }

        //Boolean para el bloqueo del Creador de Instrucciones
        bool blnIniciado = false;
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (problemaParada >= 20)
                    throw new Exception("Se ha generado un problema de la parada.");
                ActualizarDTG();

                //Si ya se inició, marcar como Iniciado y desactivar Creador de Instrucciones
                if (!blnIniciado)
                {
                    tabCreadorInstruccion.Enabled = false;
                    blnIniciado = true;
                    tabCreadorInstruccion.SelectedIndex = 0;
                    btnBorrarInstrucciones.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //Borrar MT
            miMT = null;

            //Resetear la variable del problema de la parada
            problemaParada = 0;

            //Borrar Lista de Instrucciones
            misInstrucciones = null;
            blnListaCreada = false;

            //Limpieza de controles
            dtgCinta.CurrentCell = null;
            dtgCinta.Rows.Clear();
            dtgCinta.ScrollBars = ScrollBars.None;

            foreach (Control c in grpCinta.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            chkCEspecial1.Checked = false;
            chkCEspecial2.Checked = false;
            chkCEspecial3.Checked = false;

            foreach (Control c in grpEntrada.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }

            numCabezal.Value = 1;

            //Tab/////////////////////////
            intInstruccionSiguiente = 1;
            //Movimiento
            radDerechaM.Checked = true;
            //Escritura
            cmbEscritura.DataSource = null;
            //Búsqueda
            radDerechaB.Checked = true;
            cmbBusqueda.DataSource = null;
            //Ir a..
            numCabezal.Value = 1;
            txtCaracteresIrA.Clear();

            tabCreadorInstruccion.SelectedTab = tabMovimiento;
            //////////////////////////////

            lstInstrucciones.Items.Clear();

            //Bloqueo y Desbloqueo de controles
            grpCinta.Enabled = true;
            grpEntrada.Enabled = true;
            grpCabezal.Enabled = true;

            btnAceptar.Enabled = false;

            btnReiniciar.Enabled = false;
            btnNuevo.Enabled = false;
            btnIniciar.Enabled = false;
            tabCreadorInstruccion.Enabled = true;
        }


        bool blnBorrado = false;
        private void btnBorrarInstrucciones_Click(object sender, EventArgs e)
        {
            misInstrucciones = null;
            blnListaCreada = false;
            lstInstrucciones.Items.Clear();

            if(miMT != null)
            {
                miMT.Cabezal = int.Parse(numCabezal.Value.ToString());
            }

            //Actualizar Cabezal
            //dtgCinta.CurrentCell.Style.BackColor = Color.White;
            //dtgCinta.CurrentCell.Style.ForeColor = Color.Black;
            //dtgCinta.CurrentCell = dtgCinta[miMT.Cabezal - 1, 0];
            //dtgCinta.CurrentCell.Style.BackColor = Color.FromArgb(61, 165, 206);
            //dtgCinta.CurrentCell.Style.ForeColor = Color.White;
            //dtgCinta.CurrentCell.Selected = false;

            intInstruccionSiguiente = 1;

            btnIniciar.Enabled = false;

            //Bloquear Creador de Instrucciones cuando se haya iniciado la ejecución
            blnIniciado = false;
            tabCreadorInstruccion.Enabled = true;

            if (blnBorrado)
            {
                btnBorrarInstrucciones.Enabled = false;
                blnBorrado = false;
            }
            else
            {
                btnBorrarInstrucciones.Enabled = true;
                blnBorrado = true;
            }
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            if (txtEntrada.Text != null)
            {
                btnAceptar.Enabled = true;
            }
        }
    }
}
