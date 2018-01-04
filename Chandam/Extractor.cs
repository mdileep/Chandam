//---------------------------------------------------------------------------------------------
// <copyright file="Extractor.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:38EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using Library.Chandam.Samples;
using System;
using System.Collections.Generic;
using System.IO;

namespace Chandam
{
	public class Extractor
	{
		public Dictionary<string, string> Map;
		public Dictionary<string, string> Dict;
		public MatchOptions Options;
		public OutputOptions OO;
		public List<Rule> Rules;
		public string Data;
		public string Output;
		public bool KnownChandam;

		public Extractor(string file)
		{
			Dict = new Dictionary<string, string>();
			Map = new Dictionary<string, string>();
			Dict = BuildDictionary(file);
			Map = BuildDictionary(DictValue("Map"));


			Data = DictValue("Input");
			BuildOO();
			BuildOptions();


			KnownChandam = Fetch("KnownChandam", "1");


			Output = DictValue("Output");

			if (Output == "")
			{
				FileInfo FI = new FileInfo(Data);
				Output = FI.FullName + ".htm";
			}


			FileInfo FO = new FileInfo(Output);
			if (!FO.Directory.Exists)
			{
				FO.Directory.Create();
			}

			Console.WriteLine("Output file set to " + FO.FullName);
		}

		private void BuildOO()
		{
			OO = new OutputOptions();
			OO.UseFullName = Fetch("FullName", "1");
			OO.ErrorsOnly = Fetch("ErrorsOnly", "1");
			OO.EmbedValue = StyleSheet.Value;
			BuildRules();
			OO.Rules = Rules;
		}

		private Dictionary<string, string> BuildDictionary(string file)
		{
			Dictionary<string, string> X = new Dictionary<string, string>();
			string[] Lines = new string[] { };
			try
			{
				FileInfo FI = new FileInfo(file);
				if (!FI.Exists)
				{
					Console.WriteLine("Skipping as not found-" + FI.FullName);
					return X;
				}
				Console.WriteLine("Processing file: " + FI.FullName);
				Lines = File.ReadAllLines(FI.FullName);
			}
			catch
			{
				Console.WriteLine("Skipping as file not found-" + file);
			}





			foreach (string Line in Lines)
			{
				if (Line == null)
				{
					continue;
				}
				if (Line.StartsWith("#"))
				{
					continue;
				}
				if (!Line.Contains("="))
				{
					continue;
				}

				string[] KV = Line.Split('=');
				if (KV.Length < 2)
				{
					continue;
				}
				if (!X.ContainsKey(KV[0].ToUpper()))
				{
					X.Add(KV[0].ToUpper(), KV[1]);
				}
			}
			return X;
		}

		private void BuildRules()
		{

			Rules = new List<Rule>();

			string rules = DictValue("Rules");
			if (rules.ToUpper() == "ALL")
			{
				return;
			}

			foreach (string rule in rules.Split(','))
			{
				if (rule.Trim() == "")
				{
					continue;
				}
				Rule X = Manager.FetchRule(rule);
				if (X != null)
				{
					Rules.Add(X);
				}
			}

		}

		private void BuildOptions()
		{
			Options = new MatchOptions();
			Options.IncludeRare = true;
			Options.Language = RuleLanguage.Telugu;

			Options.AllowSantiPrasa = Fetch("SantiPrasa", "1");
			Options.ExperimenatalSandhi = Fetch("SoundexSandhi", "1");
			Options.MatchPrasa = Fetch("MatchPrasa", "1");
			Options.MatchYati = Fetch("MatchYati", "1");
			Options.QuickMatch = Fetch("QuickMatch", "1");

		}

		private bool Fetch(string Key, string val)
		{
			if (DictValue(Key) == val)
			{
				return true;
			}

			return false;
		}

		private string MapValue(string Key)
		{
			if (Map.ContainsKey(Key))
			{
				return (Map[Key]);
			}
			return "";
		}

		private string DictValue(string Key)
		{
			if (Dict.ContainsKey(Key.ToUpper()))
			{
				return (Dict[Key.ToUpper()]);
			}
			return "";
		}

		public SatakamData Extract()
		{
			string[] Lines = File.ReadAllLines(Data);

			List<string> Header = new List<string>();
			List<string> Footer = new List<string>();

			SatakamData S = new SatakamData();
			List<Poem> Poems = new List<Poem>();

			Poem Curr = new Poem { Text = "", Identifier = null };
			for (int i = 0; i < Lines.Length; i++)
			{
				string line = Lines[i];

				if (line.StartsWith("#"))
				{
					continue;
				}

				if (line.Trim().Replace("\t", "") == "")
				{
					Curr.Text = Curr.Text.Trim('\n');
					Poems.Add(Curr);
					Curr = new Poem();
					Curr.Text = "";
					Curr.Identifier = null;
					continue;
				}

				if (KnownChandam && Curr.Identifier == null)
				{
					int space = line.IndexOf(" ");
					int tab = line.IndexOf("\t");
					int min = -1;
					if (space == -1 && tab == -1)
					{
						Curr.Identifier = MapValue(line);
					}
					else
					{
						if (space == -1 || tab == -1)
						{
							min = Math.Max(space, tab);
						}
						else
						{
							min = Math.Min(space, tab);
						}
					}

					if (min != -1)
					{
						Curr.Identifier = MapValue(line.Substring(0, min));
						Curr.Text = line.Substring(min + 1);
						continue;
					}
					else
					{
						Curr.Identifier = MapValue(line.Trim());
						continue;
					}
				}

				if (Curr.Text == "")
				{
					Curr.Text = line;
				}
				else
				{
					Curr.Text = Curr.Text + "\n" + line;
				}
			}

			S.Title = DictValue("Title");
			S.Title = S.Title.Trim() == "" ? "ఛందం ©  ఫలితాలు" : S.Title;

			S.Header = new List<string>() { DictValue("Author") };
			S.Footer = new List<string>() { "ఛందం <sup>©</sup> తో పద్య సాహిత్యం మరింత రసమయం..!!", "Courtesy: http://chandam.apphb.com" };

			S.Poems = Poems;
			return S;
		}



	}
}
