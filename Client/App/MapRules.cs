//---------------------------------------------------------------------------------------------
// <copyright file="MapRules.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:10EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using MiriyamApp.External;
using System;
using System.Collections;

namespace MiriyamApp
{
	public class MapRules
	{
		public static void LoadExternalRules()
		{
			if (Script.IsNullOrUndefined(Window2.Rules))
			{
				Manager.Register(new Rule[] { });
				return;
			}

			Rule2[] Rules2 = (Rule2[])(Window2.Rules);
			Rule[] Rules = MapRules.Go(Rules2);

			Dictionary Examples = (Dictionary)(Window2.Examples);
			Script.Literal("debugger;");
			MergeExamples(Rules, Examples);

			Manager.Register(Rules);
		}

		private static void MergeExamples(Rule[] rules, Dictionary examaples)
		{
			foreach (Rule R in rules)
			{
				if (examaples[R.Identifier] == null)
				{
					continue;
				}
				R.Examples = (string[])examaples[R.Identifier];
			}
		}

		public static Rule[] Go(Rule2[] Rules2)
		{
			Rule[] Rules = new Rule[Rules2.Length];
			int cnt = 0;
			foreach (Rule2 R2 in Rules2)
			{
				Rule R = new Rule();
				R.AnthyaPrasa = R2.AnthyaPrasa;
				R.DeferThresold = R2.DeferThresold;
				R.Examples = R2.Examples;
				R.Frequency = R2.Frequency;
				R.Identifier = R2.Identifier;
				R.InfiniteLength = R2.InfiniteLength;
				R.Language = (R2.Language == null) ? RuleLanguage.Telugu : (R2.Language);
				R.Lines = R2.Lines;
				R.Name = R2.Name;
				R.OnlyPrasaYati = R2.OnlyPrasaYati;
				R.PadyamSubType = R2.PadyamSubType;
				R.PadyamType = R2.PadyamType;
				R.Prasa = R2.Prasa;
				R.PrasaYati = R2.PrasaYati;
				R.References = R2.References;
				R.RuleText = R2.RuleText;
				R.Rules = R2.Rules;
				R.ReverseYati = R2.ReverseYati;
				R.RuleType = R2.RuleType;
				R.Threshold = R2.Threshold;
				R.Yati = R2.Yati == null ? new int[][] { } : R2.Yati;
				R.YatiMode = R2.YatiMode;
				R.YatiRecycle = R2.YatiRecycle;
				Rules[cnt++] = R;
			}
			return Rules;
		}

		public static MatchOptions2 DefaultOptions()
		{
			Dictionary Options = new Dictionary();
			Options["AllowSantiPrasa"] = true;
			Options["ExperimenatalSandhi"] = true;
			Options["IncludeRare"] = true;
			Options["Language"] = RuleLanguage.Telugu;
			Options["MatchPrasa"] = true;
			Options["MatchYati"] = true;
			Options["QuickMatch"] = true;
			Options["ShowGV"] = false;
			return (MatchOptions2)(object)Options;
		}


		public static Chandam.Core.MatchOptions MapOptions(MatchOptions2 Options2)
		{
			if (Options2 == null)
			{
				return null;
			}

			MatchOptions Options = new MatchOptions();
			Options.AllowSantiPrasa = IfNotNull(Options2.AllowSantiPrasa);
			Options.ExperimenatalSandhi = IfNotNull(Options2.ExperimenatalSandhi);
			Options.IncludeRare = IfNotNull(Options2.IncludeRare);
			Options.Language = (Options2.Language == null) ? RuleLanguage.Telugu : (Options2.Language);
			Options.MatchPrasa = IfNotNull(Options2.MatchPrasa);
			Options.MatchYati = IfNotNull(Options2.MatchYati);
			Options.QuickMatch = IfNotNull(Options2.QuickMatch);
			return Options;
		}

		private static bool IfNotNull(bool val)
		{
			if (val == null)
			{
				return true;
			}
			return val;

		}
	}
}
