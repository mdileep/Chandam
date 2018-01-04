//---------------------------------------------------------------------------------------------
// <copyright file="LoadRules.cs" company="Chandam-ఛందం">
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
using System.Collections.Generic;
using System.Html;

namespace MiriyamApp
{
	public class LoadRules2
	{
		public static void SetGroupedList(bool includeRare)
		{
			int cnt = 0;
			Element Jati = Util.AddOptionItem("జాతులు", "జాతులు", true);
			Element UpaJati = Util.AddOptionItem("ఉప-జాతులు", "ఉప-జాతులు", true);
			Element Vruttam = Util.AddOptionItem("తరుచుగా  వాడే వృత్తములు", "తరుచుగా  వాడే వృత్తములు", true);
			Element Ragadalu = Util.AddOptionItem("రగడలు", "రగడలు", true);
			Element Shatpadalu = Util.AddOptionItem("షట్పదలు", "షట్పదలు", true);
			Element Akkara = Util.AddOptionItem("అక్కరలు(జాతులు)", "అక్కరలు(జాతులు)", true);
			Element Dvipadalu = Util.AddOptionItem("ద్విపదలు(జాతులు)", "ద్విపదలు(జాతులు)", true);
			Element Sisamulu = Util.AddOptionItem("సీసములు(ఉప-జాతులు)", "సీసములు(ఉప-జాతులు)", true);
			Element ASamaVruttam = Util.AddOptionItem("అసమ వృత్తములు", "అసమ వృత్తములు", true);
			Element daMDakaVruttam = Util.AddOptionItem("దండకములు", "దండకములు", true);
			Element GenericVruttam = Util.AddOptionItem("ఏదేని వృత్తం ##", "ఏదేని వృత్తం ##", true);



			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.DaMDakamu)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				daMDakaVruttam.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules5(PadyamType.Vruttam, Frequency.Frequent)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Vruttam.AppendChild(O);
				//cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Akkara)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Akkara.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Ragada)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Ragadalu.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Ragada2)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Ragadalu.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Shatpada)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Shatpadalu.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Divpada)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Dvipadalu.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Sisamu)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Sisamulu.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Jati)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				Jati.AppendChild(O);
				cnt++;
			}

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.UpaJati)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				UpaJati.AppendChild(O);
				cnt++;
			}

			{
				Rule R = new Chandam.Rules.Vruttam.GenricVruttam();
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				GenericVruttam.AppendChild(O);
				//cnt++;
			}

			List<Element> OrderedVruttams = new List<Element>();
			if (includeRare)
			{
				for (int i = 1; i <= 27; i++)
				{
					string cName = Helper.ChandamName(i) + (i <= 26 ? " (" + i + ")" : " (>26)");
					Element Local = Util.AddOptionItem(cName, cName, true);

					Rule[] VRules = i <= 26 ? RuleHelper.GetRules3(i) : RuleHelper.GetRules4(i);
					foreach (Rule R in SortHelper.SortByName(VRules))
					{
						Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
						Local.AppendChild(O);
						OrderedVruttams.Add(Local);
						cnt++;
					}
				}
			}

			Rule[] asamaRules = RuleHelper.GetRules2(PadyamSubType.VishamaVruttam);
			foreach (Rule R in SortHelper.SortByName(asamaRules))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				ASamaVruttam.AppendChild(O);
				cnt++;
			}

			Element E = Window.Document.GetElementById("list");
			E.InnerHTML = "";

			if (Jati.Children.Length > 0) { E.AppendChild(Jati); }
			if (Akkara.Children.Length > 0) { E.AppendChild(Akkara); }
			if (Dvipadalu.Children.Length > 0) { E.AppendChild(Dvipadalu); }
			if (UpaJati.Children.Length > 0) { E.AppendChild(UpaJati); }
			if (Sisamulu.Children.Length > 0) { E.AppendChild(Sisamulu); }
			if (Vruttam.Children.Length > 0) { E.AppendChild(Vruttam); }

			if (includeRare)
			{
				foreach (Element _E in OrderedVruttams)
				{
					E.AppendChild(_E);
				}
			}

			if (daMDakaVruttam.Children.Length > 0) { E.AppendChild(daMDakaVruttam); }
			if (ASamaVruttam.Children.Length > 0) { E.AppendChild(ASamaVruttam); }
			if (Shatpadalu.Children.Length > 0) { E.AppendChild(Shatpadalu); }
			if (Ragadalu.Children.Length > 0) { E.AppendChild(Ragadalu); }
			if (GenericVruttam.Children.Length > 0) { E.AppendChild(GenericVruttam); }


			Document.GetElementById("totItems").InnerHTML = cnt.ToString() + "+";
		}

		public static void SetSortedList(bool includeRare)
		{
			int cnt = 0;


			Element E = Window.Document.GetElementById("list");
			E.InnerHTML = "";

			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetAllRules(includeRare)))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				E.AppendChild(O);
				cnt++;
			}

			Document.GetElementById("totItems").InnerHTML = cnt.ToString() + "+";
		}
	}
}
