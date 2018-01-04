//---------------------------------------------------------------------------------------------
// <copyright file="Satakam.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Library.Chandam.Samples
{
	public partial class Satakam
	{
		public static string Build(SatakamData S, MatchOptions Options, OutputOptions OO)
		{
			return Build(S.Poems.ToArray(), S.Title, S.HeaderString, S.FooterString, Options, OO);
		}
		private static string BuildFile(string title, string header, string footer, string content, string embedVal)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<html>");
			sb.AppendLine("<head>");
			sb.AppendFormat("<title>{0}</title>", title);
			sb.AppendLine("");
			if (embedVal == null)
			{
				sb.AppendLine(@"<link href=""Chandam.css"" rel=""stylesheet"" type=""text/css"" />");
			}
			else
			{
				sb.Append("<style>");
				sb.Append(embedVal);
				sb.Append("</style>");
			}
			sb.AppendLine("</head>");
			sb.AppendLine("<body>");
			sb.AppendFormat("<div class='title'>{0}</div>", title);
			sb.AppendFormat("<div class='header'>{0}</div>", header.Replace("\n", "<br/>"));
			sb.AppendLine("");

			sb.Append(content);

			sb.AppendFormat("<div class='footer'>{0}</div>", footer.Replace("\n", "<br/>"));
			sb.AppendLine("</body>");
			sb.AppendLine("</html>");
			return sb.ToString();

		}
		public static string Build(SatakamData S, MatchOptions Options)
		{
			return Build(S, Options, new OutputOptions { UseFullName = false, ErrorsOnly = false });
		}
		public static string Build(Poem[] Poems, string title, string header, string footer, MatchOptions Options)
		{
			return Build(Poems, title, header, footer, Options, new OutputOptions { UseFullName = false, ErrorsOnly = false });
		}
		public static string Build(Poem[] Poems, string title, string header, string footer, MatchOptions Options, OutputOptions OO)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("<ol  class='ol'>");
			for (int i = 0; i < Poems.Length; i++)
			{
				Console.WriteLine("Processing Padyam: " + (i + 1));

				Poem poem = Poems[i];

				string x = Build(poem, Options, OO);
				if (x != "")
				{
					sb.AppendLine("<li>");
					sb.AppendLine(x);
					sb.AppendLine("</li>");
				}
			}
			sb.AppendLine("</ol>");
			return BuildFile(title, header, footer, sb.ToString(), OO.EmbedValue);
		}
		public static string Build(MatchResult MR, Rule R, Padyam P, OutputOptions OO)
		{
			StringBuilder sb = new StringBuilder();

			if (MR.Percentage != 100)
			{
				sb.Append("<div style=' margin-top:10px;'>");
				sb.Append("<div class='err10' style='clear:left;text-align:left;width:100%;' tile='" + R.Name + "'>" + (OO.UseFullName ? R.Name : R.ShortName));
				sb.Append(": <b style='color:red'>" + MR.Percentage.ToString("0") + "%</b>(" + MR.Score + "/" + MR.Total + ")");
				sb.AppendLine("</div>");

				sb.AppendLine("<div style='clear:left;float:left;width:50%;margin-right:10px;'>");

				sb.AppendLine("<div style='margin:10px; text-align:left;'>");

				sb.AppendLine("<div class='Err22'>");
				sb.AppendLine(P.Build2(MR));
				sb.AppendLine("</div>");

				sb.AppendLine("<div class='err' style='text-align:right;'>తప్పులు</div>");
				sb.AppendLine(MR.ShowErrors(OutputFormat.HTML));
				sb.AppendLine("</div>");

				sb.AppendLine("</div>");

				sb.AppendLine("<div style='float:left;width:auto;margin-left:10px;'><div class='err'  style='text-align:right;'>గణ విభజన</div>");
				sb.AppendLine(P.Build(MR));
				sb.AppendLine("</div>");
				sb.AppendLine("</div>");
			}
			else
			{
				if (!OO.ErrorsOnly)
				{
					sb.Append("<div style=' margin-top:10px;'>");
					sb.AppendLine("<div class='err10' style='clear:left;text-align:left;width:100%;'>" + R.Name + "</div>");
					sb.AppendLine("<div style='clear:left;float:left;margin-left:10px;'><div class='Err22'>");
					sb.AppendLine(P.Build2(MR));
					sb.AppendLine("</div></div>");
					sb.AppendLine("</div>");
				}
			}

			return sb.ToString();
		}



		public static void Write2File(string fileName, SatakamData SD)
		{
			StringBuilder sb = new StringBuilder();
			switch (SD.Format)
			{
				case Format.Format1:
					sb.AppendLine("#FORMAT-1");
					break;
				default:
					sb.AppendLine("#");
					break;
			}
			sb.AppendLine("#" + SD.Title);
			foreach (string header in SD.Header)
			{
				sb.AppendLine((header.StartsWith("#") ? "" : "#") + header);
			}
			foreach (Poem poem in SD.Poems)
			{
				sb.AppendLine(poem.Text.Replace("\n", "\\n"));
			}
			foreach (string footer in SD.Footer)
			{
				sb.AppendLine((footer.StartsWith("#") ? "" : "#") + footer);
			}
			File.WriteAllText(fileName, sb.ToString());
		}
		public static SatakamData ExtractSatakamFromFile(string fileName)
		{
			string[] Lines = File.ReadAllLines(fileName);
			SatakamData S = ExtractSatakam(Lines);
			return S;
		}
		public static SatakamData ExtractSatakam(string[] Lines)
		{
			List<string> Header = new List<string>();
			List<string> Footer = new List<string>();

			bool dueFooter = false;
			SatakamData S = new SatakamData();
			List<Poem> Poems = new List<Poem>();
			for (int i = 0; i < Lines.Length; i++)
			{
				string line = Lines[i];
				#region FirstLine-Format
				if (i == 0)
				{
					switch (line)
					{
						case "#FORMAT-1":
							S.Format = Format.Format1;
							continue;
						case "#FORMAT-2":
							S.Format = Format.Format2;
							continue;
						default:
							S.Format = Format.Unknown;
							continue;
					}
				}
				#endregion
				#region SecondLine-Title
				if (i == 1)
				{
					S.Title = line.Replace("#", "");
					continue;
				}
				#endregion


				if (line.StartsWith("#"))
				{
					if (dueFooter)
					{
						Footer.Add(line.Replace("#", ""));
					}
					else
					{
						Header.Add(line.Replace("#", ""));
					}
				}
				else
				{
					dueFooter = true;
					switch (S.Format)
					{
						case Format.Format1:
							Poem P = new Poem();
							P.Text = line.Replace("\\n", "\n");
							Poems.Add(P);
							break;
						default:
							break;
					}
				}
			}
			S.Header = Header;
			S.Footer = Footer;
			S.Poems = Poems;
			return S;
		}





	}
}
