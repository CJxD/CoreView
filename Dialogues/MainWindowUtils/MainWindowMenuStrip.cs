using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace CoreView
{
	public partial class MainWindow
	{
		private void reloadConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Configuration.GetConfig();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_overview;
		}

		private void hardwareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
		}

		private void driversToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_drivers;
		}

		private void softwareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_software;
		}

		private void addressIRQSharingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_irqsharing;
		}

		private void addressMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_addresses;
		}

		private void iRQMapToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_irqs;
		}

		private void runningProcessesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_processes;
		}

		private void windowsLogsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_logs;
		}

		private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_database;
		}

		private void processorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_processor;
		}

		private void motherboardToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_motherboard;
		}

		private void memoryDevicesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_memory;
		}

		private void graphicsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_graphics;
		}

		private void networkToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_network;
		}

		private void hardDrivesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_harddrive;
		}

		private void opticalDrivesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_optical;
		}

		private void pCICardsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_pci;
		}

		private void uSBDevicesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			tab_cont_main.SelectedTab = tab_hardware;
			tab_cont_hardware.SelectedTab = tab_usb;
		}

        private void abortDataRetreivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread abortThread = new Thread(new ThreadStart(abortDataRetreival));
            abortThread.Start();
        }

        private void abortDataRetreival()
        {
            Splash.RestartProgress();
            Splash.AddProgressInfo("Aborting...", 50);
            currentComputer.AbortRetrieval();
            while (dataGet.IsAlive)
            {
                // Wait until all threads killed
            }
            currentComputer.ResetAbort();
            Splash.AddProgressInfo("Aborted.", 100);
        }

		private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
		{
            // Abort first, then refresh
            Thread abortThread = new Thread(new ThreadStart(abortDataRetreival));
            abortThread.Start();
            while (abortThread.IsAlive)
            {
            }
            dataGet = new Thread(new ThreadStart(currentComputer.RefreshAll));
            dataGet.Start();
		}

		private void optionsToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			OptionsDialogue options = new OptionsDialogue();
			options.ShowDialog();
		}

		private void userManualToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
                if (!File.Exists("Manual.pdf"))
                {
                    File.WriteAllBytes("Manual.pdf", Properties.Resources.Manual);
                }
				System.Diagnostics.Process.Start("Manual.pdf");
			}
			catch (Exception)
			{
				MessageBox.Show("'Manual.pdf' could not be loaded.", "Help File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void licensingToolStripMenuItem_Click(object sender, EventArgs e)
		{
            LicenceDialogue licence = new LicenceDialogue();
            licence.ShowDialog();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
            AboutDialogue about = new AboutDialogue();
            about.ShowDialog();
		}
	}
}
