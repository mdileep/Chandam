//---------------------------------------------------------------------------------------------
// <copyright file="R7.cs" company="Chandam-ఛందం">
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
	public class suruchira1 : Rule
	{
		public suruchira1()
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



			Identifier = "suruchira1";
			Name = "సురుచిర-1 (సరసిజ , మదలేఖా , విధువక్త్రా , రుచిరమ్)";

			Rules = new string[][] { new string[] { "భ", "స", "గ" } };
			Yati = new int[][] { };
			Examples = new string[] { "భాసుర భసగల్‌రే\nచా సురుచిరమయ్యెన్\nభాసుర భసగల్‌రే\nచా సురుచిరమయ్యెన్" };
		}
	}
	public class haMsamaala : Rule
	{
		public haMsamaala()
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

			Rules = new string[][] { new string[] { "స", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "haMsamaala";
			Name = "హంసమాల (భూరిధామా)";
			Examples = new string[] { "సరగంబుల్రచింపన్\nబరఁగున్ హంసమాలా\nనరసింహావతారా\nసురవిద్విడ్విహారా" };
		}
	}
	public class vibhootivRttamu : Rule
	{
		public vibhootivRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 7 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "vibhootivRttamu";
			Name = "విభూతి (చామరమ్)";
			Examples = new string[] { "స్వస్థ సద్విభూతి దా\nరస్థ జస్థగంబునన్\nస్వస్థ సద్విభూతి దా\nరస్థ జస్థగంబునన్", "అయెడన్ మునీశ్వరుం\nడీయెడన్ రఘూత్తమం\nడాయెడన్ రఘూత్తమం\nడీయెడన్ మునీద్రుడున్" };
		}
	}
	public class lOla : Rule
	{
		public lOla()
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
			Rules = new string[][] { new string[] { "య", "య", "గ" } };
			Yati = new int[][] { };
			Identifier = "lOla";
			Name = "లోల (అభీకమ్)";
			Examples = new string[] { "యయల్గంబులోలాఖ్యన్\nయయల్గంబులోలాఖ్యన్\nయయల్గంబులోలాఖ్యన్\nయయల్గంబులోలాఖ్యన్" };
		}
	}

	public class madhumati : Rule
	{
		public madhumati()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,భ,గ".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "madhumati";
			Name = "మధుమతి (స్వనకరీ)";
			Examples = new string[]
			{
							"వగరు పిందెలతోఁ\nజిగురు టాకులతోఁ\nదొగరు వన్నెలతోఁ\nమిగిలె మావితరుల్",
							@"మధుమతీ దరి రా\nమధురమౌ స్మృతితో\nవ్యధల బాపగ రా\nసుధల నీయగ రా"//Mohana Rao

			};
		}
	}
	public class madaraekha : Rule
	{
		public madaraekha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "మ స గ".Split(' ') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "madaraekha";
			Name = "మదరేఖ";
			Examples = new string[] { "కోదండాగతరజ్జుల్\nపాదాంతమ్మునయందున్\nమోదించెన్ హరిణంబున్\nనాదూకున్ బదిబారల్", "రూపింపన్మగణాద్యం\nబై పెంపార సగంబుల్‌\nదీపించున్మదరేఖన్‌\nగోపస్త్రీహృదయేశా!" };
		}
	}
	public class madanavilasitamu : Rule
	{
		public madanavilasitamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,గ".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "madanavilasitamu";
			Name = "మదనవిలసిత (ద్రుతగతి , చపలా , మధుమతి , లటహ , హరివిలసిత)";
			Examples = new string[] {   "పదపడి ననగల్\nగదసి వెలసినన్\nమదనవిలసితం\nబది యదుతిలకా.",
										"మధురిపుఁ డనినన్‌\nమధురపుననగల్‌\nమధురము లగుచున్‌\nమధుమతి నమరున్‌."
									};
		}
	}

	public class kumaaralalita : Rule
	{
		public kumaaralalita()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,న,గ".Split(',') };
			Yati = new int[][] { };
			Identifier = "kumaaralalita";
			Name = "కుమారలలిత-1 (స్విదా)";
			Examples = new string[] { "కుమారలలితకున్\nసమగ్రజనగముల్.\nకుమారలలితకున్\nసమగ్రజనగముల్." };
		}
	}
	public class kumaaralalita2 : Rule
	{
		public kumaaralalita2()
		{
			Lines = 4;
			Threshold = 3;
			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,స,గ".Split(',') };
			Yati = new int[][] { };
			Identifier = "kumaaralalita2";
			Name = "కుమారలలిత-2";
			Examples = new string[] { "కుమారలలితాఖ్యా\nతమౌ పలనిసుక్షే\nత్రమాన్యమురుగేశున్\nసమీకరణనెంతున్" };
		}
	}

	public class prasavaSara : Rule
	{
		public prasavaSara()
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
			Rules = new string[][] { new string[] { "న", "స", "గ" } };
			Yati = new int[][] { };
			Identifier = "prasavaSara";
			Name = "ప్రసవశర (దృతిః)";
			Examples = new string[] { "ఎసఁగబదమందున్\nనసగములుచెందన్\nబ్రసవశరమయ్యెన్\nబిసరుహదళాక్షా" };
		}
	}

}
