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
            SuspendLayout();
            // 
            // btnTeamConfigs
            // 
            btnTeamConfigs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTeamConfigs.Location = new Point(667, 12);
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
            btnSettings.Location = new Point(586, 12);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(75, 23);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 703);
            Controls.Add(btnSettings);
            Controls.Add(btnTeamConfigs);
            Name = "frmMainForm";
            Text = "Pokemon Showdown Teams Randomizer";
            Load += frmMainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTeamConfigs;
        private Button btnSettings;
    }
}
