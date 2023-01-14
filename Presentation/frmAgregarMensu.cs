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
    public partial class frmAgregarMensu : Form
    {
        DataSet preAre = new DataSet();
        private int idSocio;
        private int idAreaGym;
        private decimal montoPago;
        public bool renovarytur;
        public string nombreSocio;
        public int idMensualidad;
        public DateTime fechaFinal;
        public frmAgregarMensu()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarSocio_Click(object sender, EventArgs e)
        {
            frmCrudClientes abrirCli = new frmCrudClientes();
            abrirCli.confirmacion = true;
            abrirCli.ShowDialog();
            txtNom.Text = Global.nombreSocio;
            idSocio = Global.idSocio;
        }

        private void frmAgregarMensu_Load(object sender, EventArgs e)
        {
            rdbOrdinario.Checked = true;
            if (renovarytur == true) {
                lbltitle.Text = "ABONO DE MENSUALIDAD";
                txtNom.Text = nombreSocio;
                txtNom.Enabled = false;
                btnBuscarSocio.Visible = false;
                fechaFinal.AddDays(1);
                dtpInicio.Value = fechaFinal;
                dtpInicio.Enabled = false;
                
            }

            cmbAreas.DataSource = CrudArea.AreasSelect().Tables[0];
            cmbAreas.ValueMember = "ID";
            cmbAreas.DisplayMember = "AREA";
        }

        private void cmbAreas_SelectedValueChanged(object sender, EventArgs e)
        {
            selecArea();
        }
        private void selecArea() {
            idAreaGym = cmbAreas.SelectedIndex;
            preAre = CrudArea.PrecioArea(idAreaGym);
            if (cmbAreas.SelectedValue.ToString() != null)
            {
                // var etie = cmbArea.DisplayMember;
                if (rdbQuienceDias.Checked == true)
                {
                    montoPago = (decimal)preAre.Tables[0].Rows[0]["precioAreaQuince"];
                }
                else
                {
                    montoPago = (decimal)preAre.Tables[0].Rows[0]["precioArea"];
                }

                txtMonto.Text = montoPago.ToString();


            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            DateTime fechaIni;
            fechaIni = dtpInicio.Value;
            int cantMendu = (int)upDaawnMens.Value;
            DateTime fechaFin;
            if (rdbQuienceDias.Checked == true)
            {
                fechaFin = fechaIni.AddDays(15);
            }
            else { fechaFin = fechaIni.AddMonths(cantMendu); }
            
            decimal montoTotal = montoPago * cantMendu;
            if (renovarytur == true)
            {
                //EDITAR DEGITRO
                try
                {
                    CrudSocios.UpdateMensualidad(idMensualidad, idAreaGym, fechaIni.ToString("yyyy'/'MM'/'dd HH:mm:ss"), fechaFin.ToString("yyyy'/'MM'/'dd HH:mm:ss"), montoTotal);
                    this.Close();
                }
                catch { MessageBox.Show("Error al actualizar el periodo, por favor inténtelo de nuevo"); this.Close(); }
                
            }
            else {
                if (txtNom.Text != "")
                {
                    //Nueva Mensualidad
                    try
                    {
                        CrudSocios.Insert_Mensuaalidad(idSocio, idAreaGym, fechaIni.ToString("yyyy'/'MM'/'dd HH:mm:ss"), fechaFin.ToString("yyyy'/'MM'/'dd HH:mm:ss"), montoTotal);
                        this.Close();
                    }
                    catch { MessageBox.Show("Error al actualizar el periodo, por favor inténtelo de nuevo"); this.Close(); }
                    
                }
                else
                {
                    MessageBox.Show("Seleccione un socio nuevo");
                }
            }
            
        }

        private void rdbQuienceDias_CheckedChanged(object sender, EventArgs e)
        {
            upDaawnMens.Enabled = false;
            selecArea();
        }

        private void rdbOrdinario_CheckedChanged(object sender, EventArgs e)
        {
            upDaawnMens.Enabled = true;
        }
    }
}
