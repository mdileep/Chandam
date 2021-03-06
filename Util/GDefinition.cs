//---------------------------------------------------------------------------------------------
// <copyright file="GDefinition.cs" company="Chandam-ఛందం">
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

namespace Chandam.Rules
{
	public class GDefinition
	{
		public static string GName(string stream)
		{
			string ret = "";
			ret = MatchG(stream) + " ";
			return ret;
		}
		public static int GetSymbolWeight(string Symbol)
		{
			return Symbol == "|" ? 1 : (Symbol == "U" ? 2 : 0);
		}
		public static int GetGWeight(string nm)
		{
			switch (nm)
			{
				default:
					try
					{
						string s = GetSymbols(nm);
						int w = 0;
						for (int i = 0; i < s.Length; i++)
						{
							w = w + GetSymbolWeight(s[i].ToString());
						}
						return w;
					}
					catch
					{
						return 0;
					}


				case "U":
					return 2;

				case "|":
					return 1;

				case "UU":
				case "గా":

				case "U||":
				case "భ":

				case "|U|":
				case "జ":

				case "||||":
				case "నల":

				case "||U":
				case "స":
					return 4;
			}
		}

		public static Matra GetMatra(string s)
		{
			switch (s)
			{
				default:
					return Matra.Other;

				case "U":
					return Matra.Two;
				case "|":
					return Matra.One;

				case "UU":
				case "గా":

				case "U||":
				case "భ":

				case "|U|":
				case "జ":

				case "||||":
				case "నల":

				case "||U":
				case "స":
					return Matra.Four;
			}
		}
		public static SubCategory GetSubType(string gn)
		{
			switch (gn)
			{
				default:
					return SubCategory.Unknown;

				case "|||":
				case "న":
					return SubCategory.LaghuSurya;

				case "|||||":
				case "నలల":
					return SubCategory.Laghu5;


			}
		}

		public static Category2 GetType2(string gn)
		{
			switch (gn)
			{
				default:
					return Category2.Unknown;

				case "గ":
				case "U":
					return Category2.Guruvu;

				case "|":
				case "ల":
					return Category2.Laghuvu;



				case "|U|":
				case "|U":
					return Category2.Other;

				case "UU":
				case "||U":
				case "U|":
				case "|||":
					return Category2.Brahma;




				case "||UU":
				case "||U|":
				case "|||U":
				case "||||":
				case "UUU":
				case "UU|":
				case "U|U":
				case "U||":
					return Category2.Vishnu;


					//case "|||UU":
					//case "|||U|":
					//case "||U||":
					//case "U|||":
					//case "U||U":
					//case "UUU|":
					//case "||U|U":
					//case "||UU|":
					//case "UU||":
					//case "U|U|":
					//case "||||U":
					//case "|||||":
					//case "U|UU":
					//case "UU|U":
					//    return Category2.Rudra;


			}
		}
		public static Category GetType(string s)
		{
			switch (s)
			{
				default:
					return Category.Unknown;

				case "గ":
				case "U":
					return Category.Guruvu;

				case "|":
				case "ల":
					return Category.Laghuvu;

				case "UU":
				case "గా":


				case "||U":
				case "|UU":
				case "|U|":
				case "UUU":
				case "|U":
					return Category.Other;

				case "U|":
				case "|||":
					return Category.Surya;

				case "||||":
				case "|||U":
				case "||U|":
				case "U||":
				case "U|U":
				case "UU|":
					return Category.Indra;

				case "నల":
				case "నగ":
				case "సల":
				case "భ":
				case "ర":
				case "త":
					return Category.Indra;

				case "హ":
				case "న":
					return Category.Surya;

				case "|||UU":
				case "|||U|":
				case "||U||":
				case "U|||":
				case "U||U":
				case "UUU|":
				case "||U|U":
				case "||UU|":
				case "UU||":
				case "U|U|":
				case "||||U":
				case "|||||":
				case "U|UU":
				case "UU|U":
					return Category.Chandra;

				case "నగగ":
				case "నహ":
				case "సలల":
				case "భల":
				case "భగురు":
				case "మలఘు":
				case "సవ":
				case "సహ":
				case "తల":
				case "రల":
				case "నవ":
				case "నలల":
				case "రగురు":
				case "తగ":
					return Category.Chandra;
			}

		}


