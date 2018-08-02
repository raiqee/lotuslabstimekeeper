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
    public partial class MainMenu : Form
    {
        private Main _main;
        private Users currentSessionUser;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        public MainMenu(Main main)
        {
            InitializeComponent();
            this._main = main;
        }

        private void btn_prodModule_Click(object sender, EventArgs e)
        {
            ProductionModule production = new ProductionModule(this);
            production.setCurrentSessionUser(this.currentSessionUser);
            production.Show();
            this.Hide();
        }

        private void btn_pmef_Click(object sender, EventArgs e)
        {
            PMEF pmef = new PMEF();
            pmef.Show();
            this.Hide();
        }

        private void btn_leaveForm_Click(object sender, EventArgs e)
        {
            LeaveForm leave = new LeaveForm();
            leave.Show();
            this.Hide();
        }

        private void btn_maintenance_Click(object sender, EventArgs e)
        {
            MaintenanceMenu mainteMenu = new MaintenanceMenu(this);
            mainteMenu.setCurrentSessionUser(this.currentSessionUser);
            mainteMenu.Show();
            this.Hide();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            this._main.Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (currentSessionUser.usertype.code.Equals(Constants.ROLE_RANK_AND_FILE))
            {
                btn_maintenance.Enabled = false;
            }
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }
    }
}
