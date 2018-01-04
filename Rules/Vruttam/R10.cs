//---------------------------------------------------------------------------------------------
// <copyright file="R10.cs" company="Chandam-ఛందం">
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

	public class sarasaaMkavRttamu : Rule
	{
		public sarasaaMkavRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,జ,స,స,య".Split(',') };

			Yati = new int[][] { new int[] { 10 } };



			Identifier = "sarasaaMkavRttamu";
			Name = "సరసాంక";
			Examples = new string[] { "సరసాంక వృత్తమమరున్ సజసాయ లొందన్\nసరసీజ సంభవయతిన్ జలజాత నేత్రా\nసరసాంక వృత్తమమరున్ సజసాయ లొందన్\nసరసీజ సంభవయతిన్ జలజాత నేత్రా"
									};
		}
	}
	public class SuddhaviraaTi : Rule
	{
		public SuddhaviraaTi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,స,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 6 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "SuddhaviraaTi";
			Name = "శుద్ధవిరాటి (విరాట్)";
			Examples = new string[] {
										"శ్రీమంతుండగు చిన్న కృష్ణునిన్‌\nధీమంతుల్ప్రణుతింప బాణవి\nశ్రామంబున్‌ మసజంబు గంబునై\nరామా శుద్ధవిరాటి యొప్పగున్‌.",
									};
		}
	}
	public class mayoorasaari : Rule
	{
		public mayoorasaari()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,జ,ర,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "mayoorasaari";
			Name = "మయూరసారి(మయూరభాషిణి)";
			Examples = new string[] { "చూతమా యశోదసూను నంచున్‌\nవ్రేత పల్కుఁ దర్కవిశ్రమంబుల్‌\nభాతిగా రజంబుపై రగంబుల్‌\nజాతిగా మయూరసారిఁ జెప్పున్‌." };
		}
	}
	public class matta : Rule
	{
		public matta()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,భ,స,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "matta";
			Name = "మత్త (హంసశ్రేణి)";
			Examples = new string[] { "మొత్తం బారున్మభములు నిత్యో\nదాత్తంబై సస్ఫురిత గకారా\nయత్తంబై షణ్మితయతి నొందున్‌\nమత్తావృత్తంబగు మహిఁ గృష్ణా!" };
		}
	}
	public class maNiraMgamu : Rule
	{
		public maNiraMgamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,స,స,గ".Split(',') };

			Yati = new int[][] { new int[] { 6 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "maNiraMgamu";
			Name = "మణిరంగము";
			Examples = new string[] {   "శ్రీమనస్సరసీరుహమిత్రున్‌\nబ్రేమ మొప్పఁగ బేర్కొనుచోటన్‌\nరామ నస్త్రవిరామ రసాగల్‌\nకోమలంబులగున్మణిరంగన్‌.",
										"చెంగనాలుగ-చిత్రగతుల్గా\nదొంగయేణముతోచునుదూరో\nత్తుంగధారుణి-దూర్వనుమేయన్\nవంగినట్టులు-పాతరలాడున్"};
		}
	}
	public class paNavamu : Rule
	{
		public paNavamu()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,న,య,గ".Split(',') };
			Yati = new int[][] { new int[] { 6 } };
			Identifier = "paNavamu";
			Name = "పణవము (ప్రణవ , హీరాఙ్గీ)";
			Examples = new string[] {   "నీయుల్లం బొకనియతిం గార్యం\nబాయత్తంబుగ ననుసంధింపం\nజేయంజాలవు చెడుతెర్వుం బో\nబాయంద్రోయవు బలిమిం బుత్రున్",
										"ఆరంగా మనయగసంయుక్తిన్‌\nసారోదంచితశర విశ్రాంతిన్‌\nశ్రీరాజుం బొరసిన నత్యంత\nస్ఫారంబై చను ప్రణవం బుర్విన్‌.",
										"అందంబై మనయుగముల్ సొంపిం \n పం దప్పొందక పణవం బయ్యెన్." };
		}
	}
	public class rugmavati : Rule
	{
		public rugmavati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,మ,స,గ".Split(',') };

			Yati = new int[][] { new int[] { 6 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "rugmavati";
			Name = "రుగ్మవతి";
			Examples = new string[] { "అంగయతిం బొందై భమసల్ ప\nర్వుం గురుయుక్తిన్ రుగ్మవతిన్ స\nత్యాంగనకై తేఁ దా సురశాఖిం\nబొంగుచు గోపీపుత్రుఁ డనంగన్."
									};
		}
	}
	public class chaMpakamaali : Rule
	{
		public chaMpakamaali()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Rare;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,మ,స,గ".Split(',') };
			Yati = new int[][] { new int[] { 7 } };


			Identifier = "chaMpakamaali";
			Name = "చంపకమాలి (రుక్మవతి , చంపకమాలి , చంపకమాలా , పుష్పసమృద్ధి , సుభావా)";
			Examples = new string[] { "చంపకమాలిన్ గృష్ణమురారిన్\nసొంపుగ గాంచన్ హృచ్ఛభ వీధీన్\nమంపిలు వాంచాళిస్మయమిందిన్\nబెంపదెనిర్వృత్తస్ఫిరదృష్టిన్"
									};
		}
	}

	public class kOmala : Rule
	{
		public kOmala()
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

			Rules = new string[][] { new string[] { "భ", "భ", "మ", "గ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "kOmala";
			Name = "కోమల";

			Examples = new string[] { "భామగురుప్రతిభన్ బెంపొందన్\nగోమలవృత్తమగున్ రంగేంద్రా\nభామగురుప్రతిభన్ బెంపొందన్\nగోమలవృత్తమగున్ రంగేంద్రా" };
		}
	}

	public class kaumidi : Rule
	{
		public kaumidi()
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

			Rules = new string[][] { new string[] { "న", "త", "త", "గ" } };
			Yati = new int[][] { new int[] { 6 } };

			Identifier = "kaumidi";
			Name = "కౌముది (చరపదమ్)";

			Examples = new string[] { "తొడిరుమణ్వంతుఁ డీతండు నె\nక్కుడు రిపుశ్రీకుజోన్మీలనో\nగ్రుఁడు భుజోద్యద్రుషాస్ఫోటనో\nగ్రుఁడు సమిద్ధీరుఁడు శ్రీపతీ" };
		}
	}
	public class naMdini : Rule
	{
		public naMdini()
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

			Rules = new string[][] { new string[] { "భ", "త", "జ", "గ" } };
			Yati = new int[][] { new int[] { 6 } };

			Identifier = "naMdini";
			Name = "నందిని (నంది)";

			Examples = new string[] { "ధేనువుగా నందినినాత్మకా\nమ్యానుగతశ్రీలమరన్ శుభ\nఙ్ఞానపయోవాంచను గొల్తు న\nవ్యానిశపుష్టిన్‌హరిఁజేరఁగన్" };
		}
	}
	public class utsuka : Rule
	{
		public utsuka()
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

			Rules = new string[][] { new string[] { "భ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "utsuka";
			Name = "ఉత్సుక (మదనోద్ధురా)";

			Examples = new string[] { "ఉత్సుక మొప్పరచింతు శ్రీ\nవత్సశుభాంకితునిత్యనూ\nత్నోత్సవకల్పితదివ్యసే\nవోత్సము హృద్యవచశ్శ్రుతిన్" };
		}
	}
	public class kiSOra : Rule
	{
		public kiSOra()
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

			Rules = new string[][] { new string[] { "న", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "kiSOra";
			Name = "కిశోర (కరశయా)";

			Examples = new string[] { "సునభరాప్తికిశోరమిం\nపెనయురంగమహీపతీ\nసునభరాప్తికిశోరమిం\nపెనయురంగమహీపతీ" };
		}
	}
	public class rasaali : Rule
	{
		public rasaali()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "గ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "rasaali";
			Name = "రసాలి";
			Examples = new string[] { "తృప్తశైలదుహితృప్రియా ధీ\nసుప్తసంవిదతి శుద్ధతత్త్వా\nదీప్తతైజస నదీక్రియా ని\nర్లిప్తభావ విమలీకృతత్వా" };
		}

	}
	public class manOrama : Rule
	{
		public manOrama()
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

			Rules = new string[][] { new string[] { "న", "ర", "జ", "గ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "manOrama";
			Name = "మనోరమ";

			Examples = new string[] { "మనికి రమ్యమౌ మనోరమా\nర్చనలు నిత్యధర్మమై మనో\nజ్ఞనలినీవిశిష్టజీవమ\nట్లనిశముక్తి నభ్యసించఁగన్" };
		}
	}
	public class paMkti2 : Rule
	{
		public paMkti2()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "గ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "paMkti2";
			Name = "పంక్తి-2(విశ్వముఖీ)";

			Examples = new string[] { "దుర్ముఖుఁడీతఁడు తూగి సమి\nత్కర్మ ప్రచండుఁడుకాహళరా\nనోర్మిచలద్రవుఁ డత్థభుజా\nకర్మఠుఁ డాహవకాలుఁడయా" };
		}
	}
	public class bhOgavilasita : Rule
	{
		public bhOgavilasita()
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

			Rules = new string[][] { new string[] { "భ", "స", "జ", "గ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "bhOgavilasita";
			Name = "భోగివిలసిత(కుప్యమ్)";

			Examples = new string[] { "భోగివిలసితస్ఫుటప్రభా\nభోగలసితు శంభుఁ గొల్తు నే\nనాగమనుతుఁ బుణ్యకీర్తనన్\nనాగమటుల మంత్రముగ్ధనై" };
		}
	}
}