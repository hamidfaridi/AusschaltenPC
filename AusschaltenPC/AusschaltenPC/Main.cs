using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AusschaltenPC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Die fährt den PC herunter
        /// </summary>
        /// <param name="sender">BtnHerunterfahren</param>
        /// <param name="e">Click</param>
        private void BtnHerunterfahren_Click(object sender, EventArgs e)
        {
            int intTimer = 0;
            intTimer = CalculateTimer();

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            process.StandardInput.WriteLine(string.Format("shutdown -s -t {0}", intTimer));
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            MessageBox.Show(process.StandardOutput.ReadToEnd());
        }

        /// <summary>
        /// Es zählt Zeit für herunterfahren
        /// </summary>
        /// <returns>Sekunden</returns>
        private int CalculateTimer()
        {
            int seconds = 0;
            int intTag = Convert.ToInt32(nudTag.Value);
            int intStunde = Convert.ToInt32(nudStunde.Value);
            int intMinute = Convert.ToInt32(nudMinute.Value);

            seconds = intTag * 24 * 3600 + intStunde * 3600 + intMinute * 60;
            lblTimerValue.Text = DateTime.Now.AddDays(intTag).AddHours(intStunde).AddMinutes(intMinute).ToString("yyyy/MM/dd - HH:mm");

            return seconds;
        }

        /// <summary>
        /// Es winterschläft den PC
        /// </summary>
        /// <param name="sender">BtnWinterschlaf</param>
        /// <param name="e">Click</param>
        private void BtnWinterschlaf_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            process.StandardInput.WriteLine("shutdown -h");
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
            MessageBox.Show(process.StandardOutput.ReadToEnd());
        }

        /// <summary>
        /// Es aufruf CalculateTimer() Methode
        /// </summary>
        /// <param name="sender">NumericUpDown</param>
        /// <param name="e">Value Change</param>
        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            CalculateTimer();
        }
    }
}