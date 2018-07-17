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
        private readonly Main _main;
        public addNewUser(Main main)
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
        }

        private void btn_saveNewEmp_Click(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = cbo_userType.SelectedItem as ComboBoxItem;
            Users user = new Users();
            user.firstName = txt_empFname.Text;
            user.lastName = txt_empLname.Text;
            user.middleName = txt_empMname.Text;
            user.email = txt_empEmail.Text;
            user.usertype = new UserType();
            user.usertype.id = selectedItem == null ? (long) 0 : (long) selectedItem.Value;
            user.username = txt_empNo.Text;
            List<String> errMessages = getUserController().validateUser(user);
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
            _main.Show();
        }
    }
}
