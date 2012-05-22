using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace CoreView
{
    public partial class AboutDialogue : Form
    {
        public AboutDialogue()
        {
            InitializeComponent();
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            this.version_label.Text = "Version: " + fvi.FileVersion;
        }

        private void project_home_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/CJxD/CoreView");
        }

        private void licensing_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicenceDialogue licence = new LicenceDialogue();
            licence.ShowDialog();
        }
    }
}
