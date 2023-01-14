using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Titanium
{
    public partial class frmLoguin : Form
    {
        
        public frmLoguin()
        {
            InitializeComponent();
        }


        //VALIDACION DE CAMPOS POR MEDIO DE SET PROVIDER
        private bool validarCampos() 
        {
            bool ok = true;

            if (txbUsuario.Text == "" || txbPssw.Text == "") {
                ok = false;
                ErrProvUsuario.SetError(txbUsuario, "Ingresar Usuario");
                errProvPssw.SetError(txbPssw, "Ingresar Contraseña");
            }

            return ok;
        }


        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            if (validarCampos() == true) {
                frmMain main = new frmMain();
                this.Hide();
                main.Show();
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txbPssw_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nombreDeTuBoton.PerformClick();
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                btnIniciarSesion.PerformClick();
            }
        }

        private void frmLoguin_Load(object sender, EventArgs e)
        {

        }
    }
}
