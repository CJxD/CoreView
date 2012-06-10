namespace CoreView
{
    public static class ClassList
    {
        // A simple global storage for classes shown in the database (not every single class)
        // This helps loops through computer classes with tidier code

        // The list
        private static string[] classes = new string[]
        {
            "Processor",
            "Motherboard",
            "BIOS",
            "MemoryDevice",
            "GraphicsAdapter",
            "NetworkAdapter",
            "HardDrive",
            "OpticalDrive",
            "PCICard",
            "USBDevice",
            "Driver",
            "Software",
            "Conflict",
            "Process",
            "Log"
        };
        // The accessible properties
        public static string[] DatabaseClasses
        {
            get { return classes; }
        }
        public static string[] HardwareClasses
        {
            get
            {
                // Send elements 0 to 9
                string[] returnArray = new string[10];
                for (int i = 0; i < 10; i++) returnArray[i] = DatabaseClasses[i];
                return returnArray;
            }
        }
        public static string[] SoftwareClasses
        {
            get
            {
                // Send elements 10 to 14
                string[] returnArray = new string[5];
                for (int i = 10; i < 15; i++) returnArray[i - 10] = DatabaseClasses[i];
                return returnArray;
            }
        }
    }
}
