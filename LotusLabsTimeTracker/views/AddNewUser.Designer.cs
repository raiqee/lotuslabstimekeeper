﻿namespace LotusLabsTimeTracker.views
{
    partial class addEditUser
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
            this.cbo_userType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_empNo = new System.Windows.Forms.TextBox();
            this.txt_empFname = new System.Windows.Forms.TextBox();
            this.txt_empMname = new System.Windows.Forms.TextBox();
            this.txt_empLname = new System.Windows.Forms.TextBox();
            this.txt_empEmail = new System.Windows.Forms.TextBox();
            this.btn_saveNewEmp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_userType
            // 
            this.cbo_userType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_userType.FormattingEnabled = true;
            this.cbo_userType.Location = new System.Drawing.Point(252, 57);
            this.cbo_userType.Name = "cbo_userType";
            this.cbo_userType.Size = new System.Drawing.Size(248, 33);
            this.cbo_userType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email:";
            // 
            // txt_empNo
            // 
            this.txt_empNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empNo.Location = new System.Drawing.Point(252, 100);
            this.txt_empNo.Name = "txt_empNo";
            this.txt_empNo.Size = new System.Drawing.Size(248, 30);
            this.txt_empNo.TabIndex = 7;
            // 
            // txt_empFname
            // 
            this.txt_empFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empFname.Location = new System.Drawing.Point(252, 141);
            this.txt_empFname.Name = "txt_empFname";
            this.txt_empFname.Size = new System.Drawing.Size(248, 30);
            this.txt_empFname.TabIndex = 8;
            this.txt_empFname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_empMname
            // 
            this.txt_empMname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empMname.Location = new System.Drawing.Point(252, 183);
            this.txt_empMname.Name = "txt_empMname";
            this.txt_empMname.Size = new System.Drawing.Size(248, 30);
            this.txt_empMname.TabIndex = 9;
            // 
            // txt_empLname
            // 
            this.txt_empLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empLname.Location = new System.Drawing.Point(252, 224);
            this.txt_empLname.Name = "txt_empLname";
            this.txt_empLname.Size = new System.Drawing.Size(248, 30);
            this.txt_empLname.TabIndex = 10;
            // 
            // txt_empEmail
            // 
            this.txt_empEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empEmail.Location = new System.Drawing.Point(252, 266);
            this.txt_empEmail.Name = "txt_empEmail";
            this.txt_empEmail.Size = new System.Drawing.Size(248, 30);
            this.txt_empEmail.TabIndex = 11;
            // 
            // btn_saveNewEmp
            // 
            this.btn_saveNewEmp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_saveNewEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveNewEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveNewEmp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_saveNewEmp.Location = new System.Drawing.Point(151, 340);
            this.btn_saveNewEmp.Name = "btn_saveNewEmp";
            this.btn_saveNewEmp.Size = new System.Drawing.Size(248, 42);
            this.btn_saveNewEmp.TabIndex = 12;
            this.btn_saveNewEmp.Text = "Save";
            this.btn_saveNewEmp.UseVisualStyleBackColor = false;
            // 
            // addEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 431);
            this.Controls.Add(this.btn_saveNewEmp);
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
            this.Name = "addEditUser";
            this.Text = "Employee Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_userType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_empNo;
        private System.Windows.Forms.TextBox txt_empFname;
        private System.Windows.Forms.TextBox txt_empMname;
        private System.Windows.Forms.TextBox txt_empLname;
        private System.Windows.Forms.TextBox txt_empEmail;
        private System.Windows.Forms.Button btn_saveNewEmp;
    }
}