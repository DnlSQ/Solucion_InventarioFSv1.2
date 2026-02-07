using AccesoDatosSQL;
using Negocio;
using Tarea2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNegocio
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
                    string Menu = "Menu principal \n\n";
                    Menu += "1.Testear conexion\n";
                    Menu += "2.Insertar\n";
                    Menu += "3.Modificar\n";
                    Menu += "4.Eliminar\n";
                    Menu += "5.Consultar\n";
                    Menu += "6.Consultar informacion del codigo \n";
                    Menu += "7.Salir\n";
                    Menu += "Elegir opcion: ";
                    Console.WriteLine(Menu);
                    opc = Convert.ToInt32(Console.ReadLine());

                    switch (opc)
                    {

                        case 1:
                            {

                                Console.Clear();
                                Logica.VerificarConexion();
                                Console.WriteLine("Conexion Existosa");
                                Console.ReadKey();

                            }
                            break;
                        case 2: {
                                Console.Clear();

                                Perfil u = new Perfil();

                                Console.WriteLine("Digite un Codigo:");
                                u.ID_Codigo = Convert.ToInt32( Console.ReadLine());
                                Console.WriteLine("Digite una Descripcion:");
                                u.Descripcion = Console.ReadLine();
                                u.FechaCreacion = DateTime.Now;
                                u.Estado = true;

                                Logica.AgregarCodigo(u);
                                Console.WriteLine("Codigo Registrado");
                                Console.ReadKey();


                            } break;
                        case 3: {
                                Console.Clear();

                                Perfil u = new Perfil();

                                Console.WriteLine("Digite un Codigo modificar:");
                                u.ID_Codigo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Digite una Descripcion:");
                                u.Descripcion = Console.ReadLine();
                                Console.WriteLine("Digite la fecha: (yyyy/mm/dd)");
                                u.FechaCreacion = Convert.ToDateTime( Console.ReadLine());
                                Console.WriteLine("Digite el estado S/N");
                                string respuesta = Console.ReadLine();
                                if (respuesta.ToUpper().Equals("S"))
                                    u.Estado = true;
                                else
                                    u.Estado = false;

                                Logica.ModificarCodigo(u);
                                Console.WriteLine("Codigo Registrado");
                                Console.ReadKey();

                            } break;
                        case 4: {
                                Console.Clear();

                                Perfil u = new Perfil();

                                Console.WriteLine("Digite un Codigo a Eliminar:");
                                u.ID_Codigo = Convert.ToInt32(Console.ReadLine());

                                Logica.EliminarCodigo(u);
                                Console.WriteLine("Codigo Eliminado");
                                Console.ReadKey();

                            } break;
                        case 5: {

                                Console.Clear();
                                Console.WriteLine("Lista de Codigos Registrados \n\n");

                                List<Perfil> lstresultado = Logica.ConsultarCodigo(new Perfil());
                                string Mensaje = string.Empty;

                                if (lstresultado.Count > 0)
                                {
                                    foreach (Perfil item in lstresultado)
                                    {
                                        Mensaje += "Codigo: " + item.ID_Codigo + "\n";
                                        Mensaje += "Descripcion: " + item.Descripcion + "\n";
                                        Mensaje += "Fecha Creacion: " + item.FechaCreacion.ToString("yyyy/mm/dd") + "\n";
                                        Mensaje += "Estado: " + item.Estado + "\n";
                                        Mensaje += "*********************************************************************";

                                    }
                                    Console.WriteLine(Mensaje);

                                }
                                else
                                    Console.WriteLine("No hay codigos registrados");
                                Console.ReadKey();
                            
                            } break;
                        case 6: {
                                Console.Clear();
                                Console.WriteLine("Informacion de Codigo Registrado \n\n");

                                Console.Clear();

                                Perfil u = new Perfil();

                                Console.WriteLine("Digite un Codigo a buscar:");
                                u.ID_Codigo = Convert.ToInt32(Console.ReadLine());

                                List<Perfil> lstresultado = Logica.ConsultarCodigo(u);
                                string Mensaje = string.Empty;

                                if (lstresultado.Count > 0)
                                {
                                    foreach (Perfil item in lstresultado)
                                    {
                                        Mensaje += "Codigo: " + item.ID_Codigo + "\n";
                                        Mensaje += "Descripcion: " + item.Descripcion + "\n";
                                        Mensaje += "Fecha Creacion: " + item.FechaCreacion.ToString("yyyy/mm/dd") + "\n";
                                        Mensaje += "Estado: " + item.Estado + "\n";
                                        Mensaje += "*********************************************************************";

                                    }
                                    Console.WriteLine(Mensaje);

                                }
                                else
                                    Console.WriteLine("No se encontro codigo");
                                Console.ReadKey();

                            } break;
                        case 7: { } break;
                        default:
                            {

                                Console.Clear();
                                Console.WriteLine("Opcion no existente => " + opc);
                                Console.ReadKey();
                            }
                            break;

                    }


                } while (opc != 7);

            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }


        }
    }
}
