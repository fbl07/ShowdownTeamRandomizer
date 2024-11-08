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
        }

        private void btnRemoveIgnoredGameMode_Click(object sender, EventArgs e)
        {
            lbIgnoredGameModes.Items.Remove(lbIgnoredGameModes.SelectedItem);
        }

        private void btnAddIgnoredFolder_Click(object sender, EventArgs e)
        {
            lbIgnoredFolders.Items.Add(txtNewIgnoredFolder.Text);
        }

        private void btnRemoveIgnoredFolder_Click(object sender, EventArgs e)
        {
            lbIgnoredFolders.Items.Remove(lbIgnoredFolders.SelectedItem);
        }

        private void btnAddIgnoredTeam_Click(object sender, EventArgs e)
        {
            lbIgnoredTeams.Items.Add(txtNewIgnoredTeam.Text);
        }

        private void btnRemoveIgnoredTeam_Click(object sender, EventArgs e)
        {
            lbIgnoredTeams.Items.Remove(lbIgnoredTeams.SelectedItem);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configs.ShowdownDesktopFileLocation = txtDesktopLocation.Text;
            Configs.ImportFolderOnStartup = chkImportOnStartup.Checked;

            Configs.IgnoredGameModes = lbIgnoredGameModes.Items.Cast<string>().ToList();
            Configs.IgnoredFolders = lbIgnoredFolders.Items.Cast<string>().ToList();
            Configs.IgnoredTeams = lbIgnoredTeams.Items.Cast<string>().ToList();
        }
    }
}
