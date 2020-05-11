using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Randy
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }
        //*****************************************************************//
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Settings.CurrentSettings.FeedSources.Length > 0)
                FeedsBox.Text = Settings.CurrentSettings.FeedSources;
        }
        //*****************************************************************//
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //*****************************************************************//
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Settings.CurrentSettings.FeedSources = FeedsBox.Text;
            Settings.SaveSettings();
            this.Close();
        }
    }

    public class DeviceParams
    {
        public string IPAddress { get; set; }
        public int Port { get; set; }
        public int DeviceID { get; set; }
        public int Password { get; set; }
        public string Name { get; set; }

        public DeviceParams(string paramsRow)
        {
            string[] param = paramsRow.Split(new [] { "," }, StringSplitOptions.RemoveEmptyEntries);

            IPAddress = param[0].Replace(" ", "");
            Port = Convert.ToInt32(param[1].Replace(" ", ""));
            Password = Convert.ToInt32(param[2].Replace(" ", ""));
            Name = param[3];
        }
    }
}
