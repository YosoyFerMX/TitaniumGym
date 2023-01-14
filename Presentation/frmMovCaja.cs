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
    public partial class frmMovCaja : Form
    {
        DateTime fechaMov;
        public frmMovCaja()
        {
            InitializeComponent();
        }

        private void frmMovCaja_Load(object sender, EventArgs e)
        {
            fechaMov = DateTime.Now;
            lblFechaMov.Text = fechaMov.ToString("yyyy'/'MM'/'dd HH:mm:ss");
        }

        private void txtefectivoContado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtefectivoContado.Text != "" && richConcepto.Text != "")
            {
                try {
                    CrudCaja.InsertarMovCaja(1, decimal.Parse(txtefectivoContado.Text), fechaMov, richConcepto.Text);
                    MessageBox.Show("¡HECHO!");
                    richConcepto.Text = "";
                    txtefectivoContado.Text = "";
                }
                catch (Exception m) {
                    MessageBox.Show("Ocurrio un error al efectuar el movimiento, por favor cierre la ventana e intentelo nuevamente. " + m);
                }
                
                
            }
            else { MessageBox.Show("NO DEJE LOS CAMPOS VACIOS"); }
        }
    }
}
