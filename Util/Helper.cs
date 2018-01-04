//---------------------------------------------------------------------------------------------
// <copyright file="Helper.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Util;
using System;
using System.Collections.Generic;

namespace Chandam.Rules
{
	public class Helper2
	{
		public static List<Rule> Clone(List<Rule> Rules)
		{
			List<Rule> L = new List<Rule>();
			foreach (Rule R in Rules)
			{
				L.Add(R.Clone());
			}
			return L;
		}
	}

	public partial class Helper
	{
		public static string GetPadyamTypeString(PadyamType ruleType, PadyamSubType subType)
		{
			switch (ruleType)
			{
				case PadyamType.Jati:
					switch (subType)
					{
						case PadyamSubType.Akkara:
							return "జాతి(అక్కరలు)";
						case PadyamSubType.Divpada:
							return "జాతి(ద్విపదలు)";
						case PadyamSubType.Shatpada:
							return "జాతి(షట్పదలు)";
						case PadyamSubType.Ragada:
						case PadyamSubType.Ragada2:
							return "జాతి(రగడలు)";
						default:
							return "జాతి";
					}

				case PadyamType.UpaJati:
					switch (subType)
					{
						case PadyamSubType.Sisamu:
							return "ఉపజాతి(సీసములు)";
						default:
							return "ఉపజాతి";
					}

				case PadyamType.Vruttam:
					switch (subType)
					{
						case PadyamSubType.VishamaVruttam:
							return "విషమవృత్తం";
						case PadyamSubType.ArdhaVruttam:
							return "అర్ధ సమవృత్తం";
						case PadyamSubType.DaMDakamu:
							return "దండకము";
						default:
							return "వృత్తం";
					}
				default:
					return "తెలియదు";
			}
		}
		public static string ChandamName(int n)
		{
			switch (n)
			{
				case 1:
					return "ఉక్త";
				case 2:
					return "అత్యుక్త";
				case 3:
					return "మధ్య";
				case 4:
					return "ప్రతిష్ఠ";
				case 5:
					return "సుప్రతిష్ఠ";
				case 6:
					return "గాయత్రి";
				case 7:
					return "ఉష్ణిక్కు";
				case 8:
					return "అనుష్టుప్పు";
				case 9:
					return "బృహతి";
				case 10:
					return "పంక్తి";
				case 11:
					return "త్రిష్టుప్పు";
				case 12:
					return "జగతి";
				case 13:
					return "అతిజగతి";
				case 14:
					return "శక్వరి";
				case 15:
					return "అతిశక్వరి";
				case 16:
					return "అష్టి";
				case 17:
					return "అత్యష్టి";
				case 18:
					return "ధృతి";
				case 19:
					return "అతిధృతి";
				case 20:
					return "కృతి";
				case 21:
					return "ప్రకృతి";
				case 22:
					return "ఆకృతి";
				case 23:
					return "వికృతి";
				case 24:
					return "సంకృతి";
				case 25:
					return "అభికృతి";
				case 26:
					return "ఉత్కృతి";
				case -1:
					return "";
				default:
					return "ఉద్ధురమాల";
			}
		}

