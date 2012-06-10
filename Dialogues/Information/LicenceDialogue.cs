using System.Windows.Forms;

namespace CoreView
{
    public partial class LicenceDialogue : Form
    {
        public LicenceDialogue()
        {
            InitializeComponent();
        }

        private void cv_license_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license_box.Text = Properties.Resources.cv_gpl;
        }

        private void ohm_license_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license_box.Text = Properties.Resources.ohm_gpl;
        }

        private void winring_license_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license_box.Text = Properties.Resources.winring_gpl;
        }

        private void image_license_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            license_box.Text = Properties.Resources.images_gpl;
        }
    }
}
