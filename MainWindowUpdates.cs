using System;
using System.Drawing;
using System.Windows.Forms;

namespace CoreView
{
    public partial class MainWindow
    {
        private Graph processorGraph;
        private Graph graphicsGraph;
        private Graph processesGraph;

        private void updater_Tick(object sender, EventArgs e)
        {
			// Main Volatile Updates \\
			// Handle status strip
			if (Splash.Progress > 0 && Splash.Progress < 100)
			{
				this.status_strip_label.Enabled = true;
				this.status_strip_progress.Visible = true;
				this.status_strip_label.Text = Splash.Status;
				this.status_strip_progress.Value = Splash.Progress;
			}
			else
			{
				this.status_strip_label.Text = "Idle";
				this.status_strip_label.Enabled = false;
				this.status_strip_progress.Visible = false;
			}

			// Graphs and Volatile Info \\
            // If the selected index falls within the actual number of processors, continue
            if (currentComputer.Processor.Count > processor_list.SelectedIndex && currentComputer.Processor.Count > 0)
            {
                if (processorGraph != null)
                {
                    // Add value to graph
                    currentComputer.Processor[processor_list.SelectedIndex].GetVolatileInfo();
                    processorGraph.Series[0].AddValue(currentComputer.Processor[processor_list.SelectedIndex].Usage);
                    processorGraph.Series[1].AddValue(currentComputer.Processor[processor_list.SelectedIndex].Temperature);

                    // Add values to processes graph (average usage of all processors)
                    UInt16 usageTotal = 0;
                    foreach (Processor processor in currentComputer.Processor)
                    {
                        usageTotal += processor.Usage;
                    }
                    processesGraph.Series[0].AddValue(usageTotal / currentComputer.Processor.Count);

                    // Update graphs
                    processorGraph.Redraw();
                    processesGraph.Redraw();
                }
            }

            if (currentComputer.Motherboard.Count > motherboard_list.SelectedIndex && currentComputer.Motherboard.Count > 0)
            {
                // Update values
                currentComputer.Motherboard[motherboard_list.SelectedIndex].GetVolatileInfo();
            }

            if (currentComputer.GraphicsAdapter.Count > graphics_list.SelectedIndex && currentComputer.GraphicsAdapter.Count > 0)
            {
                currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].GetVolatileInfo();
                graphicsGraph.Series[0].AddValue(currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].Temperature);
                graphicsGraph.Redraw();
            }

            if (currentComputer.HardDrive.Count > harddrive_list.SelectedIndex && currentComputer.HardDrive.Count > 0)
            {
                currentComputer.HardDrive[harddrive_list.SelectedIndex].GetVolatileInfo();
            }

            // Database search results before the thread has finished
            if (temporary_database_details.Items.Count != database_details.Items.Count)
            {
                database_details.Items.Clear();
                foreach (ListViewItem item in temporary_database_details.Items)
                {
                    database_details.Items.Add(item);
                }
            }
        }

        private void createGraphs()
        {
            processorGraph = new Graph(processor_graph_container, true);
            processorGraph.Series.Add(new GraphSeries("Usage", new Pen(Color.Khaki, 1)));
            processorGraph.Series.Add(new GraphSeries("Temperature", new Pen(Color.IndianRed, 1)));
            processorGraph.MaxValue = 100;
            graphicsGraph = new Graph(graphics_graph_container, true);
            graphicsGraph.Series.Add(new GraphSeries("Temperature", new Pen(Color.IndianRed, 1)));
            graphicsGraph.MaxValue = 100;
            processesGraph = new Graph(processes_graph_container, true);
            processesGraph.Series.Add(new GraphSeries("Usage", new Pen(Color.Khaki, 1)));
            processesGraph.MaxValue = 100;
        }
    }
}
