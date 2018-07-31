namespace LotusLabsTimeTracker.views
{
    partial class TaskManager
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
            this.btn_workType = new System.Windows.Forms.Button();
            this.btn_projectType = new System.Windows.Forms.Button();
            this.btn_taskType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_workType
            // 
            this.btn_workType.Image = global::LotusLabsTimeTracker.Properties.Resources.Work_Type;
            this.btn_workType.Location = new System.Drawing.Point(48, 27);
            this.btn_workType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_workType.Name = "btn_workType";
            this.btn_workType.Size = new System.Drawing.Size(133, 142);
            this.btn_workType.TabIndex = 7;
            this.btn_workType.Text = "Work Type";
            this.btn_workType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_workType.UseVisualStyleBackColor = true;
            this.btn_workType.Click += new System.EventHandler(this.btn_workType_Click);
            // 
            // btn_projectType
            // 
            this.btn_projectType.Image = global::LotusLabsTimeTracker.Properties.Resources.Project_Type;
            this.btn_projectType.Location = new System.Drawing.Point(203, 27);
            this.btn_projectType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_projectType.Name = "btn_projectType";
            this.btn_projectType.Size = new System.Drawing.Size(137, 142);
            this.btn_projectType.TabIndex = 6;
            this.btn_projectType.Text = "Project Type";
            this.btn_projectType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_projectType.UseVisualStyleBackColor = true;
            this.btn_projectType.Click += new System.EventHandler(this.btn_projectType_Click);
            // 
            // btn_taskType
            // 
            this.btn_taskType.Image = global::LotusLabsTimeTracker.Properties.Resources.Task_Type;
            this.btn_taskType.Location = new System.Drawing.Point(360, 27);
            this.btn_taskType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_taskType.Name = "btn_taskType";
            this.btn_taskType.Size = new System.Drawing.Size(137, 142);
            this.btn_taskType.TabIndex = 5;
            this.btn_taskType.Text = "Task Type";
            this.btn_taskType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_taskType.UseVisualStyleBackColor = true;
            this.btn_taskType.Click += new System.EventHandler(this.btn_taskType_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 182);
            this.Controls.Add(this.btn_workType);
            this.Controls.Add(this.btn_projectType);
            this.Controls.Add(this.btn_taskType);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(558, 229);
            this.MinimumSize = new System.Drawing.Size(558, 229);
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TaskManager_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_projectType;
        private System.Windows.Forms.Button btn_taskType;
        private System.Windows.Forms.Button btn_workType;
    }
}