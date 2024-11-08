namespace ShowdownTeamRando
{
    partial class frmTeamsConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeamsConfig));
            rbFolders = new RadioButton();
            rbGameFormats = new RadioButton();
            cboCategories = new ComboBox();
            lblFolder = new Label();
            lbTeams = new ListBox();
            label1 = new Label();
            btnClose = new Button();
            btnImportFolder = new Button();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtFolder = new TextBox();
            label4 = new Label();
            txtGameMode = new TextBox();
            label3 = new Label();
            txtTeamName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtNewTeamName = new TextBox();
            btnAdd = new Button();
            btnImportPaste = new Button();
            btnSave = new Button();
            btnDeleteAll = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // rbFolders
            // 
            rbFolders.AutoSize = true;
            rbFolders.Checked = true;
            rbFolders.Location = new Point(12, 12);
            rbFolders.Name = "rbFolders";
            rbFolders.Size = new Size(115, 19);
            rbFolders.TabIndex = 1;
            rbFolders.TabStop = true;
            rbFolders.Text = "Teams By Folders";
            rbFolders.UseVisualStyleBackColor = true;
            rbFolders.CheckedChanged += rbFolders_CheckedChanged;
            // 
            // rbGameFormats
            // 
            rbGameFormats.AutoSize = true;
            rbGameFormats.Location = new Point(156, 12);
            rbGameFormats.Name = "rbGameFormats";
            rbGameFormats.Size = new Size(154, 19);
            rbGameFormats.TabIndex = 2;
            rbGameFormats.Text = "Teams By Game Formats";
            rbGameFormats.UseVisualStyleBackColor = true;
            rbGameFormats.CheckedChanged += rbGameFormats_CheckedChanged;
            // 
            // cboCategories
            // 
            cboCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategories.FormattingEnabled = true;
            cboCategories.Location = new Point(12, 64);
            cboCategories.Name = "cboCategories";
            cboCategories.Size = new Size(507, 23);
            cboCategories.TabIndex = 3;
            cboCategories.SelectedIndexChanged += cboCategories_SelectedIndexChanged;
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(12, 46);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(40, 15);
            lblFolder.TabIndex = 4;
            lblFolder.Text = "Folder";
            // 
            // lbTeams
            // 
            lbTeams.FormattingEnabled = true;
            lbTeams.ItemHeight = 15;
            lbTeams.Location = new Point(12, 153);
            lbTeams.Name = "lbTeams";
            lbTeams.Size = new Size(507, 319);
            lbTeams.TabIndex = 5;
            lbTeams.SelectedIndexChanged += lbTeams_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 134);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Teams";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(816, 496);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 7;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnImportFolder
            // 
            btnImportFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImportFolder.Location = new Point(669, 12);
            btnImportFolder.Name = "btnImportFolder";
            btnImportFolder.Size = new Size(222, 23);
            btnImportFolder.TabIndex = 8;
            btnImportFolder.Text = "Import From Desktop Team Folder";
            btnImportFolder.UseVisualStyleBackColor = true;
            btnImportFolder.Click += btnImportFolder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(txtFolder);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGameMode);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTeamName);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(525, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 408);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Team Info";
            // 
            // btnDelete
            // 
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(87, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(6, 193);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtFolder
            // 
            txtFolder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFolder.Location = new Point(6, 148);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(354, 23);
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
            txtGameMode.Size = new Size(354, 23);
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
            txtTeamName.Size = new Size(354, 23);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 90);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 10;
            label5.Text = "New Team Name";
            // 
            // txtNewTeamName
            // 
            txtNewTeamName.Location = new Point(12, 108);
            txtNewTeamName.Name = "txtNewTeamName";
            txtNewTeamName.Size = new Size(426, 23);
            txtNewTeamName.TabIndex = 11;
            txtNewTeamName.TextChanged += txtNewTeamName_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(444, 108);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnImportPaste
            // 
            btnImportPaste.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImportPaste.Location = new Point(499, 12);
            btnImportPaste.Name = "btnImportPaste";
            btnImportPaste.Size = new Size(164, 23);
            btnImportPaste.TabIndex = 13;
            btnImportPaste.Text = "Import From Web Export";
            btnImportPaste.UseVisualStyleBackColor = true;
            btnImportPaste.Click += btnImportPaste_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(735, 496);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteAll.Location = new Point(397, 12);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(96, 23);
            btnDeleteAll.TabIndex = 15;
            btnDeleteAll.Text = "Clear Teams";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // frmTeamsConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 531);
            Controls.Add(btnDeleteAll);
            Controls.Add(btnSave);
            Controls.Add(btnImportPaste);
            Controls.Add(btnAdd);
            Controls.Add(txtNewTeamName);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(btnImportFolder);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Controls.Add(lbTeams);
            Controls.Add(lblFolder);
            Controls.Add(cboCategories);
            Controls.Add(rbGameFormats);
            Controls.Add(rbFolders);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTeamsConfig";
            Text = "Team Configuration";
            Load += frmTeamsConfig_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbFolders;
        private RadioButton rbGameFormats;
        private ComboBox cboCategories;
        private Label lblFolder;
        private ListBox lbTeams;
        private Label label1;
        private Button btnClose;
        private Button btnImportFolder;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtGameMode;
        private Label label3;
        private TextBox txtTeamName;
        private Label label2;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtFolder;
        private Label label5;
        private TextBox txtNewTeamName;
        private Button btnAdd;
        private Button btnImportPaste;
        private Button btnSave;
        private Button btnDeleteAll;
    }
}