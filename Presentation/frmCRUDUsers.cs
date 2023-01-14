using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Titanium.usersControl;
using System.Windows.Forms;
using System_Titanium.Business;
using System_Titanium.Date;

namespace System_Titanium.Presentation
{
    public partial class frmCRUDUsers : Form
    {

        private int btnAccion = 0;
        private int id = 0;
        public frmCRUDUsers()
        {
            InitializeComponent();
        }

        private void frmCRUDUsers_Load(object sender, EventArgs e)
        {


            //LLEnar DGV al abrir Usuarios}

            refreshDGV();

            //dgvUsuarios.DataSource
            //CrudUsers.Usuarios();
            //dgvUsuarios.Rows[0].Cells[0].Value = Conexion.ds.Tables[0].Rows[0]["uName"].ToString();


            //dgvUsuarios.Rows[0].Cells[1].Value = CrudUsers.Usuarios().Tables[0].Rows[0]["uNameUser"].ToString();

            //dgvUsuarios.Rows.Add(Conexion.ds.Tables[0].Rows[0]["uName"].ToString());
        }

        //refrescar taba
        private void refreshDGV() {
            if(CrudUsers.Usuarios()!=null)
                dgvUsuarios.DataSource = CrudUsers.Usuarios().Tables[0].DefaultView;

        }

        //Limpiar campos
        private void limpiarCampos() {
            txtUser.Text = "";
            txtPssw.Text = "";
            txtTel.Text = "";
            txtNiv.Text = "";
        }



        private void validaCampos() {
            var validar = !string.IsNullOrEmpty(txtPssw.Text) && !string.IsNullOrEmpty(txtTel.Text) && !string.IsNullOrEmpty(txtUser.Text);

            btnGuardar.Enabled = validar;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtPssw_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {
            validaCampos();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nivel = "";
            if (txtNiv.SelectedIndex == 0) {
                nivel = "Super Administrador";
            } else if (txtNiv.SelectedIndex == 1) { nivel = "Administrador"; }
            if (btnAccion == 1)
            {
                CrudUsers.UpdateUsers(id, txtUser.Text, txtPssw.Text, txtTel.Text, nivel);
                btnAccion = 0;
                limpiarCampos();
                refreshDGV();

            }
            else {
                //int nivel = int.Parse(txtNiv.Text);
                CrudUsers.Insert_Usuarios(txtUser.Text, txtPssw.Text, txtTel.Text, nivel);
                limpiarCampos();
                refreshDGV();
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var filaSelected = dgvUsuarios.CurrentRow;
            if (filaSelected != null) {
                id = (int)filaSelected.Cells[0].Value;

                DialogResult result = MessageBox.Show("¿Desea elimiar usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel);

                if (DialogResult.OK == result) {

                    CrudUsers.DeleteUsers(id);
                    refreshDGV();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            var filaSelected = dgvUsuarios.CurrentRow;
            if (filaSelected != null)
            {
                btnAccion = 1;
                id = (int)filaSelected.Cells[0].Value;
                txtUser.Text = (string)filaSelected.Cells[1].Value;
                txtPssw.Text = (string)filaSelected.Cells[2].Value;
                txtTel.Text = (string)filaSelected.Cells[3].Value;
                txtNiv.Text = ((string)filaSelected.Cells[4].Value).ToString();

            }
            else {
                MessageBox.Show("Seleccione alguna fila");
            }
        }
    }
}
