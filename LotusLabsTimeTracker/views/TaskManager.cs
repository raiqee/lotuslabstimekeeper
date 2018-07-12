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
    public partial class TaskManager : Form
    {
        public TaskManager()
        {
            InitializeComponent();
        }

        private void btn_taskType_Click(object sender, EventArgs e)
        {
            TaskType task = new TaskType();
            task.Show();
            this.Hide();
        }

        private void btn_projectType_Click(object sender, EventArgs e)
        {
            ProjectType project = new ProjectType();
            project.Show();
            this.Hide();
        }

        private void btn_workType_Click(object sender, EventArgs e)
        {
            WorkType work = new WorkType();
            work.Show();
            this.Hide();
        }
    }
}
