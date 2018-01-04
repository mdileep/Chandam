//---------------------------------------------------------------------------------------------
// <copyright file="R8.cs" company="Chandam-ఛందం">
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
	public class haMsaruta : Rule
	{
		public haMsaruta()
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

			Rules = new string[][] { new string[] { "మ", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "haMsaruta";
			Name = "హంసరుత";
			Examples = new string[] { "శ్రీసంపాదితములై య\nభ్యాసంబొప్పఁగ సరోజా\nవాసంబై మధురవంబై\nకూసెన్‌ మత్తకలహంసల్" };
		}
	}
	public class siMharaekha : Rule
	{
		public siMharaekha()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,జ,గా".Split(',') };

			Yati = new int[][] { };


			Identifier = "siMharaekha";
			Name = "సింహరేఖ";
			Examples = new string[] { "శ్రీరజంబుపై గగంబుల్\nచేర సింహరేఖ యయ్యెన్\nశ్రీరజంబుపై గగంబుల్\nచేర సింహరేఖ యయ్యెన్\n" ,
										"ఈరజాగ్రగా నియుక్తిన్\nగోరి సింహరేఖ యొప్పున్\nఈరజాగ్రగా నియుక్తిన్\nగోరి సింహరేఖ యొప్పున్" };
		}
	}
	public class samaani : Rule
	{
		public samaani()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,జ,వ".Split(',') };
			Yati = new int[][] { };


			Identifier = "samaani";
			Name = "సమాని (సమానిక , శ్రద్ధరా)";
			Examples = new string[] {
										"ఈ సమానికిన్ రజవ\nన్యాస మొప్పగుం గృతులన్\nఈ సమానికిన్ రజవ\nన్యాస మొప్పగుం గృతులన్",
										"ఇంబుగారజంబువకా\nరంబుగా సమాని యగున్\nఇంబుగారజంబువకా\nరంబుగా సమాని యగున్"
									};
		}
	}
	public class vimaana : Rule
	{
		public vimaana()
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

			Rules = new string[][] { new string[] { "జ", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vimaana";
			Name = "విమాన (వారిశాలా)";
			Examples = new string[] { "అమేఘమాకాశమందున్\nగమించి విద్యుత్తు పొందున్\nసమేతముల్కాప్రపాతం\nబమేయమై పొల్చెనెల్లన్" };
		}
	}
	public class vidyunmaala : Rule
	{
		public vidyunmaala()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "మ,మ,గా".Split(',') };
			Yati = new int[][] { new int[] { 5 } };


			Identifier = "vidyunmaala";
			Name = "విద్యున్మాలా (విద్యుల్లేఖా)";
			Examples = new string[] {
										"మాద్యద్భక్తిన్‌ మాగాయుక్తిన్‌\nవిద్యున్మాలా వృత్తం బొప్పన్‌\nచైద్యధ్వంసిన్‌ సంబోధింపన్‌\nసద్యశ్శ్రేయోజాతంబయ్యెన్‌."
									};
		}
	}
	public class vitaana : Rule
	{
		public vitaana()
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

			Rules = new string[][] { new string[] { "జ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vitaana";
			Name = "వితాన";

			Examples = new string[] { "ఇతండు ఋక్షోద్యత్సేనా\nప్రతాన కోటీంద్రుం డేచున్\nజితారిధూమ్రుం డాదిత్య\nస్తుతప్రభావుం డెందైనన్" };
		}
	}
	public class maaNavaka : Rule
	{
		public maaNavaka()
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

			Rules = new string[][] { new string[] { "భ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "maaNavaka";
			Name = "మాణవక";

			Examples = new string[] { "మాణవకాఖ్యంబగు న\nక్షీణ భతంబుల్ లగముల్\nమాణవకాఖ్యంబగు న\nక్షీణ భతంబుల్ లగముల్" };
		}
	}
	public class pramaaNi : Rule
	{
		public pramaaNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,ర,వ".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "pramaaNi";
			Name = "ప్రమాణి (ప్రమాణికా)";
			Examples = new string[] {   "సరోజనాభుఁ డచ్యుతుం\nడరాతిభంజనుం డనన్‌\nజరేఫలన్‌ గలంబులన్‌\nధరన్ బ్రమాణి యొప్పగున్‌." ,
										"స్వమాంసభోక్తలైచనన్\nసముల్‌సహస్రముల్‌చనుం\nడమందదర్పులైవృధా\nభ్రమన్‌మనుష్యపాళీలో"
									};
		}
	}
	public class naaraacha : Rule
	{
		public naaraacha()
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

			Rules = new string[][] { new string[] { "త", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "naaraacha";
			Name = "నారాచ (నారాచక)";

			Examples = new string[] { "ఈతండు రాఘవాగ్రజుం\nడేతెంచు శత్రునిం గరా\nఘాతంబుచే వధించు ని\nర్ఘాతంబు నామహాజిలో" };
		}
	}
	public class naagara : Rule
	{
		public naagara()
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

			Rules = new string[][] { new string[] { "భ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "naagara";
			Name = "నాగర (నాగరక)";

			Examples = new string[] { "ఈతని పేరు వహ్ని సం\nజాత రుషాచ్ఛటాప్రచం\nడాతపనేత్రవహ్నివి\nద్యోతిత శౌర్యవార్ధియై" };
		}
	}
	public class chitrapadamu : Rule
	{
		public chitrapadamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,భ,గా".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "chitrapadamu";
			Name = "చిత్రపదము";
			Examples = new string[] {
										"వారక భాగురుయుగ్మం\nబారఁగఁ జిత్రపదాఖ్యం\nజేరిన వేడ్కఁ గవీంద్రుల్‌\nగోరి నుతింతురు శౌరిన్‌.",
										"కూడియు మున్నుగఁదోచిన్\nవాఁడిశరంబున దూయున్\nబోడి నియతునయందున\nలేడియకంపడకుండున్"
									};
		}
	}
}
