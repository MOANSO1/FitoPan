using FitoPan.Util.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan.Util.Tables
{
    public class EmpleadoTable
    {
        public void insertEmpleado(Empleado empleado)
        {
            var url = "INSERT INTO EmpleadoTable(username, password) values (@username, @password);";

            using (SqlCommand command = new SqlCommand(url, FitoPan.getInstance().getSQL().getConnection()))
            {
                command.Parameters.AddWithValue("@username", empleado.getUsername());
                command.Parameters.AddWithValue("@password", empleado.getPassword());
                command.ExecuteNonQuery();
            };
        }

        public void findUserPassword(String username, String password)
        {
            var url = "SELECT * FROM EmpleadoTable where (username=@username and password=@password)";
       
            using (SqlCommand command = new SqlCommand(url, FitoPan.getInstance().getSQL().getConnection()))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
               
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        MessageBox.Show("Usted acaba de iniciar sesión correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontrarón los datos.");
                    }
                }

            };

        }



    }
}
