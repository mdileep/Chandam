//---------------------------------------------------------------------------------------------
// <copyright file="R17.cs" company="Chandam-ఛందం">
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
	public class maMdaakraaMta : Rule
	{
		public maMdaakraaMta()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "మ,భ,న,త,త,గా".Split(',') };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "maMdaakraaMta";
			Name = "మందాక్రాంతము (శ్రీధరా)";
			Examples = new string[] {
									"వీణానాదప్రతిమ నిగమావిర్భవత్సారపుణ్య\nశ్రేణీసంపాదిత విమలతాస్థేమనిర్లేపచిత్త\nత్రాణక్రీడాకలనసతతోత్సాహవద్ధివ్యభావా\nప్రాణాపానాహరణ నిపుణప్రాపణీయానుభావా",
									"చెందెం బాదాంబుజరజముచే స్త్రీత్వ మారాతికిం జే\nయందెం జాపం బిరుతునుకలై యద్భుతం బావహిల్లన్‌\nమ్రందెన్మారొడ్డి దశముఖుఁడున్‌ రాముచే నంచుఁ జెప్పన్‌\nమందాక్రాంతన్‌ మభనతతగా మండితాశా యతుల్గాన్‌."
									};
		}
	}
	public class narkuTamu : Rule
	{
		public narkuTamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,జ,భ,జ,జ,వ".Split(',') };

			Yati = new int[][] { new int[] { 11 } };


			Identifier = "narkuTamu";
			Name = "నర్కుటము (కోకిలకాక , నర్దటకమ్)";
			Examples = new string[] {
									"కొలిచెద నందగోపసుతు కోమలపాదములన్‌\nదులిచెదఁ బూర్వసంచితపు దోషములన్‌ సుఖినై\nనిలిచెద నన్న నర్కుటము నిర్మలవృత్తమగున్‌\nసలలితమై నజంబుల భజావల దిగ్విరతిన్‌.",
									"ప్రసృతివిలోచనాకుసుమబాణదిశాలలనా\nఘసృణపటీరలేపకృతికోవిదబాహుతటీ\nవిసృమరకీర్తిజాలరణవీక్షితవైరినృప\nత్యసృగతిపంకిలాసిముఖయైందవవంశమణీ!!"
								};
		}
	}
	public class padakOkilakaaMka : Rule
	{
		public padakOkilakaaMka()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,జ,భ,జ,జ,వ".Split(',') };
			Yati = new int[][] { new int[] { 8, 14 } };

			PadyamSubType = PadyamSubType.Vruttam;

			Identifier = "padakOkilakaaMka";
			Name = "పదకోకిలకాంక";
			Examples = new string[] { };
		}
	}
	public class hariNi : Rule
	{
		public hariNi()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "hariNi";
			Name = "హరిణి";
			Examples = new string[] {   "హరిణియను వృత్తంబొప్పున్ భాస్కరాత్తవిరామమై\nసరినమరేఫస్వంబై షోడశప్రమదాసహ\nస్రరమణుఁ దృణావర్తక్రవ్యాదసంహరు మస్తకో\nపరిరుచిపింఛాచూడుం బీతవస్త్రు నుతింపఁగా",
										"జరగు నసమప్రోద్యద్రేఫల్‌ ససంగతమై లగల్‌\nదొరయఁగ మురద్వేషిన్‌ సద్భక్తితో వినుతించెదన్‌\nసరసిరుహగర్భే శానాదిత్యసత్తము నన్నచో\nహరిణి యనువృత్తం బొప్పారున్‌ బురారి విరామమై."
									};


			RuleType = RuleType.Name;
			PadyamSubType = PadyamSubType.Vruttam;

			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,స,మ,ర,స,వ".Split(',') };
			Yati = new int[][] { new int[] { 12 } };
		}
	}
	public class SikhariNi : Rule
	{
		public SikhariNi()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "య,మ,న,స,భ,వ".Split(',') };

			Yati = new int[][] { new int[] { 13 } };

			PadyamSubType = PadyamSubType.Vruttam;

			Identifier = "SikhariNi";
			Name = "శిఖరిణి";
			Examples = new string[] {
									"తపస్స్వాధ్యాయాదిక్షపితమలచిత్తప్రకలితా\nవిపజ్జాలజ్వాలావిరమణసుధావృష్టిలలితా\nజపాపుష్పక్షీరచ్ఛవికిరణసంసర్జనధురా\nసపర్వానిర్వాహప్రచురకలనస్థైర్యమధురా",
									"గజేంద్రాపద్ధ్వంసిన్‌ ముదిరసదృశుం గంజనయనున్‌\nభజింతుం దాత్పర్యంబున ననినచో భాస్కరయతిన్‌\nప్రజాహ్లాదం బైనన్‌ యమనసభవప్రస్ఫురితమై\nద్విజశ్రేష్ఠుల్మెచ్చన్‌ శిఖరిణి గడున్‌ విశ్రుతమగున్‌."
									};
		}
	}
	public class vaMSapattrapatita : Rule
	{
		public vaMSapattrapatita()
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

			Rules = new string[][] { new string[] { "భ", "ర", "న", "భ", "న", "వ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "vaMSapattrapatita";
			Name = "వంశపత్రపతిత";
			Examples = new string[] { "బాగగు వంశపత్రపతితన్ భరనభనలగల్\nబాగగు వంశపత్రపతితన్ భరనభనలగల్\nబాగగు వంశపత్రపతితన్ భరనభనలగల్\nబాగగు వంశపత్రపతితన్ భరనభనలగల్" };
		}
	}
	public class pRthiveevRttamu : Rule
	{
		public pRthiveevRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,స,జ,స,య,వ".Split(',') };

			Yati = new int[][] { new int[] { 12 } };

			PadyamSubType = PadyamSubType.Vruttam;

			Identifier = "pRthiveevRttamu";
			Name = "పృథ్వి-2";
			Examples = new string[] {   "అమూల్యమణిభూషణంబులు గజాశ్వబృందంబులున్\nసమృద్ధధనధాన్యరాసులు ప్రశస్తగోవర్గముల్\nగ్రమంబునను భూసురేశుల కగణ్యపుణ్యార్థియై\nయమర్త్యనిభుఁడిచ్చెఁ బాండువిభుఁ డత్యుదారస్థితిన్",
										"జసంబులు జసంబులున్‌ యలగ సంగతిన్‌ సాంగమై\nపొసంగ నమృతాంశుభృద్యతులు పొందఁ బాదంబులై\nబిసప్రసవలోచనా! వినుము పృథ్వినాఁ బృథ్విలో\nనసంశయమగున్‌ భవద్వినుతులందు నింపొందినన్‌." };
		}
	}
	public class dhRti : Rule
	{
		public dhRti()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "జ,స,జ,స,య,వ".Split(',') };

			Yati = new int[][] { new int[] { 9 } };


			Identifier = "dhRti";
			Name = "ధృతి (పృథ్వి , విలంబితగతి)";
			Examples = new string[] { "ప్రతాపగుణభూషణా పరహితార్థసంభాషణా\nవితీర్ణిరవినందనా విభవనూత్నసంక్రందనా\nశ్రుతిస్మృతివిచక్షణా సుకృతకీర్తిసంరక్షణా\nక్షితీంద్రనుతవర్తనా శివపదద్వయీకీర్తనా" };
		}
	}
	public class paalaaSadaLamu : Rule
	{
		public paalaaSadaLamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;

			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,న,న,న,న,గా".Split(',') };
			Yati = new int[][] { new int[] { 11 } };


			Identifier = "paalaaSadaLamu";
			Name = "పాలాశదళము (త్వరితగతి)";
			Examples = new string[] { "పదునయిదు లఘువులును బరఁగ గగ మొందన్‌\nబదియగునెడ విరతులు బలసి పొడసూపన్‌\nబొదలి హరినుతులఁ గడు దొలుపగుచుఁ బాలా\nశదళ మనఁబరఁగుఁ గవిజనులు గొనియాడన్‌." };
		}
	}
	public class chaMpakakEsari : Rule
	{
		public chaMpakakEsari()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "స", "స", "వ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "chaMpakakEsari";
			Name = "చంపకకేసరి ";
			Examples = new string[] { "సజసాస్వలౌ యతి గజంబులఁ జంపకకేసరిన్\nసజసాస్వలౌ యతి గజంబులఁ జంపకకేసరిన్\nసజసాస్వలౌ యతి గజంబులఁ జంపకకేసరిన్\nసజసాస్వలౌ యతి గజంబులఁ జంపకకేసరిన్" };

		}
	}
}

/*public class maMdaakraaMtamu : Rule
	{
		public maMdaakraaMtamu ()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "maMdaakraaMtamu";
			Name = "మందాక్రాంతము";
						Examples = new string[] { 
										"చెందెం బాదాంబుజరజముచే స్త్రీత్వ మారాతికిం జే\nయందెం జాపం బిరుతునుకలై యద్భుతం బావహిల్లన్‌\nమ్రందెన్మారొడ్డి దశముఖుఁడున్‌ రాముచే నంచుఁ జెప్పన్‌\nమందాక్రాంతన్‌ మభనతతగా మండితాశా యతుల్గాన్‌."
									};

			Prasa = true;
			PrasaYati = false;

			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "మ భ న త త గా".Split ( ' ' ) };
			Yati = new int[][] { new int[] { 11 } };




		}
	}*/
