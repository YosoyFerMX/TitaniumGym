using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Titanium.Date;
namespace System_Titanium.Presentation
{
    public partial class frmAjustesSist : Form
    {
        public frmAjustesSist()
        {
            InitializeComponent();
        }

        private void btnGenCop_Click(object sender, EventArgs e)
        {
            string nombreCopia = (DateTime.Today.Day.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Year.ToString() + "-" + DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString() + "-" + "dbTitanium");
            string comandoConsul = "BACKUP DATABASE [dbTitanium] TO  DISK = N'C:\\backUp\\" + nombreCopia + "' WITH NOFORMAT, NOINIT,  NAME = N'dbControlClientes-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            //InformesQuery.Respaldo(comandoConsul);

            Conexion.backUpBD(comandoConsul);
        }
    }
}
