//---------------------------------------------------------------------------------------------
// <copyright file="Kokkanda.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Tel.Kokkonda
{
	public class prakRti : Rule
	{
		public prakRti()
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

			Rules = new string[][] { new string[] { "స", "భ", "గా" } };
			Yati = new int[][] { new int[] { 5 } };

			Identifier = "prakRti";
			Name = "ప్రకృతి(సుభగ,అతిమోహా)";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class Sreekara : Rule
	{
		public Sreekara()
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

			Rules = new string[][] { new string[] { "స", "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "Sreekara";
			Name = "శ్రీకర";

			Examples = new string[] { "ప్రతిరోజుజేయుశౌచబాధ్యతల్ ప్రపం\nచితమౌగజేసెనొక్కచీపురెత్తిభా\nరతదేశగౌరవంబురంజిలెన్ ప్రస\nన్నతగూరెనంత మోదినాదరించగా ~ శ్రీ పిరాట్ల వెంకట శివరామకృష్ణ ప్రసాద్ గారిచే విరచితం." };
			References = new string[] { "New" };
		}
	}
	public class sannuta : Rule
	{
		public sannuta()
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

			Rules = new string[][] { new string[] { "ర", "జ", "న", "భ", "స" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "sannuta";
			Name = "సన్నుత";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class SaMkara1 : Rule
	{
		public SaMkara1()
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

			Rules = new string[][] { new string[] { "భ", "స", "న", "జ", "య" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "SaMkara1";
			Name = "శంకర1";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class SaMkara2 : Rule
	{
		public SaMkara2()
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

			Rules = new string[][] { new string[] { "భ", "జ", "న", "స", "న", "గ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "SaMkara2";
			Name = "శంకర2";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class j_naana : Rule
	{
		public j_naana()
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

			Rules = new string[][] { new string[] { "త", "న", "భ", "భ", "స", "గ" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "j_naana";
			Name = "జ్ఞాన";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class taaraka : Rule
	{
		public taaraka()
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

			Rules = new string[][] { new string[] { "స", "న", "జ", "జ", "న", "గా" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "taaraka";
			Name = "తారక";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class tanumadhyamaa : Rule
	{
		public tanumadhyamaa()
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

			Rules = new string[][] { new string[] { "య", "మ", "య", "న", "ర", "ర" } };
			Yati = new int[][] { new int[] { 8, 15 } };

			Identifier = "tanumadhyamaa";
			Name = "తనుమధ్యమా";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class SivaSaMkara : Rule
	{
		public SivaSaMkara()
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

			Rules = new string[][] { new string[] { "స", "న", "జ", "న", "భ", "స" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "SivaSaMkara";
			Name = "శివశంకర (సురభి)";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class maNideepti : Rule
	{
		public maNideepti()
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

			Rules = new string[][] { new string[] { "మ", "స", "స", "త", "జ", "య", "గ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "maNideepti";
			Name = "మణిదీప్తి";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class mattakeera : Rule
	{
		public mattakeera()
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

			Rules = new string[][] { new string[] { "న", "న", "జ", "భ", "ర", "స", "వ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "mattakeera";
			Name = "మత్తకీర";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class gaayaka : Rule
	{
		public gaayaka()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "య", "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { new int[] { 9, 13, 20 } };

			Identifier = "gaayaka";
			Name = "గాయక";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}
	public class SObhanamahaaSree : Rule
	{
		public SObhanamahaaSree()
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

			Rules = new string[][] { new string[] { "త", "భ", "య", "జ", "స", "ర", "న", "భ", "గ" } };
			Yati = new int[][] { new int[] { 8, 15, 22 } };

			Identifier = "SObhanamahaaSree";
			Name = "శోభనమహాశ్రీ";

			Examples = new string[] { };

			References = new string[] { "New" };
		}
	}

}
