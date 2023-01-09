using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model {
    internal static class Clinica {
        static public List<TipoIntervencion> tipo_intervenciones = new();
        static public List<Medico> medicos;
        static public List<Paciente> pacientes;
        static public List<Intervencion> intervenciones;

        internal static void RegistrarIntervencion() {
            Console.WriteLine("Escriba los siguientes datos del paciente");
            Console.Write('\n');
            int codigo_tipo_intervencion = Convert.ToInt32(Utils.Ask("Codigo de intervencion"));
            Console.WriteLine(null == tipo_intervenciones.Find((tipo_intervencion) => tipo_intervencion.codigo == codigo_tipo_intervencion));

            //Console.WriteLine(tipo_intervenciones.Find((tipo_intervencion) => tipo_intervencion.codigo == codigo_tipo_intervencion));


            //int matricula_medico = Convert.ToInt32(Utils.Ask("Matricula del medico"));
            //Medico? medico = medicos.Find((medico) => medico.matricula == matricula_medico);
            //if(medico == null) throw new Exception("No existe ese medico");
            
            //int dni_paciente = Convert.ToInt32(Utils.Ask("DNI del paciente"));
            //Paciente ?paciente = pacientes.Find((paciente) => paciente.dni == dni_paciente);
            //if(paciente == null) throw new Exception("No existe ese paciente");

        }
    }
}
