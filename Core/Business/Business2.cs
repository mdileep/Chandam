//---------------------------------------------------------------------------------------------
// <copyright file="Business2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using System.Collections.Generic;
using System.Text;


namespace Chandam.Core
{
	public static partial class Business
	{
		public static string BuildResult(Rule R, Padyam P, MatchResult MR, List<MatchResult> Candidates)
		{
			StringBuilder sb = new StringBuilder();
			if (MR.Percentage != 100)
			{
				sb.AppendLine("<div class='err' style='text-align:center;width:100%;'>" + R.ShortName);
				sb.AppendLine(": <b style='color:red'>" + MR.Percentage.ToString() + "%</b>(" + MR.Score + "/" + MR.Total + ")");
				sb.AppendLine("</div>");
			}
			else
			{
				sb.AppendLine("<div class='err Green' style='text-align:center;width:100%;'>" + R.ShortName);
				sb.AppendLine("</div>");
			}
			if (MR.Percentage != 100)
			{
				if (!R.InfiniteLength)
				{
					sb.AppendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>గణ విభజన</div>");
					sb.AppendLine(P.Build(MR));
					sb.AppendLine("</div>");

					sb.AppendLine("<div style='float:left;width:50%;margin-right:10px;'><div class='err' style='text-align:right;'>దోషాలు</div>");
					sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
					sb.AppendLine("</div>");
				}
				else
				{
					sb.AppendLine("<div style='float:left;width:50%;margin-right:10px;'><div class='err' style='text-align:right;'>దోషాలు</div>");
					sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
					sb.AppendLine("</div>");

					sb.AppendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>గణ విభజన</div>");
					sb.AppendLine(P.Build(MR));
					sb.AppendLine("</div>");
				}

			}
			else
			{
				try
				{

					sb.AppendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>" + R.ShortName + "</div><div class='Err22'>");
					sb.AppendLine(P.Build2(MR));
					sb.AppendLine("</div></div>");
				}
				catch
				{

				}

				sb.AppendLine("<div style='float:left;width:58%;margin-right:10px; padding-left:5px;'><div class='err'  style='text-align:right;'>గణ విభజన</div>");
				sb.AppendLine(P.Build(MR));
				sb.AppendLine("</div>");
			}

			if (Candidates != null && MR.Percentage != 100 && Candidates.Count > 1)
			{
				sb.AppendLine("<div style='clear:left; margin-top:10px;'>");
				sb.AppendLine("<div class='err'>సమీప ఫలితాలు</div>");
				sb.AppendLine("<ol>");

				for (int i = 0; i < Candidates.Count; i++)
				{
					if (i > 5 || i == 0)
					{
						continue;
					}
					MatchResult _MR = Candidates[i];
					sb.AppendLine("<li  id='candiate_" + i + "' data='" + _MR.Rule.Identifier + "'>" + _MR.Rule.Name);
					sb.AppendLine(": <b style='color:red'>" + _MR.Percentage.ToString() + "%</b>");
					sb.AppendLine("</li>");

				}
				sb.AppendLine("</ol>");

				sb.AppendLine("</div>");
			}

			return sb.ToString();
		}
		public static string BuildAllScores(List<MatchResult> L)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("<table  class='sort-table' id='scores' cellspacing='0'  border='1'  class='errTab'><thead><tr><td>#</td><td>పద్య రీతి</td><td>పేరు</td><td class='number'>శాతం</td><td class='number'>మార్కులు</td><td class='number'>మొత్తం</td></tr></thead><tbody>");
			int cnt = 1;
			foreach (MatchResult MR in L)
			{
				sb.Append(MR.Percentage == 100 ? "<tr  style='font-weight:bold;color:green;'>" : "<tr>");

				sb.Append("<td>" + (cnt++) + "</td><td>" + Helper.GetPadyamTypeString(MR.Rule.PadyamType, MR.Rule.PadyamSubType) + "</td><td>" + MR.Rule.Name + "</td><td class='number'>" + MR.Percentage.ToString("0.00") + "</td><td class='number'>" + MR.Score + "</td><td class='number'>" + MR.Total + "</td>");

				sb.Append("</tr>");

			}
			sb.Append("</tbody></table>");
			return sb.ToString();
		}
	}
}
