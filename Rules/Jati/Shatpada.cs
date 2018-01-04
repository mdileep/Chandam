//---------------------------------------------------------------------------------------------
// <copyright file="Shatpada.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Jati.Shatpada
{
	public class vaardhakashaTpada : Rule
	{
		public vaardhakashaTpada()
		{

			Lines = 6;
			Threshold = 5;


			Name = "వార్ధక షట్పద";
			Identifier = "vaardhakashaTpada";
			Examples = new string[] {

									};

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Shatpada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] {new object[]{5,5,5,5},
									new object[]{5,5,5,5},
									new object[]{5,5,5,5,5,5,2},
									new object[]{5,5,5,5},
									new object[]{5,5,5,5},
									new object[]{5,5,5,5,5,5,2},
								};
			Yati = new int[][] { };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class parivardinishaTpada : Rule
	{
		public parivardinishaTpada()
		{

			Lines = 6;
			Threshold = 4;


			Name = "పరివర్ధినీ షట్పద";
			Identifier = "parivardinishaTpada";
			Examples = new string[] {

									};

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Shatpada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] {new object[]{4,4,4,4},
									new object[]{4,4,4,4},
									new object[]{4,4,4,4,4,4,2},
									new object[]{4,4,4,4},
									new object[]{4,4,4,4},
									new object[]{   4,4,4,4,4,4,2},
								};
			Yati = new int[][] { };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class bhaamineeshaTpada : Rule
	{
		public bhaamineeshaTpada()
		{

			Lines = 6;
			Threshold = 4;


			Name = "భామినీ షట్పద";
			Identifier = "bhaamineeshaTpada";
			Examples = new string[] {
									"చెలియ బంగరు చెలిమి బంగరు\nవలపు బంగారమని చెబితివి\nచెలిని చూడవు కాదు సరి యిది చిలిపి కృష్ణయ్యా\nకలత నిద్దురలోన కంటిని\nకలువ కన్నుల వాని కలలో\nనులికి పడి లేచితిని నేనిట చిలిపి కృష్ణయ్యా",
									"వెలిగె నాకాశమున తారలు\nవెలిగె నాకాశమున చంద్రుడు\nవెలుగు నవ్వుల రూపు చూపర చిలిపి కృష్ణయ్యా\nపలుకు వజ్రపు తునకలా హరి\nపిలిచి యలసితి పిలుపు వినదా\nచిలుకరించగ సుధల వడి రా చిలిపి కృష్ణయ్యా",
									"తలచు కోగనె తనివి గూర్చెడి\nపలుకు జెలియవు పలుకు పడతివి\nవెలుగు నిచ్చెడి వెలదివీవవి కేలు మోడ్చంగా\nఅలుక బూనిన యటుల ఆటలు !\nపలుకు లీనని పచ్చి కోతలు !\nనిలువ గలవటె తల్లి కూతురలిగీ కూర్చొనినన్ !",
									"తేట మాటల తీయతీయగ\nపాట తోడను ప్రస్తుతించగ\nమాట లీయక యున్న నిజముగ బోటి నిలిచేనా !\nఏటి కమ్మరొ యిట్టి మాటలు\nచీటి మాటికి చిలిపి ఆటలు\nకోటివీణలు మ్రోగినట్టుల పాట రానీకన్ !",
									"గుమ్మడేడే గోపదేవీ\nగుమ్మడేడే కన్నతల్లీ\nగుమ్మడిని పొడచూపగదవే - అమ్మ గోపెమ్మా\nగుమ్మడేడే గోపదేవీ\nగుమ్మడేడే కన్నతల్లీ\nగుమ్మడిని పొడచూపగదవే - అమ్మ గోపెమ్మా"
									};

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Shatpada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] {new object[]{3,4,3,4},
									new object[]{3,4,3,4},
									new object[]{3,4,3,4,3,4,2 },
									new object[]{3,4,3,4},
									new object[]{3,4,3,4},
									new object[]{3,4,3,4,3,4,2 },
								};
			Yati = new int[][] { new int[] { }, new int[] { }, new int[] { 4 }, new int[] { }, new int[] { }, new int[] { 4 } };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class bhOgashaTpada : Rule
	{
		public bhOgashaTpada()
		{

			Lines = 6;
			Threshold = 3;


			Name = "భోగ షట్పద";
			Identifier = "bhOgashaTpada";
			Examples = new string[] {
									"తులసి యింటనుంచువార్ని\nతులసి పూజచేయువార్ని\nతులసియందు భక్తియుంచి మెలగువారినీ\nతులసి జూచి మ్రొక్కువార్ని\nతులసి యనుభవించువార్ని\nతెలిసి నీవు వారి దిక్కు తొంగిచూడకూ"
									};

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Shatpada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] {new object[]{3,3,3,3},
									new object[]{3,3,3,3 },
									new object[]{3,3,3,3,3,3,2 },
									new object[]{3,3,3,3},
									new object[]{3,3,3,3 },
									new object[]{3,3,3,3,3,3,2 }
								};
			Yati = new int[][] { };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class kusumashaTpada : Rule
	{
		public kusumashaTpada()
		{

			Lines = 6;
			Threshold = 5;


			Name = "కుసుమ షట్పద";
			Identifier = "kusumashaTpada";
			Examples = new string[] {
									"శ్రీశంభుతనయునకు\nసిద్ధిగణనాథునకు\nవాసిగల దేవతావందితునకూ\nఓబొజ్జకనకయ్య\nనీబంటు నేనయ్య\nఉండ్రాళ్ళ మీదికీ దండుబంపూ"
									};

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Shatpada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 5, 5 }, new object[] { 5, 5 }, new object[] { 5, 5, 5, 2 }, new object[] { 5, 5 }, new object[] { 5, 5 }, new object[] { 5, 5, 5, 2 } };
			Yati = new int[][] { };

			Prasa = false;
			PrasaYati = false;

		}
	}
	public class SarashaTpada : Rule
	{
		public SarashaTpada()
		{

			Lines = 6;
			Threshold = 4;


			Name = "శర షట్పద";
			Identifier = "SarashaTpada";
			Examples = new string[] { "శ్రీతరుణిరొ నే\nశ్రీరఘురాముడ\nచేరి కవాటము తీవే\nఖ్యాతిగ శ్రీరఘు\nరాముడవైతే\nకోతుల జేరగదోయీ"

									};

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Shatpada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 4, 4 }, new object[] { 4, 4 }, new object[] { 4, 4, 4, 2 }, new object[] { 4, 4 }, new object[] { 4, 4 }, new object[] { 4, 4, 4, 2 } };
			Yati = new int[][] { };

			Prasa = false;
			PrasaYati = false;

		}
	}

}