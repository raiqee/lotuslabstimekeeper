namespace LotusLabsTimeTracker.views
{
    partial class MainMenu
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
            this.btn_logOut = new System.Windows.Forms.Button();
            this.btn_maintenance = new System.Windows.Forms.Button();
            this.btn_leaveForm = new System.Windows.Forms.Button();
            this.btn_pmef = new System.Windows.Forms.Button();
            this.btn_prodModule = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logOut
            // 
            this.btn_logOut.Image = global::LotusLabsTimeTracker.Properties.Resources.LogOut;
            this.btn_logOut.Location = new System.Drawing.Point(699, 33);
            this.btn_logOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(128, 114);
            this.btn_logOut.TabIndex = 5;
            this.btn_logOut.Text = "Log Out";
            this.btn_logOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_logOut.UseVisualStyleBackColor = true;
            this.btn_logOut.Click += new System.EventHandler(this.btn_logOut_Click);
            // 
            // btn_maintenance
            // 
            this.btn_maintenance.Image = global::LotusLabsTimeTracker.Properties.Resources.Maintenance;
            this.btn_maintenance.Location = new System.Drawing.Point(536, 33);
            this.btn_maintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_maintenance.Name = "btn_maintenance";
            this.btn_maintenance.Size = new System.Drawing.Size(128, 114);
            this.btn_maintenance.TabIndex = 4;
            this.btn_maintenance.Text = "Maintenance";
            this.btn_maintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_maintenance.UseVisualStyleBackColor = true;
            this.btn_maintenance.Click += new System.EventHandler(this.btn_maintenance_Click);
            // 
            // btn_leaveForm
            // 
            this.btn_leaveForm.Image = global::LotusLabsTimeTracker.Properties.Resources.LeaveForm;
            this.btn_leaveForm.Location = new System.Drawing.Point(368, 33);
            this.btn_leaveForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_leaveForm.Name = "btn_leaveForm";
            this.btn_leaveForm.Size = new System.Drawing.Size(128, 114);
            this.btn_leaveForm.TabIndex = 3;
            this.btn_leaveForm.Text = "Leave Form";
            this.btn_leaveForm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_leaveForm.UseVisualStyleBackColor = true;
            this.btn_leaveForm.Click += new System.EventHandler(this.btn_leaveForm_Click);
            // 
            // btn_pmef
            // 
            this.btn_pmef.Image = global::LotusLabsTimeTracker.Properties.Resources.PMEF;
            this.btn_pmef.Location = new System.Drawing.Point(205, 33);
            this.btn_pmef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pmef.Name = "btn_pmef";
            this.btn_pmef.Size = new System.Drawing.Size(128, 114);
            this.btn_pmef.TabIndex = 2;
            this.btn_pmef.Text = "PMEF";
            this.btn_pmef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_pmef.UseVisualStyleBackColor = true;
            this.btn_pmef.Click += new System.EventHandler(this.btn_pmef_Click);
            // 
            // btn_prodModule
            // 
            this.btn_prodModule.Image = global::LotusLabsTimeTracker.Properties.Resources.ProductionModule;
            this.btn_prodModule.Location = new System.Drawing.Point(43, 33);
            this.btn_prodModule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_prodModule.Name = "btn_prodModule";
            this.btn_prodModule.Size = new System.Drawing.Size(128, 114);
            this.btn_prodModule.TabIndex = 1;
            this.btn_prodModule.Text = "Production Module";
            this.btn_prodModule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_prodModule.UseVisualStyleBackColor = true;
            this.btn_prodModule.Click += new System.EventHandler(this.btn_prodModule_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LotusLabsTimeTracker.Properties.Resources.Lotus_Labs__Transparent__04_17_2018;
            this.pictureBox1.Location = new System.Drawing.Point(221, 180);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 293);
            this.ControlBox = false;
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_maintenance);
            this.Controls.Add(this.btn_leaveForm);
            this.Controls.Add(this.btn_pmef);
            this.Controls.Add(this.btn_prodModule);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(883, 344);
            this.MinimumSize = new System.Drawing.Size(883, 344);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_prodModule;
        private System.Windows.Forms.Button btn_pmef;
        private System.Windows.Forms.Button btn_leaveForm;
        private System.Windows.Forms.Button btn_maintenance;
        private System.Windows.Forms.Button btn_logOut;
    }
}