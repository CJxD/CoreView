namespace CoreView
{
    partial class AboutDialogue
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
            this.cv_logo_box = new System.Windows.Forms.PictureBox();
            this.version_label = new System.Windows.Forms.Label();
            this.built_for_label = new System.Windows.Forms.Label();
            this.copyright_label = new System.Windows.Forms.Label();
            this.project_home_link = new System.Windows.Forms.LinkLabel();
            this.licensing_link = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.cv_logo_box)).BeginInit();
            this.SuspendLayout();
            // 
            // cv_logo_box
            // 
            this.cv_logo_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cv_logo_box.Image = global::CoreView.Properties.Resources.Text_Logo;
            this.cv_logo_box.Location = new System.Drawing.Point(3, 2);
            this.cv_logo_box.Name = "cv_logo_box";
            this.cv_logo_box.Size = new System.Drawing.Size(261, 78);
            this.cv_logo_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.cv_logo_box.TabIndex = 0;
            this.cv_logo_box.TabStop = false;
            // 
            // version_label
            // 
            this.version_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(92, 83);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(81, 13);
            this.version_label.TabIndex = 1;
            this.version_label.Text = "Version: 0.0.0.0";
            this.version_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // built_for_label
            // 
            this.built_for_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.built_for_label.AutoSize = true;
            this.built_for_label.Location = new System.Drawing.Point(45, 105);
            this.built_for_label.Name = "built_for_label";
            this.built_for_label.Size = new System.Drawing.Size(182, 13);
            this.built_for_label.TabIndex = 2;
            this.built_for_label.Text = "Built for HCS Computers and Laptops";
            this.built_for_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // copyright_label
            // 
            this.copyright_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.copyright_label.AutoSize = true;
            this.copyright_label.Location = new System.Drawing.Point(60, 128);
            this.copyright_label.Name = "copyright_label";
            this.copyright_label.Size = new System.Drawing.Size(150, 13);
            this.copyright_label.TabIndex = 3;
            this.copyright_label.Text = "Copyright ©  Chris Watts 2012";
            this.copyright_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // project_home_link
            // 
            this.project_home_link.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.project_home_link.AutoSize = true;
            this.project_home_link.LinkColor = System.Drawing.Color.ForestGreen;
            this.project_home_link.Location = new System.Drawing.Point(68, 150);
            this.project_home_link.Name = "project_home_link";
            this.project_home_link.Size = new System.Drawing.Size(136, 13);
            this.project_home_link.TabIndex = 4;
            this.project_home_link.TabStop = true;
            this.project_home_link.Text = "Project Home (external link)";
            this.project_home_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.project_home_link.VisitedLinkColor = System.Drawing.Color.DarkGreen;
            this.project_home_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.project_home_link_LinkClicked);
            // 
            // licensing_link
            // 
            this.licensing_link.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.licensing_link.AutoSize = true;
            this.licensing_link.LinkColor = System.Drawing.Color.ForestGreen;
            this.licensing_link.Location = new System.Drawing.Point(78, 172);
            this.licensing_link.Name = "licensing_link";
            this.licensing_link.Size = new System.Drawing.Size(114, 13);
            this.licensing_link.TabIndex = 5;
            this.licensing_link.TabStop = true;
            this.licensing_link.Text = "Licensing (internal link)";
            this.licensing_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.licensing_link.VisitedLinkColor = System.Drawing.Color.DarkGreen;
            this.licensing_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.licensing_link_LinkClicked);
            // 
            // AboutDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 197);
            this.Controls.Add(this.licensing_link);
            this.Controls.Add(this.project_home_link);
            this.Controls.Add(this.copyright_label);
            this.Controls.Add(this.built_for_label);
            this.Controls.Add(this.version_label);
            this.Controls.Add(this.cv_logo_box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::CoreView.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutDialogue";
            this.Text = "About Core View";
            ((System.ComponentModel.ISupportInitialize)(this.cv_logo_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cv_logo_box;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label built_for_label;
        private System.Windows.Forms.Label copyright_label;
        private System.Windows.Forms.LinkLabel project_home_link;
        private System.Windows.Forms.LinkLabel licensing_link;

    }
}