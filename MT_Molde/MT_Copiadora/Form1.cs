﻿using System;
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
        List<Instruccion> misInstrucciones = new List<Instruccion>();

        private void Main_Load(object sender, EventArgs e)
		{
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
            //Movimiento
            radIzquierdaM.Checked = true;
            //Escritura
            cmbEscritura.DataSource = null;
            //Búsqueda
            radIzquierdaB.Checked = true;
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

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            Instruccion miInstruccion = new Instruccion();
            if (radIzquierdaM.Checked)
                miInstruccion.Tipo = 2;
            else
                miInstruccion.Tipo = 1;
            miInstruccion.InstruccionId = misInstrucciones.Count + 1;

            ActualizarListadoInstrucciones(miInstruccion);
        }
    }
}
