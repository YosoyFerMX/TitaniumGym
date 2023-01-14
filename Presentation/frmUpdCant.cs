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
    public partial class frmUpdCant : Form
    {
        public int id, cantidad;
        public IComprasUPDATE Exec{get; set;}


        public frmUpdCant()
        {
            InitializeComponent();
        }

        public void updateCant(int id, int cantidad) {
            this.id = id;
            this.cantidad = cantidad;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.cantidad = int.Parse(txtEfectivo.Text);
            Exec.EjecCantidad(id, cantidad);
            this.Close();
        }

        private void frmUpdCant_Load(object sender, EventArgs e)
        {
            txtEfectivo.Text = this.cantidad.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
