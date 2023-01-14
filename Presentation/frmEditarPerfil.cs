using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Titanium.Presentation
{
    public partial class frmEditarPerfil : Form
    {
        public frmEditarPerfil()
        {
            InitializeComponent();
        }

        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog imgBrowser = new OpenFileDialog();
            imgBrowser.Filter = "Archivos de Imagen|* .jpg";
            imgBrowser.InitialDirectory = "C:\\";
            if (imgBrowser.ShowDialog() == DialogResult.OK) {

                picbBuscarImg.ImageLocation = imgBrowser.FileName;
                picbBuscarImg.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validarCampos()
        {
            var var = !string.IsNullOrEmpty(txtNvaContra.Text) && !string.IsNullOrEmpty(txtRepContra.Text) &&
                !string.IsNullOrEmpty(txtUsuario.Text);
            btnGuardar.Enabled = var;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtNvaContra.Text == txtRepContra.Text)
            {
                //accion despues de validar -> GUARDAR EN LA BD
            }
            else { MessageBox.Show("Revise las contraseñas"); }

        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtNvaContra_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtRepContra_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }
    }
}
