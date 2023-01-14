using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Titanium.usersControl;
using System_Titanium.Business;

namespace System_Titanium.Presentation
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

            rdbActivos.Checked = true;
            
        }

        private void refreshDGV() {
            dgvClients.Columns.Clear();
            DataSet SociosSelect = new DataSet();
            SociosSelect = CrudSocios.SociosMensSelect();
            var sociosActivos = new DataSet();
            sociosActivos = CrudSocios.SociosMensActivos();
            var sociosVencidos = new DataSet();
            sociosVencidos = CrudSocios.SociosMensVencidos();

            if (rdbTodos.Checked == true && SociosSelect != null) {
                dgvClients.DataSource = SociosSelect.Tables[0].DefaultView; txtSearchName.Text = "";
                this.dgvClients.Columns["photo"].Visible = false;
            } else if (rdbActivos.Checked) {
                if(sociosActivos != null)
                    dgvClients.DataSource = sociosActivos.Tables[0].DefaultView; txtSearchName.Text = "";
                    this.dgvClients.Columns["photo"].Visible = false;
            } else if (rdbProxVen.Checked) {
                if (sociosActivos != null) {
                    dgvClients.DataSource = sociosActivos.Tables[0].DefaultView; txtSearchName.Text = "";
                    this.dgvClients.Columns["photo"].Visible = false;
                    int filas = dgvClients.Rows.Count;
                    int cont = 1;
                    for (int i = 0; i < filas; i++)
                    {
                        DateTime fecha = (DateTime)dgvClients.Rows[i].Cells[4].Value;
                        TimeSpan difDias = fecha - DateTime.Now;


                        if (difDias.TotalDays > 5) //Conteo para saber quienes son los clientes que estan pronto a vencer
                        {
                            dgvClients.Rows.Remove(dgvClients.Rows[i]);
                            i -= 1;
                        }

                        if (cont == filas - 1)
                        {
                            break;
                        }
                        cont += 1;
                    }
                }
            } else if (rdbVencidos.Checked) {
                if (sociosVencidos != null) {
                    dgvClients.DataSource = sociosVencidos.Tables[0].DefaultView; txtSearchName.Text = "";
                    this.dgvClients.Columns["photo"].Visible = false;
                }
                    
            }
            
         
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void pnlEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("-> Para eliminar el registro completamente incluyendo del control de ingresos de click en 'SI'\n\n->Si desea eliminar solo de la presente tabla conservando el ingreso de click en 'NO'","Eliminar Registro", MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == result) {
                var filaSelected = dgvClients.CurrentRow;
                if (filaSelected != null)
                {
                    int id = (int)filaSelected.Cells[0].Value;
                    CrudSocios.DeleteMensualidad(id);
                    refreshDGV();
                }
                MessageBox.Show("El registro se elimno correctamente"); 
            }
        }

        private void btnConfSocios_Click(object sender, EventArgs e)
        {
            frmCrudClientes abrirSocios = new frmCrudClientes();
            abrirSocios.ShowDialog();
            refreshDGV();
        }

        private void btnNvaMen_Click(object sender, EventArgs e)
        {
            frmAgregarMensu agregarMen = new frmAgregarMensu();
            agregarMen.ShowDialog();
            refreshDGV();

        }

        private void rdbActivos_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbActivos.Checked)
                refreshDGV();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTodos.Checked)
                refreshDGV();
        }

        private void rdbVencidos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVencidos.Checked)
                refreshDGV();
        }

        private void rdbProxVen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProxVen.Checked)
                refreshDGV();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = dgvClients.DataSource;
            bs.Filter = "SOCIO like '%" + txtSearchName.Text + "%'";
            dgvClients.DataSource = bs;
        }

        private void btnEditParam_Click(object sender, EventArgs e)
        {
            frmAgregarMensu editarMens = new frmAgregarMensu();
            var filaSelected = dgvClients.CurrentRow;
            if (filaSelected != null)
            {
                editarMens.renovarytur = true;
                editarMens.idMensualidad = (int)filaSelected.Cells[0].Value;
                editarMens.nombreSocio = (string)filaSelected.Cells[1].Value;
                editarMens.fechaFinal = (DateTime)filaSelected.Cells["FIN PERIODO"].Value;
                editarMens.ShowDialog();
                refreshDGV();
            }
            else
            {
                MessageBox.Show("Seleccione alguna fila");
            }
        
        }

        private void dgvClients_DoubleClick(object sender, EventArgs e)
        {
            var filaSel = dgvClients.CurrentRow;
            if (filaSel != null && filaSel.Cells["photo"].Value != DBNull.Value) {
                
                string rura = (string)filaSel.Cells["photo"].Value;

                frmWebCam abrirFoto = new frmWebCam();
                abrirFoto.visualizador = true;
                abrirFoto.pathVisualizador = rura;
                abrirFoto.ShowDialog();
                
            }
        }

        private void btnConfPrecios_Click(object sender, EventArgs e)
        {
            frmAjustAreas openPre = new frmAjustAreas();
            openPre.ShowDialog();
        }
    }
}
