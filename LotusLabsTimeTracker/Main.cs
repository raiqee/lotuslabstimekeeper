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
using LotusLabsTimeTracker.views;

namespace LotusLabsTimeTracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            String username = this.txt_username.Text;
            String password = this.txt_password.Text;
            List<String> errMessages = getUserController().validateUserLogin(username, password);
            if (errMessages.Count > 0)
            {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            Users user = getUserController().getUserDetails(username);
            if (!user.validated)
            {
                ChangePassword changePassword = new ChangePassword(this);
                this.Hide();
                this.txt_username.Text = String.Empty;
                this.txt_password.Text = String.Empty;
                changePassword.setCurrentSessionUser(user);
                changePassword.ShowDialog();
            }
            else {
                views.MainMenu mainMenu = new views.MainMenu();
                mainMenu.setCurrentSessionUser(user);
                this.Close();
                mainMenu.ShowDialog();
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addNewUser addNewUser = new addNewUser(this);
            this.Hide();
            addNewUser.ShowDialog();
        }
    }
}
