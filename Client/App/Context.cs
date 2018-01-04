//---------------------------------------------------------------------------------------------
// <copyright file="Context.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using MiriyamApp.External;

namespace Chandam.Core
{
	public class Context
	{
		public static RuleLanguage Language
		{
			get { return _GetTarget(); }
		}

		private static RuleLanguage _GetTarget()
		{
			RuleLanguage lang = RuleLanguage.Telugu;
			try
			{
				lang = (RuleLanguage)Window2.Language;
			}
			catch
			{
			}

			switch (lang)
			{
				case RuleLanguage.Telugu:
				default: return RuleLanguage.Telugu;

				case RuleLanguage.Kannada:
					return RuleLanguage.Kannada;
			}

		}
	}
}
