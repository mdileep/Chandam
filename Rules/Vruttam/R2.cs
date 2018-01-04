//---------------------------------------------------------------------------------------------
// <copyright file="R2.cs" company="Chandam-ఛందం">
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
	public class stree : Rule
	{
		public stree()
		{
			Lines = 4;
			Threshold = 2;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "గా".Split(',') };
			Yati = new int[][] { };


			Identifier = "stree";
			Name = "స్త్రీ";
			Examples = new string[] { "స్త్రీరూ\nపారున్‌\nఘోరా\nఘోరీ.", "స్త్రీరూ\nపారుం\nగారూ\nపారున్" };
		}
	}
}
