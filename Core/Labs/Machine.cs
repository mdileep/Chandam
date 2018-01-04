//---------------------------------------------------------------------------------------------
// <copyright file="Machine.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam;
using Chandam.Core;
using Chandam.Rules;
using System;
using System.Collections.Generic;

namespace Library.Chandam.Labs
{
	public class MachinePoem
	{
		RuleLanguage lang;
		public MachinePoem()
		{
			lang = RuleLanguage.Telugu;
		}

		public string Build(string identifier)
		{
			Rule R = Manager.FetchRule(identifier);
			string s = Write(R);
			return s;
		}
		private string Write(Rule Rule)
		{
			R = new Random();
			Y = new YatiPrasaChecker2();

			string s = Rule.Identifier == "kandam" ? GenerateKandam() : GenerateVruttam(Rule);

			return s;


		}
		Random R;
		YatiPrasaChecker2 Y;
		const string NewLine = "\n";
		string[][] W = new string[][] {  new string[] { "స" , "రి" , "గ" , "మ" , "ప" , "ద" , "ని" } ,
									new string[] { "సా" , "రీ" , "గా" , "మా" , "పా" , "దా" , "నీ" } };

		int temp = -1;
		private string GenerateVruttam(Rule Rules)
		{
			string s = "";
			int g = 1;
			int localG = 1;
			int line = 1;
			string prasa = "";
			string yati = "";
			int l = Rules.RowWiseRules ? 1 : Rules.Lines;
			for (int i = 0; i < l; i++)
			{
				foreach (object[] LineRule in Rules.Rules)
				{
					localG = 1;
					foreach (object Rule in LineRule)
					{
						string nm = (string)Rule;
						int p = 0;
						temp = 0;
						int NextYati = FindNextYati(Rules.Yati, Rules.YatiMode, Rules.YatiRecycle, localG);
						p = temp;
						string curr = "";
						bool PrasaG = (g > 1 && localG == 1);
						bool YatiG = (NextYati == localG);
						if (PrasaG)
						{
							curr = PrasaString2(nm, prasa);
						}
						if (YatiG)
						{
							curr = YatiString(nm, yati, p);
						}
						if (!PrasaG && !YatiG)
						{
							curr = StringWith1(nm);
						}
						s = s + curr;
						if (g == 1 && curr.IndexOf(",") >= 0)
						{
							prasa = curr.Split(',')[1];
						}

						if (localG == 1 && curr.IndexOf(",") >= 0)
						{
							yati = curr.Split(',')[0];
						}

						g++;
						localG++;

					}
					s = s + NewLine;
					line++;
				}
			}
			return s.Replace(",", "");
		}

		private int FindNextYati(int[][] YYY, YatiMode yatiMode, bool recycle, int localG)
		{
			int next = 0;
			if (YYY.Length > 1 || YYY.Length == 0)
			{
				return 0;
			}
			int[] YY = YYY[0];
			foreach (int y in YY)
			{
				if (yatiMode == YatiMode.CharPosition)
				{
					//Assuming threshold as 3 for all..and YY is ascendeing..
					int afterGan = (int)Math.Floor(y / 3.0);
					int pos = y % 3;
					if (afterGan + 1 < localG)
					{
						continue;
					}
					if (afterGan + 1 > next)
					{
						if (pos == 0)
						{
							temp = 2;//??
							return afterGan;
						}
						else
						{
							temp = pos - 1;
							return afterGan + 1;
						}
					}
				}
			}
			return next;
		}

		private string GenerateKandam()
		{
			string s = "";

			Rule Rules = Manager.FetchRule("kandam");
			if (Rules == null)
			{
				return "Not available";
			}
			int g = 1;
			int localG = 1;
			int line = 1;
			string prasa = "";
			string yati = "";

			foreach (object[] LineRule in Rules.Rules)
			{
				localG = 1;
				foreach (object Rule in LineRule)
				{
					int w = (int)Rule;

					string curr = "";
					bool PrasaG = (g > 1 && localG == 1);
					bool YatiG = ((line == 2 || line == 4) && (localG == 4));


					if (g % 2 == 1)//Odd Handlers
					{
						if (PrasaG)
						{
							curr = PrasaString3(w, prasa, "జ");//Black List
						}

						if (YatiG)
						{
							curr = YatiString3(w, yati, "జ");//Black List
						}
						if (!PrasaG && !YatiG)
						{
							curr = StringWith2(w, "జ");//Black List
						}
					}
					else
					{
						if (g == 6)//6th One
						{
							List<string> _LL = new List<string>();//White List
							_LL.Add("నల");
							_LL.Add("జ");
							curr = StringWith(w, yati, _LL);
						}
						else
						{

							if (PrasaG)
							{
								curr = PrasaString(w, prasa);
							}
							if (YatiG)
							{
								curr = YatiString2(w, yati);
							}
							if (!PrasaG && !YatiG)
							{
								if ((line == 2 || line == 4) & localG == 5)
								{
									//curr = StringWith ( 2 ).TrimEnd ( ' ' ) + SingleAkshar ( 2 );
									curr = StringWith_i(2).Replace(" ", "") + SingleAkshar(2);
								}
								else
								{
									curr = StringWith_i(w);
								}
							}

						}
					}


					s = s + curr;

					if (g == 1)
					{
						prasa = curr.Split(',')[1];
					}

					if (localG == 1)
					{
						yati = curr.Split(',')[0];
					}

					g++;
					localG++;

				}
				s = s + NewLine;
				line++;
			}

			return s.Replace(",", "");
		}

