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
        private Users currentSessionUser;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_prodModule_Click(object sender, EventArgs e)
        {
            ProductionModule production = new ProductionModule();
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
            MaintenanceMenu mainteMenu = new MaintenanceMenu();
            mainteMenu.Show();
            this.Hide();
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Main logIn = new Main();
            logIn.Show();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
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
    }
}
