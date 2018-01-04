//---------------------------------------------------------------------------------------------
// <copyright file="Padyam.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Indic;
using Chandam.Rules;
using Chandam.Util;
using System;
using System.Collections.Generic;

namespace Chandam.Core
{
	public class Padyam
	{

		#region Public Properties
		public bool MatchYati
		{
			get
			{
				return _MatchYati;
			}
			set
			{
				_MatchYati = value;
			}
		}
		public bool MatchPrasa
		{
			get
			{
				return _MatchPrasa;
			}
			set
			{
				_MatchPrasa = value;
			}
		}
		public bool AllowSantiPrasa
		{
			get
			{
				return _AllowSantiPrasa;
			}
			set
			{
				_AllowSantiPrasa = value;
				YPC.AllowSantiPrasa = value;
			}
		}
		public bool SandiMatch
		{
			get
			{
				return _SandiMatch;
			}
			set
			{
				_SandiMatch = value;
				YPC.SoundexSandhi = value;
			}
		}
		#endregion
		#region Core Matcher
		public Padyam()
		{
			YPC = new YatiPrasaChecker2();

		}
		public MatchResult Match2(GanaVibhajana _G, Rule Rule)
		{
			s = _G.RawString;
			G = _G;
			R = Rule;
			Analyse();
			return MatchInternal();

		}
		public MatchResult Match(string str, Rule Rule)
		{
			s = str;
			G = new GanaVibhajana(s, Rule.Language);
			R = Rule;
			Analyse();
			return MatchInternal();
		}

		private MatchResult MatchInternal()
		{
			#region Handle Generic
			if (R.Identifier == "GenricVruttam")
			{
				R.Lines = G.Lines;
				string[] Names = G.GNamesStream.Split('\n');
				if (Names.Length >= 0)
				{
					L = new List<Errors>();
					R.Rules = new object[][] { Names[0].Split(' ') };
					int lp = 0;
					foreach (string name in Names)
					{
						tot++;
						lp++;
						if (name == Names[0])
						{
							score++;
						}
						else
						{
							Errors E = new Errors();
							E.Actual = name;
							E.Expected = Names[0];
							E.Mismatch = Mismatch.Name;
							E.Line = lp;
							E.Position = -1;
							L.Add(E);
						}
					}
				}
				{
					MatchResult M = new MatchResult();
					M.Total = tot;
					M.Score = score;
					M.Errors = L;
					M.Rule = R;
					return M;
				}
			}
			#endregion

			#region సమపాద వృత్తము
			if (!R.RowWiseRules && G.Lines > R.Lines)//సమపాద వృత్తము
			{
				if (R.PadyamSubType != PadyamSubType.Ragada)
				{
					switch (G.Lines)
					{
						case 5:
							R.Name = R.Name + "(పంచపాది)";
							break;
						case 6:
							R.Name = R.Name + "(షట్పది)";
							break;
						default:
							R.Name = R.Name + "(మాలిక)";
							break;
					}
				}
				R.Lines = G.Lines;
			}
			#endregion

			#region...

			tot = 0;
			score = 0;
			L = new List<Errors>();

			if (R.InfiniteLength && G.GNames.Count == 0)
			{
				MatchResult M = new MatchResult();
				M.Total = tot;
				M.Score = score;
				M.Errors = L;
				M.Rule = R;
				return M;
			}
			#endregion

			#region Check Lines
			tot++;
			if (G.Lines == R.Lines)
			{
				score++;
			}
			else
			{
				int offset = Math.Abs(R.Lines - G.Lines);
				tot = tot + offset;

				Errors E = new Errors();
				E.Actual = G.Lines.ToString();
				E.Expected = R.Lines.ToString();
				E.Mismatch = Mismatch.Lines;
				L.Add(E);
			}
			#endregion

			#region For Each Line
			for (int i = 0; i < R.Lines; i++)
			{
				LineScore(i);
			}
			#endregion

			#region KandamSpecialCheck
			if (R.RuleType == RuleType.Weight && R.Identifier == "kandam")
			{
				CheckSpecial();
			}
			#endregion

			#region Ragada Special Check
			if (R.PadyamSubType == PadyamSubType.Ragada)
			{
				tot++;
				if (G.Lines % 2 != 0)
				{
					tot++;

					Errors E = new Errors();
					E.Actual = G.Lines.ToString();
					E.Expected = (G.Lines + 1).ToString();
					E.Line = -1;
					E.Position = -1;
					E.Mismatch = Mismatch.Lines;
					L.Add(E);
				}
				else
				{
					score++;
				}
			}
			#endregion


			{
				MatchResult M = new MatchResult();
				M.Total = tot;
				M.Score = score;
				M.Errors = L;
				M.Rule = R;
				return M;
			}
		}
		#endregion

