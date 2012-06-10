namespace CoreView
{
    partial class DatabaseAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.database_add_comments = new System.Windows.Forms.TextBox();
            this.database_add_ok = new System.Windows.Forms.Button();
            this.database_add_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comments";
            // 
            // database_add_comments
            // 
            this.database_add_comments.Location = new System.Drawing.Point(13, 30);
            this.database_add_comments.Multiline = true;
            this.database_add_comments.Name = "database_add_comments";
            this.database_add_comments.Size = new System.Drawing.Size(296, 171);
            this.database_add_comments.TabIndex = 1;
            // 
            // database_add_ok
            // 
            this.database_add_ok.Location = new System.Drawing.Point(234, 207);
            this.database_add_ok.Name = "database_add_ok";
            this.database_add_ok.Size = new System.Drawing.Size(75, 23);
            this.database_add_ok.TabIndex = 2;
            this.database_add_ok.Text = "OK";
            this.database_add_ok.UseVisualStyleBackColor = true;
            this.database_add_ok.Click += new System.EventHandler(this.database_add_ok_Click);
            // 
            // database_add_cancel
            // 
            this.database_add_cancel.Location = new System.Drawing.Point(153, 207);
            this.database_add_cancel.Name = "database_add_cancel";
            this.database_add_cancel.Size = new System.Drawing.Size(75, 23);
            this.database_add_cancel.TabIndex = 3;
            this.database_add_cancel.Text = "Cancel";
            this.database_add_cancel.UseVisualStyleBackColor = true;
            this.database_add_cancel.Click += new System.EventHandler(this.database_add_cancel_Click);
            // 
            // DatabaseAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.database_add_cancel);
            this.Controls.Add(this.database_add_ok);
            this.Controls.Add(this.database_add_comments);
            this.Controls.Add(this.label1);
            this.Icon = global::CoreView.Properties.Resources.Logo;
            this.Name = "DatabaseAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add To Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox database_add_comments;
        private System.Windows.Forms.Button database_add_ok;
        private System.Windows.Forms.Button database_add_cancel;
    }
}