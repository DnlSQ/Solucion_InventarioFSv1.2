using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Tarea2;
using System.Data;

namespace AccesoDatosSQL
{
    public class AccesoSQL  
    {
        #region Atributos
        private string cadenaconexion = @"Data Source=DANIEL\SQLEXPRESS; 
                                          Initial Catalog=BD_InventarioFS; 
                                          Persist Security info = true; 
                                          user id=sa; password=12345678;";

        private SqlConnection objconexion;
       

        #endregion

        #region Constructor

        public AccesoSQL()
        {
            try
            {
                objconexion = new SqlConnection(cadenaconexion);
                ABRIR();
            }
            catch (SqlException exSQL)
            {

                throw exSQL;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
        }


        #endregion

        #region Metodos

        #region Privados

        private void ABRIR()
        {
            if (objconexion.State == System.Data.ConnectionState.Closed)
                objconexion.Open();


        }
        private void CERRAR()
        {
            if (objconexion.State == System.Data.ConnectionState.Open)
                objconexion.Close();

        }
        #endregion

        #region Publicos
        /// <summary>
        /// Metodo para realizar las opciones de insercion, modificacion, eliminacion 
        /// </summary>
        /// <param name="P_peticion">Entidad de tipo SQLPeticion</param>
        /// <returns>True = correcto | false = error </returns>
        public bool EjecutarPeticion(SQLPeticion P_peticion)
        {

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                ABRIR();
                return cmd.ExecuteNonQuery() > 0; //aqui se  ejecuta la instruccion de SQL en el SQL 

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }


        }

