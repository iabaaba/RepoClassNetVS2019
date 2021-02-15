using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEAN;

namespace DAO1
{
    public class RolDAO
    {
        #region CadenaConexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion
        public List<RolBEAN> listaRoles() {
            List<RolBEAN> lista = new List<RolBEAN>();
            RolBEAN rol;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_list", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (var datosread = cmd.ExecuteReader()) {

                            while (datosread.Read()) {
                                rol = new RolBEAN();
                                rol.idRol = Convert.ToInt32(datosread[0]);
                                rol.nombreRol = Convert.ToString(datosread[1]);
                                lista.Add(rol);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return lista;
        }

        public Boolean RegistroRol(RolBEAN rolBEAN) {
            bool rpta = false;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_Insert", conn)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreRol", rolBEAN.nombreRol);
                        conn.Open();// de la conexion
                        cmd.ExecuteNonQuery();
                        rpta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception error \n" + ex);
                throw;
            }
            return rpta;
        }

        public List<RolBEAN> RegistroListaRol(RolBEAN rolBEAN)
        {
//CREATE PROCEDURE SP_ROL_InsertANDList
//(@nombreRol varchar(20))
//AS
//insert into tb_rol(nombreRol)
//values(@nombreRol)

//select idRol, nombreRol from tb_Rol

            List< RolBEAN> lista = new List<RolBEAN>();
            RolBEAN rol;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_InsertANDList", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombreRol", rolBEAN.nombreRol);
                        conn.Open();
                        using (var datosread = cmd.ExecuteReader())
                        {

                            while (datosread.Read())
                            {
                                rol = new RolBEAN();
                                rol.idRol = Convert.ToInt32(datosread[0]);
                                rol.nombreRol = Convert.ToString(datosread[1]);
                                lista.Add(rol);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("" + ex);
                throw;
            }
            return lista;
        }

     
        public RolBEAN BuscarRolById(int id) {
            RolBEAN rolBEAN = new RolBEAN();
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_BuscarById", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRol",id);
                        conn.Open();
                        using (var dr = cmd.ExecuteReader()) 
                        {
                            if (dr.Read())
                            {
                                rolBEAN = new RolBEAN();
                                rolBEAN.idRol = Convert.ToInt32(dr[0]);
                                rolBEAN.nombreRol = dr[1].ToString; 

                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        
        public Boolean EditarRol(RolBEAN rolBEAN)
        {
            bool rpta = false;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_ROL_Editar", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRol", rolBEAN.idRol);
                        cmd.Parameters.AddWithValue("@nombreRol", rolBEAN.nombreRol);
                        conn.Open();// de la conexion
                        cmd.ExecuteNonQuery();
                        rpta = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception error \n" + ex);
                throw;
            }
            return rpta;
        }

    }
}

        