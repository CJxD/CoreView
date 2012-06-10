using System;
using System.Media;
using System.Windows.Forms;

namespace CoreView
{
    public partial class ErrorDialogue : Form
    {
        public ErrorDialogue(Exception e)
        {
            InitializeComponent();
			// Cases for small exceptions
            // If the exception is a Management exception, the text is access denied, and the error hasn't already been shown,
            // show the error.
            // Also show this error if there is a registry access failure
            if (e is System.Management.ManagementException && e.Message == "Access denied " || e is System.Security.SecurityException)
			{
                if (!Configuration.PermissionErrorDisplayed)
                {
                    Configuration.PermissionErrorDisplayed = true;
                    MessageBox.Show("Access was denied for reading some data. "
                        + "Please try running as an administrator to see this data."
                        + Environment.NewLine
                        + "Successfully gathered data will display as normal.",
                        "Permission Denied",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
			}
            // Similar approach for all other exceptions
            // Other ManagementExceptions and NullReferenceExceptions will go here if ReadErrorDisplayed is false
            else if (e is System.Management.ManagementException || e is NullReferenceException)
            {
                if (!Configuration.ReadErrorDisplayed)
                {
                    Configuration.ReadErrorDisplayed = true;
                    MessageBox.Show("Some data could not be read."
                        + Environment.NewLine
                        + "Successfully gathered data will display as normal.",
                        "Data Read Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            // Database errors go here
            else if (e is System.Data.SQLite.SQLiteException)
            {
                if (!Configuration.DatabaseErrorDisplayed)
                {
                    Configuration.DatabaseErrorDisplayed = true;
                    MessageBox.Show("There was a problem with accessing the Heuristic Database. "
                        + "Please check the database isn't opened in another program "
                        + "or contaminated.",
                        "Database Failure",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
			else if (e is System.IO.IOException || e is UnauthorizedAccessException)
			{
				MessageBox.Show("An error occurred when writing the configuration file."
					+ Environment.NewLine
					+ "Please check that it is not in use or on a write-protected medium.",
					"Configuration Failure",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			}
            // Other exceptions display a bigger error
			else
			{
				// Play an error sound
				SystemSounds.Exclamation.Play();
				this.Text = "Unhandled Exception - " + e.Message;
				this.error_details.Text = e.Source
					+ " Exception:"
					+ Environment.NewLine
					+ "   " + e.Message
					+ Environment.NewLine
					+ Environment.NewLine
					+ "Stack Trace:"
					+ Environment.NewLine
					+ e.StackTrace;
				this.error_close.Focus();
				this.ShowDialog();
			}
        }

        private void error_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