        /// <summary>
        /// Metodos para consultar informacion  del perfil
        /// </summary>
        /// <param name="P_peticion">Entidad de tipo SQLPeticion</param>
        /// <returns>Entidad lista de tipo Perfil</returns>
        public List<Perfil> ConsultarUsuario(SQLPeticion P_peticion)
        {
            List<Perfil> lstresultado = new List<Perfil>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Perfil u = new Perfil
                        {
                            ID_Codigo = Convert.ToInt32(row.ItemArray[1].ToString()),
                            Descripcion = row.ItemArray[2].ToString(),
                            FechaCreacion = Convert.ToDateTime(row.ItemArray[4].ToString()),
                            Estado = Convert.ToBoolean(row.ItemArray[3].ToString())
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Usuario> ConsultarT_usuario(SQLPeticion P_peticion)
        {
            List<Usuario> lstresultado = new List<Usuario>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Usuario u = new Usuario
                        {
                            NUsuario = row.ItemArray[0].ToString(),
                            Pass = row.ItemArray[1].ToString()
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Cliente> ConsultarCliente(SQLPeticion P_peticion)
        {
            List<Cliente> lstresultado = new List<Cliente>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Cliente u = new Cliente  //el orden del itemarray debe considir con las consultas 
                        {
                            IDCliente = Convert.ToInt32(row.ItemArray[0].ToString()),
                            C_Nombre = row.ItemArray[1].ToString(),
                            C_Apellidos = row.ItemArray[2].ToString(),
                            C_Telefono = row.ItemArray[3].ToString(),
                            Email = row.ItemArray[4].ToString(),
                            TipoCedula = row.ItemArray[5].ToString(),
                            NumeroCedula = row.ItemArray[6].ToString(),

                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Inventario> ConsultarInventario(SQLPeticion P_peticion)
        {
            List<Inventario> lstresultado = new List<Inventario>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Inventario u = new Inventario  //el orden del itemarray debe considir con las consultas 
                        {
                            IDInventario = Convert.ToInt32(row.ItemArray[0].ToString()),
                            I_Nombre = row.ItemArray[1].ToString(),
                            Cantidad = Convert.ToInt32(row.ItemArray[2].ToString()),
                            UnidadMedida = row.ItemArray[3].ToString(),
                            Descripcion = row.ItemArray[4].ToString(),
                            ProveedorId = Convert.ToInt32(row.ItemArray[5].ToString()),


                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Proveedor> ConsultarProveedor(SQLPeticion P_peticion)
        {
            List<Proveedor> lstresultado = new List<Proveedor>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Proveedor u = new Proveedor  //el orden del itemarray debe considir con las consultas 
                        {
                            IDProveedor = Convert.ToInt32(row.ItemArray[0].ToString()),
                            P_Nombre = row.ItemArray[1].ToString(),
                            Descripcion = row.ItemArray[2].ToString(),
                            Telefono = row.ItemArray[3].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Servicios> ConsultarServicio(SQLPeticion P_peticion)
        {
            List<Servicios> lstresultado = new List<Servicios>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Servicios u = new Servicios  //el orden del itemarray debe considir con las consultas 
                        {
                            IDServicio = Convert.ToInt32(row.ItemArray[0].ToString()),
                            S_Nombre = row.ItemArray[1].ToString(),
                            Descripcion = row.ItemArray[2].ToString(),
                            Duracion = row.ItemArray[3].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<UsuarioporPerfil> ConsultarUsuarioXPerfil(SQLPeticion P_peticion)
        {
            List<UsuarioporPerfil> lstresultado = new List<UsuarioporPerfil>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        UsuarioporPerfil u = new UsuarioporPerfil  //el orden del itemarray debe considir con las consultas 
                        {
                            UsuarioId = Convert.ToInt32(row.ItemArray[0].ToString()),
                            Usuario = row.ItemArray[1].ToString(),
                            CodPerfil = Convert.ToInt32(row.ItemArray[2].ToString()),
                            FechaAsociacion = row.ItemArray[3].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Usuario> ConsultarUsuarioC(SQLPeticion P_peticion)
        {
            List<Usuario> lstresultado = new List<Usuario>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Usuario u = new Usuario  //el orden del itemarray debe considir con las consultas 
                        {
                            IDUsuario = Convert.ToInt32(row.ItemArray[0].ToString()),
                            NUsuario = row.ItemArray[1].ToString(),
                            Pass = row.ItemArray[2].ToString(),
                            Fecha = row.ItemArray[3].ToString(),
                            Activo = Convert.ToBoolean(row.ItemArray[4].ToString()),
                            Bloqueo = Convert.ToBoolean(row.ItemArray[5].ToString()),
                            U_Nombre = row.ItemArray[6].ToString(),
                            U_Apellido = row.ItemArray[7].ToString(),
                            U_Telefono = row.ItemArray[8].ToString(),
                            U_Email = row.ItemArray[9].ToString(),
                            TCedula = row.ItemArray[10].ToString(),
                            Cedula = row.ItemArray[11].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<ServicioInventario> ConsultarSXI(SQLPeticion P_peticion)
        {
            List<ServicioInventario> lstresultado = new List<ServicioInventario>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ServicioInventario u = new ServicioInventario  //el orden del itemarray debe considir con las consultas 
                        {
                            IDServicioInventario = Convert.ToInt32(row.ItemArray[0].ToString()),
                            IDServicio = Convert.ToInt32(row.ItemArray[1].ToString()),
                            IDInventario = Convert.ToInt32(row.ItemArray[2].ToString()),
                            CantidadUsada = Convert.ToInt32(row.ItemArray[3].ToString()),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<Cita> ConsultarCita(SQLPeticion P_peticion)
        {
            List<Cita> lstresultado = new List<Cita>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        Cita u = new Cita  //el orden del itemarray debe considir con las consultas 
                        {
                            IDCita = Convert.ToInt32(row.ItemArray[0].ToString()),
                            ClienteId = Convert.ToInt32(row.ItemArray[1].ToString()),
                            NombreCliente = row.ItemArray[2].ToString(),
                            EmpleadoId = Convert.ToInt32(row.ItemArray[3].ToString()),
                            NombreEmpleado = row.ItemArray[4].ToString(),
                            ServicioId = Convert.ToInt32(row.ItemArray[5].ToString()),
                            NombreServicio = row.ItemArray[6].ToString(),
                            Fecha = row.ItemArray[7].ToString(),
                            Hora = row.ItemArray[8].ToString(),
                            Notas = row.ItemArray[9].ToString(),

                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        #endregion

        #region PublicosFS
        public List<UsuarioFS> ConsultarUsuarioFS(SQLPeticion P_peticion)
        {
            List<UsuarioFS> lstresultado = new List<UsuarioFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        UsuarioFS u = new UsuarioFS  //el orden del itemarray debe considir con las consultas 
                        {
                            EmpleadoID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            NombreCompleto = row.ItemArray[1].ToString(),
                            Cargo = row.ItemArray[2].ToString(),
                            Email = row.ItemArray[3].ToString(),
                            Telefono = row.ItemArray[4].ToString(),
                            Direccion = row.ItemArray[5].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<ClienteFS> ConsultarClienteFS(SQLPeticion P_peticion)
        {
            List<ClienteFS> lstresultado = new List<ClienteFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ClienteFS u = new ClienteFS  //el orden del itemarray debe considir con las consultas 
                        {
                            ClienteID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            C_Nombre = row.ItemArray[1].ToString(),
                            C_Apellidos = row.ItemArray[2].ToString(),
                            Email = row.ItemArray[3].ToString(),
                            C_Telefono = row.ItemArray[4].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<ProductoFS> ConsultarProductoFS(SQLPeticion P_peticion)
        {
            List<ProductoFS> lstresultado = new List<ProductoFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ProductoFS u = new ProductoFS  //el orden del itemarray debe considir con las consultas 
                        {
                            ProductoID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            P_Nombre = row.ItemArray[1].ToString(),
                            Descripcion = row.ItemArray[2].ToString(),
                            Precio = row.ItemArray[3].ToString(),
                            Stock= Convert.ToInt32(row.ItemArray[4].ToString()),
                            Categoria = row.ItemArray[5].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<ProveedorFS> ConsultarProveedorFS(SQLPeticion P_peticion)
        {
            List<ProveedorFS> lstresultado = new List<ProveedorFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ProveedorFS u = new ProveedorFS  //el orden del itemarray debe considir con las consultas 
                        {
                            ProveedorID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            NombreEmpresa = row.ItemArray[1].ToString(),
                            Contacto = row.ItemArray[2].ToString(),
                            Telefono = row.ItemArray[3].ToString(),
                            Direccion = row.ItemArray[4].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<UsuarioUFS> ConsultarUFS(SQLPeticion P_peticion)
        {
            List<UsuarioUFS> lstresultado = new List<UsuarioUFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        UsuarioUFS u = new UsuarioUFS  //el orden del itemarray debe considir con las consultas 
                        {
                            UsuarioID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            NombreUsuario = row.ItemArray[1].ToString(),
                            Contrasena = row.ItemArray[2].ToString(),
                            EmpleadoID = Convert.ToInt32(row.ItemArray[3].ToString()),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<RolesFS> ConsultarRolesFS(SQLPeticion P_peticion)
        {
            List<RolesFS> lstresultado = new List<RolesFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        RolesFS u = new RolesFS  //el orden del itemarray debe considir con las consultas 
                        {
                            RolID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            NombreRol = row.ItemArray[1].ToString(),

                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<UxRFS> ConsultarUxRFS(SQLPeticion P_peticion)
        {
            List<UxRFS> lstresultado = new List<UxRFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        UxRFS u = new UxRFS  //el orden del itemarray debe considir con las consultas 
                        {
                            UsuarioID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            RolID = Convert.ToInt32(row.ItemArray[1].ToString()),

                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<OrdenCompraFS> ConsultarOrdenCompraFS(SQLPeticion P_peticion)
        {
            List<OrdenCompraFS> lstresultado = new List<OrdenCompraFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        OrdenCompraFS u = new OrdenCompraFS  //el orden del itemarray debe considir con las consultas 
                        {
                            OrdenID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            FechaOrden = row.ItemArray[1].ToString(),
                            ProveedorID = Convert.ToInt32(row.ItemArray[2].ToString()),
                            Total = row.ItemArray[3].ToString(),
                            Estado = row.ItemArray[4].ToString(),
                            EmpleadoID = Convert.ToInt32(row.ItemArray[5].ToString()),

                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<DetalleOrdenCompraFS> ConsultarDetalleOrdenCompraFS(SQLPeticion P_peticion)
        {
            List<DetalleOrdenCompraFS> lstresultado = new List<DetalleOrdenCompraFS>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion
                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DetalleOrdenCompraFS detalle = new DetalleOrdenCompraFS
                        {
                            DetalleID = Convert.ToInt32(row.ItemArray[0]),
                            OrdenID = Convert.ToInt32(row.ItemArray[1]),
                            ProductoID = Convert.ToInt32(row.ItemArray[2]),
                            Cantidad = Convert.ToInt32(row.ItemArray[3]),
                            PrecioUnitario = Convert.ToInt32(row.ItemArray[4]),
                            TotalLinea = Convert.ToInt32(row.ItemArray[5])
                        };
                        lstresultado.Add(detalle);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        public List<DetalleOrdenVentaFS> ConsultarDetalleOrdenVentaFS(SQLPeticion P_peticion)
        {
            List<DetalleOrdenVentaFS> lstresultado = new List<DetalleOrdenVentaFS>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion
                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DetalleOrdenVentaFS detalle = new DetalleOrdenVentaFS
                        {
                            DetalleID = Convert.ToInt32(row.ItemArray[0]),
                            VentaID = Convert.ToInt32(row.ItemArray[1]),
                            ProductoID = Convert.ToInt32(row.ItemArray[2]),
                            Cantidad = Convert.ToInt32(row.ItemArray[3]),
                            PrecioUnitario = Convert.ToInt32(row.ItemArray[4]),
                            TotalLinea = Convert.ToInt32(row.ItemArray[5])
                        };
                        lstresultado.Add(detalle);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        public List<AuditoriaEmpleadosFS> ConsultarAuditoriaEmpleadosFS(SQLPeticion P_peticion)
        {
            List<AuditoriaEmpleadosFS> lstresultado = new List<AuditoriaEmpleadosFS>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion
                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        AuditoriaEmpleadosFS auditoria = new AuditoriaEmpleadosFS
                        {
                            AuditoriaID = Convert.ToInt32(row.ItemArray[0]),
                            EmpleadoID = Convert.ToInt32(row.ItemArray[1]),
                            NombreCompleto = row.ItemArray[2].ToString(),
                            Cargo = row.ItemArray[3].ToString(),
                            Email = row.ItemArray[4].ToString(),
                            Telefono = row.ItemArray[5].ToString(),
                            Direccion = row.ItemArray[6].ToString(),
                            FechaAuditoria = row.ItemArray[7].ToString(),
                            Accion = row.ItemArray[8].ToString(),

                        };
                        lstresultado.Add(auditoria);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        public List<AuditoriaOrdenesCompraFS> ConsultarAuditoriaOrdenesCompraFS(SQLPeticion P_peticion)
        {
            List<AuditoriaOrdenesCompraFS> lstresultado = new List<AuditoriaOrdenesCompraFS>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion
                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        AuditoriaOrdenesCompraFS auditoria = new AuditoriaOrdenesCompraFS
                        {
                            AuditoriaID = Convert.ToInt32(row.ItemArray[0]),
                            OrdenID = Convert.ToInt32(row.ItemArray[1]),
                            FechaOrden = row.ItemArray[2].ToString(),
                            ProveedorID = Convert.ToInt32(row.ItemArray[3]),
                            Estado = row.ItemArray[5].ToString(),
                            EmpleadoID = Convert.ToInt32(row.ItemArray[6]),
                            FechaAuditoria = row.ItemArray[7].ToString(),
                            Accion = row.ItemArray[8].ToString(),
                        };
                        lstresultado.Add(auditoria);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepción, si es necesario
                throw ex;
            }
            finally
            {
                CERRAR(); // Asegúrate de que CERRAR() cierre la conexión adecuadamente
            }

            return lstresultado;
        }

        public List<OrdenVentaFS> ConsultarOrdenVentaFS(SQLPeticion P_peticion)
        {
            List<OrdenVentaFS> lstresultado = new List<OrdenVentaFS>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion
                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        OrdenVentaFS orden = new OrdenVentaFS
                        {
                            VentaID = Convert.ToInt32(row.ItemArray[0]),
                            FechaVenta = row.ItemArray[1].ToString(),
                            ClienteID = Convert.ToInt32(row.ItemArray[2]),
                            Total = Convert.ToInt32(row.ItemArray[3]), // Nota: Cambia el tipo si es decimal
                            Estado = row.ItemArray[4].ToString(),
                            EmpleadoID = Convert.ToInt32(row.ItemArray[5])
                        };
                        lstresultado.Add(orden);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar excepción, si es necesario
                throw ex;
            }
            finally
            {
                CERRAR(); // Asegúrate de que CERRAR() cierre la conexión adecuadamente
            }

            return lstresultado;
        }

        public List<HistorialPrecioFS> ConsultarHistorialPrecioFS(SQLPeticion P_peticion)
        {
            List<HistorialPrecioFS> lstresultado = new List<HistorialPrecioFS>();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion
                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        HistorialPrecioFS historial = new HistorialPrecioFS
                        {
                            HistorialID = Convert.ToInt32(row.ItemArray[0]),
                            ProductoID = Convert.ToInt32(row.ItemArray[1]),
                            FechaCambio = row.ItemArray[2].ToString(),
                            PrecioAntiguo = Convert.ToInt32(row.ItemArray[3]),
                            PrecioNuevo = Convert.ToInt32(row.ItemArray[4])
                        };
                        lstresultado.Add(historial);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CERRAR();
            }

            return lstresultado;
        }

        public List<TransaccionesInven> ConsultarTransaccionesInven(SQLPeticion P_peticion)
        {
            List<TransaccionesInven> lstresultado = new List<TransaccionesInven>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        TransaccionesInven u = new TransaccionesInven  //el orden del itemarray debe considir con las consultas 
                        {
                            TransaccionID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            FechaTransaccion = row.ItemArray[1].ToString(),
                            TipoTransaccion = row.ItemArray[2].ToString(),
                            ProductoID = Convert.ToInt32(row.ItemArray[3].ToString()),
                            Cantidad = Convert.ToInt32(row.ItemArray[4].ToString()),
                            Notas = row.ItemArray[5].ToString(),
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }

        public List<ObtenerClientesOrdenesVentaFS> ConsultarCOV(SQLPeticion P_peticion)
        {
            List<ObtenerClientesOrdenesVentaFS> lstresultado = new List<ObtenerClientesOrdenesVentaFS>();
            DataTable dt = new DataTable();


            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    CommandType = System.Data.CommandType.Text,
                    CommandText = P_peticion.Peticion,
                    Connection = objconexion

                };

                if (P_peticion.ListaParametros.Count() > 0)
                    cmd.Parameters.AddRange(P_peticion.ListaParametros.ToArray());

                SqlDataAdapter objconsulta = new SqlDataAdapter(cmd);
                objconsulta.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        ObtenerClientesOrdenesVentaFS u = new ObtenerClientesOrdenesVentaFS  //el orden del itemarray debe considir con las consultas 
                        {
                            ClienteID = Convert.ToInt32(row.ItemArray[0].ToString()),
                            C_Nombre = row.ItemArray[1].ToString(),
                            C_Apellidos = row.ItemArray[2].ToString(),
                            C_Telefono = row.ItemArray[3].ToString(),
                            VentaID = Convert.ToInt32(row.ItemArray[4].ToString()),
                            FechaVenta = row.ItemArray[5].ToString(),
                            VentaTotal = Convert.ToInt32(row.ItemArray[6].ToString()),
                            
                        };
                        lstresultado.Add(u);

                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                CERRAR();
            }
            return lstresultado;

        }
        #endregion

        #endregion


    }
}
