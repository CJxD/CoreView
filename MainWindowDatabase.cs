using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CoreView
{
	public partial class MainWindow
	{
        Thread databaseWorker;
		bool abortPending = false;
        List<PC> foundComputers = new List<PC>();
        // This temporary list view allows for other threads to edit the database_details ListView
        // The updater worker will put these results into the real thing every second
        ListView temporary_database_details = new ListView();

		private void database_add_Click(object sender, EventArgs e)
        {
            DatabaseAdd databaseAddForm = new DatabaseAdd();
            databaseAddForm.ShowDialog();
            if (databaseAddForm.DialogResult == DialogResult.OK)
            {
                // Add the given comments to the PC class
                currentComputer.Comments = databaseAddForm.Comments;
                // Start the adding process
                if (databaseWorker != null && databaseWorker.IsAlive)
                {
                    MessageBox.Show("The database is currently in use."
                        + Environment.NewLine
                        + "Please try again in a moment",
                        "Database In-Use",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk
                    );
                }
                else
                {
                    Splash.RestartProgress();
					// If another computer is currently loaded, unload it
					if (database_load_computer.Text == "Unload Computer")
					{
						database_load_computer_Click(null, null);
					}
                    databaseWorker = new Thread(new ThreadStart(databaseAdd));
					databaseWorker.IsBackground = true;
                    databaseWorker.Start();
                }
            }
        }

        private void database_query_start_Click(object sender, EventArgs e)
        {
            // Check whether thread is busy
            if (databaseWorker != null && databaseWorker.IsAlive)
            {
                MessageBox.Show("The database is currently in use."
                    + Environment.NewLine
                    + "Please try again in a moment",
                    "Database In-Use",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk
                );
            }
            else
            {
                Splash.RestartProgress();
                // Copy columns
                temporary_database_details.Clear();
                foreach (ColumnHeader col in database_details.Columns)
                {
                    temporary_database_details.Columns.Add((ColumnHeader)col.Clone());
                }
                databaseWorker = new Thread(new ThreadStart(databaseQuery));
				databaseWorker.IsBackground = true;
                databaseWorker.Start();
            }
        }

        private void database_query_stop_Click(object sender, EventArgs e)
        {
            Thread abortThread = new Thread(new ThreadStart(abortDatabaseOperation));
			abortThread.IsBackground = true;
            abortThread.Start();
            // Do a final list search
            ListViewSorter sorter = new ListViewSorter(database_details);
            sorter.Sort(1, Sorting.Order.Descending);
        }

        private void abortDatabaseOperation()
        {
            Splash.RestartProgress();
            Splash.AddProgressInfo("Aborting...", 50);
			abortPending = true;
            while(databaseWorker.IsAlive)
            {
                // Do nothing
            }
			abortPending = false;
            Splash.AddProgressInfo("Aborted.", 100);
        }

        private void database_options_Click(object sender, EventArgs e)
        {
            OptionsDialogue options = new OptionsDialogue();
            options.ShowDialog();
        }

        private void database_load_computer_Click(object sender, EventArgs e)
        {
            // This switch will load/unload the currently selected computer depending on
            // what the current button text is
            if (database_load_computer.Text == "Load Selected Computer")
            {
                // Store the current computer
                storedComputer = currentComputer;
                // Load the computer with the id of the currently selected computer
                currentComputer = Database.GetComputer(Convert.ToInt32(database_details.SelectedItems[0].Text));

                // Refresh listings
                populateForm();
                // Disable live updates
                updater.Enabled = false;

                // Set the new button value
                database_load_computer.Text = "Unload Computer";
            }
            else
            {
                // Restore computer from stored
                currentComputer = storedComputer;
                // Blank the temporary one
                storedComputer = new PC();

                // Refresh listings
                populateForm();
                // Enable live updates
                updater.Enabled = true;

                // Set the new button value
                database_load_computer.Text = "Load Selected Computer";
            }
        }

        private void database_details_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Expose the comments in the larger box
            database_comments.Text = e.Item.SubItems[2].Text;
        }

        public void databaseAdd()
        {
            // Processor ID is seen as unique for each computer
            int id = currentComputer.ID;

            // First delete any existing elements with the given id
            // This makes sure any table updates are correctly handled
            Database.DeleteFromDB(id);

			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            Database.AddCommentsToDB(currentComputer.Comments, currentComputer.ID);

            // For each device instance in device classes
            // This could be done with ClassList.AllClasses, but nah
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.Processor.Count; i++)
            {
                Database.AddToDB(currentComputer.Processor[i], "processor", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.Motherboard.Count; i++)
            {
                Database.AddToDB(currentComputer.Motherboard[i], "motherboard", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.BIOS.Count; i++)
            {
                Database.AddToDB(currentComputer.BIOS[i], "bios", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.MemoryDevice.Count; i++)
            {
                Database.AddToDB(currentComputer.MemoryDevice[i], "memorydevice", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.GraphicsAdapter.Count; i++)
            {
                Database.AddToDB(currentComputer.GraphicsAdapter[i], "graphicsadapter", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.NetworkAdapter.Count; i++)
            {
                Database.AddToDB(currentComputer.NetworkAdapter[i], "networkadapter", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.HardDrive.Count; i++)
            {
                Database.AddToDB(currentComputer.HardDrive[i], "harddrive", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.OpticalDrive.Count; i++)
            {
                Database.AddToDB(currentComputer.OpticalDrive[i], "opticaldrive", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.PCICard.Count; i++)
            {
                Database.AddToDB(currentComputer.PCICard[i], "pcicard", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.USBDevice.Count; i++)
            {
                Database.AddToDB(currentComputer.USBDevice[i], "usbdevice", id, i);
            }

			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.Driver.Count; i++)
            {
                Database.AddToDB(currentComputer.Driver[i], "driver", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.Software.Count; i++)
            {
                Database.AddToDB(currentComputer.Software[i], "software", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.Conflict.Count; i++)
            {
                Database.AddToDB(currentComputer.Conflict[i], "conflict", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 5);
            for (int i = 0; i < currentComputer.Process.Count; i++)
            {
                Database.AddToDB(currentComputer.Process[i], "process", id, i);
            }
			if (abortPending) return;
            Splash.AddProgressInfo("Adding to Database...", 15);
            for (int i = 0; i < currentComputer.Log.Count; i++)
            {
                Database.AddToDB(currentComputer.Log[i], "log", id, i);
            }

            Splash.AddProgressInfo("Done.", 100);

            MessageBox.Show("Computer added to the database.", "Database Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void databaseQuery()
        {
            // Get IDs of all computers in database
            int[] idNumbers = Database.GetIDNumbers();

            // Clear the foundComputers list
            foundComputers.Clear();
            // Clear the ListView
            temporary_database_details.Items.Clear();

            foreach (int id in idNumbers)
            {
                // This loop represents 50%. Divide it equally for the number of computers to search.
                Splash.AddProgressInfo("Querying Database...", 50 / idNumbers.Length);
                // Add the complete PC object associated with the given id to the list of computers
                foundComputers.Add(Database.GetComputer(id));
            }

            // Now loop through these computers and get a score for each one
            foreach (PC computer in foundComputers)
            {
                Splash.AddProgressInfo("Querying Database...", 50 / idNumbers.Length);
                // Check the found computer against this Computer
                Database.GetScore(computer, currentComputer);
                // Round to eliminate any rounding errors
                computer.Score = Math.Round(computer.Score, 1);
                // Add the computer's ID, score and comments to the details list
                temporary_database_details.Items.Add(new ListViewItem(new string[] {
                    Convert.ToString(computer.ID),
                    Convert.ToString(computer.Score),
                    computer.Comments
                }));
            }

            // Force a finish
            Splash.AddProgressInfo("Done.", 100);
        }

        private void Complaint_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox senderControl = (CheckBox)sender;
            Configuration.Complaints[senderControl.Name] = senderControl.Checked;
        }
    }
}
