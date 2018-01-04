//---------------------------------------------------------------------------------------------
// <copyright file="San2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:35EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Sans
{
	public class jAyA : Rule
	{
		public jAyA()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "jAyA";
			Name = "జాయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viparItAkhyAnakI : Rule
	{
		public viparItAkhyAnakI()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "viparItAkhyAnakI";
			Name = "విపరీతాఖ్యానకీ";

			Examples = new string[] { };
			References = new string[] { };
		}
	}
	public class vargavatI : Rule
	{
		public vargavatI()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "గా", }, new string[] { "స", "స", "స", "గ", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "స", "స", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "vargavatI";
			Name = "వర్గవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsantikA : Rule
	{
		public vAsantikA()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "vAsantikA";
			Name = "వాసన్తికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vasantamAlikA : Rule
	{
		public vasantamAlikA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "గా", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "స", "స", "జ", "గా", }, new string[] { "స", "భ", "ర", "య", } };
			Yati = new int[][] { };

			Identifier = "vasantamAlikA";
			Name = "వసన్తమాలికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jAriNI : Rule
	{
		public jAriNI()
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

			Rules = new string[][] { new string[] { "న", "త", "త", "గ", }, new string[] { "ర", "ర", "న", "త", "గ", }, new string[] { "న", "త", "త", "గ", }, new string[] { "ర", "ర", "న", "త", "గ", } };
			Yati = new int[][] { };

			Identifier = "jAriNI";
			Name = "జారిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vimAninI : Rule
	{
		public vimAninI()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "వ", }, new string[] { "మ", "న", "జ", "ర", }, new string[] { "స", "భ", "ర", "వ", }, new string[] { "మ", "న", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "vimAninI";
			Name = "విమానినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ghaTikA : Rule
	{
		public ghaTikA()
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

			Rules = new string[][] { new string[] { "త", "స", "జ", "గ", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "త", "స", "జ", "గ", }, new string[] { "స", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "ghaTikA";
			Name = "ఘటికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vegavatI : Rule
	{
		public vegavatI()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "గ", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "స", "స", "స", "గ", }, new string[] { "భ", "భ", "భ", "గా", } };
			Yati = new int[][] { };

			Identifier = "vegavatI";
			Name = "వేగవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class haMsI : Rule
	{
		public haMsI()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "haMsI";
			Name = "హంసీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class drutamadhyA : Rule
	{
		public drutamadhyA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "గా", }, new string[] { "న", "జ", "జ", "య", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "న", "జ", "జ", "య", } };
			Yati = new int[][] { };

			Identifier = "drutamadhyA";
			Name = "ద్రుతమధ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhIrAvarttaH_1 : Rule
	{
		public dhIrAvarttaH_1()
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

			Rules = new string[][] { new string[] { "మ", "భ", "స", "మ", "గ", }, new string[] { "మ", "త", "య", "స", "గ", }, new string[] { "మ", "భ", "స", "మ", "గ", }, new string[] { "మ", "త", "య", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "dhIrAvarttaH_1";
			Name = "ధీరావర్త్తః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dhIrAvarttaH : Rule
	{
		public dhIrAvarttaH()
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

			Rules = new string[][] { new string[] { "మ", "త", "య", "స", "గ", }, new string[] { "మ", "భ", "స", "మ", "గ", }, new string[] { "మ", "త", "య", "స", "గ", }, new string[] { "మ", "భ", "స", "మ", "గ", } };
			Yati = new int[][] { };

			Identifier = "dhIrAvarttaH";
			Name = "ధీరావర్త్తః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hariNIplutA_1 : Rule
	{
		public hariNIplutA_1()
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

			Rules = new string[][] { new string[] { "న", "భ", "భ", "ర", }, new string[] { "స", "స", "స", "వ", }, new string[] { "న", "భ", "భ", "ర", }, new string[] { "స", "స", "స", "వ", } };
			Yati = new int[][] { };

			Identifier = "hariNIplutA_1";
			Name = "హరిణీప్లుతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hInatAlI : Rule
	{
		public hInatAlI()
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

			Rules = new string[][] { new string[] { "స", "భ", "స", "జ", "ర", "గ", }, new string[] { "మ", "న", "జ", "ర", }, new string[] { "స", "భ", "స", "జ", "ర", "గ", }, new string[] { "మ", "న", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "hInatAlI";
			Name = "హీనతాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsinI : Rule
	{
		public vAsinI()
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

			Rules = new string[][] { new string[] { "త", "జ", "భ", "జ", "జ", "గ", }, new string[] { "న", "జ", "భ", "జ", "జ", "గ", }, new string[] { "త", "జ", "భ", "జ", "జ", "గ", }, new string[] { "న", "జ", "భ", "జ", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "vAsinI";
			Name = "వాసినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hariluptA : Rule
	{
		public hariluptA()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "వ", }, new string[] { "స", "భ", "భ", "ర", }, new string[] { "స", "స", "స", "వ", }, new string[] { "స", "భ", "భ", "ర", } };
			Yati = new int[][] { };

			Identifier = "hariluptA";
			Name = "హరిలుప్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class hariNIplutA : Rule
	{
		public hariNIplutA()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "వ", }, new string[] { "న", "భ", "భ", "ర", }, new string[] { "స", "స", "స", "వ", }, new string[] { "న", "భ", "భ", "ర", } };
			Yati = new int[][] { };

			Identifier = "hariNIplutA";
			Name = "హరిణీప్లుతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vilAsavApI : Rule
	{
		public vilAsavApI()
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

			Rules = new string[][] { new string[] { "త", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "vilAsavApI";
			Name = "విలాసవాపీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalanAvatI : Rule
	{
		public kalanAvatI()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "జ", "గ", }, new string[] { "స", "జ", "స", "స", "గ", }, new string[] { "స", "జ", "స", "జ", "గ", }, new string[] { "స", "జ", "స", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "kalanAvatI";
			Name = "కలనావతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaisArI : Rule
	{
		public vaisArI()
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

			Rules = new string[][] { new string[] { "త", "జ", "ర", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "త", "జ", "ర", }, new string[] { "మ", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "vaisArI";
			Name = "వైసారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgabhRtA : Rule
	{
		public bhujaGgabhRtA()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "స", "గ", }, new string[] { "భ", "భ", "భ", "భ", "గ", }, new string[] { "స", "స", "స", "స", "గ", }, new string[] { "భ", "భ", "భ", "భ", "గ", } };
			Yati = new int[][] { };

			Identifier = "bhujaGgabhRtA";
			Name = "భుజఙ్గభృతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ketuH : Rule
	{
		public ketuH()
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

			Rules = new string[][] { new string[] { "భ", "ర", "న", "గా", }, new string[] { "స", "జ", "స", "గ", }, new string[] { "భ", "ర", "న", "గా", }, new string[] { "స", "జ", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "ketuH";
			Name = "కేతుః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karIritA : Rule
	{
		public karIritA()
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

			Rules = new string[][] { new string[] { "స", "భ", "జ", "ర", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "స", "భ", "జ", "ర", }, new string[] { "స", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "karIritA";
			Name = "కరీరితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vaiyAlI : Rule
	{
		public vaiyAlI()
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

			Rules = new string[][] { new string[] { "న", "న", "ర", "వ", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "న", "న", "ర", "వ", }, new string[] { "మ", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "vaiyAlI";
			Name = "వైయాలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karNinI : Rule
	{
		public karNinI()
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

			Rules = new string[][] { new string[] { "ర", "న", "భ", "గా", }, new string[] { "ర", "న", "ర", "వ", }, new string[] { "ర", "న", "భ", "గా", }, new string[] { "ర", "న", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "karNinI";
			Name = "కర్ణినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kilikitA_1 : Rule
	{
		public kilikitA_1()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "ర", }, new string[] { "ర", "న", "ర", "వ", }, new string[] { "న", "భ", "జ", "ర", }, new string[] { "ర", "న", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "kilikitA_1";
			Name = "కిలికితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kiMzukAvalI : Rule
	{
		public kiMzukAvalI()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "ర", "గ", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "న", "జ", "ర", "గ", }, new string[] { "త", "జ", "ర", "గ", } };
			Yati = new int[][] { };

			Identifier = "kiMzukAvalI";
			Name = "కింశుకావలీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lAsyalIlAlayaH : Rule
	{
		public lAsyalIlAlayaH()
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

			Rules = new string[][] { new string[] { "త", "య", "ర", "ర", "గ", }, new string[] { "భ", "స", "త", "త", "గా", }, new string[] { "త", "య", "ర", "ర", "గ", }, new string[] { "భ", "స", "త", "త", "గా", } };
			Yati = new int[][] { };

			Identifier = "lAsyalIlAlayaH";
			Name = "లాస్యలీలాలయః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lAsyalIlA : Rule
	{
		public lAsyalIlA()
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

			Rules = new string[][] { new string[] { "భ", "స", "త", "త", "గా", }, new string[] { "త", "య", "ర", "ర", "గ", }, new string[] { "భ", "స", "త", "త", "గా", }, new string[] { "త", "య", "ర", "ర", "గ", } };
			Yati = new int[][] { };

			Identifier = "lAsyalIlA";
			Name = "లాస్యలీలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vizvapramA : Rule
	{
		public vizvapramA()
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

			Rules = new string[][] { new string[] { "త", "త", "త", "గ", }, new string[] { "జ", "త", "త", "గ", }, new string[] { "త", "త", "త", "గ", }, new string[] { "జ", "త", "త", "గ", } };
			Yati = new int[][] { };

			Identifier = "vizvapramA";
			Name = "విశ్వప్రమా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upADhyam : Rule
	{
		public upADhyam()
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

			Rules = new string[][] { new string[] { "న", "స", "జ", "గా", }, new string[] { "భ", "భ", "ర", "య", }, new string[] { "న", "స", "జ", "గా", }, new string[] { "భ", "భ", "ర", "య", } };
			Yati = new int[][] { };

			Identifier = "upADhyam";
			Name = "ఉపాఢ్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bAlA : Rule
	{
		public bAlA()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "bAlA";
			Name = "బాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class lalitam_1 : Rule
	{
		public lalitam_1()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "ల", }, new string[] { "న", "స", "జ", "గ", }, new string[] { "న", "న", "స", "స", }, new string[] { "స", "జ", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "lalitam_1";
			Name = "లలితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madAkrAntA : Rule
	{
		public madAkrAntA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "ర", "గా", }, new string[] { "స", "స", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "ర", "గా", } };
			Yati = new int[][] { };

			Identifier = "madAkrAntA";
			Name = "మదాక్రాన్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ulapohA : Rule
	{
		public ulapohA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "ర", "య", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "భ", "భ", "ర", "య", }, new string[] { "స", "భ", "ర", "య", } };
			Yati = new int[][] { };

			Identifier = "ulapohA";
			Name = "ఉలపోహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madhuvAri : Rule
	{
		public madhuvAri()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "జ", "గ", }, new string[] { "త", "భ", "ర", "స", "ల", }, new string[] { "స", "జ", "స", "జ", "గ", }, new string[] { "త", "భ", "ర", "స", "ల", } };
			Yati = new int[][] { };

			Identifier = "madhuvAri";
			Name = "మధువారి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upacitrA : Rule
	{
		public upacitrA()
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

			Rules = new string[][] { new string[] { "స", "స", "స", "లల", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "స", "స", "స", "లల", }, new string[] { "భ", "భ", "భ", "గా", } };
			Yati = new int[][] { };

			Identifier = "upacitrA";
			Name = "ఉపచిత్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class baddhA : Rule
	{
		public baddhA()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "వ", }, new string[] { "స", "స", "న", "న", "గ", }, new string[] { "మ", "భ", "న", "వ", }, new string[] { "స", "స", "న", "న", "గ", } };
			Yati = new int[][] { };

			Identifier = "baddhA";
			Name = "బద్ధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class luptA : Rule
	{
		public luptA()
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

			Rules = new string[][] { new string[] { "స", "భ", "భ", "ర", }, new string[] { "స", "స", "స", "వ", }, new string[] { "స", "భ", "భ", "ర", }, new string[] { "స", "స", "స", "వ", } };
			Yati = new int[][] { };

			Identifier = "luptA";
			Name = "లుప్తా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upADhyam_1 : Rule
	{
		public upADhyam_1()
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

			Rules = new string[][] { new string[] { "భ", "భ", "ర", "య", }, new string[] { "న", "స", "జ", "గా", }, new string[] { "భ", "భ", "ర", "య", }, new string[] { "న", "స", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "upADhyam_1";
			Name = "ఉపాఢ్యమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viyadvANI_1 : Rule
	{
		public viyadvANI_1()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "య", }, new string[] { "మ", "స", "జ", "మ", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "మ", "స", "జ", "మ", } };
			Yati = new int[][] { };

			Identifier = "viyadvANI_1";
			Name = "వియద్వాణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class korakitA : Rule
	{
		public korakitA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "గా", }, new string[] { "న", "య", "న", "య", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "న", "య", "న", "య", } };
			Yati = new int[][] { };

			Identifier = "korakitA";
			Name = "కోరకితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upodgatA : Rule
	{
		public upodgatA()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "గా", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "స", "స", "జ", "గా", }, new string[] { "స", "భ", "ర", "య", } };
			Yati = new int[][] { };

			Identifier = "upodgatA";
			Name = "ఉపోద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kIrtiH : Rule
	{
		public kIrtiH()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "kIrtiH";
			Name = "కీర్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upodgatA_1 : Rule
	{
		public upodgatA_1()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "య", }, new string[] { "స", "స", "జ", "గా", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "స", "స", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "upodgatA_1";
			Name = "ఉపోద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class viyadvANI : Rule
	{
		public viyadvANI()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "మ", }, new string[] { "స", "భ", "ర", "య", }, new string[] { "మ", "స", "జ", "మ", }, new string[] { "స", "భ", "ర", "య", } };
			Yati = new int[][] { };

			Identifier = "viyadvANI";
			Name = "వియద్వాణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kumArI : Rule
	{
		public kumArI()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "kumArI";
			Name = "కుమారీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhadrA : Rule
	{
		public bhadrA()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "bhadrA";
			Name = "భద్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhadravirAT : Rule
	{
		public bhadravirAT()
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

			Rules = new string[][] { new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "bhadravirAT";
			Name = "భద్రవిరాట్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upasthitapracupitam : Rule
	{
		public upasthitapracupitam()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "భ", "గా", }, new string[] { "స", "న", "జ", "ర", "గ", }, new string[] { "న", "న", "స", }, new string[] { "న", "న", "న", "జ", "య", } };
			Yati = new int[][] { };

			Identifier = "upasthitapracupitam";
			Name = "ఉపస్థితప్రచుపితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upasarasIkam : Rule
	{
		public upasarasIkam()
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

			Rules = new string[][] { new string[] { "స", "భ", "జ", "య", }, new string[] { "త", "భ", "జ", "య", }, new string[] { "స", "భ", "జ", "య", }, new string[] { "త", "భ", "జ", "య", } };
			Yati = new int[][] { };

			Identifier = "upasarasIkam";
			Name = "ఉపసరసీకమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upameyA : Rule
	{
		public upameyA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "upameyA";
			Name = "ఉపమేయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ayavatI : Rule
	{
		public ayavatI()
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

			Rules = new string[][] { new string[] { "స", "మ", "న", "వ", }, new string[] { "త", "న", "త", "వ", }, new string[] { "స", "మ", "న", "వ", }, new string[] { "త", "న", "త", "వ", } };
			Yati = new int[][] { };

			Identifier = "ayavatI";
			Name = "అయవతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class AsavavAsitA : Rule
	{
		public AsavavAsitA()
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

			Rules = new string[][] { new string[] { "న", "భ", "జ", "ర", "య", }, new string[] { "స", "భ", "ర", "జ", "స", "గ", }, new string[] { "న", "భ", "జ", "ర", "య", }, new string[] { "స", "భ", "ర", "జ", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "AsavavAsitA";
			Name = "ఆసవవాసితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zaGkhacUDA : Rule
	{
		public zaGkhacUDA()
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

			Rules = new string[][] { new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "zaGkhacUDA";
			Name = "శఙ్ఖచూడా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aruntudaH : Rule
	{
		public aruntudaH()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "గ", }, new string[] { "న", "జ", "జ", "ర", }, new string[] { "స", "స", "జ", "గ", }, new string[] { "న", "జ", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "aruntudaH";
			Name = "అరున్తుదః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class asurADhyA : Rule
	{
		public asurADhyA()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గా", }, new string[] { "న", "న", "ర", "య", }, new string[] { "మ", "స", "జ", "గా", }, new string[] { "న", "న", "ర", "య", } };
			Yati = new int[][] { };

			Identifier = "asurADhyA";
			Name = "అసురాఢ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class asudhA : Rule
	{
		public asudhA()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "వ", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "స", "భ", "ర", "వ", }, new string[] { "మ", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "asudhA";
			Name = "అసుధా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mArdaGgI : Rule
	{
		public mArdaGgI()
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

			Rules = new string[][] { new string[] { "స", "న", "స", "న", "గా", }, new string[] { "మ", "న", "జ", "న", "న", "య", }, new string[] { "స", "న", "స", "న", "గా", }, new string[] { "మ", "న", "జ", "న", "న", "య", } };
			Yati = new int[][] { };

			Identifier = "mArdaGgI";
			Name = "మార్దఙ్గీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ArdrA : Rule
	{
		public ArdrA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "ArdrA";
			Name = "ఆర్ద్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ardharutam : Rule
	{
		public ardharutam()
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

			Rules = new string[][] { new string[] { "భ", "న", "య", "న", "ల", }, new string[] { "భ", "న", "జ", "జ", "ల", }, new string[] { "భ", "న", "య", "న", "ల", }, new string[] { "భ", "న", "జ", "జ", "ల", } };
			Yati = new int[][] { };

			Identifier = "ardharutam";
			Name = "అర్ధరుతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zAlabhaJjikA : Rule
	{
		public zAlabhaJjikA()
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

			Rules = new string[][] { new string[] { "స", "న", "ర", "వ", }, new string[] { "భ", "త", "ర", "వ", }, new string[] { "స", "న", "ర", "వ", }, new string[] { "భ", "త", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "zAlabhaJjikA";
			Name = "శాలభఞ్జికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mArdaGgI_1 : Rule
	{
		public mArdaGgI_1()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "న", "న", "య", }, new string[] { "స", "న", "స", "న", "గా", }, new string[] { "మ", "న", "జ", "న", "న", "య", }, new string[] { "స", "న", "స", "న", "గా", } };
			Yati = new int[][] { };

			Identifier = "mArdaGgI_1";
			Name = "మార్దఙ్గీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAyA : Rule
	{
		public mAyA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "mAyA";
			Name = "మాయా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mRdumAlatI : Rule
	{
		public mRdumAlatI()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "ర", }, new string[] { "న", "న", "ర", "వ", }, new string[] { "న", "జ", "జ", "ర", }, new string[] { "న", "న", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "mRdumAlatI";
			Name = "మృదుమాలతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class atailam : Rule
	{
		public atailam()
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

			Rules = new string[][] { new string[] { "జ", "త", "త", "గ", }, new string[] { "త", "త", "త", "గ", }, new string[] { "జ", "త", "త", "గ", }, new string[] { "త", "త", "త", "గ", } };
			Yati = new int[][] { };

			Identifier = "atailam";
			Name = "అతైలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class avarodhavanitA : Rule
	{
		public avarodhavanitA()
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

			Rules = new string[][] { new string[] { "న", "భ", "భ", "ర", "వ", }, new string[] { "స", "స", "జ", "భ", "య", }, new string[] { "న", "భ", "భ", "ర", "వ", }, new string[] { "స", "స", "జ", "భ", "య", } };
			Yati = new int[][] { };

			Identifier = "avarodhavanitA";
			Name = "అవరోధవనితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class manahAsA : Rule
	{
		public manahAsA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "manahAsA";
			Name = "మనహాసా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class avahitrA : Rule
	{
		public avahitrA()
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

			Rules = new string[][] { new string[] { "భ", "భ", "భ", "గా", }, new string[] { "స", "స", "స", "లల", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "స", "స", "స", "లల", } };
			Yati = new int[][] { };

			Identifier = "avahitrA";
			Name = "అవహిత్రా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class udgatA : Rule
	{
		public udgatA()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "ల", }, new string[] { "న", "స", "జ", "గ", }, new string[] { "భ", "న", "జ", "వ", }, new string[] { "స", "జ", "స", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "udgatA";
			Name = "ఉద్గతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mAlA : Rule
	{
		public mAlA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "గా", }, new string[] { "జ", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", }, new string[] { "త", "త", "జ", "గా", } };
			Yati = new int[][] { };

			Identifier = "mAlA";
			Name = "మాలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class avarodhavanitA_1 : Rule
	{
		public avarodhavanitA_1()
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

			Rules = new string[][] { new string[] { "స", "స", "జ", "భ", "య", }, new string[] { "న", "భ", "భ", "ర", "వ", }, new string[] { "స", "స", "జ", "భ", "య", }, new string[] { "న", "భ", "భ", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "avarodhavanitA_1";
			Name = "అవరోధవనితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class yuddhavirAT : Rule
	{
		public yuddhavirAT()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", }, new string[] { "మ", "స", "జ", "గా", }, new string[] { "త", "జ", "ర", "గ", } };
			Yati = new int[][] { };

			Identifier = "yuddhavirAT";
			Name = "యుద్ధవిరాట్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class atisurahitA : Rule
	{
		public atisurahitA()
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

			Rules = new string[][] { new string[] { "త", "న", "న", "న", "గ", }, new string[] { "న", "న", "స", "స", "గ", }, new string[] { "త", "న", "న", "న", "గ", }, new string[] { "న", "న", "స", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "atisurahitA";
			Name = "అతిసురహితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class atiprativinItA : Rule
	{
		public atiprativinItA()
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

			Rules = new string[][] { new string[] { "స", "భ", "ర", "న", "గా", }, new string[] { "న", "య", "జ", "ర", "గ", }, new string[] { "స", "భ", "ర", "న", "గా", }, new string[] { "న", "య", "జ", "ర", "గ", } };
			Yati = new int[][] { };

			Identifier = "atiprativinItA";
			Name = "అతిప్రతివినీతా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class avAcIkRtavadanA : Rule
	{
		public avAcIkRtavadanA()
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

			Rules = new string[][] { new string[] { "త", "న", "భ", "స", }, new string[] { "న", "య", "భ", "గా", }, new string[] { "త", "న", "భ", "స", }, new string[] { "న", "య", "భ", "గా", } };
			Yati = new int[][] { };

			Identifier = "avAcIkRtavadanA";
			Name = "అవాచీకృతవదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aupagavItam : Rule
	{
		public aupagavItam()
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

			Rules = new string[][] { new string[] { "భ", "ర", "ర", "వ", }, new string[] { "న", "ర", "ర", "వ", }, new string[] { "భ", "ర", "ర", "వ", }, new string[] { "న", "ర", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "aupagavItam";
			Name = "ఔపగవీతమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aupagavam : Rule
	{
		public aupagavam()
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

			Rules = new string[][] { new string[] { "న", "ర", "ర", "వ", }, new string[] { "భ", "ర", "ర", "వ", }, new string[] { "న", "ర", "ర", "వ", }, new string[] { "భ", "ర", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "aupagavam";
			Name = "ఔపగవమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsavavAsinI : Rule
	{
		public vAsavavAsinI()
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

			Rules = new string[][] { new string[] { "న", "జ", "భ", "జ", "జ", "గ", }, new string[] { "త", "జ", "భ", "జ", "జ", "గ", }, new string[] { "న", "జ", "భ", "జ", "జ", "గ", }, new string[] { "త", "జ", "భ", "జ", "జ", "గ", } };
			Yati = new int[][] { };

			Identifier = "vAsavavAsinI";
			Name = "వాసవవాసినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vAsavavanditA : Rule
	{
		public vAsavavanditA()
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

			Rules = new string[][] { new string[] { "మ", "స", "జ", "గ", }, new string[] { "త", "జ", "ర", }, new string[] { "మ", "స", "జ", "గ", }, new string[] { "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "vAsavavanditA";
			Name = "వాసవవన్దితా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class indumA : Rule
	{
		public indumA()
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

			Rules = new string[][] { new string[] { "జ", "త", "జ", "ర", }, new string[] { "జ", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", }, new string[] { "త", "త", "జ", "ర", } };
			Yati = new int[][] { };

			Identifier = "indumA";
			Name = "ఇన్దుమా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vimAninI_1 : Rule
	{
		public vimAninI_1()
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

			Rules = new string[][] { new string[] { "మ", "న", "జ", "ర", }, new string[] { "స", "భ", "ర", "వ", }, new string[] { "మ", "న", "జ", "ర", }, new string[] { "స", "భ", "ర", "వ", } };
			Yati = new int[][] { };

			Identifier = "vimAninI_1";
			Name = "విమానినీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vimukhI : Rule
	{
		public vimukhI()
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

			Rules = new string[][] { new string[] { "న", "న", "భ", "స", "గ", }, new string[] { "న", "న", "స", "స", "గ", }, new string[] { "న", "న", "భ", "స", "గ", }, new string[] { "న", "న", "స", "స", "గ", } };
			Yati = new int[][] { };

			Identifier = "vimukhI";
			Name = "విముఖీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class IhA : Rule
	{
		public IhA()
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

			Rules = new string[][] { new string[] { "న", "జ", "జ", "య", }, new string[] { "భ", "భ", "భ", "గా", }, new string[] { "న", "జ", "జ", "య", }, new string[] { "భ", "భ", "భ", "గా", } };
			Yati = new int[][] { };

			Identifier = "IhA";
			Name = "ఈహా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

}
