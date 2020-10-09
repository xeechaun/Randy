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
            AutoSaveIntervalBox.Value = Settings.CurrentSettings.AutoSaveInterval;
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
            Settings.CurrentSettings.AutoSaveInterval = (int)AutoSaveIntervalBox.Value;
            Settings.SaveSettings();
            this.Close();
        }
    }
}
