namespace School_Election_System
{
    partial class LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingPage));
            this.landing_split = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.landing_split)).BeginInit();
            this.landing_split.SuspendLayout();
            this.SuspendLayout();
            // 
            // landing_split
            // 
            this.landing_split.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.landing_split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.landing_split.Location = new System.Drawing.Point(0, 0);
            this.landing_split.Name = "landing_split";
            // 
            // landing_split.Panel1
            // 
            this.landing_split.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("landing_split.Panel1.BackgroundImage")));
            this.landing_split.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // landing_split.Panel2
            // 
            this.landing_split.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(79)))), ((int)(((byte)(134)))));
            this.landing_split.Panel2.Margin = new System.Windows.Forms.Padding(20);
            this.landing_split.Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.landing_split.Size = new System.Drawing.Size(1167, 741);
            this.landing_split.SplitterDistance = 596;
            this.landing_split.SplitterWidth = 1;
            this.landing_split.TabIndex = 0;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1167, 741);
            this.Controls.Add(this.landing_split);
            this.Name = "LandingPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.landing_split)).EndInit();
            this.landing_split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer landing_split;
    }
}

