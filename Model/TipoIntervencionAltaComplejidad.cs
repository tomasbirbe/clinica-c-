using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    internal class TipoIntervencionAltaComplejidad : TipoIntervencion {
        public float porcentaje_adicional { get; set; }

        public TipoIntervencionAltaComplejidad(float porcentaje_adicional, int codigo, string descripcion, string especialidad, float precio) : base(codigo, descripcion, especialidad, precio) {
            this.porcentaje_adicional = porcentaje_adicional;
        }
    }
}
