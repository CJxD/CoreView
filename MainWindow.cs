using System.Threading;
using System.Windows.Forms;
using System;

namespace CoreView
{
	public partial class MainWindow : Form
	{
        // Main data container
		public PC currentComputer = new PC();
        private PC storedComputer = new PC();

        // Data retrieval threads
        Thread dataGet;

        public MainWindow()
        {
            // Get configuration
            Configuration.GetConfig();

            // Open OpenHardwareMonitor to start reading data
            DataRetriever.ComputerSensors.Open();

            // If ShowSplash is set, run the splash screen and get data sequentially
            if (Configuration.LoadWMIAtStart)
            {
                dataGet = new Thread(new ThreadStart(currentComputer.GetAllInfo));
                dataGet.Start();
                if (Configuration.ShowSplash)
                {
                    Application.Run(new Splash());
                }
            }
            else if (Configuration.LoadHardwareAtStart)
            {
                dataGet = new Thread(new ThreadStart(currentComputer.GetHardwareInfo));
                dataGet.Start();
                while (dataGet.IsAlive)
                {
                    // Do nothing!
                }
                currentComputer.GetGeneral();
            }
            else
            {
                // If no data is to be retrieved at start up, get at least the General Info
                currentComputer.GetGeneral();
            }

            // Show main form
            InitializeComponent();
            Show();

            // Initialise graphs
            this.createGraphs();

            // Populate the form with data
            this.populateForm();

            // Start the database
			if (!Database.Initialise())
			{
				// If not successful, disable database functionality
				tab_database.Hide();
			}
        }
	}
}
