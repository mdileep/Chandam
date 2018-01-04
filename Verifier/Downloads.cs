//---------------------------------------------------------------------------------------------
// <copyright file="Downloads.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Verifier
{
	public class Downloads
	{

		public static void All()
		{
			//Downloads.BuildCheatSheet ( );
			//Downloads.BuildSansCheatSheet ( );

			//Downloads.BuildBook ( );
			//Downloads.BuildSansBook ( );


			//Downloads.BuildIndex ( );

			foreach (FileInfo FI in new DirectoryInfo("padyam").GetFiles("*.txt"))
			{
				Downloads.Determaine(FI.FullName);
			}

		}

		public static void Determaine(string source)
		{

			string title = "ఛందోగణనం";
			string caption = "ఛందం © తో పద్య సాహిత్యం మరింత రసమయం..!! [http://chandam.apphb.com] ";

			string s = File.ReadAllText(source);
			string s2 = Eval.Build(s);
			string s3 = BuildHTML(title, s2, false);
			s3 = ReWrite(s3);

			File.WriteAllText(source + ".html", s3, Encoding.UTF8);

			PDFOptions Options = PDFOptions.Default;
			Options.Caption = caption;
			Options.Title = title;
			new PDFUtil(Options).HTML2PDF(source + ".html", source + ".pdf");
		}
		private static string ReWrite(string s3)
		{
			s3 = s3.Replace("<label", "<span");
			s3 = s3.Replace("</label>", "</span>");
			s3 = s3.Replace("<b>", "<b style='color:red;'>");
			s3 = s3.Replace("<u>", "<u style='color:blue;'>");
			s3 = s3.Replace("<th>", "<th style='text-align:center;'>");
			s3 = s3.Replace("<td>", "<td style='text-align:center;'>");
			s3 = s3.Replace("<td >", "<td style='text-align:center;'>");
			s3 = s3.Replace("class='stamper'", "style='font-size:48px;text-align:center;vertical-align:middle;'");
			s3 = s3.Replace("class='err'", "style='color:red;font-size:48px;font-family:Segoe UI Symbol;'");
			s3 = s3.Replace("class='ok'", "style='color:green;font-size:48px;font-family:Segoe UI Symbol;'");
			s3 = s3.Replace("class='X3 gErr'", "style='bgcolor:#EEEEEE;text-align:center;' class='th'");
			s3 = s3.Replace("class='X gErr'", "style='bgcolor:#EEEEEE;text-align:center;' class='th'");
			s3 = s3.Replace("<td class='X gOk'>", "<td style='text-align:center;'>");
			s3 = s3.Replace("<td class='X3 gOk'>", "<td style='text-align:center;'>");
			s3 = s3.Replace("class='tab'", "borderWidth='0'");
			return s3;
		}
		public static void BuildIndex()
		{
			string dir = @"D:\Working\Chandam\Web\menu\";
			File.WriteAllText(dir + @"tel.html", new IndexBuilder().BuildTelIndex2(), Encoding.UTF8);
			File.WriteAllText(dir + @"sans.html", new IndexBuilder().BuildSanIndex2(), Encoding.UTF8);
		}
		public static void BuildCheatSheet()
		{
			string dir = @"D:\Working\Chandam\Web\menu\";
			string title = "ఛందోరాజం";
			string caption = "ఛందం © తో పద్య సాహిత్యం మరింత రసమయం..!! [http://chandam.apphb.com] ";

			string s = CheatSheet.BuildCheatSheet(false, true);
			string s2 = BuildHTML(title, s);
			string s3 = BuildHTML(title, s, false);

			File.WriteAllText(dir + @"ChaMdOraajaM.html", s2, Encoding.UTF8);
			File.WriteAllText(@"ChaMdOraajaM.html", s3, Encoding.UTF8);

			PDFOptions Options = PDFOptions.Report;
			Options.Caption = caption;
			Options.Title = title;
			Options.PageSize = PageSize.A1;
			new PDFUtil(Options).HTML2PDF(@"ChaMdOraajaM.html", @"ChaMdOraajaM.pdf");
		}

		public static void BuildSansCheatSheet()
		{
			string dir = @"D:\Working\Chandam\Web\menu\";
			string title = "సంస్కృత ఛందోరాజం";
			string caption = "ఛందం © తో పద్య సాహిత్యం మరింత రసమయం..!! [http://chandam.apphb.com] ";

			string s = CheatSheet.BuildCheatSheet2(false, true, SortHelper.SortByCharLength(new List<Rule>(RuleHelper.GetSanRules())));
			string s2 = BuildHTML(title, s);
			string s3 = BuildHTML(title, s, false);

			File.WriteAllText(dir + @"SansChaMdOraajaM.html", s2, Encoding.UTF8);
			File.WriteAllText(@"SansChaMdOraajaM.html", s3, Encoding.UTF8);

			PDFOptions Options = PDFOptions.Report;
			Options.Caption = caption;
			Options.Title = title;
			Options.PageSize = PageSize.A1;
			new PDFUtil(Options).HTML2PDF(@"SansChaMdOraajaM.html", @"SansChaMdOraajaM.pdf");
		}
		public static void BuildSansBook()
		{
			string dir = @"D:\Working\Chandam\Web\menu\";
			string title = "సంస్కృత ఛందోరత్నావళి";
			string caption = "ఛందం © తో పద్య సాహిత్యం మరింత రసమయం..!! [http://chandam.apphb.com] ";

			string s = CheatSheet.BuildSansBook();
			string s2 = BuildHTML(title, s);
			string s3 = BuildHTML(title, s, false);

			File.WriteAllText(@dir + "SansChaMdOratnaavaLi.html", s2, Encoding.UTF8);
			File.WriteAllText(@"SansChaMdOratnaavaLi.html", s3, Encoding.UTF8);


			PDFOptions Options = PDFOptions.Book;
			Options.Caption = caption;
			Options.Title = title;
			Options.PageSize = PageSize.A4;
			new PDFUtil(Options).HTML2PDF(@"SansChaMdOratnaavaLi.html", @"SansChaMdOratnaavaLi.pdf");

		}
		public static void BuildBook()
		{
			string dir = @"D:\Working\Chandam\Web\menu\";
			string title = "ఛందోరత్నావళి";
			string caption = "ఛందం © తో పద్య సాహిత్యం మరింత రసమయం..!! [http://chandam.apphb.com] ";

			string s = Business.BuildBook();
			string s2 = BuildHTML(title, s);
			string s3 = BuildHTML(title, s, false);

			File.WriteAllText(@dir + "ChaMdOratnaavaLi.html", s2, Encoding.UTF8);
			File.WriteAllText(@"ChaMdOratnaavaLi.html", s3, Encoding.UTF8);


			PDFOptions Options = PDFOptions.Book;
			Options.Caption = caption;
			Options.Title = title;
			Options.PageSize = PageSize.A4;
			new PDFUtil(Options).HTML2PDF(@"ChaMdOratnaavaLi.html", @"ChaMdOratnaavaLi.pdf");

		}

		private static string BuildHTML(string title, string content, bool includeStyles)
		{

			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" \"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">");
			sb.AppendLine("<html xmlns=\"http://www.w3.org/1999/xhtml\" lang=\"te\">");




			if (includeStyles)
			{
				sb.AppendLine("<head>");
				sb.AppendFormat("<title>{0}</title>", title);
				sb.AppendLine("<link rel=\"shortcut icon\" href=\"CSS/Miriyam.ico\" />");
				sb.AppendLine(@"<style type=""text/css"">");
				sb.AppendLine(File.ReadAllText(@"D:\Working\Chandam\Web\css\print.css", Encoding.UTF8).Replace("font.ashx", "css/font.ashx"));
				sb.AppendLine("</style>");
				sb.AppendLine("</head>");
			}


			sb.AppendLine("<body>");
			sb.AppendFormat("<h1 style='text-align:center;font-size:36px;color:blue;'>{0}</h1>", title);
			sb.AppendLine("<br />");
			sb.AppendLine(content.Replace("<a ", "<span ").Replace("</a>", "</span>"));
			sb.AppendLine("<br />");
			sb.AppendFormat("<h2  style='text-align:right;color:gray; font-size:12px;width:100%;'>ఛందం<span class='symbol'>©</span> తో పద్య సాహిత్యం మరింత రసమయం..!!</h2>");
			sb.AppendFormat("<h3 style='text-align:left;color:gray; font-size:10px; font-style:italic;'>ముద్రించిన సమయం: " + DateTime.Now.ToString("dd-MMMM-yyyy HH:mm", new CultureInfo("te-IN")) + "</h3>");
			sb.AppendLine("</body>");
			sb.AppendLine("</html>");
			return sb.ToString();
		}
		private static string BuildHTML(string title, string content)
		{
			return BuildHTML(title, content, true);
		}

	}
}

