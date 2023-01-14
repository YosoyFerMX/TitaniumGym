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
using System_Titanium.Date;

namespace System_Titanium.Presentation
{
    public partial class frmVisitas : Form
    {
        
        public frmVisitas()
        {

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVisitas_Load(object sender, EventArgs e)
        {
            TmpFech.Enabled = false;

            cmbArea.DataSource = CrudArea.AreasSelect().Tables[0];
            cmbArea.ValueMember = "ID";
            cmbArea.DisplayMember = "AREA";
            
            



        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            //Para saber el valor del indice seleccionado
            if (cmbArea.SelectedValue.ToString() != null)
            {
                int idArea = int.Parse(cmbArea.SelectedValue.ToString());
                //string hora = DateTime.Now.ToString("H:mm:ss");
                //string fecha = DateTime.Now.ToString("MM/dd/yyyy");
                decimal cantPagar = decimal.Parse(txtPrecio.Text);
                CrudVisitas.Insert_Visit(idArea, 1, cantPagar); //Se inserta a la BD la visita
                MessageBox.Show("        HECHO");
                this.Close();
            }

        }

        private void cmbArea_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbArea.SelectedValue.ToString() != null)
            {
                int id = cmbArea.SelectedIndex;
               // var etie = cmbArea.DisplayMember;
               decimal precio = (decimal)CrudArea.PrecioArea(id).Tables[0].Rows[0]["precioAreaVisita"]; 
                txtPrecio.Text = precio.ToString();
                

            }
       }
    }
}
