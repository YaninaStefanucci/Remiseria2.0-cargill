using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remiseria2._0
{
    public class Program
    {

        private static Viajes viaje;
        private static Chofer choferes;
        private static Auto auto;

        public static Viajes GetViajes()
        {
            viaje.Ordenar();

            return viaje;
        }

        public static Chofer GetChofer()
        {
            return choferes;
        }

        public static Auto GetAuto()
        {
            return auto;
        }
       
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            choferes = new Chofer();
            auto = new Auto();
            viaje = new Viajes();

            //creo el archivo la primera vez solo para usar//
            /*
              auto.AgregarAuto("Peugeot", "207", "CUN 024", "Omar Garcia", true);
              auto.AgregarAuto("Ford", "Focus", "FUT 165", "Agencia", false);
              auto.AgregarAuto("Citroen", "C4", "PEG 145", "Jose Diaz", true);


              choferes.AgregarChoferes("Omar Garcia", "18976567", "1553478356", "Rosales 1754, Haedo, Buenos Aires", "18976567", "Dia");
              choferes.AgregarChoferes("Jose Diaz", "18976567", "1553478356", "Rosales 1754, Haedo, Buenos Aires", "18976567", "Noche");
              choferes.AgregarChoferes("Hernesto Sarco", "18976567", "1553478356", "Rosales 1754, Haedo, Buenos Aires", "18976567", "Noche");
              choferes.AgregarChoferes("Juaquin Gonzales", "18976567", "1553478356", "Rosales 1754, Haedo, Buenos Aires", "18976567", "Dia");

            viaje.NuevosViajes("13:22", "14:56", 145, "El palomar", "Omar Garcia", "PEG 145","22/07/2019");
            viaje.NuevosViajes("14:22", "16:56", 163, "Moron", "Omar Garcia", "FUT 165","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 152, "Haedo", "Omar Garcia", "PEG 145","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 500, "El palomar", "Omar Garcia", "CUN 024","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 400, "El palomar", "Juaquin Gonzales", "PEG 145","22/07/2019");
            viaje.NuevosViajes("14:22", "16:56", 425, "Moron", "Juaquin Gonzales", "FUT 165","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 478, "Haedo", "Juaquin Gonzales", "PEG 145","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 499, "El palomar", "Juaquin Gonzales", "CUN 024","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 745, "El palomar", "Hernesto Sarco", "PEG 145","22/07/2019");
            viaje.NuevosViajes("14:22", "16:56", 700, "Moron", "Hernesto Sarco", "FUT 165","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 756.45, "Haedo", "Hernesto Sarco", "PEG 145","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 788, "El palomar", "Hernesto Sarco", "CUN 024","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 288, "El palomar", "Hernesto Sarco", "PEG 145","22/07/2019");
            viaje.NuevosViajes("14:22", "16:56", 234, "Moron", "Jose Diaz", "FUT 165","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 200, "Haedo", "Jose Diaz", "PEG 145","22/07/2019");
            viaje.NuevosViajes("13:22", "14:56", 256.32, "El palomar", "Jose Diaz", "CUN 024","22/07/2019");  
            
            //serealizar el archivo de disco
              Stream flujo = File.Create("Viaje.bin");
              BinaryFormatter serializer = new BinaryFormatter();
              serializer.Serialize(flujo, viaje);
              flujo.Close();

              Stream flujoAuto = File.Create("Auto.bin");
              BinaryFormatter serializerAuto = new BinaryFormatter();
              serializerAuto.Serialize(flujoAuto, auto);
              flujoAuto.Close();

              Stream flujoChofer = File.Create("Chofer.bin");
              BinaryFormatter serializerChofer = new BinaryFormatter();
              serializerChofer.Serialize(flujoChofer, choferes);
              flujoChofer.Close();

              MessageBox.Show("Archivo Guardado");
              return;
            */

            try
            {
                Stream flujo2 = File.OpenRead("Viaje.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                viaje = (Viajes)deserializer.Deserialize(flujo2);
                flujo2.Close();

                Stream flujoAuto2 = File.OpenRead("Auto.bin");
                BinaryFormatter deserializerAuto = new BinaryFormatter();
                auto = (Auto)deserializer.Deserialize(flujoAuto2);
                flujoAuto2.Close();

                Stream flujoChofer2 = File.OpenRead("Chofer.bin");
                BinaryFormatter deserializerChofer = new BinaryFormatter();
                choferes = (Chofer)deserializer.Deserialize(flujoChofer2);
                flujoChofer2.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Faltan cargar datos");
                return;
            }
            
            Application.ApplicationExit += new System.EventHandler(SerializarAlSalir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AbrirFormularioDeCarga());
            Application.Run(new AbrirFormularioDeCarga());


        }

        public static void SerializarAlSalir (object sender, EventArgs e)
        {
            //serializar
            Stream flujo = File.Create("Viaje.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(flujo, viaje);
            flujo.Close();

            MessageBox.Show("adios");
        }

        
    }
}
