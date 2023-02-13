using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_metodo_y_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            operaciones();
        }
        public static void operaciones()
        {
            try
            {
                char SiNo;
                int opcion;
                Console.WriteLine("OPERACIONES CON 2 NUMEROS");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Ingresa el primer numero");
                metodos.numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo numero");
                metodos.numero2 = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------");
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("SELECCIONA LA OPERACION QUE DESEAS REALIZAR");
                    Console.WriteLine("1 SUMA");
                    Console.WriteLine("2 RESTA");
                    Console.WriteLine("3 MULTIPLICACION");
                    Console.WriteLine("4 DIVISION");
                    Console.WriteLine("5 TODOS");
                    Console.WriteLine();

                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            metodos.suma();
                            Console.WriteLine("------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                          1 SUMA");
                            Console.WriteLine("                                 La suma de " + metodos.numero1 + " y " + metodos.numero2 + " es " + metodos.respuesta);
                            break;
                        case 2:
                            metodos.resta();
                            Console.WriteLine("------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                         2 RESTA");
                            Console.WriteLine("                               La resta de " + metodos.numero1 + " y " + metodos.numero2 + " es " + metodos.respuesta);
                            break;
                        case 3:
                            metodos.multiplicacion();
                            Console.WriteLine("------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                    3 MULTIPLICACION");
                            Console.WriteLine("                         La multiplicacion de " + metodos.numero1 + " y " + metodos.numero2 + " es " + metodos.respuesta);
                            break;
                        case 4:
                            metodos.division();
                            Console.WriteLine("------------------------------------------------------------------------------------------");
                            Console.WriteLine("                                       4 DIVISION");
                            Console.WriteLine("                           La division de " + metodos.numero1 + " y " + metodos.numero2 + " es " + metodos.respuesta);
                            break;

                        case 5:
                            Console.WriteLine("                            5 TODOS");
                            Console.WriteLine("--------------------------------LOS NUMEROS SON " + metodos.numero1 + " Y " + metodos.numero2 + "--------------------------------");
                            metodos.suma();
                            Console.WriteLine("La suma es " + metodos.respuesta);
                            metodos.resta();
                            Console.WriteLine("La resta es " + metodos.respuesta);
                            metodos.multiplicacion();
                            Console.WriteLine("La multiplicacion es " + metodos.respuesta);
                            metodos.division();
                            Console.WriteLine("La division es " + metodos.respuesta);
                            break;

                        default:
                            Console.WriteLine("Solo se aceptan numeros del 1 al 5");
                            break;
                    }
                    Console.WriteLine("------------------------------------------------------------------------------------------");
                    Console.WriteLine("¿Desea Realizar Otra Operacion Con Los Mismos Numeros (" + metodos.numero1 + ", " + metodos.numero2 + ")? (S/N) ");
                    SiNo = char.Parse(Console.ReadLine());
                    SiNo = char.ToUpper(SiNo);

                } while (SiNo == 'S');
                Console.WriteLine("¿Desea Realizar Otra Operacion Con Otros Numeros? (S/N) ");
                SiNo = char.Parse(Console.ReadLine());
                SiNo = char.ToUpper(SiNo);
                if (SiNo == 'S')
                {
                    Console.Clear();
                    operaciones();
                }
                else
                {
                    Console.WriteLine("Enter para cerrar la ventana");
                    Console.ReadKey();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("LOS DATOS NO DEBEN DE IR EN BLANCO Y SE ACEPTAN SOLO NUMEROS");

                Console.ReadKey();
                Console.Clear();
                operaciones();
            }
        }
    }
}