using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoreView
{
    public partial class OptionsDialogue : Form
    {
        public OptionsDialogue()
        {
            InitializeComponent();
            // Add the ComboBox items as dictionary items
            Dictionary<string, string> filterItems = new Dictionary<string, string>
            {
                {"Processors", "Processor"},
                {"Motherboards", "Motherboard"},
                {"BIOS", "BIOS"},
                {"Memory Devices", "MemoryDevice"},
                {"Graphics Adapters", "GraphicsAdapter"},
                {"Network Adapters", "NetworkAdapter"},
                {"Hard Drives", "HardDrive"},
                {"Optical Drives", "OpticalDrive"},
                {"PCI Cards", "PCICard"},
                {"USB Devices", "USBDevice"},
                {"Drivers", "Driver"},
                {"Software", "Software"},
                {"Resource Conflicts", "Conflict"},
                {"Processes", "Process"},
                {"Complaint - BSOD", "ComplaintBSOD"},
                {"Complaint - Device Issue", "ComplaintDeviceIssue"},
                {"Complaint - Display Issue", "ComplaintDisplayIssue"},
                {"Complaint - Input Issue", "ComplaintInputIssue"},
                {"Complaint - Lock-Outs", "ComplaintLockouts"},
                {"Complaint - Program Issue", "ComplaintProgramIssue"},
                {"Complaint - Screen Lag", "ComplaintScreenLag"},
                {"Complaint - Slow Boot", "ComplaintSlowBoot"},
                {"Complaint - Sluggish", "ComplaintSluggish"},
                {"Complaint - Sound Issue", "ComplaintSoundIssue"}
            };
            options_filterby.DisplayMember = "Key";
            options_filterby.ValueMember = "Value";
            options_filterby.DataSource = new BindingSource(filterItems, null);

            // Get each configuration option for the checked status of the radio/check boxes
            options_showsplash.Checked = Configuration.ShowSplash;
            options_loadontabs.Checked = true;
            options_loadonstart.Checked = Configuration.LoadWMIAtStart;
            options_loadhwonstart.Checked = Configuration.LoadHardwareAtStart;

            // If Show Splash is checked, then disable the other loading options
            if (Configuration.ShowSplash)
            {
                options_loadontabs.Enabled = false;
                options_loadonstart.Enabled = false;
                options_loadhwonstart.Enabled = false;
            }

            // Trigger the event to populate the data grid of weights
            options_filterby.SelectedIndex = 0;
        }

        private void options_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void options_apply_Click(object sender, EventArgs e)
        {
            // Set each configuration option to the checked status of the radio/check boxes
            Configuration.ShowSplash = options_showsplash.Checked;
            Configuration.LoadWMIAtStart = options_loadonstart.Checked;
            Configuration.LoadHardwareAtStart = options_loadhwonstart.Checked;

            Configuration.SetConfig();
            this.Close();
        }

        private void options_filterby_SelectedIndexChanged(object sender, EventArgs e)
        {
            options_weightings.Rows.Clear();
            // Get the weightings by the index of the filter in conjunction with the classes list
            foreach (KeyValuePair<string, double> weight in Configuration.Weightings[options_filterby.SelectedValue.ToString()])
            {
                options_weightings.Rows.Add(new object[] { weight.Key, weight.Value });
            }
        }

        private void options_weightings_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // This try catch block prevents the user entering a value that is not a floating-point integer
                try
                {
                    string weightName = Convert.ToString(options_weightings.Rows[e.RowIndex].Cells[0].Value);
                    double weightValue = Convert.ToDouble(options_weightings.Rows[e.RowIndex].Cells[1].Value);
                    Configuration.Weightings[options_filterby.SelectedValue.ToString()][weightName] = weightValue;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please enter decimal numbers for weightings.", "Weighting Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void options_showsplash_CheckedChanged(object sender, EventArgs e)
        {
            options_loadonstart.Checked = true;
            // Enable or disable the other loading buttons
            options_loadontabs.Enabled = !options_showsplash.Checked;
            options_loadonstart.Enabled = !options_showsplash.Checked;
            options_loadhwonstart.Enabled = !options_showsplash.Checked;
        }
    }
}
