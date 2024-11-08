using ShowdownTeamRando.Models;
using System.Reflection;
using System.Runtime.Versioning;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    public partial class frmMainForm : Form
    {
        protected Configs Configs { get; set; } = new Configs();
        protected Category? CurrentCategory { get; set; }
        protected RandomizationResult? CurrentRando { get; set; }

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            lblVersion.Text = $"Version {Assembly.GetEntryAssembly()?.GetName().Version?.ToString(3)}";

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
            LoadTeams();
        }

        private void btnTeamConfigs_Click(object sender, EventArgs e)
        {
            var configDialog = new frmTeamsConfig() { Configs = Configs };
            var result = configDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                SettingsHelper.SaveSettings(Configs);
                LoadTeams();
                cboCategories_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            var settingsDialog = new frmSettings() { Configs = Configs };
            var result = settingsDialog.ShowDialog();

            if (result == DialogResult.OK)
                SettingsHelper.SaveSettings(Configs);
        }

        private void rbFolders_CheckedChanged(object sender, EventArgs e)
        {
            Configs.UseGameModes = !rbFolders.Checked;
            lblFolder.Text = "Folder";
            LoadTeams();
        }

        private void rbGameFormats_CheckedChanged(object sender, EventArgs e)
        {
            Configs.UseGameModes = rbGameFormats.Checked;
            lblFolder.Text = "Game Mode";
            LoadTeams();
        }

        private void cboCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRandomize.Enabled = cboCategories.SelectedIndex > -1;

            if (cboCategories.SelectedIndex == -1)
                return;

            string info = "";

            if (!Configs.UseGameModes)
            {
                CurrentCategory = Configs.TeamFolders[cboCategories.SelectedItem as string];

                info = $"This folder has {CurrentCategory.Teams.Count} teams ";

                if (CurrentCategory.Teams.All(x => x.GameMode == CurrentCategory.Teams.First().GameMode))
                    info += $"all of which for {CurrentCategory.Teams.First().GameMode}.";
                else
                    info += "for multiple game modes.";
            }
            else
            {
                CurrentCategory = Configs.GameModes[cboCategories.SelectedItem as string];

                var folderCount = CurrentCategory.Teams.GroupBy(x => x.Folder).Count();

                info = $"This game mode has {CurrentCategory.Teams.Count} teams from {folderCount} folder{(folderCount > 1 ? "s" : "")}.";
            }

            
            lblCatInfo.Text = info;
        }

        private async void btnRandomize_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            btnRandomize.Enabled = false;

            CurrentRando = await RandomizationHelper.RandomizeCategory(CurrentCategory);
            RefreshRando();

            this.UseWaitCursor = false;
            btnRandomize.Enabled = true;
        }

        private void btnNextTeam_Click(object sender, EventArgs e)
        {
            if (CurrentRando.UpcomingTeams.Count == 0)
            {
                CurrentRando = null;
                RefreshRando();
                return;
            }

            CurrentRando.CurrentTeam = CurrentRando.UpcomingTeams.Dequeue();
            RefreshRando();
        }

        protected void LoadTeams()
        {
            cboCategories.Items.Clear();
            cboCategories.SelectedIndex = -1;
            CurrentCategory = null;

            if (!Configs.UseGameModes)
            {
                foreach (var folder in Configs.TeamFolders)
                {
                    cboCategories.Items.Add(folder.Key ?? "");
                }

                if (cboCategories.Items.Count > 0)
                    cboCategories.SelectedIndex = 0;

            }
            else
            {
                foreach (var gameMode in Configs.GameModes)
                {
                    cboCategories.Items.Add(gameMode.Key ?? "");
                }

                if (cboCategories.Items.Count > 0)
                    cboCategories.SelectedIndex = 0;
            }
        }

        protected void RefreshRando()
        {
            lbUpcomingTeams.Items.Clear();

            if (CurrentRando == null)
            {
                txtCurrentTeam.Text = "";
                btnNextTeam.Enabled = false;

                txtTeamName.Text = "";
                txtGameMode.Text = "";
                txtFolder.Text = "";
            }
            else
            {
                txtCurrentTeam.Text = CurrentRando.CurrentTeam.Name;
                lbUpcomingTeams.Items.AddRange(CurrentRando.UpcomingTeams.Select(t => t.Name).ToArray());
                btnNextTeam.Enabled = true;

                txtTeamName.Text = CurrentRando.CurrentTeam.Name;
                txtGameMode.Text = CurrentRando.CurrentTeam.GameMode;
                txtFolder.Text = CurrentRando.CurrentTeam.Folder;
            }

        }
    }
}
