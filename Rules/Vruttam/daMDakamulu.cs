//---------------------------------------------------------------------------------------------
// <copyright file="daMDakamulu.cs" company="Chandam-ఛందం">
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
	public class chaMDavRshTiprayaata : Rule
	{
		public chaMDavRshTiprayaata()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "chaMDavRshTiprayaata";
			Name = "చండవృష్టిప్రయాత";

			Examples = new string[] { "నగణయుగము మీదటందేడు రేఫల్ దగన్ జండవృష్టాఖ్యతో దండకంబౌహరీ ", };
		}
	}
	public class arNa : Rule
	{
		public arNa()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "arNa";
			Name = "అర్ణ";

			Examples = new string[] { "నయుగముపయి రాష్టకంబైనచో నర్ణమన్ దండకంబొప్పునోయంజనాకంజనేత్రాత్మజా", };
		}
	}
	public class arNava : Rule
	{
		public arNava()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "arNava";
			Name = "అర్ణవ(అర్హవ)";

			Examples = new string[] { "మొదట ననలమీఁదటం దొమ్మిదేరేఫలుంపంగనౌదండకం బర్ణవం బండ్రు శ్రీరామభక్తాగ్రణీ ", };
		}
	}
	public class vyaaLa : Rule
	{
		public vyaaLa()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "vyaaLa";
			Name = "వ్యాళ";

			Examples = new string[] { "ఋతులఘువులు పైని రేఫల్ పదిన్నిల్పగా వ్యాళనామంబుతోఁ దండకంబౌనయా జంబుమాలిద్రుధూమధ్యజా ", };
		}
	}
	public class jeemoota : Rule
	{
		public jeemoota()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "jeemoota";
			Name = "జీమూత";

			Examples = new string[] { "గుహముఖలఘువుల్రమున్రేఫలీరైదుజీమూత మన్దండకంబయ్యెనోనక్రచక్రంతనీశాపజీమూతఝుంఝూంనిలా", };
		}
	}
	public class leelaakara : Rule
	{
		public leelaakara()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "leelaakara";
			Name = "లీలాకర";

			Examples = new string[] { "రసలఘువులమీఁదఁబంద్రేడురేఫల్ దలిర్పంగ లీలాకరం బన్నయా దండకంబున్దగుంధారుణింగంపనాంభోధికుంభీసుతా", };
		}
	}
	public class uddaama : Rule
	{
		public uddaama()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "uddaama";
			Name = "ఉద్దామ";

			Examples = new string[] { "నయుగళమును రేఫయున్రేఫలీరాఱు సుద్దామ 'మా' దండకంబౌను బౌలస్త్యకాసూహతాజిస్థలీలక్ష్మణప్రాణసంరక్షనోద్యద్యశా", };
		}
	}
	public class SaMkha : Rule
	{
		public SaMkha()
		{
			Lines = 1;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			YatiMode = YatiMode.CharPosition;

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "SaMkha";
			Name = "శంఖ";

			Examples = new string[] { "నయుగళిపయి నెన్నఁబధ్నాల్గు రేఫల్ క్రమంబొప్పఁగా నుండినన్శంఖమన్ దండకం బెందు నందంబగున్ శాంఖహస్తాంఘ్రినీరేజభృంగాయమానాఘనా ", };
		}
	}
	public class nanahata : Rule
	{
		public nanahata()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "nanahata";
			Name = "ననహత దండకము";
			Examples = new string[] {
										"అమరగననహంబులందాదిగానొండె... చూడామనీత్యాగవైరోచనా"

									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "న న హ త త గ".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			DeferThresold = true;
			InfiniteLength = true;

		}
	}
	public class sanahata : Rule
	{
		public sanahata()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "sanahata";
			Name = "సనహత దండకము";
			Examples = new string[] {
										"సిరి నేలు రసికుండు శ్రీవత్సవక్షుండు నీరేరుహాక్షుండు నిత్యాసదృక్షుండు త్రైలోక్యసంరక్షణోపాయ దక్షుండు మాపాలి దేవుండు ధీరుం డుదారండితం డిచ్చు మాయిచ్చకున్వచ్చు సౌఖ్యమ్ము లంచున్మదిం గోరి పెద్దల్‌ స కారంబుతో సంగతం బై నహంబాది నొండెన్‌ దకారాదిగా నైన; లో నెల్ల చోటన్‌ దకారంబులం బెల్లు చెందన్‌ గకారావసానంబు నై దండకాకార మేపారఁ గీర్తింతు రెల్లప్పుడున్‌.",
										"కృతినాదిసనహంబులొండేంబ్రకల్పించి యామీఁదనెల్లందకారప్రధానంబు గుర్వంతమైక్రాల....విశ్వంభరాధీశ్వరా!!"
									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "స న హ త త గ".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			DeferThresold = true;
			InfiniteLength = true;

		}
	}
	public class nanata : Rule
	{
		public nanata()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "nanata";
			Name = "ననత దండకము";
			Examples = new string[] {
										"జయ గిరిశ సురేశముక్యామరస్తోమమౌళిస్థితస్నిగ్ధచామికరోదగ్రరత్నప్రయుక్తావతంస ప్రభాసంచయాంచత్పదాంభోరుహా...పాపౌఘనాశా నమస్తే నమస్తే నమః"
									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "న న త త గ".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;
		}
	}
	public class nanaya : Rule
	{
		public nanaya()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "nanaya";
			Name = "ననయ దండకము";
			Examples = new string[] {
										"జయజహరిగజేంద్రాది సద్భక్తరక్షైక దిక్షాభవాంభోధినిర్మగ్న జివాళికిన్నీవకాకెవ్వరుధ్దారకుల్ధేవదేవా నమస్తే నమస్తే నమస్తే"
									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "న న య య".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;
		}
	}
	public class nata : Rule
	{
		public nata()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "nata";
			Name = "నత దండకము";
			Examples = new string[] {
										"జలధికన్యాకుచాలిప్త కస్తూరిరేఖాసమాలంకృతోరస్క రక్షింపవేదిను నిన్నన్నుదేవేశమత్ప్రాణకోశా నమస్తేనమః"
									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "న త త".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;
		}
	}
	public class sata : Rule
	{
		public sata()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "sata";
			Name = "సత దండకము";
			Examples = new string[] {
										"గిరిశా కైలాసవాసా ధరాకన్యకాముగ్ధనేత్రాబ్జరాగాంశుమాలీ ననుంజేదుకోవేభవత్పాదసాన్నిధ్యమియగదే దేవదేవా నమస్తే నమస్తే నమస్తే నమః "
									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "స త త".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;
		}
	}
	public class ragaNa : Rule
	{
		public ragaNa()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "ragaNa";
			Name = "రగణ దండకము";

			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;

			YatiMode = YatiMode.CharPosition;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;

			Yati = new int[][] { };
			Rules = new string[][] { "ర గ".Split(' ') };
			Examples = new string[] {
										"దేవదేవేశ నిపాద భక్తుండ మన్నింపవే దీను దుగ్ధాబ్ధి  శాయీ నమస్తే నమస్తే నమః",
									};

		}
	}
	public class tagaNa : Rule
	{
		public tagaNa()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "tagaNa";
			Name = "తగణ దండకము";

			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;

			YatiMode = YatiMode.CharPosition;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;

			Yati = new int[][] { };
			Rules = new string[][] { "త గ".Split(' ') };
			Examples = new string[] {
										"శ్రీవత్సవక్షుండు నీరేరుహాక్షుండు నిత్యాసదృక్షుండు త్రైలోక్యసంరక్షణోపాయ దక్షుండు మాపాలి దేవుండు ధీరుం డుదారం డితం డిచ్చు మాయిచ్చకున్వచ్చు సౌఖ్యమ్ము లంచున్మదిం గోరి పెద్దల్‌ సకారంబుతో సంగతంబై నహంబాది నొండెన్‌ దకారాదిగా నైన; లో నెల్లచోటన్‌ దకారంబులం బెల్లు చెందన్‌ గకారావసానంబు నై దండకాకార మేపారఁ గీర్తింతు రెల్లప్పుడున్‌",
										"విద్వాంసు లెల్లన్ హ కారంబె కానీ న కారంబెకానీ స కారంబె కానీ వచింపం దగున్ముందుగా నిందు గాదేని యాదిం దకారంబు గల్పించి యామీది వెల్లన్ దకారంబులే మెండుగా నిచ్చకున్వచ్చు నందాక నిర్మించి గుర్వంతముం జేసినన్ దండకంబండ్రు కాదంబినీ నీలగోపాల బాలా నమస్తే పునస్తేనమః",
										"శ్రీకంఠ లోకేశ లోకోద్భవస్తాన సంహారకారీ పురారీ మురారీ ప్రియా చంద్రధారీ ...నమస్తే నమస్తే నమః  "
									};

		}
	}
	public class nagaNa : Rule
	{
		public nagaNa()
		{
			Lines = 1;
			Threshold = 3;

			Identifier = "nagaNa";
			Name = "నగణ దండకము";

			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;

			YatiMode = YatiMode.CharPosition;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;

			Yati = new int[][] { };
			Rules = new string[][] { "న గ".Split(' ') };
			Examples = new string[] {
									"మధుమధన నను దయగనవెజలధిశయన హరి హరీ"
									};

		}
	}
	public class hagaNa : Rule
	{
		public hagaNa()
		{
			Lines = 1;
			Threshold = 2;


			Identifier = "hagaNa";
			Name = "హగణ దండకము";

			Prasa = false;
			PrasaYati = false;
			InfiniteLength = true;
			DeferThresold = true;


			YatiMode = YatiMode.CharPosition;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;

			Yati = new int[][] { };
			Rules = new string[][] { "హ హ గ".Split(' ') };
			Examples = new string[] {
									"దేవదేవనన్ను బ్రోవరావెదుగ్ధ వర్ధికన్యకాముఖాంబుజాత సూర్యనిన్నెగొల్తు నెల్లవేళలం బ్రభూ నమః"
									};

		}
	}
	public class nasahata : Rule
	{
		public nasahata()
		{
			Lines = 1;
			Threshold = 3;


			Identifier = "nasahata";
			Name = "నసహత దండకము";
			Examples = new string[] {
										"అరిది బిరుదా నీవు రాయంచ తేజీవ జీరుండవై"
									};


			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.DaMDakamu;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;

			Yati = new int[][] { };
			Rules = new string[][] { "న స హ త త గ".Split(' ') };


			Prasa = false;
			PrasaYati = false;
			DeferThresold = true;
			InfiniteLength = true;
		}
	}
}