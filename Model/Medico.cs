using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prueba.Model { 
    internal class Medico
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string matricula {get; set; }
        public string especialidad { get; set; }
        public bool esta_disponible { get; set; }

        public Medico(string nombre, string apellido, string matricula, string especialidad, bool esta_disponible) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.matricula = matricula;
            this.especialidad = especialidad;
            this.esta_disponible = esta_disponible;
        }


    }

}
