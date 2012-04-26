namespace CoreView
{
    partial class OptionsDialogue
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
            this.options_general_group = new System.Windows.Forms.GroupBox();
            this.options_showsplash = new System.Windows.Forms.CheckBox();
            this.options_loadontabs = new System.Windows.Forms.RadioButton();
            this.options_loadhwonstart = new System.Windows.Forms.RadioButton();
            this.options_loadonstart = new System.Windows.Forms.RadioButton();
            this.options_weights_group = new System.Windows.Forms.GroupBox();
            this.options_filterby = new System.Windows.Forms.ComboBox();
            this.options_filter_lbl = new System.Windows.Forms.Label();
            this.options_weightings = new System.Windows.Forms.DataGridView();
            this.ch_attribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ch_weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options_apply = new System.Windows.Forms.Button();
            this.options_cancel = new System.Windows.Forms.Button();
            this.options_database_group = new System.Windows.Forms.GroupBox();
            this.options_general_group.SuspendLayout();
            this.options_weights_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.options_weightings)).BeginInit();
            this.SuspendLayout();
            // 
            // options_general_group
            // 
            this.options_general_group.Controls.Add(this.options_showsplash);
            this.options_general_group.Controls.Add(this.options_loadontabs);
            this.options_general_group.Controls.Add(this.options_loadhwonstart);
            this.options_general_group.Controls.Add(this.options_loadonstart);
            this.options_general_group.Location = new System.Drawing.Point(12, 12);
            this.options_general_group.Name = "options_general_group";
            this.options_general_group.Size = new System.Drawing.Size(332, 91);
            this.options_general_group.TabIndex = 0;
            this.options_general_group.TabStop = false;
            this.options_general_group.Text = "General Settings";
            // 
            // options_showsplash
            // 
            this.options_showsplash.AutoSize = true;
            this.options_showsplash.Location = new System.Drawing.Point(20, 20);
            this.options_showsplash.Name = "options_showsplash";
            this.options_showsplash.Size = new System.Drawing.Size(125, 17);
            this.options_showsplash.TabIndex = 3;
            this.options_showsplash.Text = "Show Splash Screen";
            this.options_showsplash.UseVisualStyleBackColor = true;
            this.options_showsplash.CheckedChanged += new System.EventHandler(this.options_showsplash_CheckedChanged);
            // 
            // options_loadontabs
            // 
            this.options_loadontabs.AutoSize = true;
            this.options_loadontabs.Location = new System.Drawing.Point(159, 65);
            this.options_loadontabs.Name = "options_loadontabs";
            this.options_loadontabs.Size = new System.Drawing.Size(137, 17);
            this.options_loadontabs.TabIndex = 2;
            this.options_loadontabs.TabStop = true;
            this.options_loadontabs.Text = "Load only on tab switch";
            this.options_loadontabs.UseVisualStyleBackColor = true;
            // 
            // options_loadhwonstart
            // 
            this.options_loadhwonstart.AutoSize = true;
            this.options_loadhwonstart.Location = new System.Drawing.Point(159, 42);
            this.options_loadhwonstart.Name = "options_loadhwonstart";
            this.options_loadhwonstart.Size = new System.Drawing.Size(170, 17);
            this.options_loadhwonstart.TabIndex = 1;
            this.options_loadhwonstart.TabStop = true;
            this.options_loadhwonstart.Text = "Load hardware data on startup";
            this.options_loadhwonstart.UseVisualStyleBackColor = true;
            // 
            // options_loadonstart
            // 
            this.options_loadonstart.AutoSize = true;
            this.options_loadonstart.Location = new System.Drawing.Point(159, 19);
            this.options_loadonstart.Name = "options_loadonstart";
            this.options_loadonstart.Size = new System.Drawing.Size(136, 17);
            this.options_loadonstart.TabIndex = 0;
            this.options_loadonstart.TabStop = true;
            this.options_loadonstart.Text = "Load all data on startup";
            this.options_loadonstart.UseVisualStyleBackColor = true;
            // 
            // options_weights_group
            // 
            this.options_weights_group.Controls.Add(this.options_filterby);
            this.options_weights_group.Controls.Add(this.options_filter_lbl);
            this.options_weights_group.Controls.Add(this.options_weightings);
            this.options_weights_group.Location = new System.Drawing.Point(12, 158);
            this.options_weights_group.Name = "options_weights_group";
            this.options_weights_group.Size = new System.Drawing.Size(332, 227);
            this.options_weights_group.TabIndex = 1;
            this.options_weights_group.TabStop = false;
            this.options_weights_group.Text = "Weightings";
            // 
            // options_filterby
            // 
            this.options_filterby.FormattingEnabled = true;
            this.options_filterby.Location = new System.Drawing.Point(70, 18);
            this.options_filterby.Name = "options_filterby";
            this.options_filterby.Size = new System.Drawing.Size(121, 21);
            this.options_filterby.TabIndex = 2;
            this.options_filterby.SelectedIndexChanged += new System.EventHandler(this.options_filterby_SelectedIndexChanged);
            // 
            // options_filter_lbl
            // 
            this.options_filter_lbl.AutoSize = true;
            this.options_filter_lbl.Location = new System.Drawing.Point(17, 21);
            this.options_filter_lbl.Name = "options_filter_lbl";
            this.options_filter_lbl.Size = new System.Drawing.Size(47, 13);
            this.options_filter_lbl.TabIndex = 1;
            this.options_filter_lbl.Text = "Filter By:";
            // 
            // options_weightings
            // 
            this.options_weightings.AllowUserToAddRows = false;
            this.options_weightings.AllowUserToDeleteRows = false;
            this.options_weightings.AllowUserToResizeColumns = false;
            this.options_weightings.AllowUserToResizeRows = false;
            this.options_weightings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.options_weightings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.options_weightings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ch_attribute,
            this.ch_weight});
            this.options_weightings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.options_weightings.Location = new System.Drawing.Point(7, 45);
            this.options_weightings.Name = "options_weightings";
            this.options_weightings.RowHeadersVisible = false;
            this.options_weightings.Size = new System.Drawing.Size(319, 176);
            this.options_weightings.TabIndex = 0;
            this.options_weightings.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.options_weightings_CellValueChanged);
            // 
            // ch_attribute
            // 
            this.ch_attribute.HeaderText = "Attribute";
            this.ch_attribute.Name = "ch_attribute";
            this.ch_attribute.ReadOnly = true;
            this.ch_attribute.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ch_weight
            // 
            this.ch_weight.HeaderText = "Weight";
            this.ch_weight.Name = "ch_weight";
            this.ch_weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // options_apply
            // 
            this.options_apply.Location = new System.Drawing.Point(269, 391);
            this.options_apply.Name = "options_apply";
            this.options_apply.Size = new System.Drawing.Size(75, 23);
            this.options_apply.TabIndex = 2;
            this.options_apply.Text = "Apply";
            this.options_apply.UseVisualStyleBackColor = true;
            this.options_apply.Click += new System.EventHandler(this.options_apply_Click);
            // 
            // options_cancel
            // 
            this.options_cancel.Location = new System.Drawing.Point(188, 391);
            this.options_cancel.Name = "options_cancel";
            this.options_cancel.Size = new System.Drawing.Size(75, 23);
            this.options_cancel.TabIndex = 3;
            this.options_cancel.Text = "Cancel";
            this.options_cancel.UseVisualStyleBackColor = true;
            this.options_cancel.Click += new System.EventHandler(this.options_cancel_Click);
            // 
            // options_database_group
            // 
            this.options_database_group.Location = new System.Drawing.Point(12, 109);
            this.options_database_group.Name = "options_database_group";
            this.options_database_group.Size = new System.Drawing.Size(332, 43);
            this.options_database_group.TabIndex = 4;
            this.options_database_group.TabStop = false;
            this.options_database_group.Text = "Database Settings";
            // 
            // OptionsDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 421);
            this.Controls.Add(this.options_database_group);
            this.Controls.Add(this.options_cancel);
            this.Controls.Add(this.options_apply);
            this.Controls.Add(this.options_weights_group);
            this.Controls.Add(this.options_general_group);
            this.Icon = global::CoreView.Properties.Resources.Logo;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsDialogue";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Core View Options";
            this.options_general_group.ResumeLayout(false);
            this.options_general_group.PerformLayout();
            this.options_weights_group.ResumeLayout(false);
            this.options_weights_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.options_weightings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox options_general_group;
        private System.Windows.Forms.GroupBox options_weights_group;
        private System.Windows.Forms.DataGridView options_weightings;
        private System.Windows.Forms.Button options_apply;
        private System.Windows.Forms.Button options_cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_attribute;
        private System.Windows.Forms.DataGridViewTextBoxColumn ch_weight;
        private System.Windows.Forms.ComboBox options_filterby;
        private System.Windows.Forms.Label options_filter_lbl;
        private System.Windows.Forms.RadioButton options_loadontabs;
        private System.Windows.Forms.RadioButton options_loadhwonstart;
        private System.Windows.Forms.RadioButton options_loadonstart;
        private System.Windows.Forms.CheckBox options_showsplash;
		private System.Windows.Forms.GroupBox options_database_group;
    }
}