using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prueba.Model { 
    internal class Medico
    {
        string nombre { get; set; }
        string apellido { get; set; }
        string matricula {get; set; }
        string especialidad { get; set; }
        bool esta_disponible { get; set; }

        internal Medico(string nombre, string apellido, string matricula, string especialidad, bool esta_disponible) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.matricula = matricula;
            this.especialidad = especialidad;
            this.esta_disponible = esta_disponible;
        }
    }

}
