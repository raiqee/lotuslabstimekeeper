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
    public partial class WorkType : Form
    {
        private Boolean isEditMode = false;
        private Boolean isActiveFlag = true;
        private long tempId = 0L;
        private TaskManager _taskManager;
        private Users currentSessionUser;

        public WorkType(TaskManager taskManager)
        {
            InitializeComponent();
            tempId = 0L;
            isEditMode = false;
            _taskManager = taskManager;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.WorkType workType = new model.WorkType();
            if (isEditMode)
            {
                workType.id = tempId;
            }
            workType.code = txt_code.Text;
            workType.name = txt_name.Text;
            workType.activeFlag = isActiveFlag;

            List<String> errMessages = getLookupController().validateWorkType(workType);
            if (errMessages.Count > 0)
            {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            workType = getLookupController().saveWorkType(workType, (!isEditMode?true:false), currentSessionUser);
            if (workType != null && workType.id != 0) {
                refreshData();
                txt_code.Text = String.Empty;
                txt_name.Text = String.Empty;
                MessageBox.Show("Work Type successfully saved");
                tempId = 0L;
                isEditMode = false;
                isActiveFlag = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Deactivate"].Index && e.RowIndex >= 0) {                
                DialogResult dr = MessageBox.Show("Are you sure you want to delete this Work Type?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    model.WorkType workType = getLookupController().getWorkType(row.Cells["ID"].Value.ToString());
                    workType.activeFlag = false;
                    getLookupController().saveWorkType(workType, false, currentSessionUser);
                    MessageBox.Show("Work Type successfully deactivated");
                }
            } else if (e.ColumnIndex == dataGridView1.Columns["Edit Column"].Index && e.RowIndex >= 0) {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                isEditMode = true;
                model.WorkType workType = getLookupController().getWorkType(row.Cells["ID"].Value.ToString());
                tempId = long.Parse(row.Cells["ID"].Value.ToString());
                txt_code.Text = workType.code;
                txt_name.Text = workType.name;
                chkActive.Checked = workType.activeFlag;
            }
            refreshData();
        }

        private void refreshData() {
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = getLookupController().getWorkTypeDataTable();
        }

        private void WorkType_Load(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private StringUtility getStringUtility()
        {
            return new StringUtility();
        }

        private LookupController getLookupController() {
            return new LookupController();
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void WorkType_FormClosed(object sender, FormClosedEventArgs e)
        {
            _taskManager.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _taskManager.Show();
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