		private void Analyse()
		{
			this.Vibhajana(R);
		}
		private void Vibhajana(Rule R)
		{

			#region ....
			int lines = 0;
			string gstr = "";
			string gn = "";

			string last = "";
			string lastSymbol = "";
			string lastLast = "";
			string lastLastSymbol = "";

			int offset = 0;
			int charCnt = 0;
			int GCount = 0;
			int y = 0;
			int W = 0;
			int GPassed = 0;

			int NextWeight = 0;
			Category NextCat = Category.Unknown;
			Category2 NextCat2 = Category2.Unknown;
			SubCategory NextSubCat = SubCategory.Unknown;
			string NextGName = "";

			int NextYati = 0;
			Yati Y = new Yati();
			#endregion

			for (int i = 0; i < G.SymbolsStream.Length; i++)
			{
				string curr = StringPlus.CharAt(G.SymbolsStream, i).ToString();

				#region Continue if Curr is " "
				if (curr == " ")
					continue;
				#endregion

				#region When Reached End of Line
				if (curr == Constants.NewLine)
				{

					if (gn != "")
					{
						Update(gn, GDefinition.GName(gn), gstr);

						gstr = "";
						gn = "";
						charCnt = 0;
						GCount = 0;
						GPassed = 0;
						W = 0;
						y = 0;
					}


					Update(Constants.NewLine, Constants.NewLine, Constants.NewLine);
					G.Yati.Add(Y);
					if (R.AnthyaPrasa)
					{
						G.AnthyaPrasa.Add(new Prasa(lastLastSymbol, true, last, lastLast));
					}

					charCnt = 0;
					GCount = 0;
					GPassed = 0;
					W = 0;
					y = 0;
					lines++;
					Y = new Yati();
					continue;

				}
				#endregion

				#region Set FristAkshar as Yati
				if (charCnt == 0)
				{
					Y.P1 = G.GWiseString[i];
					Y.PY1 = NextNonSpaceAkshar(i + 1, G.GWiseString);
					Y.YC = PrevHasSunna(i, G.GWiseString);
				}
				#endregion

				#region Prasa
				if (R.Prasa)
				{
					if (charCnt == 1)
					{
						G.Prasa.Add(new Prasa(lastSymbol, false, G.GWiseString[i], last));
					}
				}
				#endregion

				#region Do Some Updates  based on Curr Char
				gn = gn + (curr == " " ? "" : curr);
				gstr = gstr + ((gstr != "") ? " " : "") + G.GWiseString[i];
				W = W + GDefinition.GetSymbolWeight(curr);
				charCnt++;
				lastLastSymbol = lastSymbol;
				lastSymbol = curr;
				#endregion

				#region  Calc Next Yati Position
				if (R.Yati.Length == R.Lines && lines < R.Yati.Length)
				{
					//Vary By Line
					if (R.Yati[lines].Length == 0)
					{
						NextYati = 0;
					}
					else
					{
						NextYati = (y < R.Yati[lines].Length && y >= 0) ? R.Yati[lines][y] : 0;
					}
				}
				else
				{
					if (R.Yati.Length > 0 && y >= 0)
					{
						if (y < R.Yati[0].Length && y >= 0)
						{
							NextYati = R.Yati[0][y];
						}
						else
						{
							NextYati = 0;
						}
					}
					else
					{
						NextYati = 0;
					}
				}
				#endregion

				#region Update Yati Postions for other than FirstAkshar
				switch (R.YatiMode)
				{
					case YatiMode.CharPosition:
						if (charCnt == NextYati)
						{
							Y.P2.Add(G.GWiseString[i]);
							Y.PrasaYati.Add(NextNonSpaceAkshar(i + 1, G.GWiseString));
							Y.PrevContext.Add(PrevHasSunna(i, G.GWiseString));

							//Y.Positions.Add ( charCnt );
							Y.Positions.Add(GPassed + 1);
							y++;
						}
						break;
					case YatiMode.GPosition:
						if (GPassed + 1 == NextYati)
						{
							if (R.YatiRecycle && NextYati == 5)//Currently Hard coded for Seesam's  as it is the only case found till if found some other then needs to modify the code..
							{
								G.Yati.Add(Y);
								Y = new Yati();

								Y.P1 = G.GWiseString[i];
								Y.PY1 = NextNonSpaceAkshar(i + 1, G.GWiseString);
								Y.YC = PrevHasSunna(i, G.GWiseString);
								y++;
							}
							else
							{
								if (!R.ReverseYati)
								{
									Y.P2.Add(G.GWiseString[i]);
									Y.PrasaYati.Add(NextNonSpaceAkshar(i + 1, G.GWiseString));
									Y.PrevContext.Add(PrevHasSunna(i, G.GWiseString));

									//Y.Positions.Add ( charCnt );
									Y.Positions.Add(GPassed + 1);
									y++;
								}
							}

						}
						break;
				}
				#endregion

				#region Caclc Next Category Expected..
				if (R.RuleType == RuleType.Type)
				{
					object[] _R = (R.RowWiseRules && lines < R.Rules.Length) ? R.Rules[lines] : R.Rules[0];

					if (GCount >= _R.Length)
					{
						NextCat = Category.Unknown;
					}
					else
					{
						NextCat = (Category)(_R[GCount]);
					}
				}
				#endregion
				#region Caclc Next Category2 Expected..
				if (R.RuleType == RuleType.Type2)
				{
					object[] _R = (R.RowWiseRules && lines < R.Rules.Length) ? R.Rules[lines] : R.Rules[0];

					if (GCount >= _R.Length)
					{
						NextCat2 = Category2.Unknown;
					}
					else
					{
						NextCat2 = (Category2)(_R[GCount]);
					}
				}
				#endregion

				#region Calc Next Sub Category Expected..
				if (R.RuleType == RuleType.SubType)
				{
					object[] _R = (R.RowWiseRules && lines < R.Rules.Length) ? R.Rules[lines] : R.Rules[0];

					if (GCount >= _R.Length)
					{
						NextSubCat = SubCategory.Unknown;
					}
					else
					{
						NextSubCat = (SubCategory)(_R[GCount]);
					}
				}
				#endregion

				#region Calc Next Weight Expected..
				if (R.RuleType == RuleType.Weight)
				{
					object[] _R = (R.RowWiseRules && lines < R.Rules.Length) ? R.Rules[lines] : R.Rules[0];

					if (GCount >= _R.Length)
					{
						NextWeight = 0;
					}
					else
					{
						NextWeight = (int)(_R[GCount]);
					}
				}
				#endregion

				#region Calc Next GName
				if (R.RuleType == RuleType.Name)
				{
					object[] _R = (R.RowWiseRules && lines < R.Rules.Length) ? R.Rules[lines] : R.Rules[0];

					if (GCount >= _R.Length)
					{
						NextGName = "";
					}
					else
					{
						NextGName = (string)(_R[GCount]);
					}
				}
				#endregion

				#region Determine If can break now..
				bool _break = false;
				switch (R.RuleType)
				{
					case RuleType.Name:
						int thresold = 3;
						//Not Good idea need to follow other "switch cases"
						if (R.DeferThresold)
						{
							//Blind & Hard Fix ..As there are only specfic cases.
							if (R.InfiniteLength)
							{
								if (NextGName == "హ" || NextGName == "వ")
								{
									thresold = 2;
									_break = (charCnt % thresold == 0 && charCnt != 0);
									offset = 1;
								}
								else
								{
									_break = ((charCnt + offset) % thresold == 0 && charCnt != 0);
								}


							}
							else
							{
								if (GCount == 2 && charCnt == 8)
								{
									_break = true;
								}
								if (charCnt > 8)
								{
									_break = ((charCnt + 1) % thresold == 0 && charCnt != 0);
								}
							}
						}
						else
						{
							_break = (charCnt % thresold == 0 && charCnt != 0);
						}
						break;
					case RuleType.Type:
						{
							Category Current = GDefinition.GetType(gn);
							_break = (Current == NextCat);
						}
						break;
					case RuleType.Type2:
						{
							Category2 Current = GDefinition.GetType2(gn);
							_break = (Current == NextCat2);
						}
						break;
					case RuleType.SubType:
						{
							SubCategory Current = GDefinition.GetSubType(gn);
							_break = (Current == NextSubCat);
						}
						break;
					case RuleType.Weight:
						_break = (W == NextWeight);
						break;
				}

				if (!_break && (R.Threshold == gn.Length))
				{
					_break = true;
				}
				#endregion

				#region Update G-Name on Break
				if (_break && gn != "")
				{
					if (R.ReverseYati && (GPassed + 1 == NextYati))
					{
						Y.P2.Add(G.GWiseString[i]);
						Y.PrasaYati.Add(NextNonSpaceAkshar(i + 1, G.GWiseString));
						Y.PrevContext.Add(PrevHasSunna(i, G.GWiseString));
						Y.Positions.Add(GPassed + 1);
						y++;
					}

					Update(gn, GDefinition.GName(gn), gstr);

					gstr = "";
					gn = "";
					W = 0;
					GCount++;
					GPassed++;
				}
				#endregion

				#region Store Current Char Value to last
				lastLast = last;
				last = G.GWiseString[i] == " " ? last : G.GWiseString[i];
				#endregion
			}
			#region Reached End of Padyam
			if (gn != "")
			{
				Update(gn, GDefinition.GName(gn), gstr);
				G.Yati.Add(Y);
				gstr = "";
				gn = "";
				Y = new Yati();
			}
			//Always update Lines and Yati
			{
				G.Yati.Add(Y);
				lines++;
			}

			if (R.AnthyaPrasa)
			{
				G.AnthyaPrasa.Add(new Prasa(lastLastSymbol, true, last, lastLast));//Todo.. buggy
			}
			#endregion

			G.Lines = lines;
		}
		private string PrevHasSunna(int start, List<string> list)
		{
			bool got = false;
			start = start - 1;
			while (!got)
			{
				if (start >= 0 && start < list.Count)
				{
					if (list[start] == "\n" || list[start] == " ")
					{
						start = start - 1;
					}
					else
					{

						return StringPlus.EndsWith(list[start], 'ం') ? "ం" : null;
						//return "ం";
					}
				}
				else
				{
					return null;
				}
			}
			return null;
		}
		private string NextNonSpaceAkshar(int start, List<string> list)
		{
			bool got = false;
			string x = null;
			while (!got)
			{
				x = start < list.Count ? list[start] : null;
				if (x == null || x == "\n")
				{
					return null;
				}

				if (x == " ")
				{
					start = start + 1;
				}
				else
				{
					return x;
				}

			}
			return x;

		}
		private int LinePosition(int i)
		{
			if (i == 0)
			{
				return 0;
			}
			int cnt = 0;
			int l = 0;
			foreach (string nm in G.GNames)
			{
				if (nm == Constants.NewLine)
				{
					l++;
				}
				cnt++;
				if (l == i)
				{
					return cnt;
				}
			}

			return -1;
		}
		private int LinePosition2(int line)
		{
			int cnt = 0;
			int l = 0;

			for (int i = 0; i < G.GNames.Count; i++)
			{
				string nm = G.GNames[i];
				if (nm == Constants.NewLine)
				{
					l++;

					if (l == line + 1)
					{
						return cnt;
					}

				}
				cnt++;
			}

			return G.GNames.Count;
		}
		private void LineScore(int line)
		{
			int mark = LinePosition(line);
			int next = LinePosition2(line);
			int pos = 1;

			object[] Rules = R.RowWiseRules ? R.Rules[line] : R.Rules[0];
			{
				tot++;
				int gCount = mark == -1 ? 0 : next - mark;
				if (gCount != Rules.Length && !R.InfiniteLength)
				{

					int offset = Math.Abs(Rules.Length - gCount);
					tot = tot + offset;

					Errors E = new Errors();
					E.Actual = gCount == 0 ? "" : gCount.ToString();
					E.Expected = Rules.Length.ToString();
					E.Line = line + 1;
					E.Position = -1;
					E.Mismatch = Mismatch.GCount;
					L.Add(E);
				}
				else
				{
					score++;
				}
			}

			int to = mark + Rules.Length;
			if (R.InfiniteLength)
			{
				to = G.GNames.Count;
			}

			for (int j = mark; j < to; j++)
			{
				bool err = true;
				string nm = "";
				string rule = "";
				string gString = "";
				int w = 0;
				if (j < G.GNames.Count & j >= 0)
				{
					tot++;
					nm = G.GNames[j];
					nm = nm.Trim();

					gString = G.GString[j];
					gString = gString.Trim();

					switch (R.RuleType)
					{
						case RuleType.Name:
							{
								if (!R.InfiniteLength)
								{
									rule = (string)Rules[j - mark];
								}
								else
								{
									//Works only if no.of Lines are one.. as there is only one case where legth is infinite
									if (j < to - 1 && Rules.Length - 2 >= 0 && j > Rules.Length - 2)
									{
										rule = (string)Rules[(Rules.Length - 2)];
									}
									else if (j == to - 1)
									{
										rule = (string)Rules[Rules.Length - 1];
									}
									else
									{
										rule = (string)Rules[j - mark];
									}
								}
								if (nm == rule)
								{
									score++;
									err = false;
								}
							}
							break;
						case RuleType.Type:
							{
								Category r1 = (Category)Rules[j - mark];
								Category c1 = GDefinition.GetType(nm);
								rule = GDefinition.CategoryString(r1);
								if (r1 == c1)
								{
									score++;
									err = false;
								}
							}
							break;
						case RuleType.Type2:
							{
								Category2 r1 = (Category2)Rules[j - mark];
								Category2 c1 = GDefinition.GetType2(nm);
								rule = GDefinition.Category2String(r1);
								if (r1 == c1)
								{
									score++;
									err = false;
								}
							}
							break;
						case RuleType.SubType:
							{
								SubCategory r1 = (SubCategory)Rules[j - mark];
								SubCategory c1 = GDefinition.GetSubType(nm);
								rule = GDefinition.SubCategoryString(r1);
								if (r1 == c1)
								{
									score++;
									err = false;
								}
							}
							break;
						case RuleType.Weight:
							{
								int r1 = (int)Rules[j - mark];
								w = GDefinition.GetGWeight2(G.GSymbols[j]);
								int c1 = w;
								rule = r1.ToString();
								if (r1 == c1)
								{
									score++;
									err = false;
								}
							}
							break;
					}
				}

				else
				{
					if (j == -1)
					{
						for (int k = 0; k < Rules.Length; k++)
						{
							tot++;

							switch (R.RuleType)
							{
								case RuleType.Weight:
									rule = ((int)Rules[k]).ToString();
									break;
								case RuleType.Name:
									rule = (string)Rules[k];
									break;
								case RuleType.Type:
									{
										Category r1 = (Category)Rules[k];
										rule = GDefinition.CategoryString(r1);
									}
									break;
								case RuleType.Type2:
									{
										Category2 r1 = (Category2)Rules[k];
										rule = GDefinition.Category2String(r1);
									}
									break;
								case RuleType.SubType:
									{
										SubCategory r1 = (SubCategory)Rules[k];
										rule = GDefinition.SubCategoryString(r1);
									}
									break;
							}

							Errors E = new Errors();
							E.Actual = R.RuleType == RuleType.Name ? nm : ((R.RuleType == RuleType.Weight) ? w.ToString() : GDefinition.CategoryString(GDefinition.GetType(nm)));
							E.Expected = rule;
							E.Line = line + 1;
							E.Position = pos;
							E.Mismatch = R.RuleType == RuleType.Name ? Mismatch.Name : (R.RuleType == RuleType.Weight ? Mismatch.Weight : Mismatch.Category);
							E.Remarks = gString;
							L.Add(E);
							pos++;
						}

						j = Rules.Length + 1;//END Loop
						continue;
					}
					else
					{
						//Less than Expected..
						err = true;

						switch (R.RuleType)
						{
							case RuleType.Name:
								{
									rule = (string)Rules[j - mark];
								}
								break;
							case RuleType.Type:
								{
									Category r1 = (Category)Rules[j - mark];
									rule = GDefinition.CategoryString(r1);
								}
								break;
							case RuleType.Type2:
								{
									Category2 r1 = (Category2)Rules[j - mark];
									rule = GDefinition.Category2String(r1);
								}
								break;
							case RuleType.SubType:
								{
									SubCategory r1 = (SubCategory)Rules[j - mark];
									rule = GDefinition.SubCategoryString(r1);
								}
								break;
							case RuleType.Weight:
								rule = ((int)Rules[j - mark]).ToString();
								break;
						}
					}
				}
				if (err)
				{
					Errors E = new Errors();
					E.Actual = R.RuleType == RuleType.Name ? nm : ((R.RuleType == RuleType.Weight) ? w.ToString() : GDefinition.CategoryString(GDefinition.GetType(nm)));
					E.Expected = rule;
					E.Line = line + 1;
					E.Position = pos;
					E.Mismatch = R.RuleType == RuleType.Name ? Mismatch.Name : (R.RuleType == RuleType.Weight ? Mismatch.Weight : Mismatch.Category);
					E.Remarks = gString;
					L.Add(E);
				}

				pos++;
			}
			if (MatchYati)
			{
				CheckYati(line);
			}
			if (MatchPrasa)
			{
				CheckPrasa(line);

				CheckAnthyaPrasa(line);
			}
		}
		private void CheckYati(int line)
		{
			if (R.OnlyPrasaYati)
			{
				CheckPrasaYati(line);
				return;
			}


			if (G.Yati.Count > line)
			{

				if (!R.YatiRecycle)
				{
					Yati y = G.Yati[line];
					bool[] _PY = CheckYatiMatch(y, line);
					G.PrasaYati.Add(_PY);//Currently Very Tightly Coupled. To be made as Loosely Coupled.
				}
				else
				{
					try
					{
						if (line * 2 < G.Yati.Count && (line + 1) * 2 - 1 < G.Yati.Count)
						{
							Yati y = G.Yati[line * 2];
							bool[] _PY1 = CheckYatiMatch(y, line);

							y = G.Yati[(line + 1) * 2 - 1];

							bool[] _PY2 = CheckYatiMatch(y, line);
							bool[] _PY = new bool[_PY1.Length + _PY2.Length];
							for (int _k = 0; _k < _PY1.Length; _k++)
							{
								_PY[_k] = _PY1[_k];
							}
							for (int _k = _PY1.Length; _k < _PY1.Length + _PY2.Length; _k++)
							{
								_PY[_k] = _PY2[_k - _PY1.Length];
							}
							G.PrasaYati.Add(_PY);
						}
					}
					catch (Exception)
					{

					}
				}

			}
			else
			{
				//Errors E= new Errors ( );
				//E.Actual = "";
				//E.Expected = "";
				//E.Line = line + 1;
				//E.Position = -1;
				//E.Mismatch = Mismatch.Yati;
				//L.Add ( E );
			}

			#region ..
			//int n=0;
			//if ( R.Yati.Length == R.Lines )
			//{
			//    n = R.Yati[line].Length;
			//}
			//else
			//{
			//    if ( R.Yati.Length > 0 )
			//    {
			//        n = R.Yati[0].Length;
			//    }
			//}
			#endregion
		}
		private void CheckPrasaYati(int line)
		{
			//Todo..
			if (G.Yati.Count > line)
			{

				if (!R.YatiRecycle)
				{
					Yati y = G.Yati[line];
					bool[] _PY = CheckPrasaYati2(y, line);
					G.PrasaYati.Add(_PY);//Currently Very Tightly Coupled. To be made as Loosely Coupled.
				}

			}

		}
		private bool[] CheckPrasaYati2(Yati y, int line)
		{
			bool[] _PY2 = new bool[2] { true, true };//#1
			if (y.P2.Count >= 1)
			{
				int cnt = 0;
				bool[] _PY = new bool[y.P2.Count + 1];
				foreach (string p2 in y.P2)
				{



					bool res = false;
					if (!res && R.PrasaYati)
					{
						if (y.PrasaYati[cnt] != null)
						{
							//res = YatiMatcher ( y.PY1 , y.PrasaYati[cnt] );
							res = YPC.IsPrasaMatched(y.PY1, y.PrasaYati[cnt]);
							if (res)
							{
								_PY[cnt + 1] = true;
								_PY[0] = true;//Report back...
							}
							else
							{
								//#2..Why duplicate code???
								_PY[cnt + 1] = true;
								_PY[0] = true;//Report back...
							}
						}
					}

					//Context based matching also to be added...

					if (res)
					{
						score++;
					}
					else
					{
						Errors E = new Errors();
						E.Actual = p2.ToString() + y.PrasaYati[cnt];
						E.Expected = y.P1.ToString() + y.PY1;
						E.Line = line + 1;
						E.Position = y.Positions[cnt];
						E.Mismatch = Mismatch.PrasaYati;
						L.Add(E);
					}
					tot++;
					cnt++;
				}

				return _PY;
			}
			return _PY2;
		}
		private bool[] CheckYatiMatch(Yati y, int line)
		{
			bool[] _PY2 = new bool[2];
			if (y.P2.Count >= 1)
			{
				int cnt = 0;
				bool[] _PY = new bool[y.P2.Count + 1];
				foreach (string p2 in y.P2)
				{

					bool res = YatiMatcher(y.P1, p2);
					if (res)
					{
						_PY[cnt + 1] = false;
						_PY[0] = false;
					}


					#region Context based  Not reporting back at this point of time
					if (!res)
					{
						res = YatiMatcher((y.YC == null) ? y.P1 : (y.YC + y.P1), p2);
					}

					if (!res && cnt < y.PrevContext.Count && y.PrevContext[cnt] != null)
					{

						res = YatiMatcher((y.YC == null) ? y.P1 : (y.YC + y.P1), y.PrevContext[cnt] + p2);
					}
					#endregion

					if (!res && R.PrasaYati)
					{
						if (y.PrasaYati[cnt] != null)
						{
							//res = YatiMatcher ( y.PY1 , y.PrasaYati[cnt] );
							res = YPC.IsPrasaMatched(y.PY1, y.PrasaYati[cnt]);
							if (res)
							{
								_PY[cnt + 1] = true;
								_PY[0] = true;//Report back...
							}
						}
					}

					//Context based matching also to be added...

					if (res)
					{
						score++;
					}
					else
					{
						Errors E = new Errors();
						E.Actual = p2.ToString();
						E.Expected = y.P1.ToString();
						E.Line = line + 1;
						E.Position = y.Positions[cnt];
						E.Mismatch = Mismatch.Yati;
						L.Add(E);
					}
					tot++;
					cnt++;
				}

				return _PY;
			}
			return _PY2;
		}
		private void CheckSpecial()
		{
			int cnt = 0;
			int l_p = 0;
			int l_cnt = 0;//line local count;;
			int _tot = 0;

			foreach (string s in G.GNames)
			{
				_tot++;
				if (cnt > 16)
				{
					tot++;
					return;
				}

				if (s == "\n")
				{
					l_p++;
					l_cnt = 0;
					continue;
				}

				//_tot++;

				cnt++;
				l_cnt++;

				//if ( l_cnt%2==1)
				if (cnt % 2 == 1)
				{
					tot++;
					if (s.Trim() != "జ")
					{
						score++;
					}
					else
					{
						Errors E = new Errors();
						E.Actual = s;
						E.Expected = "'జ' కానిది";
						E.Mismatch = Mismatch.OddNonJa;
						E.Position = l_cnt;
						E.Line = l_p + 1;
						L.Add(E);
					}

				}

				//if ( (l_p == 1 || l_p==3) &&  ((l_cnt == 3 && cnt == 6) || (l_cnt == 3 && cnt == 14)))
				if ((l_p == 1 || l_p == 3) && (l_cnt == 3))
				{
					tot++;
					if (s.Trim() == "జ" || s.Trim() == "నల")
					{
						score++;
					}
					else
					{
						Errors E = new Errors();
						E.Actual = s;
						E.Expected = "జ or నల";
						E.Mismatch = Mismatch.Sixth;
						E.Position = l_cnt;
						E.Line = l_p + 1;
						L.Add(E);

					}

				}


			}

			if (l_cnt == 5 && (l_p == 3 || l_p == 1))//For Line 2 and 4
			{

				tot++;
				string _s = G.GSymbols[_tot - 1];
				char c = StringPlus.CharAt(_s, _s.Length - 1);
				if (c == 'U')
				{
					score++;
				}
				else
				{
					Errors E = new Errors();
					E.Actual = c.ToString();
					E.Expected = "U(గురువు)";
					E.Mismatch = Mismatch.NonGuruvu;
					E.Position = l_cnt;
					E.Line = l_p + 1;
					L.Add(E);
				}
			}

		}
		private void CheckPrasa(int line)
		{
			if (!R.Prasa)
			{
				return;
			}

			if (line == 0)
			{
				return;
			}

			tot++;

			if (G.Prasa.Count == 0)
			{
				return;
			}

			if (line > G.Prasa.Count)
			{
				return;
			}

			Prasa P1 = G.Prasa[0];
			if (R.PadyamSubType == PadyamSubType.Ragada || R.PadyamSubType == PadyamSubType.Divpada)//In fact  any poem with 2 lines
			{
				if (line % 2 == 0)
				{
					score++;
					return;
				}
				if (line % 2 == 1 && line - 1 > 0)
				{
					P1 = G.Prasa[line - 1];
				}
			}

			if (line >= G.Prasa.Count)
			{
				return;
			}

			Prasa P2 = G.Prasa[line];
			bool res = YPC.IsPrasaMatched3(P1, P2);
			if (res)
			{
				score++;
			}
			else
			{
				Errors E = new Errors();
				E.Actual = P2.Value;
				E.Expected = P1.Value;
				E.Line = line + 1;
				E.Position = -1;
				E.Mismatch = Mismatch.Prasa;
				L.Add(E);
			}
			CheckPrasaPoorva(G.Prasa, line);
		}
		private void CheckPrasaPoorva(List<Prasa> PP, int line)
		{
			tot++;
			Prasa p1 = PP[0];
			Prasa p2 = PP[line];

			if (R.PadyamSubType == PadyamSubType.Ragada || R.PadyamSubType == PadyamSubType.Divpada)//In fact  any poem with 2 lines
			{
				if (line % 2 == 0)
				{
					score++;
					CheckPrasaPoorva2(p1, p2, line);
					return;
				}
				if (line % 2 == 1 && line - 1 > 0)
				{
					p1 = PP[line - 1];
				}
			}

			//if ( p1.Symbol == Symbols.LAGHUVU )
			//{
			//    score++;
			//    if ( !IsPrasaPooravaValid ( line ) )
			//    {
			//        CheckPrasaPoorva2 ( p1 , p2 , line );
			//    }
			//    return;//No need to check  further.
			//}


			bool res = (p1.Symbol == p2.Symbol);
			if (res)
			{
				score++;//if(R.PadyamType != PadyamType.Vruttam) //Not even required..
			}
			else
			{
				//if ( !IsPrasaPooravaValid ( line ) )
				//{
				//    score++;
				//    return;
				//}

				Errors E = new Errors();
				E.Actual = GDefinition.GetSymbolName(p2.Symbol);
				E.Expected = GDefinition.GetSymbolName(p1.Symbol);
				E.Line = line + 1;
				E.Position = -1;
				E.Mismatch = p1.IsAnthyaPrasa ? Mismatch.AnthyaPrasaPoorva : Mismatch.PrasaPoorva;
				L.Add(E);
			}

			CheckPrasaPoorva2(p1, p2, line);
		}

