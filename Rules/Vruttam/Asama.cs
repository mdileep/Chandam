//---------------------------------------------------------------------------------------------
// <copyright file="Asama.cs" company="Chandam-ఛందం">
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
	public class nadeepraghOshamu : Rule
	{
		public nadeepraghOshamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {
										"ర,ర,ర,ర".Split ( ',' ),
										"జ,త,జ,ర".Split( ',' ),
										"జ,త,జ,ర".Split( ',' ),
										"జ,త,జ,ర".Split( ',' ),
									};
			Yati = new int[][] { new int[] { 7 }, new int[] { 8 }, new int[] { 7 }, new int[] { 8 } };

			Identifier = "nadeepraghOshamu";
			Name = "నదీప్రఘోషము";
			Examples = new string[] {
										"నాగతల్పా మొద ల్నాల్గు రేఫంబులున్‌\nజగన్నివాసా జతజంబు రేఫయున్‌\nదగంగ నమ్మూఁడు పదంబులందు జా\nతిగాఁ బ్రవర్తించు నదీ ప్రఘోషకున్‌."
									};

		}
	}
	public class vaaraaMgi : Rule
	{
		public vaaraaMgi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {
									"జ,త,జ,గా".Split(','),
									"జ,త,జ,గా".Split(','),
									"త,త,జ,గా".Split(','),
									"త,త,జ,గా".Split(','),
									};
			Yati = new int[][] { new int[] { 8 } };
			Examples = new string[] { "చళుక్యవంశాజతజల్ గగంబుల్\nచెలంగి యర్థంబునఁ జెంది రీతిం\nగ్రాలంగఁ దాయత్తజగానియుక్తిన్\nమేలయ్యె వారాంగి సమీహితాఖ్యన్",
										"సరిత్పదాబ్జా జతజల్‌ గగల్‌ బం\n	ధురం బగున్‌ రెంట జతుర్థకాంఘ్రిన్‌\nగారాముతోఁ దాజగగల్‌ వరాంగిన్‌\nహరార్చితా మూఁడవయంఘ్రి నొందున్‌."
									};


			Identifier = "vaaraaMgi";
			Name = "వారాంగి";

		}
	}
	public class ratipriyavRttamu : Rule
	{
		public ratipriyavRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {
										"మ,న,జ,ర,గ".Split ( ',' ),
										"జ,భ,స,జ,గ".Split ( ',' ),
										"మ,న,జ,ర,గ".Split ( ',' ),
										"జ,భ,స,జ,గ".Split ( ',' ),
									};
			Yati = new int[][] {    new int[] { 8 } ,
									new int[] { 9 } ,
									new int[] { 8 } ,
									new int[] { 9 } };


			Identifier = "ratipriyavRttamu";
			Name = "రతిప్రియ";
			Examples = new string[] { "ఖ్యాతశ్రీ మనజరగంబులుండఁగాఁ ద\nద్గతంబులై జభసజగంబు లొందగా\nవీతాఘప్రముదితవిశ్వభూపా\nధృతిం దలంప నిది రతిప్రియం బగున్" };
		}
	}
	public class SarabhakreeDaa : Rule
	{
		public SarabhakreeDaa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {
										"య,మ,న,స,ర,గ".Split ( ',' ),
										"య,మ,న,స,ర,గ".Split ( ',' ),
										"మ,భ,న,య,య".Split ( ',' ),
										"య,మ,న,స,ర,గ".Split ( ',' ),
									};
			Yati = new int[][] { new int[] { 12 } ,
									new int[] { 9 } ,
									new int[] { 12 } ,
									new int[] { 12 }};

			PadyamSubType = PadyamSubType.VishamaVruttam;
			Identifier = "SarabhakreeDaa";
			Name = "శరభక్రీడా";
			Examples = new string[] { "చతుర్వర్ణాధారా య మ న సరగవ్యాప్తి నాద్య\nద్వితీయాం త్యాంఘ్రిప్రస్తుతగతి నతిస్పష్టమైనన్\nఖ్యాతాసక్తిన్ మ భ న య య తృతీయాంఘ్రినొప్పన్\nబ్రతిప్రేమోత్పత్తిం బరఁగి శరభక్రీడ యయ్యెన్" };
		}
	}
	public class SreeramaNamu : Rule
	{
		public SreeramaNamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {
										"భ,మ,స,గ".Split ( ',' ),
										"భ,భ,భ,గా".Split ( ',' ),
										"భ,భ,భ,గా".Split ( ',' ),
										"భ,భ,భ,గా".Split ( ',' ),
									};
			Yati = new int[][] { new int[] { 6 }, new int[] { 7 }, new int[] { 6 }, new int[] { 7 } };


			Identifier = "SreeramaNamu";
			Name = "శ్రీరమణము";
			Examples = new string[] { "ఆరభమవ్యాయత్తసగవ్యా\nపారము నాదిమ పాదము సెందన్\nజారు భభాగగసంగతిచేతన్\nశ్రీరమణంబని చెప్పిరి మూఁటన్", "ధాత్రి భమంబుల్‌ తత్సగ మాదిన్‌\nభత్రయగాగణపద్ధతి మూఁటన్‌\nగోత్రధరా యిటు గూర్పఁ బదంబుల్‌\nచిత్రగతిం జను శ్రీరమణంబుల్‌." };
		}
	}
	public class upajaati : Rule
	{
		public upajaati()
		{
			Lines = 4;
			Threshold = 3;

			PadyamSubType = PadyamSubType.VishamaVruttam;
			Identifier = "upajaati";
			Name = "ఉపజాతి";
			Examples = new string[] { "పినాకికోదండము బిట్టు ద్రుంచెన్‌\nదానొప్పగెల్చెన్‌ జమదగ్ని సూనున్‌\nఅనంతసత్త్వుం డితఁ డంచు మెచ్చన్‌\nజానైన వృత్తం బుపజాతి యయ్యెన్‌." };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,త,జ,గా".Split ( ',' ) ,
									"త,త,జ,గా".Split ( ',' ) ,
									"జ,త,జ,గా".Split ( ',' ) ,
									"త,త,జ,గా".Split ( ',' ) };

			Yati = new int[][] { new int[] { 8 } };


		}
	}
	public class manOharamu : Rule
	{
		public manOharamu()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "manOharamu";
			Name = "మనోహరము";
			Examples = new string[] { "క్ష్మారాజ రమేశ జతావము లు\nద్ధుర మైనసకారచతుష్కముతోఁ\nగూరంగ సగంబులు గూడి మనో\nహరవృత్తము చెల్వగు నద్రిధరా!" };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త జ జ వ".Split(' '), "స స స స".Split(' '), "త జ జ వ".Split(' '), "స స స స".Split(' ') };
			Yati = new int[][] { new int[] { 8 }, new int[] { 9 }, new int[] { 8 }, new int[] { 9 } };
		}
	}
	public class kOmalavRttamu : Rule
	{
		public kOmalavRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {"న,జ,జ,య".Split(','),
										"జ,భ,స,జ,గ".Split(','),
										"న,జ,జ,య".Split(','),
										"జ,భ,స,జ,గ".Split(',')};
			Yati = new int[][] { new int[] { 8 }, new int[] { 9 }, new int[] { 8 }, new int[] { 9 } };

			Identifier = "kOmalavRttamu";
			Name = "కోమలి";
			Examples = new string[] { "సలలితరీతి నజాయగణంబుల్\nచళుక్యభూప జభసజస్థగస్థితిన్\nమలయుచు నర్థసమర్థతచేత\nన్వెలుంగఁ గోమలి యను వృత్త మొప్పగున్." };
		}
	}
	public class viyOgini : Rule
	{
		public viyOgini()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {    "స-స-జ-గ".Split ( '-' ),
											"స-భ-ర-వ".Split ( '-' ),
											"స-స-జ-గ".Split ( '-' ),
											"స-భ-ర-వ".Split ( '-' ) };
			Yati = new int[][] { new int[] { 6 }, new int[] { 7 }, new int[] { 6 }, new int[] { 7 } };

			Identifier = "viyOgini";
			Name = "వియోగిని";
			Examples = new string[] { "ముద మెక్కడ మ్రోడు నే వనిన్\nనిదురే లేదుగ నే వియోగినిన్\nమధుమాసపు మైక మెప్పుడో\nసుధతో నూతనశోభ లెప్పుడో " };
		}
	}
	public class ajitaprataapamu : Rule
	{
		public ajitaprataapamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {"స,జ,స,స".Split(','),
									"న,భ,జ,భ".Split(','),
									"స,జ,స,స".Split(','),
									"న,భ,జ,భ".Split(',')};
			Yati = new int[][] { new int[] { 9 }, new int[] { 8 }, new int[] { 9 }, new int[] { 8 } };

			Identifier = "ajitaprataapamu";
			Name = "అజిత ప్రతాపము";
			Examples = new string[] { "సజసాగణావలిఁ బ్రసన్న నభా\nగ్రజరపంక్తి నభిరామరూపమై\nయజితప్రతాపచెలువారుఁ గృతి\nన్విజయవిక్రమణ విశ్వభూవరా" };
		}
	}
	public class aMgajaastramu : Rule
	{
		public aMgajaastramu()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "aMgajaastramu";
			Name = "అంగజాస్త్రము";
			Examples = new string[] { "భూరిభమంబుల్‌ పొందు సగం బిం\nపారఁగ నర్థంబై యటసామున్‌\nశౌరీ విన్మసజంబు గాంతమై\nయారూఢం బగు నంగజాస్త్రమున్‌.",
									  "దానబలేంద్రోదారభమంబుల్\nపూనిసగా ప్తిం బొంపిరివోవన్\nజానారన్మసజంబు గస్థితం\nబై నీజంజను నంగజాస్త్ర మై."
									};


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {    "భ మ స గ".Split ( ' ' ),
										"భ మ స గ".Split ( ' ' ),
										"మ స జ గ".Split ( ' ' ),
										"మ స జ గ".Split ( ' ' ) };

			Yati = new int[][] { new int[] { 6 } };
		}
	}
	public class rathagamanamanOharamu : Rule
	{
		public rathagamanamanOharamu()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "rathagamanamanOharamu";
			Name = "రథగమన మనోహరము";
			Examples = new string[] { "రథగమన మనోహరంబు రెండవఘ్రిన్‌\n	ప్రథితం బగున్‌ సజజంబు రప్రయుక్తయంబున్‌\nప్రథమపదమునందుఁ బైసగంబునందున్‌\nగథితననరజంబు గద్వయంబుఁ గృష్ణా!" };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] {
									"న న ర జ గా".Split ( ' ' ),
									"స జ జ ర య".Split ( ' ' ),
									"న న ర జ గా".Split ( ' ' ),
									"న న ర జ గా".Split ( ' ' ),
								};

			Yati = new int[][] { new int[] { 9 }, new int[] { 10 }, new int[] { 9 }, new int[] { 10 } };
		}
	}
	public class veeNaarachanamu : Rule
	{
		public veeNaarachanamu()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "veeNaarachanamu";
			Name = "వీణారచనము";
			Examples = new string[] { "వీణారచనం బయ్యె భువిన్‌ తయసాగల్‌\nబాణప్రహరా తజనభభవ్యగగంబుల్‌\n	చాణూరహరా తజనభస ల్ప్రకటయతిన్‌\nవేణుధర భననభసవిశ్రుత మగుచున్‌." };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] {
								"త య స స గ".Split ( ' ' ),
								"త జ న భ గా".Split ( ' ' ),
								"త జ న న స".Split ( ' ' ),
								"భ న న భ స".Split ( ' ' ),
								};

			Yati = new int[][] { };
		}
	}
	public class naareeplutavRttamu : Rule
	{
		public naareeplutavRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.VishamaVruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {
										"మ,త,త,గా".Split ( ',' ),
										"త,త,జ,గా".Split ( ',' ),
										"మ,త,త,గా".Split ( ',' ),
										"త,త,జ,గా".Split ( ',' ),
									};
			Yati = new int[][] { new int[] { 7 }, new int[] { 8 }, new int[] { 7 }, new int[] { 8 } };
			Examples = new string[] {   "క్షీరోదన్వన్మధ్యగేహా మతాగా\nసారంబు నుద్యత్తతజల్గగంబున్‌\nబూరింపంగాఁ బాదముల్‌ రెంట రెంటన్‌\nనారీప్లుతం బయ్యె ననంతమూర్తీ!",
										"దానోదారశ్రీమతా గానియుక్తిం\nగానంగఁదాజస్థ గగప్రసక్తిన్\nమానై' చాళుక్యక్షమాపాలరమ్య\nస్థానంబునారీప్లుత సంజ్ఞమయ్యెన్" };


			Identifier = "naareeplutavRttamu";
			Name = "నారీప్లుత";

		}
	}
}

