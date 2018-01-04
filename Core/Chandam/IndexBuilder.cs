//---------------------------------------------------------------------------------------------
// <copyright file="IndexBuilder.cs" company="Chandam-ఛందం">
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

namespace Chandam.Core
{
	public class IndexBuilder
	{
		public string BuildSanIndex2()
		{
			string s2 = "<h2  style='text-align:center;'>సంస్కృత ఛందస్సులు</h2>";
			s2 = s2 + "<h2 style='text-align:center;'>వృత్తములు</h2><ol>";
			for (int i = 1; i <= 27; i++)
			{
				string cName = (i <= 26 ? Helper.ChandamName(i) + " (" + i + ")" : " ఇతర");
				Rule[] VRules = i <= 26 ? RuleHelper.GetSanRules2(i) : RuleHelper.GetSanRules3();

				s2 = s2 + "<h2 style='text-align:center;'>" + cName + "</h2>";
				s2 = s2 + "<ol>";
				foreach (Rule R in SortHelper.SortByName(VRules))
				{
					s2 = s2 + "<li id='h_" + R.Identifier + "'><a class='identifier'  title='" + R.Name + "' href='?chandassu=" + R.Identifier + "'>" + R.Name + "</a></li>";
				}
				s2 = s2 + "</ol>";
			}
			s2 = s2 + "</ol>";
			s2 = "<ol>" + s2 + "</ol>";
			return s2;
		}
		public string BuildTelIndex2()
		{
			string s2 = "<h2  style='text-align:center;'>తెలుగు ఛందస్సులు</h2>";
			s2 = s2 + SortByName2("జాతులు", PadyamSubType.Jati);
			s2 = s2 + SortByName2("అక్కరలు", PadyamSubType.Akkara);
			s2 = s2 + SortByName2("రగడలు", PadyamSubType.Ragada);
			s2 = s2 + SortByName2("ముత్యాలసరములు", PadyamSubType.Ragada2);
			s2 = s2 + SortByName2("షట్పదలు", PadyamSubType.Shatpada);
			s2 = s2 + SortByName2("ఉప-జాతులు", PadyamSubType.UpaJati);
			s2 = s2 + SortByName2("ద్విపదలు", PadyamSubType.Divpada);
			s2 = s2 + SortByName2("సీసములు", PadyamSubType.Divpada);
			s2 = s2 + SortByName2("దండకములు", PadyamSubType.DaMDakamu);

			s2 = s2 + "<h2 style='text-align:center;'>వృత్తములు</h2><ol>";
			for (int i = 1; i <= 27; i++)
			{
				string cName = Helper.ChandamName(i) + (i <= 26 ? " (" + i + ")" : " (>26)");
				Rule[] VRules = i <= 26 ? RuleHelper.GetRules3(i) : RuleHelper.GetRules4(i);

				s2 = s2 + "<h2 style='text-align:center;'>" + cName + "</h2>";
				s2 = s2 + "<ol>";
				foreach (Rule R in SortHelper.SortByName(VRules))
				{
					s2 = s2 + "<li id='h_" + R.Identifier + "'><a class='identifier'  title='" + R.Name
						+ "' href='?chandassu=" + R.Identifier + "'>" + R.ShortName + "</a></li>";
				}
				s2 = s2 + "</ol>";
			}
			s2 = s2 + "</ol>";

			s2 = s2 + SortByName2("అసమ వృత్తములు", PadyamSubType.VishamaVruttam);

			s2 = "<ol>" + s2 + "</ol>";
			return s2;
		}
		public string SortByName2(string head, PadyamSubType padyamSubType)
		{
			string s2 = "";
			s2 = s2 + "<h2 style='text-align:center;'>" + head + "</h2>";
			s2 = s2 + "<ol>";
			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(padyamSubType)))
			{
				s2 = s2 + "<li id='h_" + R.Identifier + "'><a class='identifier'  title='" + R.Name + "'  href='?chandassu=" + R.Identifier + "'>" + R.ShortName + "</a></li>";
			}
			s2 = s2 + "</ol>";
			return s2;
		}
	}
}
