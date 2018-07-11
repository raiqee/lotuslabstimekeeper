namespace LotusLabsTimeTracker.views
{
    partial class LeaveForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_empName = new System.Windows.Forms.Label();
            this.lbl_currentDate = new System.Windows.Forms.Label();
            this.lbl_empNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_tastType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_details = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dte_endTime = new System.Windows.Forms.DateTimePicker();
            this.dte_startTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_submitApproval = new System.Windows.Forms.Button();
            this.lnk_viewPMEF = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_empName);
            this.groupBox1.Controls.Add(this.lbl_currentDate);
            this.groupBox1.Controls.Add(this.lbl_empNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(282, 77);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // lbl_empName
            // 
            this.lbl_empName.AutoSize = true;
            this.lbl_empName.Location = new System.Drawing.Point(111, 12);
            this.lbl_empName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_empName.Name = "lbl_empName";
            this.lbl_empName.Size = new System.Drawing.Size(53, 13);
            this.lbl_empName.TabIndex = 18;
            this.lbl_empName.Text = "Jane Doe";
            // 
            // lbl_currentDate
            // 
            this.lbl_currentDate.AutoSize = true;
            this.lbl_currentDate.Location = new System.Drawing.Point(111, 58);
            this.lbl_currentDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.lbl_currentDate.Size = new System.Drawing.Size(129, 13);
            this.lbl_currentDate.TabIndex = 17;
            this.lbl_currentDate.Text = "06/06/2018 02:44:42 PM";
            // 
            // lbl_empNo
            // 
            this.lbl_empNo.AutoSize = true;
            this.lbl_empNo.Location = new System.Drawing.Point(111, 35);
            this.lbl_empNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_empNo.Name = "lbl_empNo";
            this.lbl_empNo.Size = new System.Drawing.Size(78, 13);
            this.lbl_empNo.TabIndex = 16;
            this.lbl_empNo.Text = "EMP05102015";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Employee ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employee Name:";
            // 
            // cbo_tastType
            // 
            this.cbo_tastType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tastType.FormattingEnabled = true;
            this.cbo_tastType.Location = new System.Drawing.Point(122, 45);
            this.cbo_tastType.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_tastType.Name = "cbo_tastType";
            this.cbo_tastType.Size = new System.Drawing.Size(156, 24);
            this.cbo_tastType.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "Leave Type :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbo_tastType);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 260);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Leave Details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(197, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 45;
            this.label15.Text = "8";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_details);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 129);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(704, 100);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Details";
            // 
            // txt_details
            // 
            this.txt_details.Location = new System.Drawing.Point(5, 20);
            this.txt_details.Margin = new System.Windows.Forms.Padding(2);
            this.txt_details.Multiline = true;
            this.txt_details.Name = "txt_details";
            this.txt_details.Size = new System.Drawing.Size(694, 75);
            this.txt_details.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Total No. of Leave/s : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Shift : ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 85);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 36;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dte_endTime);
            this.groupBox3.Controls.Add(this.dte_startTime);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(394, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(332, 107);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duration :";
            // 
            // dte_endTime
            // 
            this.dte_endTime.CustomFormat = "mm/dd/yyyy";
            this.dte_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_endTime.Location = new System.Drawing.Point(155, 62);
            this.dte_endTime.Margin = new System.Windows.Forms.Padding(2);
            this.dte_endTime.Name = "dte_endTime";
            this.dte_endTime.Size = new System.Drawing.Size(105, 22);
            this.dte_endTime.TabIndex = 40;
            // 
            // dte_startTime
            // 
            this.dte_startTime.CustomFormat = "mm/dd/yyyy";
            this.dte_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dte_startTime.Location = new System.Drawing.Point(155, 24);
            this.dte_startTime.Margin = new System.Windows.Forms.Padding(2);
            this.dte_startTime.Name = "dte_startTime";
            this.dte_startTime.Size = new System.Drawing.Size(105, 22);
            this.dte_startTime.TabIndex = 39;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 25);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "From :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 65);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 38;
            this.label11.Text = "To :";
            // 
            // btn_submitApproval
            // 
            this.btn_submitApproval.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_submitApproval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submitApproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitApproval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submitApproval.Location = new System.Drawing.Point(296, 395);
            this.btn_submitApproval.Margin = new System.Windows.Forms.Padding(2);
            this.btn_submitApproval.Name = "btn_submitApproval";
            this.btn_submitApproval.Size = new System.Drawing.Size(186, 34);
            this.btn_submitApproval.TabIndex = 36;
            this.btn_submitApproval.Text = "Submit for Approval";
            this.btn_submitApproval.UseVisualStyleBackColor = false;
            // 
            // lnk_viewPMEF
            // 
            this.lnk_viewPMEF.AutoSize = true;
            this.lnk_viewPMEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_viewPMEF.Location = new System.Drawing.Point(663, 381);
            this.lnk_viewPMEF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnk_viewPMEF.Name = "lnk_viewPMEF";
            this.lnk_viewPMEF.Size = new System.Drawing.Size(125, 17);
            this.lnk_viewPMEF.TabIndex = 37;
            this.lnk_viewPMEF.TabStop = true;
            this.lnk_viewPMEF.Text = "View Filed Leave/s";
            this.lnk_viewPMEF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_viewPMEF_LinkClicked);
            // 
            // LeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lnk_viewPMEF);
            this.Controls.Add(this.btn_submitApproval);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LeaveForm";
            this.Text = "Leave Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_empName;
        private System.Windows.Forms.Label lbl_currentDate;
        private System.Windows.Forms.Label lbl_empNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_tastType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dte_endTime;
        private System.Windows.Forms.DateTimePicker dte_startTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_details;
        private System.Windows.Forms.Button btn_submitApproval;
        private System.Windows.Forms.LinkLabel lnk_viewPMEF;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
    }
}