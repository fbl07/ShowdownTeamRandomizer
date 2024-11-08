namespace ShowdownTeamRando
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            label1 = new Label();
            txtDesktopLocation = new TextBox();
            btnBrowse = new Button();
            fdbBrowseDialog = new FolderBrowserDialog();
            chkImportOnStartup = new CheckBox();
            groupBox1 = new GroupBox();
            btnRemoveIgnoredGameMode = new Button();
            lbIgnoredGameModes = new ListBox();
            btnAddIgnoredGameMode = new Button();
            txtNewIgnoredGameMode = new TextBox();
            groupBox2 = new GroupBox();
            btnRemoveIgnoredFolder = new Button();
            lbIgnoredFolders = new ListBox();
            btnAddIgnoredFolder = new Button();
            txtNewIgnoredFolder = new TextBox();
            groupBox3 = new GroupBox();
            btnRemoveIgnoredTeam = new Button();
            lbIgnoredTeams = new ListBox();
            btnAddIgnoredTeam = new Button();
            txtNewIgnoredTeam = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 15);
            label1.TabIndex = 0;
            label1.Text = "Desktop Teams Folder Location";
            // 
            // txtDesktopLocation
            // 
            txtDesktopLocation.Location = new Point(12, 27);
            txtDesktopLocation.Name = "txtDesktopLocation";
            txtDesktopLocation.Size = new Size(336, 23);
            txtDesktopLocation.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(354, 27);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkImportOnStartup
            // 
            chkImportOnStartup.AutoSize = true;
            chkImportOnStartup.Location = new Point(12, 67);
            chkImportOnStartup.Name = "chkImportOnStartup";
            chkImportOnStartup.Size = new Size(122, 19);
            chkImportOnStartup.TabIndex = 3;
            chkImportOnStartup.Text = "Import On Startup";
            chkImportOnStartup.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemoveIgnoredGameMode);
            groupBox1.Controls.Add(lbIgnoredGameModes);
            groupBox1.Controls.Add(btnAddIgnoredGameMode);
            groupBox1.Controls.Add(txtNewIgnoredGameMode);
            groupBox1.Location = new Point(12, 104);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 173);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ignored Game Modes";
            // 
            // btnRemoveIgnoredGameMode
            // 
            btnRemoveIgnoredGameMode.Enabled = false;
            btnRemoveIgnoredGameMode.Location = new Point(6, 141);
            btnRemoveIgnoredGameMode.Name = "btnRemoveIgnoredGameMode";
            btnRemoveIgnoredGameMode.Size = new Size(75, 23);
            btnRemoveIgnoredGameMode.TabIndex = 3;
            btnRemoveIgnoredGameMode.Text = "Remove";
            btnRemoveIgnoredGameMode.UseVisualStyleBackColor = true;
            btnRemoveIgnoredGameMode.Click += btnRemoveIgnoredGameMode_Click;
            // 
            // lbIgnoredGameModes
            // 
            lbIgnoredGameModes.FormattingEnabled = true;
            lbIgnoredGameModes.ItemHeight = 15;
            lbIgnoredGameModes.Location = new Point(6, 56);
            lbIgnoredGameModes.Name = "lbIgnoredGameModes";
            lbIgnoredGameModes.Size = new Size(405, 79);
            lbIgnoredGameModes.TabIndex = 2;
            lbIgnoredGameModes.SelectedIndexChanged += lbIgnoredGameModes_SelectedIndexChanged;
            // 
            // btnAddIgnoredGameMode
            // 
            btnAddIgnoredGameMode.Location = new Point(361, 21);
            btnAddIgnoredGameMode.Name = "btnAddIgnoredGameMode";
            btnAddIgnoredGameMode.Size = new Size(50, 23);
            btnAddIgnoredGameMode.TabIndex = 1;
            btnAddIgnoredGameMode.Text = "Add";
            btnAddIgnoredGameMode.UseVisualStyleBackColor = true;
            btnAddIgnoredGameMode.Click += btnAddIgnoredGameMode_Click;
            // 
            // txtNewIgnoredGameMode
            // 
            txtNewIgnoredGameMode.Location = new Point(6, 22);
            txtNewIgnoredGameMode.Name = "txtNewIgnoredGameMode";
            txtNewIgnoredGameMode.Size = new Size(349, 23);
            txtNewIgnoredGameMode.TabIndex = 0;
            txtNewIgnoredGameMode.KeyDown += txtNewIgnoredGameMode_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRemoveIgnoredFolder);
            groupBox2.Controls.Add(lbIgnoredFolders);
            groupBox2.Controls.Add(btnAddIgnoredFolder);
            groupBox2.Controls.Add(txtNewIgnoredFolder);
            groupBox2.Location = new Point(12, 283);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(417, 173);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ignored Folders";
            // 
            // btnRemoveIgnoredFolder
            // 
            btnRemoveIgnoredFolder.Enabled = false;
            btnRemoveIgnoredFolder.Location = new Point(6, 141);
            btnRemoveIgnoredFolder.Name = "btnRemoveIgnoredFolder";
            btnRemoveIgnoredFolder.Size = new Size(75, 23);
            btnRemoveIgnoredFolder.TabIndex = 3;
            btnRemoveIgnoredFolder.Text = "Remove";
            btnRemoveIgnoredFolder.UseVisualStyleBackColor = true;
            btnRemoveIgnoredFolder.Click += btnRemoveIgnoredFolder_Click;
            // 
            // lbIgnoredFolders
            // 
            lbIgnoredFolders.FormattingEnabled = true;
            lbIgnoredFolders.ItemHeight = 15;
            lbIgnoredFolders.Location = new Point(6, 56);
            lbIgnoredFolders.Name = "lbIgnoredFolders";
            lbIgnoredFolders.Size = new Size(405, 79);
            lbIgnoredFolders.TabIndex = 2;
            lbIgnoredFolders.SelectedIndexChanged += lbIgnoredFolders_SelectedIndexChanged;
            // 
            // btnAddIgnoredFolder
            // 
            btnAddIgnoredFolder.Location = new Point(361, 21);
            btnAddIgnoredFolder.Name = "btnAddIgnoredFolder";
            btnAddIgnoredFolder.Size = new Size(50, 23);
            btnAddIgnoredFolder.TabIndex = 1;
            btnAddIgnoredFolder.Text = "Add";
            btnAddIgnoredFolder.UseVisualStyleBackColor = true;
            btnAddIgnoredFolder.Click += btnAddIgnoredFolder_Click;
            // 
            // txtNewIgnoredFolder
            // 
            txtNewIgnoredFolder.Location = new Point(6, 22);
            txtNewIgnoredFolder.Name = "txtNewIgnoredFolder";
            txtNewIgnoredFolder.Size = new Size(349, 23);
            txtNewIgnoredFolder.TabIndex = 0;
            txtNewIgnoredFolder.KeyDown += txtNewIgnoredFolder_KeyDown;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRemoveIgnoredTeam);
            groupBox3.Controls.Add(lbIgnoredTeams);
            groupBox3.Controls.Add(btnAddIgnoredTeam);
            groupBox3.Controls.Add(txtNewIgnoredTeam);
            groupBox3.Location = new Point(12, 462);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(417, 173);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ignored Teams";
            // 
            // btnRemoveIgnoredTeam
            // 
            btnRemoveIgnoredTeam.Enabled = false;
            btnRemoveIgnoredTeam.Location = new Point(6, 141);
            btnRemoveIgnoredTeam.Name = "btnRemoveIgnoredTeam";
            btnRemoveIgnoredTeam.Size = new Size(75, 23);
            btnRemoveIgnoredTeam.TabIndex = 3;
            btnRemoveIgnoredTeam.Text = "Remove";
            btnRemoveIgnoredTeam.UseVisualStyleBackColor = true;
            btnRemoveIgnoredTeam.Click += btnRemoveIgnoredTeam_Click;
            // 
            // lbIgnoredTeams
            // 
            lbIgnoredTeams.FormattingEnabled = true;
            lbIgnoredTeams.ItemHeight = 15;
            lbIgnoredTeams.Location = new Point(6, 56);
            lbIgnoredTeams.Name = "lbIgnoredTeams";
            lbIgnoredTeams.Size = new Size(405, 79);
            lbIgnoredTeams.TabIndex = 2;
            lbIgnoredTeams.SelectedIndexChanged += lbIgnoredTeams_SelectedIndexChanged;
            // 
            // btnAddIgnoredTeam
            // 
            btnAddIgnoredTeam.Location = new Point(361, 21);
            btnAddIgnoredTeam.Name = "btnAddIgnoredTeam";
            btnAddIgnoredTeam.Size = new Size(50, 23);
            btnAddIgnoredTeam.TabIndex = 1;
            btnAddIgnoredTeam.Text = "Add";
            btnAddIgnoredTeam.UseVisualStyleBackColor = true;
            btnAddIgnoredTeam.Click += btnAddIgnoredTeam_Click;
            // 
            // txtNewIgnoredTeam
            // 
            txtNewIgnoredTeam.Location = new Point(6, 22);
            txtNewIgnoredTeam.Name = "txtNewIgnoredTeam";
            txtNewIgnoredTeam.Size = new Size(349, 23);
            txtNewIgnoredTeam.TabIndex = 0;
            txtNewIgnoredTeam.KeyDown += txtNewIgnoredTeam_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(354, 646);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(273, 646);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 681);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(chkImportOnStartup);
            Controls.Add(btnBrowse);
            Controls.Add(txtDesktopLocation);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSettings";
            Text = "Settings";
            Load += frmSettings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDesktopLocation;
        private Button btnBrowse;
        private FolderBrowserDialog fdbBrowseDialog;
        private CheckBox chkImportOnStartup;
        private GroupBox groupBox1;
        private Button btnRemoveIgnoredGameMode;
        private ListBox lbIgnoredGameModes;
        private Button btnAddIgnoredGameMode;
        private TextBox txtNewIgnoredGameMode;
        private GroupBox groupBox2;
        private Button btnRemoveIgnoredFolder;
        private ListBox lbIgnoredFolders;
        private Button btnAddIgnoredFolder;
        private TextBox txtNewIgnoredFolder;
        private GroupBox groupBox3;
        private Button btnRemoveIgnoredTeam;
        private ListBox lbIgnoredTeams;
        private Button btnAddIgnoredTeam;
        private TextBox txtNewIgnoredTeam;
        private Button btnCancel;
        private Button btnSave;
    }
}