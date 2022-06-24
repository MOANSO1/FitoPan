using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan.Menus
{
    public partial class PrincipalMenu : Form
    {
        public PrincipalMenu()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            subMenuMateriales.Visible = false;
            subMenuProveedor.Visible = false;
        }
        private void hideSubMenus()
        {
            if (subMenuMateriales.Visible == true) subMenuMateriales.Visible = false;
            if(subMenuProveedor.Visible == true) subMenuProveedor.Visible = false;
        }

        private void showSubMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }

        private void PrincipalMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openFormsChild(Form formChild)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = formChild;
            formChild.TopLevel = false;
            formChild.FormBorderStyle = FormBorderStyle.None;
            formChild.Dock = DockStyle.Fill;
            panelForms.Controls.Add(formChild);
            panelForms.Tag = formChild;
            formChild.BringToFront();
            formChild.Show();
        }

        private void buttonProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            showSubMenus(subMenuProveedor);
        }

        private void buttonRegisterProv_MouseClick(object sender, MouseEventArgs e)
        {
            openFormsChild(new ProveedorMenu());


            hideSubMenus();
        }

        private void buttonRegisterMateria_MouseClick(object sender, MouseEventArgs e)
        {

            //Abre menu xd
            hideSubMenus();
        }

        private void buttonMateria_MouseClick(object sender, MouseEventArgs e)
        {
            showSubMenus(subMenuMateriales);
        }
    }
}
