//---------------------------------------------------------------------------------------------
// <copyright file="YatiChecker2.cs" company="Chandam-ఛందం">
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
using Chandam.Util;
using System.Collections.Generic;

namespace Chandam.Core
{
	public partial class YatiPrasaChecker2
	{
		const string La = "ల";
		const string Ra = "ర";

		public bool IsYatiMatched(string s1, string s2)
		{

			//HARD FIX..
			s1 = s1.Replace("ై", "ై");
			s2 = s2.Replace("ై", "ై");

			//Algo to be modified to improve Performance
			//భిన్న యతి,వికల్పవిరమణలు..Not Handled..
			//బహుయతి నిరతి  Can be implemented.. on the wrapper..
			bool f = false;
			//Preparing for లుప్తవిసర్గస్వరవళి: Very Rude way of doing this.
			s1 = s1.Replace("ఽ", "అ");
			s2 = s2.Replace("ఽ", "అ");

			#region ౠత్వసౌమ్యవళి,ఋత్వసంబంధవళి
			{
				bool f1 = StringPlus.Contains(s1, RuKaaram);
				bool f2 = StringPlus.Contains(s2, RuKaaram);
				if (f1 && f2)
				{
					LastName = "ౠత్వసౌమ్యవళి";
					return true;// No need to check Further
				}

				if (f1 || f2)
				{
					f = StringPlus.Contains(RuGroup, s1);
					if (f)
					{
						LastName = "ఋత్వసంబంధవళి";
						return true;// No need to check Further
					}
				}

			}
			#endregion

			#region ఋవళి
			{
				//రి-రీ-రె-రే-"ి"-"ీ"-"ె"-"ే"=ఋ-"ృ"
				bool f1 = StringPlus.Contains(s1, Ru) || StringPlus.Contains(s1, RuKaaram);
				bool f2 = StringPlus.Contains(s2, Ru) || StringPlus.Contains(s2, RuKaaram);
				if (f1 || f2)
				{
					char c1 = StringPlus.CharAt(f1 ? s2 : s1, 0);
					if (c1 == 'ర')
					{
						char c2 = StringPlus.CharAt(f1 ? s2 : s1, f1 ? (s2.Length - 1) : (s1.Length - 1));
						if (c2 == 'ి' || c2 == 'ీ' || c2 == 'ె' || c2 == 'ే')
						{
							LastName = "ఋవళి";
							return true;
						}
					}
				}
			}
			#endregion

			#region స్వరప్రధానవళి
			{

				List<string> C1 = ExtractVowelorFinish(s1);
				List<string> C2 = ExtractVowelorFinish(s2);


				for (int i = 0; i < C1.Count; i++)
				{
					for (int j = 0; j < C2.Count; j++)
					{
						string c1 = C1[i];
						string c2 = C2[j];

						if (c1 == c2)
						{
							if (!(StringPlus.Contains(F, c1) && StringPlus.Contains(F, c2)))
							{
								//Don't MAtch Finish and Finish
								LastName = "స్వరప్రధానవళి";
								return true;//No need to Check Further
							}
						}
						bool t = MatchGroups(VowelAndFinishGroups, c1, c2);
						if (t)
						{
							if (!(StringPlus.Contains(F, c1) && StringPlus.Contains(F, c2)))
							{
								LastName = "స్వరప్రధానవళి";
								return true;//No need to Check Further
							}
						}

					}
				}
			}
			#endregion

			#region స్వరమైత్రివళి,ఋజు యతులు,వర్గ జయతులు,తద్భవవ్యాజ విశ్రమములు,విశేషవళి,బిందు యతులు,అనునాసికాక్షర యతులు,అనుస్వార సంబంధ యతులు,ప్రత్యేక యతి
			{
				List<string> C1 = ExtractConso(s1);
				List<string> C2 = ExtractConso(s2);

				#region య,హ,అ
				if (C1.Count == 0 || C2.Count == 0)
				{
					string c1 = C1.Count > 0 ? C1[0] : "";
					string c2 = C2.Count > 0 ? C2[0] : "";

					if (c1 == "య" || c1 == "హ")
					{
						if (StringPlus.Contains(s2, "అ"))
						{
							//ప్రత్యేక యతి
							LastName = "ప్రత్యేక యతి";
							return true;//No more checks
						}
					}

					if (c2 == "య" || c2 == "హ")
					{
						if (StringPlus.Contains(s1, "అ"))
						{
							//ప్రత్యేక యతి
							LastName = "ప్రత్యేక యతి";
							return true;
						}
					}
				}
				#endregion

				for (int i = 0; i < C1.Count; i++)
				{
					for (int j = 0; j < C2.Count; j++)
					{
						string c1 = C1[i];
						string c2 = C2[j];

						if (c1 == c2)
						{
							f = true;
							LastName = "సమాన హల్లు";
							break;
						}

						if (c1 == "య" || c1 == "హ")
						{
							if (StringPlus.Contains(s2, "అ"))
							{
								//ప్రత్యేక యతి
								LastName = "ప్రత్యేక యతి";
								return true;//No more checks
							}
						}

						if (c2 == "య" || c2 == "హ")
						{
							if (StringPlus.Contains(s1, "అ"))
							{
								//ప్రత్యేక యతి
								LastName = "ప్రత్యేక యతి";
								return true;
							}
						}

						f = MatchGroups(ConsoGroups, c1, c2);
						if (f)
						{
							LastName = "స్వరమైత్రివళి/ఋజు యతులు/ఏకతరయతులు/అభేద విరతులు/అభేద వర్గ విరతులు/ఊష్మ విశ్రాంతులు/సరసయతి";
							break;
						}
					}

					if (f)
					{
						break;
					}
				}
			}

			if (!f)
			{

				bool f1 = StringPlus.Contains(s1, "ఙ");
				bool f2 = StringPlus.Contains(s2, "ఙ");
				if (f1 || f2)
				{
					bool _f = StringPlus.Contains("ంక,ంఖ,ంగ,ంఘ", f1 ? s2 : s1);
					if (_f)
					{
						//విశేషవళి
						LastName = "విశేషవళి";
						f = true;
					}
				}
			}

			if (!f)
			{
				bool f1 = StringPlus.Contains(s1, "న") || StringPlus.Contains(s1, "ణ");
				bool f2 = StringPlus.Contains(s2, "న") || StringPlus.Contains(s2, "ణ");
				if (f1 || f2)
				{
					bool _f = StringPlus.Contains(f1 ? s2 : s1, "ఙ");
					if (_f)
					{
						//తద్భవవ్యాజ విశ్రమములు
						LastName = "తద్భవవ్యాజ విశ్రమములు";
						f = true;
					}
				}

			}
			#region Probables:బిందు యతులు,అనునాసికాక్షర యతులు,అనుస్వార సంబంధ యతులు
			if (!f)
			{
				//ం+హల్లు Group= 5th Letter;
				char c1 = StringPlus.CharAt(s1, 0);
				char c2 = StringPlus.CharAt(s2, 0);
				bool f1 = (c1 == SUNNA);
				bool f2 = (c2 == SUNNA);
				if (f1 || f2)
				{

					string c2_1 = "";
					string c1_1 = "";

					if (f1)
					{
						c2_1 = StringPlus.CharAt(s2, 0).ToString();
						c1_1 = s1.Length > 1 ? StringPlus.CharAt(s1, 1).ToString() : "";

					}
					else
					{
						c2_1 = StringPlus.CharAt(s1, 0).ToString();
						c1_1 = s2.Length > 1 ? StringPlus.CharAt(s2, 1).ToString() : "";

					}


					switch (c2_1)
					{
						default:
							{
								f = AnuSeriesYati(s1, s2);
								if (!f)
								{
									f = AnuSeriesYati(s2, s1);
								}
							}

							if (!f)
							{
								bool _f1 = StringPlus.Contains("ంయ,ంర,ంల,ంవ,ంశ,ంస,ంష,ంహ", f1 ? s1 : s2);
								if (_f1)
								{
									bool _f = StringPlus.Contains("మ", f1 ? s2 : s1);
									if (_f)
									{
										//మువర్ణ  విరామం
										LastName = "మువర్ణ  విరామం";
										return true;//No need to check further
									}
								}
							}

							break;
						case "ఙ":
							f = StringPlus.Contains("క,ఖ,గ,ఘ", c1_1);
							if (f)
							{
								f = true;
							}
							break;
						case "ఞ":
							f = StringPlus.Contains("చ,ఛ,జ,ఝ", c1_1);
							if (f)
							{
								f = true;
							}
							break;
						case "ణ":
							f = StringPlus.Contains("త,థ,ద,ధ", c1_1) || StringPlus.Contains("ట,ఠ,డ,ఢ", c1_1);//+అనునాసికాక్షర యతులు
							if (f)
							{
								f = true;
							}
							break;
						case "న":
							f = StringPlus.Contains("త,థ,ద,ధ", c1_1) || StringPlus.Contains("ట,ఠ,డ,ఢ", c1_1);//+అనునాసికాక్షర యతులు
							if (f)
							{
								f = true;
							}
							break;
						case "మ":
							f = StringPlus.Contains("ప,ఫ,బ,భ", c1_1) || StringPlus.Contains("య,ర,ల,వ,శ,స,ష,హ", c1_1);//+మువర్ణ  విరామం
							if (f)
							{
								f = true;
							}
							break;
					}
				}
			}
			#endregion

			if (f)
			{
				#region Confirm Above one's
				//Conso Groups Matched Now it's time to Match if their Finish matches.
				f = MatchYatiFinishGroups(s1, s2);
				#endregion
			}
			#endregion

			#region మువిభక్తియతి,ముకారయతి
			{
				//char  c10= StringPlus.CharAt ( s1 , 0 );
				//char  c1n= StringPlus.CharAt ( s1 , s1.Length - 1 );

				//char  c20= StringPlus.CharAt ( s2 , 0 );
				//char  c2n= StringPlus.CharAt ( s2 , s2.Length - 1 );

				//bool f1=( c10 == 'మ' && c1n == 'ు' );
				//bool f2=( c20 == 'మ' && c2n == 'ు' );

				//if ( f1 || f2 )
				//{
				//    bool _f1 = StringPlus.Contains ( "పఫభబ" , ( f1 ? c20 : c10 ).ToString ( ) );
				//    bool _f2 = StringPlus.Contains ( "ుూొో" , ( f1 ? c2n : c1n ).ToString ( ) );

				//    if ( _f1 && _f2 )
				//    {
				//        LastName = "మువిభక్తియతి లేదా ముకారయతి";
				//        return true;
				//    }

				//}


				char c10 = StringPlus.CharAt(s1, 0);
				char c1n = StringPlus.CharAt(s1, s1.Length - 1);

				char c20 = StringPlus.CharAt(s2, 0);
				char c2n = StringPlus.CharAt(s2, s2.Length - 1);

				bool f1 = (c10 == 'మ' && StringPlus.Contains("ుూొో", c1n.ToString()));
				bool f2 = (c20 == 'మ' && StringPlus.Contains("ుూొో", c2n.ToString()));

				if (f1 || f2)
				{
					bool _f1 = StringPlus.Contains("పఫభబమ", (f1 ? c20 : c10).ToString());
					bool _f2 = StringPlus.Contains("ుూొో", (f1 ? c2n : c1n).ToString());

					if (_f1 && _f2)
					{
						LastName = "మువిభక్తియతి లేదా ముకారయతి";
						return true;
					}

				}

			}
			#endregion

			#region అంత్యోష్మ సంధి కళులు
			{
				bool f1 = StringPlus.Contains(s1, HA);
				bool f2 = StringPlus.Contains(s2, HA);
				if (f1 || f2)
				{
					if (f1 && s2.Length >= 3)
					{
						char c1 = StringPlus.CharAt(s2, 0);
						char c2 = StringPlus.CharAt(s2, 1);
						char c3 = StringPlus.CharAt(s2, 2);

						if (c2 == Virama)
						{
							f = IsJhuyMatch(c1, c3);
							if (f)
							{
								LastName = "అంత్యోష్మ సంధి కళులు";
								return true;
							}
						}
					}

					if (f2 && s1.Length >= 3)
					{
						char c1 = StringPlus.CharAt(s1, 0);
						char c2 = StringPlus.CharAt(s1, 1);
						char c3 = StringPlus.CharAt(s1, 2);

						if (c2 == Virama)
						{
							f = IsJhuyMatch(c1, c3);
							if (f)
							{
								LastName = "అంత్యోష్మ సంధి కళులు";
								return true;
							}
						}
					}

				}
			}
			#endregion

			if (SoundexSandhi)
			{
				f = MatchYatiFinishGroups(s1, s2);
			}

			return f;
		}

