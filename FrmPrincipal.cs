using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaEtapa2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;
        int Contador = 1;
        bool barco = false;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }
        private void BtnCrear_Click(object sender, EventArgs e)
        {
            switch (Contador)
            {
                case 1:
                    objAuto.CrearAuto(); //Creamos auto
                    objAuto.pctAuto.Location = new Point(12, 50); //Lugar donde aparece
                    Controls.Add(objAuto.pctAuto); //El picture box
                    Contador++;
                    if (barco == true) 
                    {
                        objBarco.pctBarco.Dispose();
                    }
                break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(200, 50);
                    Controls.Add(objAvion.pctAvion);
                    objAuto.pctAuto.Dispose();
                    Contador++;
                break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(450, 50);
                    Controls.Add(objBarco.pctBarco);
                    objAvion.pctAvion.Dispose();
                    Contador = 1; //Volvemos al uno asi llamamos al auto 
                    barco = true;  //Decimos que si hay barco asi se oculta al volver al auto
                break;
            }
        }
    }
}
