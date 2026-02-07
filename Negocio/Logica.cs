using AccesoDatosSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea2;
using System.Data.SqlClient;

namespace Negocio
{
    public class Logica
    {
        #region EleganciaIntegral
        #region Autenticacion y Aurorizacion

        /// <summary>
        /// Metodo para validar la autenticacion de un usuario 
        /// </summary>
        /// <param name="P_Entidad">Entidad Tipo Usuario</param>
        /// <returns>Entidad tipo usuario</returns>
        public static Usuario Autenticacion(Usuario P_Entidad)
        {
            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AUTENTICACION '" + P_Entidad.NUsuario + "','" + P_Entidad.Pass + "'",
                ListaParametros = new List<SqlParameter>()
            };

            AccesoSQL objacceso = new AccesoSQL();
            List<Usuario> resultado = objacceso.ConsultarT_usuario(peticion);

            return resultado.FirstOrDefault();

        }

        /// <summary>
        /// Metodo para validar la Autorizacion de un usuario autenticado
        /// </summary>
        /// <param name="P_Entidad">Entidad Tipo Usuario</param>
        /// <returns>Entidad lista tipo perfil</returns>
        public static List<Perfil> Autorizacion(Usuario P_Entidad)
        {
            SQLPeticion peticion = new SQLPeticion
            {
                Peticion = "EXEC PA_AUTORIZACION '" + P_Entidad.NUsuario + "'",
                ListaParametros = new List<SqlParameter>()
            };

            AccesoSQL objacceso = new AccesoSQL();
            return objacceso.ConsultarUsuario(peticion);

        }

        #endregion

        #region Perfil
        public static void VerificarConexion()
        {
            try
            {
                AccesoSQL objacceso = new AccesoSQL();

            }
            catch (Exception ex)
            {
                throw ex;

            }


        }

