//---------------------------------------------------------------------------------------------
// <copyright file="Search.cs" company="Chandam-ఛందం">
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
using System;
using System.Html;


namespace MiriyamApp
{
	public static class Search
	{
		public static void Init()
		{
			Load();

		}

		private static void Load()
		{
			LoadPadyamTypes();
			LoadSreni();
			Worker.LoadRules();

		}

		private static void LoadSreni()
		{
			Element E = Window.Document.GetElementById("SearchSreni");
			if (E == null)
			{
				return;
			}
			E.InnerHTML = "";

			Element E0 = Util.AddOptionItem("ఏదేని", "-1", false);
			E0.SetAttribute("selected", "selected");
			E.AppendChild(E0);
			foreach (string k in new string[] { "3", "4", "5", "6", "3-4", "4-3", "4-5", "5-4", "3-5", "5-3" })
			{
				Element E1 = Util.AddOptionItem(k, k, false);
				E.AppendChild(E1);
			}
		}
		private static void LoadPadyamTypes()
		{
			Element E = Window.Document.GetElementById("SearchPadyamType");
			if (E == null)
			{
				return;
			}
			E.InnerHTML = "";

			Element E1 = Util.AddOptionItem("జాతి", "Jati", false);
			Element E2 = Util.AddOptionItem("ఉపజాతి", "UpaJati", false);
			Element E3 = Util.AddOptionItem("వృత్తం", "Vruttam", false);
			Element E4 = Util.AddOptionItem("ఏదేని", "Any", false);
			E4.SetAttribute("selected", "selected");


			E.AppendChild(E4);

			E.AppendChild(E1);
			E.AppendChild(E2);
			E.AppendChild(E3);

		}
		public static void Go()
		{
			Document.GetElementById("result").InnerHTML = "<b style='color:red;'>Searching ..</b>";
			Script.SetTimeout(SearchRules, 0);

		}
		private static void SearchRules()
		{
			SearchCriteria SC = GetSearchCriteria();
			Rule[] Rules = RuleHelper.GetRules7(SC);
			//Window.Alert ( Rules.Length+"ఫలితాలు దొరికాయి.\nResults found: " + Rules.Length );
			Document.GetElementById("result").InnerHTML = BuildList(Rules);
			Util.ScrollTo("main");
		}

		private static string BuildList(Rule[] Rules)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("<h2>");
			if (Rules.Length > 0)
			{
				sb.Append(Rules.Length + " ");
			}
			sb.Append("ఫలితాలు");
			sb.Append("</h2>");
			if (Rules.Length > 0)
			{
				sb.Append("<ol>");
				foreach (Rule R in Rules)
				{
					sb.Append("<li>");
					sb.Append("<a href='?chandassu=" + R.Identifier + "' target='_blank'>" + R.Name + "</a>");
					sb.Append("&nbsp;");
					sb.Append("<a  title='" + R.Name + " పద్య ఛందస్సులో వ్రాసిన పద్యాన్ని గణించండి.' href='?chandam=" + R.Identifier + "' target='_blank'><sup>^</sup></a>");
					sb.Append("</li>");
				}
				sb.Append("</ol>");
			}
			else
			{
				sb.Append("<b>ఫలితాలు ఏమీ లేవు.<br/> శోధనను మార్చి ప్రయత్నించండి.</b>");
			}
			return (string)Script.Literal("sb.toString2()", null);
		}
		private static SearchCriteria GetSearchCriteria()
		{
			string SearchName = Util.GetValue("SearchName");
			bool SearchSansToo = Util.IsChecked("SearchSansToo");
			string SearchPadyamType = Util.SelectedValue("SearchPadyamType");

			string SearchSreni = Util.SelectedValue("SearchSreni");
			string SearchMatra = Util.GetValue("SearchMatra");
			string SearchCharLen = Util.GetValue("SearchCharLen");

			SearchCriteria SC = new SearchCriteria();
			SC.MatraSreni = SearchSreni == "-1" ? "" : SearchSreni;
			SC.IncludeSans = SearchSansToo;
			SC.NameLike = SearchName;

			SC.PadyamType = GetPadtyamType(SearchPadyamType);

			SC.CharLength = 0;
			try
			{
				SC.CharLength = int.Parse(SearchCharLen);
			}
			catch
			{
				Util.SetValue("SearchCharLen", "0");
			}


			SC.MatraLength = 0;
			try
			{
				SC.MatraLength = int.Parse(SearchMatra);
			}
			catch
			{
				Util.SetValue("SearchMatra", "0");
			}

			return SC;
		}

		private static PadyamType GetPadtyamType(string nm)
		{
			switch (nm)
			{
				case "Jati":
					return PadyamType.Jati;
				case "UpaJati":
					return PadyamType.UpaJati;
				case "Vruttam":
					return PadyamType.Vruttam;
				case "Any":
				default:
					return PadyamType.Unspecified;
			}
		}


	}
}
