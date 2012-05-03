using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoreView
{
    public partial class MainWindow
    {
        // Shortcut to prepare a list for sorting
        private void sortListView(ListView list, int column, Sorting.Order order)
        {
            // Copy the list view items into an array
            ListViewItem[] items = new ListViewItem[list.Items.Count];
            list.Items.CopyTo(items, 0);

            Sorting.QuickSort(items, order, new ListViewComparer(column));
            // Copy the sorted list back into the details box
            list.Items.Clear();
            list.Items.AddRange(items);
        }

        private void driver_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(driver_details, e.Column, Sorting.Order.Ascending);
        }

        private void software_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(software_details, e.Column, Sorting.Order.Ascending);
        }

        private void irqsharing_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(irqsharing_details, e.Column, Sorting.Order.Ascending);
        }

        private void addresses_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(addresses_details, e.Column, Sorting.Order.Ascending);
        }

        private void irqs_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(irqs_details, e.Column, Sorting.Order.Ascending);
        }

        private void processes_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(processes_details, e.Column, Sorting.Order.Ascending);
        }

        private void logs_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(logs_details, e.Column, Sorting.Order.Ascending);
        }

        private void database_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            sortListView(database_details, e.Column, Sorting.Order.Descending);
        }
    }

    // Class for comparing list view objects
    public class ListViewComparer : Comparer<ListViewItem>
    {
        private int listViewColumn = 0;

        // Constructor to store the column number to be read
        public ListViewComparer(int ListViewColumn)
        {
            this.listViewColumn = ListViewColumn;
        }

        public override int Compare(ListViewItem aRow, ListViewItem bRow)
        {
            string aItem = aRow.SubItems[listViewColumn].Text;
            string bItem = bRow.SubItems[listViewColumn].Text;

            // If the item is a date in the form dd/mm/yyyy, then return a date comparison
            DateTime aDate, bDate;
            if (DateTime.TryParse(aItem, out aDate) && DateTime.TryParse(bItem, out bDate))
            {
                return aDate.CompareTo(bDate);
            }
            else
            {
                // Using Vasian Cepa's code for logical string comparing, more useful results are obtained
                return StringLogicalComparer.Compare(aItem, bItem);
            }
        }
    }
}
