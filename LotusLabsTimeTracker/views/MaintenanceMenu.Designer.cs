namespace LotusLabsTimeTracker.views
{
    partial class MaintenanceMenu
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
            this.btn_taskMgr = new System.Windows.Forms.Button();
            this.btn_prodMgr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_taskMgr
            // 
            this.btn_taskMgr.Image = global::LotusLabsTimeTracker.Properties.Resources.TaskManager2;
            this.btn_taskMgr.Location = new System.Drawing.Point(160, 24);
            this.btn_taskMgr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_taskMgr.Name = "btn_taskMgr";
            this.btn_taskMgr.Size = new System.Drawing.Size(96, 93);
            this.btn_taskMgr.TabIndex = 4;
            this.btn_taskMgr.Text = "Task Manager";
            this.btn_taskMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_taskMgr.UseVisualStyleBackColor = true;
            this.btn_taskMgr.Click += new System.EventHandler(this.btn_taskMgr_Click);
            // 
            // btn_prodMgr
            // 
            this.btn_prodMgr.Image = global::LotusLabsTimeTracker.Properties.Resources.ProjectManager1;
            this.btn_prodMgr.Location = new System.Drawing.Point(38, 24);
            this.btn_prodMgr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_prodMgr.Name = "btn_prodMgr";
            this.btn_prodMgr.Size = new System.Drawing.Size(96, 93);
            this.btn_prodMgr.TabIndex = 3;
            this.btn_prodMgr.Text = "Profile Manager";
            this.btn_prodMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_prodMgr.UseVisualStyleBackColor = true;
            this.btn_prodMgr.Click += new System.EventHandler(this.btn_prodMgr_Click);
            // 
            // MaintenanceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 152);
            this.Controls.Add(this.btn_taskMgr);
            this.Controls.Add(this.btn_prodMgr);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MaintenanceMenu";
            this.Text = "Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_taskMgr;
        private System.Windows.Forms.Button btn_prodMgr;
    }
}