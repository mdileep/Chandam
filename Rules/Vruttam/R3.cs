//---------------------------------------------------------------------------------------------
// <copyright file="R3.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Rare
{
	public class mRgi : Rule
	{
		public mRgi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "ర" } };
			Yati = new int[][] { };

			Identifier = "mRgi";
			Name = "మృగీ";
			Examples = new string[] { "విన్ము రే\nఫన్మృగీ\nమున్ముగాఁ\nజిన్మయా" };
		}
	}
	public class naaree : Rule
	{
		public naaree()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { new string[] { "మ" } };
			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "naaree";
			Name = "నారీ (జన , పుష్ప , మద , మధు , బలి)";
			Examples = new string[] { "నారీవృ\nత్తారంభం\nబారున్మా\nకారం బై", "నారీలో\nకారాధ్యా\nసారస్యా\nధారాధ్యా" };
		}
	}
	public class vinayaM : Rule
	{
		public vinayaM()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { new string[] { "స" } };

			Yati = new int[][] { };


			Identifier = "vinayaM";
			Name = "వినయము (రమణః)";
			Examples = new string[] { "వినయం\n	బొనరిం\n	తు ననం\nతునకున్‌." };
		}
	}
}
