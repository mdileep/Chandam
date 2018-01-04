//---------------------------------------------------------------------------------------------
// <copyright file="R13.cs" company="Chandam-ఛందం">
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
	public class iMduvadana : Rule
	{
		public iMduvadana()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,జ,స,న,గ".Split(',') };
			Yati = new int[][] { };

			Identifier = "iMduvadana";
			Name = "ఇందువదన";
			Examples = new string[] { };
		}
	}
	public class mOhapralaapamu : Rule
	{
		public mOhapralaapamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,భ,త,ర,గ".Split(',') };

			Yati = new int[][] { new int[] { 5 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "mOhapralaapamu";
			Name = "మోహ ప్రలాపము";
			Examples = new string[] { };
		}
	}
	public class rati : Rule
	{
		public rati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,భ,న,స,గ".Split(',') };

			Yati = new int[][] { new int[] { 5 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "rati";
			Name = "రతి";
			Examples = new string[] { };
		}
	}
	public class maMjubhaashiNi : Rule
	{
		public maMjubhaashiNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,జ,న,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };


			Identifier = "maMjubhaashiNi";
			Name = "మంజుభాషిణి";
			Examples = new string[] { "దివిజేంద్రుఁ డాదియగు దేవసంఘముల్‌\nభువి మంజుభాషిణికి భోగిరాడ్యతిన్‌\nసవరింపఁగా సజసజంబు గాంతమై\nభువనోదరస్తుతి యపూర్వ మై చనున్‌."
									};
		}
	}
	public class gauri : Rule
	{
		public gauri()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,న,స,గ".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "gauri";
			Name = "గౌరి";
			Examples = new string[] { };
		}
	}
	public class chaMdralaekha : Rule
	{
		public chaMdralaekha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,స,ర,ర,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "chaMdralaekha";
			Name = "చంద్రలేఖ";
			Examples = new string[] { };
		}
	}
	public class balabhinmaNi : Rule
	{
		public balabhinmaNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,స,న,న,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };


			Identifier = "balabhinmaNi";
			Name = "బలభిన్మణి (అర్ధకుసుమితా)";
			Examples = new string[] { };
		}
	}
	public class kuTajagati : Rule
	{
		public kuTajagati()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,మ,త,గ".Split(',') };
			Yati = new int[][] { };
			Identifier = "kuTajagati";
			Name = "కుటజగతి(కుటగతి)";
			Examples = new string[] { };
		}
	}
	public class sumaMgali1 : Rule
	{
		public sumaMgali1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			//


			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "స", "జ", "స", "స", "గ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "sumaMgali1";
			Name = "సుమంగలి-1 (కలహంసః)";
			Examples = new string[] { "శుభదాయకంభగు సుమంగలి నెన్నన్\nవిభవోత్కరంబగు పృథూత్సవకల్యా\nణభృశాత్మయౌ లలనగా వరగౌరీ\nనిభపూజనీయగ నివాళులఁగొల్వన్" };
		}
	}
	public class ruchiramu : Rule
	{
		public ruchiramu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,భ,స,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "ruchiramu";
			Name = "రుచిరము (కలావతీ , అతిరుచిరా , సదాగతి)";
			Examples = new string[] { "అనంగకోటివిలసదంగవైభవున్‌\nమనంబులో నిలిపిన మాను నాపదల్‌\nఅనన్‌ జభంబులు సజగానుసంగతిన్‌\nదనర్చు నీరుచిరకు దంతిరాడ్యతిన్‌."
									};
		}
	}
	public class mattahaMsini : Rule
	{
		public mattahaMsini()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,త,స,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "mattahaMsini";
			Name = "మత్తహంసిని (మత్తహాసిని)";
			Examples = new string[] { "మనోహరాకార మధుదైత్యసంహరా\nవినాయకారూఢ విబుధేంద్రవందితా\nజనార్దనా జత్సజగురుల్ కుభృద్యతిన్\nదనర్చు పద్యంబు దగు మత్తహంసినిన్." };
		}
	}

	public class mattamayooramu : Rule
	{
		public mattamayooramu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,త,య,స,గ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "mattamayooramu";
			Name = "మత్తమయూరము (మాయా)";
			Examples = new string[] {
										"భోజాధీశుం డంచుఁ బ్రభూతాత్మకుఁ డంచున్‌\nభ్రాజిష్ణుం డంచున్‌ యతి బాగౌ గిరి సంజ్ఞన్‌\nఓజస్స్ఫీతంబై మతయోపేత సగంబుల్‌\nఓజం బల్కన్మత్తమయూరం బలరారున్‌.",
										"నానాభూషామంజుల నారీచయమంతన్\nరానుంబోనున్ నూపుర రావంబులు కాంచీ\nస్థానాలోలత్కింకిణి సంరావముగాగన్\nగానంగానైనంగని కన్నుల్ చలితంబై"
									};
		}
	}
	public class kanakaprabha : Rule
	{
		public kanakaprabha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "స-జ-స-జ-గ".Split('-') };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "kanakaprabha";
			Name = "కనకప్రభ (మంజుభాషిణి , జయా , నందినీ , ప్రబోధితా , మనోవతీ , విలంబితా , సునందినీ , సుమంగలీ)";
			Examples = new string[] {   "ధనమంతయుం బొలియ దారణంబుగా\nదనయ వ్రజంబుదెగ దైన్యమారఁగాఁ\nదనబంధులందఱు మృతంబుఁ బొంద నె\nవ్వనినైన శోకమను వహ్నిగాల్పదే",
										"కన నేడు నిండె కనకప్రభా ద్యుతుల్\nవనభూమి రంగుల తివాసి యయ్యెనే\nతనరారె కన్నెదుట తామ్రపర్వతం\nబనిశమ్ము ఖేచరము లాకసమ్ములో" };
		}
	}
	public class praharshiNi : Rule
	{
		public praharshiNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,న,జ,ర,గ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "praharshiNi";
			Name = "ప్రహర్షిణి (మయూరపిచ్ఛ)";
			Examples = new string[] {
										"ముక్తిశ్రీకరు భవమోచనున్మురారిన్‌\nభక్తిం బ్రోడజనులు ప్రస్తుతింప నొప్పున్‌\nవ్యక్తగ్రావయతిఁ బ్రహర్షిణి సమాఖ్యన్‌\nయుక్తంబై మనజరగోజ్జ్వలద్గణాప్తిన్‌."
									};
		}
	}
	public class prabhaatamu2 : Rule
	{
		public prabhaatamu2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,జ,ర,గ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "prabhaatamu2";
			Name = "ప్రభాతము-2 (మృగేంద్రముఖ , సువక్త్రా , అచల)";
			Examples = new string[] {
										"తొలువెలుఁగయ్యెని దోయి యోయియోకో\nసలసుతసుప్రజ సాధు రామచంద్రా \nతొలొవెలుఁగయ్యెని దోయి కౌసలేయా\nమెలకువ వచ్చెనె మీకు రామభద్రా ",
										"సరసిజనాభ భుజంగ రాజతల్పా\nశరణము నీవని సన్మతిం దలంపన్‌\nబెరయు నజారలు పేర్మి నొప్పగున్‌ గన్‌\nజరగుఁ బ్రభాతము శైల విశ్రమంబున్‌."
									};
		}
	}
	public class chaMchareekaavaLi : Rule
	{
		public chaMchareekaavaLi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,మ,ర,ర,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "chaMchareekaavaLi";
			Name = "చంచరీకావళి-1 (చంచరీకాతతి)";
			Examples = new string[] {   "జ్వాలాలీఢంబౌచున్ బానశాలల్సెలంగన్\nహేలంబానీయంబై యేపుమీ ఱెన్మహాగ్నుల్\nక్రాలుంగత్తుల్ నిప్పుల్ గౌణమౌవృత్తిమున్నై\nయేలెన్ వాచ్యత్వంబే యిప్పుడీ కల్లుబానన్",
										"కంబుగ్రీవా సత్యాకామినీప్రాణనాథా\nబింబోష్ఠామారాగల్పేర్చి భూభృద్యతుల్గాం\nచం బాదంబై ధాత్రిం జంచరీకావళీనా\nమంబొందుం గావ్యశ్రీమానినీభూషణంబై." };
		}
	}
	public class jaladamu : Rule
	{
		public jaladamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,ర,న,భ,గ".Split(',') };

			Yati = new int[][] { new int[] { 10 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "jaladamu";
			Name = "జలదము (లవలీలతా)";
			Examples = new string[] {
										"నీపలుకెల్ల నిక్కమయ నింద్యగుణా\nయీపురుషార్ధహానిసుతులీల్గుంటకుం\nదాపముఁ బొంది తాల్మిఁదిగ ద్రావి మహా\nకోపుఁడనైనఁబాటిలెఁదగుంగినియన్",
										"మ్రొక్కుల కెల్ల నెల్ల యగుమూర్తి గదా\nయక్కమలాక్షుఁ డంచుఁ జతురాస్యయతిన్‌\nదక్కక ప్రస్తుతింప జలదం బగు ని\nట్లొక్కటియై భరేఫనభ లొందు గురున్‌."
									};
		}
	}
	public class kshama : Rule
	{
		public kshama()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,త,త,గ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "kshama";
			Name = "క్షమ(క్షప , చంద్రిక-2)";
			Examples = new string[] {   "ఇతఁడు శతసహస్రేడితానీకినీ\nపతి సురపతిసాపత్యభోగుండునున్\nశతవలి యనఁగా శౌర్యనారాయణుం\nడితఁడు హరిచమూహీర మార్యోత్తమా",
										"క్షమ నిహపరముల్‌- సాధ్యమౌ నాత్మతే\n  జమతి వితతమై- జన్మ లక్ష్యాప్తికై\nసమయముఁ గనఁగన్‌- స్వస్వజీవక్షపా\n  సముదయ మెడలున్‌, స్వర్గ మొప్పన్‌ మదిన్‌" };
		}
	}
	public class chaMcharIkaavali2 : Rule
	{
		public chaMcharIkaavali2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			//


			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "య", "మ", "ర", "ర", "గ" } };
			Yati = new int[][] { new int[] { 6 } };

			Identifier = "chaMcharIkaavali2";
			Name = "చంచరీకావళి-2";
			Examples = new string[] { "యమల్రాగల్పొల్పౌ చంచరీకావళింపై\nయమల్రాగల్పొల్పౌ చంచరీకావళింపై\nయమల్రాగల్పొల్పౌ చంచరీకావళింపై\nయమల్రాగల్పొల్పౌ చంచరీకావళింపై" };
		}
	}
	public class bhaMbaragaana : Rule
	{
		public bhaMbaragaana()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "భ", "గ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "bhaMbaragaana";
			Name = "భంభరగానము";
			Examples = new string[] { "ప్రజిత వినుత బంభరగానమగున్\nగజయతి ననభాగల రంగనృపా!!\nప్రజిత వినుత బంభరగానమగున్\nగజయతి ననభాగల రంగనృపా!!" };
		}
	}
	public class lata : Rule
	{
		public lata()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,య,న,న,గ".Split(',') };

			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "lata";
			Name = "లత (మదనజవనికా)";
			Examples = new string[] { "సతవడి రంగేశ్వర నయననగో\nన్నతిని లతావృత్తము చెలువమరున్\nసతవడి రంగేశ్వర నయననగో\nన్నతిని లతావృత్తము చెలువమరున్" };
		}
	}

	public class navanaMdini : Rule
	{
		public navanaMdini()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "స,జ,స,న,గా".Split(',') };

			Yati = new int[][] { new int[] { 9 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "navanaMdini";
			Name = "నవనందిని";
			Examples = new string[] {   "నవనందినిన్ సజగణస్నగగలాయెన్\nనవవిశ్రమంబును దనర్చి చెలువొప్పన్\nనవనీతచోరకు జనార్దను నుపేంద్రున్\nభవదూరు నెంతురు సభాసదులు భక్తిన్.",
									"కనుమూసికన్దె ఱచులోఁగడువశిష్ఠుం\nడనె భీతిలేదు పదఁడాయనుచు గాధే\nయుని నీవులేవుకుటిలాయుదరుపాటా\nమునిపల్లెమంటనిడెదోములుచ యంచున్"
								};
		}
	}
}


namespace Chandam.Rules.Rare
{
	public class gOvRsha : Rule
	{
		public gOvRsha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ,త,య,స,గా".Split(',') };

			Yati = new int[][] { new int[] { 5 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "gOvRsha";
			Name = "గోవృష";
			Examples = new string[] { };
		}
	}


}


/*
public class mattamayooramu2 : Rule
	{
		public mattamayooramu2 ()
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

			Identifier = "mattamayooramu2";
			Name = "మత్తమయూరము-2";
						Examples = new string[] { "భోజాధీశుం డంచుఁ బ్రభూతాత్మకుఁ డంచున్‌\nభ్రాజిష్ణుం డంచున్‌ యతి బాగౌ గిరి సంజ్ఞన్‌\nఓజస్స్ఫీతంబై మతయో పేతసగంబుల్‌\nఓజం బల్క న్మత్తమయూరం బలరారున్‌." };
		}
	}
 public class chaMchareekaatati : Rule
	{
		public chaMchareekaatati ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "య,మ,ర,ర,గ".Split ( ',' ) };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;

			Identifier = "chaMchareekaatati";
			Name = "చంచరీకాతతి";
						Examples = new string[] { };
		}
	}*/
