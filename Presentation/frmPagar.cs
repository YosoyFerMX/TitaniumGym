using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_Titanium.Presentation;
using System.Windows.Forms;

namespace System_Titanium.Presentation
{
    public partial class frmPagar : Form
    {
           
        public frmPagar()
        {
            InitializeComponent();
        }

        public void totales(decimal total) {

            lblTotal.Text = total.ToString();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            double cambio = 0;

            if (txtEfectivo.Text == "" ) { 
                txtEfectivo.Text = (0).ToString();

            }

            cambio = double.Parse(txtEfectivo.Text) - double.Parse(lblTotal.Text);

            lblCambio.Text = cambio.ToString();
        }

        private void frmPagar_Load(object sender, EventArgs e)
        {
            txtEfectivo.Text = lblTotal.Text;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmVentas abirVe = new frmVentas();
            Global.pagoCon = decimal.Parse(txtEfectivo.Text);
            Global.cambio = decimal.Parse(lblCambio.Text);
            this.Close();
        }
    }
}
