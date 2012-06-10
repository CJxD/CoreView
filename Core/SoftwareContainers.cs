using System;
using System.Management;
using System.Diagnostics;

namespace CoreView
{
    /// <summary>
    /// See Hardware Containers for more information about these Software Containers
    /// </summary>
    public class Driver
    {
        public string Date = "N/A";
        public string Name = "N/A";
        public string Publisher = "N/A";
        public string Version = "N/A";

        public Driver() { }
        public Driver(ManagementObject wmiPnPSignedDriver)
        {
            this.GetInfo(wmiPnPSignedDriver);
        }

        public void GetInfo(ManagementObject wmiPnPSignedDriver)
        {
            try
            {
                this.Date = DataRetriever.GetValueDateString(wmiPnPSignedDriver, "DriverDate");
                // Try a Friendly Name first
                // If not, do a normal name, then DeviceName, then give up
                this.Name = DataRetriever.GetValue(wmiPnPSignedDriver, "FriendlyName");
                if (this.Name == "") this.Name = DataRetriever.GetValue(wmiPnPSignedDriver, "DriverName");
                if (this.Name == "") this.Name = DataRetriever.GetValue(wmiPnPSignedDriver, "DeviceName");
                if (this.Name == "") this.Name = "Unknown";
                this.Publisher = DataRetriever.GetValue(wmiPnPSignedDriver, "DriverProviderName");
                this.Version = DataRetriever.GetValue(wmiPnPSignedDriver, "DriverVersion");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }

	public class Software
	{
		public string Date = "N/A";
		public string Name = "N/A";
		public string Publisher = "N/A";
		public string Version = "N/A";

		public Software() { }
		public Software(ManagementObject wmiProduct)
		{
			this.GetInfo(wmiProduct);
		}

		public void GetInfo(ManagementObject wmiProduct)
		{
			try
			{
                this.Date = DataRetriever.GetValueDateString(wmiProduct, "InstallDate");
				this.Name = DataRetriever.GetValue(wmiProduct, "Name");
				this.Publisher = DataRetriever.GetValue(wmiProduct, "Vendor");
				this.Version = DataRetriever.GetValue(wmiProduct, "Version");
			}
			catch (Exception e)
			{
				ErrorDialogue errorReporter = new ErrorDialogue(e);
			}
		}
	}

	public class Address
	{
		public string Device = "N/A";
        public UInt64 EndAddress = 0;
        public string Resource = "N/A";
        public UInt64 StartAddress = 0;

		public Address() { }
        public Address(ManagementObject wmiDeviceMemoryAddress, ManagementObject wmiPnPEntity)
		{
            this.GetInfo(wmiDeviceMemoryAddress, wmiPnPEntity);
		}

        public void GetInfo(ManagementObject wmiDeviceMemoryAddress, ManagementObject wmiPnPEntity)
		{
			try
			{
                this.Device = DataRetriever.GetValue(wmiPnPEntity, "Name");
                this.EndAddress = DataRetriever.GetValueUInt64(wmiDeviceMemoryAddress, "EndingAddress");
                this.Resource = DataRetriever.GetValue(wmiDeviceMemoryAddress, "Description");
                this.StartAddress = DataRetriever.GetValueUInt64(wmiDeviceMemoryAddress, "StartingAddress");
			}
			catch (Exception e)
			{
				ErrorDialogue errorReporter = new ErrorDialogue(e);
			}
		}
	}

    public class IRQ
    {
        public string Device = "N/A";
        public string Resource = "N/A";

        public IRQ() { }
        public IRQ(ManagementObject wmiIRQResource, ManagementObject wmiPnPEntity)
        {
            this.GetInfo(wmiIRQResource, wmiPnPEntity);
        }

        public void GetInfo(ManagementObject wmiIRQResource, ManagementObject wmiPnPEntity)
        {
            try
            {
                this.Device = DataRetriever.GetValue(wmiPnPEntity, "Name");
                this.Resource = DataRetriever.GetValue(wmiIRQResource, "Name");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }

    // Conflicts now have their own class for ease of storage
    public class Conflict
    {
        public string Device1 = "N/A";
        public string Device2 = "N/A";
        public string Resource = "N/A";

        public Conflict() { }
        // Overload for Addresses to calculate a string resource representation
        public Conflict(string device1, string device2, UInt64 startAddress, UInt64 endAddress)
        {
            // Convert each address to hex
            string resource = "0x" + startAddress.ToString("X");
            resource += "-0x" + endAddress.ToString("X");
            this.Device1 = device1;
            this.Device2 = device2;
            this.Resource = resource;
        }
        // Normal constructor
        public Conflict(string device1, string device2, string resource)
        {
            this.Device1 = device1;
            this.Device2 = device2;
            this.Resource = resource;
        }
    }

    public class Process
    {
        public UInt16 CPU = 0;
        public string ExecutablePath = "N/A";
        public string ImageName = "N/A";
        public UInt64 IO = 0;
        public UInt64 Memory = 0;
        public UInt16 PID = 0;

        public Process() { }
        public Process(ManagementObject wmiProcess)
        {
            this.GetInfo(wmiProcess);
        }

        public void GetInfo(ManagementObject wmiProcess)
        {
            try
            {
                this.ExecutablePath = DataRetriever.GetValue(wmiProcess, "ExecutablePath");
                this.ImageName = DataRetriever.GetValue(wmiProcess, "Name");
                this.Memory = DataRetriever.GetValueUInt64(wmiProcess, "VirtualSize");
                this.PID = DataRetriever.GetValueUInt16(wmiProcess, "ProcessId");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }

        public void GetVoltatileInfo()
        {
            try
            {
                ManagementObject[] perfData = DataRetriever.GetWMIData("Win32_PerfFormattedData_PerfProc_Process", "IDProcess=" + this.PID);
                this.CPU = DataRetriever.GetValueUInt16(perfData[0], "PercentProcessorTime");
                this.IO = DataRetriever.GetValueUInt64(perfData[0], "IODataBytesPerSec");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }

    public class Log
    {
        public string Category = "N/A";
        public string DateTime = "N/A";
        public Int64 EventID = 0;
        public string Level = "N/A";
        public string Message = "N/A";
        public string Source = "N/A";

        public Log() { }
        public Log(EventLogEntry eventLog)
        {
            this.GetInfo(eventLog);
        }

        public void GetInfo(EventLogEntry eventLog)
        {
            try
            {
                this.Category = eventLog.Category;
                this.DateTime = eventLog.TimeGenerated.ToShortDateString() + " " + eventLog.TimeGenerated.ToLongTimeString();
                this.EventID = eventLog.InstanceId;
                this.Level = eventLog.EntryType.ToString();
                this.Message = eventLog.Message;
                this.Source = eventLog.Source;
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }
}
