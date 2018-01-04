//---------------------------------------------------------------------------------------------
// <copyright file="Jati2Vruttam2.cs" company="Chandam-ఛందం">
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
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Verifier
{

	class SymPattern
	{
		public string LHS;
		public string Middle;
		public string RHS;
		public int Length;
		public bool MirrorSymMatch;
		public bool SymMatch;
	}
	class Jati2Vruttam2
	{
		List<string> S1 = new List<string>() { "U|", "|||" };
		List<string> S2 = new List<string>() { "U||", "||||", "U|U", "|||U", "UU|", "||U|" };
		List<string> S3 = new List<string>() { "U" };

		public void Go3()
		{
			List<Rule> Rules = FindCandidates3();
			//List<Rule> Rules = new List<Rule>() {};


			StreamWriter sw = new StreamWriter("SymPatterns.txt", false, Encoding.UTF8);
			sw.WriteLine("Sym,Mirror Sym,Identifier,Name,Chandam Length,Chandam Name,Raw Pattern,Bridge Length,Symmetric Pattern,Symmetric Pattern2");

			foreach (Rule R in Rules)
			{
				if (R.Sequence == "")
				{
					Console.WriteLine(R.Identifier + " - Skipping");
					continue;
				}
				//if (R.CharLength < 7)
				//{
				//    continue;
				//}

				SymPattern SP = BuildSymSequences(R.Sequence.Replace("-", "").Replace("|", "I"));
				if (SP != null)
				{
					Console.WriteLine(R.Identifier + " - Symmetric Pattern Found.");

					string l = Mark(SP.LHS, 3);
					string m = SP.Middle;
					string r = Mark(SP.RHS, 3);

					string seq = l + (m == "" ? "-" : "-(" + m + ")-") + r;

					string seq2 = SP.LHS + (m == "" ? "-" : "-(" + m + ")-") + SP.RHS;

					sw.WriteLine(SP.SymMatch + "," + SP.MirrorSymMatch + "," + R.Identifier + "," + R.ShortName + "," + R.CharLength + "," + R.ChandamName + "," + R.Sequence.Replace("|", "I") + "," + SP.Length + "," + seq + "," + seq2);
				}
				else
				{
					Console.WriteLine(R.Identifier + " -No Symmetric Pattern Found.");
				}
			}
			sw.Close();
		}

		private string Mark(string seq, int threshold)
		{
			string retVal = "";
			for (int i = 0; i < seq.Length; i++)
			{
				retVal = retVal + seq[i];
				if ((i + 1) % threshold == 0 && i != seq.Length - 1)
				{
					retVal = retVal + "-";
				}
			}

			return retVal;
		}

		private SymPattern BuildSymSequences(string seq)
		{
			bool isEven = (seq.Length % 2 == 0);
			int mid = seq.Length / 2;
			int index = 0;
			bool go = true;

			while (go)
			{
				string lhs = seq.Substring(0, mid - index);
				string rhs = isEven ? seq.Substring(mid + index) : seq.Substring(mid + index + 1);
				string middle = isEven ? seq.Substring(mid - index, 2 * index) : seq.Substring(mid - index, (2 * index) + 1);


				//Debug.WriteLine(lhs.Length + " " + middle.Length + " " + rhs.Length);
				//Debug.WriteLine(lhs + "-" + middle + "-" + rhs);



				if (lhs.Length == 0 || rhs.Length == 0)
				{
					return null;
				}

				bool SymMatch = (lhs == rhs);
				bool MirrorSymMatch = (lhs == ReverseString(rhs));

				if (SymMatch || MirrorSymMatch)
				{
					SymPattern SP = new SymPattern { SymMatch = SymMatch, MirrorSymMatch = MirrorSymMatch, Length = middle.Length, LHS = lhs, RHS = rhs, Middle = middle };
					return SP;
				}

				if (index >= mid)
				{
					go = false;
				}

				if (index > 3)
				{
					go = false;
				}
				index++;
			}

			return null;
		}
		public static string ReverseString(string s)
		{
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}

		public void Go()
		{
			List<Rule> Rules2 = FindCandidates();
			List<Rule> Rules = FindCandidates2();

			DumpAll(Rules2);
			StreamWriter sw = new StreamWriter("JatiSequences.txt", false, Encoding.UTF8);
			foreach (Rule R in Rules)
			{
				Debug.WriteLine("Processing.." + R.ShortName);
				Console.WriteLine("Processing.." + R.Identifier);

				List<string> Sequences = BuildSeq(R.Rules);
				if (Sequences == null)
				{
					sw.WriteLine(R.Identifier);
					Debug.WriteLine("\tSkipping..");
					continue;
				}


				int cnt = 1;
				foreach (string seq in Sequences)
				{

					Go(seq);

					Debug.WriteLine("\t" + L.Count + " patterns found.");

					foreach (string sources in L)
					{
						string srcSeq = sources.Replace("-", "");
						sw.WriteLine(R.Identifier + "," + cnt + "," + sources);
					}


					cnt++;

				}
				sw.Flush();
			}
			sw.Close();
		}

		public void Go2()
		{
			List<Rule> Rules2 = FindCandidates();
			List<Rule> Rules = FindCandidates2();

			StreamWriter sw = new StreamWriter("Jati2Vruttam2.txt", false, Encoding.UTF8);
			foreach (Rule R in Rules)
			{
				sw.WriteLine("Processing.." + R.ShortName);
				Debug.WriteLine("Processing.." + R.ShortName);
				Console.WriteLine("Processing.." + R.Identifier);

				List<string> Sequences = BuildSeq(R.Rules);
				if (Sequences == null)
				{
					sw.WriteLine("\tSkipping..");
					Debug.WriteLine("\tSkipping..");
					continue;
				}


				int cnt = 1;
				foreach (string seq in Sequences)
				{

					Go(seq);

					bool foundMatch = false;
					Debug.WriteLine("\t" + L.Count + " patterns found.");
					foreach (string sources in L)
					{
						string srcSeq = sources.Replace("-", "");
						Debug.WriteLine("\t Matching Sequence " + srcSeq);
						foreach (Rule match in Rules2)
						{
							bool isMatched = srcSeq == match.Sequence.Replace("-", "");
							if (isMatched)
							{
								foundMatch = true;
								sw.WriteLine("\t " + match.ShortName + "(" + cnt + ")  " + match.Sequence + "  ⇒ " + sources.Replace("~", "-"));
								Debug.WriteLine(match.ShortName + " Matched.");
							}
						}
					}

					if (!foundMatch)
					{
						sw.WriteLine("\t No matches found.");
						Debug.WriteLine("\t No matches found.");
					}
					cnt++;

				}
				sw.Flush();
			}
			sw.Close();


		}
		private void Go(string patterns)
		{
			L = new List<string>();
			Processed = new List<string>();
			x = 1;
			BuildPatterns2(patterns);
		}
		private void DumpAll(List<Rule> Rules2)
		{
			StreamWriter sw = new StreamWriter("VruttamSequences.txt", false, Encoding.UTF8);

			foreach (Rule R in Rules2)
			{
				sw.WriteLine(R.Identifier + "," + 1 + "," + R.Sequence);
				sw.Flush();
			}
			sw.Close();
		}

		private List<string> BuildSeq(object[][] rules)
		{
			List<string> Sequences = new List<string>();
			foreach (object[] lineRules in rules)
			{
				string seq = "";
				foreach (object o in lineRules)
				{
					Category C = (Category)o;
					switch (C)
					{
						case Category.Surya:
							seq = seq + (seq == "" ? "0" : ("~" + "0"));
							break;

						case Category.Indra:
							seq = seq + (seq == "" ? "1" : ("~" + "1"));
							break;
						case Category.Guruvu:
							seq = seq + (seq == "" ? "2" : ("~" + "2"));
							break;
						default:

							return null;
					}
				}

				if (!Sequences.Contains(seq))
				{
					Sequences.Add(seq);
				}
			}

			return Sequences;
		}

		private List<Rule> FindCandidates3()
		{
			List<Rule> Rules = new List<Rule>();
			Rule[] TelRules = Manager.Rules();
			Rule[] SansRules = RuleHelper.GetSanRules();
			foreach (Rule R in TelRules)
			{
				Rules.Add(R);
			}

			foreach (Rule R in SansRules)
			{

				Rules.Add(R);

			}

			Rules.Sort(delegate (Rule a, Rule b)
			{
				return a.CharLength.CompareTo(b.CharLength);
			});
			return Rules;
		}
		private List<Rule> FindCandidates2()
		{
			List<Rule> Rules = new List<Rule>();
			Rule[] TelRules = Manager.Rules();
			Rule[] SansRules = RuleHelper.GetSanRules();
			foreach (Rule R in TelRules)
			{
				if (R.RuleType == RuleType.Type)
				{
					Rules.Add(R);
				}
			}

			foreach (Rule R in SansRules)
			{
				if (R.RuleType == RuleType.Type)
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
		private void BuildPatterns(string pattern)
		{
			if (Processed.Contains(pattern))
			{
				return;
			}
			Processed.Add(pattern);

			string[] groups = pattern.Split('~');
			for (int i = 0; i < groups.Length; i++)
			{
				string v = groups[i];
				if (v == "0" || v == "1" || v == "2")
				{
					List<string> target = v == "0" ? S1 : (v == "1" ? S2 : S3);
					BuildSeries(pattern, i, target);
				}
			}

		}
		private void BuildSeries(string patterns, int g, List<string> target)
		{
			foreach (string s in target)
			{
				string v = patterns;
				string[] X = v.Split('~');
				X[g] = s;
				string newPattern = string.Join("~", X);
				if (("~" + newPattern + "~").Contains("~0~") || ("~" + newPattern + "~").Contains("~1~") || ("~" + newPattern + "~").Contains("~2~"))
				{
					BuildPatterns(newPattern);
				}
				else
				{
					newPattern = newPattern.TrimStart('~');
					if (!L.Contains(newPattern))
					{
						L.Add(newPattern);
						Debug.WriteLine((x++) + " " + newPattern);
					}
				}
			}
		}
		private void BuildPatterns2(string pattern)
		{
			string[] groups = pattern.Split('~');
			BuildPatterns2("", groups);
		}
		private void BuildPatterns2(string prefix, string[] groups)
		{
			string v = groups[0];
			if (v == "0" || v == "1" || v == "2")
			{
				List<string> target = v == "0" ? S1 : (v == "1" ? S2 : S3);
				foreach (string s in target)
				{
					string newPattern = (prefix == "" ? "" : prefix + "-") + s;
					string[] r = RemoveFirst(groups);
					if (r == null)
					{
						//Debug.WriteLine((x++)+" "+newPattern);
						if (!L.Contains(newPattern))
						{
							L.Add(newPattern);
						}
						else
						{
							Debug.WriteLine("....");
						}
						continue;
					}
					BuildPatterns2(newPattern, r);
				}
			}

		}
		private string[] RemoveFirst(string[] groups)
		{
			if (groups.Length == 0 || groups.Length == 1)
			{
				return null;
			}

			string[] Output = new string[groups.Length - 1];
			for (int i = 1; i < groups.Length; i++)//i=1 not i=0;
			{

				Output[i - 1] = groups[i];
			}

			return Output;

		}

		List<string> Processed = new List<string>();
		List<string> L = new List<string>();
		int x = 1;

	}
}
