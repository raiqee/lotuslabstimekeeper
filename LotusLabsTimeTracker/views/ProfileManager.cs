using LotusLabsTimeTracker.controllers;
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
    public partial class ProfileManager : Form
    {
        private MaintenanceMenu _maintenanceMenu;
        private Users currentSessionUser;
        private UserType userType { get; set; }
        private Users supervisor { get; set; }
        public ProfileManager(MaintenanceMenu maintenanceMenu)
        {
            InitializeComponent();
            _maintenanceMenu = maintenanceMenu;

        }

        private void lnk_addNewEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addNewUser addNewUser = new addNewUser(this);
            this.Hide();
            addNewUser.ShowDialog();
        }

        private void btn_editUser_Click(object sender, EventArgs e)
        {
            
        }

        private void clearFields() {
            cmbSearchSupervisor.Items.Clear();
            cmbSearchPosition.Items.Clear();
        }

        private void ProfileManager_Load(object sender, EventArgs e)
        {
            clearFields();
            ComboBoxItem emptyItem = new ComboBoxItem();
            emptyItem.Text = "";
            emptyItem.Value = 0L;

            cmbSearchPosition.Items.Add(emptyItem);
            foreach (UserType userType in getUserController().getUserTypes())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = userType.name;
                item.Value = userType.id;
                cmbSearchPosition.Items.Add(item);
            }

            //GET QA MANAGER AND SUPERIVISOR
            cmbSearchSupervisor.Items.Add(emptyItem);
            foreach (Users users in getUserController().getUsersListPerUserType("'QA_MANAGER', 'SUPERVISOR'"))
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = getUserController().getFullName(users);
                item.Value = users.id;
                cmbSearchSupervisor.Items.Add(item);
            }

            refreshGrid();
        }

        public void refreshGrid() {

            var editIcon = new Bitmap(LotusLabsTimeTracker.Properties.Resources.edit, 8, 8);

            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = getUserController().getUsersDataTable(null, null);

            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = "Edit";
            editColumn.Image = editIcon;
            editColumn.Width = 50;
            editColumn.MinimumWidth = 50;
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            if (dataGridView1.Columns["Edit"] == null)
            {
                dataGridView1.Columns.Insert(9, editColumn);
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

        private void ProfileManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            _maintenanceMenu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                String strId = row.Cells["ID"].Value.ToString();
                long id = long.Parse(strId);
                EditUserPage editUser = new EditUserPage(this);
                editUser.setCurrentSessionUser(this.currentSessionUser);
                editUser.selectedUserId = id;
                editUser.Show();
                this.Hide();
            }
        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ComboBoxItem selectedUserType = cmbSearchPosition.SelectedItem as ComboBoxItem;
            this.userType = new UserType();
            this.userType.id = selectedUserType == null ? (long)0 : (long)selectedUserType.Value;

            ComboBoxItem selectedUserSupervisor = cmbSearchSupervisor.SelectedItem as ComboBoxItem;
            this.supervisor = new Users();
            this.supervisor.id = selectedUserSupervisor == null ? (long)0 : (long)selectedUserSupervisor.Value;

            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = getUserController().getUsersDataTable(this.userType, this.supervisor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbSearchPosition.SelectedIndex = 0;
            cmbSearchSupervisor.SelectedIndex = 0;
        }
    }
}
