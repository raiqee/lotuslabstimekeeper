using LotusLabsTimeTracker.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotusLabsTimeTracker.model;

namespace LotusLabsTimeTracker.views
{
    public partial class addNewUser : Form
    {
        public addNewUser()
        {
            InitializeComponent();
        }

        private void addEditUser_Load(object sender, EventArgs e)
        {
            UserController userController = new UserController();
            cbo_userType.Items.Add("Select User Type");
            foreach(UserType userType in userController.getUserTypes()) {
                cbo_userType.Items.Add(userType.name);
            }
        }

        private void btn_saveNewEmp_Click(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
