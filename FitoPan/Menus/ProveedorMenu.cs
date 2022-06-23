using DataLayer;
using DataObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan.Menus
{
    public partial class ProveedorMenu : Form
    {
        public ProveedorMenu()
        {
            InitializeComponent();
            tableModel();
            buttonEnable();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void cleanText()
        {
            rptaNameProveedor.Clear();
            rptaPhone.Clear();
            rptaRazonSocial.Clear();
            rptaRUC.Clear();
            rptaAddressProveedor.Clear();
        }

        private void tableModel()
        {
            var query = "select p.idProveedor as 'ID', p.nameProveedor as 'Nombre del Proveedor', p.businessNameProveedor as 'Razón Social', p.addressProveedor as 'Dirección', p.phoneProveedor as 'Teléfono' FROM ProveedorTable p; ";
            using (SqlCommand command = new SqlCommand(query, ConnectionSQL.Instance.getConnection()))
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                dataGridView1.DataSource = bindingSource;
                sda.Update(dataTable);
                dataGridView1.Refresh();
            }
        }

        private void buttonDisable()
        {
            buttonDelete.Enabled = false;
            buttonModificar.Enabled = false;
            buttonRegister.Enabled = false;
            buttonUpdate.Enabled = true;
        }

        private void buttonEnable()
        {
            buttonDelete.Enabled = true;
            buttonModificar.Enabled = true;
            buttonRegister.Enabled = true;
            buttonUpdate.Enabled = false;
        }

        private void buttonRegister_MouseClick(object sender, MouseEventArgs e)
        {
            if (rptaNameProveedor.Text == "" || rptaPhone.Text == "" || rptaRazonSocial.Text == "" || rptaRUC.Text == "" || rptaAddressProveedor.Text == "")
            {
                MessageBox.Show("Debe completar las casillas en blanco.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String idProveedor = rptaRUC.Text;
            String nameProveedor = rptaNameProveedor.Text;
            String businessNameProveedor = rptaRazonSocial.Text;
            String addressProveedor = rptaAddressProveedor.Text;
            String phoneProveedor = rptaPhone.Text;

            if(FitoPan.getInstance().getProveedorTable().findProveedor(idProveedor) != null)
            {
                MessageBox.Show("Se ha encontrado a otro proveedor con el mismo RUC.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor proveedor = new Proveedor();
            proveedor.setIDProveedor(idProveedor);
            proveedor.setNameProveedor(nameProveedor);
            proveedor.setBusinessNameProveedor(businessNameProveedor);
            proveedor.setPhoneProveedor(phoneProveedor);
            proveedor.setAddressProveedor(addressProveedor);

            FitoPan.getInstance().getProveedorTable().insertProveedor(proveedor);
            cleanText();
            tableModel();
        }

        private void buttonModificar_MouseClick(object sender, MouseEventArgs e)
        {
            String idProveedor = rptaRUC.Text;
            if (idProveedor == "")
            {
                MessageBox.Show("Debe ingresar un RUC para modificar los datos.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FitoPan.getInstance().getProveedorTable().findProveedor(idProveedor) == null)
            {
                MessageBox.Show("No se ha encontrado a otro proveedor con el mismo RUC.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Proveedor proveedor = FitoPan.getInstance().getProveedorTable().findProveedor(idProveedor);
            rptaRUC.Text = proveedor.getIDProveedor();
            rptaNameProveedor.Text = proveedor.getNameProveedor();
            rptaRazonSocial.Text = proveedor.getBusinessNameProveedor();
            rptaPhone.Text = proveedor.getPhoneProveedor();
            rptaAddressProveedor.Text = proveedor.getAddressProveedor();

            buttonDisable();
        }

        private void buttonUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            if (rptaNameProveedor.Text == "" || rptaPhone.Text == "" || rptaRazonSocial.Text == "" || rptaRUC.Text == "" || rptaAddressProveedor.Text == "")
            {
                MessageBox.Show("Debe completar las casillas en blanco.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String idProveedor = rptaRUC.Text;
            String nameProveedor = rptaNameProveedor.Text;
            String businessNameProveedor = rptaRazonSocial.Text;
            String addressProveedor = rptaAddressProveedor.Text;
            String phoneProveedor = rptaPhone.Text;

            Proveedor proveedor = new Proveedor();
            proveedor.setIDProveedor(idProveedor);
            proveedor.setNameProveedor(nameProveedor);
            proveedor.setBusinessNameProveedor(businessNameProveedor);
            proveedor.setPhoneProveedor(phoneProveedor);
            proveedor.setAddressProveedor(addressProveedor);

            FitoPan.getInstance().getProveedorTable().updateProveedor(proveedor);
            cleanText();
            tableModel();
            buttonEnable();
        }

        private void buttonDelete_MouseClick(object sender, MouseEventArgs e)
        {
            String idProveedor = rptaRUC.Text;
            if(idProveedor == "")
            {
                MessageBox.Show("Debe ingresar un RUC para eliminar los datos.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (FitoPan.getInstance().getProveedorTable().findProveedor(idProveedor) == null)
            {
                MessageBox.Show("No se ha encontrado a otro proveedor con el mismo RUC.", "Sistema de seguridad | FitoPan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FitoPan.getInstance().getProveedorTable().deleteProveedor(idProveedor);
            cleanText();
            tableModel();
            buttonEnable();
        }
    }
}
