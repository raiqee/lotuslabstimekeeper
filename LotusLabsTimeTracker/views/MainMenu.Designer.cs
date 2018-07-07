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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Image = global::LotusLabsTimeTracker.Properties.Resources.PMEF;
            this.button2.Location = new System.Drawing.Point(205, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 115);
            this.button2.TabIndex = 2;
            this.button2.Text = "PMEF";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::LotusLabsTimeTracker.Properties.Resources.LeaveForm;
            this.button3.Location = new System.Drawing.Point(368, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 115);
            this.button3.TabIndex = 3;
            this.button3.Text = "Leave Form";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::LotusLabsTimeTracker.Properties.Resources.Maintenance;
            this.button4.Location = new System.Drawing.Point(536, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 115);
            this.button4.TabIndex = 4;
            this.button4.Text = "Maintenance";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::LotusLabsTimeTracker.Properties.Resources.ProductionModule;
            this.button1.Location = new System.Drawing.Point(42, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 115);
            this.button1.TabIndex = 1;
            this.button1.Text = "Production Module";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LotusLabsTimeTracker.Properties.Resources.Lotus_Labs__Transparent__04_17_2018;
            this.pictureBox1.Location = new System.Drawing.Point(149, 171);
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
            this.ClientSize = new System.Drawing.Size(709, 293);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}