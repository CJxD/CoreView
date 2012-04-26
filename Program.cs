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
            // Write dependencies to disk
            // OpenHardwareMonitor is simply written to disk if not present
            if (!File.Exists("OpenHardwareMonitorLib.dll"))
            {
                WriteFile("OpenHardwareMonitorLib.dll", Properties.Resources.lib_hardware_monitor);
            }

            // An attempt to load SQLite, and if it fails, then write out the correct 
            string architecture = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            try
            {
                Assembly.LoadFrom("System.Data.SQLite.dll");
            }
            catch (Exception e)
            {
                // If the file was not found, or it was in the wrong architecture, then write the appropriate file
                if (e is BadImageFormatException || e is FileNotFoundException)
                {
                    if (architecture == "AMD64")
                    {
                        // 64 bit
                        WriteFile("System.Data.SQLite.dll", Properties.Resources.lib_sqlite_x64);
                    }
                    else
                    {
                        // 32 bit
                        WriteFile("System.Data.SQLite.dll", Properties.Resources.lib_sqlite_x86);
                    }
                }
                else
                {
                    throw;
                }
            }

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

        // A function to write files and provide an error if it doesn't go to plan
        private static void WriteFile(string path, byte[] bytes)
        {
            try
            {
                File.WriteAllBytes(path, bytes);
            }
            catch (Exception e)
            {
                if (e is IOException || e is UnauthorizedAccessException)
                {
                    // Error dialogue allowing abort, retry and ignore
                    DialogResult result = MessageBox.Show(
                        "One of the required dependencies for Core View couldn't be loaded. "
                        + "Please make sure the storage medium isn't write protected and dependency files are not in use.",
                        "Unable to load dependency files",
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
                            WriteFile(path, bytes);
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
