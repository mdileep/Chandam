//---------------------------------------------------------------------------------------------
// <copyright file="MinifyJS.cs" company="Chandam-ఛందం">
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
using System.IO;
using System.Web;

namespace Server
{
	public class MinifyJS : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			//Todo:Enable Cache..
			try
			{
				if (context.Request.Url.Host.Contains("localhost"))
				{
					context.Response.ContentType = "application/x-javascript";
					string[] Files = new string[] {"JS/ssloader.js",
"JS/ss.js",
"JS/Samples.min.js",
"JS/sortabletable.js",
"JS/ajax.js",
"JS/MiriyamLib.min.js",
"JS/MiriyamApp.min.js",
"JS/ga.js" };

					using (StreamWriter W = new StreamWriter(context.Server.MapPath("JS/chandam.js")))
					{
						foreach (string file in Files)
						{
							W.Write(File.ReadAllText(context.Server.MapPath(file)));
							W.Write(Environment.NewLine);
						}
					}
				}

				context.Response.WriteFile(context.Server.MapPath("JS/chandam.js"));

			}
			catch
			{
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
