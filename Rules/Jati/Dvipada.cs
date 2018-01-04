//---------------------------------------------------------------------------------------------
// <copyright file="Dvipada.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Jati.Dvipada
{
	public class dvipada : Rule
	{
		public dvipada()
		{

			Lines = 2;
			Threshold = 4;


			Name = "ద్విపద";
			Identifier = "dvipada";
			Examples = new string[] {   "శ్రీకామినీనాధుజితదైత్యనాధు\nలోకరక్షణకృత్యులోకైకనిత్యు" ,
										"నడురాత్రి యరుదెంచెనరలోకనాధ\nకడుడస్సినాడవుకనుమోడ్తుగాక",
										"ఇంద్ర గణములు మూఁ డిన గణంబొకటి\nచంద్రాస్య ! ద్విపదకుఁ జను చెప్పరేచ",
										"ద్విపదకు ద్విపదకుఁ దెగ జెప్పవలయు\nనెపుడు సంస్కృతమున నితర భాషలను",
										"యతుల లోపలఁ బ్రాసయతి దక్క సకల\nయతులు చెల్లును బ్రయో గాతి సారమున",
										"ద్విపద తో ద్విపద సంధిల నేకశబ్ద\nమపుడు రెంటను గూర్ప నది యయుక్తంబు",
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">2</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">మూడు ఇంద్ర , ఒక సూర్య</span> గణములుండును.</li></ol></div>";


			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Divpada;

			Rules = new object[][] { new object[] { Category.Indra, Category.Indra, Category.Indra, Category.Surya } };
			Yati = new int[][] { new int[] { 3 } };


			Prasa = true;
			PrasaYati = false;



		}
	}
	public class dvipadamaalika : Rule
	{
		public dvipadamaalika()
		{
			Lines = 4;
			Threshold = 4;

			Name = "ద్విపదమాలిక";
			Identifier = "dvipadamaalika";
			Examples = new string[] { "శ్రీకామినీనాధుజితదైత్యనాధు\nలోకరక్షణకృత్యులోకైకనిత్యు\nనడురాత్రి యరుదెంచెనరలోకనాధ\nకడుడస్సినాడవుకనుమోడ్తుగాక" };
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">మూడు ఇంద్ర , ఒక సూర్య</span> గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Divpada;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] { new object[] { Category.Indra, Category.Indra, Category.Indra, Category.Surya } };
			Yati = new int[][] { new int[] { 3 } };


			Prasa = true;
			PrasaYati = false;
		}
	}
	public class maMjareedvipada : Rule
	{
		public maMjareedvipada()
		{
			Lines = 4;
			Threshold = 4;

			Name = "మంజరీ ద్విపద";
			Identifier = "maMjareedvipada";
			Examples = new string[] {
									"శ్రీకామినీనాధుజితదైత్యనాధు\nలోకరక్షణకృత్యులోకైకనిత్యు\nనడురాత్రి యరుదెంచెనరలోకనాధ\nకడుడస్సినాడవుకనుమోడ్తుగాక" ,
									"శ్రీమందిరాకారు జితదైత్యధీరుఁ\nగీర్తించుచోఁ బుణ్యవర్తనుం డనుచు\nయతిమాఱు ప్రాస మి ట్లచ్చోట నిడక\nసరసిజనాభాయ సముదగ్రసాహ",
									"సాయ నమోయంచు శబ్దమొక్కటియు\nరెండుపాదముల నీక్రియఁ బంచియిడక\nవెలయు ప్రాసములేని ద్విపద యై పరఁగఁ\nబూజింపవలయు వాక్పుష్పమంజరుల.",
									"ఇంద్రులు మువ్వురు నినుఁ డొక్కరుండు\nసాంద్రమై యొక్కొక్కచరణంబుఁ గొలువ\nనలరుఁ బద్మోదరుఁ డంచు ధీరోత్త\nములు విస్తరింతురు ముదముతో ద్విపద.",
									"శ్రీమందిరాకారు జితదైత్యధీరు\nగీర్తించుచోఁ బుణ్యవర్తనుఁ డనుచు\nయతిమాఱు ప్రాసమిట్లచ్చోట నిడక\nసరసిజనాభాయ సముదగ్ర సాహ",
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">మూడు ఇంద్ర , ఒక సూర్య</span> గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Divpada;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {new object[]{Category.Indra,Category.Indra,Category.Indra,
													Category.Surya
									}};
			Yati = new int[][] { new int[] { 3 } };


			Prasa = false;
			PrasaYati = true;



		}
	}
}