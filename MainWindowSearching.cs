using System;
using System.Windows.Forms;

namespace CoreView
{
	public partial class MainWindow
	{
        /// <summary>
        /// General function to search any list view form. Highlights rows with matches.
        /// </summary>
        /// <param name="needle">String to search for</param>
        /// <param name="haystack">ListView object to search in</param>
        private void searchList(string needle, ListView haystack)
        {
            // Focus the list view
            haystack.Focus();
            // Clear currently selected items
            haystack.SelectedItems.Clear();
            int i = 0;
            ListViewItem found;
            do
            {
                // Recursively find all instances of the given text, starting from zero
                found = haystack.FindItemWithText(needle, true, i, true);
                if (found != null)
                {
                    // Select found item
                    found.Selected = true;
                    // Next search starts from the next element in the list view
                    i = found.Index + 1;
                }
                else
                {
                    // Otherwise, stop
                    i = haystack.Items.Count;
                }
            } while (i < haystack.Items.Count);
        }

        private void drivers_search_btn_Click(object sender, EventArgs e)
        {
            searchList(driver_search.Text, driver_details);
        }

        private void software_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(software_search.Text, software_details);
        }

        private void irqsharing_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(irqsharing_search.Text, irqsharing_details);
        }

        private void addresses_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(addresses_search.Text, addresses_details);
        }

        private void irqs_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(irqs_search.Text, irqs_details);
        }

        private void processes_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(processes_search.Text, processes_details);
        }

        private void logs_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(logs_search.Text, logs_details);
        }

        private void database_search_btn_Click(object sender, System.EventArgs e)
        {
            searchList(database_search.Text, database_details);
        }
	}
}
