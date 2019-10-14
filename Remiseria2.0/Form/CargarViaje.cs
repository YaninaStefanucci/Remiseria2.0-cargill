using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria2._0
{
    [Serializable]


    public partial class CargarViaje : Form
    {

        public Chofer chofer;
        public Auto auto;
        public Viajes viaje;

        
        public CargarViaje()
        {
            auto = Program.GetAuto();
            chofer = Program.GetChofer();
            viaje = Program.GetViajes();

           

            InitializeComponent();
            
        }

        public void BtnGuardarViaje_Click(object sender, EventArgs e)
        {

            
            viaje.NuevosViajes(TxtHoraSalida.Text, TxtHoraLlgada.Text, Convert.ToDouble(TxtPrecio.Text), TxtDestino.Text, CmBoxChofer.Text, CmBoxAuto.Text, DateTime.Now.Date.ToString("dd/MM/yyyy"));
            
            
            this.Close(); 


        }

        private void CargarViaje_Load(object sender, EventArgs e)
        {
            ///INICIALIZO LOS COMBOS BOX ///

            foreach (Chofer c in chofer.GetChofer())
            {

                CmBoxChofer.Items.Add(c.NombreApellido);
            }

            foreach (Auto a in auto.GetAuto())
            {

                CmBoxAuto.Items.Add(a.Patente);
            }

            
        }

        private void CmBoxChofer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
