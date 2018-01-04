//---------------------------------------------------------------------------------------------
// <copyright file="YatiPrasaTester.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Indic;
using Chandam.Rules;
using Chandam.Util;


namespace Chandam.Extensions
{
	public class YatiPrasaTester
	{
		public string p1;
		public string p2;
		const string PRASA = "'ప్రాస'";
		const string PRASA_YATI = "'ప్రాసయతి'";
		const string YATI = "'యతి'";
		RuleLanguage lang;
		public YatiPrasaTester()
		{
			lang = RuleLanguage.Telugu;
		}
		public string CheckPrasa(string s1, string s2, bool allowSantiPrasa)
		{
			YatiPrasaChecker2 Y = new YatiPrasaChecker2();
			s1 = s1.Replace(" ", "");
			s2 = s2.Replace(" ", "");

			Y.AllowSantiPrasa = allowSantiPrasa;
			Y.SoundexSandhi = false;
			GanaVibhajana G1 = new GanaVibhajana(s1, lang);
			GanaVibhajana G2 = new GanaVibhajana(s2, lang);

			if (G1.GWiseString.Count == 0)
			{
				return "<span class='gName'>Group-1 is not valid</span>";
			}
			if (G2.GWiseString.Count == 0)
			{
				return "<span class='gName'>Group-2 is not valid</span>";
			}

			bool f = false;
			if (G1.GWiseString.Count > 1 && G2.GWiseString.Count > 1)
			{
				p1 = G1.GWiseString[0] + "<u>" + G1.GWiseString[1] + "</u>";
				p2 = G2.GWiseString[0] + "<u>" + G2.GWiseString[1] + "</u>";

				Prasa P1 = new Prasa(StringPlus.CharAt(G1.SymbolsStream, 0).ToString(), false, G1.GWiseString[1], G1.GWiseString[0]);
				Prasa P2 = new Prasa(StringPlus.CharAt(G2.SymbolsStream, 0).ToString(), false, G2.GWiseString[1], G2.GWiseString[0]);

				f = Y.IsPrasaMatched3(P1, P2);

				if (f && Y.NoMoreChecks)
				{
					return Success(p1, p2, PRASA, Y.LastName);
				}

				if (f)
				{
					if (P1.Symbol == Symbols.LAGHUVU)
					{
						//Nothing to do..
					}
					else
					{
						f = (P1.Symbol == P2.Symbol);
					}
				}


				if (f)
				{
					Errors E = CheckPrasaPoorva2(Y, P1, P2);
					if (E == null)
					{
						return Success(p1, p2, PRASA, Y.LastName);
					}
					return FailWith(p1, p2, E, PRASA);
				}
				else
				{
					return FailWith(p1, p2, null, PRASA);
				}
			}
			else
			{
				p1 = G1.GWiseString[0];
				p2 = G2.GWiseString[0];
				f = Y.IsPrasaMatched(p1, p2);
				if (f)
				{
					return Success(p1, p2, PRASA, Y.LastName);
				}
			}
			return FailWith(p1, p2, null, PRASA);
		}
		public string CheckYati(string s1, string s2, bool Sandhi)
		{

			GanaVibhajana G1 = new GanaVibhajana(s1, lang);
			GanaVibhajana G2 = new GanaVibhajana(s2, lang);


			if (G1.GWiseString.Count == 0)
			{
				return "<span class='gName'>Group-1 is not valid</span>";
			}
			if (G2.GWiseString.Count == 0)
			{
				return "<span class='gName'>Group-2 is not valid</span>";
			}

			string c1 = null;
			string y1 = null;
			string py1 = null;

			string c2 = null;
			string y2 = null;
			string py2 = null;

			YatiPrasaChecker2 YPC = new YatiPrasaChecker2();
			YPC.SoundexSandhi = Sandhi;

			#region...
			if (G1.GWiseString.Count == 3)
			{
				c1 = StringPlus.EndsWith(G1.GWiseString[0], 'ం') ? "ం" : null;
				y1 = G1.GWiseString[1];
				py1 = G1.GWiseString[2];
				p1 = (c1 != null) ? G1.GWiseString[0] + G1.GWiseString[1] : G1.GWiseString[1];
				p1 = p1 + G1.GWiseString[2];
			}

			if (G1.GWiseString.Count == 2)
			{
				c1 = StringPlus.EndsWith(G1.GWiseString[0], 'ం') ? "ం" : null;
				y1 = G1.GWiseString[1];
				p1 = (c1 != null) ? G1.GWiseString[0] + G1.GWiseString[1] : G1.GWiseString[1];
			}

			if (G2.GWiseString.Count == 3)
			{
				c2 = StringPlus.EndsWith(G2.GWiseString[0], 'ం') ? "ం" : null;
				y2 = G2.GWiseString[1];
				py2 = G2.GWiseString[2];
				p2 = (c2 != null) ? G2.GWiseString[0] + G2.GWiseString[1] : G2.GWiseString[1];
				p2 = p2 + G2.GWiseString[2];
			}
			if (G1.GWiseString.Count == 1)
			{
				y1 = G1.GWiseString[0];
				p1 = G1.GWiseString[0];
			}

			if (G2.GWiseString.Count == 2)
			{
				c2 = StringPlus.EndsWith(G2.GWiseString[0], 'ం') ? "ం" : null;
				y2 = G2.GWiseString[1];
				p2 = (c2 != null) ? G2.GWiseString[0] + G2.GWiseString[1] : G2.GWiseString[1];
			}
			if (G2.GWiseString.Count == 1)
			{
				y2 = G2.GWiseString[0];
				p2 = G2.GWiseString[0];
			}
			#endregion

			bool res = YPC.IsYatiMatched(p1, p2);
			if (res)
			{
				return Success(p1, p2, YATI, YPC.LastName);
			}
			else
			{
				//Context not matched  so prepare for Prasa Yati

				if (G1.GWiseString.Count == 2)
				{
					y1 = G1.GWiseString[0];
					py1 = G1.GWiseString[1];
				}

				if (G2.GWiseString.Count == 2)
				{
					y2 = G2.GWiseString[0];
					py2 = G2.GWiseString[1];
				}

				res = YPC.IsYatiMatched(y1, y2);
				if (res)
				{
					return Success(y1, y2, YATI, YPC.LastName);
				}
				else
				{
					string s = FailWith(p1, p2, null, YATI);
					if (G1.GWiseString.Count > 1 && G2.GWiseString.Count > 1)
					{
						s = s + "<br/>అందువల్ల ప్రాస యతి సరి పోతుందేమో చూస్తున్నా<br/>";
						s = s + CheckPrasa(py1, py2, false);
					}
					return s;
				}
			}
		}
		private Errors CheckPrasaPoorva2(YatiPrasaChecker2 Y, Prasa p1, Prasa p2)
		{
			char SUNNA = 'ం';
			char VISARGA = 'ః';
			if (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == SUNNA)
			{
				if (StringPlus.CharAt(p2.Poorva, p2.Poorva.Length - 1) == SUNNA)
				{
					Y.LastName = (Y.LastName == null) ? "బిందుపూర్వక ప్రాసము" : Y.LastName + "(విసర్గపూర్వక ప్రాసము)";
					return null;
				}
				else
				{
					Errors E = new Errors();
					E.Actual = p1.Value;
					E.Expected = "'" + SUNNA + "'  తో కూడిన అక్షరం";
					E.Mismatch = p1.IsAnthyaPrasa ? Mismatch.AnthyaPrasaPoorvaBindu : Mismatch.PrasaPoorvaBindu;
					return E;
				}
			}
			else
			{
				if (StringPlus.CharAt(p1.Poorva, p1.Poorva.Length - 1) == VISARGA)
				{
					if (StringPlus.CharAt(p2.Poorva, p2.Poorva.Length - 1) == VISARGA)
					{
						Y.LastName = (Y.LastName == null) ? "విసర్గపూర్వక ప్రాసము" : Y.LastName + "(విసర్గపూర్వక ప్రాసము)";
						return null;
					}
					else
					{
						Errors E = new Errors();
						E.Actual = p1.Value;
						E.Expected = "'" + VISARGA + "'  తో కూడిన అక్షరం";
						E.Mismatch = p1.IsAnthyaPrasa ? Mismatch.AnthyaPrasaPoorvaVisarga : Mismatch.PrasaPoorvaVisarga;
						return E;
					}
				}
			}
			return null;
		}
		private bool YatiMatcher(string p1, string p2)
		{
			return new YatiPrasaChecker2().IsYatiMatched(p1, p2);
		}
		private string Success(string s1, string s2, string objective, string which)
		{
			return "<span class='gName'>" + s1 + "</span> , <span class='gName'>" + s2 + "</span> లకు  " + objective + " సరిపోయింది.<br/> ఏ " + objective + ": <span class='gName'>" + (which == null ? "--" : which) + "</span> ";
		}
		private string FailWith(string s1, string s2, Errors E, string objective)
		{
			string s = "<span class='gName'>" + s1 + "</span> , <span class='gName'>" + s2 + "</span> లకు  " + objective + " సరిపోలేదు.";
			if (E != null)
			{
				s = s + "<br/> కారణం: " + "<span class='gName'>" + E.Expected + "</span>";
			}
			return s;
		}
	}
}


