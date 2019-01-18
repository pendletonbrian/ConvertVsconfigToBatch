using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ConvertVsconfigToBatch
{
    public partial class Form1 : Form
    {
        #region Private Members

        /// <summary>
        /// The name of the batch file which will be used to create the installer.
        /// </summary>
        private static readonly string M_FILENAME = "Standalone_Install_VS2017_Enterprise.bat";

        #endregion Private Members

        #region constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion constructor

        private void BtnBrowseForSource_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.DefaultExt = "vsconfig";
                diag.Filter = "Visual Studio configuration files (*.vsconfig)|*.vsconfig|All files (*.*)|*.*";
                diag.FilterIndex = 0;
                diag.Multiselect = false;
                diag.Title = "Select the VS config file:";

                if (diag.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                txtSourceFile.Text = diag.FileName;
            }

            if (string.IsNullOrWhiteSpace(txtBatchFile.Text))
            {
                FileInfo fi = new FileInfo(txtSourceFile.Text);

                txtBatchFile.Text = Path.Combine(fi.DirectoryName, M_FILENAME);
            }

            CheckForReady();
        }

        private void BtnBrowseNetworkInstaller_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog diag = new OpenFileDialog())
            {
                diag.DefaultExt = "vsconfig";
                diag.Filter = "Visual Studio Network Installer (*.exe)|*.exe|All files (*.*)|*.*";
                diag.FilterIndex = 0;
                diag.Multiselect = false;
                diag.Title = "Select the Network Installer:";

                if (diag.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                txtNetworkInstaller.Text = diag.FileName;
            }

            if (string.IsNullOrWhiteSpace(txtBatchFile.Text))
            {
                FileInfo fi = new FileInfo(txtNetworkInstaller.Text);

                txtBatchFile.Text = Path.Combine(fi.DirectoryName, M_FILENAME);
            }

            CheckForReady();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Start with the network installer.  It is the exe doing all the
            //  work, and needs to have all the following info passed into it
            //  with the correct flags.
            sb.Append($"{txtNetworkInstaller.Text} ");
            sb.AppendLine("--layout C:\\Trusted\\VS2017_Enterprise");

            string line;
            bool continueReading = false;

            using (StreamReader rdr = new StreamReader(txtSourceFile.Text))
            {
                while ((line = rdr.ReadLine()) != null)
                {
                    line = line.Trim();

                    if (continueReading)
                    {
                        if (line.Contains("]"))
                        {
                            break;
                        }

                        line = line.Replace("\"", string.Empty);
                        line = line.Replace(",", string.Empty);

                        sb.AppendLine($"--add {line}");
                    }
                    else if (line.Contains("["))
                    {
                        continueReading = true;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(txtBatchFile.Text))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }

            MessageBox.Show(this, "All done.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void CheckForReady()
        {
            btnStart.Enabled =

                // The batch file to be created?
                string.IsNullOrWhiteSpace(txtBatchFile.Text).Equals(false) &&

                // Source *.vsconfig file (the export from another VS setup).
                string.IsNullOrWhiteSpace(txtSourceFile.Text).Equals(false) &&
                File.Exists(txtSourceFile.Text) &&

                // Network installer file to be used to generate the standalone.
                string.IsNullOrWhiteSpace(txtNetworkInstaller.Text).Equals(false) &&
                File.Exists(txtNetworkInstaller.Text);

            if (btnStart.Enabled)
            {
                txtBatchFile.Text = txtBatchFile.Text;
            }
        }
    }
}