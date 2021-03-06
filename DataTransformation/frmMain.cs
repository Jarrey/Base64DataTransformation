﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using Exception = System.Exception;

namespace DataTransformation
{
  public partial class frmMain : Form
  {
    private const string FILE_PATH_LABEL = "File: ";
    private const string FILE_EXT_LABEL = "Ext.: ";
    private const string FILE_SIZE_LABEL = "Size: {0} bytes";

    public frmMain()
    {
      InitializeComponent();
    }

    #region Properties
    private FileInfo SelectedOriginalFile { get; set; }
    private FileInfo SelectedDataFile { get; set; }
    #endregion

    #region Event Handlers

    private void btnOpenFile_Click(object sender, EventArgs e)
    {
      using (var openfile = new OpenFileDialog { Filter = @"All Files|*.*" })
      {
        if (openfile.ShowDialog() == DialogResult.OK)
        {
          var fileinfo = new FileInfo(openfile.FileName);
          lblFilePath.Text = FILE_PATH_LABEL + fileinfo.FullName;
          lblFileExt.Text = FILE_EXT_LABEL + fileinfo.Extension;
          lblFileSize.Text = string.Format(FILE_SIZE_LABEL, fileinfo.Length);
          SelectedOriginalFile = fileinfo;
        }
      }
    }

    private void btnTransformation_Click(object sender, EventArgs e)
    {
      if (SelectedOriginalFile == null)
      {
        MessageBox.Show(@"Please select one file first.");
        return;
      }

      if (!SelectedOriginalFile.Exists)
      {
        MessageBox.Show(string.Format("Cannot find the file: {0}", SelectedOriginalFile.FullName));
      }

      byte[] filedata = File.ReadAllBytes(SelectedOriginalFile.FullName);
      var data = SelectedOriginalFile.Extension + "|" + EncryptionTool.Encrypt(txtPassword.Text, filedata);
      txtData.Text = data.Substring(0, Math.Min(data.Length, 5000));

      // Do actions
      // Save to local clipboard
      if (chkClipboard.Checked)
      {
        Clipboard.SetText(data);
      }

      // Save as text file locally
      if (chkSaveTxtFile.Checked)
      {
        using (var savefile = new SaveFileDialog { OverwritePrompt = true, Filter = @"Text File|*.txt", DefaultExt = ".txt" })
        {
          if (savefile.ShowDialog() == DialogResult.OK)
          {
            File.WriteAllText(savefile.FileName, data);
          }
        }
      }

      // Save to Outlook draft mail, that can be access via Web Mail
      if (chkSaveDraftMail.Checked)
      {
        OutlookDraftBoxTool.SaveAsDraft(SelectedOriginalFile.Name, data);
      }
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
      using (var openfile = new OpenFileDialog { Filter = @"Ecoded Text File|*.txt|All Files|*.*" })
      {
        if (openfile.ShowDialog() == DialogResult.OK)
        {
          SelectedDataFile = new FileInfo(openfile.FileName);
        }
      }
    }

    private void btnShow_Click(object sender, EventArgs e)
    {
      if ((SelectedDataFile == null || !SelectedDataFile.Exists) && string.IsNullOrEmpty(txtEncodedData.Text))
      {
        MessageBox.Show(@"Please select one data file or paste data into box.");
        return;
      }

      string data = string.Empty;
      string ext = ".bin";
      if (SelectedDataFile != null && SelectedDataFile.Exists)
      {
        ParseDataExtension(File.ReadAllText(SelectedDataFile.FullName), ref data, ref ext);
      }
      else
      {
        ParseDataExtension(txtEncodedData.Text, ref data, ref ext);
      }

      using (var savefile = new SaveFileDialog { OverwritePrompt = true, Filter = ext + @" Files|*" + ext + @"|All Files|*.*", DefaultExt = ext })
      {
        if (savefile.ShowDialog() == DialogResult.OK)
        {
          try
          {
            File.WriteAllBytes(savefile.FileName, EncryptionTool.Decrypt(txtDePassword.Text, data));
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtEncodedData.Clear();
    }

    private void btnRefreshMailDrafts_Click(object sender, EventArgs e)
    {
      cmbMailDrafts.DisplayMember = "Subject";
      cmbMailDrafts.DataSource = OutlookDraftBoxTool.RetrieveDraftMails().ToList();
    }

    private void cmbMailDrafts_SelectedIndexChanged(object sender, EventArgs e)
    {
      var draftMail =cmbMailDrafts.SelectedItem as DraftMail;
      if (draftMail != null)
      {
        txtEncodedData.Text = draftMail.Body;
      }
    }

    #endregion

    private void ParseDataExtension(string d, ref string data, ref string ext)
    {
      var ds = d.Split('|');
      if (ds.Length > 1)
      {
        ext = ds[0];
        data = ds[1];
      }
      else
      {
        data = ds[0];
      }
    }
  }
}
