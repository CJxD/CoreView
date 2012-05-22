using System;
using System.Windows.Forms;

namespace CoreView
{
    partial class MainWindow
    {
        private void showFullTextToolTip(object sender, EventArgs e)
        {
            Label label = sender as Label;
            showFullText.Show(label.Text, label);
        }
    }
}
