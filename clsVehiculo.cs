using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaEtapa2
{
    internal class clsVehiculo
    {
        //Creamos las picturesbox  
        public PictureBox pctAuto;  
        public PictureBox pctAvion;
        public PictureBox pctBarco;
        public void CrearAuto()
        {
            pctAuto = new PictureBox(); //Defino picture box
            pctAuto.SizeMode = PictureBoxSizeMode.Zoom;//modo de imagen 
            pctAuto.Width = 200;//ancho
            pctAuto.Height = 200;//largo
            pctAuto.BackColor = Color.Transparent;//fondo transparente
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Vehiculo-removebg.png");//ruta
            pctAuto.ImageLocation = ruta;
        }
        public void CrearAvion()
        {
            pctAvion = new PictureBox();
            pctAvion.SizeMode = PictureBoxSizeMode.Zoom;
            pctAvion.Width = 200;
            pctAvion.Height = 200;
            pctAvion.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Avion-removebg.png");
            pctAvion.ImageLocation = ruta;
        }
        public void CrearBarco()
        {
            pctBarco = new PictureBox();
            pctBarco.SizeMode = PictureBoxSizeMode.Zoom;
            pctBarco.Width = 200;
            pctBarco.Height = 200;
            pctBarco.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "Barco-removebg.png");
            pctBarco.ImageLocation = ruta;
        }
    }
}
