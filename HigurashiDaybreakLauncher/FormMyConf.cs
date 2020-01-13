using System;
using System.Windows.Forms;

namespace HigurashiDaybreakConfig
{
    public partial class FormMyConf : Form
    {

        private DXEnvironment config;

        public FormMyConf()
        {
            InitializeComponent();
        }

        public void setConfig(ref DXEnvironment conf)
        {
            this.config = conf;
            this.txtGameFolder.Text = this.config.getGameLocation();
        }

        private void saveConfig()
        {
            this.config.setGameLocation(this.txtGameFolder.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.saveConfig();
            this.Close();
        }

        private void btnBrowseGameFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogue = new FolderBrowserDialog();
            if (dialogue.ShowDialog() == DialogResult.OK)
            {
                this.txtGameFolder.Text = dialogue.SelectedPath;
            }

        }
    }
}