		/*
		private bool IsPrasaPooravaValid (int line)
		{
			if (R.PadyamType != PadyamType.Vruttam)
			{
				return true;
			}

			try
			{
				//Try to avoid try-catch
				string  _Rule=Symbols.GURUVU;
				if ( R.RowWiseRules )
				{
					_Rule = ( string ) R.Rules[line][0];
				}
				else
				{
					_Rule = ( string ) R.Rules[0][0];
				}
				_Rule = GDefinition.GetSysmbols ( _Rule );
				if ( StringPlus.CharAt ( _Rule , 0 ) == '|' )
				{
					return false;
				}
			}
			catch
			{

			}
			return true;
		}
		*/

		private void CheckPrasaPoorva2(Prasa p1, Prasa p2, int line)
		{
			tot++;

			char SUNNA = 'ం';
			char VISARGA = 'ః';
			if (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == SUNNA || StringPlus.CharAt(p2.Poorva, p2.Poorva.Length - 1) == SUNNA)
			{
				if (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == SUNNA && StringPlus.CharAt(p2.Poorva, p2.Poorva.Length - 1) == SUNNA)
				{
					score++;
					return;
				}
				else
				{
					Errors E = new Errors();
					E.Actual = p2.Poorva;
					E.Expected = (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == SUNNA) ?
								 ("'" + SUNNA + "'  తో కూడిన అక్షరం") : ("'" + SUNNA + "'  తో లేని అక్షరం");
					E.Line = line + 1;
					E.Position = -1;
					E.Mismatch = p1.IsAnthyaPrasa ? Mismatch.AnthyaPrasaPoorvaBindu : Mismatch.PrasaPoorvaBindu;
					L.Add(E);
					return;
				}
			}
			else
			{
				if (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == VISARGA || (StringPlus.CharAt(p2.Poorva, p2.Poorva.Length - 1) == VISARGA))
				{
					if (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == VISARGA && (StringPlus.CharAt(p2.Poorva, p2.Poorva.Length - 1) == VISARGA))
					{
						score++;
						return;
					}
					else
					{
						Errors E = new Errors();
						E.Actual = p2.Poorva;
						E.Expected = (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == VISARGA) ?
									("'" + VISARGA + "'  తో కూడిన అక్షరం") : ("'" + VISARGA + "'  తో లేని అక్షరం");
						E.Line = line + 1;
						E.Position = -1;
						E.Mismatch = p1.IsAnthyaPrasa ? Mismatch.AnthyaPrasaPoorvaVisarga : Mismatch.PrasaPoorvaVisarga;
						L.Add(E);
						return;
					}
				}
			}

			score++;
		}
		private void CheckAnthyaPrasa(int line)
		{
			if (!R.AnthyaPrasa)
			{
				return;
			}

			if (line == 0)
			{
				return;
			}

			tot++;

			if (G.AnthyaPrasa.Count == 0)
			{
				return;
			}

			if (line > G.AnthyaPrasa.Count)
			{
				return;
			}

			string p1 = G.AnthyaPrasa[0].Value;
			if (R.PadyamSubType == PadyamSubType.Ragada || R.PadyamSubType == PadyamSubType.Divpada)//In fact  any poem with 2 lines
			{
				if (line % 2 == 0)
				{
					score++;
					return;
				}
				if (line % 2 == 1 && line - 1 > 0)
				{
					p1 = G.AnthyaPrasa[line - 1].Value;
				}
			}

			if (line >= G.AnthyaPrasa.Count)
			{
				return;
			}
			string p2 = G.AnthyaPrasa[line].Value;

			bool res = YPC.IsPrasaMatched(p1, p2);


			if (res)
			{
				score++;
			}
			else
			{
				Errors E = new Errors();
				E.Actual = p2.ToString();
				E.Expected = p1;
				E.Line = line + 1;
				E.Position = -1;
				E.Mismatch = Mismatch.AnthyaPrasa;
				L.Add(E);
			}

			CheckPrasaPoorva(G.AnthyaPrasa, line);

		}
		private bool YatiMatcher(string p1, string p2)
		{
			return YPC.IsYatiMatched(p1, p2);
		}
		private string LineStamper(int lp)
		{
			string ret = "";
			bool isOK = IsOk(lp);
			if (isOK)
			{
				ret = "<label class='ok'>" + "✔" + "</label>";
			}
			else
			{
				ret = ret + "<label class='err'>" + "✘" + "</label>";
			}
			return ret;
		}
		private string GStamper(int lp, int gp)
		{
			string ret = "";
			bool isOK = IsGOK(gp, lp);
			if (isOK)
			{
				ret = "gOk";
			}
			else
			{
				return "gErr";
			}
			return ret;
		}
		private bool IsOk(int lp)
		{
			foreach (Errors E in MR.Errors)
			{
				if (E.Line == lp + 1)
				{
					return false;
				}
			}
			if (lp + 1 > R.Lines)
			{
				return false;
			}
			return true;
		}
		private bool IsGOK(int GPassed, int lp)
		{
			if (lp + 1 > R.Lines)
			{
				return false;
			}

			foreach (Errors E in MR.Errors)
			{
				if (E.Line == lp + 1 && E.Position == GPassed + 1)
				{
					return false;
				}
			}

			if (R.RowWiseRules || R.RuleType == RuleType.Weight)
			{
				if (lp < R.Rules.Length && R.Rules.Length != 1 && GPassed >= R.Rules[lp].Length)
				{
					return false;
				}

			}
			else
			{
				if (GPassed + 1 > R.Rules[0].Length && !R.InfiniteLength)
				{
					return false;
				}
			}
			return true;
		}
		private void Update(string gn, string gn2, string gstr)
		{
			G.GNamesStream = G.GNamesStream + gn2;
			G.GNames.Add(gn2);
			G.GString.Add(gstr);
			G.GSymbols.Add(gn);
		}
		public string Build(MatchResult _MR)
		{
			if (_MR == null)
			{
				throw new Exception("Matching object can't be null..");
			}
			else
			{
				MR = _MR;
			}
			return BuildHTML(R);
		}
		public string Build2(MatchResult _MR)
		{
			if (_MR == null)
			{
				throw new Exception("Matching object can't be null..");
			}
			else
			{
				MR = _MR;
			}
			return BuildText(R);
		}

