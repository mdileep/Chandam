//---------------------------------------------------------------------------------------------
// <copyright file="R1.cs" company="Chandam-ఛందం">
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
	public class Sree : Rule
	{
		public Sree()
		{
			Lines = 4;
			Threshold = 1;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = false;
			PrasaYati = false;

			Rules = new string[][] { new string[] { "గ" } };
			Yati = new int[][] { };


			Identifier = "Sree";
			Name = "శ్రీ (శ్రీః)";
			Examples = new string[] { "శ్రీ\nశ్రీం\nజే\nయున్", "శ్రీ\nభా\nవిం\nతున్‌." };
		}
	}
}
