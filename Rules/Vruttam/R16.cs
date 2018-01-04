//---------------------------------------------------------------------------------------------
// <copyright file="R16.cs" company="Chandam-ఛందం">
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
	public class priyakaaMta : Rule
	{
		public priyakaaMta()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,య,న,య,స,గ".Split(',') };

			Yati = new int[][] { new int[] { 11 } };


			Identifier = "priyakaaMta";
			Name = "ప్రియకాంత(కాంత)";
			Examples = new string[] {
									"ద్విపదములం గాన తిరిగితిన్ గాదె హరీ యీ\nవిపినము నందెల్ల వెదకి పిల్చేను సదా నా\nజప మిట నీ పేరె చలము చాలించు హితానన్\nకృప సుధ చల్లేవ హృదియు తృళ్ళేను ముదానన్",
									"అవనియు శ్రీయున్సతు లజుఁడాత్మోద్భవుఁ డాప్తుల్‌\nదివిజులు దామోదరునకు దేవళ్ళిఁ కనేరీ\nసవతు గ నాఁగా నయనయసమ్యక్సగయుక్తిన్‌\nగవినుతమై దిగ్యతిఁ బ్రియకాంతాకృతి యొప్పున్‌."
									};
		}
	}
	public class paMchaamaramu : Rule
	{
		public paMchaamaramu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "paMchaamaramu";
			Name = "పంచచామరము (నారాచ , మహోత్సవ)";

			Examples = new string[] {   "ఇ టా చతుర్ముఖుం డరాగఁ నిష్ట శిష్టపాళితోఁ\nదటాలునన్మునిప్రభుండు తద్ద భక్తియుక్తిమై\nనిటాలమందుఁ గేలుదోయి నిల్చి మ్రొక్కి నిల్చితా\nని టేటికో  ననుం గనంగ  నేగుదెంచె ధాతయున్",
										"త్వరాస దృగ్విధీయమాన దానతోయ శోషితాం\nబురాశి వర్ధనాతి కృత్ప్రభూత కీర్తి మండల\nస్ఫురత్సుధా మయూఖ వైరి భూమి భృచ్చిరోల్లస\nత్కిరీట రత్న రాజితకాంతి దీపితాంఘ్రి పంకజా",
										"జరేఫలున్‌ జరేఫలున్‌ జసంయుతంబులై తగన్‌\nగురూపరిస్థితిం బొసంగి గుంఫనం బెలర్పఁగా\nవిరించిసంఖ్య నందమైన విశ్రమంబులం దగున్‌\nబ్రరూఢమైనఁ బద్మనాభ పంచచామరం బగున్‌.",
										"మరుత్ర్పరోహలోలతల్ప మధ్యసంస్థలాశ్రయా\nధరారమాకరోపలాలితప్రసారితాంఘ్రికా\nమరుద్వృధాకధానుబంధమంథరోత్సవానక\nస్ఫురద్విరావనర్తితోప భూవనీశిఖావళా"
									};


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Rules = new string[][] { "జ ర జ ర జ గ".Split(' ') };
			Yati = new int[][] { new int[] { 10 } };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class padmakamu : Rule
	{
		public padmakamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,భ,జ,జ,జ,గ".Split(',') };
			Yati = new int[][] { new int[] { 11 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "padmakamu";
			Name = "పద్మకము-1 (పద్మ)";
			Examples = new string[] { "నకలితంబు నభజాజగణంబులు గాంతమై\nసకలదిగ్విరమణంబులు సన్నుతమై చనన్‌\nశకటదైత్యమదభంజను సన్నుతిసేయఁగాఁ\nబ్రకటమై కృతులఁ బద్మము పద్మకుఁ బట్టగున్‌." };
		}
	}
	public class padmakamu2 : Rule
	{
		public padmakamu2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,భ,జ,జ,జ,గ".Split(',') };
			Yati = new int[][] { new int[] { 8 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "padmakamu2";
			Name = "పద్మకము-2 (పద్మ)";
			Examples = new string[] {
										"కొడుకుపల్కువినికూడదునాక దురాత్ముడై\nకడఁగ మీకు నపకారము సేసిధరిత్రి వె\nల్వడఁగ బంచెఁగడుఁ బాపమతిన్ దృతరాష్ట్రుఁడె\nయ్యెడల దుర్జనుల నేమఱి నమ్మఁగఁబీలునే"
									};
		}
	}
	public class chaMdraSree : Rule
	{
		public chaMdraSree()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "య,మ,న,స,ర,గ".Split(',') };
			Yati = new int[][] { new int[] { 12 } };

			Identifier = "chaMdraSree";
			Name = "చంద్రశ్రీ (ప్రవరలలితమ్)";
			Examples = new string[] { "జగన్నాథున్‌ లక్ష్మీహృదయజలజప్రోద్యదర్కున్‌\nఖగాధీశారూఢున్‌ సుకవిజనకల్పద్రుమంబున్‌\nదగన్వర్ణింపంగా యమనసయుతంబై రగంబుల్‌\nమొగిం జంద్రశ్రీకిన్నిలుచు యతి ముక్కంటినొందున్‌." };
		}
	}
	public class lalitagati : Rule
	{
		public lalitagati()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "జ", "స" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "lalitagati";
			Name = "లలితగతి";

			Examples = new string[] { "నలినిఁ బదునొకటి యతి నానజసలున్\nలలితగతి కలరు నిల రంగనృపతీ\nనలినిఁ బదునొకటి యతి నానజసలున్\nలలితగతి కలరు నిల  రంగనృపతీ" };
		}
	}
	public class gajaraaja : Rule
	{
		public gajaraaja()
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

			Rules = new string[][] { new string[] { "స", "జ", "భ", "భ", "స" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "gajaraaja";
			Name = "గజరాజ";
			Examples = new string[] { "సజభాస లష్టవిశ్రమరీతిఁ దనరినన్\nగజరాజమౌను రంగనృపాల వసుమతిన్\nసజభాస లష్టవిశ్రమరీతిఁ దనరినన్\nగజరాజమౌను రంగనృపాల వసుమతిన్" };
		}
	}
	public class gajavilasita : Rule
	{
		public gajavilasita()
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

			Rules = new string[][] { new string[] { "భ", "ర", "న", "న", "న", "గ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "gajavilasita";
			Name = "గజవిలసిత (ఋషభగజవిలసితమ్)";

			Examples = new string[] { "చీకటువివ్వికావు జిలుగు తళుకు జిగి దం\nతా కృతి కానరాద యసలు నలుపుటిటికుల్\nగాక నగాళి కావు కదలవు మొదలవు ముం\nదీ కరిరాజిలేద యిటగునగున కదుపన్" };
		}
	}
	public class phalasadanamu : Rule
	{
		public phalasadanamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,న,న,స,గ".Split(',') };
			Yati = new int[][] { new int[] { 10 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "phalasadanamu";
			Name = "ఫలసదనము (శిశుభరణమ్)";
			Examples = new string[] {"అనల మిటుల పురము నలమి యఱుమంగా\nదనుజ సమితిచెడి సదనము  లఱవంగా\nదనుజపతికి నెడద తలరి చెదరంగా\nమనసు వివశమగుచు మఱల గరువంబై",
										"ననలును ననలును దనరఁగ సగయుక్తిన్‌\nవనరుహ భవయతు లవహిత మతితోడన్‌\nనినుపుచు సుకవులు మణివిలసదురస్కున్‌\nగొనకొని పొగడఁగ నగు ఫలసదనంబుల్‌." };
		}
	}
	public class aSvagati : Rule
	{
		public aSvagati()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "గ" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "aSvagati";
			Name = "అశ్వగతి (ఖగతిః , అశ్వాక్రాంత , పద్మముఖీ , సంగత)";
			Examples = new string[] { "ఐదు భకారములుం గమునై తగు నశ్వగతిన్\nఐదు భకారములుం గమునై తగు నశ్వగతిన్\nఐదు భకారములుం గమునై తగు నశ్వగతిన్\nఐదు భకారములుం గమునై తగు నశ్వగతిన్" };
		}
	}
	public class maedini : Rule
	{
		public maedini()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,జ,భ,జ,ర,గ".Split(',') };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "maedini";
			Name = "మేదిని (వాణి , వాణినీ)";
			Examples = new string[] {
										"విను మిటులేటికిం జనిన వృత్తమూది యల్గన్\nజనము నుతించు నీదు గురుసారధీరబుద్ధిన్\nనిను నతిశాంతచిత్తయని నిక్క మేను గందున్\nమనమున నిట్టినీకగునె మత్సరంబు వత్సా.",
										"నగణముతో జకారభగణంబులున్ జకార\nప్రగుణిత రేఫయున్‌ గురువుభాతిఁగాగ నోలిన్‌\nదగ నవతార విశ్రమము దండిగా నొనర్పన్‌\nమృగమదవర్ణుఁ డీయకొను మేదినీ సమాఖ్యన్‌."
									};
		}
	}
	public class madanadarpaNa : Rule
	{
		public madanadarpaNa()
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

			Rules = new string[][] { new string[] { "భ", "స", "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "madanadarpaNa";
			Name = "మదనదర్పణ (మదనదర్ప)";

			Examples = new string[] { "శ్రీభసజరజల్ గయుక్తిఁ జెందివచ్చినం గుమా\nరాభ మదనదర్పమయ్యె నబ్జభూవిరామమై\nశ్రీభసజరజల్ గయుక్తిఁ జెందివచ్చినం గుమా\nరాభ మదనదర్పమయ్యె నబ్జభూవిరామమై" };
		}
	}
	public class chaMdrabhaanu : Rule
	{
		public chaMdrabhaanu()
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

			Rules = new string[][] { new string[] { "న", "ర", "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { new int[] { 10 } };


			Identifier = "chaMdrabhaanu";
			Name = "చంద్రభాను";
			Examples = new string[] { "నరజరల్ జగల్ గదించినం దిశావిరామమై\nయరయఁ జంద్రభానువృత్తమౌను రంగభూవరా!\nనరజరల్ జగల్ గదించినం దిశావిరామమై\nయరయఁ జంద్రభానువృత్తమౌను రంగభూవరా!" };
		}
	}
}
