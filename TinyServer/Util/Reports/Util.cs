//---------------------------------------------------------------------------------------------
// <copyright file="Util.cs" company="Chandam-ఛందం">
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
using System.Collections.Generic;

namespace Server.ReportsUtil
{
	public class Weekly
	{
		public string Actions()
		{
			MongoLib.MongoUtil MU = new MongoLib.MongoUtil();
			List<MetricGroup> L = MU.WeeklyActions();
			return BuildHarizontalPie(L);
		}
		private string BuildHarizontalPie(List<MetricGroup> L)
		{
			string s = "";
			int tot = (int)(Tot(L));
			int cnt = 0;
			foreach (MetricGroup M in L)
			{
				double v = (M.Y * 100) / tot;
				if (v > 2)
				{
					s = s + string.Format(@"<div class='hPole' style='background-color:{0};width:{1}%;color:{2}'  title='{3}-{1}%'>{3}</div>",
							cnt % 2 == 0 ? "Green" : "white",
							v,
							cnt % 2 == 0 ? "white" : "black",
							M.X);
				}
				cnt++;
			}
			s = "<div class='hChart'>" + s + "</div>";
			return s;
		}
		public string Determine()
		{
			MongoLib.MongoUtil MU = new MongoLib.MongoUtil();
			List<MetricGroup> L = MU.WeeklyDetermine();
			return BuildGraph(L);
		}
		private string BuildGraph(List<MetricGroup> L)
		{
			string s = "";
			int max = (int)(Max(L) * 1.1);
			foreach (MetricGroup M in L)
			{
				double v = (M.Y * 100) / max;
				v = (v < 4 ? 4 : v);
				s = s + string.Format(@"<div class='pole'><div style='height:{4}%; color:black;'  title='{2}'><nobr>{2}</nobr></div><div style='height:{0}%; background-color:{1};'  title='{3}'><nobr>{3}</nobr></div></div>",
										v,
										"Green",
										M.X,
										M.Y,
										100 - v);
			}
			s = "<div class='vChart'>" + s + "</div>";
			return s;
		}
		private int Max(List<MetricGroup> L)
		{
			int max = 0;
			foreach (MetricGroup M in L)
			{
				if (M.Y > max)
				{
					max = M.Y;
				}
			}
			return max;
		}
		private int Tot(List<MetricGroup> L)
		{
			int tot = 0;
			foreach (MetricGroup M in L)
			{

				tot = tot + M.Y;

			}
			return tot;
		}
	}
}
