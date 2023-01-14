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
    public partial class frmBuys : Form
    {

        public IContract contrato { get; set; }

        private int btnAccion = 0;
        private int id = 0;
        public bool confirmationBuy;
        

        public frmBuys()
        {
            InitializeComponent();
        }


        private void frmBuys_Load(object sender, EventArgs e)
        {

            // traer productos
            refreshDGV();
            //cavias campos
            vaciarCampos();

            // desabilitar boton uardar
            btnGuardar.Enabled = false;
            txtGanancia.Enabled = false;
            txtExistencia.Enabled = false;
            if (confirmationBuy == true)
            {
                gbVentas.Visible = false;
                dgvProductos.Size = new Size(1100,375);
                btnDelete.Visible = false;
                btnEdit.Visible = false;
                dgvProductos.Columns["Precio Compra"].Visible = false;
            }
            else { btnAgregarCompra.Enabled = false; }
            
        }

        private void refreshDGV()
        {
            DataSet dsProd = new DataSet();
            dsProd = CrudProductos.Productos();
            if (dsProd != null)
                dgvProductos.DataSource = dsProd.Tables[0];
        }

        private void validarCampos()
        {
            var validar = !string.IsNullOrEmpty(txtNom.Text) &&
                !string.IsNullOrEmpty(txtPrecioCosto.Text) && !string.IsNullOrEmpty(txtVenta.Text) && !string.IsNullOrEmpty(txtGanancia.Text) && !string.IsNullOrEmpty(txtAgregarExis.Text) &&
                !string.IsNullOrEmpty(txtExistencia.Text);

            btnGuardar.Enabled = validar;
        }

        private void vaciarCampos() {
            txtNom.Text = "";
            txtPrecioCosto.Text = (0).ToString();
            txtGanancia.Text = (0).ToString();
            txtVenta.Text = (0).ToString();
            txtExistencia.Text = 0.ToString();
            txtAgregarExis.Text = 0.ToString();
        }

        private void selectIndex() {
            var filaSel = dgvProductos.CurrentRow;
            if (filaSel != null)
            {
                if (confirmationBuy == true)
                {
                    contrato.Ejecutar((int)filaSel.Cells[0].Value, (string)filaSel.Cells[1].Value, (decimal)filaSel.Cells[2].Value, (decimal)filaSel.Cells[3].Value, ((int)filaSel.Cells[5].Value));
                    this.Close();
                }
                else {
                    btnAccion = 1;
                    id = (int)filaSel.Cells[0].Value;
                    txtNom.Text = (string)filaSel.Cells[1].Value;
                    txtPrecioCosto.Text = ((decimal)filaSel.Cells[2].Value).ToString();
                    txtVenta.Text = ((decimal)filaSel.Cells[3].Value).ToString();
                    txtGanancia.Text = ((decimal)filaSel.Cells[4].Value).ToString();
                    txtExistencia.Text = ((int)filaSel.Cells[5].Value).ToString();
                }
                 
            }
            else { MessageBox.Show("Seleccione alguna fila"); }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var filaSelected = dgvProductos.CurrentRow;
            if (filaSelected != null)
            {
                id = (int)filaSelected.Cells[0].Value;

                DialogResult result = MessageBox.Show("¿Desea elimiar el producto?", "Eliminar Producto", MessageBoxButtons.OKCancel);

            }
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            validarCampos();

            if (txtPrecioCosto.Text != "")
            {
                txtGanancia.Enabled = true;
            }
            else { txtGanancia.Enabled = false; }
            
        }

        private void txtGanancia_TextChanged(object sender, EventArgs e)
        {
           // validarCampos();

            
            


        }

        private void txtVenta_TextChanged(object sender, EventArgs e)
        {
            validarCampos();

        }

        private void txtExistencia_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void txtStockMin_TextChanged(object sender, EventArgs e)
        {
            validarCampos();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var filaSelected = dgvProductos.CurrentRow;
            if (filaSelected != null)
            {
                btnAccion = 1;
                id = (int)filaSelected.Cells[0].Value;
                txtNom.Text = (string)filaSelected.Cells[1].Value;
                txtPrecioCosto.Text = ((decimal)filaSelected.Cells[2].Value).ToString();
                txtVenta.Text = ((decimal)filaSelected.Cells[3].Value).ToString();
                txtGanancia.Text = ((decimal)filaSelected.Cells[4].Value).ToString();
                txtExistencia.Text = ((int)filaSelected.Cells[5].Value).ToString();

            }
            else
            {
                MessageBox.Show("Seleccione alguna fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //int stockMin = int.Parse(txtStockMin.Text);

            int sumaExistencia = int.Parse(txtAgregarExis.Text) + int.Parse(txtExistencia.Text);
            if (btnAccion == 1)
            {
                //EDITAR PRODUCTOS
                try
                {
                    CrudProductos.UpdateProd(id, txtNom.Text, decimal.Parse(txtPrecioCosto.Text), decimal.Parse(txtVenta.Text), decimal.Parse(txtGanancia.Text), sumaExistencia);
                    btnAccion = 0;
                    vaciarCampos();
                    refreshDGV();
                }
                catch {
                    MessageBox.Show("Error al actualizar producto, por favor salga de la ventana actual e inténtelo de nuevo");                
                }

                

            }
            else
            {
                //int nivel = int.Parse(txtNiv.Text);

                //INSERTAR PRODUCTOS

                try
                {
                    CrudProductos.Insert_Productos(id, txtNom.Text, decimal.Parse(txtPrecioCosto.Text), decimal.Parse(txtVenta.Text),
                    decimal.Parse(txtGanancia.Text), sumaExistencia);
                    vaciarCampos();
                    refreshDGV();
                }
                catch {
                    MessageBox.Show("Error al insertar producto, por favor salga de la ventana actual e inténtelo de nuevo");
                }
                
            }


        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            //Filtrar por nombre

            BindingSource bs = new BindingSource();

            bs.DataSource = dgvProductos.DataSource;
            bs.Filter = "Producto like '%" + txtSearchName.Text + "%'";
            dgvProductos.DataSource = bs;
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            selectIndex();
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            selectIndex();
        }

        private void txtPrecioCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void txtGanancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void txtVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void txtGanancia_ValueChanged(object sender, EventArgs e)
        {
            if (txtGanancia.Text == "")
            {
                txtGanancia.Text = (0).ToString();

            }

            

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            decimal precioCompra = decimal.Parse(txtPrecioCosto.Text);
            decimal porcentaje = (precioCompra / 100) * decimal.Parse(txtGanancia.Text);
            txtVenta.Text = (precioCompra + porcentaje).ToString();
        }
    }

}
