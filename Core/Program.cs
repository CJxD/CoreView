using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CoreView
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Load OpenHardwareMonitorLib
            loadAssemblyFromBytes(Properties.Resources.lib_hardware_monitor);

            // Load sqlite3 with correct architecture
            string architecture = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            if (architecture == "AMD64")
            {
                // 64 bit
                loadAssemblyFromBytes(Properties.Resources.lib_sqlite_x64);
            }
            else
            {
                // 32 bit
                loadAssemblyFromBytes(Properties.Resources.lib_sqlite_x86);
            }
            // Load sqlite wrapper
            loadAssemblyFromBytes(Properties.Resources.lib_sqlite_wrapper);

            // Run the program
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }
            catch (Exception e)
            {
                // Fatal unhandled error - report gracefully
                ErrorDialogue errorReporter = new ErrorDialogue(e);
            }
        }

        private static void loadAssemblyFromBytes(Byte[] resource)
        {
            try
            {
                Assembly.Load(resource);
            }
            catch (Exception e)
            {
                if (e is BadImageFormatException)
                {
                    // Error dialogue allowing abort, retry and ignore
                    DialogResult result = MessageBox.Show(
                        "One of the required dependencies for Core View couldn't be loaded. "
                        + "Your system may not be compatible."
                        + Environment.NewLine
                        + Environment.NewLine
                        + "If running as a 32-bit application on a 64-bit machine, please try removing the 32-bit constraint. Otherwise, try running in 32-bit mode. If this problem persists, please contact the development project at http://github.com/CJxD/CoreView",
                        "Dependency Load Failure",
                        MessageBoxButtons.AbortRetryIgnore,
                        MessageBoxIcon.Error
                    );

                    // Exit with error code 1 if aborted, retry this function if retry selected
                    switch (result)
                    {
                        case DialogResult.Abort:
                            Environment.Exit(1);
                            break;
                        case DialogResult.Retry:
                            loadAssemblyFromBytes(resource);
                            break;
                    }
                }
                else
                {
                    // Fatal error - report gracefully
                    ErrorDialogue errorReporter = new ErrorDialogue(e);
                }
            }
        }
    }
}
