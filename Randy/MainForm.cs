using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Randy
{
    public partial class MainForm : Form
    {
        XmlNodeList items;
        //bool selectAll = false;

        Dictionary<string, string> feedItems = new Dictionary<string, string>();

        public MainForm()
        {
            InitializeComponent();
        }
        //****************************//
        private void MainForm_Load(object sender, EventArgs e)
        {
            HashListBox.SelectedIndex = 0;
            MultiOperationBox.SelectedIndex = 0;

            string feedSourceStr = Settings.CurrentSettings.FeedSources;
            feedSourceStr = feedSourceStr.Replace("\r", "");
            string[] feedSources = feedSourceStr.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            FeedsListBox.Items.AddRange(feedSources);
        }
        //****************************//
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings = new SettingsForm();
            settings.ShowDialog();
        }
        //****************************//
        private void FeedsListBox_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            //bool selectAll = false;
            //if (cb.Text == "Select All")
            //    selectAll = true;

            //foreach (var cb in FeedsListBox.CheckBoxItems)
            //{
            //    if (cb.Checked)
            //    {
            //        //if (cb.Text == "Custom")
            //        //    FeedCustomBox.Visible = true;
            //    }
            //}

            items = null;
            ItemsListBox.Items.Clear();
            DataBox.Text = "";
        }
        //****************************//
        private void GetDataButton_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            GetDataButton.Enabled = false;
            List<string> selectedSources = new List<string>();
            foreach (var cb in FeedsListBox.CheckBoxItems)
            {
                if (cb.Checked)
                {
                    selectedSources.Add(cb.Text);
                }
            }

            ItemsListBox.Items.Clear();
            ItemsListBox.Items.Add("Select All");
            foreach (string address in selectedSources)
            {
                try
                {
                    string content = APIHelper.ExecuteRequest(address);

                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.LoadXml(content);

                    items = xmlDoc.GetElementsByTagName("item");

                    foreach (XmlNode item in items)
                    {
                        string title = item.SelectNodes("title")[0].InnerText;

                        string description = item.SelectNodes("description")[0].InnerText;

                        if (!feedItems.ContainsKey(title))
                            feedItems.Add(title, description);

                        if (title.Length > 0)
                            ItemsListBox.Items.Add(title);
                    }

                    ItemsListBox.Refresh();

                    //if (ItemsListBox.Items.Count > 0)
                    //    ItemsListBox.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.UseWaitCursor = false;
            GetDataButton.Enabled = true;
        }
        //****************************//
        private void ItemsListBox_CheckBoxCheckedChanged(object sender, EventArgs e)
        {
            ItemsListBox.CheckBoxCheckedChanged -= ItemsListBox_CheckBoxCheckedChanged;

            bool selectAll = false;
            if (((PresentationControls.CheckBoxComboBoxItem)sender).Text == "Select All")
            {
                selectAll = ((PresentationControls.CheckBoxComboBoxItem)sender).Checked;

                foreach (var cb in ItemsListBox.CheckBoxItems)
                {
                    cb.Checked = selectAll;
                }
            }
            else
            {
                selectAll = true;
                foreach (var cb in ItemsListBox.CheckBoxItems)
                {
                    if (cb.Text != "Select All")
                    {
                        if (!cb.Checked)
                        {
                            selectAll = false;
                            break;
                        }
                    }
                }

                foreach (var cb in ItemsListBox.CheckBoxItems)
                {
                    if (cb.Text == "Select All")
                    {
                        cb.Checked = selectAll;
                        break;
                    }
                }
            }

            ItemsListBox.CheckBoxCheckedChanged += ItemsListBox_CheckBoxCheckedChanged;
        }
        //****************************//
        private void ItemsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //PrepareData();
        }
        //****************************//
        private void ClearFeedButton_Click(object sender, EventArgs e)
        {
            ItemsListBox.CheckBoxCheckedChanged -= ItemsListBox_CheckBoxCheckedChanged;

            FeedsListBox.ClearSelection();
            //foreach (var cb in FeedsListBox.CheckBoxItems)
            //{
            //    cb.Checked = false;
            //}

            ItemsListBox.ClearSelection();
            ItemsListBox.Items.Clear();

            DataBox.Text = "";
            NumBox.Text = "";

            ItemsListBox.CheckBoxCheckedChanged += ItemsListBox_CheckBoxCheckedChanged;
        }
        //****************************//
        private void GetNumButton_Click(object sender, EventArgs e)
        {
            byte[] finalData = PrepareData();

            if(HashListBox.SelectedItem.ToString()== "MD5")
                NumBox.Text = Hash.MD5(finalData);
            else if (HashListBox.SelectedItem.ToString() == "SHA1")
                NumBox.Text = Hash.SHA1(finalData);
            else if (HashListBox.SelectedItem.ToString() == "SHA256")
                NumBox.Text = Hash.SHA256(finalData);
            else if (HashListBox.SelectedItem.ToString() == "SHA384")
                NumBox.Text = Hash.SHA384(finalData);
            else if (HashListBox.SelectedItem.ToString() == "SHA512")
                NumBox.Text = Hash.SHA512(finalData);
        }
        //****************************//
        private byte[] PrepareData()
        {
            byte[] finalData = new byte[1];
            string allDataStr = "";
            bool concatenate = false;
            if (MultiOperationBox.SelectedItem.ToString() == "Concatenate")
                concatenate = true;

            #region select titles
            List<string> selectedTitles = new List<string>();
            foreach (var cb in ItemsListBox.CheckBoxItems)
            {
                if (cb.Text != "Select All")
                {
                    if (cb.Checked)
                    {
                        selectedTitles.Add(cb.Text);
                    }
                }
            }
            #endregion

            

            #region select data
            List<string> selectedDataItems = new List<string>();

            foreach (string title in selectedTitles)
            {
                if (feedItems.ContainsKey(title))
                {
                    string data = feedItems[title];

                    selectedDataItems.Add(title + Environment.NewLine + data);

                    allDataStr += title + Environment.NewLine + data + Environment.NewLine;
                }
            }
            #endregion


            if (selectedDataItems.Count <= 0)
                return new byte[0];

            if (allDataStr.StartsWith(Environment.NewLine))
                allDataStr = allDataStr.Substring(2);
            if (allDataStr.EndsWith(Environment.NewLine))
                allDataStr = allDataStr.Substring(0, allDataStr.Length-2);
            DataBox.Text = allDataStr;

            if (concatenate)
                finalData = Encoding.ASCII.GetBytes(allDataStr);
            else
            {
                int minLength = selectedDataItems[0].Length;

                foreach (string dataStr in selectedDataItems)
                {
                    if (dataStr.Length < minLength)
                        minLength = dataStr.Length;
                }

                for (int i = 0; i < selectedDataItems.Count; i++)
                {
                    selectedDataItems[i] = selectedDataItems[i].Substring(0, minLength);
                }

                finalData = Encoding.ASCII.GetBytes(selectedDataItems[0]);

                for (int i = 1; i < selectedDataItems.Count; i++)
                {
                    finalData = XORBytes(finalData, Encoding.ASCII.GetBytes(selectedDataItems[i]));
                }
            }

            return finalData;
        }
        //****************************//
        private byte[] XORBytes(byte[] byteArr1, byte[] byteArr2)
        {
            byte[] finalBytes = new byte[byteArr1.Length];

            for (int i = 0; i < finalBytes.Length; i++)
            {
                finalBytes[i] = (byte)(byteArr1[i] ^ byteArr2[i]);
            }

            return finalBytes;
        }
        //****************************//
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = MultiOperationBox.SelectedItem.ToString() + ".csv";

                string sources = "";

                foreach (var cb in FeedsListBox.CheckBoxItems)
                {
                    if (cb.Checked)
                    {
                        sources += cb.Text + ",";
                    }
                }

                string data = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + ","+HashListBox.SelectedItem.ToString() + "," + NumBox.Text + "," + sources + Environment.NewLine;
                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.Write(data);
                    sw.Flush();
                    sw.Close();
                }

                SystemSounds.Hand.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
        }
        //****************************//
    }
}
