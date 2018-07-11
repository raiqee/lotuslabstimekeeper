namespace LotusLabsTimeTracker.views
{
    partial class EditUser
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
            this.btn_saveEditUser = new System.Windows.Forms.Button();
            this.txt_empEmail = new System.Windows.Forms.TextBox();
            this.txt_empLname = new System.Windows.Forms.TextBox();
            this.txt_empMname = new System.Windows.Forms.TextBox();
            this.txt_empFname = new System.Windows.Forms.TextBox();
            this.txt_empNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_userType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_empStatus = new System.Windows.Forms.ComboBox();
            this.lnk_resetPassword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_saveEditUser
            // 
            this.btn_saveEditUser.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_saveEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveEditUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_saveEditUser.Location = new System.Drawing.Point(119, 312);
            this.btn_saveEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_saveEditUser.Name = "btn_saveEditUser";
            this.btn_saveEditUser.Size = new System.Drawing.Size(186, 34);
            this.btn_saveEditUser.TabIndex = 25;
            this.btn_saveEditUser.Text = "Save";
            this.btn_saveEditUser.UseVisualStyleBackColor = false;
            this.btn_saveEditUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_empEmail
            // 
            this.txt_empEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empEmail.Location = new System.Drawing.Point(212, 215);
            this.txt_empEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txt_empEmail.Name = "txt_empEmail";
            this.txt_empEmail.Size = new System.Drawing.Size(187, 26);
            this.txt_empEmail.TabIndex = 24;
            this.txt_empEmail.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txt_empLname
            // 
            this.txt_empLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empLname.Location = new System.Drawing.Point(212, 182);
            this.txt_empLname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_empLname.Name = "txt_empLname";
            this.txt_empLname.Size = new System.Drawing.Size(187, 26);
            this.txt_empLname.TabIndex = 23;
            this.txt_empLname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_empMname
            // 
            this.txt_empMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empMname.Location = new System.Drawing.Point(212, 149);
            this.txt_empMname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_empMname.Name = "txt_empMname";
            this.txt_empMname.Size = new System.Drawing.Size(187, 26);
            this.txt_empMname.TabIndex = 22;
            this.txt_empMname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_empFname
            // 
            this.txt_empFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empFname.Location = new System.Drawing.Point(212, 115);
            this.txt_empFname.Margin = new System.Windows.Forms.Padding(2);
            this.txt_empFname.Name = "txt_empFname";
            this.txt_empFname.Size = new System.Drawing.Size(187, 26);
            this.txt_empFname.TabIndex = 21;
            this.txt_empFname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_empNo
            // 
            this.txt_empNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empNo.Location = new System.Drawing.Point(212, 84);
            this.txt_empNo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_empNo.Name = "txt_empNo";
            this.txt_empNo.ReadOnly = true;
            this.txt_empNo.Size = new System.Drawing.Size(187, 26);
            this.txt_empNo.TabIndex = 20;
            this.txt_empNo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Email:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Middle Name:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "First Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employee ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbo_userType
            // 
            this.cbo_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_userType.FormattingEnabled = true;
            this.cbo_userType.Location = new System.Drawing.Point(212, 46);
            this.cbo_userType.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_userType.Name = "cbo_userType";
            this.cbo_userType.Size = new System.Drawing.Size(187, 28);
            this.cbo_userType.TabIndex = 13;
            this.cbo_userType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Employee Status:";
            // 
            // cbo_empStatus
            // 
            this.cbo_empStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_empStatus.FormattingEnabled = true;
            this.cbo_empStatus.Location = new System.Drawing.Point(212, 249);
            this.cbo_empStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbo_empStatus.Name = "cbo_empStatus";
            this.cbo_empStatus.Size = new System.Drawing.Size(187, 28);
            this.cbo_empStatus.TabIndex = 27;
            // 
            // lnk_resetPassword
            // 
            this.lnk_resetPassword.AutoSize = true;
            this.lnk_resetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnk_resetPassword.Location = new System.Drawing.Point(283, 358);
            this.lnk_resetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnk_resetPassword.Name = "lnk_resetPassword";
            this.lnk_resetPassword.Size = new System.Drawing.Size(139, 20);
            this.lnk_resetPassword.TabIndex = 28;
            this.lnk_resetPassword.TabStop = true;
            this.lnk_resetPassword.Text = "Reset Password";
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 387);
            this.Controls.Add(this.lnk_resetPassword);
            this.Controls.Add(this.cbo_empStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_saveEditUser);
            this.Controls.Add(this.txt_empEmail);
            this.Controls.Add(this.txt_empLname);
            this.Controls.Add(this.txt_empMname);
            this.Controls.Add(this.txt_empFname);
            this.Controls.Add(this.txt_empNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_userType);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditUser";
            this.Text = "Edit User Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_saveEditUser;
        private System.Windows.Forms.TextBox txt_empEmail;
        private System.Windows.Forms.TextBox txt_empLname;
        private System.Windows.Forms.TextBox txt_empMname;
        private System.Windows.Forms.TextBox txt_empFname;
        private System.Windows.Forms.TextBox txt_empNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_userType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_empStatus;
        private System.Windows.Forms.LinkLabel lnk_resetPassword;
    }
}