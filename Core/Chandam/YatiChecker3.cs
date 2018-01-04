//---------------------------------------------------------------------------------------------
// <copyright file="YatiChecker3.cs" company="Chandam-ఛందం">
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
		IndicParser I;
		string Conso;
		string Y;
		string F;
		string YF;
		string V;
		string AGroup;
		string RuKaaram;
		string Ru;
		string[] VowelGroups;
		string[] VowelAndFinishGroups;
		string[] ConsoGroups;
		string[] FinishGroups;
		string RuGroup;
		char SUNNA;
		string HA;
		char Virama;
		string[] PrasaGroups;
		private string _last;
		bool _AllowSantiPrasa;
		bool _NoMoreChecks;
		bool _SoundBasedSandi;

		public YatiPrasaChecker2()
		{
			//Mostly Redundant .. To be improved..

			I = new IndicParser();
			I.CharSet = new TeluguCharSet();
			Virama = '్';
			HA = "హ";
			Conso = "క,ఖ,గ,ఘ,ఙ,చ,ఛ,జ,ఝ,ఞ,ట,ఠ,డ,ఢ,ణ,త,థ,ద,ధ,న,ప,ఫ,బ,భ,మ,య,ర,ఱ,ల,ళ,వ,శ,ష,స,హ";
			Y = "అ,ఆ,ఇ,ఈ,ఉ,ఊ,ఋ,ఎ,ఏ,ఌ,ౡ,ఐ,ఒ,ఓ,ఔ,ౠ,క,ఖ,గ,ఘ,ఙ,చ,ఛ,జ,ఝ,ఞ,ట,ఠ,డ,ఢ,ణ,త,థ,ద,ధ,న,ప,ఫ,బ,భ,మ,య,ర,ఱ,ల,ళ,వ,శ,ష,స,హ";
			YF = "ాిీుూృౄెేైొోౌంఃౖఽౣౢఅ,ఆ,ఇ,ఈ,ఉ,ఊ,ఋ,ఎ,ఏ,ఌ,ఐ,ఒ,ఓ,ఔ,ౠ,ఌ,ౡ";
			V = "అ,ఆ,ఇ,ఈ,ఉ,ఊ,ఋ,ఎ,ఏ,ఌ,ఐ,ఒ,ఓ,ఔ,ౠ,ఌ,ౡ";
			//F = "ాిీుూృౄెేైొోౌంఃౖౣౢ";
			F = "ాిీుూృౄెేైొోౌఃౖౣౢ";//Removing ం from List because Sunna as ex: ki &kIM are also valid parirs. Simple ignore Sunna too.

			RuKaaram = "ృ";
			Ru = "ఋ";
			RuGroup = "ఇ,ఈ,ఋ,ౠ,ఎ,ఏ,ి,ీ,ృ,ౄ,ె,ే";
			AGroup = "ా,ై ,ౌ,ం";
			SUNNA = 'ం';


			PrasaGroups = new string[]
			{
			"ఱ,ర",//ప్రాసవైరము
			"న,ణ", //ప్రాది ప్రాసము
			"స,ష,శ",//శ-ప్రాసమ+ప్రాది ప్రాసము
			"ల,ళ,డ,ర",//అభేద ప్రాస+ప్రాసమైత్రి ప్రాసము
			"ప,వ",//అభేద ప్రాస
			"గ,ఙ",//వికల్ప ప్రాస
			"జ,ఞ",//వికల్ప ప్రాస
			"డ,ణ",//వికల్ప ప్రాస
			"ద,న",//వికల్ప ప్రాస
			"బ,మ",//వికల్ప ప్రాస
			"ద,డ",//అప్రశస్త ప్రాస
			"క,గ",//స్వవర్గజ ప్రాసము
			"ఖ,ఘ",//స్వవర్గజ ప్రాసము
			"గ,ఘ",//స్వవర్గజ ప్రాసము
			"చ,జ",//స్వవర్గజ ప్రాసము
			"ఛ,ఝ",//స్వవర్గజ ప్రాసము
			"జ,ఝ",//స్వవర్గజ ప్రాసము
			"ట,డ",//స్వవర్గజ ప్రాసము
			"ఠ,ఢ",//స్వవర్గజ ప్రాసము
			"డ,ఢ",//స్వవర్గజ ప్రాసము
			"త,ద",//స్వవర్గజ ప్రాసము
			"థ,ధ",//స్వవర్గజ ప్రాసము
			"ద,ధ",//స్వవర్గజ ప్రాసము
			"ప,బ",//స్వవర్గజ ప్రాసము
			"ఫ,భ",//స్వవర్గజ ప్రాసము
			"బ,భ",//స్వవర్గజ ప్రాసము
			};
			VowelGroups = new string[] {
										"అ,ఆ,ఐ,ఔ",
										"ఇ,ఈ,ఋ,ౠ,ఎ,ఏ",
										"ఉ,ఊ,ఒ,ఓ",
										};

			VowelAndFinishGroups = new string[] {
												"అ,ఆ,ఐ,ఔ,ా,ై ,ౌ",
												"ఇ,ఈ,ఋ,ౠ,ఎ,ఏ,ి,ీ,ృ,ౄ,ె,ే",
												"ఉ,ఊ,ఒ,ఓ,ు,ూ,ొ,ో"
												};

			ConsoGroups = new string[] {
										"క,ఖ,గ,ఘ",
										"చ,ఛ,జ,ఝ",
										"ట,ఠ,డ,ఢ",
										"త,థ,ద,ధ",
										"ప,ఫ,బ,భ",
										"య,హ",//ఋజు యతులు
										"ర,ఱ",//ఏకతరయతులు
										"వ,బ",//అభేద విరతులు
										"ల,ళ",//అభేద విరతులు
										"ల,డ",//అభేద విరతులు
										"ప,వ",//అభేద వర్గ విరతులు
										"ఫ,వ",//అభేద వర్గ విరతులు
										"బ,వ",//అభేద వర్గ విరతులు
										"భ,వ",//అభేద వర్గ విరతులు
										"శ,ష,స",//ఊష్మ విశ్రాంతులు
										"చ,ఛ,జ,ఝ,శ,ష,స",//సరసయతి 
										"న,ణ",//సరసయతి ,
										"ల,ళ,డ,ర"//Special Yati Same as Abhedha
										};

			FinishGroups = new string[] {
											"ా,ై,ౌ,ం",
											"ి,ీ,ృ,ౄ,ె,ే",
											"ు,ూ,ొ,ో"
										};

		}
		private List<string> ExtractConsoOrVowel(string s1)
		{
			List<string> L = new List<string>();
			foreach (char c in StringPlus.ToCharArray(s1))
			{
				bool f = StringPlus.Contains(Y, c.ToString());
				if (f)
				{
					L.Add(c.ToString());
				}
			}
			return L;
		}
		private List<string> ExtractVowelorFinish(string s1)
		{
			List<string> L = new List<string>();
			foreach (char c in StringPlus.ToCharArray(s1))
			{
				bool f = StringPlus.Contains(YF, c.ToString());
				if (f)
				{
					L.Add(c.ToString());
				}
			}
			return L;
		}
		private List<string> ExtractConso(string s1)
		{
			List<string> L = new List<string>();
			IndicAkshar IA = new IndicAkshar();
			IA.SetChars(s1, I.CharSet);
			foreach (char c in StringPlus.ToCharArray(s1))
			{
				bool f = StringPlus.Contains(Conso, c.ToString());
				if (f)
				{
					L.Add(c.ToString());
				}
			}
			return L;
		}
		private List<string> ExtractFinish(string s1)
		{
			List<string> L = new List<string>();
			foreach (char c in StringPlus.ToCharArray(s1))
			{
				bool f = StringPlus.Contains(F, c.ToString());
				if (f)
				{
					L.Add(c.ToString());
				}
			}
			return L;
		}
		private List<string> ExtractConsoOrFinish(string s1)
		{
			List<string> L = new List<string>();
			foreach (char c in StringPlus.ToCharArray(s1))
			{
				bool f = StringPlus.Contains(Y, c.ToString());
				if (f)
				{
					L.Add(c.ToString());
				}
			}
			return L;
		}
		private bool MatchGroups(string[] Groups, string c1, string c2)
		{
			bool f = false;
			foreach (string group in Groups)
			{
				f = IsGroupMatched(group, c1, c2);
				if (f)
					return true;
			}

			return false;
		}
		private bool IsGroupMatched(string g, string s1, string s2)
		{
			bool f = StringPlus.Contains(g, s1) && StringPlus.Contains(g, s2);
			return f;
		}
		public string LastName
		{
			get
			{
				return _last;
			}
			set
			{
				_last = value;
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
			}
		}
		public bool SoundexSandhi
		{
			get
			{
				return _SoundBasedSandi;
			}
			set
			{

				_SoundBasedSandi = value;
			}
		}
		public bool NoMoreChecks
		{
			get
			{
				return _NoMoreChecks;
			}
			set
			{

				_NoMoreChecks = value;
			}
		}
	}

}