using LotusLabsTimeTracker.controllers;
using LotusLabsTimeTracker.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotusLabsTimeTracker.views
{
    public partial class ProductReport : Form
    {
        private ProductionModule _productionModule;
        private Users currentSessionUser;

        public ProductReport(ProductionModule productionModule)
        {
            InitializeComponent();
            this._productionModule = productionModule;
        }

        private void ProductReport_Load(object sender, EventArgs e)
        {

            foreach (model.WorkType workType in getLookupController().getWorkTypes(true))
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = workType.name;
                item.Value = workType.id.ToString();
                cbo_prodWorkType.Items.Add(item);
            }
            foreach (model.TaskType taskType in getLookupController().getTaskTypes(true))
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = taskType.name;
                item.Value = taskType.id.ToString();
                cbo_prodTaskType.Items.Add(item);
            }
            foreach (model.Users employee in getUserController().getUsersByRank(getCurrentSessionUser())) {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = getUserController().getFullName(employee);
                item.Value = employee.id.ToString();
                cbo_employee.Items.Add(item);
            }
            cbo_employee.SelectedIndex = cbo_employee.FindStringExact(getUserController().getFullName(currentSessionUser));
            ComboBoxItem selectedItem = cbo_employee.SelectedItem as ComboBoxItem;
            long id = selectedItem == null ? (long)0 : long.Parse(selectedItem.Value.ToString());
            Users user = getUserController().getUserDetails(id);
            lblEmployeeNumber.Text = user.username;

            //public DataTable getUserTasks(Users user, WorkType workType, Project project, TaskType taskType)
            refreshGrid();

        }

        public void refreshGrid()
        {
            dataGridView1.Update();
            dataGridView1.Refresh();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ComboBoxItem selectedUser = cbo_employee.SelectedItem as ComboBoxItem;
            Users user = new Users();
            user.id = selectedUser == null ? (long)0 : long.Parse(selectedUser.Value.ToString());

            ComboBoxItem selectedWorkType = cbo_prodWorkType.SelectedItem as ComboBoxItem;
            model.WorkType workType = new model.WorkType();
            workType.id = selectedWorkType == null ? (long)0 : long.Parse(selectedWorkType.Value.ToString()); ;

            ComboBoxItem selectedProject = cbo_prodProjType.SelectedItem as ComboBoxItem;
            model.Project project = new model.Project();
            project.id = selectedProject == null ? (long)0 : long.Parse(selectedProject.Value.ToString()); ;

            ComboBoxItem selectedTask = cbo_prodTaskType.SelectedItem as ComboBoxItem;
            model.TaskType taskType = new model.TaskType();
            taskType.id = selectedTask == null ? (long)0 : long.Parse(selectedTask.Value.ToString()); ;

            //Users user, WorkType workType, Project project, TaskType taskType
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            dataGridView1.DataSource = getProductionController().getUserTasks(user, workType, project, taskType, start, end);

            lblTaskCount.Text = dataGridView1.DisplayedRowCount(false).ToString();
        }

        public Users getCurrentSessionUser()
        {
            return this.currentSessionUser;
        }

        public void setCurrentSessionUser(Users currentSessionUser)
        {
            this.currentSessionUser = currentSessionUser;
        }

        private void ProductReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this._productionModule.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private LookupController getLookupController()
        {
            return new LookupController();
        }

        private ProductionController getProductionController() {
            return new ProductionController();
        }

        private void cbo_prodFilter_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbo_prodWorkType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = cbo_prodWorkType.SelectedItem as ComboBoxItem;
            model.WorkType workType = new model.WorkType();
            workType.id = selectedItem == null ? (long)0 : long.Parse(selectedItem.Value.ToString());

            cbo_prodProjType.Items.Clear();
            foreach (Project project in getLookupController().getProjectsByWorkType(true, workType))
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = project.name;
                item.Value = project.id.ToString();
                cbo_prodProjType.Items.Add(item);
            }
        }

        private UserController getUserController()
        {
            return new UserController();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbo_employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem selectedItem = cbo_employee.SelectedItem as ComboBoxItem;
            long id = selectedItem == null ? (long)0 : long.Parse(selectedItem.Value.ToString());
            Users user = getUserController().getUserDetails(id);
            if (user != null) {
                lblEmployeeNumber.Text = user.username;
            }
            
        }

        private void btn_prodReport_Click(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filename = "Production_Report" + DateTime.Now.ToString("MMddyyhhmmtt") +".csv";
            String folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + filename;
            string separator = ",";
            string delimiter = "\"";


            var csvString = new StringBuilder();
            //headers
            csvString.Append("Date").Append(separator);
            csvString.Append("Task").Append(separator);
            csvString.Append("Project").Append(separator);
            csvString.Append("Work Type").Append(separator);
            csvString.Append("Details").Append(separator);
            csvString.Append("Start Time").Append(separator);
            csvString.Append("End Time").Append(separator);
            csvString.Append("Elapsed Time");
            csvString.AppendLine();

            foreach (DataGridViewRow row in dataGridView1.Rows) {

                csvString.Append(delimiter + Convert.ToDateTime(row.Cells[1].Value.ToString()).ToString("MM/dd/yyyy HH:mm:ss") + delimiter).Append(separator);
                csvString.Append(delimiter + row.Cells[2].Value + delimiter).Append(separator);
                csvString.Append(delimiter + row.Cells[3].Value + delimiter).Append(separator);
                csvString.Append(delimiter + row.Cells[4].Value + delimiter).Append(separator);
                csvString.Append(delimiter + row.Cells[5].Value + delimiter).Append(separator);
                csvString.Append(delimiter + Convert.ToDateTime(row.Cells[6].Value.ToString()).ToString("MM/dd/yyyy HH:mm:ss") + delimiter).Append(separator);
                csvString.Append(delimiter + Convert.ToDateTime(row.Cells[7].Value.ToString()).ToString("MM/dd/yyyy HH:mm:ss") + delimiter).Append(separator);

                DateTime startDate = Convert.ToDateTime(row.Cells[6].Value.ToString());
                DateTime endDate = Convert.ToDateTime(row.Cells[7].Value.ToString());

                TimeSpan elapsed = (endDate - startDate);

                csvString.Append(delimiter + elapsed.ToString(@"hh\:mm\:ss") + delimiter).Append(separator);
                csvString.AppendLine();
            }

            //after your loop
            File.WriteAllText(folderPath, csvString.ToString());

            MessageBox.Show("Report successfully generated. Check it on your Desktop with file name : " + filename);


        }
    }
}