		public static string PossibleMatraSeries(string Sequence)
		{
			string seq = Sequence.Replace("-", "");
			string temp = "";
			for (int i = 3; i <= 6; i++)
			{
				bool h = CanSplit(seq, i);
				if (h)
				{
					temp = temp + i + ",";
				}
			}

			{
				foreach (int[] D in new int[][] { new int[] { 3, 4 }, new int[] { 3, 5 }, new int[] { 4, 5 } })
				{
					int x = D[0];
					int y = D[1];
					bool h2 = CanSplit2(seq, x, y);
					if (h2)
					{
						temp = temp + (x + "-" + y) + ",";
					}
					x = D[1];
					y = D[0];
					h2 = CanSplit2(seq, x, y);
					if (h2)
					{
						temp = temp + (x + "-" + y) + ",";
					}
				}

			}

			if (temp.EndsWith(","))
			{
				temp = temp.Substring(0, temp.Length - 1);
			}

			temp = temp.Replace(",", " , ");

			return temp;
		}
		public static string BuildSequence(object[][] Rules)
		{
			if (Rules == null || Rules.Length == 0)
			{
				return "";
			}

			string l = "";
			foreach (object _Rule in Rules[0])
			{
				if (_Rule.GetType() == typeof(string))
				{
					l = l + GDefinition.GetSymbols((string)_Rule) + "-";
				}
			}

			if (l.EndsWith("-"))
			{
				l = l.Substring(0, l.Length - 1);
			}
			return l;
		}
		public static int MatraLength(object[][] Rules)
		{
			if (Rules == null || Rules.Length == 0)
			{
				return 0;
			}

			int l = 0;
			foreach (object _Rule in Rules[0])
			{
				if (_Rule.GetType() == typeof(string))
				{
					l = l + GDefinition.MatraLength((string)_Rule);
				}
			}
			return l;
		}
		public static int CharLength(object[][] Rules)
		{
			if (Rules == null || Rules.Length == 0)
			{
				return 0;
			}

			int l = 0;
			foreach (object _Rule in Rules[0])
			{
				if (_Rule.GetType() == typeof(string))
				{
					l = l + GDefinition.GLength((string)_Rule);
				}
			}
			return l;
		}
		public static int MinCharLength(object[][] Rules, RuleType R)
		{
			if (Rules == null || Rules.Length == 0)
			{
				return 0;
			}
			int min = 99999;
			foreach (object[] LineRule in Rules)
			{
				int l = 0;
				foreach (object Rule in LineRule)
				{
					int local = 0;
					switch (R)
					{
						case RuleType.Name:
							local = GDefinition.MinThreshold2((string)Rule);
							break;
						case RuleType.SubType:
							local = GDefinition.MinThreshold3((SubCategory)Rule);
							break;
						case RuleType.Type:
							local = GDefinition.MinThreshold((Category)Rule);
							break;
						case RuleType.Weight:
							local = GDefinition.MinThreshold4((int)Rule);
							break;
					}
					l = l + local;
				}
				if (l < min)
				{
					min = l;
				}
			}
			return min;
		}
		public static int MaxCharLength(object[][] Rules, RuleType R)
		{
			if (Rules == null || Rules.Length == 0)
			{
				return 0;
			}

			int max = 0;
			foreach (object[] LineRule in Rules)
			{
				int l = 0;
				foreach (object Rule in LineRule)
				{
					int local = 0;
					switch (R)
					{
						case RuleType.Name:
							local = GDefinition.MaxThreshold2((string)Rule);
							break;
						case RuleType.SubType:
							local = GDefinition.MaxThreshold3((SubCategory)Rule);
							break;
						case RuleType.Type:
							local = GDefinition.MaxThreshold((Category)Rule);
							break;
						case RuleType.Weight:
							local = GDefinition.MaxThreshold4((int)Rule);
							break;
					}
					l = l + local;
				}
				if (l > max)
				{
					max = l;
				}
			}
			return max;
		}
		public static int CalcThreshold(Rule R)
		{
			int threshold = 0;
			foreach (object[] LineRule in R.Rules)
			{
				foreach (object Rule in LineRule)
				{
					int local = 0;
					switch (R.RuleType)
					{
						case RuleType.Name:
							local = GDefinition.Threshold2((string)Rule);
							break;
						case RuleType.SubType:
							local = GDefinition.Threshold3((SubCategory)Rule);
							break;
						case RuleType.Type:
							local = GDefinition.Threshold((Category)Rule);
							break;
						case RuleType.Weight:
							local = GDefinition.Threshold4((int)Rule);
							break;
					}

					if (local > threshold)
					{
						threshold = local;
					}
				}
			}
			return threshold;
		}

		public static int FindChandamNumber(object[][] Rules)
		{

			if (Rules == null || Rules.Length == 0)
			{
				return 0;
			}

			List<int> Binary = new List<int>();
			foreach (object _Rule in Rules[0])
			{
				if (_Rule.GetType() == typeof(string))
				{
					int[] GBinary = GDefinition.GBinaray((string)_Rule);
					//Scriptsharp fix .. Otherwise Can use AddRange..
					foreach (int i in GBinary)
					{
						Binary.Add(i);
					}
				}
			}

			double tot_invert = 0;
			for (int i = 0; i < Binary.Count; i++)
			{
				int b = Binary[i];
				double mul = Math.Pow(2.0, (double)i);
				int invert = 1 - b;

				tot_invert = tot_invert + (invert * mul);

			}
			return (int)tot_invert + 1;
		}


		public static string BuildGana(int c, int n)
		{
			if (n < 1 || n > Math.Pow(2, c))
			{
				return " ఛందస్సు సంఖ్య <span  class='gName'>1</span> నుండి <span  class='gName'>" + Math.Pow(2, c) + "</span> మధ్య లో ఉండవలెను.";
			}

			if (c < 1 || c > 26)
			{
				return "";
			}


			////#344
			////101 011 000 - Binary
			////0101011000 - Binay With Filler  at Left/ Start
			////0 101 011 000 - Split from Right

			////000 110 101 0 - ReOrder  from Right as per the sequence
			////UUU 11U | U | U

			List<int> Binary = GetBinary(n - 1, c);

			List<string> Seq = new List<string>();
			string seq = "";
			int cnt = 0;

			//for (int i = Binary.Count - 1; i >= 0; i--)
			for (int i = 0; i < Binary.Count; i++)
			{
				cnt++;
				int b = Binary[i];
				seq = seq + ((b == 0) ? "U" : "|");
				if ((cnt) % 3 == 0)
				{
					Seq.Add(seq);
					seq = "";
				}
			}

			if (seq != "")
			{
				Seq.Add(seq);
			}
			string s = "";
			s = SequenceToGNames(Seq);
			s = "<span class='gName'>" + Helper.ChandamName(c) + " (" + c + ") </span> ఛందము నందు <span class='gName'>" + n + "</span> వ ఛందస్సుకు గల గణములు <span class='gName'> " + s + "</span>";

			return s;
		}



