//---------------------------------------------------------------------------------------------
// <copyright file="Business.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using System.Collections.Generic;

namespace Chandam.Core
{
	public static partial class Business
	{

		public static string BuildBook()
		{
			return CheatSheet.BuildBook();
		}
		public static string BuildCheatSheet()
		{
			return CheatSheet.BuildCheatSheet(false, false);
		}
		public static string Rules(string identifier)
		{
			Rule R = Manager.FetchRule(identifier);
			return Rules2(R, false);
		}

		public static string Rules3(Rule R)
		{
			return Rules2(R, true);
		}

		public static string Rules2(Rule R, bool useExample)
		{
			string s = R.RuleText == null ? CheatSheet.BuildRules2(R, useExample) : R.RuleText;
			return "<div class='err'>" + R.Name + "</div>" + s;
		}

		public static string Samples(string identifier)
		{
			Rule R = Manager.FetchRule(identifier);
			R.Language = Context.Language;
			string s = "";
			foreach (Example item in R.Examples2)
			{
				if (item != null)
				{
					string poem = item.Text;
					string author = item.Author;
					s = s + "<li  title='Click on this poem to use' class='sample'>" + TryMatch3(poem, R);
					if (author != "")
					{
						s = s + " <i>~" + author + "</i>";
					}
					s = s + "</li>";
				}
			}
			if (s != "")
			{
				s = "<ol class='poems'>" + s + "</ol>";
			}
			else
			{
				s = Strings.NoExamples;
			}
			return "<div class='err'>" + R.Name + "</div>" + s;
		}
		public static string Scores(string s, MatchOptions Options)
		{
			GanaVibhajana G = new GanaVibhajana(s, Options.Language);
			bool includeRare = Options.IncludeRare;
			int min = G.Min;
			int max = G.Max;
			includeRare = true;

			List<Rule> Rules = Options.QuickMatch ? RuleHelper.GetAllRules2(min, max, G.PreLines) : RuleHelper.GetAllRules(includeRare);

			List<MatchResult> L = new List<MatchResult>();
			foreach (Rule R in Rules)
			{
				Padyam P = new Padyam();
				P.MatchYati = Options.MatchYati;
				P.MatchPrasa = Options.MatchPrasa;
				P.AllowSantiPrasa = Options.AllowSantiPrasa;
				P.SandiMatch = Options.ExperimenatalSandhi;

				MatchResult MR = P.Match(s, R);
				L.Add(MR);
				P = null;
			}

			string s2 = BuildAllScores(L);

			{
				L = null;
			}
			return s2;
		}
		private static string TryMatch3(string s, Rule R)
		{
			if (s == null || s.Trim().Length == 0)
			{
				return "";
			}

			Padyam P = new Padyam();
			MatchOptions Options = MatchOptions.TradtionalMatchSettings;
			P.MatchYati = Options.MatchYati;
			P.MatchPrasa = Options.MatchPrasa;
			P.AllowSantiPrasa = Options.AllowSantiPrasa;
			P.SandiMatch = Options.ExperimenatalSandhi;

			MatchResult MR = P.Match(s, R);
			if (MR.Total == 0)
			{
				return "";
			}

			//string sb="";
			//sb =sb+ "<div style='float:left;width:40%;margin-left:10px;'><div class='err'>" + R.ShortName + "</div><div class='Err22'>";
			//sb =sb+P.Build2 ( MR ) ;
			//sb =sb+"</div></div>" ;
			//return sb;
			return P.Build2(MR);
		}
	}
}
