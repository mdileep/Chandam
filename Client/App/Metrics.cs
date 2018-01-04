//---------------------------------------------------------------------------------------------
// <copyright file="Metrics.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using MiriyamApp.External;
using MiriyamApp.Social.Facebook;
using System;
using System.Html;

namespace MiriyamApp
{
	public static class Metrics
	{
		public extern static void Export2(Metric metric);
		public extern static void Export2(Metric metric, int time);
		public extern static void Export2(Metric metric, int time, string identifier);
		public static void Export2(Metric metric, int? time, string identifier, string percentage)
		{
			string content = "m=" + ToString2(metric) + (time == null ? "" : "&t=" + time) + (identifier == null ? "" : "&i=" + identifier) + (percentage == null ? "" : "&s=" + percentage);
			Ajax.MakeCall("/Metrics.ashx", new AjaxCallback(delegate (string err, string data, XHR xhr)
	   {
		   ShowStats();

	   }), HTTPMethod.POST, content);


		}
		public static void ShowStats()
		{
			Ajax.MakeCall("/Stats.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
   {
	   Window.Document.GetElementById("totCalcs").InnerHTML = data;
   }), HTTPMethod.GET);
		}
		private static string ToString2(Metric metric)
		{
			switch (metric)
			{
				case Metric.Random:
					return "Random";
				case Metric.Scores:
					return "Scores";
				case Metric.Determine:
					return "Determine";
				case Metric.TryMatch:
					return "TryMatch";
				case Metric.TryMatch2:
					return "TryMatch2";
				case Metric.Rules:
					return "Rules";
				case Metric.Rules2:
					return "Rules2";
				case Metric.ShowDesigner:
					return "ShowDesigner";
				case Metric.Samples:
					return "Samples";
				case Metric.Book:
					return "Book";
				case Metric.CheatSheet:
					return "CheatSheet";
				case Metric.Load:
					return "Load";
				default:
					return "Unknown";
			}
		}


	}
	public enum Metric
	{
		Random = 0,
		Scores = 1,
		Determine = 2,
		TryMatch = 3,
		TryMatch2 = 4,
		Rules = 5,
		Rules2 = 6,
		ShowDesigner = 7,
		Samples = 8,
		CheatSheet = 9,
		Book = 10,
		Load = 11
	}

}
