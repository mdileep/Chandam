//---------------------------------------------------------------------------------------------
// <copyright file="R9.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:27EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Rare
{
	public class halamukhi : Rule
	{
		public halamukhi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,న,స".Split(',') };

			Yati = new int[][] { };


			Identifier = "halamukhi";
			Name = "హలముఖి";
			Examples = new string[] {   "చిత్తజాతుని గురునికై\nయెత్తుఁ డంజలు లనినచో\nసత్తుగా రనసములొగిన్‌\nబొత్తుగా హలముఖి యగున్‌.",
										"ఎంతలేసికుటిలులు రా\nవింతలైనవలపులు రా\nజంతలింక తెలియును లే\nస్వాంతమందుశిఖులెగయన్"
									};
		}
	}

	public class bhujagaSiSirutamu : Rule
	{
		public bhujagaSiSirutamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,న,య".Split(',') };
			Yati = new int[][] { };


			Identifier = "bhujagaSiSirutamu";
			Name = "భుజంగశిశురుతము";
			Examples = new string[] {   "నిజమున ననయలొప్పన్\nభుజగశిశురుతమయ్యెన్\nసుజనవినుతచరిత్రా\nవృజినతృణఘనదాత్రా."
									};
		}
	}

	public class bhujaMgaSiSirutamu : Rule
	{
		public bhujaMgaSiSirutamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,మ".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "bhujaMgaSiSirutamu";
			Name = "భుజగశిశురుతము (భుజగశిశుభృతా)";
			Examples = new string[] {   "భుజగశిశురుతన్నామల్\nభుజగశిశురుతన్నామల్\nభుజగశిశురుతన్నామల్\nభుజగశిశురుతన్నామల్"
									};
		}
	}

	public class bhadrakamu1 : Rule
	{
		public bhadrakamu1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,న,ర".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "bhadrakamu1";
			Name = "భద్రకము-1";
			Examples = new string[] {
										"కాద్రవేయశయనా సము\nన్నిద్రదైత్యమదభంజనా\nరుద్రమిత్ర రనరేఫముల్\nభద్రకంబునకు భాసిలున్."
									};
		}
	}

}
