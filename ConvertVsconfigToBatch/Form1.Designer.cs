namespace ConvertVsconfigToBatch
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
            this.grpSourceFile = new System.Windows.Forms.GroupBox();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnBrowseForSource = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpNetworkInstaller = new System.Windows.Forms.GroupBox();
            this.txtNetworkInstaller = new System.Windows.Forms.TextBox();
            this.btnBrowseNetworkInstaller = new System.Windows.Forms.Button();
            this.grpBatchFile = new System.Windows.Forms.GroupBox();
            this.txtBatchFile = new System.Windows.Forms.TextBox();
            this.grpSourceFile.SuspendLayout();
            this.grpNetworkInstaller.SuspendLayout();
            this.grpBatchFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSourceFile
            // 
            this.grpSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSourceFile.Controls.Add(this.txtSourceFile);
            this.grpSourceFile.Controls.Add(this.btnBrowseForSource);
            this.grpSourceFile.Location = new System.Drawing.Point(12, 74);
            this.grpSourceFile.Name = "grpSourceFile";
            this.grpSourceFile.Size = new System.Drawing.Size(486, 56);
            this.grpSourceFile.TabIndex = 1;
            this.grpSourceFile.TabStop = false;
            this.grpSourceFile.Text = "*.vsconfig";
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceFile.BackColor = System.Drawing.Color.White;
            this.txtSourceFile.Location = new System.Drawing.Point(6, 21);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.ReadOnly = true;
            this.txtSourceFile.Size = new System.Drawing.Size(443, 20);
            this.txtSourceFile.TabIndex = 1;
            this.txtSourceFile.TabStop = false;
            // 
            // btnBrowseForSource
            // 
            this.btnBrowseForSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForSource.Location = new System.Drawing.Point(455, 19);
            this.btnBrowseForSource.Name = "btnBrowseForSource";
            this.btnBrowseForSource.Size = new System.Drawing.Size(25, 23);
            this.btnBrowseForSource.TabIndex = 1;
            this.btnBrowseForSource.Text = "...";
            this.btnBrowseForSource.UseVisualStyleBackColor = true;
            this.btnBrowseForSource.Click += new System.EventHandler(this.BtnBrowseForSource_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(218, 272);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // grpNetworkInstaller
            // 
            this.grpNetworkInstaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNetworkInstaller.Controls.Add(this.txtNetworkInstaller);
            this.grpNetworkInstaller.Controls.Add(this.btnBrowseNetworkInstaller);
            this.grpNetworkInstaller.Location = new System.Drawing.Point(12, 12);
            this.grpNetworkInstaller.Name = "grpNetworkInstaller";
            this.grpNetworkInstaller.Size = new System.Drawing.Size(486, 56);
            this.grpNetworkInstaller.TabIndex = 0;
            this.grpNetworkInstaller.TabStop = false;
            this.grpNetworkInstaller.Text = "Network Installer";
            // 
            // txtNetworkInstaller
            // 
            this.txtNetworkInstaller.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetworkInstaller.BackColor = System.Drawing.Color.White;
            this.txtNetworkInstaller.Location = new System.Drawing.Point(6, 21);
            this.txtNetworkInstaller.Name = "txtNetworkInstaller";
            this.txtNetworkInstaller.ReadOnly = true;
            this.txtNetworkInstaller.Size = new System.Drawing.Size(443, 20);
            this.txtNetworkInstaller.TabIndex = 1;
            this.txtNetworkInstaller.TabStop = false;
            // 
            // btnBrowseNetworkInstaller
            // 
            this.btnBrowseNetworkInstaller.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseNetworkInstaller.Location = new System.Drawing.Point(455, 19);
            this.btnBrowseNetworkInstaller.Name = "btnBrowseNetworkInstaller";
            this.btnBrowseNetworkInstaller.Size = new System.Drawing.Size(25, 23);
            this.btnBrowseNetworkInstaller.TabIndex = 0;
            this.btnBrowseNetworkInstaller.Text = "...";
            this.btnBrowseNetworkInstaller.UseVisualStyleBackColor = true;
            this.btnBrowseNetworkInstaller.Click += new System.EventHandler(this.BtnBrowseNetworkInstaller_Click);
            // 
            // grpBatchFile
            // 
            this.grpBatchFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBatchFile.Controls.Add(this.txtBatchFile);
            this.grpBatchFile.Location = new System.Drawing.Point(12, 136);
            this.grpBatchFile.Name = "grpBatchFile";
            this.grpBatchFile.Size = new System.Drawing.Size(486, 56);
            this.grpBatchFile.TabIndex = 2;
            this.grpBatchFile.TabStop = false;
            this.grpBatchFile.Text = "Batch file (All three must be in the same directory)";
            // 
            // txtBatchFile
            // 
            this.txtBatchFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBatchFile.BackColor = System.Drawing.Color.White;
            this.txtBatchFile.Location = new System.Drawing.Point(6, 21);
            this.txtBatchFile.Name = "txtBatchFile";
            this.txtBatchFile.ReadOnly = true;
            this.txtBatchFile.Size = new System.Drawing.Size(474, 20);
            this.txtBatchFile.TabIndex = 1;
            this.txtBatchFile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 331);
            this.Controls.Add(this.grpBatchFile);
            this.Controls.Add(this.grpNetworkInstaller);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpSourceFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Convert VS Config to install batch";
            this.grpSourceFile.ResumeLayout(false);
            this.grpSourceFile.PerformLayout();
            this.grpNetworkInstaller.ResumeLayout(false);
            this.grpNetworkInstaller.PerformLayout();
            this.grpBatchFile.ResumeLayout(false);
            this.grpBatchFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSourceFile;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnBrowseForSource;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpNetworkInstaller;
        private System.Windows.Forms.TextBox txtNetworkInstaller;
        private System.Windows.Forms.Button btnBrowseNetworkInstaller;
        private System.Windows.Forms.GroupBox grpBatchFile;
        private System.Windows.Forms.TextBox txtBatchFile;
    }
}

