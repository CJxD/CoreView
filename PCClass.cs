using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management;
using System.Security.Cryptography;

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

        // Methods to get all info sequentially
        public void GetAllInfo()
        {
            this.GetHardwareInfo();
            this.GetSoftwareInfo();
        }
        public void GetHardwareInfo()
        {
            // Complete error catching for information gathering
            try
            {
                // Set progress to 0%
                Splash.AddProgressInfo("Initialising...", 0);
                GetGeneral();

                // Hardware \\
                // Output what the current task is doing
                // Add 3% onto progress bar
                // Each process will increate the percentage by a different amount
                // depending on how long it usually takes proportionally
                Splash.AddProgressInfo("Loading Processor Information...", 3);
                GetProcessors();

                Splash.AddProgressInfo("Loading Motherboard Information...", 2);
                GetMotherboards();

                Splash.AddProgressInfo("Loading BIOS Information...", 1);
                GetBIOS();

                Splash.AddProgressInfo("Loading Memory Information...", 2);
                GetMemory();

                Splash.AddProgressInfo("Loading Graphics Information...", 3);
                GetGraphics();

                Splash.AddProgressInfo("Loading Network Information...", 4);
                GetNetworks();

                Splash.AddProgressInfo("Loading Disk Drive Information...", 4);
                GetHardDrives();

                Splash.AddProgressInfo("Loading Optical Drive Information...", 2);
                GetOpticalDrives();

                Splash.AddProgressInfo("Loading PCI Information...", 4);
                GetPCICards();

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
                Splash.AddProgressInfo("Processing Driver Information...", 6);
                GetDrivers();

                Splash.AddProgressInfo("Processing Software Information...", 15);
                GetSoftware();

                Splash.AddProgressInfo("Processing Address Maps...", 18);
                GetAddresses();

                Splash.AddProgressInfo("Processing IRQ Maps...", 14);
                GetIRQs();

                Splash.AddProgressInfo("Processing Conflicts...", 3);
                GetConflicts();

                Splash.AddProgressInfo("Processing Running Processes...", 5);
                GetProcesses();

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
                this.PCICard.Add(new PCICard(Object));
            }

        }

        public void GetUSBDevices()
        {
            ManagementObject[] WMIDataTemp1 = DataRetriever.GetWMIData("Win32_USBControllerDevice");
            foreach (ManagementObject Object in WMIDataTemp1)
            {
                // There is more data in Win32_PnPEntity, so data is being pulled from that
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
                    // Only write a log if newer than 1 week old
                    if (log.TimeGenerated.AddDays(7) >= DateTime.Now)
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
                }
            }
        }

        public void GetGeneral()
        {
            // General info
            // Unique ID
            foreach (NetworkAdapter adapter in NetworkAdapter)
            {
                if (adapter.MACAddress != "" && adapter.MACAddress != "N/A")
                {
                    // Convert formatted hex to integer
                    // Start new MD5 hash
                    MD5 hash = new MD5CryptoServiceProvider();

                    // Get an array of bytes from the MACAddress
                    string hex = adapter.MACAddress.Replace(":", "");
                    int length = hex.Length;
                    byte[] bytes = new byte[length / 2];
                    for (int i = 0; i < length / 2; i++)
                        bytes[i] = Convert.ToByte(hex.Substring(i, 2), 16);

                    // Make MD5
                    hash.ComputeHash(bytes);
                    // Turn bytes to string
                    string output = BitConverter.ToString(hash.Hash);
                    // Remove slashses
                    output = output.Replace("-", "");
                    // Extract first 4 bytes of hash (32 bits)
                    output = output.Substring(0, 8);
                    // Convert to 32 bit integer and subtract the MSB with a bitmask - ensures positive only
                    this.ID = Convert.ToInt32(output, 16) & 0x7FFFFFFF;
                }
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
