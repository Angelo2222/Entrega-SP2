using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int intentos = 0;
            if (txtUsuario.Text == "Adm" && txtContrasenia.Text == "@1a" && (cmbModulo.Text == "ADM → Administración" || cmbModulo.Text == "COM → Compras" || cmbModulo.Text == "VTA → Ventas"))
            {
                this.Hide();
                frmInicio frmInicio = new frmInicio();
                frmInicio.ShowDialog();
            }
            else
            {
            if (txtUsuario.Text == "Jonh" && txtContrasenia.Text == "*2b" && cmbModulo.Text == "SIST → Sistemas")
            {
                    this.Hide();
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.ShowDialog();
            }
            else
            if (txtUsuario.Text == "Ceci" && txtContrasenia.Text == "@3c" && (cmbModulo.Text == "ADM → Administración" || cmbModulo.Text == "VTA → Ventas"))
            {
                    this.Hide();
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.ShowDialog();
            }
            else
            if (txtUsuario.Text == "God" && txtContrasenia.Text == "@4d" && (cmbModulo.Text == "ADM → Administración" || cmbModulo.Text == "COM → Compras" || cmbModulo.Text == "VTA → Ventas" || cmbModulo.Text == "SIST → Sistemas"))
            {
                    this.Hide();
                    frmInicio frmInicio = new frmInicio();
                    frmInicio.ShowDialog();
            }
            else
            {
                    MessageBox.Show("No so VO.");
                        intentos++; 
                    if (intentos == 2) 
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // evento Click del botón "btnCancelar"
            
            {
                this.Close(); // cierra el formulario
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
