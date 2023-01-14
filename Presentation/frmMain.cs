using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System_Titanium.usersControl;
using System_Titanium.Presentation;
namespace System_Titanium
{
    public partial class frmMain : Form
    {
        public int limpiar;
        public frmMain()
        {
            InitializeComponent();
            this.Hide();

        }





        private void frmMain_Load(object sender, EventArgs e)
        {
            uCtrl_Encabezado encabezado = new uCtrl_Encabezado();
            pnlEncabezado.Controls.Add(encabezado);
            encabezado.BringToFront();
            //if (pnlEncabezado.Contains(encabezado) == false)
            //{

            //}
            //else { encabezado.BringToFront(); }

            gpbAdmin.Visible = true;

        }

        //METODO PARA ABRIR UN CONTROL DE USUARIO EN EL PANEL PRINCIPAL
        public void abrir_controlUduario()
        {
            cerrar();
            MessageBox.Show("Si accesa al metodo");
        }



        public void Cerrar_sesion() {
            Application.Restart();
            //frmLoguin loguin = new frmLoguin();
            //loguin.Show();

        }

        public void cerrar() {
            this.Hide();
            
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmCRUDUsers abrirUSers = new frmCRUDUsers();
            abrirUSers.ShowDialog();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        private void pnlEncabezado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVisit_Click(object sender, EventArgs e)
        {
            frmVisitas abrirVisitas = new frmVisitas();
            abrirVisitas.ShowDialog();
        }

        private void lnklInfDev_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDevelopers openDev = new frmDevelopers();
            openDev.Show();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            frmHistorial opneHyst = new frmHistorial();
            opneHyst.ShowDialog();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            frmCorteCaja abrirCaja = new frmCorteCaja();
            abrirCaja.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmHistorial abrirRepor = new frmHistorial();
            abrirRepor.ShowDialog();
        }
    }
}
