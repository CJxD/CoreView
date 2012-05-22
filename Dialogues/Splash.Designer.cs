namespace CoreView
{
    partial class Splash
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
            this.components = new System.ComponentModel.Container();
            this.splash_progress = new System.Windows.Forms.ProgressBar();
            this.splash_poller = new System.Windows.Forms.Timer(this.components);
            this.splash_status = new System.Windows.Forms.Label();
            this.skip_label = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // splash_progress
            // 
            this.splash_progress.BackColor = System.Drawing.Color.PaleGreen;
            this.splash_progress.ForeColor = System.Drawing.Color.Lime;
            this.splash_progress.Location = new System.Drawing.Point(49, 115);
            this.splash_progress.Name = "splash_progress";
            this.splash_progress.Size = new System.Drawing.Size(228, 34);
            this.splash_progress.TabIndex = 1;
            // 
            // splash_poller
            // 
            this.splash_poller.Enabled = true;
            this.splash_poller.Interval = 1000;
            this.splash_poller.Tick += new System.EventHandler(this.splash_poller_Tick);
            // 
            // splash_status
            // 
            this.splash_status.AutoSize = true;
            this.splash_status.BackColor = System.Drawing.Color.Transparent;
            this.splash_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splash_status.ForeColor = System.Drawing.Color.Black;
            this.splash_status.Location = new System.Drawing.Point(62, 152);
            this.splash_status.Name = "splash_status";
            this.splash_status.Size = new System.Drawing.Size(74, 17);
            this.splash_status.TabIndex = 2;
            this.splash_status.Text = "Initialising...";
            // 
            // skip_label
            // 
            this.skip_label.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.skip_label.AutoSize = true;
            this.skip_label.BackColor = System.Drawing.Color.Transparent;
            this.skip_label.LinkColor = System.Drawing.Color.PaleGreen;
            this.skip_label.Location = new System.Drawing.Point(291, 5);
            this.skip_label.Name = "skip_label";
            this.skip_label.Size = new System.Drawing.Size(28, 13);
            this.skip_label.TabIndex = 3;
            this.skip_label.TabStop = true;
            this.skip_label.Text = "Skip";
            this.skip_label.VisitedLinkColor = System.Drawing.Color.PaleGreen;
            this.skip_label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.skip_label_LinkClicked);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CoreView.Properties.Resources.Splash;
            this.ClientSize = new System.Drawing.Size(325, 180);
            this.Controls.Add(this.skip_label);
            this.Controls.Add(this.splash_status);
            this.Controls.Add(this.splash_progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::CoreView.Properties.Resources.Logo;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading Core View";
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Splash_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar splash_progress;
        private System.Windows.Forms.Timer splash_poller;
        private System.Windows.Forms.Label splash_status;
        private System.Windows.Forms.LinkLabel skip_label;
    }
}