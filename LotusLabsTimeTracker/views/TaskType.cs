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
    public partial class TaskType : Form
    {
        private TaskManager _taskManager;
        private Users currentSessionUser;
        private Boolean isEditMode = false;
        private Boolean isActiveFlag = true;
        private long tempId = 0L;

        public TaskType(TaskManager taskManager)
        {
            InitializeComponent();
            isEditMode = false;
            tempId = 0L;
            _taskManager = taskManager;
        }

        private void refreshData()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = getLookupController().getTaskTypeDataTable();
        }

        private void TaskType_Load(object sender, EventArgs e)
        { 
            refreshData();
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
            editColumn.Name = "Edit Column";
            editColumn.Text = "Click";
            editColumn.Width = 100;
            editColumn.UseColumnTextForButtonValue = true;

            if (dataGridView1.Columns["Edit Column"] == null)
            {
                dataGridView1.Columns.Insert(4, editColumn);
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Deactivate";
            deleteColumn.Text = "Click";
            editColumn.Width = 100;
            deleteColumn.UseColumnTextForButtonValue = true;

            if (dataGridView1.Columns["Deactivate"] == null)
            {
                dataGridView1.Columns.Insert(5, deleteColumn);
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

        private void TaskType_FormClosed(object sender, FormClosedEventArgs e)
        {
            _taskManager.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.TaskType taskType = new model.TaskType();
            if (isEditMode)
            {
                taskType.id = tempId;
            }
            taskType.code = txtTaskTypeCode.Text;
            taskType.name = txtTaskTypeName.Text;
            taskType.activeFlag = isActiveFlag;

            List<String> errMessages = getLookupController().validateTaskType(taskType);
            if (errMessages.Count > 0)
            {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            taskType = getLookupController().saveTaskType(taskType, (!isEditMode ? true : false), currentSessionUser);
            if (taskType != null && taskType.id != 0)
            {
                refreshData();
                txtTaskTypeCode.Text = String.Empty;
                txtTaskTypeName.Text = String.Empty;
                MessageBox.Show("Task Type successfully saved");
                tempId = 0L;
                isEditMode = false;
                isActiveFlag = true;
            }
        }

        private LookupController getLookupController()
        {
            return new LookupController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _taskManager.Show();
            this.Close();
        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Deactivate"].Index && e.RowIndex >= 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Task Type?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    model.TaskType taskType = getLookupController().getTaskType(row.Cells["ID"].Value.ToString());
                    taskType.activeFlag = false;
                    getLookupController().saveTaskType(taskType, false, currentSessionUser);
                    MessageBox.Show("Task Type successfully deactivated");
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edit Column"].Index && e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                isEditMode = true;
                model.TaskType taskType = getLookupController().getTaskType(row.Cells["ID"].Value.ToString());
                tempId = taskType.id;
                txtTaskTypeCode.Text = taskType.code;
                txtTaskTypeName.Text = taskType.name;
                chkActive.Checked = taskType.activeFlag;
            }
            refreshData();
        }
    }
}
