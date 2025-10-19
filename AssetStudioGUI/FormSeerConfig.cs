using System;
using System.Windows.Forms;

namespace AssetStudioGUI
{
    public partial class FormSeerConfig : Form
    {
        public FormSeerConfig()
        {
            InitializeComponent();
        }

        private void FormSeerConfig_Load(object sender, EventArgs e)
        {
            filterHead.Text = Properties.Settings.Default.seerFilterHead;
            folderHead.Text = Properties.Settings.Default.seerFolderHead;
            filterBody.Text = Properties.Settings.Default.seerFilterBody;
            folderBody.Text = Properties.Settings.Default.seerFolderBody;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.seerFilterHead = filterHead.Text;
            Properties.Settings.Default.seerFolderHead = folderHead.Text;
            Properties.Settings.Default.seerFilterBody = filterBody.Text;
            Properties.Settings.Default.seerFolderBody = folderBody.Text;

            Properties.Settings.Default.Save();
        }
    }
}
