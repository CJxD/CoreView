using System;
using System.Management;
using OpenHardwareMonitor.Hardware;

namespace CoreView
{
    /* Note: because of the likeness of the below classes, only one or two will be commented. */
    /// <summary>
    /// These classes provide a way to store attributes about individual computer components.
    /// They should be accessed from a list representing each separate component.
    /// </summary>
    public class Processor
    {
        // Define properties
        public string Architecture = "N/A";
        public string Availability = "N/A";
        public UInt32 CacheL2 = 0;
        public UInt32 CacheL3 = 0;
        public string Caption = "N/A";
        public UInt32 Cores = 0;
		public UInt32 CurrentClock = 0;
		public string ErrorDescription = "N/A";
        public string Family = "N/A";
        public string Manufacturer = "N/A";
        public string Model = "N/A";
		public UInt32 ReferenceClock = 0;
        public UInt16 Revision = 0;
        public string Socket = "N/A";
        public string Status = "N/A";
        public string Stepping = "N/A";
        public Int16 Temperature = 0;
		public UInt16 ThermalDesignPower = 0;
        public UInt32 Threads = 0;
        public UInt16 Usage = 0;

        // Overloaded constructor method
        // The one with no arguments does nothing to initialise the class
        // The one with the ManagementObject argument will call GetInfo to arrange the held data into the properties above
        public Processor() { }
        public Processor(ManagementObject wmiProcessor)
        {
            this.GetInfo(wmiProcessor);
        }

        // The main information handler for the classes.
        // This splits out the data in the ManagementObject into the class's own properties
        public void GetInfo(ManagementObject wmiProcessor)
        {
            // If anything fails, the try loop will just end without making a fuss
            // Because of the default values, N/A will be displayed everywhere if something fails here.
            try
            {
                // Architecture, Availability and several other properties are given as numerical codes.
                // A dictionary with the codes is used to convert these to strings.
                this.Architecture = DataRetriever.ConvertArchitecture(DataRetriever.GetValueUInt16(wmiProcessor, "Architecture"));
                this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiProcessor, "Availability"));
                this.CacheL2 = DataRetriever.GetValueUInt32(wmiProcessor, "L2CacheSize");
                this.CacheL3 = DataRetriever.GetValueUInt32(wmiProcessor, "L3CacheSize");
                this.Caption = DataRetriever.GetValue(wmiProcessor, "Caption");
                this.Cores = DataRetriever.GetValueUInt32(wmiProcessor, "NumberOfCores");
				this.CurrentClock = DataRetriever.GetValueUInt32(wmiProcessor, "CurrentClockSpeed");
				this.ErrorDescription = DataRetriever.GetValue(wmiProcessor, "ErrorDescription");
                this.Family = DataRetriever.ConvertFamily(DataRetriever.GetValueUInt16(wmiProcessor, "Family"));
                this.Manufacturer = DataRetriever.GetValue(wmiProcessor, "Manufacturer");
                this.Model = DataRetriever.GetValue(wmiProcessor, "Name");
                this.ReferenceClock = DataRetriever.GetValueUInt32(wmiProcessor, "MaxClockSpeed");
                this.Revision = DataRetriever.GetValueUInt16(wmiProcessor, "Revision");
                this.Socket = DataRetriever.GetValue(wmiProcessor, "SocketDesignation");
                this.Status = DataRetriever.GetValue(wmiProcessor, "Status");
                this.Stepping = DataRetriever.GetValue(wmiProcessor, "Stepping");
                //this.Temperature = DataRetriever.GetValueFloat(wmiProcessor, "CurrentVoltage");
                //this.ThermalDesignPower = DataRetriever.GetValueFloat(wmiProcessor, "CurrentVoltage");
                this.Threads = DataRetriever.GetValueUInt32(wmiProcessor, "NumberOfLogicalProcessors");
                //this.Usage = DataRetriever.GetValueUInt16(wmiProcessor, "LoadPercentage");
                this.GetVolatileInfo();
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }

