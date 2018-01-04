//---------------------------------------------------------------------------------------------
// <copyright file="Font.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Web;

namespace Server
{
	public class Font : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{

			if (context.Request.QueryString.Count == 0)
				return;

			string t = context.Request.QueryString["u"];
			string h = MIME(t.Substring(t.LastIndexOf(".")));
			if (h == "")
			{
				return;
			}
			context.Response.AddHeader("Content-Type", h);
			context.Response.WriteFile(context.Server.MapPath("~/css/f/" + t));
			context.Response.Flush();
			context.Response.End();

		}

		private string MIME(string ext)
		{
			switch (ext)
			{
				case ".ttf":
					return "application/octet-stream";
				case ".woff":
					return "application/octet-stream";
				case ".eot":
					return "application/octet-stream";
				case ".svg":
					return "image/svg+xml";
				default:
					return "";
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
