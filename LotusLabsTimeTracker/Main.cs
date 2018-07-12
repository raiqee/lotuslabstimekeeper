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
using LotusLabsTimeTracker.views;

namespace LotusLabsTimeTracker
{
    public partial class Main : Form
    {
        UserController controller = new UserController();
        public Main()
        {
            InitializeComponent();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            String username = this.txt_username.Text;
            String password = this.txt_password.Text;
            List<String> errMessages = this.validateUser(username, password);
            if (errMessages.Count>0) {
                String concatinatedErrMessages = "";
                foreach (String errMessage in errMessages) {
                    concatinatedErrMessages += errMessage + "\n";
                }
                MessageBox.Show(concatinatedErrMessages);
            }
        }

        private List<String> validateUser(String username, String password) {
            List<String> messages = new List<string>();
            if (username == null){
                messages.Add("Username is required");
            }
            else if (username.Trim().Equals("")) { 
                messages.Add("Username is required"); 
            }
            if (password == null){
                messages.Add("Password is required");
            }
            else if (username.Trim().Equals("")) {
                messages.Add("Password is required");
            }
            return messages;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addEditUser addEditUser = new addEditUser();
            this.Hide();
            addEditUser.ShowDialog();
        }
    }
}
