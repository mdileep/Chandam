//---------------------------------------------------------------------------------------------
// <copyright file="Sans.cs" company="Chandam-ఛందం">
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
using MiriyamApp;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Verifier
{
	public class Sans
	{
		public void Go()
		{
			List<Chandam> TelList = Read2();
			List<Rule> TelRules = ToRules2(TelList);
			BuildCheatSheet(TelRules, "TelCheatSheet.html");

			List<Chandam> SansList = Read();
			List<Rule> SansRules = ToRules(SansList);
			BuildCheatSheet(SansRules, "SansCheatSheet.html");

			List<Rule> Rules = new List<Rule>();
			Rules.AddRange(TelRules);
			Rules.AddRange(SansRules);

			BuildCheatSheet(Rules, "TelSansCheatSheet.html");

			IdentifyDuplicates(Rules);

			CodeIt(SansRules, "SansCodeIt.txt");
			CodeIt(TelRules, "TelCodeIt.txt");

		}

		private List<Rule> ToRules2(List<Chandam> L)
		{
			List<Rule> Rules = new List<Rule>();
			foreach (Chandam C in L)
			{
				Rule R = new Rule();
				R.AnthyaPrasa = false;
				R.DeferThresold = false;
				R.Examples = new string[] { };
				R.Frequency = Frequency.Rare;
				R.Language = RuleLanguage.Telugu;

				R.Identifier = C.EngTitle;
				R.InfiniteLength = false;
				R.Lines = C.Lines;
				R.Name = C.TelTitle;

				R.OnlyPrasaYati = false;
				R.PadyamSubType = FindSubType(C.RuleType);
				R.PadyamType = PadyamType.Vruttam;

				R.Prasa = true;
				R.PrasaYati = false;
				R.References = new string[] { };
				//R.ReverseYati = false;

				if (FindRowWiseRules(C.RuleType))
				{
					R.Rules = new object[C.LineRules.Count][];
					int cnt = 0;
					foreach (LineRule LR in C.LineRules)
					{
						R.Rules[cnt] = C.LineRules[cnt].Sequence.Split(',');
						cnt++;
					}

				}
				else
				{
					R.Rules = new string[][] { C.LineRules[0].Sequence.Split(',') };

				}
				//R.RuleText = "";
				R.RuleType = RuleType.Name;
				//R.ShortName = C.TelTitle;
				R.Threshold = 3;
				R.Yati = new int[][] { ToIntArray(C.Yati) };
				R.YatiMode = YatiMode.CharPosition;
				//R.YatiRecycle = false;
				R.References = C.New == "" ? new string[] { } : new string[] { C.New };
				Rules.Add(R);
			}
			return Rules;
		}

		private int[] ToIntArray(string p)
		{
			if (p.Length == 0)
			{
				return new int[] { };
			}
			List<int> h = new List<int>();
			foreach (string v in p.Split(','))
			{
				h.Add(int.Parse(v));
			}

			return h.ToArray();
		}


		private List<Chandam> Read2()
		{
			List<Chandam> L = new List<Chandam>();
			string file = "Tel.txt";

			int cnt = 0;
			foreach (string line in File.ReadAllLines(file))
			{


				if (cnt == 0)
				{
					cnt++;
					continue;
				}


				string[] Cols = line.Split(';');
				//kalyaaNa;కల్యాణ;రజజరజరసరలగ;8,13,22;New

				Chandam C = new Chandam();
				C.New = Cols[4];
				C.Yati = Cols[3];
				C.EngTitle = Cols[0].Contains("(") ? Cols[0].Substring(0, Cols[0].IndexOf("(")) : Cols[0];
				C.TelTitle = Cols[1];
				C.TotSyllables = 0;
				C.Lines = 4;
				C.RuleType = "సమవృత్తం";
				C.LineRules = new List<LineRule>();
				C.LineRules.Add(new LineRule
				{
					Syllables = 0,
					Sequence = ReWrite(Cols[2])

				});
				C.LineRules.Add(new LineRule
				{
					Syllables = 0,
					Sequence = ReWrite(Cols[2])
				});
				C.LineRules.Add(new LineRule
				{
					Syllables = 0,
					Sequence = ReWrite(Cols[2])
				});
				C.LineRules.Add(new LineRule
				{
					Syllables = 0,
					Sequence = ReWrite(Cols[2])
				});


				L.Add(C);
				cnt++;
			}
			return L;
		}

		private string ReWrite(string p)
		{
			p = p.Replace("లగ", "వ").Replace("గగ", "గా").Replace("గల", "హ").Replace("లల", "లా");
			string s = "";
			foreach (char c in p)
			{
				s = s + "," + c;
			}
			s = s.TrimStart(',');
			s = s.Replace(",ా", "ా");
			return s;
		}

		private void CodeIt(List<Rule> Rules, string file)
		{
			using (StreamWriter sw = new StreamWriter(file))
			{
				foreach (Rule R in Rules)
				{
					sw.WriteLine(CSWriter.CodeIt(R));
				}
			}
		}

		private void IdentifyDuplicates(List<Rule> Rules)
		{
			Debug.WriteLine("New" + "-" + "CharLength" + "-" + "ChandamNumber" + "-" + "Old");
			foreach (Rule R in Rules)
			{
				foreach (Rule R1 in RuleHelper.GetAllRules(true))
				{
					if (R1.PadyamType != R.PadyamType || R.RowWiseRules || R1.RowWiseRules)
					{
						continue;
					}


					//if ( AreEqual ( R1.Rules , R.Rules ) )
					if (R.CharLength == R1.CharLength && R.ChandamNumber == R1.ChandamNumber)
					{
						Debug.WriteLine(R.Name + "-" + R.CharLength + "-" + R.ChandamNumber + "-" + R1.Name);
					}
				}
			}
		}

		private bool AreEqual(object[][] LR, object[][] LR1)
		{

			if (LR.Length != LR1.Length)
			{
				return false;
			}

			bool res = true;
			for (int i = 0; i < LR.Length; i++)
			{
				object[] o1 = LR[i];
				object[] o2 = LR1[i];
				res = AreEqual(o1, o2);
				if (!res)
				{
					return res;
				}

			}
			return res;
		}

		private bool AreEqual(object[] o1, object[] o2)
		{
			if (o1.Length != o2.Length)
			{
				return false;
			}
			bool res = true;
			for (int i = 0; i < o1.Length; i++)
			{
				object ox1 = o1[i];
				object ox2 = o2[i];
				res = AreEqual(ox1, ox2);
				if (!res)
				{
					return res;
				}
			}
			return res;
		}

		private bool AreEqual(object ox1, object ox2)
		{
			return (string)ox1 == (string)ox2;
		}

		private void BuildCheatSheet(List<Rule> Rules, string file)
		{
			string s = CheatSheet.BuildCheatSheet2(false, false, SortHelper.SortByCharLength(Rules));
			File.WriteAllText(file, s, Encoding.UTF8);
		}

		private List<Rule> ToRules(List<Chandam> L)
		{
			List<Rule> Rules = new List<Rule>();
			foreach (Chandam C in L)
			{
				Rule R = new Rule();
				R.AnthyaPrasa = false;
				R.DeferThresold = false;
				R.Examples = new string[] { };
				R.Frequency = Frequency.Rare;
				R.Language = RuleLanguage.Sanskrit;

				R.Identifier = C.EngTitle;
				R.InfiniteLength = false;
				R.Lines = C.Lines;
				R.Name = C.TelTitle;

				R.OnlyPrasaYati = false;
				R.PadyamSubType = FindSubType(C.RuleType);
				R.PadyamType = PadyamType.Vruttam;

				R.Prasa = true;
				R.PrasaYati = false;
				R.References = new string[] { };
				//R.ReverseYati = false;

				if (FindRowWiseRules(C.RuleType))
				{
					R.Rules = new object[C.LineRules.Count][];
					int cnt = 0;
					foreach (LineRule LR in C.LineRules)
					{
						R.Rules[cnt] = C.LineRules[cnt].Sequence.Split(',');
						cnt++;
					}

				}
				else
				{
					R.Rules = new string[][] { C.LineRules[0].Sequence.Split(',') };

				}
				//R.RuleText = "";
				R.RuleType = RuleType.Name;
				//R.ShortName = C.TelTitle;
				R.Threshold = 3;
				R.Yati = new int[][] { };
				R.YatiMode = YatiMode.CharPosition;
				//R.YatiRecycle = false;
				Rules.Add(R);
			}
			return Rules;
		}

		private bool FindRowWiseRules(string p)
		{
			switch (p)
			{
				case "సమవృత్తం":
					return false;
				case "అర్ధ సమవృత్తం":
				case "విషమ వృత్తం":
					return true;
			}
			return true;
		}

		private PadyamSubType FindSubType(string p)
		{
			switch (p)
			{
				case "సమవృత్తం":
					return PadyamSubType.Vruttam;
				case "అర్ధ సమవృత్తం":
					return PadyamSubType.ArdhaVruttam;
				case "విషమ వృత్తం":
					return PadyamSubType.VishamaVruttam;
			}
			return PadyamSubType.Other;
		}

		private List<Chandam> Read()
		{
			List<Chandam> L = new List<Chandam>();
			string file = "Sans2.txt";

			int cnt = 0;
			foreach (string line in File.ReadAllLines(file))
			{


				if (cnt == 0)
				{
					cnt++;
					continue;
				}


				string[] Cols = line.Split(',');
				//English,DevNagari,Telugu
				//Total Syllables,Lines,Type
				//Syllables ,Sequence

				Chandam C = new Chandam();
				C.EngTitle = Cols[0];
				//C.DevTile = Cols[1];
				C.TelTitle = Cols[2];


				C.TotSyllables = int.Parse(Cols[3]);
				C.Lines = int.Parse(Cols[4]);
				C.RuleType = Cols[5];
				C.LineRules = new List<LineRule>();
				C.LineRules.Add(new LineRule
				{
					Syllables = int.Parse(Cols[6]),
					Sequence = Helper.SequenceToGNames2(Cols[7])

				});
				C.LineRules.Add(new LineRule
				{
					Syllables = int.Parse(Cols[8]),
					Sequence = Helper.SequenceToGNames2(Cols[9])
				});
				C.LineRules.Add(new LineRule
				{
					Syllables = int.Parse(Cols[10]),
					Sequence = Helper.SequenceToGNames2(Cols[11])
				});
				C.LineRules.Add(new LineRule
				{
					Syllables = int.Parse(Cols[12]),
					Sequence = Helper.SequenceToGNames2(Cols[13])
				});

				L.Add(C);
				cnt++;
			}
			return L;
		}



	}
	public class LineRule
	{
		public int Syllables
		{
			get;
			set;
		}
		public string Sequence
		{
			get;
			set;
		}
	}

	public class Chandam
	{
		public List<LineRule> LineRules
		{
			get;
			set;
		}

		public int Lines
		{
			get;
			set;
		}
		public int TotSyllables
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}
		public string TelTitle
		{
			get;
			set;
		}
		public List<string> Items
		{
			get;
			set;
		}
		public string BaseRule
		{
			get;
			set;
		}
		public List<string> Rules
		{
			get;
			set;
		}
		public string RuleType
		{
			get;
			set;
		}

		public string EngTitle
		{
			get;
			set;
		}

		public string New
		{
			get;
			set;
		}

		public string Yati
		{
			get;
			set;
		}
	}
}

