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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Creación de MT
                miMT = new MT(int.Parse(numCabezal.Value.ToString()), txtAlfabeto.Text, txtEntrada.Text);
                //Bloqueo y Desbloqueo de controles
                grpCinta.Enabled = false;
                grpEntrada.Enabled = false;
                btnAceptar.Enabled = false;
                btnNuevo.Enabled = true;
                //Crear columnas y Colocar datos en la cinta (DataGrid)
                for (int i = 0; i < miMT.Entrada.Length; i++)
                {
                    dtgCinta.Columns.Add(miMT.Entrada[i].ToString(), "");
                }

                dtgCinta.Rows.Add();

                for (int i = 0; i < miMT.Entrada.Length; i++)
                {
                    dtgCinta.Rows[0].Cells[i].Value = miMT.Entrada[i];
                }

                //Agregar Lista de Caracteres a controles de tabCrearInstrucción

                ////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Borrar MT
            miMT = null;

            //Limpieza de controles
            dtgCinta.Rows.Clear();

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
            cmbEscritura.Items.Clear();
            //Búsqueda
            radIzquierdaB.Checked = true;
            cmbBusqueda.Items.Clear();
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
    }
}
