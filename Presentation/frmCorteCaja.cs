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
    public partial class frmCorteCaja : Form
    {
        public frmCorteCaja()
        {
            InitializeComponent();
        }

        private void btnArqueo_Click(object sender, EventArgs e)
        {
            frmCalculadora abrirArqueo = new frmCalculadora();
            abrirArqueo.ShowDialog();
            txtefectivoContado.Text = Global.ImporteTotCalcu.ToString();
            
        }

        private void txtefectivoContado_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void txtRetiroCorte_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionesNum.SoloNumeros(sender,e);
        }

        private void btnConfcaja_Click(object sender, EventArgs e)
        {
            frmAjustesCaja abrirAjCaja = new frmAjustesCaja();
            abrirAjCaja.ShowDialog();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (txtefectivoContado.Text != "" && txtRetiroCorte.Text != "")
            {
                decimal retiros = 0;
                decimal ingresoVisita = 0;
                decimal ingresoMensu = 0;
                decimal ingresoVentas = 0;

                DataSet ingresosTemporales = new DataSet();
                try {
                    ingresosTemporales = CrudCaja.ingresosCaja();
                    if (ingresosTemporales.Tables[0].Rows[0]["Visitas"] != DBNull.Value)
                        ingresoVisita = (decimal)ingresosTemporales.Tables[0].Rows[0]["Visitas"];
                    if (ingresosTemporales.Tables[0].Rows[0]["Mensualidades"] != DBNull.Value)
                        ingresoMensu = (decimal)ingresosTemporales.Tables[0].Rows[0]["Mensualidades"];
                    if (ingresosTemporales.Tables[0].Rows[0]["ventas"] != DBNull.Value)
                        ingresoVentas = (decimal)ingresosTemporales.Tables[0].Rows[0]["ventas"];
                    if (ingresosTemporales.Tables[0].Rows[0]["Retiros"] != DBNull.Value)
                    {
                        retiros = (decimal)ingresosTemporales.Tables[0].Rows[0]["Retiros"];
                    }
                    decimal suma = (ingresoMensu + ingresoVisita + ingresoVentas) - retiros;


                    decimal montoCajaCalculado = (decimal)CrudCaja.VerConfCaja().Tables[0].Rows[0]["montoCaja"] + suma;


                    decimal diferencia = decimal.Parse(txtefectivoContado.Text) - (montoCajaCalculado);
                    //query para insertar corte de caja
                    DialogResult msj = MessageBox.Show("EL CORTE DE CAJA SE REALIZARÁ, ¿SEGURO DESEA CONTINUAR?", "CORTE DE CAJA", MessageBoxButtons.OKCancel);
                    if (DialogResult.OK == msj)
                        try {
                            CrudCaja.InsertarCorteCaja(1, decimal.Parse(txtefectivoContado.Text), montoCajaCalculado, diferencia, decimal.Parse(txtRetiroCorte.Text), DateTime.Now);
                            txtefectivoContado.Text = "";
                            txtRetiroCorte.Text = "";
                        }
                        catch (Exception m) {
                            MessageBox.Show("Ocurrió un error durante la inserción del corte, por favor inténtelo de nuevo " + m);
                        }
                        
                }
                catch (Exception m) {
                    MessageBox.Show("Ocurrió Un Error al consultar las ganancias, intentelo de nuevo. " + m);
                }

            }
            else { MessageBox.Show("NO DEJE CAMPOS VACIOS"); }
            
        }

        private void btnMovcaja_Click(object sender, EventArgs e)
        {
            frmMovCaja abrirMov = new frmMovCaja();
            abrirMov.ShowDialog();

        }
    }
}
