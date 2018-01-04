//---------------------------------------------------------------------------------------------
// <copyright file="SansCodeIt.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
namespace Chandam.Rules.Sans
{
	public class kinnaTakaH : Rule
	{
		public kinnaTakaH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "జ", "జ", "వ", }, new string[] { "స", "స", "స", "స", }, new string[] { "త", "జ", "జ", "వ", }, new string[] { "స", "స", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "kinnaTakaH";
			Name = "కిన్నటకః";

			Examples = new string[] { };
			References = new string[] { };
		}
	}
	public class ketumatI : Rule
	{
		public ketumatI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "జ", "స", "గ", }, new string[] { "భ", "ర", "న", "గా", }, new string[] { "స", "జ", "స", "గ", }, new string[] { "భ", "ర", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "ketumatI";
			Name = "కేతుమతీ";

			Examples = new string[] { };
			References = new string[] { };
		}
	}
	public class vaidhAtrI : Rule
	{
		public vaidhAtrI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "vaidhAtrI";
			Name = "వైధాత్రీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kilikitA : Rule
	{
		public kilikitA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "న", "ర", "వ", }, new string[] { "న", "భ", "జ", "ర", }, new string[] { "ర", "న", "ర", "వ", }, new string[] { "న", "భ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "kilikitA";
			Name = "కిలికితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karadhA : Rule
	{
		public karadhA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గ", }, new string[] { "న", "న", "ర", "వ", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "న", "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "karadhA";
			Name = "కరధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varddhamAnam : Rule
	{
		public varddhamAnam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "స", "జ", "భ", "గా", }, new string[] { "స", "న", "జ", "ర", "గ", }, new string[] { "న", "న", "స", "న", "న", "స", }, new string[] { "న", "న", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "varddhamAnam";
			Name = "వర్ద్ధమానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varAsikA : Rule
	{
		public varAsikA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "varAsikA";
			Name = "వరాసికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmAkSI : Rule
	{
		public kAmAkSI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "స", "న", "న", "గ", }, new string[] { "మ", "భ", "న", "వ", }, new string[] { "స", "స", "న", "న", "గ", }, new string[] { "మ", "భ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAmAkSI";
			Name = "కామాక్షీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class camUruH : Rule
	{
		public camUruH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "న", "జ", "ర", "గ", }, new string[] { "ర", "న", "జ", "ర", }, new string[] { "స", "న", "జ", "ర", "గ", }, new string[] { "ర", "న", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "camUruH";
			Name = "చమూరుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class camUrubhIruH : Rule
	{
		public camUrubhIruH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "న", "జ", "ర", }, new string[] { "స", "న", "జ", "ర", "గ", }, new string[] { "ర", "న", "జ", "ర", }, new string[] { "స", "న", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "camUrubhIruH";
			Name = "చమూరుభీరుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalanA : Rule
	{
		public kalanA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "జ", "స", "స", "గ", }, new string[] { "స", "జ", "స", "జ", "గ", }, new string[] { "స", "జ", "స", "స", "గ", }, new string[] { "స", "జ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalanA";
			Name = "కలనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vANI : Rule
	{
		public vANI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vANI";
			Name = "వాణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAntA : Rule
	{
		public kAntA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "kAntA";
			Name = "కాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karabhoddhatA : Rule
	{
		public karabhoddhatA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "త", "ర", "వ", }, new string[] { "స", "న", "ర", "వ", }, new string[] { "భ", "త", "ర", "వ", }, new string[] { "స", "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "karabhoddhatA";
			Name = "కరభోద్ధతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kamalAkarA : Rule
	{
		public kamalAkarA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "గా", }, new string[] { "భ", "న", "జ", "య", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "భ", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "kamalAkarA";
			Name = "కమలాకరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class buddhiH : Rule
	{
		public buddhiH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "buddhiH";
			Name = "బుద్ధిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bRhaccharAvatI : Rule
	{
		public bRhaccharAvatI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "న", "జ", "ర", }, new string[] { "న", "న", "ర", "య", }, new string[] { "స", "భ", "న", "జ", "ర", }, new string[] { "న", "న", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "bRhaccharAvatI";
			Name = "బృహచ్ఛరావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarAvatI : Rule
	{
		public zarAvatI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "య", }, new string[] { "స", "భ", "న", "జ", "ర", }, new string[] { "న", "న", "ర", "య", }, new string[] { "స", "భ", "న", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "zarAvatI";
			Name = "శరావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class premA : Rule
	{
		public premA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "premA";
			Name = "ప్రేమా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anaGgapadam : Rule
	{
		public anaGgapadam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "గ", }, new string[] { "స", "స", "స", "స", "గ", }, new string[] { "భ", "భ", "భ", "భ", "గ", }, new string[] { "స", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "anaGgapadam";
			Name = "అనఙ్గపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class samudrakAntA : Rule
	{
		public samudrakAntA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "samudrakAntA";
			Name = "సముద్రకాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anAlepanam : Rule
	{
		public anAlepanam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "భ", "య", "య", "వ", }, new string[] { "న", "త", "త", "త", "గ", }, new string[] { "న", "భ", "య", "య", "వ", }, new string[] { "న", "త", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "anAlepanam";
			Name = "అనాలేపనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zizirazikhA : Rule
	{
		public zizirazikhA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "వ", }, new string[] { "న", "జ", "జ", "ర", }, new string[] { "న", "న", "ర", "వ", }, new string[] { "న", "జ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "zizirazikhA";
			Name = "శిశిరశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aJcitAgrA : Rule
	{
		public aJcitAgrA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "జ", "ర", "గ", }, new string[] { "న", "న", "ర", "య", }, new string[] { "న", "జ", "జ", "ర", "గ", }, new string[] { "న", "న", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "aJcitAgrA";
			Name = "అఞ్చితాగ్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pAtazIlA : Rule
	{
		public pAtazIlA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "న", "మ", "య", }, new string[] { "త", "మ", "ర", "గ", }, new string[] { "స", "న", "మ", "య", }, new string[] { "త", "మ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "pAtazIlA";
			Name = "పాతశీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pATalikA : Rule
	{
		public pATalikA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "య", "న", "య", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "న", "య", "న", "య", }, new string[] { "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "pATalikA";
			Name = "పాటలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ahInatAlI : Rule
	{
		public ahInatAlI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "న", "జ", "ర", }, new string[] { "స", "భ", "స", "జ", "ర", "గ", }, new string[] { "మ", "న", "జ", "ర", }, new string[] { "స", "భ", "స", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "ahInatAlI";
			Name = "అహీనతాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zizumukhI : Rule
	{
		public zizumukhI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "భ", "జ", "జ", "గ", }, new string[] { "న", "భ", "స", "జ", "గ", }, new string[] { "న", "భ", "జ", "జ", "గ", }, new string[] { "న", "భ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "zizumukhI";
			Name = "శిశుముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class puSpitAgrA : Rule
	{
		public puSpitAgrA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "య", }, new string[] { "న", "జ", "జ", "ర", "గ", }, new string[] { "న", "న", "ర", "య", }, new string[] { "న", "జ", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "puSpitAgrA";
			Name = "పుష్పితాగ్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class puSTidA : Rule
	{
		public puSTidA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "puSTidA";
			Name = "పుష్టిదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ramaNA : Rule
	{
		public ramaNA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "ramaNA";
			Name = "రమణా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anirayA : Rule
	{
		public anirayA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "భ", "స", "జ", "గ", }, new string[] { "న", "భ", "జ", "జ", "గ", }, new string[] { "న", "భ", "స", "జ", "గ", }, new string[] { "న", "భ", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "anirayA";
			Name = "అనిరయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paravaktram : Rule
	{
		public paravaktram()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "జ", "ర", }, new string[] { "న", "న", "ర", "వ", }, new string[] { "న", "జ", "జ", "ర", }, new string[] { "న", "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "paravaktram";
			Name = "పరవక్త్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anAsavavAsitA : Rule
	{
		public anAsavavAsitA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "ర", "జ", "స", "గ", }, new string[] { "న", "భ", "జ", "ర", "య", }, new string[] { "స", "భ", "ర", "జ", "స", "గ", }, new string[] { "న", "భ", "జ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "anAsavavAsitA";
			Name = "అనాసవవాసితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paraprINitA : Rule
	{
		public paraprINitA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "త", "త", "గ", }, new string[] { "న", "న", "స", "త", "త", "గ", }, new string[] { "న", "న", "త", "త", "గ", }, new string[] { "న", "న", "స", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "paraprINitA";
			Name = "పరప్రీణితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zizirA : Rule
	{
		public zizirA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "zizirA";
			Name = "శిశిరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saMpAtazIlA : Rule
	{
		public saMpAtazIlA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "మ", "ర", "గ", }, new string[] { "స", "న", "మ", "య", }, new string[] { "త", "మ", "ర", "గ", }, new string[] { "స", "న", "మ", "య" } };
			Yati = new int[][] { };

			Identifier = "saMpAtazIlA";
			Name = "సంపాతశీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class alipadam : Rule
	{
		public alipadam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "ర", "న", "త", "గ", }, new string[] { "న", "త", "త", "గ", }, new string[] { "ర", "ర", "న", "త", "గ", }, new string[] { "న", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "alipadam";
			Name = "అలిపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Alepanam : Rule
	{
		public Alepanam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "త", "త", "త", "గ", }, new string[] { "న", "భ", "య", "య", "వ", }, new string[] { "న", "త", "త", "త", "గ", }, new string[] { "న", "భ", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "Alepanam";
			Name = "ఆలేపనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AlolaghaTikA : Rule
	{
		public AlolaghaTikA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "స", "జ", "గ", }, new string[] { "త", "స", "జ", "గ", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "త", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "AlolaghaTikA";
			Name = "ఆలోలఘటికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AkhyAnakI : Rule
	{
		public AkhyAnakI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "AkhyAnakI";
			Name = "ఆఖ్యానకీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pramAlikA : Rule
	{
		public pramAlikA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "ర", "య", }, new string[] { "స", "స", "జ", "గా", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "స", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "pramAlikA";
			Name = "ప్రమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zIlAturA : Rule
	{
		public zIlAturA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "zIlAturA";
			Name = "శీలాతురా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class akusumacaram : Rule
	{
		public akusumacaram()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "న", "జ", "య", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "భ", "న", "జ", "య", }, new string[] { "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "akusumacaram";
			Name = "అకుసుమచరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pramodapadam : Rule
	{
		public pramodapadam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "జ", "భ", "య", }, new string[] { "న", "న", "ర", "జ", "గా", }, new string[] { "న", "జ", "జ", "భ", "య", }, new string[] { "న", "న", "ర", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "pramodapadam";
			Name = "ప్రమోదపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class akoSakRSTA : Rule
	{
		public akoSakRSTA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "ర", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "akoSakRSTA";
			Name = "అకోషకృష్టా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pramAthinI : Rule
	{
		public pramAthinI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "న", "జ", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "pramAthinI";
			Name = "ప్రమాథినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sarasIkam : Rule
	{
		public sarasIkam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "భ", "జ", "య", }, new string[] { "స", "భ", "జ", "య", }, new string[] { "త", "భ", "జ", "య", }, new string[] { "స", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "sarasIkam";
			Name = "సరసీకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saurabheyI : Rule
	{
		public saurabheyI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "saurabheyI";
			Name = "సౌరభేయీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amarAvatI : Rule
	{
		public amarAvatI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", }, new string[] { "జ", "ర", "జ", "ర", "గ", }, new string[] { "ర", "జ", "ర", "జ", }, new string[] { "జ", "ర", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "amarAvatI";
			Name = "అమరావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prativinItA : Rule
	{
		public prativinItA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "య", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "న", "గా", }, new string[] { "న", "య", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "prativinItA";
			Name = "ప్రతివినీతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amarAvatI_1 : Rule
	{
		public amarAvatI_1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "ర", "జ", "ర", "గ", }, new string[] { "ర", "జ", "ర", "జ", }, new string[] { "జ", "ర", "జ", "ర", "గ", }, new string[] { "ర", "జ", "ర", "జ" } };
			Yati = new int[][] { };

			Identifier = "amarAvatI_1";
			Name = "అమరావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pramodapariNItA : Rule
	{
		public pramodapariNItA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "జ", "గా", }, new string[] { "న", "జ", "జ", "భ", "య", }, new string[] { "న", "న", "ర", "జ", "గా", }, new string[] { "న", "జ", "జ", "భ", "య" } };
			Yati = new int[][] { };

			Identifier = "pramodapariNItA";
			Name = "ప్రమోదపరిణీతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class alparutam : Rule
	{
		public alparutam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ", "న", "జ", "జ", "ల", }, new string[] { "భ", "న", "య", "న", "ల", }, new string[] { "భ", "న", "జ", "జ", "ల", }, new string[] { "భ", "న", "య", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "alparutam";
			Name = "అల్పరుతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sArikA : Rule
	{
		public sArikA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "న", "ర", "వ", }, new string[] { "ర", "న", "భ", "గా", }, new string[] { "ర", "న", "ర", "వ", }, new string[] { "ర", "న", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "sArikA";
			Name = "సారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prabhAsitA : Rule
	{
		public prabhAsitA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "స", "జ", "గ", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "మ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "prabhAsitA";
			Name = "ప్రభాసితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prabhAsitA_1 : Rule
	{
		public prabhAsitA_1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గ", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "స", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "prabhAsitA_1";
			Name = "ప్రభాసితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arbhakapaGktiH : Rule
	{
		public arbhakapaGktiH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "ర", "య", }, new string[] { "భ", "భ", "ర", "య", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "భ", "భ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "arbhakapaGktiH";
			Name = "అర్భకపఙ్క్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class samayavatI : Rule
	{
		public samayavatI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "న", "త", "వ", }, new string[] { "స", "మ", "న", "వ", }, new string[] { "త", "న", "త", "వ", }, new string[] { "స", "మ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "samayavatI";
			Name = "సమయవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAcIkRtavadanA : Rule
	{
		public sAcIkRtavadanA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "య", "భ", "గా", }, new string[] { "త", "న", "భ", "స", }, new string[] { "న", "య", "భ", "గా", }, new string[] { "త", "న", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "sAcIkRtavadanA";
			Name = "సాచీకృతవదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zukAvalI : Rule
	{
		public zukAvalI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "న", "జ", "ర", "గ", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "న", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "zukAvalI";
			Name = "శుకావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class RddhiH : Rule
	{
		public RddhiH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "RddhiH";
			Name = "ఋద్ధిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sammadAkrAntA : Rule
	{
		public sammadAkrAntA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "స", "జ", "ర", "గా", }, new string[] { "స", "స", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "ర", "గా", }, new string[] { "స", "స", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "sammadAkrAntA";
			Name = "సమ్మదాక్రాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aparavaktram : Rule
	{
		public aparavaktram()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "వ", }, new string[] { "న", "జ", "జ", "ర", }, new string[] { "న", "న", "ర", "వ", }, new string[] { "న", "జ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "aparavaktram";
			Name = "అపరవక్త్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aparaprINitA : Rule
	{
		public aparaprINitA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "స", "త", "త", "గ", }, new string[] { "న", "న", "త", "త", "గ", }, new string[] { "న", "న", "స", "త", "త", "గ", }, new string[] { "న", "న", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "aparaprINitA";
			Name = "అపరప్రీణితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sundarI_1 : Rule
	{
		public sundarI_1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "ర", "వ", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "స", "భ", "ర", "వ", }, new string[] { "స", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sundarI_1";
			Name = "సున్దరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class surADhyA : Rule
	{
		public surADhyA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "ర", "య", }, new string[] { "మ", "స", "జ", "గా", }, new string[] { "న", "న", "ర", "య", }, new string[] { "మ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "surADhyA";
			Name = "సురాఢ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sundarI : Rule
	{
		public sundarI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "స", "జ", "గ", }, new string[] { "స", "భ", "ర", "వ", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "స", "భ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "sundarI";
			Name = "సున్దరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rucimukhI : Rule
	{
		public rucimukhI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "స", "స", "గ", }, new string[] { "న", "న", "భ", "స", "గ", }, new string[] { "న", "న", "స", "స", "గ", }, new string[] { "న", "న", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "rucimukhI";
			Name = "రుచిముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class navanIlatA : Rule
	{
		public navanIlatA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "స", "జ", "గ", }, new string[] { "స", "భ", "జ", "ర", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "స", "భ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "navanIlatA";
			Name = "నవనీలతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zAlA : Rule
	{
		public zAlA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "zAlA";
			Name = "శాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class apramAthinI : Rule
	{
		public apramAthinI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ", "ర", "య", }, new string[] { "న", "జ", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "న", "జ", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "apramAthinI";
			Name = "అప్రమాథినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class naTakaH : Rule
	{
		public naTakaH()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "స", "స", "స", }, new string[] { "త", "జ", "జ", "వ", }, new string[] { "స", "స", "స", "స", }, new string[] { "త", "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "naTakaH";
			Name = "నటకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sudhA : Rule
	{
		public sudhA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గ", }, new string[] { "స", "భ", "ర", "వ", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "స", "భ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "sudhA";
			Name = "సుధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirmadhuvAri : Rule
	{
		public nirmadhuvAri()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "భ", "ర", "స", "ల", }, new string[] { "స", "జ", "స", "జ", "గ", }, new string[] { "త", "భ", "ర", "స", "ల", }, new string[] { "స", "జ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "nirmadhuvAri";
			Name = "నిర్మధువారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anUpakam : Rule
	{
		public anUpakam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "జ", "జ", "ర", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "న", "జ", "జ", "ర", }, new string[] { "స", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "anUpakam";
			Name = "అనూపకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ratAkhyAnakI : Rule
	{
		public ratAkhyAnakI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "ratAkhyAnakI";
			Name = "రతాఖ్యానకీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class surahitA : Rule
	{
		public surahitA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "న", "స", "స", "గ", }, new string[] { "త", "న", "న", "న", "గ", }, new string[] { "న", "న", "స", "స", "గ", }, new string[] { "త", "న", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "surahitA";
			Name = "సురహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saurabhakam : Rule
	{
		public saurabhakam()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "జ", "స", "ల", }, new string[] { "న", "స", "జ", "గ", }, new string[] { "ర", "న", "భ", "గ", }, new string[] { "స", "జ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "saurabhakam";
			Name = "సౌరభకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class padmAvatI_1 : Rule
	{
		public padmAvatI_1()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "జ", "స", "స", "గ", }, new string[] { "త", "భ", "జ", "య", }, new string[] { "స", "జ", "స", "స", "గ", }, new string[] { "త", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "padmAvatI_1";
			Name = "పద్మావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class padmAvatI : Rule
	{
		public padmAvatI()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.ArdhaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "భ", "జ", "య", }, new string[] { "స", "జ", "స", "స", "గ", }, new string[] { "త", "భ", "జ", "య", }, new string[] { "స", "జ", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "padmAvatI";
			Name = "పద్మావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rAmA : Rule
	{
		public rAmA()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.VishamaVruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "rAmA";
			Name = "రామా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class snu : Rule
	{
		public snu()
		{
			Lines = 4;
			Threshold = 1;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ల" } };
			Yati = new int[][] { };

			Identifier = "snu";
			Name = "స్ను(క్షితి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class madhu : Rule
	{
		public madhu()
		{
			Lines = 4;
			Threshold = 2;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "లల" } };
			Yati = new int[][] { };

			Identifier = "madhu";
			Name = "మధు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mahI : Rule
	{
		public mahI()
		{
			Lines = 4;
			Threshold = 2;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "వ" } };
			Yati = new int[][] { };

			Identifier = "mahI";
			Name = "మహీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cAru : Rule
	{
		public cAru()
		{
			Lines = 4;
			Threshold = 2;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "హ" } };
			Yati = new int[][] { };

			Identifier = "cAru";
			Name = "చారు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pAJcAli : Rule
	{
		public pAJcAli()
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

			Rules = new string[][] { new string[] { "త" } };
			Yati = new int[][] { };

			Identifier = "pAJcAli";
			Name = "పాఞ్చాలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class balAkA : Rule
	{
		public balAkA()
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

			Rules = new string[][] { new string[] { "య" } };
			Yati = new int[][] { };

			Identifier = "balAkA";
			Name = "బలాకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class haraNi : Rule
	{
		public haraNi()
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

			Rules = new string[][] { new string[] { "న" } };
			Yati = new int[][] { };

			Identifier = "haraNi";
			Name = "హరణి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class ramaNaH :Rule 
	{ 
		public ramaNaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స"}};
			Yati = new int[][]{};
		
			Identifier = "ramaNaH";
			Name = "రమణః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class mandari : Rule
	{
		public mandari()
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

			Rules = new string[][] { new string[] { "భ" } };
			Yati = new int[][] { };

			Identifier = "mandari";
			Name = "మన్దరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mRgendu : Rule
	{
		public mRgendu()
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

			Rules = new string[][] { new string[] { "జ" } };
			Yati = new int[][] { };

			Identifier = "mRgendu";
			Name = "మృగేన్దు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class kAru : Rule
	{
		public kAru()
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

			Rules = new string[][] { new string[] { "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "kAru";
			Name = "కారు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dolA : Rule
	{
		public dolA()
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

			Rules = new string[][] { new string[] { "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "dolA";
			Name = "దోలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}


	public class nandaH : Rule
	{
		public nandaH()
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

			Rules = new string[][] { new string[] { "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "nandaH";
			Name = "నన్దః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class satI : Rule
	{
		public satI()
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

			Rules = new string[][] { new string[] { "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "satI";
			Name = "సతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mugdham : Rule
	{
		public mugdham()
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

			Rules = new string[][] { new string[] { "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "mugdham";
			Name = "ముగ్ధమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class dharA : Rule
	{
		public dharA()
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

			Rules = new string[][] { new string[] { "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "dharA";
			Name = "ధరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Rju : Rule
	{
		public Rju()
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

			Rules = new string[][] { new string[] { "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "Rju";
			Name = "ఋజు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAri : Rule
	{
		public vAri()
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

			Rules = new string[][] { new string[] { "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "vAri";
			Name = "వారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tAvuri : Rule
	{
		public tAvuri()
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

			Rules = new string[][] { new string[] { "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "tAvuri";
			Name = "తావురి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class anRju : Rule
	{
		public anRju()
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

			Rules = new string[][] { new string[] { "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "anRju";
			Name = "అనృజు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhAri : Rule
	{
		public dhAri()
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

			Rules = new string[][] { new string[] { "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "dhAri";
			Name = "ధారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hrIH : Rule
	{
		public hrIH()
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

			Rules = new string[][] { new string[] { "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "hrIH";
			Name = "హ్రీః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jatu : Rule
	{
		public jatu()
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

			Rules = new string[][] { new string[] { "స", "లల" } };
			Yati = new int[][] { };

			Identifier = "jatu";
			Name = "జతు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class hAsikA : Rule
	{
		public hAsikA()
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

			Rules = new string[][] { new string[] { "మ", "వ" } };
			Yati = new int[][] { };

			Identifier = "hAsikA";
			Name = "హాసికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chidram : Rule
	{
		public chidram()
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

			Rules = new string[][] { new string[] { "త", "లల" } };
			Yati = new int[][] { };

			Identifier = "chidram";
			Name = "ఛిద్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hali : Rule
	{
		public hali()
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

			Rules = new string[][] { new string[] { "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "hali";
			Name = "హలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zilA : Rule
	{
		public zilA()
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

			Rules = new string[][] { new string[] { "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "zilA";
			Name = "శిలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalki : Rule
	{
		public kalki()
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

			Rules = new string[][] { new string[] { "ర", "లల" } };
			Yati = new int[][] { };

			Identifier = "kalki";
			Name = "కల్కి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vArddhi : Rule
	{
		public vArddhi()
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

			Rules = new string[][] { new string[] { "జ", "హ" } };
			Yati = new int[][] { };

			Identifier = "vArddhi";
			Name = "వార్ద్ధి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class priyA : Rule
	{
		public priyA()
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

			Rules = new string[][] { new string[] { "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "priyA";
			Name = "ప్రియా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varIyaH : Rule
	{
		public varIyaH()
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

			Rules = new string[][] { new string[] { "య", "లల" } };
			Yati = new int[][] { };

			Identifier = "varIyaH";
			Name = "వరీయః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalali : Rule
	{
		public kalali()
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

			Rules = new string[][] { new string[] { "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "kalali";
			Name = "కలలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nArI : Rule
	{
		public nArI()
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

			Rules = new string[][] { new string[] { "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "nArI";
			Name = "నరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class lolam : Rule
	{
		public lolam()
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

			Rules = new string[][] { new string[] { "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "lolam";
			Name = "లోలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nAlI : Rule
	{
		public nAlI()
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

			Rules = new string[][] { new string[] { "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "nAlI";
			Name = "నాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viT : Rule
	{
		public viT()
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

			Rules = new string[][] { new string[] { "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "viT";
			Name = "విట్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class kumbhAri : Rule
	{
		public kumbhAri()
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

			Rules = new string[][] { new string[] { "మ", "హ" } };
			Yati = new int[][] { };

			Identifier = "kumbhAri";
			Name = "కుమ్భారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kSut : Rule
	{
		public kSut()
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

			Rules = new string[][] { new string[] { "భ", "లల" } };
			Yati = new int[][] { };

			Identifier = "kSut";
			Name = "క్షుత్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAlInam : Rule
	{
		public mAlInam()
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

			Rules = new string[][] { new string[] { "మ", "లల" } };
			Yati = new int[][] { };

			Identifier = "mAlInam";
			Name = "మాలీనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kSupam : Rule
	{
		public kSupam()
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

			Rules = new string[][] { new string[] { "జ", "లల" } };
			Yati = new int[][] { };

			Identifier = "kSupam";
			Name = "క్షుపమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kiJjalki : Rule
	{
		public kiJjalki()
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

			Rules = new string[][] { new string[] { "త", "హ" } };
			Yati = new int[][] { };

			Identifier = "kiJjalki";
			Name = "కిఞ్జల్కి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class pAli : Rule
	{
		public pAli()
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

			Rules = new string[][] { new string[] { "స", "హ" } };
			Yati = new int[][] { };

			Identifier = "pAli";
			Name = "పాలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}


	public class pAMzu : Rule
	{
		public pAMzu()
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

			Rules = new string[][] { new string[] { "న", "హ" } };
			Yati = new int[][] { };

			Identifier = "pAMzu";
			Name = "పాంశు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vainasam : Rule
	{
		public vainasam()
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

			Rules = new string[][] { new string[] { "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "vainasam";
			Name = "వైనసమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class bhrUH : Rule
	{
		public bhrUH()
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

			Rules = new string[][] { new string[] { "య", "హ" } };
			Yati = new int[][] { };

			Identifier = "bhrUH";
			Name = "భ్రూః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class niskA : Rule
	{
		public niskA()
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

			Rules = new string[][] { new string[] { "మ", "స" } };
			Yati = new int[][] { };

			Identifier = "niskA";
			Name = "నిస్కా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rADhi : Rule
	{
		public rADhi()
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

			Rules = new string[][] { new string[] { "భ", "త" } };
			Yati = new int[][] { };

			Identifier = "rADhi";
			Name = "రాఢి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}


	public class hATakazAli : Rule
	{
		public hATakazAli()
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

			Rules = new string[][] { new string[] { "త", "జ" } };
			Yati = new int[][] { };

			Identifier = "hATakazAli";
			Name = "హాటకశాలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAlatikA : Rule
	{
		public mAlatikA()
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

			Rules = new string[][] { new string[] { "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "mAlatikA";
			Name = "మాలతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sudAyi : Rule
	{
		public sudAyi()
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

			Rules = new string[][] { new string[] { "జ", "న" } };
			Yati = new int[][] { };

			Identifier = "sudAyi";
			Name = "సుదాయి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maGkuram : Rule
	{
		public maGkuram()
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

			Rules = new string[][] { new string[] { "మ", "జ" } };
			Yati = new int[][] { };

			Identifier = "maGkuram";
			Name = "మఙ్కురమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mRdukIlA : Rule
	{
		public mRdukIlA()
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

			Rules = new string[][] { new string[] { "స", "ర" } };
			Yati = new int[][] { };

			Identifier = "mRdukIlA";
			Name = "మృదుకీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAhUti : Rule
	{
		public sAhUti()
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

			Rules = new string[][] { new string[] { "మ", "త" } };
			Yati = new int[][] { };

			Identifier = "sAhUti";
			Name = "సాహూతి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vidyullekhA :Rule 
	{ 
		public vidyullekhA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","మ"}};
			Yati = new int[][]{};
		
			Identifier = "vidyullekhA";
			Name = "విద్యుల్లేఖా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class DhuNDhi : Rule
	{
		public DhuNDhi()
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

			Rules = new string[][] { new string[] { "స", "త" } };
			Yati = new int[][] { };

			Identifier = "DhuNDhi";
			Name = "ఢుణ్ఢి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nandi : Rule
	{
		public nandi()
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

			Rules = new string[][] { new string[] { "భ", "భ" } };
			Yati = new int[][] { };

			Identifier = "nandi";
			Name = "నన్ది(బిల్వ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vijohA : Rule
	{
		public vijohA()
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

			Rules = new string[][] { new string[] { "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "vijohA";
			Name = "విజోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mazagA : Rule
	{
		public mazagA()
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

			Rules = new string[][] { new string[] { "య", "స" } };
			Yati = new int[][] { };

			Identifier = "mazagA";
			Name = "మశగా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tantrI : Rule
	{
		public tantrI()
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

			Rules = new string[][] { new string[] { "మ", "య" } };
			Yati = new int[][] { };

			Identifier = "tantrI";
			Name = "తన్త్రీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class nirasikA : Rule
	{
		public nirasikA()
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

			Rules = new string[][] { new string[] { "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "nirasikA";
			Name = "నిరసికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class guNavatI : Rule
	{
		public guNavatI()
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

			Rules = new string[][] { new string[] { "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "guNavatI";
			Name = "గుణవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mantrikA : Rule
	{
		public mantrikA()
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

			Rules = new string[][] { new string[] { "ర", "త" } };
			Yati = new int[][] { };

			Identifier = "mantrikA";
			Name = "మన్త్రికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class manthAnakam : Rule
	{
		public manthAnakam()
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

			Rules = new string[][] { new string[] { "త", "త" } };
			Yati = new int[][] { };

			Identifier = "manthAnakam";
			Name = "మన్థానకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saurabhi : Rule
	{
		public saurabhi()
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

			Rules = new string[][] { new string[] { "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "saurabhi";
			Name = "సౌరభి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pikAlI : Rule
	{
		public pikAlI()
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

			Rules = new string[][] { new string[] { "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "pikAlI";
			Name = "పికాలీ(చంద్రమౌళి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratari : Rule
	{
		public pratari()
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

			Rules = new string[][] { new string[] { "ర", "న" } };
			Yati = new int[][] { };

			Identifier = "pratari";
			Name = "ప్రతరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kSamApAli : Rule
	{
		public kSamApAli()
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

			Rules = new string[][] { new string[] { "జ", "త" } };
			Yati = new int[][] { };

			Identifier = "kSamApAli";
			Name = "క్షమాపాలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upavali : Rule
	{
		public upavali()
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

			Rules = new string[][] { new string[] { "న", "న" } };
			Yati = new int[][] { };

			Identifier = "upavali";
			Name = "ఉపవలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAvaTu : Rule
	{
		public sAvaTu()
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

			Rules = new string[][] { new string[] { "జ", "భ" } };
			Yati = new int[][] { };

			Identifier = "sAvaTu";
			Name = "సావటు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vabhrUH : Rule
	{
		public vabhrUH()
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

			Rules = new string[][] { new string[] { "త", "మ" } };
			Yati = new int[][] { };

			Identifier = "vabhrUH";
			Name = "వభ్రూః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaMsari : Rule
	{
		public kaMsari()
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

			Rules = new string[][] { new string[] { "మ", "భ" } };
			Yati = new int[][] { };

			Identifier = "kaMsari";
			Name = "కంసరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sari : Rule
	{
		public sari()
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

			Rules = new string[][] { new string[] { "న", "స" } };
			Yati = new int[][] { };

			Identifier = "sari";
			Name = "సరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class valImukhI : Rule
	{
		public valImukhI()
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

			Rules = new string[][] { new string[] { "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "valImukhI";
			Name = "వలీముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karmadA : Rule
	{
		public karmadA()
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

			Rules = new string[][] { new string[] { "ర", "స" } };
			Yati = new int[][] { };

			Identifier = "karmadA";
			Name = "కర్మదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kareNuH : Rule
	{
		public kareNuH()
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

			Rules = new string[][] { new string[] { "ర", "మ" } };
			Yati = new int[][] { };

			Identifier = "kareNuH";
			Name = "కరేణుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kamanI : Rule
	{
		public kamanI()
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

			Rules = new string[][] { new string[] { "స", "య" } };
			Yati = new int[][] { };

			Identifier = "kamanI";
			Name = "కమనీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuhI : Rule
	{
		public kuhI()
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

			Rules = new string[][] { new string[] { "జ", "స" } };
			Yati = new int[][] { };

			Identifier = "kuhI";
			Name = "కుహీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class panthA : Rule
	{
		public panthA()
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

			Rules = new string[][] { new string[] { "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "panthA";
			Name = "పన్థా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class sthAlI : Rule
	{
		public sthAlI()
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

			Rules = new string[][] { new string[] { "త", "ర" } };
			Yati = new int[][] { };

			Identifier = "sthAlI";
			Name = "స్థాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class puTamardi : Rule
	{
		public puTamardi()
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

			Rules = new string[][] { new string[] { "న", "జ" } };
			Yati = new int[][] { };

			Identifier = "puTamardi";
			Name = "పుటమర్ది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madhumArakam : Rule
	{
		public madhumArakam()
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

			Rules = new string[][] { new string[] { "స", "జ" } };
			Yati = new int[][] { };

			Identifier = "madhumArakam";
			Name = "మధుమారకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class indhA : Rule
	{
		public indhA()
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

			Rules = new string[][] { new string[] { "త", "భ" } };
			Yati = new int[][] { };

			Identifier = "indhA";
			Name = "ఇన్ధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sopadhi : Rule
	{
		public sopadhi()
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

			Rules = new string[][] { new string[] { "ర", "భ" } };
			Yati = new int[][] { };

			Identifier = "sopadhi";
			Name = "సోపధి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sindhurayA : Rule
	{
		public sindhurayA()
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

			Rules = new string[][] { new string[] { "భ", "మ" } };
			Yati = new int[][] { };

			Identifier = "sindhurayA";
			Name = "సిన్ధురయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kacchapI : Rule
	{
		public kacchapI()
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

			Rules = new string[][] { new string[] { "య", "ర" } };
			Yati = new int[][] { };

			Identifier = "kacchapI";
			Name = "కచ్ఛపీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaJjA : Rule
	{
		public kaJjA()
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

			Rules = new string[][] { new string[] { "జ", "మ" } };
			Yati = new int[][] { };

			Identifier = "kaJjA";
			Name = "కఞ్జా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prothA : Rule
	{
		public prothA()
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

			Rules = new string[][] { new string[] { "మ", "న" } };
			Yati = new int[][] { };

			Identifier = "prothA";
			Name = "ప్రోథా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class somazruti : Rule
	{
		public somazruti()
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

			Rules = new string[][] { new string[] { "య", "భ" } };
			Yati = new int[][] { };

			Identifier = "somazruti";
			Name = "సోమశ్రుతి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class amati : Rule
	{
		public amati()
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

			Rules = new string[][] { new string[] { "భ", "న" } };
			Yati = new int[][] { };

			Identifier = "amati";
			Name = "అమతి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arti : Rule
	{
		public arti()
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

			Rules = new string[][] { new string[] { "య", "న" } };
			Yati = new int[][] { };

			Identifier = "arti";
			Name = "అర్తి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vRttahAri : Rule
	{
		public vRttahAri()
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

			Rules = new string[][] { new string[] { "య", "జ" } };
			Yati = new int[][] { };

			Identifier = "vRttahAri";
			Name = "వృత్తహారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arajaskA : Rule
	{
		public arajaskA()
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

			Rules = new string[][] { new string[] { "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "arajaskA";
			Name = "అరజస్కా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class abhikhyA : Rule
	{
		public abhikhyA()
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

			Rules = new string[][] { new string[] { "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "abhikhyA";
			Name = "అభిఖ్యా(సలిల)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zaGkhadyuti : Rule
	{
		public zaGkhadyuti ()
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

			Rules = new string[][] { new string[] { "స" , "భ" } };
			Yati = new int[][] { };

			Identifier = "zaGkhadyuti";
			Name = "శఙ్ఖద్యుతి";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}*/
	public class visasi : Rule
	{
		public visasi()
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

			Rules = new string[][] { new string[] { "స", "న" } };
			Yati = new int[][] { };

			Identifier = "visasi";
			Name = "విససి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anibhRtam : Rule
	{
		public anibhRtam()
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

			Rules = new string[][] { new string[] { "న", "త" } };
			Yati = new int[][] { };

			Identifier = "anibhRtam";
			Name = "అనిభృతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class atikali : Rule
	{
		public atikali()
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

			Rules = new string[][] { new string[] { "త", "న" } };
			Yati = new int[][] { };

			Identifier = "atikali";
			Name = "అతికలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vindu : Rule
	{
		public vindu()
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

			Rules = new string[][] { new string[] { "య", "త" } };
			Yati = new int[][] { };

			Identifier = "vindu";
			Name = "విన్దు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zunakam : Rule
	{
		public zunakam()
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

			Rules = new string[][] { new string[] { "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "zunakam";
			Name = "శునకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class avoDhA : Rule
	{
		public avoDhA()
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

			Rules = new string[][] { new string[] { "మ", "ర" } };
			Yati = new int[][] { };

			Identifier = "avoDhA";
			Name = "అవోఢా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ayamitam : Rule
	{
		public ayamitam()
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

			Rules = new string[][] { new string[] { "న", "భ" } };
			Yati = new int[][] { };

			Identifier = "ayamitam";
			Name = "అయమితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mahodhikA : Rule
	{
		public mahodhikA()
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

			Rules = new string[][] { new string[] { "జ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "mahodhikA";
			Name = "మహోధికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratardi : Rule
	{
		public pratardi()
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

			Rules = new string[][] { new string[] { "జ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "pratardi";
			Name = "ప్రతర్ది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varajApi : Rule
	{
		public varajApi()
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

			Rules = new string[][] { new string[] { "భ", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "varajApi";
			Name = "వరజాపి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vyAhAri : Rule
	{
		public vyAhAri()
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

			Rules = new string[][] { new string[] { "భ", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "vyAhAri";
			Name = "వ్యాహారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalpamukhI : Rule
	{
		public kalpamukhI()
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

			Rules = new string[][] { new string[] { "భ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalpamukhI";
			Name = "కల్పముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mahonmukhI : Rule
	{
		public mahonmukhI()
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

			Rules = new string[][] { new string[] { "మ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "mahonmukhI";
			Name = "మహోన్ముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirvAdhikA : Rule
	{
		public nirvAdhikA()
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

			Rules = new string[][] { new string[] { "త", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "nirvAdhikA";
			Name = "నిర్వాధికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anAsAdi : Rule
	{
		public anAsAdi()
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

			Rules = new string[][] { new string[] { "ర", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "anAsAdi";
			Name = "అనాసాది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmoddhatA : Rule
	{
		public kAmoddhatA()
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

			Rules = new string[][] { new string[] { "త", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "kAmoddhatA";
			Name = "కామోద్ధతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kroDAntikam : Rule
	{
		public kroDAntikam()
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

			Rules = new string[][] { new string[] { "త", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "kroDAntikam";
			Name = "క్రోడాన్తికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaMsAsAri : Rule
	{
		public kaMsAsAri()
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

			Rules = new string[][] { new string[] { "య", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "kaMsAsAri";
			Name = "కంసాసారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ammethI : Rule
	{
		public ammethI()
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

			Rules = new string[][] { new string[] { "మ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "ammethI";
			Name = "అమ్మేథీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anu : Rule
	{
		public anu()
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

			Rules = new string[][] { new string[] { "న", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "anu";
			Name = "అను";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mahoddhatA : Rule
	{
		public mahoddhatA()
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

			Rules = new string[][] { new string[] { "య", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "mahoddhatA";
			Name = "మహోద్ధతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class madhumatI :Rule 
	{ 
		public madhumatI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "madhumatI";
			Name = "మధుమతీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class mahanIyA : Rule
	{
		public mahanIyA()
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

			Rules = new string[][] { new string[] { "య", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "mahanIyA";
			Name = "మహనీయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class proJchitA : Rule
	{
		public proJchitA()
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

			Rules = new string[][] { new string[] { "స", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "proJchitA";
			Name = "ప్రోఞ్ఛితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsaki : Rule
	{
		public vAsaki()
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

			Rules = new string[][] { new string[] { "న", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "vAsaki";
			Name = "వాసకి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAhI : Rule
	{
		public kAhI()
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

			Rules = new string[][] { new string[] { "స", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "kAhI";
			Name = "కాహీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varkaritA : Rule
	{
		public varkaritA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "varkaritA";
			Name = "వర్కరితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIhArI : Rule
	{
		public nIhArI()
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

			Rules = new string[][] { new string[] { "మ", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "nIhArI";
			Name = "నీహారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maNimukhI : Rule
	{
		public maNimukhI()
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

			Rules = new string[][] { new string[] { "న", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "maNimukhI";
			Name = "మణిముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class puraTi : Rule
	{
		public puraTi()
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

			Rules = new string[][] { new string[] { "న", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "puraTi";
			Name = "పురటి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jAsari : Rule
	{
		public jAsari()
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

			Rules = new string[][] { new string[] { "భ", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "jAsari";
			Name = "జాసరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ahatiH : Rule
	{
		public ahatiH()
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

			Rules = new string[][] { new string[] { "య", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "ahatiH";
			Name = "అహతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ahari : Rule
	{
		public ahari()
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

			Rules = new string[][] { new string[] { "న", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "ahari";
			Name = "అహరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varddhiSNu : Rule
	{
		public varddhiSNu()
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

			Rules = new string[][] { new string[] { "త", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "varddhiSNu";
			Name = "వర్ద్ధిష్ణు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ziprA : Rule
	{
		public ziprA()
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

			Rules = new string[][] { new string[] { "మ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "ziprA";
			Name = "శిప్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varazazi : Rule
	{
		public varazazi()
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

			Rules = new string[][] { new string[] { "ర", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "varazazi";
			Name = "వరశశి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class cAmaram :Rule 
	{ 
		public cAmaram()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "cAmaram";
			Name = "చామరమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class saralAGghri : Rule
	{
		public saralAGghri()
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

			Rules = new string[][] { new string[] { "త", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "saralAGghri";
			Name = "సరలాఙ్ఘ్రి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class yamanakam : Rule
	{
		public yamanakam()
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

			Rules = new string[][] { new string[] { "స", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "yamanakam";
			Name = "యమనకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ahiMsA : Rule
	{
		public ahiMsA()
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

			Rules = new string[][] { new string[] { "ర", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "ahiMsA";
			Name = "అహింసా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class kumAralalitA :Rule 
	{ 
		public kumAralalitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "kumAralalitA";
			Name = "కుమారలలితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kAlambI : Rule
	{
		public kAlambI()
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

			Rules = new string[][] { new string[] { "మ", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "kAlambI";
			Name = "కాలమ్బీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nimnAzayA : Rule
	{
		public nimnAzayA()
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

			Rules = new string[][] { new string[] { "త", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "nimnAzayA";
			Name = "నిమ్నాశయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ulapA : Rule
	{
		public ulapA()
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

			Rules = new string[][] { new string[] { "భ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "ulapA";
			Name = "ఉలపా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parabhRtam : Rule
	{
		public parabhRtam()
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

			Rules = new string[][] { new string[] { "న", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "parabhRtam";
			Name = "పరభృతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kharviNI : Rule
	{
		public kharviNI()
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

			Rules = new string[][] { new string[] { "ర", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "kharviNI";
			Name = "ఖర్విణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuThArikA : Rule
	{
		public kuThArikA()
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

			Rules = new string[][] { new string[] { "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "kuThArikA";
			Name = "కుఠారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Upikam : Rule
	{
		public Upikam()
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

			Rules = new string[][] { new string[] { "య", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "Upikam";
			Name = "ఊపికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class staradhi : Rule
	{
		public staradhi()
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

			Rules = new string[][] { new string[] { "జ", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "staradhi";
			Name = "స్తరధి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kezavatI : Rule
	{
		public kezavatI()
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

			Rules = new string[][] { new string[] { "య", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kezavatI";
			Name = "కేశవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parabhAnu : Rule
	{
		public parabhAnu()
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

			Rules = new string[][] { new string[] { "య", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "parabhAnu";
			Name = "పరభాను";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amatiH : Rule
	{
		public amatiH()
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

			Rules = new string[][] { new string[] { "మ", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "amatiH";
			Name = "అమతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kharpari : Rule
	{
		public kharpari()
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

			Rules = new string[][] { new string[] { "జ", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "kharpari";
			Name = "ఖర్పరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kharakarA : Rule
	{
		public kharakarA()
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

			Rules = new string[][] { new string[] { "న", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "kharakarA";
			Name = "ఖరకరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kiNapA : Rule
	{
		public kiNapA()
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

			Rules = new string[][] { new string[] { "భ", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "kiNapA";
			Name = "కిణపా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upohA : Rule
	{
		public upohA()
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

			Rules = new string[][] { new string[] { "య", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "upohA";
			Name = "ఉపోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kizalayam : Rule
	{
		public kizalayam()
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

			Rules = new string[][] { new string[] { "న", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "kizalayam";
			Name = "కిశలయమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paurasari : Rule
	{
		public paurasari()
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

			Rules = new string[][] { new string[] { "భ", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "paurasari";
			Name = "పౌరసరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upodari : Rule
	{
		public upodari()
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

			Rules = new string[][] { new string[] { "జ", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "upodari";
			Name = "ఉపోదరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kozi : Rule
	{
		public kozi()
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

			Rules = new string[][] { new string[] { "భ", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "kozi";
			Name = "కోశి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vahirvali : Rule
	{
		public vahirvali()
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

			Rules = new string[][] { new string[] { "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vahirvali";
			Name = "వహిర్వలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhImArjanam : Rule
	{
		public bhImArjanam()
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

			Rules = new string[][] { new string[] { "త", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhImArjanam";
			Name = "భీమార్జనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saurakAntA : Rule
	{
		public saurakAntA()
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

			Rules = new string[][] { new string[] { "ర", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "saurakAntA";
			Name = "సౌరకాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zaragItiH : Rule
	{
		public zaragItiH()
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

			Rules = new string[][] { new string[] { "ర", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "zaragItiH";
			Name = "శరగీతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kirmIram : Rule
	{
		public kirmIram()
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

			Rules = new string[][] { new string[] { "మ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "kirmIram";
			Name = "కిర్మీరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karabhit : Rule
	{
		public karabhit()
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

			Rules = new string[][] { new string[] { "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "karabhit";
			Name = "కరభిత్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhUrimadhu : Rule
	{
		public bhUrimadhu()
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

			Rules = new string[][] { new string[] { "మ", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "bhUrimadhu";
			Name = "భూరిమధు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class bhUridhAmA :Rule 
	{ 
		public bhUridhAmA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "bhUridhAmA";
			Name = "భూరిధామా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class paddhari : Rule
	{
		public paddhari()
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

			Rules = new string[][] { new string[] { "య", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "paddhari";
			Name = "పద్ధరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vRndA : Rule
	{
		public vRndA()
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

			Rules = new string[][] { new string[] { "త", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "vRndA";
			Name = "వృన్దా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class alAlApi : Rule
	{
		public alAlApi()
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

			Rules = new string[][] { new string[] { "స", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "alAlApi";
			Name = "అలాలాపి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuradi : Rule
	{
		public kuradi()
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

			Rules = new string[][] { new string[] { "జ", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "kuradi";
			Name = "కురది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIravaTu : Rule
	{
		public vIravaTu()
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

			Rules = new string[][] { new string[] { "న", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "vIravaTu";
			Name = "వీరవటు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhUrivasu : Rule
	{
		public bhUrivasu()
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

			Rules = new string[][] { new string[] { "య", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "bhUrivasu";
			Name = "భూరివసు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class madalekhA :Rule 
	{ 
		public madalekhA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "madalekhA";
			Name = "మదలేఖా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class lolatanu : Rule
	{
		public lolatanu()
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

			Rules = new string[][] { new string[] { "స", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "lolatanu";
			Name = "లోలతను";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kArpikA : Rule
	{
		public kArpikA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "kArpikA";
			Name = "కార్పికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zambUkaH : Rule
	{
		public zambUkaH()
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

			Rules = new string[][] { new string[] { "స", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "zambUkaH";
			Name = "శమ్బూకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virohi : Rule
	{
		public virohi()
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

			Rules = new string[][] { new string[] { "జ", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "virohi";
			Name = "విరోహి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zantanu : Rule
	{
		public zantanu()
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

			Rules = new string[][] { new string[] { "భ", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "zantanu";
			Name = "శన్తను";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaThodgatA : Rule
	{
		public kaThodgatA()
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

			Rules = new string[][] { new string[] { "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kaThodgatA";
			Name = "కఠోద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class padyA :Rule 
	{ 
		public padyA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","మ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "padyA";
			Name = "పద్యా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class undari : Rule
	{
		public undari()
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

			Rules = new string[][] { new string[] { "భ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "undari";
			Name = "ఉన్దరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sthUlA : Rule
	{
		public sthUlA()
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

			Rules = new string[][] { new string[] { "త", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "sthUlA";
			Name = "స్థూలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bahulayA : Rule
	{
		public bahulayA()
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

			Rules = new string[][] { new string[] { "ర", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "bahulayA";
			Name = "బహులయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prahANaH : Rule
	{
		public prahANaH()
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

			Rules = new string[][] { new string[] { "య", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "prahANaH";
			Name = "ప్రహాణః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pUrNA : Rule
	{
		public pUrNA()
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

			Rules = new string[][] { new string[] { "త", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "pUrNA";
			Name = "పూర్ణా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class suri : Rule
	{
		public suri()
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

			Rules = new string[][] { new string[] { "న", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "suri";
			Name = "సురి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class narhi : Rule
	{
		public narhi()
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

			Rules = new string[][] { new string[] { "య", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "narhi";
			Name = "నర్హి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hindIram : Rule
	{
		public hindIram()
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

			Rules = new string[][] { new string[] { "మ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "hindIram";
			Name = "హిన్దీరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rasadhAri : Rule
	{
		public rasadhAri()
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

			Rules = new string[][] { new string[] { "స", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "rasadhAri";
			Name = "రసధారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class methikA : Rule
	{
		public methikA()
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

			Rules = new string[][] { new string[] { "ర", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "methikA";
			Name = "మేథికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sumohitA : Rule
	{
		public sumohitA()
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

			Rules = new string[][] { new string[] { "జ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sumohitA";
			Name = "సుమోహితా(పద్యా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mInapadI : Rule
	{
		public mInapadI()
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

			Rules = new string[][] { new string[] { "భ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "mInapadI";
			Name = "మీనపదీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class svanakarI :Rule 
	{ 
		public svanakarI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "svanakarI";
			Name = "స్వనకరీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class nandathu : Rule
	{
		public nandathu()
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

			Rules = new string[][] { new string[] { "భ", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "nandathu";
			Name = "నన్దథు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hoDapadA : Rule
	{
		public hoDapadA()
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

			Rules = new string[][] { new string[] { "భ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "hoDapadA";
			Name = "హోడపదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class holA : Rule
	{
		public holA()
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

			Rules = new string[][] { new string[] { "న", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "holA";
			Name = "హోలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hIram : Rule
	{
		public hIram()
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

			Rules = new string[][] { new string[] { "త", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "hIram";
			Name = "హీరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class svidA :Rule 
	{ 
		public svidA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "svidA";
			Name = "స్విదా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/

	public class sAmikA : Rule
	{
		public sAmikA()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "sAmikA";
			Name = "సామికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maulisrak : Rule
	{
		public maulisrak()
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

			Rules = new string[][] { new string[] { "మ", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "maulisrak";
			Name = "మౌలిస్రక్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gRhiNI : Rule
	{
		public gRhiNI()
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

			Rules = new string[][] { new string[] { "స", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "gRhiNI";
			Name = "గృహిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhanadhari : Rule
	{
		public dhanadhari()
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

			Rules = new string[][] { new string[] { "స", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "dhanadhari";
			Name = "ధనధరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mayUrI : Rule
	{
		public mayUrI()
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

			Rules = new string[][] { new string[] { "య", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "mayUrI";
			Name = "మయూరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class haMsamAlA : Rule
	{
		public haMsamAlA()
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

			Rules = new string[][] { new string[] { "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "haMsamAlA";
			Name = "హంసమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gUrNikA : Rule
	{
		public gUrNikA()
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

			Rules = new string[][] { new string[] { "ర", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "gUrNikA";
			Name = "గూర్ణికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class RcA : Rule
	{
		public RcA()
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

			Rules = new string[][] { new string[] { "జ", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "RcA";
			Name = "ఋచా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class guJjA : Rule
	{
		public guJjA()
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

			Rules = new string[][] { new string[] { "త", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "guJjA";
			Name = "గుఞ్జా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vedhAH : Rule
	{
		public vedhAH()
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

			Rules = new string[][] { new string[] { "త", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "vedhAH";
			Name = "వేధాః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mauralikam : Rule
	{
		public mauralikam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "mauralikam";
			Name = "మౌరలికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class godhi : Rule
	{
		public godhi()
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

			Rules = new string[][] { new string[] { "స", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "godhi";
			Name = "గోధి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class harSiNI : Rule
	{
		public harSiNI()
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

			Rules = new string[][] { new string[] { "ర", "భ", "ల" } };
			Yati = new int[][] { };

			Identifier = "harSiNI";
			Name = "హర్షిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vayasyaH : Rule
	{
		public vayasyaH()
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

			Rules = new string[][] { new string[] { "య", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "vayasyaH";
			Name = "వయస్యః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAyAvinI : Rule
	{
		public mAyAvinI()
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

			Rules = new string[][] { new string[] { "స", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "mAyAvinI";
			Name = "మాయావినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zroNI : Rule
	{
		public zroNI()
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

			Rules = new string[][] { new string[] { "జ", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "zroNI";
			Name = "శ్రోణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class devalam : Rule
	{
		public devalam()
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

			Rules = new string[][] { new string[] { "మ", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "devalam";
			Name = "దేవలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mRSTapAdA : Rule
	{
		public mRSTapAdA()
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

			Rules = new string[][] { new string[] { "ర", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "mRSTapAdA";
			Name = "మృష్టపాదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rAjarAjI : Rule
	{
		public rAjarAjI()
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

			Rules = new string[][] { new string[] { "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "rAjarAjI";
			Name = "రాజరాజీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class murajikA : Rule
	{
		public murajikA()
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

			Rules = new string[][] { new string[] { "న", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "murajikA";
			Name = "మురజికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class adhikArI : Rule
	{
		public adhikArI()
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

			Rules = new string[][] { new string[] { "స", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "adhikArI";
			Name = "అధికారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class abhIkam :Rule 
	{ 
		public abhIkam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"య","య","గ"}};
			Yati = new int[][]{};
		
			Identifier = "abhIkam";
			Name = "అభీకమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class muhurA : Rule
	{
		public muhurA()
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

			Rules = new string[][] { new string[] { "స", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "muhurA";
			Name = "ముహురా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class navasarA : Rule
	{
		public navasarA()
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

			Rules = new string[][] { new string[] { "మ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "navasarA";
			Name = "నవసరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ciraruciH : Rule
	{
		public ciraruciH()
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

			Rules = new string[][] { new string[] { "య", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "ciraruciH";
			Name = "చిరరుచిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class acaTu : Rule
	{
		public acaTu()
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

			Rules = new string[][] { new string[] { "న", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "acaTu";
			Name = "అచటు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class doSA : Rule
	{
		public doSA()
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

			Rules = new string[][] { new string[] { "త", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "doSA";
			Name = "దోషా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class muzaki : Rule
	{
		public muzaki()
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

			Rules = new string[][] { new string[] { "త", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "muzaki";
			Name = "ముశకి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class dRtiH :Rule 
	{ 
		public dRtiH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "dRtiH";
			Name = "దృతిః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class purohitA : Rule
	{
		public purohitA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "purohitA";
			Name = "పురోహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class adhIrA : Rule
	{
		public adhIrA()
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

			Rules = new string[][] { new string[] { "భ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "adhIrA";
			Name = "అధీరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sampAkaH : Rule
	{
		public sampAkaH()
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

			Rules = new string[][] { new string[] { "మ", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "sampAkaH";
			Name = "సమ్పాకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sairavI : Rule
	{
		public sairavI()
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

			Rules = new string[][] { new string[] { "ర", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sairavI";
			Name = "సైరవీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ibhabhrAntA : Rule
	{
		public ibhabhrAntA()
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

			Rules = new string[][] { new string[] { "మ", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "ibhabhrAntA";
			Name = "ఇభభ్రాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pAJcAlAGghriH : Rule
	{
		public pAJcAlAGghriH()
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

			Rules = new string[][] { new string[] { "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "pAJcAlAGghriH";
			Name = "పాఞ్చాలాఙ్ఘ్రిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amanA : Rule
	{
		public amanA()
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

			Rules = new string[][] { new string[] { "స", "స", "లల" } };
			Yati = new int[][] { };

			Identifier = "amanA";
			Name = "అమనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kiSku : Rule
	{
		public kiSku()
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

			Rules = new string[][] { new string[] { "త", "త", "హ" } };
			Yati = new int[][] { };

			Identifier = "kiSku";
			Name = "కిష్కు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sindhuk : Rule
	{
		public sindhuk()
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

			Rules = new string[][] { new string[] { "త", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "sindhuk";
			Name = "సిన్ధుక్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gopAvedI : Rule
	{
		public gopAvedI()
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

			Rules = new string[][] { new string[] { "న", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "gopAvedI";
			Name = "గోపావేదీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sRtamadhu : Rule
	{
		public sRtamadhu()
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

			Rules = new string[][] { new string[] { "స", "భ", "లల" } };
			Yati = new int[][] { };

			Identifier = "sRtamadhu";
			Name = "సృతమధు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class digIzaH : Rule
	{
		public digIzaH()
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

			Rules = new string[][] { new string[] { "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "digIzaH";
			Name = "దిగీశః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anRtanarma : Rule
	{
		public anRtanarma()
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

			Rules = new string[][] { new string[] { "స", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "anRtanarma";
			Name = "అనృతనర్మ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class valIkendu : Rule
	{
		public valIkendu()
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

			Rules = new string[][] { new string[] { "స", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "valIkendu";
			Name = "వలీకేన్దు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhASA : Rule
	{
		public bhASA()
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

			Rules = new string[][] { new string[] { "య", "ర", "లల" } };
			Yati = new int[][] { };

			Identifier = "bhASA";
			Name = "భాషా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class samAnikA : Rule
	{
		public samAnikA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "హ" } };
			Yati = new int[][] { };

			Identifier = "samAnikA";
			Name = "సమానికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anirbhAraH : Rule
	{
		public anirbhAraH()
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

			Rules = new string[][] { new string[] { "య", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "anirbhAraH";
			Name = "అనిర్భారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kurarikA : Rule
	{
		public kurarikA()
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

			Rules = new string[][] { new string[] { "న", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "kurarikA";
			Name = "కురరికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vezi : Rule
	{
		public vezi()
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

			Rules = new string[][] { new string[] { "భ", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "vezi";
			Name = "వేశి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nakhapadA : Rule
	{
		public nakhapadA()
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

			Rules = new string[][] { new string[] { "న", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "nakhapadA";
			Name = "నఖపదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vidyunmAlA :Rule 
	{ 
		public vidyunmAlA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","మ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "vidyunmAlA";
			Name = "విద్యున్మాలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class pArAntacArI : Rule
	{
		public pArAntacArI()
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

			Rules = new string[][] { new string[] { "య", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "pArAntacArI";
			Name = "పారాన్తచారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amarandi : Rule
	{
		public amarandi()
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

			Rules = new string[][] { new string[] { "త", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "amarandi";
			Name = "అమరన్ది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nAgAri : Rule
	{
		public nAgAri()
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

			Rules = new string[][] { new string[] { "స", "య", "హ" } };
			Yati = new int[][] { };

			Identifier = "nAgAri";
			Name = "నాగారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ari : Rule
	{
		public ari()
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

			Rules = new string[][] { new string[] { "భ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "ari";
			Name = "అరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kulacAri : Rule
	{
		public kulacAri()
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

			Rules = new string[][] { new string[] { "జ", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "kulacAri";
			Name = "కులచారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidyA : Rule
	{
		public vidyA()
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

			Rules = new string[][] { new string[] { "త", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "vidyA";
			Name = "విద్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lakSmI : Rule
	{
		public lakSmI()
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

			Rules = new string[][] { new string[] { "ర", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "lakSmI";
			Name = "లక్ష్మీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gajagatiH : Rule
	{
		public gajagatiH()
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

			Rules = new string[][] { new string[] { "న", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "gajagatiH";
			Name = "గజగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rudrAlI : Rule
	{
		public rudrAlI()
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

			Rules = new string[][] { new string[] { "న", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "rudrAlI";
			Name = "రుద్రాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paJcazikhA : Rule
	{
		public paJcazikhA()
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

			Rules = new string[][] { new string[] { "స", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "paJcazikhA";
			Name = "పఞ్చశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paJjari : Rule
	{
		public paJjari()
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

			Rules = new string[][] { new string[] { "భ", "మ", "లల" } };
			Yati = new int[][] { };

			Identifier = "paJjari";
			Name = "పఞ్జరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuzakam : Rule
	{
		public kuzakam()
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

			Rules = new string[][] { new string[] { "ర", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "kuzakam";
			Name = "కుశకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class lasadasu : Rule
	{
		public lasadasu ()
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

			Rules = new string[][] { new string[] { "న" , "స" , "వ" } };
			Yati = new int[][] { };

			Identifier = "lasadasu";
			Name = "లసదసు";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}*/
	public class amAnikA : Rule
	{
		public amAnikA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "amAnikA";
			Name = "అమానికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kulAdhArI : Rule
	{
		public kulAdhArI()
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

			Rules = new string[][] { new string[] { "య", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "kulAdhArI";
			Name = "కులాధారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zAkhoTaki :Rule 
	{ 
		public zAkhoTaki()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","మ","లల"}};
			Yati = new int[][]{};
		
			Identifier = "zAkhoTaki";
			Name = "శాఖోటకి";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class vihAvA : Rule
	{
		public vihAvA()
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

			Rules = new string[][] { new string[] { "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "vihAvA";
			Name = "విహావా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kurucarI : Rule
	{
		public kurucarI()
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

			Rules = new string[][] { new string[] { "ర", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kurucarI";
			Name = "కురుచరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaucamAraH : Rule
	{
		public kaucamAraH()
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

			Rules = new string[][] { new string[] { "స", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "kaucamAraH";
			Name = "కౌచమారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pAkali : Rule
	{
		public pAkali()
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

			Rules = new string[][] { new string[] { "న", "ర", "లల" } };
			Yati = new int[][] { };

			Identifier = "pAkali";
			Name = "పాకలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arAli : Rule
	{
		public arAli()
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

			Rules = new string[][] { new string[] { "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "arAli";
			Name = "అరాలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kRtayuH : Rule
	{
		public kRtayuH()
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

			Rules = new string[][] { new string[] { "న", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "kRtayuH";
			Name = "కృతయుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virAjikarA : Rule
	{
		public virAjikarA()
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

			Rules = new string[][] { new string[] { "జ", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "virAjikarA";
			Name = "విరాజికరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class IDA : Rule
	{
		public IDA()
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

			Rules = new string[][] { new string[] { "త", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "IDA";
			Name = "ఈడా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class citrapadA :Rule 
	{ 
		public citrapadA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","భ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "citrapadA";
			Name = "చిత్రపదా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class zraddharA :Rule 
	{ 
		public zraddharA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","జ","వ"}};
			Yati = new int[][]{};
		
			Identifier = "zraddharA";
			Name = "శ్రద్ధరా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class tuGgA : Rule
	{
		public tuGgA()
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

			Rules = new string[][] { new string[] { "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "tuGgA";
			Name = "తుఙ్గా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maru : Rule
	{
		public maru()
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

			Rules = new string[][] { new string[] { "జ", "భ", "లల" } };
			Yati = new int[][] { };

			Identifier = "maru";
			Name = "మరు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class siMhalekhA :Rule 
	{ 
		public siMhalekhA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","జ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "siMhalekhA";
			Name = "సింహలేఖా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class saraghA : Rule
	{
		public saraghA()
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

			Rules = new string[][] { new string[] { "స", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "saraghA";
			Name = "సరఘా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Akatanu : Rule
	{
		public Akatanu()
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

			Rules = new string[][] { new string[] { "జ", "త", "లల" } };
			Yati = new int[][] { };

			Identifier = "Akatanu";
			Name = "ఆకతను";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zallakaplutam : Rule
	{
		public zallakaplutam()
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

			Rules = new string[][] { new string[] { "స", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "zallakaplutam";
			Name = "శల్లకప్లుతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratisIrA : Rule
	{
		public pratisIrA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "pratisIrA";
			Name = "ప్రతిసీరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upalinI : Rule
	{
		public upalinI()
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

			Rules = new string[][] { new string[] { "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "upalinI";
			Name = "ఉపలినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mANavakam :Rule 
	{ 
		public mANavakam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","త","వ"}};
			Yati = new int[][]{};
		
			Identifier = "mANavakam";
			Name = "మాణవకమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kSaram : Rule
	{
		public kSaram()
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

			Rules = new string[][] { new string[] { "జ", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "kSaram";
			Name = "క్షరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class atijani : Rule
	{
		public atijani()
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

			Rules = new string[][] { new string[] { "మ", "భ", "లల" } };
			Yati = new int[][] { };

			Identifier = "atijani";
			Name = "అతిజని";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*
	public class atimohA :Rule 
	{ 
		public atimohA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","భ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "atimohA";
			Name = "అతిమోహా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class manolA : Rule
	{
		public manolA()
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

			Rules = new string[][] { new string[] { "య", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "manolA";
			Name = "మనోలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cayanam : Rule
	{
		public cayanam()
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

			Rules = new string[][] { new string[] { "య", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "cayanam";
			Name = "చయనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class caturIhA : Rule
	{
		public caturIhA()
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

			Rules = new string[][] { new string[] { "జ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "caturIhA";
			Name = "చతురీహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mANDavakam : Rule
	{
		public mANDavakam()
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

			Rules = new string[][] { new string[] { "న", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "mANDavakam";
			Name = "మాణ్డవకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class yazaskarI : Rule
	{
		public yazaskarI()
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

			Rules = new string[][] { new string[] { "జ", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "yazaskarI";
			Name = "యశస్కరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class indraphalA : Rule
	{
		public indraphalA()
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

			Rules = new string[][] { new string[] { "భ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "indraphalA";
			Name = "ఇన్ద్రఫలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*
public class vArizAlA :Rule 
{ 
	public vArizAlA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"జ","త","గా"}};
		Yati = new int[][]{};
		
		Identifier = "vArizAlA";
		Name = "వారిశాలా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}*/
	public class yugadhAri : Rule
	{
		public yugadhAri()
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

			Rules = new string[][] { new string[] { "స", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "yugadhAri";
			Name = "యుగధారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sandhyA : Rule
	{
		public sandhyA()
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

			Rules = new string[][] { new string[] { "త", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "sandhyA";
			Name = "సన్ధ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class manthari : Rule
	{
		public manthari()
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

			Rules = new string[][] { new string[] { "మ", "య", "లల" } };
			Yati = new int[][] { };

			Identifier = "manthari";
			Name = "మన్థరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalilA : Rule
	{
		public kalilA()
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

			Rules = new string[][] { new string[] { "స", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "kalilA";
			Name = "కలిలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class akhaniH : Rule
	{
		public akhaniH()
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

			Rules = new string[][] { new string[] { "న", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "akhaniH";
			Name = "అఖనిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AkhrTam : Rule
	{
		public AkhrTam()
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

			Rules = new string[][] { new string[] { "ర", "జ", "లల" } };
			Yati = new int[][] { };

			Identifier = "AkhrTam";
			Name = "ఆఖ్ర్టమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zikhilikhitA : Rule
	{
		public zikhilikhitA()
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

			Rules = new string[][] { new string[] { "మ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "zikhilikhitA";
			Name = "శిఖిలిఖితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAtyA : Rule
	{
		public vAtyA()
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

			Rules = new string[][] { new string[] { "భ", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "vAtyA";
			Name = "వాత్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sArAvanadA : Rule
	{
		public sArAvanadA()
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

			Rules = new string[][] { new string[] { "త", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "sArAvanadA";
			Name = "సారావనదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhArGgI : Rule
	{
		public bhArGgI()
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

			Rules = new string[][] { new string[] { "జ", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhArGgI";
			Name = "భార్ఙ్గీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vRntam : Rule
	{
		public vRntam()
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

			Rules = new string[][] { new string[] { "స", "మ", "లల" } };
			Yati = new int[][] { };

			Identifier = "vRntam";
			Name = "వృన్తమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhUmadhArI : Rule
	{
		public bhUmadhArI()
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

			Rules = new string[][] { new string[] { "య", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhUmadhArI";
			Name = "భూమధారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karaJji : Rule
	{
		public karaJji()
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

			Rules = new string[][] { new string[] { "జ", "న", "హ" } };
			Yati = new int[][] { };

			Identifier = "karaJji";
			Name = "కరఞ్జి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karAlI : Rule
	{
		public karAlI()
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

			Rules = new string[][] { new string[] { "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "karAlI";
			Name = "కరాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class haMsarutam :Rule 
	{ 
		public haMsarutam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","న","గా"}};
			Yati = new int[][]{};
		
			Identifier = "haMsarutam";
			Name = "హంసరుతమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class pramANikA :Rule 
	{ 
		public pramANikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","ర","వ"}};
			Yati = new int[][]{};
		
			Identifier = "pramANikA";
			Name = "ప్రమాణికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class nArAcikA :Rule 
	{ 
		public nArAcikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","ర","వ"}};
			Yati = new int[][]{};
		
			Identifier = "nArAcikA";
			Name = "నారాచికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class haripadam : Rule
	{
		public haripadam()
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

			Rules = new string[][] { new string[] { "న", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "haripadam";
			Name = "హరిపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hemarUpam : Rule
	{
		public hemarUpam()
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

			Rules = new string[][] { new string[] { "ర", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "hemarUpam";
			Name = "హేమరూపమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAtuli : Rule
	{
		public vAtuli()
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

			Rules = new string[][] { new string[] { "య", "య", "లల" } };
			Yati = new int[][] { };

			Identifier = "vAtuli";
			Name = "వాతులి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class haThinI : Rule
	{
		public haThinI()
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

			Rules = new string[][] { new string[] { "మ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "haThinI";
			Name = "హఠినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirudam : Rule
	{
		public nirudam()
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

			Rules = new string[][] { new string[] { "స", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "nirudam";
			Name = "నిరుదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aprItA : Rule
	{
		public aprItA()
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

			Rules = new string[][] { new string[] { "న", "మ", "లల" } };
			Yati = new int[][] { };

			Identifier = "aprItA";
			Name = "అప్రీతా(శాఖోటకి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAntabhAraH : Rule
	{
		public vAntabhAraH()
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

			Rules = new string[][] { new string[] { "న", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vAntabhAraH";
			Name = "వాన్తభారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maulimAlikA : Rule
	{
		public maulimAlikA()
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

			Rules = new string[][] { new string[] { "ర", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "maulimAlikA";
			Name = "మౌలిమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kRSNagatikA : Rule
	{
		public kRSNagatikA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "kRSNagatikA";
			Name = "కృష్ణగతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vRtumukhI : Rule
	{
		public vRtumukhI()
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

			Rules = new string[][] { new string[] { "న", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vRtumukhI";
			Name = "వృతుముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class harit : Rule
	{
		public harit()
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

			Rules = new string[][] { new string[] { "న", "స", "హ" } };
			Yati = new int[][] { };

			Identifier = "harit";
			Name = "హరిత్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paridhArA : Rule
	{
		public paridhArA()
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

			Rules = new string[][] { new string[] { "స", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "paridhArA";
			Name = "పరిధారా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*
public class bhadrikA :Rule 
{ 
	public bhadrikA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"ర","న","ర"}};
		Yati = new int[][]{};
		
		Identifier = "bhadrikA";
		Name = "భద్రికా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}*/
	public class sphuTaghaTitA : Rule
	{
		public sphuTaghaTitA()
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

			Rules = new string[][] { new string[] { "న", "య", "న" } };
			Yati = new int[][] { };

			Identifier = "sphuTaghaTitA";
			Name = "స్ఫుటఘటితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizalyam : Rule
	{
		public vizalyam()
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

			Rules = new string[][] { new string[] { "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "vizalyam";
			Name = "విశల్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuhU : Rule
	{
		public kuhU()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "kuhU";
			Name = "కుహూ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zaralIDhA : Rule
	{
		public zaralIDhA()
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

			Rules = new string[][] { new string[] { "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "zaralIDhA";
			Name = "శరలీఢా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nibhAlitA : Rule
	{
		public nibhAlitA()
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

			Rules = new string[][] { new string[] { "స", "త", "ర" } };
			Yati = new int[][] { };

			Identifier = "nibhAlitA";
			Name = "నిభాలితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class masRNam : Rule
	{
		public masRNam()
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

			Rules = new string[][] { new string[] { "న", "న", "త" } };
			Yati = new int[][] { };

			Identifier = "masRNam";
			Name = "మసృణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maNimadhyam : Rule
	{
		public maNimadhyam()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స" } };
			Yati = new int[][] { };

			Identifier = "maNimadhyam";
			Name = "మణిమధ్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class udarazri : Rule
	{
		public udarazri()
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

			Rules = new string[][] { new string[] { "స", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "udarazri";
			Name = "ఉదరశ్రి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tomaram : Rule
	{
		public tomaram()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "tomaram";
			Name = "తోమరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ardhakSAmA : Rule
	{
		public ardhakSAmA()
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

			Rules = new string[][] { new string[] { "మ", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "ardhakSAmA";
			Name = "అర్ధక్షామా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mukhalA : Rule
	{
		public mukhalA()
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

			Rules = new string[][] { new string[] { "న", "య", "స" } };
			Yati = new int[][] { };

			Identifier = "mukhalA";
			Name = "ముఖలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ardhakalA : Rule
	{
		public ardhakalA()
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

			Rules = new string[][] { new string[] { "స", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "ardhakalA";
			Name = "అర్ధకలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAyAsArI : Rule
	{
		public mAyAsArI()
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

			Rules = new string[][] { new string[] { "న", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "mAyAsArI";
			Name = "మాయాసారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class meghAlokaH : Rule
	{
		public meghAlokaH()
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

			Rules = new string[][] { new string[] { "య", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "meghAlokaH";
			Name = "మేఘాలోకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class avanijA : Rule
	{
		public avanijA()
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

			Rules = new string[][] { new string[] { "జ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "avanijA";
			Name = "అవనిజా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}/*public class madanoddhurA :Rule 
{ 
	public madanoddhurA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"భ","భ","ర"}};
		Yati = new int[][]{};
		
		Identifier = "madanoddhurA";
		Name = "మదనోద్ధురా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}*/
	public class niSadham : Rule
	{
		public niSadham()
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

			Rules = new string[][] { new string[] { "భ", "ర", "స" } };
			Yati = new int[][] { };

			Identifier = "niSadham";
			Name = "నిషధమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madanakam : Rule
	{
		public madanakam()
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

			Rules = new string[][] { new string[] { "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "madanakam";
			Name = "మదనకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anavIrA : Rule
	{
		public anavIrA()
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

			Rules = new string[][] { new string[] { "స", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "anavIrA";
			Name = "అనవీరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lIlA : Rule
	{
		public lIlA()
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

			Rules = new string[][] { new string[] { "న", "య", "జ" } };
			Yati = new int[][] { };

			Identifier = "lIlA";
			Name = "లీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ayanapatAkA : Rule
	{
		public ayanapatAkA()
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

			Rules = new string[][] { new string[] { "మ", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "ayanapatAkA";
			Name = "అయనపతాకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zambaradhArI : Rule
	{
		public zambaradhArI()
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

			Rules = new string[][] { new string[] { "భ", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "zambaradhArI";
			Name = "శమ్బరధారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirvindhyA : Rule
	{
		public nirvindhyA()
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

			Rules = new string[][] { new string[] { "జ", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "nirvindhyA";
			Name = "నిర్విన్ధ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madhumallI : Rule
	{
		public madhumallI()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "madhumallI";
			Name = "మధుమల్లీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sugandhiH : Rule
	{
		public sugandhiH()
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

			Rules = new string[][] { new string[] { "స", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "sugandhiH";
			Name = "సుగన్ధిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmA : Rule
	{
		public kAmA()
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

			Rules = new string[][] { new string[] { "త", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "kAmA";
			Name = "కామా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vandAruH : Rule
	{
		public vandAruH()
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

			Rules = new string[][] { new string[] { "మ", "స", "భ" } };
			Yati = new int[][] { };

			Identifier = "vandAruH";
			Name = "వన్దారుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class khelADhyam : Rule
	{
		public khelADhyam()
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

			Rules = new string[][] { new string[] { "మ", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "khelADhyam";
			Name = "ఖేలాఢ్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAMsIkam : Rule
	{
		public kAMsIkam()
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

			Rules = new string[][] { new string[] { "మ", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "kAMsIkam";
			Name = "కాంసీకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class halodgatA : Rule
	{
		public halodgatA()
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

			Rules = new string[][] { new string[] { "న", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "halodgatA";
			Name = "హలోద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kITamAlA : Rule
	{
		public kITamAlA()
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

			Rules = new string[][] { new string[] { "స", "జ", "త" } };
			Yati = new int[][] { };

			Identifier = "kITamAlA";
			Name = "కీటమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaThinAsthi : Rule
	{
		public kaThinAsthi()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ" } };
			Yati = new int[][] { };

			Identifier = "kaThinAsthi";
			Name = "కఠినాస్థి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhaunikam : Rule
	{
		public dhaunikam()
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

			Rules = new string[][] { new string[] { "భ", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "dhaunikam";
			Name = "ధౌనికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class halamukhI :Rule 
	{ 
		public halamukhI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","న","స"}};
			Yati = new int[][]{};
		
			Identifier = "halamukhI";
			Name = "హలముఖీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class culakam : Rule
	{
		public culakam()
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

			Rules = new string[][] { new string[] { "న", "న", "న" } };
			Yati = new int[][] { };

			Identifier = "culakam";
			Name = "చులకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dadhi : Rule
	{
		public dadhi()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ" } };
			Yati = new int[][] { };

			Identifier = "dadhi";
			Name = "దధి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAridhiyAnam : Rule
	{
		public vAridhiyAnam()
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

			Rules = new string[][] { new string[] { "భ", "త", "జ" } };
			Yati = new int[][] { };

			Identifier = "vAridhiyAnam";
			Name = "వారిధియానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class bhujagazizubhRtA :Rule 
	{ 
		public bhujagazizubhRtA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","మ"}};
			Yati = new int[][]{};
		
			Identifier = "bhujagazizubhRtA";
			Name = "భుజగశిశుభృతా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class pravahlikA : Rule
	{
		public pravahlikA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "pravahlikA";
			Name = "ప్రవహ్లికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalaham : Rule
	{
		public kalaham()
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

			Rules = new string[][] { new string[] { "స", "భ", "మ" } };
			Yati = new int[][] { };

			Identifier = "kalaham";
			Name = "కలహమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaisAruH : Rule
	{
		public vaisAruH()
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

			Rules = new string[][] { new string[] { "త", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "vaisAruH";
			Name = "వైసారుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rambhA : Rule
	{
		public rambhA()
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

			Rules = new string[][] { new string[] { "త", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "rambhA";
			Name = "రమ్భా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIrA : Rule
	{
		public vIrA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "vIrA";
			Name = "వీరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sambuddhiH : Rule
	{
		public sambuddhiH()
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

			Rules = new string[][] { new string[] { "స", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "sambuddhiH";
			Name = "సమ్బుద్ధిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class karazayA :Rule 
	{ 
		public karazayA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","భ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "karazayA";
			Name = "కరశయా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class rUpAmAlI : Rule
	{
		public rUpAmAlI()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "rUpAmAlI";
			Name = "రూపామాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class raJjakam : Rule
	{
		public raJjakam()
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

			Rules = new string[][] { new string[] { "భ", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "raJjakam";
			Name = "రఞ్జకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sahelikA : Rule
	{
		public sahelikA()
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

			Rules = new string[][] { new string[] { "జ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "sahelikA";
			Name = "సహేలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vikacavatI : Rule
	{
		public vikacavatI()
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

			Rules = new string[][] { new string[] { "న", "య", "భ" } };
			Yati = new int[][] { };

			Identifier = "vikacavatI";
			Name = "వికచవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhaurikam : Rule
	{
		public bhaurikam()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "bhaurikam";
			Name = "భౌరికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class priyatilakA : Rule
	{
		public priyatilakA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "priyatilakA";
			Name = "ప్రియతిలకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhRtahAlA : Rule
	{
		public dhRtahAlA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "మ" } };
			Yati = new int[][] { };

			Identifier = "dhRtahAlA";
			Name = "ధృతహాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bimbam : Rule
	{
		public bimbam()
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

			Rules = new string[][] { new string[] { "న", "స", "య" } };
			Yati = new int[][] { };

			Identifier = "bimbam";
			Name = "బిమ్బమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zazikarI : Rule
	{
		public zazikarI()
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

			Rules = new string[][] { new string[] { "స", "న", "త" } };
			Yati = new int[][] { };

			Identifier = "zazikarI";
			Name = "శశికరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ravonmukhI : Rule
	{
		public ravonmukhI()
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

			Rules = new string[][] { new string[] { "త", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "ravonmukhI";
			Name = "రవోన్ముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Akekaram : Rule
	{
		public Akekaram()
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

			Rules = new string[][] { new string[] { "త", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "Akekaram";
			Name = "ఆకేకరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgasaGgatA : Rule
	{
		public bhujaGgasaGgatA()
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

			Rules = new string[][] { new string[] { "స", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "bhujaGgasaGgatA";
			Name = "భుజఙ్గసఙ్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class karmiSThA : Rule
	{
		public karmiSThA ()
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

			Rules = new string[][] { new string[] { "భ" , "స" , "మ" } };
			Yati = new int[][] { };

			Identifier = "karmiSThA";
			Name = "కర్మిష్ఠా";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}*/
	public class valgA : Rule
	{
		public valgA()
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

			Rules = new string[][] { new string[] { "త", "త", "త" } };
			Yati = new int[][] { };

			Identifier = "valgA";
			Name = "వల్గా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ahilA : Rule
	{
		public ahilA()
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

			Rules = new string[][] { new string[] { "త", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "ahilA";
			Name = "అహిలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varmitA : Rule
	{
		public varmitA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "varmitA";
			Name = "వర్మితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class carapadam :Rule 
	{ 
		public carapadam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","త","త","గ"}};
			Yati = new int[][]{};
		
			Identifier = "carapadam";
			Name = "చరపదమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class sukhelA : Rule
	{
		public sukhelA()
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

			Rules = new string[][] { new string[] { "స", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "sukhelA";
			Name = "సుఖేలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIrohA : Rule
	{
		public nIrohA()
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

			Rules = new string[][] { new string[] { "స", "ర", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "nIrohA";
			Name = "నీరోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sarasamukhI : Rule
	{
		public sarasamukhI()
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

			Rules = new string[][] { new string[] { "త", "న", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "sarasamukhI";
			Name = "సరసముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirmedhA : Rule
	{
		public nirmedhA()
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

			Rules = new string[][] { new string[] { "న", "త", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "nirmedhA";
			Name = "నిర్మేధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIrAntA : Rule
	{
		public vIrAntA()
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

			Rules = new string[][] { new string[] { "జ", "స", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vIrAntA";
			Name = "వీరాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAravatI : Rule
	{
		public vAravatI()
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

			Rules = new string[][] { new string[] { "స", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vAravatI";
			Name = "వారవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class makaramukhI : Rule
	{
		public makaramukhI()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "makaramukhI";
			Name = "మకరముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalApAntaritA : Rule
	{
		public kalApAntaritA()
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

			Rules = new string[][] { new string[] { "య", "స", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalApAntaritA";
			Name = "కలాపాన్తరితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pravAdapadA : Rule
	{
		public pravAdapadA()
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

			Rules = new string[][] { new string[] { "స", "జ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "pravAdapadA";
			Name = "ప్రవాదపదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIrAJjaliH : Rule
	{
		public nIrAJjaliH()
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

			Rules = new string[][] { new string[] { "త", "న", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "nIrAJjaliH";
			Name = "నీరాఞ్జలిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varhAturA : Rule
	{
		public varhAturA()
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

			Rules = new string[][] { new string[] { "త", "భ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "varhAturA";
			Name = "వర్హాతురా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class campakamAlA :Rule 
	{ 
		public campakamAlA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","మ","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "campakamAlA";
			Name = "చమ్పకమాలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class nIranidhiH : Rule
	{
		public nIranidhiH()
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

			Rules = new string[][] { new string[] { "న", "త", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "nIranidhiH";
			Name = "నీరనిధిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viralam : Rule
	{
		public viralam()
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

			Rules = new string[][] { new string[] { "భ", "స", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "viralam";
			Name = "విరలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Rtam : Rule
	{
		public Rtam()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "Rtam";
			Name = "ఋతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gaNadehA : Rule
	{
		public gaNadehA()
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

			Rules = new string[][] { new string[] { "స", "మ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "gaNadehA";
			Name = "గణదేహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saMhatikA : Rule
	{
		public saMhatikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "saMhatikA";
			Name = "సంహతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class suSamA : Rule
	{
		public suSamA()
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

			Rules = new string[][] { new string[] { "త", "య", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "suSamA";
			Name = "సుషమా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class naragA : Rule
	{
		public naragA()
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

			Rules = new string[][] { new string[] { "న", "య", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "naragA";
			Name = "నరగా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mayUrasAriNI :Rule 
	{ 
		public mayUrasAriNI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","జ","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "mayUrasAriNI";
			Name = "మయూరసారిణీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class dhamanikA : Rule
	{
		public dhamanikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "dhamanikA";
			Name = "ధమనికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sahajA : Rule
	{
		public sahajA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sahajA";
			Name = "సహజా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class surayAnavatI : Rule
	{
		public surayAnavatI()
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

			Rules = new string[][] { new string[] { "స", "స", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "surayAnavatI";
			Name = "సురయానవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhUmrAlI : Rule
	{
		public dhUmrAlI()
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

			Rules = new string[][] { new string[] { "య", "య", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "dhUmrAlI";
			Name = "ధూమ్రాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dvAravahA : Rule
	{
		public dvAravahA()
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

			Rules = new string[][] { new string[] { "ర", "త", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "dvAravahA";
			Name = "ద్వారవహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class surAkSI : Rule
	{
		public surAkSI()
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

			Rules = new string[][] { new string[] { "న", "య", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "surAkSI";
			Name = "సురాక్షీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gahanA : Rule
	{
		public gahanA()
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

			Rules = new string[][] { new string[] { "భ", "న", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "gahanA";
			Name = "గహనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nameruH : Rule
	{
		public nameruH()
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

			Rules = new string[][] { new string[] { "త", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "nameruH";
			Name = "నమేరుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hemahAsaH : Rule
	{
		public hemahAsaH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "hemahAsaH";
			Name = "హేమహాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tanimA : Rule
	{
		public tanimA()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "tanimA";
			Name = "తనిమా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class citibhRtam : Rule
	{
		public citibhRtam()
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

			Rules = new string[][] { new string[] { "న", "న", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "citibhRtam";
			Name = "చితిభృతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nemadhAri : Rule
	{
		public nemadhAri()
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

			Rules = new string[][] { new string[] { "జ", "భ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "nemadhAri";
			Name = "నేమధారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class manoramA :Rule 
	{ 
		public manoramA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","ర","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "manoramA";
			Name = "మనోరమా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class cArucAraNam : Rule
	{
		public cArucAraNam()
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

			Rules = new string[][] { new string[] { "ర", "న", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "cArucAraNam";
			Name = "చారుచారణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jarA : Rule
	{
		public jarA()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "jarA";
			Name = "జరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chalitakam : Rule
	{
		public chalitakam()
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

			Rules = new string[][] { new string[] { "న", "త", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "chalitakam";
			Name = "ఛలితకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class hIrAGgI :Rule 
	{ 
		public hIrAGgI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","న","య","గ"}};
			Yati = new int[][]{};
		
			Identifier = "hIrAGgI";
			Name = "హీరాఙ్గీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class rasabhUma : Rule
	{
		public rasabhUma()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "rasabhUma";
			Name = "రసభూమ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mattA :Rule 
	{ 
		public mattA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","భ","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "mattA";
			Name = "మత్తా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class hIralambi : Rule
	{
		public hIralambi()
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

			Rules = new string[][] { new string[] { "భ", "భ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "hIralambi";
			Name = "హీరలమ్బి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class indraH : Rule
	{
		public indraH()
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

			Rules = new string[][] { new string[] { "జ", "జ", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "indraH";
			Name = "ఇన్ద్రః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class asitadhArA : Rule
	{
		public asitadhArA()
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

			Rules = new string[][] { new string[] { "స", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "asitadhArA";
			Name = "అసితధారా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class acalapaGktiH : Rule
	{
		public acalapaGktiH()
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

			Rules = new string[][] { new string[] { "ర", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "acalapaGktiH";
			Name = "అచలపఙ్క్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmacAri : Rule
	{
		public kAmacAri()
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

			Rules = new string[][] { new string[] { "త", "భ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "kAmacAri";
			Name = "కామచారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paNavaH : Rule
	{
		public paNavaH()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "paNavaH";
			Name = "పణవః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class keram : Rule
	{
		public keram()
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

			Rules = new string[][] { new string[] { "ర", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "keram";
			Name = "కేరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarat : Rule
	{
		public zarat()
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

			Rules = new string[][] { new string[] { "న", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "zarat";
			Name = "శరత్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class khaurali : Rule
	{
		public khaurali()
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

			Rules = new string[][] { new string[] { "న", "య", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "khaurali";
			Name = "ఖౌరలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class visraMsi : Rule
	{
		public visraMsi()
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

			Rules = new string[][] { new string[] { "న", "స", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "visraMsi";
			Name = "విస్రంసి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kIlAlam : Rule
	{
		public kIlAlam()
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

			Rules = new string[][] { new string[] { "భ", "మ", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "kIlAlam";
			Name = "కీలాలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kheTakam : Rule
	{
		public kheTakam()
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

			Rules = new string[][] { new string[] { "భ", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "kheTakam";
			Name = "ఖేటకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karNapAlikA : Rule
	{
		public karNapAlikA()
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

			Rules = new string[][] { new string[] { "ర", "య", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "karNapAlikA";
			Name = "కర్ణపాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class unnAlam : Rule
	{
		public unnAlam()
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

			Rules = new string[][] { new string[] { "త", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "unnAlam";
			Name = "ఉన్నాలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vireki : Rule
	{
		public vireki()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "vireki";
			Name = "విరేకి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class baladhArI : Rule
	{
		public baladhArI()
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

			Rules = new string[][] { new string[] { "స", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "baladhArI";
			Name = "బలధారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zephAlI : Rule
	{
		public zephAlI()
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

			Rules = new string[][] { new string[] { "య", "మ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "zephAlI";
			Name = "శేఫాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upadhAyyA : Rule
	{
		public upadhAyyA()
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

			Rules = new string[][] { new string[] { "భ", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "upadhAyyA";
			Name = "ఉపధాయ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vizvamukhI :Rule 
	{ 
		public vizvamukhI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","భ","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "vizvamukhI";
			Name = "విశ్వముఖీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class bhinnapadam : Rule
	{
		public bhinnapadam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhinnapadam";
			Name = "భిన్నపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizadacchAyaH : Rule
	{
		public vizadacchAyaH()
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

			Rules = new string[][] { new string[] { "స", "త", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "vizadacchAyaH";
			Name = "విశదచ్ఛాయః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizAlaprabham : Rule
	{
		public vizAlaprabham()
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

			Rules = new string[][] { new string[] { "జ", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "vizAlaprabham";
			Name = "విశాలప్రభమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kRtamaNitA : Rule
	{
		public kRtamaNitA()
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

			Rules = new string[][] { new string[] { "భ", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "kRtamaNitA";
			Name = "కృతమణితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upasaMkulA : Rule
	{
		public upasaMkulA()
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

			Rules = new string[][] { new string[] { "స", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "upasaMkulA";
			Name = "ఉపసంకులా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizAlAntikam : Rule
	{
		public vizAlAntikam()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "vizAlAntikam";
			Name = "విశాలాన్తికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amRtagatiH : Rule
	{
		public amRtagatiH()
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

			Rules = new string[][] { new string[] { "న", "జ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "amRtagatiH";
			Name = "అమృతగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kUlam : Rule
	{
		public kUlam()
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

			Rules = new string[][] { new string[] { "త", "స", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kUlam";
			Name = "కూలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class phaladharam : Rule
	{
		public phaladharam()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "phaladharam";
			Name = "ఫలధరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaDizabhedinI : Rule
	{
		public vaDizabhedinI()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vaDizabhedinI";
			Name = "వడిశభేదినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class phalinI : Rule
	{
		public phalinI()
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

			Rules = new string[][] { new string[] { "న", "య", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "phalinI";
			Name = "ఫలినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kRkapAdi : Rule
	{
		public kRkapAdi()
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

			Rules = new string[][] { new string[] { "న", "ర", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "kRkapAdi";
			Name = "కృకపాది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kRtakavali : Rule
	{
		public kRtakavali()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "kRtakavali";
			Name = "కృతకవలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paricAravatI : Rule
	{
		public paricAravatI()
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

			Rules = new string[][] { new string[] { "త", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "paricAravatI";
			Name = "పరిచారవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class kupyam :Rule 
	{ 
		public kupyam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","స","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "kupyam";
			Name = "కుప్యమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class mahimAvasAyi : Rule
	{
		public mahimAvasAyi()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "mahimAvasAyi";
			Name = "మహిమావసాయి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lulitam : Rule
	{
		public lulitam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "lulitam";
			Name = "లులితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kANDamukhI : Rule
	{
		public kANDamukhI()
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

			Rules = new string[][] { new string[] { "జ", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kANDamukhI";
			Name = "కాణ్డముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class padmAvarttaH : Rule
	{
		public padmAvarttaH()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "padmAvarttaH";
			Name = "పద్మావర్త్తః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class akSarAvalI : Rule
	{
		public akSarAvalI()
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

			Rules = new string[][] { new string[] { "ర", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "akSarAvalI";
			Name = "అక్షరావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madhyAdhArA : Rule
	{
		public madhyAdhArA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "madhyAdhArA";
			Name = "మధ్యాధారా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bodhAturA : Rule
	{
		public bodhAturA()
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

			Rules = new string[][] { new string[] { "య", "మ", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "bodhAturA";
			Name = "బోధాతురా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vanitAvinodi : Rule
	{
		public vanitAvinodi()
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

			Rules = new string[][] { new string[] { "న", "భ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "vanitAvinodi";
			Name = "వనితావినోది";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prasarA : Rule
	{
		public prasarA()
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

			Rules = new string[][] { new string[] { "మ", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "prasarA";
			Name = "ప్రసరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anucAyitA : Rule
	{
		public anucAyitA()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "anucAyitA";
			Name = "అనుచాయితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sarAvikA : Rule
	{
		public sarAvikA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sarAvikA";
			Name = "సరావికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class virAT :Rule 
	{ 
		public virAT()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","స","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "virAT";
			Name = "విరాట్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kAmanibhA : Rule
	{
		public kAmanibhA()
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

			Rules = new string[][] { new string[] { "మ", "స", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "kAmanibhA";
			Name = "కామనిభా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaMzAropI : Rule
	{
		public vaMzAropI()
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

			Rules = new string[][] { new string[] { "య", "భ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vaMzAropI";
			Name = "వంశారోపీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class uditam : Rule
	{
		public uditam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "uditam";
			Name = "ఉదితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class apayodhA : Rule
	{
		public apayodhA()
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

			Rules = new string[][] { new string[] { "స", "ర", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "apayodhA";
			Name = "అపయోధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paTupaTTikA : Rule
	{
		public paTupaTTikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "paTupaTTikA";
			Name = "పటుపట్టికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zrutakIrttiH : Rule
	{
		public zrutakIrttiH()
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

			Rules = new string[][] { new string[] { "న", "య", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "zrutakIrttiH";
			Name = "శ్రుతకీర్త్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rodhakam : Rule
	{
		public rodhakam()
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

			Rules = new string[][] { new string[] { "న", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "rodhakam";
			Name = "రోధకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class samit : Rule
	{
		public samit()
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

			Rules = new string[][] { new string[] { "న", "య", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "samit";
			Name = "సమిత్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sainikam : Rule
	{
		public sainikam()
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

			Rules = new string[][] { new string[] { "జ", "ర", "జ", "హ" } };
			Yati = new int[][] { };

			Identifier = "sainikam";
			Name = "సైనికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prasRmarakarA : Rule
	{
		public prasRmarakarA()
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

			Rules = new string[][] { new string[] { "న", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "prasRmarakarA";
			Name = "ప్రసృమరకరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class praphullakadalI : Rule
	{
		public praphullakadalI()
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

			Rules = new string[][] { new string[] { "జ", "స", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "praphullakadalI";
			Name = "ప్రఫుల్లకదలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parimalalalitam : Rule
	{
		public parimalalalitam()
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

			Rules = new string[][] { new string[] { "న", "న", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "parimalalalitam";
			Name = "పరిమలలలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nAbhasam : Rule
	{
		public nAbhasam()
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

			Rules = new string[][] { new string[] { "జ", "జ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "nAbhasam";
			Name = "నాభసమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAmapadA : Rule
	{
		public sAmapadA()
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

			Rules = new string[][] { new string[] { "మ", "స", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "sAmapadA";
			Name = "సామపదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prapAtAvatAram : Rule
	{
		public prapAtAvatAram()
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

			Rules = new string[][] { new string[] { "య", "య", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "prapAtAvatAram";
			Name = "ప్రపాతావతారమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amoghamAlikA : Rule
	{
		public amoghamAlikA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "amoghamAlikA";
			Name = "అమోఘమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class niravadhigatiH : Rule
	{
		public niravadhigatiH()
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

			Rules = new string[][] { new string[] { "న", "స", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "niravadhigatiH";
			Name = "నిరవధిగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratAritA : Rule
	{
		public pratAritA()
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

			Rules = new string[][] { new string[] { "స", "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "pratAritA";
			Name = "ప్రతారితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sIdhuH : Rule
	{
		public sIdhuH()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "sIdhuH";
			Name = "సీధుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*
public class senikA :Rule 
{ 
	public senikA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"ర","జ","ర","వ"}};
		Yati = new int[][]{};
		
		Identifier = "senikA";
		Name = "సేనికా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}*/
	public class paJcazAkhI : Rule
	{
		public paJcazAkhI()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "paJcazAkhI";
			Name = "పఞ్చశాఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amandapAdaH : Rule
	{
		public amandapAdaH()
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

			Rules = new string[][] { new string[] { "భ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "amandapAdaH";
			Name = "అమన్దపాదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class antarvanitA : Rule
	{
		public antarvanitA()
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

			Rules = new string[][] { new string[] { "మ", "స", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "antarvanitA";
			Name = "అన్తర్వనితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIlA : Rule
	{
		public nIlA()
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

			Rules = new string[][] { new string[] { "త", "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "nIlA";
			Name = "నీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class subhadrikA :Rule 
	{ 
		public subhadrikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","ర","వ"}};
			Yati = new int[][]{};
		
			Identifier = "subhadrikA";
			Name = "సుభద్రికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class zalkazakalam : Rule
	{
		public zalkazakalam()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "zalkazakalam";
			Name = "శల్కశకలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saubhagakalA : Rule
	{
		public saubhagakalA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "saubhagakalA";
			Name = "సౌభగకలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sarojavanikA : Rule
	{
		public sarojavanikA()
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

			Rules = new string[][] { new string[] { "జ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "sarojavanikA";
			Name = "సరోజవనికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class agarim : Rule
	{
		public agarim()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "agarim";
			Name = "అగరిమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saMsRtazobhAsAraH : Rule
	{
		public saMsRtazobhAsAraH()
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

			Rules = new string[][] { new string[] { "స", "త", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "saMsRtazobhAsAraH";
			Name = "సంసృతశోభాసారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class prAkArabandhaH :Rule 
	{ 
		public prAkArabandhaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","త","త","గా"}};
			Yati = new int[][]{};
		
			Identifier = "prAkArabandhaH";
			Name = "ప్రాకారబన్ధః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class amAlInam : Rule
	{
		public amAlInam()
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

			Rules = new string[][] { new string[] { "య", "య", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "amAlInam";
			Name = "అమాలీనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saMzrayazrIH : Rule
	{
		public saMzrayazrIH()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "హ" } };
			Yati = new int[][] { };

			Identifier = "saMzrayazrIH";
			Name = "సంశ్రయశ్రీః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class rathoddhatA :Rule 
	{ 
		public rathoddhatA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","న","ర","వ"}};
			Yati = new int[][]{};
		
			Identifier = "rathoddhatA";
			Name = "రథోద్ధతా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class rathapadam :Rule 
	{ 
		public rathapadam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","స","గా"}};
			Yati = new int[][]{};
		
			Identifier = "rathapadam";
			Name = "రథపదమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class zramitazikhaNDI : Rule
	{
		public zramitazikhaNDI()
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

			Rules = new string[][] { new string[] { "భ", "స", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "zramitazikhaNDI";
			Name = "శ్రమితశిఖణ్డీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class anukUlA :Rule 
	{ 
		public anukUlA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","త","న","గా"}};
			Yati = new int[][]{};
		
			Identifier = "anukUlA";
			Name = "అనుకూలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class ArAdhinI : Rule
	{
		public ArAdhinI()
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

			Rules = new string[][] { new string[] { "త", "మ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "ArAdhinI";
			Name = "ఆరాధినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zritakamalA : Rule
	{
		public zritakamalA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "zritakamalA";
			Name = "శ్రితకమలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sammadamAlikA : Rule
	{
		public sammadamAlikA()
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

			Rules = new string[][] { new string[] { "న", "స", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "sammadamAlikA";
			Name = "సమ్మదమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saurabhavarddhinI : Rule
	{
		public saurabhavarddhinI()
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

			Rules = new string[][] { new string[] { "న", "య", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "saurabhavarddhinI";
			Name = "సౌరభవర్ద్ధినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAndrapadam : Rule
	{
		public sAndrapadam()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "హ" } };
			Yati = new int[][] { };

			Identifier = "sAndrapadam";
			Name = "సాన్ద్రపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zeSApIDam : Rule
	{
		public zeSApIDam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "లల" } };
			Yati = new int[][] { };

			Identifier = "zeSApIDam";
			Name = "శేషాపీడమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class sumukhI :Rule 
	{ 
		public sumukhI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","జ","వ"}};
			Yati = new int[][]{};
		
			Identifier = "sumukhI";
			Name = "సుముఖీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class piculam : Rule
	{
		public piculam()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "హ" } };
			Yati = new int[][] { };

			Identifier = "piculam";
			Name = "పిచులమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zAlinI :Rule 
	{ 
		public zAlinI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","త","త","గా"}};
			Yati = new int[][]{};
		
			Identifier = "zAlinI";
			Name = "శాలినీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class bhramaravilasitA :Rule 
	{ 
		public bhramaravilasitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","భ","న","వ"}};
			Yati = new int[][]{};
		
			Identifier = "bhramaravilasitA";
			Name = "భ్రమరవిలసితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class bhujagahAriNI : Rule
	{
		public bhujagahAriNI()
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

			Rules = new string[][] { new string[] { "న", "ర", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "bhujagahAriNI";
			Name = "భుజగహారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kelicaram : Rule
	{
		public kelicaram()
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

			Rules = new string[][] { new string[] { "న", "య", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "kelicaram";
			Name = "కేలిచరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIvadhaH : Rule
	{
		public vIvadhaH()
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

			Rules = new string[][] { new string[] { "న", "జ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "vIvadhaH";
			Name = "వీవధః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class dodhakam :Rule 
	{ 
		public dodhakam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","భ","భ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "dodhakam";
			Name = "దోధకమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class khaTakA : Rule
	{
		public khaTakA()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "khaTakA";
			Name = "ఖటకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgI : Rule
	{
		public bhujaGgI()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "bhujaGgI";
			Name = "భుజఙ్గీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vallavIvilAsaH : Rule
	{
		public vallavIvilAsaH()
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

			Rules = new string[][] { new string[] { "ర", "య", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "vallavIvilAsaH";
			Name = "వల్లవీవిలాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kanakamaJjarI : Rule
	{
		public kanakamaJjarI()
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

			Rules = new string[][] { new string[] { "న", "ర", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "kanakamaJjarI";
			Name = "కనకమఞ్జరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kanakakAminI : Rule
	{
		public kanakakAminI()
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

			Rules = new string[][] { new string[] { "జ", "త", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "kanakakAminI";
			Name = "కనకకామినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujalatA : Rule
	{
		public bhujalatA()
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

			Rules = new string[][] { new string[] { "న", "స", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "bhujalatA";
			Name = "భుజలతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhUrighaTakam : Rule
	{
		public bhUrighaTakam()
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

			Rules = new string[][] { new string[] { "మ", "న", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhUrighaTakam";
			Name = "భూరిఘటకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kandavinodaH : Rule
	{
		public kandavinodaH()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "kandavinodaH";
			Name = "కన్దవినోదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class upendravajrA :Rule 
	{ 
		public upendravajrA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","త","జ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "upendravajrA";
			Name = "ఉపేన్ద్రవజ్రా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class lalitAlabAlam : Rule
	{
		public lalitAlabAlam()
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

			Rules = new string[][] { new string[] { "స", "జ", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "lalitAlabAlam";
			Name = "లలితాలబాలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalitAgamanam : Rule
	{
		public lalitAgamanam()
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

			Rules = new string[][] { new string[] { "స", "స", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "lalitAgamanam";
			Name = "లలితాగమనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lakSaNalIlA : Rule
	{
		public lakSaNalIlA()
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

			Rules = new string[][] { new string[] { "భ", "త", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "lakSaNalIlA";
			Name = "లక్షణలీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizvavirAT : Rule
	{
		public vizvavirAT()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vizvavirAT";
			Name = "విశ్వవిరాట్(సాయం)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upacitram : Rule
	{
		public upacitram()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "upacitram";
			Name = "ఉపచిత్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upadArikA : Rule
	{
		public upadArikA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "upadArikA";
			Name = "ఉపదారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuzalakalAvatikA : Rule
	{
		public kuzalakalAvatikA()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kuzalakalAvatikA";
			Name = "కుశలకలావతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class upasthitam :Rule 
	{ 
		public upasthitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","స","త","గా"}};
			Yati = new int[][]{};
		
			Identifier = "upasthitam";
			Name = "ఉపస్థితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class upasthitA :Rule 
	{ 
		public upasthitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","జ","జ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "upasthitA";
			Name = "ఉపస్థితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class krozitakuzalA : Rule
	{
		public krozitakuzalA()
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

			Rules = new string[][] { new string[] { "భ", "స", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "krozitakuzalA";
			Name = "క్రోశితకుశలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upahitacaNDI : Rule
	{
		public upahitacaNDI()
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

			Rules = new string[][] { new string[] { "స", "భ", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "upahitacaNDI";
			Name = "ఉపహితచణ్డీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kUlacAriNI : Rule
	{
		public kUlacAriNI()
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

			Rules = new string[][] { new string[] { "ర", "జ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "kUlacAriNI";
			Name = "కూలచారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhAratI : Rule
	{
		public bhAratI()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhAratI";
			Name = "భారతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilulitamaJjarI : Rule
	{
		public vilulitamaJjarI()
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

			Rules = new string[][] { new string[] { "న", "జ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vilulitamaJjarI";
			Name = "విలులితమఞ్జరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dArikA : Rule
	{
		public dArikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "dArikA";
			Name = "దారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dArudehA : Rule
	{
		public dArudehA()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "dArudehA";
			Name = "దారుదేహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class damanakam : Rule
	{
		public damanakam()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "damanakam";
			Name = "దమనకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAtormI : Rule
	{
		public vAtormI()
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

			Rules = new string[][] { new string[] { "మ", "భ", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vAtormI";
			Name = "వాతోర్మీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vimalA : Rule
	{
		public vimalA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vimalA";
			Name = "విమలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class harikAntA : Rule
	{
		public harikAntA()
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

			Rules = new string[][] { new string[] { "స", "భ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "harikAntA";
			Name = "హరికాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gahvaram : Rule
	{
		public gahvaram()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "gahvaram";
			Name = "గహ్వరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vikasitapadmAvalI : Rule
	{
		public vikasitapadmAvalI()
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

			Rules = new string[][] { new string[] { "న", "య", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "vikasitapadmAvalI";
			Name = "వికసితపద్మావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vihAriNI : Rule
	{
		public vihAriNI()
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

			Rules = new string[][] { new string[] { "స", "జ", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vihAriNI";
			Name = "విహారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilambitamadhyA : Rule
	{
		public vilambitamadhyA()
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

			Rules = new string[][] { new string[] { "మ", "స", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "vilambitamadhyA";
			Name = "విలమ్బితమధ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gambhAri : Rule
	{
		public gambhAri()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "gambhAri";
			Name = "గమ్భారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gallakam : Rule
	{
		public gallakam()
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

			Rules = new string[][] { new string[] { "న", "న", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "gallakam";
			Name = "గల్లకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dAmaghaTitA : Rule
	{
		public dAmaghaTitA()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "dAmaghaTitA";
			Name = "దామఘటితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalasvanavaMzaH : Rule
	{
		public kalasvanavaMzaH()
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

			Rules = new string[][] { new string[] { "భ", "భ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "kalasvanavaMzaH";
			Name = "కలస్వనవంశః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vArayAtrikam : Rule
	{
		public vArayAtrikam()
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

			Rules = new string[][] { new string[] { "భ", "ర", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "vArayAtrikam";
			Name = "వారయాత్రికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varNabalAkA : Rule
	{
		public varNabalAkA()
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

			Rules = new string[][] { new string[] { "స", "స", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "varNabalAkA";
			Name = "వర్ణబలాకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmukalekhA : Rule
	{
		public kAmukalekhA()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స", "హ" } };
			Yati = new int[][] { };

			Identifier = "kAmukalekhA";
			Name = "కాముకలేఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalitakamalavilAsaH : Rule
	{
		public kalitakamalavilAsaH()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "kalitakamalavilAsaH";
			Name = "కలితకమలవిలాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAlavarma : Rule
	{
		public kAlavarma()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "హ" } };
			Yati = new int[][] { };

			Identifier = "kAlavarma";
			Name = "కాలవర్మ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vArttAhArI : Rule
	{
		public vArttAhArI()
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

			Rules = new string[][] { new string[] { "న", "జ", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "vArttAhArI";
			Name = "వార్త్తాహారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jAlapAdaH : Rule
	{
		public jAlapAdaH()
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

			Rules = new string[][] { new string[] { "త", "మ", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "jAlapAdaH";
			Name = "జాలపాదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class indravajrA :Rule 
	{ 
		public indravajrA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","త","జ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "indravajrA";
			Name = "ఇన్ద్రవజ్రా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class IhAmRgI : Rule
	{
		public IhAmRgI()
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

			Rules = new string[][] { new string[] { "త", "భ", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "IhAmRgI";
			Name = "ఈహామృగీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaDAram : Rule
	{
		public kaDAram()
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

			Rules = new string[][] { new string[] { "య", "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "kaDAram";
			Name = "కడారమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jihmAzayA : Rule
	{
		public jihmAzayA()
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

			Rules = new string[][] { new string[] { "త", "భ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "jihmAzayA";
			Name = "జిహ్మాశయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class javanazAlinI : Rule
	{
		public javanazAlinI()
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

			Rules = new string[][] { new string[] { "స", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "javanazAlinI";
			Name = "జవనశాలినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class meghadhvanipUraH : Rule
	{
		public meghadhvanipUraH()
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

			Rules = new string[][] { new string[] { "త", "య", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "meghadhvanipUraH";
			Name = "మేఘధ్వనిపూరః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madanayA : Rule
	{
		public madanayA()
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

			Rules = new string[][] { new string[] { "న", "న", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "madanayA";
			Name = "మదనయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class uddhatikarI : Rule
	{
		public uddhatikarI()
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

			Rules = new string[][] { new string[] { "భ", "య", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "uddhatikarI";
			Name = "ఉద్ధతికరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viSTambhaH : Rule
	{
		public viSTambhaH()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "viSTambhaH";
			Name = "విష్టమ్భః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class uditadinezaH : Rule
	{
		public uditadinezaH()
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

			Rules = new string[][] { new string[] { "స", "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "uditadinezaH";
			Name = "ఉదితదినేశః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}/*
public class moTanakam :Rule 
{ 
	public moTanakam()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"త","జ","జ","వ"}};
		Yati = new int[][]{};
		
		Identifier = "moTanakam";
		Name = "మోటనకమ్";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}*/
	public class mAtrA : Rule
	{
		public mAtrA()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "mAtrA";
			Name = "మాత్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AzApAdaH : Rule
	{
		public AzApAdaH()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "AzApAdaH";
			Name = "ఆశాపాదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAlavikA : Rule
	{
		public mAlavikA()
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

			Rules = new string[][] { new string[] { "త", "జ", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "mAlavikA";
			Name = "మాలవికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class uditavijohA : Rule
	{
		public uditavijohA()
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

			Rules = new string[][] { new string[] { "త", "త", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "uditavijohA";
			Name = "ఉదితవిజోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class svAgatA :Rule 
	{ 
		public svAgatA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","న","భ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "svAgatA";
			Name = "స్వాగతా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class arthazikhA : Rule
	{
		public arthazikhA()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "arthazikhA";
			Name = "అర్థశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class suvRttiH : Rule
	{
		public suvRttiH()
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

			Rules = new string[][] { new string[] { "స", "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "suvRttiH";
			Name = "సువృత్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madanamAlA : Rule
	{
		public madanamAlA()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "madanamAlA";
			Name = "మదనమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsaramaNikA : Rule
	{
		public vAsaramaNikA()
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

			Rules = new string[][] { new string[] { "భ", "స", "స", "భ" } };
			Yati = new int[][] { };

			Identifier = "vAsaramaNikA";
			Name = "వాసరమణికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class priyaMvadaH :Rule 
	{ 
		public priyaMvadaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","భ","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "priyaMvadaH";
			Name = "ప్రియంవదః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class chalitakapadam : Rule
	{
		public chalitakapadam()
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

			Rules = new string[][] { new string[] { "త", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "chalitakapadam";
			Name = "ఛలితకపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class puTaH :Rule 
	{ 
		public puTaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","మ","య"}};
			Yati = new int[][]{};
		
			Identifier = "puTaH";
			Name = "పుటః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class svaravarSiNI : Rule
	{
		public svaravarSiNI()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "మ" } };
			Yati = new int[][] { };

			Identifier = "svaravarSiNI";
			Name = "స్వరవర్షిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class jaloddhatagatiH :Rule 
	{ 
		public jaloddhatagatiH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","స","జ","స"}};
			Yati = new int[][]{};
		
			Identifier = "jaloddhatagatiH";
			Name = "జలోద్ధతగతిః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class vasantahAsaH : Rule
	{
		public vasantahAsaH()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "య" } };
			Yati = new int[][] { };

			Identifier = "vasantahAsaH";
			Name = "వసన్తహాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vasanavizAlA : Rule
	{
		public vasanavizAlA()
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

			Rules = new string[][] { new string[] { "న", "న", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "vasanavizAlA";
			Name = "వసనవిశాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mauktikadAma : Rule
	{
		public mauktikadAma()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "mauktikadAma";
			Name = "మౌక్తికదామ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mattAlI : Rule
	{
		public mattAlI()
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

			Rules = new string[][] { new string[] { "మ", "త", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "mattAlI";
			Name = "మత్తాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jvalitA : Rule
	{
		public jvalitA()
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

			Rules = new string[][] { new string[] { "స", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "jvalitA";
			Name = "జ్వలితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class jaladharamAlA :Rule 
	{ 
		public jaladharamAlA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","భ","స","మ"}};
			Yati = new int[][]{};
		
			Identifier = "jaladharamAlA";
			Name = "జలధరమాలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class varatrA : Rule
	{
		public varatrA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "varatrA";
			Name = "వరత్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virataprabhA : Rule
	{
		public virataprabhA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "virataprabhA";
			Name = "విరతప్రభా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIraNamAlA : Rule
	{
		public vIraNamAlA()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "vIraNamAlA";
			Name = "వీరణమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prasRmaramarAlikA : Rule
	{
		public prasRmaramarAlikA()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "prasRmaramarAlikA";
			Name = "ప్రసృమరమరాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viratimahatI : Rule
	{
		public viratimahatI()
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

			Rules = new string[][] { new string[] { "త", "న", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "viratimahatI";
			Name = "విరతిమహతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class maNimAlA :Rule 
	{ 
		public maNimAlA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","య","త","య"}};
			Yati = new int[][]{};
		
			Identifier = "maNimAlA";
			Name = "మణిమాలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class ativAsitA : Rule
	{
		public ativAsitA()
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

			Rules = new string[][] { new string[] { "స", "య", "ర", "స" } };
			Yati = new int[][] { };

			Identifier = "ativAsitA";
			Name = "అతివాసితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vanitAvilokaH : Rule
	{
		public vanitAvilokaH()
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

			Rules = new string[][] { new string[] { "త", "త", "స", "య" } };
			Yati = new int[][] { };

			Identifier = "vanitAvilokaH";
			Name = "వనితావిలోకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vanitAbharaNam : Rule
	{
		public vanitAbharaNam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "vanitAbharaNam";
			Name = "వనితాభరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class asudhArA : Rule
	{
		public asudhArA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "asudhArA";
			Name = "అసుధారా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAraGgaH : Rule
	{
		public sAraGgaH()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "త" } };
			Yati = new int[][] { };

			Identifier = "sAraGgaH";
			Name = "సారఙ్గః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vipulapAlikA : Rule
	{
		public vipulapAlikA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "vipulapAlikA";
			Name = "విపులపాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viplutazikhA : Rule
	{
		public viplutazikhA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "viplutazikhA";
			Name = "విప్లుతశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class candravartma :Rule 
	{ 
		public candravartma()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","న","భ","స"}};
			Yati = new int[][]{};
		
			Identifier = "candravartma";
			Name = "చన్ద్రవర్త్మ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class viralA : Rule
	{
		public viralA()
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

			Rules = new string[][] { new string[] { "స", "న", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "viralA";
			Name = "విరలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalavallivihaGgaH : Rule
	{
		public kalavallivihaGgaH()
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

			Rules = new string[][] { new string[] { "జ", "త", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "kalavallivihaGgaH";
			Name = "కలవల్లివిహఙ్గః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class nayamAlinI :Rule 
	{ 
		public nayamAlinI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","భ","య"}};
			Yati = new int[][]{};
		
			Identifier = "nayamAlinI";
			Name = "నయమాలినీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class viraloddhatA : Rule
	{
		public viraloddhatA()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "స" } };
			Yati = new int[][] { };

			Identifier = "viraloddhatA";
			Name = "విరలోద్ధతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class tAmarasam :Rule 
	{ 
		public tAmarasam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","జ","య"}};
			Yati = new int[][]{};
		
			Identifier = "tAmarasam";
			Name = "తామరసమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class vidyAdhAraH : Rule
	{
		public vidyAdhAraH()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "vidyAdhAraH";
			Name = "విద్యాధారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rUpAvaliH : Rule
	{
		public rUpAvaliH()
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

			Rules = new string[][] { new string[] { "త", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "rUpAvaliH";
			Name = "రూపావలిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nagamahitA : Rule
	{
		public nagamahitA()
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

			Rules = new string[][] { new string[] { "స", "భ", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "nagamahitA";
			Name = "నగమహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saGgamavatI : Rule
	{
		public saGgamavatI()
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

			Rules = new string[][] { new string[] { "భ", "జ", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "saGgamavatI";
			Name = "సఙ్గమవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class galitanAlA : Rule
	{
		public galitanAlA()
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

			Rules = new string[][] { new string[] { "జ", "భ", "య", "ర" } };
			Yati = new int[][] { };

			Identifier = "galitanAlA";
			Name = "గలితనాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arilA : Rule
	{
		public arilA()
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

			Rules = new string[][] { new string[] { "స", "భ", "భ", "భ" } };
			Yati = new int[][] { };

			Identifier = "arilA";
			Name = "అరిలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidrumadolA : Rule
	{
		public vidrumadolA()
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

			Rules = new string[][] { new string[] { "న", "య", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "vidrumadolA";
			Name = "విద్రుమదోలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arditapAdam : Rule
	{
		public arditapAdam()
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

			Rules = new string[][] { new string[] { "ర", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "arditapAdam";
			Name = "అర్దితపాదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class drutavilambitam :Rule 
	{ 
		public drutavilambitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","భ","భ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "drutavilambitam";
			Name = "ద్రుతవిలమ్బితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class samayaprahitA : Rule
	{
		public samayaprahitA()
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

			Rules = new string[][] { new string[] { "స", "స", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "samayaprahitA";
			Name = "సమయప్రహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhRSTapadam : Rule
	{
		public dhRSTapadam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "dhRSTapadam";
			Name = "ధృష్టపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mukulitakalikAvalI : Rule
	{
		public mukulitakalikAvalI()
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

			Rules = new string[][] { new string[] { "ర", "న", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "mukulitakalikAvalI";
			Name = "ముకులితకలికావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dorlIlA : Rule
	{
		public dorlIlA()
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

			Rules = new string[][] { new string[] { "స", "స", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "dorlIlA";
			Name = "దోర్లీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vikalavakulavallI : Rule
	{
		public vikalavakulavallI()
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

			Rules = new string[][] { new string[] { "న", "న", "త", "త" } };
			Yati = new int[][] { };

			Identifier = "vikalavakulavallI";
			Name = "వికలవకులవల్లీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class drutapadam : Rule
	{
		public drutapadam()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "drutapadam";
			Name = "ద్రుతపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAkSI : Rule
	{
		public sAkSI()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "మ" } };
			Yati = new int[][] { };

			Identifier = "sAkSI";
			Name = "సాక్షీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vijayaparicayA : Rule
	{
		public vijayaparicayA()
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

			Rules = new string[][] { new string[] { "న", "న", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "vijayaparicayA";
			Name = "విజయపరిచయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zuddhAntam : Rule
	{
		public zuddhAntam()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "zuddhAntam";
			Name = "శుద్ధాన్తమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class suvanamAlikA : Rule
	{
		public suvanamAlikA()
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

			Rules = new string[][] { new string[] { "త", "స", "జ", "స" } };
			Yati = new int[][] { };

			Identifier = "suvanamAlikA";
			Name = "సువనమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class suvihitA : Rule
	{
		public suvihitA()
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

			Rules = new string[][] { new string[] { "య", "స", "జ", "స" } };
			Yati = new int[][] { };

			Identifier = "suvihitA";
			Name = "సువిహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sammadavadanA : Rule
	{
		public sammadavadanA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "sammadavadanA";
			Name = "సమ్మదవదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arpitamadanA : Rule
	{
		public arpitamadanA()
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

			Rules = new string[][] { new string[] { "భ", "స", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "arpitamadanA";
			Name = "అర్పితమదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rAdhikA : Rule
	{
		public rAdhikA()
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

			Rules = new string[][] { new string[] { "స", "భ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "rAdhikA";
			Name = "రాధికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AdhidaivI : Rule
	{
		public AdhidaivI()
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

			Rules = new string[][] { new string[] { "య", "మ", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "AdhidaivI";
			Name = "ఆధిదైవీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vINAdaNDam : Rule
	{
		public vINAdaNDam()
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

			Rules = new string[][] { new string[] { "జ", "స", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "vINAdaNDam";
			Name = "వీణాదణ్డమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class induvaMzA :Rule 
	{ 
		public induvaMzA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","త","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "induvaMzA";
			Name = "ఇన్దువంశా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class sutalam : Rule
	{
		public sutalam()
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

			Rules = new string[][] { new string[] { "స", "ర", "స", "ర" } };
			Yati = new int[][] { };

			Identifier = "sutalam";
			Name = "సుతలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhavalakarI : Rule
	{
		public dhavalakarI()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "మ" } };
			Yati = new int[][] { };

			Identifier = "dhavalakarI";
			Name = "ధవలకరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arjitaphalikA : Rule
	{
		public arjitaphalikA()
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

			Rules = new string[][] { new string[] { "భ", "స", "ర", "స" } };
			Yati = new int[][] { };

			Identifier = "arjitaphalikA";
			Name = "అర్జితఫలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidhAritA : Rule
	{
		public vidhAritA()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "vidhAritA";
			Name = "విధారితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vikatthanam : Rule
	{
		public vikatthanam()
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

			Rules = new string[][] { new string[] { "జ", "జ", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "vikatthanam";
			Name = "వికత్థనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mihirA : Rule
	{
		public mihirA()
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

			Rules = new string[][] { new string[] { "న", "స", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "mihirA";
			Name = "మిహిరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rasikaparicitA : Rule
	{
		public rasikaparicitA()
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

			Rules = new string[][] { new string[] { "స", "త", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "rasikaparicitA";
			Name = "రసికపరిచితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class modakam : Rule
	{
		public modakam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ" } };
			Yati = new int[][] { };

			Identifier = "modakam";
			Name = "మోదకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mithunamAlI : Rule
	{
		public mithunamAlI()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "mithunamAlI";
			Name = "మిథునమాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vaMzastham :Rule 
	{ 
		public vaMzastham()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","త","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "vaMzastham";
			Name = "వంశస్థమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class parilekhaH : Rule
	{
		public parilekhaH()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "parilekhaH";
			Name = "పరిలేఖః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumAragatiH : Rule
	{
		public kumAragatiH()
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

			Rules = new string[][] { new string[] { "జ", "న", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "kumAragatiH";
			Name = "కుమారగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parimitavijayA : Rule
	{
		public parimitavijayA()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "parimitavijayA";
			Name = "పరిమితవిజయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarameyA : Rule
	{
		public zarameyA()
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

			Rules = new string[][] { new string[] { "స", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "zarameyA";
			Name = "శరమేయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumudinIvikAzaH : Rule
	{
		public kumudinIvikAzaH()
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

			Rules = new string[][] { new string[] { "జ", "త", "స", "య" } };
			Yati = new int[][] { };

			Identifier = "kumudinIvikAzaH";
			Name = "కుముదినీవికాశః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuraGgAvatAraH : Rule
	{
		public kuraGgAvatAraH()
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

			Rules = new string[][] { new string[] { "య", "య", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "kuraGgAvatAraH";
			Name = "కురఙ్గావతారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumbhodhnI : Rule
	{
		public kumbhodhnI()
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

			Rules = new string[][] { new string[] { "మ", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "kumbhodhnI";
			Name = "కుమ్భోధ్నీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upalekhA : Rule
	{
		public upalekhA()
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

			Rules = new string[][] { new string[] { "స", "భ", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "upalekhA";
			Name = "ఉపలేఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class udayanamukhI : Rule
	{
		public udayanamukhI()
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

			Rules = new string[][] { new string[] { "న", "స", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "udayanamukhI";
			Name = "ఉదయనముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kRtakatikA : Rule
	{
		public kRtakatikA()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "kRtakatikA";
			Name = "కృతకతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhasalavinoditA : Rule
	{
		public bhasalavinoditA()
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

			Rules = new string[][] { new string[] { "జ", "భ", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "bhasalavinoditA";
			Name = "భసలవినోదితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pathikAntA : Rule
	{
		public pathikAntA()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "pathikAntA";
			Name = "పథికాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mAlatI :Rule 
	{ 
		public mAlatI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "mAlatI";
			Name = "మాలతీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class paritoSA : Rule
	{
		public paritoSA()
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

			Rules = new string[][] { new string[] { "స", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "paritoSA";
			Name = "పరితోషా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paripuGkhitA : Rule
	{
		public paripuGkhitA()
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

			Rules = new string[][] { new string[] { "ర", "స", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "paripuGkhitA";
			Name = "పరిపుఙ్ఖితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lumbAkSI : Rule
	{
		public lumbAkSI()
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

			Rules = new string[][] { new string[] { "స", "స", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "lumbAkSI";
			Name = "లుమ్బాక్షీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizAlAmbhojAlI : Rule
	{
		public vizAlAmbhojAlI()
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

			Rules = new string[][] { new string[] { "త", "స", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "vizAlAmbhojAlI";
			Name = "విశాలామ్భోజాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class lalitA :Rule 
	{ 
		public lalitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","భ","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "lalitA";
			Name = "లలితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class badhirA : Rule
	{
		public badhirA()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "badhirA";
			Name = "బధిరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalitam : Rule
	{
		public lalitam()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "ర" } };
			Yati = new int[][] { };

			Identifier = "lalitam";
			Name = "లలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upadhAnam : Rule
	{
		public upadhAnam()
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

			Rules = new string[][] { new string[] { "జ", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "upadhAnam";
			Name = "ఉపధానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lIlAratnam : Rule
	{
		public lIlAratnam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "lIlAratnam";
			Name = "లీలారత్నమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class antarvikAsavAsakaH : Rule
	{
		public antarvikAsavAsakaH()
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

			Rules = new string[][] { new string[] { "త", "ర", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "antarvikAsavAsakaH";
			Name = "అన్తర్వికాసవాసకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lIDhAlarkaH : Rule
	{
		public lIDhAlarkaH()
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

			Rules = new string[][] { new string[] { "మ", "త", "స", "య" } };
			Yati = new int[][] { };

			Identifier = "lIDhAlarkaH";
			Name = "లీఢాలర్కః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class subhadrAvataraNiH : Rule
	{
		public subhadrAvataraNiH()
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

			Rules = new string[][] { new string[] { "మ", "త", "త", "స" } };
			Yati = new int[][] { };

			Identifier = "subhadrAvataraNiH";
			Name = "సుభద్రావతరణిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class ujjvalA :Rule 
	{ 
		public ujjvalA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","భ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "ujjvalA";
			Name = "ఉజ్జ్వలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class vizikhalatA : Rule
	{
		public vizikhalatA()
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

			Rules = new string[][] { new string[] { "న", "జ", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "vizikhalatA";
			Name = "విశిఖలతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class balorjitA : Rule
	{
		public balorjitA()
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

			Rules = new string[][] { new string[] { "న", "జ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "balorjitA";
			Name = "బలోర్జితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class sragviNI :Rule 
	{ 
		public sragviNI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","ర","ర","ర"}};
			Yati = new int[][]{};
		
			Identifier = "sragviNI";
			Name = "స్రగ్విణీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class kusumavicitrA :Rule 
	{ 
		public kusumavicitrA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","య","న","య"}};
			Yati = new int[][]{};
		
			Identifier = "kusumavicitrA";
			Name = "కుసుమవిచిత్రా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class lalanA : Rule
	{
		public lalanA()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "lalanA";
			Name = "లలనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zampA : Rule
	{
		public zampA()
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

			Rules = new string[][] { new string[] { "త", "న", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "zampA";
			Name = "శమ్పా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalAmalalitAdharA : Rule
	{
		public lalAmalalitAdharA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "lalAmalalitAdharA";
			Name = "లలామలలితాధరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anIcakam : Rule
	{
		public anIcakam()
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

			Rules = new string[][] { new string[] { "జ", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "anIcakam";
			Name = "అనీచకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viyogavatI : Rule
	{
		public viyogavatI()
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

			Rules = new string[][] { new string[] { "జ", "జ", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "viyogavatI";
			Name = "వియోగవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class bhujaGgaprayAtam :Rule 
	{ 
		public bhujaGgaprayAtam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"య","య","య","య"}};
			Yati = new int[][]{};
		
			Identifier = "bhujaGgaprayAtam";
			Name = "భుజఙ్గప్రయాతమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class prabhA :Rule 
	{ 
		public prabhA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","ర","ర"}};
			Yati = new int[][]{};
		
			Identifier = "prabhA";
			Name = "ప్రభా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class valabhI : Rule
	{
		public valabhI()
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

			Rules = new string[][] { new string[] { "భ", "భ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "valabhI";
			Name = "వలభీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vaizvadevI :Rule 
	{ 
		public vaizvadevI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","మ","య","య"}};
			Yati = new int[][]{};
		
			Identifier = "vaizvadevI";
			Name = "వైశ్వదేవీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class toTakam :Rule 
	{ 
		public toTakam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","స","స","స"}};
			Yati = new int[][]{};
		
			Identifier = "toTakam";
			Name = "తోటకమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class aviralaratikA : Rule
	{
		public aviralaratikA()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "aviralaratikA";
			Name = "అవిరలరతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgajuSI : Rule
	{
		public bhujaGgajuSI()
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

			Rules = new string[][] { new string[] { "ర", "స", "ర", "స" } };
			Yati = new int[][] { };

			Identifier = "bhujaGgajuSI";
			Name = "భుజఙ్గజుషీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAsArakrAntA : Rule
	{
		public kAsArakrAntA()
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

			Rules = new string[][] { new string[] { "మ", "త", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "kAsArakrAntA";
			Name = "కాసారక్రాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sukhazailam : Rule
	{
		public sukhazailam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "sukhazailam";
			Name = "సుఖశైలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class pramitAkSarA :Rule 
	{ 
		public pramitAkSarA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","జ","స","స"}};
			Yati = new int[][]{};
		
			Identifier = "pramitAkSarA";
			Name = "ప్రమితాక్షరా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class taralanayanam : Rule
	{
		public taralanayanam()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న" } };
			Yati = new int[][] { };

			Identifier = "taralanayanam";
			Name = "తరలనయనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class siktamaNimAlA : Rule
	{
		public siktamaNimAlA()
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

			Rules = new string[][] { new string[] { "భ", "య", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "siktamaNimAlA";
			Name = "సిక్తమణిమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIlagirikA : Rule
	{
		public nIlagirikA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "nIlagirikA";
			Name = "నీలగిరికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vyAyogavatI : Rule
	{
		public vyAyogavatI()
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

			Rules = new string[][] { new string[] { "త", "జ", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "vyAyogavatI";
			Name = "వ్యాయోగవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sarojAvAlI : Rule
	{
		public sarojAvAlI()
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

			Rules = new string[][] { new string[] { "య", "య", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "sarojAvAlI";
			Name = "సరోజావాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nimagnakIlA : Rule
	{
		public nimagnakIlA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "త" } };
			Yati = new int[][] { };

			Identifier = "nimagnakIlA";
			Name = "నిమగ్నకీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karamAlA : Rule
	{
		public karamAlA()
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

			Rules = new string[][] { new string[] { "స", "భ", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "karamAlA";
			Name = "కరమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirantikam : Rule
	{
		public nirantikam()
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

			Rules = new string[][] { new string[] { "త", "భ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "nirantikam";
			Name = "నీరాన్తికమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhAsitabharaNam : Rule
	{
		public bhAsitabharaNam()
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

			Rules = new string[][] { new string[] { "భ", "స", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "bhAsitabharaNam";
			Name = "భాసితభరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kiMzukAstaraNam : Rule
	{
		public kiMzukAstaraNam()
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

			Rules = new string[][] { new string[] { "ర", "స", "య", "మ" } };
			Yati = new int[][] { };

			Identifier = "kiMzukAstaraNam";
			Name = "కింశుకాస్తరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhAsitasaraNiH : Rule
	{
		public bhAsitasaraNiH()
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

			Rules = new string[][] { new string[] { "భ", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "bhAsitasaraNiH";
			Name = "భాసితసరణిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vivaravilasitam : Rule
	{
		public vivaravilasitam()
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

			Rules = new string[][] { new string[] { "త", "న", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "vivaravilasitam";
			Name = "వివరవిలసితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class malayasurabhiH : Rule
	{
		public malayasurabhiH()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "malayasurabhiH";
			Name = "మలయసురభిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viSamavyAlI : Rule
	{
		public viSamavyAlI()
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

			Rules = new string[][] { new string[] { "న", "స", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "viSamavyAlI";
			Name = "విషమవ్యాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class udarkaracitA : Rule
	{
		public udarkaracitA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "స" } };
			Yati = new int[][] { };

			Identifier = "udarkaracitA";
			Name = "ఉదర్కరచితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pikAlikA : Rule
	{
		public pikAlikA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "pikAlikA";
			Name = "పికాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class savyAlI : Rule
	{
		public savyAlI()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "savyAlI";
			Name = "సవ్యాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAmavadanA : Rule
	{
		public vAmavadanA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "vAmavadanA";
			Name = "వామవదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sukarNapUram : Rule
	{
		public sukarNapUram()
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

			Rules = new string[][] { new string[] { "న", "ర", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "sukarNapUram";
			Name = "సుకర్ణపూరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zraddharAntA : Rule
	{
		public zraddharAntA()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "zraddharAntA";
			Name = "శ్రద్ధరాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vipannakadanam : Rule
	{
		public vipannakadanam()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vipannakadanam";
			Name = "విపన్నకదనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sArddhapadA : Rule
	{
		public sArddhapadA()
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

			Rules = new string[][] { new string[] { "ర", "య", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sArddhapadA";
			Name = "సార్ద్ధపదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ulkAbhAsaH : Rule
	{
		public ulkAbhAsaH()
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

			Rules = new string[][] { new string[] { "మ", "త", "స", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "ulkAbhAsaH";
			Name = "ఉల్కాభాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upacitaratikA : Rule
	{
		public upacitaratikA()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "upacitaratikA";
			Name = "ఉపచితరతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tArakam : Rule
	{
		public tArakam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "tArakam";
			Name = "తారకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vRddhavAmA : Rule
	{
		public vRddhavAmA()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "vRddhavAmA";
			Name = "వృద్ధవామా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidalA : Rule
	{
		public vidalA()
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

			Rules = new string[][] { new string[] { "న", "స", "త", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vidalA";
			Name = "విదలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upagatazikhA : Rule
	{
		public upagatazikhA()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "upagatazikhA";
			Name = "ఉపగతశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class svinnazarIram : Rule
	{
		public svinnazarIram()
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

			Rules = new string[][] { new string[] { "భ", "త", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "svinnazarIram";
			Name = "స్విన్నశరీరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vibhA : Rule
	{
		public vibhA()
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

			Rules = new string[][] { new string[] { "న", "య", "త", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "vibhA";
			Name = "విభా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class varivazitA : Rule
	{
		public varivazitA()
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

			Rules = new string[][] { new string[] { "స", "స", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "varivazitA";
			Name = "వరివశితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upasarasI : Rule
	{
		public upasarasI()
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

			Rules = new string[][] { new string[] { "స", "న", "జ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "upasarasI";
			Name = "ఉపసరసీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsavilAsavatI : Rule
	{
		public vAsavilAsavatI()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vAsavilAsavatI";
			Name = "వాసవిలాసవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sArasanAvaliH : Rule
	{
		public sArasanAvaliH()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "sArasanAvaliH";
			Name = "సారసనావలిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virodhinI : Rule
	{
		public virodhinI()
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

			Rules = new string[][] { new string[] { "న", "భ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "virodhinI";
			Name = "విరోధినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vinatAkSI : Rule
	{
		public vinatAkSI()
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

			Rules = new string[][] { new string[] { "స", "భ", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "vinatAkSI";
			Name = "వినతాక్షీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sukhakArikA : Rule
	{
		public sukhakArikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "మ", "ల" } };
			Yati = new int[][] { };

			Identifier = "sukhakArikA";
			Name = "సుఖకారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidhuravitAnam : Rule
	{
		public vidhuravitAnam()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "vidhuravitAnam";
			Name = "విధురవితానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class udAttahAsaH : Rule
	{
		public udAttahAsaH()
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

			Rules = new string[][] { new string[] { "జ", "త", "భ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "udAttahAsaH";
			Name = "ఉదాత్తహాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zalabhalolA : Rule
	{
		public zalabhalolA()
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

			Rules = new string[][] { new string[] { "య", "య", "జ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "zalabhalolA";
			Name = "శలభలోలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paGkAvaliH : Rule
	{
		public paGkAvaliH()
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

			Rules = new string[][] { new string[] { "భ", "న", "య", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "paGkAvaliH";
			Name = "పఙ్కావలిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paGkajadhAriNI : Rule
	{
		public paGkajadhAriNI()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "paGkajadhAriNI";
			Name = "పఙ్కజధారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paGkavatI : Rule
	{
		public paGkavatI()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ", "జ", "ల" } };
			Yati = new int[][] { };

			Identifier = "paGkavatI";
			Name = "పఙ్కవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jagatsamAnikA : Rule
	{
		public jagatsamAnikA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "jagatsamAnikA";
			Name = "జగత్సమానికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paragatiH : Rule
	{
		public paragatiH()
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

			Rules = new string[][] { new string[] { "ర", "న", "స", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "paragatiH";
			Name = "పరగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalanAyikA : Rule
	{
		public kalanAyikA()
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

			Rules = new string[][] { new string[] { "జ", "త", "న", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalanAyikA";
			Name = "కలనాయికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalApatiprabhA : Rule
	{
		public kalApatiprabhA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalApatiprabhA";
			Name = "కలాపతిప్రభా(మనోహర)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class kalahaMsaH :Rule 
	{ 
		public kalahaMsaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","జ","స","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "kalahaMsaH";
			Name = "కలహంసః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kalAdhAmam : Rule
	{
		public kalAdhAmam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "జ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalAdhAmam";
			Name = "కలాధామమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class abhrabhramazIlA : Rule
	{
		public abhrabhramazIlA()
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

			Rules = new string[][] { new string[] { "త", "య", "స", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "abhrabhramazIlA";
			Name = "అభ్రభ్రమశీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maJjumAlatI : Rule
	{
		public maJjumAlatI()
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

			Rules = new string[][] { new string[] { "ర", "జ", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "maJjumAlatI";
			Name = "మఞ్జుమాలతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parivRDham : Rule
	{
		public parivRDham()
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

			Rules = new string[][] { new string[] { "న", "త", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "parivRDham";
			Name = "పరివృఢమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class garudavAritA : Rule
	{
		public garudavAritA()
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

			Rules = new string[][] { new string[] { "జ", "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "garudavAritA";
			Name = "గరుదవారితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class abhIrukA : Rule
	{
		public abhIrukA()
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

			Rules = new string[][] { new string[] { "జ", "భ", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "abhIrukA";
			Name = "అభీరుకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class darpamAlA : Rule
	{
		public darpamAlA()
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

			Rules = new string[][] { new string[] { "య", "య", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "darpamAlA";
			Name = "దర్పమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class drutalambinI : Rule
	{
		public drutalambinI()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "drutalambinI";
			Name = "ద్రుతలమ్బినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ambudAvalI : Rule
	{
		public ambudAvalI()
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

			Rules = new string[][] { new string[] { "స", "య", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "ambudAvalI";
			Name = "అమ్బుదావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pArAvataH : Rule
	{
		public pArAvataH()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "pArAvataH";
			Name = "పారావతః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amitanagAnikA : Rule
	{
		public amitanagAnikA()
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

			Rules = new string[][] { new string[] { "భ", "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "amitanagAnikA";
			Name = "అమితనగానికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class guNasArikA : Rule
	{
		public guNasArikA()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "guNasArikA";
			Name = "గుణసారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class haravanitA : Rule
	{
		public haravanitA()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "haravanitA";
			Name = "హరవనితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class narAvaliH : Rule
	{
		public narAvaliH()
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

			Rules = new string[][] { new string[] { "త", "భ", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "narAvaliH";
			Name = "నరావలిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aDamaruH : Rule
	{
		public aDamaruH()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "aDamaruH";
			Name = "అడమరుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mANavikAvikASaH : Rule
	{
		public mANavikAvikASaH()
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

			Rules = new string[][] { new string[] { "త", "భ", "భ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "mANavikAvikASaH";
			Name = "మాణవికావికాషః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuberakaTikA : Rule
	{
		public kuberakaTikA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "kuberakaTikA";
			Name = "కుబేరకటికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class marmasphuram : Rule
	{
		public marmasphuram()
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

			Rules = new string[][] { new string[] { "త", "భ", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "marmasphuram";
			Name = "మర్మస్ఫురమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class komalakalpakalikA : Rule
	{
		public komalakalpakalikA()
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

			Rules = new string[][] { new string[] { "స", "య", "స", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "komalakalpakalikA";
			Name = "కోమలకల్పకలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class madanajavanikA :Rule 
	{ 
		public madanajavanikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","య","న","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "madanajavanikA";
			Name = "మదనజవనికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class maJjubhASiNI :Rule 
	{ 
		public maJjubhASiNI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","జ","స","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "maJjubhASiNI";
			Name = "మఞ్జుభాషిణీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class lodhrazikhA : Rule
	{
		public lodhrazikhA()
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

			Rules = new string[][] { new string[] { "మ", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "lodhrazikhA";
			Name = "లోధ్రశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class lavalIlatA :Rule 
	{ 
		public lavalIlatA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","ర","న","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "lavalIlatA";
			Name = "లవలీలతా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class lIlAlolaH : Rule
	{
		public lIlAlolaH()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "lIlAlolaH";
			Name = "లీలాలోలః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kirAtaH : Rule
	{
		public kirAtaH()
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

			Rules = new string[][] { new string[] { "న", "జ", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "kirAtaH";
			Name = "కిరాతః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kandaH : Rule
	{
		public kandaH()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "kandaH";
			Name = "కన్దః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karapallavodgatA : Rule
	{
		public karapallavodgatA()
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

			Rules = new string[][] { new string[] { "య", "య", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "karapallavodgatA";
			Name = "కరపల్లవోద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kanakitA : Rule
	{
		public kanakitA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "kanakitA";
			Name = "కనకితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kanakaketakI : Rule
	{
		public kanakaketakI()
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

			Rules = new string[][] { new string[] { "త", "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kanakaketakI";
			Name = "కనకకేతకీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class kaThinI : Rule
	{
		public kaThinI()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "kaThinI";
			Name = "కఠినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kIralekhA : Rule
	{
		public kIralekhA()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "kIralekhA";
			Name = "కీరలేఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mattamayUraH :Rule 
	{ 
		public mattamayUraH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","త","య","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "mattamayUraH";
			Name = "మత్తమయూరః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class karmaThaH :Rule 
	{ 
		public karmaThaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","భ","భ","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "karmaThaH";
			Name = "కర్మఠః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class mayUkhasaraNiH :Rule 
	{ 
		public mayUkhasaraNiH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","స","జ","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "mayUkhasaraNiH";
			Name = "మయూఖసరణిః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class AnanamUlam :Rule 
	{ 
		public AnanamUlam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","త","య","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "AnanamUlam";
			Name = "ఆననమూలమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class pramodaH :Rule 
	{ 
		public pramodaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","ర","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "pramodaH";
			Name = "ప్రమోదః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class bhasalamadam :Rule 
	{ 
		public bhasalamadam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","స","జ","త","గ"}};
			Yati = new int[][]{};
		
			Identifier = "bhasalamadam";
			Name = "భసలమదమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class pramodatilakA :Rule 
	{ 
		public pramodatilakA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","భ","జ","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "pramodatilakA";
			Name = "ప్రమోదతిలకా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class prajJAmUlam :Rule 
	{ 
		public prajJAmUlam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","భ","న","య","గ"}};
			Yati = new int[][]{};
		
			Identifier = "prajJAmUlam";
			Name = "ప్రజ్ఞామూలమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class ApaNikA :Rule 
	{ 
		public ApaNikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","త","జ","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "ApaNikA";
			Name = "ఆపణికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class prapAtalikA :Rule 
	{ 
		public prapAtalikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","స","జ","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "prapAtalikA";
			Name = "ప్రపాతలికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class rucirA :Rule 
	{ 
		public rucirA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","భ","స","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "rucirA";
			Name = "రుచిరా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class bhAjanazIlA :Rule 
	{ 
		public bhAjanazIlA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","య","ర","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "bhAjanazIlA";
			Name = "భాజనశీలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class azaniH :Rule 
	{ 
		public azaniH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","త","న","ల"}};
			Yati = new int[][]{};
		
			Identifier = "azaniH";
			Name = "అశనిః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class caJcarIkAvalI :Rule 
	{ 
		public caJcarIkAvalI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"య","మ","ర","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "caJcarIkAvalI";
			Name = "చఞ్చరీకావలీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class azokapuSpam :Rule 
	{ 
		public azokapuSpam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","ర","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "azokapuSpam";
			Name = "అశోకపుష్పమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class rasadhArA :Rule 
	{ 
		public rasadhArA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","య","న","య","గ"}};
			Yati = new int[][]{};
		
			Identifier = "rasadhArA";
			Name = "రసధారా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class candrahAsakarA :Rule 
	{ 
		public candrahAsakarA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","స","జ","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "candrahAsakarA";
			Name = "చన్ద్రహాసకరా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class caNDI :Rule 
	{ 
		public caNDI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","స","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "caNDI";
			Name = "చణ్డీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class AnatA :Rule 
	{ 
		public AnatA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","న","ర","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "AnatA";
			Name = "ఆనతా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class atiraMhaH :Rule 
	{ 
		public atiraMhaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","జ","జ","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "atiraMhaH";
			Name = "అతిరంహః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class akhaNDamaNDanam :Rule 
	{ 
		public akhaNDamaNDanam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","ర","ర","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "akhaNDamaNDanam";
			Name = "అఖణ్డమణ్డనమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class abhirAmA :Rule 
	{ 
		public abhirAmA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","భ","త","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "abhirAmA";
			Name = "అభిరామా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class pravAhikA :Rule 
	{ 
		public pravAhikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","త","త","త","గ"}};
			Yati = new int[][]{};
		
			Identifier = "pravAhikA";
			Name = "ప్రవాహికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class pRSadvatI :Rule 
	{ 
		public pRSadvatI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","ర","ర","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "pRSadvatI";
			Name = "పృషద్వతీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class prabhAvatI :Rule 
	{ 
		public prabhAvatI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","భ","స","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "prabhAvatI";
			Name = "ప్రభావతీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class prabodhaphalitA :Rule 
	{ 
		public prabodhaphalitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","న","ర","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "prabodhaphalitA";
			Name = "ప్రబోధఫలితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class candrikA :Rule 
	{ 
		public candrikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","త","త","గ"}};
			Yati = new int[][]{};
		
			Identifier = "candrikA";
			Name = "చన్ద్రికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class rucivarNA :Rule 
	{ 
		public rucivarNA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","స","జ","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "rucivarNA";
			Name = "రుచివర్ణా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class praharSiNI :Rule 
	{ 
		public praharSiNI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","న","జ","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "praharSiNI";
			Name = "ప్రహర్షిణీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	/*public class ardhakusumitA :Rule 
	{ 
		public ardhakusumitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","స","న","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "ardhakusumitA";
			Name = "అర్ధకుసుమితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	/*public class mRgendramukham :Rule 
	{ 
	public mRgendramukham()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"న","జ","జ","ర","గ"}};
		Yati = new int[][]{};
		
		Identifier = "mRgendramukham";
		Name = "మృగేన్ద్రముఖమ్";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
	}*/
	public class aTTAsinI : Rule
	{
		public aTTAsinI()
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

			Rules = new string[][] { new string[] { "త", "భ", "ర", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "aTTAsinI";
			Name = "అట్టాసినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aniloddhatamukhI : Rule
	{
		public aniloddhatamukhI()
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

			Rules = new string[][] { new string[] { "న", "ర", "ర", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "aniloddhatamukhI";
			Name = "అనిలోద్ధతముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class arkazeSA : Rule
	{
		public arkazeSA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "arkazeSA";
			Name = "అర్కశేషా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karNizaraH : Rule
	{
		public karNizaraH()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "karNizaraH";
			Name = "కర్ణిశరః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAraviNI : Rule
	{
		public kAraviNI()
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

			Rules = new string[][] { new string[] { "భ", "జ", "భ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAraviNI";
			Name = "కారవిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anindagurvinduH : Rule
	{
		public anindagurvinduH()
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

			Rules = new string[][] { new string[] { "న", "య", "త", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "anindagurvinduH";
			Name = "అనిన్దగుర్విన్దుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizambhari : Rule
	{
		public vizambhari()
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

			Rules = new string[][] { new string[] { "న", "న", "య", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "vizambhari";
			Name = "విశమ్భరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class akahari : Rule
	{
		public akahari()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "akahari";
			Name = "అకహరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalitapatAkA : Rule
	{
		public lalitapatAkA()
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

			Rules = new string[][] { new string[] { "న", "స", "య", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "lalitapatAkA";
			Name = "లలితపతాకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kusumbhinI : Rule
	{
		public kusumbhinI()
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

			Rules = new string[][] { new string[] { "జ", "భ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "kusumbhinI";
			Name = "కుసుమ్భినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kUrcalalitam : Rule
	{
		public kUrcalalitam()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kUrcalalitam";
			Name = "కూర్చలలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class unnarma : Rule
	{
		public unnarma()
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

			Rules = new string[][] { new string[] { "భ", "భ", "స", "స", "హ" } };
			Yati = new int[][] { };

			Identifier = "unnarma";
			Name = "ఉన్నర్మ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madhupAli : Rule
	{
		public madhupAli()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "లల" } };
			Yati = new int[][] { };

			Identifier = "madhupAli";
			Name = "మధుపాలి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madAvadAtA : Rule
	{
		public madAvadAtA()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "madAvadAtA";
			Name = "మదావదాతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class asambAdhA :Rule 
	{ 
		public asambAdhA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","త","న","స","గా"}};
			Yati = new int[][]{};
		
			Identifier = "asambAdhA";
			Name = "అసమ్బాధా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class kurarIrutA :Rule 
	{ 
		public kurarIrutA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","భ","జ","వ"}};
			Yati = new int[][]{};
		
			Identifier = "kurarIrutA";
			Name = "కురరీరుతా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	/*public class indravadanA :Rule 
	{ 
	public indravadanA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"భ","జ","స","న","గా"}};
		Yati = new int[][]{};
		
		Identifier = "indravadanA";
		Name = "ఇన్ద్రవదనా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
	}*/
	/*public class aparAjitA :Rule 
	{ 
	public aparAjitA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"న","న","ర","స","వ"}};
		Yati = new int[][]{};
		
		Identifier = "aparAjitA";
		Name = "అపరాజితా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
	}*/
	public class kRtamAlam : Rule
	{
		public kRtamAlam()
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

			Rules = new string[][] { new string[] { "త", "జ", "య", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "kRtamAlam";
			Name = "కృతమాలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class krIDAyatanam : Rule
	{
		public krIDAyatanam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "krIDAyatanam";
			Name = "క్రీడాయతనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class babhrulakSmIH : Rule
	{
		public babhrulakSmIH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "babhrulakSmIH";
			Name = "బభ్రులక్ష్మీః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuDaGgikA : Rule
	{
		public kuDaGgikA()
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

			Rules = new string[][] { new string[] { "జ", "ర", "జ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "kuDaGgikA";
			Name = "కుడఙ్గికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upakArikA : Rule
	{
		public upakArikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "upakArikA";
			Name = "ఉపకారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aJcalavatI : Rule
	{
		public aJcalavatI()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "aJcalavatI";
			Name = "అఞ్చలవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class hemamihikA : Rule
	{
		public hemamihikA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "hemamihikA";
			Name = "హేమమిహికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hetiH : Rule
	{
		public hetiH()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "hetiH";
			Name = "హేతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class celAJcalam : Rule
	{
		public celAJcalam()
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

			Rules = new string[][] { new string[] { "త", "భ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "celAJcalam";
			Name = "చేలాఞ్చలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vazamUlam : Rule
	{
		public vazamUlam()
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

			Rules = new string[][] { new string[] { "స", "భ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vazamUlam";
			Name = "వశమూలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class jAhamukhI : Rule
	{
		public jAhamukhI()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "jAhamukhI";
			Name = "జాహముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vATikAvikAzaH : Rule
	{
		public vATikAvikAzaH()
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

			Rules = new string[][] { new string[] { "భ", "న", "య", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vATikAvikAzaH";
			Name = "వాటికావికాశః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vipAkavatI : Rule
	{
		public vipAkavatI()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "vipAkavatI";
			Name = "విపాకవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vindhyArUDham : Rule
	{
		public vindhyArUDham()
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

			Rules = new string[][] { new string[] { "మ", "ర", "మ", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vindhyArUDham";
			Name = "విన్ధ్యారూఢమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilambanIyA : Rule
	{
		public vilambanIyA()
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

			Rules = new string[][] { new string[] { "న", "భ", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vilambanIyA";
			Name = "విలమ్బనీయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhIradhvAnam : Rule
	{
		public dhIradhvAnam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "dhIradhvAnam";
			Name = "ధీరధ్వానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cUDApIDam : Rule
	{
		public cUDApIDam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "cUDApIDam";
			Name = "చూడాపీడమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vinandinI : Rule
	{
		public vinandinI()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "vinandinI";
			Name = "వినన్దినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gaganodgatA : Rule
	{
		public gaganodgatA()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "gaganodgatA";
			Name = "గగనోద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anantadAmA : Rule
	{
		public anantadAmA()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "anantadAmA";
			Name = "అనన్తదామా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dRptadehA : Rule
	{
		public dRptadehA()
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

			Rules = new string[][] { new string[] { "య", "ర", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "dRptadehA";
			Name = "దృప్తదేహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gaganagatikA : Rule
	{
		public gaganagatikA()
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

			Rules = new string[][] { new string[] { "ర", "స", "జ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "gaganagatikA";
			Name = "గగనగతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vAsantI :Rule 
	{ 
	public vAsantI()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"మ","త","న","మ","గా"}};
		Yati = new int[][]{};
		
		Identifier = "vAsantI";
		Name = "వాసన్తీ";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
	}*/
	/*public class vasantatilakA :Rule 
	{ 
		public vasantatilakA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","భ","జ","జ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "vasantatilakA";
			Name = "వసన్తతిలకా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kalpamIlitA : Rule
	{
		public kalpamIlitA()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "kalpamIlitA";
			Name = "కల్పమీలితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmalA : Rule
	{
		public kAmalA()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAmalA";
			Name = "కామలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhUrizikhA : Rule
	{
		public bhUrizikhA()
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

			Rules = new string[][] { new string[] { "స", "స", "మ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "bhUrizikhA";
			Name = "భూరిశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalpakAntA : Rule
	{
		public kalpakAntA()
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

			Rules = new string[][] { new string[] { "ర", "త", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "kalpakAntA";
			Name = "కల్పకాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class alakAlikA : Rule
	{
		public alakAlikA()
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

			Rules = new string[][] { new string[] { "త", "భ", "ర", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "alakAlikA";
			Name = "అలకాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vitAnitA : Rule
	{
		public vitAnitA()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "vitAnitA";
			Name = "వితానితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmazAlA : Rule
	{
		public kAmazAlA()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "kAmazAlA";
			Name = "కామశాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaMzottaMsA : Rule
	{
		public vaMzottaMsA()
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

			Rules = new string[][] { new string[] { "త", "య", "స", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vaMzottaMsA";
			Name = "వంశోత్తంసా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zAradacandraH :Rule 
	{ 
		public zAradacandraH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","య","స","భ","గా"}};
			Yati = new int[][]{};
		
			Identifier = "zAradacandraH";
			Name = "శారదచన్ద్రః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kAkiNikA : Rule
	{
		public kAkiNikA()
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

			Rules = new string[][] { new string[] { "జ", "జ", "భ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAkiNikA";
			Name = "కాకిణికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cakram : Rule
	{
		public cakram()
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

			Rules = new string[][] { new string[] { "భ", "న", "న", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "cakram";
			Name = "చక్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jaladarasitA : Rule
	{
		public jaladarasitA()
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

			Rules = new string[][] { new string[] { "న", "స", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "jaladarasitA";
			Name = "జలదరసితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class kalahetikA : Rule
	{
		public kalahetikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kalahetikA";
			Name = "కలహేతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bimbAlakSyam : Rule
	{
		public bimbAlakSyam()
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

			Rules = new string[][] { new string[] { "మ", "ర", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "bimbAlakSyam";
			Name = "బిమ్బాలక్ష్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalAdharaH : Rule
	{
		public kalAdharaH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "జ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "kalAdharaH";
			Name = "కలాధరః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAladhvAnam : Rule
	{
		public kAladhvAnam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "kAladhvAnam";
			Name = "కాలధ్వానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prapAtaH : Rule
	{
		public prapAtaH()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "prapAtaH";
			Name = "ప్రపాతః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sudhAdhArA : Rule
	{
		public sudhAdhArA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "త", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "sudhAdhArA";
			Name = "సుధాధరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sambodhA : Rule
	{
		public sambodhA()
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

			Rules = new string[][] { new string[] { "జ", "త", "న", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "sambodhA";
			Name = "సమ్బోధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class niryatpArAvAraH : Rule
	{
		public niryatpArAvAraH()
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

			Rules = new string[][] { new string[] { "మ", "త", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "niryatpArAvAraH";
			Name = "నిర్యత్పారావారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parIvAhaH : Rule
	{
		public parIvAhaH()
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

			Rules = new string[][] { new string[] { "న", "త", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "parIvAhaH";
			Name = "పరీవాహః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saGkalpAsAraH : Rule
	{
		public saGkalpAsAraH()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "saGkalpAsAraH";
			Name = "సఙ్కల్పాసారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class puSpazakaTikA : Rule
	{
		public puSpazakaTikA()
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

			Rules = new string[][] { new string[] { "భ", "స", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "puSpazakaTikA";
			Name = "పుష్పశకటికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pArAvAraH : Rule
	{
		public pArAvAraH()
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

			Rules = new string[][] { new string[] { "త", "న", "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "pArAvAraH";
			Name = "పారావారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pariNAhI : Rule
	{
		public pariNAhI()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "pariNAhI";
			Name = "పరిణాహీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirmuktamAlA : Rule
	{
		public nirmuktamAlA()
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

			Rules = new string[][] { new string[] { "మ", "ర", "భ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "nirmuktamAlA";
			Name = "నిర్ముక్తమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class prapannapAnIyam : Rule
	{
		public prapannapAnIyam()
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

			Rules = new string[][] { new string[] { "త", "య", "త", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "prapannapAnIyam";
			Name = "ప్రపన్నపానీయమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ratirekha : Rule
	{
		public ratirekha()
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

			Rules = new string[][] { new string[] { "త", "య", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "ratirekha";
			Name = "రతిరేఖ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saramAsaraNiH : Rule
	{
		public saramAsaraNiH()
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

			Rules = new string[][] { new string[] { "స", "స", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "saramAsaraNiH";
			Name = "సరమాసరణిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nAndImukhI : Rule
	{
		public nAndImukhI()
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

			Rules = new string[][] { new string[] { "న", "న", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "nAndImukhI";
			Name = "నాన్దీముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class manmathaH : Rule
	{
		public manmathaH()
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

			Rules = new string[][] { new string[] { "స", "స", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "manmathaH";
			Name = "మన్మథః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pathyA : Rule
	{
		public pathyA()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "pathyA";
			Name = "పథ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nAsAbharaNam : Rule
	{
		public nAsAbharaNam()
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

			Rules = new string[][] { new string[] { "త", "య", "భ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "nAsAbharaNam";
			Name = "నాసాభరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratibhAdarzanam : Rule
	{
		public pratibhAdarzanam()
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

			Rules = new string[][] { new string[] { "స", "భ", "త", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "pratibhAdarzanam";
			Name = "ప్రతిభాదర్శనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vipinatilakam : Rule
	{
		public vipinatilakam()
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

			Rules = new string[][] { new string[] { "న", "స", "న", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "vipinatilakam";
			Name = "విపినతిలకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class krIDitakaTakA : Rule
	{
		public krIDitakaTakA()
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

			Rules = new string[][] { new string[] { "భ", "స", "స", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "krIDitakaTakA";
			Name = "క్రీడితకటకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vANIbhUSA : Rule
	{
		public vANIbhUSA()
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

			Rules = new string[][] { new string[] { "మ", "మ", "త", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "vANIbhUSA";
			Name = "వాణీభూషా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarakalpA : Rule
	{
		public zarakalpA()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "zarakalpA";
			Name = "శరకల్పా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizakalitA : Rule
	{
		public vizakalitA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "vizakalitA";
			Name = "విశకలితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vajrAlI : Rule
	{
		public vajrAlI()
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

			Rules = new string[][] { new string[] { "త", "య", "మ", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "vajrAlI";
			Name = "వజ్రాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mayUvadanA : Rule
	{
		public mayUvadanA()
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

			Rules = new string[][] { new string[] { "భ", "జ", "జ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "mayUvadanA";
			Name = "మయూవదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karNalatA : Rule
	{
		public karNalatA()
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

			Rules = new string[][] { new string[] { "స", "భ", "భ", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "karNalatA";
			Name = "కర్ణలతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class mitasakthi : Rule
	{
		public mitasakthi()
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

			Rules = new string[][] { new string[] { "న", "స", "స", "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "mitasakthi";
			Name = "మితసక్థి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jananidhivelA : Rule
	{
		public jananidhivelA()
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

			Rules = new string[][] { new string[] { "న", "య", "స", "మ", "స" } };
			Yati = new int[][] { };

			Identifier = "jananidhivelA";
			Name = "జననిధివేలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nizipAlam : Rule
	{
		public nizipAlam()
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

			Rules = new string[][] { new string[] { "భ", "జ", "స", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "nizipAlam";
			Name = "నిశిపాలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarahatiH : Rule
	{
		public zarahatiH()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న" } };
			Yati = new int[][] { };

			Identifier = "zarahatiH";
			Name = "శరహతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class camarIcaram : Rule
	{
		public camarIcaram()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "camarIcaram";
			Name = "చమరీచరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zAntasurabhiH : Rule
	{
		public zAntasurabhiH()
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

			Rules = new string[][] { new string[] { "భ", "న", "ర", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "zAntasurabhiH";
			Name = "శాన్తసురభిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sphoTakRIDam : Rule
	{
		public sphoTakRIDam()
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

			Rules = new string[][] { new string[] { "న", "య", "మ", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "sphoTakRIDam";
			Name = "స్ఫోటకృఈడమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madanamAlikA : Rule
	{
		public madanamAlikA()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "madanamAlikA";
			Name = "మదనమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class plavaGgamaH : Rule
	{
		public plavaGgamaH()
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

			Rules = new string[][] { new string[] { "భ", "భ", "త", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "plavaGgamaH";
			Name = "ప్లవఙ్గమః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class UhinI : Rule
	{
		public UhinI()
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

			Rules = new string[][] { new string[] { "ర", "స", "య", "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "UhinI";
			Name = "ఊహినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class citrA : Rule
	{
		public citrA()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "citrA";
			Name = "చిత్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class siMhapuccham : Rule
	{
		public siMhapuccham()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "siMhapuccham";
			Name = "సింహపుచ్ఛమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class elA : Rule
	{
		public elA()
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

			Rules = new string[][] { new string[] { "స", "జ", "న", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "elA";
			Name = "ఏలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mAlinI :Rule 
	{ 
		public mAlinI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","మ","య","య"}};
			Yati = new int[][]{};
		
			Identifier = "mAlinI";
			Name = "మాలినీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class Anaddham : Rule
	{
		public Anaddham()
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

			Rules = new string[][] { new string[] { "ర", "న", "స", "త", "మ" } };
			Yati = new int[][] { };

			Identifier = "Anaddham";
			Name = "ఆనద్ధమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zIrzavirahitA : Rule
	{
		public zIrzavirahitA()
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

			Rules = new string[][] { new string[] { "త", "య", "భ", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "zIrzavirahitA";
			Name = "శీర్శవిరహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class tUNakam :Rule 
	{ 
		public tUNakam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","జ","ర","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "tUNakam";
			Name = "తూణకమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class zaGkAvalI : Rule
	{
		public zaGkAvalI()
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

			Rules = new string[][] { new string[] { "త", "భ", "ర", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "zaGkAvalI";
			Name = "శఙ్కావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dIpakam : Rule
	{
		public dIpakam()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "త", "య" } };
			Yati = new int[][] { };

			Identifier = "dIpakam";
			Name = "దీపకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhoritam : Rule
	{
		public dhoritam()
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

			Rules = new string[][] { new string[] { "భ", "న", "ర", "ర", "స" } };
			Yati = new int[][] { };

			Identifier = "dhoritam";
			Name = "ధోరితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAriNI : Rule
	{
		public sAriNI()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "sAriNI";
			Name = "సారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zazikalA :Rule 
	{ 
		public zazikalA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","న","న","స"}};
			Yati = new int[][]{};
		
			Identifier = "zazikalA";
			Name = "శశికలా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class cArvaTakam : Rule
	{
		public cArvaTakam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "భ", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "cArvaTakam";
			Name = "చార్వటకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maNihaMsaH : Rule
	{
		public maNihaMsaH()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "maNihaMsaH";
			Name = "మణిహంసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumAralIlA : Rule
	{
		public kumAralIlA()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "kumAralIlA";
			Name = "కుమారలీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lAsyakArI : Rule
	{
		public lAsyakArI()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "lAsyakArI";
			Name = "లాస్యకారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lIlAcandram : Rule
	{
		public lIlAcandram()
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

			Rules = new string[][] { new string[] { "మ", "మ", "త", "య", "స" } };
			Yati = new int[][] { };

			Identifier = "lIlAcandram";
			Name = "లీలాచన్ద్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lIlAlekhaH : Rule
	{
		public lIlAlekhaH()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "మ" } };
			Yati = new int[][] { };

			Identifier = "lIlAlekhaH";
			Name = "లీలాలేఖః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parimalam : Rule
	{
		public parimalam()
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

			Rules = new string[][] { new string[] { "న", "య", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "parimalam";
			Name = "పరిమలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bahulAbhram : Rule
	{
		public bahulAbhram()
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

			Rules = new string[][] { new string[] { "స", "భ", "స", "భ", "మ" } };
			Yati = new int[][] { };

			Identifier = "bahulAbhram";
			Name = "బహులాభ్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parikhAyatanam : Rule
	{
		public parikhAyatanam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "parikhAyatanam";
			Name = "పరిఖాయతనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class candrApIDam : Rule
	{
		public candrApIDam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "candrApIDam";
			Name = "చన్ద్రాపీడమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class narAcaH :Rule 
	{ 
		public narAcaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","ర","జ","ర","జ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "narAcaH";
			Name = "నరాచః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class dantAlikA : Rule
	{
		public dantAlikA()
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

			Rules = new string[][] { new string[] { "త", "మ", "ర", "మ", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "dantAlikA";
			Name = "దన్తాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vANinI :Rule 
	{ 
		public vANinI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","భ","జ","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "vANinI";
			Name = "వాణినీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kamalaparam : Rule
	{
		public kamalaparam()
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

			Rules = new string[][] { new string[] { "న", "య", "న", "య", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kamalaparam";
			Name = "కమలపరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaladhautapadam : Rule
	{
		public kaladhautapadam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "kaladhautapadam";
			Name = "కలధౌతపదమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cakitA : Rule
	{
		public cakitA()
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

			Rules = new string[][] { new string[] { "భ", "స", "మ", "త", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "cakitA";
			Name = "చకితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class citram :Rule 
	{ 
		public citram()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","జ","ర","జ","ర","ల"}};
			Yati = new int[][]{};
		
			Identifier = "citram";
			Name = "చిత్రమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class garuDarutam : Rule
	{
		public garuDarutam()
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

			Rules = new string[][] { new string[] { "న", "జ", "భ", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "garuDarutam";
			Name = "గరుడరుతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalahakaram : Rule
	{
		public kalahakaram()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalahakaram";
			Name = "కలహకరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalpadhAri : Rule
	{
		public kalpadhAri()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "జ", "ర", "ల" } };
			Yati = new int[][] { };

			Identifier = "kalpadhAri";
			Name = "కల్పధారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalpAhArI : Rule
	{
		public kalpAhArI()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalpAhArI";
			Name = "కల్పాహారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sAravarohA : Rule
	{
		public sAravarohA()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "త", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "sAravarohA";
			Name = "సారవరోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class narazikhI : Rule
	{
		public narazikhI()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "స", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "narazikhI";
			Name = "నరశిఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sUtazikhA : Rule
	{
		public sUtazikhA()
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

			Rules = new string[][] { new string[] { "త", "య", "స", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "sUtazikhA";
			Name = "సూతశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhogAvaliH : Rule
	{
		public bhogAvaliH()
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

			Rules = new string[][] { new string[] { "త", "న", "న", "య", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhogAvaliH";
			Name = "భోగావలిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vakrAvalokaH : Rule
	{
		public vakrAvalokaH()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "vakrAvalokaH";
			Name = "వక్రావలోకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class valivadanam : Rule
	{
		public valivadanam()
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

			Rules = new string[][] { new string[] { "న", "య", "మ", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "valivadanam";
			Name = "వలివదనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class taravArikA : Rule
	{
		public taravArikA()
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

			Rules = new string[][] { new string[] { "న", "స", "స", "జ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "taravArikA";
			Name = "తరవారికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class RSabhagajavilasitam :Rule 
	{ 
		public RSabhagajavilasitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","ర","న","న","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "RSabhagajavilasitam";
			Name = "ఋషభగజవిలసితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class bhImAvarttaH : Rule
	{
		public bhImAvarttaH()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhImAvarttaH";
			Name = "భీమావర్త్తః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ArabhaTI : Rule
	{
		public ArabhaTI()
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

			Rules = new string[][] { new string[] { "భ", "భ", "న", "జ", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "ArabhaTI";
			Name = "ఆరభటీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kulyAvarttam : Rule
	{
		public kulyAvarttam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "స", "భ", "త", "ల" } };
			Yati = new int[][] { };

			Identifier = "kulyAvarttam";
			Name = "కుల్యావర్త్తమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class abhidhAtrI : Rule
	{
		public abhidhAtrI()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "జ", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "abhidhAtrI";
			Name = "అభిధాత్రీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zizubharaNam :Rule 
	{ 
		public zizubharaNam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","న","న","స","గ"}};
			Yati = new int[][]{};
		
			Identifier = "zizubharaNam";
			Name = "శిశుభరణమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class pravaralalitam :Rule 
	{ 
		public pravaralalitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"య","మ","న","స","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "pravaralalitam";
			Name = "ప్రవరలలితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class khagatiH :Rule 
	{ 
		public khagatiH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","భ","భ","భ","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "khagatiH";
			Name = "ఖగతిః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class mAlyopastham : Rule
	{
		public mAlyopastham()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "య", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "mAlyopastham";
			Name = "మాల్యోపస్థమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class acaladhRtiH : Rule
	{
		public acaladhRtiH()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "ల" } };
			Yati = new int[][] { };

			Identifier = "acaladhRtiH";
			Name = "అచలధృతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madanalalitA : Rule
	{
		public madanalalitA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "మ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "madanalalitA";
			Name = "మదనలలితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class troTakam : Rule
	{
		public troTakam()
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

			Rules = new string[][] { new string[] { "న", "జ", "ర", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "troTakam";
			Name = "త్రోటకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAlAvalayam : Rule
	{
		public mAlAvalayam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "mAlAvalayam";
			Name = "మాలావలయమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratIpavallI : Rule
	{
		public pratIpavallI()
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

			Rules = new string[][] { new string[] { "స", "స", "భ", "ర", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "pratIpavallI";
			Name = "ప్రతీపవల్లీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class anilohA : Rule
	{
		public anilohA()
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

			Rules = new string[][] { new string[] { "స", "భ", "త", "య", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "anilohA";
			Name = "అనిలోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class phalguH : Rule
	{
		public phalguH()
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

			Rules = new string[][] { new string[] { "స", "భ", "స", "భ", "స", "హ" } };
			Yati = new int[][] { };

			Identifier = "phalguH";
			Name = "ఫల్గుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAlAdharaH : Rule
	{
		public mAlAdharaH()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "mAlAdharaH";
			Name = "మాలాధరః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bAlavikrIDitam : Rule
	{
		public bAlavikrIDitam()
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

			Rules = new string[][] { new string[] { "భ", "స", "జ", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "bAlavikrIDitam";
			Name = "బాలవిక్రీడితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class krUrAzanam : Rule
	{
		public krUrAzanam()
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

			Rules = new string[][] { new string[] { "త", "న", "త", "న", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "krUrAzanam";
			Name = "క్రూరాశనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zukavanitA : Rule
	{
		public zukavanitA()
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

			Rules = new string[][] { new string[] { "స", "స", "భ", "భ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "zukavanitA";
			Name = "శుకవనితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidhuravirahitA : Rule
	{
		public vidhuravirahitA()
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

			Rules = new string[][] { new string[] { "స", "త", "య", "భ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "vidhuravirahitA";
			Name = "విధురవిరహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mandAkrAntA :Rule 
	{ 
		public mandAkrAntA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","భ","న","త","త","గా"}};
			Yati = new int[][]{};
		
			Identifier = "mandAkrAntA";
			Name = "మన్దాక్రాన్తా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class titikSA : Rule
	{
		public titikSA()
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

			Rules = new string[][] { new string[] { "భ", "న", "య", "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "titikSA";
			Name = "తితిక్షా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zAyinI : Rule
	{
		public zAyinI()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "భ", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "zAyinI";
			Name = "శాయినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class atizAyinI : Rule
	{
		public atizAyinI()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "భ", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "atizAyinI";
			Name = "అతిశాయినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class salekhA : Rule
	{
		public salekhA()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "salekhA";
			Name = "సలేఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAnAkrAntA : Rule
	{
		public mAnAkrAntA()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "mAnAkrAntA";
			Name = "మానాక్రాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hariNI : Rule
	{
		public hariNI()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "hariNI";
			Name = "హారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhArAkrAntA : Rule
	{
		public bhArAkrAntA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "ర", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "bhArAkrAntA";
			Name = "భారాక్రాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaMzalaH : Rule
	{
		public vaMzalaH()
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

			Rules = new string[][] { new string[] { "భ", "త", "జ", "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "vaMzalaH";
			Name = "వంశలః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class acalanayanam : Rule
	{
		public acalanayanam()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "లల" } };
			Yati = new int[][] { };

			Identifier = "acalanayanam";
			Name = "అచలనయనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class vaMzapatrapatitam :Rule 
	{ 
		public vaMzapatrapatitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","ర","న","భ","న","వ"}};
			Yati = new int[][]{};
		
			Identifier = "vaMzapatrapatitam";
			Name = "వంశపత్రపతితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kAsAram : Rule
	{
		public kAsAram()
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

			Rules = new string[][] { new string[] { "మ", "మ", "త", "న", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAsAram";
			Name = "కాసారమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karNasphoTam : Rule
	{
		public karNasphoTam()
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

			Rules = new string[][] { new string[] { "న", "య", "త", "న", "మ", "హ" } };
			Yati = new int[][] { };

			Identifier = "karNasphoTam";
			Name = "కర్ణస్ఫోటమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class nardaTakam :Rule 
	{ 
		public nardaTakam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","భ","జ","జ","వ"}};
			Yati = new int[][]{};
		
			Identifier = "nardaTakam";
			Name = "నర్దటకమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class pratIhAraH : Rule
	{
		public pratIhAraH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "pratIhAraH";
			Name = "ప్రతీహారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAlasAroddhataH : Rule
	{
		public kAlasAroddhataH()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAlasAroddhataH";
			Name = "కాలసారోద్ధతః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zikhariNI :Rule 
	{ 
		public zikhariNI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"య","మ","న","స","భ","వ"}};
			Yati = new int[][]{};
		
			Identifier = "zikhariNI";
			Name = "శిఖరిణీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class valvajam : Rule
	{
		public valvajam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "త", "న", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "valvajam";
			Name = "వల్వజమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAmarUpam : Rule
	{
		public kAmarUpam()
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

			Rules = new string[][] { new string[] { "మ", "ర", "భ", "న", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "kAmarUpam";
			Name = "కామరూపమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIravizrAmaH : Rule
	{
		public vIravizrAmaH()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "న", "ర", "గా" } };
			Yati = new int[][] { };

			Identifier = "vIravizrAmaH";
			Name = "వీరవిశ్రామః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class pRthvI :Rule 
	{ 
		public pRthvI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"జ","స","జ","స","య","వ"}};
			Yati = new int[][]{};
		
			Identifier = "pRthvI";
			Name = "పృథ్వీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kAntAram : Rule
	{
		public kAntAram()
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

			Rules = new string[][] { new string[] { "య", "మ", "న", "స", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "kAntAram";
			Name = "కాన్తారమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAhAntaritam : Rule
	{
		public vAhAntaritam()
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

			Rules = new string[][] { new string[] { "త", "న", "భ", "భ", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "vAhAntaritam";
			Name = "వాహాన్తరితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virudarutam : Rule
	{
		public virudarutam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "virudarutam";
			Name = "విరుదరుతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class nArAcam :Rule 
	{ 
		public nArAcam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","ర","ర","ర","ర"}};
			Yati = new int[][]{};
		
			Identifier = "nArAcam";
			Name = "నారాచమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class pArthivam : Rule
	{
		public pArthivam()
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

			Rules = new string[][] { new string[] { "జ", "స", "జ", "స", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "pArthivam";
			Name = "పార్థివమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tumulakam : Rule
	{
		public tumulakam()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న" } };
			Yati = new int[][] { };

			Identifier = "tumulakam";
			Name = "తుములకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nandanam : Rule
	{
		public nandanam()
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

			Rules = new string[][] { new string[] { "న", "జ", "భ", "జ", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "nandanam";
			Name = "నన్దనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maJjIrA : Rule
	{
		public maJjIrA()
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

			Rules = new string[][] { new string[] { "మ", "మ", "భ", "మ", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "maJjIrA";
			Name = "మఞ్జీరా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parviNI : Rule
	{
		public parviNI()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "న", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "parviNI";
			Name = "పర్విణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pataGgapAdaH : Rule
	{
		public pataGgapAdaH()
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

			Rules = new string[][] { new string[] { "జ", "త", "త", "త", "త", "త" } };
			Yati = new int[][] { };

			Identifier = "pataGgapAdaH";
			Name = "పతఙ్గపాదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilulitavanamAlA : Rule
	{
		public vilulitavanamAlA()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "న", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "vilulitavanamAlA";
			Name = "విలులితవనమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zArdUlalalitam : Rule
	{
		public zArdUlalalitam()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "స", "త", "స" } };
			Yati = new int[][] { };

			Identifier = "zArdUlalalitam";
			Name = "శార్దూలలలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class daNDI : Rule
	{
		public daNDI()
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

			Rules = new string[][] { new string[] { "త", "న", "త", "న", "త", "స" } };
			Yati = new int[][] { };

			Identifier = "daNDI";
			Name = "దణ్డీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mattakokilam :Rule 
	{ 
		public mattakokilam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"ర","స","జ","జ","భ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "mattakokilam";
			Name = "మత్తకోకిలమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class vasupadamaJjarI : Rule
	{
		public vasupadamaJjarI()
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

			Rules = new string[][] { new string[] { "న", "జ", "భ", "జ", "జ", "ర" } };
			Yati = new int[][] { };

			Identifier = "vasupadamaJjarI";
			Name = "వసుపదమఞ్జరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class azvagatiH : Rule
	{
		public azvagatiH()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "స" } };
			Yati = new int[][] { };

			Identifier = "azvagatiH";
			Name = "అశ్వగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hariNaplutam : Rule
	{
		public hariNaplutam()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "జ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "hariNaplutam";
			Name = "హరిణప్లుతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kroDakrIDam : Rule
	{
		public kroDakrIDam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "న", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "kroDakrIDam";
			Name = "క్రోడక్రీడమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class krIDacandram : Rule
	{
		public krIDacandram()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "krIDacandram";
			Name = "క్రీడచన్ద్రమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hIrakahAradharam : Rule
	{
		public hIrakahAradharam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ" } };
			Yati = new int[][] { };

			Identifier = "hIrakahAradharam";
			Name = "హీరకహారధరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class candralekhA : Rule
	{
		public candralekhA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "candralekhA";
			Name = "చన్ద్రలేఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIlazArdUlam : Rule
	{
		public nIlazArdUlam()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "nIlazArdUlam";
			Name = "నీలశార్దూలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class SaTpaderitam : Rule
	{
		public SaTpaderitam()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "ర", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "SaTpaderitam";
			Name = "షట్పదేరితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class parAmodaH : Rule
	{
		public parAmodaH()
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

			Rules = new string[][] { new string[] { "య", "స", "స", "జ", "న", "మ" } };
			Yati = new int[][] { };

			Identifier = "parAmodaH";
			Name = "పరామోదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ardhAntarAlApi : Rule
	{
		public ardhAntarAlApi()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "త", "త", "త" } };
			Yati = new int[][] { };

			Identifier = "ardhAntarAlApi";
			Name = "అర్ధాన్తరాలాపి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class satketuH : Rule
	{
		public satketuH()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "జ", "ర", "య" } };
			Yati = new int[][] { };

			Identifier = "satketuH";
			Name = "సత్కేతుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sindhusauvIram : Rule
	{
		public sindhusauvIram()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "sindhusauvIram";
			Name = "సిన్ధుసౌవీరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paripoSakam : Rule
	{
		public paripoSakam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "paripoSakam";
			Name = "పరిపోషకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class kusumitalatAvellitA :Rule 
	{ 
		public kusumitalatAvellitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","త","న","య","య","య"}};
			Yati = new int[][]{};
		
			Identifier = "kusumitalatAvellitA";
			Name = "కుసుమితలతావేల్లితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class zambhuH :Rule 
	{ 
		public zambhuH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","త","య","భ","మ","మ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "zambhuH";
			Name = "శమ్భుః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class prapaJcacAmaram : Rule
	{
		public prapaJcacAmaram()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "prapaJcacAmaram";
			Name = "ప్రపఞ్చచామరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chAyA : Rule
	{
		public chAyA()
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

			Rules = new string[][] { new string[] { "య", "మ", "న", "స", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "chAyA";
			Name = "ఛాయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class phulladAma : Rule
	{
		public phulladAma()
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

			Rules = new string[][] { new string[] { "మ", "త", "న", "స", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "phulladAma";
			Name = "ఫుల్లదామ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jhillIlIlA : Rule
	{
		public jhillIlIlA()
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

			Rules = new string[][] { new string[] { "న", "య", "మ", "మ", "జ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "jhillIlIlA";
			Name = "ఝిల్లీలీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nirgalitamekhalA : Rule
	{
		public nirgalitamekhalA()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "న", "భ", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "nirgalitamekhalA";
			Name = "నిర్గలితమేఖలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lolalolambalIlam : Rule
	{
		public lolalolambalIlam()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "lolalolambalIlam";
			Name = "లోలలోలమ్బలీలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class grAvAstaraNam : Rule
	{
		public grAvAstaraNam()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "మ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "grAvAstaraNam";
			Name = "గ్రావాస్తరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalpalatApatAkinI : Rule
	{
		public kalpalatApatAkinI()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "స", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalpalatApatAkinI";
			Name = "కల్పలతాపతాకినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mArAbhisaraNam : Rule
	{
		public mArAbhisaraNam()
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

			Rules = new string[][] { new string[] { "త", "న", "మ", "భ", "స", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "mArAbhisaraNam";
			Name = "మారాభిసరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zilImukhojjRmbhitam : Rule
	{
		public zilImukhojjRmbhitam()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "న", "జ", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "zilImukhojjRmbhitam";
			Name = "శిలీముఖోజ్జృమ్భితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class TaGkaNam : Rule
	{
		public TaGkaNam()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "న", "ర", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "TaGkaNam";
			Name = "టఙ్కణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kiraNakIrttiH : Rule
	{
		public kiraNakIrttiH()
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

			Rules = new string[][] { new string[] { "త", "జ", "త", "భ", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "kiraNakIrttiH";
			Name = "కిరణకీర్త్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class surasA : Rule
	{
		public surasA()
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

			Rules = new string[][] { new string[] { "మ", "ర", "భ", "న", "య", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "surasA";
			Name = "సురసా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class meghavisphUrjitA :Rule 
	{ 
		public meghavisphUrjitA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"య","మ","న","స","ర","ర","గ"}};
			Yati = new int[][]{};
		
			Identifier = "meghavisphUrjitA";
			Name = "మేఘవిస్ఫూర్జితా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class dhavalam : Rule
	{
		public dhavalam()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "dhavalam";
			Name = "ధవలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidhunidhuvanam : Rule
	{
		public vidhunidhuvanam()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "త", "న", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vidhunidhuvanam";
			Name = "విధునిధువనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class zArdUlavikrIDitam :Rule 
	{ 
		public zArdUlavikrIDitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","స","జ","స","త","త","గ"}};
			Yati = new int[][]{};
		
			Identifier = "zArdUlavikrIDitam";
			Name = "శార్దూలవిక్రీడితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kalApadIpakam : Rule
	{
		public kalApadIpakam()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", "ర", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "kalApadIpakam";
			Name = "కలాపదీపకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhekAlokaH : Rule
	{
		public bhekAlokaH()
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

			Rules = new string[][] { new string[] { "భ", "మ", "మ", "త", "న", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhekAlokaH";
			Name = "భేకాలోకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class mattebhavikrIDitam :Rule 
	{ 
		public mattebhavikrIDitam()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"స","భ","ర","న","మ","య","వ"}};
			Yati = new int[][]{};
		
			Identifier = "mattebhavikrIDitam";
			Name = "మత్తేభవిక్రీడితమ్";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class viSvagvitAnam : Rule
	{
		public viSvagvitAnam()
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

			Rules = new string[][] { new string[] { "త", "భ", "జ", "న", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "viSvagvitAnam";
			Name = "విష్వగ్వితానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class suvadanA : Rule
	{
		public suvadanA()
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

			Rules = new string[][] { new string[] { "మ", "ర", "భ", "న", "య", "భ", "వ" } };
			Yati = new int[][] { };

			Identifier = "suvadanA";
			Name = "సువదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vANIvANaH : Rule
	{
		public vANIvANaH()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "త", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "vANIvANaH";
			Name = "వాణీవాణః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIravimAnam : Rule
	{
		public vIravimAnam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vIravimAnam";
			Name = "వీరవిమానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saurabhazobhAsAraH : Rule
	{
		public saurabhazobhAsAraH()
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

			Rules = new string[][] { new string[] { "భ", "మ", "త", "న", "స", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "saurabhazobhAsAraH";
			Name = "సౌరభశోభాసారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhUrizobhA : Rule
	{
		public bhUrizobhA()
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

			Rules = new string[][] { new string[] { "మ", "మ", "న", "న", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhUrizobhA";
			Name = "భూరిశోభా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zobhA : Rule
	{
		public zobhA()
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

			Rules = new string[][] { new string[] { "య", "మ", "న", "న", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "zobhA";
			Name = "శోభా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhArAvatAraH : Rule
	{
		public bhArAvatAraH()
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

			Rules = new string[][] { new string[] { "న", "త", "జ", "న", "న", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhArAvatAraH";
			Name = "భారావతారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gItikA : Rule
	{
		public gItikA()
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

			Rules = new string[][] { new string[] { "స", "జ", "జ", "భ", "ర", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "gItikA";
			Name = "గీతికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class IdRSam : Rule
	{
		public IdRSam()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", "ర", "జ", "హ" } };
			Yati = new int[][] { };

			Identifier = "IdRSam";
			Name = "ఈదృషమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class utpalamAlikA :Rule 
	{ 
		public utpalamAlikA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","ర","న","భ","భ","ర","వ"}};
			Yati = new int[][]{};
		
			Identifier = "utpalamAlikA";
			Name = "ఉత్పలమాలికా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class avandhyopacAraH : Rule
	{
		public avandhyopacAraH()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "avandhyopacAraH";
			Name = "అవన్ధ్యోపచారః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saMlakSyalIlA : Rule
	{
		public saMlakSyalIlA()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "ర", "న", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "saMlakSyalIlA";
			Name = "సంలక్ష్యలీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class talpakatallajam : Rule
	{
		public talpakatallajam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "జ", "మ" } };
			Yati = new int[][] { };

			Identifier = "talpakatallajam";
			Name = "తల్పకతల్లజమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mandAkSamandaram : Rule
	{
		public mandAkSamandaram()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "మ", "జ", "ర", "మ" } };
			Yati = new int[][] { };

			Identifier = "mandAkSamandaram";
			Name = "మన్దాక్షమన్దరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class azokalokaH : Rule
	{
		public azokalokaH()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "త", "ర", "మ" } };
			Yati = new int[][] { };

			Identifier = "azokalokaH";
			Name = "అశోకలోకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class taDidambaram : Rule
	{
		public taDidambaram()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "భ" } };
			Yati = new int[][] { };

			Identifier = "taDidambaram";
			Name = "తడిదమ్బరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kanakamAlikA : Rule
	{
		public kanakamAlikA()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "న", "ర", "న", "ర" } };
			Yati = new int[][] { };

			Identifier = "kanakamAlikA";
			Name = "కనకమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pratimA : Rule
	{
		public pratimA()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "pratimA";
			Name = "ప్రతిమా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kamalazikhA : Rule
	{
		public kamalazikhA()
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

			Rules = new string[][] { new string[] { "న", "య", "మ", "భ", "స", "స", "స" } };
			Yati = new int[][] { };

			Identifier = "kamalazikhA";
			Name = "కమలశిఖా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalitalalAma : Rule
	{
		public lalitalalAma()
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

			Rules = new string[][] { new string[] { "న", "జ", "త", "త", "త", "త", "స" } };
			Yati = new int[][] { };

			Identifier = "lalitalalAma";
			Name = "లలితలలామ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vidyadAlI : Rule
	{
		public vidyadAlI()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "vidyadAlI";
			Name = "విద్యదాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class sarasI :Rule 
	{ 
		public sarasI()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","భ","జ","జ","జ","ర"}};
			Yati = new int[][]{};
		
			Identifier = "sarasI";
			Name = "సరసీ";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class sragdharA :Rule 
	{ 
		public sragdharA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"మ","ర","భ","న","య","య","య"}};
			Yati = new int[][]{};
		
			Identifier = "sragdharA";
			Name = "స్రగ్ధరా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class kalamatallikA : Rule
	{
		public kalamatallikA()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "ర", "న", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "kalamatallikA";
			Name = "కలమతల్లికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dUrAvalokaH : Rule
	{
		public dUrAvalokaH()
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

			Rules = new string[][] { new string[] { "మ", "ర", "భ", "న", "య", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "dUrAvalokaH";
			Name = "దూరావలోకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarakANDaprakANDam : Rule
	{
		public zarakANDaprakANDam()
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

			Rules = new string[][] { new string[] { "స", "ర", "న", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "zarakANDaprakANDam";
			Name = "శరకాణ్డప్రకాణ్డమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class svarNAbharaNam : Rule
	{
		public svarNAbharaNam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "న", "య", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "svarNAbharaNam";
			Name = "స్వర్ణాభరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhastrAnistaraNam : Rule
	{
		public bhastrAnistaraNam()
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

			Rules = new string[][] { new string[] { "మ", "స", "భ", "న", "జ", "ర", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhastrAnistaraNam";
			Name = "భస్త్రానిస్తరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arbhakamAlA : Rule
	{
		public arbhakamAlA()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "త", "న", "మ", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "arbhakamAlA";
			Name = "అర్భకమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhadrakam : Rule
	{
		public bhadrakam()
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

			Rules = new string[][] { new string[] { "భ", "ర", "న", "స", "న", "ర", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhadrakam";
			Name = "భద్రకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgoddhatam : Rule
	{
		public bhujaGgoddhatam()
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

			Rules = new string[][] { new string[] { "త", "భ", "ర", "ర", "స", "ర", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhujaGgoddhatam";
			Name = "భుజఙ్గోద్ధతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class acalaviratiH :Rule 
	{ 
		public acalaviratiH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","న","న","న","న","న","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "acalaviratiH";
			Name = "అచలవిరతిః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class sitastavakaH :Rule 
	{ 
		public sitastavakaH()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"త","భ","య","జ","స","ర","న","గ"}};
			Yati = new int[][]{};
		
			Identifier = "sitastavakaH";
			Name = "సితస్తవకః";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}
	public class madirA :Rule 
	{ 
		public madirA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"భ","భ","భ","భ","భ","భ","భ","గ"}};
			Yati = new int[][]{};
		
			Identifier = "madirA";
			Name = "మదిరా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class bhogAvalI : Rule
	{
		public bhogAvalI()
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

			Rules = new string[][] { new string[] { "త", "భ", "ర", "స", "న", "న", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhogAvalI";
			Name = "భోగావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class niSkalakaNThI : Rule
	{
		public niSkalakaNThI()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స", "త", "య", "స", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "niSkalakaNThI";
			Name = "నిష్కలకణ్ఠీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vanavAsinI : Rule
	{
		public vanavAsinI()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "భ", "ర", "న", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "vanavAsinI";
			Name = "వనవాసినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class drutamukham : Rule
	{
		public drutamukham()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "మ", "ర", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "drutamukham";
			Name = "ద్రుతముఖమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ayamAnam : Rule
	{
		public ayamAnam()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "ayamAnam";
			Name = "అయమానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIranIrAjanA : Rule
	{
		public vIranIrAjanA()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "vIranIrAjanA";
			Name = "వీరనీరాజనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhImAbhogaH : Rule
	{
		public bhImAbhogaH()
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

			Rules = new string[][] { new string[] { "మ", "త", "త", "మ", "మ", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhImAbhogaH";
			Name = "భీమాభోగః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaGkaNakvANaH : Rule
	{
		public kaGkaNakvANaH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "kaGkaNakvANaH";
			Name = "కఙ్కణక్వాణః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsakalIlA : Rule
	{
		public vAsakalIlA()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స", "త", "య", "భ", "మ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vAsakalIlA";
			Name = "వాసకలీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaGkaNakvANavANI : Rule
	{
		public kaGkaNakvANavANI()
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

			Rules = new string[][] { new string[] { "మ", "ర", "ర", "ర", "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "kaGkaNakvANavANI";
			Name = "కఙ్కణక్వాణవాణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saMbhRtazaradhiH : Rule
	{
		public saMbhRtazaradhiH()
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

			Rules = new string[][] { new string[] { "భ", "న", "య", "భ", "న", "య", "స", "హ" } };
			Yati = new int[][] { };

			Identifier = "saMbhRtazaradhiH";
			Name = "సంభృతశరధిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paridhAnIyam : Rule
	{
		public paridhAnIyam()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "త", "జ", "య", "స", "గా" } };
			Yati = new int[][] { };

			Identifier = "paridhAnIyam";
			Name = "పరిధానీయమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAnavatI : Rule
	{
		public mAnavatI()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "జ", "జ", "జ", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "mAnavatI";
			Name = "మానవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	/*public class adritanayA :Rule 
	{ 
		public adritanayA()
		{ 
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType =PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa=false;
			InfiniteLength = false;

			Rules = new string[][]{new string[]{"న","జ","భ","జ","భ","జ","భ","వ"}};
			Yati = new int[][]{};
		
			Identifier = "adritanayA";
			Name = "అద్రితనయా";
					
			Examples = new string[]{};
		
			References=new string[]{};
		}
	}*/
	public class mantharAyanam : Rule
	{
		public mantharAyanam()
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

			Rules = new string[][] { new string[] { "న", "ర", "న", "న", "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "mantharAyanam";
			Name = "మన్థరాయనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vipulAyitam : Rule
	{
		public vipulAyitam()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "భ", "న", "జ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "vipulAyitam";
			Name = "విపులాయితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class amaracamarI : Rule
	{
		public amaracamarI()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "amaracamarI";
			Name = "అమరచమరీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cakoraH : Rule
	{
		public cakoraH()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "భ", "హ" } };
			Yati = new int[][] { };

			Identifier = "cakoraH";
			Name = "చకోరః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pArAvArAntastham : Rule
	{
		public pArAvArAntastham()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "స", "భ", "స", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "pArAvArAntastham";
			Name = "పారావారాన్తస్థమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilambalalitam : Rule
	{
		public vilambalalitam()
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

			Rules = new string[][] { new string[] { "జ", "స", "జ", "స", "జ", "స", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "vilambalalitam";
			Name = "విలమ్బలలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gotragarIyaH : Rule
	{
		public gotragarIyaH()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "త", "య", "న", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "gotragarIyaH";
			Name = "గోత్రగరీయః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class indravimAnam : Rule
	{
		public indravimAnam()
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

			Rules = new string[][] { new string[] { "భ", "త", "న", "మ", "భ", "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "indravimAnam";
			Name = "ఇన్ద్రవిమానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mattagajendraH : Rule
	{
		public mattagajendraH()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "mattagajendraH";
			Name = "మత్తగజేన్ద్రః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rAmAbaddham : Rule
	{
		public rAmAbaddham()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "భ", "త", "న", "త", "వ" } };
			Yati = new int[][] { };

			Identifier = "rAmAbaddham";
			Name = "రామాబద్ధమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pulakAJcitam : Rule
	{
		public pulakAJcitam()
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

			Rules = new string[][] { new string[] { "భ", "స", "న", "య", "న", "న", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "pulakAJcitam";
			Name = "పులకాఞ్చితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilAsavAsaH : Rule
	{
		public vilAsavAsaH()
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

			Rules = new string[][] { new string[] { "భ", "స", "భ", "భ", "స", "జ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vilAsavAsaH";
			Name = "విలాసవాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}


	public class anAmayam : Rule
	{
		public anAmayam()
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

			Rules = new string[][] { new string[] { "జ", "జ", "జ", "జ", "జ", "జ", "జ", "జ" } };
			Yati = new int[][] { };

			Identifier = "anAmayam";
			Name = "అనామయమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zambaram : Rule
	{
		public zambaram()
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

			Rules = new string[][] { new string[] { "న", "భ", "భ", "ర", "న", "భ", "భ", "ర" } };
			Yati = new int[][] { };

			Identifier = "zambaram";
			Name = "శమ్బరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class adhIrakarIram : Rule
	{
		public adhIrakarIram()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "భ", "స", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "adhIrakarIram";
			Name = "అధీరకరీరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class arditam : Rule
	{
		public arditam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "arditam";
			Name = "అర్దితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class vigAhitageham : Rule
	{
		public vigAhitageham()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "య", "మ", "న", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "vigAhitageham";
			Name = "విగాహితగేహమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhAsamAnabimbam : Rule
	{
		public bhAsamAnabimbam()
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

			Rules = new string[][] { new string[] { "ర", "జ", "భ", "స", "జ", "భ", "స", "య" } };
			Yati = new int[][] { };

			Identifier = "bhAsamAnabimbam";
			Name = "భాసమానబిమ్బమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class samAhitam : Rule
	{
		public samAhitam()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "జ", "జ", "జ", "జ", "య" } };
			Yati = new int[][] { };

			Identifier = "samAhitam";
			Name = "సమాహితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vellitavelam : Rule
	{
		public vellitavelam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "మ", "స", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "vellitavelam";
			Name = "వేల్లితవేలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class gaGgodakam : Rule
	{
		public gaGgodakam()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "gaGgodakam";
			Name = "గఙ్గోదకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgaH : Rule
	{
		public bhujaGgaH()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "య", "య", "య", "య" } };
			Yati = new int[][] { };

			Identifier = "bhujaGgaH";
			Name = "భుజఙ్గః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}


	public class atulapulakam : Rule
	{
		public atulapulakam()
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

			Rules = new string[][] { new string[] { "న", "న", "న", "న", "న", "న", "న", "స" } };
			Yati = new int[][] { };

			Identifier = "atulapulakam";
			Name = "అతులపులకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class utkaTapaTTikA : Rule
	{
		public utkaTapaTTikA()
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

			Rules = new string[][] { new string[] { "త", "జ", "ర", "జ", "న", "స", "ర", "ర" } };
			Yati = new int[][] { };

			Identifier = "utkaTapaTTikA";
			Name = "ఉత్కటపట్టికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhaureyam : Rule
	{
		public dhaureyam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "స", "స", "న", "న", "స", "మ" } };
			Yati = new int[][] { };

			Identifier = "dhaureyam";
			Name = "ధౌరేయమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pArSatasaraNam : Rule
	{
		public pArSatasaraNam()
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

			Rules = new string[][] { new string[] { "భ", "న", "య", "మ", "న", "న", "న", "య" } };
			Yati = new int[][] { };

			Identifier = "pArSatasaraNam";
			Name = "పార్షతసరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaMzalonnatA : Rule
	{
		public vaMzalonnatA()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "మ", "మ", "జ", "ర", "మ" } };
			Yati = new int[][] { };

			Identifier = "vaMzalonnatA";
			Name = "వంశలోన్నతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cittacintAmaNiH : Rule
	{
		public cittacintAmaNiH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "న", "జ", "త", "త", "త", "గ" } };
			Yati = new int[][] { };

			Identifier = "cittacintAmaNiH";
			Name = "చిత్తచిన్తామణిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class krozapadA : Rule
	{
		public krozapadA()
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

			Rules = new string[][] { new string[] { "భ", "మ", "స", "భ", "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "krozapadA";
			Name = "క్రోశపదా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumudamAlA : Rule
	{
		public kumudamAlA()
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

			Rules = new string[][] { new string[] { "న", "త", "స", "భ", "య", "న", "త", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "kumudamAlA";
			Name = "కుముదమాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mallapallIprakAzam : Rule
	{
		public mallapallIprakAzam()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "య", "య", "య", "య", "ల" } };
			Yati = new int[][] { };

			Identifier = "mallapallIprakAzam";
			Name = "మల్లపల్లీప్రకాశమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hrINahaiyaGgavInam : Rule
	{
		public hrINahaiyaGgavInam()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "ర", "ర", "ర", "ర", "గ" } };
			Yati = new int[][] { };

			Identifier = "hrINahaiyaGgavInam";
			Name = "హ్రీణహైయఙ్గవీనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nIpavanIyakam : Rule
	{
		public nIpavanIyakam()
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

			Rules = new string[][] { new string[] { "భ", "న", "న", "స", "భ", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "nIpavanIyakam";
			Name = "నీపవనీయకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rasikarasAlA : Rule
	{
		public rasikarasAlA()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "స", "భ", "త", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "rasikarasAlA";
			Name = "రసికరసాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saudAmanadAma : Rule
	{
		public saudAmanadAma()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "న", "జ", "య", "స", "ల" } };
			Yati = new int[][] { };

			Identifier = "saudAmanadAma";
			Name = "సౌదామనదామ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizeSakabalitam : Rule
	{
		public vizeSakabalitam()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "మ", "జ", "జ", "జ", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "vizeSakabalitam";
			Name = "విశేషకబలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class bhAvinIvilasitam : Rule
	{
		public bhAvinIvilasitam()
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

			Rules = new string[][] { new string[] { "ర", "న", "ర", "న", "ర", "న", "ర", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "bhAvinIvilasitam";
			Name = "భావినీవిలసితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zarabhUriNI : Rule
	{
		public zarabhUriNI()
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

			Rules = new string[][] { new string[] { "ర", "స", "జ", "జ", "భ", "ర", "స", "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "zarabhUriNI";
			Name = "శరభూరిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mudiram : Rule
	{
		public mudiram()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "స", "స", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "mudiram";
			Name = "ముదిరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zivikA : Rule
	{
		public zivikA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "భ", "భ", "గ" } };
			Yati = new int[][] { };

			Identifier = "zivikA";
			Name = "శివికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class abhrabramaNam : Rule
	{
		public abhrabramaNam()
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

			Rules = new string[][] { new string[] { "త", "న", "మ", "స", "న", "న", "న", "న", "గ" } };
			Yati = new int[][] { };

			Identifier = "abhrabramaNam";
			Name = "అభ్రబ్రమణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vyAkozakozalam : Rule
	{
		public vyAkozakozalam()
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

			Rules = new string[][] { new string[] { "త", "భ", "య", "భ", "స", "స", "స", "జ", "గ" } };
			Yati = new int[][] { };

			Identifier = "vyAkozakozalam";
			Name = "వ్యాకోశకోశలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virahavirahasyam : Rule
	{
		public virahavirahasyam()
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

			Rules = new string[][] { new string[] { "మ", "న", "న", "త", "య", "న", "న", "స", "గ" } };
			Yati = new int[][] { };

			Identifier = "virahavirahasyam";
			Name = "విరహవిరహస్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AbhAsamAnam : Rule
	{
		public AbhAsamAnam()
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

			Rules = new string[][] { new string[] { "య", "య", "య", "య", "త", "త", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "AbhAsamAnam";
			Name = "ఆభాసమానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class priyajIvitam : Rule
	{
		public priyajIvitam()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "భ", "భ", "భ", "భ", "భ", "గా" } };
			Yati = new int[][] { };

			Identifier = "priyajIvitam";
			Name = "ప్రియజీవితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumbhakam : Rule
	{
		public kumbhakam()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "ర", "ర", "ర", "ర", "ర", "హ" } };
			Yati = new int[][] { };

			Identifier = "kumbhakam";
			Name = "కుమ్భకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sUrasUcakaH : Rule
	{
		public sUrasUcakaH()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "స", "స", "స", "య", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "sUrasUcakaH";
			Name = "సూరసూచకః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tanukilakiJcitam : Rule
	{
		public tanukilakiJcitam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "న", "జ", "న", "త", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "tanukilakiJcitam";
			Name = "తనుకిలకిఞ్చితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ujjhitakadanam : Rule
	{
		public ujjhitakadanam()
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

			Rules = new string[][] { new string[] { "భ", "న", "జ", "జ", "జ", "న", "న", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "ujjhitakadanam";
			Name = "ఉజ్ఝితకదనమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zRkhalavalayitam : Rule
	{
		public zRkhalavalayitam()
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

			Rules = new string[][] { new string[] { "భ", "న", "న", "భ", "మ", "న", "న", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "zRkhalavalayitam";
			Name = "శృఖలవలయితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kuhakakuharam : Rule
	{
		public kuhakakuharam()
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

			Rules = new string[][] { new string[] { "న", "న", "మ", "య", "న", "న", "మ", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "kuhakakuharam";
			Name = "కుహకకుహరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viSANAzritam : Rule
	{
		public viSANAzritam()
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

			Rules = new string[][] { new string[] { "య", "న", "ర", "భ", "జ", "త", "స", "య", "వ" } };
			Yati = new int[][] { };

			Identifier = "viSANAzritam";
			Name = "విషాణాశ్రితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhasalazalAkA : Rule
	{
		public bhasalazalAkA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "మ", "న", "య", "త", "న", "గా" } };
			Yati = new int[][] { };

			Identifier = "bhasalazalAkA";
			Name = "భసలశలాకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vIravikrAntaH : Rule
	{
		public vIravikrAntaH()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "త", "త", "త", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vIravikrAntaH";
			Name = "వీరవిక్రాన్తః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class azokAnokaham : Rule
	{
		public azokAnokaham()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "భ", "న", "ర", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "azokAnokaham";
			Name = "అశోకానోకహమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zakuntakuntalaH : Rule
	{
		public zakuntakuntalaH()
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

			Rules = new string[][] { new string[] { "మ", "ర", "ర", "న", "న", "ర", "జ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "zakuntakuntalaH";
			Name = "శకున్తకున్తలః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class vizvavizvAsaH : Rule
	{
		public vizvavizvAsaH()
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

			Rules = new string[][] { new string[] { "మ", "య", "య", "య", "ర", "మ", "త", "త", "గా" } };
			Yati = new int[][] { };

			Identifier = "vizvavizvAsaH";
			Name = "విశ్వవిశ్వాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class virAmavATikA : Rule
	{
		public virAmavATikA()
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

			Rules = new string[][] { new string[] { "న", "జ", "ర", "స", "న", "జ", "ర", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "virAmavATikA";
			Name = "విరామవాటికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jImUtadhvAnam : Rule
	{
		public jImUtadhvAnam()
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

			Rules = new string[][] { new string[] { "మ", "మ", "మ", "మ", "మ", "మ", "మ", "మ", "గా" } };
			Yati = new int[][] { };

			Identifier = "jImUtadhvAnam";
			Name = "జీమూతధ్వానమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vazaMvadaH : Rule
	{
		public vazaMvadaH()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "స", "స", "స", "స", "లల" } };
			Yati = new int[][] { };

			Identifier = "vazaMvadaH";
			Name = "వశంవదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karNATakam : Rule
	{
		public karNATakam()
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

			Rules = new string[][] { new string[] { "త", "భ", "జ", "భ", "జ", "భ", "న", "న", "వ" } };
			Yati = new int[][] { };

			Identifier = "karNATakam";
			Name = "కర్ణాటకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kAkalIkalakokilaH : Rule
	{
		public kAkalIkalakokilaH()
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

			Rules = new string[][] { new string[] { "ర", "స", "జ", "జ", "భ", "ర", "స", "జ", "వ" } };
			Yati = new int[][] { };

			Identifier = "kAkalIkalakokilaH";
			Name = "కాకలీకలకోకిలః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vinidrasindhuraH : Rule
	{
		public vinidrasindhuraH()
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

			Rules = new string[][] { new string[] { "ర", "ర", "ర", "ర", "జ", "ర", "జ", "ర", "వ" } };
			Yati = new int[][] { };

			Identifier = "vinidrasindhuraH";
			Name = "వినిద్రసిన్ధురః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class cArugatiH : Rule
	{
		public cArugatiH()
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

			Rules = new string[][] { new string[] { "న", "న", "స", "మ", "న", "జ", "ర", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "cArugatiH";
			Name = "చారుగతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vikuNThakaNThaH : Rule
	{
		public vikuNThakaNThaH()
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

			Rules = new string[][] { new string[] { "ర", "జ", "ర", "జ", "ర", "జ", "ర", "జ", "గా" } };
			Yati = new int[][] { };

			Identifier = "vikuNThakaNThaH";
			Name = "వికుణ్ఠకణ్ఠః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vinayavilAsaH : Rule
	{
		public vinayavilAsaH()
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

			Rules = new string[][] { new string[] { "న", "య", "న", "య", "న", "య", "న", "య", "గా" } };
			Yati = new int[][] { };

			Identifier = "vinayavilAsaH";
			Name = "వినయవిలాసః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
}

/*public class somarAjI :Rule 
{ 
	public somarAjI()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"య","య"}};
		Yati = new int[][]{};
		
		Identifier = "somarAjI";
		Name = "సోమరాజీ";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}public class nUtanam :Rule 
{ 
	public nUtanam()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"ర","న","భ","భ","ర"}};
		Yati = new int[][]{};
		
		Identifier = "nUtanam";
		Name = "నూతనమ్";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
} public class bhramarAvalikA :Rule 
{ 
	public bhramarAvalikA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"స","స","స","స","స"}};
		Yati = new int[][]{};
		
		Identifier = "bhramarAvalikA";
		Name = "భ్రమరావలికా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}
public class prabhadrakam :Rule 
{ 
public prabhadrakam()
{ 
	Lines = 4;
	Threshold = 3;

	RuleType = RuleType.Name;
	PadyamType = PadyamType.Vruttam;
	PadyamSubType =PadyamSubType.Vruttam;
	Frequency = Frequency.Rare;
	YatiMode = YatiMode.CharPosition;

	Prasa = true;
	PrasaYati = false;
	AnthyaPrasa=false;
	InfiniteLength = false;

	Rules = new string[][]{new string[]{"న","జ","భ","జ","ర"}};
	Yati = new int[][]{};
		
	Identifier = "prabhadrakam";
	Name = "ప్రభద్రకమ్";
			
	Examples = new string[]{};
		
	References=new string[]{};
}
}/*public class praharaNakalikA :Rule 
{ 
	public praharaNakalikA()
	{ 
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType =PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa=false;
		InfiniteLength = false;

		Rules = new string[][]{new string[]{"న","న","భ","న","వ"}};
		Yati = new int[][]{};
		
		Identifier = "praharaNakalikA";
		Name = "ప్రహరణకలికా";
				
		Examples = new string[]{};
		
		References=new string[]{};
	}
}
public class alolA :Rule 
{ 
public alolA()
{ 
	Lines = 4;
	Threshold = 3;

	RuleType = RuleType.Name;
	PadyamType = PadyamType.Vruttam;
	PadyamSubType =PadyamSubType.Vruttam;
	Frequency = Frequency.Rare;
	YatiMode = YatiMode.CharPosition;

	Prasa = true;
	PrasaYati = false;
	AnthyaPrasa=false;
	InfiniteLength = false;

	Rules = new string[][]{new string[]{"మ","స","మ","భ","గా"}};
	Yati = new int[][]{};
		
	Identifier = "alolA";
	Name = "అలోలా";
			
	Examples = new string[]{};
		
	References=new string[]{};
}
}*/
