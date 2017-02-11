namespace MongoDBMigrator
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
            this.gpbConnStrings = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSrcConnString = new System.Windows.Forms.TextBox();
            this.lsbDatabases = new System.Windows.Forms.ListBox();
            this.txtDestConnString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbDatabases = new System.Windows.Forms.GroupBox();
            this.gpbQuery = new System.Windows.Forms.GroupBox();
            this.chkSrcSSL = new System.Windows.Forms.CheckBox();
            this.chkDestSSL = new System.Windows.Forms.CheckBox();
            this.gpbCollections = new System.Windows.Forms.GroupBox();
            this.lsbCollections = new System.Windows.Forms.ListBox();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.btnLoadDBs = new System.Windows.Forms.Button();
            this.gpbBatchSize = new System.Windows.Forms.GroupBox();
            this.nudBatchSize = new System.Windows.Forms.NumericUpDown();
            this.gpbConnStrings.SuspendLayout();
            this.gpbDatabases.SuspendLayout();
            this.gpbQuery.SuspendLayout();
            this.gpbCollections.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gpbBatchSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbConnStrings
            // 
            this.gpbConnStrings.Controls.Add(this.chkDestSSL);
            this.gpbConnStrings.Controls.Add(this.chkSrcSSL);
            this.gpbConnStrings.Controls.Add(this.txtDestConnString);
            this.gpbConnStrings.Controls.Add(this.label3);
            this.gpbConnStrings.Controls.Add(this.txtSrcConnString);
            this.gpbConnStrings.Controls.Add(this.label1);
            this.gpbConnStrings.Location = new System.Drawing.Point(12, 12);
            this.gpbConnStrings.Name = "gpbConnStrings";
            this.gpbConnStrings.Size = new System.Drawing.Size(622, 102);
            this.gpbConnStrings.TabIndex = 0;
            this.gpbConnStrings.TabStop = false;
            this.gpbConnStrings.Text = "Connection Strings";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 393);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(622, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // txtSrcConnString
            // 
            this.txtSrcConnString.Location = new System.Drawing.Point(86, 28);
            this.txtSrcConnString.Name = "txtSrcConnString";
            this.txtSrcConnString.Size = new System.Drawing.Size(437, 20);
            this.txtSrcConnString.TabIndex = 1;
            // 
            // lsbDatabases
            // 
            this.lsbDatabases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbDatabases.FormattingEnabled = true;
            this.lsbDatabases.Location = new System.Drawing.Point(19, 30);
            this.lsbDatabases.Name = "lsbDatabases";
            this.lsbDatabases.Size = new System.Drawing.Size(270, 147);
            this.lsbDatabases.TabIndex = 2;
            this.lsbDatabases.SelectedIndexChanged += new System.EventHandler(this.lsbDatabases_SelectedIndexChanged);
            // 
            // txtDestConnString
            // 
            this.txtDestConnString.Location = new System.Drawing.Point(86, 61);
            this.txtDestConnString.Name = "txtDestConnString";
            this.txtDestConnString.Size = new System.Drawing.Size(437, 20);
            this.txtDestConnString.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination:";
            // 
            // gpbDatabases
            // 
            this.gpbDatabases.Controls.Add(this.btnLoadDBs);
            this.gpbDatabases.Controls.Add(this.lsbDatabases);
            this.gpbDatabases.Location = new System.Drawing.Point(12, 120);
            this.gpbDatabases.Name = "gpbDatabases";
            this.gpbDatabases.Size = new System.Drawing.Size(307, 195);
            this.gpbDatabases.TabIndex = 5;
            this.gpbDatabases.TabStop = false;
            this.gpbDatabases.Text = "Databases";
            // 
            // gpbQuery
            // 
            this.gpbQuery.Controls.Add(this.txtQuery);
            this.gpbQuery.Location = new System.Drawing.Point(13, 321);
            this.gpbQuery.Name = "gpbQuery";
            this.gpbQuery.Size = new System.Drawing.Size(514, 63);
            this.gpbQuery.TabIndex = 6;
            this.gpbQuery.TabStop = false;
            this.gpbQuery.Text = "JSON Find Query (optional)";
            // 
            // chkSrcSSL
            // 
            this.chkSrcSSL.AutoSize = true;
            this.chkSrcSSL.Location = new System.Drawing.Point(542, 31);
            this.chkSrcSSL.Name = "chkSrcSSL";
            this.chkSrcSSL.Size = new System.Drawing.Size(68, 17);
            this.chkSrcSSL.TabIndex = 4;
            this.chkSrcSSL.Text = "Use SSL";
            this.chkSrcSSL.UseVisualStyleBackColor = true;
            // 
            // chkDestSSL
            // 
            this.chkDestSSL.AutoSize = true;
            this.chkDestSSL.Location = new System.Drawing.Point(542, 64);
            this.chkDestSSL.Name = "chkDestSSL";
            this.chkDestSSL.Size = new System.Drawing.Size(68, 17);
            this.chkDestSSL.TabIndex = 5;
            this.chkDestSSL.Text = "Use SSL";
            this.chkDestSSL.UseVisualStyleBackColor = true;
            // 
            // gpbCollections
            // 
            this.gpbCollections.Controls.Add(this.lsbCollections);
            this.gpbCollections.Location = new System.Drawing.Point(325, 120);
            this.gpbCollections.Name = "gpbCollections";
            this.gpbCollections.Size = new System.Drawing.Size(309, 195);
            this.gpbCollections.TabIndex = 6;
            this.gpbCollections.TabStop = false;
            this.gpbCollections.Text = "Collections";
            // 
            // lsbCollections
            // 
            this.lsbCollections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbCollections.FormattingEnabled = true;
            this.lsbCollections.Location = new System.Drawing.Point(19, 30);
            this.lsbCollections.Name = "lsbCollections";
            this.lsbCollections.Size = new System.Drawing.Size(272, 147);
            this.lsbCollections.TabIndex = 2;
            // 
            // txtQuery
            // 
            this.txtQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuery.Location = new System.Drawing.Point(18, 30);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(478, 20);
            this.txtQuery.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel2,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 17);
            this.lblStatus.Text = "Ready";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(490, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // btnLoadDBs
            // 
            this.btnLoadDBs.Location = new System.Drawing.Point(208, -1);
            this.btnLoadDBs.Name = "btnLoadDBs";
            this.btnLoadDBs.Size = new System.Drawing.Size(93, 23);
            this.btnLoadDBs.TabIndex = 3;
            this.btnLoadDBs.Text = "Load/Refresh";
            this.btnLoadDBs.UseVisualStyleBackColor = true;
            this.btnLoadDBs.Click += new System.EventHandler(this.btnLoadDBs_Click);
            // 
            // gpbBatchSize
            // 
            this.gpbBatchSize.Controls.Add(this.nudBatchSize);
            this.gpbBatchSize.Location = new System.Drawing.Point(533, 322);
            this.gpbBatchSize.Name = "gpbBatchSize";
            this.gpbBatchSize.Size = new System.Drawing.Size(101, 62);
            this.gpbBatchSize.TabIndex = 8;
            this.gpbBatchSize.TabStop = false;
            this.gpbBatchSize.Text = "Batch Size";
            // 
            // nudBatchSize
            // 
            this.nudBatchSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudBatchSize.Location = new System.Drawing.Point(18, 29);
            this.nudBatchSize.Name = "nudBatchSize";
            this.nudBatchSize.Size = new System.Drawing.Size(65, 20);
            this.nudBatchSize.TabIndex = 0;
            this.nudBatchSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.gpbBatchSize);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gpbCollections);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gpbQuery);
            this.Controls.Add(this.gpbDatabases);
            this.Controls.Add(this.gpbConnStrings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MongoDB Data Migrator";
            this.gpbConnStrings.ResumeLayout(false);
            this.gpbConnStrings.PerformLayout();
            this.gpbDatabases.ResumeLayout(false);
            this.gpbQuery.ResumeLayout(false);
            this.gpbQuery.PerformLayout();
            this.gpbCollections.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gpbBatchSize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBatchSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbConnStrings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lsbDatabases;
        private System.Windows.Forms.TextBox txtSrcConnString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDestConnString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbDatabases;
        private System.Windows.Forms.GroupBox gpbQuery;
        private System.Windows.Forms.CheckBox chkDestSSL;
        private System.Windows.Forms.CheckBox chkSrcSSL;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.GroupBox gpbCollections;
        private System.Windows.Forms.ListBox lsbCollections;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Button btnLoadDBs;
        private System.Windows.Forms.GroupBox gpbBatchSize;
        private System.Windows.Forms.NumericUpDown nudBatchSize;
    }
}

