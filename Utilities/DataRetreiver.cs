using System;
using System.Collections.Generic;
using System.Management;
using OpenHardwareMonitor.Hardware;
using System.Text.RegularExpressions;

namespace CoreView
{
    public static class DataRetriever
    {
        /// <summary>
        /// Overloaded method for retrieving WMI Data. There are 3 modes of operation:
        ///     Retrieving ManagementObjects from a given class
        ///     Retrieving ManagementObjects from a class with a WQL WHERE statement
        ///     Retrieving ManagementObjects from a class with a WQL WHERE statement and a specified scope
        /// </summary>
        /// <param name="wmiClass">The class to retrieve (e.g. Win32_Processor)</param>
        /// <param name="whereClause">The WHERE statement to be appended (e.g. Speed=1600 AND Bank=A0)</param>
        /// <param name="scope">Declare a namespace/scope if CIMV2 is not the desired target. (e.g. WMI)</param>
        /// <returns>Array of matched ManagementObjects</returns>
        public static ManagementObject[] GetWMIData(string wmiClass) { return GetWMIData(wmiClass, "", "CIMV2"); }
        public static ManagementObject[] GetWMIData(string wmiClass, string whereClause) { return GetWMIData(wmiClass, whereClause, "CIMV2"); }
        public static ManagementObject[] GetWMIData(string wmiClass, string whereClause, string scope)
        {
			try
			{
				// If a where clause has been set, prepare the clause to add to the query string
				if (whereClause != "")
				{
					whereClause = " WHERE " + whereClause;
				}
				// Create a search query
				string query = "SELECT * FROM " + wmiClass + whereClause;
				ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher("root\\" + scope, query);
				ManagementObjectCollection matches = wmiSearcher.Get();

				// Create an array to hold the matches
				ManagementObject[] matchArray = new ManagementObject[matches.Count];

                // If matches found, copy to output
                if (matches.Count > 0)
                {
                    // Copy the search matches into this array
                    matches.CopyTo(matchArray, 0);
                }
                else
                {
                    // Return a single, null element if nothing is found
                    matchArray = new ManagementObject[1] { null };
                }

                // Return array
				return matchArray;
			}
			catch (Exception e)
			{
				ErrorDialogue errorReporter = new ErrorDialogue(e);
				return null;
			}
        }

		/// <summary>
		/// Method to specifically retrieve PnP information using a Dependent ID
		/// Uses the GetWMIData method for its interrogation.
		/// </summary>
		/// <param name="dependentID">The Dependent ID of the device</param>
		/// <returns>ManagementObject containing the Win32_PNPEntity data about the device</returns>
        public static ManagementObject GetPnPEntity(string dependentID)
        {
            string whereClause = "DeviceID = ";
            
            // Format the Dependent ID to remove any leading/trailing formatting
            // to expose the real ID
            // Remove double quotes
            dependentID = dependentID.Replace("\"", "");
            // Chop the string at the equals sign and take the last part
            dependentID = dependentID.Split(new char[] {'='})[1];

            // Append the new Device ID to the where clause
            whereClause += "'" + dependentID + "'";

            // Run a data query and return the only value in the array
            return GetWMIData("Win32_PnPEntity", whereClause)[0];
        }

		/// <summary>
		/// Method to specifically retrieve associate data in the case where 2 classes
		/// rely on referencing each other to get the full picture
		/// This uses its own WMI query structure
		/// Thanks to http://stackoverflow.com/questions/9787892/wmi-hardware-addresses-and-irqs
		/// Optional scope overload. If no scope specified, then the ManagementSearcher will get associates from any namespace.
		/// </summary>
		/// <param name="class1">The class to derive the information from</param>
		/// <param name="class2">The associated class to find</param>
		/// <param name="attribute">The attribute from the first class to be referenced</param>
		/// <param name="value">The value of the attribute</param>
		/// <param name="scope">The scope to look in (optional if looking through any scope)</param>
		/// <returns>Array of ManagementObjects</returns>
        public static ManagementObject[] GetWMIAssociates(string class1, string class2, string attribute, string value) { return GetWMIAssociates(class1, class2, attribute, value, ""); }
        public static ManagementObject[] GetWMIAssociates(string class1, string class2, string attribute, string value, string scope)
        {
            try
            {
                // Create a search query
                string query = "ASSOCIATORS OF {" + class1 + "." + attribute + "='" + value + "'} "
                    + "WHERE RESULTCLASS = " + class2;
                ManagementObjectSearcher wmiSearcher;
                if (scope != "")
                {
                    // Scoped search
                    wmiSearcher = new ManagementObjectSearcher("root\\" + scope, query);
                }
                else
                {
                    // Unscoped search
                    wmiSearcher = new ManagementObjectSearcher(query);
                }
                ManagementObjectCollection matches = wmiSearcher.Get();

                // Create output array
                ManagementObject[] matchArray = new ManagementObject[matches.Count];

                // If matches found, copy to output
                if (matches.Count > 0)
                {
                    // Copy the search matches into this array
                    matches.CopyTo(matchArray, 0);
                }
                else
                {
                    // Return a single, null element if nothing is found
                    matchArray = new ManagementObject[1] { null };
                }

                return matchArray;
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
                return null;
            }
        }

