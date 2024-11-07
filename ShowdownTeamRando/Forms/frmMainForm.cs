using ShowdownTeamRando.Models;
using System.Runtime.Versioning;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    public partial class frmMainForm : Form
    {
        protected Configs Configs { get; set; } = new Configs();

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            var loadedConfigs = SettingsHelper.LoadSettings();
            if (loadedConfigs == null)
                loadedConfigs = new Configs();

            this.Configs = loadedConfigs;

            if (Configs.ImportFolderOnStartup)
            {
                var result = ImportHelper.ImportFromShowdownDesktop(this.Configs);

                Configs.TeamFolders = result.Folders;
                Configs.GameModes = result.GameModes;

                SettingsHelper.SaveSettings(this.Configs);
            }
        }

        private void btnTeamConfigs_Click(object sender, EventArgs e)
        {
            var configDialog = new frmTeamsConfig() { Configs = Configs };
            var result = configDialog.ShowDialog();

            if (result == DialogResult.OK)
                SettingsHelper.SaveSettings(Configs);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsDialog = new frmSettings() { Configs = Configs };
            var result = settingsDialog.ShowDialog();

            if (result == DialogResult.OK)
                SettingsHelper.SaveSettings(Configs);
        }
    }
}