		public static string SequenceToGNames2(string series)
		{
			series = series.Replace(" ", "");

			List<string> Seq = new List<string>();
			string seq = "";
			int cnt = 0;
			for (int i = 0; i < series.Length; i++)
			{
				cnt++;
				string b = series.Substring(i, 1);
				seq = seq + b;
				if ((cnt) % 3 == 0)
				{
					Seq.Add(seq);
					seq = "";
				}
			}

			if (seq != "")
			{
				Seq.Add(seq);
			}
			string s = "";
			s = SequenceToGNames(Seq);
			s = s.Replace(" ", "");
			return s;
		}

		public static string SequenceToGNames(List<string> Seq)
		{
			string s = "";
			foreach (string _s in Seq)
			{
				s = s + GDefinition.GName(_s) + " , ";

			}
			s = s.Substring(0, s.Length - 2);//Trim End..  ', '
			return s;
		}

		public static string[] BuildNotes(decimal n)
		{
			List<int> Septa = GetSepta(n, 1);
			string[] Notes = new string[] { "స", "రి", "గ", "మ", "ప", "ద", "ని" };
			string[] Seq = new string[Septa.Count];
			for (int i = 0; i < Septa.Count; i++)
			{
				int b = Septa[Septa.Count - i - 1];
				Seq[i] = Notes[b];
			}
			return Seq;
		}

		private static List<int> GetBinary(decimal n, int c)
		{
			return GetNumbered(n, c, (decimal)2.0);
		}
		private static List<int> GetSepta(decimal n, int c)
		{
			return GetNumbered(n, c, (decimal)7.0);
		}

		private static List<int> GetNumbered(decimal n, int c, decimal x)
		{
			int remainder = 0;
			decimal remaining = n;
			List<int> Binary = new List<int>();
			while (remaining != 0)
			{
				remainder = (int)remaining % (int)x;
				remaining = (decimal)(object)Math.Floor(remaining / x);
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

		private static bool CanSplit(string items, int target)
		{
			if (items.Length < target)
			{
				return false;
			}
			int tot = 0;
			for (int i = 0; i < items.Length; i++)
			{
				if (tot > target)
				{
					return false;
				}
				if (tot == target)
				{
					tot = 0;
				}
				tot = tot + (StringPlus.CharAt(items, i) == '|' ? 1 : 2);
			}
			return true;
		}
		private static bool CanSplit2(string items, int x, int y)
		{
			int tot = 0;
			int target = x;

			if (items.Length < target)
			{
				return false;
			}

			int done = 0;
			for (int i = 0; i < items.Length; i++)
			{
				if (tot > target)
				{
					return false;
				}
				if (tot == target)
				{
					tot = 0;
					target = (target == x) ? y : x;
					done++;
				}
				tot = tot + (StringPlus.CharAt(items, i) == '|' ? 1 : 2);
			}
			if (done < 2)
			{
				return false;
			}
			return true;
		}
		public static string MismatchString(Mismatch M)
		{
			switch (M)
			{
				case Mismatch.Name:
					return "గణ నామం";
				case Mismatch.Category:
					return "గణ స్వభావం";
				case Mismatch.Weight:
					return "మాత్ర";
				case Mismatch.Yati:
					return "యతి";
				case Mismatch.Lines:
					return "పాదములు";
				case Mismatch.GCount:
					return "గణాల సంఖ్య";
				case Mismatch.Prasa:
					return "ప్రాస";
				case Mismatch.AnthyaPrasa:
					return "అంత్యప్రాస";
				case Mismatch.NonGuruvu:
					return "చివరి అక్షరం";
				case Mismatch.OddNonJa:
					return "బేసి గణం";
				case Mismatch.Sixth:
					return "ఆరవ గణం";
				case Mismatch.PrasaPoorva:
					return "ప్రాస పూర్వాక్షరం";
				case Mismatch.AnthyaPrasaPoorva:
					return "అంత్యప్రాస పూర్వాక్షరం";
				case Mismatch.PrasaPoorvaBindu:
					return "ప్రాస పూర్వాక్షరం బిందువు";
				case Mismatch.AnthyaPrasaPoorvaBindu:
					return "అంత్యప్రాస పూర్వాక్షరం బిందువు";
				case Mismatch.PrasaYati:
					return "ప్రాస యతి ";
				default:
					return "తెలియదు";
			}
		}

		public static decimal GetOrder(decimal length, decimal order)
		{
			if (length < 0)
			{
				return -1;
			}

			decimal upTo = 0;
			if (length == 1)
			{
				upTo = 0;
			}
			else
			{
				upTo = (decimal)Math.Pow(2.0, (double)length) - 2;
			}

			order = order + upTo;
			return order;
		}
	}
}
