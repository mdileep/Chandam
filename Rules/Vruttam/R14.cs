//---------------------------------------------------------------------------------------------
// <copyright file="R14.cs" company="Chandam-ఛందం">
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

	public class sumaMgali : Rule
	{
		public sumaMgali()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "స,జ,స,స,గా".Split(',') };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "sumaMgali";
			Name = "సుమంగలి-2";
			Examples = new string[] { "కరులన్ సుమంగలి కదా సజసాగాలన్\nకరులన్ సుమంగలి కదా సజసాగాలన్\nకరులన్ సుమంగలి కదా సజసాగాలన్\nకరులన్ సుమంగలి కదా సజసాగాలన్" };
		}
	}
	public class vanamayooramu : Rule
	{
		public vanamayooramu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "vanamayooramu";
			Name = "వనమయూరము(ఇందువదన , ఇన్ద్రవదనా)";
			Examples = new string[]{
									"ఉన్నతములై వనమయూరకృతులోలిన్\nఎన్నగ భజంబులపయిన్ సనగగంబుల్\nచెన్నొదవ దంతియతి జెంది యలవారున్\nవెన్నుని నుతింతురు వివేకులతిభక్తిన్" ,
									"మాణవకరత్నములు  మౌనివరువెంటన్\nరాణమెయిఁ  బోవునెడ  రాముఁ డు  మృదుశ్రీ\nవాణి నిటు  పల్కె  ఋషి వర్య !  గిరిచెంతన్\nబొణిమి  నెసంగెఁ  దరుపుంజ మది  గంటే ?",
									"రాజకులశేఖరపరంతప వివేక\nభ్రాజిత జగద్వలయ భాసురసముద్య\nత్తేజనిరవద్యయువతీమదనవీరో\nగ్రాజివిజయాత్రిభివనంకుశనరేంద్రా"
									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "భ జ స న గా".Split(' ') };
			Yati = new int[][] { new int[] { 9 } };


			Prasa = true;
			PrasaYati = false;
		}

	}
	public class bhoonutamu : Rule
	{
		public bhoonutamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,న,భ,భ,గా".Split(',') };

			Yati = new int[][] { new int[] { 10 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "bhoonutamu";
			Name = "భూనుతము-1 (లతా , వనలతా , వలనా)";
			Examples = new string[] {
										"శ్రీనివాస పురుషోత్తమ సింధువిహారా\nపూని మమ్ముఁ గృప జేకొని ప్రోవు మనంగా\nభూనుతంబు రనభాగలఁ బొంది గయుక్తిన్‌\nపూని సొంపుగ గ్రహాక్షరమున్‌ వడినొందన్‌.",
										"ఆకఁలేకయయపాంపతినైననుదాటున్\nదోఁకచిచ్చనఁ గరక్కసితుంగదహించున్\nవీఁక యీదృశములోకము వీరులకెల్లన్\nజోఁక యీతనికినంజని సూమనకెందున్"
									};
		}
	}

	public class bhoonuta2 : Rule
	{
		public bhoonuta2()
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

			Rules = new string[][] { new string[] { "ర", "న", "న", "భ", "గా" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "bhoonuta2";
			Name = "భూనుతము-2";

			Examples = new string[] { "అందమై రననభతతి నంది గగంబుల్\nపొందఁగాఁ బదగతి గని భూనుతమయ్యెన్\nఅందమై రననభతతి నంది గగంబుల్\nపొందఁగాఁ బదగతి గని భూనుతమయ్యెన్" };
		}
	}

	public class kamalavilasitamu : Rule
	{
		public kamalavilasitamu()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,న,న,గా".Split(',') };
			Yati = new int[][] { new int[] { 9 } };
			Identifier = "kamalavilasitamu";
			Name = "కమలవిలసితము(సురుచిర , ఉపచిత్ర , సుపవిత్ర)";
			Examples = new string[] {
										"నగణము నగణము నగణముఁ జేరన్\nనగణము గగము నొనర నట మీఁదన్\nదిగి భ విరమణము దిరమగునేనిన్\nదగుఁ  గమలవిలసితము కమలాక్షా",
										"క్రమమున ననననగగములు గూడన్\nగమలవిలసితము కమలజవిశ్రా\nమము జగతిని నగు మహితచరిత్రా\nకమలదళనయన కడుఁ బొగడొందున్." };
		}
	}

	public class praharaNakalita : Rule
	{
		public praharaNakalita()
		{
			Lines = 4;
			Threshold = 3;



			Identifier = "praharaNakalita";
			Name = "ప్రహరణకలిత (ప్రహరణకలికా)";
			Examples = new string[] {   "వనములు నదులున్ వరుసగఁ గనుచున్\nజనపతి చనెఁ దిన్నని పయనములన్\nమునికులతిలకున్ మును చని కనెఁ బా\nవనశుచిరుచి నవ్వరఋషితనయున్",
										"వనరుహసఖుఁడన్‌ వనరుహరిపుఁడన్‌\nగనుఁగవ యగు నాకరి వరదునకున్‌\nననభనలగమున్నగయతిఁ బలుకన్‌\nబనుపడుఁ గృతులం బ్రహరణకలితన్‌.",
										"ఇది యిటులగుటట్లెఱిఁగి పలికె నా\nవిదురుఁడు సభఁగోవిదులు వొగడఁగా\nనదివినియును నేనడపనదురితం\nబొదవెఁగలకసేటొలయకుడుగునే"
									};

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "న న భ న వ".Split(' ') };
			Yati = new int[][] { new int[] { 8 } };


			Prasa = true;
			PrasaYati = true;

		}
	}

	public class asaMbaadha : Rule
	{
		public asaMbaadha()
		{
			Lines = 4;
			Threshold = 3;

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "asaMbaadha";
			Name = "అసంబాధ";
			Examples = new string[] { "కోటుల్ లక్షల్ దానవబలములు క్షోదింపన్\nనీటుల్ గోటిల్ సాగవు పొసగదు నిల్వంగన్\nదాటీఘోటీఘట్టనశకలితదర్పంబౌ\nనాటోపంబున్ జూపఁగ వెలఁదుక యన్నట్లా",
									"సౌమ్యంబై విష్ణుస్తుతులను నతి సేవ్యంబై\nరమ్యస్ఫూర్తిన్‌ రుద్రవిరమణము రమ్యంబై\nగమ్యాకారం బొప్పు మతనసగగప్రాప్తిన్‌\nసమ్యగ్భావంబై పొలుపమరు నసంబాధన్‌." };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,త,న,స,గా".Split(',') };
			Yati = new int[][] { new int[] { 12 } };
		}
	}


	public class aparaajitamu : Rule
	{
		public aparaajitamu()
		{
			Lines = 4;
			Threshold = 3;

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "aparaajitamu";
			Name = "అపరాజితము (పరాజితము)";
			Examples = new string[] {   "మునిజనవినుతుం డమోఘజయోన్నతుం\nడనితరసదృశుం డనంగ గురుం డనం\nజను ననయుతమై రసంబు లగంబులై\nతనరఁగ నపరాజితం బహిరాడ్యతిన్‌.",
										"ననరసలగముల్ పెనంగినసద్యశో\nధనవినుపరాజితంబగురేచనా\nననరసలగముల్ పెనంగినసద్యశో\nధనవినుపరాజితంబగురేచనా"};


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,ర,స,వ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };
		}
	}
	public class suMdari : Rule
	{
		public suMdari()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,భ,ర,స,వ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "suMdari";
			Name = "సుందరి-2";
			Examples = new string[] { "కోరిన కోరిక లిచ్చుఁ గోమలి చూడవే\nమారునితండ్రి యనం గ్రమంబున నీక్రియన్‌\nభారసవంబుల నొప్పుఁ బన్నగరాడ్యతిన్‌\nసూరిజనంబులు సెప్ప సుందరివృత్తముల్‌.",
									  "వెన్నెల లో విహరిమ్చ వెళ్ళగ వేడ్కగా\nకన్నుల ముమ్దర తోచె కాంతుల కల్కియై\nఅన్నుల మిన్నయె తాను అల్లన నాడుచున్\nవెన్నెలె ఆడిన రీతి , పేర్మిని వీణతో"
									};
		}
	}

	public class vasaMtatilakamu : Rule
	{
		public vasaMtatilakamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "vasaMtatilakamu";
			Name = "వసంతతిలకము (ఉద్ధర్షిణీ , ఔద్ధర్షిణి , కర్ణోత్పలా , మధుమాధవీ , శోభావతీ , సింహోన్నతా , సింహోద్ధతా , మదనము)";
			Examples = new string[] {
										"శ్రీరమ్య రాజకులశేఖర రాజరాజా\nభూరిప్రతాపపరిభూతవిరోధివర్గా\nహారామృతాబ్జహర హాసతుషారకుంద\nస్ఫారద్యశఃప్రసర పాండుకృతత్రిలోకా",
										"గౌరీనితాంతజప కారణనామధేయున్‌\nదూరీకృతప్రణతదుష్కృతు నంబుజాక్షున్‌\nధీరోత్తముల్గిరియతిన్‌ తభజాగగల్పెం\nపారన్వసంతతిలకాఖ్య మొనర్తు రొప్పున్‌."

									};





			Prasa = true;
			PrasaYati = false;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "త భ జ జ గా".Split(' ') };
			Yati = new int[][] { new int[] { 8 } };
		}
	}
	public class madanamu : Rule
	{
		public madanamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త,భ,జ,జ,గా".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "madanamu";
			Name = "మదనము";
			Examples = new string[] { "దైతేయభంజన హరీ తభజాగగంబుల్\nమాతంగ విశ్రమమునన్ మదనాఖ్య నొప్పున్.\nదైతేయభంజన హరీ తభజాగగంబుల్\nమాతంగ విశ్రమమునన్ మదనాఖ్య నొప్పున్."
									};
		}
	}
}