		private bool MatchYatiFinishGroups(string s1, string s2)
		{
			bool f = false;

			List<string> C1 = ExtractFinish(s1);
			List<string> C2 = ExtractFinish(s2);

			if (C1.Count == 0 && C2.Count == 0)
			{
				return true;
			}

			if (C1.Count == 0)
			{
				//Match only 'అ' Group
				foreach (string _s in C2)
				{
					f = StringPlus.Contains(AGroup, _s);
					if (f)
					{
						return true;
					}
				}
			}

			if (C2.Count == 0)
			{
				//Match only 'అ' Group
				foreach (string _s in C1)
				{
					f = StringPlus.Contains(AGroup, _s);
					if (f)
					{
						return true;
					}
				}
			}

			for (int i = 0; i < C1.Count; i++)
			{
				for (int j = 0; j < C2.Count; j++)
				{
					string c1 = C1[i];
					string c2 = C2[j];

					f = MatchGroups(FinishGroups, c1, c2);
					if (f)
					{
						return true;
					}
				}
			}

			return f;
		}
		private bool AnuSeriesYati(string s1, string s2)
		{
			bool f = false;
			bool _f1 = StringPlus.Contains("ంట,ంఠ,ండ,ంఢ", s1);
			bool _f2 = StringPlus.Contains("ంత,ంథ,ంద,ంధ", s2);
			if (_f1 && _f2)
			{
				//అనుస్వార సంబంధ యతులు
				return true;
			}
			if (_f1)
			{
				bool _f = StringPlus.Contains("న", s2);
				if (_f)
				{
					//అనునాసికాక్షర యతులు
					return true;
				}
			}
			if (_f1)
			{
				bool _f = StringPlus.Contains("ణ", s2);
				if (_f)
				{
					//అనునాసికాక్షర యతులు
					return true;
				}
			}
			return f;
		}
		private bool IsJhuyMatch(char c1, char c3)
		{

			//Not a good way but OK
			switch (c1)
			{
				case 'క':
					if (c3 == 'ఖ')
					{
						return true;
					}
					break;
				case 'గ':
					if (c3 == 'ఘ')
					{
						return true;
					}
					break;
				case 'చ':
					if (c3 == 'ఛ')
					{
						return true;
					}
					break;
				case 'జ':
					if (c3 == 'ఝ')
					{
						return true;
					}
					break;
				case 'ట':
					if (c3 == 'ఠ')
					{
						return true;
					}
					break;
				case 'డ':
					if (c3 == 'ఢ')
					{
						return true;
					}
					break;
				case 'త':
					if (c3 == 'థ')
					{
						return true;
					}
					break;
				case 'ద':
					if (c3 == 'ధ')
					{
						return true;
					}
					break;
				case 'ప':
					if (c3 == 'ఫ')
					{
						return true;
					}
					break;
				case 'బ':
					if (c3 == 'భ')
					{
						return true;
					}
					break;
			}
			return false;
		}
		public bool IsPrasaMatched(string s1, string s2)
		{
			//HARD FIX..
			s1 = s1.Replace("ై", "ై");
			s2 = s2.Replace("ై", "ై");

			//Eleminate Vowel
			{
				bool f1 = StringPlus.Contains(V, s1);
				bool f2 = StringPlus.Contains(V, s2);
				if (f1 || f2)
				{
					return true;
				}
			}

			TeluguParser T1 = new TeluguParser();
			IndicAkshar[] A1 = T1.Split(s1);

			TeluguParser T2 = new TeluguParser();
			IndicAkshar[] A2 = T2.Split(s2);

			List<string> C1 = ExtractConsoOrVowel(s1);
			List<string> C2 = ExtractConsoOrVowel(s2);

			if (A1.Length > 1)
			{
				//Somthing+Hallu^  then ignore Hallu^ ^=Virama..There is no standard rule found but from the convention being followed. Mostly I found Hallu=Na.
				C1 = ExtractConsoOrVowel(A1[0].ToString2());
			}

			if (A2.Length > 1)
			{
				C2 = ExtractConsoOrVowel(A2[0].ToString2());
			}

			if (C1.Count == C2.Count)
			{
				bool f = MatchPrasaConsos(C1, C2);
				if (f)
				{
					if (LastName == null)
					{
						LastName = "ప్రాసవైరము/ప్రాది ప్రాసము/శ-ప్రాసము/అభేద ప్రాస/అప్రశస్త ప్రాస/ప్రాసమైత్రి ప్రాసము/వికల్ప ప్రాస/స్వవర్గజ ప్రాసము";
					}
					return true;
				}
				return MatchSantaPrasa(C1, C2);
			}
			else
			{
				//Need  to improve this algo..
				if ((C1.Count == 1 && C2.Count == 2) || (C1.Count == 2 && C1.Count == 1))
				{
					if (C1.Count == 1 && C2.Count == 2)
					{
						if (C2[1] == La || C2[1] == Ra)
						{
							C2.RemoveAt(1);
							bool f = MatchPrasaConsos(C1, C2);//సంయుతాసంయుత ప్రాసము
							if (f)
							{
								if (LastName == null)
								{
									LastName = "సంయుతాసంయుత ప్రాసము";
								}
								return true;
							}
							return MatchSantaPrasa(C1, C2);
						}
					}
					if (C2.Count == 1 && C1.Count == 2)
					{
						if (C1[1] == La || C1[1] == Ra)
						{
							C2.RemoveAt(1);
							bool f = MatchPrasaConsos(C1, C2);//సంయుతాసంయుత ప్రాసము
							if (f)
							{
								if (LastName == null)
								{
									LastName = "సంయుతాసంయుత ప్రాసము";
								}
								return true;
							}
							return MatchSantaPrasa(C1, C2);
						}
					}
				}

				if (C1.Count == C2.Count && (A1.Length > 1 || A2.Length > 1))
				{
					//May need to check for Ax[Ax.Length-1] Ends with Virama..But OK  for now
					bool f = MatchPrasaConsos(C1, C2);
					if (f)
					{
						return true;
					}
				}
				return MatchSantaPrasa(C1, C2);
			}


		}
		private bool MatchSantaPrasa(List<string> C1, List<string> C2)
		{
			if (!this._AllowSantiPrasa)
			{
				return false;
			}

			if (C1.Count < 1 || C2.Count < 1)
			{
				return false;
			}

			bool f = (C1[0] == C2[0]);// i.e. at position 0 or 1.
			if (f)
			{
				LastName = "శాంతిప్రాసము";
				return true;
			}

			f = (C1[C1.Count - 1] == C2[C2.Count - 1]);// i.e. at position last position
			if (f)
			{
				LastName = "శాంతిప్రాసము";
				return true;
			}


			return false;
		}
		private bool TryMatch(string c1, string c2)
		{
			bool f = false;
			if (c1 == c2)
			{
				return true;

			}
			f = MatchGroups(PrasaGroups, c1, c2);
			if (f)
			{
				return true;
			}
			return f;
		}
		private bool MatchPrasaConsos(List<string> C1, List<string> C2)
		{
			//Unlike Yati all Compound Groups in the same order to be matched.Incase of yati atleast one Conso to be in it's group.
			//Ex:ర్జు,ర్జ,ర్జి,ర్జూ but not జ్రు,జ్ర,జ్రి
			bool f = false;

			if (C2.Count == 2 && C1.Count == 2)
			{
				if (C1[0] == Ra && C2[0] == C2[1] && C1[1] == C2[0])
				{
					LastName = "వలపలిగిలక ప్రాస";
					this.NoMoreChecks = true;
					return true;//వలపలిగిలక ప్రాస
				}
				if (C2[0] == Ra && C1[0] == C1[1] && C2[1] == C1[0])
				{
					LastName = "వలపలిగిలక ప్రాస";
					this.NoMoreChecks = true;
					return true;//వలపలిగిలక ప్రాస
				}

				if (C2[0] == "ఙ" && C2[1] == "ఞ" && C1[0] == "గ" && C1[1] == "న")
				{
					LastName = "వికల్ప ప్రాస";
					return true;//వికల్ప ప్రాస-II
				}
				if (C1[0] == "ఙ" && C1[1] == "ఞ" && C2[0] == "గ" && C2[1] == "న")
				{
					LastName = "వికల్ప ప్రాస";
					return true;//వికల్ప ప్రాస-II
				}

			}

			for (int i = 0; i < C1.Count; i++)
			{
				string c1 = C1[i];
				string c2 = C2[i];

				if (c1 == c2)
				{
					f = true;
					continue;
				}
				f = MatchGroups(PrasaGroups, c1, c2);
				if (!f)
				{
					return false;//If atleast one fails then no need to check further.
				}
			}
			//Seems there are some more Rules available..
			return f;
		}

