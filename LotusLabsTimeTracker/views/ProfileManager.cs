using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusLabsTimeTracker.views
{
    public partial class ProfileManager : Form
    {
        private MaintenanceMenu _maintenanceMenu;
        private Users currentSessionUser;
        public ProfileManager(MaintenanceMenu maintenanceMenu)
        {
            InitializeComponent();
            _maintenanceMenu = maintenanceMenu;

        }

        private void lnk_addNewEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addNewUser addNewUser = new addNewUser(this);
            this.Hide();
            addNewUser.ShowDialog();
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            EditUser editUser = new EditUser();
            editUser.Show();
            this.Hide();
        }

        private void ProfileManager_Load(object sender, EventArgs e)
        {

        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void ProfileManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            _maintenanceMenu.Show();
        }
    }
}
