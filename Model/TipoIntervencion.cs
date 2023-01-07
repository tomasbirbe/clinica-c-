using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    internal class TipoIntervencion
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public string especialidad { get; set; }
        public float precio { get; set; }
        public float porcentaje_adicional { get; set; }

        public TipoIntervencion(int codigo, string descripcion, string especialidad, float precio) {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.especialidad = especialidad;
            this.precio = precio;

        }
    }
}
