//---------------------------------------------------------------------------------------------
// <copyright file="Vruttam2Jati.cs" company="Chandam-ఛందం">
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
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Verifier
{
	class Vruttam2Jati
	{
		string _input;
		int[] items = new int[] { 2, 3, 4 };
		List<string> Patterns = new List<string>();
		Dictionary<string, VJ> Dict = new Dictionary<string, VJ>();
		Dictionary<string, VJ> Dict2 = new Dictionary<string, VJ>();
		public void Go()
		{
			List<Rule> Rules = FindCandidates();
			foreach (Rule R in Rules)
			{
				string seq = R.Sequence.Replace("-", "");
				Go(seq);
				if (Patterns.Count > 0)
				{
					Dict[R.Identifier] = new VJ { Rule = R, List = Patterns };
				}
				else
				{
					Dict2[R.Identifier] = new VJ { Rule = R, List = Patterns };
				}
			}
			Dump(Rules.Count);
			Dump2();
			Dump3();
		}

		private void Dump3()
		{
			StreamWriter SW = new StreamWriter("Vruttas2Jati2_Kannada_Not.txt", false, Encoding.UTF8);
			int cnt = 1;
			SW.WriteLine("S.No~Chandam Name~Chandam No.~Vruttam No~Name~Alias~Identifier~Raw Sequence~Jati Sequence~Jati Explained~Total Sequences Available");
			foreach (KeyValuePair<string, VJ> KVP in Dict2)
			{
				VJ V = KVP.Value;
				Rule R = V.Rule;

				string g = V.List.Count > 0 ? GetSequenceName(V.List[0]) : "";
				string s1 = V.List.Count > 0 ? V.List[0] : "";
				string s = (cnt++) + "~" + R.ChandamName + "~" + R.CharLength + "~" + R.ChandamNumber + "~" + R.ShortName + "~" + R.Alias + " ~ " + R.Identifier + " ~ " + R.Sequence + "~" + s1 + "~" + g + "~" + V.List.Count;
				SW.WriteLine(s);
			}
			SW.Close();

		}

		private void Dump2()
		{
			StreamWriter SW = new StreamWriter("Vruttas2Jati2_Kannada.txt", false, Encoding.UTF8);
			int cnt = 1;
			SW.WriteLine("S.No~Chandam Name~Chandam No.~Vruttam No~Name~Alias~Identifier~Raw Sequence~Jati Sequence~Jati Explained~Total Sequences Available");
			foreach (KeyValuePair<string, VJ> KVP in Dict)
			{
				VJ V = KVP.Value;
				Rule R = V.Rule;

				string g = V.List.Count > 0 ? GetSequenceName(V.List[0]) : "";
				string s1 = V.List.Count > 0 ? V.List[0] : "";
				string s = (cnt++) + "~" + R.ChandamName + "~" + R.CharLength + "~" + R.ChandamNumber + "~" + R.ShortName + "~" + R.Alias + " ~ " + R.Identifier + " ~ " + R.Sequence + "~" + s1 + "~" + g + "~" + V.List.Count;
				SW.WriteLine(s);
			}
			SW.Close();
		}
		private void Dump(int tot)
		{
			StreamWriter SW = new StreamWriter("Vruttas2Jati_Kannada.txt", false, Encoding.UTF8);

			SW.WriteLine("<Total Vrutta's Considered :" + tot + ">");
			SW.WriteLine("<Total Vrutta's Found which can be translated as  Jati :" + Dict.Count + ">");
			SW.WriteLine("Percentage :" + ((Dict.Count * 100) / tot).ToString("0.0"));
			SW.WriteLine("");


			int cnt = 1;
			string prev = "";

			foreach (KeyValuePair<string, VJ> KVP in Dict)
			{
				VJ V = KVP.Value;
				Rule R = V.Rule;

				string curr = "<<" + R.ChandamName + (R.ChandamNumber > 0 ? "(" + R.CharLength + ")" : " ") + ">>";

				if (prev != curr)
				{
					SW.WriteLine(curr);
					SW.WriteLine("");
				}
				SW.WriteLine((cnt++) + " " + R.Name + " : [" + R.Identifier + "] >> " + R.Sequence);
				for (int i = 0; i < V.List.Count; i++)
				{
					string g = GetSequenceName(V.List[i]);
					SW.WriteLine("\t" + (i + 1) + "." + " " + V.List[i] + " >> " + g);
				}

				prev = curr;
				SW.WriteLine(" ");
			}

			SW.Close();
		}
		private string GetSequenceName(string seq)
		{
			string g = "";
			foreach (string s in seq.Split('-'))
			{
				Category2 gType = GDefinition.GetType2(s);
				g = (g + "-" + gType.ToString());
			}
			return g.TrimStart('-').TrimEnd('-');
		}
		private List<Rule> FindCandidates()
		{
			List<Rule> Rules = new List<Rule>();
			Rule[] TelRules = Manager.Rules();
			Rule[] SansRules = RuleHelper.GetSanRules();
			foreach (Rule R in TelRules)
			{
				if (R.PadyamType == PadyamType.Vruttam && !R.RowWiseRules && !R.InfiniteLength && PadyamSubType.DaMDakamu != R.PadyamSubType)
				{
					Rules.Add(R);
				}
			}
			foreach (Rule R in SansRules)
			{
				if (R.PadyamType == PadyamType.Vruttam && !R.RowWiseRules && !R.InfiniteLength && PadyamSubType.DaMDakamu != R.PadyamSubType)
				{
					Rules.Add(R);
				}
			}
			Rules.Sort(delegate (Rule a, Rule b)
			{
				return a.CharLength.CompareTo(b.CharLength);
			});
			return Rules;
		}
		private void Go(string input)
		{
			_input = input;
			Patterns = new List<string>();
			Go(0, "");
		}
		private void Go(int pos, string preFix)
		{
			foreach (int item in items)
			{
				string s = SubString(_input, pos, item);

				if (s == "")
				{
					if (preFix.Replace("-", "").Length == _input.Length && !Patterns.Contains(preFix))
					{
						Patterns.Add(preFix);
						Debug.WriteLine(preFix);
					}
				}
				else
				{
					Category2 gType = GDefinition.GetType2(s);
					//if (gType == Category.Indra || gType == Category.Surya)
					if (gType == Category2.Brahma || gType == Category2.Vishnu)
					{
						string next = Next(preFix, s);
						Go(pos + item, next);
					}
				}
			}
		}
		private string Next(string preFix, string s)
		{
			return preFix != "" ? (preFix + "-" + s) : s;
		}
		private string SubString(string input, int pos, int l)
		{
			if (pos + l > input.Length)
			{
				return "";
			}
			return input.Substring(pos, l);
		}
	}
	class VJ
	{
		public Rule Rule;
		public List<string> List;
	}
}
