using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model {
    internal static class Menu {
        private static int respuesta { get; set; }

        public static string Ask(string parameter) {
            Console.WriteLine($"{parameter}");
            Console.Write("> ");

            return Console.ReadLine();
        }

        public static void RegistrarIntervencion() {
            Console.WriteLine("Escriba los siguientes datos del paciente");
            Console.Write('\n');
            string dni = Ask("DNI");
            string nombre = Ask("Nombre");
            string apellido = Ask("Apellido");
            float porcentaje_cobertura = 0;
            do {
                try {
                    porcentaje_cobertura = float.Parse(Ask("Porcentaje de cobertura").Replace('.', ','));
                    if(porcentaje_cobertura < 0 || porcentaje_cobertura > 100) {
                        Console.WriteLine("Ingresa un numero entre 0 y 100");
                    }

                }
                catch(Exception ex) {
                    if(ex is FormatException) {
                        Console.WriteLine("Ingresa un valor valido (Numerico)");
                    }
                }

            } while(porcentaje_cobertura > 100 || porcentaje_cobertura < 0);

        }
        public static void MostrarMenuPrincipal() {
            do {
                Console.WriteLine("1- Registrar intervencion");
                Console.WriteLine("2- Obtener la deuda total de un paciente");
                try {
                    respuesta = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch(respuesta) {
                        case 1: {
                                RegistrarIntervencion();
                                break;
                            }
                    }
                }
                catch(Exception ex) {
                    if(ex is FormatException) {
                        respuesta = 99;
                        Console.Clear();
                        Console.WriteLine("Por favor, Ingresa un numero \n");
                    }
                }
            } while(respuesta != 0);
            Console.Clear();
            Console.WriteLine("Adios!");
        }
    }


}
