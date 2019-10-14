using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2._0
{
    public class ComisionDueño
    {
        
        public static double Comision (double TotalDelViaje)
        {

            double ComisionAPagar = (TotalDelViaje * 20) / 100;

            return ComisionAPagar;

            
        }
    }
}
