using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Titanium.Business;
using System.IO;

namespace System_Titanium.Presentation
{
    public partial class frmCrudClientes : Form
    {
        //public string path = @"C:\Users\SoyFer\Documents\PROYECTIOS PERSONALES\GYM\System_Titanium\Presentation\SociosImage\";
        public string path = Application.StartupPath + @"\SociosImage\";
        private int idSocio;
        private bool editarCli;
        public bool confirmacion;
        public frmCrudClientes()
        {
            InitializeComponent();
        }

        private void refreshDGV() {
            
            //dgvSocios.Rows.Clear();
            if (CrudSocios.SociosSelect() != null)
            {
                dgvSocios.DataSource = CrudSocios.SociosSelect().Tables[0].DefaultView;
                this.dgvSocios.Columns["photo"].Visible = false;
            }
            else { MessageBox.Show("No existen Socios"); }

        }

        private void cleanCampos() {
            txtNom.Clear();
            txtTel.Clear();
            txtCorr.Clear();
            pictureSocio.Image = null;
        }
        private void frmCrudClientes_Load(object sender, EventArgs e)
        {
            if (confirmacion == true) {
                gbSocios.Visible = false;
                dgvSocios.Size = new Size(960, 380);
                btnDelete.Visible = false;
                btnEdit.Visible = false;
            }
            btnGuardar.Enabled = false;
            refreshDGV();
        }

        private void Validar_campos()
        {

            var vr = !string.IsNullOrEmpty(txtNom.Text) && !string.IsNullOrEmpty(txtTel.Text) && !string.IsNullOrEmpty(txtCorr.Text);

            btnGuardar.Enabled = vr;

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            Validar_campos();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            Validar_campos();
        }

        private void txtCorr_TextChanged(object sender, EventArgs e)
        {
            Validar_campos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cleanCampos();
            var filaSelected = dgvSocios.CurrentRow;
            if (filaSelected != null)
            {
                editarCli = true;
                idSocio = (int)filaSelected.Cells[0].Value;
                txtNom.Text = (string)filaSelected.Cells[1].Value;
                txtTel.Text = ((string)filaSelected.Cells[2].Value);
                txtCorr.Text = ((string)filaSelected.Cells[3].Value);
                if (filaSelected.Cells[5].Value != DBNull.Value) {
                    string path = ((string)filaSelected.Cells[5].Value);
                    try {
                        //pictureSocio = new PictureBox();
                        pictureSocio.Load(path);
                    }
                    catch{
                        MessageBox.Show("No se encontró la foto del cliente, agregue una foto");
                    }
                    
                }
            
                
            }
            else
            {
                MessageBox.Show("Seleccione alguna fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editarCli == true)
            {
                //Update
                //Global.photo.Image.Save(path +txtTel.Text +".jpg", ImageFormat.Jpeg);
                pictureSocio.Dispose();
                try {
                    Global.photo.Image.Save(path + txtTel.Text + "SOCIO.jpg", ImageFormat.Jpeg);
                    CrudSocios.UpdateSocio(idSocio, 1, txtNom.Text, txtTel.Text, txtCorr.Text, path + txtTel.Text + "SOCIO.jpg");
                    cleanCampos();
                    editarCli = false;
                    
                }
                catch{
                    MessageBox.Show("Ocurrió un problema al actualizar la foto, por favor cierre la ventana e intentelo de nuevo");
                }
                
                
                
                
            }
            else {
                //Insert
                pictureSocio.Image.Save(path + txtTel.Text + "SOCIO.jpg", ImageFormat.Jpeg);
                CrudSocios.Insert_Socio(1,txtNom.Text,txtTel.Text,txtCorr.Text, path +txtTel.Text + "SOCIO.jpg");
                
                cleanCampos();
            }
            
            pictureSocio = new PictureBox();
            refreshDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var filaSelected = dgvSocios.CurrentRow;
            if (filaSelected != null)
            {
                idSocio = (int)filaSelected.Cells[0].Value;
                string path = (string)filaSelected.Cells[5].Value;
                DialogResult result = MessageBox.Show("¿Desea elimiar socio?\n¡Advertencia! Tome en cuenta que al eliminar el socio, también se borrarán los registros asociados a este", "Eliminar Socio", MessageBoxButtons.OKCancel);

                if (DialogResult.OK == result) {
                    try
                    {
                        CrudSocios.DeleteSocio(idSocio);
                        bool resultFile = File.Exists(path);
                        if (resultFile == true) {
                            //MessageBox.Show("ARCHIVO ENCONTRADO");
                            File.Delete(path);

                        }
                        refreshDGV();
                        MessageBox.Show("El Socio se eliminó correctamente");
                    }
                    catch { MessageBox.Show("Error al elimiar Socio"); }
                    
                     
                }  
            }
            else
            {
                MessageBox.Show("Seleccione alguna fila");
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvSocios.DataSource;
            bs.Filter = "SOCIO like '%" + txtSearchName.Text + "%'";
            dgvSocios.DataSource = bs;
        }

        private void dgvSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (confirmacion == true) {
                var filaSelected = dgvSocios.CurrentRow;
                if (filaSelected != null)
                {
                    Global.idSocio = (int)filaSelected.Cells[0].Value;
                    Global.nombreSocio = (string)filaSelected.Cells[1].Value;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione alguna fila");
                }
            }
      
        }

        private void btnAbrirCamara_Click(object sender, EventArgs e)
        {

            if (txtNom.Text != "" && txtTel.Text != "")
            {
                frmWebCam abrirCam = new frmWebCam();
                Global.nombreSocio = txtTel.Text;
                abrirCam.ShowDialog();
                frmCrudClientes cli = new frmCrudClientes();
                
            }
            else {
                MessageBox.Show("Es necesario rellenar los campos");
            }
            if (Global.photo != null) {
                
                pictureSocio.Image = Global.photo.Image;
            }
                
            

        }
    }
}