		public string Build3()
		{
			return s.Replace("\n", "<br />");
		}

		private string BuildHTML(Rule R)
		{
			string t1 = "";
			string t2 = "";
			string t3 = "";
			string n = "";
			int lp = 0;

			int CharsPassed = 0;
			int GPassed = 0;
			int NextYati = 1;
			int y = 0;
			int l_yati = 0;
			bool marker = false;
			int maxG = MaxOfG(G.GNames);
			for (int i = 0; i < G.GNames.Count; i++)
			{
				if (lp < R.Yati.Length && R.Yati[lp].Length == 0)
				{
					NextYati = -1;//When No Yati for given Row Exists
				}

				if (R.Yati.Length == 0)
				{
					NextYati = -1;//When No Yati Rule even exists.
				}
				if (G.GNames[i] == Constants.NewLine)
				{
					string equal =
					n = n + "<tr  class='ga'>" +
								"<td  class='stamper' rowspan='3'>" + LineStamper(lp) + "</td>" +
								t1 + Equivalize(maxG - GPassed) +
							"</tr>" +
							"<tr class='up'>" + t2 + "</tr>" +
							"<tr class='dw'>" + t3 + "</tr>\n";

					t1 = "";
					t2 = "";
					t3 = "";

					CharsPassed = 0;
					GPassed = 0;
					NextYati = 1;
					y = 0;
					l_yati = 0;
					lp++;
				}
				else
				{
					string[] Chars = G.GString[i].Split(' ');
					string x = GStamper(lp, GPassed);
					t1 = t1 + "<td class='X " + x + "' title='" + G.GNames[i] + "'>" + GDefinition.GetGName(R.RuleType, G.GNames[i]) + "</td>";
					t2 = t2 + "<td class='X " + x + "'>" + G.GSymbols[i].Replace(Symbols.LAGHUVU, "| ").Replace(Symbols.GURUVU, "U ") + "</td>";
					t3 = t3 + "<td class='X3 " + x + "'> ";


					#region  if Reverse Yati find the toal Non-space chars..
					int TotalNonSpace = 0;
					if (R.ReverseYati)
					{
						for (int _i = 0; _i < Chars.Length; _i++)
						{
							if (Chars[_i] != "" && Chars[_i] != " ")
							{
								TotalNonSpace++;
							}
						}
					}
					#endregion

					int non_space = 0;
					for (int j = 0; j < Chars.Length; j++)
					{
						if (Chars[j] == "")
						{
							continue;
						}

						// Is First Non Space char
						if (Chars[j] != " ")
						{
							non_space++;
						}

						#region Yati
						if (R.Prasa && CharsPassed + 1 == 2)
						{
							t3 = t3 + " <span class='yati'>" + Chars[j] + "</span> ";
						}
						else
						{
							bool found = false;
							switch (R.YatiMode)
							{
								case YatiMode.CharPosition:
									found = (CharsPassed + 1 == NextYati);
									break;
								case YatiMode.GPosition:
									found = (GPassed + 1 == NextYati) && (non_space == (R.ReverseYati && GPassed + 1 != 1 ? TotalNonSpace : 1));
									break;
							}

							if (found)
							{

								if (R.PrasaYati && G.PrasaYati.Count > 0 && lp < G.PrasaYati.Count && l_yati < G.PrasaYati[lp].Length && G.PrasaYati[lp][l_yati])
								{
									string _local = NextNonSpace(j + 1, Chars);
									t3 = t3 + " <span class='y1'><u>" + Chars[j] + " ";
									if (_local != "")
									{
										t3 = t3 + (R.Prasa ? "<span class='yati'>" + _local + "</span> " : _local);
									}
									else
									{
										marker = true;
									}
									t3 = t3 + "</u></span> ";
									j = j + 1;
									CharsPassed++;
								}
								else
								{
									t3 = t3 + " <span class='y1'><u>" + Chars[j] + "</u></span> ";
								}

								l_yati++;
								if (R.Yati.Length == R.Lines)
								{
									//Vary By Line 
									if (lp < R.Yati.Length && R.Yati[lp].Length == 0)
									{
										NextYati = 0;
									}
									else
									{
										NextYati = (lp < R.Yati.Length && y < R.Yati[lp].Length && y >= 0) ? R.Yati[lp][y] : 0;
									}
								}
								else
								{
									if (R.Yati.Length > 0 && R.Yati[0].Length > 0)
									{
										//Constant Value
										NextYati = (y < R.Yati[0].Length && y >= 0) ? R.Yati[0][y] : 0;
									}
								}
								y++;
							}
							else
							{

								if (R.AnthyaPrasa && ((i + 1 < G.GNames.Count && G.GNames[i + 1] == Constants.NewLine) || i == G.GNames.Count - 1) && j == Chars.Length - 1)
								{
									t3 = t3 + " <span class='yati'>" + Chars[j] + "</span> ";

								}
								else
								{
									if (marker)//Blind fix
									{
										string _local = NextNonSpace(j + 1, Chars);
										t3 = t3 + " <u><span class='yati'>" + Chars[j] + "</span></u> ";
										marker = false;
									}
									else
									{
										t3 = t3 + " " + Chars[j];
									}
								}

							}
						}
						#endregion

						//Count as a Char passed in case of Non-Space only
						if (j < Chars.Length && Chars[j] != " ")
						{
							CharsPassed++;
						}
					}

					t3 = t3 + "</td>";
					GPassed++;
				}
			}
			{

				return "<table cellspacing='0' border='1' class='tab'>" +
							n +
							"<tr  class='ga'>" +
									"<td  class='stamper' rowspan='3'>" + LineStamper(lp) + "</td>" +
										t1 + Equivalize(maxG - GPassed) +
							"</tr>" +
							"<tr class='up'>" + t2 + "</tr>" +
							"<tr class='dw'>" + t3 + "</tr>\n" +
						"</table>";
			}

		}

