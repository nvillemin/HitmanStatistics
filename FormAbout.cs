using System.Windows.Forms;

namespace HitmanStatistics {
    public partial class FormAbout : Form {
        const string version = "2.2.4";

        public FormAbout() {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, System.EventArgs e) {
            LabelVersion.Text = "Version: " + version;
        }

        private void LinkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("mailto:" + LinkLabelEmail.Text);
        }

        private void LinkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            System.Diagnostics.Process.Start("https://github.com/nvillemin/HitmanStatistics");
        }

        private void ButtonOK_Click(object sender, System.EventArgs e) {
            this.Close();
        }
    }
}
