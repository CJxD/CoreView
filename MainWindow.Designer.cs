namespace CoreView
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.main_menu_strip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.overviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motherboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.memoryDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.networkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hardDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opticalDrivesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCICardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSBDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressIRQSharingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addressMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iRQMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runningProcessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abortDataRetreivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.userManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licensingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updater = new System.Windows.Forms.Timer(this.components);
            this.tab_database = new System.Windows.Forms.TabPage();
            this.database_container = new System.Windows.Forms.SplitContainer();
            this.database_icon = new System.Windows.Forms.PictureBox();
            this.database_complaint_panel = new System.Windows.Forms.Panel();
            this.ComplaintBSOD = new System.Windows.Forms.CheckBox();
            this.ComplaintDeviceIssue = new System.Windows.Forms.CheckBox();
            this.ComplaintDisplayIssue = new System.Windows.Forms.CheckBox();
            this.ComplaintInputIssue = new System.Windows.Forms.CheckBox();
            this.ComplaintLockouts = new System.Windows.Forms.CheckBox();
            this.ComplaintSoundIssue = new System.Windows.Forms.CheckBox();
            this.ComplaintProgramIssue = new System.Windows.Forms.CheckBox();
            this.ComplaintSluggish = new System.Windows.Forms.CheckBox();
            this.ComplaintScreenLag = new System.Windows.Forms.CheckBox();
            this.ComplaintSlowBoot = new System.Windows.Forms.CheckBox();
            this.database_query_stop = new System.Windows.Forms.Button();
            this.database_add = new System.Windows.Forms.Button();
            this.database_options = new System.Windows.Forms.Button();
            this.database_query_start = new System.Windows.Forms.Button();
            this.database_complaints_lbl = new System.Windows.Forms.Label();
            this.database_load_computer = new System.Windows.Forms.Button();
            this.database_comments = new System.Windows.Forms.TextBox();
            this.database_search_btn = new System.Windows.Forms.Button();
            this.database_search = new System.Windows.Forms.TextBox();
            this.database_details = new System.Windows.Forms.ListView();
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_logs = new System.Windows.Forms.TabPage();
            this.logs_container = new System.Windows.Forms.SplitContainer();
            this.logs_quick_4 = new System.Windows.Forms.Label();
            this.logs_quick_title_4 = new System.Windows.Forms.Label();
            this.logs_quick_3 = new System.Windows.Forms.Label();
            this.logs_quick_2 = new System.Windows.Forms.Label();
            this.logs_quick_title_2 = new System.Windows.Forms.Label();
            this.logs_quick_1 = new System.Windows.Forms.Label();
            this.logs_quick_title_1 = new System.Windows.Forms.Label();
            this.logs_icon = new System.Windows.Forms.PictureBox();
            this.logs_details_extend = new System.Windows.Forms.TextBox();
            this.logs_search_btn = new System.Windows.Forms.Button();
            this.logs_search = new System.Windows.Forms.TextBox();
            this.logs_details = new System.Windows.Forms.ListView();
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_processes = new System.Windows.Forms.TabPage();
            this.processes_container = new System.Windows.Forms.SplitContainer();
            this.processes_quick_1 = new System.Windows.Forms.Label();
            this.processes_quick_title_1 = new System.Windows.Forms.Label();
            this.processes_icon = new System.Windows.Forms.PictureBox();
            this.processes_graph_container = new System.Windows.Forms.Panel();
            this.processes_search_btn = new System.Windows.Forms.Button();
            this.processes_search = new System.Windows.Forms.TextBox();
            this.processes_details = new System.Windows.Forms.ListView();
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_irqs = new System.Windows.Forms.TabPage();
            this.irqs_container = new System.Windows.Forms.SplitContainer();
            this.irqs_quick_1 = new System.Windows.Forms.Label();
            this.irqs_quick_title_1 = new System.Windows.Forms.Label();
            this.irqs_icon = new System.Windows.Forms.PictureBox();
            this.irqs_search_btn = new System.Windows.Forms.Button();
            this.irqs_search = new System.Windows.Forms.TextBox();
            this.irqs_details = new System.Windows.Forms.ListView();
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_addresses = new System.Windows.Forms.TabPage();
            this.addresses_container = new System.Windows.Forms.SplitContainer();
            this.addresses_quick_1 = new System.Windows.Forms.Label();
            this.addresses_quick_title_1 = new System.Windows.Forms.Label();
            this.addresses_icon = new System.Windows.Forms.PictureBox();
            this.addresses_search_btn = new System.Windows.Forms.Button();
            this.addresses_search = new System.Windows.Forms.TextBox();
            this.addresses_details = new System.Windows.Forms.ListView();
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_irqsharing = new System.Windows.Forms.TabPage();
            this.irqsharing_container = new System.Windows.Forms.SplitContainer();
            this.irqsharing_quick_1 = new System.Windows.Forms.Label();
            this.irqsharing_quick_title_1 = new System.Windows.Forms.Label();
            this.irqsharing_icon = new System.Windows.Forms.PictureBox();
            this.irqsharing_search_btn = new System.Windows.Forms.Button();
            this.irqsharing_search = new System.Windows.Forms.TextBox();
            this.irqsharing_details = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_software = new System.Windows.Forms.TabPage();
            this.software_container = new System.Windows.Forms.SplitContainer();
            this.software_quick_1 = new System.Windows.Forms.Label();
            this.software_quick_title_1 = new System.Windows.Forms.Label();
            this.software_icon = new System.Windows.Forms.PictureBox();
            this.software_search_btn = new System.Windows.Forms.Button();
            this.software_search = new System.Windows.Forms.TextBox();
            this.software_details = new System.Windows.Forms.ListView();
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_drivers = new System.Windows.Forms.TabPage();
            this.drivers_container = new System.Windows.Forms.SplitContainer();
            this.driver_quick_1 = new System.Windows.Forms.Label();
            this.driver_quick_title_1 = new System.Windows.Forms.Label();
            this.drivers_icon = new System.Windows.Forms.PictureBox();
            this.drivers_search_btn = new System.Windows.Forms.Button();
            this.driver_search = new System.Windows.Forms.TextBox();
            this.driver_details = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_hardware = new System.Windows.Forms.TabPage();
            this.tab_cont_hardware = new System.Windows.Forms.TabControl();
            this.tab_processor = new System.Windows.Forms.TabPage();
            this.processor_container = new System.Windows.Forms.SplitContainer();
            this.processor_quick_4 = new System.Windows.Forms.Label();
            this.processor_quick_title_4 = new System.Windows.Forms.Label();
            this.processor_quick_3 = new System.Windows.Forms.Label();
            this.processor_quick_title_3 = new System.Windows.Forms.Label();
            this.processor_quick_2 = new System.Windows.Forms.Label();
            this.processor_quick_title_2 = new System.Windows.Forms.Label();
            this.processor_quick_1 = new System.Windows.Forms.Label();
            this.processor_quick_title_1 = new System.Windows.Forms.Label();
            this.processor_icon = new System.Windows.Forms.PictureBox();
            this.processor_status = new System.Windows.Forms.Button();
            this.processor_list = new System.Windows.Forms.ComboBox();
            this.processor_graph_container = new System.Windows.Forms.Panel();
            this.processor_details = new System.Windows.Forms.ListView();
            this.ch_attribute = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_motherboard = new System.Windows.Forms.TabPage();
            this.motherboard_container = new System.Windows.Forms.SplitContainer();
            this.motherboard_quick_4 = new System.Windows.Forms.Label();
            this.motherboard_quick_title_4 = new System.Windows.Forms.Label();
            this.motherboard_quick_3 = new System.Windows.Forms.Label();
            this.motherboard_quick_title_3 = new System.Windows.Forms.Label();
            this.motherboard_quick_2 = new System.Windows.Forms.Label();
            this.motherboard_quick_title_2 = new System.Windows.Forms.Label();
            this.motherboard_quick_1 = new System.Windows.Forms.Label();
            this.motherboard_quick_title_1 = new System.Windows.Forms.Label();
            this.motherboard_icon = new System.Windows.Forms.PictureBox();
            this.motherboard_status = new System.Windows.Forms.Button();
            this.motherboard_list = new System.Windows.Forms.ComboBox();
            this.biosSepLabel = new System.Windows.Forms.Label();
            this.bios_details = new System.Windows.Forms.ListView();
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.motherboard_details = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_memory = new System.Windows.Forms.TabPage();
            this.memory_container = new System.Windows.Forms.SplitContainer();
            this.memory_quick_4 = new System.Windows.Forms.Label();
            this.memory_quick_title_4 = new System.Windows.Forms.Label();
            this.memory_quick_3 = new System.Windows.Forms.Label();
            this.memory_quick_title_3 = new System.Windows.Forms.Label();
            this.memory_quick_2 = new System.Windows.Forms.Label();
            this.memory_quick_title_2 = new System.Windows.Forms.Label();
            this.memory_quick_1 = new System.Windows.Forms.Label();
            this.memory_quick_title_1 = new System.Windows.Forms.Label();
            this.memory_icon = new System.Windows.Forms.PictureBox();
            this.memory_status = new System.Windows.Forms.Button();
            this.memory_list = new System.Windows.Forms.ComboBox();
            this.memory_details = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_graphics = new System.Windows.Forms.TabPage();
            this.graphics_container = new System.Windows.Forms.SplitContainer();
            this.graphics_quick_4 = new System.Windows.Forms.Label();
            this.graphics_quick_title_4 = new System.Windows.Forms.Label();
            this.graphics_quick_3 = new System.Windows.Forms.Label();
            this.graphics_quick_title_3 = new System.Windows.Forms.Label();
            this.graphics_quick_2 = new System.Windows.Forms.Label();
            this.graphics_quick_title_2 = new System.Windows.Forms.Label();
            this.graphics_quick_1 = new System.Windows.Forms.Label();
            this.graphics_quick_title_1 = new System.Windows.Forms.Label();
            this.graphics_icon = new System.Windows.Forms.PictureBox();
            this.graphics_status = new System.Windows.Forms.Button();
            this.graphics_list = new System.Windows.Forms.ComboBox();
            this.graphics_graph_container = new System.Windows.Forms.Panel();
            this.graphics_details = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_network = new System.Windows.Forms.TabPage();
            this.network_container = new System.Windows.Forms.SplitContainer();
            this.network_quick_4 = new System.Windows.Forms.Label();
            this.network_quick_title_4 = new System.Windows.Forms.Label();
            this.network_quick_3 = new System.Windows.Forms.Label();
            this.network_quick_title_3 = new System.Windows.Forms.Label();
            this.network_quick_2 = new System.Windows.Forms.Label();
            this.network_quick_title_2 = new System.Windows.Forms.Label();
            this.network_quick_1 = new System.Windows.Forms.Label();
            this.network_quick_title_1 = new System.Windows.Forms.Label();
            this.network_icon = new System.Windows.Forms.PictureBox();
            this.network_status = new System.Windows.Forms.Button();
            this.network_list = new System.Windows.Forms.ComboBox();
            this.network_graph_container = new System.Windows.Forms.Panel();
            this.network_details = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_harddrive = new System.Windows.Forms.TabPage();
            this.harddrive_container = new System.Windows.Forms.SplitContainer();
            this.harddrive_quick_4 = new System.Windows.Forms.Label();
            this.harddrive_quick_title_4 = new System.Windows.Forms.Label();
            this.harddrive_quick_3 = new System.Windows.Forms.Label();
            this.harddrive_quick_title_3 = new System.Windows.Forms.Label();
            this.harddrive_quick_2 = new System.Windows.Forms.Label();
            this.harddrive_quick_title_2 = new System.Windows.Forms.Label();
            this.harddrive_quick_1 = new System.Windows.Forms.Label();
            this.harddrive_quick_title_1 = new System.Windows.Forms.Label();
            this.harddrive_icon = new System.Windows.Forms.PictureBox();
            this.harddrive_status = new System.Windows.Forms.Button();
            this.harddrive_list = new System.Windows.Forms.ComboBox();
            this.smartSepLabel = new System.Windows.Forms.Label();
            this.harddrive_details = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smart_details = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_optical = new System.Windows.Forms.TabPage();
            this.optical_container = new System.Windows.Forms.SplitContainer();
            this.optical_quick_2 = new System.Windows.Forms.Label();
            this.optical_quick_title_2 = new System.Windows.Forms.Label();
            this.optical_quick_1 = new System.Windows.Forms.Label();
            this.optical_quick_title_1 = new System.Windows.Forms.Label();
            this.optical_icon = new System.Windows.Forms.PictureBox();
            this.optical_status = new System.Windows.Forms.Button();
            this.optical_list = new System.Windows.Forms.ComboBox();
            this.optical_details = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_pci = new System.Windows.Forms.TabPage();
            this.pci_container = new System.Windows.Forms.SplitContainer();
            this.pci_quick_2 = new System.Windows.Forms.Label();
            this.pci_quick_title_2 = new System.Windows.Forms.Label();
            this.pci_quick_1 = new System.Windows.Forms.Label();
            this.pci_quick_title_1 = new System.Windows.Forms.Label();
            this.pci_icon = new System.Windows.Forms.PictureBox();
            this.pci_status = new System.Windows.Forms.Button();
            this.pci_list = new System.Windows.Forms.ComboBox();
            this.pci_details = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_usb = new System.Windows.Forms.TabPage();
            this.usb_container = new System.Windows.Forms.SplitContainer();
            this.usb_quick_2 = new System.Windows.Forms.Label();
            this.usb_quick_title_2 = new System.Windows.Forms.Label();
            this.usb_quick_1 = new System.Windows.Forms.Label();
            this.usb_quick_title_1 = new System.Windows.Forms.Label();
            this.usb_icon = new System.Windows.Forms.PictureBox();
            this.usb_status = new System.Windows.Forms.Button();
            this.usb_list = new System.Windows.Forms.ComboBox();
            this.usb_details = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tab_overview = new System.Windows.Forms.TabPage();
            this.overview_container = new System.Windows.Forms.SplitContainer();
            this.overview_quick_6 = new System.Windows.Forms.Label();
            this.overview_quick_title_6 = new System.Windows.Forms.Label();
            this.overview_quick_5 = new System.Windows.Forms.Label();
            this.overview_quick_title_5 = new System.Windows.Forms.Label();
            this.overview_quick_4 = new System.Windows.Forms.Label();
            this.overview_quick_title_4 = new System.Windows.Forms.Label();
            this.overview_quick_3 = new System.Windows.Forms.Label();
            this.overview_quick_title_3 = new System.Windows.Forms.Label();
            this.overview_quick_2 = new System.Windows.Forms.Label();
            this.overview_quick_title_2 = new System.Windows.Forms.Label();
            this.overview_quick_1 = new System.Windows.Forms.Label();
            this.overview_quick_title_1 = new System.Windows.Forms.Label();
            this.overview_icon = new System.Windows.Forms.PictureBox();
            this.tab_cont_main = new System.Windows.Forms.TabControl();
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.status_strip_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_strip_progress = new System.Windows.Forms.ToolStripProgressBar();
            this.showFullText = new System.Windows.Forms.ToolTip(this.components);
            this.main_menu_strip.SuspendLayout();
            this.tab_database.SuspendLayout();
            this.database_container.Panel1.SuspendLayout();
            this.database_container.Panel2.SuspendLayout();
            this.database_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_icon)).BeginInit();
            this.database_complaint_panel.SuspendLayout();
            this.tab_logs.SuspendLayout();
            this.logs_container.Panel1.SuspendLayout();
            this.logs_container.Panel2.SuspendLayout();
            this.logs_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logs_icon)).BeginInit();
            this.tab_processes.SuspendLayout();
            this.processes_container.Panel1.SuspendLayout();
            this.processes_container.Panel2.SuspendLayout();
            this.processes_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processes_icon)).BeginInit();
            this.tab_irqs.SuspendLayout();
            this.irqs_container.Panel1.SuspendLayout();
            this.irqs_container.Panel2.SuspendLayout();
            this.irqs_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irqs_icon)).BeginInit();
            this.tab_addresses.SuspendLayout();
            this.addresses_container.Panel1.SuspendLayout();
            this.addresses_container.Panel2.SuspendLayout();
            this.addresses_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addresses_icon)).BeginInit();
            this.tab_irqsharing.SuspendLayout();
            this.irqsharing_container.Panel1.SuspendLayout();
            this.irqsharing_container.Panel2.SuspendLayout();
            this.irqsharing_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.irqsharing_icon)).BeginInit();
            this.tab_software.SuspendLayout();
            this.software_container.Panel1.SuspendLayout();
            this.software_container.Panel2.SuspendLayout();
            this.software_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.software_icon)).BeginInit();
            this.tab_drivers.SuspendLayout();
            this.drivers_container.Panel1.SuspendLayout();
            this.drivers_container.Panel2.SuspendLayout();
            this.drivers_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drivers_icon)).BeginInit();
            this.tab_hardware.SuspendLayout();
            this.tab_cont_hardware.SuspendLayout();
            this.tab_processor.SuspendLayout();
            this.processor_container.Panel1.SuspendLayout();
            this.processor_container.Panel2.SuspendLayout();
            this.processor_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processor_icon)).BeginInit();
            this.tab_motherboard.SuspendLayout();
            this.motherboard_container.Panel1.SuspendLayout();
            this.motherboard_container.Panel2.SuspendLayout();
            this.motherboard_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motherboard_icon)).BeginInit();
            this.tab_memory.SuspendLayout();
            this.memory_container.Panel1.SuspendLayout();
            this.memory_container.Panel2.SuspendLayout();
            this.memory_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memory_icon)).BeginInit();
            this.tab_graphics.SuspendLayout();
            this.graphics_container.Panel1.SuspendLayout();
            this.graphics_container.Panel2.SuspendLayout();
            this.graphics_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphics_icon)).BeginInit();
            this.tab_network.SuspendLayout();
            this.network_container.Panel1.SuspendLayout();
            this.network_container.Panel2.SuspendLayout();
            this.network_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.network_icon)).BeginInit();
            this.tab_harddrive.SuspendLayout();
            this.harddrive_container.Panel1.SuspendLayout();
            this.harddrive_container.Panel2.SuspendLayout();
            this.harddrive_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.harddrive_icon)).BeginInit();
            this.tab_optical.SuspendLayout();
            this.optical_container.Panel1.SuspendLayout();
            this.optical_container.Panel2.SuspendLayout();
            this.optical_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optical_icon)).BeginInit();
            this.tab_pci.SuspendLayout();
            this.pci_container.Panel1.SuspendLayout();
            this.pci_container.Panel2.SuspendLayout();
            this.pci_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pci_icon)).BeginInit();
            this.tab_usb.SuspendLayout();
            this.usb_container.Panel1.SuspendLayout();
            this.usb_container.Panel2.SuspendLayout();
            this.usb_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usb_icon)).BeginInit();
            this.tab_overview.SuspendLayout();
            this.overview_container.Panel1.SuspendLayout();
            this.overview_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.overview_icon)).BeginInit();
            this.tab_cont_main.SuspendLayout();
            this.status_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_menu_strip
            // 
            this.main_menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.optionsToolStripMenuItem1,
            this.helpToolStripMenuItem1,
            this.helpToolStripMenuItem2});
            this.main_menu_strip.Location = new System.Drawing.Point(0, 0);
            this.main_menu_strip.Name = "main_menu_strip";
            this.main_menu_strip.Size = new System.Drawing.Size(784, 24);
            this.main_menu_strip.TabIndex = 1;
            this.main_menu_strip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadConfigurationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // reloadConfigurationToolStripMenuItem
            // 
            this.reloadConfigurationToolStripMenuItem.Name = "reloadConfigurationToolStripMenuItem";
            this.reloadConfigurationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.reloadConfigurationToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.reloadConfigurationToolStripMenuItem.Text = "Reload Configuration";
            this.reloadConfigurationToolStripMenuItem.Click += new System.EventHandler(this.reloadConfigurationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overviewToolStripMenuItem,
            this.hardwareToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.softwareToolStripMenuItem,
            this.addressIRQSharingToolStripMenuItem,
            this.addressMapToolStripMenuItem,
            this.iRQMapToolStripMenuItem,
            this.runningProcessesToolStripMenuItem,
            this.windowsLogsToolStripMenuItem,
            this.databaseToolStripMenuItem});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.optionsToolStripMenuItem1.Text = "View";
            // 
            // overviewToolStripMenuItem
            // 
            this.overviewToolStripMenuItem.Name = "overviewToolStripMenuItem";
            this.overviewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D0)));
            this.overviewToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.overviewToolStripMenuItem.Text = "Overview";
            this.overviewToolStripMenuItem.Click += new System.EventHandler(this.overviewToolStripMenuItem_Click);
            // 
            // hardwareToolStripMenuItem
            // 
            this.hardwareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processorToolStripMenuItem,
            this.motherboardToolStripMenuItem,
            this.memoryDevicesToolStripMenuItem,
            this.graphicsToolStripMenuItem,
            this.networkToolStripMenuItem,
            this.hardDrivesToolStripMenuItem,
            this.opticalDrivesToolStripMenuItem,
            this.pCICardsToolStripMenuItem,
            this.uSBDevicesToolStripMenuItem});
            this.hardwareToolStripMenuItem.Name = "hardwareToolStripMenuItem";
            this.hardwareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D1)));
            this.hardwareToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.hardwareToolStripMenuItem.Text = "Hardware";
            this.hardwareToolStripMenuItem.Click += new System.EventHandler(this.hardwareToolStripMenuItem_Click);
            // 
            // processorToolStripMenuItem
            // 
            this.processorToolStripMenuItem.Name = "processorToolStripMenuItem";
            this.processorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.P)));
            this.processorToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.processorToolStripMenuItem.Text = "Processor";
            this.processorToolStripMenuItem.Click += new System.EventHandler(this.processorToolStripMenuItem_Click);
            // 
            // motherboardToolStripMenuItem
            // 
            this.motherboardToolStripMenuItem.Name = "motherboardToolStripMenuItem";
            this.motherboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.M)));
            this.motherboardToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.motherboardToolStripMenuItem.Text = "Motherboard";
            this.motherboardToolStripMenuItem.Click += new System.EventHandler(this.motherboardToolStripMenuItem_Click);
            // 
            // memoryDevicesToolStripMenuItem
            // 
            this.memoryDevicesToolStripMenuItem.Name = "memoryDevicesToolStripMenuItem";
            this.memoryDevicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.R)));
            this.memoryDevicesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.memoryDevicesToolStripMenuItem.Text = "Memory";
            this.memoryDevicesToolStripMenuItem.Click += new System.EventHandler(this.memoryDevicesToolStripMenuItem_Click);
            // 
            // graphicsToolStripMenuItem
            // 
            this.graphicsToolStripMenuItem.Name = "graphicsToolStripMenuItem";
            this.graphicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.G)));
            this.graphicsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.graphicsToolStripMenuItem.Text = "Graphics";
            this.graphicsToolStripMenuItem.Click += new System.EventHandler(this.graphicsToolStripMenuItem_Click);
            // 
            // networkToolStripMenuItem
            // 
            this.networkToolStripMenuItem.Name = "networkToolStripMenuItem";
            this.networkToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.N)));
            this.networkToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.networkToolStripMenuItem.Text = "Network";
            this.networkToolStripMenuItem.Click += new System.EventHandler(this.networkToolStripMenuItem_Click);
            // 
            // hardDrivesToolStripMenuItem
            // 
            this.hardDrivesToolStripMenuItem.Name = "hardDrivesToolStripMenuItem";
            this.hardDrivesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.H)));
            this.hardDrivesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.hardDrivesToolStripMenuItem.Text = "Hard Drives";
            this.hardDrivesToolStripMenuItem.Click += new System.EventHandler(this.hardDrivesToolStripMenuItem_Click);
            // 
            // opticalDrivesToolStripMenuItem
            // 
            this.opticalDrivesToolStripMenuItem.Name = "opticalDrivesToolStripMenuItem";
            this.opticalDrivesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.C)));
            this.opticalDrivesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.opticalDrivesToolStripMenuItem.Text = "Optical Drives";
            this.opticalDrivesToolStripMenuItem.Click += new System.EventHandler(this.opticalDrivesToolStripMenuItem_Click);
            // 
            // pCICardsToolStripMenuItem
            // 
            this.pCICardsToolStripMenuItem.Name = "pCICardsToolStripMenuItem";
            this.pCICardsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.X)));
            this.pCICardsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pCICardsToolStripMenuItem.Text = "PCI Slots";
            this.pCICardsToolStripMenuItem.Click += new System.EventHandler(this.pCICardsToolStripMenuItem_Click);
            // 
            // uSBDevicesToolStripMenuItem
            // 
            this.uSBDevicesToolStripMenuItem.Name = "uSBDevicesToolStripMenuItem";
            this.uSBDevicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.U)));
            this.uSBDevicesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.uSBDevicesToolStripMenuItem.Text = "USB Devices";
            this.uSBDevicesToolStripMenuItem.Click += new System.EventHandler(this.uSBDevicesToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D2)));
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // softwareToolStripMenuItem
            // 
            this.softwareToolStripMenuItem.Name = "softwareToolStripMenuItem";
            this.softwareToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D3)));
            this.softwareToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.softwareToolStripMenuItem.Text = "Software";
            this.softwareToolStripMenuItem.Click += new System.EventHandler(this.softwareToolStripMenuItem_Click);
            // 
            // addressIRQSharingToolStripMenuItem
            // 
            this.addressIRQSharingToolStripMenuItem.Name = "addressIRQSharingToolStripMenuItem";
            this.addressIRQSharingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D4)));
            this.addressIRQSharingToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.addressIRQSharingToolStripMenuItem.Text = "Address/IRQ Sharing";
            this.addressIRQSharingToolStripMenuItem.Click += new System.EventHandler(this.addressIRQSharingToolStripMenuItem_Click);
            // 
            // addressMapToolStripMenuItem
            // 
            this.addressMapToolStripMenuItem.Name = "addressMapToolStripMenuItem";
            this.addressMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D5)));
            this.addressMapToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.addressMapToolStripMenuItem.Text = "Address Map";
            this.addressMapToolStripMenuItem.Click += new System.EventHandler(this.addressMapToolStripMenuItem_Click);
            // 
            // iRQMapToolStripMenuItem
            // 
            this.iRQMapToolStripMenuItem.Name = "iRQMapToolStripMenuItem";
            this.iRQMapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D6)));
            this.iRQMapToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.iRQMapToolStripMenuItem.Text = "IRQ Map";
            this.iRQMapToolStripMenuItem.Click += new System.EventHandler(this.iRQMapToolStripMenuItem_Click);
            // 
            // runningProcessesToolStripMenuItem
            // 
            this.runningProcessesToolStripMenuItem.Name = "runningProcessesToolStripMenuItem";
            this.runningProcessesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D7)));
            this.runningProcessesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.runningProcessesToolStripMenuItem.Text = "Running Processes";
            this.runningProcessesToolStripMenuItem.Click += new System.EventHandler(this.runningProcessesToolStripMenuItem_Click);
            // 
            // windowsLogsToolStripMenuItem
            // 
            this.windowsLogsToolStripMenuItem.Name = "windowsLogsToolStripMenuItem";
            this.windowsLogsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D8)));
            this.windowsLogsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.windowsLogsToolStripMenuItem.Text = "Windows Logs";
            this.windowsLogsToolStripMenuItem.Click += new System.EventHandler(this.windowsLogsToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.D9)));
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            this.databaseToolStripMenuItem.Click += new System.EventHandler(this.databaseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abortDataRetreivalToolStripMenuItem,
            this.refreshDataToolStripMenuItem,
            this.optionsToolStripMenuItem2});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.helpToolStripMenuItem1.Text = "Tools";
            // 
            // abortDataRetreivalToolStripMenuItem
            // 
            this.abortDataRetreivalToolStripMenuItem.Name = "abortDataRetreivalToolStripMenuItem";
            this.abortDataRetreivalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.abortDataRetreivalToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.abortDataRetreivalToolStripMenuItem.Text = "Abort Data Retreival";
            this.abortDataRetreivalToolStripMenuItem.Click += new System.EventHandler(this.abortDataRetreivalToolStripMenuItem_Click);
            // 
            // refreshDataToolStripMenuItem
            // 
            this.refreshDataToolStripMenuItem.Name = "refreshDataToolStripMenuItem";
            this.refreshDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.refreshDataToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.refreshDataToolStripMenuItem.Text = "Refresh Data";
            this.refreshDataToolStripMenuItem.Click += new System.EventHandler(this.refreshDataToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem2
            // 
            this.optionsToolStripMenuItem2.Name = "optionsToolStripMenuItem2";
            this.optionsToolStripMenuItem2.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.optionsToolStripMenuItem2.Size = new System.Drawing.Size(204, 22);
            this.optionsToolStripMenuItem2.Text = "Options";
            this.optionsToolStripMenuItem2.Click += new System.EventHandler(this.optionsToolStripMenuItem2_Click);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userManualToolStripMenuItem,
            this.licensingToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem2.Text = "Help";
            // 
            // userManualToolStripMenuItem
            // 
            this.userManualToolStripMenuItem.Name = "userManualToolStripMenuItem";
            this.userManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.userManualToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.userManualToolStripMenuItem.Text = "User Manual";
            this.userManualToolStripMenuItem.Click += new System.EventHandler(this.userManualToolStripMenuItem_Click);
            // 
            // licensingToolStripMenuItem
            // 
            this.licensingToolStripMenuItem.Name = "licensingToolStripMenuItem";
            this.licensingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.licensingToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.licensingToolStripMenuItem.Text = "Licensing";
            this.licensingToolStripMenuItem.Click += new System.EventHandler(this.licensingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // updater
            // 
            this.updater.Interval = 1000;
            this.updater.Tick += new System.EventHandler(this.updater_Tick);
            // 
            // tab_database
            // 
            this.tab_database.Controls.Add(this.database_container);
            this.tab_database.Location = new System.Drawing.Point(4, 29);
            this.tab_database.Name = "tab_database";
            this.tab_database.Padding = new System.Windows.Forms.Padding(3);
            this.tab_database.Size = new System.Drawing.Size(781, 487);
            this.tab_database.TabIndex = 10;
            this.tab_database.Text = "Database";
            this.tab_database.UseVisualStyleBackColor = true;
            // 
            // database_container
            // 
            this.database_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.database_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.database_container.IsSplitterFixed = true;
            this.database_container.Location = new System.Drawing.Point(-4, 0);
            this.database_container.Name = "database_container";
            // 
            // database_container.Panel1
            // 
            this.database_container.Panel1.Controls.Add(this.database_icon);
            this.database_container.Panel1.Controls.Add(this.database_complaint_panel);
            this.database_container.Panel1.Controls.Add(this.database_query_stop);
            this.database_container.Panel1.Controls.Add(this.database_add);
            this.database_container.Panel1.Controls.Add(this.database_options);
            this.database_container.Panel1.Controls.Add(this.database_query_start);
            this.database_container.Panel1.Controls.Add(this.database_complaints_lbl);
            // 
            // database_container.Panel2
            // 
            this.database_container.Panel2.Controls.Add(this.database_load_computer);
            this.database_container.Panel2.Controls.Add(this.database_comments);
            this.database_container.Panel2.Controls.Add(this.database_search_btn);
            this.database_container.Panel2.Controls.Add(this.database_search);
            this.database_container.Panel2.Controls.Add(this.database_details);
            this.database_container.Size = new System.Drawing.Size(782, 509);
            this.database_container.SplitterDistance = 230;
            this.database_container.TabIndex = 6;
            // 
            // database_icon
            // 
            this.database_icon.Image = global::CoreView.Properties.Resources.Database;
            this.database_icon.Location = new System.Drawing.Point(35, 18);
            this.database_icon.Name = "database_icon";
            this.database_icon.Size = new System.Drawing.Size(128, 128);
            this.database_icon.TabIndex = 16;
            this.database_icon.TabStop = false;
            // 
            // database_complaint_panel
            // 
            this.database_complaint_panel.Controls.Add(this.ComplaintBSOD);
            this.database_complaint_panel.Controls.Add(this.ComplaintDeviceIssue);
            this.database_complaint_panel.Controls.Add(this.ComplaintDisplayIssue);
            this.database_complaint_panel.Controls.Add(this.ComplaintInputIssue);
            this.database_complaint_panel.Controls.Add(this.ComplaintLockouts);
            this.database_complaint_panel.Controls.Add(this.ComplaintSoundIssue);
            this.database_complaint_panel.Controls.Add(this.ComplaintProgramIssue);
            this.database_complaint_panel.Controls.Add(this.ComplaintSluggish);
            this.database_complaint_panel.Controls.Add(this.ComplaintScreenLag);
            this.database_complaint_panel.Controls.Add(this.ComplaintSlowBoot);
            this.database_complaint_panel.Location = new System.Drawing.Point(7, 192);
            this.database_complaint_panel.Name = "database_complaint_panel";
            this.database_complaint_panel.Size = new System.Drawing.Size(220, 122);
            this.database_complaint_panel.TabIndex = 15;
            // 
            // ComplaintBSOD
            // 
            this.ComplaintBSOD.AutoSize = true;
            this.ComplaintBSOD.Location = new System.Drawing.Point(7, 3);
            this.ComplaintBSOD.Name = "ComplaintBSOD";
            this.ComplaintBSOD.Size = new System.Drawing.Size(56, 17);
            this.ComplaintBSOD.TabIndex = 1;
            this.ComplaintBSOD.Text = "BSOD";
            this.ComplaintBSOD.UseVisualStyleBackColor = true;
            this.ComplaintBSOD.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintDeviceIssue
            // 
            this.ComplaintDeviceIssue.AutoSize = true;
            this.ComplaintDeviceIssue.Location = new System.Drawing.Point(7, 26);
            this.ComplaintDeviceIssue.Name = "ComplaintDeviceIssue";
            this.ComplaintDeviceIssue.Size = new System.Drawing.Size(88, 17);
            this.ComplaintDeviceIssue.TabIndex = 2;
            this.ComplaintDeviceIssue.Text = "Device Issue";
            this.ComplaintDeviceIssue.UseVisualStyleBackColor = true;
            this.ComplaintDeviceIssue.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintDisplayIssue
            // 
            this.ComplaintDisplayIssue.AutoSize = true;
            this.ComplaintDisplayIssue.Location = new System.Drawing.Point(7, 50);
            this.ComplaintDisplayIssue.Name = "ComplaintDisplayIssue";
            this.ComplaintDisplayIssue.Size = new System.Drawing.Size(88, 17);
            this.ComplaintDisplayIssue.TabIndex = 3;
            this.ComplaintDisplayIssue.Text = "Display Issue";
            this.ComplaintDisplayIssue.UseVisualStyleBackColor = true;
            this.ComplaintDisplayIssue.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintInputIssue
            // 
            this.ComplaintInputIssue.AutoSize = true;
            this.ComplaintInputIssue.Location = new System.Drawing.Point(7, 74);
            this.ComplaintInputIssue.Name = "ComplaintInputIssue";
            this.ComplaintInputIssue.Size = new System.Drawing.Size(78, 17);
            this.ComplaintInputIssue.TabIndex = 4;
            this.ComplaintInputIssue.Text = "Input Issue";
            this.ComplaintInputIssue.UseVisualStyleBackColor = true;
            this.ComplaintInputIssue.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintLockouts
            // 
            this.ComplaintLockouts.AutoSize = true;
            this.ComplaintLockouts.Location = new System.Drawing.Point(7, 98);
            this.ComplaintLockouts.Name = "ComplaintLockouts";
            this.ComplaintLockouts.Size = new System.Drawing.Size(75, 17);
            this.ComplaintLockouts.TabIndex = 5;
            this.ComplaintLockouts.Text = "Lock-Outs";
            this.ComplaintLockouts.UseVisualStyleBackColor = true;
            this.ComplaintLockouts.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintSoundIssue
            // 
            this.ComplaintSoundIssue.AutoSize = true;
            this.ComplaintSoundIssue.Location = new System.Drawing.Point(116, 99);
            this.ComplaintSoundIssue.Name = "ComplaintSoundIssue";
            this.ComplaintSoundIssue.Size = new System.Drawing.Size(85, 17);
            this.ComplaintSoundIssue.TabIndex = 10;
            this.ComplaintSoundIssue.Text = "Sound Issue";
            this.ComplaintSoundIssue.UseVisualStyleBackColor = true;
            this.ComplaintSoundIssue.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintProgramIssue
            // 
            this.ComplaintProgramIssue.AutoSize = true;
            this.ComplaintProgramIssue.Location = new System.Drawing.Point(116, 3);
            this.ComplaintProgramIssue.Name = "ComplaintProgramIssue";
            this.ComplaintProgramIssue.Size = new System.Drawing.Size(93, 17);
            this.ComplaintProgramIssue.TabIndex = 6;
            this.ComplaintProgramIssue.Text = "Program Issue";
            this.ComplaintProgramIssue.UseVisualStyleBackColor = true;
            this.ComplaintProgramIssue.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintSluggish
            // 
            this.ComplaintSluggish.AutoSize = true;
            this.ComplaintSluggish.Location = new System.Drawing.Point(116, 75);
            this.ComplaintSluggish.Name = "ComplaintSluggish";
            this.ComplaintSluggish.Size = new System.Drawing.Size(66, 17);
            this.ComplaintSluggish.TabIndex = 9;
            this.ComplaintSluggish.Text = "Sluggish";
            this.ComplaintSluggish.UseVisualStyleBackColor = true;
            this.ComplaintSluggish.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintScreenLag
            // 
            this.ComplaintScreenLag.AutoSize = true;
            this.ComplaintScreenLag.Location = new System.Drawing.Point(116, 27);
            this.ComplaintScreenLag.Name = "ComplaintScreenLag";
            this.ComplaintScreenLag.Size = new System.Drawing.Size(81, 17);
            this.ComplaintScreenLag.TabIndex = 7;
            this.ComplaintScreenLag.Text = "Screen Lag";
            this.ComplaintScreenLag.UseVisualStyleBackColor = true;
            this.ComplaintScreenLag.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // ComplaintSlowBoot
            // 
            this.ComplaintSlowBoot.AutoSize = true;
            this.ComplaintSlowBoot.Location = new System.Drawing.Point(116, 51);
            this.ComplaintSlowBoot.Name = "ComplaintSlowBoot";
            this.ComplaintSlowBoot.Size = new System.Drawing.Size(74, 17);
            this.ComplaintSlowBoot.TabIndex = 8;
            this.ComplaintSlowBoot.Text = "Slow Boot";
            this.ComplaintSlowBoot.UseVisualStyleBackColor = true;
            this.ComplaintSlowBoot.CheckedChanged += new System.EventHandler(this.Complaint_CheckedChanged);
            // 
            // database_query_stop
            // 
            this.database_query_stop.Location = new System.Drawing.Point(14, 414);
            this.database_query_stop.Name = "database_query_stop";
            this.database_query_stop.Size = new System.Drawing.Size(202, 32);
            this.database_query_stop.TabIndex = 14;
            this.database_query_stop.Text = "Stop Operation";
            this.database_query_stop.UseVisualStyleBackColor = true;
            this.database_query_stop.Click += new System.EventHandler(this.database_query_stop_Click);
            // 
            // database_add
            // 
            this.database_add.Location = new System.Drawing.Point(14, 367);
            this.database_add.Name = "database_add";
            this.database_add.Size = new System.Drawing.Size(202, 32);
            this.database_add.TabIndex = 13;
            this.database_add.Text = "Add to Database";
            this.database_add.UseVisualStyleBackColor = true;
            this.database_add.Click += new System.EventHandler(this.database_add_Click);
            // 
            // database_options
            // 
            this.database_options.Location = new System.Drawing.Point(14, 452);
            this.database_options.Name = "database_options";
            this.database_options.Size = new System.Drawing.Size(202, 32);
            this.database_options.TabIndex = 12;
            this.database_options.Text = "Options";
            this.database_options.UseVisualStyleBackColor = true;
            this.database_options.Click += new System.EventHandler(this.database_options_Click);
            // 
            // database_query_start
            // 
            this.database_query_start.Location = new System.Drawing.Point(14, 320);
            this.database_query_start.Name = "database_query_start";
            this.database_query_start.Size = new System.Drawing.Size(202, 32);
            this.database_query_start.TabIndex = 11;
            this.database_query_start.Text = "Start Search";
            this.database_query_start.UseVisualStyleBackColor = true;
            this.database_query_start.Click += new System.EventHandler(this.database_query_start_Click);
            // 
            // database_complaints_lbl
            // 
            this.database_complaints_lbl.AutoSize = true;
            this.database_complaints_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_complaints_lbl.Location = new System.Drawing.Point(10, 173);
            this.database_complaints_lbl.Name = "database_complaints_lbl";
            this.database_complaints_lbl.Size = new System.Drawing.Size(78, 16);
            this.database_complaints_lbl.TabIndex = 0;
            this.database_complaints_lbl.Text = "Complaints:";
            // 
            // database_load_computer
            // 
            this.database_load_computer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.database_load_computer.Location = new System.Drawing.Point(292, 452);
            this.database_load_computer.Name = "database_load_computer";
            this.database_load_computer.Size = new System.Drawing.Size(250, 32);
            this.database_load_computer.TabIndex = 17;
            this.database_load_computer.Text = "Load Selected Computer";
            this.database_load_computer.UseVisualStyleBackColor = true;
            this.database_load_computer.Click += new System.EventHandler(this.database_load_computer_Click);
            // 
            // database_comments
            // 
            this.database_comments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.database_comments.Location = new System.Drawing.Point(5, 302);
            this.database_comments.Multiline = true;
            this.database_comments.Name = "database_comments";
            this.database_comments.Size = new System.Drawing.Size(537, 144);
            this.database_comments.TabIndex = 0;
            // 
            // database_search_btn
            // 
            this.database_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.database_search_btn.Location = new System.Drawing.Point(211, 452);
            this.database_search_btn.Name = "database_search_btn";
            this.database_search_btn.Size = new System.Drawing.Size(75, 32);
            this.database_search_btn.TabIndex = 6;
            this.database_search_btn.Text = "Search";
            this.database_search_btn.UseVisualStyleBackColor = true;
            this.database_search_btn.Click += new System.EventHandler(this.database_search_btn_Click);
            // 
            // database_search
            // 
            this.database_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.database_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_search.Location = new System.Drawing.Point(5, 452);
            this.database_search.Multiline = true;
            this.database_search.Name = "database_search";
            this.database_search.Size = new System.Drawing.Size(200, 32);
            this.database_search.TabIndex = 5;
            this.database_search.Enter += new System.EventHandler(this.database_search_Enter);
            // 
            // database_details
            // 
            this.database_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.database_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40});
            this.database_details.FullRowSelect = true;
            this.database_details.Location = new System.Drawing.Point(5, 6);
            this.database_details.Name = "database_details";
            this.database_details.Size = new System.Drawing.Size(537, 290);
            this.database_details.TabIndex = 4;
            this.database_details.UseCompatibleStateImageBehavior = false;
            this.database_details.View = System.Windows.Forms.View.Details;
            this.database_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.database_details_ColumnClick);
            this.database_details.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.database_details_ItemSelectionChanged);
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "ID";
            this.columnHeader38.Width = 82;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "Score";
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Comments";
            this.columnHeader40.Width = 391;
            // 
            // tab_logs
            // 
            this.tab_logs.Controls.Add(this.logs_container);
            this.tab_logs.Location = new System.Drawing.Point(4, 29);
            this.tab_logs.Name = "tab_logs";
            this.tab_logs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_logs.Size = new System.Drawing.Size(781, 487);
            this.tab_logs.TabIndex = 9;
            this.tab_logs.Text = "Event Logs";
            this.tab_logs.UseVisualStyleBackColor = true;
            this.tab_logs.Enter += new System.EventHandler(this.populateLogsTab);
            // 
            // logs_container
            // 
            this.logs_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logs_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.logs_container.IsSplitterFixed = true;
            this.logs_container.Location = new System.Drawing.Point(-4, 0);
            this.logs_container.Name = "logs_container";
            // 
            // logs_container.Panel1
            // 
            this.logs_container.Panel1.Controls.Add(this.logs_quick_4);
            this.logs_container.Panel1.Controls.Add(this.logs_quick_title_4);
            this.logs_container.Panel1.Controls.Add(this.logs_quick_3);
            this.logs_container.Panel1.Controls.Add(this.logs_quick_2);
            this.logs_container.Panel1.Controls.Add(this.logs_quick_title_2);
            this.logs_container.Panel1.Controls.Add(this.logs_quick_1);
            this.logs_container.Panel1.Controls.Add(this.logs_quick_title_1);
            this.logs_container.Panel1.Controls.Add(this.logs_icon);
            // 
            // logs_container.Panel2
            // 
            this.logs_container.Panel2.Controls.Add(this.logs_details_extend);
            this.logs_container.Panel2.Controls.Add(this.logs_search_btn);
            this.logs_container.Panel2.Controls.Add(this.logs_search);
            this.logs_container.Panel2.Controls.Add(this.logs_details);
            this.logs_container.Size = new System.Drawing.Size(782, 509);
            this.logs_container.SplitterDistance = 200;
            this.logs_container.TabIndex = 7;
            // 
            // logs_quick_4
            // 
            this.logs_quick_4.AutoSize = true;
            this.logs_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_4.Location = new System.Drawing.Point(20, 314);
            this.logs_quick_4.Name = "logs_quick_4";
            this.logs_quick_4.Size = new System.Drawing.Size(30, 17);
            this.logs_quick_4.TabIndex = 18;
            this.logs_quick_4.Text = "Info";
            this.logs_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // logs_quick_title_4
            // 
            this.logs_quick_title_4.AutoSize = true;
            this.logs_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_title_4.Location = new System.Drawing.Point(10, 290);
            this.logs_quick_title_4.Name = "logs_quick_title_4";
            this.logs_quick_title_4.Size = new System.Drawing.Size(94, 17);
            this.logs_quick_title_4.TabIndex = 17;
            this.logs_quick_title_4.Text = "\'Dirty\' Flag Set:";
            // 
            // logs_quick_3
            // 
            this.logs_quick_3.AutoSize = true;
            this.logs_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_3.Location = new System.Drawing.Point(20, 267);
            this.logs_quick_3.Name = "logs_quick_3";
            this.logs_quick_3.Size = new System.Drawing.Size(30, 17);
            this.logs_quick_3.TabIndex = 16;
            this.logs_quick_3.Text = "Info";
            this.logs_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // logs_quick_2
            // 
            this.logs_quick_2.AutoSize = true;
            this.logs_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_2.Location = new System.Drawing.Point(20, 250);
            this.logs_quick_2.Name = "logs_quick_2";
            this.logs_quick_2.Size = new System.Drawing.Size(30, 17);
            this.logs_quick_2.TabIndex = 15;
            this.logs_quick_2.Text = "Info";
            this.logs_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // logs_quick_title_2
            // 
            this.logs_quick_title_2.AutoSize = true;
            this.logs_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_title_2.Location = new System.Drawing.Point(10, 226);
            this.logs_quick_title_2.Name = "logs_quick_title_2";
            this.logs_quick_title_2.Size = new System.Drawing.Size(95, 17);
            this.logs_quick_title_2.TabIndex = 14;
            this.logs_quick_title_2.Text = "Last Shutdown:";
            // 
            // logs_quick_1
            // 
            this.logs_quick_1.AutoSize = true;
            this.logs_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_1.Location = new System.Drawing.Point(20, 203);
            this.logs_quick_1.Name = "logs_quick_1";
            this.logs_quick_1.Size = new System.Drawing.Size(30, 17);
            this.logs_quick_1.TabIndex = 13;
            this.logs_quick_1.Text = "Info";
            this.logs_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // logs_quick_title_1
            // 
            this.logs_quick_title_1.AutoSize = true;
            this.logs_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.logs_quick_title_1.Name = "logs_quick_title_1";
            this.logs_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.logs_quick_title_1.TabIndex = 12;
            this.logs_quick_title_1.Text = "Entries:";
            // 
            // logs_icon
            // 
            this.logs_icon.Image = global::CoreView.Properties.Resources.Log;
            this.logs_icon.Location = new System.Drawing.Point(35, 18);
            this.logs_icon.Name = "logs_icon";
            this.logs_icon.Size = new System.Drawing.Size(128, 128);
            this.logs_icon.TabIndex = 5;
            this.logs_icon.TabStop = false;
            // 
            // logs_details_extend
            // 
            this.logs_details_extend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logs_details_extend.Location = new System.Drawing.Point(5, 302);
            this.logs_details_extend.Multiline = true;
            this.logs_details_extend.Name = "logs_details_extend";
            this.logs_details_extend.Size = new System.Drawing.Size(567, 144);
            this.logs_details_extend.TabIndex = 1;
            // 
            // logs_search_btn
            // 
            this.logs_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logs_search_btn.Location = new System.Drawing.Point(211, 452);
            this.logs_search_btn.Name = "logs_search_btn";
            this.logs_search_btn.Size = new System.Drawing.Size(75, 32);
            this.logs_search_btn.TabIndex = 6;
            this.logs_search_btn.Text = "Search";
            this.logs_search_btn.UseVisualStyleBackColor = true;
            this.logs_search_btn.Click += new System.EventHandler(this.logs_search_btn_Click);
            // 
            // logs_search
            // 
            this.logs_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logs_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logs_search.Location = new System.Drawing.Point(5, 452);
            this.logs_search.Multiline = true;
            this.logs_search.Name = "logs_search";
            this.logs_search.Size = new System.Drawing.Size(200, 32);
            this.logs_search.TabIndex = 5;
            this.logs_search.Enter += new System.EventHandler(this.logs_search_Enter);
            // 
            // logs_details
            // 
            this.logs_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.logs_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader41,
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader45});
            this.logs_details.FullRowSelect = true;
            this.logs_details.Location = new System.Drawing.Point(5, 6);
            this.logs_details.Name = "logs_details";
            this.logs_details.Size = new System.Drawing.Size(567, 290);
            this.logs_details.TabIndex = 4;
            this.logs_details.UseCompatibleStateImageBehavior = false;
            this.logs_details.View = System.Windows.Forms.View.Details;
            this.logs_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.logs_details_ColumnClick);
            this.logs_details.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.logs_details_ItemSelectionChanged);
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "Level";
            this.columnHeader41.Width = 93;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Date/Time";
            this.columnHeader42.Width = 121;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "Source";
            this.columnHeader43.Width = 175;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "EventID";
            this.columnHeader44.Width = 62;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "Information";
            this.columnHeader45.Width = 112;
            // 
            // tab_processes
            // 
            this.tab_processes.Controls.Add(this.processes_container);
            this.tab_processes.Location = new System.Drawing.Point(4, 29);
            this.tab_processes.Name = "tab_processes";
            this.tab_processes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_processes.Size = new System.Drawing.Size(781, 487);
            this.tab_processes.TabIndex = 7;
            this.tab_processes.Text = "Running Processes";
            this.tab_processes.UseVisualStyleBackColor = true;
            this.tab_processes.Enter += new System.EventHandler(this.populateProcessesTab);
            // 
            // processes_container
            // 
            this.processes_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processes_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.processes_container.IsSplitterFixed = true;
            this.processes_container.Location = new System.Drawing.Point(-4, 0);
            this.processes_container.Name = "processes_container";
            // 
            // processes_container.Panel1
            // 
            this.processes_container.Panel1.Controls.Add(this.processes_quick_1);
            this.processes_container.Panel1.Controls.Add(this.processes_quick_title_1);
            this.processes_container.Panel1.Controls.Add(this.processes_icon);
            this.processes_container.Panel1.Controls.Add(this.processes_graph_container);
            // 
            // processes_container.Panel2
            // 
            this.processes_container.Panel2.Controls.Add(this.processes_search_btn);
            this.processes_container.Panel2.Controls.Add(this.processes_search);
            this.processes_container.Panel2.Controls.Add(this.processes_details);
            this.processes_container.Size = new System.Drawing.Size(782, 509);
            this.processes_container.SplitterDistance = 200;
            this.processes_container.TabIndex = 6;
            // 
            // processes_quick_1
            // 
            this.processes_quick_1.AutoSize = true;
            this.processes_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_quick_1.Location = new System.Drawing.Point(20, 203);
            this.processes_quick_1.Name = "processes_quick_1";
            this.processes_quick_1.Size = new System.Drawing.Size(30, 17);
            this.processes_quick_1.TabIndex = 9;
            this.processes_quick_1.Text = "Info";
            this.processes_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // processes_quick_title_1
            // 
            this.processes_quick_title_1.AutoSize = true;
            this.processes_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.processes_quick_title_1.Name = "processes_quick_title_1";
            this.processes_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.processes_quick_title_1.TabIndex = 8;
            this.processes_quick_title_1.Text = "Entries:";
            // 
            // processes_icon
            // 
            this.processes_icon.Image = global::CoreView.Properties.Resources.Process;
            this.processes_icon.Location = new System.Drawing.Point(35, 18);
            this.processes_icon.Name = "processes_icon";
            this.processes_icon.Size = new System.Drawing.Size(128, 128);
            this.processes_icon.TabIndex = 7;
            this.processes_icon.TabStop = false;
            // 
            // processes_graph_container
            // 
            this.processes_graph_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processes_graph_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processes_graph_container.BackColor = System.Drawing.Color.DarkSlateGray;
            this.processes_graph_container.Location = new System.Drawing.Point(7, 233);
            this.processes_graph_container.Name = "processes_graph_container";
            this.processes_graph_container.Size = new System.Drawing.Size(190, 248);
            this.processes_graph_container.TabIndex = 6;
            // 
            // processes_search_btn
            // 
            this.processes_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processes_search_btn.Location = new System.Drawing.Point(211, 452);
            this.processes_search_btn.Name = "processes_search_btn";
            this.processes_search_btn.Size = new System.Drawing.Size(75, 32);
            this.processes_search_btn.TabIndex = 6;
            this.processes_search_btn.Text = "Search";
            this.processes_search_btn.UseVisualStyleBackColor = true;
            this.processes_search_btn.Click += new System.EventHandler(this.processes_search_btn_Click);
            // 
            // processes_search
            // 
            this.processes_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.processes_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processes_search.Location = new System.Drawing.Point(5, 452);
            this.processes_search.Multiline = true;
            this.processes_search.Name = "processes_search";
            this.processes_search.Size = new System.Drawing.Size(200, 32);
            this.processes_search.TabIndex = 5;
            this.processes_search.Enter += new System.EventHandler(this.processes_search_Enter);
            // 
            // processes_details
            // 
            this.processes_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processes_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader33,
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36,
            this.columnHeader37});
            this.processes_details.FullRowSelect = true;
            this.processes_details.Location = new System.Drawing.Point(5, 6);
            this.processes_details.Name = "processes_details";
            this.processes_details.Size = new System.Drawing.Size(567, 440);
            this.processes_details.TabIndex = 4;
            this.processes_details.UseCompatibleStateImageBehavior = false;
            this.processes_details.View = System.Windows.Forms.View.Details;
            this.processes_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.processes_details_ColumnClick);
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Process Name";
            this.columnHeader33.Width = 141;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "Process ID";
            this.columnHeader34.Width = 75;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Executable Path";
            this.columnHeader35.Width = 174;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "CPU Usage";
            this.columnHeader36.Width = 69;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "IO Speed";
            this.columnHeader37.Width = 104;
            // 
            // tab_irqs
            // 
            this.tab_irqs.Controls.Add(this.irqs_container);
            this.tab_irqs.Location = new System.Drawing.Point(4, 29);
            this.tab_irqs.Name = "tab_irqs";
            this.tab_irqs.Padding = new System.Windows.Forms.Padding(3);
            this.tab_irqs.Size = new System.Drawing.Size(781, 487);
            this.tab_irqs.TabIndex = 6;
            this.tab_irqs.Text = "IRQ Map";
            this.tab_irqs.UseVisualStyleBackColor = true;
            this.tab_irqs.Enter += new System.EventHandler(this.populateIRQsTab);
            // 
            // irqs_container
            // 
            this.irqs_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.irqs_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.irqs_container.IsSplitterFixed = true;
            this.irqs_container.Location = new System.Drawing.Point(-4, 0);
            this.irqs_container.Name = "irqs_container";
            // 
            // irqs_container.Panel1
            // 
            this.irqs_container.Panel1.Controls.Add(this.irqs_quick_1);
            this.irqs_container.Panel1.Controls.Add(this.irqs_quick_title_1);
            this.irqs_container.Panel1.Controls.Add(this.irqs_icon);
            // 
            // irqs_container.Panel2
            // 
            this.irqs_container.Panel2.Controls.Add(this.irqs_search_btn);
            this.irqs_container.Panel2.Controls.Add(this.irqs_search);
            this.irqs_container.Panel2.Controls.Add(this.irqs_details);
            this.irqs_container.Size = new System.Drawing.Size(782, 509);
            this.irqs_container.SplitterDistance = 200;
            this.irqs_container.TabIndex = 7;
            // 
            // irqs_quick_1
            // 
            this.irqs_quick_1.AutoSize = true;
            this.irqs_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irqs_quick_1.Location = new System.Drawing.Point(20, 203);
            this.irqs_quick_1.Name = "irqs_quick_1";
            this.irqs_quick_1.Size = new System.Drawing.Size(30, 17);
            this.irqs_quick_1.TabIndex = 8;
            this.irqs_quick_1.Text = "Info";
            this.irqs_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // irqs_quick_title_1
            // 
            this.irqs_quick_title_1.AutoSize = true;
            this.irqs_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irqs_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.irqs_quick_title_1.Name = "irqs_quick_title_1";
            this.irqs_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.irqs_quick_title_1.TabIndex = 7;
            this.irqs_quick_title_1.Text = "Entries:";
            // 
            // irqs_icon
            // 
            this.irqs_icon.Image = global::CoreView.Properties.Resources.IRQ;
            this.irqs_icon.Location = new System.Drawing.Point(35, 18);
            this.irqs_icon.Name = "irqs_icon";
            this.irqs_icon.Size = new System.Drawing.Size(128, 128);
            this.irqs_icon.TabIndex = 5;
            this.irqs_icon.TabStop = false;
            // 
            // irqs_search_btn
            // 
            this.irqs_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.irqs_search_btn.Location = new System.Drawing.Point(211, 452);
            this.irqs_search_btn.Name = "irqs_search_btn";
            this.irqs_search_btn.Size = new System.Drawing.Size(75, 32);
            this.irqs_search_btn.TabIndex = 6;
            this.irqs_search_btn.Text = "Search";
            this.irqs_search_btn.UseVisualStyleBackColor = true;
            this.irqs_search_btn.Click += new System.EventHandler(this.irqs_search_btn_Click);
            // 
            // irqs_search
            // 
            this.irqs_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.irqs_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irqs_search.Location = new System.Drawing.Point(5, 452);
            this.irqs_search.Multiline = true;
            this.irqs_search.Name = "irqs_search";
            this.irqs_search.Size = new System.Drawing.Size(200, 32);
            this.irqs_search.TabIndex = 5;
            this.irqs_search.Enter += new System.EventHandler(this.irqs_search_Enter);
            // 
            // irqs_details
            // 
            this.irqs_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.irqs_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader31,
            this.columnHeader32});
            this.irqs_details.FullRowSelect = true;
            this.irqs_details.Location = new System.Drawing.Point(5, 6);
            this.irqs_details.Name = "irqs_details";
            this.irqs_details.Size = new System.Drawing.Size(567, 440);
            this.irqs_details.TabIndex = 4;
            this.irqs_details.UseCompatibleStateImageBehavior = false;
            this.irqs_details.View = System.Windows.Forms.View.Details;
            this.irqs_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.irqs_details_ColumnClick);
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Resource";
            this.columnHeader31.Width = 179;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Device";
            this.columnHeader32.Width = 384;
            // 
            // tab_addresses
            // 
            this.tab_addresses.Controls.Add(this.addresses_container);
            this.tab_addresses.Location = new System.Drawing.Point(4, 29);
            this.tab_addresses.Name = "tab_addresses";
            this.tab_addresses.Padding = new System.Windows.Forms.Padding(3);
            this.tab_addresses.Size = new System.Drawing.Size(781, 487);
            this.tab_addresses.TabIndex = 5;
            this.tab_addresses.Text = "Address Map";
            this.tab_addresses.UseVisualStyleBackColor = true;
            this.tab_addresses.Enter += new System.EventHandler(this.populateAddressesTab);
            // 
            // addresses_container
            // 
            this.addresses_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addresses_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.addresses_container.IsSplitterFixed = true;
            this.addresses_container.Location = new System.Drawing.Point(-4, 0);
            this.addresses_container.Name = "addresses_container";
            // 
            // addresses_container.Panel1
            // 
            this.addresses_container.Panel1.Controls.Add(this.addresses_quick_1);
            this.addresses_container.Panel1.Controls.Add(this.addresses_quick_title_1);
            this.addresses_container.Panel1.Controls.Add(this.addresses_icon);
            // 
            // addresses_container.Panel2
            // 
            this.addresses_container.Panel2.Controls.Add(this.addresses_search_btn);
            this.addresses_container.Panel2.Controls.Add(this.addresses_search);
            this.addresses_container.Panel2.Controls.Add(this.addresses_details);
            this.addresses_container.Size = new System.Drawing.Size(782, 509);
            this.addresses_container.SplitterDistance = 200;
            this.addresses_container.TabIndex = 7;
            // 
            // addresses_quick_1
            // 
            this.addresses_quick_1.AutoSize = true;
            this.addresses_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresses_quick_1.Location = new System.Drawing.Point(20, 203);
            this.addresses_quick_1.Name = "addresses_quick_1";
            this.addresses_quick_1.Size = new System.Drawing.Size(30, 17);
            this.addresses_quick_1.TabIndex = 8;
            this.addresses_quick_1.Text = "Info";
            this.addresses_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // addresses_quick_title_1
            // 
            this.addresses_quick_title_1.AutoSize = true;
            this.addresses_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresses_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.addresses_quick_title_1.Name = "addresses_quick_title_1";
            this.addresses_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.addresses_quick_title_1.TabIndex = 7;
            this.addresses_quick_title_1.Text = "Entries:";
            // 
            // addresses_icon
            // 
            this.addresses_icon.Image = ((System.Drawing.Image)(resources.GetObject("addresses_icon.Image")));
            this.addresses_icon.Location = new System.Drawing.Point(35, 18);
            this.addresses_icon.Name = "addresses_icon";
            this.addresses_icon.Size = new System.Drawing.Size(128, 128);
            this.addresses_icon.TabIndex = 5;
            this.addresses_icon.TabStop = false;
            // 
            // addresses_search_btn
            // 
            this.addresses_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addresses_search_btn.Location = new System.Drawing.Point(211, 452);
            this.addresses_search_btn.Name = "addresses_search_btn";
            this.addresses_search_btn.Size = new System.Drawing.Size(75, 32);
            this.addresses_search_btn.TabIndex = 6;
            this.addresses_search_btn.Text = "Search";
            this.addresses_search_btn.UseVisualStyleBackColor = true;
            this.addresses_search_btn.Click += new System.EventHandler(this.addresses_search_btn_Click);
            // 
            // addresses_search
            // 
            this.addresses_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addresses_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresses_search.Location = new System.Drawing.Point(5, 452);
            this.addresses_search.Multiline = true;
            this.addresses_search.Name = "addresses_search";
            this.addresses_search.Size = new System.Drawing.Size(200, 32);
            this.addresses_search.TabIndex = 5;
            this.addresses_search.Enter += new System.EventHandler(this.addresses_search_Enter);
            // 
            // addresses_details
            // 
            this.addresses_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addresses_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader29,
            this.columnHeader30});
            this.addresses_details.FullRowSelect = true;
            this.addresses_details.Location = new System.Drawing.Point(5, 6);
            this.addresses_details.Name = "addresses_details";
            this.addresses_details.Size = new System.Drawing.Size(567, 440);
            this.addresses_details.TabIndex = 4;
            this.addresses_details.UseCompatibleStateImageBehavior = false;
            this.addresses_details.View = System.Windows.Forms.View.Details;
            this.addresses_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.addresses_details_ColumnClick);
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Resource";
            this.columnHeader29.Width = 179;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Device";
            this.columnHeader30.Width = 384;
            // 
            // tab_irqsharing
            // 
            this.tab_irqsharing.Controls.Add(this.irqsharing_container);
            this.tab_irqsharing.Location = new System.Drawing.Point(4, 29);
            this.tab_irqsharing.Name = "tab_irqsharing";
            this.tab_irqsharing.Padding = new System.Windows.Forms.Padding(3);
            this.tab_irqsharing.Size = new System.Drawing.Size(781, 487);
            this.tab_irqsharing.TabIndex = 4;
            this.tab_irqsharing.Text = "Address/IRQ Sharing";
            this.tab_irqsharing.UseVisualStyleBackColor = true;
            this.tab_irqsharing.Enter += new System.EventHandler(this.populateConflictsTab);
            // 
            // irqsharing_container
            // 
            this.irqsharing_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.irqsharing_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.irqsharing_container.IsSplitterFixed = true;
            this.irqsharing_container.Location = new System.Drawing.Point(-4, 0);
            this.irqsharing_container.Name = "irqsharing_container";
            // 
            // irqsharing_container.Panel1
            // 
            this.irqsharing_container.Panel1.Controls.Add(this.irqsharing_quick_1);
            this.irqsharing_container.Panel1.Controls.Add(this.irqsharing_quick_title_1);
            this.irqsharing_container.Panel1.Controls.Add(this.irqsharing_icon);
            // 
            // irqsharing_container.Panel2
            // 
            this.irqsharing_container.Panel2.Controls.Add(this.irqsharing_search_btn);
            this.irqsharing_container.Panel2.Controls.Add(this.irqsharing_search);
            this.irqsharing_container.Panel2.Controls.Add(this.irqsharing_details);
            this.irqsharing_container.Size = new System.Drawing.Size(782, 509);
            this.irqsharing_container.SplitterDistance = 200;
            this.irqsharing_container.TabIndex = 6;
            // 
            // irqsharing_quick_1
            // 
            this.irqsharing_quick_1.AutoSize = true;
            this.irqsharing_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irqsharing_quick_1.Location = new System.Drawing.Point(20, 203);
            this.irqsharing_quick_1.Name = "irqsharing_quick_1";
            this.irqsharing_quick_1.Size = new System.Drawing.Size(30, 17);
            this.irqsharing_quick_1.TabIndex = 8;
            this.irqsharing_quick_1.Text = "Info";
            this.irqsharing_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // irqsharing_quick_title_1
            // 
            this.irqsharing_quick_title_1.AutoSize = true;
            this.irqsharing_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irqsharing_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.irqsharing_quick_title_1.Name = "irqsharing_quick_title_1";
            this.irqsharing_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.irqsharing_quick_title_1.TabIndex = 7;
            this.irqsharing_quick_title_1.Text = "Entries:";
            // 
            // irqsharing_icon
            // 
            this.irqsharing_icon.Image = global::CoreView.Properties.Resources.Sharing;
            this.irqsharing_icon.Location = new System.Drawing.Point(35, 18);
            this.irqsharing_icon.Name = "irqsharing_icon";
            this.irqsharing_icon.Size = new System.Drawing.Size(128, 128);
            this.irqsharing_icon.TabIndex = 5;
            this.irqsharing_icon.TabStop = false;
            // 
            // irqsharing_search_btn
            // 
            this.irqsharing_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.irqsharing_search_btn.Location = new System.Drawing.Point(211, 452);
            this.irqsharing_search_btn.Name = "irqsharing_search_btn";
            this.irqsharing_search_btn.Size = new System.Drawing.Size(75, 32);
            this.irqsharing_search_btn.TabIndex = 6;
            this.irqsharing_search_btn.Text = "Search";
            this.irqsharing_search_btn.UseVisualStyleBackColor = true;
            this.irqsharing_search_btn.Click += new System.EventHandler(this.irqsharing_search_btn_Click);
            // 
            // irqsharing_search
            // 
            this.irqsharing_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.irqsharing_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irqsharing_search.Location = new System.Drawing.Point(5, 452);
            this.irqsharing_search.Multiline = true;
            this.irqsharing_search.Name = "irqsharing_search";
            this.irqsharing_search.Size = new System.Drawing.Size(200, 32);
            this.irqsharing_search.TabIndex = 5;
            this.irqsharing_search.Enter += new System.EventHandler(this.irqsharing_search_Enter);
            // 
            // irqsharing_details
            // 
            this.irqsharing_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.irqsharing_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader28});
            this.irqsharing_details.FullRowSelect = true;
            this.irqsharing_details.Location = new System.Drawing.Point(5, 6);
            this.irqsharing_details.Name = "irqsharing_details";
            this.irqsharing_details.Size = new System.Drawing.Size(567, 440);
            this.irqsharing_details.TabIndex = 4;
            this.irqsharing_details.UseCompatibleStateImageBehavior = false;
            this.irqsharing_details.View = System.Windows.Forms.View.Details;
            this.irqsharing_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.irqsharing_details_ColumnClick);
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Resource";
            this.columnHeader27.Width = 179;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Device";
            this.columnHeader28.Width = 384;
            // 
            // tab_software
            // 
            this.tab_software.Controls.Add(this.software_container);
            this.tab_software.Location = new System.Drawing.Point(4, 29);
            this.tab_software.Name = "tab_software";
            this.tab_software.Padding = new System.Windows.Forms.Padding(3);
            this.tab_software.Size = new System.Drawing.Size(781, 487);
            this.tab_software.TabIndex = 3;
            this.tab_software.Text = "Software";
            this.tab_software.UseVisualStyleBackColor = true;
            this.tab_software.Enter += new System.EventHandler(this.populateSoftwareTab);
            // 
            // software_container
            // 
            this.software_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.software_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.software_container.IsSplitterFixed = true;
            this.software_container.Location = new System.Drawing.Point(-4, 0);
            this.software_container.Name = "software_container";
            // 
            // software_container.Panel1
            // 
            this.software_container.Panel1.Controls.Add(this.software_quick_1);
            this.software_container.Panel1.Controls.Add(this.software_quick_title_1);
            this.software_container.Panel1.Controls.Add(this.software_icon);
            // 
            // software_container.Panel2
            // 
            this.software_container.Panel2.Controls.Add(this.software_search_btn);
            this.software_container.Panel2.Controls.Add(this.software_search);
            this.software_container.Panel2.Controls.Add(this.software_details);
            this.software_container.Size = new System.Drawing.Size(782, 509);
            this.software_container.SplitterDistance = 200;
            this.software_container.TabIndex = 5;
            // 
            // software_quick_1
            // 
            this.software_quick_1.AutoSize = true;
            this.software_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.software_quick_1.Location = new System.Drawing.Point(20, 203);
            this.software_quick_1.Name = "software_quick_1";
            this.software_quick_1.Size = new System.Drawing.Size(30, 17);
            this.software_quick_1.TabIndex = 8;
            this.software_quick_1.Text = "Info";
            this.software_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // software_quick_title_1
            // 
            this.software_quick_title_1.AutoSize = true;
            this.software_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.software_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.software_quick_title_1.Name = "software_quick_title_1";
            this.software_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.software_quick_title_1.TabIndex = 7;
            this.software_quick_title_1.Text = "Entries:";
            // 
            // software_icon
            // 
            this.software_icon.Image = global::CoreView.Properties.Resources.Software;
            this.software_icon.Location = new System.Drawing.Point(35, 18);
            this.software_icon.Name = "software_icon";
            this.software_icon.Size = new System.Drawing.Size(128, 128);
            this.software_icon.TabIndex = 4;
            this.software_icon.TabStop = false;
            // 
            // software_search_btn
            // 
            this.software_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.software_search_btn.Location = new System.Drawing.Point(211, 452);
            this.software_search_btn.Name = "software_search_btn";
            this.software_search_btn.Size = new System.Drawing.Size(75, 32);
            this.software_search_btn.TabIndex = 6;
            this.software_search_btn.Text = "Search";
            this.software_search_btn.UseVisualStyleBackColor = true;
            this.software_search_btn.Click += new System.EventHandler(this.software_search_btn_Click);
            // 
            // software_search
            // 
            this.software_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.software_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.software_search.Location = new System.Drawing.Point(5, 452);
            this.software_search.Multiline = true;
            this.software_search.Name = "software_search";
            this.software_search.Size = new System.Drawing.Size(200, 32);
            this.software_search.TabIndex = 5;
            this.software_search.Enter += new System.EventHandler(this.software_search_Enter);
            // 
            // software_details
            // 
            this.software_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.software_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader23,
            this.columnHeader26,
            this.columnHeader25,
            this.columnHeader24});
            this.software_details.FullRowSelect = true;
            this.software_details.Location = new System.Drawing.Point(5, 6);
            this.software_details.Name = "software_details";
            this.software_details.Size = new System.Drawing.Size(567, 440);
            this.software_details.TabIndex = 4;
            this.software_details.UseCompatibleStateImageBehavior = false;
            this.software_details.View = System.Windows.Forms.View.Details;
            this.software_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.software_details_ColumnClick);
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Name";
            this.columnHeader23.Width = 144;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Publisher";
            this.columnHeader26.Width = 149;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Version";
            this.columnHeader25.Width = 130;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Date Installed";
            this.columnHeader24.Width = 140;
            // 
            // tab_drivers
            // 
            this.tab_drivers.Controls.Add(this.drivers_container);
            this.tab_drivers.Location = new System.Drawing.Point(4, 29);
            this.tab_drivers.Name = "tab_drivers";
            this.tab_drivers.Padding = new System.Windows.Forms.Padding(3);
            this.tab_drivers.Size = new System.Drawing.Size(781, 487);
            this.tab_drivers.TabIndex = 2;
            this.tab_drivers.Text = "Drivers";
            this.tab_drivers.UseVisualStyleBackColor = true;
            this.tab_drivers.Enter += new System.EventHandler(this.populateDriversTab);
            // 
            // drivers_container
            // 
            this.drivers_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.drivers_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.drivers_container.IsSplitterFixed = true;
            this.drivers_container.Location = new System.Drawing.Point(-4, 0);
            this.drivers_container.Name = "drivers_container";
            // 
            // drivers_container.Panel1
            // 
            this.drivers_container.Panel1.Controls.Add(this.driver_quick_1);
            this.drivers_container.Panel1.Controls.Add(this.driver_quick_title_1);
            this.drivers_container.Panel1.Controls.Add(this.drivers_icon);
            // 
            // drivers_container.Panel2
            // 
            this.drivers_container.Panel2.Controls.Add(this.drivers_search_btn);
            this.drivers_container.Panel2.Controls.Add(this.driver_search);
            this.drivers_container.Panel2.Controls.Add(this.driver_details);
            this.drivers_container.Size = new System.Drawing.Size(782, 509);
            this.drivers_container.SplitterDistance = 200;
            this.drivers_container.TabIndex = 4;
            // 
            // driver_quick_1
            // 
            this.driver_quick_1.AutoSize = true;
            this.driver_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_quick_1.Location = new System.Drawing.Point(20, 203);
            this.driver_quick_1.Name = "driver_quick_1";
            this.driver_quick_1.Size = new System.Drawing.Size(30, 17);
            this.driver_quick_1.TabIndex = 6;
            this.driver_quick_1.Text = "Info";
            this.driver_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // driver_quick_title_1
            // 
            this.driver_quick_title_1.AutoSize = true;
            this.driver_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_quick_title_1.Location = new System.Drawing.Point(10, 180);
            this.driver_quick_title_1.Name = "driver_quick_title_1";
            this.driver_quick_title_1.Size = new System.Drawing.Size(50, 17);
            this.driver_quick_title_1.TabIndex = 5;
            this.driver_quick_title_1.Text = "Entries:";
            // 
            // drivers_icon
            // 
            this.drivers_icon.Image = global::CoreView.Properties.Resources.Driver;
            this.drivers_icon.Location = new System.Drawing.Point(35, 18);
            this.drivers_icon.Name = "drivers_icon";
            this.drivers_icon.Size = new System.Drawing.Size(128, 128);
            this.drivers_icon.TabIndex = 4;
            this.drivers_icon.TabStop = false;
            // 
            // drivers_search_btn
            // 
            this.drivers_search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.drivers_search_btn.Location = new System.Drawing.Point(211, 452);
            this.drivers_search_btn.Name = "drivers_search_btn";
            this.drivers_search_btn.Size = new System.Drawing.Size(75, 32);
            this.drivers_search_btn.TabIndex = 6;
            this.drivers_search_btn.Text = "Search";
            this.drivers_search_btn.UseVisualStyleBackColor = true;
            this.drivers_search_btn.Click += new System.EventHandler(this.drivers_search_btn_Click);
            // 
            // driver_search
            // 
            this.driver_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.driver_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.driver_search.Location = new System.Drawing.Point(5, 452);
            this.driver_search.Multiline = true;
            this.driver_search.Name = "driver_search";
            this.driver_search.Size = new System.Drawing.Size(200, 32);
            this.driver_search.TabIndex = 5;
            this.driver_search.Enter += new System.EventHandler(this.driver_search_Enter);
            // 
            // driver_details
            // 
            this.driver_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.driver_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader21,
            this.columnHeader20,
            this.columnHeader22});
            this.driver_details.FullRowSelect = true;
            this.driver_details.Location = new System.Drawing.Point(5, 6);
            this.driver_details.Name = "driver_details";
            this.driver_details.Size = new System.Drawing.Size(567, 440);
            this.driver_details.TabIndex = 4;
            this.driver_details.UseCompatibleStateImageBehavior = false;
            this.driver_details.View = System.Windows.Forms.View.Details;
            this.driver_details.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.driver_details_ColumnClick);
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Name";
            this.columnHeader19.Width = 144;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Publisher";
            this.columnHeader21.Width = 147;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Version";
            this.columnHeader20.Width = 161;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Date Installed";
            this.columnHeader22.Width = 112;
            // 
            // tab_hardware
            // 
            this.tab_hardware.Controls.Add(this.tab_cont_hardware);
            this.tab_hardware.Location = new System.Drawing.Point(4, 29);
            this.tab_hardware.Margin = new System.Windows.Forms.Padding(0);
            this.tab_hardware.Name = "tab_hardware";
            this.tab_hardware.Size = new System.Drawing.Size(781, 487);
            this.tab_hardware.TabIndex = 1;
            this.tab_hardware.Text = "Hardware";
            this.tab_hardware.UseVisualStyleBackColor = true;
            // 
            // tab_cont_hardware
            // 
            this.tab_cont_hardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_cont_hardware.Controls.Add(this.tab_processor);
            this.tab_cont_hardware.Controls.Add(this.tab_motherboard);
            this.tab_cont_hardware.Controls.Add(this.tab_memory);
            this.tab_cont_hardware.Controls.Add(this.tab_graphics);
            this.tab_cont_hardware.Controls.Add(this.tab_network);
            this.tab_cont_hardware.Controls.Add(this.tab_harddrive);
            this.tab_cont_hardware.Controls.Add(this.tab_optical);
            this.tab_cont_hardware.Controls.Add(this.tab_pci);
            this.tab_cont_hardware.Controls.Add(this.tab_usb);
            this.tab_cont_hardware.ItemSize = new System.Drawing.Size(59, 18);
            this.tab_cont_hardware.Location = new System.Drawing.Point(-2, -1);
            this.tab_cont_hardware.Name = "tab_cont_hardware";
            this.tab_cont_hardware.SelectedIndex = 0;
            this.tab_cont_hardware.Size = new System.Drawing.Size(786, 491);
            this.tab_cont_hardware.TabIndex = 1;
            // 
            // tab_processor
            // 
            this.tab_processor.Controls.Add(this.processor_container);
            this.tab_processor.Location = new System.Drawing.Point(4, 22);
            this.tab_processor.Name = "tab_processor";
            this.tab_processor.Padding = new System.Windows.Forms.Padding(3);
            this.tab_processor.Size = new System.Drawing.Size(778, 465);
            this.tab_processor.TabIndex = 0;
            this.tab_processor.Text = "Processor";
            this.tab_processor.UseVisualStyleBackColor = true;
            this.tab_processor.Enter += new System.EventHandler(this.populateProcessorTab);
            // 
            // processor_container
            // 
            this.processor_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processor_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.processor_container.IsSplitterFixed = true;
            this.processor_container.Location = new System.Drawing.Point(-4, 0);
            this.processor_container.Name = "processor_container";
            // 
            // processor_container.Panel1
            // 
            this.processor_container.Panel1.Controls.Add(this.processor_quick_4);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_title_4);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_3);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_title_3);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_2);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_title_2);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_1);
            this.processor_container.Panel1.Controls.Add(this.processor_quick_title_1);
            this.processor_container.Panel1.Controls.Add(this.processor_icon);
            this.processor_container.Panel1.Controls.Add(this.processor_status);
            this.processor_container.Panel1.Controls.Add(this.processor_list);
            // 
            // processor_container.Panel2
            // 
            this.processor_container.Panel2.Controls.Add(this.processor_graph_container);
            this.processor_container.Panel2.Controls.Add(this.processor_details);
            this.processor_container.Size = new System.Drawing.Size(782, 465);
            this.processor_container.SplitterDistance = 200;
            this.processor_container.TabIndex = 3;
            // 
            // processor_quick_4
            // 
            this.processor_quick_4.AutoSize = true;
            this.processor_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_4.Location = new System.Drawing.Point(20, 410);
            this.processor_quick_4.Name = "processor_quick_4";
            this.processor_quick_4.Size = new System.Drawing.Size(30, 17);
            this.processor_quick_4.TabIndex = 11;
            this.processor_quick_4.Text = "Info";
            this.processor_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // processor_quick_title_4
            // 
            this.processor_quick_title_4.AutoSize = true;
            this.processor_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_title_4.Location = new System.Drawing.Point(10, 387);
            this.processor_quick_title_4.Name = "processor_quick_title_4";
            this.processor_quick_title_4.Size = new System.Drawing.Size(130, 17);
            this.processor_quick_title_4.TabIndex = 10;
            this.processor_quick_title_4.Text = "Current Clock Speed:";
            // 
            // processor_quick_3
            // 
            this.processor_quick_3.AutoSize = true;
            this.processor_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_3.Location = new System.Drawing.Point(20, 364);
            this.processor_quick_3.Name = "processor_quick_3";
            this.processor_quick_3.Size = new System.Drawing.Size(30, 17);
            this.processor_quick_3.TabIndex = 9;
            this.processor_quick_3.Text = "Info";
            this.processor_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // processor_quick_title_3
            // 
            this.processor_quick_title_3.AutoSize = true;
            this.processor_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_title_3.Location = new System.Drawing.Point(10, 341);
            this.processor_quick_title_3.Name = "processor_quick_title_3";
            this.processor_quick_title_3.Size = new System.Drawing.Size(49, 17);
            this.processor_quick_title_3.TabIndex = 8;
            this.processor_quick_title_3.Text = "Socket:";
            // 
            // processor_quick_2
            // 
            this.processor_quick_2.AutoSize = true;
            this.processor_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_2.Location = new System.Drawing.Point(20, 317);
            this.processor_quick_2.Name = "processor_quick_2";
            this.processor_quick_2.Size = new System.Drawing.Size(30, 17);
            this.processor_quick_2.TabIndex = 7;
            this.processor_quick_2.Text = "Info";
            this.processor_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // processor_quick_title_2
            // 
            this.processor_quick_title_2.AutoSize = true;
            this.processor_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.processor_quick_title_2.Name = "processor_quick_title_2";
            this.processor_quick_title_2.Size = new System.Drawing.Size(49, 17);
            this.processor_quick_title_2.TabIndex = 6;
            this.processor_quick_title_2.Text = "Model:";
            // 
            // processor_quick_1
            // 
            this.processor_quick_1.AutoSize = true;
            this.processor_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_1.Location = new System.Drawing.Point(20, 270);
            this.processor_quick_1.Name = "processor_quick_1";
            this.processor_quick_1.Size = new System.Drawing.Size(30, 17);
            this.processor_quick_1.TabIndex = 5;
            this.processor_quick_1.Text = "Info";
            this.processor_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // processor_quick_title_1
            // 
            this.processor_quick_title_1.AutoSize = true;
            this.processor_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.processor_quick_title_1.Name = "processor_quick_title_1";
            this.processor_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.processor_quick_title_1.TabIndex = 4;
            this.processor_quick_title_1.Text = "Manufacturer:";
            // 
            // processor_icon
            // 
            this.processor_icon.Image = global::CoreView.Properties.Resources.Processor;
            this.processor_icon.Location = new System.Drawing.Point(35, 18);
            this.processor_icon.Name = "processor_icon";
            this.processor_icon.Size = new System.Drawing.Size(128, 128);
            this.processor_icon.TabIndex = 3;
            this.processor_icon.TabStop = false;
            // 
            // processor_status
            // 
            this.processor_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.processor_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.processor_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processor_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processor_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.processor_status.Location = new System.Drawing.Point(7, 192);
            this.processor_status.Margin = new System.Windows.Forms.Padding(0);
            this.processor_status.Name = "processor_status";
            this.processor_status.Size = new System.Drawing.Size(70, 35);
            this.processor_status.TabIndex = 2;
            this.processor_status.Text = "N/A";
            this.processor_status.UseVisualStyleBackColor = false;
            // 
            // processor_list
            // 
            this.processor_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processor_list.FormattingEnabled = true;
            this.processor_list.Location = new System.Drawing.Point(7, 168);
            this.processor_list.Name = "processor_list";
            this.processor_list.Size = new System.Drawing.Size(187, 21);
            this.processor_list.TabIndex = 0;
            this.processor_list.SelectedIndexChanged += new System.EventHandler(this.processor_list_SelectedIndexChanged);
            // 
            // processor_graph_container
            // 
            this.processor_graph_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processor_graph_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.processor_graph_container.BackColor = System.Drawing.Color.DarkSlateGray;
            this.processor_graph_container.Location = new System.Drawing.Point(5, 4);
            this.processor_graph_container.Name = "processor_graph_container";
            this.processor_graph_container.Size = new System.Drawing.Size(567, 215);
            this.processor_graph_container.TabIndex = 5;
            // 
            // processor_details
            // 
            this.processor_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.processor_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_attribute,
            this.ch_value});
            this.processor_details.FullRowSelect = true;
            this.processor_details.Location = new System.Drawing.Point(5, 225);
            this.processor_details.Name = "processor_details";
            this.processor_details.Size = new System.Drawing.Size(567, 234);
            this.processor_details.TabIndex = 4;
            this.processor_details.UseCompatibleStateImageBehavior = false;
            this.processor_details.View = System.Windows.Forms.View.Details;
            // 
            // ch_attribute
            // 
            this.ch_attribute.Text = "Attribute";
            this.ch_attribute.Width = 210;
            // 
            // ch_value
            // 
            this.ch_value.Text = "Value";
            this.ch_value.Width = 353;
            // 
            // tab_motherboard
            // 
            this.tab_motherboard.Controls.Add(this.motherboard_container);
            this.tab_motherboard.Location = new System.Drawing.Point(4, 22);
            this.tab_motherboard.Name = "tab_motherboard";
            this.tab_motherboard.Padding = new System.Windows.Forms.Padding(3);
            this.tab_motherboard.Size = new System.Drawing.Size(778, 465);
            this.tab_motherboard.TabIndex = 1;
            this.tab_motherboard.Text = "Motherboard";
            this.tab_motherboard.UseVisualStyleBackColor = true;
            this.tab_motherboard.Enter += new System.EventHandler(this.populateMotherboardTab);
            // 
            // motherboard_container
            // 
            this.motherboard_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.motherboard_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.motherboard_container.IsSplitterFixed = true;
            this.motherboard_container.Location = new System.Drawing.Point(-4, 0);
            this.motherboard_container.Name = "motherboard_container";
            // 
            // motherboard_container.Panel1
            // 
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_4);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_title_4);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_3);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_title_3);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_2);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_title_2);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_1);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_quick_title_1);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_icon);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_status);
            this.motherboard_container.Panel1.Controls.Add(this.motherboard_list);
            // 
            // motherboard_container.Panel2
            // 
            this.motherboard_container.Panel2.Controls.Add(this.biosSepLabel);
            this.motherboard_container.Panel2.Controls.Add(this.bios_details);
            this.motherboard_container.Panel2.Controls.Add(this.motherboard_details);
            this.motherboard_container.Size = new System.Drawing.Size(782, 465);
            this.motherboard_container.SplitterDistance = 200;
            this.motherboard_container.TabIndex = 4;
            // 
            // motherboard_quick_4
            // 
            this.motherboard_quick_4.AutoSize = true;
            this.motherboard_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_4.Location = new System.Drawing.Point(20, 410);
            this.motherboard_quick_4.Name = "motherboard_quick_4";
            this.motherboard_quick_4.Size = new System.Drawing.Size(30, 17);
            this.motherboard_quick_4.TabIndex = 11;
            this.motherboard_quick_4.Text = "Info";
            this.motherboard_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // motherboard_quick_title_4
            // 
            this.motherboard_quick_title_4.AutoSize = true;
            this.motherboard_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_title_4.Location = new System.Drawing.Point(10, 387);
            this.motherboard_quick_title_4.Name = "motherboard_quick_title_4";
            this.motherboard_quick_title_4.Size = new System.Drawing.Size(86, 17);
            this.motherboard_quick_title_4.TabIndex = 10;
            this.motherboard_quick_title_4.Text = "BIOS Version:";
            // 
            // motherboard_quick_3
            // 
            this.motherboard_quick_3.AutoSize = true;
            this.motherboard_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_3.Location = new System.Drawing.Point(20, 364);
            this.motherboard_quick_3.Name = "motherboard_quick_3";
            this.motherboard_quick_3.Size = new System.Drawing.Size(30, 17);
            this.motherboard_quick_3.TabIndex = 9;
            this.motherboard_quick_3.Text = "Info";
            this.motherboard_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // motherboard_quick_title_3
            // 
            this.motherboard_quick_title_3.AutoSize = true;
            this.motherboard_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_title_3.Location = new System.Drawing.Point(10, 341);
            this.motherboard_quick_title_3.Name = "motherboard_quick_title_3";
            this.motherboard_quick_title_3.Size = new System.Drawing.Size(72, 17);
            this.motherboard_quick_title_3.TabIndex = 8;
            this.motherboard_quick_title_3.Text = "Product ID:";
            // 
            // motherboard_quick_2
            // 
            this.motherboard_quick_2.AutoSize = true;
            this.motherboard_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_2.Location = new System.Drawing.Point(20, 317);
            this.motherboard_quick_2.Name = "motherboard_quick_2";
            this.motherboard_quick_2.Size = new System.Drawing.Size(30, 17);
            this.motherboard_quick_2.TabIndex = 7;
            this.motherboard_quick_2.Text = "Info";
            this.motherboard_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // motherboard_quick_title_2
            // 
            this.motherboard_quick_title_2.AutoSize = true;
            this.motherboard_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.motherboard_quick_title_2.Name = "motherboard_quick_title_2";
            this.motherboard_quick_title_2.Size = new System.Drawing.Size(49, 17);
            this.motherboard_quick_title_2.TabIndex = 6;
            this.motherboard_quick_title_2.Text = "Model:";
            // 
            // motherboard_quick_1
            // 
            this.motherboard_quick_1.AutoSize = true;
            this.motherboard_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_1.Location = new System.Drawing.Point(20, 270);
            this.motherboard_quick_1.Name = "motherboard_quick_1";
            this.motherboard_quick_1.Size = new System.Drawing.Size(30, 17);
            this.motherboard_quick_1.TabIndex = 5;
            this.motherboard_quick_1.Text = "Info";
            this.motherboard_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // motherboard_quick_title_1
            // 
            this.motherboard_quick_title_1.AutoSize = true;
            this.motherboard_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.motherboard_quick_title_1.Name = "motherboard_quick_title_1";
            this.motherboard_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.motherboard_quick_title_1.TabIndex = 4;
            this.motherboard_quick_title_1.Text = "Manufacturer:";
            // 
            // motherboard_icon
            // 
            this.motherboard_icon.Image = global::CoreView.Properties.Resources.Motherboard;
            this.motherboard_icon.Location = new System.Drawing.Point(35, 18);
            this.motherboard_icon.Name = "motherboard_icon";
            this.motherboard_icon.Size = new System.Drawing.Size(128, 128);
            this.motherboard_icon.TabIndex = 4;
            this.motherboard_icon.TabStop = false;
            // 
            // motherboard_status
            // 
            this.motherboard_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.motherboard_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.motherboard_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motherboard_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherboard_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.motherboard_status.Location = new System.Drawing.Point(7, 192);
            this.motherboard_status.Margin = new System.Windows.Forms.Padding(0);
            this.motherboard_status.Name = "motherboard_status";
            this.motherboard_status.Size = new System.Drawing.Size(70, 35);
            this.motherboard_status.TabIndex = 2;
            this.motherboard_status.Text = "N/A";
            this.motherboard_status.UseVisualStyleBackColor = false;
            // 
            // motherboard_list
            // 
            this.motherboard_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.motherboard_list.FormattingEnabled = true;
            this.motherboard_list.Location = new System.Drawing.Point(7, 168);
            this.motherboard_list.Name = "motherboard_list";
            this.motherboard_list.Size = new System.Drawing.Size(187, 21);
            this.motherboard_list.TabIndex = 0;
            this.motherboard_list.SelectedIndexChanged += new System.EventHandler(this.motherboard_list_SelectedIndexChanged);
            // 
            // biosSepLabel
            // 
            this.biosSepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.biosSepLabel.AutoSize = true;
            this.biosSepLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biosSepLabel.Location = new System.Drawing.Point(3, 298);
            this.biosSepLabel.Name = "biosSepLabel";
            this.biosSepLabel.Size = new System.Drawing.Size(109, 17);
            this.biosSepLabel.TabIndex = 7;
            this.biosSepLabel.Text = "BIOS Information:";
            // 
            // bios_details
            // 
            this.bios_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bios_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader46,
            this.columnHeader47});
            this.bios_details.FullRowSelect = true;
            this.bios_details.Location = new System.Drawing.Point(5, 318);
            this.bios_details.Name = "bios_details";
            this.bios_details.Size = new System.Drawing.Size(567, 141);
            this.bios_details.TabIndex = 5;
            this.bios_details.UseCompatibleStateImageBehavior = false;
            this.bios_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "Attribute";
            this.columnHeader46.Width = 210;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "Value";
            this.columnHeader47.Width = 353;
            // 
            // motherboard_details
            // 
            this.motherboard_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.motherboard_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.motherboard_details.FullRowSelect = true;
            this.motherboard_details.Location = new System.Drawing.Point(5, 6);
            this.motherboard_details.Name = "motherboard_details";
            this.motherboard_details.Size = new System.Drawing.Size(567, 289);
            this.motherboard_details.TabIndex = 4;
            this.motherboard_details.UseCompatibleStateImageBehavior = false;
            this.motherboard_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Attribute";
            this.columnHeader1.Width = 210;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 353;
            // 
            // tab_memory
            // 
            this.tab_memory.Controls.Add(this.memory_container);
            this.tab_memory.Location = new System.Drawing.Point(4, 22);
            this.tab_memory.Name = "tab_memory";
            this.tab_memory.Padding = new System.Windows.Forms.Padding(3);
            this.tab_memory.Size = new System.Drawing.Size(778, 465);
            this.tab_memory.TabIndex = 2;
            this.tab_memory.Text = "Memory";
            this.tab_memory.UseVisualStyleBackColor = true;
            this.tab_memory.Enter += new System.EventHandler(this.populateMemoryTab);
            // 
            // memory_container
            // 
            this.memory_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memory_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.memory_container.IsSplitterFixed = true;
            this.memory_container.Location = new System.Drawing.Point(-4, 0);
            this.memory_container.Name = "memory_container";
            // 
            // memory_container.Panel1
            // 
            this.memory_container.Panel1.Controls.Add(this.memory_quick_4);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_title_4);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_3);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_title_3);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_2);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_title_2);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_1);
            this.memory_container.Panel1.Controls.Add(this.memory_quick_title_1);
            this.memory_container.Panel1.Controls.Add(this.memory_icon);
            this.memory_container.Panel1.Controls.Add(this.memory_status);
            this.memory_container.Panel1.Controls.Add(this.memory_list);
            // 
            // memory_container.Panel2
            // 
            this.memory_container.Panel2.Controls.Add(this.memory_details);
            this.memory_container.Size = new System.Drawing.Size(782, 465);
            this.memory_container.SplitterDistance = 200;
            this.memory_container.TabIndex = 4;
            // 
            // memory_quick_4
            // 
            this.memory_quick_4.AutoSize = true;
            this.memory_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_4.Location = new System.Drawing.Point(20, 410);
            this.memory_quick_4.Name = "memory_quick_4";
            this.memory_quick_4.Size = new System.Drawing.Size(30, 17);
            this.memory_quick_4.TabIndex = 11;
            this.memory_quick_4.Text = "Info";
            this.memory_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // memory_quick_title_4
            // 
            this.memory_quick_title_4.AutoSize = true;
            this.memory_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_title_4.Location = new System.Drawing.Point(10, 387);
            this.memory_quick_title_4.Name = "memory_quick_title_4";
            this.memory_quick_title_4.Size = new System.Drawing.Size(48, 17);
            this.memory_quick_title_4.TabIndex = 10;
            this.memory_quick_title_4.Text = "Speed:";
            // 
            // memory_quick_3
            // 
            this.memory_quick_3.AutoSize = true;
            this.memory_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_3.Location = new System.Drawing.Point(20, 364);
            this.memory_quick_3.Name = "memory_quick_3";
            this.memory_quick_3.Size = new System.Drawing.Size(30, 17);
            this.memory_quick_3.TabIndex = 9;
            this.memory_quick_3.Text = "Info";
            this.memory_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // memory_quick_title_3
            // 
            this.memory_quick_title_3.AutoSize = true;
            this.memory_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_title_3.Location = new System.Drawing.Point(10, 341);
            this.memory_quick_title_3.Name = "memory_quick_title_3";
            this.memory_quick_title_3.Size = new System.Drawing.Size(49, 17);
            this.memory_quick_title_3.TabIndex = 8;
            this.memory_quick_title_3.Text = "Socket:";
            // 
            // memory_quick_2
            // 
            this.memory_quick_2.AutoSize = true;
            this.memory_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_2.Location = new System.Drawing.Point(20, 317);
            this.memory_quick_2.Name = "memory_quick_2";
            this.memory_quick_2.Size = new System.Drawing.Size(30, 17);
            this.memory_quick_2.TabIndex = 7;
            this.memory_quick_2.Text = "Info";
            this.memory_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // memory_quick_title_2
            // 
            this.memory_quick_title_2.AutoSize = true;
            this.memory_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.memory_quick_title_2.Name = "memory_quick_title_2";
            this.memory_quick_title_2.Size = new System.Drawing.Size(49, 17);
            this.memory_quick_title_2.TabIndex = 6;
            this.memory_quick_title_2.Text = "Model:";
            // 
            // memory_quick_1
            // 
            this.memory_quick_1.AutoSize = true;
            this.memory_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_1.Location = new System.Drawing.Point(20, 270);
            this.memory_quick_1.Name = "memory_quick_1";
            this.memory_quick_1.Size = new System.Drawing.Size(30, 17);
            this.memory_quick_1.TabIndex = 5;
            this.memory_quick_1.Text = "Info";
            this.memory_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // memory_quick_title_1
            // 
            this.memory_quick_title_1.AutoSize = true;
            this.memory_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.memory_quick_title_1.Name = "memory_quick_title_1";
            this.memory_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.memory_quick_title_1.TabIndex = 4;
            this.memory_quick_title_1.Text = "Manufacturer:";
            // 
            // memory_icon
            // 
            this.memory_icon.Image = global::CoreView.Properties.Resources.Memory;
            this.memory_icon.Location = new System.Drawing.Point(35, 18);
            this.memory_icon.Name = "memory_icon";
            this.memory_icon.Size = new System.Drawing.Size(128, 128);
            this.memory_icon.TabIndex = 4;
            this.memory_icon.TabStop = false;
            // 
            // memory_status
            // 
            this.memory_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.memory_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.memory_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memory_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memory_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.memory_status.Location = new System.Drawing.Point(7, 192);
            this.memory_status.Margin = new System.Windows.Forms.Padding(0);
            this.memory_status.Name = "memory_status";
            this.memory_status.Size = new System.Drawing.Size(70, 35);
            this.memory_status.TabIndex = 2;
            this.memory_status.Text = "N/A";
            this.memory_status.UseVisualStyleBackColor = false;
            // 
            // memory_list
            // 
            this.memory_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memory_list.FormattingEnabled = true;
            this.memory_list.Location = new System.Drawing.Point(7, 168);
            this.memory_list.Name = "memory_list";
            this.memory_list.Size = new System.Drawing.Size(187, 21);
            this.memory_list.TabIndex = 0;
            this.memory_list.SelectedIndexChanged += new System.EventHandler(this.memory_list_SelectedIndexChanged);
            // 
            // memory_details
            // 
            this.memory_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.memory_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.memory_details.FullRowSelect = true;
            this.memory_details.Location = new System.Drawing.Point(5, 6);
            this.memory_details.Name = "memory_details";
            this.memory_details.Size = new System.Drawing.Size(567, 453);
            this.memory_details.TabIndex = 4;
            this.memory_details.UseCompatibleStateImageBehavior = false;
            this.memory_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Attribute";
            this.columnHeader3.Width = 210;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Value";
            this.columnHeader4.Width = 353;
            // 
            // tab_graphics
            // 
            this.tab_graphics.Controls.Add(this.graphics_container);
            this.tab_graphics.Location = new System.Drawing.Point(4, 22);
            this.tab_graphics.Name = "tab_graphics";
            this.tab_graphics.Padding = new System.Windows.Forms.Padding(3);
            this.tab_graphics.Size = new System.Drawing.Size(778, 465);
            this.tab_graphics.TabIndex = 3;
            this.tab_graphics.Text = "Graphics";
            this.tab_graphics.UseVisualStyleBackColor = true;
            this.tab_graphics.Enter += new System.EventHandler(this.populateGraphicsTab);
            // 
            // graphics_container
            // 
            this.graphics_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphics_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.graphics_container.IsSplitterFixed = true;
            this.graphics_container.Location = new System.Drawing.Point(-4, 0);
            this.graphics_container.Name = "graphics_container";
            // 
            // graphics_container.Panel1
            // 
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_4);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_title_4);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_3);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_title_3);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_2);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_title_2);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_1);
            this.graphics_container.Panel1.Controls.Add(this.graphics_quick_title_1);
            this.graphics_container.Panel1.Controls.Add(this.graphics_icon);
            this.graphics_container.Panel1.Controls.Add(this.graphics_status);
            this.graphics_container.Panel1.Controls.Add(this.graphics_list);
            // 
            // graphics_container.Panel2
            // 
            this.graphics_container.Panel2.Controls.Add(this.graphics_graph_container);
            this.graphics_container.Panel2.Controls.Add(this.graphics_details);
            this.graphics_container.Size = new System.Drawing.Size(782, 465);
            this.graphics_container.SplitterDistance = 200;
            this.graphics_container.TabIndex = 4;
            // 
            // graphics_quick_4
            // 
            this.graphics_quick_4.AutoSize = true;
            this.graphics_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_4.Location = new System.Drawing.Point(20, 410);
            this.graphics_quick_4.Name = "graphics_quick_4";
            this.graphics_quick_4.Size = new System.Drawing.Size(30, 17);
            this.graphics_quick_4.TabIndex = 11;
            this.graphics_quick_4.Text = "Info";
            this.graphics_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // graphics_quick_title_4
            // 
            this.graphics_quick_title_4.AutoSize = true;
            this.graphics_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_title_4.Location = new System.Drawing.Point(10, 387);
            this.graphics_quick_title_4.Name = "graphics_quick_title_4";
            this.graphics_quick_title_4.Size = new System.Drawing.Size(94, 17);
            this.graphics_quick_title_4.TabIndex = 10;
            this.graphics_quick_title_4.Text = "Driver Version:";
            // 
            // graphics_quick_3
            // 
            this.graphics_quick_3.AutoSize = true;
            this.graphics_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_3.Location = new System.Drawing.Point(20, 364);
            this.graphics_quick_3.Name = "graphics_quick_3";
            this.graphics_quick_3.Size = new System.Drawing.Size(30, 17);
            this.graphics_quick_3.TabIndex = 9;
            this.graphics_quick_3.Text = "Info";
            this.graphics_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // graphics_quick_title_3
            // 
            this.graphics_quick_title_3.AutoSize = true;
            this.graphics_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_title_3.Location = new System.Drawing.Point(10, 341);
            this.graphics_quick_title_3.Name = "graphics_quick_title_3";
            this.graphics_quick_title_3.Size = new System.Drawing.Size(132, 17);
            this.graphics_quick_title_3.TabIndex = 8;
            this.graphics_quick_title_3.Text = "Current Refresh Rate:";
            // 
            // graphics_quick_2
            // 
            this.graphics_quick_2.AutoSize = true;
            this.graphics_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_2.Location = new System.Drawing.Point(20, 317);
            this.graphics_quick_2.Name = "graphics_quick_2";
            this.graphics_quick_2.Size = new System.Drawing.Size(30, 17);
            this.graphics_quick_2.TabIndex = 7;
            this.graphics_quick_2.Text = "Info";
            this.graphics_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // graphics_quick_title_2
            // 
            this.graphics_quick_title_2.AutoSize = true;
            this.graphics_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.graphics_quick_title_2.Name = "graphics_quick_title_2";
            this.graphics_quick_title_2.Size = new System.Drawing.Size(72, 17);
            this.graphics_quick_title_2.TabIndex = 6;
            this.graphics_quick_title_2.Text = "Resolution:";
            // 
            // graphics_quick_1
            // 
            this.graphics_quick_1.AutoSize = true;
            this.graphics_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_1.Location = new System.Drawing.Point(20, 270);
            this.graphics_quick_1.Name = "graphics_quick_1";
            this.graphics_quick_1.Size = new System.Drawing.Size(30, 17);
            this.graphics_quick_1.TabIndex = 5;
            this.graphics_quick_1.Text = "Info";
            this.graphics_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // graphics_quick_title_1
            // 
            this.graphics_quick_title_1.AutoSize = true;
            this.graphics_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.graphics_quick_title_1.Name = "graphics_quick_title_1";
            this.graphics_quick_title_1.Size = new System.Drawing.Size(46, 17);
            this.graphics_quick_title_1.TabIndex = 4;
            this.graphics_quick_title_1.Text = "Name:";
            // 
            // graphics_icon
            // 
            this.graphics_icon.Image = global::CoreView.Properties.Resources.Graphics;
            this.graphics_icon.Location = new System.Drawing.Point(35, 18);
            this.graphics_icon.Name = "graphics_icon";
            this.graphics_icon.Size = new System.Drawing.Size(128, 128);
            this.graphics_icon.TabIndex = 4;
            this.graphics_icon.TabStop = false;
            // 
            // graphics_status
            // 
            this.graphics_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.graphics_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.graphics_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphics_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphics_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.graphics_status.Location = new System.Drawing.Point(7, 192);
            this.graphics_status.Margin = new System.Windows.Forms.Padding(0);
            this.graphics_status.Name = "graphics_status";
            this.graphics_status.Size = new System.Drawing.Size(70, 35);
            this.graphics_status.TabIndex = 2;
            this.graphics_status.Text = "N/A";
            this.graphics_status.UseVisualStyleBackColor = false;
            // 
            // graphics_list
            // 
            this.graphics_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphics_list.FormattingEnabled = true;
            this.graphics_list.Location = new System.Drawing.Point(7, 168);
            this.graphics_list.Name = "graphics_list";
            this.graphics_list.Size = new System.Drawing.Size(187, 21);
            this.graphics_list.TabIndex = 0;
            this.graphics_list.SelectedIndexChanged += new System.EventHandler(this.graphics_list_SelectedIndexChanged);
            // 
            // graphics_graph_container
            // 
            this.graphics_graph_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphics_graph_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.graphics_graph_container.BackColor = System.Drawing.Color.DarkSlateGray;
            this.graphics_graph_container.Location = new System.Drawing.Point(5, 4);
            this.graphics_graph_container.Name = "graphics_graph_container";
            this.graphics_graph_container.Size = new System.Drawing.Size(567, 215);
            this.graphics_graph_container.TabIndex = 6;
            // 
            // graphics_details
            // 
            this.graphics_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphics_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.graphics_details.FullRowSelect = true;
            this.graphics_details.Location = new System.Drawing.Point(5, 225);
            this.graphics_details.Name = "graphics_details";
            this.graphics_details.Size = new System.Drawing.Size(567, 234);
            this.graphics_details.TabIndex = 4;
            this.graphics_details.UseCompatibleStateImageBehavior = false;
            this.graphics_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Attribute";
            this.columnHeader5.Width = 210;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Value";
            this.columnHeader6.Width = 353;
            // 
            // tab_network
            // 
            this.tab_network.Controls.Add(this.network_container);
            this.tab_network.Location = new System.Drawing.Point(4, 22);
            this.tab_network.Name = "tab_network";
            this.tab_network.Padding = new System.Windows.Forms.Padding(3);
            this.tab_network.Size = new System.Drawing.Size(778, 465);
            this.tab_network.TabIndex = 4;
            this.tab_network.Text = "Network";
            this.tab_network.UseVisualStyleBackColor = true;
            this.tab_network.Enter += new System.EventHandler(this.populateNetworkTab);
            // 
            // network_container
            // 
            this.network_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.network_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.network_container.IsSplitterFixed = true;
            this.network_container.Location = new System.Drawing.Point(-4, 0);
            this.network_container.Name = "network_container";
            // 
            // network_container.Panel1
            // 
            this.network_container.Panel1.Controls.Add(this.network_quick_4);
            this.network_container.Panel1.Controls.Add(this.network_quick_title_4);
            this.network_container.Panel1.Controls.Add(this.network_quick_3);
            this.network_container.Panel1.Controls.Add(this.network_quick_title_3);
            this.network_container.Panel1.Controls.Add(this.network_quick_2);
            this.network_container.Panel1.Controls.Add(this.network_quick_title_2);
            this.network_container.Panel1.Controls.Add(this.network_quick_1);
            this.network_container.Panel1.Controls.Add(this.network_quick_title_1);
            this.network_container.Panel1.Controls.Add(this.network_icon);
            this.network_container.Panel1.Controls.Add(this.network_status);
            this.network_container.Panel1.Controls.Add(this.network_list);
            // 
            // network_container.Panel2
            // 
            this.network_container.Panel2.Controls.Add(this.network_graph_container);
            this.network_container.Panel2.Controls.Add(this.network_details);
            this.network_container.Size = new System.Drawing.Size(782, 465);
            this.network_container.SplitterDistance = 200;
            this.network_container.TabIndex = 4;
            // 
            // network_quick_4
            // 
            this.network_quick_4.AutoSize = true;
            this.network_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_4.Location = new System.Drawing.Point(20, 410);
            this.network_quick_4.Name = "network_quick_4";
            this.network_quick_4.Size = new System.Drawing.Size(30, 17);
            this.network_quick_4.TabIndex = 11;
            this.network_quick_4.Text = "Info";
            this.network_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // network_quick_title_4
            // 
            this.network_quick_title_4.AutoSize = true;
            this.network_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_title_4.Location = new System.Drawing.Point(10, 387);
            this.network_quick_title_4.Name = "network_quick_title_4";
            this.network_quick_title_4.Size = new System.Drawing.Size(77, 17);
            this.network_quick_title_4.TabIndex = 10;
            this.network_quick_title_4.Text = "Max Speed:";
            // 
            // network_quick_3
            // 
            this.network_quick_3.AutoSize = true;
            this.network_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_3.Location = new System.Drawing.Point(20, 364);
            this.network_quick_3.Name = "network_quick_3";
            this.network_quick_3.Size = new System.Drawing.Size(30, 17);
            this.network_quick_3.TabIndex = 9;
            this.network_quick_3.Text = "Info";
            this.network_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // network_quick_title_3
            // 
            this.network_quick_title_3.AutoSize = true;
            this.network_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_title_3.Location = new System.Drawing.Point(10, 341);
            this.network_quick_title_3.Name = "network_quick_title_3";
            this.network_quick_title_3.Size = new System.Drawing.Size(91, 17);
            this.network_quick_title_3.TabIndex = 8;
            this.network_quick_title_3.Text = "MAC Address:";
            // 
            // network_quick_2
            // 
            this.network_quick_2.AutoSize = true;
            this.network_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_2.Location = new System.Drawing.Point(20, 317);
            this.network_quick_2.Name = "network_quick_2";
            this.network_quick_2.Size = new System.Drawing.Size(30, 17);
            this.network_quick_2.TabIndex = 7;
            this.network_quick_2.Text = "Info";
            this.network_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // network_quick_title_2
            // 
            this.network_quick_title_2.AutoSize = true;
            this.network_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.network_quick_title_2.Name = "network_quick_title_2";
            this.network_quick_title_2.Size = new System.Drawing.Size(49, 17);
            this.network_quick_title_2.TabIndex = 6;
            this.network_quick_title_2.Text = "Model:";
            // 
            // network_quick_1
            // 
            this.network_quick_1.AutoSize = true;
            this.network_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_1.Location = new System.Drawing.Point(20, 270);
            this.network_quick_1.Name = "network_quick_1";
            this.network_quick_1.Size = new System.Drawing.Size(30, 17);
            this.network_quick_1.TabIndex = 5;
            this.network_quick_1.Text = "Info";
            this.network_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // network_quick_title_1
            // 
            this.network_quick_title_1.AutoSize = true;
            this.network_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.network_quick_title_1.Name = "network_quick_title_1";
            this.network_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.network_quick_title_1.TabIndex = 4;
            this.network_quick_title_1.Text = "Manufacturer:";
            // 
            // network_icon
            // 
            this.network_icon.Image = global::CoreView.Properties.Resources.Network;
            this.network_icon.Location = new System.Drawing.Point(35, 18);
            this.network_icon.Name = "network_icon";
            this.network_icon.Size = new System.Drawing.Size(128, 128);
            this.network_icon.TabIndex = 4;
            this.network_icon.TabStop = false;
            // 
            // network_status
            // 
            this.network_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.network_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.network_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.network_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.network_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.network_status.Location = new System.Drawing.Point(7, 192);
            this.network_status.Margin = new System.Windows.Forms.Padding(0);
            this.network_status.Name = "network_status";
            this.network_status.Size = new System.Drawing.Size(70, 35);
            this.network_status.TabIndex = 2;
            this.network_status.Text = "N/A";
            this.network_status.UseVisualStyleBackColor = false;
            // 
            // network_list
            // 
            this.network_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.network_list.FormattingEnabled = true;
            this.network_list.Location = new System.Drawing.Point(7, 168);
            this.network_list.Name = "network_list";
            this.network_list.Size = new System.Drawing.Size(187, 21);
            this.network_list.TabIndex = 0;
            this.network_list.SelectedIndexChanged += new System.EventHandler(this.network_list_SelectedIndexChanged);
            // 
            // network_graph_container
            // 
            this.network_graph_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.network_graph_container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.network_graph_container.BackColor = System.Drawing.Color.DarkSlateGray;
            this.network_graph_container.Location = new System.Drawing.Point(5, 4);
            this.network_graph_container.Name = "network_graph_container";
            this.network_graph_container.Size = new System.Drawing.Size(567, 215);
            this.network_graph_container.TabIndex = 5;
            // 
            // network_details
            // 
            this.network_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.network_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.network_details.FullRowSelect = true;
            this.network_details.Location = new System.Drawing.Point(5, 225);
            this.network_details.Name = "network_details";
            this.network_details.Size = new System.Drawing.Size(567, 234);
            this.network_details.TabIndex = 4;
            this.network_details.UseCompatibleStateImageBehavior = false;
            this.network_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Attribute";
            this.columnHeader7.Width = 210;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Value";
            this.columnHeader8.Width = 353;
            // 
            // tab_harddrive
            // 
            this.tab_harddrive.Controls.Add(this.harddrive_container);
            this.tab_harddrive.Location = new System.Drawing.Point(4, 22);
            this.tab_harddrive.Name = "tab_harddrive";
            this.tab_harddrive.Padding = new System.Windows.Forms.Padding(3);
            this.tab_harddrive.Size = new System.Drawing.Size(778, 465);
            this.tab_harddrive.TabIndex = 5;
            this.tab_harddrive.Text = "Hard Drives";
            this.tab_harddrive.UseVisualStyleBackColor = true;
            this.tab_harddrive.Enter += new System.EventHandler(this.populateHardDriveTab);
            // 
            // harddrive_container
            // 
            this.harddrive_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.harddrive_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.harddrive_container.IsSplitterFixed = true;
            this.harddrive_container.Location = new System.Drawing.Point(-4, 0);
            this.harddrive_container.Name = "harddrive_container";
            // 
            // harddrive_container.Panel1
            // 
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_4);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_title_4);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_3);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_title_3);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_2);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_title_2);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_1);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_quick_title_1);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_icon);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_status);
            this.harddrive_container.Panel1.Controls.Add(this.harddrive_list);
            // 
            // harddrive_container.Panel2
            // 
            this.harddrive_container.Panel2.Controls.Add(this.smartSepLabel);
            this.harddrive_container.Panel2.Controls.Add(this.harddrive_details);
            this.harddrive_container.Panel2.Controls.Add(this.smart_details);
            this.harddrive_container.Size = new System.Drawing.Size(782, 465);
            this.harddrive_container.SplitterDistance = 200;
            this.harddrive_container.TabIndex = 4;
            // 
            // harddrive_quick_4
            // 
            this.harddrive_quick_4.AutoSize = true;
            this.harddrive_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_4.Location = new System.Drawing.Point(20, 410);
            this.harddrive_quick_4.Name = "harddrive_quick_4";
            this.harddrive_quick_4.Size = new System.Drawing.Size(30, 17);
            this.harddrive_quick_4.TabIndex = 11;
            this.harddrive_quick_4.Text = "Info";
            this.harddrive_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // harddrive_quick_title_4
            // 
            this.harddrive_quick_title_4.AutoSize = true;
            this.harddrive_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_title_4.Location = new System.Drawing.Point(10, 387);
            this.harddrive_quick_title_4.Name = "harddrive_quick_title_4";
            this.harddrive_quick_title_4.Size = new System.Drawing.Size(133, 17);
            this.harddrive_quick_title_4.TabIndex = 10;
            this.harddrive_quick_title_4.Text = "Number of Partitions:";
            // 
            // harddrive_quick_3
            // 
            this.harddrive_quick_3.AutoSize = true;
            this.harddrive_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_3.Location = new System.Drawing.Point(20, 364);
            this.harddrive_quick_3.Name = "harddrive_quick_3";
            this.harddrive_quick_3.Size = new System.Drawing.Size(30, 17);
            this.harddrive_quick_3.TabIndex = 9;
            this.harddrive_quick_3.Text = "Info";
            this.harddrive_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // harddrive_quick_title_3
            // 
            this.harddrive_quick_title_3.AutoSize = true;
            this.harddrive_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_title_3.Location = new System.Drawing.Point(10, 341);
            this.harddrive_quick_title_3.Name = "harddrive_quick_title_3";
            this.harddrive_quick_title_3.Size = new System.Drawing.Size(60, 17);
            this.harddrive_quick_title_3.TabIndex = 8;
            this.harddrive_quick_title_3.Text = "Capacity:";
            // 
            // harddrive_quick_2
            // 
            this.harddrive_quick_2.AutoSize = true;
            this.harddrive_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_2.Location = new System.Drawing.Point(20, 317);
            this.harddrive_quick_2.Name = "harddrive_quick_2";
            this.harddrive_quick_2.Size = new System.Drawing.Size(30, 17);
            this.harddrive_quick_2.TabIndex = 7;
            this.harddrive_quick_2.Text = "Info";
            this.harddrive_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // harddrive_quick_title_2
            // 
            this.harddrive_quick_title_2.AutoSize = true;
            this.harddrive_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.harddrive_quick_title_2.Name = "harddrive_quick_title_2";
            this.harddrive_quick_title_2.Size = new System.Drawing.Size(49, 17);
            this.harddrive_quick_title_2.TabIndex = 6;
            this.harddrive_quick_title_2.Text = "Model:";
            // 
            // harddrive_quick_1
            // 
            this.harddrive_quick_1.AutoSize = true;
            this.harddrive_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_1.Location = new System.Drawing.Point(20, 270);
            this.harddrive_quick_1.Name = "harddrive_quick_1";
            this.harddrive_quick_1.Size = new System.Drawing.Size(30, 17);
            this.harddrive_quick_1.TabIndex = 5;
            this.harddrive_quick_1.Text = "Info";
            this.harddrive_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // harddrive_quick_title_1
            // 
            this.harddrive_quick_title_1.AutoSize = true;
            this.harddrive_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.harddrive_quick_title_1.Name = "harddrive_quick_title_1";
            this.harddrive_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.harddrive_quick_title_1.TabIndex = 4;
            this.harddrive_quick_title_1.Text = "Manufacturer:";
            // 
            // harddrive_icon
            // 
            this.harddrive_icon.Image = global::CoreView.Properties.Resources.HardDrive;
            this.harddrive_icon.Location = new System.Drawing.Point(35, 18);
            this.harddrive_icon.Name = "harddrive_icon";
            this.harddrive_icon.Size = new System.Drawing.Size(128, 128);
            this.harddrive_icon.TabIndex = 4;
            this.harddrive_icon.TabStop = false;
            // 
            // harddrive_status
            // 
            this.harddrive_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.harddrive_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.harddrive_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.harddrive_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harddrive_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.harddrive_status.Location = new System.Drawing.Point(7, 192);
            this.harddrive_status.Margin = new System.Windows.Forms.Padding(0);
            this.harddrive_status.Name = "harddrive_status";
            this.harddrive_status.Size = new System.Drawing.Size(70, 35);
            this.harddrive_status.TabIndex = 2;
            this.harddrive_status.Text = "N/A";
            this.harddrive_status.UseVisualStyleBackColor = false;
            // 
            // harddrive_list
            // 
            this.harddrive_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.harddrive_list.FormattingEnabled = true;
            this.harddrive_list.Location = new System.Drawing.Point(7, 168);
            this.harddrive_list.Name = "harddrive_list";
            this.harddrive_list.Size = new System.Drawing.Size(187, 21);
            this.harddrive_list.TabIndex = 0;
            this.harddrive_list.SelectedIndexChanged += new System.EventHandler(this.harddrive_list_SelectedIndexChanged);
            // 
            // smartSepLabel
            // 
            this.smartSepLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.smartSepLabel.AutoSize = true;
            this.smartSepLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smartSepLabel.Location = new System.Drawing.Point(3, 221);
            this.smartSepLabel.Name = "smartSepLabel";
            this.smartSepLabel.Size = new System.Drawing.Size(84, 17);
            this.smartSepLabel.TabIndex = 6;
            this.smartSepLabel.Text = "SMART Data:";
            // 
            // harddrive_details
            // 
            this.harddrive_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.harddrive_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.harddrive_details.FullRowSelect = true;
            this.harddrive_details.Location = new System.Drawing.Point(5, 6);
            this.harddrive_details.Name = "harddrive_details";
            this.harddrive_details.Size = new System.Drawing.Size(567, 212);
            this.harddrive_details.TabIndex = 5;
            this.harddrive_details.UseCompatibleStateImageBehavior = false;
            this.harddrive_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Attribute";
            this.columnHeader11.Width = 210;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Value";
            this.columnHeader12.Width = 353;
            // 
            // smart_details
            // 
            this.smart_details.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.smart_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.smart_details.FullRowSelect = true;
            this.smart_details.Location = new System.Drawing.Point(5, 241);
            this.smart_details.Name = "smart_details";
            this.smart_details.Size = new System.Drawing.Size(567, 218);
            this.smart_details.TabIndex = 4;
            this.smart_details.UseCompatibleStateImageBehavior = false;
            this.smart_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Attribute";
            this.columnHeader9.Width = 210;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Value";
            this.columnHeader10.Width = 353;
            // 
            // tab_optical
            // 
            this.tab_optical.Controls.Add(this.optical_container);
            this.tab_optical.Location = new System.Drawing.Point(4, 22);
            this.tab_optical.Name = "tab_optical";
            this.tab_optical.Padding = new System.Windows.Forms.Padding(3);
            this.tab_optical.Size = new System.Drawing.Size(778, 465);
            this.tab_optical.TabIndex = 6;
            this.tab_optical.Text = "Optical Drives";
            this.tab_optical.UseVisualStyleBackColor = true;
            this.tab_optical.Enter += new System.EventHandler(this.populateOpticalTab);
            // 
            // optical_container
            // 
            this.optical_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optical_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.optical_container.IsSplitterFixed = true;
            this.optical_container.Location = new System.Drawing.Point(-4, 0);
            this.optical_container.Name = "optical_container";
            // 
            // optical_container.Panel1
            // 
            this.optical_container.Panel1.Controls.Add(this.optical_quick_2);
            this.optical_container.Panel1.Controls.Add(this.optical_quick_title_2);
            this.optical_container.Panel1.Controls.Add(this.optical_quick_1);
            this.optical_container.Panel1.Controls.Add(this.optical_quick_title_1);
            this.optical_container.Panel1.Controls.Add(this.optical_icon);
            this.optical_container.Panel1.Controls.Add(this.optical_status);
            this.optical_container.Panel1.Controls.Add(this.optical_list);
            // 
            // optical_container.Panel2
            // 
            this.optical_container.Panel2.Controls.Add(this.optical_details);
            this.optical_container.Size = new System.Drawing.Size(782, 465);
            this.optical_container.SplitterDistance = 200;
            this.optical_container.TabIndex = 4;
            // 
            // optical_quick_2
            // 
            this.optical_quick_2.AutoSize = true;
            this.optical_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optical_quick_2.Location = new System.Drawing.Point(20, 317);
            this.optical_quick_2.Name = "optical_quick_2";
            this.optical_quick_2.Size = new System.Drawing.Size(30, 17);
            this.optical_quick_2.TabIndex = 7;
            this.optical_quick_2.Text = "Info";
            this.optical_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // optical_quick_title_2
            // 
            this.optical_quick_title_2.AutoSize = true;
            this.optical_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optical_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.optical_quick_title_2.Name = "optical_quick_title_2";
            this.optical_quick_title_2.Size = new System.Drawing.Size(46, 17);
            this.optical_quick_title_2.TabIndex = 6;
            this.optical_quick_title_2.Text = "Name:";
            // 
            // optical_quick_1
            // 
            this.optical_quick_1.AutoSize = true;
            this.optical_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optical_quick_1.Location = new System.Drawing.Point(20, 270);
            this.optical_quick_1.Name = "optical_quick_1";
            this.optical_quick_1.Size = new System.Drawing.Size(30, 17);
            this.optical_quick_1.TabIndex = 5;
            this.optical_quick_1.Text = "Info";
            this.optical_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // optical_quick_title_1
            // 
            this.optical_quick_title_1.AutoSize = true;
            this.optical_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optical_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.optical_quick_title_1.Name = "optical_quick_title_1";
            this.optical_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.optical_quick_title_1.TabIndex = 4;
            this.optical_quick_title_1.Text = "Manufacturer:";
            // 
            // optical_icon
            // 
            this.optical_icon.Image = global::CoreView.Properties.Resources.Optical;
            this.optical_icon.Location = new System.Drawing.Point(35, 18);
            this.optical_icon.Name = "optical_icon";
            this.optical_icon.Size = new System.Drawing.Size(128, 128);
            this.optical_icon.TabIndex = 4;
            this.optical_icon.TabStop = false;
            // 
            // optical_status
            // 
            this.optical_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.optical_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.optical_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optical_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optical_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.optical_status.Location = new System.Drawing.Point(7, 192);
            this.optical_status.Margin = new System.Windows.Forms.Padding(0);
            this.optical_status.Name = "optical_status";
            this.optical_status.Size = new System.Drawing.Size(70, 35);
            this.optical_status.TabIndex = 2;
            this.optical_status.Text = "N/A";
            this.optical_status.UseVisualStyleBackColor = false;
            // 
            // optical_list
            // 
            this.optical_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optical_list.FormattingEnabled = true;
            this.optical_list.Location = new System.Drawing.Point(7, 168);
            this.optical_list.Name = "optical_list";
            this.optical_list.Size = new System.Drawing.Size(187, 21);
            this.optical_list.TabIndex = 0;
            this.optical_list.SelectedIndexChanged += new System.EventHandler(this.optical_list_SelectedIndexChanged);
            // 
            // optical_details
            // 
            this.optical_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.optical_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14});
            this.optical_details.FullRowSelect = true;
            this.optical_details.Location = new System.Drawing.Point(5, 6);
            this.optical_details.Name = "optical_details";
            this.optical_details.Size = new System.Drawing.Size(567, 453);
            this.optical_details.TabIndex = 4;
            this.optical_details.UseCompatibleStateImageBehavior = false;
            this.optical_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Attribute";
            this.columnHeader13.Width = 210;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Value";
            this.columnHeader14.Width = 353;
            // 
            // tab_pci
            // 
            this.tab_pci.Controls.Add(this.pci_container);
            this.tab_pci.Location = new System.Drawing.Point(4, 22);
            this.tab_pci.Name = "tab_pci";
            this.tab_pci.Padding = new System.Windows.Forms.Padding(3);
            this.tab_pci.Size = new System.Drawing.Size(778, 465);
            this.tab_pci.TabIndex = 7;
            this.tab_pci.Text = "PCI Slots";
            this.tab_pci.UseVisualStyleBackColor = true;
            this.tab_pci.Enter += new System.EventHandler(this.populatePCITab);
            // 
            // pci_container
            // 
            this.pci_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pci_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.pci_container.IsSplitterFixed = true;
            this.pci_container.Location = new System.Drawing.Point(-4, 0);
            this.pci_container.Name = "pci_container";
            // 
            // pci_container.Panel1
            // 
            this.pci_container.Panel1.Controls.Add(this.pci_quick_2);
            this.pci_container.Panel1.Controls.Add(this.pci_quick_title_2);
            this.pci_container.Panel1.Controls.Add(this.pci_quick_1);
            this.pci_container.Panel1.Controls.Add(this.pci_quick_title_1);
            this.pci_container.Panel1.Controls.Add(this.pci_icon);
            this.pci_container.Panel1.Controls.Add(this.pci_status);
            this.pci_container.Panel1.Controls.Add(this.pci_list);
            // 
            // pci_container.Panel2
            // 
            this.pci_container.Panel2.Controls.Add(this.pci_details);
            this.pci_container.Size = new System.Drawing.Size(782, 465);
            this.pci_container.SplitterDistance = 200;
            this.pci_container.TabIndex = 4;
            // 
            // pci_quick_2
            // 
            this.pci_quick_2.AutoSize = true;
            this.pci_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pci_quick_2.Location = new System.Drawing.Point(20, 317);
            this.pci_quick_2.Name = "pci_quick_2";
            this.pci_quick_2.Size = new System.Drawing.Size(30, 17);
            this.pci_quick_2.TabIndex = 7;
            this.pci_quick_2.Text = "Info";
            this.pci_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // pci_quick_title_2
            // 
            this.pci_quick_title_2.AutoSize = true;
            this.pci_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pci_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.pci_quick_title_2.Name = "pci_quick_title_2";
            this.pci_quick_title_2.Size = new System.Drawing.Size(49, 17);
            this.pci_quick_title_2.TabIndex = 6;
            this.pci_quick_title_2.Text = "Model:";
            // 
            // pci_quick_1
            // 
            this.pci_quick_1.AutoSize = true;
            this.pci_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pci_quick_1.Location = new System.Drawing.Point(20, 270);
            this.pci_quick_1.Name = "pci_quick_1";
            this.pci_quick_1.Size = new System.Drawing.Size(30, 17);
            this.pci_quick_1.TabIndex = 5;
            this.pci_quick_1.Text = "Info";
            this.pci_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // pci_quick_title_1
            // 
            this.pci_quick_title_1.AutoSize = true;
            this.pci_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pci_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.pci_quick_title_1.Name = "pci_quick_title_1";
            this.pci_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.pci_quick_title_1.TabIndex = 4;
            this.pci_quick_title_1.Text = "Manufacturer:";
            // 
            // pci_icon
            // 
            this.pci_icon.Image = global::CoreView.Properties.Resources.PCI;
            this.pci_icon.Location = new System.Drawing.Point(35, 18);
            this.pci_icon.Name = "pci_icon";
            this.pci_icon.Size = new System.Drawing.Size(128, 128);
            this.pci_icon.TabIndex = 4;
            this.pci_icon.TabStop = false;
            // 
            // pci_status
            // 
            this.pci_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.pci_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pci_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pci_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pci_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pci_status.Location = new System.Drawing.Point(7, 192);
            this.pci_status.Margin = new System.Windows.Forms.Padding(0);
            this.pci_status.Name = "pci_status";
            this.pci_status.Size = new System.Drawing.Size(70, 35);
            this.pci_status.TabIndex = 2;
            this.pci_status.Text = "N/A";
            this.pci_status.UseVisualStyleBackColor = false;
            // 
            // pci_list
            // 
            this.pci_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pci_list.FormattingEnabled = true;
            this.pci_list.Location = new System.Drawing.Point(7, 168);
            this.pci_list.Name = "pci_list";
            this.pci_list.Size = new System.Drawing.Size(187, 21);
            this.pci_list.TabIndex = 0;
            this.pci_list.SelectedIndexChanged += new System.EventHandler(this.pci_list_SelectedIndexChanged);
            // 
            // pci_details
            // 
            this.pci_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pci_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader16});
            this.pci_details.FullRowSelect = true;
            this.pci_details.Location = new System.Drawing.Point(5, 6);
            this.pci_details.Name = "pci_details";
            this.pci_details.Size = new System.Drawing.Size(567, 453);
            this.pci_details.TabIndex = 4;
            this.pci_details.UseCompatibleStateImageBehavior = false;
            this.pci_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Attribute";
            this.columnHeader15.Width = 210;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Value";
            this.columnHeader16.Width = 353;
            // 
            // tab_usb
            // 
            this.tab_usb.Controls.Add(this.usb_container);
            this.tab_usb.Location = new System.Drawing.Point(4, 22);
            this.tab_usb.Name = "tab_usb";
            this.tab_usb.Padding = new System.Windows.Forms.Padding(3);
            this.tab_usb.Size = new System.Drawing.Size(778, 465);
            this.tab_usb.TabIndex = 8;
            this.tab_usb.Text = "USB Devices";
            this.tab_usb.UseVisualStyleBackColor = true;
            this.tab_usb.Enter += new System.EventHandler(this.populateUSBTab);
            // 
            // usb_container
            // 
            this.usb_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usb_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.usb_container.IsSplitterFixed = true;
            this.usb_container.Location = new System.Drawing.Point(-4, 0);
            this.usb_container.Name = "usb_container";
            // 
            // usb_container.Panel1
            // 
            this.usb_container.Panel1.Controls.Add(this.usb_quick_2);
            this.usb_container.Panel1.Controls.Add(this.usb_quick_title_2);
            this.usb_container.Panel1.Controls.Add(this.usb_quick_1);
            this.usb_container.Panel1.Controls.Add(this.usb_quick_title_1);
            this.usb_container.Panel1.Controls.Add(this.usb_icon);
            this.usb_container.Panel1.Controls.Add(this.usb_status);
            this.usb_container.Panel1.Controls.Add(this.usb_list);
            // 
            // usb_container.Panel2
            // 
            this.usb_container.Panel2.Controls.Add(this.usb_details);
            this.usb_container.Size = new System.Drawing.Size(782, 465);
            this.usb_container.SplitterDistance = 200;
            this.usb_container.TabIndex = 4;
            // 
            // usb_quick_2
            // 
            this.usb_quick_2.AutoSize = true;
            this.usb_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb_quick_2.Location = new System.Drawing.Point(20, 317);
            this.usb_quick_2.Name = "usb_quick_2";
            this.usb_quick_2.Size = new System.Drawing.Size(30, 17);
            this.usb_quick_2.TabIndex = 7;
            this.usb_quick_2.Text = "Info";
            this.usb_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // usb_quick_title_2
            // 
            this.usb_quick_title_2.AutoSize = true;
            this.usb_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb_quick_title_2.Location = new System.Drawing.Point(10, 293);
            this.usb_quick_title_2.Name = "usb_quick_title_2";
            this.usb_quick_title_2.Size = new System.Drawing.Size(46, 17);
            this.usb_quick_title_2.TabIndex = 6;
            this.usb_quick_title_2.Text = "Name:";
            // 
            // usb_quick_1
            // 
            this.usb_quick_1.AutoSize = true;
            this.usb_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb_quick_1.Location = new System.Drawing.Point(20, 270);
            this.usb_quick_1.Name = "usb_quick_1";
            this.usb_quick_1.Size = new System.Drawing.Size(30, 17);
            this.usb_quick_1.TabIndex = 5;
            this.usb_quick_1.Text = "Info";
            this.usb_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // usb_quick_title_1
            // 
            this.usb_quick_title_1.AutoSize = true;
            this.usb_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb_quick_title_1.Location = new System.Drawing.Point(10, 247);
            this.usb_quick_title_1.Name = "usb_quick_title_1";
            this.usb_quick_title_1.Size = new System.Drawing.Size(89, 17);
            this.usb_quick_title_1.TabIndex = 4;
            this.usb_quick_title_1.Text = "Manufacturer:";
            // 
            // usb_icon
            // 
            this.usb_icon.Image = global::CoreView.Properties.Resources.USB;
            this.usb_icon.Location = new System.Drawing.Point(35, 18);
            this.usb_icon.Name = "usb_icon";
            this.usb_icon.Size = new System.Drawing.Size(128, 128);
            this.usb_icon.TabIndex = 4;
            this.usb_icon.TabStop = false;
            // 
            // usb_status
            // 
            this.usb_status.BackgroundImage = global::CoreView.Properties.Resources.StatWarn;
            this.usb_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.usb_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usb_status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usb_status.Location = new System.Drawing.Point(7, 192);
            this.usb_status.Margin = new System.Windows.Forms.Padding(0);
            this.usb_status.Name = "usb_status";
            this.usb_status.Size = new System.Drawing.Size(70, 35);
            this.usb_status.TabIndex = 2;
            this.usb_status.Text = "N/A";
            this.usb_status.UseVisualStyleBackColor = false;
            // 
            // usb_list
            // 
            this.usb_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usb_list.FormattingEnabled = true;
            this.usb_list.Location = new System.Drawing.Point(7, 168);
            this.usb_list.Name = "usb_list";
            this.usb_list.Size = new System.Drawing.Size(187, 21);
            this.usb_list.TabIndex = 0;
            this.usb_list.SelectedIndexChanged += new System.EventHandler(this.usb_list_SelectedIndexChanged);
            // 
            // usb_details
            // 
            this.usb_details.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.usb_details.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18});
            this.usb_details.FullRowSelect = true;
            this.usb_details.Location = new System.Drawing.Point(5, 6);
            this.usb_details.Name = "usb_details";
            this.usb_details.Size = new System.Drawing.Size(567, 453);
            this.usb_details.TabIndex = 4;
            this.usb_details.UseCompatibleStateImageBehavior = false;
            this.usb_details.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Attribute";
            this.columnHeader17.Width = 210;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Value";
            this.columnHeader18.Width = 353;
            // 
            // tab_overview
            // 
            this.tab_overview.Controls.Add(this.overview_container);
            this.tab_overview.Location = new System.Drawing.Point(4, 29);
            this.tab_overview.Name = "tab_overview";
            this.tab_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tab_overview.Size = new System.Drawing.Size(781, 487);
            this.tab_overview.TabIndex = 0;
            this.tab_overview.Text = "Overview";
            this.tab_overview.UseVisualStyleBackColor = true;
            // 
            // overview_container
            // 
            this.overview_container.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.overview_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.overview_container.IsSplitterFixed = true;
            this.overview_container.Location = new System.Drawing.Point(-4, 0);
            this.overview_container.Name = "overview_container";
            // 
            // overview_container.Panel1
            // 
            this.overview_container.Panel1.Controls.Add(this.overview_quick_6);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_title_6);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_5);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_title_5);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_4);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_title_4);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_3);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_title_3);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_2);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_title_2);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_1);
            this.overview_container.Panel1.Controls.Add(this.overview_quick_title_1);
            this.overview_container.Panel1.Controls.Add(this.overview_icon);
            this.overview_container.Size = new System.Drawing.Size(782, 487);
            this.overview_container.SplitterDistance = 380;
            this.overview_container.TabIndex = 5;
            // 
            // overview_quick_6
            // 
            this.overview_quick_6.AutoSize = true;
            this.overview_quick_6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_6.Location = new System.Drawing.Point(22, 422);
            this.overview_quick_6.Name = "overview_quick_6";
            this.overview_quick_6.Size = new System.Drawing.Size(30, 17);
            this.overview_quick_6.TabIndex = 15;
            this.overview_quick_6.Text = "Info";
            this.overview_quick_6.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // overview_quick_title_6
            // 
            this.overview_quick_title_6.AutoSize = true;
            this.overview_quick_title_6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_title_6.Location = new System.Drawing.Point(12, 398);
            this.overview_quick_title_6.Name = "overview_quick_title_6";
            this.overview_quick_title_6.Size = new System.Drawing.Size(80, 17);
            this.overview_quick_title_6.TabIndex = 14;
            this.overview_quick_title_6.Text = "Architecture:";
            // 
            // overview_quick_5
            // 
            this.overview_quick_5.AutoSize = true;
            this.overview_quick_5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_5.Location = new System.Drawing.Point(22, 374);
            this.overview_quick_5.Name = "overview_quick_5";
            this.overview_quick_5.Size = new System.Drawing.Size(30, 17);
            this.overview_quick_5.TabIndex = 13;
            this.overview_quick_5.Text = "Info";
            this.overview_quick_5.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // overview_quick_title_5
            // 
            this.overview_quick_title_5.AutoSize = true;
            this.overview_quick_title_5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_title_5.Location = new System.Drawing.Point(12, 350);
            this.overview_quick_title_5.Name = "overview_quick_title_5";
            this.overview_quick_title_5.Size = new System.Drawing.Size(115, 17);
            this.overview_quick_title_5.TabIndex = 12;
            this.overview_quick_title_5.Text = "Operating System:";
            // 
            // overview_quick_4
            // 
            this.overview_quick_4.AutoSize = true;
            this.overview_quick_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_4.Location = new System.Drawing.Point(22, 327);
            this.overview_quick_4.Name = "overview_quick_4";
            this.overview_quick_4.Size = new System.Drawing.Size(30, 17);
            this.overview_quick_4.TabIndex = 11;
            this.overview_quick_4.Text = "Info";
            this.overview_quick_4.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // overview_quick_title_4
            // 
            this.overview_quick_title_4.AutoSize = true;
            this.overview_quick_title_4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_title_4.Location = new System.Drawing.Point(12, 304);
            this.overview_quick_title_4.Name = "overview_quick_title_4";
            this.overview_quick_title_4.Size = new System.Drawing.Size(109, 17);
            this.overview_quick_title_4.TabIndex = 10;
            this.overview_quick_title_4.Text = "Network Domain:";
            // 
            // overview_quick_3
            // 
            this.overview_quick_3.AutoSize = true;
            this.overview_quick_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_3.Location = new System.Drawing.Point(22, 281);
            this.overview_quick_3.Name = "overview_quick_3";
            this.overview_quick_3.Size = new System.Drawing.Size(30, 17);
            this.overview_quick_3.TabIndex = 9;
            this.overview_quick_3.Text = "Info";
            this.overview_quick_3.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // overview_quick_title_3
            // 
            this.overview_quick_title_3.AutoSize = true;
            this.overview_quick_title_3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_title_3.Location = new System.Drawing.Point(12, 258);
            this.overview_quick_title_3.Name = "overview_quick_title_3";
            this.overview_quick_title_3.Size = new System.Drawing.Size(97, 17);
            this.overview_quick_title_3.TabIndex = 8;
            this.overview_quick_title_3.Text = "Primary Owner:";
            // 
            // overview_quick_2
            // 
            this.overview_quick_2.AutoSize = true;
            this.overview_quick_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_2.Location = new System.Drawing.Point(22, 234);
            this.overview_quick_2.Name = "overview_quick_2";
            this.overview_quick_2.Size = new System.Drawing.Size(30, 17);
            this.overview_quick_2.TabIndex = 7;
            this.overview_quick_2.Text = "Info";
            this.overview_quick_2.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // overview_quick_title_2
            // 
            this.overview_quick_title_2.AutoSize = true;
            this.overview_quick_title_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_title_2.Location = new System.Drawing.Point(12, 210);
            this.overview_quick_title_2.Name = "overview_quick_title_2";
            this.overview_quick_title_2.Size = new System.Drawing.Size(108, 17);
            this.overview_quick_title_2.TabIndex = 6;
            this.overview_quick_title_2.Text = "Computer Name:";
            // 
            // overview_quick_1
            // 
            this.overview_quick_1.AutoSize = true;
            this.overview_quick_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_1.Location = new System.Drawing.Point(22, 187);
            this.overview_quick_1.Name = "overview_quick_1";
            this.overview_quick_1.Size = new System.Drawing.Size(30, 17);
            this.overview_quick_1.TabIndex = 5;
            this.overview_quick_1.Text = "Info";
            this.overview_quick_1.MouseHover += new System.EventHandler(this.showFullTextToolTip);
            // 
            // overview_quick_title_1
            // 
            this.overview_quick_title_1.AutoSize = true;
            this.overview_quick_title_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overview_quick_title_1.Location = new System.Drawing.Point(12, 164);
            this.overview_quick_title_1.Name = "overview_quick_title_1";
            this.overview_quick_title_1.Size = new System.Drawing.Size(111, 17);
            this.overview_quick_title_1.TabIndex = 4;
            this.overview_quick_title_1.Text = "OEM Information:";
            // 
            // overview_icon
            // 
            this.overview_icon.Location = new System.Drawing.Point(35, 18);
            this.overview_icon.Name = "overview_icon";
            this.overview_icon.Size = new System.Drawing.Size(128, 128);
            this.overview_icon.TabIndex = 4;
            this.overview_icon.TabStop = false;
            // 
            // tab_cont_main
            // 
            this.tab_cont_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_cont_main.Controls.Add(this.tab_overview);
            this.tab_cont_main.Controls.Add(this.tab_hardware);
            this.tab_cont_main.Controls.Add(this.tab_drivers);
            this.tab_cont_main.Controls.Add(this.tab_software);
            this.tab_cont_main.Controls.Add(this.tab_addresses);
            this.tab_cont_main.Controls.Add(this.tab_irqs);
            this.tab_cont_main.Controls.Add(this.tab_irqsharing);
            this.tab_cont_main.Controls.Add(this.tab_processes);
            this.tab_cont_main.Controls.Add(this.tab_logs);
            this.tab_cont_main.Controls.Add(this.tab_database);
            this.tab_cont_main.ItemSize = new System.Drawing.Size(57, 25);
            this.tab_cont_main.Location = new System.Drawing.Point(0, 22);
            this.tab_cont_main.Name = "tab_cont_main";
            this.tab_cont_main.SelectedIndex = 0;
            this.tab_cont_main.Size = new System.Drawing.Size(789, 520);
            this.tab_cont_main.TabIndex = 0;
            this.tab_cont_main.Enter += new System.EventHandler(this.populateLogsTab);
            // 
            // status_strip
            // 
            this.status_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_strip_label,
            this.status_strip_progress});
            this.status_strip.Location = new System.Drawing.Point(0, 540);
            this.status_strip.Name = "status_strip";
            this.status_strip.Size = new System.Drawing.Size(784, 22);
            this.status_strip.TabIndex = 2;
            this.status_strip.Text = "Status";
            // 
            // status_strip_label
            // 
            this.status_strip_label.Name = "status_strip_label";
            this.status_strip_label.Size = new System.Drawing.Size(106, 17);
            this.status_strip_label.Text = "Current Operation:";
            // 
            // status_strip_progress
            // 
            this.status_strip_progress.Name = "status_strip_progress";
            this.status_strip_progress.Size = new System.Drawing.Size(100, 16);
            // 
            // showFullText
            // 
            this.showFullText.AutoPopDelay = 5000;
            this.showFullText.InitialDelay = 100;
            this.showFullText.ReshowDelay = 100;
            // 
            // MainWindow
            // 
            this.AcceptButton = this.addresses_search_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.status_strip);
            this.Controls.Add(this.tab_cont_main);
            this.Controls.Add(this.main_menu_strip);
            this.Icon = global::CoreView.Properties.Resources.Logo;
            this.MainMenuStrip = this.main_menu_strip;
            this.MinimumSize = new System.Drawing.Size(540, 460);
            this.Name = "MainWindow";
            this.Text = "Core View Diagnostic Utility";
            this.main_menu_strip.ResumeLayout(false);
            this.main_menu_strip.PerformLayout();
            this.tab_database.ResumeLayout(false);
            this.database_container.Panel1.ResumeLayout(false);
            this.database_container.Panel1.PerformLayout();
            this.database_container.Panel2.ResumeLayout(false);
            this.database_container.Panel2.PerformLayout();
            this.database_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.database_icon)).EndInit();
            this.database_complaint_panel.ResumeLayout(false);
            this.database_complaint_panel.PerformLayout();
            this.tab_logs.ResumeLayout(false);
            this.logs_container.Panel1.ResumeLayout(false);
            this.logs_container.Panel1.PerformLayout();
            this.logs_container.Panel2.ResumeLayout(false);
            this.logs_container.Panel2.PerformLayout();
            this.logs_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logs_icon)).EndInit();
            this.tab_processes.ResumeLayout(false);
            this.processes_container.Panel1.ResumeLayout(false);
            this.processes_container.Panel1.PerformLayout();
            this.processes_container.Panel2.ResumeLayout(false);
            this.processes_container.Panel2.PerformLayout();
            this.processes_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processes_icon)).EndInit();
            this.tab_irqs.ResumeLayout(false);
            this.irqs_container.Panel1.ResumeLayout(false);
            this.irqs_container.Panel1.PerformLayout();
            this.irqs_container.Panel2.ResumeLayout(false);
            this.irqs_container.Panel2.PerformLayout();
            this.irqs_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.irqs_icon)).EndInit();
            this.tab_addresses.ResumeLayout(false);
            this.addresses_container.Panel1.ResumeLayout(false);
            this.addresses_container.Panel1.PerformLayout();
            this.addresses_container.Panel2.ResumeLayout(false);
            this.addresses_container.Panel2.PerformLayout();
            this.addresses_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addresses_icon)).EndInit();
            this.tab_irqsharing.ResumeLayout(false);
            this.irqsharing_container.Panel1.ResumeLayout(false);
            this.irqsharing_container.Panel1.PerformLayout();
            this.irqsharing_container.Panel2.ResumeLayout(false);
            this.irqsharing_container.Panel2.PerformLayout();
            this.irqsharing_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.irqsharing_icon)).EndInit();
            this.tab_software.ResumeLayout(false);
            this.software_container.Panel1.ResumeLayout(false);
            this.software_container.Panel1.PerformLayout();
            this.software_container.Panel2.ResumeLayout(false);
            this.software_container.Panel2.PerformLayout();
            this.software_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.software_icon)).EndInit();
            this.tab_drivers.ResumeLayout(false);
            this.drivers_container.Panel1.ResumeLayout(false);
            this.drivers_container.Panel1.PerformLayout();
            this.drivers_container.Panel2.ResumeLayout(false);
            this.drivers_container.Panel2.PerformLayout();
            this.drivers_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drivers_icon)).EndInit();
            this.tab_hardware.ResumeLayout(false);
            this.tab_cont_hardware.ResumeLayout(false);
            this.tab_processor.ResumeLayout(false);
            this.processor_container.Panel1.ResumeLayout(false);
            this.processor_container.Panel1.PerformLayout();
            this.processor_container.Panel2.ResumeLayout(false);
            this.processor_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processor_icon)).EndInit();
            this.tab_motherboard.ResumeLayout(false);
            this.motherboard_container.Panel1.ResumeLayout(false);
            this.motherboard_container.Panel1.PerformLayout();
            this.motherboard_container.Panel2.ResumeLayout(false);
            this.motherboard_container.Panel2.PerformLayout();
            this.motherboard_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.motherboard_icon)).EndInit();
            this.tab_memory.ResumeLayout(false);
            this.memory_container.Panel1.ResumeLayout(false);
            this.memory_container.Panel1.PerformLayout();
            this.memory_container.Panel2.ResumeLayout(false);
            this.memory_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memory_icon)).EndInit();
            this.tab_graphics.ResumeLayout(false);
            this.graphics_container.Panel1.ResumeLayout(false);
            this.graphics_container.Panel1.PerformLayout();
            this.graphics_container.Panel2.ResumeLayout(false);
            this.graphics_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphics_icon)).EndInit();
            this.tab_network.ResumeLayout(false);
            this.network_container.Panel1.ResumeLayout(false);
            this.network_container.Panel1.PerformLayout();
            this.network_container.Panel2.ResumeLayout(false);
            this.network_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.network_icon)).EndInit();
            this.tab_harddrive.ResumeLayout(false);
            this.harddrive_container.Panel1.ResumeLayout(false);
            this.harddrive_container.Panel1.PerformLayout();
            this.harddrive_container.Panel2.ResumeLayout(false);
            this.harddrive_container.Panel2.PerformLayout();
            this.harddrive_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.harddrive_icon)).EndInit();
            this.tab_optical.ResumeLayout(false);
            this.optical_container.Panel1.ResumeLayout(false);
            this.optical_container.Panel1.PerformLayout();
            this.optical_container.Panel2.ResumeLayout(false);
            this.optical_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.optical_icon)).EndInit();
            this.tab_pci.ResumeLayout(false);
            this.pci_container.Panel1.ResumeLayout(false);
            this.pci_container.Panel1.PerformLayout();
            this.pci_container.Panel2.ResumeLayout(false);
            this.pci_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pci_icon)).EndInit();
            this.tab_usb.ResumeLayout(false);
            this.usb_container.Panel1.ResumeLayout(false);
            this.usb_container.Panel1.PerformLayout();
            this.usb_container.Panel2.ResumeLayout(false);
            this.usb_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usb_icon)).EndInit();
            this.tab_overview.ResumeLayout(false);
            this.overview_container.Panel1.ResumeLayout(false);
            this.overview_container.Panel1.PerformLayout();
            this.overview_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.overview_icon)).EndInit();
            this.tab_cont_main.ResumeLayout(false);
            this.status_strip.ResumeLayout(false);
            this.status_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip main_menu_strip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem reloadConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motherboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem memoryDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem networkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opticalDrivesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCICardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSBDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressIRQSharingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addressMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iRQMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runningProcessesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem userManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer updater;
        private System.Windows.Forms.TabPage tab_database;
        private System.Windows.Forms.SplitContainer database_container;
        private System.Windows.Forms.Button database_query_stop;
        private System.Windows.Forms.Button database_add;
        private System.Windows.Forms.Button database_options;
        private System.Windows.Forms.Button database_query_start;
        private System.Windows.Forms.CheckBox ComplaintSoundIssue;
        private System.Windows.Forms.CheckBox ComplaintSluggish;
        private System.Windows.Forms.CheckBox ComplaintSlowBoot;
        private System.Windows.Forms.CheckBox ComplaintScreenLag;
        private System.Windows.Forms.CheckBox ComplaintProgramIssue;
        private System.Windows.Forms.CheckBox ComplaintLockouts;
        private System.Windows.Forms.CheckBox ComplaintInputIssue;
        private System.Windows.Forms.CheckBox ComplaintDisplayIssue;
        private System.Windows.Forms.CheckBox ComplaintDeviceIssue;
        private System.Windows.Forms.CheckBox ComplaintBSOD;
        private System.Windows.Forms.Label database_complaints_lbl;
        private System.Windows.Forms.TextBox database_comments;
        private System.Windows.Forms.Button database_search_btn;
        private System.Windows.Forms.TextBox database_search;
        private System.Windows.Forms.ListView database_details;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.TabPage tab_logs;
        private System.Windows.Forms.TabPage tab_processes;
        private System.Windows.Forms.SplitContainer processes_container;
        private System.Windows.Forms.Button processes_search_btn;
        private System.Windows.Forms.TextBox processes_search;
        private System.Windows.Forms.ListView processes_details;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.TabPage tab_irqs;
        private System.Windows.Forms.SplitContainer irqs_container;
        private System.Windows.Forms.Button irqs_search_btn;
        private System.Windows.Forms.TextBox irqs_search;
        private System.Windows.Forms.ListView irqs_details;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.TabPage tab_addresses;
        private System.Windows.Forms.SplitContainer addresses_container;
        private System.Windows.Forms.Button addresses_search_btn;
        private System.Windows.Forms.TextBox addresses_search;
        private System.Windows.Forms.ListView addresses_details;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.TabPage tab_irqsharing;
        private System.Windows.Forms.SplitContainer irqsharing_container;
        private System.Windows.Forms.Button irqsharing_search_btn;
        private System.Windows.Forms.TextBox irqsharing_search;
        private System.Windows.Forms.ListView irqsharing_details;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.TabPage tab_software;
        private System.Windows.Forms.SplitContainer software_container;
        private System.Windows.Forms.Button software_search_btn;
        private System.Windows.Forms.TextBox software_search;
        private System.Windows.Forms.ListView software_details;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.TabPage tab_drivers;
        private System.Windows.Forms.SplitContainer drivers_container;
        private System.Windows.Forms.Button drivers_search_btn;
        private System.Windows.Forms.TextBox driver_search;
        private System.Windows.Forms.ListView driver_details;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.TabPage tab_hardware;
        private System.Windows.Forms.TabControl tab_cont_hardware;
        private System.Windows.Forms.TabPage tab_processor;
        private System.Windows.Forms.SplitContainer processor_container;
        private System.Windows.Forms.Button processor_status;
        private System.Windows.Forms.ComboBox processor_list;
        private System.Windows.Forms.Panel processor_graph_container;
        private System.Windows.Forms.ListView processor_details;
        private System.Windows.Forms.ColumnHeader ch_attribute;
        private System.Windows.Forms.ColumnHeader ch_value;
        private System.Windows.Forms.TabPage tab_motherboard;
        private System.Windows.Forms.SplitContainer motherboard_container;
        private System.Windows.Forms.Button motherboard_status;
        private System.Windows.Forms.ComboBox motherboard_list;
        private System.Windows.Forms.ListView motherboard_details;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TabPage tab_memory;
        private System.Windows.Forms.SplitContainer memory_container;
        private System.Windows.Forms.Button memory_status;
        private System.Windows.Forms.ComboBox memory_list;
        private System.Windows.Forms.ListView memory_details;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TabPage tab_graphics;
        private System.Windows.Forms.SplitContainer graphics_container;
        private System.Windows.Forms.Button graphics_status;
        private System.Windows.Forms.ComboBox graphics_list;
        private System.Windows.Forms.ListView graphics_details;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tab_network;
        private System.Windows.Forms.SplitContainer network_container;
        private System.Windows.Forms.Button network_status;
        private System.Windows.Forms.ComboBox network_list;
        private System.Windows.Forms.Panel network_graph_container;
        private System.Windows.Forms.ListView network_details;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TabPage tab_harddrive;
        private System.Windows.Forms.SplitContainer harddrive_container;
        private System.Windows.Forms.Button harddrive_status;
        private System.Windows.Forms.ComboBox harddrive_list;
        private System.Windows.Forms.ListView harddrive_details;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView smart_details;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TabPage tab_optical;
        private System.Windows.Forms.SplitContainer optical_container;
        private System.Windows.Forms.Button optical_status;
        private System.Windows.Forms.ComboBox optical_list;
        private System.Windows.Forms.ListView optical_details;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.TabPage tab_pci;
        private System.Windows.Forms.SplitContainer pci_container;
        private System.Windows.Forms.Button pci_status;
        private System.Windows.Forms.ComboBox pci_list;
        private System.Windows.Forms.ListView pci_details;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.TabPage tab_usb;
        private System.Windows.Forms.SplitContainer usb_container;
        private System.Windows.Forms.Button usb_status;
        private System.Windows.Forms.ComboBox usb_list;
        private System.Windows.Forms.ListView usb_details;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.TabPage tab_overview;
        private System.Windows.Forms.TabControl tab_cont_main;
        private System.Windows.Forms.SplitContainer logs_container;
        private System.Windows.Forms.TextBox logs_details_extend;
        private System.Windows.Forms.Button logs_search_btn;
        private System.Windows.Forms.TextBox logs_search;
        private System.Windows.Forms.ListView logs_details;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.PictureBox processor_icon;
        private System.Windows.Forms.PictureBox motherboard_icon;
        private System.Windows.Forms.PictureBox memory_icon;
        private System.Windows.Forms.PictureBox graphics_icon;
        private System.Windows.Forms.PictureBox network_icon;
        private System.Windows.Forms.PictureBox harddrive_icon;
        private System.Windows.Forms.PictureBox optical_icon;
        private System.Windows.Forms.PictureBox pci_icon;
        private System.Windows.Forms.PictureBox usb_icon;
        private System.Windows.Forms.Panel database_complaint_panel;
        private System.Windows.Forms.Panel processes_graph_container;
        private System.Windows.Forms.PictureBox software_icon;
        private System.Windows.Forms.PictureBox drivers_icon;
        private System.Windows.Forms.PictureBox irqsharing_icon;
        private System.Windows.Forms.PictureBox database_icon;
        private System.Windows.Forms.PictureBox logs_icon;
        private System.Windows.Forms.PictureBox processes_icon;
        private System.Windows.Forms.PictureBox irqs_icon;
        private System.Windows.Forms.PictureBox addresses_icon;
        private System.Windows.Forms.Label processor_quick_title_1;
        private System.Windows.Forms.Label processor_quick_title_3;
        private System.Windows.Forms.Label processor_quick_2;
        private System.Windows.Forms.Label processor_quick_title_2;
        private System.Windows.Forms.Label processor_quick_1;
        private System.Windows.Forms.Label processor_quick_4;
        private System.Windows.Forms.Label processor_quick_title_4;
        private System.Windows.Forms.Label processor_quick_3;
        private System.Windows.Forms.Label motherboard_quick_title_1;
        private System.Windows.Forms.Label motherboard_quick_title_3;
        private System.Windows.Forms.Label motherboard_quick_2;
        private System.Windows.Forms.Label motherboard_quick_title_2;
        private System.Windows.Forms.Label motherboard_quick_1;
        private System.Windows.Forms.Label motherboard_quick_4;
        private System.Windows.Forms.Label motherboard_quick_title_4;
        private System.Windows.Forms.Label motherboard_quick_3;
        private System.Windows.Forms.Label memory_quick_title_1;
        private System.Windows.Forms.Label memory_quick_title_3;
        private System.Windows.Forms.Label memory_quick_2;
        private System.Windows.Forms.Label memory_quick_title_2;
        private System.Windows.Forms.Label memory_quick_1;
        private System.Windows.Forms.Label memory_quick_4;
        private System.Windows.Forms.Label memory_quick_title_4;
        private System.Windows.Forms.Label memory_quick_3;
        private System.Windows.Forms.Label graphics_quick_title_1;
        private System.Windows.Forms.Label graphics_quick_title_3;
        private System.Windows.Forms.Label graphics_quick_2;
        private System.Windows.Forms.Label graphics_quick_title_2;
        private System.Windows.Forms.Label graphics_quick_1;
        private System.Windows.Forms.Label graphics_quick_4;
        private System.Windows.Forms.Label graphics_quick_title_4;
        private System.Windows.Forms.Label graphics_quick_3;
        private System.Windows.Forms.Label network_quick_title_1;
        private System.Windows.Forms.Label network_quick_title_3;
        private System.Windows.Forms.Label network_quick_2;
        private System.Windows.Forms.Label network_quick_title_2;
        private System.Windows.Forms.Label network_quick_1;
        private System.Windows.Forms.Label network_quick_4;
        private System.Windows.Forms.Label network_quick_title_4;
        private System.Windows.Forms.Label network_quick_3;
        private System.Windows.Forms.Label harddrive_quick_title_1;
        private System.Windows.Forms.Label harddrive_quick_title_3;
        private System.Windows.Forms.Label harddrive_quick_2;
        private System.Windows.Forms.Label harddrive_quick_title_2;
        private System.Windows.Forms.Label harddrive_quick_1;
        private System.Windows.Forms.Label harddrive_quick_4;
        private System.Windows.Forms.Label harddrive_quick_title_4;
        private System.Windows.Forms.Label harddrive_quick_3;
        private System.Windows.Forms.Label optical_quick_title_1;
        private System.Windows.Forms.Label optical_quick_2;
        private System.Windows.Forms.Label optical_quick_title_2;
        private System.Windows.Forms.Label optical_quick_1;
        private System.Windows.Forms.Label pci_quick_title_1;
        private System.Windows.Forms.Label pci_quick_2;
        private System.Windows.Forms.Label pci_quick_title_2;
        private System.Windows.Forms.Label pci_quick_1;
        private System.Windows.Forms.Label usb_quick_title_1;
        private System.Windows.Forms.Label usb_quick_2;
        private System.Windows.Forms.Label usb_quick_title_2;
        private System.Windows.Forms.Label usb_quick_1;
        private System.Windows.Forms.ListView bios_details;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.Button database_load_computer;
        private System.Windows.Forms.Label processes_quick_1;
        private System.Windows.Forms.Label processes_quick_title_1;
        private System.Windows.Forms.Label irqs_quick_1;
        private System.Windows.Forms.Label irqs_quick_title_1;
        private System.Windows.Forms.Label addresses_quick_1;
        private System.Windows.Forms.Label addresses_quick_title_1;
        private System.Windows.Forms.Label irqsharing_quick_1;
        private System.Windows.Forms.Label irqsharing_quick_title_1;
        private System.Windows.Forms.Label software_quick_1;
        private System.Windows.Forms.Label software_quick_title_1;
        private System.Windows.Forms.Label driver_quick_1;
        private System.Windows.Forms.Label driver_quick_title_1;
        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.ToolStripStatusLabel status_strip_label;
        private System.Windows.Forms.ToolStripProgressBar status_strip_progress;
        private System.Windows.Forms.Panel graphics_graph_container;
        private System.Windows.Forms.ToolStripMenuItem abortDataRetreivalToolStripMenuItem;
        private System.Windows.Forms.SplitContainer overview_container;
        private System.Windows.Forms.Label overview_quick_4;
        private System.Windows.Forms.Label overview_quick_title_4;
        private System.Windows.Forms.Label overview_quick_3;
        private System.Windows.Forms.Label overview_quick_title_3;
        private System.Windows.Forms.Label overview_quick_2;
        private System.Windows.Forms.Label overview_quick_title_2;
        private System.Windows.Forms.Label overview_quick_1;
        private System.Windows.Forms.Label overview_quick_title_1;
        private System.Windows.Forms.PictureBox overview_icon;
        private System.Windows.Forms.Label overview_quick_5;
        private System.Windows.Forms.Label overview_quick_title_5;
        private System.Windows.Forms.Label overview_quick_6;
        private System.Windows.Forms.Label overview_quick_title_6;
        private System.Windows.Forms.Label smartSepLabel;
        private System.Windows.Forms.Label biosSepLabel;
        private System.Windows.Forms.ToolTip showFullText;
        private System.Windows.Forms.Label logs_quick_1;
        private System.Windows.Forms.Label logs_quick_title_1;
        private System.Windows.Forms.Label logs_quick_4;
        private System.Windows.Forms.Label logs_quick_title_4;
        private System.Windows.Forms.Label logs_quick_3;
        private System.Windows.Forms.Label logs_quick_2;
        private System.Windows.Forms.Label logs_quick_title_2;
    }
}