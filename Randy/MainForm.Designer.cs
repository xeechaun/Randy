namespace Randy
{
    partial class MainForm
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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.HashListBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataBox = new System.Windows.Forms.TextBox();
            this.GetDataButton = new System.Windows.Forms.Button();
            this.GetNumButton = new System.Windows.Forms.Button();
            this.NumBox = new System.Windows.Forms.TextBox();
            this.ClearFeedButton = new System.Windows.Forms.Button();
            this.FeedsListBox = new PresentationControls.CheckBoxComboBox();
            this.ItemsListBox = new PresentationControls.CheckBoxComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MultiOperationBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select feeds";
            // 
            // HashListBox
            // 
            this.HashListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HashListBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashListBox.FormattingEnabled = true;
            this.HashListBox.Items.AddRange(new object[] {
            "MD5",
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.HashListBox.Location = new System.Drawing.Point(6, 61);
            this.HashListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HashListBox.Name = "HashListBox";
            this.HashListBox.Size = new System.Drawing.Size(172, 31);
            this.HashListBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select hash algorithm";
            // 
            // DataBox
            // 
            this.DataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBox.Location = new System.Drawing.Point(6, 216);
            this.DataBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DataBox.Multiline = true;
            this.DataBox.Name = "DataBox";
            this.DataBox.ReadOnly = true;
            this.DataBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DataBox.Size = new System.Drawing.Size(846, 111);
            this.DataBox.TabIndex = 3;
            // 
            // GetDataButton
            // 
            this.GetDataButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetDataButton.Location = new System.Drawing.Point(703, 73);
            this.GetDataButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetDataButton.Name = "GetDataButton";
            this.GetDataButton.Size = new System.Drawing.Size(149, 31);
            this.GetDataButton.TabIndex = 2;
            this.GetDataButton.Text = "Get feed items";
            this.GetDataButton.UseVisualStyleBackColor = true;
            this.GetDataButton.Click += new System.EventHandler(this.GetDataButton_Click);
            // 
            // GetNumButton
            // 
            this.GetNumButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetNumButton.Location = new System.Drawing.Point(384, 23);
            this.GetNumButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GetNumButton.Name = "GetNumButton";
            this.GetNumButton.Size = new System.Drawing.Size(173, 85);
            this.GetNumButton.TabIndex = 6;
            this.GetNumButton.Text = "Generate Random Number >>";
            this.GetNumButton.UseVisualStyleBackColor = true;
            this.GetNumButton.Click += new System.EventHandler(this.GetNumButton_Click);
            // 
            // NumBox
            // 
            this.NumBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumBox.Location = new System.Drawing.Point(6, 30);
            this.NumBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBox.Multiline = true;
            this.NumBox.Name = "NumBox";
            this.NumBox.ReadOnly = true;
            this.NumBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumBox.Size = new System.Drawing.Size(846, 63);
            this.NumBox.TabIndex = 7;
            // 
            // ClearFeedButton
            // 
            this.ClearFeedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearFeedButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFeedButton.Location = new System.Drawing.Point(768, 139);
            this.ClearFeedButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearFeedButton.Name = "ClearFeedButton";
            this.ClearFeedButton.Size = new System.Drawing.Size(84, 42);
            this.ClearFeedButton.TabIndex = 4;
            this.ClearFeedButton.Text = "Clear";
            this.ClearFeedButton.UseVisualStyleBackColor = true;
            this.ClearFeedButton.Click += new System.EventHandler(this.ClearFeedButton_Click);
            // 
            // FeedsListBox
            // 
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FeedsListBox.CheckBoxProperties = checkBoxProperties1;
            this.FeedsListBox.DisplayMemberSingleItem = "";
            this.FeedsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeedsListBox.FormattingEnabled = true;
            this.FeedsListBox.Location = new System.Drawing.Point(6, 76);
            this.FeedsListBox.Name = "FeedsListBox";
            this.FeedsListBox.Size = new System.Drawing.Size(691, 31);
            this.FeedsListBox.TabIndex = 10;
            this.FeedsListBox.CheckBoxCheckedChanged += new System.EventHandler(this.FeedsListBox_CheckBoxCheckedChanged);
            // 
            // ItemsListBox
            // 
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ItemsListBox.CheckBoxProperties = checkBoxProperties2;
            this.ItemsListBox.DisplayMemberSingleItem = "";
            this.ItemsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.Items.AddRange(new object[] {
            "http://www.nytimes.com/services/xml/rss/nyt/HomePage.xml",
            "https://krebsonsecurity.com/feed",
            "http://feeds.abcnews.com/abcnews/topstories",
            "https://urdu.arynews.tv/feed",
            "https://www.thelocal.dk/feeds/rss.php",
            "http://www.france24.com/en/france/rss",
            "https://www.news.com.au/feed",
            "https://japantoday.com/feed",
            "https://themoscowtimes.com/feeds/main.xml",
            "https://www.theguardian.com/world/europe-news/rss",
            "https://www.thelocal.se/feeds/rss.php",
            "http://www.independent.co.uk/topic/Italy/rss",
            "https://www.aljazeera.com/xml/rss/all.xml",
            "https://sputniknews.com/export/rss2/archive/index.xml",
            "http://pakistan.asia-news.com/en_GB/rss",
            "https://www.thelocal.es/feeds/rss.php",
            "http://www.independent.co.uk/topic/Bulgaria/rss",
            "https://www.theguardian.com/world/hungary/rss",
            "https://www.theguardian.com/world/poland/rss",
            "https://www.thelocal.de/feeds/rss.php",
            "Custom"});
            this.ItemsListBox.Location = new System.Drawing.Point(6, 146);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(756, 31);
            this.ItemsListBox.TabIndex = 11;
            this.ItemsListBox.CheckBoxCheckedChanged += new System.EventHandler(this.ItemsListBox_CheckBoxCheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Selected data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select feed items to use as source data";
            // 
            // MultiOperationBox
            // 
            this.MultiOperationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MultiOperationBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiOperationBox.FormattingEnabled = true;
            this.MultiOperationBox.Items.AddRange(new object[] {
            "Concatenate",
            "XOR"});
            this.MultiOperationBox.Location = new System.Drawing.Point(184, 61);
            this.MultiOperationBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MultiOperationBox.Name = "MultiOperationBox";
            this.MultiOperationBox.Size = new System.Drawing.Size(172, 31);
            this.MultiOperationBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Multiple items operation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GetNumButton);
            this.groupBox1.Controls.Add(this.MultiOperationBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.HashListBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 352);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(858, 115);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SettingsButton);
            this.groupBox2.Controls.Add(this.FeedsListBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DataBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ClearFeedButton);
            this.groupBox2.Controls.Add(this.ItemsListBox);
            this.groupBox2.Controls.Add(this.GetDataButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 333);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Image = global::Randy.Properties.Resources.settings;
            this.SettingsButton.Location = new System.Drawing.Point(797, 17);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(55, 50);
            this.SettingsButton.TabIndex = 16;
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NumBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(858, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generated Random";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 603);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randy";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HashListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DataBox;
        private System.Windows.Forms.Button GetDataButton;
        private System.Windows.Forms.Button GetNumButton;
        private System.Windows.Forms.TextBox NumBox;
        private System.Windows.Forms.Button ClearFeedButton;
        private PresentationControls.CheckBoxComboBox FeedsListBox;
        private PresentationControls.CheckBoxComboBox ItemsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MultiOperationBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SettingsButton;
    }
}

