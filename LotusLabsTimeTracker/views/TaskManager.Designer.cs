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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pmef = new System.Windows.Forms.Button();
            this.btn_prodModule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = global::LotusLabsTimeTracker.Properties.Resources.Work_Type;
            this.button1.Location = new System.Drawing.Point(366, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 115);
            this.button1.TabIndex = 7;
            this.button1.Text = "Work Type";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_pmef
            // 
            this.btn_pmef.Image = global::LotusLabsTimeTracker.Properties.Resources.Project_Type;
            this.btn_pmef.Location = new System.Drawing.Point(203, 27);
            this.btn_pmef.Name = "btn_pmef";
            this.btn_pmef.Size = new System.Drawing.Size(128, 115);
            this.btn_pmef.TabIndex = 6;
            this.btn_pmef.Text = "Project Type";
            this.btn_pmef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pmef.UseVisualStyleBackColor = true;
            // 
            // btn_prodModule
            // 
            this.btn_prodModule.Image = global::LotusLabsTimeTracker.Properties.Resources.Task_Type;
            this.btn_prodModule.Location = new System.Drawing.Point(36, 27);
            this.btn_prodModule.Name = "btn_prodModule";
            this.btn_prodModule.Size = new System.Drawing.Size(128, 115);
            this.btn_prodModule.TabIndex = 5;
            this.btn_prodModule.Text = "Task Type";
            this.btn_prodModule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_prodModule.UseVisualStyleBackColor = true;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 166);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pmef);
            this.Controls.Add(this.btn_prodModule);
            this.Name = "TaskManager";
            this.Text = "Task Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_pmef;
        private System.Windows.Forms.Button btn_prodModule;
        private System.Windows.Forms.Button button1;
    }
}