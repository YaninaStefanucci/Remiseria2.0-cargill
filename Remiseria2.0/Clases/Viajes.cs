using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2._0
{

    [Serializable]
    public class Viajes
    {
        

        public List<Viaje> viajes { get; set; }

        public Viajes()
        {
            viajes = new List<Viaje>();
        }

        
        public void NuevosViajes(string hs, string hl, double precio, string destino, string nom, string patente, string fecha)
        {
            viajes.Add(new Viaje(hs, hl, precio, destino, nom, patente, fecha));
            
        }

        public List<Viaje> getViaje()
        {
            return viajes;
        }

        public double CuantoCosto (Viaje v)
        {
            return v.Precio;
         
        }

        public string QuePatenteTiene(Viaje p)
        {
            return p.Patente;
        }
        
      public void Ordenar()
        {
            viajes.Sort((p, q) => string.Compare(p.Patente, q.Patente));
        }

    }
}
