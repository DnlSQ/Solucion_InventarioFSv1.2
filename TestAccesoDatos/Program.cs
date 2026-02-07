using AccesoDatosSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccesoDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc = 0;
            try
            {
                do
                {
                    Console.Clear();
                    string Menu = "Menu Principal\n\n";
                    Menu += "1.Testear Conexion BD\n";
                    Menu += "2.Salir\n";
                    Menu += "Elegir una opcion:\n";
                    Console.WriteLine(Menu);
                    opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {

                        case 1:
                            {

                                Console.Clear();
                                AccesoSQL objacceso = new AccesoSQL();
                                Console.WriteLine("Conexion Existosa");
                                Console.ReadKey();

                            }
                            break;
                        case 2: { } break;
                        default:
                            {

                                Console.Clear();
                                Console.WriteLine("Opcion no existente => " + opc);
                                Console.ReadKey();
                            }
                            break;

                    }


                } while (opc != 2);

            }
            catch (Exception ex )
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            
                
                
            
        }
    }
}
