using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Titanium.Presentation
{
    public partial class frmWebCam : Form
    {
        public string path = Application.StartupPath + @"\SociosImage\";
        private bool dispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MyWebCam;
        public bool visualizador;
        public string pathVisualizador;
        
        public frmWebCam()
        {
            InitializeComponent();
        }

        public void cargaDispositvios()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                dispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                {
                    cmbLisCam.Items.Add(MisDispositivos[i].Name.ToString());
                }
                cmbLisCam.Text = MisDispositivos[0].Name.ToString();
            }
            else
            {
                dispositivos = false;
            }

        }
        private void ClosewebCam()
        {
            if (MyWebCam != null && MyWebCam.IsRunning)
            {
                MyWebCam.SignalToStop();
                MyWebCam = null;
            }
        }

        private void capture(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ClosewebCam();
            int i = cmbLisCam.SelectedIndex;
            string nombreVideo = MisDispositivos[i].MonikerString;
            MyWebCam = new VideoCaptureDevice(nombreVideo);
            MyWebCam.NewFrame += new NewFrameEventHandler(capture);
            MyWebCam.Start();
        }

        private void frmWebCam_Load(object sender, EventArgs e)
        {
            if (visualizador == true)
            {
                cmbLisCam.Visible = false;
                btnIniciar.Visible = false;
                btnCapture.Visible = false;
                this.Size = new Size(416,419);
                try
                {
                    pictureBox1.Load(pathVisualizador);
                }
                catch {
                    MessageBox.Show("No se encontro la foto el Cliente");
                }
                

            }
            else {
                cargaDispositvios();
            }
            
        }

        private void frmWebCam_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClosewebCam();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (MyWebCam != null && MyWebCam.IsRunning)
            {
                //PictureBox newPhoto = new PictureBox();
                Global.photo = new PictureBox();
                Global.photo.Image = pictureBox1.Image;
                //newPhoto.Image = pictureBox1.Image;
                //string tempFolder = path + "SOCIO.jpg";
                //File.Delete(tempFolder);
                //newPhoto.Image.Save(path + "SOCIO.jpg",ImageFormat.Jpeg);

                pictureBox1.Dispose();
                this.Close();

                

            }
        }
    }
}
