//---------------------------------------------------------------------------------------------
// <copyright file="RareRules.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:27EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Rare
{
	public class durmila : Rule
	{
		public durmila()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "స", "స", "స" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "durmila";
			Name = "దుర్మిల (ద్విమిలా)";

			Examples = new string[] { "ధరణీతనయాహృదయేశ్వరబాణనితాంతమహాగ్ని శిఖావలిచే\nవరుణాలయభాగ్బహుజంతుతతిప్రళయాగతయైనగతిం బొలిచెన్\nధరణిం గన నాశ్రయమందినచో దగ నాపదయైన దదాశ్రితులం\nబొరయంగను మానకయుండునొ దుర్భరముల్సిలుగుల్బహులాకృతులై" };
		}
	}
	public class SRMgaara : Rule
	{
		public SRMgaara()
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

			Rules = new string[][] { new string[] { "స", "త", "య", "భ", "న", "న", "న", "య" } };
			Yati = new int[][] { new int[] { 11, 19 } };

			Identifier = "SRMgaara";
			Name = "శృంగార";

			Examples = new string[] { "మృడవిశ్రామంబవలన్ బందొమ్మిదిటను యతి తగి మెఱిసినయంత\nన్గడు శృంగారాఖ్యఁ జెలంగున్ రఙ్గనృపతి సతయభనననయ యుక్తిన్\nమృడవిశ్రామంబవలన్ బందొమ్మిదిటను యతి తగి మెఱిసినయంత\nన్గడు శృంగారాఖ్యఁ జెలంగున్ రజ్గనృపతి సతయభనననయ యుక్తిన్" };
		}
	}
	public class kirITa : Rule
	{
		public kirITa()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "భ", "భ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "kirITa";
			Name = "మేదురదన్తమ్ (కిరీట)";

			Examples = new string[] { "వారిధి యెచ్చట లోతులు లోతులు వారక చొచ్చెడి యమ్ములచేతను\nనేరని మాదిరి లోపల లోపల నిప్పులు పోసెడి యమ్ములచేతను\nదూరిన చోటుల చిక్కని నెత్తురు తూములు కట్టెడు నమ్ములచేతను\nతీరిక నూరక నూపిరి లేవఁగ దీసుకపోయెడు నమ్ములచేతను" };
		}
	}
	public class baMdhura : Rule
	{
		public baMdhura()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "స", "భ", "భ", "భ", "గ" } };
			Yati = new int[][] { new int[] { 16 } };

			Identifier = "baMdhura";
			Name = "బంధుర ";

			Examples = new string[] { "పరిమళభరితవికచ సుమముల శ్రీబంధుర కాంచన దివ్యమణి\nస్ఫిర వలసమున వెలయఁగ భ్రమరసంవీత వినీలవిభాసమునన్\nసిరిమొగమున రతనపునిలుపసలాసేచనకంబుగ శోభిలఁగన్\nహరి మధువ ననివసనమిలగనె నవ్యక్తుగతిన్ బ్రియకామినికై ", };
		}
	}
	public class vijaya : Rule
	{
		public vijaya()
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

			Rules = new string[][] { new string[] { "భ", "స", "భ", "త", "న", "స", "న", "న", "గ" } };
			Yati = new int[][] { new int[] { 12, 19 } };

			Identifier = "vijaya";
			Name = "విజయ";

			Examples = new string[] { "భానులఁ బదియుందొమ్మిదిటం జొప్పడి విరతులు నేర్పడ విజయమగున్\nసైనికయుత రంగాధిప సల్లాణసు భసభతనల్ సననగములతోన్\nభానులఁ బదియుందొమ్మిదిటం జొప్పడి విరతులు నేర్పడ విజయమగున్\nసైనికయుత రంగాధిప సల్లాణసు భసభతనల్ సననగములతోన్" };
		}
	}
	public class suruchi : Rule
	{
		public suruchi()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "స", "త", "న", "న", "య", "గ" } };
			Yati = new int[][] { new int[] { 8, 14, 21 } };

			Identifier = "suruchi";
			Name = "సురుచి";

			Examples = new string[] { "వసుమనువుల నిర్వదియొకటన్ జెల్వై విరమణములు వరలం బాగౌ\nనసమ సురుచి శ్రీహరిసమ రంగేంద్రా ననభసతననయగప్రాప్తిన్\nవసుమనువుల నిర్వదియొకటన్ జెల్వై విరమణములు వరలం బాగౌ\nనసమ సురుచి శ్రీహరిసమ రంగేంద్రా ననభసతననయగప్రాప్తిన్" };
		}
	}
	public class vanaruha : Rule
	{
		public vanaruha()
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

			Rules = new string[][] { new string[] { "మ", "స", "భ", "భ", "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { new int[] { 11, 19 } };

			Identifier = "vanaruha";
			Name = "వనరుహ";

			Examples = new string[] { "రుద్రప్రౌఢినిఁ బందొమ్మిదిటన్ రుజులగు యతులొనరుట వనరుహమై\nభద్రశ్రీయుత రంగాధిపతీ పరగు లిపుల మసభభననననగల్\nరుద్రప్రౌఢినిఁ బందొమ్మిదిటన్ రుజులగు యతులొనరుట వనరుహమై\nభద్రశ్రీయుత రంగాధిపతీ పరగు లిపుల మసభభననననగల్" };
		}
	}
	public class jaladarava : Rule
	{
		public jaladarava()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { new int[] { 8, 15 } };

			Identifier = "jaladarava";
			Name = "ధరణిధరగతి (జలదరవ , అలకా)";

			Examples = new string[] { "చెదరిన తలయు చినిగిన వలువ చెలువము తరిగిన మొగమై\nకదలిన నడుము కదిసిన యురము కలగిన తునిగిన సరమై\nఅదరిన పిఱుఁదు నలసిన పదము నదవదలయి చను కనులై\nబెదరి బెదరియు విరిసి విరిసియు వెడలకు  వెడలకు మగువా", };
		}
	}


	public class prabhu : Rule
	{
		public prabhu()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "జ", "జ", "జ", "జ", "జ", "వ" } };
			Yati = new int[][] { new int[] { 9, 15, 21 } };

			Identifier = "prabhu";
			Name = "ప్రభు";

			Examples = new string[] { "ప్రముదితగజబుతురసవిశ్రమముల్‌రమణం గవివర్యనుతంబునునై\nక్రమమున నననలు రహి నైదు జకారములున్ లగమున్ బ్రభువృత్తమగున్\nప్రముదితగజబుతురసవిశ్రమముల్‌రమణం గవివర్యనుతంబునునై\nక్రమమున నననలు రహి నైదు జకారములున్ లగమున్ బ్రభువృత్తమగున్" };
		}
	}

	public class apavaaha : Rule
	{
		public apavaaha()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "న", "న", "న", "న", "స", "గా" } };
			Yati = new int[][] { new int[] { 10, 16, 22 } };

			Identifier = "apavaaha";
			Name = "అపవాహ";

			Examples = new string[] { "దిక్సీమాంతమిత ధిమిత ధిమిత ధిమిక ధిమిక పటుతరమృదంగోద్యత్\nప్రక్సంరావముల నటన చతురశఫరి శకుని నిచయకృతసాహాయ్యున్ \nప్రాక్సృష్టిన్ వెలుచు జలజభవకృత నుతిభరిత సవనఘటనానేహః\nస్రుక్సందీపిత మహితచరుని హితనుత రుచిరమహి మహాధాయ్యున్", "ఔ బ్రహ్మర్తురనములను యతి మగణ గుహక న సగగ లపవాహాఖ్యన్\nఔ బ్రహ్మర్తురనములను యతి మగణ గుహక న సగగ లపవాహాఖ్యన్\nఔ బ్రహ్మర్తురనములను యతి మగణ గుహక న సగగ లపవాహాఖ్యన్\nఔ బ్రహ్మర్తురనములను యతి మగణ గుహక న సగగ లపవాహాఖ్యన్" };
		}
	}
	public class varaha : Rule
	{
		public varaha()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "న", "న", "న", "న", "స", "గా" } };
			Yati = new int[][] { new int[] { 10, 16 } };

			Identifier = "varaha";
			Name = "వరాహ";

			Examples = new string[] { "దిక్సీమాంతమిత ధిమిత ధిమిత ధిమిక ధిమిక పటుతరమృదంగోద్యత్\nప్రక్సంరావముల నటన చతురశఫరి శకుని నిచయకృతసాహాయ్యున్ \nప్రాక్సృష్టిన్ వెలుచు జలజభవకృత నుతిభరిత సవనఘటనానేహః\nస్రుక్సందీపిత మహితచరుని హితనుత రుచిరమహి మహాధాయ్యున్" };
		}
	}

	public class tanvi : Rule
	{
		public tanvi()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "స", "భ", "భ", "న", "య" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "tanvi";
			Name = "తన్వి";

			Examples = new string[] { "కల్పలతావేల్లితకుసువి లసత్కాంతులు దిక్కుల వెలుగిడు తన్విన్\nకల్పవికల్పంబుల నొకగతి సంకల్పమునన్‌ దమి నెడపెడు ధన్యన్\nవేల్పులు జోహారులగొను స్మితసంప్రీత నుషస్సు నెద గొలుతు భక్తిన్\nమేల్పసముత్తెంపుతెర వెడలి నెమ్మిన్‌ మది తెల్విని నెరఁపగ రాగన్" };
		}
	}
	public class kusuma : Rule
	{
		public kusuma()
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

			Rules = new string[][] { new string[] { "న", "భ", "న", "భ", "న", "న", "న", "వ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "kusuma";
			Name = "కుసుమ";

			Examples = new string[] { "నభనభల్ తగ నగణముల్ వగణయుతమయి చెలువలరినన్\nవిభుఁడు రంగనృపతి త్రయోదశవిరతి వసుమతిఁ గుసుమమౌ\nనభనభల్ తగ నగణముల్ వగణయుతమయి చెలువలరినన్\nవిభుఁడు రంగనృపతి త్రయోదశవిరతి వసుమతిఁ గుసుమమౌ" };
		}
	}
	public class mattaakrIDa : Rule
	{
		public mattaakrIDa()
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

			Rules = new string[][] { new string[] { "మ", "మ", "త", "న", "న", "న", "న", "వ" } };
			Yati = new int[][] { new int[] { 9, 17 } };

			Identifier = "mattaakrIDa";
			Name = "మత్తాక్రీడ";

			Examples = new string[] { "మత్తాక్రీడన్ మాతల్ నానాల్ మఱి వము వసుగజమత యతులమరన్\nమత్తాక్రీడన్ మాతల్ నానాల్ మఱి వము వసుగజమత యతులమరన్\nమత్తాక్రీడన్ మాతల్ నానాల్ మఱి వము వసుగజమత యతులమరన్\nమత్తాక్రీడన్ మాతల్ నానాల్ మఱి వము వసుగజమత యతులమరన్" };
		}
	}
	public class narEMdra : Rule
	{
		public narEMdra()
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

			Rules = new string[][] { new string[] { "భ", "ర", "న", "న", "జ", "జ", "య" } };
			Yati = new int[][] { new int[] { 14 } };

			Identifier = "narEMdra";
			Name = "నరేంద్ర";

			Examples = new string[] { "జాలములై తరంగశిఖరములను సన్ననిరేఖగ ధూమ\nజ్వాలలు లేచి యల్లుకొని నభమున వల్లులు వృక్షములయ్యెన్\nనీలతమాలకాననము నిలువున నింగికి లేచెడునట్టుల్\nహాలహలమ్ము క్రొత్తదిగ జలనిదియం దుదయించినయట్టుల్" };
		}
	}
	public class surabhoojaraaja : Rule
	{
		public surabhoojaraaja()
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

			Rules = new string[][] { new string[] { "న", "భ", "ర", "న", "న", "న", "ర" } };
			Yati = new int[][] { new int[] { 12 } };

			Identifier = "surabhoojaraaja";
			Name = "సురభూజరాజ";

			Examples = new string[] { "రవియతిన్‌ సురభూజరాజము ప్రబలు నభరననారలన్\nతవిలి రంగమహీతలాధిప దళితవిమతనృపాలకా\nరవియతిన్‌ సురభూజరాజము ప్రబలు నభరననారలన్\nతవిలి రంగమహీతలాధిప దళితవిమతనృపాలకా" };
		}
	}
	public class kanakalata : Rule
	{
		public kanakalata()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "స" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "kanakalata";
			Name = "కనకలత";

			Examples = new string[] { "పలుకునఁ గనకలత వెలయఁ బలికెద నవమణిసూ\nనలసితముగ రవిశశికిరణసువిలసనము మహీ\nస్థలినలమ రహి శివశమరసనల దమిల గురియన్\nలలితను గొలువఁగ బదకమలముల కెనయగు పసన్" };
		}
	}
	public class haMsi : Rule
	{
		public haMsi()
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

			Rules = new string[][] { new string[] { "మ", "మ", "త", "న", "న", "న", "స", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "haMsi";
			Name = "హంసి";

			Examples = new string[] { "శాతార్చిర్ధూర్బాంధుర్యంబుల్ జలనిధి జలములు సలసల గ్రాగన్\nపాతాళస్థప్రాణిశ్రేణుల్ పలపల భరమయి యసువుల వ్రేగన్\nయాతాయాతాయాసక్లిష్టాసువులయి యలమట వడిబడి యాదో\nవ్రాతంబెల్లన్ వార్వాసంబుల్ వదలి దివమునకుఁ జన నెగురంగన్" };
		}
	}
	public class vichikilata : Rule
	{
		public vichikilata()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "vichikilata";
			Name = "విచికిలిత (కనకలతిక , అచలవిరతిః)";

			Examples = new string[] { "పొదివి పొదివి నృపుల తలలు పుణికి పుణికి నఱకి స\nమ్మదము ముదము నెడఁదఁ గదుర మలఁగి మలఁగి గురునకున్\nగుదురు కలుగ జలమువదలి కొసఁకు గినుకఁ దొలఁగితిన్\nవదలి ధనువు జగమఖిలము వదలి యెచటొ యరిగితిన్" };
		}
	}

	/*public class malayaja : Rule
	{
		public malayaja ()
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

			Rules = new string[][] { new string[] { "న" , "జ" , "న" , "స" , "న" , "న" , "భ" , "న" , "వ" } };
			Yati = new int[][] { new int[] { 8 , 15 , 22 } };

			Identifier = "malayaja";
			Name = "మలయజ ";
			
			Examples = new string[] { "నలిన విలోచన నజనసనంబులు నభనగణంబులు నటలగమున్ \nమలనగిరిత్రయమహితయతుల్దగిమయలజవృత్తము మహివెలయున్ \nనలిన విలోచన నజనసనంబులు నభనగణంబులు నటలగమున్ \nమలనగిరిత్రయమహితయతుల్దగిమయలజవృత్తము మహివెలయున్ " , };
		}
	}
	public class bhaMbharagaanamu : Rule
	{
		public bhaMbharagaanamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,భ,భ,గ".Split ( ',' ) };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;

			Identifier = "bhaMbharagaanamu";
			Name = "భంభరగానము";
						Examples = new string[] { };
		}
	}
*/
}