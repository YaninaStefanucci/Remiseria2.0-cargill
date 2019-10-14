using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria2._0
{
    public partial class CalcularComision : Form
    {
        public Chofer chofer;
        public Viajes viaje;
        public Auto auto;
        public CalcularComision()
        {
            chofer = Program.GetChofer();
            viaje = Program.GetViajes();
            auto = Program.GetAuto();

            InitializeComponent();
        }

        private void CmbBoxChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void CalcularComision_Load(object sender, EventArgs e)
        {
            foreach (Chofer c in chofer.GetChofer())
            {

                BoxChofer.Items.Add(c.NombreApellido);
            }
        }

        private void BtnCalcularComision_Click(object sender, EventArgs e)
        {
           
            string nombre = BoxChofer.Text;
            string fecha = FechaFiltro.Value.ToString("dd/MM/yyyy");

            double ComisionAgencia = 0, auxComisionAgencia = 0, comisionDueño = 0, auxComisionDueño = 0, AutoAlquilado = 0, AutoAlquiladoAux = 0;
            double comision = 0;
            string mensaje = "", DueñoAnterior = "", Dueño = "", patenteAux = "", patente = "";

            foreach (Viaje v in viaje.getViaje())
            {
              

                if (fecha == v.Fecha)
               {       

                if (nombre == v.Nombre)                  

                {
                    double presio = viaje.CuantoCosto(v);

                    patente = viaje.QuePatenteTiene(v);

                    Dueño = auto.QuienEsDuño(patente);

                    if ("Agencia" == auto.QuienEsDuño(patente))
                    {
                        
                        auxComisionAgencia += ComisionAutoAgencia.Comision(viaje.CuantoCosto(v));
                        ComisionAgencia = ComisionAgencia + auxComisionAgencia;
                       
                    }

                    if (nombre == auto.QuienEsDuño(patente))
                    {
                        auxComisionDueño += ComisionDueño.Comision(viaje.CuantoCosto(v));
                        comisionDueño = comisionDueño + auxComisionDueño;
                    }

                    if (nombre != auto.QuienEsDuño(patente) && "Agencia" != auto.QuienEsDuño(patente))
                    {
                        if(DueñoAnterior == "") { DueñoAnterior = Dueño; }

                        AutoAlquiladoAux = ComisionAutoPrestado.Comision(viaje.CuantoCosto(v));
                        
                        if (Dueño == DueñoAnterior)
                        {
                            AutoAlquilado = AutoAlquilado + AutoAlquiladoAux;
                            
                        }
                        if (Dueño != DueñoAnterior)
                        {
                            patenteAux = patente;

                            comision = comision + AutoAlquilado;

                            mensaje = mensaje + "Debe pagar a " + DueñoAnterior + " por el auto " + patente + ": $" + AutoAlquilado + " y ";

                            AutoAlquilado = 0;

                            DueñoAnterior = Dueño;

                            patenteAux = patente;
                        }

                        
                    }
                    
                }

               }

            }
            DueñoAnterior = "";


            if (nombre != auto.QuienEsDuño(patente) && "Agencia" != auto.QuienEsDuño(patente))
            { 
                if (Dueño != DueñoAnterior)
                {

                comision = comision + AutoAlquilado;

                mensaje = mensaje + " Debe pagar a " + Dueño + " por el auto " + patenteAux + ": $" + AutoAlquilado;

              
                }
            }
            MessageBox.Show("Pagar por comision y alquiler del Auto :$" + ComisionAgencia.ToString());

            MessageBox.Show("Comision total a agencia es : $" + comisionDueño.ToString());

            MessageBox.Show(mensaje + " de comision para la agencia debe abonar: $" + ComisionAutoAgencia.Comision(comision));
            



        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
          
        
    
}
