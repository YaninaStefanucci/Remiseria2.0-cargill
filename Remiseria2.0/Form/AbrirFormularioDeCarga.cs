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
    public partial class AbrirFormularioDeCarga : Form
    {

        public Viajes viaje;

        public AbrirFormularioDeCarga()
        {
            viaje = Program.GetViajes();

            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

           CargarViaje cargarviaje =  new CargarViaje();

            cargarviaje.Show();


        }

        private void Button2_Click(object sender, EventArgs e)
        {

            CalcularComision calcularComision = new CalcularComision();

            calcularComision.Show();
        }

        private void AbrirFormularioDeCarga_Load(object sender, EventArgs e)
        {

        }
    }
}
