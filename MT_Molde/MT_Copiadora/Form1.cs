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
		public Main()
		{
			InitializeComponent();
		}

        //Declaración de MT
        MT miMT;

        //Declaracion de lista de instrucciones
        List<Instruccion> misInstrucciones;
        bool blnListaCreada = false;

        private void Main_Load(object sender, EventArgs e)
		{
            btnNuevo.Enabled = false;
            btnReiniciar.Enabled = false;
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
                    //Creación de MT
                    miMT = new MT(int.Parse(numCabezal.Value.ToString()), txtAlfabeto.Text, txtCinta.Text, txtEntrada.Text);

                    if (miMT.Alfabeto != "" && miMT.Cinta != "" && miMT.Entrada != "")
                    {
                        //Bloqueo y Desbloqueo de controles
                        grpCinta.Enabled = false;
                        grpEntrada.Enabled = false;
                        grpCabezal.Enabled = false;
                        btnAceptar.Enabled = false;
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
            //Borrar MT
            miMT = null;

            //Borrar Lista de Instrucciones
            misInstrucciones = null;
            blnListaCreada = false;

            //Limpieza de controles
            dtgCinta.CurrentCell = null;
            dtgCinta.Rows.Clear();
            dtgCinta.ScrollBars = ScrollBars.None;

            foreach(Control c in grpCinta.Controls)
            {
                if(c is TextBox)
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
            btnAceptar.Enabled = true;
            btnNuevo.Enabled = false;
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
            }

            Instruccion InstruccionAlmacenar = new Instruccion();
            InstruccionAlmacenar.InstruccionId = misInstrucciones.Count + 1;
            InstruccionAlmacenar.Tipo = 9;

            ActualizarListadoInstrucciones(InstruccionAlmacenar);
        }

        //Instrucción: Escritura
        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            if (!blnListaCreada)
            {
                misInstrucciones = new List<Instruccion>();
                blnListaCreada = true;
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
                    intInstruccionSiguiente = miInstruccion.Escribir();
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
                    miMT.Variable = miMT.Resultante[miMT.Cabezal];
                    miMT.Cabezal++;
                    break;
            }

            string[] celdas = new string[miMT.Resultante.Length];
            char[] cinta = miMT.Resultante.ToCharArray();
            for (int i = 0; i < miMT.Resultante.Length; i++)
            {
                celdas[i] = cinta[i].ToString();
            }
            dtgCinta.Rows.Add(celdas);
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

                //Actualizar DTG
                //dtgCinta.Rows.Clear();
                //dtgCinta.ColumnCount = miMT.Entrada.Length;
                //string[] celdas = new string[miMT.Entrada.Length];
                //char[] cinta = miMT.Entrada.ToCharArray();
                //for (int i = 0; i < miMT.Entrada.Length; i++)
                //{
                //    celdas[i] = cinta[i].ToString();
                //}
                //dtgCinta.Rows.Add(celdas);

                //Actualizar Cabezal
                //dtgCinta.CurrentCell.Style.BackColor = Color.White;
                //dtgCinta.CurrentCell.Style.ForeColor = Color.Black;
                //dtgCinta.CurrentCell = dtgCinta[miMT.Cabezal - 1, 0];
                //dtgCinta.CurrentCell.Style.BackColor = Color.FromArgb(61, 165, 206);
                //dtgCinta.CurrentCell.Style.ForeColor = Color.White;
                //dtgCinta.CurrentCell.Selected = false;
            }
            else
            {
                MessageBox.Show("Ha concluido el procedimiento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //tmrEjecucion.Enabled = false;
                //tmrEjecucion.Stop();
            }
        }

        private void tmrEjecucion_Tick(object sender, EventArgs e)
        {
            ActualizarDTG();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ActualizarDTG();
            //if(tmrEjecucion.Enabled)
            //{
            //    btnIniciar.Text = "Iniciar";
            //    tmrEjecucion.Enabled = true;
            //    //tmrEjecucion.Start();
            //}
            //else
            //{
            //    btnIniciar.Text = "Detener";
            //    tmrEjecucion.Enabled = false;
            //    //tmrEjecucion.Stop();
            //}
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
