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
            workType.activeFlag = chkActive.Checked;

            List<String> errMessages = getLookupController().validateWorkType(workType);
            if (errMessages.Count > 0)
            {
                MessageBox.Show(getStringUtility().arrayToStringMessages(errMessages));
                return;
            }
            workType = getLookupController().saveWorkType(workType, (!isEditMode?true:false), currentSessionUser);
            if (workType != null && workType.id != 0) {
                refreshData();
                txt_code.ReadOnly = false;
                txt_code.Text = String.Empty;
                txt_name.Text = String.Empty;
                MessageBox.Show("Work Type successfully saved");
                tempId = 0L;
                isEditMode = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Status"].Index && e.RowIndex >= 0) {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                bool status = bool.Parse(row.Cells["Status"].Value.ToString());
                String statusStr = status ? "deactivate" : "activate";
                DialogResult dr = MessageBox.Show("Are you sure you want to " + statusStr + " this Work Type?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes) {
                    model.WorkType workType = getLookupController().getWorkType(row.Cells["ID"].Value.ToString());
                    workType.activeFlag = !status;
                    getLookupController().saveWorkType(workType, false, currentSessionUser);
                    MessageBox.Show("Work Type successfully " + statusStr + "d");
                }
            } else if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index && e.RowIndex >= 0) {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                isEditMode = true;
                model.WorkType workType = getLookupController().getWorkType(row.Cells["ID"].Value.ToString());
                tempId = long.Parse(row.Cells["ID"].Value.ToString());
                txt_code.Text = workType.code;
                txt_name.Text = workType.name;
                chkActive.Checked = workType.activeFlag;
                txt_code.ReadOnly = true;
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
            var editIcon = new Bitmap(LotusLabsTimeTracker.Properties.Resources.edit,8,8);
        
            refreshData();

            DataGridViewImageColumn editColumn = new DataGridViewImageColumn();
            editColumn.Name = "Edit";
            editColumn.Image = editIcon;
            editColumn.Width = 50;
            editColumn.MinimumWidth = 50;
            editColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            if (dataGridView1.Columns["Edit"] == null)
            {
                dataGridView1.Columns.Insert(4, editColumn);
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
