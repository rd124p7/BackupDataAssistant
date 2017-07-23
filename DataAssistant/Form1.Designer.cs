namespace DataAssistant
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
            this.lblBackupDrive = new System.Windows.Forms.Label();
            this.txtDriveLetter = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.lblTotalSpace = new System.Windows.Forms.Label();
            this.btnStartBackup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBackupDrive
            // 
            this.lblBackupDrive.AutoSize = true;
            this.lblBackupDrive.Location = new System.Drawing.Point(13, 13);
            this.lblBackupDrive.Name = "lblBackupDrive";
            this.lblBackupDrive.Size = new System.Drawing.Size(72, 13);
            this.lblBackupDrive.TabIndex = 0;
            this.lblBackupDrive.Text = "Backup Drive";
            // 
            // txtDriveLetter
            // 
            this.txtDriveLetter.Location = new System.Drawing.Point(91, 10);
            this.txtDriveLetter.Name = "txtDriveLetter";
            this.txtDriveLetter.ReadOnly = true;
            this.txtDriveLetter.Size = new System.Drawing.Size(100, 20);
            this.txtDriveLetter.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(197, 8);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.AutoSize = true;
            this.lblFreeSpace.Location = new System.Drawing.Point(13, 33);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Padding = new System.Windows.Forms.Padding(5);
            this.lblFreeSpace.Size = new System.Drawing.Size(78, 23);
            this.lblFreeSpace.TabIndex = 3;
            this.lblFreeSpace.Text = "Free Space: ";
            // 
            // lblTotalSpace
            // 
            this.lblTotalSpace.AutoSize = true;
            this.lblTotalSpace.Location = new System.Drawing.Point(13, 56);
            this.lblTotalSpace.Name = "lblTotalSpace";
            this.lblTotalSpace.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalSpace.Size = new System.Drawing.Size(67, 23);
            this.lblTotalSpace.TabIndex = 4;
            this.lblTotalSpace.Text = "Total Size:";
            // 
            // btnStartBackup
            // 
            this.btnStartBackup.Location = new System.Drawing.Point(197, 85);
            this.btnStartBackup.Name = "btnStartBackup";
            this.btnStartBackup.Size = new System.Drawing.Size(86, 23);
            this.btnStartBackup.TabIndex = 5;
            this.btnStartBackup.Text = "Start Backup";
            this.btnStartBackup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 120);
            this.Controls.Add(this.btnStartBackup);
            this.Controls.Add(this.lblTotalSpace);
            this.Controls.Add(this.lblFreeSpace);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDriveLetter);
            this.Controls.Add(this.lblBackupDrive);
            this.Name = "Form1";
            this.Text = "Data Backup Assistant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackupDrive;
        private System.Windows.Forms.TextBox txtDriveLetter;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblFreeSpace;
        private System.Windows.Forms.Label lblTotalSpace;
        private System.Windows.Forms.Button btnStartBackup;
    }
}

