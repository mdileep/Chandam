//---------------------------------------------------------------------------------------------
// <copyright file="Svg.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Web;

namespace Server
{
	public class Svg : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{

			if (context.Request.QueryString.Count == 0)
			{
				return;
			}
			context.Response.AddHeader("Content-Type", "image/svg+xml");
			string t = context.Request.QueryString["u"];
			if (!t.EndsWith(".svg"))
			{
				return;
			}
			context.Response.WriteFile(context.Server.MapPath("~/Css/" + t));
			context.Response.Flush();
			context.Response.End();
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
