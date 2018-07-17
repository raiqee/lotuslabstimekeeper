using LotusLabsTimeTracker.controllers;
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
        
        public WorkType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.WorkType workType = new model.WorkType();
            workType.code = txt_code.Text;
            workType.name = txt_name.Text;
            workType.description = txt_description.Text;
            workType = getLookupController().saveWorkType(workType);
            if (workType != null && workType.id != 0) {
                dataGridView1.Refresh();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void WorkType_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getLookupController().getWorkTypeDataTable();
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
    }
}
