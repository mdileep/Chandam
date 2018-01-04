//---------------------------------------------------------------------------------------------
// <copyright file="Chandassu.cs" company="Chandam-ఛందం">
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
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;


namespace Verifier
{
	public class Chandassu
	{
		public Dictionary<string, V2R> Dict = new Dictionary<string, V2R>();

		public void Analysis()
		{
			List<Rule> Rules = FindCandidates();
			Eval(Rules);
			Dump(Rules.Count);
		}
		private void Eval(List<Rule> Rules)
		{
			Eval(Rules, Mode.OnlySurya);
			Eval(Rules, Mode.OnlyIndra);
			Eval(Rules, Mode.SuryaIndra);
			Eval(Rules, Mode.IndraSurya);
			Eval(Rules, Mode.Any);
		}
		private void Eval(List<Rule> Rules, Mode mode)
		{
			#region Init..
			string curr = "";
			string ns = "";
			string gs = "";
			string lastSeq = "";
			int len = 0;
			bool found = false;
			#endregion
			foreach (Rule R in Rules)
			{
				#region Init..
				string seq = R.Sequence.Replace("-", "");
				curr = "";
				ns = "";
				gs = "";
				len = 0;
				lastSeq = "";
				found = false;
				#endregion

				for (int i = 0; i < seq.Length; i++)
				{
					curr = curr + seq[i];
					Category gType = GDefinition.GetType(curr);
					found = CanFound(seq, mode, ref gType, ref i, ref curr);
					if (found)
					{
						lastSeq = curr;
						ns = ns + curr + "-";
						gs = gs + gType.ToString() + "-";
						len = len + curr.Length;
						curr = "";
					}

				}

				if (!found)
				{
					Category gType2 = GDefinition.GetType(lastSeq + curr);
					if (gType2 == Category.Surya || gType2 == Category.Indra)
					{
						ns = ns.TrimEnd('-').TrimStart('-') + curr;
						int li = gs.TrimEnd('-').TrimStart('-').LastIndexOf('-');
						gs = li == -1 ? gType2.ToString() : gs.Substring(0, li) + gType2.ToString();
						len = len + curr.Length;
					}
				}

				#region Wrap
				ns = ns.TrimEnd('-').TrimStart('-');
				gs = gs.TrimEnd('-').TrimStart('-');
				if (!string.IsNullOrEmpty(ns) && !string.IsNullOrEmpty(gs) && len == seq.Length)
				{
					if (Dict.ContainsKey(R.Identifier))
					{
						V2R V = Dict[R.Identifier];
						if (!V.Sequences.Contains(ns))
						{
							V.Mode.Add(mode);
							V.Sequences.Add(ns);
							V.GSequences.Add(gs);
							Dict[R.Identifier] = V;
						}
					}
					else
					{
						V2R V = new V2R();
						V.Rule = R;
						V.Mode.Add(mode);
						V.Sequences.Add(ns);
						V.GSequences.Add(gs);
						Dict[R.Identifier] = V;
					}
				}
				#endregion
			}
		}
		private bool CanFound(string seq, Mode mode, ref Category gType, ref int i, ref string curr)
		{
			bool found = false;
			switch (mode)
			{
				case Mode.SuryaIndra:
					if (gType == Category.Indra || gType == Category.Surya)
					{
						found = true;
					}
					break;
				case Mode.OnlyIndra:
					if (gType == Category.Indra)
					{
						found = true;
					}
					break;
				case Mode.OnlySurya:
					if (gType == Category.Surya)
					{
						found = true;
					}
					break;
				case Mode.IndraSurya:
					if (gType == Category.Surya && i + 1 < seq.Length)
					{
						curr = curr + seq[i + 1];
						gType = GDefinition.GetType(curr);
						i++;
						found = true;
					}
					else if (gType == Category.Indra || gType == Category.Surya)
					{
						found = true;
					}
					break;
				case Mode.Any:
					//Surya: UI  III
					//Indra: Surya+I,Surya+U
					//Indra: UUI,IIUI
					if (gType == Category.Surya && i + 1 < seq.Length)
					{
						curr = curr + seq[i + 1];
						gType = GDefinition.GetType(curr);
						i++;
						found = true;
					}
					else if (gType == Category.Indra)
					{
						found = true;
					}
					break;
			}
			return found;
		}
		private void Dump(int tot)
		{
			StreamWriter SW = new StreamWriter("Vruttas2Jati.txt", false, Encoding.UTF8);

			SW.WriteLine("<Total Vrutta's Considered :" + tot + ">");
			SW.WriteLine("<Total Vrutta's Found which can be translated as  Jati :" + Dict.Count + ">");
			SW.WriteLine("Percentage :" + ((Dict.Count * 100) / tot).ToString("0.0"));
			SW.WriteLine("");


			int cnt = 1;
			foreach (KeyValuePair<string, V2R> KVP in Dict)
			{
				V2R V = KVP.Value;
				Rule R = V.Rule;
				SW.WriteLine((cnt++) + " " + R.Name + " : [" + R.ChandamName + (R.ChandamNumber > 0 ? "(" + R.CharLength + ")" : "") + " " + R.Identifier + "] >> " + R.Sequence);
				for (int i = 0; i < V.Sequences.Count; i++)
				{
					SW.WriteLine("\t" + V.Mode[i] + " >> " + V.Sequences[i] + " >> " + V.GSequences[i]);
				}
				SW.WriteLine(" ");
			}

			SW.Close();
		}
		private List<Rule> FindCandidates()
		{
			List<Rule> Rules = new List<Rule>();
			Rule[] TelRules = Manager.Rules();
			Rule[] SansRules = RuleHelper.GetSanRules();
			foreach (Rule R in TelRules)
			{
				if (R.PadyamType == PadyamType.Vruttam && !R.RowWiseRules)
				{
					Rules.Add(R);
				}
			}
			foreach (Rule R in SansRules)
			{
				if (R.PadyamType == PadyamType.Vruttam && !R.RowWiseRules)
				{
					Rules.Add(R);
				}
			}
			Rules.Sort(delegate (Rule a, Rule b)
			{
				//return a.ChandamNumber.CompareTo(b.ChandamNumber);
				return a.ChandamOrder.CompareTo(b.ChandamOrder);
			});
			return Rules;
		}