        /// <summary>
        /// Metodo para agregar un usuario en base de datos
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public static bool AgregarCodigo(Perfil P_Entidad)
        {

            try
            {
                //Aqui se establece la peticion a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarCodigo " + P_Entidad.ID_Codigo + ",'" + P_Entidad.Descripcion + "','" + P_Entidad.FechaCreacion.ToString("dd/MM/yyyy hh:mm:ss") + "','" + P_Entidad.Estado + "'",
                    ListaParametros = new List<System.Data.SqlClient.SqlParameter>()
                };
                //Ejecuta acceso a datos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Metodo para modificar un usuario en base de datos
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public static bool ModificarCodigo(Perfil P_Entidad)
        {

            try
            {
                //Aqui se establece la peticion a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarCodigo " + P_Entidad.ID_Codigo + ",'" + P_Entidad.Descripcion + "','" + P_Entidad.FechaCreacion.ToString("dd/MM/yyyy hh:mm:ss") + "','" + P_Entidad.Estado + "'",
                    ListaParametros = new List<System.Data.SqlClient.SqlParameter>()
                };
                //Ejecuta acceso a datos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Metodo para eliminar un usuario en base de datos
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public static bool EliminarCodigo(Perfil P_Entidad)
        {

            try
            {
                //Aqui se establece la peticion a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarCodigo " + P_Entidad.ID_Codigo,
                    ListaParametros = new List<System.Data.SqlClient.SqlParameter>()
                };
                //Ejecuta acceso a datos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// Metodo para consultar un usuario en base de datos
        /// </summary>
        /// <param name="P_Entidad"></param>
        /// <returns></returns>
        public static List<Perfil> ConsultarCodigo(Perfil P_Entidad)
        {

            try
            {
                //Aqui se establece la peticion a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarCodigo " + P_Entidad.ID_Codigo,
                    ListaParametros = new List<System.Data.SqlClient.SqlParameter>()
                };
                //Ejecuta acceso a datos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarUsuario(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region Cliente

        public static List<Cliente> ConsultarCliente(Cliente P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarCliente '" + P_entidad.IDCliente + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarCliente(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarCliente(Cliente P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarCliente " + P_entidad.C_Nombre + ",'" + P_entidad.C_Apellidos + "','" + P_entidad.C_Telefono + "','" + P_entidad.Email + "','" + P_entidad.TipoCedula + "','" + P_entidad.NumeroCedula + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarCliente(Cliente P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarCliente " + P_entidad.IDCliente + "," + P_entidad.C_Nombre + ",'" + P_entidad.C_Apellidos + "','" + P_entidad.C_Telefono + "','" + P_entidad.Email + "','" + P_entidad.TipoCedula + "','" + P_entidad.NumeroCedula + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarCliente(Cliente P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarCliente '" + P_entidad.IDCliente + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region Inventario

        public static List<Inventario> ConsultarInventario(Inventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarInventario '" + P_entidad.IDInventario + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarInventario(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarInventario(Inventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarInventario '" + P_entidad.I_Nombre + "', " + P_entidad.Cantidad + ", '" + P_entidad.UnidadMedida + "', '" + P_entidad.Descripcion + "', " + P_entidad.ProveedorId

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarInventario(Inventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarInventario " + P_entidad.IDInventario + ", '" + P_entidad.I_Nombre + "', " + P_entidad.Cantidad + ", '" + P_entidad.UnidadMedida + "', '" + P_entidad.Descripcion + "', " + P_entidad.ProveedorId

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarInventario(Inventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarInventario '" + P_entidad.IDInventario + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Provedores

        public static List<Proveedor> ConsultarProveedor(Proveedor P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarProveedor '" + P_entidad.IDProveedor + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarProveedor(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarProveedor(Proveedor P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarProveedor '" + P_entidad.P_Nombre + "', '" + P_entidad.Descripcion + "', '" + P_entidad.Telefono + "'"


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarProveedor(Proveedor P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarProveedor " + P_entidad.IDProveedor + ", '" + P_entidad.P_Nombre + "', '" + P_entidad.Descripcion + "', '" + P_entidad.Telefono + "'"

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarProveedor(Proveedor P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarProveedor '" + P_entidad.IDProveedor + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Servicios
        public static List<Servicios> ConsultarServicio(Servicios P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarServicio '" + P_entidad.IDServicio + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarServicio(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarServicio(Servicios P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarServicio '" + P_entidad.S_Nombre + "', '" + P_entidad.Descripcion + "', '" + P_entidad.Duracion + "'"


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarServicio(Servicios P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarServicio " + P_entidad.IDServicio + ", '" + P_entidad.S_Nombre + "', '" + P_entidad.Descripcion + "', '" + P_entidad.Duracion + "'"

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarServicio(Servicios P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarServicio '" + P_entidad.IDServicio + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region Usuario

        public static List<Usuario> ConsultarUsuarioC(Usuario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarUsuario '" + P_entidad.IDUsuario + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarUsuarioC(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarUsuario(Usuario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarUsuario " + P_entidad.IDUsuario + ", '" + P_entidad.NUsuario + "', '" + P_entidad.Pass + "', '" + P_entidad.Fecha + "', " + (P_entidad.Activo ? "1" : "0") + ", " + (P_entidad.Bloqueo ? "1" : "0") + ", '" + P_entidad.U_Nombre + "', '" + P_entidad.U_Apellido + "', '" + P_entidad.U_Telefono + "', '" + P_entidad.U_Email + "', '" + P_entidad.TCedula + "', '" + P_entidad.Cedula + "'"


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarUsuario(Usuario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarUsuario " + P_entidad.IDUsuario + ",'" + P_entidad.NUsuario + "', '" + P_entidad.Pass + "', '" + P_entidad.Fecha + "', " + (P_entidad.Activo ? "1" : "0") + ", " + (P_entidad.Bloqueo ? "1" : "0") + ", '" + P_entidad.U_Nombre + "', '" + P_entidad.U_Apellido + "', '" + P_entidad.U_Telefono + "', '" + P_entidad.U_Email + "', '" + P_entidad.TCedula + "', '" + P_entidad.Cedula + "'"

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarUsuario(Usuario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarUsuario '" + P_entidad.IDUsuario + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




        #endregion

        #region UsuarioXPerfil
        public static List<UsuarioporPerfil> ConsultarUsuarioXPerfil(UsuarioporPerfil P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarUsuarioPorPerfil '" + P_entidad.UsuarioId + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarUsuarioXPerfil(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarUsuarioXPerfil(UsuarioporPerfil P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarUsuarioPorPerfil " + P_entidad.UsuarioId + ", '" + P_entidad.Usuario + "', " + P_entidad.CodPerfil + ", '" + P_entidad.FechaAsociacion + "'"


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarUsuarioXPerfil(UsuarioporPerfil P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarUsuarioPorPerfil " + P_entidad.UsuarioId + ", '" + P_entidad.Usuario + "', " + P_entidad.CodPerfil + ", '" + P_entidad.FechaAsociacion + "'"

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarUsuarioXPerfil(UsuarioporPerfil P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarUsuarioPorPerfil '" + P_entidad.UsuarioId + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region ServicioInventario
        public static List<ServicioInventario> ConsultarSXI(ServicioInventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarServicioInventario '" + P_entidad.IDServicioInventario + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarSXI(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarSXI(ServicioInventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarServicioInventario " + P_entidad.IDServicio + ", " + P_entidad.IDInventario + ", " + P_entidad.CantidadUsada


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarSXI(ServicioInventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarServicioInventario " + P_entidad.IDServicioInventario + ", " + P_entidad.IDServicio + ", " + P_entidad.IDInventario + ", " + P_entidad.CantidadUsada

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarSXI(ServicioInventario P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarServicioInventario '" + P_entidad.IDServicioInventario + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region Citas
        public static List<Cita> ConsultarCitas(Cita P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ConsultarCita '" + P_entidad.IDCita + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarCita(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarCitas(Cita P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_AgregarCita " + P_entidad.ClienteId + ", '" + P_entidad.NombreCliente + "', " + P_entidad.EmpleadoId + ", '" + P_entidad.NombreEmpleado + "', " + P_entidad.ServicioId + ", '" + P_entidad.NombreServicio + "', '" + P_entidad.Fecha + "', '" + P_entidad.Hora + "', '" + P_entidad.Notas + "'"


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarCitas(Cita P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_ModificarCita " + P_entidad.IDCita + ", " + P_entidad.ClienteId + ", '" + P_entidad.NombreCliente + "', " + P_entidad.EmpleadoId + ", '" + P_entidad.NombreEmpleado + "', " + P_entidad.ServicioId + ", '" + P_entidad.NombreServicio + "', '" + P_entidad.Fecha + "', '" + P_entidad.Hora + "', '" + P_entidad.Notas + "'"

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarCitas(Cita P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_EliminarCita '" + P_entidad.IDCita + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion
        #endregion

        #region InventarioFS

        #region EmpleadoFS

        public static List<UsuarioFS> ConsultarUsuarioFS(UsuarioFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Empleados_Consultar '" + P_entidad.EmpleadoID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarUsuarioFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarUsuarioFS(UsuarioFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Empleados_Insertar '" + P_entidad.NombreCompleto + "', '" + P_entidad.Cargo + "', '" + P_entidad.Email + "', '" + P_entidad.Telefono + "', '" + P_entidad.Direccion + "'"
            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarUsuarioFS(UsuarioFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Empleados_Modificar " + P_entidad.EmpleadoID + ", '" + P_entidad.NombreCompleto + "', '" + P_entidad.Cargo + "', '" + P_entidad.Email + "', '" + P_entidad.Telefono + "', '" + P_entidad.Direccion + "'"


            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarUsuarioFS(UsuarioFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Empleados_Eliminar '" + P_entidad.EmpleadoID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }




        #endregion

        #region UsuarioFS
        public static List<UsuarioUFS> ConsultarUFS(UsuarioUFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Usuarios_Consultar '" + P_entidad.UsuarioID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarUFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarUFS(UsuarioUFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Usuarios_Insertar '" + P_entidad.NombreUsuario + "', '" + P_entidad.Contrasena + "', " + P_entidad.EmpleadoID

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarUFS(UsuarioUFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Usuarios_Modificar " + P_entidad.UsuarioID + ", '" + P_entidad.NombreUsuario + "', '" + P_entidad.Contrasena + "', " + P_entidad.EmpleadoID




                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarUFS(UsuarioUFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Usuarios_Eliminar '" + P_entidad.UsuarioID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region RolesFS
        public static List<RolesFS> ConsultarRolesFS(RolesFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Usuarios_Consultar '" + P_entidad.RolID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarRolesFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region UxR
        public static List<UxRFS> ConsultarUxRFS(UxRFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_UsuariosRoles_Consultar '" + P_entidad.UsuarioID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarUxRFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region ClienteFS
        public static List<ClienteFS> ConsultarClienteFS(ClienteFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Clientes_Consultar '" + P_entidad.ClienteID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarClienteFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarClienteFS(ClienteFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Clientes_Insertar '" + P_entidad.C_Nombre + "', '" + P_entidad.C_Apellidos + "', '" + P_entidad.Email + "', '" + P_entidad.C_Telefono + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarClienteFS(ClienteFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Clientes_Modificar " + P_entidad.ClienteID + ", '" + P_entidad.C_Nombre + "', '" + P_entidad.C_Apellidos + "', '" + P_entidad.Email + "', '" + P_entidad.C_Telefono + "'"


                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarClienteFS(ClienteFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Clientes_Eliminar '" + P_entidad.ClienteID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        #endregion

        #region ProductosFS
        public static List<ProductoFS> ConsultarProductoFS(ProductoFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Productos_Consultar '" + P_entidad.ProductoID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarProductoFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarProductoFS(ProductoFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Productos_Insertar '" + P_entidad.P_Nombre + "', '" + P_entidad.Descripcion + "', " + P_entidad.Precio + ", " + P_entidad.Stock + ", '" + P_entidad.Categoria + "'"

            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarProductoFS(ProductoFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Productos_Modificar " + P_entidad.ProductoID + ", '" + P_entidad.P_Nombre + "', '" + P_entidad.Descripcion + "', " + P_entidad.Precio + ", " + P_entidad.Stock + ", '" + P_entidad.Categoria + "'"


            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarProductoFS(ProductoFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Productos_Eliminar '" + P_entidad.ProductoID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region ProveedoresFS
        public static List<ProveedorFS> ConsultarProveedorFS(ProveedorFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Proveedores_Consultar '" + P_entidad.ProveedorID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarProveedorFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarProveedorFS(ProveedorFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Proveedores_Insertar '" + P_entidad.NombreEmpresa + "', '" + P_entidad.Contacto + "', '" + P_entidad.Telefono + "', '" + P_entidad.Direccion + "'"


            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarProveedorFS(ProveedorFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Proveedores_Modificar " + P_entidad.ProveedorID + ", '" + P_entidad.NombreEmpresa + "', '" + P_entidad.Contacto + "', '" + P_entidad.Telefono + "', '" + P_entidad.Direccion + "'"



            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarProveedorFS(ProveedorFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Proveedores_Eliminar '" + P_entidad.ProveedorID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region OrdenCompraFS
        public static List<OrdenCompraFS> ConsultarOrdenCompraFS(OrdenCompraFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesCompra_Consultar '" + P_entidad.OrdenID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarOrdenCompraFS(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarOrdenCompraFS(OrdenCompraFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesCompra_Insertar '" + P_entidad.FechaOrden + "', " + P_entidad.ProveedorID + ", " + P_entidad.Total + ", '" + P_entidad.Estado + "', " + P_entidad.EmpleadoID


            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarOrdenCompraFS(OrdenCompraFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesCompra_Modificar " + P_entidad.OrdenID + ", '" + P_entidad.FechaOrden + "', " + P_entidad.ProveedorID + ", " + P_entidad.Total + ", '" + P_entidad.Estado + "', " + P_entidad.EmpleadoID





            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarOrdenCompraFS(OrdenCompraFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesCompra_Eliminar '" + P_entidad.OrdenID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region OrdenVentaFS
        public static List<OrdenVentaFS> ConsultarOrdenVentaFS(OrdenVentaFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesVenta_Consultar '" + P_entidad.VentaID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarOrdenVentaFS(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool AgregarOrdenVentaFS(OrdenVentaFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesVenta_Insertar '" + P_entidad.FechaVenta + "', " + P_entidad.ClienteID + ", " + P_entidad.Total + ", '" + P_entidad.Estado + "', " + P_entidad.EmpleadoID
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool ModificarOrdenVentaFS(OrdenVentaFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesVenta_Modificar " + P_entidad.VentaID + ", '" + P_entidad.FechaVenta + "', " + P_entidad.ClienteID + ", " + P_entidad.Total + ", '" + P_entidad.Estado + "', " + P_entidad.EmpleadoID
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool EliminarOrdenVentaFS(OrdenVentaFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_OrdenesVenta_Eliminar '" + P_entidad.VentaID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region DetalleOrdenCompraFS
        public static List<DetalleOrdenCompraFS> ConsultarDetalleOrdenCompraFS(DetalleOrdenCompraFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenCompra_Consultar '" + P_entidad.DetalleID + "'"
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarDetalleOrdenCompraFS(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool AgregarDetalleOrdenCompraFS(DetalleOrdenCompraFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenCompra_Insertar " + P_entidad.OrdenID + ", " + P_entidad.ProductoID + ", " + P_entidad.Cantidad + ", " + P_entidad.PrecioUnitario + ", " + P_entidad.TotalLinea
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ModificarDetalleOrdenCompraFS(DetalleOrdenCompraFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenCompra_Modificar " + P_entidad.DetalleID + ", " + P_entidad.OrdenID + ", " + P_entidad.ProductoID + ", " + P_entidad.Cantidad + ", " + P_entidad.PrecioUnitario + ", " + P_entidad.TotalLinea
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EliminarDetalleOrdenCompraFS(DetalleOrdenCompraFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenCompra_Eliminar '" + P_entidad.DetalleID + "'"
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region DetalleOrdenVentaFS

        public static List<DetalleOrdenVentaFS> ConsultarDetalleOrdenVentaFS(DetalleOrdenVentaFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenVenta_Consultar '" + P_entidad.DetalleID + "'"
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarDetalleOrdenVentaFS(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool AgregarDetalleOrdenVentaFS(DetalleOrdenVentaFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenVenta_Insertar " + P_entidad.VentaID + ", " + P_entidad.ProductoID + ", " + P_entidad.Cantidad + ", " + P_entidad.PrecioUnitario + ", " + P_entidad.TotalLinea
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ModificarDetalleOrdenVentaFS(DetalleOrdenVentaFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenVenta_Modificar " + P_entidad.DetalleID + ", " + P_entidad.VentaID + ", " + P_entidad.ProductoID + ", " + P_entidad.Cantidad + ", " + P_entidad.PrecioUnitario + ", " + P_entidad.TotalLinea
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EliminarDetalleOrdenVentaFS(DetalleOrdenVentaFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_DetalleOrdenVenta_Eliminar '" + P_entidad.DetalleID + "'"
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region HistorialPreciosFS
        public static List<HistorialPrecioFS> ConsultarHistorialPrecioFS(HistorialPrecioFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Consultar_HistorialPrecios '" + P_entidad.HistorialID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarHistorialPrecioFS(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool AgregarHistorialPrecioFS(HistorialPrecioFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_HistorialPrecio_Insertar " +
                               P_entidad.ProductoID + ", " +
                               P_entidad.FechaCambio + ", " +
                               P_entidad.PrecioAntiguo + ", " +
                               P_entidad.PrecioNuevo
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool ModificarHistorialPrecioFS(HistorialPrecioFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_HistorialPrecio_Modificar " +
                               P_entidad.HistorialID + ", " +
                               P_entidad.ProductoID + ", " +
                               P_entidad.FechaCambio + ", " +
                               P_entidad.PrecioAntiguo + ", " +
                               P_entidad.PrecioNuevo
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool EliminarHistorialPrecioFS(HistorialPrecioFS P_entidad)
        {
            try
            {
                // Aquí se establece la petición a ejecutar
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_HistorialPrecio_Eliminar '" + P_entidad.HistorialID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region AuditoriaEmpleadosFS
        public static List<AuditoriaEmpleadosFS> ConsultarAuditorsFSiaEmpleado(AuditoriaEmpleadosFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Consultar_AuditoriaEmpleados '" + P_entidad.AuditoriaID + "'"
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarAuditoriaEmpleadosFS(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region AuditoriaOrdenComprasFS
        public static List<AuditoriaOrdenesCompraFS> ConsultarAuditoriaOrdenesCompraFS(AuditoriaOrdenesCompraFS P_entidad)
        {
            try
            {
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_Consultar_AuditoriaOrdenesCompra '" + P_entidad.AuditoriaID + "'"
                };
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarAuditoriaOrdenesCompraFS(objpeticion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region TransaccionesInventario
        public static List<TransaccionesInven> ConsultarTransaccionesInven(TransaccionesInven P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_TransaccionesInventario_Consultar " + P_entidad.TransaccionID

                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarTransaccionesInven(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool AgregarTransaccionesInven(TransaccionesInven P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_TransaccionesInventario_Insertar '" + P_entidad.FechaTransaccion + "', '" + P_entidad.TipoTransaccion + "', " + P_entidad.ProductoID + ", " + P_entidad.Cantidad + ", '" + P_entidad.Notas + "'"

            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool ModificarTransaccionesInven(TransaccionesInven P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_TransaccionesInventario_Modificar " + P_entidad.TransaccionID + ", '" + P_entidad.FechaTransaccion + "', '" + P_entidad.TipoTransaccion + "', " + P_entidad.ProductoID + ", " + P_entidad.Cantidad + ", '" + P_entidad.Notas + "'"


            };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public static bool EliminarTransaccionesInven(TransaccionesInven P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = @"EXEC PA_TransaccionesInventario_Eliminar '" + P_entidad.TransaccionID + "'"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.EjecutarPeticion(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region ConsultaClientesOrdenesVenta
        public static List<ObtenerClientesOrdenesVentaFS> ConsultarCOV(ObtenerClientesOrdenesVentaFS P_entidad)
        {
            try
            {
                //Aqui se establece la peticion a ejecutar 
                SQLPeticion objpeticion = new SQLPeticion
                {
                    Peticion = "EXEC [dbo].[PA_ObtenerDatosClientesVentas1]"
                };
                // Ejecuta contra AccesoDatos
                AccesoSQL objacceso = new AccesoSQL();
                return objacceso.ConsultarCOV(objpeticion);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        #endregion

        #region 

        #endregion






        #endregion





    }

}
