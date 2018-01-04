//---------------------------------------------------------------------------------------------
// <copyright file="Business4.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:11EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using MiriyamAPI;
using MiriyamApp.External;
using System;
using System.Collections.Generic;

namespace Chandam.Core
{
	public static partial class Business
	{
		public static string BuildResult(Rule R, Padyam P, MatchResult MR, List<MatchResult> Candidates,bool showGV)
		{
			bool handleProse = (Candidates != null);
			
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("<div class='padyam'>");
				sb.AppendLine("<div class='chandassu'  title='" + R.Name + "'>" + R.ShortName +"</div>");
				sb.AppendLine("<div class='poem'>");
				sb.AppendLine(P.Build2(MR));
				sb.AppendLine("</div>");
				if (showGV)
				{
					sb.Append("<div class='open'>[O]</div>");
				}
			sb.AppendLine("</div>");

			if (showGV)
			{
				sb.Append("<div class='ganaVibhajana'>");
				sb.AppendLine(BuildResult4(R, P, MR, Candidates));
				sb.AppendLine("</div>");
			}


			return (string)Script.Literal("sb.toString2()", null);
		}
		
		public static string BuildResult4(Rule R, Padyam P, MatchResult MR, List<MatchResult> Candidates)
		{
			StringBuilder sb = new StringBuilder();

			if (MR.Percentage != 100)
			{
				sb.AppendLine("<div class='err' style='text-align:center;width:100%;'>" + R.ShortName);
				sb.AppendLine(": <b class='percentage'>" + Number.ParseFloat(MR.Percentage.ToString()).ToFixed()  +"%</b>(" + MR.Score + "/" + MR.Total + ")");
				sb.AppendLine("</div>");
			}
			else
			{
				sb.AppendLine("<div class='err Green' style='text-align:center;width:100%;'>");
				sb.AppendLine(R.ShortName);
				sb.AppendLine("</div>");
			}

				if (!R.InfiniteLength)
				{
					sb.AppendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>గణ విభజన</div>");
					sb.AppendLine(P.Build(MR));
					sb.AppendLine("</div>");

					if (MR.Percentage != 100)
					{
						sb.AppendLine("<div style='float:left;width:50%;margin-right:10px;'><div class='err' style='text-align:right;'>దోషాలు</div>");
						sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
						sb.AppendLine("</div>");
					}
				}
				else
				{
					if (MR.Percentage != 100)
					{
						sb.AppendLine("<div style='float:left;width:50%;margin-right:10px;'><div class='err' style='text-align:right;'>దోషాలు</div>");
						sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
						sb.AppendLine("</div>");
					}

					sb.AppendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>గణ విభజన</div>");
					sb.AppendLine(P.Build(MR));
					sb.AppendLine("</div>");
				}
			return (string)Script.Literal("sb.toString2()", null);
		}
	}
}


namespace Chandam.Core
{
	public static partial class Business
	{
		public static Probable Determine(string s, MatchOptions2 Options2)
		{
			if (s == null || s.Trim().Length == 0)
			{
				return null;
			}
			MatchOptions Options = Worker.GetOptions(Options2);
			Probable Pr = Padyam.MostProbable(s, Options);
			return Pr;
		}
		public static string BuildResult2(Probable Pr, bool showGV)
		{
			if (Pr == null)
				return "";

			Padyam P = Pr.Padyam;
			MatchResult MR = Pr.MatchResult;
			Rule R = Pr.Rule;
			if (MR.Total == 0)
			{
				return "";
			}
			string s2 = BuildResult(R, P, MR, Pr.Candiates, showGV);
			{
				P = null;
				MR = null;
				R = null;
			}

			return s2;
		}
		public static string TryMatch(string s, string identifier, MatchOptions2 Options)
		{
			Rule R = Manager.FetchRule(identifier);
			return TryMatch2(s, R, Options);
		}
		public static string TryMatch2(string s, Rule R, MatchOptions2 Options)
		{
			if (s == null || s.Trim().Length == 0)
			{
				return "";
			}

			MatchOptions Options2 = Worker.GetOptions(Options);

			Padyam P = new Padyam();
			P.MatchYati = Options2.MatchYati;
			P.MatchPrasa = Options2.MatchPrasa;
			P.AllowSantiPrasa = Options2.AllowSantiPrasa;
			P.SandiMatch = Options2.ExperimenatalSandhi;
			

			MatchResult MR = P.Match(s, R);
			if (MR.Total == 0)
			{
				return "";
			}
			return BuildResult(R, P, MR, null, Options == null ? true : Options.ShowGV);
		}
	}
}

