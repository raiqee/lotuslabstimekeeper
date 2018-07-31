namespace LotusLabsTimeTracker.views
{
    partial class FIledLeaveForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.dte_to = new System.Windows.Forms.DateTimePicker();
            this.dte_from = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_loadPMEF = new System.Windows.Forms.Button();
            this.btn_approve = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grd_PMEF = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leaveType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbo_empList = new System.Windows.Forms.ComboBox();
            this.lbl_currentDate = new System.Windows.Forms.Label();
            this.lbl_empNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_PMEF)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Date";
            // 
            // dte_to
            // 
            this.dte_to.CustomFormat = "mm/dd/yyyy";
            this.dte_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_to.Location = new System.Drawing.Point(151, 66);
            this.dte_to.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dte_to.Name = "dte_to";
            this.dte_to.Size = new System.Drawing.Size(139, 22);
            this.dte_to.TabIndex = 39;
            // 
            // dte_from
            // 
            this.dte_from.CustomFormat = "mm/dd/yyyy";
            this.dte_from.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_from.Location = new System.Drawing.Point(151, 33);
            this.dte_from.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dte_from.Name = "dte_from";
            this.dte_from.Size = new System.Drawing.Size(139, 22);
            this.dte_from.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "From : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(69, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "To :";
            // 
            // btn_loadPMEF
            // 
            this.btn_loadPMEF.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_loadPMEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadPMEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadPMEF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_loadPMEF.Location = new System.Drawing.Point(772, 25);
            this.btn_loadPMEF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_loadPMEF.Name = "btn_loadPMEF";
            this.btn_loadPMEF.Size = new System.Drawing.Size(147, 71);
            this.btn_loadPMEF.TabIndex = 44;
            this.btn_loadPMEF.Text = "Load";
            this.btn_loadPMEF.UseVisualStyleBackColor = false;
            // 
            // btn_approve
            // 
            this.btn_approve.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_approve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_approve.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_approve.Location = new System.Drawing.Point(671, 358);
            this.btn_approve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_approve.Name = "btn_approve";
            this.btn_approve.Size = new System.Drawing.Size(248, 42);
            this.btn_approve.TabIndex = 43;
            this.btn_approve.Text = "Approve";
            this.btn_approve.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dte_to);
            this.groupBox2.Controls.Add(this.dte_from);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(333, 95);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // grd_PMEF
            // 
            this.grd_PMEF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_PMEF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.leaveType,
            this.shift,
            this.startDate,
            this.endDate,
            this.details,
            this.status});
            this.grd_PMEF.Location = new System.Drawing.Point(15, 123);
            this.grd_PMEF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grd_PMEF.Name = "grd_PMEF";
            this.grd_PMEF.RowTemplate.Height = 24;
            this.grd_PMEF.Size = new System.Drawing.Size(904, 217);
            this.grd_PMEF.TabIndex = 42;
            // 
            // date
            // 
            this.date.HeaderText = "Date Filed";
            this.date.Name = "date";
            // 
            // leaveType
            // 
            this.leaveType.HeaderText = "Leave Type";
            this.leaveType.Name = "leaveType";
            // 
            // shift
            // 
            this.shift.HeaderText = "Shift";
            this.shift.Name = "shift";
            // 
            // startDate
            // 
            this.startDate.HeaderText = "Start Date";
            this.startDate.Name = "startDate";
            // 
            // endDate
            // 
            this.endDate.HeaderText = "End Date";
            this.endDate.Name = "endDate";
            // 
            // details
            // 
            this.details.HeaderText = "Details";
            this.details.Name = "details";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // cbo_empList
            // 
            this.cbo_empList.FormattingEnabled = true;
            this.cbo_empList.Location = new System.Drawing.Point(151, 15);
            this.cbo_empList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_empList.Name = "cbo_empList";
            this.cbo_empList.Size = new System.Drawing.Size(161, 24);
            this.cbo_empList.TabIndex = 18;
            // 
            // lbl_currentDate
            // 
            this.lbl_currentDate.AutoSize = true;
            this.lbl_currentDate.Location = new System.Drawing.Point(148, 71);
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.lbl_currentDate.Size = new System.Drawing.Size(164, 17);
            this.lbl_currentDate.TabIndex = 17;
            this.lbl_currentDate.Text = "06/06/2018 02:44:42 PM";
            // 
            // lbl_empNo
            // 
            this.lbl_empNo.AutoSize = true;
            this.lbl_empNo.Location = new System.Drawing.Point(148, 43);
            this.lbl_empNo.Name = "lbl_empNo";
            this.lbl_empNo.Size = new System.Drawing.Size(101, 17);
            this.lbl_empNo.TabIndex = 16;
            this.lbl_empNo.Text = "EMP05102015";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_empList);
            this.groupBox1.Controls.Add(this.lbl_currentDate);
            this.groupBox1.Controls.Add(this.lbl_empNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 95);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // FIledLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 417);
            this.Controls.Add(this.btn_loadPMEF);
            this.Controls.Add(this.btn_approve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grd_PMEF);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(951, 464);
            this.MinimumSize = new System.Drawing.Size(951, 464);
            this.Name = "FIledLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_PMEF)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dte_to;
        private System.Windows.Forms.DateTimePicker dte_from;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_loadPMEF;
        private System.Windows.Forms.Button btn_approve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grd_PMEF;
        private System.Windows.Forms.ComboBox cbo_empList;
        private System.Windows.Forms.Label lbl_currentDate;
        private System.Windows.Forms.Label lbl_empNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn leaveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn details;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}