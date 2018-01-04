//---------------------------------------------------------------------------------------------
// <copyright file="ChandamReports.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Reports;
using Chandam.Rules;
using System.Collections.Generic;

namespace Chandam.Reports
{
	public class BarGraph
	{
		public string Title;
		public List<BarGraphValue> Values;
		public static string BuildGraph(BarGraph L)
		{
			string s = "<h2>" + L.Title + "</h2>";
			foreach (BarGraphValue B in L.Values)
			{
				s = s + string.Format(@"<li style='background-color:#222;border:solid 1px black; color:white;'>
										<div style='width:{0}%; background-color:{1}; padding-left:5px;'>
										<nobr>
											{2}
										</nobr>
										</div>
									</li><br/>", B.Value, B.Color, B.Title);
			}
			s = "<ul>" + s + "</ul>";
			return s;
		}

		public void Add(BarGraphValue B)
		{
			if (Values == null)
			{
				Values = new List<BarGraphValue>();
			}

			Values.Add(B);
		}
	}
	public class BarGraphValue
	{
		public string Title;
		public float Value;
		public string Color;
	}
}
namespace Library.Reports
{
	public class ChandamReports
	{
		int tot = 0;// Script Sharp fix as ref not allowed..
		public string PendingWork()
		{
			string s = "";
			s = s + GetExamplesYatiReport();
			s = s + GetExamplesReport2();



			s = s + GetExamplesReport();
			s = s + GetYatiReport();

			s = s + ListMissingData();
			return s;
		}

		private string ListMissingData()
		{
			string s1 = "";
			string s2 = "";
			string s3 = "";
			foreach (Rule R in RuleHelper.GetAllRules(true))
			{
				bool f2 = R.Yati.Length > 0 || (R.PadyamType == PadyamType.Vruttam && R.CharLength <= 10);
				bool f1 = R.Examples.Length == 0;
				f2 = !f2;

				string h = "<li>" + R.Name + (R.ChandamName == "" ? "" : "(" + R.ChandamName + ")") + "</li>";
				if (f1)
				{
					s1 = s1 + h;
				}
				if (f2)
				{
					s2 = s2 + h;
				}
				if (f1 && f2)
				{
					s3 = s3 + h;
				}
			}

			return "<h2>యతి+ఉదాహరణలు లేనివి</h2><ol>" + s3 + "</ol>" +
					"<h2>ఉదాహరణలు లేనివి</h2><ol>" + s1 + "</ol>" +
					"<h2>యతి లేనివి</h2><ol>" + s2 + "</ol>";
		}