//Pending Examples: అసంబాధ
namespace Chandam.Rules.Rare
{

	public class aalOla : Rule
	{
		public aalOla()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,స,మ,భ,గా".Split(',') };
			Yati = new int[][] { };
			Identifier = "aalOla";
			Name = "ఆలోల";
			Examples = new string[] { };
		}
	}
	public class kalaravamu : Rule
	{
		public kalaravamu()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,న,న,న,వ".Split(',') };
			Yati = new int[][] { };
			Identifier = "kalaravamu";
			Name = "కలరవము";
			Examples = new string[] { };
		}
	}
	public class kumaari : Rule
	{
		public kumaari()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,భ,జ,వ".Split(',') };
			Yati = new int[][] { new int[] { 7 } };
			Identifier = "kumaari";
			Name = "కుమారి (కురరీరుతా)";
			Examples = new string[] { "సకలమునీంద్రబృందహృదయాబ్జరవిమ్\nప్రకటితభక్తరక్షణచణాగ్రసరమ్\nవికచసరోజసుందరదరస్మితకమ్\nప్రకృతివిభాసురం భవ! భజామి సదా!" };
		}
	}
	public class jalaMdharamu : Rule
	{
		public jalaMdharamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,భ,భ,జ,వ".Split(',') };

			Yati = new int[][] { new int[] { 11 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "jalaMdharamu";
			Name = "జలంధరము";
			Examples = new string[] { };
		}
	}
	public class nadi : Rule
	{
		public nadi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,త,జ,గా".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "nadi";
			Name = "నది";
			Examples = new string[] { };
		}
	}
	public class naaMdeemukhi : Rule
	{
		public naaMdeemukhi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,స,త,త,గా".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "naaMdeemukhi";
			Name = "నాందీముఖి";
			Examples = new string[] { };
		}
	}
	public class maNikamalavilasitamu : Rule
	{
		public maNikamalavilasitamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,స,స,స,గా".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "maNikamalavilasitamu";
			Name = "మణికమలవిలసితము";
			Examples = new string[] { };
		}
	}
	public class madanaarta : Rule
	{
		public madanaarta()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త,య,స,భ,గా".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "madanaarta";
			Name = "మదనార్త (శారదచన్ద్రః)";
			Examples = new string[] { };
		}
	}
	public class vaasaMti : Rule
	{
		public vaasaMti()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,త,న,మ,గా".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "vaasaMti";
			Name = "వాసంతి";
			Examples = new string[] { };
		}
	}
	public class vidrumalata : Rule
	{
		public vidrumalata()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,న,న,వ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "vidrumalata";
			Name = "విద్రుమలత";
			Examples = new string[] { };
		}
	}
	public class SlOkamu : Rule
	{
		public SlOkamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "SlOkamu";
			Name = "శ్లోకము";
			Examples = new string[] { };



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "త భ జ జ హ".Split(' ') };
			Yati = new int[][] { };


			Prasa = false;
			PrasaYati = false;
		}

	}




}
