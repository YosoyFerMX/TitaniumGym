using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Titanium.Presentation
{
    public partial class frmCalculadora : Form
    {
        private decimal mil = 0;
        private decimal quinientos = 0;
        private decimal doscientos = 0;
        private decimal cien = 0;
        private decimal cicuenta = 0;
        private decimal veinte = 0;
        private decimal diez = 0;
        private decimal cinco = 0;
        private decimal dos = 0;
        private decimal uno = 0;
        private double centavo = 0;
        private decimal suma;
        public frmCalculadora()
        {
            InitializeComponent();
        }
        private void SumaTotal() {
            
            suma = mil + quinientos + doscientos + cien + cicuenta + veinte + diez + cinco + dos + uno + decimal.Parse(centavo.ToString());
            txtImportTotal.Text = suma.ToString("C2");
        }

        private void txtMil_TextChanged(object sender, EventArgs e)
        {
            if (txtMil.Text != "") {
                mil = (int.Parse(txtMil.Text) * 1000);
                lblMil.Text = mil.ToString("C");
            }
            else { lblMil.Text = "0"; mil = 0; }
                

            SumaTotal();
        }

        private void txtQuini_TextChanged(object sender, EventArgs e)
        {
            if (txtQuini.Text != "") {
                quinientos = (int.Parse(txtQuini.Text) * 500);
                lblQuini.Text = quinientos.ToString("C2");
            }
            else { lblQuini.Text = "0"; quinientos = 0; }
                

            SumaTotal();
        }

        private void txtDosc_TextChanged(object sender, EventArgs e)
        {
            if (txtDosc.Text != "") {
                doscientos = (int.Parse(txtDosc.Text) * 200);
                lblDosci.Text = doscientos.ToString("C2");
            }
            else { lblDosci.Text = "0"; doscientos = 0; }
                

            SumaTotal();
        }

        private void txtCien_TextChanged(object sender, EventArgs e)
        {
            if (txtCien.Text != "") {
                cien = (int.Parse(txtCien.Text) * 100);
                lblCien.Text = cien.ToString("C2");
            }
            else { lblCien.Text = "0"; cien = 0; }
                

            SumaTotal();
        }

        private void txtCinc_TextChanged(object sender, EventArgs e)
        {
            if (txtCinc.Text != "") {
                cicuenta = (int.Parse(txtCinc.Text) * 50);
                lblCincu.Text = cicuenta.ToString("C2");
            }
            else { lblCincu.Text = "0"; cicuenta = 0; }
                

            SumaTotal();
        }

        private void txtVeinte_TextChanged(object sender, EventArgs e)
        {
            if (txtVeinte.Text != "") {
                veinte = (int.Parse(txtVeinte.Text) * 20);
                lblVeinte.Text = veinte.ToString("C2");
            }
            else { lblVeinte.Text = "0"; veinte = 0; }
                

            SumaTotal();
        }

        private void txtDiez_TextChanged(object sender, EventArgs e)
        {
            if (txtDiez.Text != "") {
                diez = (int.Parse(txtDiez.Text) * 10);
                lblDiez.Text = diez.ToString("C2");
            }
            else { lblDiez.Text = "0"; diez = 0; }
                

            SumaTotal();
        }

        private void txtCinco_TextChanged(object sender, EventArgs e)
        {
            if (txtCinco.Text != "") {
                cinco = (int.Parse(txtCinco.Text) * 5);
                lblCinco.Text = cinco.ToString("C2");
            }
            else { lblCinco.Text = "0"; cinco = 0; }
                

            SumaTotal();
        }

        private void txtDos_TextChanged(object sender, EventArgs e)
        {
            if (txtDos.Text != "") {dos = (int.Parse(txtDos.Text) * 2);
                lblDos.Text = dos.ToString("C2");
            }
            else { lblDos.Text = "0"; dos = 0; }
                

            SumaTotal();
        }

        private void txtUno_TextChanged(object sender, EventArgs e)
        {
            if (txtUno.Text != "") {uno = (int.Parse(txtUno.Text) * 1);
                lblUno.Text = uno.ToString("C2");
            }
            else { lblUno.Text = "0"; uno = 0; }
                

            SumaTotal();
        }

        private void txtCentavo_TextChanged(object sender, EventArgs e)
        {
            if (txtCentavo.Text != "") {
                centavo = (int.Parse(txtCentavo.Text) * .50);
                lblCentavo.Text = centavo.ToString("C2");
            }
            else { lblCentavo.Text = "0"; centavo = 0; }
                
            

            SumaTotal();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Global.ImporteTotCalcu = suma;
            this.Close();
        }

        private void txtMil_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void txtQuini_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtDosc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtCien_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtCinc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtVeinte_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtDiez_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtCinco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtDos_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtUno_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }

        private void txtCentavo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender, e);
        }
    }
}
