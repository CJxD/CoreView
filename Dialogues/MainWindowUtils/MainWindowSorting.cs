using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoreView
{
    public partial class MainWindow
    {
        ListViewSorter driverSorter;
        ListViewSorter softwareSorter;
        ListViewSorter irqsharingSorter;
        ListViewSorter addressesSorter;
        ListViewSorter irqsSorter;
        ListViewSorter processesSorter;
        ListViewSorter logsSorter;
        ListViewSorter databaseSorter;

        private void driver_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (driverSorter == null)
            {
                driverSorter = new ListViewSorter(driver_details);
            }
            driverSorter.Sort(e.Column);
        }

        private void software_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (softwareSorter == null)
            {
                softwareSorter = new ListViewSorter(software_details);
            }
            softwareSorter.Sort(e.Column);
        }

        private void irqsharing_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (irqsharingSorter == null)
            {
                irqsharingSorter = new ListViewSorter(irqsharing_details);
            }
            irqsharingSorter.Sort(e.Column);
        }

        private void addresses_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (addressesSorter == null)
            {
                addressesSorter = new ListViewSorter(addresses_details);
            }
            addressesSorter.Sort(e.Column);
        }

        private void irqs_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (irqsSorter == null)
            {
                irqsSorter = new ListViewSorter(irqs_details);
            }
            irqsSorter.Sort(e.Column);
        }

        private void processes_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (processesSorter == null)
            {
                processesSorter = new ListViewSorter(processes_details);
            }
            processesSorter.Sort(e.Column);
        }

        private void logs_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (logsSorter == null)
            {
                logsSorter = new ListViewSorter(logs_details);
            }
            logsSorter.Sort(e.Column);
        }

        private void database_details_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (databaseSorter == null)
            {
                databaseSorter = new ListViewSorter(database_details);
            }
            databaseSorter.Sort(e.Column);
        }
    }
}
