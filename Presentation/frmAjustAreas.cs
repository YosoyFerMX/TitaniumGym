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
    public partial class frmAjustAreas : Form
    {
        public frmAjustAreas()
        {
            InitializeComponent();
        }

        private void frmAjustAreas_Load(object sender, EventArgs e)
        {

            refreshDGV();
        }

        private void refreshDGV() {

            DataSet Areas = new DataSet();
            Areas = Business.CrudArea.AreasSelect();

            dgvAreasPrecios.DataSource = Areas.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id;
            string area;
            decimal preSocio;
            decimal preVisi;
            decimal preQuin;
            int countRows = dgvAreasPrecios.Rows.Count;
            for (int i =0; i < countRows; i++) {
                id = (int)dgvAreasPrecios.Rows[i].Cells["ID"].Value;
                area = (string)dgvAreasPrecios.Rows[i].Cells["AREA"].Value;
                preSocio = (decimal)dgvAreasPrecios.Rows[i].Cells["PRECIO SOCIO"].Value;
                preVisi = (decimal)dgvAreasPrecios.Rows[i].Cells["PRECIO VISITA"].Value;
                preQuin = (decimal)dgvAreasPrecios.Rows[i].Cells["PRECIO QUINCENAL"].Value;

                try
                {
                    Business.CrudArea.UpdateArea(id, area, preSocio, preVisi, preQuin);
                }
                catch { MessageBox.Show("Ocurrió un error al actualizar los registros, inténtelo de nuevo"); }
            }

            refreshDGV();
        }
    }
}
