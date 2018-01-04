//---------------------------------------------------------------------------------------------
// <copyright file="MatchOptions.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;

namespace Chandam.Core
{
	public class MatchOptions
	{
		bool _MatchYati;
		bool _MatchPrasa;
		bool _AllowSantiPrasa;
		bool _QuickMatch;
		bool _IncludeRare;
		bool _ExperimenatalSandhi;
		RuleLanguage _lang;

		public static MatchOptions QucikMatchSettings
		{
			get
			{
				MatchOptions Options = new MatchOptions();
				Options.AllowSantiPrasa = false;
				Options.IncludeRare = true;
				Options.MatchPrasa = true;
				Options.MatchYati = true;
				Options.QuickMatch = true;
				Options.ExperimenatalSandhi = true;
				Options.Language = RuleLanguage.Telugu;
				return Options;
			}
		}

		public static MatchOptions TradtionalMatchSettings
		{
			get
			{
				MatchOptions Options = new MatchOptions();
				Options.AllowSantiPrasa = false;
				Options.IncludeRare = true;
				Options.MatchPrasa = true;
				Options.MatchYati = true;
				Options.QuickMatch = false;
				Options.ExperimenatalSandhi = true;
				Options.Language = RuleLanguage.Telugu;
				return Options;
			}
		}

		public bool ExperimenatalSandhi
		{
			get
			{
				return _ExperimenatalSandhi;
			}
			set
			{
				_ExperimenatalSandhi = value;
			}
		}

		public bool IncludeRare
		{
			get
			{
				return _IncludeRare;
			}
			set
			{
				_IncludeRare = value;
			}
		}

		public bool QuickMatch
		{
			get
			{
				return _QuickMatch;
			}
			set
			{
				_QuickMatch = value;
			}
		}

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
			}
		}

		public RuleLanguage Language
		{
			get
			{
				return _lang;
			}
			set
			{
				_lang = value;
			}
		}
	}
}