		private string Equivalize(int p)
		{
			string s = "";
			for (int i = 0; i < p; i++)
			{
				s = s + "<td  rowspan=\"3\">&nbsp;</td>";
			}
			return s;
		}

		private int MaxOfG(List<string> list)
		{
			int max = 0;
			int cnt = 0;
			foreach (string g in list)
			{

				if (g == "\n")
				{
					if (cnt > max)
					{
						max = cnt;

					}
					cnt = 0;
					continue;
				}
				cnt++;
			}
			if (cnt > max)
			{
				max = cnt;
			}
			return max;
		}
		private string NextNonSpace(int from, string[] Chars)
		{
			bool got = false;
			while (!got)
			{
				if (from < Chars.Length)
				{
					if (Chars[from] != " ")
					{
						return Chars[from];
					}
					from = from + 1;

				}
				else
				{
					got = true;
				}
			}
			return "";

		}
		private string BuildText(Rule R)
		{
			string t3 = "";
			string n = "";
			int lp = 0;

			int CharsPassed = 0;
			int GPassed = 0;
			int NextYati = 1;
			int y = 0;
			int l_yati = 0;
			int tot = -1;
			List<int> UMarkings = new List<int>();
			List<int> BMarkings = new List<int>();

			for (int i = 0; i < G.GNames.Count; i++)
			{
				if ((lp < R.Yati.Length && R.Yati[lp].Length == 0) || R.Yati.Length == 0)
				{
					NextYati = -1;//When No Yati for given Row Exists
				}

				if (G.GNames[i] == Constants.NewLine)
				{
					n = n + t3 + "<br />";

					t3 = "";
					CharsPassed = 0;
					GPassed = 0;
					NextYati = 1;
					y = 0;
					l_yati = 0;
					lp++;
					tot++;
				}
				else
				{
					string[] Chars = G.GString[i].Split(' ');

					#region  if Reverse Yati find the toal Non-space chars..
					int TotalNonSpace = 0;
					if (R.ReverseYati)
					{
						for (int _i = 0; _i < Chars.Length; _i++)
						{
							if (Chars[_i] != "" && Chars[_i] != " ")
							{
								TotalNonSpace++;
							}
						}
					}
					#endregion

					int non_space = 0;
					for (int j = 0; j < Chars.Length; j++)
					{

						if (Chars[j] == "")
						{
							continue;
						}
						tot++;
						// Is First Non Space char
						if (Chars[j] != " ")
						{
							non_space++;
						}

						if (R.AnthyaPrasa && ((i + 1 < G.GNames.Count && G.GNames[i + 1] == Constants.NewLine) || i == G.GNames.Count - 1) && j == Chars.Length - 1)
						{
							BMarkings.Add(tot);
						}

						#region Yati
						if (R.Prasa && CharsPassed + 1 == 2)
						{
							//t3 = t3 + "<b>" + Chars[j] + "</b>";
							BMarkings.Add(tot);
						}
						else
						{
							bool found = false;
							switch (R.YatiMode)
							{
								case YatiMode.CharPosition:
									found = (CharsPassed + 1 == NextYati);
									break;
								case YatiMode.GPosition:
									found = (GPassed + 1 == NextYati) && (non_space == (R.ReverseYati && GPassed + 1 != 1 ? TotalNonSpace : 1));
									break;
							}

							if (found)
							{

								if (R.PrasaYati && G.PrasaYati.Count > 0 && lp < G.PrasaYati.Count && l_yati < G.PrasaYati[lp].Length && G.PrasaYati[lp][l_yati])
								{
									UMarkings.Add(tot);
									UMarkings.Add(tot + 1);
								}
								else
								{
									UMarkings.Add(tot);
								}
								l_yati++;

								if (R.Yati.Length == R.Lines)
								{
									//Vary By Line 
									if (lp < R.Yati.Length && R.Yati[lp].Length == 0)
									{
										NextYati = 0;
									}
									else
									{
										NextYati = (lp < R.Yati.Length && y < R.Yati[lp].Length && y >= 0) ? R.Yati[lp][y] : 0;
									}
								}
								else
								{
									if (R.Yati.Length > 0 && R.Yati[0].Length > 0)
									{
										//Constant Value
										NextYati = (y < R.Yati[0].Length && y >= 0) ? R.Yati[0][y] : 0;
									}
								}
								y++;

							}
							else
							{
								string temp = Chars[j].ToString().EndsWith("్") ? Chars[j] + " " : Chars[j];

								t3 = t3 + "" + temp;
							}
						}
						#endregion

						//Count as a Char passed in case of Non-Space only
						if (Chars[j] != " ")
						{
							CharsPassed++;
						}
						else
						{

						}
					}

					t3 = t3 + "";
					GPassed++;
				}
			}
			//return n + t3;

			List<string> f = G.Raw;
			int tot2 = -1;
			for (int i = 0; i < f.Count; i++)
			{
				string _f = f[i];
				if (!StringPlus.Contains(G.Accept + "- ", _f))
				{
					tot2++;
				}
				if (UMarkings.Contains(tot2))
				{
					f[i] = "<u>" + f[i] + "</u>";
				}
				if (BMarkings.Contains(tot2))
				{
					f[i] = "<b>" + f[i] + "</b>";
				}

			}
			string temp2 = "";
			foreach (string _f in f)
			{
				temp2 = temp2 + _f.Replace("\n", "<br />");
			}
			return temp2;

		}
		#region Static
		public static Probable MostProbable(string s, MatchOptions Options)
		{
			return MostProbable2(s, Options, null);
		}
		public static Probable MostProbable2(string s, MatchOptions Options, List<Rule> Rules)
		{
			if (s.Trim().Length == 0)
				return null;

			Probable P = null;
			int score = 0;

			GanaVibhajana G = new GanaVibhajana(s, Options.Language);

			int min = G.Min;
			int max = G.Max;

			bool includeRare = Options.IncludeRare;
			includeRare = true;

			List<MatchResult> Results = new List<MatchResult>();
			//List<Rule> Rules=Options.QuickMatch ? RuleHelper.GetAllRules2 ( min , max , G.PreLines ) : RuleHelper.GetAllRules ( includeRare );
			if (Rules == null || Rules.Count == 0)
			{
				Rules = Options.QuickMatch ? RuleHelper.GetAllRules2(min, max, G.PreLines) : RuleHelper.GetAllRules(includeRare);
			}

			if (Rules.Count == 0)
			{
				Rules = RuleHelper.GetAllRules(includeRare);
			}

			List<Rule> Rules2 = Helper2.Clone(Rules);
			foreach (Rule R in Rules2)
			{
				Padyam Padyam = new Padyam();
				Padyam.MatchYati = Options.MatchYati;
				Padyam.MatchPrasa = Options.MatchPrasa;
				Padyam.AllowSantiPrasa = Options.AllowSantiPrasa;
				Padyam.SandiMatch = Options.ExperimenatalSandhi;
				MatchResult MR = Padyam.Match2(G.Clone(), R);//(s,R);
				Results.Add(MR);
				if (MR.Percentage >= score)
				{
					P = new Probable();
					P.Padyam = Padyam;
					P.MatchResult = MR;
					P.Rule = R;

					if (MR.IsMatched)
					{
						return P;
					}
					score = MR.Percentage;
				}
			}
			if (P != null)
			{
				P.Candiates = SortHelper2.Top(Results);
			}
			else
			{

			}
			return P;
		}
		#endregion


		#region Private
		GanaVibhajana G;
		string s;
		private Rule R;
		int tot = 0;
		int score = 0;
		List<Errors> L;
		MatchResult MR = null;
		bool _MatchPrasa;
		bool _MatchYati;
		bool _AllowSantiPrasa;
		bool _SandiMatch;
		YatiPrasaChecker2 YPC;
		#endregion
	}

}
/*	public class Letter
	{
		public bool IsYati;
		public bool IsPrasaYati;
		public string Symbol;
		public string Akshar;
		public bool IsYatiMatched;
		public bool IsPrasaYatiMatched;
	}
	public class Gana
	{
		public string Name;
		public Category Category;
		public string Symbols;
		public List<Letter> Letters;
		public bool HasError;
		public List<Errors> Errors;
	}
	public class Line
	{
		public List<Gana> Ganamulu;
		public bool HasError;
		public List<Errors> Errors;
	}
	public class Padyam2
	{
		public List<Line> Lines;
		public Rule Rule;
		public List<Errors> Errors;
	}
	*/
