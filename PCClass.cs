using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CoreView
{
    /// <summary>
    /// Class storing all information about the current computer
    /// </summary>
    public class PC
    {
        // Unique computer identifier from MAC Address
        public int ID { get; set; }
        // Score as set by GetScore
        public double Score { get; set; }
        // Comments about the computer problem
        public string Comments { get; set; }

        public string Architecture = "";
        public bool DirtyFlag = false;
		public string Name = "";
		public string NetworkDomain = "";
		public string OEMData = "";
		public byte[] OEMLogo;
        public string OperatingSystem = "";
		public string PrimaryOwner = "";
        public DateTime ShutdownDate = new DateTime();
        public string ShutdownReason = "";

        public List<Processor> Processor = new List<Processor>();
        public List<Motherboard> Motherboard = new List<Motherboard>();
        public List<BIOS> BIOS = new List<BIOS>();
        public List<MemoryDevice> MemoryDevice = new List<MemoryDevice>();
        public List<GraphicsAdapter> GraphicsAdapter = new List<GraphicsAdapter>();
        public List<NetworkAdapter> NetworkAdapter = new List<NetworkAdapter>();
        public List<HardDrive> HardDrive = new List<HardDrive>();
        public List<OpticalDrive> OpticalDrive = new List<OpticalDrive>();
        public List<PCICard> PCICard = new List<PCICard>();
        public List<USBDevice> USBDevice = new List<USBDevice>();

        public List<Driver> Driver = new List<Driver>();
        public List<Software> Software = new List<Software>();
        public List<Address> Address = new List<Address>();
        public List<IRQ> IRQ = new List<IRQ>();
        public List<Conflict> Conflict = new List<Conflict>();
        public List<Process> Process = new List<Process>();
        public List<Log> Log = new List<Log>();

        // Boolean to flag if an abort is requested
        private bool abortRetrieval = false;
        public void AbortRetrieval()
        {
            abortRetrieval = true;
        }
        public void ResetAbort()
        {
            abortRetrieval = false;
        }

        // Methods to get all info sequentially
        public void GetAllInfo()
        {
			Splash.RestartProgress();
            Splash.AddProgressInfo("Initialising...", 0);
            GetGeneral();
            this.GetHardwareInfo();
            this.GetSoftwareInfo();
            Splash.AddProgressInfo("Done.", 100);
        }
        public void GetHardwareInfo()
        {
            // Complete error catching for information gathering
            try
            {
                // Hardware \\
                // Output what the current task is doing
                // Add 3% onto progress bar
                // Each process will increate the percentage by a different amount
                // depending on how long it usually takes proportionally
                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Processor Information...", 3);
                GetProcessors();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Motherboard Information...", 2);
                GetMotherboards();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading BIOS Information...", 1);
                GetBIOS();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Memory Information...", 2);
                GetMemory();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Graphics Information...", 3);
                GetGraphics();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Network Information...", 4);
                GetNetworks();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Disk Drive Information...", 4);
                GetHardDrives();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading Optical Drive Information...", 2);
                GetOpticalDrives();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading PCI Information...", 4);
                GetPCICards();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Loading USB Information...", 5);
                GetUSBDevices();
            }
            catch (Exception e)
            {
                ErrorDialogue errorDialogue = new ErrorDialogue(e);
                errorDialogue.Show();
            }
        }

        public void GetSoftwareInfo()
        {
            // Complete error catching for information gathering
            try
            {
                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing Driver Information...", 6);
                GetDrivers();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing Software Information...", 15);
                GetSoftware();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing Address Maps...", 18);
                GetAddresses();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing IRQ Maps...", 14);
                GetIRQs();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing Conflicts...", 3);
                GetConflicts();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing Running Processes...", 5);
                GetProcesses();

                if (abortRetrieval) return;
                Splash.AddProgressInfo("Processing Windows Logs...", 10);
                GetLogs();
            }
            catch (Exception e)
            {
                ErrorDialogue errorDialogue = new ErrorDialogue(e);
                errorDialogue.Show();
            }
        }

        public void GetProcessors()
        {
            // Fetch data as ManagementObjects
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_Processor");
            // Loop though each ManagementObject and add a new device for each instance
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.Processor.Add(new Processor(Object));
            }
        }

        public void GetMotherboards()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_Baseboard");
            ManagementObject[] WMIDataTemp2 = DataRetriever.GetWMIData("Win32_MotherboardDevice");
            for (int i = 0; i < WMIDataTemp1.Length; i++)
            {
                this.Motherboard.Add(new Motherboard(WMIDataTemp1[i], WMIDataTemp2[i]));
            }
        }

        public void GetBIOS()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_BIOS");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.BIOS.Add(new BIOS(Object));
            }
        }

        public void GetMemory()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_PhysicalMemory");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.MemoryDevice.Add(new MemoryDevice(Object));
            }
        }

        public void GetGraphics()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_VideoController");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.GraphicsAdapter.Add(new GraphicsAdapter(Object));
            }
        }


        public void GetNetworks()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_NetworkAdapter");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.NetworkAdapter.Add(new NetworkAdapter(Object));
            }
            // Sort network adapters by whether they're physical or not
            List<NetworkAdapter> tempList = new List<NetworkAdapter>();
            foreach (NetworkAdapter Adapter in this.NetworkAdapter)
            {
                if (Adapter.PhysicalAdapter)
                {
                    // If it's physical, insert it at the top of the list
                    tempList.Insert(0, Adapter);
                }
                else
                {
                    // Otherwise, add it to the bottom
                    tempList.Add(Adapter);
                }
            }
            // Overwrite the existing list
            this.NetworkAdapter.Clear();
            this.NetworkAdapter.AddRange(tempList);
            // Clear the temporary list
            tempList.Clear();
        }

        public void GetHardDrives()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_DiskDrive");
            string deviceID;
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                // Get SMART data relative to the hard drive being processed
                // PNPDeviceID = InstanceName
                // First get the PNPDeviceID and sanitise it
                deviceID = DataRetriever.GetValue(Object, "PNPDeviceID");
                // Double-escape backslashes
                deviceID = deviceID.Replace("\\", "\\\\");

                // Get SMART data
                ManagementObject[] WMIDataTemp2 = DataRetriever.GetWMIData("MSStorageDriver_ATAPISmartData", "InstanceName='" + deviceID + "_0'", "WMI");

                // If nothing was found, make a new hard drive without SMART data
                if (WMIDataTemp2 == null || WMIDataTemp2.Length < 1)
                {
                    this.HardDrive.Add(new HardDrive(Object, null, null));
                }
                else
                {
                    // Get Failure Predict status
                    ManagementObject[] WMIDataTemp3 = DataRetriever.GetWMIData("MSStorageDriver_FailurePredictStatus", "InstanceName='" + deviceID + "_0'", "WMI");

                    this.HardDrive.Add(new HardDrive(Object, WMIDataTemp2[0], WMIDataTemp3[0]));
                }
            }
        }

        public void GetOpticalDrives()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_CDROMDrive");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.OpticalDrive.Add(new OpticalDrive(Object));
            }
        }

        public void GetPCICards()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_SystemSlot");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                //ManagementObject[] WMIDataTemp2 = DataRetriever.GetWMIData("Win32_SystemSlot");
                //if (Object["DeviceID"].ToString().Substring(0, 3) == "PCI")
                //{
                    this.PCICard.Add(new PCICard(Object, null));
                //}
            }
        }

        public void GetUSBDevices()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_USBControllerDevice");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                // There is more data in Win32_PnPEntity, so data is being pulled from that too
                ManagementObject WMIDataTemp2 = DataRetriever.GetPnPEntity(Object["Dependent"].ToString());
                this.USBDevice.Add(new USBDevice(WMIDataTemp2));
            }
        }

        public void GetDrivers()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_PnPSignedDriver");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.Driver.Add(new Driver(Object));
            }
        }

        public void GetSoftware()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_Product");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.Software.Add(new Software(Object));
            }
        }

        public void GetAddresses()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_DeviceMemoryAddress");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                // For each DeviceMemoryAddress found, get the PnP data associated with it
                ManagementObject[] WMIDataTemp2 = DataRetriever.GetWMIAssociates("Win32_DeviceMemoryAddress", "Win32_PnPEntity", "StartingAddress", Convert.ToString(Object["StartingAddress"]), "CIMV2");
                if (WMIDataTemp2 != null)
                {
                    foreach (ManagementObject Associate in WMIDataTemp2)
                    {
                        this.Address.Add(new Address(Object, Associate));
                    }
                }
            }
        }

        public void GetIRQs()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_IRQResource");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                ManagementObject[] WMIDataTemp2 = DataRetriever.GetWMIAssociates("Win32_IRQResource", "Win32_PnPEntity", "IRQNumber", Convert.ToString(Object["IRQNumber"]), "CIMV2");
                if (WMIDataTemp2 != null)
                {
                    foreach (ManagementObject Associate in WMIDataTemp2)
                    {
                        this.IRQ.Add(new IRQ(Object, Associate));
                    }
                }
            }
        }

        public void GetConflicts()
        {
            // Address conflicts
            // Check every address against every other address
            for (int i = 0; i < this.Address.Count - 1; i++)
            {
                string conflictingDevice = "";
                UInt64 startAddress = 0;
                UInt64 endAddress = 0;
                // Cycle all the other addresses until a conflict is found
                int j = i + 1;
                while (j < this.Address.Count && conflictingDevice == "")
                {
                    // Check if start address is between current device's start and end
                    if (this.Address[i].StartAddress < this.Address[j].StartAddress
                        && this.Address[i].EndAddress > this.Address[j].StartAddress)
                    {
                        conflictingDevice = this.Address[j].Device;
                        // If the start address is inbetween, then this is where the conflict starts
                        startAddress = this.Address[j].StartAddress;
                    }
                    else
                    {
                        // Otherwise, the conflict would start from the current device's start address
                        startAddress = this.Address[i].StartAddress;
                    }
                    // Check end address
                    if (this.Address[i].StartAddress < this.Address[j].EndAddress
                        && this.Address[i].EndAddress > this.Address[j].EndAddress)
                    {
                        conflictingDevice = this.Address[j].Device;
                        endAddress = this.Address[j].EndAddress;
                    }
                    else
                    {
                        endAddress = this.Address[i].EndAddress;
                    }
                    // Move on to next Address
                    j++;
                }
                // If a conflict was found, make a new conflict instance
                if (conflictingDevice != "")
                {
                    this.Conflict.Add(new Conflict(
                        this.Address[i].Device,
                        conflictingDevice,
                        startAddress,
                        endAddress
                    ));
                }
            }

            // IRQ Conflicts
            // Check every IRQ against every other IRQ
            for (int i = 0; i < this.IRQ.Count - 1; i++)
            {
                string conflictingDevice = "";
                string resource = "";
                // Cycle all the other IRQs until a conflict is found
                int j = i + 1;
                while (j < this.IRQ.Count && conflictingDevice == "")
                {
                    if (this.IRQ[i].Resource == this.IRQ[j].Resource)
                    {
                        conflictingDevice = this.IRQ[j].Device;
                        resource = this.IRQ[j].Resource;
                    }
                    // Move on to next IRQ
                    j++;
                }
                // If a conflict was found, make a new conflict instance
                if (conflictingDevice != "")
                {
                    this.Conflict.Add(new Conflict(
                        this.IRQ[i].Device,
                        conflictingDevice,
                        resource
                    ));
                }
            }
        }

        public void GetProcesses()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_Process");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                this.Process.Add(new Process(Object));
            }
        }

        public void GetLogs()
        {
            EventLog EventDataTemp;

            // Add a log entry for each instance in the following Event Types
            string[] eventTypes = new string[] { "Application", "Security", "System" };
            foreach (string eventType in eventTypes)
            {
                EventDataTemp = new EventLog(eventType, Environment.MachineName);
                foreach (EventLogEntry log in EventDataTemp.Entries)
                {
                    // Only write a log if newer LogAgeMax
                    if (log.TimeGenerated.AddDays(Configuration.LogAgeMax) >= DateTime.Now || Configuration.LogAgeMax == 0)
                    {
                        // Only write a log if configuration is not specific of event type
                        // Or if the log is an error when the option is set
                        if (Configuration.OnlyErrorLogs)
                        {
                            if (log.EntryType == EventLogEntryType.Error)
                            {
                                this.Log.Add(new Log(log));
                            }
                        }
                        else
                        {
                            this.Log.Add(new Log(log));
                        }
                    }

                    // Get the reason for last shutdown (event code 1074 or 6008)
                    // This will be rerecorded each time one of these IDs are found, but only the latest one will be kept
                    if (log.EventID == 1074 || log.EventID == 6008)
                    {
                        this.ShutdownDate = log.TimeGenerated;
                        this.ShutdownReason = log.Message;
                    }
                }
            }

            // Replace full shutdown reason message with the pure reason only using regular expressions
            Match match = Regex.Match(this.ShutdownReason, @"(unexpected)|reason: ([\w|(|)| ]+)", RegexOptions.IgnoreCase);
            this.ShutdownReason = match.Groups[1].Value + match.Groups[2].Value;

            // Replace 'No title for this reason could be found' with 'unexplained'
            if (this.ShutdownReason == "No title for this reason could be found") this.ShutdownReason = "unexplained";
        }

        public void GetGeneral()
        {
            // General info
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_OperatingSystem");
            this.Architecture = DataRetriever.GetValue(WMIDataTemp1[0], "OSArchitecture");
            this.Name = DataRetriever.GetValue(WMIDataTemp1[0], "CSName");
            this.OperatingSystem = DataRetriever.GetValue(WMIDataTemp1[0], "Name");
            this.OperatingSystem = this.OperatingSystem.Split(new char[] { '¦', '|' })[0];

            WMIDataTemp1 = DataRetriever.GetWMIData("Win32_ComputerSystem");
            this.NetworkDomain = DataRetriever.GetValue(WMIDataTemp1[0], "Domain");
            string[] oemTemp = DataRetriever.GetValueArray(WMIDataTemp1[0], "OEMStringArray");
            if (oemTemp != null) this.OEMData = String.Join(" - ", oemTemp);

            this.OEMLogo = DataRetriever.GetValueBytes(WMIDataTemp1[0], "OEMLogoBitmap");
            this.PrimaryOwner = DataRetriever.GetValue(WMIDataTemp1[0], "PrimaryOwnerName");

            WMIDataTemp1 = DataRetriever.GetWMIData("Win32_Volume", "SystemVolume = True");
            try
            {
                this.DirtyFlag = DataRetriever.GetValueBool(WMIDataTemp1[0], "DirtyBitSet");
            }
            catch
            {
                // If the DirtyFlag could not be properly converted, return false
                // Still need to find out what's really going on here.
                this.DirtyFlag = false;
            }

            // Unique ID - composite of processor ID and hard drive serial numbers
            string id = "";
            WMIDataTemp1 = DataRetriever.GetWMIData("Win32_Processor");
            foreach (ManagementObject Object in WMIDataTemp1)
                id += DataRetriever.GetValue(Object, "ProcessorId");

            WMIDataTemp1 = DataRetriever.GetWMIData("Win32_LogicalDisk");
            foreach (ManagementObject Object in WMIDataTemp1)
                id += DataRetriever.GetValue(Object, "VolumeSerialNumber");

            if (id != "")
            {
                // Convert formatted hex to integer
                // Start new MD5 hash
                MD5 hash = new MD5CryptoServiceProvider();

                // Get an array of bytes from the hexadecimal string
                int length = id.Length;
                byte[] bytes = new byte[length / 2];
                for (int i = 0; i < length / 2; i++)
                    bytes[i] = Convert.ToByte(id.Substring(i, 2), 16);

                // Make MD5
                hash.ComputeHash(bytes);
                // Turn bytes to string
                string output = BitConverter.ToString(hash.Hash);
                // Remove dashes
                output = output.Replace("-", "");
                // Extract first 4 bytes of hash (32 bits)
                output = output.Substring(0, 8);
                // Convert to 32 bit integer and subtract the MSB with a bitmask - ensures positive only
                // Fairly unlikely to get clashes with a 32-bit integer
                this.ID = Convert.ToInt32(output, 16) & 0x7FFFFFFF;
            }

            if (this.ID == 0)
            {
                // Random fallback
                Random random = new Random();
                this.ID = random.Next(2147483647);
            }
            // Score
            this.Score = 0;
        }

        public void RefreshAll()
        {
            // Delete the lists and start again
            // Another option would be to foreach through the list elements and initialise each object again.
            this.Processor.Clear();
            this.Motherboard.Clear();
            this.BIOS.Clear();
            this.MemoryDevice.Clear();
            this.GraphicsAdapter.Clear();
            this.NetworkAdapter.Clear();
            this.HardDrive.Clear();
            this.OpticalDrive.Clear();
            this.PCICard.Clear();
            this.USBDevice.Clear();
            this.Driver.Clear();
            this.Software.Clear();
            this.Address.Clear();
            this.IRQ.Clear();
            this.Conflict.Clear();
            this.Process.Clear();
            this.Log.Clear();
            this.GetAllInfo();
        }

        public void RefreshVolatileData()
        {
            foreach (Processor processor in this.Processor) processor.GetVolatileInfo();
            foreach (Motherboard motherboard in this.Motherboard) motherboard.GetVolatileInfo();
            foreach (GraphicsAdapter graphics in this.GraphicsAdapter) graphics.GetVolatileInfo();
            foreach (HardDrive harddrive in this.HardDrive) harddrive.GetVolatileInfo();
        }
    }
}
