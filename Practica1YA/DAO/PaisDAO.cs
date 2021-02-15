using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEAN;

namespace DAO
{
    public class PaisDAO
    {

        #region CadenaConexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

        public List<PaisBEAN> listaPaises()
        {

            //CREATE PROCEDURE SP_PAIS_list
            //as
            //select idPais, nombrePais, codigoPais from tbPais


            List<PaisBEAN> listaPais = new List<PaisBEAN>();
            PaisBEAN pais;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_PAIS_list", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        using (var datosread = cmd.ExecuteReader())
                        {

                            while (datosread.Read())
                            {
                                pais = new PaisBEAN();
                                pais.idPais = Convert.ToInt32(datosread[0]);
                                pais.nombrePais = Convert.ToString(datosread[1]);
                                pais.codigoPais = Convert.ToString(datosread[2]);
                                listaPais.Add(pais);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return listaPais;
        }

        public Boolean RegistroPais(PaisBEAN paisBEAN)
        {
            //CREATE PROCEDURE SP_PAIS_Insert
            //(@nombrePais varchar(20))
            //AS
            //insert into tbPais(nombrePais) values(@nombrePais)

            bool rpta = false;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_PAIS_Insert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombrePais", paisBEAN.nombrePais);
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
