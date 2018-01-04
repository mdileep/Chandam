//---------------------------------------------------------------------------------------------
// <copyright file="R15.cs" company="Chandam-ఛందం">
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

	public class kalahaMsi : Rule
	{
		public kalahaMsi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "త,య,స,భ,గ".Split(',') };
			Yati = new int[][] { };

			Identifier = "kalahaMsi";
			Name = "కలహంసి";
			Examples = new string[] { };
		}
	}
	public class sugaMdhi : Rule
	{
		public sugaMdhi()
		{
			Lines = 4;
			Threshold = 3;




			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "ర జ ర జ ర".Split(' ') };
			Yati = new int[][] { new int[] { 9 } };

			Prasa = true;
			PrasaYati = false;

			Identifier = "sugaMdhi";
			Name = "సుగంధి (ఉత్సవ , ఉత్సాహ , చామర , తూణక , మహోత్సవ , శాలిని-2 , ప్రశాంతి)";

			Examples = new string[] {"నిన్ను వేఁడువార మయ్య నీరజాక్ష! మమ్ము నా\nపన్నులం బ్రపన్నులం బ్రపంచమున్ దయామతిం\nజెన్నుమీరఁ గావవే, ప్రసిద్ధుఁ డిద్ధకీర్తిసం\nపన్నుఁడున్ వదాన్యుఁడుం దపస్వితుల్యతేజుఁడున్",
									"ఇట్టు లామునీంద్రుఁ  డాడి యీయ నన్న థేనువున్\nబట్టి  కట్టి  కొంచుఁ  బోవ బార్థివుండు  బల్మి మైఁ\nదొట్టఁ గన్  దురంతచింత  దుఃఖితాత్మ యౌచు న\nన్నిట్టు  వాయఁగా  మునీంద్రుఁ డేమి  తప్పు చేసితిన్",
									"ఓరి నీదుమాయరూపమున్నదున్నయట్లుగాఁ\nగోరిపట్టుకోఁదలంపఁగూడిరావు దుర్మతీ\nయౌర చావుమంచు స్వామి యగ్ని బాణసంధిగా\nనూరితాటకేయుమేన నొల్కొనన్విదిర్చినన్",
									"పుంతవింతలన్కనంగభూప్రదక్షిణశ్రమల్\nసుంతసేదదీర్చుకొండుచూడరండుమాగృహం\nఅంతపెద్దవిందులేవిఅందబోరుమీరిటన్\nఅంతరంగమందుపూర్తిఆదరాభిమానముల్\nసంతరించుకొంచుతేటచల్లబువ్వపచ్చడిన్\nయింతజేర్చికుడ్వబెట్టయేమిలోటులేదులే\nశాంతదాయకమ్ములైనసాధువర్తనమ్ములన్\nస్వాంతమందుసంతసింపశాయజేయమేమిమున్ ~ శ్రీ సూర్యనారాయణ సరిపల్లి గారిచే విరచితం.",
									};
		}
	}
	public class sukaesaramu : Rule
	{
		public sukaesaramu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "sukaesaramu";
			Name = "సుకేసరము (ప్రభద్రక , భద్రక-2)";

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,జ,భ,జ,ర".Split(',') };
			Yati = new int[][] { new int[] { 11 } };

			Examples = new string[] {   "ననలు చివుళ్ళు వహ్నిపరిణామమూర్తులై\nయనలము లంటుకొన్నఁ దమవైన యాకృతుల్\nకొనకొని మారెగాని మఱికోలుపోవు నై\nజనిభృతమైన వన్నియల జాలి తోటలన్",
										"యతియవతారసంఖ్య నిడి యాదరంబుతో\nనతిశయమై నజంబులు భజాంతరేఫలున్‌\nవితతముగా నొనర్చి యరవిందలోచనున్‌\nక్షితిధరు సంస్తుతించిన సుకేసరంబగున్‌." };

		}
	}
	public class maalini : Rule
	{
		public maalini()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "maalini";
			Name = "మాలిని (నాందీముఖీ)";
			Examples = new string[] {
										"సకల నిగమవేద్యున్‌ సంసృతివ్యాధివైద్యున్‌\nమకుటవిమలమూర్తిన్‌ మాలినీవృత్త పూర్తిన్‌\nనకలితసమయోక్తిన్నాగవిశ్రాంతియుక్తిన్‌\nసుకవులు వివరింపన్‌ సొంపగున్విస్తరింపన్‌.",
										"సరససురవధూలాస్యంబులున్ సిద్ధవిద్యా\nధరపటుపటహాతోద్యంబులున్ గిన్నరీకం\nపురుషలలితగీతంబుల్ మహారమ్యమయ్యెన్\nవరమునుదివిజాళీర్వాదనాదంబుతోడన్"
									};




			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "న న మ య య".Split(' ') };
			Yati = new int[][] { new int[] { 9 } };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class manOj_namu : Rule
	{
		public manOj_namu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,జ,భ,ర".Split(',') };

			Yati = new int[][] { new int[] { 10 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "manOj_namu";
			Name = "మనోజ్ఞము";
			Examples = new string[] {
										"విమలమనోజ్ఞగుణప్రవృత్తినిఁదెల్పు వా\nక్సుమ మెదచాటున నూగు చొక్కపుఁ బూవుఁగా\nస్వమనితవస్తువిభూతి పైకొన హృల్లతా\nప్రమితినిఁ జాటు సుగంధ భావసమజ్ఞలన్",
										"అజశివశక్రనిరంతరార్చితపద్ద్వయున్‌\nభుజగకులాధిపతల్పుఁ బూని నుతింపఁగా\nనజయతి నొండి నజాభరార్చిత మైచనున్‌\nఋజు వగు నుర్వి మనోజ్ఞ ఋష్యనురాగమై."
									};
		}
	}
	public class maNibhooshaNamu : Rule
	{
		public maNibhooshaNamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,న,భ,భ,ర".Split(',') };

			Yati = new int[][] { new int[] { 10 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "maNibhooshaNamu";
			Name = "మణిభూషణము (మణిభూషణశ్రీ , నూతనమ్ , రమణీయక , సుందర , ఉత్సర)";
			Examples = new string[] {
									"రామవిక్రముఁడ జేయుఁడ రాతిగజావళీ\nసామజాహితుఁడు సాంబుడు సాల్వచమూపతీ\nక్షేమవృధ్ధియనువాని న కృత్రిమ సాహసో\nద్ధాము దాకె శరధారలధారుణిఁగప్పుచున్",
									"హస్తిరాజభయనిర్హర యండజవాహనా\nధ్వస్తసంసరణ యంచుఁ బితామహవిశ్రమ\nప్రస్తుతంబుగ రనంబుల భారగణంబులన్‌\nవిస్తరింప మణిభూషణ వృత్తము చెల్వగున్‌."
									};
		}
	}
	public class maNigaNanikaramu : Rule
	{
		public maNigaNanikaramu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,న,న,స".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "maNigaNanikaramu";
			Name = "మణిగణనికరము (శశికళ)";
			Examples = new string[] {
										"గొడుగులు పఱియలు గుఱుకులు గొనుటన్\nసిడముల తునుయలు సెదరి యునికిఁ బెం\nదడిగలుఁ బడగలు దఱ్చు ముఱియలై\nపుడమిఁ గలయుటకుఁ బొగులొలయ మదిన్",
										"కనకపు వలువలుఁ గరకటకములున్‌\nనునుపగు తుఱుమును నొసలితిలకమున్‌\nదనరెడు హరిఁ గని తగననననసల్‌\nనినిచిన మణిగణనికర మిభయతిన్‌."
									};
		}
	}
	public class nalini : Rule
	{
		public nalini()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "nalini";
			Name = "నలిని (భ్రమరావలికా , నలినీ , భ్రమరావళి)";

			Examples = new string[] { "నలినీవిమలాశయమానసమొప్పునవో\nత్పలసుందరభావసముద్గతసుస్మితమం\nజులసత్త్వమునంబ్రకృతిన్ శుభదర్పణమ\nట్లలరారుపరాత్పరు వ్యాయతసృష్టిగనన్" };
		}
	}
	public class chaMdrarEkha : Rule
	{
		public chaMdrarEkha()
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

			Rules = new string[][] { new string[] { "మ", "ర", "మ", "య", "య" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "chaMdrarEkha";
			Name = "చంద్రరేఖ";
			Examples = new string[] { "ఇంద్రాణిన్ జంద్రరేఖావృత్తాచ్ఛధీకౌముదీ శ్రీ\nసాంద్రస్మేరాభిరామన్ శశ్వత్సుధావర్షిణిన్ నీ\nలేంద్రప్రామాణ్యనీరంద్రేభ్యన్ శ్రుతిజ్ఞేయనాద్యన్\nమంద్రస్తోత్రప్రసక్తిన్ మాన్యప్రపత్తిన్ భజింతున్" };
		}
	}
	public class ila : Rule
	{
		public ila()
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

			Rules = new string[][] { new string[] { "స", "జ", "న", "న", "స" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "ila";
			Name = "ఇల";
			Examples = new string[] { "వసనంబులూడఁగఁ బడఁతి గమి పఱవన్\nపసమీరు తత్కుచభరము రుచికనుచే\nయ సురుల్ మహాగ్నికి నఱ తగులఁబడియున్\nగొసరైన చూపులఁ గుసులుకొని గనఁగన్" };
		}
	}
	public class ila2 : Rule
	{
		public ila2()
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

			Rules = new string[][] { new string[] { "స", "జ", "న", "న", "స" } };
			Yati = new int[][] { new int[] { 5, 8 } };

			Identifier = "ila2";
			Name = "ఇల2 ";
			Examples = new string[] { "వసనంబులూడఁగఁ బడఁతి గమి పఱవన్\nపసమీరు తత్కుచభరము రుచికనుచే\nయ సురుల్ మహాగ్నికి నఱ తగులఁబడియున్\nగొసరైన చూపులఁ గుసులుకొని గనఁగన్" };
		}
	}
	public class alasagati : Rule
	{
		public alasagati()
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

			Rules = new string[][] { new string[] { "న", "స", "న", "భ", "య" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "alasagati";
			Name = "అలసగతి ";
			Examples = new string[] { "తమగృహములున్ మఱియు దగ్ధమగుచుండన్\nగుమతులయి రక్కసులు కొందఱు దురాశా\nభ్రములు తగలంబడు పరావసధచౌర్య\nక్రమము నెఱపన్ దహనకాండము దహింపన్" };
		}
	}
}
