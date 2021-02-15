using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEAN;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAO1
{
    public class ProductoDAO
    {

        #region CadenaConexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD"].ConnectionString;
        #endregion

        public List<ProductoBEAN> listaProducto()
        {
            List<ProductoBEAN> lista = new List<ProductoBEAN>();
            ProductoBEAN producto;

            try
            {
                using (var conn = new SqlConnection(_stringConnection))
                {

                    using (var cmd = new SqlCommand("SP_PRODUCTO_list", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();

                        using (var dr = cmd.ExecuteReader())
                        {

                            while (dr.Read())
                            {
                                producto = new ProductoBEAN();
                                producto.idProducto = Convert.ToInt32(dr[0]);
                                producto.nombreProducto = Convert.ToString(dr[1]);
                                producto.descriptionProducto = Convert.ToString(dr[2]);
                                producto.estadoProducto = Convert.ToBoolean(dr[3]);
                                lista.Add(producto);

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
