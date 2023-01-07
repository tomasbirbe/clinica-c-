using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    internal class Paciente
    {
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string obra_social { get; set; }
        public float porcentaje_cobertura { get; set; }
        public TipoIntervencion[] intervenciones { get; set; }

        public Paciente(string dni, string nombre, string apellido, string obra_social, float porcentaje_cobertura, TipoIntervencion[] intervenciones) {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.obra_social = obra_social;
            this.porcentaje_cobertura = porcentaje_cobertura;
            this.intervenciones = intervenciones;
        }
    }
}
