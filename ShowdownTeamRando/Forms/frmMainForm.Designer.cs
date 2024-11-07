namespace ShowdownTeamRando
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTeamConfigs = new Button();
            btnSettings = new Button();
            rbGameFormats = new RadioButton();
            rbFolders = new RadioButton();
            groupBox1 = new GroupBox();
            label5 = new Label();
            lbUpcomingTeams = new ListBox();
            btnNextTeam = new Button();
            label1 = new Label();
            txtCurrentTeam = new TextBox();
            lblFolder = new Label();
            cboCategories = new ComboBox();
            groupBox2 = new GroupBox();
            txtFolder = new TextBox();
            label4 = new Label();
            txtGameMode = new TextBox();
            label3 = new Label();
            txtTeamName = new TextBox();
            label2 = new Label();
            lblCatInfo = new Label();
            btnRandomize = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnTeamConfigs
            // 
            btnTeamConfigs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTeamConfigs.Location = new Point(694, 12);
            btnTeamConfigs.Name = "btnTeamConfigs";
            btnTeamConfigs.Size = new Size(150, 23);
            btnTeamConfigs.TabIndex = 0;
            btnTeamConfigs.Text = "Team Configurations";
            btnTeamConfigs.UseVisualStyleBackColor = true;
            btnTeamConfigs.Click += btnTeamConfigs_Click;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSettings.Location = new Point(613, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // rbGameFormats
            // 
            rbGameFormats.AutoSize = true;
            rbGameFormats.Location = new Point(156, 12);
            rbGameFormats.Name = "rbGameFormats";
            rbGameFormats.Size = new Size(154, 19);
            rbGameFormats.TabIndex = 4;
            rbGameFormats.Text = "Teams By Game Formats";
            rbGameFormats.UseVisualStyleBackColor = true;
            rbGameFormats.CheckedChanged += rbGameFormats_CheckedChanged;
            // 
            // rbFolders
            // 
            rbFolders.AutoSize = true;
            rbFolders.Checked = true;
            rbFolders.Location = new Point(12, 12);
            rbFolders.Name = "rbFolders";
            rbFolders.Size = new Size(115, 19);
            rbFolders.TabIndex = 3;
            rbFolders.TabStop = true;
            rbFolders.Text = "Teams By Folders";
            rbFolders.UseVisualStyleBackColor = true;
            rbFolders.CheckedChanged += rbFolders_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(lbUpcomingTeams);
            groupBox1.Controls.Add(btnNextTeam);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtCurrentTeam);
            groupBox1.Location = new Point(12, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 287);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Randomization Results";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 106);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 4;
            label5.Text = "Upcoming Teams";
            // 
            // lbUpcomingTeams
            // 
            lbUpcomingTeams.FormattingEnabled = true;
            lbUpcomingTeams.ItemHeight = 15;
            lbUpcomingTeams.Location = new Point(6, 124);
            lbUpcomingTeams.Name = "lbUpcomingTeams";
            lbUpcomingTeams.SelectionMode = SelectionMode.None;
            lbUpcomingTeams.Size = new Size(413, 154);
            lbUpcomingTeams.TabIndex = 3;
            // 
            // btnNextTeam
            // 
            btnNextTeam.Enabled = false;
            btnNextTeam.Location = new Point(6, 68);
            btnNextTeam.Name = "btnNextTeam";
            btnNextTeam.Size = new Size(413, 23);
            btnNextTeam.TabIndex = 2;
            btnNextTeam.Text = "Next Team";
            btnNextTeam.UseVisualStyleBackColor = true;
            btnNextTeam.Click += btnNextTeam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 1;
            label1.Text = "Current Team";
            // 
            // txtCurrentTeam
            // 
            txtCurrentTeam.Location = new Point(6, 39);
            txtCurrentTeam.Name = "txtCurrentTeam";
            txtCurrentTeam.ReadOnly = true;
            txtCurrentTeam.Size = new Size(413, 23);
            txtCurrentTeam.TabIndex = 0;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(12, 53);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(40, 15);
            lblFolder.TabIndex = 7;
            lblFolder.Text = "Folder";
            // 
            // cboCategories
            // 
            cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(12, 71);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(425, 23);
            cboCategories.TabIndex = 6;
            cboCategories.SelectedIndexChanged += cboCategories_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(txtFolder);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtGameMode);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTeamName);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(443, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 381);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Team Info";
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(6, 148);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(389, 23);
            txtFolder.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 130);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 4;
            label4.Text = "Folder";
            // 
            // txtGameMode
            // 
            txtGameMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGameMode.Location = new Point(6, 94);
            txtGameMode.Name = "txtGameMode";
            txtGameMode.ReadOnly = true;
            txtGameMode.Size = new Size(389, 23);
            txtGameMode.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 76);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Game Mode";
            // 
            // txtTeamName
            // 
            txtTeamName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTeamName.Location = new Point(6, 37);
            txtTeamName.Name = "txtTeamName";
            txtTeamName.ReadOnly = true;
            txtTeamName.Size = new Size(389, 23);
            txtTeamName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Name";
            // 
            // lblCatInfo
            // 
            lblCatInfo.AutoSize = true;
            lblCatInfo.Location = new Point(12, 100);
            lblCatInfo.Name = "lblCatInfo";
            lblCatInfo.Size = new Size(44, 15);
            lblCatInfo.TabIndex = 11;
            lblCatInfo.Text = "catInfo";
            // 
            // btnRandomize
            // 
            btnRandomize.Location = new Point(12, 122);
            btnRandomize.Name = "btnRandomize";
            btnRandomize.Size = new Size(425, 23);
            btnRandomize.TabIndex = 12;
            btnRandomize.Text = "Randomize!";
            btnRandomize.UseVisualStyleBackColor = true;
            btnRandomize.Click += btnRandomize_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 453);
            Controls.Add(btnRandomize);
            Controls.Add(lblCatInfo);
            Controls.Add(groupBox2);
            Controls.Add(lblFolder);
            Controls.Add(cboCategories);
            Controls.Add(groupBox1);
            Controls.Add(rbGameFormats);
            Controls.Add(rbFolders);
            Controls.Add(btnSettings);
            Controls.Add(btnTeamConfigs);
            Name = "frmMainForm";
            Text = "Pokemon Showdown Teams Randomizer";
            Load += frmMainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTeamConfigs;
        private Button btnSettings;
        private RadioButton rbGameFormats;
        private RadioButton rbFolders;
        private GroupBox groupBox1;
        private Label lblFolder;
        private ComboBox cboCategories;
        private GroupBox groupBox2;
        private TextBox txtFolder;
        private Label label4;
        private TextBox txtGameMode;
        private Label label3;
        private TextBox txtTeamName;
        private Label label2;
        private Label lblCatInfo;
        private Button btnRandomize;
        private Label label5;
        private ListBox lbUpcomingTeams;
        private Button btnNextTeam;
        private Label label1;
        private TextBox txtCurrentTeam;
    }
}
