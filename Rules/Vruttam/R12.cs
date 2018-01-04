//---------------------------------------------------------------------------------------------
// <copyright file="R12.cs" company="Chandam-ఛందం">
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
	public class sragviNi : Rule
	{
		public sragviNi()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "sragviNi";
			Name = "స్రగ్విణీ (లక్ష్మీధర , పద్మినీ)";
			Examples = new string[] {
										"దేవకీనందనున్‌ దేవచూడామణిన్‌\nభూవధూవల్లభుం బుండరీకోదరున్‌\nభావనాతీతునిం బల్కఁగా స్రగ్విణీ\nభావ మాద్యంతరేఫంబగున్‌ షడ్యతిన్‌.",
										"అండజా ధీశవా హా జగద్ధేహ దో\nర్దండ చండారినిర్ధారితారీ నతా\nక్షండలా గండరింఖన్మణీ కుండలా\nపుండరీకేక్షణా ప్రోవునన్ సుక్షణా"
									};




			Prasa = true;
			PrasaYati = false;


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "ర ర ర ర".Split(' ') };
			Yati = new int[][] { new int[] { 7 } };
		}
	}
	public class jalOddhatagati : Rule
	{
		public jalOddhatagati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,స,జ,స".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "jalOddhatagati";
			Name = "జలోద్ధతగతి";
			Examples = new string[] { "సరోరుహదళాక్ష శాశ్వతయశా\nపురారినుత యంచు భూదరయతిన్‌\nసరాగ మగుచున్‌ జసల్‌ జసలతో\nనురుప్రభ యగున్‌ జలోద్ధతగతిన్‌.",
										"పయోధులివి యేడు పాలితమినో\nద్రయాగపరిరక్షణార్ధము సదా\nవయశ్లధశరీరువాంఛనుబడిన్\nప్రయాతములు మౌనిరాజవపతిన్"
									};
		}
	}
	public class ujjvala : Rule
	{
		public ujjvala()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "ర" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "ujjvala";
			Name = "ఉజ్జ్వల";

			Examples = new string[] { "న్నభర లమరున్ మహితోజ్జ్వలన్\nన్నభర లమరున్ మహితోజ్జ్వలన్\nన్నభర లమరున్ మహితోజ్జ్వలన్\nన్నభర లమరున్ మహితోజ్జ్వలన్" };
		}
	}
	public class viSvadaevi : Rule
	{
		public viSvadaevi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,మ,య,య".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "viSvadaevi";
			Name = "విశ్వదేవి (వైశ్వదేవీ)";
			Examples = new string[] {
										"జానొందం గావ్యశ్రీకి సంప్రీతితోడన్‌\nమానాథున్ నాథుం జేసి మాయాగణంబుల్‌\nధీనిత్యుల్‌ ధాత్రీభృద్యతిం గూర్తు రింపుల్‌\nతేనెల్‌ సోనల్‌ గా విశ్వదేవీసమాఖ్యన్‌.",
										"అంభారావోత్సృష్టంబులైపప్లవోగ్రో\nజ్జృంభమ్ముల్ సైన్యంబుల్ ధురీణాంబులంతన్\nభుంభుంధ్వానంబుల్గాగఁబుట్టెన్ ధరాబృ\nద్గంభీరానీకంబున్ విఘాతంబు చేసెన్"
									};
		}
	}

	public class jaladharamaala : Rule
	{
		public jaladharamaala()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,భ,స,మ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };


			Identifier = "jaladharamaala";
			Name = "జలధరమాలా (కాంతోత్పీడా)";

			Examples = new string[] {
										"శ్రీతన్వీశుం దగిలితిఁ జిత్తం బారన్‌\nమాతా యంచున్‌ జలధరమాలావృత్తం\nబేతేరంగా మభనమ లింపొందంగాఁ\nబ్రీతిం బల్కన్విరతి కరిన్‌ బ్రాపించున్‌.",
										"ఆకాశంబందునగరుదాక్షోదంబై\nయేకోనల్పోయితిమట నేదిక్కేదోఁ\nకాకుండం గన్నులు జతుకావర్ణంబై\nయేకోనల్తోచవుమదికేదోభీతిన్"
									};
		}
	}

	public class iMdravaMSamu : Rule
	{
		public iMdravaMSamu()
		{
			Lines = 4;
			Threshold = 3;

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "iMdravaMSamu";
			Name = "ఇంద్రవంశము(ఇన్దువంశా)";
			Examples = new string[] { "సొంపార నీ దేవుని సూనుఁడై కదా\nఱంపిల్లెఁ బుష్పాస్త్రుఁడు ఱాఁగ యౌననన్‌\nఇంపార భూభృద్యతి నింద్రవంశమున్‌\nబెంపారఁ దాజంబులఁ బేర్చు రేఫతోన్‌.",
										"ఆకాశమందైనఁ గటాచవందరం\nగాకీర్ణ ఘోరాకృతియాడనీయకే\nరేకైన ఱెక్కన్విని కృత్తశక్తియై\nకాకంబు విష్ణ్వాశపొకారిపోవఁగా"
									};


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త త జ ర".Split(' ') };

			Yati = new int[][] { new int[] { 8 } };
		}
	}

	public class vaMSasthamu : Rule
	{
		public vaMSasthamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,త,జ,ర".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "vaMSasthamu";
			Name = "వంశస్థము";
			Examples = new string[] {
										 "నమో నమో దేవ జనార్దనాయ తే\nనమో నమః పంకజనాభ నావుడున్‌\nరమించు వంశస్థ విరామమద్రులన్‌\nసమంచితంబై జతజంబు రేఫయున్‌.",
										 "లతాంగు లానంద వులాస మూర్తులై\nనితాంత గర్భంబులు నిక్కిముందటన్\nపతంగ రాత్చంచువు భాతి శార్ ఙ్గస\nజ్యతాధురావైఖరి నధ్భుతంబుగాన్"
									};
		}
	}

	public class bhujaMgaprayaatamu : Rule
	{
		public bhujaMgaprayaatamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "bhujaMgaprayaatamu";
			Name = "భుజంగప్రయాతము (అప్రమేయా)";
			Examples = new string[] {   "హరించుం గలిప్రేరితాఘంబులెల్లన్\nభరించున్ ధరన్ రామభద్రుండుఁ బోలెన్\nజరించున్ సదా వేదశాస్త్రానువృత్తిన్\nవరించున్ విశేషించి వైకుంఠుభక్తిన్.",
										"హరీ ! చక్రధారీ ! మురారీ ! త్రిధామా !\nవరాంగా ! యుపేంద్రా ! సుబావో ! స్వయంభూ !\nపరేశా ! హృషీకేశ ! వైకుంఠవాసా !\nవరాహా ! సహస్రాక్ష ! ప్రాగ్వంశ ! దేవా ! ",
										" ద్విపాస్యత్రిధామత్రిధాతుప్రసిద్ధా!\nసుపర్వప్రమోదాశుభాంగావృషాంకా!\nకపిత్థాత్త సంపృక్త భుక్తప్రహృష్టా!\nకృపాంభోధి! కుబ్జాకృ తీశా! నమస్తే!",
										"అభద్రాంధకారోదయద్భానుభావా\nశుబైకాశ్రయీభూత శుద్ధస్వభావా\nఅభక్తావళీదృష్ట్యహః కాలతారా\nస్వభక్తాగ్రభూపారి జాతావతారా"
									};

			Prasa = true;
			PrasaYati = false;

			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "య య య య".Split(' ') };
			Yati = new int[][] { new int[] { 8 } };
		}
	}

	public class priyaMvada : Rule
	{
		public priyaMvada()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,భ,జ,ర".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "priyaMvada";
			Name = "ప్రియంవద (మత్తకోకిల)";
			Examples = new string[] {   "త్రిభువనాభినుతు దేవదేవునిన్‌\nబ్రభు ముకుందు నిటు ప్రస్తుతింపఁగా\nనభజరల్గదిసినం బ్రియంవదా\nవిభవ మొప్పు గిరి విశ్రమంబులన్‌.",
										"దివిషదీశ్వరుఁడు తేపమౌనులున్\nగవురుగప్పుచుపొగల్ వెలార్పఁగా\nనవుదపస్సుల మహాగ్నిరేగఁగా\nనవురయచ్చరలనంపునంటఁగా" };
		}
	}


	public class pramitaaksharamu : Rule
	{
		public pramitaaksharamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,జ,స,స".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "pramitaaksharamu";
			Name = "ప్రమితాక్షరము";
			Examples = new string[] {
										"కమనీయతేజుని నగణ్యయశున్‌\nగమలాధిపుం బలుకఁగా సజసల్‌\nక్రమమొప్పుఁ గూడఁగ సకారముతోఁ\nబ్రమితాక్షరం బహివిరామమగున్‌.",
										"ప్రమితాక్షరప్రణవరాజితమౌ\nప్రమధాధిపప్రధితతౌధననా\nమములాత్మనేమశుభమంత్రములై\nవిమలాత్మబుధ్ధిసమవీతములన్"
									};
		}
	}


	public class dRtavilaMbitamu : Rule
	{
		public dRtavilaMbitamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,భ,భ,ర".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "dRtavilaMbitamu";
			Name = "ద్రుతవిలంబితము (సుందరీ , హరిణప్లుతా)";
			Examples = new string[] {
										"శ్రుతి మతాంగ నిరూఢమహాయతిన్‌\nయతివరప్రముఖార్యజనం బొగిన్‌\nద్రుతవిలంబిత తోషితరీతులన్‌\nక్షితిధరున్‌ నుతిసేయు నభారలన్‌.",
										"త్రిభువనాంకుశదీప్తనిధీసమ\nస్త భువనాశ్రయధర్మధురంధరా\nశుభయశః పరిశోభితపూర్వది\nక్పృభువిలాసకృపారసభంధురా"
									};
		}
	}

	public class tOvakamu : Rule
	{
		public tOvakamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,జ,య".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "tOvakamu";
			Name = "తోవకము (తోదకము-2 , దోధకము , తామరస , కలరవము)";
			Examples = new string[] {
										"చెలఁగి నజాయలఁ జెందిన నారీ\nతిలకము లద్రియతిన్‌ మృదురీతిన్‌\nవెలయఁగఁ దోవక వృత్తి విభాతిన్‌\nబలుకుదు రిమ్ములఁ బంకజనాభున్‌.",
										"తమతమతప్పులుదారెరియంగా\nవిమలమతీ యిటు వీరికినై శో\nకమున దహింపఁగఁగాదుమనంబున్\nసముచితమిత్తఱి శాంతముసుమ్మీ"
									};
		}
	}

	public class tOTakamu : Rule
	{
		public tOTakamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "tOTakamu";
			Name = "తోటకము (ఛిత్తక , భ్రమరావళి , నందినీ)";
			Examples = new string[] {   "జగదీశ్వర  నాకు  బ్ర సన్నుఁ డవే\nనొగినాతపమున్  ఫల యుక్తమయే\nన్సగరాత్మజులందరు నావలనన్\nవగదీరఁగఁ గాంత్రు నివాపములన్",
										"జలజోదరనిర్మలసంస్తవముల్‌\nవిలసిల్లెడుఁ దోటకవృత్తమునన్‌\nబొలుపై సచతుష్కముఁ బొండగ నిం\nపలరారఁగఁ బల్కుదు రష్టయతిన్‌.",
										"అలకాధిపతీసుగుణాభిరతీ\nమలయోధ్భవచంద్రసమానయశా\nకులపావసయూరుజగోత్రవరా\nలలనాజనతాఝుషలక్ష్మనుభా"
									};



			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			RuleType = RuleType.Name;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "స స స స".Split(' ') };
			Yati = new int[][] { new int[] { 9 } };


			Prasa = true;
			PrasaYati = false;
		}
	}

	public class padamaali : Rule
	{
		public padamaali()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "ర" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "padamaali";
			Name = "పదమాలి (మాలతీ)";
			Examples = new string[] { "నజజర లీపదమాలి నాదగున్\nనజజర లీపదమాలి నాదగున్\nనజజర లీపదమాలి నాదగున్\nనజజర లీపదమాలి నాదగున్" };
		}
	}
	public class prabha : Rule
	{
		public prabha()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "prabha";
			Name = "ప్రభ (ప్రముదితవదన , ప్రభాత , మందాకినీ , గౌరీ , చంచలాక్షీ)";
			Examples = new string[] { "స్వరయతి ననరాల్ ప్రభాఖ్యం దగున్\nస్వరయతి ననరాల్ ప్రభాఖ్యం దగున్\nస్వరయతి ననరాల్ ప్రభాఖ్యం దగున్\nస్వరయతి ననరాల్ ప్రభాఖ్యం దగున్" };
		}
	}
	public class prahEya : Rule
	{
		public prahEya()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "య" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "prahEya";
			Name = "ప్రహేయ (పుటః)";
			Examples = new string[] { "అమరపతిసుతప్రాలంబబాహు\nభ్రమణచటుల ధూఃపాతంబుతోడన్\nకమలవిమలసూకాయంబు గ్లానిన్\nచెమరిచి కలఁగెన్ జేతంబు తూలన్" };
		}
	}
	public class maNimaala1 : Rule
	{
		public maNimaala1()
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

			Rules = new string[][] { new string[] { "త", "య", "త", "య" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "maNimaala1";
			Name = "మణిమాల-1 (అబ్జవిచిత్రా , పుష్పవిచిత్రా)";
			Examples = new string[] { "భృంగామలచూడా బాణాసురహేడా\nశృంగారవిరామా నృత్యాహితకామా\nసంగేతరవృత్తీ సంవ్యానితకృత్తీ\nసాంగాగమమూర్తీ సాయుజ్యదకీర్తీ" };
		}
	}
	public class mEghavilasitamu : Rule
	{
		public mEghavilasitamu()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "స" } };
			Yati = new int[][] { new int[] { 6 } };

			Identifier = "mEghavilasitamu";
			Name = "మేఘవిలసితము";
			Examples = new string[] { "ప్రాంతోన్మీలితపలితసరసిజా\nక్రాంతాక్షిస్ఫుటకరుణరసధునీ\nకాంతోషస్సితకమలన సదృశా\nకాంతార్థీకృతి ఘటిత తనుఘృణీ" };
		}
	}
	public class lalita : Rule
	{
		public lalita()
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

			Rules = new string[][] { new string[] { "త", "భ", "జ", "ర" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "lalita";
			Name = "లలిత";
			Examples = new string[] { "తాల్చు న్నభాశి లలితన్ తభల్ జరల్\nతాల్చు న్నభాశి లలితన్ తభల్ జరల్\nతాల్చు న్నభాశి లలితన్ తభల్ జరల్\nతాల్చు న్నభాశి లలితన్ తభల్ జరల్" };
		}
	}
	public class navamaalini : Rule
	{
		public navamaalini()
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

			Rules = new string[][] { new string[] { "న", "జ", "భ", "య" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "navamaalini";
			Name = "నవమాలిని";
			Examples = new string[] { "నలి నవమాలినిన్ నజభయల్ విన్\nనలి నవమాలినిన్ నజభయల్ విన్\nనలి నవమాలినిన్ నజభయల్ విన్\nనలి నవమాలినిన్ నజభయల్ విన్" };
		}
	}
	public class kusuma_vichitra : Rule
	{
		public kusuma_vichitra()
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

			Rules = new string[][] { new string[] { "న", "య", "న", "య" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "kusuma_vichitra";
			Name = "కుసుమవిచిత్ర (గజలలిత)";
			Examples = new string[] { "శకయవనాళుల్ సకల ధరిత్రిన్\nవికటగతిం ద్రెవ్విన నరపాలుం\nడకుటిలబుద్ధిన్ హతులను జేసెన్\nశకచమువుల్ భాస్వరశరవహ్నిన్" };
		}
	}
	public class chaMdravartma : Rule
	{
		public chaMdravartma()
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

			Rules = new string[][] { new string[] { "ర", "న", "భ", "స" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "chaMdravartma";
			Name = "చంద్రవర్త్మ";
			Examples = new string[] { "ఉర్వియెల్ల నొక యుండవలె మహా\nఖర్వమూర్తికనగాను వెలసెఁ దా\nముర్విఁ బెద్ద నదు లూచకొనియె నా\nదూర్వ కాడలనఁ దోచె నచటికిన్" };
		}
	}
	public class vRMta : Rule
	{
		public vRMta()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "గా" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "vRMta";
			Name = "వృంత (రథపదమ్)";

			Examples = new string[] { "ఇతఁడు శరభుఁడు నహిప్రౌఢిన్\nపృతన మొగదలఁ జరించున్ సం\nగత ప్రళయసమయకాలుండై\nవితతభుజపరిఘవీలుండై" };
		}
	}

}