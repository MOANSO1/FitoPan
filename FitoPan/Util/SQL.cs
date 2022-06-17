using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace FitoPan.Util
{
    public class SQL {
        private SqlConnection connection = null;
        private SqlCommand command = null;

        public SqlConnection getConnection()
        {
            try
            {
                if (connection == null && connection.State == ConnectionState.Closed)
                {
                    return connectSQL();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;
        }

        public SqlConnection connectSQL()
        {
            try
            {
                string source = "IMJOYCEPG";
                string catalog = "FitoPan";
                string userID = "Joyce";
                string password = "12345";

                string url = "Data Source=" + source + ";Initial Catalog =" + catalog + ";User id=" + userID + ";Password=" + password;

                connection = new SqlConnection(url);
                connection.Open();
                MessageBox.Show("--> Se conectó correctamente a la base SQL <--");

                var tableEmpleado = "IF NOT EXISTS (SELECT * FROM sysobjects " +
                    "where name='EmpleadoTable' and xtype='U')" +
                    "CREATE TABLE EmpleadoTable(" +
                    "username varchar(16) not null," +
                    "password varchar(32) not null," +
                    "CONSTRAINT PK_ID_USERNAME primary key(username));";

                command = new SqlCommand(tableEmpleado, connection);
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return connection;
        }
    }
}

