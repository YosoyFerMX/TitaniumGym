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
using System_Titanium.Reportes;

namespace System_Titanium.Presentation
{
    public partial class frmAjustesCaja : Form
    {
        private decimal monto;
        public frmAjustesCaja()
        {
            InitializeComponent();
        }

        private void frmAjustesCaja_Load(object sender, EventArgs e)
        {
            monto = (decimal)CrudCaja.VerConfCaja().Tables[0].Rows[0]["montoCaja"];
            txtMontCaja.Text = monto.ToString("C2");
            if (CrudCaja.VerCortes() != null) {
                dgvCortes.DataSource = CrudCaja.VerCortes().Tables[0].DefaultView;
                dgvCortes.Columns["montoEnCaja"].Visible = false;
            }

            foreach (DataGridViewColumn column in dgvCortes.Columns)    //deshabilitar el click y  reordenamiento por columnas
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void txtMontCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try {
                CrudCaja.UpdateMontoCaja(decimal.Parse(txtMontCaja.Text));
                MessageBox.Show("¡¡HECHO!!");
            }
            catch (Exception ms) {
                MessageBox.Show("No se realizó la acción.\nSalga y vuelva a intentarlo" + "\n" + ms);
            }
        }

        private void dgvCortes_DoubleClick(object sender, EventArgs e)
        {
            var filaSel = dgvCortes.CurrentRow;
            if (filaSel != null && filaSel.Cells["ID"].Value != DBNull.Value)
            {

                int id = (int)filaSel.Cells["ID"].Value;
                string nombre = (string)filaSel.Cells["USUARIO"].Value;
                decimal montoCon = (decimal)filaSel.Cells["MONTO CONTADO"].Value;
                decimal montoCAL = (decimal)filaSel.Cells["MONTO CALCULADO"].Value;
                decimal diferencia = (decimal)filaSel.Cells["DIFERENCIA"].Value;
                decimal retirado = (decimal)filaSel.Cells["RETIRADO"].Value;
                DateTime fecha = (DateTime)filaSel.Cells["FECHA DE CORTE"].Value;
                decimal montoEnCaja = (decimal)filaSel.Cells["montoEnCaja"].Value;
                ReportCaja reporte = new ReportCaja();
                int corteAnt = filaSel.Index;
                int idCorteAnterior = (int)dgvCortes.Rows[corteAnt + 1].Cells["ID"].Value;
                reporte.PrintReporteCaja(id,nombre,montoCon,montoCAL,diferencia,retirado,fecha, idCorteAnterior, montoEnCaja);

                

            }
        }
    }
}
