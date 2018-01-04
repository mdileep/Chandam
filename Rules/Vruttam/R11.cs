//---------------------------------------------------------------------------------------------
// <copyright file="R11.cs" company="Chandam-ఛందం">
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
	public class svaagatavRttamu : Rule
	{
		public svaagatavRttamu()
		{
			Lines = 4;
			Threshold = 3;


			Prasa = true;
			PrasaYati = false;

			Identifier = "svaagatavRttamu";
			Name = "స్వాగతం";
			Examples = new string[] {
										"రాజరాజగుణరాజిత రాజ\nత్తేజ రాజకులదీపవిశిష్టాం\nభోజమిత్ర నృపపూజితపాదాం\nభోజ భూవినుతపుణ్యవరేణ్యా",
										"నారదాదిమునినాయక వంద్యున్‌\nశౌరిఁ జేరుఁ డన స్వాగత మొప్పున్‌\nసారమైనయతి షణ్మితి నొందన్‌\nభూరిరేఫనభముల్‌ గగయుక్తిన్‌.",

									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			RuleType = RuleType.Name;

			Rules = new string[][] { "ర న భ గా".Split(' ') };
			Yati = new int[][] { new int[] { 7 } };

		}
	}
	public class bhadrika : Rule
	{
		public bhadrika()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,ర,వ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "bhadrika";
			Name = "భద్రిక-1 (సుభద్రికా , చంద్రిక , అపరవక్త్ర , ప్రసభ)";
			Examples = new string[] {
										"ఇతఁడు నలుఁడ హీన మూర్తియా\nయతన మఖిల మైన శూరక\nర్మతతికి సరి రాదు వీనికిన్\nక్షితి శతశతసేనయైననున్",
										"నగణయుగమునన్‌ రవంబులన్‌\nబ్రగుణరసవిరామసంగతిన్‌\nతగిలి హరికథాసమేతమై\nనెగఁడు గృతుల నిండి చంద్రికన్‌."
									};
		}
	}

	public class Syaeni : Rule
	{
		public Syaeni()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,జ,ర,వ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "Syaeni";
			Name = "శ్యేని (సేని)";
			Examples = new string[] {   "ఆరమాధినాథుఁ డక్షయంబుగాఁ\nజీర లిచ్చె యాజ్ఞసేని కంచుఁ బెం\nపారఁ జెప్ప శ్యేని యయ్యె షడ్యతిన్‌\nస్ఫారమై రజంబుపై రవంబుగాన్‌.",
										"మింటడేగపిండుమేలిచక్రముల్\nవెంటవెంటతిర్గివేగ వ్రాలుచున్\nమంటలేచువట్టిమాసఖండముల్\nగెంటుకొంచుఁబోవుఁగీర్ణధాత్రిగా"
									};
		}
	}
	public class Saalini : Rule
	{
		public Saalini()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,త,త,గా".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "Saalini";
			Name = "శాలిని";
			Examples = new string[] { "ధీరశ్రేష్ఠుల్సన్నుతింపం గవీంద్రా\nధారంబై ధాత్రిన్మతాగాగణాప్తిన్\nదోరంబై భూభృద్యతుల్ సంఘటింపన్\nనీరేజాక్షా శాలినీవృత్త మొప్పున్.",
										"భావశ్రీగమ్యప్రభాశాలినిన్‌స్వే\nచ్చావిర్భూతాత్మస్వయంభాసినిన్ బ్ర\nఙ్ఞావైదగ్ధ్యవ్యక్తసర్వాంతరాత్మన్\nశ్రీవిద్యోపాస్యన్ భజింతున్ భవానిన్"
									};
		}
	}
	public class vaatOrmi : Rule
	{
		public vaatOrmi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,భ,త,వ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "vaatOrmi";
			Name = "వాతోర్మి";
			Examples = new string[] {
										"దేవాధీశున్‌ హరిఁ దేజోవనధిన్‌\nభావింపంగా ఋతుభాస్వద్విరతిన్‌\nఈ వాతోర్మిన్‌ మభలేపారుఁ దకా\nరావాసంబై లగ మర్దిన్‌ గదియన్‌.",
										"అంతన్ దైత్యేశ్వరుఁ-డాకాశగతిన్\nకాంతారోదధ్వని-కప్పంగ దిశల్\nక్రాంతమ్మైదక్షిణగాఢోగ్రకకు\nప్ప్రాంతమ్మైతేరగ ప్రాణమ్ములొగిన్"
									};
		}
	}
	public class rathOddhatamu : Rule
	{
		public rathOddhatamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,న,ర,వ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "rathOddhatamu";
			Name = "రథోద్ధతము (పరాంతికము)";
			Examples = new string[] {
										"నందగోపవరనందనున్‌ రమా\nనందుఁ బ్రస్తుతి యొనర్చి షడ్యతిన్‌\nఅందమై రనరవాహ్వయంబు లిం\nపొందఁ జెప్పిన రథోద్ధతం బగున్‌.",
										"హారహీరధవళాంశునిర్మలో\nదారకీర్తిరణదర్ప సద్గుణా\nవైరివీరరసవైద్యమన్మధా\nకార ధీరపరగండభైరవా"
									};
		}
	}


	public class bhadrika2 : Rule
	{
		public bhadrika2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,ర,వ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "bhadrika2";
			Name = "చంద్రిక (భద్రిక-2)";
			Examples = new string[] {
										"అగవర ధర నారవాన్వితం\nబుగఁ గృతులను జెప్పఁ బొందికై\nతగ విధివిరమంబు తాకగా\nజగతిని నెగడొందుఁ జంద్రికన్"
									};
		}
	}


	public class dOdakamu : Rule
	{
		public dOdakamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,భ,భ,గా".Split(',') };
			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "dOdakamu";
			Name = "దోదకము (తోధక , తోదక , తోటక , దోధక , తరంగక , బందు , భిత్తక)";
			Examples = new string[] { "కామితభత్రయ గాయుత మై వి\nశ్రామపుఁ దోదక సంజ్ఞతఁ జెందున్\nపాదపవృత్తము భా భగగంబుల్\nమోదముతో నిరు మూఁడవిరామన్" ,
										"తోరపువేడుకఁ-దోదకవేత్తా\nకారముగాఁద్రిభకారగగంబుల్\nనీరజనాభుని-నెమ్మినుతింపన్\nజారువిరామముషణ్మితినొందున్" };
		}
	}


	public class geetaalaMbanamu : Rule
	{
		public geetaalaMbanamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త,జ,జ,వ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "geetaalaMbanamu";
			Name = "గీతాలంబనము (కలితాంత , కాంత , కాంతి , మోటనకమ్)";
			Examples = new string[] { "నాళీకభవామరనాథు లొగిన్‌\nశ్రీలోలుని గీర్తన సేయ నొగిన్‌\nబోలంగఁ దజావలఁ బొందిన గీ\nతాలంబన మై చను నద్రియతిన్‌." ,
										"ధారాధరవాహనధైర్యకృతీ\nక్షీరాభ్ధిశిబీశ్వరశీతలరు\nగ్ధారాధరకల్పకకామగవీ\nతారాధిపసన్నిభదాననిధీ"

									};
		}
	}



	public class maMdaaradaama : Rule
	{
		public maMdaaradaama()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "గా" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "maMdaaradaama";
			Name = "మందారదామ (ప్రాకారబన్ధః)";
			Examples = new string[] { "శృంగారరేఖావిశేషస్వరూపా\nరంగజ్జనానీకరక్షాదిలీపా\nసంగీతసాహిత్యసారస్యలోలా\nఅంగీకృతాంగీకృతాచారశీలా" };
		}

	}

	public class sumukhi : Rule
	{
		public sumukhi()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "వ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "sumukhi";
			Name = "సుముఖి (ద్రుతపాదగతి)";

			Examples = new string[] { "కడవఁ గడంగి కడంగి రథుల్\nనడపఁగ దూలిన వాజితతుల్\nకడచి చనున్ ముఖకౢప్తకళల్" };
		}
	}
	public class upasthita2 : Rule
	{
		public upasthita2()
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

			Rules = new string[][] { new string[] { "జ", "స", "త", "గా" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "upasthita2";
			Name = "ఉపస్థిత-2 (స్త్రీ , శిఖండి , విరుత)";

			Examples = new string[] { "ఉపస్థితముచేయున్ జస్తగాప్తిన్\nఉపస్థితముచేయున్ జస్తగాప్తిన్\nఉపస్థితముచేయున్ జస్తగాప్తిన్\nఉపస్థితముచేయున్ జస్తగాప్తిన్" };
		}
	}
	public class upasthita1 : Rule
	{
		public upasthita1()
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

			Rules = new string[][] { new string[] { "త", "జ", "జ", "గా" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "upasthita1";
			Name = "ఉపస్థిత-1";

			Examples = new string[] { "భక్తుల్ హరిమీఁద నుపస్థితం బా\nసక్తిన్ విరతుల్కరిసంఖ్య సాగన్\nసూక్తుల్ గొనిచెప్పెడుచో దజాగా\nయుక్తంబగుచుం జెలువొందుచుండున్" };
		}
	}

	public class Ekaroopa : Rule
	{
		public Ekaroopa()
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

			Rules = new string[][] { new string[] { "మ", "భ", "జ", "గా" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "Ekaroopa";
			Name = "ఏకరూప";

			Examples = new string[] { "స్తోకంబై తోకలును జూలునిప్పుల్\nదాకొన్నన్  హేషలుగ దౌడులొప్పన్\nజీకాకై మంటలకెచేరు గుఱ్ఱా\nలేకోనల్ లేననల మేదుచోటుల్" };
		}
	}
	public class pRdhivi : Rule
	{
		public pRdhivi()
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

			Rules = new string[][] { new string[] { "న", "న", "జ", "వ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "pRdhivi";
			Name = "పృథివి (పృథ్వి)";

			Examples = new string[] { "విరళవిలసితపృథ్వి గనన్\nస్థిరమతి నగనదీవితతిన్\nనెరవగు పలుకు నిండురస\nస్ఫురసుమమధురవృత్తి మదిన్" };
		}
	}
	public class bhramara_vilasita : Rule
	{
		public bhramara_vilasita()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "వ" } };
			Yati = new int[][] { new int[] { 6 } };

			Identifier = "bhramara_vilasita";
			Name = "భ్రమరవిలసిత";

			Examples = new string[] { "మాకందోద్యత్సుమమధుఝరిణీ\nసేకంబై త్రావి సివము లెసఁగన్\nసాకూతంబొప్ప సరస సరఘా\nనీకంబుల్ ఝుమ్మని రొదలురలెన్" };
		}
	}
	public class mauktikamaala : Rule
	{
		public mauktikamaala()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "గా" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "mauktikamaala";
			Name = "మౌక్తికమాల (అనుకూలా)";

			Examples = new string[] { "మౌక్తిక మాలావి మల సుకాంతన్\nవ్యక్తమగున్ స్వాతి పధవిముక్త\nప్రాక్తన జీవార్ణవశుభతత్త్వం\nబుక్తిని శ్రీసూక్త మొదవుశోభన్" };
		}
	}

	public class iMdravajramu : Rule
	{
		public iMdravajramu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "iMdravajramu";
			Name = "ఇంద్రవజ్రము";
			Examples = new string[]{
									"సామర్థ్యలీలన్ తతజద్విగంబుల్\nభూమిధ్రవిశ్రాంతుల బొంది యొప్పున్\nప్రేమంబుతో నైందవబింబవక్త్రున్\nహేమాంబురుం బాడుదు రింద్రవజ్రన్" ,
									"ఈతాజగానిర్మితి నింద్రవజ్రా\nనీతాఖ్య వర్తించు వినిర్మలోక్తిన్\nఇత్తా, జ, గా సంగతి నింద్రవజ్రా\nవృత్తంబగున్ సన్నుత - వృత్తరేచా !"
									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Rules = new string[][] { "త త జ గా".Split(' ') };
			Yati = new int[][] { new int[] { 8 } };


			Prasa = true;
			PrasaYati = false;
		}
	}

	public class upEMdravajramu : Rule
	{
		public upEMdravajramu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "upEMdravajramu";
			Name = "ఉపేంద్రవజ్రము";
			Examples = new string[]{
									"పురారి ముఖ్యామరపూజనీయున్\nసరోజనాభున్ జతజద్విగోక్తిన్\nదిరంబుగానద్రియతిన్నుతింపన్\nఇరాసుతాధీశు నుపేంద్ర వజ్రన్" ,
									"ఉపేంద్రవజ్రాహ్వయ మొప్పునిం పై\nయుపేంద్రపుత్త్రా జతజోక్తగాలన్\nసపద్మ పద్మా ! జత జల్గగంబున్\nఉపేంద్ర వజ్రాఖ్యము నొప్పు జెప్పన్.",
									"పురారిముఖ్యామరు పూజనీయున్‌\nసరోజనాభున్‌ జతజద్విగోక్తిన్‌\nదిరంబుగా నద్రియతిన్నుతింపన్‌\nఇరాసుతాధీశు నుపేంద్రవజ్రన్‌.",
									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Rules = new string[][] { "జ త జ గా".Split(' ') };
			Yati = new int[][] { new int[] { 8 } };


			Prasa = true;
			PrasaYati = false;

		}
	}

	public class vRtta : Rule
	{
		public vRtta()
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

			Rules = new string[][] { new string[] { "న", "స", "త", "గా" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "vRtta";
			Name = "వృత్త";

			Examples = new string[] { "అనిలజుని వృత్తాంతం బపేక్షన్\nవిని మదిని నిర్వృత్తార్తుఁడౌ రా\nముని మనికి శ్రీపుంభావనష్టిన్\nదనిమమున వృత్తస్ఫూర్తినుండెన్" };
		}
	}
}