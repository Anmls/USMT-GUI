namespace USMT_GUI
{
    partial class Form1
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
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
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
            this.RadioButtonRestore.TabStop = true;
            this.RadioButtonRestore.Text = "Restore";
            this.RadioButtonRestore.UseVisualStyleBackColor = true;
            // 
            // RadioButtonBackup
            // 
            this.RadioButtonBackup.AutoSize = true;
            this.RadioButtonBackup.Location = new System.Drawing.Point(7, 20);
            this.RadioButtonBackup.Name = "RadioButtonBackup";
            this.RadioButtonBackup.Size = new System.Drawing.Size(62, 17);
            this.RadioButtonBackup.TabIndex = 0;
            this.RadioButtonBackup.Text = "Backup";
            this.RadioButtonBackup.UseVisualStyleBackColor = true;
            // 
            // GroupBoxTarget
            // 
            this.GroupBoxTarget.Controls.Add(this.TextBoxSpecificUser);
            this.GroupBoxTarget.Controls.Add(this.TextBoxRecentUsers);
            this.GroupBoxTarget.Controls.Add(this.RadioButtonRecentUsers);
            this.GroupBoxTarget.Controls.Add(this.RadioButtonSpecificUser);
            this.GroupBoxTarget.Location = new System.Drawing.Point(93, 13);
            this.GroupBoxTarget.Name = "GroupBoxTarget";
            this.GroupBoxTarget.Size = new System.Drawing.Size(261, 72);
            this.GroupBoxTarget.TabIndex = 1;
            this.GroupBoxTarget.TabStop = false;
            this.GroupBoxTarget.Text = "Target";
            // 
            // TextBoxSpecificUser
            // 
            this.TextBoxSpecificUser.Location = new System.Drawing.Point(94, 19);
            this.TextBoxSpecificUser.Name = "TextBoxSpecificUser";
            this.TextBoxSpecificUser.Size = new System.Drawing.Size(157, 20);
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
            // 
            // GroupBoxMigrationStore
            // 
            this.GroupBoxMigrationStore.Controls.Add(this.TextBoxLocalDrive);
            this.GroupBoxMigrationStore.Controls.Add(this.ButtonLocalDriveBrowse);
            this.GroupBoxMigrationStore.Controls.Add(this.RadioButtonLocalDrive);
            this.GroupBoxMigrationStore.Controls.Add(this.RadioButtonDefaultStore);
            this.GroupBoxMigrationStore.Location = new System.Drawing.Point(13, 92);
            this.GroupBoxMigrationStore.Name = "GroupBoxMigrationStore";
            this.GroupBoxMigrationStore.Size = new System.Drawing.Size(341, 72);
            this.GroupBoxMigrationStore.TabIndex = 2;
            this.GroupBoxMigrationStore.TabStop = false;
            this.GroupBoxMigrationStore.Text = "Migration Store";
            // 
            // TextBoxLocalDrive
            // 
            this.TextBoxLocalDrive.Location = new System.Drawing.Point(88, 43);
            this.TextBoxLocalDrive.Name = "TextBoxLocalDrive";
            this.TextBoxLocalDrive.Size = new System.Drawing.Size(170, 20);
            this.TextBoxLocalDrive.TabIndex = 3;
            // 
            // ButtonLocalDriveBrowse
            // 
            this.ButtonLocalDriveBrowse.Location = new System.Drawing.Point(256, 42);
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
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(197, 170);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(279, 170);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 199);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.GroupBoxMigrationStore);
            this.Controls.Add(this.GroupBoxTarget);
            this.Controls.Add(this.GroupBoxTask);
            this.Name = "Form1";
            this.Text = "USMT";
            this.GroupBoxTask.ResumeLayout(false);
            this.GroupBoxTask.PerformLayout();
            this.GroupBoxTarget.ResumeLayout(false);
            this.GroupBoxTarget.PerformLayout();
            this.GroupBoxMigrationStore.ResumeLayout(false);
            this.GroupBoxMigrationStore.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.TextBox TextBoxLocalDrive;
        private System.Windows.Forms.Button ButtonLocalDriveBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