/*



ననహతదండకము
అమరగననహంబులందాదిగానొండె... చూడామనీత్యాగవైరోచనా 

సనహత దండకము
కృతినాదిసనహంబులొండేంబ్రకల్పించి యామీఁదనెల్లందకార ప్రధానంబు గుర్వంతమైక్రాల....విశ్వంభరాధీశ్వరా!!

ననత దండకము
జయ గిరిశ సురేశముక్యామరస్తోమమౌళిస్థితస్నిగ్ధచామికరోదగ్రరత్నప్రయుక్తావతంస ప్రభాసంచయాంచత్పదాంభోరుహా...పాపౌఘనాశా నమస్తే నమస్తే నమః  

ననయ దండకము
జయజహరిగజేంద్రాది సద్భక్తరక్షైక దిక్షాభవాంభోధినిర్మగ్న జివాళికిన్నీవకాకెవ్వరుధ్దారకుల్ధేవదేవా నమస్తే నమస్తే  

నత దండకము 
జలధికన్యాకుచాలిప్త కస్తూరిరేఖాసమాలంకృతోరస్క రక్షింపవేదిను నిన్నన్నుదేవేశమత్ప్రాణకోశా నమస్తేనమః 
సత దండకము
గిరిశా కైలాసవాసా ధరాకన్యకాముగ్ధనేత్రాబ్జరాగాంశుమాలీ ననుంజేదుకోవేభవత్పాదసాన్నిధ్యమియగదే దేవదేవా నమస్తే నమస్తే నమస్తే నమః 
రగణ దండకము
దేవదేవేశ నిపాద భక్తుండ మన్నింపవే దీను దుగ్ధాబ్ధి  శాయీ నమస్తే నమస్తే నమః  

నగణదండకము
మధుమధన నను దయగనవెజలధిశయన హరి హరీ

సగణదండకము   
ధరణీతనయా వదనాంబుజ భాస్కరన్ దయజూడగదే రఘువీరా
 హగణదండకము 
దేవదేవనన్ను బ్రోవరావెదుగ్ధ వర్ధికన్యకాముఖాంబుజాత సూర్యనిన్నెగొల్తు నెల్లంవేళలం బ్రభూ నమః

---
నసహతదండకము
అరిది బిరుదా నీవు రాయంచ తేజీవ జీరుండవై 
త గణ దండకము
శ్రీకంఠ లోకేశ లోకోద్భవస్తాన సంహారకారీ పురారీ మురారీ ప్రియా చంద్రధారీ ...నమస్తే నమస్తే నమః  
---
 



upajati
సామస్వర శ్రీనుపజాతివృత్తం
బమేయనాదంచితయౌగికోక్తిన్
సామర్ధ్యశబ్ధార్థరరసప్రవృత్తిన్
బ్రమోదియౌపల్కునురాయిడింపన్ 
 ajita prataana
కపిలోకమంత్రులుసుఖంబెసగన్
విపులపీఠమునబెట్టి యాతనిన్
కపురారతుల్ చెలఁగఁగంజముఖి
సిపరిదిప్తకరశుభ్రకాంతులన్ 
 
 */
