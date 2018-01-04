//---------------------------------------------------------------------------------------------
// <copyright file="R27.cs" company="Chandam-ఛందం">
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
	public class layagraahi : Rule
	{
		public layagraahi()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "layagraahi";
			Name = "లయగ్రాహి";
			Examples = new string[] {"ఎందునిలనేజనులకుందలఁపరానితపమందికొనిచేసిరొకొనందుఁడుయశోదా\nసుందరియుఁబూర్ణనిధిఁబొందిరికడున్దొరసిపొందగునుముప్పుతఱినందనునిగాశ్రీ\nమందిరునినంచునిటులందముగఁ బ్రాసములు గ్రందుకొనిచెప్పుమునిబృందములయగ్రా\nహిందనరసబ్భజసలుందగనకారమునుబొందనిరుచోట్లనుబిఱుందభయలొందన్" ,
									"కమ్మని లతంతముల కుమ్మొనసి వచ్చు మధు పమ్ముల సుగీతనిన దమ్ములెసఁగెం జూ\nతమ్ముల లసత్కిసల యమ్ముల సుగంధిముకుళమ్ములను నానుచుము దమ్మెనర వాచా\nలమ్ములగు కోకిలకులమ్ముల రవమ్ము మధురమ్మగుచు వించెననుశమ్ము సుమనోభా \nరమ్ముల నశోక నికరమ్ములును జంపక చ యమ్ములును గింశుకవ నమ్ములును నొప్పెన్"
									};



			Prasa = true;
			PrasaYati = true;
			OnlyPrasaYati = true;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Rules = new string[][] { "భ జ స న భ జ స న భ య".Split(' ') };
			Yati = new int[][] { new int[] { 9, 17, 25 } };//No yati but prasayati...

		}
	}
	public class layavibhaati : Rule
	{
		public layavibhaati()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "layavibhaati";
			Name = "లయవిభాతి";
			Examples = new string[]{
									"పడయరెతనూభముల న్బడయుదురుగాకపెరపడతులునుభర్తలునుబడసిరెతలంపన్\nబుడమిగలనందుడునుబడతుకయశోదయునుగడపునజగత్రయమునిడికొనినపుత్రున్\nబడసిరటయంచుబెడగడరునసనత్రివృతిగడనసగముల్పొసగనిడలయవిభాతిన్\nనొడువుదురుసత్కవులెపుడునువిరితేనియలువడియుపగిదిన్రనముగడలుకొనుచుండున్" ,
									"అలికులము నీలముల చెలువము వహింప నవడళముల హరిన్మణుల పొలుపు నదలిర్పన్\nదలిరుగమి కెంపులుగఁ బలుదెఱ్ఁగు క్రొవ్విరుల విలసనము ముత్తియపు గుళికలకుఁ దక్కున్ \nగల మణులకుం బసిఁడికళకులకు నీడగుచు వెలయఁగఁ బరాగములు లలితపు వితానం\nబులుగ గృహముఖ్యముల  చెలువు ప్రతిబింబములు బలెఁ బురము నల్ధెసలఁ బొలుచును వనంబుల్ ",
									"చలువ లొసఁగెన్‌ సరగఁ జెలువ యపు డొక్కరితె వలఁతితన మొప్ప నొకపొలఁతి తడి యొత్తెన్‌\nగొలఁదిగ జవాది నొకవెలఁది తలఁ బూసె నొక జలరుహదళాక్షి సిగ కలరుసరి చుట్టెన్‌\nదిలక మిడియెన్నిటలఫలకమున నొక్క సతి తెలి నిలువుటద్ద మొకచెలి నిలిపె మ్రోలన్‌\nగలయ జవరా లొకతె మలయజ మలందె నొక లలన విసరెన్‌ సురటి యలనరున కర్థిన్‌."
									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "న స న న స న న స న న స గ".Split(' ') };
			Yati = new int[][] { new int[] { 9 + 1, 18 + 1, 27 + 1 } };//No yati but prasayati...


			Prasa = true;
			PrasaYati = true;
			OnlyPrasaYati = true;
		}

	}
	public class layahaari : Rule
	{
		public layahaari()
		{
			Lines = 4;
			Threshold = 3;

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "layahaari";
			Name = "లయహారి";
			Examples = new string[] {
										"చదువులును గిదువులను జదువ ధన మొదవు నని మదిఁ దలఁపవలదు మును చదివిరె ధరిత్రిన్‌\nసదమలినహృదయుఁ డనఁ బొదలు దితిసుతసుతుఁడు -    మొదలఁ బలికినపలుకు జదువఁగ ముకుందుం\nడద నెఱిగిఁ కదిసెఁ గద! చదివినభృగువుకొడుకు -    చదువుతుది నొకపనికి నొదవెనె యటంచున్‌\nపదునొకఁడు నగణములు గదిసి సగమెనయ భువి -    విదితముగ బుధులు పలుకుదురు లయహారిన్‌.",
										"పిడుగులురలి నగతిని బొడుచుచును నడచుచును బెడిదముగ విదలుచుచు విడిపడని పట్టున్ \nనడగిరులు వెడదరులు విడిలుకొని పెనుగరుల సుడివడిన యులిఉలును పొడుచుకొను రీతిన్ \nతొడలు తొడలు వి ద్రుచుచు మెడలు మెడలు విరుచుచు నొడలు నొడలు కుముల్ఁగ బొడుచుచు మహోగ్రుల్\nవిడివడిన కనలు వెలు వడిన పెనుపరిచలము కడవ నొకఁడొకఁడు పెనువడిన గతి పోరన్ "
									};

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "న,న,న,న,న,న,న,న,న,న,న,స,గ".Split(',') };
			Yati = new int[][] { new int[] { 11, 21, 31 } };//No Yati but  Prasayati...

			Prasa = true;
			PrasaYati = true;
			OnlyPrasaYati = true;
		}
	}
	public class tribhaMgi : Rule
	{
		public tribhaMgi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న న న న న న స స భ మ స గ".Split(' ') };

			Yati = new int[][] { new int[] { 25, 29, 34 } };//9, 17 వ అక్షరములు (ప్రాసయతి)


			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "tribhaMgi";
			Name = "త్రిభంగి";
			Examples = new string[] {
									"నననన ననసస లును భమసగలును దనరి నటింపఁ గణంకన్‌ నలువంకన్‌ బెంపుదొలంకన్‌\nమునుకొని నఖముఖమున వెడఁగదలుపఁ జనుఁ గడునొప్పగువీణల్‌ నెరజాణల్‌ వేలుపుగాణల్‌\nవనరుహ జనితుని తనయులు మొదలుగ ఘనమతులాదటతోడన్‌ శ్రుతిగూడన్‌ వెన్నునిఁబాడన్‌\nవినఁగలిగిన నదిజననము ఫలమని -    మునిజను లిందు శుభాంగున్‌ దగుభంగిన్‌ జెప్పుఁ ద్రిభంగిన్‌." ,
									"తెలుగు మధురిమలు,పలుకు పరిమళము తెలిపిన తల్లివి నీవే ! గతినీవే ! నా ధృతి నీవే !\nసలిపి ప్రణతులను తెలిపినను మదిని పలుకుల నీయగ రావా ! అలిగేవా ! విద్యల దేవీ !\nతెలిసియు విషయము కలత నిడుదువిటు ! పలుకుల భాండము లేదో ! దయ రాదో ! కూతును కాదో !\nఅలుకను వదలుచు నిలుపగ పరువును పలుకగ రమ్మిక వేగన్ ఎద యూగన్ గంటము సాగన్\nపలుకుగతులనట తెలుపగ కవితనె తలపున ప్రేరణ నిమ్మా! విధికొమ్మా ! బంగరు బొమ్మా !"
									};
		}
	}
	public class ramaNakamu : Rule
	{
		public ramaNakamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,న,న,న,న,న,న,న,వ".Split(',') };

			Yati = new int[][] { new int[] { 9, 17, 25 } };


			Identifier = "ramaNakamu";
			Name = "రమణకము";
			Examples = new string[] {
										"మససిత జనక సమదరిపు గజహరి  మదగజవసు విరమణములతో\nనననన నననన  నలగము లెనయఁగ  నరవరనుత! రమణక మమరున్‌.\nమససిత జనక సమదరిపు గజహరి  మదగజవసు విరమణములతో\nనననన నననన  నలగము లెనయఁగ  నరవరనుత! రమణక మమరున్‌.",
										"తెరగుతెరగులగుతెలుగునుడువులనతెర పయినవెనుక దిటవుగతా\nకరముగపలుకుచుకలమునకదుపుచుకదలిచి నెడదలకవినటుడై\nఉరునటనకవనఒడుపులనిపుణుడుయువనవపధబలయుతమదియా\nభరణితనికెళొకపసిడితొణికిసలభరిణెరజతపటపటలములన్ ~ శ్రీ సూర్యనారాయణ  సరిపల్లి గారిచే విరచితం.",

									};
		}
	}
	public class laakshaNi : Rule
	{
		public laakshaNi()
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

			Rules = new string[][] { new string[] { "భ", "న", "న", "న", "న", "భ", "న", "న", "స" } };
			Yati = new int[][] { new int[] { 16 } };

			Identifier = "laakshaNi";
			Name = "లాక్షణి";

			Examples = new string[] { "పక్షవిరమణముభననననములును భాసురభభనసలెనసినచో\nలాక్షణియనఁదగునతులితమదనవిలాసలలితగుణగణజలధీ.\nపక్షవిరమణముభననననములును భాసురభభనసలెనసినచో\nలాక్షణియనఁదగునతులితమదనవిలాసలలితగుణగణజలధీ.", };
		}
	}
	public class dara : Rule
	{
		public dara()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "న", "న", "భ", "స" } };
			Yati = new int[][] { new int[] { 9, 17, 25 } };

			Identifier = "dara";
			Name = "దర";

			Examples = new string[] { "ఎనిమిది నగణములెలమిగ నిలుపుచు నిరవుగ భసలము లింపుగ నెరపన్\nమును కొని దరమగు పొలువుగ వసువులు మురిపెపు యతులుగ మూఁడు నెలవులన్ \nఎనిమిది నగణములెలమిగ నిలుపుచు నిరవుగ భసలము లింపుగ నెరపన్\nమును కొని దరమగు పొలువుగ వసువులు మురిపెపు యతులుగ మూఁడు నెలవులన్ ", };
		}
	}
	public class Saaloora : Rule
	{
		public Saaloora()
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

			Rules = new string[][] { new string[] { "త", "న", "న", "న", "న", "న", "న", "న", "న", "వ" } };
			Yati = new int[][] { new int[] { 16 } };

			Identifier = "Saaloora";
			Name = "శాలూర";

			Examples = new string[] { "అంతన్ రఘుపరివృఢధనురుదితశరనికరసరదనలపటుతరశిఖా\nప్రాంతంబగుచుజలధిబహులకుహరనివసదసురమకరతతితతతనూ \nసంతానములు తెక తెక లయి తహ తహ లయి తికమక పడి వడిగుడుసులై\nయంతర్జలములనసుచయములురలిసగము వెలకిలఁబడిచలనమురలెన్ ", };
		}
	}
}

