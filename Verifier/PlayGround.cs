//---------------------------------------------------------------------------------------------
// <copyright file="PlayGround.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using Chandam.Rules.Rare;
using SearchEngine.Services.Indic;
using System;

namespace Verifier
{
	class PlayGround
	{

		internal void Play2()
		{


		}

		internal void Play()
		{
			string s = Converter.Convert(@"ఉత్తరదిశకుఁబోయితి హిమవ దుర్విధరమునవాలియై
కత్తళమనుచుఁబోయిపరుగునఁ గ్రౌంచగిరిపయివాలియై
జొత్తిలనడుగుదోయితుదికొససోమగిరిపయివాలియై
తత్తరపడుచువేరుదెసమదితట్టకముడుగుచుండఁగా.", Language.Telugu, Language.Kannada);

			Matcher(s);

			Identifier(s);

		}
		private void Identifier(string s)
		{
			MatchOptions Options = MatchOptions.QucikMatchSettings;
			Options.Language = RuleLanguage.Kannada;
			Options.MatchYati = false;
			Options.MatchPrasa = true;


			Probable Pr = Padyam.MostProbable(s, Options);
			MatchResult MR = Pr.MatchResult;
			Console.Write(MR.Percentage);
		}
		private void Matcher(string s)
		{
			Rule R = new karibRMhitamu();
			R.Language = RuleLanguage.Kannada;

			Padyam P = new Padyam();
			P.MatchPrasa = true;
			P.MatchYati = false;

			MatchResult MR = P.Match(s, R);

			Console.Write(MR.Percentage);
		}
	}
}
