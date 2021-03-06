//---------------------------------------------------------------------------------------------
// <copyright file="SimpleInidicParser.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Indic;
using Chandam.Util;
using System;

namespace Library.IndicBase
{
	public class SimpleInidicParser
	{

		public static string IgnoreSet { get { return " \n"; } }
		public static string AchchuSet { get { return "అఆఇఈఉఊఋఎఏఌఐఒఓఔౠ"; } }
		public static string HalluSet
		{
			get
			{
				return "కఖగఘ" +
						 "ఙచఛజఝఞ" +
						 "టఠడఢణ" +
						 "తథదధన" +
						 "పఫబభమ" +
						 "యరఱలళవ" +
						 "శషసహ";
			}
		}
		public static string NumberSet { get { return "౦౧౨౩౪౫౬౭౮౯"; } }
		public static string PolluSet { get { return "్"; } }
		public static string SmallAchchuSet { get { return "అఇఉఋఎఌఒ"; } }
		public static string SpecialFinishSet { get { return "ంః"; } }
		public static string SmallFinishingSet { get { return "ిుృెొౌ"; } }
		public static string FinishingSet { get { return "ాిీుూృౄెేైొోౌంః"; } }
		public static string NeutralSet { get { return "ఁ"; } }
		public static bool IsGuruvu(string s) { { return CheckGuruvu(s); } }
		public static bool IsLaghuvu(string s) { { return CheckLaghuvu(s); } }

		public static bool CheckLaghuvu(string s)
		{
			return (GetSymbol(s) == Symbols.LAGHUVU);
		}
		public static bool CheckGuruvu(string s)
		{
			return (GetSymbol(s) == Symbols.GURUVU);
		}
		////public static bool IsSpecialAkshar(string lockedString)
		////{
		////    return (SpecialAkshar + ",").Contains(lockedString + ",");
		////}
		public static string GetSymbol(string s)
		{
			try
			{
				int c = 0; string Symbol = "";
				if (s.Length == 0) { Symbol = ""; return Symbol; }
				for (int i = 0; i < s.Length; i++)
				{
					char Chr = s[i];
					if (IsPollu(Chr))
					{
						Symbol = Symbols.GURUVU; return Symbol;

					}
					if (IsHallu(Chr)) { c++; }
					if (IsSpecialFinishing(Chr)) { Symbol = Symbols.GURUVU; return Symbol; }
					if (IsLongFinishing(Chr)) { Symbol = Symbols.GURUVU; return Symbol; }
					if (IsLongAchchu(Chr)) { Symbol = Symbols.GURUVU; return Symbol; }
					if (IsNeutral(Chr))
					{
						Symbol = "";
						return Symbol;
					}
					if (IsStranger(Chr) || IsNumber(Chr))
					{
						Symbol = "?";
						return Symbol;
					}
					if (CanIgonre(Chr))
					{
						Symbol = "_"; return Symbol;

					}
					if (c > 1) { Symbol = Symbols.GURUVU; return Symbol; }
				}
				Symbol = Symbols.LAGHUVU; return Symbol;
			}
			catch
			{
				return "?";
			}

		}



		public static string[] Split(string s)
		{

			string[] IA = null;
			try
			{
				string[] retVal = new string[s.Length];
				int cnt = 0;
				string lockedString = "";

				char lastChar = ' ';
				string lastCharNature = "a";
				bool released = false;
				for (int i = 0; i < s.Length; i++)
				{

					released = false;
					char currChar = s[i];
					string currCharNature = CharNature(currChar);


					bool CanIRelase = CanRelease(currCharNature, lastCharNature);

					if (CanIRelase)
					{
						bool CanImmRelase = IsImmRelease(currCharNature);
						if (CanImmRelase)
						{
							retVal[cnt++] = lockedString;
							lockedString = currChar.ToString();
						}
						else
						{

							if (IsSpecialFinishing(currChar))
							{
								if (lockedString == "")
								{
									try
									{
										retVal[cnt - 1] = retVal[cnt - 1] + lockedString + currChar;
									}
									catch
									{
										throw new Exception("Invalid TE Char ");
									}

								}
								else
								{
									retVal[cnt++] = lockedString + currChar;
								}
							}
							else
							{

								if (CanIgonre(currChar))
								{
									lockedString = lockedString + currChar;
									retVal[cnt++] = lockedString;
								}
								else
								{
									retVal[cnt++] = lockedString;
									retVal[cnt++] = currChar.ToString();
								}
							}
							lockedString = "";




						}

						lastChar = ' ';
						lastCharNature = "";
						released = true;
					}

					else
					{
						lastChar = currChar;
						lockedString = lockedString + currChar;
						lastCharNature = currCharNature;
					}

				}
				if (!released) { retVal[cnt++] = lockedString; }

				IA = new string[cnt];
				for (int i = 0; i < cnt; i++)
				{

					IA[i] = retVal[i];

				}

			}
			catch
			{ }
			return IA;


		}
		private static bool CanRelease(string CN, string PN)
		{
			bool res = false;
			if (CN == "a" || CN == "e")//a A e E
			{
				res = true;
			}

			if (CN == "s" || CN == "l") //kaa ka ki kI
			{
				res = true;
			}
			if (CN == "o") { res = true; }
			if (CN == "p") { res = false; }
			if (CN == "h" && PN == "h")
			{
				res = true;
			}
			if (CN == "y" || CN == "z" || CN == "n" || CN == "x") { res = true; }
			return res;
		}
		private static bool IsImmRelease(string CN)
		{

			bool res = false;
			if (CN == "h")
			{
				res = true;
			}

			if (CN == "p") { res = false; }

			return res;
		}

