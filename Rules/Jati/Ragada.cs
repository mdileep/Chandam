//---------------------------------------------------------------------------------------------
// <copyright file="Ragada.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Jati.Ragada
{
	public class mutyaalasaramu : Rule
	{

		public mutyaalasaramu()
		{
			Lines = 4;
			Threshold = 4;


			Name = "ముత్యాల సరము";
			Identifier = "mutyaalasaramu";
			Examples = new string[] {

									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada2;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] {    new object[] { 3 , 4 , 3 , 4 } ,
										new object[] { 3 , 4 , 3 , 4 } ,
										new object[] { 3 , 4 , 3 , 4 } ,
										new object[] { 3 , 4 , 3 , 4, 2 }
									};
			Yati = new int[][] { };

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = true;//Optional.. Seems  I don't know how  to handle Optional Rules at this time..
		}
	}
	public class mutyaalasaramu2 : Rule
	{

		public mutyaalasaramu2()
		{

			Lines = 4;
			Threshold = 4;


			Name = "ముత్యాల సరము2";
			Identifier = "mutyaalasaramu2";
			Examples = new string[] {
									"చెలియ బంగరు చెలిమి బంగరు\nవలపు బంగారమని చెబితివి\nచెలిని చూడవు కాదు సరి యిది\nచిలిపి కృష్ణయ్యా",
									"కలత నిద్దురలోన కంటిని\nకలువ కన్నుల వాని కలలో\nనులికి పడి లేచితిని నేనిట\nచిలిపి కృష్ణయ్యా",
									"వెలిగె నాకాశమున తారలు\nవెలిగె నాకాశమున చంద్రుడు\nవెలుగు నవ్వుల రూపు చూపర\nచిలిపి కృష్ణయ్యా",
									"పలుకు వజ్రపు తునకలా హరి\nపిలిచి యలసితి పిలుపు వినదా\nచిలుకరించగ సుధల వడి రా\nచిలిపి కృష్ణయ్యా"
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada2;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] {    new object[] { 3 , 4 , 3 , 4 } ,
										new object[] { 3 , 4 , 3 , 4 } ,
										new object[] { 3 , 4 , 3 , 4 } ,
										new object[] { 3 , 4 ,  2 }
									};
			Yati = new int[][] { };

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;//Optional.. Seems  I don't know how to handle Optional Rules at this time..
		}
	}
	public class utkaLika : Rule
	{

		public utkaLika()
		{

			Lines = 2;
			Threshold = 3;


			Name = "ఉత్కళిక";
			Identifier = "utkaLika";
			Examples = new string[] {
									"భువనసువన ఫలము లలమి\nజవనపవన బలము కలిమి\nయెదలు పొదల మరగి తిరిగి\nచదల తుదల కరిగి పెరిగి\nపేపుమాపు మించి పొంచి\nరూపు చూపి సంచరించు\nయోగరాగ కీరమునకు\nయాగభాగ సారమునకు" ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 3, 3, 3, 3 } };
			Yati = new int[][] { };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = false;


		}


	}
	public class haMsagatiragaDa : Rule
	{
		public haMsagatiragaDa()
		{

			Lines = 2;
			Threshold = 5;


			Name = "హంసగతి  రగడ";
			Identifier = "haMsagatiragaDa";
			Examples = new string[] {
										"మఱియును గ, టాక్షజిత - మారునందు\nతఱి త్రాడు, సొమ్మగు ను - దారునందు."
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 5, 5, 3, 3 } };
			Yati = new int[][] { new int[] { 3 } };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = true;

		}
	}
	public class vijayabhadraragaDa : Rule
	{
		public vijayabhadraragaDa()
		{

			Lines = 2;
			Threshold = 5;


			Name = "విజయభద్ర  రగడ";
			Identifier = "vijayabhadraragaDa";
			Examples = new string[] {
									"శ్రీకి నొడయం డనఁగఁ జిత్తజునిగురుఁ డనఁగ    శేషశయనుం డనఁగఁ జెలువుగఁ జతుర్భుజుఁడు\nనాకౌకసుల నేలు నముచిసూదనువూజ    నతఁడు దాఁగైకొన్న నందగోపాత్మజుఁడు\nఇతనిఁ గొల్చినఁ గాని యిహపరంబులు గలుగ    వితరసేవల ననఁగ నెసఁగు నివ్విభుఁ డంచుఁ\nజతురమతు లొనరింప జయభద్రరగడ లిటు    సద్ద్విరదగతి రెంటఁ జాటింపులం బెంచు" ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 5, 5, 5, 5, 5, 5, 5, 5 } };
			Yati = new int[][] { new int[] { 5 } };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = true;

		}
	}
	public class vRshabhagatiragaDa : Rule
	{
		public vRshabhagatiragaDa()
		{

			Lines = 2;
			Threshold = 4;


			Name = "వృషభగతి రగడ";
			Identifier = "vRshabhagatiragaDa";
			Examples = new string[] {
									"శ్రీమనోహరు నంబుజోదరుఁ    జిత్తజాతగురుం దలంచెదఁ\nగామితార్థవిధాయి నిర్జిత    కాళియాహిని నాశ్రయించెద\nననువుగా భగణములు భానుస    మన్వితద్వితయములు నాలుగు\nననిమిషాధిపలఘుయతినిడఁగ    నలరువృషభగమనము మేలగు." ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 3, 4, 3, 4, 3, 4, 3, 4 } };
			Yati = new int[][] { new int[] { 5 } };

			Prasa = true;
			PrasaYati = true;
			AnthyaPrasa = true;

		}
	}
	public class dviradagatiragaDa : Rule
	{
		public dviradagatiragaDa()
		{

			Lines = 2;
			Threshold = 5;


			Name = "ద్విరదగతి రగడ";
			Identifier = "dviradagatiragaDa";
			Examples = new string[] {
									"శ్రీయువతి నిజయువతిఁ జేసి యెంతయు మించి\nకాయజునిఁ దనతనయుఁ గా నెలమిఁ బాటించి\nసకల దేవతలఁ బరిజనులుగా మన్నించి,\nప్రకటగతి శ్రుతుల నుతిపాఠకులఁ గావించి\nహరి యొప్పు నన నొప్పు నవతార లఘువిరతి\nశరది నగనలలభలసలతరల ద్విరదగతి." ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 5, 5, 5, 5 } };
			Yati = new int[][] { new int[] { 3 } };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = true;

		}
	}
	public class hariNagatiragaDa : Rule
	{
		public hariNagatiragaDa()
		{

			Lines = 2;
			Threshold = 4;


			Name = "హరిణగతి రగడ";
			Identifier = "hariNagatiragaDa";
			Examples = new string[] {
									"శ్రీనివాసు భజింతు నే నని \nపూని కుజనులపొంత బోనని",
									"భానుయుతనలభసగగంబుల \n లోననిరుదోలుననగంబుల",
									"నిరవుగా నిరుమాఱులఘువుల \n నెల్లవారును నొగి గణింపఁగ",
									"విరతులను గావింపనిమ్ముల\n హరిణగతి చెలువగు జగమ్ముల." ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 3, 4, 3, 4 } };
			Yati = new int[][] { new int[] { 3 } };

			Prasa = false;
			PrasaYati = true;
			AnthyaPrasa = true;
		}
	}
	public class harigatiragaDa : Rule
	{
		public harigatiragaDa()
		{

			Lines = 2;
			Threshold = 4;


			Name = "హరిగతి రగడ";
			Identifier = "harigatiragaDa";
			Examples = new string[] {
									"శ్రీరామాకుచకుంకుమపంకము చేఁ బొలుపగు విపులోరఃఫలకము\nతారతుషారపటీరసమానో దకవాహిని యొదవిన పదకమలము\nనతిశయ మై యలవడు నేదేవుని    ననవరతోదారత నాహరిగతి\nయితరుల కలవడ దని నృప లఘుయతి నిభనలగగభసల నగును హరిగతి." ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 4, 4, 4, 4, 4, 4, 4, 4 } };
			Yati = new int[][] { new int[] { 5 } };

			Prasa = true;
			PrasaYati = true;
			AnthyaPrasa = true;
		}
	}
	public class taaLaragaDa : Rule
	{
		public taaLaragaDa()
		{

			Lines = 2;
			Threshold = 4;


			Name = "తాళ రగడ";
			Identifier = "taaLaragaDa";
			Examples = new string[] {
									"దవుదౌ,వులగాం,చెంగై,లాసముతరుణెందుకళాధరును నువాసము దళహరి,నికటస్థానస్థపుటితధవళచ్ఛాయా,చ్చేదవి,లాసము\nదవుదౌ,వులగాం,చెంగై,లాసముతరుణెందుకళాధరును నువాసము దళహరి,నికటస్థానస్థపుటితధవళచ్ఛాయా,చ్చేదవి,లాసము" ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 } };
			Yati = new int[][] { new int[] { 5, 9, 13 } };

			Prasa = true;
			PrasaYati = true;
			AnthyaPrasa = false;
		}
	}
	public class madhuragatiragaDa : Rule
	{
		public madhuragatiragaDa()
		{

			Lines = 2;
			Threshold = 4;


			Name = "మధురగతి రగడ";
			Identifier = "madhuragatiragaDa";
			Examples = new string[] {
									"శ్రీవనితాధిపుఁ జేరి భజింపుఁడు\nభావజ జనకుని భక్తిఁ దలంపుఁడు\nఅని గగనలభసలను నాల్గిటఁ గృతి\nజను గజలఘువిశ్రమము మధురగతి." ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 4, 4, 4, 4 } };
			Yati = new int[][] { new int[] { 3 } };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = true;

		}
	}
	public class vijayamaMgaLaragaDa : Rule
	{

		public vijayamaMgaLaragaDa()
		{

			Lines = 2;
			Threshold = 3;


			Name = "విజయమంగళ  రగడ";
			Identifier = "vijayamaMgaLaragaDa";
			Examples = new string[] {
									"శ్రీధరాయ శిష్టజననిషేవితాయ భక్తలోక జీవితాయ గర్వితోరుసింధురాజబంధనాయ\nగాధిపుత్రయజ్ఞ విఘ్నకరమహాసురీమహోగ్ర కాయ శైలదళన నిపుణ ఘన సురాధిపాయుధాయ",
									"కేశవాయ తే నమోఽస్తు కృష్ణ పాహిపాహి యనుఁచు గేలుమొగచి మౌళినునిచి కృష్ణుఁ బలికెననుచునిట్లు\nదేశభాషణములఁ జెప్ప ద్విగుణతురగవల్గనమునఁ దేరు విజయమంగళంబు తీయచెఱకు రసమునట్లు." ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 } };
			Yati = new int[][] { new int[] { 9 } };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = true;

		}
	}
	public class hayaprachaararagaDa : Rule
	{

		public hayaprachaararagaDa()
		{

			Lines = 2;
			Threshold = 3;


			Name = "హయప్రచార రగడ";
			Identifier = "hayaprachaararagaDa";
			Examples = new string[] {
									"తెల్లగ పడె తిన్నగ పడె\nమెల్లగ పడె మృదువుగ పడె\nచల్లగ పడె చక్కగ పడె\nవెల్లగ హిమ వృష్టియు పడె" ,
									"హనచతుష్టయంబు ఋతుల\nజనితయతుల జరగుఁ గృతులఁ\nజను హయప్రచార రగడ\nవినుతశాస్త్రవిధులు వొగడ.",
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 3, 3, 3, 3 } };
			Yati = new int[][] { new int[] { 3 } };

			Prasa = true;
			PrasaYati = true;
			AnthyaPrasa = true;
		}
	}
	public class turagavalganaragaDa : Rule
	{

		public turagavalganaragaDa()
		{

			Lines = 4;
			Threshold = 3;


			Name = "తురగవల్గన రగడ";
			Identifier = "turagavalganaragaDa";
			Examples = new string[] {
									"దశరథావనీశ విమలతర తపఃఫలావతార\nనిశిత శర లఘుప్రయోగ నిహత తాటకా విహార\nకపట పటు సుబాహు దశన ఘటిత గాధిసూను యాగ\nఅపరిమేయ గౌతమాంగనాఘ దమన పద పరాగ\nకోమలేక్షు దళన సదృశ ఘోర శంభు చాప భంగ\nభూమిజా వివాహ విభవ పూర్ణ సమ్మదాంతరంగ\nపరశురామ గర్వ పవన పాప పీన బాహు నాగ\nగురు వచోఽనుపాల నాతి కుతుక విధుత రాజ్యభోగ\nపాద భజన వితరణాతి ఫలిత గుహ సమస్త పుణ్య\nపాదుకా ప్రదాన విహిత భరత సౌహృదానుగుణ్య\nఘన విరాధ మద వినాశ కలిత బహు విపన్నిరాస\nవినుత పద నివేశ పూత వివిధ మౌని కుల నివాస\nతత నిశాచరీ విరూపతా కృతప్రియా వినోద\nఅతుల బల ఖరాది దనుజ హనన జనిత విబుధ మోద\nహరిణ రూప ధారి దారు ణాసు రాసు హరణ బాణ\nపరమ ఘోర బాహుబల కబంధ మర్దనప్రవీణ\nఅమల శబరికా ఫలోపహార రుచి ఘనాభిముఖ్య\nసమద వాలి దర్ప దమన సఫలితార్క తనయ సఖ్య\nశరణ వరణ పర పరానుజప్రదీపితప్రసాద\nఅరుణితాక్షి కోణ విరచితాంబురాశి గర్వ సాద\nపర్వతౌఘ రచిత సేతు బంధ సుతర సింధు కాండ\nగర్వ పంక్తికంఠ కంఠ ఖండనప్రచండకాండ\nసకల దివిజ నుత చరిత్ర సాధు భవ లతా లవిత్ర\nసకరుణా తరంగ నేత్ర జానకీ మనోజ్ఞ గాత్ర\nయతి జపార్హ పుణ్య నామ యతి వితీర్ణ భక్త కామ\nసతత సిత యశోఽభిరామ సర్వలోక పూర్ణ ధామ\nఅహిత విదళ నాతి రౌద్ర యార్త పాలనా వినిద్ర\nమహిత నిఖిల గుణ సముద్ర మమ్ము బ్రోవు రామభద్ర" ,
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 3, 3, 3, 3, 3, 3, 3, 3 } };
			Yati = new int[][] { new int[] { 5 } };

			Prasa = true;
			AnthyaPrasa = true;
			PrasaYati = true;

		}
	}
}