		public void BuildNotes()
		{
			string toFile = "Vruttas2Notes.txt";
			List<Rule> Rules = FindCandidates();
			BuildNotes(Rules, toFile);
			new MidiGerator().Go(toFile);
		}

		private void BuildNotes(List<Rule> Rules, string toFile)
		{
			StreamWriter SW = new StreamWriter(toFile, false, Encoding.UTF8);
			SW.WriteLine(Join("Chandam Name",
								"Chandam Number",
								"Notes Order",
								"Identifier",
								"Name",
								"Sequence",
								"Notes Sequence"));

			foreach (Rule R in Rules)
			{
				if (R.NotesSequence == "")
				{
					continue;
				}
				SW.WriteLine(Join(
									R.CharLength.ToString().PadLeft(2) + " " + R.ChandamName,
									R.ChandamNumber,
									R.ChandamOrder - 1,
									R.Identifier,
									R.ShortName,
									R.Sequence,
									R.NotesSequence));
			}
			SW.Close();

		}


		public string Join(params object[] arr)
		{
			string s = "";
			foreach (object a in arr)
			{
				s = s + a.ToString() + ",";
			}
			return s.TrimEnd(',');
		}


		private static List<UInt64> GetSepta(decimal n, int c)
		{
			return GetNumbered(n, c, (decimal)7.0);
		}

		private static List<UInt64> GetNumbered(decimal n, int c, decimal x)
		{
			UInt64 remainder = 0;
			decimal remaining = n;
			List<UInt64> Binary = new List<UInt64>();
			while (remaining != 0)
			{
				remainder = (UInt64)remaining % (UInt64)x;
				remaining = (UInt64)Math.Floor(remaining / x);
				Binary.Add(remainder);
			}

			if (Binary.Count < c)
			{
				//Filler
				while (Binary.Count != c)
				{
					Binary.Add(0);
				}
			}
			return Binary;
		}
		[DllImport("kernel32.dll", SetLastError = true)]
		static extern bool Beep(uint dwFreq, uint dwDuration);

	}

	public class V2R
	{
		public V2R()
		{
			Sequences = new List<string>();
			GSequences = new List<string>();
			Mode = new List<Mode>();
		}
		public Rule Rule { get; set; }
		public List<string> Sequences { get; set; }
		public List<string> GSequences { get; set; }
		public List<Mode> Mode { get; set; }
		public string Actual { get; set; }
	}

	public enum Mode
	{
		OnlyIndra,
		OnlySurya,
		SuryaIndra,
		IndraSurya,
		Any,
	}
}




//private void Eval2(List<Rule> Rules)
//{
//	foreach (Rule R in Rules)
//	{
//		string seq = R.Sequence.Replace("-", "");
//		List<string> All = new List<string>();
//		List<bool> Route = new List<bool>();
//		for (int i = 0; i < seq.Length; i++)
//		{
//			//2,3,4
//			//Surya: UI  III
//			//Indra: Surya+I,Surya+U
//			//Indra: UUI,IIUI

//			//UIU III UIU III UIU III UIU IIIU-25
//			//UIUIIIUIUIIIUIUIIIUIUIIIU
//			//UIU I IIUI UI IIUI UI IIUI UI IIU
//			//25-2+2+
//		}
//	}
//}

