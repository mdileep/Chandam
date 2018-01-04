//---------------------------------------------------------------------------------------------
// <copyright file="X.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:35EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
/*
namespace Library.Chandam.Sans
{

	public class chaMdrika : Rule
	{
		public chaMdrika ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,న,ర,వ".Split ( ',' ) };
			Yati = new int[][] { new int[] { 7 } };


			Identifier = "chaMdrika";
			Name = "చంద్రిక(అపరవక్త్ర,ప్రసభ)";
			ShortName = "చంద్రిక(అపరవక్త్ర,ప్రసభ)";
			Examples = new string[] { 
										"నగణయుగమునన్‌ రవంబులన్‌\nబ్రగుణరసవిరామసంగతిన్‌\nతగిలి హరికథాసమేతమై\nనెగఁడు గృతుల నిండి చంద్రికన్‌." 
									};
		}
	}
public class alakA : Rule
	{
		public alakA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "న" , "న" , "న" , "న" , "న" , "న" , "గ" } };
			Yati = new int[][] { };

			Identifier = "alakA";
			Name = "అలకా";
			ShortName = "అలకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class rukmavati : Rule
	{
		public rukmavati ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "మ" , "స" , "గ" } };
			Yati = new int[][] { new int[] { 6 } };

			Identifier = "rukmavati ";
			Name = "రుక్మవతి (చంపకమాలి,చంపకమాలా,పుష్పసమృద్ధి,సుభావా)";
			ShortName = "రుక్మవతి (చంపకమాలి,చంపకమాలా,పుష్పసమృద్ధి,సుభావా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class kaaMti : Rule
	{
		public kaaMti ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "జ" , "జ" , "వ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "kaaMti ";
			Name = "కాంతి (కలికాంత,కాంత,గీతాలంబన,మోటక,మోటనక)";
			ShortName = "కాంతి (కలికాంత,కాంత,గీతాలంబన,మోటక,మోటనక)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class gauree : Rule
	{
		public gauree ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "ర" , "ర" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "gauree ";
			Name = "గౌరీ (చంచలాక్షీ,ప్రముదితవదనా,మందాకినీ,ప్రభ,ప్రభాత)";
			ShortName = "గౌరీ (చంచలాక్షీ,ప్రముదితవదనా,మందాకినీ,ప్రభ,ప్రభాత)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class maNibhooshaNa : Rule
	{
		public maNibhooshaNa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "న" , "భ" , "భ" , "ర" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "maNibhooshaNa ";
			Name = "మణిభూషణ (రమణీయక,సుందర,ఉత్సర,మణిభూషణశ్రీ)";
			ShortName = "మణిభూషణ (రమణీయక,సుందర,ఉత్సర,మణిభూషణశ్రీ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class drutavilaMbita : Rule
	{
		public drutavilaMbita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "భ" , "భ" , "ర" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "drutavilaMbita ";
			Name = "ద్రుతవిలంబిత (సుందరీ,హరిణప్లుతా)";
			ShortName = "ద్రుతవిలంబిత (సుందరీ,హరిణప్లుతా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class paMchachaamaramu : Rule
	{
		public paMchachaamaramu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "ర" , "జ" , "ర" , "జ" , "గ" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "paMchachaamaramu ";
			Name = "పంచచామరము (నారాచ,మహోత్సవ )";
			ShortName = "పంచచామరము (నారాచ,మహోత్సవ )";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class bhujaMgaprayaatamu : Rule
	{
		public bhujaMgaprayaatamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "య" , "య" , "య" , "య" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "bhujaMgaprayaatamu ";
			Name = "భుజంగప్రయాతము (అప్రమేయా)";
			ShortName = "భుజంగప్రయాతము (అప్రమేయా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class tOTaka : Rule
	{
		public tOTaka ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "స" , "స" , "స" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "tOTaka ";
			Name = "తోటక (ఛిత్తక,భ్రమరావళి,నందినీ)";
			ShortName = "తోటక (ఛిత్తక,భ్రమరావళి,నందినీ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class kusumavichitra : Rule
	{
		public kusumavichitra ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "య" , "న" , "య" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "kusumavichitra ";
			Name = "కుసుమవిచిత్ర (గజలలిత)";
			ShortName = "కుసుమవిచిత్ర (గజలలిత)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class priyaMvadaa : Rule
	{
		public priyaMvadaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "భ" , "జ" , "ర" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "priyaMvadaa ";
			Name = "ప్రియంవదా (మత్తకోకిల)";
			ShortName = "ప్రియంవదా (మత్తకోకిల)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class maNimaalaa : Rule
	{
		public maNimaalaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "య" , "త" , "య" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "maNimaalaa ";
			Name = "మణిమాలా (అబ్జవిచిత్రా,పుష్పవిచిత్రా)";
			ShortName = "మణిమాలా (అబ్జవిచిత్రా,పుష్పవిచిత్రా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}	public class vidyunmaalaa : Rule
	{
		public vidyunmaalaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "మ" , "గా" } };
			Yati = new int[][] { new int[] { 5 } };

			Identifier = "vidyunmaalaa ";
			Name = "విద్యున్మాలా (విద్యుల్లేఖా)";
			ShortName = "విద్యున్మాలా (విద్యుల్లేఖా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class sukaaMti : Rule
	{
		public sukaaMti ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "గ" } };
			Yati = new int[][] { new int[] { }};

			Identifier = "sukaaMti ";
			Name = "సుకాంతి (జయా,నగానితా,నగణికా,లాసినీ,విలాసినీ,కలా)";
			ShortName = "సుకాంతి (జయా,నగానితా,నగణికా,లాసినీ,విలాసినీ,కలా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class chaMdrikaa : Rule
	{
		public chaMdrikaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "ర" , "వ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "chaMdrikaa ";
			Name = "చంద్రికా (అపరవక్త్ర,ప్రసభ,భద్రికా)";
			ShortName = "చంద్రికా (అపరవక్త్ర,ప్రసభ,భద్రికా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jaladharamaalaa : Rule
	{
		public jaladharamaalaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "భ" , "స" , "మ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "jaladharamaalaa ";
			Name = "జలధరమాలా (కాంతోత్పీడా)";
			ShortName = "జలధరమాలా (కాంతోత్పీడా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class maalini : Rule
	{
		public maalini ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "మ" , "య" , "య" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "maalini ";
			Name = "మాలిని (నాందీముఖీ)";
			ShortName = "మాలిని (నాందీముఖీ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class vasaMtatilaka : Rule
	{
		public vasaMtatilaka ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "భ" , "జ" , "జ" , "గా" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "vasaMtatilaka ";
			Name = "వసంతతిలక (ఉద్ధర్షిణీ,ఔద్ధర్షిణి,కర్ణోత్పలా,మధుమాధవీ,శోభావతీ,సింహోన్నతా,సింహోద్ధతా,మదనము)";
			ShortName = "వసంతతిలక (ఉద్ధర్షిణీ,ఔద్ధర్షిణి,కర్ణోత్పలా,మధుమాధవీ,శోభావతీ,సింహోన్నతా,సింహోద్ధతా,మదనము)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class kamalavilasita : Rule
	{
		public kamalavilasita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "న" , "న" , "గా" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "kamalavilasita ";
			Name = "కమలవిలసిత (సురుచిర,ఉపచిత్ర,సుపవిత్ర)";
			ShortName = "కమలవిలసిత (సురుచిర,ఉపచిత్ర,సుపవిత్ర)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class bhoonuta : Rule
	{
		public bhoonuta ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "న" , "భ" , "భ" , "గా" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "bhoonuta ";
			Name = "భూనుత (లతా,వనలతా,వలనా)";
			ShortName = "భూనుత (లతా,వనలతా,వలనా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class bhAskaram : Rule
		{
			public bhAskaram ()
			{
				Lines = 4;
				Threshold = 3;

				RuleType = RuleType.Name;
				PadyamType = PadyamType.Vruttam;
				PadyamSubType = PadyamSubType.Vruttam;
				Frequency = Frequency.Rare;
				YatiMode = YatiMode.CharPosition;

				Prasa = true;
				PrasaYati = false;
				AnthyaPrasa = false;
				InfiniteLength = false;

				Rules = new string[][] { new string[] { "భ" , "న" , "జ" , "య" , "భ" , "న" , "న" , "స" , "గ" } };
				Yati = new int[][] { };

				Identifier = "bhAskaram";
				Name = "భాస్కరమ్";
				ShortName = "భాస్కరమ్";

				Examples = new string[] { };

				References = new string[] { };
			}
		}
	public class subhaga : Rule
		{
			public subhaga ()
			{
				Lines = 4;
				Threshold = 3;

				RuleType = RuleType.Name;
				PadyamType = PadyamType.Vruttam;
				PadyamSubType = PadyamSubType.Vruttam;
				Frequency = Frequency.Rare;
				YatiMode = YatiMode.CharPosition;

				Prasa = true;
				PrasaYati = false;
				AnthyaPrasa = false;
				InfiniteLength = false;

				Rules = new string[][] { new string[] { "స" , "భ" , "గా" } };
				Yati = new int[][] { new int[] { 5 } };

				Identifier = "subhaga";
				Name = "సుభగ";
				ShortName = "సుభగ";

				Examples = new string[] { };

				References = new string[] { };
			}
		}
	public class iMdravajra : Rule
	{
		public iMdravajra ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "త" , "జ" , "గా" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "iMdravajra";
			Name = "ఇంద్రవజ్ర";
			ShortName = "ఇంద్రవజ్ర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mauktikamaalaa : Rule
	{
		public mauktikamaalaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "త" , "న" , "గా" } };
			Yati = new int[][] { new int[] { 7 } };

			Identifier = "mauktikamaalaa ";
			Name = "మౌక్తికమాలా (కుట్మలదంతీ,రుచిరా,సాంద్రపద,భద్రపద)";
			ShortName = "మౌక్తికమాలా (కుట్మలదంతీ,రుచిరా,సాంద్రపద,భద్రపద)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class upaeMdravajra : Rule
	{
		public upaeMdravajra ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "త" , "జ" , "గా" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "upaeMdravajra";
			Name = "ఉపేంద్రవజ్ర";
			ShortName = "ఉపేంద్రవజ్ర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class dvimilA : Rule
		{
			public dvimilA ()
			{
				Lines = 4;
				Threshold = 3;

				RuleType = RuleType.Name;
				PadyamType = PadyamType.Vruttam;
				PadyamSubType = PadyamSubType.Vruttam;
				Frequency = Frequency.Rare;
				YatiMode = YatiMode.CharPosition;

				Prasa = true;
				PrasaYati = false;
				AnthyaPrasa = false;
				InfiniteLength = false;

				Rules = new string[][] { new string[] { "స" , "స" , "స" , "స" , "స" , "స" , "స" , "స" } };
				Yati = new int[][] { };

				Identifier = "dvimilA";
				Name = "ద్విమిలా";
				ShortName = "ద్విమిలా";

				Examples = new string[] { };

				References = new string[] { };
			}
		}
	public class prabhaata : Rule
		{
			public prabhaata ()
			{
				Lines = 4;
				Threshold = 3;

				RuleType = RuleType.Name;
				PadyamType = PadyamType.Vruttam;
				PadyamSubType = PadyamSubType.Vruttam;
				Frequency = Frequency.Rare;
				YatiMode = YatiMode.CharPosition;

				Prasa = true;
				PrasaYati = false;
				AnthyaPrasa = false;
				InfiniteLength = false;

				Rules = new string[][] { new string[] { "న" , "జ" , "జ" , "ర" , "గ" } };
				Yati = new int[][] { new int[] { 8 } };

				Identifier = "prabhaata ";
				Name = "ప్రభాత (మృగేంద్రముఖ,సువక్త్రా,అచల)";
				ShortName = "ప్రభాత (మృగేంద్రముఖ,సువక్త్రా,అచల)";

				Examples = new string[] { };

				References = new string[] { };
			}
		}
		public class jalada : Rule
		{
			public jalada ()
			{
				Lines = 4;
				Threshold = 3;

				RuleType = RuleType.Name;
				PadyamType = PadyamType.Vruttam;
				PadyamSubType = PadyamSubType.Vruttam;
				Frequency = Frequency.Rare;
				YatiMode = YatiMode.CharPosition;

				Prasa = true;
				PrasaYati = false;
				AnthyaPrasa = false;
				InfiniteLength = false;

				Rules = new string[][] { new string[] { "భ" , "ర" , "న" , "భ" , "గ" } };
				Yati = new int[][] { new int[] { 10 } };

				Identifier = "jalada";
				Name = "జలద";
				ShortName = "జలద";

				Examples = new string[] { };

				References = new string[] { };
			}
		}
	public class manOhara : Rule
	{
		public manOhara ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "జ" , "ర" , "జ" , "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "manOhara";
			Name = "మనోహర";
			ShortName = "మనోహర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ruchira : Rule
	{
		public ruchira ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "భ" , "స" , "జ" , "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "ruchira ";
			Name = "రుచిర (కలావతీ,అతిరుచిరా,సదాగతి)";
			ShortName = "రుచిర (కలావతీ,అతిరుచిరా,సదాగతి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mattamayoora : Rule
	{
		public mattamayoora ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "త" , "య" , "స" , "గ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "mattamayoora ";
			Name = " మత్తమయూర(మాయా)";
			ShortName = "మత్తమయూర (మాయా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class praharaNakalitaa : Rule
	{
		public praharaNakalitaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "భ" , "న" , "వ" } };
			Yati = new int[][] { new int[] { 8 } };

			Identifier = "praharaNakalitaa ";
			Name = "ప్రహరణకలితా (కలికా)";
			ShortName = "ప్రహరణకలితా (కలికా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class madanavilasita : Rule
	{
		public madanavilasita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "గ" } };
			Yati = new int[][] { new int[] { }};

			Identifier = "madanavilasita ";
			Name = "మదనవిలసిత (ద్రుతగతి,చపలా,మధుమతి,లటహ,హరివిలసిత)";
			ShortName = "మదనవిలసిత (ద్రుతగతి,చపలా,మధుమతి,లటహ,హరివిలసిత)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhujaGgavijRmbhitam : Rule
	{
		public bhujaGgavijRmbhitam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "మ" , "త" , "న" , "న" , "న" , "ర" , "స" , "వ" } };
			Yati = new int[][] { };

			Identifier = "bhujaGgavijRmbhitam";
			Name = "భుజఙ్గవిజృమ్భితమ్";
			ShortName = "భుజఙ్గవిజృమ్భితమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class meduradantam : Rule
	{
		public meduradantam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "భ" , "భ" , "భ" , "భ" , "భ" , "భ" , "భ" } };
			Yati = new int[][] { };

			Identifier = "meduradantam";
			Name = "మేదురదన్తమ్(కిరీట)";
			ShortName = "మేదురదన్తమ్(కిరీట)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Satapatra : Rule
	{
		public Satapatra ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "జ" , "స" , "న" , "భ" , "జ" , "స" , "న" , "గ" } };
			Yati = new int[][] { new int[] { 9 , 17 } };

			Identifier = "Satapatra ";
			Name = "శతపత్ర (చారుమతి)";
			ShortName = "శతపత్ర (చారుమతి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	
	public class mattakOkila : Rule
	{
		public mattakOkila ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "స" , "జ" , "జ" , "భ" , "ర" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "mattakOkila ";
			Name = "మత్తకోకిల(చర్చరీ,మల్లికామాల,మాలికోత్తరమాలికా,విబుధప్రియా,హరనర్తన,ఉజ్జ్వల)";
			ShortName = "మత్తకోకిల(చర్చరీ,మల్లికామాల,మాలికోత్తరమాలికా,విబుధప్రియా,హరనర్తన,ఉజ్జ్వల)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kusumalataavaellita : Rule
	{
		public kusumalataavaellita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "త" , "న" , "య" , "య" , "య" } };
			Yati = new int[][] { new int[] { 12 } };

			Identifier = "kusumalataavaellita ";
			Name = "కుసుమలతావేల్లిత (చంద్రలేఖా,చిత్రలేఖా)";
			ShortName = "కుసుమలతావేల్లిత (చంద్రలేఖా,చిత్రలేఖా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class niSaa : Rule
	{
		public niSaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "ర" , "ర" , "ర" , "ర" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "niSaa ";
			Name = "నిశా-2(నారాచ,నారాచక,మహామలికా,సింహవిక్రీడిత,వరదా )";
			ShortName = "నిశా-2(నారాచ,నారాచక,మహామలికా,సింహవిక్రీడిత,వరదా )";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maMdaakraaMta : Rule
	{
		public maMdaakraaMta ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "భ" , "న" , "త" , "త" , "గా" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "maMdaakraaMta ";
			Name = "మందాక్రాంత (శ్రీధరా)";
			ShortName = "మందాక్రాంత (శ్రీధరా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pRthvi : Rule
	{
		public pRthvi ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "స" , "జ" , "స" , "య" , "వ" } };
			Yati = new int[][] { new int[] { 9 , 12 } };

			Identifier = "pRthvi ";
			Name = "పృథ్వి (ధృతి,విలంబితగతి)";
			ShortName = "పృథ్వి (ధృతి,విలంబితగతి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class aSvagati : Rule
	{
		public aSvagati ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "భ" , "భ" , "భ" , "భ" , "గ" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "aSvagati ";
			Name = "అశ్వగతి (అశ్వాక్రాంత,పద్మముఖీ,సంగత)";
			ShortName = "అశ్వగతి (అశ్వాక్రాంత,పద్మముఖీ,సంగత)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class priyakaaMtaa : Rule
	{
		public priyakaaMtaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "య" , "న" , "య" , "స" , "గ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "priyakaaMtaa ";
			Name = "ప్రియకాంతా (కాంత)";
			ShortName = "ప్రియకాంతా (కాంత)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class phalasadana : Rule
	{
		public phalasadana ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "న" , "న" , "స" , "గ" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "phalasadana";
			Name = "ఫలసదన";
			ShortName = "ఫలసదన";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sugaMdhi : Rule
	{
		public sugaMdhi ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "జ" , "ర" , "జ" , "ర" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "sugaMdhi ";
			Name = "సుగంధి (ఉత్సవ,ఉత్సాహ,చామర,తూణక,మహోత్సవ,శాలిని,ప్రశాంతి)";
			ShortName = "సుగంధి (ఉత్సవ,ఉత్సాహ,చామర,తూణక,మహోత్సవ,శాలిని,ప్రశాంతి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class nalinee : Rule
	{
		public nalinee ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "స" , "స" , "స" , "స" } };
			Yati = new int[][] { new int[] { 10 } };

			Identifier = "nalinee ";
			Name = "నలినీ (భ్రమరావళి,శ్రీ)";
			ShortName = "నలినీ (భ్రమరావళి,శ్రీ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maMgaLamahaaSree : Rule
	{
		public maMgaLamahaaSree ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "జ" , "స" , "న" , "భ" , "జ" , "స" , "న" , "గా" } };
			Yati = new int[][] { new int[] { 9 , 17 } };

			Identifier = "maMgaLamahaaSree";
			Name = "మంగళమహాశ్రీ";
			ShortName = "మంగళమహాశ్రీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mahaasragdhara : Rule
	{
		public mahaasragdhara ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "త" , "త" , "న" , "స" , "ర" , "ర" , "గ" } };
			Yati = new int[][] { new int[] { 9 , 16 } };

			Identifier = "mahaasragdhara";
			Name = "మహాస్రగ్ధర";
			ShortName = "మహాస్రగ్ధర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class krauMchapada : Rule
	{
		public krauMchapada ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "మ" , "స" , "భ" , "న" , "న" , "న" , "య" }};
			Yati = new int[][] { new int[] { 11 , 19 }};

			Identifier = "krauMchapada ";
			Name = "క్రౌంచపద (తెలుగు)";
			ShortName = "క్రౌంచపద (తెలుగు)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ruciram : Rule
	{
		public ruciram ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "స" , "గ" }};
			Yati = new int[][] { };

			Identifier = "ruciram";
			Name = "రుచిరమ్";
			ShortName = "రుచిరమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bilva : Rule
	{
		public bilva ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "భ" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "bilva";
			Name = "బిల్వ";
			ShortName = "బిల్వ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class salila : Rule
	{
		public salila ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "లా" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "salila";
			Name = "సలిల";
			ShortName = "సలిల";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chaMdramauLi : Rule
	{
		public chaMdramauLi ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "య" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "chaMdramauLi";
			Name = "చంద్రమౌళి";
			ShortName = "చంద్రమౌళి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class ItiH : Rule
	{
		public ItiH ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "య" }};
			Yati = new int[][] { };

			Identifier = "ItiH";
			Name = "ఈతిః";
			ShortName = "ఈతిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chaMdravadana : Rule
	{
		public chaMdravadana ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "య" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "chaMdravadana ";
			Name = "చంద్రవదన (కామలతికా,కామలలితా.ఈతిః)";
			ShortName = "చంద్రవదన (కామలతికా,కామలలితా,ఈతిః)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tanumadhyaa : Rule
	{
		public tanumadhyaa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "య" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "tanumadhyaa";
			Name = "తనుమధ్యా";
			ShortName = "తనుమధ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zazivadanA : Rule
	{
		public zazivadanA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "య" }};
			Yati = new int[][] { };

			Identifier = "zazivadanA";
			Name = "శశివదనా";
			ShortName = "శశివదనా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhramaravilasita : Rule
	{
		public bhramaravilasita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "భ" , "న" , "వ" }};
			Yati = new int[][] { new int[] { 6 }};

			Identifier = "bhramaravilasita";
			Name = "భ్రమరవిలసిత";
			ShortName = "భ్రమరవిలసిత";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class rathOddhata : Rule
	{
		public rathOddhata ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "న" , "ర" , "వ" }};
			Yati = new int[][] { new int[] { 7 }};

			Identifier = "rathOddhata ";
			Name = "రథోద్ధత (పరాంతిక)";
			ShortName = "రథోద్ధత (పరాంతిక)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class saayaM : Rule
	{
		public saayaM ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "స" , "జ" , "గా" }};
			Yati = new int[][] { new int[] { 6 }};

			Identifier = "saayaM";
			Name = "సాయం";
			ShortName = "సాయం";

			Examples = new string[] { };

			References = new string[] { "New" , };
		}
	}
	public class svaagatamu : Rule
	{
		public svaagatamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "న" , "భ" , "గా" }};
			Yati = new int[][] { new int[] { 7 }};

			Identifier = "svaagatamu";
			Name = "స్వాగతము";
			ShortName = "స్వాగతము";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
		public class sumukhee : Rule
	{
		public sumukhee ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "జ" , "జ" , "వ" }};
			Yati = new int[][] { new int[] { 7 }};

			Identifier = "sumukhee ";
			Name = "సుముఖీ (ద్రుతపాదగతి)";
			ShortName = "సుముఖీ (ద్రుతపాదగతి)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kaNikA : Rule
	{
		public kaNikA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "వ" }};
			Yati = new int[][] { };

			Identifier = "kaNikA";
			Name = "కణికా";
			ShortName = "కణికా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kalA : Rule
	{
		public kalA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "గ" }};
			Yati = new int[][] { };

			Identifier = "kalA";
			Name = "కలా";
			ShortName = "కలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	
	public class krIDA : Rule
	{
		public krIDA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "య" , "గ" }};
			Yati = new int[][] { };

			Identifier = "krIDA";
			Name = "క్రీడా";
			ShortName = "క్రీడా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class valA : Rule
	{
		public valA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "గ" }};
			Yati = new int[][] { };

			Identifier = "valA";
			Name = "వలా";
			ShortName = "వలా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zrIH : Rule
	{
		public zrIH ()
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

			Rules = new string[][] { new string[] { "గ" }};
			Yati = new int[][] { };

			Identifier = "zrIH";
			Name = "శ్రీః";
			ShortName = "శ్రీః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kshiti : Rule
	{
		public kshiti ()
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

			Rules = new string[][] { new string[] { "ల" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "kshiti";
			Name = "క్షితి";
			ShortName = "క్షితి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class strI : Rule
	{
		public strI ()
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

			Rules = new string[][] { new string[] { "గా" }};
			Yati = new int[][] { };

			Identifier = "strI";
			Name = "స్త్రీ";
			ShortName = "స్త్రీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mRgI : Rule
	{
		public mRgI ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" }};
			Yati = new int[][] { };

			Identifier = "mRgI";
			Name = "మృగీ";
			ShortName = "మృగీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kanyA : Rule
	{
		public kanyA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "గ" }};
			Yati = new int[][] { };

			Identifier = "kanyA";
			Name = "కన్యా";
			ShortName = "కన్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paTu : Rule
	{
		public paTu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "ల" }};
			Yati = new int[][] { };

			Identifier = "paTu";
			Name = "పటు";
			ShortName = "పటు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sulUH : Rule
	{
		public sulUH ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "వ" }};
			Yati = new int[][] { };

			Identifier = "sulUH";
			Name = "సులూః";
			ShortName = "సులూః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maNDalam : Rule
	{
		public maNDalam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "వ" }};
			Yati = new int[][] { };

			Identifier = "maNDalam";
			Name = "మణ్డలమ్";
			ShortName = "మణ్డలమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sUriNI : Rule
	{
		public sUriNI ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "గా" }};
			Yati = new int[][] { };

			Identifier = "sUriNI";
			Name = "సూరిణీ";
			ShortName = "సూరిణీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}public class kaNThI : Rule
	{
		public kaNThI ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "జ" , "గా" }};
			Yati = new int[][] { };

			Identifier = "kaNThI";
			Name = "కణ్ఠీ";
			ShortName = "కణ్ఠీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class paGktiH : Rule
	{
		public paGktiH ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "గా" }};
			Yati = new int[][] { };

			Identifier = "paGktiH";
			Name = "పఙ్క్తిః";
			ShortName = "పఙ్క్తిః";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class praguNam : Rule
	{
		public praguNam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "గా" }};
			Yati = new int[][] { };

			Identifier = "praguNam";
			Name = "ప్రగుణమ్";
			ShortName = "ప్రగుణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vasumatI : Rule
	{
		public vasumatI ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "స" }};
			Yati = new int[][] { };

			Identifier = "vasumatI";
			Name = "వసుమతీ";
			ShortName = "వసుమతీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tilakA : Rule
	{
		public tilakA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "స" }};
			Yati = new int[][] { };

			Identifier = "tilakA";
			Name = "తిలకా";
			ShortName = "తిలకా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class kokapadam : Rule
	{
	public kokapadam ()
	{
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType = PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa = false;
		InfiniteLength = false;

		Rules = new string[][] { new string[] { "భ" , "మ" , "స" , "భ" , "న" , "న" , "న" , "య" }};
		Yati = new int[][] { };

		Identifier = "kokapadam";
		Name = "కోకపదమ్";
		ShortName = "కోకపదమ్";

		Examples = new string[] { };

		References = new string[] { };
	}
	}
	public class apavAhaH : Rule
	{
	public apavAhaH ()
	{
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType = PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa = false;
		InfiniteLength = false;

		Rules = new string[][] { new string[] { "మ" , "న" , "న" , "న" , "న" , "న" , "న" , "స" , "గా" }};
		Yati = new int[][] { };

		Identifier = "apavAhaH";
		Name = "అపవాహః(వరాహ)";
		ShortName = "అపవాహః(వరాహ)";

		Examples = new string[] { };

		References = new string[] { };
	}
	}
	
	public class Arbhavam : Rule
	{
		public Arbhavam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "జ" }};
			Yati = new int[][] { };

			Identifier = "Arbhavam";
			Name = "ఆర్భవమ్";
			ShortName = "ఆర్భవమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	
	public class kaviraajaviraajitamu : Rule
	{
		public kaviraajaviraajitamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "జ" , "జ" , "జ" , "జ" , "జ" , "జ" , "వ" }};
			Yati = new int[][] { new int[] { 8 , 14 , 20 }};

			Identifier = "kaviraajaviraajitamu ";
			Name = "కవిరాజవిరాజితము (హంసగతి,మహాతరుణీదయిత,శ్రవణాభరణమ్)";
			ShortName = "కవిరాజవిరాజితము (హంసగతి,మహాతరుణీదయిత,శ్రవణాభరణమ్)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class padmanaabha : Rule
	{
		public padmanaabha ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "త" , "త" , "త" , "త" , "త" , "త" , "గా" }};
			Yati = new int[][] { new int[] { 13 }};

			Identifier = "padmanaabha";
			Name = "పద్మనాభ";
			ShortName = "పద్మనాభ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maanini : Rule
	{
		public maanini ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "భ" , "భ" , "భ" , "భ" , "భ" , "భ" , "గ" }};
			Yati = new int[][] { new int[] { 7 , 13 , 19 }};

			Identifier = "maanini ";
			Name = "మానిని (మదిరా,లతాకుసుమ,సంగతా)";
			ShortName = "మానిని (మదిరా,లతాకుసుమ,సంగతా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class karibRMhita : Rule
	{
		public karibRMhita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "న" , "భ" , "న" , "భ" , "న" , "ర" }};
			Yati = new int[][] { new int[] { 13 }};

			Identifier = "karibRMhita";
			Name = "కరిబృంహిత";
			ShortName = "కరిబృంహిత";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mattaebhavikreeDitamu : Rule
	{
		public mattaebhavikreeDitamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "భ" , "ర" , "న" , "మ" , "య" , "వ" }};
			Yati = new int[][] { new int[] { 14 }};

			Identifier = "mattaebhavikreeDitamu";
			Name = "మత్తేభవిక్రీడితము";
			ShortName = "మత్తేభవిక్రీడితము";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhootilaka : Rule
	{
		public bhootilaka ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "భ" , "ర" , "స" , "జ" , "జ" , "గ" }};
			Yati = new int[][] { new int[] { 12 }};

			Identifier = "bhootilaka";
			Name = "భూతిలక";
			ShortName = "భూతిలక";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class SaardoolavikreeDitamu : Rule
	{
		public SaardoolavikreeDitamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "స" , "జ" , "స" , "త" , "త" , "గ" }};
			Yati = new int[][] { new int[] { 13 }};

			Identifier = "SaardoolavikreeDitamu";
			Name = "శార్దూలవిక్రీడితము";
			ShortName = "శార్దూలవిక్రీడితము";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class taraLa : Rule
	{
		public taraLa ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "భ" , "ర" , "స" , "జ" , "జ" , "గ" }};
			Yati = new int[][] { new int[] { 12 }};

			Identifier = "taraLa ";
			Name = "తరళ (ధ్రువకోకిల)";
			ShortName = "తరళ (ధ్రువకోకిల)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
		public class kavikaMThabhooshaNa : Rule
		{
			public kavikaMThabhooshaNa ()
			{
				Lines = 4;
				Threshold = 3;

				RuleType = RuleType.Name;
				PadyamType = PadyamType.Vruttam;
				PadyamSubType = PadyamSubType.Vruttam;
				Frequency = Frequency.Rare;
				YatiMode = YatiMode.CharPosition;

				Prasa = true;
				PrasaYati = false;
				AnthyaPrasa = false;
				InfiniteLength = false;

				Rules = new string[][] { new string[] { "స" , "జ" , "స" , "స" , "స" , "జ" , "గ" }};
				Yati = new int[][] { new int[] { 9 }};

				Identifier = "kavikaMThabhooshaNa ";
				Name = "కవికంఠభూషణ (కవికంఠవిభూషణ)";
				ShortName = "కవికంఠభూషణ (కవికంఠవిభూషణ)";

				Examples = new string[] { };

				References = new string[] { };
			}
		}
	public class prabhu : Rule
	{
		public prabhu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "న" , "న" , "జ" , "జ" , "జ" , "జ" , "జ" , "వ" }};
			Yati = new int[][] { new int[] { 9 , 15 , 21 }};

			Identifier = "prabhu";
			Name = "ప్రభు";
			ShortName = "ప్రభు";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class bhaaskaravilasitamu : Rule
	{
		public bhaaskaravilasitamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "న" , "జ" , "య" , "భ" , "న" , "న" , "స" , "గ" }};
			Yati = new int[][] { new int[] { 13 }};

			Identifier = "bhaaskaravilasitamu";
			Name = "భాస్కరవిలసితము";
			ShortName = "భాస్కరవిలసితము";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class chaMpakamaala : Rule
	{
		public chaMpakamaala ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "జ" , "భ" , "జ" , "జ" , "జ" , "ర" }};
			Yati = new int[][] { new int[] { 11 }};

			Identifier = "chaMpakamaala";
			Name = "చంపకమాల";
			ShortName = "చంపకమాల";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class vanamaMjari : Rule
	{
		public vanamaMjari ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "జ" , "జ" , "జ" , "జ" , "భ" , "ర" }};
			Yati = new int[][] { new int[] { 14 }};

			Identifier = "vanamaMjari";
			Name = "వనమంజరి";
			ShortName = "వనమంజరి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class sragdhara : Rule
	{
		public sragdhara ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "ర" , "భ" , "న" , "య" , "య" , "య" }};
			Yati = new int[][] { new int[] { 8 , 14 }};

			Identifier = "sragdhara";
			Name = "స్రగ్ధర";
			ShortName = "స్రగ్ధర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class utpalamaala : Rule
	{
		public utpalamaala ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;శిఖరిణి
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "ర" , "న" , "భ" , "భ" , "ర" , "వ" }};
			Yati = new int[][] { new int[] { 10 }};

			Identifier = "utpalamaala";
			Name = "ఉత్పలమాల";
			ShortName = "ఉత్పలమాల";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class SikhariNi : Rule
	{
		public SikhariNi ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "య" , "మ" , "న" , "స" , "భ" , "వ" }};
			Yati = new int[][] { new int[] { 13 }};

			Identifier = "SikhariNi";
			Name = "శిఖరిణి";
			ShortName = "శిఖరిణి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class alasagati : Rule
	{
		public alasagati ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "స" , "న" , "భ" , "య" }};
			Yati = new int[][] { new int[] { 10 }};

			Identifier = "alasagati";
			Name = "అలసగతి";
			ShortName = "అలసగతి";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class Sree : Rule
	{
		public Sree ()
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

			Rules = new string[][] { new string[] { "గ" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "Sree";
			Name = "శ్రీ(శ్రీః)";
			ShortName = "శ్రీ(శ్రీః)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class jana : Rule
	{
		public jana ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "లా" }};
			Yati = new int[][] { new int[] { }};

			Identifier = "jana ";
			Name = "జన(పుష్ప,మద,మధు,బలి,నారీ)";
			ShortName = "జన(పుష్ప,మద,మధు,బలి,నారీ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tanumadhyA : Rule
	{
		public tanumadhyA ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "త" , "య" }};
			Yati = new int[][] { };

			Identifier = "tanumadhyA";
			Name = "తనుమధ్యా";
			ShortName = "తనుమధ్యా";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class praharshiNi : Rule
	{
		public praharshiNi ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "న" , "జ" , "ర" , "గ" }};
			Yati = new int[][] { new int[] { 8 }};

			Identifier = "praharshiNi ";
			Name = "ప్రహర్షిణి (మయూరపిచ్ఛ)";
			ShortName = "ప్రహర్షిణి (మయూరపిచ్ఛ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class navanaMdinee : Rule
	{
	public navanaMdinee ()
	{
		Lines = 4;
		Threshold = 3;

		RuleType = RuleType.Name;
		PadyamType = PadyamType.Vruttam;
		PadyamSubType = PadyamSubType.Vruttam;
		Frequency = Frequency.Rare;
		YatiMode = YatiMode.CharPosition;

		Prasa = true;
		PrasaYati = false;
		AnthyaPrasa = false;
		InfiniteLength = false;

		Rules = new string[][] { new string[] { "స" , "జ" , "స" , "న" , "గా" }};
		Yati = new int[][] { new int[] { 9 }};

		Identifier = "navanaMdinee";
		Name = "నవనందినీ";
		ShortName = "నవనందినీ";

		Examples = new string[] { };

		References = new string[] { };
	}
	}
	public class sragviNee : Rule
	{
		public sragviNee ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "ర" , "ర" , "ర" , "ర" }};
			Yati = new int[][] { new int[] { 7 }};

			Identifier = "sragviNee ";
			Name = "స్రగ్విణీ (లక్ష్మీధర,పద్మినీ)";
			ShortName = "స్రగ్విణీ (లక్ష్మీధర,పద్మినీ)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class maeghavilasita : Rule
	{
		public maeghavilasita ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "న" , "న" , "స" }};
			Yati = new int[][] { new int[] { 6 }};

			Identifier = "maeghavilasita";
			Name = "మేఘవిలసిత";
			ShortName = "మేఘవిలసిత";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class pramitaakshara : Rule
	{
		public pramitaakshara ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "స" , "జ" , "స" , "స" }};
			Yati = new int[][] { new int[] { 9 }};

			Identifier = "pramitaakshara";
			Name = "ప్రమితాక్షర";
			ShortName = "ప్రమితాక్షర";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class zravaNAbharaNam : Rule
	{
		public zravaNAbharaNam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "న" , "జ" , "జ" , "జ" , "జ" , "జ" , "జ" , "వ" }};
			Yati = new int[][] { };

			Identifier = "zravaNAbharaNam";
			Name = "శ్రవణాభరణమ్";
			ShortName = "శ్రవణాభరణమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class mattAkrIDam : Rule
	{
		public mattAkrIDam ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "మ" , "మ" , "త" , "న" , "న" , "న" , "న" , "వ" }};
			Yati = new int[][] { };

			Identifier = "mattAkrIDam";
			Name = "మత్తాక్రీడమ్";
			ShortName = "మత్తాక్రీడమ్";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tanvee : Rule
	{
		public tanvee ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "త" , "న" , "స" , "భ" , "భ" , "న" , "య" }};
			Yati = new int[][] { new int[] { 13 }};

			Identifier = "tanvee";
			Name = "తన్వీ";
			ShortName = "తన్వీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	public class tanvI : Rule
	{
		public tanvI ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "త" , "న" , "స" , "భ" , "భ" , "న" , "య" }};
			Yati = new int[][] { };

			Identifier = "tanvI";
			Name = "తన్వీ";
			ShortName = "తన్వీ";

			Examples = new string[] { };

			References = new string[] { };
		}
	}
	
	public class vanamayoora : Rule
	{
		public vanamayoora ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Frequency = Frequency.Rare;
			YatiMode = YatiMode.CharPosition;

			Prasa = true;
			PrasaYati = false;
			AnthyaPrasa = false;
			InfiniteLength = false;

			Rules = new string[][] { new string[] { "భ" , "జ" , "స" , "న" , "గా" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "vanamayoora ";
			Name = "వనమయూర (ఇందువదనా)";
			ShortName = "వనమయూర (ఇందువదనా)";

			Examples = new string[] { };

			References = new string[] { };
		}
	}

}
*/