//if ( G1.GWiseString.Count == 2 || G2.GWiseString.Count == 2 )
//{
//    //Try with Prasa Yati.
//    if ( G1.GWiseString.Count == 3 )
//    {
//        c1 = StringPlus.EndsWith ( G1.GWiseString[0] , 'ం' ) ? "ం" : null;
//        y1 = G1.GWiseString[1];
//        py1 = G1.GWiseString[2];
//        p1 = ( c1 != null ) ? G1.GWiseString[0] + G1.GWiseString[1] : G1.GWiseString[1];
//        p1 = p1 + G1.GWiseString[2];
//    }

//    if ( G1.GWiseString.Count == 2 )
//    {
//        c1 = StringPlus.EndsWith ( G1.GWiseString[0] , 'ం' ) ? "ం" : null;
//        y1 = G1.GWiseString[1];
//        p1 = ( c1 != null ) ? G1.GWiseString[0] + G1.GWiseString[1] : G1.GWiseString[1];
//    }

//    if ( G2.GWiseString.Count == 3 )
//    {
//        c2 = StringPlus.EndsWith ( G2.GWiseString[0] , 'ం' ) ? "ం" : null;
//        y2 = G2.GWiseString[1];
//        py2 = G2.GWiseString[2];
//        p2 = ( c2 != null ) ? G2.GWiseString[0] + G2.GWiseString[1] : G2.GWiseString[1];
//        p2 = p2 + G2.GWiseString[2];
//    }
//    if ( G1.GWiseString.Count == 1 )
//    {
//        y1 = G1.GWiseString[0];
//        p1 = G1.GWiseString[0];
//    }

