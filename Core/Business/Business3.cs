//---------------------------------------------------------------------------------------------
// <copyright file="Business3.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;

namespace Chandam.Core
{
	public static partial class Business
	{
		public static Probable Determine(string s, MatchOptions Options)
		{
			if (s == null || s.Trim().Length == 0)
			{
				return null;
			}
			Probable Pr = Padyam.MostProbable(s, Options);
			return Pr;
		}

		public static string BuildResult2(Probable Pr)
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
			string s2 = BuildResult(R, P, MR, Pr.Candiates);
			{
				P = null;
				MR = null;
				R = null;
			}

			return s2;
		}

		public static string TryMatch(string s, string identifier, MatchOptions Options)
		{
			Rule R = Manager.FetchRule(identifier);
			return TryMatch2(s, R, Options);
		}
		public static string TryMatch2(string s, Rule R, MatchOptions Options)
		{
			if (s == null || s.Trim().Length == 0)
			{
				return "";
			}

			Padyam P = new Padyam();
			P.MatchYati = Options.MatchYati;
			P.MatchPrasa = Options.MatchPrasa;
			P.AllowSantiPrasa = Options.AllowSantiPrasa;
			P.SandiMatch = Options.ExperimenatalSandhi;

			MatchResult MR = P.Match(s, R);
			if (MR.Total == 0)
			{
				return "";
			}
			return BuildResult(R, P, MR, null);
		}
	}
}
