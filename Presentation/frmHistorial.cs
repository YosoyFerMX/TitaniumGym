using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System_Titanium.usersControl;
using System_Titanium.Business;

namespace System_Titanium.Presentation
{
    public partial class frmHistorial : Form
    {
        private Button currentButton;
        DataSet dsCategoriasAreas = new DataSet();
        private DateTime desde;
        private DateTime hasta;
        public frmHistorial()
        {
            InitializeComponent();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            SetDateMenuButton(btnToday);
            dsCategoriasAreas = Business.Reportes.Dashboard();
            if (dsCategoriasAreas != null) {
                lblVent.Text = ((int)dsCategoriasAreas.Tables[0].Rows[0]["nTickets"]).ToString();
                lblsoc.Text = ((int)dsCategoriasAreas.Tables[0].Rows[0]["nSocios"]).ToString();
                lblMens.Text = ((int)dsCategoriasAreas.Tables[0].Rows[0]["nMensuActivas"]).ToString();
            
            }
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "dd MMM yyyy";
            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dd MMM yyyy";

            desde = DateTime.Now;
            hasta = DateTime.Now.AddDays(1);
            categoriaAreas(desde, hasta);
            ProductoMasVendido(desde, hasta);
            EntradaVisitas(desde, hasta);
        }

        
        ArrayList categoria = new ArrayList();
        ArrayList CantCat = new ArrayList();
        private void categoriaAreas(DateTime desde, DateTime hasta) {
            categoria = new ArrayList();
            CantCat = new ArrayList();
            dsCategoriasAreas = new DataSet();
            dsCategoriasAreas = Business.Reportes.AreaMoreUse(desde, hasta);
            //int filas = dsCategoriasAreas.Tables.Count;
            if (dsCategoriasAreas != null)
            {
                foreach (DataRow row in dsCategoriasAreas.Tables[0].Rows)
                {
                    categoria.Add(row["nombreArea"]);
                    CantCat.Add(row["Conteo"]);
                }
                chartAreasGym.Series[0].Points.DataBindXY(categoria, CantCat);
            }
            else {
                chartAreasGym.Series[0].Points.Clear();        // Si no existen registros limpia el grafico    
            }
            
        }

        private void ProductoMasVendido(DateTime desde, DateTime hasta)
        {
            categoria = new ArrayList();
            CantCat = new ArrayList();
            dsCategoriasAreas = Business.Reportes.ProductoMasVendido(desde, hasta);
            //int filas = dsCategoriasAreas.Tables.Count;
            if (dsCategoriasAreas != null) {
                foreach (DataRow row in dsCategoriasAreas.Tables[0].Rows)
                {
                    categoria.Add(row["nombreProd"]);
                    CantCat.Add(row["CANTIDAD"]);
                }
            }
         
            ChartProdMoreVEndido.Series[0].Points.DataBindXY(categoria,CantCat);
            //chartAreasGym.Series[0].Points.DataBindXY(categoria, CantCat);
        }
        private void EntradaVisitas(DateTime desde, DateTime hasta)
        {
            categoria = new ArrayList();
            CantCat = new ArrayList();
            dsCategoriasAreas = Business.Reportes.EntradasVisitas(desde, hasta);
            //int filas = dsCategoriasAreas.Tables.Count;
            if (dsCategoriasAreas != null) {
                foreach (DataRow row in dsCategoriasAreas.Tables[0].Rows)
                {
                    categoria.Add(row["nombreArea"]);
                    CantCat.Add(row["cantidad"]);
                }
            }
            chartVisitas.Series[0].Points.DataBindXY(categoria, CantCat);
            //chartAreasGym.Series[0].Points.DataBindXY(categoria, CantCat);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMain openMain = new frmMain();
            openMain.Show();
            this.Close();

        }

        private void SetDateMenuButton(object button) {
            var btn = (Button)button;
            //HightLigthing Button
            btn.BackColor = btnThisMonth.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;

            //Uniligth Buton
            if (currentButton != null && currentButton != btn) {
                currentButton.BackColor = this.BackColor;
                currentButton.ForeColor = Color.FromArgb(124,141,181);
            }
            currentButton = btn;
        }


        private void btnLast15Day_Click(object sender, EventArgs e)
        {
            SetDateMenuButton(sender);
            desde = DateTime.Now.AddDays(-15);
            hasta = DateTime.Now.AddDays(1);
            categoriaAreas(desde, hasta);
            ProductoMasVendido(desde, hasta);
            EntradaVisitas(desde, hasta);

        }

        private void btnLast7Day_Click(object sender, EventArgs e)
        {
            SetDateMenuButton(sender);
            desde = DateTime.Now.AddDays(-7);
            hasta = DateTime.Now.AddDays(1);
            categoriaAreas(desde, hasta);
            ProductoMasVendido(desde, hasta);
            EntradaVisitas(desde, hasta);
        }

        private void btnThisMonth_Click(object sender, EventArgs e)
        {
            SetDateMenuButton(sender);
            desde = DateTime.Now.AddMonths(-1);
            hasta = DateTime.Now.AddDays(1);
            categoriaAreas(desde, hasta);
            ProductoMasVendido(desde, hasta);
            EntradaVisitas(desde, hasta);
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDateMenuButton(sender);
            //SetDateMenuButton(sender);
            desde = DateTime.Now;
            hasta = DateTime.Now.AddDays(1);
            categoriaAreas(desde, hasta);
            ProductoMasVendido(desde, hasta);
            EntradaVisitas(desde, hasta);
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            SetDateMenuButton(sender);
            desde = dtpInicio.Value;
            hasta = dtpHasta.Value.AddDays(1);
            categoriaAreas(desde, hasta);
            ProductoMasVendido(desde, hasta);
            EntradaVisitas(desde, hasta);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            dtpInicio.Select();
            SendKeys.Send("%{DOWN}");
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            dtpHasta.Select();
            SendKeys.Send("%{DOWN}");
            
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = dtpInicio.Text;

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = dtpHasta.Text;
        }

        private void btnRepotGeneral_Click(object sender, EventArgs e)
        {
            Reportes.ReportGeneral reportGen = new Reportes.ReportGeneral();
            reportGen.ReporteGeneral(desde, hasta);
        }
    }
}
