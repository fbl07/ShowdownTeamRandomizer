using ShowdownTeamRando.Models;
using System.Data;
using System.Runtime.Versioning;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        public required Configs Configs { get; set; }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txtDesktopLocation.Text = Configs.ShowdownDesktopFileLocation;
            chkImportOnStartup.Checked = Configs.ImportFolderOnStartup;

            lbIgnoredGameModes.Items.AddRange(Configs.IgnoredGameModes.ToArray());
            lbIgnoredFolders.Items.AddRange(Configs.IgnoredFolders.ToArray());
            lbIgnoredTeams.Items.AddRange(Configs.IgnoredTeams.ToArray());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            fdbBrowseDialog.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"My Games\Pokemon Showdown\Teams");
            fdbBrowseDialog.SelectedPath = Configs.ShowdownDesktopFileLocation;

            if (fdbBrowseDialog.ShowDialog() == DialogResult.OK)
                txtDesktopLocation.Text = fdbBrowseDialog.SelectedPath;
        }

        private void btnAddIgnoredGameMode_Click(object sender, EventArgs e)
        {
            lbIgnoredGameModes.Items.Add(txtNewIgnoredGameMode.Text);
            lbIgnoredGameModes.SelectedIndex = lbIgnoredGameModes.Items.Count - 1;
        }

        private void btnRemoveIgnoredGameMode_Click(object sender, EventArgs e)
        {
            lbIgnoredGameModes.Items.Remove(lbIgnoredGameModes.SelectedItem);

            if (lbIgnoredGameModes.Items.Count == 0)
            {
                lbIgnoredGameModes.SelectedIndex = -1;
                btnRemoveIgnoredGameMode.Enabled = false;
            }
        }

        private void btnAddIgnoredFolder_Click(object sender, EventArgs e)
        {
            lbIgnoredFolders.Items.Add(txtNewIgnoredFolder.Text);
            lbIgnoredFolders.SelectedIndex = lbIgnoredFolders.Items.Count - 1;
        }

        private void btnRemoveIgnoredFolder_Click(object sender, EventArgs e)
        {
            lbIgnoredFolders.Items.Remove(lbIgnoredFolders.SelectedItem);

            if (lbIgnoredFolders.Items.Count == 0)
            {
                lbIgnoredFolders.SelectedIndex = -1;
                btnRemoveIgnoredFolder.Enabled = false;
            }
        }

        private void btnAddIgnoredTeam_Click(object sender, EventArgs e)
        {
            lbIgnoredTeams.Items.Add(txtNewIgnoredTeam.Text);
            lbIgnoredTeams.SelectedIndex = lbIgnoredTeams.Items.Count - 1;
        }

        private void btnRemoveIgnoredTeam_Click(object sender, EventArgs e)
        {
            lbIgnoredTeams.Items.Remove(lbIgnoredTeams.SelectedItem);

            if (lbIgnoredTeams.Items.Count == 0)
            {
                lbIgnoredTeams.SelectedIndex = -1;
                btnRemoveIgnoredTeam.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configs.ShowdownDesktopFileLocation = txtDesktopLocation.Text;
            Configs.ImportFolderOnStartup = chkImportOnStartup.Checked;

            Configs.IgnoredGameModes = lbIgnoredGameModes.Items.Cast<string>().ToList();
            Configs.IgnoredFolders = lbIgnoredFolders.Items.Cast<string>().ToList();
            Configs.IgnoredTeams = lbIgnoredTeams.Items.Cast<string>().ToList();
        }

        private void lbIgnoredGameModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveIgnoredGameMode.Enabled = lbIgnoredGameModes.SelectedIndex != -1;
        }

        private void lbIgnoredFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveIgnoredFolder.Enabled = lbIgnoredFolders.SelectedIndex != -1;
        }

        private void lbIgnoredTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveIgnoredTeam.Enabled = lbIgnoredTeams.SelectedIndex != -1;
        }

        private void txtNewIgnoredGameMode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddIgnoredGameMode.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtNewIgnoredFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddIgnoredFolder.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtNewIgnoredTeam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddIgnoredTeam.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
