using System;
using System.Windows.Forms;

namespace CoreView
{
    public partial class DatabaseAdd : Form
    {
        public string Comments { get; private set; }

        public DatabaseAdd()
        {
            InitializeComponent();
        }

        private void database_add_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void database_add_ok_Click(object sender, EventArgs e)
        {
            Comments = this.database_add_comments.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
