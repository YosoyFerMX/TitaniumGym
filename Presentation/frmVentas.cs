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
using System_Titanium.usersControl;

namespace System_Titanium.Presentation
{
    public partial class frmVentas : Form, IContract, IComprasUPDATE
    {
        //private double sumaPrecio = 0;
        private decimal SumTotal = 0, mult, granTototal;

        public frmVentas()
        {
            InitializeComponent();
        }
        public void EjecCantidad(int id, int cant) {
            //recibe parametros id y cantidad
            int valueID = 0;
            for (int fil = 0; fil <= dgvVentas.Rows.Count -1; fil ++) {
                valueID = (int)dgvVentas.Rows[fil].Cells[0].Value;
                if (valueID == id) {
                    int existencia = (int)dgvVentas.Rows[fil].Cells[3].Value;
                    dgvVentas.Rows[fil].Cells[5].Value = cant;
                    dgvVentas.Rows[fil].Cells[4].Value = ((decimal)dgvVentas.Rows[fil].Cells[2].Value * cant);
                    dgvVentas.Rows[fil].Cells[3].Value = (existencia);
                    
                    break;
                }
            }
            
            SumaTotal();

        }
        public void Ejecutar(int id, string producto,decimal precioCosto, decimal precio, int existencia) {
            bool existenciaInList = false;
            int val = 0;
            for (int fila = 0; fila < dgvVentas.Rows.Count; fila ++) {
                val = (int)dgvVentas.Rows[fila].Cells[0].Value;
                if ( val == id)
                {
                    int cant = (int)dgvVentas.Rows[fila].Cells[5].Value;
                    dgvVentas.Rows[fila].Cells[5].Value = cant + 1;
                    dgvVentas.Rows[fila].Cells[4].Value = ((decimal)dgvVentas.Rows[fila].Cells[2].Value * cant);
                    //dgvVentas.Rows[fila].Cells[3].Value = (decimal);
                    existenciaInList = true;
                }
            
            }
            // ---------------> FALLOS EN LA SUMA GLOBAL DEL DATA GRID VIEW "SOLUCIONAR!!!!!"
            if (existenciaInList == false) {
                int n = dgvVentas.Rows.Add();
                dgvVentas.Rows[n].Cells[0].Value = id;
                dgvVentas.Rows[n].Cells[1].Value = producto;
                dgvVentas.Rows[n].Cells[2].Value = precio;
                dgvVentas.Rows[n].Cells[3].Value = existencia;
                dgvVentas.Rows[n].Cells[4].Value = precio;
                dgvVentas.Rows[n].Cells[5].Value = 1;
                dgvVentas.Rows[n].Cells[6].Value = precioCosto;
                dgvVentas.Columns[6].Visible = false;

                //sumaPrecio = sumaPrecio + precio;
                //txtTotal.Text = sumaPrecio.ToString();
            }
            
            
            SumaTotal();

        }


        private void SumaTotal() {
            for (int fila = 0; fila < dgvVentas.Rows.Count; fila++)
            {
                mult = (decimal)dgvVentas.Rows[fila].Cells[2].Value * (int)dgvVentas.Rows[fila].Cells[5].Value;
                SumTotal = SumTotal + mult;
               
            }
            //MessageBox.Show("Total: " + SumTotal);
            lblTotal.Text = SumTotal.ToString();
            granTototal = SumTotal;
            mult = 0;
            SumTotal = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBuys prod = new frmBuys();
            prod.contrato = this;
            prod.confirmationBuy = true;
            prod.ShowDialog();  
            
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {

            SumaTotal();
            frmPagar pagar = new frmPagar();
            pagar.totales(granTototal);
            pagar.ShowDialog();
            var fecha = DateTime.Now.ToString("yyyy'/'MM'/'dd HH:mm:ss");
            CrudVentas.Insert_Ticket(1,fecha,Global.pagoCon,Global.cambio,granTototal);
            int folio = (int)CrudVentas.FolioTicket().Tables[0].Rows[0]["folioTicket"];
            for (int fila = 0; fila < dgvVentas.Rows.Count; fila++) {
                CrudVentas.Insert_Venta(folio,(int)dgvVentas.Rows[fila].Cells[0].Value,(string)dgvVentas.Rows[fila].Cells[1].Value,(int)dgvVentas.Rows[fila].Cells[5].Value, (decimal)dgvVentas.Rows[fila].Cells[2].Value, (decimal)dgvVentas.Rows[fila].Cells[4].Value, (decimal)dgvVentas.Rows[fila].Cells[6].Value);
            }

            dgvVentas.Rows.Clear();    
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfprod_Click(object sender, EventArgs e)
        {
            frmBuys prod = new frmBuys();
            prod.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentasDia abrirVentas = new frmVentasDia();
            abrirVentas.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
                return;

            dgvVentas.Rows.Remove(dgvVentas.CurrentRow);
            SumaTotal();
        }


        private void dgvVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdCant ventEditCant = new frmUpdCant();
            ventEditCant.Exec = this;
            var filaSel = dgvVentas.CurrentRow;
            if (filaSel != null)
            {
                // contrato.Ejecutar((int)filaSel.Cells[0].Value, (string)filaSel.Cells[1].Value, ((double)filaSel.Cells[3].Value), ((int)filaSel.Cells[5].Value));

                ventEditCant.updateCant((int)filaSel.Cells[0].Value, ((int)filaSel.Cells[5].Value));



            }
            else { MessageBox.Show("Seleccione alguna fila"); }


            ventEditCant.ShowDialog();
        }
    }
}
