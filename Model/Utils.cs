using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Model {
    enum TipoDato {
        str,
        integer,
        withDecimals,
    }

    internal class Utils{
        internal static string Ask(string parameter) {
            Console.WriteLine($"{parameter}");
            Console.Write("> ");

            return Console.ReadLine();
        }

    }
}
