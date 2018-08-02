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
    public partial class MaintenanceMenu : Form
    {
        private MainMenu _mainMenu;
        private Users currentSessionUser;

        public MaintenanceMenu(MainMenu mainMenu)
        {
            InitializeComponent();
            _mainMenu = mainMenu;
        }

        private void btn_prodMgr_Click(object sender, EventArgs e)
        {
            ProfileManager profileMgr = new ProfileManager(this);
            profileMgr.setCurrentSessionUser(this.currentSessionUser);
            profileMgr.Show();
            this.Hide();
        }

        private void btn_taskMgr_Click(object sender, EventArgs e)
        {
            TaskManager taskMgr = new TaskManager(this);
            taskMgr.setCurrentSessionUser(this.currentSessionUser);
            taskMgr.Show();
            this.Hide();
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void MaintenanceMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }

        private void MaintenanceMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