		public static bool IsSpecialFinishing(char Char)
		{

			{
				bool ret = false;
				string MatchString = SpecialFinishSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;

			}

		}
		public static bool IsLongFinishing(char Char)
		{

			{
				bool ret = false;
				if (!IsSpecialFinishing(Char) && !IsSmallFinishing(Char) && IsFinishing(Char)) { ret = true; }
				return ret;

			}
		}
		public static bool IsPollu(char Char)
		{

			{
				bool ret = false;
				string MatchString = PolluSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsSmallFinishing(char Char)
		{

			{
				bool ret = false;
				string MatchString = SmallFinishingSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsNeutral(char Char)
		{

			{
				bool ret = false;
				string MatchString = NeutralSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsFinishing(char Char)
		{

			{
				bool ret = false;
				string MatchString = FinishingSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsHallu(char Char)
		{

			{
				bool ret = false;
				string MatchString = HalluSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsAchchu(char Char)
		{
			{
				bool ret = false;
				string MatchString = AchchuSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}

		}
		public static bool IsSmallAchchu(char Char)
		{

			{
				bool ret = false;
				string MatchString = SmallAchchuSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsLongAchchu(char Char)
		{
			{
				bool ret = false;
				if (IsAchchu(Char)) { if (!IsSmallAchchu(Char)) { ret = true; } }
				return ret;
			}
		}
		public static string CharNature(char Char)
		{

			{
				string ret = "x";
				if (CanIgonre(Char)) { ret = "y"; return ret; }
				if (IsSmallAchchu(Char)) { ret = "a"; return ret; }
				if (IsLongAchchu(Char)) { ret = "e"; return ret; }
				if (IsHallu(Char)) { ret = "h"; return ret; }
				if (IsPollu(Char)) { ret = "p"; return ret; }
				if (IsSpecialFinishing(Char)) { ret = "o"; return ret; }
				if (IsSmallFinishing(Char)) { ret = "s"; return ret; }
				if (IsLongFinishing(Char)) { ret = "l"; return ret; }
				if (IsNeutral(Char)) { ret = "z"; return ret; }
				if (IsNumber(Char)) { ret = "n"; return ret; }
				return ret;
			}
		}
		public static bool IsNumber(char Char)
		{

			{

				bool ret = false;
				string MatchString = NumberSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;

			}
		}
		public static bool IsStranger(char Char)
		{
			{ return (CharNature(Char) == "x") ? true : false; }
		}
		public static bool CanIgonre(char Char)
		{


			{
				bool ret = false;
				string MatchString = IgnoreSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;

			}

		}
		public static bool IsValid(char Char) { { return !IsStranger(Char); } }

	}
	public class IndicRTSParser
	{

		public static string IgnoreSet { get { return " \n"; } }
		public static string AchchuSet { get { return "aeiouMAEIOU"; } }
		public static string HalluSet
		{
			get
			{
				return "kKgG" +
						"cCjn" +
						"tTdDN" + "pbB" + "ymrRlv" + "sSkL";
			}
		}
		public static string NumberSet { get { return "0123456789"; } }
		public static string FinishingSet { get { return "aeiou"; } }
		public static string SpecialFinishSet { get { return "MH:"; } }

		public static string[] Split(string s)
		{

			string[] IA = null;
			try
			{
				string[] retVal = new string[s.Length];
				int cnt = 0;
				string lockedString = "";

				char lastChar = ' ';
				string lastCharNature = "a";
				bool released = false;
				for (int i = 0; i < s.Length; i++)
				{

					released = false;
					char currChar = s[i];
					string currCharNature = CharNature(currChar);


					bool CanIRelase = CanRelease(currCharNature, lastCharNature);

					if (CanIRelase)
					{
						bool CanImmRelase = IsImmRelease(currCharNature);
						if (CanImmRelase)
						{
							retVal[cnt++] = lockedString;
							lockedString = currChar.ToString();
						}
						else
						{
							if (IsSpecialFinishing(currChar))
							{
								if (cnt == 0) { retVal[0] = currChar.ToString(); }
								else { retVal[cnt - 1] = retVal[cnt - 1] + currChar; }
							}
							else
							{
								lockedString = lockedString + currChar;
								retVal[cnt++] = lockedString;
							}
							lockedString = "";




						}

						lastChar = ' ';
						lastCharNature = "";
						released = true;
					}

					else
					{
						lastChar = currChar;
						lockedString = lockedString + currChar;
						lastCharNature = currCharNature;
					}

				}
				if (!released) { retVal[cnt++] = lockedString; }

				IA = new string[cnt];
				for (int i = 0; i < cnt; i++)
				{

					IA[i] = retVal[i];

				}

			}
			catch
			{ }
			return IA;


		}
		private static bool CanRelease(string CN, string PN)
		{
			bool res = false;
			if (CN == "a" && PN == "h")
			{
				res = false;
			}
			if (CN == "a" && PN != "h")
			{
				res = true;
			}
			if (CN == "h" && PN == "h")
			{
				res = false;
			}
			if (CN == "h" && PN == "a")
			{
				res = true;
			}
			if (CN == "y" || CN == "z" || CN == "n" || CN == "x") { res = true; }
			return res;
		}
		private static bool IsImmRelease(string CN)
		{

			bool res = false;
			if (CN == "h")
			{
				res = true;
			}

			if (CN == "p") { res = false; }

			return res;
		}

		public static bool IsSpecialFinishing(char Char)
		{

			{
				bool ret = false;
				string MatchString = SpecialFinishSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;

			}

		}
		public static bool IsHallu(char Char)
		{

			{
				bool ret = false;
				string MatchString = HalluSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}
		}
		public static bool IsAchchu(char Char)
		{
			{
				bool ret = false;
				string MatchString = AchchuSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;
			}

		}

		public static string CharNature(char Char)
		{

			{
				string ret = "x";
				if (CanIgonre(Char)) { ret = "y"; return ret; }
				if (IsAchchu(Char)) { ret = "a"; return ret; }
				if (IsHallu(Char)) { ret = "h"; return ret; }
				if (IsSpecialFinishing(Char)) { ret = "o"; return ret; }
				if (IsNumber(Char)) { ret = "n"; return ret; }
				return ret;
			}
		}
		public static bool IsNumber(char Char)
		{

			{

				bool ret = false;
				string MatchString = NumberSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;

			}
		}
		public static bool IsStranger(char Char)
		{
			{ return (CharNature(Char) == "x") ? true : false; }
		}
		public static bool CanIgonre(char Char)
		{


			{
				bool ret = false;
				string MatchString = IgnoreSet;
				//ret = MatchString.Contains(Char.ToString());
				ret = StringPlus.Contains(MatchString, Char.ToString());
				return ret;

			}

		}
		public static bool IsValid(char Char) { { return !IsStranger(Char); } }

		public static string LockedChar { get { return "aAotkKgcCjnTs"; } }
		public static string Mapped(string[] s)
		{
			string ret = "";

			for (int i = 0; i < s.Length; i++)
			{
				string CurrStr = s[i];

				string LockedStr = "";
				for (int j = 0; j < CurrStr.Length; j++)
				{
					char CurrChar = CurrStr[j];
					//if (LockedChar.Contains(CurrChar.ToString()))
					if (StringPlus.Contains(LockedChar, CurrChar.ToString()))
					{
						LockedStr = LockedStr + CurrChar;
					}
					else
					{
						ret = ret + Map(LockedStr + CurrChar);
						LockedStr = "";
					}

				}
				ret = ret + Map(LockedStr);

			}
			return ret;
		}

		private static string Map(string LockedStr)
		{
			string ret = "";
			switch (LockedStr)
			{
				default: ret = LockedStr + "-"; break;
					//case "aa":
					//case "A":
					//    ret = "ఆ"; break;
					//case "a": ret = "అ"; break;
					//case "aa":
					//case "A":
					//        ret = "ఆ"; break;
					//case "A":
					//        ret = "ఆ"; break;
					//    case "i": ret = "ఇ"; break;
					//ఆఇఈఈఉఊఊఎ ఏ ఐ ఏ ఐ ఒ   
			}
			return ret;
		}
	}
}