//---------------------------------------------------------------------------------------------
// <copyright file="TelCodeIt.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Tel
{
	public class purusha : Rule
	{
		public purusha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "స", "మ" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "purusha";
			Name = "పురుష(కర్మిష్ఠా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalita2 : Rule
	{
		public lalita2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "ల" } };
			Yati = new int[][] { new int[] { } };

			Identifier = "lalita2";
			Name = "లలిత-2 (దయి/పటు)";

			Examples = new string[] { };
			References = new string[] { };
		}
	}
	public class naaraayaNa : Rule
	{
		public naaraayaNa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "త", "హ" } };
			Yati = new int[][] { new int[] { } };

			Identifier = "naaraayaNa";
			Name = "నారాయణ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gaNanaatha : Rule
	{
		public gaNanaatha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "య", "భ", "య" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "gaNanaatha";
			Name = "గణనాథ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class daeva : Rule
	{
		public daeva()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "త", "య", "స", "గా" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "daeva";
			Name = "దేవ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paramaeSa : Rule
	{
		public paramaeSa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "న", "జ", "భ", "గా" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "paramaeSa";
			Name = "పరమేశ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class DiMDima : Rule
	{
		public DiMDima()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "స", "న", "జ", "ర" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "DiMDima";
			Name = "డిండిమ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mahaamaMgaLamaNi : Rule
	{
		public mahaamaMgaLamaNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "మ", "స", "స", "స" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "mahaamaMgaLamaNi";
			Name = "మహామంగళమణి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chaMdraSaekhara : Rule
	{
		public chaMdraSaekhara()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "ర", "జ", "ర" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "chaMdraSaekhara";
			Name = "చంద్రశేఖర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chaMdraSree2 : Rule
	{
		public chaMdraSree2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "య", "మ", "న", "య", "య" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "chaMdraSree2";
			Name = "చంద్రశ్రీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kamalaakara : Rule
	{
		public kamalaakara()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "న", "జ", "జ", "య" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "kamalaakara";
			Name = "కమలాకర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaamadaeva : Rule
	{
		public vaamadaeva()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "జ", "న", "ర", "జ", "గ" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "vaamadaeva";
			Name = "వామదేవ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chaMchala : Rule
	{
		public chaMchala()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", "ర", "ల" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "chaMchala";
			Name = "చంచల (చిత్రశోభ,చిత్రమ్)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maMgaLamaNi : Rule
	{
		public maMgaLamaNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "స", "న", "జ", "న", "గ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "maMgaLamaNi";
			Name = "మంగళమణి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Damaruka : Rule
	{
		public Damaruka()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "త", "జ", "స", "న", "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "Damaruka";
			Name = "డమరుక";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Sreemati : Rule
	{
		public Sreemati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "త", "య", "స", "జ", "గా" } };
			Yati = new int[][] { new int[] { 12 } };

			Identifier = "Sreemati";
			Name = "శ్రీమతి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jaagrati : Rule
	{
		public jaagrati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "న", "జ", "న", "భ", "గా" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "jaagrati";
			Name = "జాగ్రత్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class taaMDavajava : Rule
	{
		public taaMDavajava()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "న", "న", "స", "న", "య" } };
			Yati = new int[][] { new int[] { 12 } };

			Identifier = "taaMDavajava";
			Name = "తాండవజవ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaaNi : Rule
	{
		public vaaNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "భ", "స", "న", "య", "స", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "vaaNi";
			Name = "వాణి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prabhaakalita : Rule
	{
		public prabhaakalita()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "జ", "భ", "ర", "జ", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "prabhaakalita";
			Name = "ప్రభాకలిత";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class yaSasvi : Rule
	{
		public yaSasvi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "న", "న", "న", "జ", "జ", "య", "గ" } };
			Yati = new int[][] { new int[] { 6, 14, 20 } };

			Identifier = "yaSasvi";
			Name = "యశస్వి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lakshmee : Rule
	{
		public lakshmee()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "య", "స", "భ", "న", "న", "స", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "lakshmee";
			Name = "లక్ష్మీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nati : Rule
	{
		public nati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "త", "య", "న", "జ", "జ", "న", "గ" } };
			Yati = new int[][] { new int[] { 9, 15 } };

			Identifier = "nati";
			Name = "నతి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mattaebha : Rule
	{
		public mattaebha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "భ", "య", "జ", "స", "ర", "న", "గ" } };
			Yati = new int[][] { new int[] { 8, 15 } };

			Identifier = "mattaebha";
			Name = "మత్తేభ (అశ్వధాటి,సితస్తవకః)";

			Examples = new string[] { "సప్తాశ్వరూఢుడయిసావిత్రుడీదినముసామీప్యమయ్యెమకరం\nతృప్తాత్ములయ్యిగొనితీరైనగుమ్మిడులదీవించుభూసురగణం\nప్రాప్తించపుణ్యగతిరాజర్షిభీష్ముడటుభావించుమారణదినం \nతప్తాధికంబులకుతప్తాండుడున్ధరయుదాపైననాయనపధం\nలుప్తంబులైజనవెలోకాలమాంద్యములులోజేరవహ్నిజఠరమ్ \nదీప్తోద్ధతిన్మెరయదివ్యంపుపౌష్యసిరితీరైనముగ్గురచనం \nక్లుప్తంబులైనిశలుకొండంతలైపగలుకొమ్మాకురాలుశిశిరం \nగుప్తంబులైజనినగోత్రీకులన్ఋణముగొమ్మంచుతర్పణదినం \nవ్యాప్తించగాలచిమివడ్లన్నపొంగలులవడ్డించుతీపిపచనం \nసుప్తాత్ములన్కుదుపుజోరైనశీతపువిశోకంపుభోగిదహనం \nజ్ఞప్తిన్తలంచుకొనిసాలందుమేలుపశుజాతందుపూజకనుమల్ \nనప్తారపౌత్రసుతనవ్యంపుటూహలిడినాణ్యంపుబొమ్మకొలువుల్\nసప్తస్వరావళులసల్లాపముల్సలుపుసన్నాయిగంగిబసవల్\nవ్యాప్తింపనామధునివారంబురంగహరియంచేగుదాసుభజనల్\nహప్తాలపాటుయికహర్మ్యాలపైకెగిరియాడేటిగాలిపటముల్\nకోప్తాలుపాస్ట్రిలికకొండెక్కిగారెదధికోవాలకమ్మదనముల్\nఆప్తాళిబంధుతతికానందసంగమముఆసూర్యుసంక్రమణముల్ \nలిప్తల్యుగాలుగనులెక్కౌనిరీక్షణములీడేరురక్తిఫలదం \nజప్తైనబుద్ధివిడిచాకంటిసూక్ష్మతనుసాధించుగొప్పతరుణం \nక్షిప్తానకుందుమదిసిద్ధందినాత్మగనికృత్స్నమ్ము కృష్ణునిపరం ~ శ్రీ సూర్యనారాయణ సరిపల్లి గారిచే విరచితం." };
			References = new string[] { };
		}
	}
	public class tulya2 : Rule
	{
		public tulya2()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "త", "న", "త", "న", "త", "వ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "tulya2";
			Name = "తుల్య2";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tulya1 : Rule
	{
		public tulya1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "న", "త", "న", "త", "న", "త", "న" } };
			Yati = new int[][] { new int[] { 7, 13, 19 } };

			Identifier = "tulya1";
			Name = "తుల్య1";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalyaaNa : Rule
	{
		public kalyaaNa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "జ", "జ", "ర", "జ", "ర", "స", "ర", "వ" } };
			Yati = new int[][] { new int[] { 8, 13, 22 } };

			Identifier = "kalyaaNa";
			Name = "కల్యాణ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class SaMbhunaTanamu : Rule
	{
		public SaMbhunaTanamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "స", "న", "భ", "జ", "స", "న", "భ", "వ" } };
			Yati = new int[][] { new int[] { 10, 18 } };

			Identifier = "SaMbhunaTanamu";
			Name = "శంభునటనము";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
}
