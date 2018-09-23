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
using LotusLabsTimeTracker.utilities;

namespace LotusLabsTimeTracker.views
{
    public partial class addNewUser : Form
    {
        private readonly ProfileManager _main;
        public addNewUser(ProfileManager main)
        {
            InitializeComponent();
            _main = main;
        }

        public addNewUser()
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

        private void addEditUser_Load(object sender, EventArgs e)
        {
            foreach(UserType userType in getUserController().getUserTypes()) {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = userType.name;
                item.Value = userType.id;
                cbo_userType.Items.Add(item);
            }

            foreach (Users users in getUserController().getUsersListPerUserType("'QA_MANAGER', 'SUPERVISOR'"))
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = getUserController().getFullName(users);
                item.Value = users.id;
                cmbSearchSupervisor.Items.Add(item);
            }
        }

        private void btn_saveNewEmp_Click(object sender, EventArgs e)
        {

            Users user = new Users();
            user.firstName = txt_empFname.Text;
            user.lastName = txt_empLname.Text;
            user.middleName = txt_empMname.Text;
            user.email = txt_empEmail.Text;

            ComboBoxItem selectedUserType = cbo_userType.SelectedItem as ComboBoxItem;
            user.usertype = new UserType();
            user.usertype.id = selectedUserType == null ? (long) 0 : (long)selectedUserType.Value;

            ComboBoxItem selectedSupervisor = cmbSearchSupervisor.SelectedItem as ComboBoxItem;
            user.supervisor = new Users();
            user.supervisor.id = selectedSupervisor == null ? (long)0 : (long)selectedSupervisor.Value;

            user.username = txt_empNo.Text;
            List<String> errMessages = getUserController().validateUser(user, true);
            if (errMessages.Count > 0) { 
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            getUserController().createUser(user);
            MessageBox.Show("User successfully added");
            this.clearForms();
        }

        private void clearForms() {
            txt_empEmail.Text = String.Empty;
            txt_empFname.Text = String.Empty;
            txt_empLname.Text = String.Empty;
            txt_empMname.Text = String.Empty;
            txt_empNo.Text = String.Empty;
            cbo_userType.SelectedIndex = 0;
        }

        private void addNewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            _main.refreshGrid();
            _main.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbo_userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
