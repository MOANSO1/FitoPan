using FitoPan.Util;
using FitoPan.Util.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan
{
    class FitoPan{
        private static FitoPan instance = new FitoPan();
        private SQL sql = new SQL();

        private EmpleadoTable empleadoTable = new EmpleadoTable();

        public void startProgram()
        {
            sql.connectSQL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginMenu());
        }



        public static FitoPan getInstance(){return instance;}
        public SQL getSQL() { return sql;}
        
        public EmpleadoTable getEmpleadoTable() { return empleadoTable; }
    }
}
