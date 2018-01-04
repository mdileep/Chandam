//---------------------------------------------------------------------------------------------
// <copyright file="Worker.cs" company="Chandam-ఛందం">
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
using MiriyamApp;
using MiriyamApp.External;
using System;
using System.Html;

namespace MiriyamAPI
{
	public static partial class Worker
	{
		public static void BeautifyAll(string identifier, Element parent, MatchOptions2 Options2)
		{
			ElementCollection List = (parent == null) ? Document.GetElementsByTagName("*") : parent.GetElementsByTagName("*");
			if (List == null)
			{
				return;
			}

			Element[] L = new Element[List.Length];
			for (int i = 0; i < List.Length; i++)
			{
				L[i] = List[i];
			}
			if (Options2 == null)
			{
				Options2 = MapRules.DefaultOptions();
				Options2.ShowGV = true;
			}

			for (int i = 0; i < L.Length; i++)
			{
				Element elem = L[i];
				string chandam = (string)elem.GetAttribute("chandam");
				string identifier2 = (string)elem.GetAttribute("chandassu");

				if (chandam == "0")
				{
					continue;
				}

				if (chandam == "1" || identifier2 != "")
				{
					if (identifier2 != null && identifier2 != "")
					{

						Beautify(elem, identifier2, Options2);

					}
					else
					{
						Beautify(elem, identifier, Options2);
					}
				}
			}

		}
		public static void BeautifyId(string id, string identifier, MatchOptions2 Options2)
		{
			Beautify(Document.GetElementById(id), identifier, Options2);
		}
		public static void BeautifyTags(string tag, string identifier, MatchOptions2 Options2)
		{
			ElementCollection List = Document.GetElementsByTagName(tag);
			Element[] L = new Element[List.Length];
			for (int i = 0; i < List.Length; i++)
			{
				L[i] = List[i];
			}
			if (Options2 == null)
			{
				Options2 = MapRules.DefaultOptions();
				Options2.ShowGV = true;
			}
			foreach (Element e in L)
			{
				if (e.TagName.ToLowerCase() == "div")
				{
					return;
				}
				Beautify(e, identifier, Options2);
			}
		}
		public static void Beautify(Element elem, string identifier, MatchOptions2 Options2)
		{
			if (elem == null)
			{
				return;
			}

			if (identifier == "ignore")
			{
				return;
			}

			Init();

			string padyam = CleanHTML(elem.InnerHTML.ToUpperCase());
			string html = "";
			if (Options2 == null)
			{
				Options2 = MapRules.DefaultOptions();
			}

			html = (identifier == null || identifier == "") ? Determine(padyam, Options2) : TryMatch(padyam, identifier, Options2);

			if (html != "")
			{
				elem.InnerHTML = "<div class='formatted'>" + html + "</div>" +
								 "<div class='orginal'>" + elem.InnerHTML + "</div>";
			}

			Element Close = Util.FindByClass(elem, "open");
			if (Close == null)
			{
				return;
			}

			Util.RegisterClick3(Close, delegate (ElementEvent ee)
			{
				Element Anchor = ee.Target.ParentNode.ParentNode;
				Element Target = Util.FindByClass(Anchor, "ganaVibhajana");

				OverlayDialog OD = new OverlayDialog("", Target.InnerHTML);
				OD.FooterText = "ఛందం<sup class='copyright'>©</sup> తో పద్యసాహిత్యం మరింత రసమయం..!! [<a target='_blank' href='http://chandam.apphb.com'>http://chandam.apphb.com</a>]";
				OD.ShowClose = false;
				OD.Show();
			});
		}
		private static string TryMatch(string padyam, string identifier, MatchOptions2 Options2)
		{
			return Business.TryMatch(padyam, identifier, Options2);
		}
		public static MatchOptions GetOptions(MatchOptions2 Options2)
		{
			if (Options2 == null)
			{
				return Settings();
			}
			else
			{
				return MapRules.MapOptions(Options2);
			}
		}
		public static string Determine(string padyam, MatchOptions2 Options2)
		{
			Probable Pr = Business.Determine(padyam, Options2);
			return Business.BuildResult2(Pr, Options2 == null ? true : Options2.ShowGV);
		}
		private static void Init()
		{
			if (Window2.Loaded == null || !Window2.Loaded)
			{
				MapRules.LoadExternalRules();
				Window2.Loaded = true;
			}
		}
		private static string CleanHTML(string str)
		{
			str = str.Replace("&nbsp;", " ");//May be clean all kinds of stuf like &nbsp;
			str = str.Replace("\t", " ");

			RegExp exp = new RegExp("<(.*?)/>", "mig");
			str = str.ReplaceRegex(exp, "\n");

			exp = new RegExp("<(.*?)>", "mig");
			str = str.ReplaceRegex(exp, "\n");

			str = str.Replace("<BR>", "\n").Replace("<BR />", "\n").Replace("\n\n", "\n");
			while (str.IndexOf("\n\n") != -1)
			{
				str = str.Replace("\n\n", "\n");
			}

			StringBuilder sb = new StringBuilder();
			foreach (string line in str.Split("\n"))
			{
				if (line.Trim().Length > 0)
				{
					sb.AppendLine(line);
				}
			}

			return (string)Script.Literal("sb.toString2()", null);
		}
		private static MatchOptions Settings()
		{
			MatchOptions Options = new MatchOptions();
			Options.MatchYati = true;
			Options.MatchPrasa = true;
			Options.AllowSantiPrasa = true;
			Options.QuickMatch = true;
			Options.ExperimenatalSandhi = true;
			Options.Language = RuleLanguage.Telugu;
			return Options;
		}
	}
}

;