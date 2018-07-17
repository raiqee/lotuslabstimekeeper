using LotusLabsTimeTracker.model;
using LotusLabsTimeTracker.controllers;
using LotusLabsTimeTracker.utilities;
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
    public partial class ProductionModule : Form
    {
        private MainMenu _mainMenu;
        private Users currentSessionUser;
        
        public ProductionModule(MainMenu mainMenu)
        {
            InitializeComponent();
            this._mainMenu = mainMenu;
        }

        private void ProductionModule_Load(object sender, EventArgs e)
        {
            //Start timer 
            Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            lbl_empName.Text = currentSessionUser.firstName + " " + currentSessionUser.lastName;
            lbl_empNo.Text = currentSessionUser.username;
            lbl_currentDate.Text = DateTime.Now.ToString();
        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_currentDate.Text = DateTime.Now.ToString();
        }

        private void ProductionModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }
    }
}