		public bool IsPrasaMatched2(Prasa P1, Prasa P2)
		{
			//Matches along with Poorva
			List<string> C1 = ExtractConsoOrVowel(P1.Value);
			List<string> C2 = ExtractConsoOrVowel(P2.Value);

			bool f1 = StringPlus.EndsWith(P1.Poorva, SUNNA);
			bool f2 = StringPlus.EndsWith(P2.Poorva, SUNNA);

			if (f1 && C1.Count == 1 && C1[0] == HA && C2.Count == 2 && C2[0] == HA && C2[1] == "వ")
			{
				LastName = "వికల్ప ప్రాస";
				return true;// వికల్ప ప్రాస-II
			}
			if (f2 && C2.Count == 1 && C2[0] == HA && C1.Count == 2 && C1[0] == HA && C1[1] == "వ")
			{
				LastName = "వికల్ప ప్రాస";
				return true;// వికల్ప ప్రాస-II
			}

			if (f1 && C1.Count == 1 && (C1[0] == "న" || C1[0] == "మ") && C2.Count == 2 && C2[0] == C2[1] && (C2[0] == C1[0]))
			{
				LastName = "అనునాసిక ప్రాసము";
				this.NoMoreChecks = true;
				return true;//అనునాసిక ప్రాసము
			}
			if (f2 && C2.Count == 1 && (C2[0] == "న" || C2[0] == "మ") && C1.Count == 2 && C1[0] == C1[1] && (C2[0] == C1[0]))
			{
				LastName = "అనునాసిక ప్రాసము";
				this.NoMoreChecks = true;
				return true;//అనునాసిక ప్రాసము
			}

			if (f1 && C1.Count == 1 && C1[0] == "బ" && C2.Count == 2 && C2[0] == C2[1] && C2[0] == "మ")
			{
				LastName = "ప్రాసమైత్రి ప్రాస";
				this.NoMoreChecks = true;
				return true;//ప్రాసమైత్రి ప్రాస
			}

			if (f2 && C2.Count == 1 && C2[0] == "బ" && C1.Count == 2 && C1[0] == C1[1] && C1[0] == "మ")
			{
				LastName = "ప్రాసమైత్రి ప్రాస";
				this.NoMoreChecks = true;
				return true;//ప్రాసమైత్రి ప్రాస
			}

			if (f1 && f2 && (C1.Count >= 1 && C2.Count >= 1) && ((C1[0] == "బ" && C2[0] == "మ") || (C2[0] == "మ" && C1[0] == "బ")))
			{
				LastName = "ప్రాసమైత్రి ప్రాస";
				this.NoMoreChecks = true;
				return true;//ప్రాసమైత్రి ప్రాస
			}

			//న+్+హల్లు=ం+హల్లు
			if (C1.Count == 2 && C1[0] == "న" && f2 && C2.Count == 1 && C2[0] == C1[1])
			{
				LastName = "బిందు ప్రాసము";
				return true;//బిందు ప్రాసము
			}
			if (C2.Count == 2 && C2[0] == "న" && f1 && C1.Count == 1 && C1[0] == C2[1])
			{
				LastName = "బిందు ప్రాసము";
				return true;//బిందు ప్రాసము
			}
			return false;
		}

		public bool IsPrasaMatched3(Prasa P1, Prasa P2)
		{
			this.NoMoreChecks = false;
			bool res = IsPrasaMatched(P1.Value, P2.Value);
			if (!res)
			{
				res = IsPrasaMatched2(P1, P2);
			}
			return res;
		}
	}
}



#region Special అ Group Not found anywhere-- Is a wrong group. Hence removing...
//{
//bool f1 = s1.Length == 1 && StringPlus.Contains ( V , s1 );
//bool f2 = s2.Length == 1 && StringPlus.Contains ( V , s2 );
//if ( f1  || f2)
//{
//    f=StringPlus.Contains ( Conso , f1 ? s2 : s1 );
//    if ( f )
//    {
//        return true;
//    }

//    f = StringPlus.Contains ( f1 ? s2 : s1 , SUNNA.ToString() );
//    if ( f )
//    {
//        return true;
//    }

//    f = StringPlus.Contains ( f1 ? s2 : s1 , VISARGA );
//    if ( f )
//    {
//        return true;
//    }

//}

//}
#endregion