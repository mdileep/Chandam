//---------------------------------------------------------------------------------------------
// <copyright file="Log.cs" company="Chandam-ఛందం">
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
	public class Log : IHttpHandler
	{
		const string from = "telugu.chandam@gmail.com";
		const string to = "m.dileep@gmail.com";
		private string FixResposne(string s)
		{
			return s.Replace("_l_", "<").Replace("_r_", ">").Replace("\n", "<br/>");

		}
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";

			string t = context.Request.Form["t"];
			string email = context.Request.Form["e"];
			string sub = context.Request.Form["n"];
			string code = context.Request.Form["c"];
			string rules = context.Request.Form["r"];

			rules = FixResposne(rules);
			code = FixResposne(code);


			switch (t)
			{
				case "rc":
					try
					{

						new Email().SendMail(from, to, "Rules and Code for " + sub, rules + "<br />" + code);
					}
					catch (Exception ex)
					{
						context.Response.Write(ex.Message + "<br/>" + ex.StackTrace);
					}

					try
					{
						if (!new System.Text.RegularExpressions.Regex("\\S+@\\S+\\.\\S+").IsMatch(email))
						{
							return;
						}

						new Email().SendMail(from, email, "Rules for " + sub, rules);
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
