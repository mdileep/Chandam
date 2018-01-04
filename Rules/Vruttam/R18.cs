//---------------------------------------------------------------------------------------------
// <copyright file="R18.cs" company="Chandam-ఛందం">
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
	public class mattakOkilamu : Rule
	{
		public mattakOkilamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "mattakOkilamu";
			Name = "మత్తకోకిల (చర్చరీ , మల్లికామాల , మాలికోత్తరమాలికా , విబుధప్రియా , హరనర్తన , ఉజ్జ్వల)";
			Examples = new string[] {"బల్లిదుం డగు కంసుచేతను బాధ నొందుచుచున్న మీ\nతల్లిఁ గాచిన భంగిఁ గాచితి ధార్తరాష్ట్రులచేత నేఁ\nదల్లడంబునఁ జిక్కకుండఁగ దావకీన గుణవ్రజం\nబెల్ల సంస్తుతి సేసి చెప్పఁగ నెంతదాన జగత్పతీ!",
									"అన్యసన్నుత సాహసుండు మురారి యొత్తె యదూత్తముల్\nధన్యులై వినఁ బాంచజన్యము దారితాఖిలజంతు చై\nతన్యమున్ భువనైకమాన్యము దారుణధ్వని భీతరా\nజన్యమున్ బరిమూర్చితాఖిలశత్రుదానవసైన్యమున్.",
									"తండ్రి సచ్చినమీఁద మాపెదతండ్రిబిడ్డలు దొల్లి పె\nక్కండ్రు సర్పవిషాగ్నిబాధల గాసిఁ బెట్టఁగ మమ్ము ని\nల్లాండ్ర నంతముఁ బొందకుండఁగ లాలనంబున మీరు మా\nతండ్రి భంగి సముద్ధరింతురు తద్విధంబు దలంతురే?",
									"వావిఁ జెల్లెలు గాని పుత్రికవంటి దుత్తమురాలు; సం\nభావనీయచరిత్ర; భీరువు; బాల; నూత్నవివాహ సు\nశ్రీవిలాసిని; దీన; కంపితచిత్త; నీ కిదె మ్రొక్కెదన్;\nకావవే; కరుణామయాత్మక; కంస! మానవవల్లభా!",
									"తల్లి! నీ యుదరంబులోనఁ బ్రధానబూరుషుఁ డున్నవాఁ\nడెల్లి పుట్టెడిఁ; గంసుచే భయ మింత లేదు; నిజంబు; మా\nకెల్లవారికి భద్రమయ్యెడు; నింక నీ కడు పెప్పుడుం\nజల్లగావలె యాదవావళి సంతసంబునఁ బొంగఁగన్.",
									"ఒక్కచేత సుదర్శనంబును నొక్క చేతను శంఖమున్‌\nఒక్కచేతఁ బయోరుహంబును నొక్క చేత గదం దగన్‌\nజక్కడంబగుమూర్తికిన్‌ రసజాభరంబులు దిగ్యతిన్‌\nమక్కువందగఁ బాడి రార్యులు మత్తకోకిల వృత్తమున్‌.",
									 };



			Prasa = true;
			PrasaYati = false;

			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "ర స జ జ భ ర".Split(' ') };
			Yati = new int[][] { new int[] { 11 } };
		}
	}
	public class hariNapluta : Rule
	{
		public hariNapluta()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "hariNapluta";
			Name = "హరిణప్లుత";
			Examples = new string[] { };



			Prasa = true;
			PrasaYati = false;

			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "ర స జ జ భ ర".Split(' ') };
			Yati = new int[][] { new int[] { 9, 14 } };
		}
	}

	public class tvaritapadagati : Rule
	{
		public tvaritapadagati()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "య" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "tvaritapadagati";
			Name = "త్వరితపదగతి ";

			Examples = new string[] { "సరసిరుహభవసదృశచతుర ననననాయల్\nత్వరితపదగతి కమరు దశమయతియు గాగన్\nసరసిరుహభవసదృశచతుర ననననాయల్\nత్వరితపదగతి కమరు దశమయతియు గాగన్" };
		}
	}
	public class niSa : Rule
	{
		public niSa()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "niSa";
			Name = "నిశా-2 (నారాచ , నారాచక , మహామలికా , సింహవిక్రీడిత , వరదా )";

			Examples = new string[] { "అడవిశునులు భక్షణాశన్ శవానీక సాన్నిధ్యమున్\nబడసి పెరమృగాళిపై రాఁ జలద్దర్శయద్దంతముల్\nగుడగుడలుగ గొంచు ఘూర్ణారవన్మంద్రరావంబుగన్\nజడసిజడియనట్లు సాగున్ మరిం బేర్చి కవ్వించుచున్" };
		}
	}
	public class haranartana : Rule
	{
		public haranartana()
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

			Rules = new string[][] { new string[] { "ర", "స", "జ", "య", "భ", "ర" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "haranartana";
			Name = "హరనర్తన ";

			Examples = new string[] { "బద్ధవాసనఁజేసిహావళిశార్దూళావళిపొందుచున్\nయుద్ధభూమినిఁజేరిదృష్ట్లొగినేదాత్త్యాయతిఁజిందుచున్\nవిద్ధసైందవరాజిపైవిచలద్ గృధ్రావృతి క్రోధసం\nబద్ధ గర్జనఁబాపి తప్పక యట్లేకప్పక నిల్చున్ " };
		}
	}

	public class kusumitalataavaellita : Rule
	{
		public kusumitalataavaellita()
		{
			Lines = 4;
			Threshold = 3;

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "kusumitalataavaellita";
			Name = "కుసుమితలతావేల్లిత";



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "మ,త,న,య,య,య".Split(',') };
			Yati = new int[][] { new int[] { 12 } };

			Examples = new string[] { "శ్రీనాథున్‌ బ్రహ్మాద్యమరవర సంసేవ్యపాదారవిందున్‌\nదీనానాథవ్రాతభరను గుణోదీర్ణునిం బాడి వోలిన్‌\nగానారూఢాత్ముల్‌ మతనయయయల్‌ కామజిద్విశ్రమంబై\nవీనుల్‌ నిండారం గుసుమితలతావేల్లితావృత్తమొప్పున్‌." };
		}
	}
	public class ativinaya : Rule
	{
		public ativinaya()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "స" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "ativinaya";
			Name = "అతివినయ";

			Examples = new string[] { "ననలు గలయఁగ ననల నసయుతములగుచున్\nదనరు నతివినయకివి దశమయతికృతులన్\nననలు గలయఁగ ననల నసయుతములగుచున్\nననలు గలయఁగ ననల నసయుతములగుచున్" };
		}
	}
	public class dEvaraaja : Rule
	{
		public dEvaraaja()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "జ", "భ", "స" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "dEvaraaja";
			Name = "దేవరాజ";

			Examples = new string[] { "క్షితి నరల్‌నజల్‌భసలును జెన్నుగా నభవయతి\nస్థితియు దేవరాజమునకుఁ జెల్లు రంగనరపతీ\nక్షితి నరల్‌నజల్‌భసలును జెన్నుగా నభవయతి\nస్థితియు దేవరాజమునకుఁ జెల్లు రంగనరపతీ" };
		}
	}
	public class taraLamu : Rule
	{
		public taraLamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,స,న,జ,న,ర".Split(',') };

			Yati = new int[][] { new int[] { 11 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "taraLamu";
			Name = "తరలి";
			Examples = new string[] { "చారుభసన భూరిజన రసాంద్రగణములన్‌ దిశా\nసార విరతి నందముగ నిజంబు తరలి చెన్నగున్‌.\nచారుభసన భూరిజన రసాంద్రగణములన్‌ దిశా\nసార విరతి నందముగ నిజంబు తరలి చెన్నగున్‌."
									};
		}
	}

	public class kshmaahaara : Rule
	{
		public kshmaahaara()
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

			Rules = new string[][] { new string[] { "మ", "న", "య", "త", "న", "మ" } };
			Yati = new int[][] { new int[] { 9, 13 } };

			Identifier = "kshmaahaara";
			Name = "క్ష్మాహార";

			Examples = new string[] { "సానుక్రోశుఁడు మధురస్వాద్వాభాషి సకలవేదార్థా\nహీనప్రౌడుఁడు ధిషణాహేలాలోకహిత సదాజీవుం\nడేనోదూరుఁడు తరిణుం డీహాదూరుఁ డితిహశబ్దార్థా\nఙ్ఞానాస్థానము నిరతస్వాహాభర్తృచరణశీలుండున్" };
		}
	}
}
