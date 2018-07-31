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
    public partial class ProjectType : Form
    {
        private Boolean isActiveFlag = true;
        private Boolean isEditMode = false;
        private long tempId = 0L;
        private TaskManager _taskManager;
        private Users currentSessionUser;

        public ProjectType(TaskManager taskManager)
        {
            InitializeComponent();
            tempId = 0L;
            isEditMode = false;
            _taskManager = taskManager;
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void ProjectType_FormClosed(object sender, FormClosedEventArgs e)
        {
            _taskManager.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _taskManager.Show();
            this.Close();
        }

        private void ProjectType_Load(object sender, EventArgs e)
        {
            foreach (model.WorkType workType in getLookupController().getWorkTypes(false))
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = workType.name;
                item.Value = workType.id.ToString();
                cbo_workType.Items.Add(item);
            }

            refreshData();
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit Column";
            editColumn.Text = "Click";
            editColumn.Width = 100;
            editColumn.UseColumnTextForButtonValue = true;

            if (dataGridView1.Columns["Edit Column"] == null)
            {
                dataGridView1.Columns.Insert(5, editColumn);
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Deactivate";
            deleteColumn.Text = "Click";
            editColumn.Width = 100;
            deleteColumn.UseColumnTextForButtonValue = true;

            if (dataGridView1.Columns["Deactivate"] == null)
            {
                dataGridView1.Columns.Insert(6, deleteColumn);
            }
        }

        private LookupController getLookupController() {
            return new LookupController();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Project project = new Project();
            if (isEditMode)
            {
                project.id = tempId;
            }
            project.code = txtProjectCode.Text;
            project.name = txtProjectName.Text;

            ComboBoxItem selectedItem = cbo_workType.SelectedItem as ComboBoxItem;
            project.workType = new model.WorkType();
            project.workType.id = selectedItem == null ? (long)0 : long.Parse(selectedItem.Value.ToString());
            project.activeFlag = isActiveFlag;

            List<String> errMessages = getLookupController().validateProject(project);
            if (errMessages.Count > 0)
            {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            project = getLookupController().saveProject(project, (!isEditMode?true:false), currentSessionUser);
            if (project != null && project.id != 0)
            {
                refreshData();
                txtProjectCode.Text = String.Empty;
                txtProjectName.Text = String.Empty;
                cbo_workType.SelectedIndex = 0;
                MessageBox.Show("Project successfully saved");
                tempId = 0L;
                isEditMode = false;
                isActiveFlag = true;
            }
        }

        private void refreshData()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = getLookupController().getProjectDataTable();
        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Deactivate"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Project?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    Project project = getLookupController().getProject(row.Cells["ID"].Value.ToString());
                    project.activeFlag = false;
                    getLookupController().saveProject(project, false, currentSessionUser);
                    MessageBox.Show("Project successfully deactivated");
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit Column"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                isEditMode = true;
                Project project = getLookupController().getProject(row.Cells["ID"].Value.ToString());
                tempId = project.id;
                txtProjectCode.Text = project.code;
                txtProjectName.Text = project.name;
                cbo_workType.SelectedIndex = cbo_workType.FindStringExact(project.workType.name);
                chkActive.Checked = project.activeFlag;
            }
            refreshData();
        }
    }
}
