//---------------------------------------------------------------------------------------------
// <copyright file="Reports.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Server.ReportsUtil;
using System.Web;

namespace Server
{
	public class Reports : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";

			try
			{
				string r = "";
				string t = context.Request.Form["r"];
				switch (t)
				{

					default:
					case "wd":
						r = new Weekly().Determine();
						break;

					case "a":
						r = new Weekly().Actions();
						break;
				}
				context.Response.Write("<html><head><link href=\"CSS/Chandam.css\" type=\"text/css\" rel=\"Stylesheet\" /></head><body><h1>Reports</h1>" + r + "</body></html>");
			}
			catch
			{
				context.Response.Write("");
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
