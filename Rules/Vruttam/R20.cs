//---------------------------------------------------------------------------------------------
// <copyright file="R20.cs" company="Chandam-ఛందం">
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
	public class aMburuhamu : Rule
	{
		public aMburuhamu()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "aMburuhamu";
			Name = "అంబురుహము";
			Examples = new string[] { "తారతుషార పటీర మరాళ సుధాసమాన మహాయశా\nనీరదభృంగ తమాలదళాసితనీరజేంద్ర మణిద్యుతీ\nహార కిరీట ముఖాభరణాంచిత యంచు శ్రీపతిగూర్చి భా\nభారసవంబుల భాను విరామముఁ బల్క నంబురుహంబగున్‌." ,
									  "దేవకులార్చితదేవశిరోమణిదేవదేవజగత్రయీ\nపావనమూర్తికృపావనమూర్తివిభావనాకులచిత్తరా\nజీవముధవ్రతజీవదశాపరిచేష్టితాఖిలలోకల\nక్ష్మీవదనాసవశీతలసౌరభసేవనాంచితజీవనా" };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ భ భ భ ర స వ".Split(' ') };
			Yati = new int[][] { new int[] { 13 } };
		}
	}
	public class khacharaplutamu : Rule
	{
		public khacharaplutamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,భ,భ,మ,స,స,వ".Split(',') };

			Yati = new int[][] { new int[] { 12 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "khacharaplutamu";
			Name = "ఖచరప్లుతము";
			Examples = new string[] {
										"వరద కేశవ దైత్యవిదారీ వారిజనాభ జగన్నిధీ\nకరుణఁ జూడుము మమ్ముఁ బ్రసన్నాకార హరీయని పల్కినన్‌\nవరుసతో సభభంబు మసావల్‌ వాలఁగ రుద్రవిరామ మై\nయరుదుగా మునిపుంగవవర్ణ్యంబై ఖచరప్లుత మొప్పగన్‌.",
										"కనకసారససారసరేఖాగ్రస్థితపక్షిచయంబహో\nయనినయట్టులకట్టినరెక్కల్‌వ్యాయతచంచులునాడఁగన్\nకనినమున్నులకన్నులఁబంపాకాండసరోజలమూగఁగా\nదనుజనాయకుఁడాయకఁగొంచున్‌దాటిచనెన్ గగనాధ్వమున్ "
									};
		}
	}
	public class maththEbhaM : Rule
	{
		public maththEbhaM()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "maththEbhaM";
			Name = "మత్తేభవిక్రీడితము";
			Examples = new string[]{
									  "సవరక్షార్థము దండ్రి పంప జని విశ్వామిత్రుడుం దోడరా\nనవలీలం దునుమాడె రాము డదయుండై బాలుడై కుంతల\nచ్ఛవిసంపజ్జితహాటకన్ గపటభాషావిఫురన్నాటకన్\nజవభిన్నార్యమఘోటకన్ కరవిరాజ త్ఖేటకన్ దాటకన్" ,
									  "సిరికిం జెప్పడు; శంఖ చక్ర యుగముంజేదోయి సంధింపడే\nపరివారంబును జీర డభ్రగపతిం బన్నింప డాకర్ణికాం\nతర ధమ్మిల్లము జక్క నొత్తడు వివాదప్రోత్థితశ్రీకుచో\nపరిచేలాంచలమైన వీడడు గజప్రాణావనోత్సాహియై" ,
									  "అల వైకుంఠపురంబులో నగరిలో నా మూల సౌధంబు దా\nపల మందారవనాంతరామృత సరః ప్రాంతేందు కాంతోపలో\nత్పల పర్యంక రమావినోది యగు నాపన్నప్రసన్నుండు వి\nహ్వల నాగేంద్రము \"పాహిపాహి\" యనఁ గుయ్యాలించి సంరంభియై.",
									  "కలఁ డంభోధిఁ, గలండు గాలిఁ, గలఁ డాకాశంబునం, గుంభినిం\nగలఁ, డగ్నిన్ దిశలం బగళ్ళ నిశలన్ ఖద్యోత చంద్రాత్మలం\nగలఁ, డోంకారమునం ద్రిమూర్తులఁ ద్రిలింగవ్యక్తులం దంతటం\nగలఁ, డీశుండు గలండు, తండ్రి! వెదకంగా నేల యీ యా యెడన్.",
									  "వాఁడె వధూమణి చూడవే ద్రిదివద్రుమంబు ధరిత్రికిన్‌\nబోఁడిమి దెచ్చిన శూరుఁ డీతనిఁ బోలలే రిల నెవ్వరున్‌\nవీఁ డధికుం డని భీమవిశ్రమవృత్తి భూతిలకం బగున్‌\nవేఁడి నుతింతురు భారసంబుల వెంట జాగము లొందఁగాన్‌."
									};

			Prasa = true;
			PrasaYati = false;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "స భ ర న మ య వ".Split(' ') };
			Yati = new int[][] { new int[] { 14 } };
		}
	}

	public class vasaMtamaMjari : Rule
	{
		public vasaMtamaMjari()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,భ,భ,న,ర,స,వ".Split(',') };
			Yati = new int[][] { new int[] { 13 } };


			Identifier = "vasaMtamaMjari";
			Name = "వసంతమంజరి";
			Examples = new string[] { "కమలనేత్రను బంకజముఖినిఁ గన్యకాజనధిక్కృతన్\nసుమనిభాంగినిఁ బల్లవపదను సుందరీవరరత్నమున్\nవిమలదంతిని హంసగమనను బింబసామ్యపుయోనినిన్\nసమదకుంజరకుంభకుచను వసంతమంజరి నంజలిన్." };
		}
	}
	public class utpalamaala : Rule
	{
		public utpalamaala()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "utpalamaala";
			Name = "ఉత్పలమాల";
			Examples = new string[]{
									"పుణ్యుడు రామచంద్రుడట వోయి ముదంబున గాంచె దండకా\nరణ్యము దాపసోత్తమ శరణ్యము నుద్దత బర్హిబర్హలా\nవణ్యము గౌతమీ విమల వాఃకణ పర్యటనప్రభూత సా\nద్గుణ్యము నుల్ల సత్తరు నికుంజ వరేణ్యము నగ్రగణ్యమున్" ,
									"ఊహ గలంగి జీవనపుటోలమునం బడి పోరుచున్ మహా\nమోహలతా నిహద్దపదమున్ విడిపించుకొనంగ లేక సం\nదేహముబోదు దేహి క్రియ దీనదశన్ గజ ముండె భీషణ\nగ్రాహదురంత దంత పరిఘట్టిత పాద ఖురాగ్ర శల్యమైన్" ,
									"ఎవ్వనిచే జనించు జగ; మెవ్వని లోపల నుండు లీనమై;\nయెవ్వని యందు డిందుఁ; బరమేశ్వరుఁ డెవ్వఁడు; మూలకారణం\nబెవ్వఁ; డనాదిమధ్యలయుఁ డెవ్వఁడు; సర్వముఁ దానయైనవాఁ\nడెవ్వఁడు; వాని నాత్మభవు నీశ్వరు నే శరణంబు వేడెదన్.",
									"భానుసమాన విన్ బరన భారలగంబుల గూడి విశ్రమ\nస్థానము నందు బద్మజ యుతంబుగ నుత్పలమాలయై చనున్\nపద్మజయుగ్యతిన్ భరనభారలగంబులఁ జెంది సన్మనః\nపద్మవికాస హేతువగు పద్యము నుత్పలమాలయం డ్రిలన్",
									"శ్రీరమణీముఖాంబురుహ సేవన షట్పద నాథ యంచు శృం\nగార రమేశ యంచు ధృత కౌస్తుభ యంచు భరేఫనంబులన్‌\nభారలగంబులుం గదియఁ బల్కుచు నుత్పలమాలికాకృతిన్‌\nగారవమొప్పఁ జెప్పుదురు కావ్యవిదుల్‌ యతి తొమ్మిదింటఁగాన్‌."
									};

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Rules = new string[][] { "భ ర న భ భ ర వ".Split(' ') };
			Yati = new int[][] { new int[] { 10 } };


			Prasa = true;
			PrasaYati = false;


		}
	}
	public class prabhaalalitamu : Rule
	{
		public prabhaalalitamu()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "భ", "ర", "స", "వ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "prabhaalalitamu";
			Name = "ప్రభాకలితము";

			Examples = new string[] { "వెలయ నజాభరసంబులున్ రవివిశ్రమంబులునుం బ్రజా\nకలితకునొప్పు నగణ్యపుణ్య లగంబుమీద ధరం గృతిన్\nవెలయ నజాభరసంబులున్ రవివిశ్రమంబులునుం బ్రజా\nకలితకునొప్పు నగణ్యపుణ్య లగంబుమీద ధరం గృతిన్" };
		}
	}
	public class kalita : Rule
	{
		public kalita()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "స", "న", "న", "వ" } };
			Yati = new int[][] { new int[] { 12 } };

			Identifier = "kalita";
			Name = "కలిత";

			Examples = new string[] { "ననభసననవంబుల నలినాప్తవిరమణము రస\nప్రణుత కలితవృత్త మమరు రంగమనుజపతిమణీ\nననభసననవంబుల నలినాప్తవిరమణము రస\nప్రణుత కలితవృత్త మమరు రంగమనుజపతిమణీ" };
		}
	}
	public class bhujara : Rule
	{
		public bhujara()
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

			Rules = new string[][] { new string[] { "న", "భ", "న", "భ", "ర", "స", "వ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "bhujara";
			Name = "భుజగ";

			Examples = new string[] { "మును నభల్ నభరసవముల్ పదుమూఁట విశ్రమమొప్పినన్\nఘనవజారత విజయరంగశిఖామణీ భుజగంబగున్\nమును నభల్ నభరసవముల్ పదుమూఁట విశ్రమమొప్పినన్\nఘనవజారత విజయరంగశిఖామణీ భుజగంబగున్" };
		}
	}
}
