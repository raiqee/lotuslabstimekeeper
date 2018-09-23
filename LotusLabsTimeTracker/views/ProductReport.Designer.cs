namespace LotusLabsTimeTracker.views
{
    partial class ProductReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTaskCount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_employee = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_prodFilter = new System.Windows.Forms.GroupBox();
            this.cbo_prodWorkType = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_prodReport = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbo_prodProjType = new System.Windows.Forms.ComboBox();
            this.cbo_prodTaskType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.cbo_prodFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1006, 537);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 36);
            this.button1.TabIndex = 39;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 541);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 25);
            this.label12.TabIndex = 40;
            this.label12.Text = "Task Count :";
            // 
            // lblTaskCount
            // 
            this.lblTaskCount.AutoSize = true;
            this.lblTaskCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskCount.Location = new System.Drawing.Point(220, 541);
            this.lblTaskCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskCount.Name = "lblTaskCount";
            this.lblTaskCount.Size = new System.Drawing.Size(24, 25);
            this.lblTaskCount.TabIndex = 43;
            this.lblTaskCount.Text = "8";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 126);
            this.panel1.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_employee);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblEmployeeNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(356, 126);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbo_employee
            // 
            this.cbo_employee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_employee.FormattingEnabled = true;
            this.cbo_employee.Location = new System.Drawing.Point(147, 12);
            this.cbo_employee.Name = "cbo_employee";
            this.cbo_employee.Size = new System.Drawing.Size(201, 24);
            this.cbo_employee.TabIndex = 18;
            this.cbo_employee.SelectedIndexChanged += new System.EventHandler(this.cbo_employee_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "06/06/2018 02:44:42 PM";
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Location = new System.Drawing.Point(148, 43);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(101, 17);
            this.lblEmployeeNumber.TabIndex = 16;
            this.lblEmployeeNumber.Text = "EMP05102015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Name:";
            // 
            // cbo_prodFilter
            // 
            this.cbo_prodFilter.Controls.Add(this.cbo_prodWorkType);
            this.cbo_prodFilter.Controls.Add(this.label16);
            this.cbo_prodFilter.Controls.Add(this.btn_prodReport);
            this.cbo_prodFilter.Controls.Add(this.dateTimePicker2);
            this.cbo_prodFilter.Controls.Add(this.dateTimePicker1);
            this.cbo_prodFilter.Controls.Add(this.label10);
            this.cbo_prodFilter.Controls.Add(this.label9);
            this.cbo_prodFilter.Controls.Add(this.cbo_prodProjType);
            this.cbo_prodFilter.Controls.Add(this.cbo_prodTaskType);
            this.cbo_prodFilter.Controls.Add(this.label8);
            this.cbo_prodFilter.Controls.Add(this.label7);
            this.cbo_prodFilter.Controls.Add(this.label4);
            this.cbo_prodFilter.Location = new System.Drawing.Point(367, 6);
            this.cbo_prodFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_prodFilter.Name = "cbo_prodFilter";
            this.cbo_prodFilter.Padding = new System.Windows.Forms.Padding(4);
            this.cbo_prodFilter.Size = new System.Drawing.Size(809, 126);
            this.cbo_prodFilter.TabIndex = 34;
            this.cbo_prodFilter.TabStop = false;
            this.cbo_prodFilter.Text = "Filter";
            this.cbo_prodFilter.Enter += new System.EventHandler(this.cbo_prodFilter_Enter);
            // 
            // cbo_prodWorkType
            // 
            this.cbo_prodWorkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_prodWorkType.FormattingEnabled = true;
            this.cbo_prodWorkType.Location = new System.Drawing.Point(112, 34);
            this.cbo_prodWorkType.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_prodWorkType.Name = "cbo_prodWorkType";
            this.cbo_prodWorkType.Size = new System.Drawing.Size(160, 24);
            this.cbo_prodWorkType.TabIndex = 40;
            this.cbo_prodWorkType.SelectedIndexChanged += new System.EventHandler(this.cbo_prodWorkType_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(8, 39);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "Work Type :";
            // 
            // btn_prodReport
            // 
            this.btn_prodReport.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_prodReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prodReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prodReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_prodReport.Location = new System.Drawing.Point(550, 34);
            this.btn_prodReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prodReport.Name = "btn_prodReport";
            this.btn_prodReport.Size = new System.Drawing.Size(234, 64);
            this.btn_prodReport.TabIndex = 38;
            this.btn_prodReport.Text = "Load";
            this.btn_prodReport.UseVisualStyleBackColor = false;
            this.btn_prodReport.Click += new System.EventHandler(this.btn_prodReport_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(394, 77);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker2.TabIndex = 37;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(394, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 22);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(332, 81);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "To :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "From :";
            // 
            // cbo_prodProjType
            // 
            this.cbo_prodProjType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_prodProjType.FormattingEnabled = true;
            this.cbo_prodProjType.Location = new System.Drawing.Point(112, 61);
            this.cbo_prodProjType.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_prodProjType.Name = "cbo_prodProjType";
            this.cbo_prodProjType.Size = new System.Drawing.Size(160, 24);
            this.cbo_prodProjType.TabIndex = 33;
            // 
            // cbo_prodTaskType
            // 
            this.cbo_prodTaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_prodTaskType.FormattingEnabled = true;
            this.cbo_prodTaskType.Location = new System.Drawing.Point(112, 89);
            this.cbo_prodTaskType.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_prodTaskType.Name = "cbo_prodTaskType";
            this.cbo_prodTaskType.Size = new System.Drawing.Size(160, 24);
            this.cbo_prodTaskType.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(332, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Date Range :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Project :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Task : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 397);
            this.panel2.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 397);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 658);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbo_prodFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTaskCount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1207, 705);
            this.MinimumSize = new System.Drawing.Size(1207, 705);
            this.Name = "ProductReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductReport_FormClosed);
            this.Load += new System.EventHandler(this.ProductReport_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.cbo_prodFilter.ResumeLayout(false);
            this.cbo_prodFilter.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTaskCount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox cbo_prodFilter;
        private System.Windows.Forms.Button btn_prodReport;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbo_prodProjType;
        private System.Windows.Forms.ComboBox cbo_prodTaskType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbo_employee;
        private System.Windows.Forms.ComboBox cbo_prodWorkType;
        private System.Windows.Forms.Label label16;
    }
}