/*public class ghana_ninada :Rule
{
public ghana_ninada()
{
Lines = 4;
Threshold = 3;

RuleType = RuleType.Name;
PadyamType = PadyamType.Vruttam;
PadyamSubType = PadyamSubType.VishamaVruttam;
YatiMode = YatiMode.CharPosition;

Prasa = true;
PrasaYati = false;
AnthyaPrasa=false;

Rules = new string[][]{new string[]{"న","న","న","న","జ","న","జ","న","న","న","భ","స",},};
Yati = new int[][]{new int[]{11,20,35,},};

Identifier = "ghana_ninada";
Name = "ఘననినద ";

Examples = new string[]{"అరయఁగ ఘన నినదము నగుఁగృతిన్ ననననలు నాపయి జన జనలు న నభ ల్తగనెసఁగన్\nదొరయుగఁ బదునొకఁడు గదురనిర్వదిరువదితొమ్మిదియుగ నగుచు యతులొప్పఁగ నెపుడున్ ",};
}
}	public class varaaMgi : Rule
	{
		public varaaMgi ()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "varaaMgi";
			Name = "వరాంగి";
			


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] {"జ త జ గా".Split ( ' ' ),
									"జ త జ గా".Split ( ' ' ),
									"త త జ గా".Split ( ' ' ),
									"జ త జ గా".Split ( ' ' ) };
			Yati = new int[][] { new int[] { 8 } };
			Examples = new string[] {  };
		}
	}*/
