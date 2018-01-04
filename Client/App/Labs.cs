//---------------------------------------------------------------------------------------------
// <copyright file="Labs.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using Library.Chandam.Labs;
using MiriyamApp;
using System;
using System.Collections.Generic;
using System.Html;

namespace MiriyamaApp.Labs
{
	public class ChandamLab
	{
		public static void Init()
		{
			Worker.LoadRules();
			SetList();
			LoadChandamNames();
			Document.GetElementById("LabsPage").Style.Display = "block";
			try
			{
				Document.GetElementById("banner").Style.Display = "block";
				for (int i = 0; i < Document.GetElementById("banner").ChildNodes.Length; i++)
				{
					Element E = Document.GetElementById("banner").ChildNodes[i];
					E.Style.Display = "none";
				}
			}
			catch
			{

			}
		}

		private static void LoadChandamNames()
		{
			Element E = Window.Document.GetElementById("ChandamNames");
			E.InnerHTML = "";
			for (int i = 1; i <= 26; i++)
			{
				string s = Helper.ChandamName(i) + " (" + i + ")";
				Element O = Util.AddOptionItem(s, i.ToString(), false);
				E.AppendChild(O);
			}
		}

		public static void SetList()
		{
			//perf to  be improved...
			Element E = Window.Document.GetElementById("MachineEnabled");
			E.InnerHTML = "";

			Element Jati = Util.AddOptionItem("జాతులు", "జాతులు", true);
			Element SamaVruttam = Util.AddOptionItem("సమ వృత్తములు", "సమ వృత్తములు", true);
			Element ASamaVruttam = Util.AddOptionItem("అసమ వృత్తములు", "అసమ వృత్తములు", true);


			foreach (Rule R in SortHelper.SortByName(RuleHelper.GetRules2(PadyamSubType.Jati)))
			{
				if (R.Identifier == "kandam")
				{
					Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
					Jati.AppendChild(O);
				}
			}

			List<Element> OrderedVruttams = new List<Element>();
			for (int i = 1; i <= 27; i++)
			{

				string cName = Helper.ChandamName(i) + (i <= 26 ? " (" + i + ")" : " (>26)");
				Element Local = Util.AddOptionItem(cName, cName, true);
				Rule[] VRules = i <= 26 ? RuleHelper.GetRules3(i) : RuleHelper.GetRules4(i);
				foreach (Rule R in SortHelper.SortByName(VRules))
				{
					if (!R.InfiniteLength)
					{
						Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
						Local.AppendChild(O);
						OrderedVruttams.Add(Local);
					}

				}
			}

			Rule[] asamaRules = RuleHelper.GetRules2(PadyamSubType.VishamaVruttam);
			foreach (Rule R in SortHelper.SortByName(asamaRules))
			{
				Element O = Util.AddOptionItem(R.Name, R.Identifier, false);
				ASamaVruttam.AppendChild(O);
			}


			E.AppendChild(Jati);
			E.AppendChild(SamaVruttam);
			foreach (Element _E in OrderedVruttams)
			{
				E.AppendChild(_E);
			}
			E.AppendChild(ASamaVruttam);

		}

		public static void WriteAPadyam()
		{
			string identifier = Util.SelectedValue("MachineEnabled");
			string s = new MachinePoem().Build(identifier);
			s = Business.TryMatch(s, identifier, MatchOptions.QucikMatchSettings);
			Document.GetElementById("result").InnerHTML = s;
			Util.ScrollTo("main");

		}
		public static void FindMatraVruttams(int n)
		{

			Rule[] Rules = RuleHelper.GetMatraVruttams(n);
			if (Rules.Length == 0)
			{
				Document.GetElementById("result").InnerHTML = "<span class='gName'>ఫలితాలు ఏమీ లేవు</span>";
				return;
			}

			Rules = SortHelper.SortByCharLength(Rules);
			StringBuilder sb = new StringBuilder();
			sb.Append("<span class='gName'>");
			sb.Append(n);
			sb.Append("</span>");
			sb.Append(" మాత్రలు గల వృత్తములు క్రిందన ఇవ్వబడ్డాయి.");

			sb.Append(" మొత్తం ");
			sb.Append("<span class='gName'> ");
			sb.Append(Rules.Length);
			sb.Append("</span>");
			sb.Append(" వృత్తములు దొరికాయి. ");


			sb.Append("<ol>");
			int last = 0;
			foreach (Rule R in Rules)
			{
				if (R.CharLength != last)
				{
					if (0 != last)
					{
						sb.Append("</ol>");
						sb.Append("</li>");
					}
					sb.Append("<li>");

					sb.Append("<b>");
					sb.Append(R.ChandamName + " (" + R.CharLength + ") ");
					sb.Append("</b>");
					sb.Append("</li>");
					sb.Append("<ol>");

				}

				sb.Append("<li>");
				sb.Append(R.Name);
				sb.Append("</li>");

				last = R.CharLength;
			}
			sb.Append("</li>");
			sb.Append("</ol>");
			Document.GetElementById("result").InnerHTML = (string)Script.Literal("sb.toString2()", null);

		}
		public static string BuildGana(int c, int n)
		{
			return Helper.BuildGana(c, n);
		}



	}
}
