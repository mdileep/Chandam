//---------------------------------------------------------------------------------------------
// <copyright file="Print.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Html;

namespace MiriyamApp
{
	public class StandardExport
	{
		public static void PrintElemet(string ElementId)
		{
			Element Elem = Document.GetElementById(ElementId);
			if (Elem == null)
			{
				return;
			}

			string Content = Elem.InnerHTML;
			if (Content.Trim() == "")
			{
				Window.Alert("Nothing to print");
				return;
			}

			string[] styleSheets = new string[] { "CSS/Print.css" };
			string title = "Chandam-ఛందం ©";
			string Header = "";
			string Footer = "<div class='power'>ఛందం<sup class='copyright'>©</sup> తో పద్య సాహిత్యం మరింత రసమయం..!!</div>";

			Export.Print(styleSheets, title, Header, Content, Footer);

		}
	}

	public class Export
	{


		public static void Print(string[] styleSheets, string title, string Header, string content, string Footer)
		{
			string styleSheet = BuildStyleSheet(styleSheets);
			string html = "<html><head><title>{0}</title>{1}</head><body>{2}{3}{4}</body></html>";
			html = html.Replace("{0}", title).Replace("{1}", styleSheet).Replace("{2}", Header).Replace("{3}", content).Replace("{4}", Footer);

			PrintHTML(html);

		}

		private static void PrintHTML(string html)
		{
			WindowInstance wp = Window.Open("", "PrintPage");
			wp.Document.Open();
			wp.Document.Write(html);
			wp.Document.Close();
			wp.Document.Body.Focus();
			wp.Print();
		}

		private static string BuildStyleSheet(string[] styleSheets)
		{
			string s = "";
			string template = "<link href=\"{0}\" type=\"text/css\" rel=\"Stylesheet\" />";

			foreach (string stylesheet in styleSheets)
			{
				s = s + template.Replace("{0}", stylesheet);
			}
			return s;
		}
	}
}
