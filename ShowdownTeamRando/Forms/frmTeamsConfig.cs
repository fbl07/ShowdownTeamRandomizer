using ShowdownTeamRando.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowdownTeamRando
{
    [SupportedOSPlatform("windows")]
    public partial class frmTeamsConfig : Form
    {
        public required Configs Configs { get; set; }

        public frmTeamsConfig()
        {
            InitializeComponent();
        }
        private void frmTeamsConfig_Load(object sender, EventArgs e)
        {
            rbFolders.Checked = !Configs.UseGameModes;
            LoadTeams();
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
            lbTeams.Items.Clear();
            lbTeams.SelectedIndex = -1;
            btnAdd.Enabled = (cboCategories.SelectedIndex != -1 && txtNewTeamName.Text.Length > 0);

            lbTeams_SelectedIndexChanged(sender, e);

            if (cboCategories.SelectedIndex == -1)
                return;

            if (!Configs.UseGameModes)
            {
                var folderName = cboCategories.SelectedItem as string;

                var folder = Configs.TeamFolders[folderName];

                foreach (var team in folder?.Teams)
                {
                    lbTeams.Items.Add(team.Name ?? "");
                }
            }
            else
            {
                var gameModeName = cboCategories.SelectedItem as string;

                var gameMode = Configs.GameModes[gameModeName];

                foreach (var team in gameMode?.Teams)
                {
                    lbTeams.Items.Add(team.Name ?? "");
                }
            }
        }

        private void lbTeams_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUpdate.Enabled = lbTeams.SelectedIndex != -1;
            btnDelete.Enabled = lbTeams.SelectedIndex != -1;

            if (lbTeams.SelectedIndex == -1)
            {
                txtTeamName.Text = "";
                txtGameMode.Text = "";
                txtFolder.Text = "";
            }
            else
            {
                var team = FindTeam();

                txtTeamName.Text = team.Name;
                txtGameMode.Text = team.GameMode;
                txtFolder.Text = team.Folder;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var team = FindTeam();

            int selectedIndex = lbTeams.SelectedIndex;

            team.Name = txtTeamName.Text;
            cboCategories_SelectedIndexChanged(btnUpdate, e);
            lbTeams.SelectedIndex = selectedIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var team = FindTeam();

            if (rbFolders.Checked)
                Configs.TeamFolders[cboCategories.SelectedItem as string].Teams.Remove(team);
            else
                Configs.GameModes[cboCategories.SelectedItem as string].Teams.Remove(team);

            cboCategories_SelectedIndexChanged(btnUpdate, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newTeam = new Team()
            {
                Name = txtNewTeamName.Text,
            };

            if (rbFolders.Checked)
            {
                newTeam.Folder = cboCategories.SelectedItem as string;
                Configs.TeamFolders[cboCategories.SelectedItem as string].Teams.Add(newTeam);
            }
            else
            {
                newTeam.GameMode = cboCategories.SelectedItem as string;
                Configs.GameModes[cboCategories.SelectedItem as string].Teams.Add(newTeam);
            }

            cboCategories_SelectedIndexChanged(btnUpdate, e);
            lbTeams.SelectedIndex = lbTeams.Items.Count - 1;
        }

        private void btnImportFolder_Click(object sender, EventArgs e)
        {
            var result = ImportHelper.ImportFromShowdownDesktop(Configs);
            Configs.TeamFolders = result.Folders;
            Configs.GameModes = result.GameModes;

            LoadTeams();
        }

        private void btnImportPaste_Click(object sender, EventArgs e)
        {
            var pasteDialog = new frmPasteDialog();

            if (pasteDialog.ShowDialog() == DialogResult.OK)
            {
                var result = ImportHelper.ImportFromPaste(Configs, pasteDialog.Paste);
                Configs.TeamFolders = result.Folders;
                Configs.GameModes = result.GameModes;

                LoadTeams();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            Configs.TeamFolders.Clear();
            Configs.GameModes.Clear();
            cboCategories.SelectedIndex = -1;
            lbTeams.SelectedIndex = -1;
            LoadTeams();
        }

        private void txtNewTeamName_TextChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = (cboCategories.SelectedIndex != -1 && txtNewTeamName.Text.Length > 0);
        }

        protected void LoadTeams()
        {
            cboCategories.Items.Clear();
            lbTeams.Items.Clear();

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

        protected Team FindTeam()
        {
            string categoryName = cboCategories.SelectedItem as string;

            Team team = null;

            if (rbFolders.Checked)
                team = Configs.TeamFolders[categoryName].Teams[lbTeams.SelectedIndex];
            else
                team = Configs.GameModes[categoryName].Teams[lbTeams.SelectedIndex];

            return team;
        }
    }
}
