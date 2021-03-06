﻿namespace DataTransformation
{
  partial class frmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.tabTop = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.lblPassword = new System.Windows.Forms.Label();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.chkSaveDraftMail = new System.Windows.Forms.CheckBox();
      this.chkSaveTxtFile = new System.Windows.Forms.CheckBox();
      this.chkClipboard = new System.Windows.Forms.CheckBox();
      this.btnTransformation = new System.Windows.Forms.Button();
      this.lblFileSize = new System.Windows.Forms.Label();
      this.lblFileExt = new System.Windows.Forms.Label();
      this.lblFilePath = new System.Windows.Forms.Label();
      this.txtData = new System.Windows.Forms.TextBox();
      this.btnOpenFile = new System.Windows.Forms.Button();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.lblDePassword = new System.Windows.Forms.Label();
      this.txtDePassword = new System.Windows.Forms.TextBox();
      this.btnClear = new System.Windows.Forms.Button();
      this.lblGo = new System.Windows.Forms.Label();
      this.btnOpen = new System.Windows.Forms.Button();
      this.txtEncodedData = new System.Windows.Forms.TextBox();
      this.btnShow = new System.Windows.Forms.Button();
      this.cmbMailDrafts = new System.Windows.Forms.ComboBox();
      this.lblDraftList = new System.Windows.Forms.Label();
      this.btnRefreshMailDrafts = new System.Windows.Forms.Button();
      this.tabTop.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabTop
      // 
      this.tabTop.Controls.Add(this.tabPage1);
      this.tabTop.Controls.Add(this.tabPage2);
      this.tabTop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabTop.Location = new System.Drawing.Point(0, 0);
      this.tabTop.Name = "tabTop";
      this.tabTop.SelectedIndex = 0;
      this.tabTop.Size = new System.Drawing.Size(607, 510);
      this.tabTop.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.lblPassword);
      this.tabPage1.Controls.Add(this.txtPassword);
      this.tabPage1.Controls.Add(this.chkSaveDraftMail);
      this.tabPage1.Controls.Add(this.chkSaveTxtFile);
      this.tabPage1.Controls.Add(this.chkClipboard);
      this.tabPage1.Controls.Add(this.btnTransformation);
      this.tabPage1.Controls.Add(this.lblFileSize);
      this.tabPage1.Controls.Add(this.lblFileExt);
      this.tabPage1.Controls.Add(this.lblFilePath);
      this.tabPage1.Controls.Add(this.txtData);
      this.tabPage1.Controls.Add(this.btnOpenFile);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(599, 484);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Package";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // lblPassword
      // 
      this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(406, 76);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(56, 13);
      this.lblPassword.TabIndex = 6;
      this.lblPassword.Text = "Password:";
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPassword.Location = new System.Drawing.Point(468, 72);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.Size = new System.Drawing.Size(123, 20);
      this.txtPassword.TabIndex = 5;
      this.txtPassword.UseSystemPasswordChar = true;
      // 
      // chkSaveDraftMail
      // 
      this.chkSaveDraftMail.AutoSize = true;
      this.chkSaveDraftMail.Checked = true;
      this.chkSaveDraftMail.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkSaveDraftMail.Location = new System.Drawing.Point(254, 74);
      this.chkSaveDraftMail.Name = "chkSaveDraftMail";
      this.chkSaveDraftMail.Size = new System.Drawing.Size(110, 17);
      this.chkSaveDraftMail.TabIndex = 4;
      this.chkSaveDraftMail.Text = "Save as draft mail";
      this.chkSaveDraftMail.UseVisualStyleBackColor = true;
      // 
      // chkSaveTxtFile
      // 
      this.chkSaveTxtFile.AutoSize = true;
      this.chkSaveTxtFile.Location = new System.Drawing.Point(133, 74);
      this.chkSaveTxtFile.Name = "chkSaveTxtFile";
      this.chkSaveTxtFile.Size = new System.Drawing.Size(105, 17);
      this.chkSaveTxtFile.TabIndex = 4;
      this.chkSaveTxtFile.Text = "Save as TXT file";
      this.chkSaveTxtFile.UseVisualStyleBackColor = true;
      // 
      // chkClipboard
      // 
      this.chkClipboard.AutoSize = true;
      this.chkClipboard.Checked = true;
      this.chkClipboard.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkClipboard.Location = new System.Drawing.Point(9, 74);
      this.chkClipboard.Name = "chkClipboard";
      this.chkClipboard.Size = new System.Drawing.Size(108, 17);
      this.chkClipboard.TabIndex = 4;
      this.chkClipboard.Text = "Copy to clipboard";
      this.chkClipboard.UseVisualStyleBackColor = true;
      // 
      // btnTransformation
      // 
      this.btnTransformation.Location = new System.Drawing.Point(9, 40);
      this.btnTransformation.Name = "btnTransformation";
      this.btnTransformation.Size = new System.Drawing.Size(108, 27);
      this.btnTransformation.TabIndex = 3;
      this.btnTransformation.Text = "&Transformation";
      this.btnTransformation.UseVisualStyleBackColor = true;
      this.btnTransformation.Click += new System.EventHandler(this.btnTransformation_Click);
      // 
      // lblFileSize
      // 
      this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFileSize.AutoEllipsis = true;
      this.lblFileSize.Location = new System.Drawing.Point(123, 47);
      this.lblFileSize.Name = "lblFileSize";
      this.lblFileSize.Size = new System.Drawing.Size(468, 17);
      this.lblFileSize.TabIndex = 2;
      // 
      // lblFileExt
      // 
      this.lblFileExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFileExt.AutoEllipsis = true;
      this.lblFileExt.Location = new System.Drawing.Point(123, 31);
      this.lblFileExt.Name = "lblFileExt";
      this.lblFileExt.Size = new System.Drawing.Size(468, 17);
      this.lblFileExt.TabIndex = 2;
      // 
      // lblFilePath
      // 
      this.lblFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFilePath.AutoEllipsis = true;
      this.lblFilePath.Location = new System.Drawing.Point(123, 7);
      this.lblFilePath.Name = "lblFilePath";
      this.lblFilePath.Size = new System.Drawing.Size(468, 17);
      this.lblFilePath.TabIndex = 2;
      // 
      // txtData
      // 
      this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtData.Location = new System.Drawing.Point(9, 97);
      this.txtData.Multiline = true;
      this.txtData.Name = "txtData";
      this.txtData.ReadOnly = true;
      this.txtData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtData.Size = new System.Drawing.Size(582, 379);
      this.txtData.TabIndex = 1;
      // 
      // btnOpenFile
      // 
      this.btnOpenFile.Location = new System.Drawing.Point(9, 7);
      this.btnOpenFile.Name = "btnOpenFile";
      this.btnOpenFile.Size = new System.Drawing.Size(108, 27);
      this.btnOpenFile.TabIndex = 0;
      this.btnOpenFile.Text = "&Open ...";
      this.btnOpenFile.UseVisualStyleBackColor = true;
      this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.btnRefreshMailDrafts);
      this.tabPage2.Controls.Add(this.lblDraftList);
      this.tabPage2.Controls.Add(this.cmbMailDrafts);
      this.tabPage2.Controls.Add(this.lblDePassword);
      this.tabPage2.Controls.Add(this.txtDePassword);
      this.tabPage2.Controls.Add(this.btnClear);
      this.tabPage2.Controls.Add(this.lblGo);
      this.tabPage2.Controls.Add(this.btnOpen);
      this.tabPage2.Controls.Add(this.txtEncodedData);
      this.tabPage2.Controls.Add(this.btnShow);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(599, 484);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Un-package";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // lblDePassword
      // 
      this.lblDePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblDePassword.AutoSize = true;
      this.lblDePassword.Location = new System.Drawing.Point(119, 460);
      this.lblDePassword.Name = "lblDePassword";
      this.lblDePassword.Size = new System.Drawing.Size(56, 13);
      this.lblDePassword.TabIndex = 8;
      this.lblDePassword.Text = "Password:";
      // 
      // txtDePassword
      // 
      this.txtDePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txtDePassword.Location = new System.Drawing.Point(182, 456);
      this.txtDePassword.Name = "txtDePassword";
      this.txtDePassword.Size = new System.Drawing.Size(123, 20);
      this.txtDePassword.TabIndex = 7;
      this.txtDePassword.UseSystemPasswordChar = true;
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnClear.Location = new System.Drawing.Point(119, 429);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 23);
      this.btnClear.TabIndex = 4;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // lblGo
      // 
      this.lblGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
      this.lblGo.AutoSize = true;
      this.lblGo.Location = new System.Drawing.Point(347, 446);
      this.lblGo.Name = "lblGo";
      this.lblGo.Size = new System.Drawing.Size(34, 13);
      this.lblGo.TabIndex = 3;
      this.lblGo.Text = "--->>>";
      // 
      // btnOpen
      // 
      this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnOpen.Location = new System.Drawing.Point(8, 429);
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(105, 47);
      this.btnOpen.TabIndex = 2;
      this.btnOpen.Text = "Open ...";
      this.btnOpen.UseVisualStyleBackColor = true;
      this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
      // 
      // txtEncodedData
      // 
      this.txtEncodedData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtEncodedData.Location = new System.Drawing.Point(8, 34);
      this.txtEncodedData.MaxLength = 2147483647;
      this.txtEncodedData.Multiline = true;
      this.txtEncodedData.Name = "txtEncodedData";
      this.txtEncodedData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtEncodedData.Size = new System.Drawing.Size(583, 389);
      this.txtEncodedData.TabIndex = 1;
      // 
      // btnShow
      // 
      this.btnShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnShow.Location = new System.Drawing.Point(486, 429);
      this.btnShow.Name = "btnShow";
      this.btnShow.Size = new System.Drawing.Size(105, 47);
      this.btnShow.TabIndex = 0;
      this.btnShow.Text = "Show ...";
      this.btnShow.UseVisualStyleBackColor = true;
      this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
      // 
      // cmbMailDrafts
      // 
      this.cmbMailDrafts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbMailDrafts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbMailDrafts.FormattingEnabled = true;
      this.cmbMailDrafts.Location = new System.Drawing.Point(74, 7);
      this.cmbMailDrafts.Name = "cmbMailDrafts";
      this.cmbMailDrafts.Size = new System.Drawing.Size(488, 21);
      this.cmbMailDrafts.TabIndex = 9;
      this.cmbMailDrafts.SelectedIndexChanged += new System.EventHandler(this.cmbMailDrafts_SelectedIndexChanged);
      // 
      // lblDraftList
      // 
      this.lblDraftList.AutoSize = true;
      this.lblDraftList.Location = new System.Drawing.Point(8, 11);
      this.lblDraftList.Name = "lblDraftList";
      this.lblDraftList.Size = new System.Drawing.Size(60, 13);
      this.lblDraftList.TabIndex = 10;
      this.lblDraftList.Text = "Mail Drafts:";
      // 
      // btnRefreshMailDrafts
      // 
      this.btnRefreshMailDrafts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRefreshMailDrafts.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshMailDrafts.Image")));
      this.btnRefreshMailDrafts.Location = new System.Drawing.Point(568, 6);
      this.btnRefreshMailDrafts.Name = "btnRefreshMailDrafts";
      this.btnRefreshMailDrafts.Size = new System.Drawing.Size(23, 23);
      this.btnRefreshMailDrafts.TabIndex = 11;
      this.btnRefreshMailDrafts.UseVisualStyleBackColor = true;
      this.btnRefreshMailDrafts.Click += new System.EventHandler(this.btnRefreshMailDrafts_Click);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(607, 510);
      this.Controls.Add(this.tabTop);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MinimumSize = new System.Drawing.Size(600, 500);
      this.Name = "frmMain";
      this.Text = "Data Transformation";
      this.tabTop.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabTop;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.CheckBox chkSaveDraftMail;
    private System.Windows.Forms.CheckBox chkSaveTxtFile;
    private System.Windows.Forms.CheckBox chkClipboard;
    private System.Windows.Forms.Button btnTransformation;
    private System.Windows.Forms.Label lblFilePath;
    private System.Windows.Forms.TextBox txtData;
    private System.Windows.Forms.Button btnOpenFile;
    private System.Windows.Forms.Label lblFileExt;
    private System.Windows.Forms.Label lblGo;
    private System.Windows.Forms.Button btnOpen;
    private System.Windows.Forms.TextBox txtEncodedData;
    private System.Windows.Forms.Button btnShow;
    private System.Windows.Forms.Label lblFileSize;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.TextBox txtPassword;
    private System.Windows.Forms.Label lblDePassword;
    private System.Windows.Forms.TextBox txtDePassword;
    private System.Windows.Forms.Button btnRefreshMailDrafts;
    private System.Windows.Forms.Label lblDraftList;
    private System.Windows.Forms.ComboBox cmbMailDrafts;
  }
}