		public static int Threshold(Category C1)
		{
			switch (C1)
			{
				case Category.Guruvu:
				case Category.Laghuvu:
					return 1;
				case Category.Chandra:
					return 5;
				case Category.Indra:
					return 4;
				case Category.Surya:
					return 3;
			}
			return 3;
		}
		public static int Threshold2(string n)
		{
			switch (n)
			{
				case "ల":
				case "గ":
					return 1;
				case "వ":
				case "గా":
				case "హ":
				case "లల":
					return 2;
				default:
					return 3;
			}
		}
		public static int Threshold3(SubCategory subCategory)
		{
			switch (subCategory)
			{
				case SubCategory.Laghu5:
					return 5;
				case SubCategory.LaghuSurya:
				case SubCategory.Unknown:
				default:
					return 3;
			}
		}
		public static int Threshold4(int w)
		{
			return w;
		}
		public static int Threshold5(Category2 C1)
		{
			switch (C1)
			{
				case Category2.Guruvu:
				case Category2.Laghuvu:
					return 1;
				case Category2.Rudra:
					return 5;
				case Category2.Vishnu:
					return 4;
				case Category2.Brahma:
					return 3;
			}
			return 3;
		}


		public static int MinThreshold(Category C1)
		{
			switch (C1)
			{
				case Category.Guruvu:
				case Category.Laghuvu:
					return 1;
				case Category.Chandra:
					return 4;
				case Category.Indra:
					return 3;
				case Category.Surya:
					return 2;
			}
			return 3;
		}
		public static int MinThreshold2(string n)
		{
			return Threshold2(n);
		}
		public static int MinThreshold3(SubCategory subCategory)
		{
			return Threshold3(subCategory);
		}
		public static int MinThreshold4(int w)
		{
			return MathHelper.Ceil(w / 2.0);
		}
		public static int MinThreshold5(Category2 C1)
		{
			switch (C1)
			{
				case Category2.Guruvu:
				case Category2.Laghuvu:
					return 1;
				case Category2.Rudra:
					return 4;
				case Category2.Vishnu:
					return 3;
				case Category2.Brahma:
					return 2;
			}
			return 3;
		}

		public static int MaxThreshold(Category C1)
		{
			return Threshold(C1);
		}
		public static int MaxThreshold2(string n)
		{
			return Threshold2(n);

		}
		public static int MaxThreshold3(SubCategory subCategory)
		{
			return Threshold3(subCategory);
		}
		public static int MaxThreshold4(int w)
		{
			return w;
		}
		public static int MaxThreshold5(Category2 C1)
		{
			return Threshold5(C1);
		}


		private static string MatchG(string s)
		{
			switch (s)
			{
				default:
					return "?";

				case "U":
					return "గ";
				case "|":
					return "ల";
				case "|||":
					return "న";
				case "||U":
					return "స";

				case "|UU":
					return "య";
				case "|U|":
					return "జ";

				case "U||":
					return "భ";
				case "U|U":
					return "ర";

				case "UU|":
					return "త";
				case "UUU":
					return "మ";

				case "|U":
					return "వ";
				case "U|":
					return "హ";
				case "UU":
					return "గా";
				case "||":
					return "లల";


				case "||||":
					return "నల";
				case "|||U":
					return "నగ";
				case "||U|":
					return "సల";



				case "|||UU":
					return "నగగ";
				case "|||U|":
					return "నహ";
				case "||U||":
					return "నలల";
				case "U|||":
					return "భల";
				case "U||U":
					return "భగురు";
				case "UUU|":
					return "మలఘు";
				case "||U|U":
					return "సవ";
				case "||UU|":
					return "సహ";
				case "UU||":
					return "తల";
				case "U|U|":
					return "రల";
				case "||||U":
					return "నవ";

				case "U|UU":
					return "రగురు";
				case "UU|U":
					return "తగ";

				case "|||||":
					return "నలల";
			}
		}
		public static string GetSymbols(string nm)
		{
			switch (nm)
			{
				default:
					if (nm.Length > 1)
					{
						string s = "";
						for (int i = 0; i < nm.Length; i++)
						{
							s = s + GetSymbols(nm[i].ToString());
						}
						return s;
					}
					return "?";

				case "గ":
					return "U";
				case "ల":
					return "|";

				case "న":
					return "|||";

				case "స":
					return "||U";

				case "య":
					return "|UU";
				case "జ":
					return "|U|";

				case "భ":
					return "U||";

				case "ర":
					return "U|U";

				case "త":
					return "UU|";
				case "మ":
					return "UUU";

				case "వ":
					return "|U";
				case "హ":
					return "U|";
				case "గా":
					return "UU";
				case "లల":
					return "||";


				case "నల":
					return "||||";
				case "నగ":
					return "|||U";
				case "సల":
					return "||U|";



					/*case "|||UU":
						return "నగగ";
					case "|||U|":
						return "నహ";
					case "||U||":
						return "నలల";
					case "U|||":
						return "భల";
					case "U||U":
						return "భగురు";
					case "UUU|":
						return "మలఘు";
					case "||U|U":
						return "సవ";
					case "||UU|":
						return "సహ";
					case "UU||":
						return "తల";
					case "U|U|":
						return "రల";
					case "||||U":
						return "నవ";

					case "U|UU":
						return "రగురు";
					case "UU|U":
						return "తగ";

					case "|||||":
						return "నలల";*/
			}
		}
		public static int[] GBinaray(string nm)
		{
			switch (nm)
			{
				default:
					return new int[] { };

				case "గ":
					return new int[] { 1 };
				case "ల":
					return new int[] { 0 };


				case "న":
					return new int[] { 0, 0, 0 };

				case "స":
					return new int[] { 0, 0, 1 };

				case "య":
					return new int[] { 0, 1, 1 };
				case "జ":
					return new int[] { 0, 1, 0 };

				case "భ":
					return new int[] { 1, 0, 0 };

				case "ర":
					return new int[] { 1, 0, 1 };

				case "త":
					return new int[] { 1, 1, 0 };
				case "మ":
					return new int[] { 1, 1, 1 };

				case "వ":
					return new int[] { 0, 1 };
				case "హ":
					return new int[] { 1, 0 };
				case "గా":
					return new int[] { 1, 1 };
				case "లల":
					return new int[] { 0, 0 };


				case "నల":
					return new int[] { 0, 0, 0, 0 };
				case "నగ":
					return new int[] { 0, 0, 0, 1 };
				case "సల":
					return new int[] { 0, 0, 1, 0 };
			}
		}
		public static int MatraLength(string gName)
		{
			int[] Binary = GBinaray(gName);

			int tot = 0;

			foreach (int b in Binary)
			{
				tot = tot + (b + 1);
			}
			return tot;
		}
		public static int GLength(string gName)
		{
			switch (gName)
			{
				case "ల":
				case "గ":
					return 1;

				case "గా":
				case "హ":
				case "వ":
				case "లల":
					return 2;

				case "య":
				case "మ":
				case "త":
				case "ర":
				case "జ":
				case "భ":
				case "న":
				case "స":
				default:
					return 3;
			}
		}
		public static int GetGWeight2(string p)
		{
			int w = 0;
			//Script Sahrp Fix
			for (int i = 0; i < p.Length; i++)
			{
				w = w + GetSymbolWeight(StringPlus.CharAt(p, i).ToString());
			}
			return w;
		}
		public static string GetSymbolName(string sym)
		{
			switch (sym)
			{
				case "|":
					return "లఘువు";
				case "U":
					return "గురువు";
				default:
					return "తెలియదు";
			}
		}
		public static string GAlias(string nm)
		{
			switch (nm)
			{
				case "గా":
					return nm + "(గగ)";
				case "వ":
					return nm + "(లగ)";
				case "హ":
					return nm + "(గల)";
				case "లా":
					return nm + "(లల)";
				default: return nm;
			}
		}

