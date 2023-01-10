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
            int matricula_medico;
            int dni_paciente;

            TipoIntervencion? tipo_intervencion = null;

            do {
                try {
                    int codigo_tipo_intervencion = Convert.ToInt32(Utils.Ask("Codigo de interencion"));
                    if (codigo_tipo_intervencion == 0) break;
                    tipo_intervencion = tipo_intervenciones
                        .Find((tipo_intervencion) => tipo_intervencion.codigo == codigo_tipo_intervencion)
                        ?? throw new Exception("No existe esa intervencion"); 
                } catch (FormatException) {
                    Console.WriteLine("Ingresa un codigo valido");
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
                }
            } while (tipo_intervencion == null);
        }
    }
}
