using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoreView
{
    public partial class Splash : Form
    {
        // Percentage for progress bar
        private static int ProgressPercentage = 0;
        private static int TargetPercentage = 0;

        // Splash screen status message
        private static string StatusMessage = "";

		// Property to get the current progress percentage
		public static int Progress
		{
			get
			{
				return ProgressPercentage;
			}
		}
		// Property to get the current status message
		public static string Status
		{
			get
			{
				return StatusMessage;
			}
		}

        public Splash()
        {
            InitializeComponent();
        }

        public static void AddProgressInfo(string status, int percentageToIncrease)
        {
            // Adds a percentage target and status message to show
            // Copy over current target as base
            ProgressPercentage = TargetPercentage;
            // The new target percentage is the current percentage plus the percentage increase
            TargetPercentage += percentageToIncrease;
            // Copy status over
            StatusMessage = status;

            // Make sure neither are above 100
            if (ProgressPercentage > 100) ProgressPercentage = 100;
            if (TargetPercentage > 100) TargetPercentage = 100;
        }

        public static void RestartProgress()
        {
            ProgressPercentage = 0;
            TargetPercentage = 0;
        }

        private void splash_poller_Tick(object sender, EventArgs e)
        {
            // Set the bar status if the current percentage is lower than the given one
            if (this.splash_progress.Value < ProgressPercentage) this.splash_progress.Value = ProgressPercentage;

            // Trick to make the bar move even if the program is hanging
            // Makes it look like something is happening by increasing slowly from
            // the base percentage to the target percentage
            if (this.splash_progress.Value < TargetPercentage)
            {
                this.splash_progress.Value++;
            }

            // Show status message
            this.splash_status.Text = StatusMessage;
            // Close if 100% is reached
            if (ProgressPercentage == 100)
            {
                this.Close();
            }
        }

        // Form drag handler
        Point mousePoint = Point.Empty;
        private void Splash_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Splash_MouseUp(object sender, MouseEventArgs e)
        {
            mousePoint = Point.Empty;
        }

        private void Splash_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousePoint.IsEmpty)
            {
                this.Location = new Point(this.Location.X + (e.X - mousePoint.X), this.Location.Y + (e.Y - mousePoint.Y));
            }
        }

        private void skip_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}