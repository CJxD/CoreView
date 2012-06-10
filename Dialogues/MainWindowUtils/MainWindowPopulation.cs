using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CoreView
{
    public partial class MainWindow
    {
        private void populateForm()
        {
            // Turn off data updating while forms are processed
            updater.Enabled = false;

            // Add WMI data into form
            populateProcessorTab(null, null);
            populateMotherboardTab(null, null);
            populateMemoryTab(null, null);
            populateGraphicsTab(null, null);
            populateNetworkTab(null, null);
            populateHardDriveTab(null, null);
            populateOpticalTab(null, null);
            populatePCITab(null, null);
            populateUSBTab(null, null);
            populateDriversTab(null, null);
            populateSoftwareTab(null, null);
            populateConflictsTab(null, null);
            populateAddressesTab(null, null);
            populateIRQsTab(null, null);
            populateProcessesTab(null, null);
            populateLogsTab(null, null);
            populateOverviewTab(null, null);

            updater.Enabled = true;
        }

        // Overview \\

        // Hardware \\
        // Processor
        private void populateProcessorTab(object sender, EventArgs e)
        {
            try
            {
                // If no items exist and all data wasn't loaded at start up, load it now.
                if (currentComputer.Processor.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading IRQ Information...", 50);
                    currentComputer.GetProcessors();
                    Splash.AddProgressInfo("Done", 50);
                }

                processor_list.Items.Clear();
                foreach (Processor processor in currentComputer.Processor)
                {
                    // Organised by model name
                    if (processor.Model != "")
                    {
                        processor_list.Items.Add(processor.Model);
                    }
                    else
                    {
                        processor_list.Items.Add("Processor Device");
                    }
                }
                // If 1 or more items exist, then organise instance/index related data
                if (processor_list.Items.Count > 0)
                {
                    // Set the list box to select the first item
                    processor_list.SelectedIndex = 0;
                    // Use the function below for adding the index-related data to the detail list
                    changeHardwareDetails(currentComputer.Processor[0], processor_details);
                    // Change side info including status graphic
                    processor_status.Text = currentComputer.Processor[0].Status;
                    processor_status.BackgroundImage = getStatusImage(currentComputer.Processor[0].Status);
                }
            }
            catch (Exception)
            {
                // Swallow all exceptions.
                // The only exceptions here are temporary problems while data is still being gathered.
            }
        }

        // Motherboard
        private void populateMotherboardTab(object sender, EventArgs e)
        {
            try
            {
                // Motherboard
                if (currentComputer.Motherboard.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Motherboard Information...", 50);
                    currentComputer.GetMotherboards();
                    Splash.AddProgressInfo("Done", 50);
                }
                // BIOS
                if (currentComputer.BIOS.Count == 0 && !Configuration.LoadWMIAtStart)
                {
                    Splash.AddProgressInfo("Loading BIOS Information...", 50);
                    currentComputer.GetBIOS();
                    Splash.AddProgressInfo("Done", 50);
                }

                motherboard_list.Items.Clear();
                foreach (Motherboard motherboard in currentComputer.Motherboard)
                {
                    // Organised by model name
                    if (motherboard.Model != "")
                    {
                        motherboard_list.Items.Add(motherboard.Model);
                    }
                    else
                    {
                        motherboard_list.Items.Add("Motherboard Device");
                    }
                }
                if (motherboard_list.Items.Count > 0)
                {
                    motherboard_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.Motherboard[0], motherboard_details);
                    changeHardwareDetails(currentComputer.BIOS[0], bios_details);
                    motherboard_status.Text = currentComputer.Motherboard[0].Status;
                    motherboard_status.BackgroundImage = getStatusImage(currentComputer.Motherboard[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // Memory
        private void populateMemoryTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.MemoryDevice.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Memory Information...", 50);
                    currentComputer.GetMemory();
                    Splash.AddProgressInfo("Done", 50);
                }

                memory_list.Items.Clear();
                foreach (MemoryDevice memoryDevice in currentComputer.MemoryDevice)
                {
                    // Organised by location
                    if (memoryDevice.DeviceLocation != "")
                    {
                        memory_list.Items.Add(memoryDevice.DeviceLocation);
                    }
                    else
                    {
                        memory_list.Items.Add("DIMM");
                    }
                }
                if (memory_list.Items.Count > 0)
                {
                    memory_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.MemoryDevice[0], memory_details);
                    memory_status.Text = currentComputer.MemoryDevice[0].Status;
                    memory_status.BackgroundImage = getStatusImage(currentComputer.MemoryDevice[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // Graphics
        private void populateGraphicsTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.GraphicsAdapter.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Graphics Information...", 50);
                    currentComputer.GetGraphics();
                    Splash.AddProgressInfo("Done", 50);
                }

                graphics_list.Items.Clear();
                foreach (GraphicsAdapter graphicsAdapter in currentComputer.GraphicsAdapter)
                {
                    // Organised by name
                    if (graphicsAdapter.Name != "")
                    {
                        graphics_list.Items.Add(graphicsAdapter.Name);
                    }
                    else
                    {
                        graphics_list.Items.Add("Graphics Adapter");
                    }
                }
                if (graphics_list.Items.Count > 0)
                {
                    graphics_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.GraphicsAdapter[0], graphics_details);
                    graphics_status.Text = currentComputer.GraphicsAdapter[0].Status;
                    graphics_status.BackgroundImage = getStatusImage(currentComputer.GraphicsAdapter[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // Network
        private void populateNetworkTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.NetworkAdapter.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Network Information...", 50);
                    currentComputer.GetNetworks();
                    Splash.AddProgressInfo("Done", 50);
                }

                network_list.Items.Clear();
                foreach (NetworkAdapter networkAdapter in currentComputer.NetworkAdapter)
                {
                    // Organised by name
                    if (networkAdapter.Name != "")
                    {
                        network_list.Items.Add(networkAdapter.Name);
                    }
                    else
                    {
                        network_list.Items.Add("Network Adapter");
                    }
                }
                if (network_list.Items.Count > 0)
                {
                    network_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.NetworkAdapter[0], network_details);
                    network_status.Text = currentComputer.NetworkAdapter[0].Status;
                    network_status.BackgroundImage = getStatusImage(currentComputer.NetworkAdapter[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // Hard Drives
        private void populateHardDriveTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.HardDrive.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Disk Drive Information...", 50);
                    currentComputer.GetHardDrives();
                    Splash.AddProgressInfo("Done", 50);
                }

                harddrive_list.Items.Clear();
                smart_details.Items.Clear();
                foreach (HardDrive hardDrive in currentComputer.HardDrive)
                {
                    // Organised by model
                    if (hardDrive.Model != "")
                    {
                        harddrive_list.Items.Add(hardDrive.Model);
                    }
                    else
                    {
                        harddrive_list.Items.Add("Hard Drive");
                    }
                }
                if (harddrive_list.Items.Count > 0)
                {
                    harddrive_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.HardDrive[0], harddrive_details);
                    changeHardwareDetails(currentComputer.HardDrive[0].SMARTData, smart_details);
                    harddrive_status.Text = currentComputer.HardDrive[0].Status;
                    harddrive_status.BackgroundImage = getStatusImage(currentComputer.HardDrive[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // Optical Drives
        private void populateOpticalTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.OpticalDrive.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Optical Drive Information...", 50);
                    currentComputer.GetOpticalDrives();
                    Splash.AddProgressInfo("Done", 50);
                }

                optical_list.Items.Clear();
                foreach (OpticalDrive opticalDrive in currentComputer.OpticalDrive)
                {
                    // Organised by name
                    if (opticalDrive.Name != "")
                    {
                        optical_list.Items.Add(opticalDrive.Name);
                    }
                    else
                    {
                        optical_list.Items.Add("Optical Drive");
                    }
                }
                if (optical_list.Items.Count > 0)
                {
                    optical_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.OpticalDrive[0], optical_details);
                    optical_status.Text = currentComputer.OpticalDrive[0].Status;
                    optical_status.BackgroundImage = getStatusImage(currentComputer.OpticalDrive[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // PCI Cards
        private void populatePCITab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.PCICard.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading PCI Information...", 50);
                    currentComputer.GetPCICards();
                    Splash.AddProgressInfo("Done", 50);
                }

                pci_list.Items.Clear();
                foreach (PCICard pciCard in currentComputer.PCICard)
                {
                    // Organised by tag
                    if (pciCard.Tag != "")
                    {
                        pci_list.Items.Add(pciCard.Tag);
                    }
                    else
                    {
                        pci_list.Items.Add("PCI Card");
                    }
                }
                if (pci_list.Items.Count > 0)
                {
                    pci_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.PCICard[0], pci_details);
                    pci_status.Text = currentComputer.PCICard[0].Status;
                    pci_status.BackgroundImage = getStatusImage(currentComputer.PCICard[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // USB Devices
        private void populateUSBTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.USBDevice.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading USB Info...", 50);
                    currentComputer.GetUSBDevices();
                    Splash.AddProgressInfo("Done", 50);
                }

                usb_list.Items.Clear();
                foreach (USBDevice usbDevice in currentComputer.USBDevice)
                {
                    // Organised by name
                    if (usbDevice.Name != "")
                    {
                        usb_list.Items.Add(usbDevice.Name);
                    }
                    else
                    {
                        usb_list.Items.Add("USB Device");
                    }
                }
                if (usb_list.Items.Count > 0)
                {
                    usb_list.SelectedIndex = 0;
                    changeHardwareDetails(currentComputer.USBDevice[0], usb_details);
                    usb_status.Text = currentComputer.USBDevice[0].Status;
                    usb_status.BackgroundImage = getStatusImage(currentComputer.USBDevice[0].Status);
                }
            }
            catch (Exception)
            {
            }
        }

        // Software \\
        // Drivers
        private void populateDriversTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.Driver.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Processing Driver Information...", 50);
                    currentComputer.GetDrivers();
                    Splash.AddProgressInfo("Done", 50);
                }

				// Quick info
				driver_quick_1.Text = currentComputer.Driver.Count.ToString();
				// Main info
                driver_details.Items.Clear();
                foreach (Driver driver in currentComputer.Driver)
                {
                    // If the driver has a name, include in list
                    if (driver.Name != "")
                    {
                        // Add values to list as a ListViewItem
                        driver_details.Items.Add(new ListViewItem(new string[] {
                        driver.Name,
                        driver.Publisher,
                        driver.Version,
                        driver.Date
                    }));
                    }
                }
                // Resize last column
                driver_details.Columns[driver_details.Columns.Count - 1].Width = -2;
                // Sort
                driverSorter = new ListViewSorter(driver_details);
                driverSorter.Sort(0);
            }
            catch (Exception)
            {
            }
        }

        // Installed Software
        private void populateSoftwareTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.Software.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Processing Software Information...", 50);
                    currentComputer.GetSoftware();
                    Splash.AddProgressInfo("Done", 50);
                }

				software_quick_1.Text = currentComputer.Software.Count.ToString();
                software_details.Items.Clear();
                foreach (Software software in currentComputer.Software)
                {
                    if (software.Name != "")
                    {
                        software_details.Items.Add(new ListViewItem(new string[] {
                        software.Name,
                        software.Publisher,
                        software.Version,
                        software.Date
                    }));
                    }
                }
                software_details.Columns[software_details.Columns.Count - 1].Width = -2;
                softwareSorter = new ListViewSorter(software_details);
                softwareSorter.Sort(0);
            }
            catch (Exception)
            {
            }
        }

        // Addresses
        private void populateAddressesTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.Address.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Processing Address Maps Information...", 50);
                    currentComputer.GetAddresses();
                    Splash.AddProgressInfo("Done", 50);
                }

				addresses_quick_1.Text = currentComputer.Address.Count.ToString();
                addresses_details.Items.Clear();
                foreach (Address address in currentComputer.Address)
                {
                    if (address.Resource != "")
                    {
                        addresses_details.Items.Add(new ListViewItem(new string[] {
                        address.Resource,
                        address.Device
                    }));
                    }
                }
                addressesSorter = new ListViewSorter(addresses_details);
                addressesSorter.Sort(0);
            }
            catch (Exception)
            {
            }
        }

        // IRQs
        private void populateIRQsTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.IRQ.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Processing IRQ Maps Information...", 50);
                    currentComputer.GetIRQs();
                    Splash.AddProgressInfo("Done", 50);
                }

				irqs_quick_1.Text = currentComputer.IRQ.Count.ToString();
                irqs_details.Items.Clear();
                foreach (IRQ irq in currentComputer.IRQ)
                {
                    if (irq.Resource != "")
                    {
                        irqs_details.Items.Add(new ListViewItem(new string[] {
                        irq.Resource,
                        irq.Device
                    }));
                    }
                }
                irqs_details.Columns[irqs_details.Columns.Count - 1].Width = -2;
                irqsSorter = new ListViewSorter(irqs_details);
                irqsSorter.Sort(0);
            }
            catch (Exception)
            {
            }
        }

        // Conflicts
        private void populateConflictsTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.Conflict.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Conflicts Information...", 50);
                    currentComputer.GetConflicts();
                    Splash.AddProgressInfo("Done", 50);
                }

				irqsharing_quick_1.Text = currentComputer.Conflict.Count.ToString();
                irqsharing_details.Items.Clear();
                foreach (Conflict conflict in currentComputer.Conflict)
                {
                    if (conflict.Resource != "")
                    {
                        // Device 1
                        irqsharing_details.Items.Add(new ListViewItem(new string[] {
                        conflict.Resource,
                        conflict.Device1
                    }));
                        // Device 2
                        irqsharing_details.Items.Add(new ListViewItem(new string[] {
                        conflict.Resource,
                        conflict.Device2
                    }));
                        // Seperator
                        irqsharing_details.Items.Add("");
                    }
                }
                irqsharing_details.Columns[irqsharing_details.Columns.Count - 1].Width = -2;
            }
            catch (Exception)
            {
            }
        }

        // Processes
        private void populateProcessesTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.Process.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Process Information...", 50);
                    currentComputer.GetProcesses();
                    Splash.AddProgressInfo("Done", 50);
                }

				processes_quick_1.Text = currentComputer.Process.Count.ToString();
                processes_details.Items.Clear();
                foreach (Process process in currentComputer.Process)
                {
                    // If the process has a name, include in list
                    if (process.ImageName != "")
                    {
                        processes_details.Items.Add(new ListViewItem(new string[] {
                        process.ImageName,
                        Convert.ToString(process.PID),
                        process.ExecutablePath,
                        Convert.ToString(process.CPU),
                        Convert.ToString(process.IO)
                    }));
                    }
                }
                processes_details.Columns[processes_details.Columns.Count - 1].Width = -2;
                processesSorter = new ListViewSorter(processes_details);
                processesSorter.Sort(0);
            }
            catch (Exception)
            {
            }
        }

        // Event Logs
        private void populateLogsTab(object sender, EventArgs e)
        {
            try
            {
                if (currentComputer.Log.Count == 0 && !Configuration.LoadWMIAtStart && sender != null)
                {
                    Splash.AddProgressInfo("Loading Event Log Information...", 50);
                    currentComputer.GetLogs();
                    Splash.AddProgressInfo("Done", 50);
                }

                // Count
                logs_quick_1.Text = currentComputer.Log.Count.ToString();
                // Date, time and reason of last shutdown
                if (currentComputer.ShutdownReason != "")
                {
                    logs_quick_2.Text = currentComputer.ShutdownDate.ToShortDateString()
                        + " "
                        + currentComputer.ShutdownDate.ToShortTimeString();
                    logs_quick_3.Text = currentComputer.ShutdownReason;
                }
                else
                {
                    logs_quick_2.Text = "No information available";
                    logs_quick_3.Text = "";
                }
                // Dirty bit
                logs_quick_4.Text = currentComputer.DirtyFlag.ToString();

				// Only change if number of items has changed
				if (logs_details.Items.Count != currentComputer.Log.Count)
				{
					logs_details.Items.Clear();
					foreach (Log log in currentComputer.Log)
					{
						// If the log has a source, include in list
						if (log.Source != "")
						{
							logs_details.Items.Add(new ListViewItem(new string[] {
                        log.Level,
                        log.DateTime,
                        log.Source,
                        Convert.ToString(log.EventID),
                        log.Message
                    }));
						}
					}
					logs_details.Columns[logs_details.Columns.Count - 1].Width = -2;
                    logsSorter = new ListViewSorter(logs_details);
                    logsSorter.Sort(0);
				}
            }
            catch (Exception)
            {
            }
        }

		// Overview
		private void populateOverviewTab(object sender, EventArgs e)
		{
			try
			{
                overview_quick_1.Text = currentComputer.OEMData;
                overview_quick_2.Text = currentComputer.Name;
                overview_quick_3.Text = currentComputer.PrimaryOwner;
                overview_quick_4.Text = currentComputer.NetworkDomain;
                overview_quick_5.Text = currentComputer.OperatingSystem;
                overview_quick_6.Text = currentComputer.Architecture;

                if (currentComputer.OEMLogo != null)
                {
                    MemoryStream oemLogoStream = new MemoryStream(currentComputer.OEMLogo);
                    overview_icon.Image = Image.FromStream(oemLogoStream);
                }
                else
                {
                    overview_icon.Image = Properties.Resources.windows_logo;
                }
			}
			catch (Exception)
			{
			}
		}

        // This subroutine is a shortcut that changes the detail-list data on-screen if dropdown selectors are changed
        // It also plays a part in initialisation
        private void changeHardwareDetails(object hardwareInstance, ListView list)
        {
            // Clear the list
            list.Items.Clear();

            if (hardwareInstance != null)
            {
                // Get the properties of the given hardware class
                FieldInfo[] classFields = hardwareInstance.GetType().GetFields();
                string name, value;
                // Loop through each field in the class
                foreach (FieldInfo field in classFields)
                {
                    // Extract the field name (format it)
                    name = fieldToString(field.Name);
                    // Extract the value
                    value = Convert.ToString(field.GetValue(hardwareInstance));
                    // If the value is zero or blank, output N/A
                    if (value == "0" || value == "") value = "N/A";
                    // Add the value to the list
                    list.Items.Add(new ListViewItem(new string[] {
                        name,
                        value
                    }));
                }
                // Resize columns
                list.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                // Make last column fill the remaining width
                list.Columns[list.Columns.Count - 1].Width = -2;
            }
        }

        private Image getStatusImage(string status)
        {
            switch (status)
            {
                case "OK":
                    return CoreView.Properties.Resources.StatGood;
                case "Error":
                case "Pred Fail":
                    return CoreView.Properties.Resources.StatBad;
                default:
                    return CoreView.Properties.Resources.StatWarn;
            }
        }

        private string fieldToString(string field)
        {
            // Regex to replace field names such as
            // CakeIsGood
            // to a human-friendly
            // Cake Is Good
            // Replaces formats: lowercaseUppercase and AcronymUppercase in a single pattern

            string pattern = @"(([a-z])([A-Z0-9]))|(([A-Z]+)([A-Z]))";
            return System.Text.RegularExpressions.Regex.Replace(field, pattern, "$2$5 $3$6");
        }
    }
}
