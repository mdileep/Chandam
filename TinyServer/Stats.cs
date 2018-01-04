//---------------------------------------------------------------------------------------------
// <copyright file="Stats.cs" company="Chandam-ఛందం">
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
	public class Stats : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";
			int y = 10000;
			try
			{
				MongoLib.MongoUtil MU = new MongoLib.MongoUtil();
				y = MU.Sum();
			}
			catch
			{
			}
			context.Response.Write(y + "+");
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
