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

namespace WebCamProjectPrincipal
{
    public partial class Form1 : Form
    {
        //private OpenFileDialog Archivo = null;
        private string path = @"C:\Users\chuni\OneDrive\Escritorio\Practicas\practicas C#\WebCamSolution\WebCamProjectPrincipal\ImagenesPerfil\";
        private bool hayDispositivos;
        private FilterInfoCollection misDispositivos; //Esto me sirve para obtener una lista de los dispositivos que hay en mi equipo instalados
        private VideoCaptureDevice miWebCam; //Una vez que tengo un dispositivo elegido voy guardando los frames aca.
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if(misDispositivos.Count > 0)
            {
                hayDispositivos = true;
                for(int i = 0; i < misDispositivos.Count; i++)
                {
                    cbxGrabar.Items.Add(misDispositivos[i].Name.ToString());
                }
                cbxGrabar.Text = misDispositivos[0].Name.ToString();
            }
            else
            {
                hayDispositivos = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDispositivos();
        }
        private void Capturando(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pbxGrabar.Image = imagen;
            pbxGrabar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            CerrarWebCam();
            int i = cbxGrabar.SelectedIndex;
            string nombreVideo = misDispositivos[i].MonikerString;
            miWebCam = new VideoCaptureDevice(nombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            miWebCam.Start();
        }
        private void CerrarWebCam()
        {
            if(miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                pbxCapturar.Image = pbxGrabar.Image;
                pbxCapturar.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!(File.Exists(path + "ClienteDni2.jpg")))
            {
                pbxCapturar.Image.Save(path + "ClienteDni2.jpg", ImageFormat.Jpeg);
                MessageBox.Show("Imagen cargada con exito");
            }
            else
            {
                MessageBox.Show("La imagen que intenta guardar ya existe en la carpeta local");
            }
        }
    }
}
