using DataLayer;
using DataLayer.Tables;
using FitoPan.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan
{
    public class FitoPan
    {
        private static FitoPan instance = new FitoPan();
        private ConnectionSQL connectionSQL = new ConnectionSQL();
        private MaterialesTable materialesTable = new MaterialesTable();
        private ProveedorTable proveedorTable = new ProveedorTable();
        private Utilities util = new Utilities();

        public void startProgram(){
            ConnectionSQL.Instance.connectSQL();
            new PrincipalMenu().Show();
            Application.Run();
        }

        public static FitoPan getInstance(){return instance;}
        public ConnectionSQL getConnectionSQL(){return connectionSQL;}
        public ProveedorTable getProveedorTable() { return proveedorTable; }
        public MaterialesTable getMaterialesTable() { return materialesTable; }
        public Utilities getUtilities() { return util; }
    }
}
