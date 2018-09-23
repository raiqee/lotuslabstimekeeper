using LotusLabsTimeTracker.controllers;
using LotusLabsTimeTracker.model;
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
    public partial class EditUserPage : Form
    {
        private ProfileManager _profileManager;
        private Users currentSessionUser;
        public long selectedUserId { get; set; }

        public EditUserPage(ProfileManager profileManager)
        {
            InitializeComponent();
            this._profileManager = profileManager;
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            Users user = getUserController().getUserDetails(selectedUserId);
            
            foreach (UserType userType in getUserController().getUserTypes())
            {
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

            //cbo_workType.SelectedIndex = cbo_workType.FindStringExact(project.workType.name);
            cbo_userType.SelectedIndex = cbo_userType.FindStringExact(user.usertype.name);
            cmbSearchSupervisor.SelectedIndex = cmbSearchSupervisor.FindStringExact(getUserController().getFullName(user.supervisor)); 
            txt_empNo.Text = user.username;
            txt_empFname.Text = user.firstName;
            txt_empLname.Text = user.lastName;
            txt_empMname.Text = user.middleName;
            txt_empEmail.Text = user.email;
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private void btn_saveNewEmp_Click(object sender, EventArgs e)
        {
            Users user = getUserController().getUserDetails(selectedUserId);
            user.firstName = txt_empFname.Text;
            user.lastName = txt_empLname.Text;
            user.middleName = txt_empMname.Text;
            user.email = txt_empEmail.Text;

            ComboBoxItem selectedUserType = cbo_userType.SelectedItem as ComboBoxItem;
            user.usertype = new UserType();
            user.usertype.id = selectedUserType == null ? (long)0 : (long)selectedUserType.Value;

            ComboBoxItem selectedSupervisor = cmbSearchSupervisor.SelectedItem as ComboBoxItem;
            user.supervisor = new Users();
            user.supervisor.id = selectedSupervisor == null ? (long)0 : (long)selectedSupervisor.Value;

            user.username = txt_empNo.Text;
            List<String> errMessages = getUserController().validateUser(user, false);
            if (errMessages.Count > 0)
            {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            getUserController().updateUser(user);
            MessageBox.Show("User successfully updated");
            
        }

        private void txt_empNo_TextChanged(object sender, EventArgs e)
        {

        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        private void EditUserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            _profileManager.refreshGrid();
            _profileManager.Show();
        }
    }
}
