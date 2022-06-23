using DataObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tables
{
    public class ProveedorTable{
        public void insertProveedor(Proveedor proveedor){
            var query = "INSERT INTO ProveedorTable(idProveedor, nameProveedor, businessNameProveedor, addressProveedor, phoneProveedor)" +
                "values(@idProveedor, @nameProveedor, @businessNameProveedor, @addressProveedor, @phoneProveedor);";

            using (SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection())){
                command.Parameters.AddWithValue("@idProveedor", proveedor.getIDProveedor());
                command.Parameters.AddWithValue("@nameProveedor", proveedor.getNameProveedor());
                command.Parameters.AddWithValue("@businessNameProveedor", proveedor.getBusinessNameProveedor());
                command.Parameters.AddWithValue("@addressProveedor", proveedor.getAddressProveedor());
                command.Parameters.AddWithValue("@phoneProveedor", proveedor.getPhoneProveedor());
                command.ExecuteNonQuery();
            }
        }

        public void updateProveedor(Proveedor proveedor)
        {
            var url = "UPDATE ProveedorTable SET nameProveedor=@nameProveedor, businessNameProveedor=@businessNameProveedor," +
                "addressProveedor=@addressProveedor, phoneProveedor=@phoneProveedor WHERE idProveedor=@idProveedor";

            using (SqlCommand command = new SqlCommand(url, ConnectionSQL.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@idProveedor", proveedor.getIDProveedor());
                command.Parameters.AddWithValue("@nameProveedor", proveedor.getNameProveedor());
                command.Parameters.AddWithValue("@businessNameProveedor", proveedor.getBusinessNameProveedor());
                command.Parameters.AddWithValue("@addressProveedor", proveedor.getAddressProveedor());
                command.Parameters.AddWithValue("@phoneProveedor", proveedor.getPhoneProveedor());
                command.ExecuteNonQuery();
            };
        }

        public Proveedor findProveedor(String idProveedor){
            Proveedor proveedor = null;

            var query = "SELECT * FROM ProveedorTable WHERE idProveedor=@idProveedor";

            using (SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection())){
                command.Parameters.AddWithValue("@idProveedor", idProveedor);

                using (SqlDataReader rs = command.ExecuteReader()){
                    if (rs.Read()){
                        String nameProveedor = rs.GetString(1);
                        String businessNameProveedor = rs.GetString(2);
                        String addressProveedor = rs.GetString(3);
                        String phoneProveedor = rs.GetString(4);

                        proveedor = new Proveedor();
                        proveedor.setIDProveedor(idProveedor);
                        proveedor.setNameProveedor(nameProveedor);
                        proveedor.setBusinessNameProveedor(businessNameProveedor);
                        proveedor.setAddressProveedor(addressProveedor);
                        proveedor.setPhoneProveedor(phoneProveedor);

                    }
                }
            }
            return proveedor;
        }

        public void deleteProveedor(String idProveedor){
            var query = "DELETE FROM ProveedorTable WHERE idProveedor=@idProveedor";

            using(SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection())){
                command.Parameters.AddWithValue("@idProveedor", idProveedor);
                command.ExecuteNonQuery();
            }
        }
    }
}
