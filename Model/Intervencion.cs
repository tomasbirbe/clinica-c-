using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model
{
    public enum CondicionPago {
        PAGO,
        PENDIENTE,
    }
    internal class Intervencion
    {
        public DateTime fecha { get; set; }
        public TipoIntervencion intervencion_efectuada { get; set; }
        public Medico medico { get; set; }
        public CondicionPago condicion_pago { get; set; }

        public Intervencion(DateTime fecha, TipoIntervencion intervencion_efectuada, Medico medico, CondicionPago condicion_pago, int codigo, string descripcion, string especialidad, float precio) {
            this.fecha = fecha;
            this.intervencion_efectuada = intervencion_efectuada;
            this.medico = medico;
            this.condicion_pago = CondicionPago.PENDIENTE;
        }
    }
}
