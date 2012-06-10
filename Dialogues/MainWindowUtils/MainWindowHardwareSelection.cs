using System;
using System.Windows.Forms;

namespace CoreView
{
    public partial class MainWindow
    {
        private void processor_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (processor_list.SelectedIndex >= 0)
            {
                // General information
                currentComputer.Processor[processor_list.SelectedIndex].GetVolatileInfo();
                changeHardwareDetails(currentComputer.Processor[processor_list.SelectedIndex], processor_details);
                // Side information
                processor_quick_1.Text = currentComputer.Processor[processor_list.SelectedIndex].Manufacturer;
                processor_quick_2.Text = currentComputer.Processor[processor_list.SelectedIndex].Model;
                processor_quick_3.Text = currentComputer.Processor[processor_list.SelectedIndex].Socket;
                processor_quick_4.Text = currentComputer.Processor[processor_list.SelectedIndex].CurrentClock.ToString() + "MHz";
            }
        }

        private void motherboard_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (motherboard_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.Motherboard[motherboard_list.SelectedIndex], motherboard_details);
                motherboard_quick_1.Text = currentComputer.Motherboard[motherboard_list.SelectedIndex].Manufacturer;
                motherboard_quick_2.Text = currentComputer.Motherboard[motherboard_list.SelectedIndex].Model;
                motherboard_quick_3.Text = currentComputer.Motherboard[motherboard_list.SelectedIndex].ProductID;
                motherboard_quick_4.Text = currentComputer.BIOS[motherboard_list.SelectedIndex].Version;
            }
        }

        private void memory_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memory_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.MemoryDevice[memory_list.SelectedIndex], memory_details);
                memory_quick_1.Text = currentComputer.MemoryDevice[memory_list.SelectedIndex].Manufacturer;
                memory_quick_2.Text = currentComputer.MemoryDevice[memory_list.SelectedIndex].Model;
                memory_quick_3.Text = currentComputer.MemoryDevice[memory_list.SelectedIndex].Capacity.ToString() + "MB";
                memory_quick_4.Text = currentComputer.MemoryDevice[memory_list.SelectedIndex].Speed.ToString() + "MHz";
            }
        }

        private void graphics_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (graphics_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.GraphicsAdapter[graphics_list.SelectedIndex], graphics_details);
                graphics_quick_1.Text = currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].Name;
                graphics_quick_2.Text = currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].HorizontalResolution.ToString() + "x" + currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].VerticalResolution.ToString();
                graphics_quick_3.Text = currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].CurrentRefresh.ToString() + "Hz";
                graphics_quick_4.Text = currentComputer.GraphicsAdapter[graphics_list.SelectedIndex].DriverVersion;
            }
        }

        private void network_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (network_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.NetworkAdapter[network_list.SelectedIndex], network_details);
                network_quick_1.Text = currentComputer.NetworkAdapter[network_list.SelectedIndex].Manufacturer;
                network_quick_2.Text = currentComputer.NetworkAdapter[network_list.SelectedIndex].Name;
                network_quick_3.Text = currentComputer.NetworkAdapter[network_list.SelectedIndex].MACAddress;
                network_quick_4.Text = currentComputer.NetworkAdapter[network_list.SelectedIndex].MaxSpeed + "MB/s";
            }
        }

        private void harddrive_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (harddrive_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.HardDrive[harddrive_list.SelectedIndex], harddrive_details);
                changeHardwareDetails(currentComputer.HardDrive[harddrive_list.SelectedIndex].SMARTData, smart_details);
                harddrive_quick_1.Text = currentComputer.HardDrive[harddrive_list.SelectedIndex].Manufacturer;
                harddrive_quick_2.Text = currentComputer.HardDrive[harddrive_list.SelectedIndex].Model;
                harddrive_quick_3.Text = currentComputer.HardDrive[harddrive_list.SelectedIndex].Capacity.ToString() + "GB";
                harddrive_quick_4.Text = currentComputer.HardDrive[harddrive_list.SelectedIndex].Partitions.ToString();
            }
        }

        private void optical_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (optical_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.OpticalDrive[optical_list.SelectedIndex], optical_details);
                optical_quick_1.Text = currentComputer.OpticalDrive[optical_list.SelectedIndex].Manufacturer;
                optical_quick_2.Text = currentComputer.OpticalDrive[optical_list.SelectedIndex].Name;
            }
        }

        private void pci_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pci_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.PCICard[pci_list.SelectedIndex], pci_details);
                pci_quick_1.Text = currentComputer.PCICard[pci_list.SelectedIndex].Manufacturer;
                pci_quick_2.Text = currentComputer.PCICard[pci_list.SelectedIndex].Model;
            }
        }

        private void usb_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usb_list.SelectedIndex >= 0)
            {
                changeHardwareDetails(currentComputer.USBDevice[usb_list.SelectedIndex], usb_details);
                usb_quick_1.Text = currentComputer.USBDevice[usb_list.SelectedIndex].Manufacturer;
                usb_quick_2.Text = currentComputer.USBDevice[usb_list.SelectedIndex].Name;
            }
        }

        private void logs_details_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            logs_details_extend.Text = e.Item.SubItems[4].Text;
        }
    }
}
