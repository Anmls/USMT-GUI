namespace USMT_GUI
{
    partial class USMT
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
			this.GroupBoxTask = new System.Windows.Forms.GroupBox();
			this.RadioButtonRestore = new System.Windows.Forms.RadioButton();
			this.RadioButtonBackup = new System.Windows.Forms.RadioButton();
			this.GroupBoxTarget = new System.Windows.Forms.GroupBox();
			this.TextBoxSpecificUser = new System.Windows.Forms.TextBox();
			this.TextBoxRecentUsers = new System.Windows.Forms.TextBox();
			this.RadioButtonRecentUsers = new System.Windows.Forms.RadioButton();
			this.RadioButtonSpecificUser = new System.Windows.Forms.RadioButton();
			this.GroupBoxMigrationStore = new System.Windows.Forms.GroupBox();
			this.TextBoxLocalDrive = new System.Windows.Forms.TextBox();
			this.ButtonLocalDriveBrowse = new System.Windows.Forms.Button();
			this.RadioButtonLocalDrive = new System.Windows.Forms.RadioButton();
			this.RadioButtonDefaultStore = new System.Windows.Forms.RadioButton();
			this.startButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.outputTextBox = new System.Windows.Forms.TextBox();
			this.outputTextBox2 = new System.Windows.Forms.RichTextBox();
			this.GroupBoxTask.SuspendLayout();
			this.GroupBoxTarget.SuspendLayout();
			this.GroupBoxMigrationStore.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBoxTask
			// 
			this.GroupBoxTask.Controls.Add(this.RadioButtonRestore);
			this.GroupBoxTask.Controls.Add(this.RadioButtonBackup);
			this.GroupBoxTask.Location = new System.Drawing.Point(13, 13);
			this.GroupBoxTask.Name = "GroupBoxTask";
			this.GroupBoxTask.Size = new System.Drawing.Size(74, 72);
			this.GroupBoxTask.TabIndex = 0;
			this.GroupBoxTask.TabStop = false;
			this.GroupBoxTask.Text = "Task";
			// 
			// RadioButtonRestore
			// 
			this.RadioButtonRestore.AutoSize = true;
			this.RadioButtonRestore.Location = new System.Drawing.Point(7, 44);
			this.RadioButtonRestore.Name = "RadioButtonRestore";
			this.RadioButtonRestore.Size = new System.Drawing.Size(62, 17);
			this.RadioButtonRestore.TabIndex = 1;
			this.RadioButtonRestore.Text = "Restore";
			this.RadioButtonRestore.UseVisualStyleBackColor = true;
			// 
			// RadioButtonBackup
			// 
			this.RadioButtonBackup.AutoSize = true;
			this.RadioButtonBackup.Checked = true;
			this.RadioButtonBackup.Location = new System.Drawing.Point(7, 20);
			this.RadioButtonBackup.Name = "RadioButtonBackup";
			this.RadioButtonBackup.Size = new System.Drawing.Size(62, 17);
			this.RadioButtonBackup.TabIndex = 0;
			this.RadioButtonBackup.TabStop = true;
			this.RadioButtonBackup.Text = "Backup";
			this.RadioButtonBackup.UseVisualStyleBackColor = true;
			// 
			// GroupBoxTarget
			// 
			this.GroupBoxTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBoxTarget.Controls.Add(this.TextBoxSpecificUser);
			this.GroupBoxTarget.Controls.Add(this.TextBoxRecentUsers);
			this.GroupBoxTarget.Controls.Add(this.RadioButtonRecentUsers);
			this.GroupBoxTarget.Controls.Add(this.RadioButtonSpecificUser);
			this.GroupBoxTarget.Location = new System.Drawing.Point(93, 13);
			this.GroupBoxTarget.Name = "GroupBoxTarget";
			this.GroupBoxTarget.Size = new System.Drawing.Size(223, 72);
			this.GroupBoxTarget.TabIndex = 1;
			this.GroupBoxTarget.TabStop = false;
			this.GroupBoxTarget.Text = "Target";
			// 
			// TextBoxSpecificUser
			// 
			this.TextBoxSpecificUser.Location = new System.Drawing.Point(94, 19);
			this.TextBoxSpecificUser.Name = "TextBoxSpecificUser";
			this.TextBoxSpecificUser.Size = new System.Drawing.Size(118, 20);
			this.TextBoxSpecificUser.TabIndex = 2;
			// 
			// TextBoxRecentUsers
			// 
			this.TextBoxRecentUsers.Location = new System.Drawing.Point(152, 43);
			this.TextBoxRecentUsers.Name = "TextBoxRecentUsers";
			this.TextBoxRecentUsers.Size = new System.Drawing.Size(26, 20);
			this.TextBoxRecentUsers.TabIndex = 3;
			// 
			// RadioButtonRecentUsers
			// 
			this.RadioButtonRecentUsers.AutoSize = true;
			this.RadioButtonRecentUsers.Location = new System.Drawing.Point(7, 44);
			this.RadioButtonRecentUsers.Name = "RadioButtonRecentUsers";
			this.RadioButtonRecentUsers.Size = new System.Drawing.Size(205, 17);
			this.RadioButtonRecentUsers.TabIndex = 1;
			this.RadioButtonRecentUsers.TabStop = true;
			this.RadioButtonRecentUsers.Text = "Users logged in within last           days.";
			this.RadioButtonRecentUsers.UseVisualStyleBackColor = true;
			// 
			// RadioButtonSpecificUser
			// 
			this.RadioButtonSpecificUser.AutoSize = true;
			this.RadioButtonSpecificUser.Checked = true;
			this.RadioButtonSpecificUser.Location = new System.Drawing.Point(7, 20);
			this.RadioButtonSpecificUser.Name = "RadioButtonSpecificUser";
			this.RadioButtonSpecificUser.Size = new System.Drawing.Size(91, 17);
			this.RadioButtonSpecificUser.TabIndex = 0;
			this.RadioButtonSpecificUser.TabStop = true;
			this.RadioButtonSpecificUser.Text = "Specific User:";
			this.RadioButtonSpecificUser.UseVisualStyleBackColor = true;
			this.RadioButtonSpecificUser.CheckedChanged += new System.EventHandler(this.RadioButtonSpecificUser_CheckedChanged);
			// 
			// GroupBoxMigrationStore
			// 
			this.GroupBoxMigrationStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GroupBoxMigrationStore.Controls.Add(this.TextBoxLocalDrive);
			this.GroupBoxMigrationStore.Controls.Add(this.ButtonLocalDriveBrowse);
			this.GroupBoxMigrationStore.Controls.Add(this.RadioButtonLocalDrive);
			this.GroupBoxMigrationStore.Controls.Add(this.RadioButtonDefaultStore);
			this.GroupBoxMigrationStore.Location = new System.Drawing.Point(13, 92);
			this.GroupBoxMigrationStore.Name = "GroupBoxMigrationStore";
			this.GroupBoxMigrationStore.Size = new System.Drawing.Size(303, 72);
			this.GroupBoxMigrationStore.TabIndex = 2;
			this.GroupBoxMigrationStore.TabStop = false;
			this.GroupBoxMigrationStore.Text = "Migration Store";
			// 
			// TextBoxLocalDrive
			// 
			this.TextBoxLocalDrive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBoxLocalDrive.Location = new System.Drawing.Point(88, 43);
			this.TextBoxLocalDrive.Name = "TextBoxLocalDrive";
			this.TextBoxLocalDrive.Size = new System.Drawing.Size(128, 20);
			this.TextBoxLocalDrive.TabIndex = 3;
			// 
			// ButtonLocalDriveBrowse
			// 
			this.ButtonLocalDriveBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonLocalDriveBrowse.Location = new System.Drawing.Point(222, 41);
			this.ButtonLocalDriveBrowse.Name = "ButtonLocalDriveBrowse";
			this.ButtonLocalDriveBrowse.Size = new System.Drawing.Size(75, 22);
			this.ButtonLocalDriveBrowse.TabIndex = 2;
			this.ButtonLocalDriveBrowse.Text = "Browse";
			this.ButtonLocalDriveBrowse.UseVisualStyleBackColor = true;
			this.ButtonLocalDriveBrowse.Click += new System.EventHandler(this.ButtonLocalDriveBrowse_Click);
			// 
			// RadioButtonLocalDrive
			// 
			this.RadioButtonLocalDrive.AutoSize = true;
			this.RadioButtonLocalDrive.Location = new System.Drawing.Point(7, 44);
			this.RadioButtonLocalDrive.Name = "RadioButtonLocalDrive";
			this.RadioButtonLocalDrive.Size = new System.Drawing.Size(82, 17);
			this.RadioButtonLocalDrive.TabIndex = 1;
			this.RadioButtonLocalDrive.TabStop = true;
			this.RadioButtonLocalDrive.Text = "Local Drive:";
			this.RadioButtonLocalDrive.UseVisualStyleBackColor = true;
			// 
			// RadioButtonDefaultStore
			// 
			this.RadioButtonDefaultStore.AutoSize = true;
			this.RadioButtonDefaultStore.Checked = true;
			this.RadioButtonDefaultStore.Location = new System.Drawing.Point(7, 20);
			this.RadioButtonDefaultStore.Name = "RadioButtonDefaultStore";
			this.RadioButtonDefaultStore.Size = new System.Drawing.Size(293, 17);
			this.RadioButtonDefaultStore.TabIndex = 0;
			this.RadioButtonDefaultStore.TabStop = true;
			this.RadioButtonDefaultStore.Text = "Default Migration Store Share. (\\\\box-ahs\\mig\\migstore\\)";
			this.RadioButtonDefaultStore.UseVisualStyleBackColor = true;
			// 
			// startButton
			// 
			this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.startButton.Location = new System.Drawing.Point(159, 482);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 3;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.ButtonStart_Click);
			// 
			// exitButton
			// 
			this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.exitButton.Location = new System.Drawing.Point(241, 482);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 4;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ButtonExit_Click);
			// 
			// outputTextBox
			// 
			this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTextBox.Location = new System.Drawing.Point(13, 170);
			this.outputTextBox.Multiline = true;
			this.outputTextBox.Name = "outputTextBox";
			this.outputTextBox.Size = new System.Drawing.Size(303, 306);
			this.outputTextBox.TabIndex = 5;
			this.outputTextBox.Visible = false;
			// 
			// outputTextBox2
			// 
			this.outputTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.outputTextBox2.DetectUrls = false;
			this.outputTextBox2.Location = new System.Drawing.Point(13, 171);
			this.outputTextBox2.Name = "outputTextBox2";
			this.outputTextBox2.Size = new System.Drawing.Size(303, 305);
			this.outputTextBox2.TabIndex = 7;
			this.outputTextBox2.Text = "";
			// 
			// USMT
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 511);
			this.Controls.Add(this.outputTextBox2);
			this.Controls.Add(this.outputTextBox);
			this.Controls.Add(this.GroupBoxMigrationStore);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.GroupBoxTarget);
			this.Controls.Add(this.GroupBoxTask);
			this.MinimumSize = new System.Drawing.Size(345, 0);
			this.Name = "USMT";
			this.Text = "USMT";
			this.GroupBoxTask.ResumeLayout(false);
			this.GroupBoxTask.PerformLayout();
			this.GroupBoxTarget.ResumeLayout(false);
			this.GroupBoxTarget.PerformLayout();
			this.GroupBoxMigrationStore.ResumeLayout(false);
			this.GroupBoxMigrationStore.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxTask;
        private System.Windows.Forms.RadioButton RadioButtonRestore;
        private System.Windows.Forms.RadioButton RadioButtonBackup;
        private System.Windows.Forms.GroupBox GroupBoxTarget;
        private System.Windows.Forms.TextBox TextBoxRecentUsers;
        private System.Windows.Forms.TextBox TextBoxSpecificUser;
        private System.Windows.Forms.RadioButton RadioButtonRecentUsers;
        private System.Windows.Forms.RadioButton RadioButtonSpecificUser;
        private System.Windows.Forms.GroupBox GroupBoxMigrationStore;
        private System.Windows.Forms.RadioButton RadioButtonLocalDrive;
        private System.Windows.Forms.RadioButton RadioButtonDefaultStore;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox TextBoxLocalDrive;
        private System.Windows.Forms.Button ButtonLocalDriveBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox outputTextBox;
		private System.Windows.Forms.RichTextBox outputTextBox2;
    }
}

