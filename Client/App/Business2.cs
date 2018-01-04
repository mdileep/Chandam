//---------------------------------------------------------------------------------------------
// <copyright file="Business2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Extensions;
using Chandam.Rules;
using Chandam.Samples;
using System;
using System.Collections.Generic;

namespace Chandam.Core
{
	public static partial class Business
	{

		static Business()
		{

		}
		public static string BuildResult(Rule R, Padyam P, MatchResult MR, List<MatchResult> Candidates)
		{
			bool handleProse = (Candidates != null);
			StringBuilder sb = new StringBuilder();

			if (MR.Percentage != 100)
			{
				if (MR.Percentage < 50 && handleProse)
				{

				}
				else
				{
					sb.AppendLine("<div class='err w100 center'>" + R.Name);
					sb.AppendLine(": <b class='red'>" + Number.ParseFloat(MR.Percentage.ToString()).ToFixed() + "%</b>(" + MR.Score + "/" + MR.Total + ")");
					sb.AppendLine("</div>");
				}
			}
			else
			{
				sb.AppendLine("<div class='err Green  w100 center'>" + R.Name);
				sb.AppendLine("</div>");
			}

			if (MR.Percentage != 100)
			{
				if (MR.Percentage < 50 && handleProse)
				{
					sb.AppendLine("<div class='vachanam'>" + "<div class='err'>కవిత లేదా పాట లేదా వచనము లేదా గద్యము లేదా మరేదైనా ఛందోప్రక్రియ</div>" + "<div class='Err22'>");
					sb.AppendLine(P.Build3());
					sb.AppendLine("</div></div>");
				}
				else
				{
					if (!R.InfiniteLength)
					{
						sb.AppendLine("<div class='build'><div class='err'>గణ విభజన</div>");
						sb.AppendLine(P.Build(MR));
						sb.AppendLine("</div>");

						sb.AppendLine("<div class='buildErrors'><div class='err'>దోషాలు</div>");
						sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
						sb.AppendLine("</div>");
					}
					else
					{
						sb.AppendLine("<div class='build2'><div class='err'>దోషాలు</div>");
						sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
						sb.AppendLine("</div>");

						sb.AppendLine("<div  class='buildErrors'><div class='err'>గణ విభజన</div>");
						sb.AppendLine(P.Build(MR));
						sb.AppendLine("</div>");
					}
				}

			}
			else
			{
				try
				{

					sb.AppendLine("<div class='build'><div class='err'>" + R.ShortName + "</div><div class='Err22'>");
					sb.AppendLine(P.Build2(MR));
					sb.AppendLine("</div></div>");
				}
				catch
				{

				}

				sb.AppendLine("<div class='build3'><div class='err right'>గణ విభజన</div>");
				sb.AppendLine(P.Build(MR));
				sb.AppendLine("</div>");
			}

			if (Candidates != null && MR.Percentage != 100 && Candidates.Count >= 1)
			{
				sb.AppendLine("<div class='candidates'>");
				sb.AppendLine("<div class='err'>సమీప ఫలితాలు</div>");
				sb.AppendLine("<ol style='cursor:pointer;' class='num'>");
				for (int i = 0; i < Candidates.Count; i++)
				{
					if (i > 5 || (i == 0 && MR.Percentage >= 50 && !handleProse))
					{
						continue;
					}
					MatchResult _MR = Candidates[i];
					sb.AppendLine("<li  id='candiate_" + i + "' data='" + _MR.Rule.Identifier + "'>" + _MR.Rule.Name);
					sb.AppendLine(": <b style='color:red'>" + Number.ParseFloat(_MR.Percentage.ToString()).ToFixed() + "%</b>");
					sb.AppendLine("</li>");
				}
				sb.AppendLine("</ol>");
				sb.Append(Strings.Help);
				sb.AppendLine("</div>");
			}

			return (string)Script.Literal("sb.toString2()", null);
		}
		public static string BuildAllScores(List<MatchResult> L)
		{

			StringBuilder sb = new StringBuilder();
			sb.Append("<div class='err'>మూల్యాంకనం</div>" + "<table  class='sort-table' id='scores' cellspacing='0'  border='1'  class='errTab'><thead><tr><td>#</td><td>పద్య రీతి</td><td>పేరు</td><td class='number'>శాతం</td><td class='number'>మార్కులు</td><td class='number'>మొత్తం</td></tr></thead><tbody>");
			int cnt = 1;
			foreach (MatchResult MR in L)
			{
				sb.Append(MR.Percentage == 100 ? "<tr  style='font-weight:bold;color:green;'>" : "<tr>");

				sb.Append("<td>" + (cnt++) + "</td><td>" + Helper.GetPadyamTypeString(MR.Rule.PadyamType, MR.Rule.PadyamSubType) + (MR.Rule.ChandamName == "" ? "" : " (" + MR.Rule.ChandamName + ")") + "</td><td>" + MR.Rule.Name + "</td><td class='number'>" + Number.ParseFloat(MR.Percentage.ToString()).ToFixed() + "</td><td class='number'>" + MR.Score + "</td><td class='number'>" + MR.Total + "</td>");

				sb.Append("</tr>");

			}
			sb.Append("</tbody></table>");
			return (string)Script.Literal("sb.toString2()", null);
		}

		public static string GetRandomPoem()
		{
			int current = (int)(Math.Floor(Math.Random() * SamplePoems.Poems.Length));
			string s = SamplePoems.GetItem(current);
			return s;
		}

		public static void InitRandomPoems()
		{
			foreach (Rule R in RuleHelper.GetAllRules(true))
			{
				SamplePoems.Append(R.Examples);
			}

		}
		public static int RandomPoemsCount
		{
			get
			{
				return SamplePoems.Poems.Length;
			}
		}
		public static string CheckPrasa(string s1, string s2, bool allowSantiPrasa)
		{
			return new YatiPrasaTester().CheckPrasa(s1, s2, allowSantiPrasa);
		}
		public static string CheckYati(string s1, string s2, bool Sandhi)
		{
			return new YatiPrasaTester().CheckYati(s1, s2, Sandhi);
		}
	}
}
