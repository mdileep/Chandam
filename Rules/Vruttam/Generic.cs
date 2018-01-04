//---------------------------------------------------------------------------------------------
// <copyright file="Generic.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Vruttam
{
	public class GenricVruttam : Rule
	{
		public GenricVruttam()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "GenricVruttam";
			Name = "ఏదేని సమ వృత్తం";
			Examples = new string[]{

									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.GenricVruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { new string[] { } };
			Yati = new int[][] { };


			Prasa = false;
			PrasaYati = false;


		}
	}
}

/*
 public class maMgaLamahaaSrI : Rule
	{
		public maMgaLamahaaSrI ()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "maMgaLamahaaSrI";
			Name = "మంగళమహాశ్రీ";
						Examples = new string[]{  
									
									};
			


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "భ జ స న భ జ స న గా".Split ( ' ' ) };
			Yati = new int[][] { };

			
			Prasa = true;
			PrasaYati = false;
		}
	}
 */