        public void GetVolatileInfo()
        {
            DataRetriever.RefreshSensors(HardwareType.CPU, 0);
            this.CurrentClock = Convert.ToUInt32(DataRetriever.GetSensorValue(HardwareType.CPU, 0, SensorType.Clock, 1));
            this.Temperature = Convert.ToInt16(DataRetriever.GetSensorValue(HardwareType.CPU, 0, SensorType.Temperature, 0));
            this.Usage = Convert.ToUInt16(DataRetriever.GetSensorValue(HardwareType.CPU, 0, SensorType.Load, 0));
        }
    }

    public class Motherboard
    {
        public string Availability = "N/A";
		public string ErrorDescription = "N/A";
        public string Manufacturer = "N/A";
        public string Model = "N/A";
		public string ProductID = "N/A";
		public string SerialID = "N/A";
        public string Status = "N/A";
        public Int16 Temperature = 0;

        public Motherboard() { }
		public Motherboard(ManagementObject wmiBaseboard, ManagementObject wmiMotherboardDevice)
        {
            this.GetInfo(wmiBaseboard, wmiMotherboardDevice);
        }

		// This class requires 2 WMI classes for all data
		public void GetInfo(ManagementObject wmiBaseboard, ManagementObject wmiMotherboardDevice)
        {
            try
            {
				this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiMotherboardDevice, "Availability"));
				this.ErrorDescription = DataRetriever.GetValue(wmiMotherboardDevice, "ErrorDescription");
                this.Manufacturer = DataRetriever.GetValue(wmiBaseboard, "Manufacturer");
                this.Model = DataRetriever.GetValue(wmiBaseboard, "Model");
				this.ProductID = DataRetriever.GetValue(wmiBaseboard, "Product");
				this.SerialID = DataRetriever.GetValue(wmiBaseboard, "SerialNumber");
                this.Status = DataRetriever.GetValue(wmiBaseboard, "Status");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }

        public void GetVolatileInfo()
        {
            DataRetriever.RefreshSensors(HardwareType.Mainboard, 0);
            this.Temperature = Convert.ToInt16(DataRetriever.GetSensorValue(HardwareType.Mainboard, 0, SensorType.Temperature, 0));
        }
    }

    public class BIOS
    {
        public string Info = "N/A";
		public string SerialID = "N/A";
        public string Version = "N/A";

        public BIOS() { }
        public BIOS(ManagementObject wmiBIOS)
        {
            this.GetInfo(wmiBIOS);
        }

        public void GetInfo(ManagementObject wmiBIOS)
        {
            try
            {
                this.Info = DataRetriever.GetValue(wmiBIOS, "Description");
				this.SerialID = DataRetriever.GetValue(wmiBIOS, "SerialNumber");
                this.Version = DataRetriever.GetValue(wmiBIOS, "BIOSVersion");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }

    public class MemoryDevice
    {
        public string Availability = "N/A";
        public string Bank = "N/A";
        public UInt64 Capacity = 0;
		public string DeviceLocation = "N/A";
		public string ErrorDescription = "N/A";
        public string Manufacturer = "N/A";
        public string Model = "N/A";
        public UInt32 Speed = 0;
        public string Status = "N/A";

        public MemoryDevice() { }
        public MemoryDevice(ManagementObject wmiPhysicalMemory)
        {
            this.GetInfo(wmiPhysicalMemory);
        }

        public void GetInfo(ManagementObject wmiPhysicalMemory)
        {
            try
            {
                //this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiPhysicalMemory, "Availability"));
                this.Bank = DataRetriever.GetValue(wmiPhysicalMemory, "BankLabel");
                this.Capacity = DataRetriever.GetValueUInt64(wmiPhysicalMemory, "Capacity");
                // Convert to MB
                this.Capacity = this.Capacity / (1024 * 1024);
				this.DeviceLocation = DataRetriever.GetValue(wmiPhysicalMemory, "DeviceLocator");
				//this.ErrorDescription = DataRetriever.GetValue(wmiPhysicalMemory, "ErrorDescription");
                this.Manufacturer = DataRetriever.GetValue(wmiPhysicalMemory, "Manufacturer");
                this.Model = DataRetriever.GetValue(wmiPhysicalMemory, "Name");
                this.Speed = DataRetriever.GetValueUInt32(wmiPhysicalMemory, "Speed");
                this.Status = DataRetriever.GetValue(wmiPhysicalMemory, "Status");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }

    public class GraphicsAdapter
    {
        public string Architecture = "N/A";
        public string Availability = "N/A";
		public UInt32 BitsPerPixel = 0;
        public UInt32 CurrentClock = 0;
		public UInt32 CurrentRefresh = 0;
		public string DriverDate = "N/A";
		public string DriverVersion = "N/A";
		public string ErrorDescription = "N/A";
		public UInt32 HorizontalResolution = 0;
		public UInt32 MaxRefresh = 0;
		public UInt32 MemorySize = 0;
		public string MemoryType = "N/A";
		public UInt32 MinRefresh = 0;
        public string Name = "N/A";
        public string Status = "N/A";
        public Int16 Temperature = 0;
		public UInt32 VerticalResolution = 0;

        public GraphicsAdapter() { }
        public GraphicsAdapter(ManagementObject wmiVideoController)
        {
            this.GetInfo(wmiVideoController);
        }

        public void GetInfo(ManagementObject wmiVideoController)
        {
            try
            {
                this.Architecture = DataRetriever.ConvertVideoArchitecture(DataRetriever.GetValueUInt16(wmiVideoController, "VideoArchitecture"));
                this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiVideoController, "Availability"));
				this.BitsPerPixel = DataRetriever.GetValueUInt32(wmiVideoController, "CurrentBitsPerPixel");
				this.CurrentRefresh = DataRetriever.GetValueUInt32(wmiVideoController, "CurrentRefreshRate");
				this.DriverDate = DataRetriever.GetValueDateString(wmiVideoController, "DriverDate");
				this.DriverVersion = DataRetriever.GetValue(wmiVideoController, "DriverVersion");
				this.ErrorDescription = DataRetriever.GetValue(wmiVideoController, "ErrorDescription");
				this.HorizontalResolution = DataRetriever.GetValueUInt32(wmiVideoController, "CurrentHorizontalResolution");
				this.MaxRefresh = DataRetriever.GetValueUInt32(wmiVideoController, "MaxRefreshRate");
				this.MemorySize = DataRetriever.GetValueUInt32(wmiVideoController, "AdapterRAM");
                this.MemorySize = this.MemorySize / (1024 * 1024);
				this.MemoryType = DataRetriever.ConvertVideoArchitecture(DataRetriever.GetValueUInt16(wmiVideoController, "VideoMemoryType"));
				this.MinRefresh = DataRetriever.GetValueUInt32(wmiVideoController, "MinRefreshRate");
                this.Name = DataRetriever.GetValue(wmiVideoController, "Name");
                this.Status = DataRetriever.GetValue(wmiVideoController, "Status");
				this.VerticalResolution = DataRetriever.GetValueUInt32(wmiVideoController, "CurrentVerticalResolution");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }

        public void GetVolatileInfo()
        {
            // As GPUs are split between ATI and Nvidia, detect which is present first
            HardwareType hardwareType;
            if (this.Name.ToLower().Contains("nvidia"))
            {
                hardwareType = HardwareType.GpuNvidia;
            }
            else
            {
                hardwareType = HardwareType.GpuAti;
            }
            DataRetriever.RefreshSensors(hardwareType, 0);
            this.CurrentClock = Convert.ToUInt32(DataRetriever.GetSensorValue(hardwareType, 0, SensorType.Clock, 0));
            this.Temperature = Convert.ToInt16(DataRetriever.GetSensorValue(hardwareType, 0, SensorType.Temperature, 0));
        }
    }

	public class NetworkAdapter
	{
		public string AdapterType = "N/A";
		public string Availability = "N/A";
		public UInt16 ConnectionStatus = 0;
		public UInt64 CurrentSpeed = 0;
		public string ErrorDescription = "N/A";
		public string Manufacturer = "N/A";
		public string MACAddress = "N/A";
		public UInt64 MaxSpeed = 0;
		public string Name = "N/A";
		// This property isn't in the spec, but is useful for organising the order
		// of which adapters are shown. Real adapters at the top.
		public bool PhysicalAdapter = false;
        public string Status = "N/A";

		public NetworkAdapter() { }
		public NetworkAdapter(ManagementObject wmiNetworkAdapter)
		{
			this.GetInfo(wmiNetworkAdapter);
		}

		public void GetInfo(ManagementObject wmiNetworkAdapter)
		{
			try
			{
				this.AdapterType = DataRetriever.GetValue(wmiNetworkAdapter, "AdapterType");
				this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiNetworkAdapter, "Availability"));
				//this.ConnectionStatus = DataRetriever.GetValueUInt16(wmiNetworkAdapter, "NetConnectionStatus");
				//this.CurrentSpeed = DataRetriever.GetValueUInt64(wmiNetworkAdapter, "Speed");
				this.ErrorDescription = DataRetriever.GetValue(wmiNetworkAdapter, "ErrorDescription");
				this.Manufacturer = DataRetriever.GetValue(wmiNetworkAdapter, "Manufacturer");
				this.MACAddress = DataRetriever.GetValue(wmiNetworkAdapter, "MACAddress");
				//this.MaxSpeed = DataRetriever.GetValueUInt64(wmiNetworkAdapter, "MaxSpeed");
				this.Name = DataRetriever.GetValue(wmiNetworkAdapter, "Caption");
                this.PhysicalAdapter = DataRetriever.GetValueBool(wmiNetworkAdapter, "PhysicalAdapter");
                this.Status = DataRetriever.GetValue(wmiNetworkAdapter, "Status");
			}
			catch (Exception e)
			{
                ErrorDialogue errorReporter = new ErrorDialogue(e);
			}
		}
	}

    public class HardDrive
    {
        public string Availability = "N/A";
        public UInt64 Capacity = 0;
		public string ErrorDescription = "N/A";
        public string Manufacturer = "N/A";
        public string Model = "N/A";
        public UInt32 Partitions = 0;
        // Make SMART Data a property rather than a field so it doesn't get mixed in
        // with everything else when reporting data
        public HardDriveSMARTData SMARTData {get; set;}
        public string Status = "N/A";
        public Int16 Temperature = 0;

        public HardDrive() { }
		// Single parameter constructor
        public HardDrive(ManagementObject wmiDiskDrive, ManagementObject wmiATAPISmartData, ManagementObject wmiFailurePredictStatus)
        {
			// If SMART data is found, include it in the Hard Drive data
			if (wmiATAPISmartData != null)
			{
				SMARTData = new HardDriveSMARTData();
				this.SMARTData.GetInfo(wmiATAPISmartData);
			}
			this.GetInfo(wmiDiskDrive, wmiFailurePredictStatus);
        }

        public void GetInfo(ManagementObject wmiDiskDrive, ManagementObject wmiFailurePredictStatus)
        {
            try
            {
                //this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiDiskDrive, "Availability"));
                this.Capacity = DataRetriever.GetValueUInt64(wmiDiskDrive, "Size");
                // Convert to GB
                this.Capacity = this.Capacity / (1024 * 1024 * 1024);
				this.ErrorDescription = DataRetriever.GetValue(wmiDiskDrive, "ErrorDescription");
                this.Manufacturer = DataRetriever.GetValue(wmiDiskDrive, "Manufacturer");
                this.Model = DataRetriever.GetValue(wmiDiskDrive, "Name");
                this.Partitions = DataRetriever.GetValueUInt32(wmiDiskDrive, "Partitions");
                // Use WMI Failure Prediction as status if available, else use standard status
                if (wmiFailurePredictStatus != null)
                {
                    if (DataRetriever.GetValueBool(wmiFailurePredictStatus, "PredictFailure"))
                    {
                        this.Status = DataRetriever.GetValue(wmiFailurePredictStatus, "Reason");
                    }
                    else
                    {
                        this.Status = "OK";
                    }
                }
                else
                {
                    this.Status = DataRetriever.GetValue(wmiDiskDrive, "Status");
                }
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }

        public void GetVolatileInfo()
        {
            DataRetriever.RefreshSensors(HardwareType.HDD, 0);
            this.Temperature = Convert.ToInt16(DataRetriever.GetSensorValue(HardwareType.HDD, 0, SensorType.Temperature, 0));
        }
    }

	public class HardDriveSMARTData
	{
        public UInt16 ReadErrorRate = 0;
        public UInt16 ThroughputPerformance = 0;
        public UInt16 SpinUpTime = 0;
        public UInt16 StartStopCount = 0;
        public UInt16 ReallocatedSectorsCount = 0;
        public UInt16 ReadChannelMargin = 0;
        public UInt16 SeekErrorRate = 0;
        public UInt16 SeekTimePerformance = 0;
        public UInt16 PowerOnHoursPOH = 0;
        public UInt16 SpinRetryCount = 0;
        public UInt16 CalibrationRetryCount = 0;
        public UInt16 PowerCycleCount = 0;
        public UInt16 SoftReadErrorRate = 0;
        public UInt16 SATADownshiftErrorCount = 0;
        public UInt16 EndtoEnderror = 0;
        public UInt16 HeadStability = 0;
        public UInt16 InducedOpVibrationDetection = 0;
        public UInt16 ReportedUncorrectableErrors = 0;
        public UInt16 CommandTimeout = 0;
        public UInt16 HighFlyWrites = 0;
        public UInt16 AirflowTemperatureWDC = 0;
        public UInt16 TemperatureDifferencefrom100 = 0;
        public UInt16 GSenseErrorRate = 0;
        public UInt16 PoweroffRetractCount = 0;
        public UInt16 LoadCycleCount = 0;
        public UInt16 Temperature = 0;
        public UInt16 HardwareECCRecovered = 0;
        public UInt16 ReallocationEventCount = 0;
        public UInt16 CurrentPendingSectorCount = 0;
        public UInt16 UncorrectableSectorCount = 0;
        public UInt16 UltraDMACRCErrorCount = 0;
        public UInt16 MultiZoneErrorRate = 0;
        public UInt16 WriteErrorRateFujitsu = 0;
        public UInt16 OffTrackSoftReadErrorRate = 0;
        public UInt16 DataAddressMarkerrors = 0;
        public UInt16 RunOutCancel = 0;
        public UInt16 SoftECCCorrection = 0;
        public UInt16 ThermalAsperityRateTAR = 0;
        public UInt16 FlyingHeight = 0;
        public UInt16 SpinHighCurrent = 0;
        public UInt16 SpinBuzz = 0;
        public UInt16 OfflineSeekPerformance = 0;
        public UInt16 VibrationDuringWrite = 0;
        public UInt16 ShockDuringWrite = 0;
        public UInt16 DiskShift = 0;
        public UInt16 GSenseErrorRateAlt = 0;
        public UInt16 LoadedHours = 0;
        public UInt16 LoadUnloadRetryCount = 0;
        public UInt16 LoadFriction = 0;
        public UInt16 LoadUnloadCycleCount = 0;
        public UInt16 LoadInTime = 0;
        public UInt16 TorqueAmplificationCount = 0;
        public UInt16 PowerOffRetractCycle = 0;
        public UInt16 GMRHeadAmplitude = 0;
        public UInt16 DriveTemperature = 0;
        public UInt16 HeadFlyingHours = 0;
        public UInt16 TransferErrorRateFujitsu = 0;
        public UInt16 TotalLBAsWritten = 0;
        public UInt16 TotalLBAsRead = 0;
        public UInt16 ReadErrorRetryRate = 0;
        public UInt16 FreeFallProtection = 0;

		public HardDriveSMARTData() { }
        public HardDriveSMARTData(ManagementObject wmiATAPISmartData)
        {
			this.GetInfo(wmiATAPISmartData);
        }

		public void GetInfo(ManagementObject wmiATAPISmartData)
        {
            try
            {
                // Convert the Vendor Specific bytes into SMART Data

                byte[] vendorSpecific = DataRetriever.GetValueBytes(wmiATAPISmartData, "VendorSpecific");
                SMARTData data = new SMARTData(vendorSpecific);
                Int32 attributeData = 0;

                // Because the field names above are the same as those given by the SMARTData class,
                // we can loop through all the attributes in the SMART Data variable and add the data to
                // the class's fields using System Reflection methods.
                foreach (SMARTAttribute attribute in data.Attributes)
                {
                    // Convert vendor data byte array to integer
                    attributeData = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        // For each of the 6 bytes (not including the last two for flags), add the byte data multiplied by its offset
                        attributeData += Convert.ToInt32(attribute.VendorData[i]) * (i * 256);
                    }
                    this.GetType().GetField(Convert.ToString(attribute.AttributeType)).SetValue(this, Convert.ToUInt16(attribute.Value));
                }
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
	}

	public class OpticalDrive
	{
		public string Availability = "N/A";
		public string ErrorDescription = "N/A";
		public string Manufacturer = "N/A";
		public string MediaType = "N/A";
		public string Name = "N/A";
        public string Status = "N/A";
		public double TransferRate = 0;

		public OpticalDrive() { }
		public OpticalDrive(ManagementObject wmiCDROMDrive)
		{
			this.GetInfo(wmiCDROMDrive);
		}

		public void GetInfo(ManagementObject wmiCDROMDrive)
		{
			try
			{
                this.Availability = DataRetriever.ConvertAvailability(DataRetriever.GetValueUInt16(wmiCDROMDrive, "Availability"));
				this.ErrorDescription = DataRetriever.GetValue(wmiCDROMDrive, "ErrorDescription");
				this.Manufacturer = DataRetriever.GetValue(wmiCDROMDrive, "Manufacturer");
				this.MediaType = DataRetriever.GetValue(wmiCDROMDrive, "MediaType");
				this.Name = DataRetriever.GetValue(wmiCDROMDrive, "Name");
                this.Status = DataRetriever.GetValue(wmiCDROMDrive, "Status");
                this.TransferRate = DataRetriever.GetValueFloat(wmiCDROMDrive, "TransferRate");
			}
			catch (Exception e)
			{
                ErrorDialogue errorReporter = new ErrorDialogue(e);
			}
		}
	}

    public class PCICard
    {
        public string Manufacturer = "N/A";
        public string Model = "N/A";
		public string Slot = "N/A";
        public string Status = "N/A";
		public string Tag = "N/A";
        public string Usage = "N/A";

        public PCICard() { }
        public PCICard(ManagementObject wmiSystemSlot)
        {
            this.GetInfo(wmiSystemSlot);
        }

        public void GetInfo(ManagementObject wmiSystemSlot)
        {
            try
            {
                this.Manufacturer = DataRetriever.GetValue(wmiSystemSlot, "Manufacturer");
                this.Model = DataRetriever.GetValue(wmiSystemSlot, "Model");
				this.Slot = DataRetriever.GetValue(wmiSystemSlot, "SlotDesignation");
                this.Status = DataRetriever.GetValue(wmiSystemSlot, "Status");
				this.Tag = DataRetriever.GetValue(wmiSystemSlot, "Tag");
                //this.Usage = DataRetriever.GetValue(wmiSystemSlot, "Usage");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }

    public class USBDevice
    {
        public string Availability = "N/A";
        public string Description = "N/A";
		public string ErrorDescription = "N/A";
        public string Manufacturer = "N/A";
        public string Name = "N/A";
        public string Status = "N/A";

        public USBDevice() { }
        public USBDevice(ManagementObject wmiUSBEntity)
        {
            this.GetInfo(wmiUSBEntity);
        }

        public void GetInfo(ManagementObject wmiUSBEntity)
        {
            try
            {
                this.Availability = DataRetriever.GetValue(wmiUSBEntity, "Availability");
                this.Description = DataRetriever.GetValue(wmiUSBEntity, "Description");
                this.ErrorDescription = DataRetriever.GetValue(wmiUSBEntity, "ErrorDescription");
                this.Manufacturer = DataRetriever.GetValue(wmiUSBEntity, "Manufacturer");
                this.Name = DataRetriever.GetValue(wmiUSBEntity, "Name");
                this.Status = DataRetriever.GetValue(wmiUSBEntity, "Status");
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }
    }
}