		public static string GetGName(RuleType ruleType, string nm)
		{
			switch (ruleType)
			{
				case RuleType.Type:
					return CategoryString(GetType(nm.Trim()));

				case RuleType.SubType:
					return SubCategoryString(GetSubType(nm.Trim()));

				case RuleType.Weight:
					return nm + " [" + GetGWeight(nm.Trim()) + "]";

				case RuleType.Custom:
				case RuleType.Name:
				default:
					return nm;
			}
		}
		public static string Category2String(Category2 C)
		{
			switch (C)
			{
				case Category2.Brahma:
					return "బ్రహ్మ";
				case Category2.Vishnu:
					return "విష్ణు";
				case Category2.Rudra:
					return "రుద్ర";
				case Category2.Guruvu:
					return "గురువు";

				case Category2.Laghuvu:
					return "లఘువు";
				case Category2.Other:
					return "తక్కిన";
				case Category2.Unknown:
				default:
					return "తెలియదు";
			}
		}
		public static string CategoryString(Category C)
		{
			switch (C)
			{
				case Category.Surya:
					return "సూర్య";
				case Category.Indra:
					return "ఇంద్ర";
				case Category.Chandra:
					return "చంద్ర";
				case Category.Guruvu:
					return "గురువు";

				case Category.Laghuvu:
					return "లఘువు";
				case Category.Other:
					return "తక్కిన";
				case Category.Unknown:
				default:
					return "తెలియదు";
			}
		}
		public static string SubCategoryString(SubCategory Cat)
		{
			switch (Cat)
			{
				case SubCategory.LaghuSurya:
					return "నల(లఘు సూర్య)";
				case SubCategory.Laghu5:
					return "5 లఘువులు";
				default:
					return "తెలియదు";

			}
		}
	}
}
//యమతరజభనస
// | U    U    U  | U     |  |
//ya maa taa raa ja bhaa na sa 
//public static string Ga { get { return "U"; } }
//public static string Ya { get { return "|UU"; } }
//public static string Ma { get { return "UUU"; } }
//public static string Ta { get { return "UU|"; } }
//public static string Ra { get { return "U|U"; } }
//public static string Ja { get { return "|U|"; } }
//public static string Bha { get { return "U||"; } }
//public static string Na { get { return "||U"; } }
//public static string Sa { get { return "|||"; } }
//public static string Va { get { return "|U"; } }