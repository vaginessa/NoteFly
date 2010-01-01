﻿namespace NoteFly
{
    partial class FrmAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.okButton = new System.Windows.Forms.Button();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linklblWebsite = new System.Windows.Forms.LinkLabel();
            this.lblTextLicense = new System.Windows.Forms.Label();
            this.timerTextEffect = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbVersionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(90, 142);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(133, 22);
            this.okButton.TabIndex = 25;
            this.okButton.Text = "&Close";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 5);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(145, 24);
            this.lblProductName.TabIndex = 26;
            this.lblProductName.Text = "lblProductName";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(7, 31);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(68, 16);
            this.lblVersion.TabIndex = 27;
            this.lblVersion.Text = "lblVersion";
            // 
            // linklblWebsite
            // 
            this.linklblWebsite.AutoSize = true;
            this.linklblWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblWebsite.Location = new System.Drawing.Point(12, 142);
            this.linklblWebsite.Name = "linklblWebsite";
            this.linklblWebsite.Size = new System.Drawing.Size(62, 18);
            this.linklblWebsite.TabIndex = 28;
            this.linklblWebsite.TabStop = true;
            this.linklblWebsite.Text = "Website";
            this.linklblWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblWebsite_LinkClicked);
            // 
            // lblTextLicense
            // 
            this.lblTextLicense.Location = new System.Drawing.Point(7, 60);
            this.lblTextLicense.Name = "lblTextLicense";
            this.lblTextLicense.Size = new System.Drawing.Size(225, 30);
            this.lblTextLicense.TabIndex = 30;
            this.lblTextLicense.Text = "This programme is released under the terms of GNU Public License version2";
            // 
            // timerTextEffect
            // 
            this.timerTextEffect.Interval = 50;
            this.timerTextEffect.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.CausesValidation = false;
            this.richTextBox1.DetectUrls = false;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(10, 102);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.ShortcutsEnabled = false;
            this.richTextBox1.Size = new System.Drawing.Size(196, 24);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "Happy new year!";
            this.richTextBox1.Visible = false;
            // 
            // lbVersionStatus
            // 
            this.lbVersionStatus.AutoSize = true;
            this.lbVersionStatus.Location = new System.Drawing.Point(87, 33);
            this.lbVersionStatus.Name = "lbVersionStatus";
            this.lbVersionStatus.Size = new System.Drawing.Size(28, 13);
            this.lbVersionStatus.TabIndex = 32;
            this.lbVersionStatus.Text = "RC1";
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 171);
            this.Controls.Add(this.lbVersionStatus);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblTextLicense);
            this.Controls.Add(this.linklblWebsite);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linklblWebsite;
        private System.Windows.Forms.Label lblTextLicense;
        private System.Windows.Forms.Timer timerTextEffect;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbVersionStatus;

    }
}
