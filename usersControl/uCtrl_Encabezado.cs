using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Titanium.Presentation;

namespace System_Titanium.usersControl
{
    public partial class uCtrl_Encabezado : UserControl
    {
        public uCtrl_Encabezado()
        {
            InitializeComponent();
        }

        private void btnExitSesion_Click(object sender, EventArgs e)
        {
            frmMain cerrar_sesion = new frmMain();
            cerrar_sesion.Cerrar_sesion();

            
        }

        private void uCtrl_Encabezado_Load(object sender, EventArgs e)
        {
            timerHorayFecha.Enabled = true;
        }

        private void timerHorayFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("H:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("D");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditarPerfil EditarPerfil = new frmEditarPerfil();
            EditarPerfil.Show();
        }
    }
}
