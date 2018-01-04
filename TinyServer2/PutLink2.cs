//---------------------------------------------------------------------------------------------
// <copyright file="PutLink2.cs" company="Chandam-ఛందం">
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
	public class Stats : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";
			int y = 10000;
			try
			{

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

	public class Metrics : IHttpHandler
	{

		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/xml";

			string metric = context.Request.Form["m"];
			string ticks = context.Request.Form["t"];
			string identifier = context.Request.Form["i"];
			string score = context.Request.Form["s"];

			string clientIp = "";
			int iTicks = 0;
			int iScore = 0;

			try
			{
				identifier = identifier ?? "";
				iTicks = Convert.ToInt32(ticks);
				iScore = Convert.ToInt32(score);
				clientIp = (context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? context.Request.ServerVariables["REMOTE_ADDR"]).Split(',')[0].Trim();
				clientIp = (clientIp.Length < 4) ? "" : clientIp;

			}
			catch
			{

			}


			context.Response.Write("<ok />");
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
namespace Server
{
	public class GetLink : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{
			context.Response.ContentType = "text/html";

			string p = context.Request.Form["p"];
			try
			{

				context.Response.Write(p);
			}
			catch
			{
				context.Response.Write("");
				return;
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
namespace Server
{
	public class Subscribe : IHttpHandler
	{


		public void ProcessRequest(HttpContext context)
		{
			string email = context.Request.Form["e"];
			string go = context.Request.Form["g"];

			context.Response.ContentType = "text/html";

			try
			{
				context.Response.Write("");
			}
			catch
			{
				context.Response.Write("");
				return;
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
namespace Server
{
	public class PutLink : IHttpHandler
	{
		public void ProcessRequest(HttpContext context)
		{

			context.Response.ContentType = "text/html";

			string t = context.Request.Form["d"];

			if (string.IsNullOrEmpty(t))
			{
				context.Response.Write("");
				return;
			}
			try
			{
				string _Key = Guid.NewGuid().ToString();
				context.Response.Write(_Key);
			}
			catch
			{
				context.Response.Write("");
				return;
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
