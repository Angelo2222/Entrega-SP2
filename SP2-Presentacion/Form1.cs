using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prysp2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex != -1)
            {
                cmbPersonas.Enabled = true;
            }
            if (cmbTipo.Text == "A")
            {
                cmbPersonas.Items.Clear(); 
                cmbPersonas.Items.Add(1);
                cmbPersonas.Items.Add(2);
                cmbPersonas.Items.Add(3);
                cmbPersonas.Items.Add(4);
            }
            if (cmbTipo.Text == "B")
            {
                cmbPersonas.Items.Clear();
                cmbPersonas.Items.Add(1);
                cmbPersonas.Items.Add(2);
                cmbPersonas.Items.Add(3);
                cmbPersonas.Items.Add(4);
                cmbPersonas.Items.Add(5);
                cmbPersonas.Items.Add(6);
                cmbPersonas.Items.Add(7);
                cmbPersonas.Items.Add(8);
            }
        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPersonas.SelectedIndex !=-1)
            {
                cmbDias.Enabled = true;
            }
        }

        private void mrcAdi_Enter(object sender, EventArgs e)
        {
            
        
        }
        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char. IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Unicamente Numeros");
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbDias.SelectedIndex != -1)
            {
                mrcAdi.Enabled = true;
                mrcFormadepago.Enabled = true;
            }
        }

        private void lblDias_Click(object sender, EventArgs e)
        {

        }

        private void mrcFormadepago_Enter(object sender, EventArgs e)
        {

        }

        private void cmbTarjetas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTarjetas.SelectedIndex != -1)
            {
                mrcTitular.Enabled = true;
            }
        }

        private void optTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked)
            {
                cmbTarjetas.Enabled = true;
            }
        }

        private void optEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked)
            {
                cmbTarjetas.Enabled = false;
            }
            if (optEfectivo.Checked)
            {
                mrcTitular.Enabled = true;
            }
        }

        private void mrcTitular_Enter(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtTelefono.Text != "")
            {
                this.lblResumen.Text = "Nombre: " + this.txtNombre.Text + "\n" + "Telefono: " + this.txtTelefono.Text + "\n" + "Cabaña tipo: " + this.cmbTipo.Text + "\n" + "Cantidad de Personas: " + this.cmbPersonas.Text + "\n" + "Dias: " + this.cmbDias.Text;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
