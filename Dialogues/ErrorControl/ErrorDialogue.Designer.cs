namespace CoreView
{
    partial class ErrorDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorDialogue));
            this.error_details = new System.Windows.Forms.TextBox();
            this.error_close = new System.Windows.Forms.Button();
            this.error_icon = new System.Windows.Forms.PictureBox();
            this.error_label = new System.Windows.Forms.Label();
            this.error_advice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // error_details
            // 
            this.error_details.BackColor = System.Drawing.SystemColors.Control;
            this.error_details.Location = new System.Drawing.Point(6, 76);
            this.error_details.Multiline = true;
            this.error_details.Name = "error_details";
            this.error_details.ReadOnly = true;
            this.error_details.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.error_details.Size = new System.Drawing.Size(336, 127);
            this.error_details.TabIndex = 0;
            // 
            // error_close
            // 
            this.error_close.Location = new System.Drawing.Point(348, 176);
            this.error_close.Name = "error_close";
            this.error_close.Size = new System.Drawing.Size(94, 27);
            this.error_close.TabIndex = 1;
            this.error_close.Text = "Close";
            this.error_close.UseVisualStyleBackColor = true;
            this.error_close.Click += new System.EventHandler(this.error_close_Click);
            // 
            // error_icon
            // 
            this.error_icon.Image = ((System.Drawing.Image)(resources.GetObject("error_icon.Image")));
            this.error_icon.Location = new System.Drawing.Point(12, 9);
            this.error_icon.Name = "error_icon";
            this.error_icon.Size = new System.Drawing.Size(48, 48);
            this.error_icon.TabIndex = 2;
            this.error_icon.TabStop = false;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_label.Location = new System.Drawing.Point(60, 10);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(187, 13);
            this.error_label.TabIndex = 3;
            this.error_label.Text = "Core View encountered an error";
            // 
            // error_advice
            // 
            this.error_advice.AutoSize = true;
            this.error_advice.Location = new System.Drawing.Point(68, 26);
            this.error_advice.Name = "error_advice";
            this.error_advice.Size = new System.Drawing.Size(227, 13);
            this.error_advice.TabIndex = 5;
            this.error_advice.Text = "The program may become unstable as a result.";
            // 
            // ErrorDialogue
            // 
            this.AcceptButton = this.error_close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 215);
            this.Controls.Add(this.error_advice);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.error_icon);
            this.Controls.Add(this.error_close);
            this.Controls.Add(this.error_details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = global::CoreView.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorDialogue";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unhandled Error";
            ((System.ComponentModel.ISupportInitialize)(this.error_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox error_details;
        private System.Windows.Forms.Button error_close;
        private System.Windows.Forms.PictureBox error_icon;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Label error_advice;
    }
}