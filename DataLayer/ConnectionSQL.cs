using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DataLayer
{
    public class ConnectionSQL{

        private static readonly ConnectionSQL _instance = new ConnectionSQL();

        public static ConnectionSQL Instance
        {
            get { return ConnectionSQL._instance; }
        }

        private SqlConnection connection = null;
        private SqlCommand command = null;

        public SqlConnection getConnection()
        {
            try
            {
                if (connection == null && connection.State == ConnectionState.Closed){
                    return connectSQL();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Acabo de detectar un error: " + ex.Message, "Sistema de errores | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Se ha conectado a la base de datos correctamente.", "Base de datos | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var tableProveedor = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ProveedorTable' and xtype='U')" +
                    "CREATE TABLE ProveedorTable(" +
                    "idProveedor varchar(11) not null," +
                    "nameProveedor varchar(64) not null," +
                    "businessNameProveedor varchar(24) not null," +
                    "addressProveedor varchar(100)," +
                    "phoneProveedor varchar(12)," +
                    "CONSTRAINT PK_ID_PROVEEDOR PRIMARY KEY(idProveedor));";

                var tableMateriales = "IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='MaterialesTable' and xtype='U')" +
                    "CREATE TABLE MaterialesTable(" +
                    "idMaterial varchar(11) not null," +
                    "nameMaterial varchar(64) not null," +
                    "categoryMaterial varchar(32) not null," +
                    "fechaIngresoMaterial date not null," +
                    "loteMaterial int not null," +
                    "fechaVencimientoMaterial date not null," +
                    "idProveedor varchar(11) not null," +
                    "cantidadMaterial int not null," +
                    "CONSTRAINT PK_ID_MATERIAL PRIMARY KEY(idMaterial)," +
                    "CONSTRAINT FK_ID_PROVEEDOR FOREIGN KEY (idProveedor) references ProveedorTable(idProveedor));";

                command = new SqlCommand(tableProveedor, connection);
                command.ExecuteNonQuery();
                command = new SqlCommand(tableMateriales, connection);
                command.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Acabo de detectar un error: " + ex.Message, "Sistema de errores | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connection;
        }


    }

}
