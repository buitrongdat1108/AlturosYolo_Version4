
namespace AlturosYolo.Version4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFile = new System.Windows.Forms.DataGridView();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.ColumnResultType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultConfidence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResultHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelYoloInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIconYoloInformation = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(426, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(675, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dataGridViewFile);
            this.groupBox2.Location = new System.Drawing.Point(33, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Name";
            // 
            // dataGridViewFile
            // 
            this.dataGridViewFile.AllowUserToAddRows = false;
            this.dataGridViewFile.AllowUserToDeleteRows = false;
            this.dataGridViewFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFileName,
            this.ColumnWidth,
            this.ColumnHeight});
            this.dataGridViewFile.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewFile.Name = "dataGridViewFile";
            this.dataGridViewFile.ReadOnly = true;
            this.dataGridViewFile.RowHeadersWidth = 51;
            this.dataGridViewFile.RowTemplate.Height = 24;
            this.dataGridViewFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFile.Size = new System.Drawing.Size(275, 353);
            this.dataGridViewFile.TabIndex = 0;
            this.dataGridViewFile.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.DataPropertyName = "Name";
            this.ColumnFileName.HeaderText = "FileName";
            this.ColumnFileName.MinimumWidth = 6;
            this.ColumnFileName.Name = "ColumnFileName";
            this.ColumnFileName.ReadOnly = true;
            this.ColumnFileName.Width = 72;
            // 
            // ColumnWidth
            // 
            this.ColumnWidth.DataPropertyName = "Width";
            this.ColumnWidth.HeaderText = "Width";
            this.ColumnWidth.MinimumWidth = 6;
            this.ColumnWidth.Name = "ColumnWidth";
            this.ColumnWidth.ReadOnly = true;
            this.ColumnWidth.Width = 75;
            // 
            // ColumnHeight
            // 
            this.ColumnHeight.DataPropertyName = "Height";
            this.ColumnHeight.HeaderText = "Height";
            this.ColumnHeight.MinimumWidth = 6;
            this.ColumnHeight.Name = "ColumnHeight";
            this.ColumnHeight.ReadOnly = true;
            this.ColumnHeight.Width = 75;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.btnOpen);
            this.groupBox3.Location = new System.Drawing.Point(33, 480);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(293, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // btnLoad
            // 
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(57, 106);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(169, 58);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Yolo";
            this.toolTip1.SetToolTip(this.btnLoad, "Load Alturos Yolo module");
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Location = new System.Drawing.Point(57, 21);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(169, 65);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open";
            this.toolTip1.SetToolTip(this.btnOpen, "Open Image\'s folder diarectory");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetect.Location = new System.Drawing.Point(702, 437);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(113, 37);
            this.btnDetect.TabIndex = 1;
            this.btnDetect.Text = "Detect";
            this.toolTip1.SetToolTip(this.btnDetect, "Detect");
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.dataGridResult);
            this.groupBoxResult.Location = new System.Drawing.Point(426, 480);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(688, 170);
            this.groupBoxResult.TabIndex = 3;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            // 
            // dataGridResult
            // 
            this.dataGridResult.AllowUserToAddRows = false;
            this.dataGridResult.AllowUserToDeleteRows = false;
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnResultType,
            this.ColumnResultConfidence,
            this.ColumnResultX,
            this.ColumnResultY,
            this.ColumnResultWidth,
            this.ColumnResultHeight});
            this.dataGridResult.Location = new System.Drawing.Point(7, 21);
            this.dataGridResult.MultiSelect = false;
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.ReadOnly = true;
            this.dataGridResult.RowHeadersWidth = 51;
            this.dataGridResult.RowTemplate.Height = 24;
            this.dataGridResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResult.Size = new System.Drawing.Size(675, 143);
            this.dataGridResult.TabIndex = 0;
            this.dataGridResult.SelectionChanged += new System.EventHandler(this.dataGridResult_SelectionChanged);
            // 
            // ColumnResultType
            // 
            this.ColumnResultType.DataPropertyName = "Type";
            this.ColumnResultType.HeaderText = "Type";
            this.ColumnResultType.MinimumWidth = 6;
            this.ColumnResultType.Name = "ColumnResultType";
            this.ColumnResultType.ReadOnly = true;
            this.ColumnResultType.Width = 200;
            // 
            // ColumnResultConfidence
            // 
            this.ColumnResultConfidence.DataPropertyName = "Confidence";
            this.ColumnResultConfidence.HeaderText = "Confidence";
            this.ColumnResultConfidence.MinimumWidth = 6;
            this.ColumnResultConfidence.Name = "ColumnResultConfidence";
            this.ColumnResultConfidence.ReadOnly = true;
            this.ColumnResultConfidence.Width = 125;
            // 
            // ColumnResultX
            // 
            this.ColumnResultX.DataPropertyName = "X";
            this.ColumnResultX.HeaderText = "X";
            this.ColumnResultX.MinimumWidth = 6;
            this.ColumnResultX.Name = "ColumnResultX";
            this.ColumnResultX.ReadOnly = true;
            this.ColumnResultX.Width = 75;
            // 
            // ColumnResultY
            // 
            this.ColumnResultY.DataPropertyName = "Y";
            this.ColumnResultY.HeaderText = "Y";
            this.ColumnResultY.MinimumWidth = 6;
            this.ColumnResultY.Name = "ColumnResultY";
            this.ColumnResultY.ReadOnly = true;
            this.ColumnResultY.Width = 75;
            // 
            // ColumnResultWidth
            // 
            this.ColumnResultWidth.DataPropertyName = "Width";
            this.ColumnResultWidth.HeaderText = "Width";
            this.ColumnResultWidth.MinimumWidth = 6;
            this.ColumnResultWidth.Name = "ColumnResultWidth";
            this.ColumnResultWidth.ReadOnly = true;
            this.ColumnResultWidth.Width = 75;
            // 
            // ColumnResultHeight
            // 
            this.ColumnResultHeight.DataPropertyName = "Height";
            this.ColumnResultHeight.HeaderText = "Height";
            this.ColumnResultHeight.MinimumWidth = 6;
            this.ColumnResultHeight.Name = "ColumnResultHeight";
            this.ColumnResultHeight.ReadOnly = true;
            this.ColumnResultHeight.Width = 75;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelYoloInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 655);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1203, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelYoloInfo
            // 
            this.toolStripStatusLabelYoloInfo.Name = "toolStripStatusLabelYoloInfo";
            this.toolStripStatusLabelYoloInfo.Size = new System.Drawing.Size(114, 20);
            this.toolStripStatusLabelYoloInfo.Text = "change by code";
            // 
            // notifyIconYoloInformation
            // 
            this.notifyIconYoloInformation.BalloonTipTitle = "Yolo Information";
            this.notifyIconYoloInformation.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconYoloInformation.Icon")));
            this.notifyIconYoloInformation.Text = "notifyIcon1";
            this.notifyIconYoloInformation.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFile)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultConfidence;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResultHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHeight;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelYoloInfo;
        private System.Windows.Forms.NotifyIcon notifyIconYoloInformation;
    }
}

