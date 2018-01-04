//---------------------------------------------------------------------------------------------
// <copyright file="GenerateRulesJS.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using Library.Chandam.Samples;
using SearchEngine.Services.Indic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace Verifier
{
	public class GenerateRulesJS
	{
		string root = "";

		public GenerateRulesJS(string root)
		{
			this.root = root;
		}

		public void Go()
		{
			version = GetNewVersion();
			license = File.ReadAllText(root + "license.txt");
			license = String.Format(license, DateTime.Now.ToString("dd-MMM-yyyy HH:MM:ss tt \"GMT\"zzz"), version);

			Go(RuleLanguage.Telugu);
			Go(RuleLanguage.Kannada);
		}

		private void Go(RuleLanguage lang)
		{
			string langCode = Helper3.GetLangCode(lang);
			APIBuilder Builder = new APIBuilder(root, version);

			Builder.Go(true, lang, langCode);
			Builder.Go(false, lang, langCode);

			PackAll(langCode);

			ListIdentifiers(lang, langCode);
		}

		public void PackAll(string langCode)
		{
			PackingHelper.Pack(root, "chandam." + langCode + ".js",
			new string[]
			{
				"Miriyam.API.Core.js",
				"MiriyamUtil.js",
				"MiriyamLib.js",
				"config."+langCode+".js",
				"MiriyamAPI.js"
			}, license);

			PackingHelper.Pack(root, "chandam." + langCode + ".min.js",
			new string[]
			{
				"Miriyam.API.Core.js",
				"MiriyamUtil.min.js",
				"MiriyamLib.min.js",
				"config."+langCode+".js",
				"MiriyamAPI.min.js"
			}, license);

			PackingHelper.Pack(root, "chandam." + langCode + ".app.min.js",
			new string[]
			{
				"minified.template.js",
				"config."+langCode+".examples.js",
				"MiriyamUtil.min.js",
				"MiriyamLib.min.js",
				"MiriyamApp.min.js",
				"skel-minified.js"
			}, license);

			PackingHelper.Pack(root, "chandam." + langCode + ".app.js",
			new string[]
			{
				"minified.template.js",
				"config."+langCode+".examples.js",
				"MiriyamUtil.js",
				"MiriyamLib.js",
				"MiriyamApp.js",
				"skel-minified.js"
			}, license);
		}

		private void ListIdentifiers(RuleLanguage lang, string langCode)
		{
			StreamWriter sw = new StreamWriter(root + @"\id." + langCode + ".txt", false, Encoding.UTF8);
			Rule[] Rules = Manager.Rules();
			foreach (Rule R in Rules)
			{
				sw.Write("<tr>");
				sw.Write("<td>" + R.Identifier + "</td>");
				sw.Write("<td>" + R.Name + "</td>");
				sw.Write("<td><a href='/?chandassu=" + R.Identifier + "' target='_blank'>లక్షణాలు</a></td>");
				sw.WriteLine("</tr>");
			}
			sw.Close();
		}

		private string GetNewVersion()
		{
			string version = File.ReadAllText(root + "version.txt");
			Version V = Version.Parse(version);
			Version V2 = new Version(V.Major, V.Minor, V.Build, V.Revision + 1);
			if (V2.Revision >= 100)
			{
				V2 = new Version(V.Major, V.Minor, V.Build + 1, 0);
			}
			if (V2.Build >= 100)
			{
				V2 = new Version(V.Major, V.Minor + 1, 0, 0);
			}
			if (V2.Minor >= 10)
			{
				V2 = new Version(V.Major + 1, 0, 0, 0);
			}

			File.WriteAllText(root + "version.txt", V2.ToString());
			return V2.ToString();
		}



		string version;
		string license;
	}
	public class Helper3
	{
		public static string GetLangCode(RuleLanguage lang)
		{
			switch (lang)
			{
				case RuleLanguage.Kannada:
					return "kn";

				default:
				case RuleLanguage.Telugu:
					return "te";
			}
		}

	}
	public class ExportRules
	{

		public string ToXML(bool withExamples, RuleLanguage lang, string langCode)
		{
			bool compact = true;
			//Why not Serialisation??


			Rule[] Rules = Manager.Rules();
			XmlDocument doc = new XmlDocument();
			XmlElement RulesNode = doc.CreateElement("Rules");
			RulesNode.SetAttribute("lang", Helper3.GetLangCode(lang));
			foreach (Rule R in Rules)
			{
				XmlElement RuleNode = doc.CreateElement("Rule");

				RuleNode.SetAttribute("identifier", R.Identifier);

				{
					XmlNode nameNode = doc.CreateElement("name");
					nameNode.InnerText = GetName(R.Name, lang);
					RuleNode.AppendChild(nameNode);
				}
				{
					XmlNode linesNode = doc.CreateElement("lines");
					linesNode.InnerText = R.Lines.ToString();
					RuleNode.AppendChild(linesNode);
				}
				{
					XmlElement thresholdNode = doc.CreateElement("threshold");
					thresholdNode.InnerText = R.Threshold.ToString();
					if (R.DeferThresold)
					{
						thresholdNode.SetAttribute("deferThresold", R.DeferThresold.ToString());
					}
					RuleNode.AppendChild(thresholdNode);
				}
				{
					XmlNode padyamTypeNode = doc.CreateElement("padyamType");
					padyamTypeNode.InnerText = EnumText(R.PadyamType);
					RuleNode.AppendChild(padyamTypeNode);
				}
				{
					XmlNode node = doc.CreateElement("padyamSubType");
					node.InnerText = EnumText(R.PadyamSubType);
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("ruleType");
					node.InnerText = EnumText(R.RuleType);
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("rules");
					node.InnerXml = GetRulesXml(R.RuleType, R.Rules);
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("prasa");
					node.InnerText = R.Prasa ? "1" : "0";
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("prasaYati");
					node.InnerText = R.PrasaYati ? "1" : "0";
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("onlyPrasaYati");
					node.InnerText = R.OnlyPrasaYati ? "1" : "0";
					RuleNode.AppendChild(node);
				}

				{
					XmlNode node = doc.CreateElement("onlyPrasaYati");
					node.InnerText = R.OnlyPrasaYati ? "1" : "0";
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("anthyaPrasa");
					node.InnerText = R.AnthyaPrasa ? "1" : "0";
					RuleNode.AppendChild(node);
				}


				if (lang == RuleLanguage.Kannada)
				{
					//NOTHING at this point of time
				}
				else
				{
					{
						XmlNode node = doc.CreateElement("yatiMode");
						node.InnerText = EnumText(R.YatiMode);
						RuleNode.AppendChild(node);
					}

					{
						XmlNode node = doc.CreateElement("yatiRecycle");
						node.InnerText = R.YatiRecycle ? "1" : "0";
						RuleNode.AppendChild(node);
					}
					{
						XmlNode node = doc.CreateElement("reverseYati");
						node.InnerText = R.ReverseYati ? "1" : "0";
						RuleNode.AppendChild(node);
					}
					{
						XmlNode node = doc.CreateElement("yati");
						//node.InnerText = R.Yati;
						RuleNode.AppendChild(node);
					}
				}
				{
					XmlNode node = doc.CreateElement("frequency");
					node.InnerText = EnumText(R.Frequency);
					RuleNode.AppendChild(node);
				}

				{
					XmlNode node = doc.CreateElement("language");
					node.InnerText = EnumText(lang);
					RuleNode.AppendChild(node);
				}
				{
					XmlNode node = doc.CreateElement("infiniteLength");
					node.InnerText = R.InfiniteLength ? "1" : "0";
					RuleNode.AppendChild(node);
				}

				if (withExamples)
				{
					XmlNode node = doc.CreateElement("rules");
					node.InnerXml = GetExamplesXml(R.Examples, lang);
					RuleNode.AppendChild(node);
				}

				if (lang != RuleLanguage.Kannada)
				{
					{
						XmlNode node = doc.CreateElement("references");
						node.InnerXml = GetArrayXml(R.References);
						RuleNode.AppendChild(node);
					}
					if (compact)
					{
						XmlNode node = doc.CreateElement("ruleText");
						XmlCDataSection ruleTextSection = doc.CreateCDataSection(R.RuleText);
						node.AppendChild(ruleTextSection);
						RuleNode.AppendChild(node);
					}

				}
				doc.AppendChild(RuleNode);
			}
			return doc.ToString();
		}

		private string GetArrayXml(string[] p)
		{
			throw new NotImplementedException();
		}

		private string GetExamplesXml(string[] p, RuleLanguage lang)
		{
			throw new NotImplementedException();
		}

		private string GetRulesXml(RuleType ruleType, object[][] p)
		{
			throw new NotImplementedException();
		}

		private string EnumText(object o)
		{
			return o.ToString();
		}

		public string ToJSON(bool withExamples, RuleLanguage lang, string langCode)
		{
			bool compact = true;

			Rule[] Rules = Manager.Rules();

			StringBuilder sb = new StringBuilder();
			sb.AppendLine("[");
			foreach (Rule R in Rules)
			{

				sb.Append("{");

				sb.Append(AddString("identifier", R.Identifier));

				sb.Append(AddString("name", GetName(R.Name, lang)));


				sb.Append(AddInt("lines", R.Lines));
				sb.Append(AddInt("threshold", R.Threshold));

				if (R.DeferThresold)
				{
					sb.Append(AddBool("deferThresold", R.DeferThresold));
				}

				sb.Append(AddEnum("padyamType", R.PadyamType));
				sb.Append(AddEnum("padyamSubType", R.PadyamSubType));
				sb.Append(AddEnum("ruleType", R.RuleType));
				sb.Append(AddRules("rules", R.RuleType, R.Rules));


				sb.Append(AddBool("prasa", R.Prasa));
				sb.Append(AddBool("prasaYati", R.PrasaYati));
				sb.Append(AddBool("onlyPrasaYati", R.OnlyPrasaYati));
				sb.Append(AddBool("anthyaPrasa", R.AnthyaPrasa));



				if (lang == RuleLanguage.Kannada)
				{
					//TODO...
				}
				else
				{

					sb.Append(AddEnum("yatiMode", R.YatiMode));
					sb.Append(AddBool("yatiRecycle", R.YatiRecycle));
					sb.Append(AddBool("reverseYati", R.ReverseYati));
					sb.Append(AddYati("yati", R.Yati));
				}

				sb.Append(AddEnum("frequency", R.Frequency));
				sb.Append(AddBool("infiniteLength", R.InfiniteLength));
				sb.Append(AddEnum("language", lang));//


				if (withExamples)
				{
					sb.Append(AddStringArray("examples", GetStrings(R.Examples, lang)));
				}

				if (lang != RuleLanguage.Kannada)
				{
					sb.Append(AddStringArray("references", R.References));
					if (compact)
					{
						sb.Append(AddString("ruleText", R.RuleText));
					}
				}

				sb.AppendLine("},");
			}

			sb.AppendLine("]");
			return sb.ToString();
		}

		public string OnlySamplesJSON(RuleLanguage lang, string langCode)
		{
			Rule[] Rules = Manager.Rules();
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("{");
			foreach (Rule R in Rules)
			{
				if (R.Examples == null || R.Examples.Length == 0)
				{
					continue;
				}
				sb.Append(AddStringArray(R.Identifier, GetStrings(R.Examples, lang)));
				sb.AppendLine("");
			}
			sb.AppendLine("}");
			return sb.ToString();
		}

		private string GetName(string nm, RuleLanguage lang)
		{
			switch (lang)
			{
				case RuleLanguage.Kannada:
					return Converter.Convert(nm, Language.Telugu, Language.Kannada);
				default:
					return nm;
			}
		}

		private string[] GetStrings(string[] arr, RuleLanguage lang)
		{
			switch (lang)
			{
				default:
				case RuleLanguage.Telugu:
					return arr;
				case RuleLanguage.Kannada:
					List<string> L = new List<string>();
					foreach (string s in arr)
					{
						L.Add(Converter.Convert(s, Language.Telugu, Language.Kannada));
					}
					return L.ToArray();
			}

		}
		private string AddEnum(string name, RuleLanguage val)
		{
			return name + ":" + (int)val + ",";
		}

		private string AddEnum(string name, YatiMode val)
		{
			return name + ":" + (int)val + ",";
		}

		private string AddEnum(string name, RuleType val)
		{
			return name + ":" + (int)val + ",";
		}

		private string AddEnum(string name, PadyamType val)
		{
			return name + ":" + (int)val + ",";
		}

		private string AddEnum(string name, PadyamSubType val)
		{
			return name + ":" + (int)val + ",";
		}

		private string AddEnum(string name, Frequency val)
		{
			return name + ":" + (int)val + ",";
		}

		private string AddYati(string name, int[][] val)
		{
			return name + ":" + YatiArrayArray(val);
		}

		private string AddRules(string name, RuleType rt, object[][] val)
		{
			switch (rt)
			{
				case RuleType.Name:
					return name + ":" + StringArrayArray(val);
				case RuleType.Type:
					return name + ":" + TypeArrayArray(val);
				case RuleType.Weight:
					return name + ":" + WeightArrayArray(val);
				case RuleType.SubType:
					return name + ":" + SubTypewArrayArray(val);
			}
			return "";
		}

		private string SubTypewArrayArray(object[][] val)
		{
			string s = "[";
			foreach (object[] row in val)
			{
				s = s + "[";
				foreach (object c in row)
				{
					s = s + (int)((SubCategory)c) + ",";
				}
				s = s + "],";
			}
			s = s + "],";
			return s.Replace(",],],", "]],").Replace(",],", "],");
		}

		private string WeightArrayArray(object[][] p)
		{
			string s = "[";
			foreach (object[] row in p)
			{
				s = s + "[";
				foreach (object c in row)
				{
					s = s + c.ToString() + ",";
				}
				s = s + "],";
			}
			s = s + "],";
			return s.Replace(",],],", "]],").Replace(",],", "],");
		}

		private string StringArrayArray(object[][] val)
		{
			string s = "[";
			foreach (object[] row in val)
			{
				s = s + "[";
				foreach (object c in row)
				{
					s = s + "\"" + c.ToString() + "\",";
				}
				s = s + "],";
			}
			s = s + "],";
			return s.Replace(",],],", "]],").Replace(",],", "],");
		}

		private string TypeArrayArray(object[][] val)
		{
			string s = "[";
			foreach (object[] row in val)
			{
				s = s + "[";
				foreach (object c in row)
				{
					s = s + (int)((Category)c) + ",";
				}
				s = s + "],";
			}
			s = s + "],";
			return s.Replace(",],],", "]],").Replace(",],", "],");
		}

		private string AddStringArray(string name, string[] val)
		{
			if (val == null || val.Length == 0)
			{
				return "";
			}

			StringBuilder sb = new StringBuilder();
			sb.Append(name + ":[");
			foreach (string s in val)
			{
				sb.Append("\"" + s.Replace("\"", "\\" + "\"").Replace("\n", "\\n") + "\",");
			}
			sb.Append("],");
			return sb.ToString().Replace(",],]", "]],").Replace(",],", "],");
		}

		public string AddStringArray2(string name, string[] val)
		{
			if (val == null || val.Length == 0)
			{
				return "";
			}

			StringBuilder sb = new StringBuilder();
			sb.Append(name + "=[");
			foreach (string s in val)
			{
				sb.Append("\"" + s.Replace("\"", "\\" + "\"").Replace("\n", "\\n") + "\",");
			}
			sb.Append("],");
			return sb.ToString().Replace(",],]", "]],").Replace(",],", "]") + ";";
		}

		private string AddString(string name, string val)
		{
			if (val == null)
			{
				return "";
			}
			return name + ":\"" + val.ToString().Replace("\"", "\\" + "\"").Replace("\n", "\\n") + "\",";
		}

		private string AddBool(string name, bool val)
		{
			if (!val)
			{
				return "";
			}
			return name + ":" + (val ? "true" : "false") + ",";
		}

		private string AddInt(string name, int val)
		{
			return name + ":" + val + ",";
		}

		public string YatiArrayArray(int[][] val)
		{
			string s = "[";
			foreach (int[] row in val)
			{
				s = s + "[";
				foreach (int c in row)
				{
					s = s + c.ToString() + ",";
				}
				s = s + "],";
			}
			s = s + "],";
			return s.Replace(",],],", "]],").Replace(",],", "],");
		}


	}
	public class PackingHelper
	{
		public static void Pack(string root, string toFile, string[] fromFiles, string license)
		{
			Console.WriteLine("Packing..." + toFile);
			StreamWriter sw = new StreamWriter(root + toFile, false, Encoding.UTF8);
			sw.Write(license);
			foreach (string f in fromFiles)
			{
				sw.WriteLine(File.ReadAllText(root + f));
			}
			sw.Close();
		}
	}
	public class APIBuilder
	{
		string version;
		string root;

		public APIBuilder(string root, string version)
		{
			this.version = version;
			this.root = root;
		}

		public void Go(bool withExamples, RuleLanguage lang, string langCode)
		{

			StringBuilder sb = new StringBuilder();

			sb.AppendLine("var ChandamAPI={};");
			sb.AppendLine("ChandamAPI.Version = '" + version + "';");

			sb.AppendLine("var Config = {};");
			sb.AppendLine("Config.Mode = 0;");
			sb.AppendLine("Config.Language = " + (int)lang + ";");


			sb.AppendLine("Config.ExternalRules=" + new ExportRules().ToJSON(false, lang, langCode));

			if (withExamples)
			{
				sb.AppendLine("Config.ExternalExamples=" + new ExportRules().OnlySamplesJSON(lang, langCode));
				sb.AppendLine(new ExportRules().AddStringArray2("Config.Samples", new MyFavPoems().Poems));
			}


			string s = sb.ToString().Replace(",},", "},");

			string fileName = (withExamples ? "config." + langCode + ".examples.js" : "config." + langCode + ".js");
			File.WriteAllText(root + fileName, s, Encoding.UTF8);
		}
	}
}
