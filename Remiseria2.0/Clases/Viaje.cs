using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2._0
{
    [Serializable]
    public class Viaje
    {

        public string HoraSalida { get; set; }
        public string HoraLlegada { get; set; }
        public double Precio { get; set; }
        public string Destino { get; set; }

        public string Nombre { get; set; }

        public string Patente { get; set; }

        public string Fecha { get; set; }

        public Viaje(string hs, string hl, double precio, string destino, string nom, string patente, string fecha)
        {
            HoraSalida = hs;
            HoraLlegada = hl;
            Precio = precio;
            Destino = destino;
            Nombre = nom;
            Patente = patente;
            Fecha = fecha;
        }

       
        public string GetHoraSalida()
        {
            return HoraSalida;
        }

        public string GetHoraLlegada()
        {
            return HoraLlegada;
        }

        public double GetPrecio()
        {
            return Precio;
        }

        public string GetDestino()
        {
            return Destino;
        }


        public string GetNombre()
        {
            return Nombre;
        }

        public string GetPatente()
        {
            return Patente;
        }
    }
}
