using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_metodo_y_variable
{
    public class metodos
    {
        public static double numero1 { get; set; }
        public static double numero2 { get; set; }
        public static double respuesta { get; set; }


        public static void resta()
        {
            respuesta = numero1 - numero2;
        }

        public static void suma()
        {
            respuesta = numero1 + numero2;
        }

        public static void multiplicacion()
        {
            respuesta = numero1 * numero2;
        }

        public static void division()
        {
            respuesta = numero1 / numero2;
        }

    }
}