		private string StringWith(int w, string yati, List<string> whiteList)
		{
			string s = "";
			string nm = "";
			while (!whiteList.Contains(nm))
			{
				s = YatiString2(w, yati);
				GanaVibhajana G = new GanaVibhajana(s, lang);
				nm = GDefinition.GName(G.SymbolsStream.Replace(" ", "")).Trim();
			}
			return s;
		}



		private string YatiString3(int w, string yati, string blackList)
		{
			string s = "";
			string nm = blackList;
			while (nm == blackList)
			{
				s = YatiString2(w, yati);
				GanaVibhajana G = new GanaVibhajana(s, lang);
				nm = GDefinition.GName(G.SymbolsStream.Replace(" ", "")).Trim();
			}
			return s;
		}

		private string PrasaString3(int w, string prasa, string blackList)
		{
			string s = "";
			string nm = blackList;
			while (nm == blackList)
			{
				s = PrasaString(w, prasa);
				GanaVibhajana G = new GanaVibhajana(s, lang);
				nm = GDefinition.GName(G.SymbolsStream.Replace(" ", "")).Trim();
			}
			return s;
		}

		private string PrasaString2(string nm, string prasa)
		{
			if (prasa == "")
				return StringWith1(nm);

			string s = "";

			bool matched = false;
			while (!matched)
			{
				s = StringWith1(nm);
				{
					string lp = s.Split(',')[1];
					matched = Y.IsPrasaMatched(lp, prasa);
				}
			}
			return s;
		}
		private string YatiString(string nm, string yati, int p)
		{
			string s = "";
			bool matched = false;
			while (!matched)
			{
				s = StringWith1(nm);
				string lp = s.Split(',')[p];
				matched = Y.IsYatiMatched(lp, yati);
			}
			return s;
		}

		private string StringWith1(string nm)
		{
			int thresold = GDefinition.Threshold2(nm);
			string curr = nm;
			string s = "";//Can be done in a very Better way
			string sym = GDefinition.GetSymbols(nm);

			s = "";
			for (int i = 0; i < thresold; i++)
			{
				int index = sym[i] == '|' ? 0 : 1;
				string[] Selected = W[index];
				string t = Selected[R.Next(Selected.Length)];
				s = s + (i == 0 ? "" : ",") + t;
			}

			return s + " ";
		}



		private string SingleAkshar(int w)
		{
			string[] Selected = W[w - 1];
			string t = Selected[R.Next(Selected.Length)];
			return t;
		}

		private string YatiString2(int w, string yati)
		{
			string s = "";
			bool matched = false;
			while (!matched)
			{
				s = StringWith_i(w);
				string lp = s.Split(',')[0];
				matched = Y.IsYatiMatched(lp, yati);
			}
			return s;
		}

		private string PrasaString(int w, string prasa)
		{
			string s = "";
			bool matched = false;
			while (!matched)
			{
				s = StringWith_i(w);
				string lp = s.Split(',')[1];
				matched = Y.IsPrasaMatched(lp, prasa);
			}
			return s;
		}

		private string StringWith_i(int w)
		{
			string s = "";
			int tot = 0;
			while (tot != w)
			{
				int index = R.Next(W.Length);
				string[] Selected = W[index];
				string t = Selected[R.Next(Selected.Length)];
				int weight = GetWeight(t);
				if (weight + tot <= w)
				{
					s = s + (tot == 0 ? "" : ",") + t;
					tot = weight + tot;
				}
			}
			s = s + " ";
			return s;
		}
		private string StringWith2(int w, string blackList)
		{
			string s = "";
			string nm = blackList;
			while (nm == blackList)
			{
				s = StringWith_i(w);
				GanaVibhajana G = new GanaVibhajana(s, lang);
				nm = GDefinition.GName(G.SymbolsStream.Replace(" ", "")).Trim();
			}
			return s;
		}
		private string StringWithList(int w, List<string> whiteList)
		{
			string s = "";
			string nm = "";
			while (!whiteList.Contains(nm))
			{
				s = StringWith_i(w);
				GanaVibhajana G = new GanaVibhajana(s, lang);
				nm = GDefinition.GName(G.SymbolsStream.Replace(" ", "")).Trim();
			}
			return s;

		}
		private int GetWeight(string s)
		{
			switch (s)
			{
				case "స":
				case "రి":
				case "గ":
				case "మ":
				case "ప":
				case "ద":
				case "ని":
					return 1;

				case "సా":
				case "రీ":
				case "గా":
				case "మా":
				case "పా":
				case "దా":
				case "నీ":
					return 2;
			}
			return 0;
		}
	}
}