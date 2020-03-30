using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AusschaltenPC
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnHerunterfahren_Click(object sender, EventArgs e)
        {
            int intTimer = 0;
            intTimer = CalculateTimer();

            Process prcHerunterfahren = new Process();
            prcHerunterfahren.StartInfo.FileName = "cmd.exe";
            prcHerunterfahren.StartInfo.CreateNoWindow = true;
            prcHerunterfahren.StartInfo.RedirectStandardInput = true;
            prcHerunterfahren.StartInfo.RedirectStandardOutput = true;
            prcHerunterfahren.StartInfo.UseShellExecute = false;
            prcHerunterfahren.Start();

            prcHerunterfahren.StandardInput.WriteLine(string.Format("shutdown -s -t {0}", intTimer));
            prcHerunterfahren.StandardInput.Flush();
            prcHerunterfahren.StandardInput.Close();
            prcHerunterfahren.WaitForExit();
            MessageBox.Show(prcHerunterfahren.StandardOutput.ReadToEnd());
        }

        private int CalculateTimer()
        {
            int intTimer = 0;
            int intTag = Convert.ToInt32(nudTag.Value);
            int intStunde = Convert.ToInt32(nudStunde.Value);
            int intMinute = Convert.ToInt32(nudMinute.Value);

            intTimer = intTag * 24 * 3600 + intStunde * 3600 + intMinute;
            lblTimerValue.Text = DateTime.Now.AddDays(intTag).AddHours(intStunde).AddMinutes(intMinute).ToString("yyyy/MM/dd - HH:mm");

            return intTimer;
        }

        private void BtnWinterschlaf_Click(object sender, EventArgs e)
        {
            Process prcHerunterfahren = new Process();
            prcHerunterfahren.StartInfo.FileName = "cmd.exe";
            prcHerunterfahren.StartInfo.CreateNoWindow = true;
            prcHerunterfahren.StartInfo.RedirectStandardInput = true;
            prcHerunterfahren.StartInfo.RedirectStandardOutput = true;
            prcHerunterfahren.StartInfo.UseShellExecute = false;
            prcHerunterfahren.Start();

            prcHerunterfahren.StandardInput.WriteLine("shutdown -h");
            prcHerunterfahren.StandardInput.Flush();
            prcHerunterfahren.StandardInput.Close();
            prcHerunterfahren.WaitForExit();
            MessageBox.Show(prcHerunterfahren.StandardOutput.ReadToEnd());
        }

        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            CalculateTimer();
        }
    }
}