        /// <summary>
        /// Method to specifically retrieve reference data in the case where 2 classes
        /// rely on referencing each other to get the full picture
        /// This uses its own WMI query structure
        /// Thanks to http://stackoverflow.com/questions/9787892/wmi-hardware-addresses-and-irqs
        /// Optional scope overload. If no scope specified, then the ManagementSearcher will get references from any namespace.
        /// </summary>
        /// <param name="class1">The class to derive the information from</param>
        /// <param name="class2">The referenced class to find</param>
        /// <param name="attribute">The attribute from the first class to be associated</param>
        /// <param name="value">The value of the attribute</param>
        /// <param name="scope">The scope to look in (optional if looking through any scope)</param>
        /// <returns>Array of ManagementObjects</returns>
        public static ManagementObject[] GetWMIReferences(string class1, string class2, string attribute, string value) { return GetWMIAssociates(class1, class2, attribute, value, ""); }
        public static ManagementObject[] GetWMIReferences(string class1, string class2, string attribute, string value, string scope)
        {
            try
            {
                // Create a search query
                string query = "REFERENCES OF {" + class1 + "." + attribute + "='" + value + "'} "
                    + "WHERE RESULTCLASS = " + class2;
                ManagementObjectSearcher wmiSearcher;
                if (scope != "")
                {
                    // Scoped search
                    wmiSearcher = new ManagementObjectSearcher("root\\" + scope, query);
                }
                else
                {
                    // Unscoped search
                    wmiSearcher = new ManagementObjectSearcher(query);
                }
                ManagementObjectCollection matches = wmiSearcher.Get();

                // Create output array
                ManagementObject[] matchArray = new ManagementObject[matches.Count];

                // If matches found, copy to output
                if (matches.Count > 0)
                {
                    // Copy the search matches into this array
                    matches.CopyTo(matchArray, 0);
                }
                else
                {
                    // Return a single, null element if nothing is found
                    matchArray = new ManagementObject[1] { null };
                }

                return matchArray;
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
                return null;
            }
        }

        
        public static Computer ComputerSensors = new Computer();
		/// <summary>
		/// Method for obtaining sensor information using OpenHardwareMonitorLib
		/// Courtesy of http://openhardwaremonitor.org/
		/// </summary>
        /// <param name="hardwareType">The HardwareType of the desired device</param>
        /// <param name="hardwareInstance">The instance number of the desired device</param>
        /// <param name="sensorType">The SensorType of the desired sensor</param>
        /// <param name="sensorInstance">The instance number of the desired sensor</param>
		/// <returns>The value of the sensor</returns>
        public static float GetSensorValue(HardwareType hardwareType, int hardwareInstance, SensorType sensorType, int sensorInstance)
        {
            float result = 0;
            try
            {
                // Loop through hardware to find the one required
                foreach (IHardware hardwareElement in ComputerSensors.Hardware)
                {
                    // If the hardware element's type is what we're looking for
                    if (hardwareElement.HardwareType == hardwareType)
                    {
                        // And the instance is the same (/intelcpu/0 <= Check this number)
                        if (hardwareElement.Identifier.ToString().EndsWith(hardwareInstance.ToString()))
                        {
                            // Then start looping the sensors
                            foreach (ISensor sensor in hardwareElement.Sensors)
                            {
                                // If the sensor's type is what we're looking for
                                if (sensor.SensorType == sensorType)
                                {
                                    // And the instance is the same (/intelcpu/0/temperature/0 <= Check this number)
                                    if (sensor.Identifier.ToString().EndsWith(sensorInstance.ToString()))
                                    {
                                        // Get value and return it, skipping all the other elements
                                        result = (float)sensor.Value;
                                        return result;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            return result;
        }

        /// <summary>
        /// Refresh sensors of a hardware device
        /// </summary>
        /// <param name="hardwareType">The HardwareType of the desired device</param>
        /// <param name="hardwareInstance">The instance number of the desired device</param>
        public static void RefreshSensors(HardwareType hardwareType, int hardwareInstance)
        {
            // First make sure HDD checking is enabled
            if (hardwareType == HardwareType.HDD && !ComputerSensors.HDDEnabled)
            {
                ComputerSensors.HDDEnabled = true;
            }
            foreach (IHardware hardwareElement in ComputerSensors.Hardware)
            {
                if (hardwareElement.HardwareType == hardwareType)
                {
                    if (hardwareElement.Identifier.ToString().EndsWith(hardwareInstance.ToString()))
                    {
                        hardwareElement.Update();
                    }
                }
            }
        }

        // Properties and assignments to convert Architecture, Availability and other such properties to strings
        // References found at http://msdn.microsoft.com/en-us/library/windows/desktop/aa394512(v=vs.85).aspx
        // And http://msdn.microsoft.com/en-us/library/windows/desktop/aa394512(v=vs.85).aspx

        private static Dictionary<UInt16, string> ArchitectureRef = new Dictionary<UInt16, string>
        {
            {0, "x86"},
            {1, "MIPS"},
            {2, "Alpha"},
            {3, "PowerPC"},
            {6, "Itanium-based System"},
            {9, "x64"}
        };

        private static Dictionary<UInt16, string> AvailabilityRef = new Dictionary<UInt16, string>
        {
            {1, "Other"},
            {2, "Unknown"},
            {3, "Running on Full Power"},
            {4, "Warning"},
            {5, "In Test"},
            {6, "Not Applicable"},
            {7, "Power Off"},
            {8, "Off Line"},
            {9, "Off Duty"},
            {10, "Degraded"},
            {11, "Not Installed"},
            {12, "Install Error"},
            {13, "Power Save - Unknown"},
            {14, "Power Save - Low Power Mode"},
            {15, "Power Save - Standby"},
            {16, "Power Cycle"},
            {17, "Power Save - Warning"}
        };

		private static Dictionary<UInt16, string> EventTypeRef = new Dictionary<UInt16, string>
        {
            {1, "Error"},
            {2, "Warning"},
            {3, "Information"},
            {4, "Security Audit Success"},
            {5, "Security Audit Failure"},
        };

        private static Dictionary<UInt16, string> FamilyRef = new Dictionary<UInt16, string>
        {
            {1, "Other"},
            {2, "Unknown"},
            {3, "8086"},
            {4, "80286"},
            {5, "Intel386™ Processor"},
            {6, "Intel486™ Processor"},
            {7, "8087"},
            {8, "80287"},
            {9, "80387"},
            {10, "80487"},
            {11, "Pentium Brand"},
            {12, "Pentium Pro"},
            {13, "Pentium II"},
            {14, "Pentium Processor with MMX™ Technology"},
            {15, "Celeron™"},
            {16, "Pentium II Xeon™"},
            {17, "Pentium III"},
            {18, "M1 Family"},
            {19, "M2 Family"},
            {24, "AMD Duron™ Processor Family"},
            {25, "K5 Family"},
            {26, "K6 Family"},
            {27, "K6-2"},
            {28, "K6-3"},
            {29, "AMD Athlon™ Processor Family"},
            {30, "AMD2900 Family"},
            {31, "K6-2+"},
            {32, "Power PC Family"},
            {33, "Power PC 601"},
            {34, "Power PC 603"},
            {35, "Power PC 603+"},
            {36, "Power PC 604"},
            {37, "Power PC 620"},
            {38, "Power PC X704"},
            {39, "Power PC 750"},
            {48, "Alpha Family"},
            {49, "Alpha 21064"},
            {50, "Alpha 21066"},
            {51, "Alpha 21164"},
            {52, "Alpha 21164PC"},
            {53, "Alpha 21164a"},
            {54, "Alpha 21264"},
            {55, "Alpha 21364"},
            {64, "MIPS Family"},
            {65, "MIPS R4000"},
            {66, "MIPS R4200"},
            {67, "MIPS R4400"},
            {68, "MIPS R4600"},
            {69, "MIPS R10000"},
            {80, "SPARC Family"},
            {81, "SuperSPARC"},
            {82, "microSPARC II"},
            {83, "microSPARC IIep"},
            {84, "UltraSPARC"},
            {85, "UltraSPARC II"},
            {86, "UltraSPARC IIi"},
            {87, "UltraSPARC III"},
            {88, "UltraSPARC IIIi"},
            {96, "68040"},
            {97, "68xxx Family"},
            {98, "68000"},
            {99, "68010"},
            {100, "68020"},
            {101, "68030"},
            {112, "Hobbit Family"},
            {120, "Crusoe™ TM5000 Family"},
            {121, "Crusoe™ TM3000 Family"},
            {122, "Efficeon™ TM8000 Family"},
            {128, "Weitek"},
            {130, "Itanium™ Processor"},
            {131, "AMD Athlon™ 64 Processor Famiily"},
            {132, "AMD Opteron™ Processor Family"},
            {144, "PA-RISC Family"},
            {145, "PA-RISC 8500"},
            {146, "PA-RISC 8000"},
            {147, "PA-RISC 7300LC"},
            {148, "PA-RISC 7200"},
            {149, "PA-RISC 7100LC"},
            {150, "PA-RISC 7100"},
            {160, "V30 Family"},
            {176, "Pentium III Xeon™ Processor"},
            {177, "Pentium III Processor with Intel SpeedStep™ Technology"},
            {178, "Pentium 4"},
            {179, "Intel Xeon™"},
            {180, "AS400 Family"},
            {181, "Intel Xeon™ Processor MP"},
            {182, "AMD Athlon™ XP Family"},
            {183, "AMD Athlon™ MP Family"},
            {184, "Intel Itanium 2"},
            {185, "Intel Pentium M Processor"},
            {190, "K7"},
            {200, "IBM390 Family"},
            {201, "G4"},
            {202, "G5"},
            {203, "G6"},
            {204, "z/Architecture Base"},
            {250, "i860"},
            {251, "i960"},
            {260, "SH-3"},
            {261, "SH-4"},
            {280, "ARM"},
            {281, "StrongARM"},
            {300, "6x86"},
            {301, "MediaGX"},
            {302, "MII"},
            {320, "WinChip"},
            {350, "DSP"},
            {500, "Video Processor"}
        };

        private static Dictionary<UInt16, string> VideoArchitectureRef = new Dictionary<UInt16, string>
        {
            {1, "Other"},
            {2, "Unknown"},
            {3, "CGA"},
            {4, "EGA"},
            {5, "VGA"},
            {6, "SVGA"},
            {7, "MDA"},
            {8, "HGC"},
            {9, "MCGA"},
            {10, "8514A"},
            {11, "XGA"},
            {12, "Linear Frame Buffer"},
            {160, "PC-98"}
        };

        private static Dictionary<UInt16, string> VideoMemoryTypeRef = new Dictionary<UInt16, string>
        {
            {1, "Other"},
            {2, "Unknown"},
            {3, "VRAM"},
            {4, "DRAM"},
            {5, "SRAM"},
            {6, "WRAM"},
            {7, "EDO RAM"},
            {8, "Burst Synchronous DRAM"},
            {9, "Pipelined Burst SRAM"},
            {10, "CDRAM"},
            {11, "3DRAM"},
            {12, "SDRAM"},
            {160, "SGRAM"}
        };

        private static Dictionary<UInt16, string> VoltageRef = new Dictionary<UInt16, string>
        {
            {0, "Unknown"},
            {1, "Other"},
            {2, "3.3v"},
            {3, "5v"},
            {4, "12v"}
        };

        // Functions to make references to the above dictionaries
        // These are required because without them it becomes messy to do try/catch
        public static string ConvertArchitecture(UInt16 architectureCode)
        {
			try
			{
				return ArchitectureRef[architectureCode];
			}
			catch
			{
				// If the value return failed, then no dictionary entry exists
				// In which case, return N/A
				return "N/A";
			}
        }

        public static string ConvertAvailability(UInt16 availabilityCode)
        {
			try
			{
				return AvailabilityRef[availabilityCode];
			}
			catch
			{
                return AvailabilityRef[1];
			}
        }

        public static string ConvertEventType(UInt16 eventCode)
        {
            try
            {
                return EventTypeRef[eventCode];
            }
            catch
            {
                return "N/A";
            }
        }

        public static string ConvertFamily(UInt16 familyCode)
        {
			try
			{
				return FamilyRef[familyCode];
			}
			catch
			{
                return FamilyRef[1];
			}
        }

        public static string ConvertVideoArchitecture(UInt16 architectureCode)
        {
			try
			{
				return VideoArchitectureRef[architectureCode];
			}
			catch
			{
                return VideoArchitectureRef[1];
			}
        }

        public static string ConvertVideoMemoryType(UInt16 memoryCode)
        {
			try
			{
				return VideoMemoryTypeRef[memoryCode];
			}
			catch
			{
                return VideoMemoryTypeRef[1];
			}
        }

        public static string ConvertVoltage(UInt16 voltageCode)
        {
            try
            {
                return VoltageRef[voltageCode];
            }
            catch
            {
                return "N/A";
            }
        }

        public static Dictionary<string, string> ConvertSMARTData(byte[] vendorSpecificCode)
        {
            Dictionary<string, string> SMARTData = new Dictionary<string, string>();
            return SMARTData;
        }

        // Main GetValue function - Converts the given Management data to a string
        // Handles errors in this process
        public static string GetValue(ManagementObject managementObject, string field)
        {
            try
            {
                return Convert.ToString(managementObject[field]);
            }
            catch(Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
                return "0";
            }
        }
        // Wrappers for alternative data types
        public static UInt16 GetValueUInt16(ManagementObject m, string f)
        {
            try
            {
                return Convert.ToUInt16(GetValue(m, f));
            }
            catch (FormatException)
            {
                // If there was a problem with the input format
                // return 0 and don't complain
                return 0;
            }
            catch (OverflowException)
            {
                // Same for if the value falls outside the acceptable bounds of the container
                return 0;
            }
        }
        public static UInt32 GetValueUInt32(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToUInt32(GetValue(m, f));
			}
			catch (FormatException)
			{
				return 0;
			}
            catch (OverflowException)
            {
                return 0;
            }
        }
        public static UInt64 GetValueUInt64(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToUInt64(GetValue(m, f));
			}
			catch (FormatException)
			{
				return 0;
			}
            catch (OverflowException)
            {
                return 0;
            }
        }
        public static Int16 GetValueInt16(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToInt16(GetValue(m, f));
			}
			catch (FormatException)
			{
				return 0;
			}
            catch (OverflowException)
            {
                return 0;
            }
        }
        public static Int32 GetValueInt32(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToInt32(GetValue(m, f));
			}
			catch (FormatException)
			{
				return 0;
			}
            catch (OverflowException)
            {
                return 0;
            }
        }
        public static Int64 GetValueInt64(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToInt64(GetValue(m, f));
			}
			catch (FormatException)
			{
				return 0;
			}
            catch (OverflowException)
            {
                return 0;
            }
        }
        public static double GetValueFloat(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToDouble(GetValue(m, f));
			}
			catch (FormatException)
			{
				return 0;
			}
            catch (OverflowException)
            {
                return 0;
            }
        }
        public static bool GetValueBool(ManagementObject m, string f)
        {
			try
			{
				return Convert.ToBoolean(GetValue(m, f));
			}
			catch (FormatException)
			{
				return false;
			}
        }
        public static string GetValueDateString(ManagementObject m, string f)
        {
            try
            {
                // Use Regex to read the date in chunks of 2 or 4 and restructure them into dd/mm/yyyy hh:mm:ss
                string date = Convert.ToString(GetValue(m, f));
                string pattern = @"(\d{4})(\d{2})(\d{2})((\d{2})(\d{2})(\d{2}))?[\d\+\.\*\-]*";
                string replacement = @"$3/$2/$1 $5:$6:$7";
                string formattedDate = Regex.Replace(date, pattern, replacement);

                // If no time was found, remove it
                formattedDate = formattedDate.Replace(" ::", "");
                formattedDate = formattedDate.Replace(" 00:00:00", "");

                return formattedDate;
            }
            catch (FormatException)
            {
                return "N/A";
            }
        }

        public static byte[] GetValueBytes(ManagementObject managementObject, string field)
        {
            try
            {
                return (byte[])managementObject[field];
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
                errorReporter.ShowDialog();
                return null;
            }
        }

        public static string[] GetValueArray(ManagementObject managementObject, string field)
        {
            try
            {
                return (string[])managementObject[field];
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
                errorReporter.ShowDialog();
                return null;
            }
        }

        public static UInt16[] GetValueUInt16Array(ManagementObject managementObject, string field)
        {
            try
            {
                return (UInt16[])managementObject[field];
            }
            catch (Exception e)
            {
                ErrorDialogue errorReporter = new ErrorDialogue(e);
                errorReporter.ShowDialog();
                return null;
            }
        }
    }
}
