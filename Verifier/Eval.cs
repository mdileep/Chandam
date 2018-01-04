//---------------------------------------------------------------------------------------------
// <copyright file="Eval.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using System.Diagnostics;
using System.Text;

namespace Verifier
{
	public class Eval
	{

		public static string Build(string s)
		{
			Probable Pr = Padyam.MostProbable(s, MatchOptions.QucikMatchSettings);
			if (Pr.MatchResult == null)
			{
				Debugger.Break();
			}
			MatchResult MR = Pr.MatchResult;
			Rule R = Pr.Rule;
			Padyam P = Pr.Padyam;

			return Build(MR, R, P);

		}
		public static string Build(string padyam, string ruleId, out string name, out int percentage)
		{
			percentage = 0;
			name = "";
			Rule R = Manager.FetchRule(ruleId.Trim());
			if (R == null)
			{

				return "";
			}

			Padyam P = new Padyam();
			P.MatchYati = MatchOptions.QucikMatchSettings.MatchYati;
			P.MatchPrasa = MatchOptions.QucikMatchSettings.MatchPrasa;
			P.AllowSantiPrasa = MatchOptions.QucikMatchSettings.AllowSantiPrasa;
			P.SandiMatch = MatchOptions.QucikMatchSettings.ExperimenatalSandhi;


			MatchResult MR = P.Match(padyam, R);

			percentage = MR.Percentage;
			name = R.ShortName;
			if (MR.Total == 0)
			{
				return "";
			}

			return P.Build2(MR);


		}

		public static string Build(MatchResult MR, Rule R, Padyam P)
		{
			StringBuilder sb = new StringBuilder();


			{
				sb.Append("<h2 style='color:blue; text-align:left; width:100%;'>" + R.Name);
				if (MR.Percentage != 100)
				{
					sb.Append(": <b style='color:red'>" + MR.Percentage.ToString("0") + "<span class='symbol'>%</span></b>(" + MR.Score + "/" + MR.Total + ")");
				}
				sb.AppendLine("</h2>");
				sb.AppendLine("<br/>");
				sb.AppendLine("<p style='width:100%; text-align:left;border:1px solid Blue; border-left:4px solid #EEEEEE; '>");
				sb.AppendLine(P.Build2(MR));
				sb.AppendLine("</p>");
				sb.AppendLine("<br/>");

				sb.AppendLine("<br/>");
				sb.AppendLine("<h2 style='color:blue; text-align:center; width:100%;'>గణ విభజన</h2>");
				sb.AppendLine("<br/>");
				sb.AppendLine(P.Build(MR));


				if (MR.Percentage != 100)
				{
					sb.AppendLine("<br/>");
					sb.AppendLine("<h2 style='color:blue; text-align:center; width:100%;'>దోషాలు</h2>");
					sb.AppendLine("<br/>");
					sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
				}
			}


			return sb.ToString();
		}
	}
}
