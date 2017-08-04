using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Office.Interop.Outlook;

namespace DataTransformation
{
  internal class OutlookDraftBoxTool
  {
    private const string DraftMailIdentifier = "DataTransformation-Data-DraftMail - ";
    private const string DraftMailSubjectFormat = "{0}{1} - {2}";

    internal static void SaveAsDraft(string fileName, string data)
    {
      var outlook = new Application();
      MailItem mail = outlook.CreateItem(OlItemType.olMailItem);
      mail.Subject = string.Format(DraftMailSubjectFormat, DraftMailIdentifier, DateTime.Now, fileName);
      mail.Body = data;
      mail.Save();
    }

    internal static IEnumerable<DraftMail> RetrieveDraftMails()
    {
      var outlook = new Application();
      var drafts = outlook.Session.GetDefaultFolder(OlDefaultFolders.olFolderDrafts);

      return from MailItem mail in drafts.Items
        where mail.Subject.StartsWith(DraftMailIdentifier)
        select new DraftMail(mail.Subject.Replace(DraftMailIdentifier, string.Empty), mail.Body);
    }
  }

  internal class DraftMail
  {
    public DraftMail(string subject, string body)
      {
        Subject = subject;
        Body = body;
      }

    public string Subject { get; set; }
    public string Body { get; set; }
  }
}
