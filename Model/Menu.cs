using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model {
    internal static class Menu {
        private static int input { get; set; }

        public static void MostrarMenuPrincipal() {
            do {
                Console.WriteLine("1- Registrar intervencion");
                Console.WriteLine("2- Obtener la deuda total de un paciente");
                try {
                    input = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch(input) {
                        case 1: {
                                Clinica.RegistrarIntervencion();
                                break;
                            }
                    }
                }
                catch(Exception ex) {
                    if(ex is FormatException) {
                        input = 99;
                        Console.Clear();
                        Console.WriteLine("Por favor, Ingresa un numero \n");
                    }
                }
            } while(input != 0);
            Console.Clear();
            Console.WriteLine("Adios!");
        }
    }


}
