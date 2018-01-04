//---------------------------------------------------------------------------------------------
// <copyright file="Satakam2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Library.Chandam.Samples
{
	public class OutputOptions
	{
		public bool UseFullName { get; set; }
		public bool ErrorsOnly { get; set; }
		public List<Rule> Rules;
		public string EmbedValue { get; set; }
	}

	public partial class Satakam
	{
		private static string Build(MatchResult MR, Rule R, Padyam P)
		{
			return Build(MR, R, P, new OutputOptions { ErrorsOnly = false, UseFullName = false });
		}

		public static string Build(Poem Poem, MatchOptions Options)
		{
			return Build(Poem, Options, new OutputOptions { UseFullName = false, ErrorsOnly = false });
		}

		public static string Build(Poem Poem, MatchOptions Options, OutputOptions OO)
		{
			if (Poem == null) { return ""; }
			if (Poem.Text.Trim().Length == 0) { return ""; }

			List<Rule> Rules = new List<Rule>();

			if (OO.Rules == null || OO.Rules.Count == 0)
			{
				if (Poem.Identifier == null)
				{
					Rules.AddRange(Manager.Rules());
				}
				else
				{
					Rule R2 = Manager.FetchRule(Poem.Identifier);
					if (R2 == null)
					{
						Rules.AddRange(Manager.Rules());
					}
					else
					{
						Rules.Add(R2);
					}
				}
			}
			else
			{
				Rules.AddRange(OO.Rules);
			}

			Probable Pr = Padyam.MostProbable2(Poem.Text, Options, Rules);
			if (Pr.MatchResult == null)
			{
				Debugger.Break();
			}
			MatchResult MR = Pr.MatchResult;
			Rule R = Pr.Rule;
			Padyam P = Pr.Padyam;
			return Build(MR, R, P, OO);

		}

		public static string EvaluateAllRules(string htmlFile)
		{
			string title = "ఛందం";
			string auth = "ఎందరో";
			string s = EvaluateAllRulesInternal(title, auth);
			File.WriteAllText(htmlFile, s);
			return s;
		}
		private static string EvaluateAllRulesInternal(string title, string auth)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<ol  class='ol'>");

			int cnt = 1;
			int cnt2 = 1;
			foreach (Rule R in RuleHelper.GetAllRules(true))
			{
				Console.WriteLine((cnt++) + ". " + R.Identifier);

				sb.AppendLine("<ol  class='ol'>");
				foreach (string s in R.Examples)
				{
					cnt2++;

					sb.AppendLine("<li>");
					Padyam P = new Padyam();
					P.MatchYati = false;
					P.MatchPrasa = true;

					MatchResult MR = P.Match(s, R);
					sb.Append(Build(MR, R, P));
					sb.AppendLine("<li>");
				}

				sb.AppendLine("</ol>");
			}
			Console.WriteLine("Total Poems evaluated: " + cnt2);
			return BuildFile(title, title, "", sb.ToString(), null);
		}


	}
}