//    if ( G2.GWiseString.Count == 2 )
//    {
//        c2 = StringPlus.EndsWith ( G2.GWiseString[0] , 'ం' ) ? "ం" : null;
//        y2 = G2.GWiseString[1];
//        p2 = ( c2 != null ) ? G2.GWiseString[0] + G2.GWiseString[1] : G2.GWiseString[1];
//    }
//    if ( G2.GWiseString.Count == 1 )
//    {
//        y2 = G2.GWiseString[0];
//        p2 = G2.GWiseString[0];
//    }

//    bool res=YPC.IsYatiMatched ( p1 , p2 );//Try Direct Match

//    if ( !res )
//    {
//        res = YatiMatcher ( p1 , p2 );
//    }

//    if ( res )
//    {
//        return Success ( p1 , p2 , "ప్రాస యతి" );
//    }
//    else
//    {
//        return FailWith ( p1 , p2 , null, "ప్రాస యతి" );
//    }
//}




//if ( G1.GWiseString.Count == 2 )
//{
//c1 = StringPlus.EndsWith ( G1.GWiseString[0] , 'ం' ) ? "ం" : null;
//y1 = G1.GWiseString[1];
//p1 = ( c1 != null ) ? G2.GWiseString[0] + G1.GWiseString[1] : G1.GWiseString[1];
//}

//if ( G1.GWiseString.Count == 1 )
//{
//y1 = G1.GWiseString[0];
//p1 = G1.GWiseString[0];
//}

//if ( G2.GWiseString.Count == 2 )
//{
//c2 = StringPlus.EndsWith ( G2.GWiseString[0] , 'ం' ) ? "ం" : null;
//y2 = G2.GWiseString[1];
//p2 = ( c2 != null ) ? G2.GWiseString[0] + G2.GWiseString[1] : G2.GWiseString[1];
//}

//if ( G2.GWiseString.Count == 1 )
//{
//y2 = G2.GWiseString[0];
//p2 = G2.GWiseString[0];
//}