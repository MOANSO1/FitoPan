using DataObjects;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Tables
{
    public class MaterialesTable {
        public void insertProveedor(Materiales material)
        {
            var query = "INSERT INTO MaterialesTable(idMaterial, nameMaterial, categoryMaterial, fechaIngresoMaterial," +
                "loteMaterial, fechaVencimientoMaterial, idProveedor, cantidadMaterial)" +
                "values(@idMaterial, @nameMaterial, @categoryMaterial, @fechaIngresoMaterial," +
                "@loteMaterial, @fechaVencimientoMaterial, @idProveedor, @cantidadMaterial);";

            using (SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection())){
                command.Parameters.AddWithValue("@idMaterial", material.getIDMaterial());
                command.Parameters.AddWithValue("@nameMaterial", material.getNameMaterial());
                command.Parameters.AddWithValue("@categoryMaterial", material.getCategoryMaterial());
                command.Parameters.AddWithValue("@fechaIngresoMaterial", material.getFechaIngresoMaterial());
                command.Parameters.AddWithValue("@loteMaterial", material.getLoteMaterial());
                command.Parameters.AddWithValue("@fechaVencimientoMaterial", material.getFechaVencimientoMaterial());
                command.Parameters.AddWithValue("@idProveedor", material.getIDProveedor());
                command.Parameters.AddWithValue("@cantidadMaterial", material.getCantidadMaterial()); ;
                
                command.ExecuteNonQuery();
            }
        }

        public void updateMaterial(Materiales material)
        {
            var url = "UPDATE MaterialesTable SET idMaterial=@idMaterial, nameMaterial=@nameMaterial, " +
                "categoryMaterial=@categoryMaterial, fechaIngresoMaterial=@fechaIngresoMaterial, loteMaterial=@loteMaterial, " +
                "fechaVencimientoMaterial=@fechaVencimientoMaterial, idProveedor=@idProveedor, cantidadMaterial=@cantidadMaterial " +
                "WHERE idMaterial=@idMaterial";

            using (SqlCommand command = new SqlCommand(url, ConnectionSQL.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@idMaterial", material.getIDMaterial());
                command.Parameters.AddWithValue("@nameMaterial", material.getNameMaterial());
                command.Parameters.AddWithValue("@categoryMaterial", material.getCategoryMaterial());
                command.Parameters.AddWithValue("@fechaIngresoMaterial", material.getFechaIngresoMaterial());
                command.Parameters.AddWithValue("@loteMaterial", material.getLoteMaterial());
                command.Parameters.AddWithValue("@fechaVencimientoMaterial", material.getFechaVencimientoMaterial());
                command.Parameters.AddWithValue("@idProveedor", material.getIDProveedor());
                command.Parameters.AddWithValue("@cantidadMaterial", material.getCantidadMaterial()); ;
                command.ExecuteNonQuery();
            };
        }

        public Materiales findMaterial(String idMaterial)
        {
            Materiales material = null;

            var query = "SELECT * FROM MaterialesTable WHERE idMaterial=@idMaterial";

            using (SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@idMaterial", idMaterial);

                using (SqlDataReader rs = command.ExecuteReader())
                {
                    if (rs.Read())
                    {
                        String nameMaterial = rs.GetString(1);
                        String categoryMaterial = rs.GetString(2);
                        String fechaIngresoMaterial = rs.GetString(3);
                        String loteMaterial = rs.GetString(4);
                        String fechaVencimientoMaterial = rs.GetString(5);
                        String idProveedor = rs.GetString(6);
                        int cantidadMaterial = rs.GetInt32(7);

                        material = new Materiales();
                        material.setIDMaterial(idMaterial);
                        material.setNameMaterial(nameMaterial);
                        material.setCategoryMaterial(categoryMaterial);
                        material.setFechaIngresoMaterial(fechaIngresoMaterial);
                        material.setLoteMaterial(loteMaterial);
                        material.setFechaVencimientoMaterial(fechaVencimientoMaterial);
                        material.setIDProveedor(idProveedor);
                        material.setCantidadMaterial(cantidadMaterial);
                    }
                }
            }
            return material;
        }

        public void deleteMaterial(String idMaterial)
        {
            var query = "DELETE FROM MaterialesTable WHERE idMaterial=@idMaterial";

            using (SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection()))
            {
                command.Parameters.AddWithValue("@idMaterial", idMaterial);
                command.ExecuteNonQuery();
            }
        }
    }
}
