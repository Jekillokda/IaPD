namespace BurnMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.supportedMediaLabel = new System.Windows.Forms.Label();
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBurn = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.buttonBurn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelMediaType = new System.Windows.Forms.Label();
            this.buttonDetectMedia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTotalSize = new System.Windows.Forms.Label();
            this.progressBarCapacity = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxEject = new System.Windows.Forms.CheckBox();
            this.checkBoxCloseMedia = new System.Windows.Forms.CheckBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRemoveFiles = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageBurn.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(16, 15);
            this.devicesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(260, 24);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.devicesComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(356, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supported Media:";
            // 
            // supportedMediaLabel
            // 
            this.supportedMediaLabel.Location = new System.Drawing.Point(485, 11);
            this.supportedMediaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.supportedMediaLabel.Name = "supportedMediaLabel";
            this.supportedMediaLabel.Size = new System.Drawing.Size(349, 70);
            this.supportedMediaLabel.TabIndex = 3;
            this.supportedMediaLabel.Click += new System.EventHandler(this.supportedMediaLabel_Click);
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            this.backgroundBurnWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBurnWorker_DoWork);
            this.backgroundBurnWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBurnWorker_ProgressChanged);
            this.backgroundBurnWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBurnWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBurn);
            this.tabControl1.Location = new System.Drawing.Point(16, 92);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(824, 352);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPageBurn
            // 
            this.tabPageBurn.Controls.Add(this.groupBox3);
            this.tabPageBurn.Controls.Add(this.groupBox2);
            this.tabPageBurn.Controls.Add(this.groupBox1);
            this.tabPageBurn.Location = new System.Drawing.Point(4, 25);
            this.tabPageBurn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBurn.Name = "tabPageBurn";
            this.tabPageBurn.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageBurn.Size = new System.Drawing.Size(816, 323);
            this.tabPageBurn.TabIndex = 0;
            this.tabPageBurn.Text = "Burn Files";
            this.tabPageBurn.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusProgressBar);
            this.groupBox3.Controls.Add(this.labelStatusText);
            this.groupBox3.Controls.Add(this.buttonBurn);
            this.groupBox3.Location = new System.Drawing.Point(479, 167);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(327, 144);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Progress";
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(16, 53);
            this.statusProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(299, 18);
            this.statusProgressBar.TabIndex = 8;
            // 
            // labelStatusText
            // 
            this.labelStatusText.Location = new System.Drawing.Point(12, -11);
            this.labelStatusText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(303, 54);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "status";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonBurn
            // 
            this.buttonBurn.Location = new System.Drawing.Point(112, 80);
            this.buttonBurn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(117, 36);
            this.buttonBurn.TabIndex = 6;
            this.buttonBurn.Text = "&Burn";
            this.buttonBurn.UseVisualStyleBackColor = true;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelMediaType);
            this.groupBox2.Controls.Add(this.buttonDetectMedia);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelTotalSize);
            this.groupBox2.Controls.Add(this.progressBarCapacity);
            this.groupBox2.Location = new System.Drawing.Point(479, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(327, 153);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected media type:";
            // 
            // labelMediaType
            // 
            this.labelMediaType.Location = new System.Drawing.Point(156, 25);
            this.labelMediaType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMediaType.Name = "labelMediaType";
            this.labelMediaType.Size = new System.Drawing.Size(159, 49);
            this.labelMediaType.TabIndex = 10;
            this.labelMediaType.Text = "Press \'Detect Media\' Button";
            // 
            // buttonDetectMedia
            // 
            this.buttonDetectMedia.Location = new System.Drawing.Point(16, 25);
            this.buttonDetectMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDetectMedia.Name = "buttonDetectMedia";
            this.buttonDetectMedia.Size = new System.Drawing.Size(131, 34);
            this.buttonDetectMedia.TabIndex = 9;
            this.buttonDetectMedia.Text = "Detect Media";
            this.buttonDetectMedia.UseVisualStyleBackColor = true;
            this.buttonDetectMedia.Click += new System.EventHandler(this.buttonDetectMedia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "0";
            // 
            // labelTotalSize
            // 
            this.labelTotalSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalSize.AutoSize = true;
            this.labelTotalSize.Location = new System.Drawing.Point(257, 90);
            this.labelTotalSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalSize.Name = "labelTotalSize";
            this.labelTotalSize.Size = new System.Drawing.Size(62, 17);
            this.labelTotalSize.TabIndex = 7;
            this.labelTotalSize.Text = "totalSize";
            // 
            // progressBarCapacity
            // 
            this.progressBarCapacity.Location = new System.Drawing.Point(8, 113);
            this.progressBarCapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarCapacity.Name = "progressBarCapacity";
            this.progressBarCapacity.Size = new System.Drawing.Size(307, 15);
            this.progressBarCapacity.Step = 1;
            this.progressBarCapacity.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarCapacity.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEject);
            this.groupBox1.Controls.Add(this.checkBoxCloseMedia);
            this.groupBox1.Controls.Add(this.textBoxLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonRemoveFiles);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(15, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(449, 304);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files to burn";
            // 
            // checkBoxEject
            // 
            this.checkBoxEject.AutoSize = true;
            this.checkBoxEject.Checked = true;
            this.checkBoxEject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEject.Location = new System.Drawing.Point(217, 272);
            this.checkBoxEject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxEject.Name = "checkBoxEject";
            this.checkBoxEject.Size = new System.Drawing.Size(151, 21);
            this.checkBoxEject.TabIndex = 7;
            this.checkBoxEject.Text = "Eject when finished";
            this.checkBoxEject.UseVisualStyleBackColor = true;
            // 
            // checkBoxCloseMedia
            // 
            this.checkBoxCloseMedia.AutoSize = true;
            this.checkBoxCloseMedia.Checked = true;
            this.checkBoxCloseMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCloseMedia.Location = new System.Drawing.Point(13, 272);
            this.checkBoxCloseMedia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCloseMedia.Name = "checkBoxCloseMedia";
            this.checkBoxCloseMedia.Size = new System.Drawing.Size(107, 21);
            this.checkBoxCloseMedia.TabIndex = 6;
            this.checkBoxCloseMedia.Text = "Close media";
            this.checkBoxCloseMedia.UseVisualStyleBackColor = true;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(164, 235);
            this.textBoxLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(169, 22);
            this.textBoxLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 239);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume Label:";
            // 
            // buttonRemoveFiles
            // 
            this.buttonRemoveFiles.Location = new System.Drawing.Point(291, 193);
            this.buttonRemoveFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRemoveFiles.Name = "buttonRemoveFiles";
            this.buttonRemoveFiles.Size = new System.Drawing.Size(141, 33);
            this.buttonRemoveFiles.TabIndex = 3;
            this.buttonRemoveFiles.Text = "Remove File(s)...";
            this.buttonRemoveFiles.UseVisualStyleBackColor = true;
            this.buttonRemoveFiles.Click += new System.EventHandler(this.buttonRemoveFiles_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(13, 193);
            this.buttonAddFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(112, 33);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "Add Files...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(13, 23);
            this.listBoxFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(419, 148);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 454);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.supportedMediaLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devicesComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "BurnMedia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBurn.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label supportedMediaLabel;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBurn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.Button buttonBurn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelMediaType;
        private System.Windows.Forms.Button buttonDetectMedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTotalSize;
        private System.Windows.Forms.ProgressBar progressBarCapacity;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxEject;
        private System.Windows.Forms.CheckBox checkBoxCloseMedia;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRemoveFiles;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}

