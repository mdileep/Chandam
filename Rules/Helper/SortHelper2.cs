//---------------------------------------------------------------------------------------------
// <copyright file="SortHelper2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:35EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;


namespace Chandam.Rules
{
	public partial class SortHelper
	{
		public static Rule[] OrderedRules()
		{
			//Very  bad way of sorting....
			List<Rule> Rules = new List<Rule>();

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Akkara)))
			{
				Rules.Add(R);
			}
			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Divpada)))
			{
				Rules.Add(R);
			}
			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Jati)))
			{
				Rules.Add(R);
			}
			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Ragada)))
			{
				Rules.Add(R);
			}
			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Ragada2)))
			{
				Rules.Add(R);
			}
			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Shatpada)))
			{
				Rules.Add(R);
			}


			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.UpaJati)))
			{
				Rules.Add(R);
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Sisamu)))
			{
				Rules.Add(R);
			}

			for (int i = 1; i <= 27; i++)
			{
				//string cName = Helper.ChandamName(i) + (i <= 26 ? " (" + i + ")" : " (>26)");
				Rule[] VRules = i <= 26 ? RuleHelper.GetRules3(i) : RuleHelper.GetRules4(i);
				foreach (Rule R in SortHelper.SortByName(VRules))
				{
					Rules.Add(R);
				}
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.DaMDakamu)))
			{
				Rules.Add(R);
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.VishamaVruttam)))
			{
				Rules.Add(R);
			}

			//Why doing this again??
			Rule[] Rules2 = new Rule[Rules.Count];
			for (int i = 0; i < Rules.Count; i++)
			{
				Rules2[i] = Rules[i];
			}

			return Rules2;


		}
	}
}
