//---------------------------------------------------------------------------------------------
// <copyright file="Email.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Net.Mail;

/// <summary>
/// Summary description for Email
/// </summary>
namespace Chandam.Util
{
	public class Email
	{
		public void SendMail(string toList, string from, string ccList, string subject, string body)
		{

			MailMessage message = new MailMessage();
			SmtpClient smtpClient = new SmtpClient();
			try
			{
				MailAddress fromAddress = new MailAddress(from);
				message.From = fromAddress;
				message.To.Add(toList);
				if (ccList != null && ccList != string.Empty)
				{
					message.CC.Add(ccList);
				}
				message.Subject = subject;
				message.IsBodyHtml = true;
				message.Body = body;
				// We use gmail as our smtp client
				smtpClient.Host = "smtp.gmail.com";
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.UseDefaultCredentials = true;
				smtpClient.Credentials = new System.Net.NetworkCredential("mdileep", "");
				smtpClient.Send(message);
			}
			catch
			{

			}
		}
	}
}
