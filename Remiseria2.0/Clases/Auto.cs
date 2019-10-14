using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2._0
{
    [Serializable]
    public class Auto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public string Duenio { get; set; }
        public bool AireAcondicionado { get; set; }

        public List<Auto> auto { get; set; }
        public Auto(string marca, string modelo, string patente, string duenio, bool AC)
        {
            Marca = marca;
            Modelo = modelo;
            Patente = patente;
            Duenio = duenio;
            AireAcondicionado = AC;
        }

        public Auto()
        {
            auto = new List<Auto>();
        }

        public void AgregarAuto(string marca, string modelo, string patente, string duenio, bool AC)
        {
            auto.Add(new Auto( marca, modelo,  patente,  duenio,  AC));
        }

        public List<Auto> GetAuto()
        {
            return auto;
        }

        public string QuienEsDuño (string patente)
        {
            foreach (Auto a in auto)
            {
                if (patente == a.Patente)
                {
                    return a.Duenio;
                }
            }

            return "vacio";
        }


    }
}
