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
    public class ClienteDAO
    {

        #region CadenaConexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

//        CREATE PROCEDUre SP_CLIENTE_ListaPorDNI
//(@NumDoc varchar(20)
//)
//AS
//select cli.idCliente, cli.nombreCliente, cli.apellidosCliente, cli.numeroDocumentoCliente, 
//cli.generoCliente, cli.idCategoria, cat.nombreCategoria

//from tb_Cliente cli inner join tb_Categoria cat
//on cli.idCategoria = cat.idCategoria
//where cli.numeroDocumentoCliente = '44476373'

        public List<ClienteBEAN> listaCliente(string numDoc)
        {
            List<ClienteBEAN> lista = new List<ClienteBEAN>();
            ClienteBEAN cli;
            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {
                    using (var cmd = new SqlCommand("SP_CLIENTE_ListaPorDNI", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@NumDoc", numDoc);
                        conn.Open();
                        using (var dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                cli = new ClienteBEAN();
                                cli.idCliente = Convert.ToInt32(dr[0]);
                                cli.nombreCliente = Convert.ToString(dr[1]);
                                cli.apellidoCliente = Convert.ToString(dr[2]);
                                cli.numeroDocument = Convert.ToString(dr[3]);
                                cli.generoCliente = Convert.ToString(dr[4]);
                                cli.idCategoria = Convert.ToInt32(dr[5]);
                                cli.nombreCategoria = Convert.ToString(dr[6]);
                                lista.Add(cli);
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


    }
}
