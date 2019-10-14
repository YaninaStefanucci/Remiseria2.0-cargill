using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remiseria2._0
{
    [Serializable]
    public class Chofer
    {
        public string NombreApellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Registro { get; set; }
        public string Turno { get; set; }

        public List<Chofer> choferes { get; set; }
        public Chofer(string nombreApellido, string dni, string telefono, string direccion, string registro, string turno)
        {
            NombreApellido = nombreApellido;
            Dni = dni;
            Telefono = telefono;
            Direccion = direccion;
            Registro = registro;
            Turno = turno;
        }

        public Chofer()
        {
            choferes = new List<Chofer>();
        }
       
        public void AgregarChoferes(string nombreApellido, string dni, string telefono, string direccion, string registro, string turno)
        {          
            choferes.Add(new Chofer(nombreApellido, dni, telefono, direccion, registro, turno));
        }

        public List<Chofer> GetChofer()
        {
            return choferes;
        }

    }
    



}
