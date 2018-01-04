//---------------------------------------------------------------------------------------------
// <copyright file="Feedback.cs" company="Chandam-ఛందం">
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
using System.Web;

namespace Server
{
	public class Feedback : IHttpHandler
	{
		const string from = "telugu.chandam@gmail.com";
		const string to = "m.dileep@gmail.com";
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";

			string name = context.Request.Form["n"];
			string email = context.Request.Form["e"];
			string sub = "Feedback on Chandam " + (String.IsNullOrEmpty(name) ? "" : " from [ Sri " + name + "]");
			string body = context.Request.Form["m"];

			string t = "f";
			switch (t)
			{
				case "f":
					try
					{
						if (!new System.Text.RegularExpressions.Regex("\\S+@\\S+\\.\\S+").IsMatch(email))
						{
							new Email().SendMail(from, to, sub, body);
							return;
						}

						new Email().SendMail(from, to, email, sub, body);
					}
					catch (Exception ex)
					{
						context.Response.Write(ex.Message + "<br/>" + ex.StackTrace);
					}
					break;
			}
		}

		public bool IsReusable
		{
			get
			{
				return false;
			}
		}
	}
}
