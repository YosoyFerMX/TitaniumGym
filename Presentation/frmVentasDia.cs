using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Titanium.Business;

namespace System_Titanium.Presentation
{
    public partial class frmVentasDia : Form
    {
        //private int id;
        //private 
        DataSet dsVentasDia = new DataSet();
        public frmVentasDia()
        {
            InitializeComponent();
        }

        private void frmVentasDia_Load(object sender, EventArgs e)
        {
            ConsultaPorFecha(TmpFech.Value);
        }

        private void ConsultaPorFecha(DateTime fecha) {
            
            dsVentasDia = CrudVentas.VentasDia(fecha);
            dgvVentasDia.Columns.Clear();
            if (dsVentasDia != null) {
                dgvVentasDia.DataSource = dsVentasDia.Tables[0];
                //dgvVentasDia.Columns["CAJERO"].Visible = false;
                dgvVentasDia.Columns["PAGO CON"].Visible = false;
                dgvVentasDia.Columns["CAMBIO"].Visible = false;
            }
                

        }

        private void TmpFech_ValueChanged(object sender, EventArgs e)
        {
            ConsultaPorFecha(TmpFech.Value);
            LimpiarCampos();
        }
        private void LimpiarCampos() {
            dgvTicket.Columns.Clear();
            
            lblCajero.Text = "";
            lblCambio.Text = "";
            lblFechaHora.Text = "";
            lblFolio.Text = "";
        }
        private void btnVentasHoy_Click(object sender, EventArgs e)
        {
            ConsultaPorFecha(DateTime.Now);
            TmpFech.Value = DateTime.Now;
            LimpiarCampos();
        }

        private void dgvVentasDia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var filaSel = dgvVentasDia.CurrentRow;
            if (filaSel != null)
            {
                lblCajero.Text = (string)filaSel.Cells["CAJERO"].Value;
                int idFol = (int)filaSel.Cells["FOLIO"].Value;
                lblFolio.Text = idFol.ToString();
                lblTotal.Text = ((decimal)filaSel.Cells["TOTAL"].Value).ToString("C2");
                lblCambio.Text = ((decimal)filaSel.Cells["CAMBIO"].Value).ToString("C2");
                lblPagoCon.Text = ((decimal)filaSel.Cells["PAGO CON"].Value).ToString("C2");
                lblFechaHora.Text = TmpFech.Value.ToString("yyyy/MM/dd") +" | Hora: "+ (string)filaSel.Cells["HORA"].Value.ToString();
                //
                //ventEditCant.updateCant((int)filaSel.Cells[0].Value, ((int)filaSel.Cells[5].Value));

                dsVentasDia = CrudVentas.ListaVentasDia(idFol);
                if (dsVentasDia != null)
                {
                    dgvTicket.Columns.Clear();
                    dgvTicket.DataSource = dsVentasDia.Tables[0];
                }
                else { dgvTicket.Columns.Clear(); }
                


            }
        }
    }
}
