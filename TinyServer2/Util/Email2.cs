//---------------------------------------------------------------------------------------------
// <copyright file="Email2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Net.Mail;


namespace Server
{
	public class Email
	{
		const string uid = "telugu.chandam";
		const string pwd = "";
		const string host = "smtp.gmail.com";
		const int port = 587;

		public void SendMail(string from, string toList, string subject, string body)
		{
			SendMail(from, toList, "", subject, body);
		}
		public void SendMail(string from, string toList, string ccList, string subject, string body)
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
				smtpClient.Host = host;
				smtpClient.Port = port;
				smtpClient.EnableSsl = true;
				smtpClient.UseDefaultCredentials = true;
				smtpClient.Credentials = new System.Net.NetworkCredential(uid, pwd);
				smtpClient.Send(message);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}



}