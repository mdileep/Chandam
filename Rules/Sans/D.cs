//---------------------------------------------------------------------------------------------
// <copyright file="D.cs" company="Chandam-ఛందం">
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
	public class Siva : Rule
	{
		public Siva()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర", "జ" } };
			Yati = new int[][] { };

			Identifier = "Siva";
			Name = "శివ(ఆర్భవమ్)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class vasana : Rule
	{
		public vasana()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న", "స", "వ" } };
			Yati = new int[][] { };

			Identifier = "vasana ";
			Name = "వసన (కమల,మహి,లసదసు)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sabhaa : Rule
	{
		public sabhaa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స", "భ" } };
			Yati = new int[][] { };

			Identifier = "sabhaa ";
			Name = "సభా (గురుమధ్యా,శఙ్ఖద్యుతి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
}

/*public class saMj_naa : Rule
	{
		public saMj_naa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "స" , "స" , "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "saMj~naa ";
			Name = "సంజ్ఞా (కమలలోచనా,కమలాక్షీ,చండీ)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maMjubhaashiNi : Rule
	{
		public maMjubhaashiNi ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "జ" , "స" , "జ" , "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "maMjubhaashiNi ";
			Name = "మంజుభాషిణి (కనకప్రభా,జయా,నందినీ,ప్రబోధితా,మనోవతీ,విలంబితా,సునందినీ,సుమంగలీ)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}
	
	public class abhinavataamarasa : Rule
	{
		public abhinavataamarasa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "జ" , "జ" , "య" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "abhinavataamarasa ";
			Name = "అభినవతామరస (కమలవిలాసిని,తామరస,లలితపద,తోదక,తోవక,దోధక,కలరవ)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}
	
	public class dOdaka : Rule
	{
		public dOdaka ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "భ" , "భ" , "గా" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "dOdaka ";
			Name = "దోదక (దోధక,తరంగక,బందు,భిత్తక,తోటక,తోదక)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}

	public class paMkti : Rule
	{
		public paMkti ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "గా" } };
			Yati = new int[][] { };

			Identifier = "paMkti ";
			Name = "పంక్తి (అక్షరోపపదా,అక్షరపంక్తి,కాంచనమాలా,కుంతలతన్వీ,భూతలతన్వీ,హంసా,సుందరి,పఙ్క్తిః)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sarasija : Rule
	{
		public sarasija ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "స" , "గ" } };
			Yati = new int[][] { };

			Identifier = "sarasija ";
			Name = "సరసిజ (మదలేఖా,విధువక్త్రా,సురుచిర,రుచిరమ్)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class SaSivadanaa : Rule
	{
		public SaSivadanaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "య" } };
			Yati = new int[][] { };

			Identifier = "SaSivadanaa ";
			Name = "శశివదనా (కనకలతా,చతురంశా,మకరశీర్షా,ముకులితా,సురలత)";
			
			Examples = new string[] { };

			References = new string[] { };
		}
	}
*/
