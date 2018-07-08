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
            this.btn_taskMgr.Location = new System.Drawing.Point(213, 30);
            this.btn_taskMgr.Name = "btn_taskMgr";
            this.btn_taskMgr.Size = new System.Drawing.Size(128, 115);
            this.btn_taskMgr.TabIndex = 4;
            this.btn_taskMgr.Text = "Task Manager";
            this.btn_taskMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_taskMgr.UseVisualStyleBackColor = true;
            // 
            // btn_prodMgr
            // 
            this.btn_prodMgr.Image = global::LotusLabsTimeTracker.Properties.Resources.ProjectManager1;
            this.btn_prodMgr.Location = new System.Drawing.Point(50, 30);
            this.btn_prodMgr.Name = "btn_prodMgr";
            this.btn_prodMgr.Size = new System.Drawing.Size(128, 115);
            this.btn_prodMgr.TabIndex = 3;
            this.btn_prodMgr.Text = "Project Manager";
            this.btn_prodMgr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_prodMgr.UseVisualStyleBackColor = true;
            this.btn_prodMgr.Click += new System.EventHandler(this.btn_prodModule_Click);
            // 
            // MaintenanceMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 187);
            this.Controls.Add(this.btn_taskMgr);
            this.Controls.Add(this.btn_prodMgr);
            this.Name = "MaintenanceMenu";
            this.Text = "Maintenance";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_taskMgr;
        private System.Windows.Forms.Button btn_prodMgr;
    }
}