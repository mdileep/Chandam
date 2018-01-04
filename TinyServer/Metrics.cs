//---------------------------------------------------------------------------------------------
// <copyright file="Metrics.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Server.Util.DB;
using System;
using System.Web;

namespace Server
{
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


			Metric Metric = new Metric();
			Metric.Name = metric;
			Metric.Identifier = identifier;
			Metric.Time = iTicks;
			Metric.Date = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
			Metric.Hours = Convert.ToInt32(DateTime.Now.ToString("HHmmss"));
			Metric.Host = context.Request.Url.Host;
			Metric.IP = clientIp;
			Metric.Score = iScore;

			Metric2 Metric2 = new Metric2
			{
				Name = Metric.Name,
				Identifier = Metric.Identifier,
				Count = 1,
				Total = Metric.Time
			};

			MongoLib.MongoUtil M = new MongoLib.MongoUtil();
			if (M.Exists(metric, identifier))
			{
				M.Update(Metric2);
			}
			else
			{
				M.Add(Metric2);
			}

			M.Add(Metric);

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
