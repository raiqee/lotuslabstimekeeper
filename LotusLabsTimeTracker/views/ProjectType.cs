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

            var editIcon = new Bitmap(LotusLabsTimeTracker.Properties.Resources.edit, 8, 8);

            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = "Edit";
            editColumn.Image = editIcon;
            editColumn.Width = 50;
            editColumn.MinimumWidth = 50;
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            if (dataGridView1.Columns["Edit"] == null)
            {
                dataGridView1.Columns.Insert(5, editColumn);
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
            project.activeFlag = chkActive.Checked;

            ComboBoxItem selectedItem = cbo_workType.SelectedItem as ComboBoxItem;
            project.workType = new model.WorkType();
            project.workType.id = selectedItem == null ? (long)0 : long.Parse(selectedItem.Value.ToString());

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
                txtProjectCode.ReadOnly = false;
                txtProjectCode.Text = String.Empty;
                txtProjectName.Text = String.Empty;
                cbo_workType.SelectedIndex = 0;
                MessageBox.Show("Project successfully saved");
                tempId = 0L;
                isEditMode = false;
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
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                bool status = bool.Parse(row.Cells["Status"].Value.ToString());
                String statusStr = status ? "deactivate" : "activate";
                DialogResult dr = MessageBox.Show("Are you sure you want to " + statusStr + " this Project?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    Project project = getLookupController().getProject(row.Cells["ID"].Value.ToString());
                    project.activeFlag = !status;
                    getLookupController().saveProject(project, false, currentSessionUser);
                    MessageBox.Show("Project successfully " + statusStr + "d");
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                isEditMode = true;
                Project project = getLookupController().getProject(row.Cells["ID"].Value.ToString());
                tempId = project.id;
                txtProjectCode.ReadOnly = true;
                txtProjectCode.Text = project.code;
                txtProjectName.Text = project.name;
                cbo_workType.SelectedIndex = cbo_workType.FindStringExact(project.workType.name);
                chkActive.Checked = project.activeFlag;
            }
            refreshData();
        }
    }
}
