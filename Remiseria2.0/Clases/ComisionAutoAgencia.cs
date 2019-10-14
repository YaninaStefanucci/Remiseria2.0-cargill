using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2._0
{
    public class ComisionAutoAgencia
    {
    
        public static double Comision(double TotalDelViaje)
        {

             double ComisionAPagar = TotalDelViaje / 2;

             return ComisionAPagar;
           
        }
    }
}