		private string GetExamplesYatiReport()
		{
			tot = 0;
			int[] YatiData = GetExamplesYatiData();

			BarGraph L = new BarGraph();
			L.Title = "యతి+ఉదాహరణలు";
			for (int i = 0; i < YatiData.Length; i++)
			{
				BarGraphValue B = new BarGraphValue();
				B.Value = (YatiData[i] * 100) / tot;
				B.Title = string.Format("<b>{0}</b> పద్యరకాలకు  యతులు+ఉదాహరణలు <b>{1}</b>", YatiData[i], i == 0 ? "కలవు" : "లేవు");
				B.Color = (i == 0 ? "Green" : "Red");
				L.Add(B);
			}
			return BarGraph.BuildGraph(L);
		}
		private string GetExamplesReport()
		{
			tot = 0;
			int[] Examples = GetExamplesData();
			BarGraph L = new BarGraph();
			L.Title = "ఉదాహరణలు";
			for (int i = 0; i < Examples.Length; i++)
			{
				BarGraphValue B = new BarGraphValue();
				B.Value = (Examples[i] * 100) / tot;

				switch (i)
				{
					case 0:
						B.Title = string.Format("<b>{0}</b> పద్యరకాలకు ఉదాహరణలు లేవు.", Examples[i]);
						break;
					default:
						if (i > 5)
						{
							B.Title = string.Format("<b>{0}</b> పద్యరకాలకు <b>5</b> కంటే ఎక్కువ ఉదాహరణలు కలవు.", Examples[i]);
						}
						else
						{
							B.Title = string.Format("<b>{0}</b> పద్యరకాలకు <b>{1}</b> ఉదాహరణలు కలవు.", Examples[i], i);
						}
						break;

				}
				B.Color = ColorCode(i);
				L.Add(B);
			}
			return BarGraph.BuildGraph(L);
		}
		private string GetExamplesReport2()
		{
			tot = 0;
			int[] Examples = GetExamplesData2();
			BarGraph L = new BarGraph();
			L.Title = "ఉదాహరణలు";
			for (int i = 0; i < Examples.Length; i++)
			{
				BarGraphValue B = new BarGraphValue();
				B.Value = (Examples[i] * 100) / tot;
				switch (i)
				{
					case 0:
						B.Title = string.Format("<b>{0}</b> పద్యరకాలకు కనీసం ఒక్క ఉదాహరణ కూడా లేదు.", Examples[i], i);
						break;
					case 5:
						B.Title = string.Format("<b>{0}</b> పద్యరకాలకు <b>{1}</b> లేదా అంతకంటే ఎక్కువ ఉదాహరణలు కలవు.", Examples[i], i);
						break;
					default:
						B.Title = string.Format("<b>{0}</b> పద్యరకాలకు కనీసం <b>{1}</b> ఉదాహరణలు కలవు.", Examples[i], i);
						break;
				}

				B.Color = ColorCode(i);
				L.Add(B);
			}
			return BarGraph.BuildGraph(L);
		}
		private int[] GetExamplesData()
		{
			int[] Examples = new int[] { 0 , 0 , 0 ,
										0 , 0 , 0 ,
										0};

			//Debug.AppendLine ( "Missing Examples Data" );
			foreach (Rule R in RuleHelper.GetAllRules(true))
			{
				tot++;
				if (R.Examples.Length > 5)
				{
					Examples[6]++;
					continue;
				}
				if (R.Examples.Length == 0)
				{
					//Debug.AppendLine ( R.Name );
				}
				Examples[R.Examples.Length]++;
			}
			return Examples;
		}
		private int[] GetExamplesData2()
		{
			int[] Examples = GetExamplesData();
			int[] N = new int[] { Examples[0], 0, 0, 0, 0, 0 };

			for (int i = 1; i < Examples.Length - 1; i++)
			{

				for (int j = i; j < Examples.Length; j++)
				{
					if (i >= 5)
					{
						N[5] = N[5] + Examples[j];
						continue;
					}
					N[i] = N[i] + Examples[j];
				}
			}
			return N;
		}
		private string GetYatiReport()
		{
			tot = 0;
			int[] YatiData = GetYatiData();

			BarGraph L = new BarGraph();
			L.Title = "యతి";
			for (int i = 0; i < YatiData.Length; i++)
			{
				BarGraphValue B = new BarGraphValue();
				B.Value = (YatiData[i] * 100) / tot;
				B.Title = string.Format("<b>{0}</b> పద్యరకాలకు  యతులు <b>{1}</b>", YatiData[i], i != 0 ? "కలవు" : "లేవు");
				B.Color = (i == 0 ? "Red" : "Green");
				L.Add(B);
			}
			return BarGraph.BuildGraph(L);
		}
		private int[] GetYatiData()
		{
			//Debug.AppendLine ( "Missing Yati Data." );
			int[] Examples = new int[] { 0, 0 };
			foreach (Rule R in RuleHelper.GetAllRules(true))
			{
				tot++;
				bool f = R.Yati.Length > 0 || (R.PadyamType == PadyamType.Vruttam && R.CharLength <= 10);
				if (f)
				{
					Examples[1]++;
					continue;
				}
				//Debug.AppendLine ( R.Name );
				Examples[0]++;
			}
			return Examples;
		}
		private int[] GetExamplesYatiData()
		{
			//Debug.AppendLine ( "Missing Yati and Examples Data." );
			int[] Examples = new int[] { 0, 0 };
			foreach (Rule R in RuleHelper.GetAllRules(true))
			{
				tot++;
				bool f1 = R.Yati.Length > 0 || (R.PadyamType == PadyamType.Vruttam && R.CharLength <= 10);
				bool f2 = R.Examples.Length == 0;
				f1 = !f1;
				if (f1 && f2)
				{
					Examples[1]++;
					//Debug.AppendLine ( R.Name );
					continue;
				}
				Examples[0]++;
			}
			return Examples;
		}
		private string ColorCode(int i)
		{
			switch (i)
			{
				case 0:
					return "Red";
				case 1:
					return "#AC193D";
				case 2:
					return "#D24726";
				case 3:
					return "#8C0095";
				default:
					return "#008299";
				case 5:
				case 6:
				case 7:
					return "Green";

			}
		}
	}
}
