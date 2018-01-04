//---------------------------------------------------------------------------------------------
// <copyright file="R6.cs" company="Chandam-ఛందం">
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
	public class suralata : Rule
	{
		public suralata()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,య".Split(',') };
			Yati = new int[][] { };

			Identifier = "suralata";
			Name = "సురలత (శశివదన , కనకలతా , చతురంశా , మకరశీర్షా , ముకులితా)";
			Examples = new string[] { "శశివదనాభన్\nశశధరుఁడోటన్\nదశఁజూటన్\nవిశయమునందెన్", "సురలతఁ జెప్పన్ \n సొరిది నయంబుల్.\nసురలతఁ జెప్పన్ \n సొరిది నయంబుల్." };
		}
	}
	public class vichitramu : Rule
	{
		public vichitramu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "య,య".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "vichitramu";
			Name = "విచిత్రము (సోమరాజీ)";
			Examples = new string[] { "ఖరప్రౌఢచాప\nస్ఫురద్బాణధారన్\nధరాకన్యకారా\nట్మరాసంబువిర్గెన్", "విచిత్రంబునందున్\nరుచించున్ యయంబుల్\nవిచిత్రంబునందున్\nరుచించున్ యయంబుల్" };
		}
	}
	public class vasumati : Rule
	{
		public vasumati()
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
			Rules = new string[][] { new string[] { "త", "స" } };
			Yati = new int[][] { };
			Identifier = "vasumati";
			Name = "వసుమతి";

			Examples = new string[] { "ధాత్రిన్ వసుమతిన్\nనేత్రోత్సవముగా\nక్షేత్రజ్ఞునెఱుకన్\nజిత్రింప మనసౌ" };
		}
	}
	public class vasudha : Rule
	{
		public vasudha()
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

			Rules = new string[][] { new string[] { "స", "స" } };
			Yati = new int[][] { };

			Identifier = "vasudha";
			Name = "వసుధ (కిసలయ , తిలకా)";

			Examples = new string[] { "వసుధాపతియౌ\nవసుదేవసుతున్\nబసుకాపరిగా\nససిఁబిల్తురిలన్" };
		}
	}
	public class tanumadhyaavRttamu : Rule
	{
		public tanumadhyaavRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త,య".Split(',') };

			Yati = new int[][] { };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "tanumadhyaavRttamu";
			Name = "తనుమధ్య";
			Examples = new string[] {
										"గోపాలుని దేవే\nనాపాలికి నాఁగాఁ\nబై పై తనుమధ్యన్‌\nబ్రాపించుఁ దయంబుల్‌.",
										"గౌరీతనుమధ్యన్\nస్వారింగొని సింహం\nబారాధనలందున్\nక్రూరాగ్రియమయ్యున్"
									};
		}
	}
	public class chaMdravadana : Rule
	{
		public chaMdravadana()
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
			Rules = new string[][] { new string[] { "భ", "య" } };
			Yati = new int[][] { };
			Identifier = "chaMdravadana";
			Name = "చంద్రవదన";
			Examples = new string[] { "చంద్రవదనన్ వ\nజ్రేంద్ర మణిభూషా\nసాంద్రలలితాంగిన్\nమంద్రనుతిఁ గొల్తున్" };
		}
	}
	public class saavitrI : Rule
	{
		public saavitrI()
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
			Rules = new string[][] { new string[] { "మ", "మ" } };
			Yati = new int[][] { };
			Identifier = "saavitrI";
			Name = "సావిత్రి (విద్యుల్లేఖా)";
			Examples = new string[] { "సావిత్రీ ధ్యానంబౌ\nభావప్రాప్తోద్భాసన్\nజీవాత్మైక్యంబెంచన్\nధీవిస్రబ్ధప్రాప్తిన్ " };
		}
	}
}
