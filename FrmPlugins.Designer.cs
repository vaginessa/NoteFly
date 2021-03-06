﻿namespace NoteFly
{
    /// <summary>
    /// FrmPlugins window
    /// </summary>
    public partial class FrmPlugins
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used..</param>
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlugins));
            this.timerTextUpdaterLoading = new System.Windows.Forms.Timer(this.components);
            this.tabPagePluginsAvailable = new System.Windows.Forms.TabPage();
            this.tabPagePluginsInstalled = new System.Windows.Forms.TabPage();
            this.tabControlPlugins = new System.Windows.Forms.TabControl();
            this.tabPagePluginsUpdates = new System.Windows.Forms.TabPage();
            this.tableLayoutpnlPluginUpdates = new System.Windows.Forms.TableLayoutPanel();
            this.chxlbxPluginUpdates = new System.Windows.Forms.CheckedListBox();
            this.btnUpdatePlugins = new System.Windows.Forms.Button();
            this.lbltextpluginupdates = new System.Windows.Forms.Label();
            this.btnRestartProgram = new System.Windows.Forms.Button();
            this.pluginGrid = new NoteFly.PluginGrid();
            this.splitContainerAvailablePlugins = new System.Windows.Forms.SplitContainer();
            this.lblTextNoInternetConnection = new System.Windows.Forms.Label();
            this.lbxAvailablePlugins = new System.Windows.Forms.ListBox();
            this.searchtbPlugins = new NoteFly.SearchTextBox();
            this.linklblPluginMoreInfo = new System.Windows.Forms.LinkLabel();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblPluginVersion = new System.Windows.Forms.Label();
            this.lblPluginName = new System.Windows.Forms.Label();
            this.lblPluginDescription = new System.Windows.Forms.Label();
            this.btnPluginDownload = new System.Windows.Forms.Button();
            this.tabPagePluginsAvailable.SuspendLayout();
            this.tabPagePluginsInstalled.SuspendLayout();
            this.tabControlPlugins.SuspendLayout();
            this.tabPagePluginsUpdates.SuspendLayout();
            this.tableLayoutpnlPluginUpdates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAvailablePlugins)).BeginInit();
            this.splitContainerAvailablePlugins.Panel1.SuspendLayout();
            this.splitContainerAvailablePlugins.Panel2.SuspendLayout();
            this.splitContainerAvailablePlugins.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerTextUpdaterLoading
            // 
            this.timerTextUpdaterLoading.Interval = 200;
            this.timerTextUpdaterLoading.Tick += new System.EventHandler(this.timerTextUpdater_Tick);
            // 
            // tabPagePluginsAvailable
            // 
            this.tabPagePluginsAvailable.Controls.Add(this.splitContainerAvailablePlugins);
            this.tabPagePluginsAvailable.Location = new System.Drawing.Point(4, 25);
            this.tabPagePluginsAvailable.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagePluginsAvailable.Name = "tabPagePluginsAvailable";
            this.tabPagePluginsAvailable.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePluginsAvailable.Size = new System.Drawing.Size(480, 365);
            this.tabPagePluginsAvailable.TabIndex = 0;
            this.tabPagePluginsAvailable.Text = "available";
            this.tabPagePluginsAvailable.UseVisualStyleBackColor = true;
            // 
            // tabPagePluginsInstalled
            // 
            this.tabPagePluginsInstalled.Controls.Add(this.pluginGrid);
            this.tabPagePluginsInstalled.Location = new System.Drawing.Point(4, 25);
            this.tabPagePluginsInstalled.Margin = new System.Windows.Forms.Padding(53, 4, 53, 4);
            this.tabPagePluginsInstalled.Name = "tabPagePluginsInstalled";
            this.tabPagePluginsInstalled.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagePluginsInstalled.Size = new System.Drawing.Size(480, 365);
            this.tabPagePluginsInstalled.TabIndex = 1;
            this.tabPagePluginsInstalled.Text = "Installed";
            this.tabPagePluginsInstalled.UseVisualStyleBackColor = true;
            // 
            // tabControlPlugins
            // 
            this.tabControlPlugins.Controls.Add(this.tabPagePluginsInstalled);
            this.tabControlPlugins.Controls.Add(this.tabPagePluginsAvailable);
            this.tabControlPlugins.Controls.Add(this.tabPagePluginsUpdates);
            this.tabControlPlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPlugins.Location = new System.Drawing.Point(0, 0);
            this.tabControlPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlPlugins.Name = "tabControlPlugins";
            this.tabControlPlugins.SelectedIndex = 0;
            this.tabControlPlugins.ShowToolTips = true;
            this.tabControlPlugins.Size = new System.Drawing.Size(488, 394);
            this.tabControlPlugins.TabIndex = 0;
            this.tabControlPlugins.SelectedIndexChanged += new System.EventHandler(this.tabControlPlugins_SelectedIndexChanged);
            // 
            // tabPagePluginsUpdates
            // 
            this.tabPagePluginsUpdates.Controls.Add(this.tableLayoutpnlPluginUpdates);
            this.tabPagePluginsUpdates.Location = new System.Drawing.Point(4, 25);
            this.tabPagePluginsUpdates.Name = "tabPagePluginsUpdates";
            this.tabPagePluginsUpdates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePluginsUpdates.Size = new System.Drawing.Size(480, 365);
            this.tabPagePluginsUpdates.TabIndex = 2;
            this.tabPagePluginsUpdates.Text = "updates";
            this.tabPagePluginsUpdates.UseVisualStyleBackColor = true;
            // 
            // tableLayoutpnlPluginUpdates
            // 
            this.tableLayoutpnlPluginUpdates.ColumnCount = 3;
            this.tableLayoutpnlPluginUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.07173F));
            this.tableLayoutpnlPluginUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.80169F));
            this.tableLayoutpnlPluginUpdates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.33755F));
            this.tableLayoutpnlPluginUpdates.Controls.Add(this.chxlbxPluginUpdates, 1, 2);
            this.tableLayoutpnlPluginUpdates.Controls.Add(this.btnUpdatePlugins, 1, 3);
            this.tableLayoutpnlPluginUpdates.Controls.Add(this.lbltextpluginupdates, 1, 1);
            this.tableLayoutpnlPluginUpdates.Controls.Add(this.btnRestartProgram, 1, 4);
            this.tableLayoutpnlPluginUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutpnlPluginUpdates.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutpnlPluginUpdates.Name = "tableLayoutpnlPluginUpdates";
            this.tableLayoutpnlPluginUpdates.RowCount = 6;
            this.tableLayoutpnlPluginUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.tableLayoutpnlPluginUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.27273F));
            this.tableLayoutpnlPluginUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.tableLayoutpnlPluginUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutpnlPluginUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutpnlPluginUpdates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutpnlPluginUpdates.Size = new System.Drawing.Size(474, 359);
            this.tableLayoutpnlPluginUpdates.TabIndex = 2;
            // 
            // chxlbxPluginUpdates
            // 
            this.chxlbxPluginUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chxlbxPluginUpdates.FormattingEnabled = true;
            this.chxlbxPluginUpdates.Location = new System.Drawing.Point(42, 47);
            this.chxlbxPluginUpdates.Margin = new System.Windows.Forms.Padding(0);
            this.chxlbxPluginUpdates.Name = "chxlbxPluginUpdates";
            this.chxlbxPluginUpdates.Size = new System.Drawing.Size(382, 196);
            this.chxlbxPluginUpdates.TabIndex = 0;
            this.chxlbxPluginUpdates.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chxlbxPluginUpdates_ItemCheck);
            // 
            // btnUpdatePlugins
            // 
            this.btnUpdatePlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdatePlugins.Location = new System.Drawing.Point(45, 246);
            this.btnUpdatePlugins.Name = "btnUpdatePlugins";
            this.btnUpdatePlugins.Size = new System.Drawing.Size(376, 29);
            this.btnUpdatePlugins.TabIndex = 1;
            this.btnUpdatePlugins.Text = "&Update selected plugins";
            this.btnUpdatePlugins.UseCompatibleTextRendering = true;
            this.btnUpdatePlugins.UseVisualStyleBackColor = true;
            this.btnUpdatePlugins.Click += new System.EventHandler(this.btnupdateplugins_Click);
            // 
            // lbltextpluginupdates
            // 
            this.lbltextpluginupdates.AutoSize = true;
            this.lbltextpluginupdates.Location = new System.Drawing.Point(45, 25);
            this.lbltextpluginupdates.Name = "lbltextpluginupdates";
            this.lbltextpluginupdates.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lbltextpluginupdates.Size = new System.Drawing.Size(159, 20);
            this.lbltextpluginupdates.TabIndex = 2;
            this.lbltextpluginupdates.Text = "Available plugin updates:";
            // 
            // btnRestartProgram
            // 
            this.btnRestartProgram.BackColor = System.Drawing.Color.Transparent;
            this.btnRestartProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartProgram.Location = new System.Drawing.Point(45, 281);
            this.btnRestartProgram.Name = "btnRestartProgram";
            this.btnRestartProgram.Size = new System.Drawing.Size(376, 31);
            this.btnRestartProgram.TabIndex = 3;
            this.btnRestartProgram.Text = "&Restart";
            this.btnRestartProgram.UseCompatibleTextRendering = true;
            this.btnRestartProgram.UseVisualStyleBackColor = false;
            this.btnRestartProgram.Visible = false;
            this.btnRestartProgram.Click += new System.EventHandler(this.btnRestartProgram_Click);
            // 
            // pluginGrid
            // 
            this.pluginGrid.AutoScroll = true;
            this.pluginGrid.BackColor = System.Drawing.Color.Transparent;
            this.pluginGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pluginGrid.Location = new System.Drawing.Point(4, 4);
            this.pluginGrid.Margin = new System.Windows.Forms.Padding(0);
            this.pluginGrid.MinimumSize = new System.Drawing.Size(10, 10);
            this.pluginGrid.Name = "pluginGrid";
            this.pluginGrid.Size = new System.Drawing.Size(472, 357);
            this.pluginGrid.TabIndex = 0;
            // 
            // splitContainerAvailablePlugins
            // 
            this.splitContainerAvailablePlugins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAvailablePlugins.Location = new System.Drawing.Point(4, 4);
            this.splitContainerAvailablePlugins.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainerAvailablePlugins.Name = "splitContainerAvailablePlugins";
            // 
            // splitContainerAvailablePlugins.Panel1
            // 
            this.splitContainerAvailablePlugins.Panel1.Controls.Add(this.lblTextNoInternetConnection);
            this.splitContainerAvailablePlugins.Panel1.Controls.Add(this.lbxAvailablePlugins);
            this.splitContainerAvailablePlugins.Panel1.Controls.Add(this.searchtbPlugins);
            this.splitContainerAvailablePlugins.Panel1MinSize = 0;
            // 
            // splitContainerAvailablePlugins.Panel2
            // 
            this.splitContainerAvailablePlugins.Panel2.Controls.Add(this.linklblPluginMoreInfo);
            this.splitContainerAvailablePlugins.Panel2.Controls.Add(this.lblLicense);
            this.splitContainerAvailablePlugins.Panel2.Controls.Add(this.lblPluginVersion);
            this.splitContainerAvailablePlugins.Panel2.Controls.Add(this.lblPluginName);
            this.splitContainerAvailablePlugins.Panel2.Controls.Add(this.lblPluginDescription);
            this.splitContainerAvailablePlugins.Panel2.Controls.Add(this.btnPluginDownload);
            this.splitContainerAvailablePlugins.Panel2MinSize = 0;
            this.splitContainerAvailablePlugins.Size = new System.Drawing.Size(472, 357);
            this.splitContainerAvailablePlugins.SplitterDistance = 221;
            this.splitContainerAvailablePlugins.SplitterWidth = 5;
            this.splitContainerAvailablePlugins.TabIndex = 0;
            // 
            // lblTextNoInternetConnection
            // 
            this.lblTextNoInternetConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblTextNoInternetConnection.Location = new System.Drawing.Point(4, 48);
            this.lblTextNoInternetConnection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextNoInternetConnection.Name = "lblTextNoInternetConnection";
            this.lblTextNoInternetConnection.Size = new System.Drawing.Size(213, 129);
            this.lblTextNoInternetConnection.TabIndex = 2;
            this.lblTextNoInternetConnection.Visible = false;
            // 
            // lbxAvailablePlugins
            // 
            this.lbxAvailablePlugins.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbxAvailablePlugins.Enabled = false;
            this.lbxAvailablePlugins.FormattingEnabled = true;
            this.lbxAvailablePlugins.ItemHeight = 16;
            this.lbxAvailablePlugins.Items.AddRange(new object[] {
            "Loading..."});
            this.lbxAvailablePlugins.Location = new System.Drawing.Point(0, 0);
            this.lbxAvailablePlugins.Name = "lbxAvailablePlugins";
            this.lbxAvailablePlugins.Size = new System.Drawing.Size(221, 324);
            this.lbxAvailablePlugins.TabIndex = 5;
            this.lbxAvailablePlugins.SelectedIndexChanged += new System.EventHandler(this.lbxAvailablePlugins_SelectedIndexChanged);
            // 
            // searchtbPlugins
            // 
            this.searchtbPlugins.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchtbPlugins.Enabled = false;
            this.searchtbPlugins.Location = new System.Drawing.Point(0, 327);
            this.searchtbPlugins.Margin = new System.Windows.Forms.Padding(4);
            this.searchtbPlugins.MaximumSize = new System.Drawing.Size(220, 30);
            this.searchtbPlugins.Name = "searchtbPlugins";
            this.searchtbPlugins.Size = new System.Drawing.Size(220, 30);
            this.searchtbPlugins.TabIndex = 4;
            this.searchtbPlugins.SearchStart += new NoteFly.SearchTextBox.SearchStartHandler(this.searchtbPlugins_SearchStart);
            this.searchtbPlugins.SearchStop += new NoteFly.SearchTextBox.SearchStopHandler(this.searchtbPlugins_SearchStop);
            // 
            // linklblPluginMoreInfo
            // 
            this.linklblPluginMoreInfo.AutoSize = true;
            this.linklblPluginMoreInfo.Location = new System.Drawing.Point(168, 276);
            this.linklblPluginMoreInfo.Name = "linklblPluginMoreInfo";
            this.linklblPluginMoreInfo.Size = new System.Drawing.Size(63, 16);
            this.linklblPluginMoreInfo.TabIndex = 4;
            this.linklblPluginMoreInfo.TabStop = true;
            this.linklblPluginMoreInfo.Text = "more info";
            this.linklblPluginMoreInfo.Visible = false;
            this.linklblPluginMoreInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblPluginMoreInfo_LinkClicked);
            // 
            // lblLicense
            // 
            this.lblLicense.ForeColor = System.Drawing.Color.Black;
            this.lblLicense.Location = new System.Drawing.Point(12, 79);
            this.lblLicense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(219, 27);
            this.lblLicense.TabIndex = 3;
            // 
            // lblPluginVersion
            // 
            this.lblPluginVersion.ForeColor = System.Drawing.Color.DimGray;
            this.lblPluginVersion.Location = new System.Drawing.Point(12, 50);
            this.lblPluginVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPluginVersion.Name = "lblPluginVersion";
            this.lblPluginVersion.Size = new System.Drawing.Size(219, 28);
            this.lblPluginVersion.TabIndex = 2;
            // 
            // lblPluginName
            // 
            this.lblPluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblPluginName.Location = new System.Drawing.Point(6, 15);
            this.lblPluginName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPluginName.Name = "lblPluginName";
            this.lblPluginName.Size = new System.Drawing.Size(232, 29);
            this.lblPluginName.TabIndex = 1;
            // 
            // lblPluginDescription
            // 
            this.lblPluginDescription.Location = new System.Drawing.Point(11, 106);
            this.lblPluginDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPluginDescription.Name = "lblPluginDescription";
            this.lblPluginDescription.Size = new System.Drawing.Size(220, 186);
            this.lblPluginDescription.TabIndex = 0;
            // 
            // btnPluginDownload
            // 
            this.btnPluginDownload.Location = new System.Drawing.Point(4, 329);
            this.btnPluginDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnPluginDownload.Name = "btnPluginDownload";
            this.btnPluginDownload.Size = new System.Drawing.Size(238, 28);
            this.btnPluginDownload.TabIndex = 0;
            this.btnPluginDownload.UseCompatibleTextRendering = true;
            this.btnPluginDownload.UseVisualStyleBackColor = true;
            this.btnPluginDownload.Visible = false;
            this.btnPluginDownload.Click += new System.EventHandler(this.btnPluginDownload_Click);
            // 
            // FrmPlugins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(488, 394);
            this.Controls.Add(this.tabControlPlugins);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlugins";
            this.tabPagePluginsAvailable.ResumeLayout(false);
            this.tabPagePluginsInstalled.ResumeLayout(false);
            this.tabControlPlugins.ResumeLayout(false);
            this.tabPagePluginsUpdates.ResumeLayout(false);
            this.tableLayoutpnlPluginUpdates.ResumeLayout(false);
            this.tableLayoutpnlPluginUpdates.PerformLayout();
            this.splitContainerAvailablePlugins.Panel1.ResumeLayout(false);
            this.splitContainerAvailablePlugins.Panel2.ResumeLayout(false);
            this.splitContainerAvailablePlugins.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAvailablePlugins)).EndInit();
            this.splitContainerAvailablePlugins.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerTextUpdaterLoading;
        private System.Windows.Forms.TabPage tabPagePluginsAvailable;
        private System.Windows.Forms.SplitContainer splitContainerAvailablePlugins;
        private System.Windows.Forms.Label lblTextNoInternetConnection;
        private System.Windows.Forms.ListBox lbxAvailablePlugins;
        private SearchTextBox searchtbPlugins;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblPluginVersion;
        private System.Windows.Forms.Label lblPluginName;
        private System.Windows.Forms.Label lblPluginDescription;
        private System.Windows.Forms.Button btnPluginDownload;
        private System.Windows.Forms.TabPage tabPagePluginsInstalled;
        private PluginGrid pluginGrid;
        private System.Windows.Forms.TabControl tabControlPlugins;
        private System.Windows.Forms.TabPage tabPagePluginsUpdates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutpnlPluginUpdates;
        private System.Windows.Forms.CheckedListBox chxlbxPluginUpdates;
        private System.Windows.Forms.Button btnUpdatePlugins;
        private System.Windows.Forms.Label lbltextpluginupdates;
        private System.Windows.Forms.Button btnRestartProgram;
        private System.Windows.Forms.LinkLabel linklblPluginMoreInfo;

    }
}