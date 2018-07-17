using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotusLabsTimeTracker.controllers;
using LotusLabsTimeTracker.model;
using LotusLabsTimeTracker.utilities;

namespace LotusLabsTimeTracker.views
{
    public partial class ChangePassword : Form
    {

        //will act as session since c# windows 
        //application doesnt support session. 
        //value that will be passed from current form to another 
        //so that current logged-in session is alive
        private Users currentSessionUser;

        private Main _main;

        public ChangePassword(Main main)
        {
            InitializeComponent();
            _main = main;
        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_saveNewEmp_Click(object sender, EventArgs e)
        {
            String newPassword = this.newPassword.Text;
            String confirmPassword = this.confirmPassword.Text;
            List<String> errMessages = getUserController().validatePassword(newPassword, confirmPassword);
            if (errMessages.Count > 0) {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                this.newPassword.Text = String.Empty;
                this.confirmPassword.Text = String.Empty;
                return;
            }
            getCurrentSessionUser().password = getUserController().generateHashPassword(newPassword);
            getCurrentSessionUser().validated = true;
            getUserController().updateUser(getCurrentSessionUser());
            MainMenu mainMenu = new MainMenu();
            mainMenu.setCurrentSessionUser(getCurrentSessionUser());
            this.Hide();
            mainMenu.ShowDialog();
        }

        public Users getCurrentSessionUser() {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser) {
            this.currentSessionUser = currentSessionUser;
        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.Show();
        }
    }
}
