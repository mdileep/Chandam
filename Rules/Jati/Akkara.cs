//---------------------------------------------------------------------------------------------
// <copyright file="Akkara.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Jati.Akkara
{
	public class mahaaakkara : Rule
	{
		public mahaaakkara()
		{
			Lines = 4;
			Threshold = 5;


			Name = "మహాక్కర";
			Identifier = "mahaaakkara";
			Examples = new string[] {
										"ఆదివార మాదిగ ననుక్రమమున - నన్నివాసరముల నొక్కినుండు\nనాదితేయాధినాథు లేగురు నల - రారంగ నొక్కసుధాకరుండు\nనాది హరిఁ గొల్వ రెండును నాలుగు - నగు వాసరంబున నర్కుఁడైన\nనాదరంబున నెడసొచ్చునని మ - హాక్కరం బలుకుదు రార్యు లెల్ల.",
										"వారిజాప్తుండు పంచేంద్రగణములు వనజారియును గూడి వెలయుచుండ\nనారయ రెండవ నాలవచోట్ల నర్కుండయిననుం దనర్చుచుండఁ\nగోరి యవ్వడిపంచమగణమునఁ గూడి మొదల నిలుపంగ నగు\nసారమై ప్రాసవడి సప్తగణములు సాఁగ మహాక్కర యతిశయిల్లు",
										"మొదట  సూర్యుండు  పదపగా నింద్రుండు మొదలుగా నేవురు  వరలుచుమ్డ్రు\nమెదల  సూర్యుండు  పిమ్మట నేగురు పురుహుతులదకంగ జంద్రుడొండు\nముదము తోనెడ సొచ్చు మహాక్కర మొనసి కావ్యములందు  నిడగ కృష్ణ",

									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">5</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">ఒక సూర్య ,ఐదు ఇంద్ర , ఒక చంద్ర</span> గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Akkara;

			Rules = new object[][] { new object[] { Category.Surya , Category.Indra , Category.Indra ,
													Category.Indra , Category.Indra ,Category.Indra , Category.Chandra } };
			Yati = new int[][] { new int[] { 5 } };//To be Checked


			Prasa = true;
			PrasaYati = false;

		}
	}
	public class madhyaakkara : Rule
	{
		public madhyaakkara()
		{
			Lines = 4;
			Threshold = 4;


			Name = "మధ్యాక్కర";
			Identifier = "madhyaakkara";

			Examples = new string[] {
									"ఓజతో నిద్దఱింద్రులును నొక్కయాదిత్యుండు మఱియు\nరాజితంబుగ నిద్ద ఱమర రాజులు నొక్కసూర్యుండు\nపూజింతు రత్యంతభక్తిఁ బుండరీకాక్షు ననంతు,\nభ్రాజిల్లు బుధులు మధ్యాక్కరంబు నొప్పారఁ బల్కుదురు.",
									"కలదవి నాలుగు మధ్య కరకును చరణము చూడ, \nనిలుచును నిండగు ప్రాస నియమము చక్కని విధము \nమొలకేత్తును యెతియు నిచట మొదలుగ నాల్గవగణము \nచలుపుచు ఇంద్రులుభయులు చండాంశు రెండుమారులిక ~ శ్రీ పిరాట్ల వెంకట శివరామకృష్ణ ప్రసాద్ గారిచే విరచితం.",
									"మహిళను దూషించువాడు మాన్యుడు జగతిన్ నిజమ్ము\nబహుబంధనములు గల్గించి పట్టిలాగుచునుండు ననుచు\nబహు విధముల వేదికపయి పల్కు ప్రగల్భాలు గాని\nమహినట్టి వాడె భార్యయెడ మసలు నెంతయు వినయమున",
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">4</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">రెండు ఇంద్ర , ఒక సూర్య , రెండు ఇంద్ర , ఒక సూర్య</span> గణములుండును.</li></ol></div>";




			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Akkara;
			Rules = new object[][] { new object[] { Category.Indra , Category.Indra , Category.Surya ,
													Category.Indra , Category.Indra , Category.Surya } };
			Yati = new int[][] { new int[] { 4 } };


			Prasa = true;
			PrasaYati = false;



		}
	}
	public class madhuraakkara : Rule
	{
		public madhuraakkara()
		{

			Lines = 4;
			Threshold = 5;

			Name = "మధురాక్కర";
			Identifier = "madhuraakkara";
			Examples = new string[] {   "రవియు నింద్రులు మువ్వురు రాజొకండును గలసి\nరవిసుధాకర లోచను రాజితాసన సరోజ\nరవికులేశ గొలుతురని ప్రస్తుతింతురు ధరిత్రి\nనవిరళం బగు మధురాక్కరాఖ్యచే సత్కవులు",
										"తనర జనకుండు నన్నప్రదాతయును భయత్రాత\nయును ననఁగ నింతులకు మువ్వు రొగిన గురువులు వీర\nలనఘ యుపనేత మఱియు నిరంతరాధ్యాపకుండు\nననఁగఁ బురుషున కియ్యేవు రనయంబును గురువులు",
										"తరణి వాసవ త్రితయంబు ధవళ భానుయుతి నొంద\nనిరతి విశ్రాంతి నాలవనెలవున నింపుమీఱ\nసరసమధురార్ధములఁ జెప్పఁ జను మధురాక్కరంబు\nవరుసఁ బంచగణములను వాలి కృతుల వెలయు"
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">4</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">ఒక సూర్య , మూడు ఇంద్ర , ఒక చంద్ర</span> గణములుండును.</li></ol></div>";
			References = new string[] { "http://andhramahabharatam.blogspot.in/2005/11/1449.html" };

			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Akkara;

			Rules = new object[][] { new object[] { Category.Surya, Category.Indra, Category.Indra, Category.Indra, Category.Chandra } };
			Yati = new int[][] { new int[] { 4 } };

			Prasa = true;
			PrasaYati = false;
		}
	}
	public class aMtaraakkara : Rule
	{
		public aMtaraakkara()
		{

			Lines = 4;
			Threshold = 5;

			Name = "అంతరాక్కర";
			Identifier = "aMtaraakkara";
			Examples = new string[] {   "సాగరపు తీరమున సంచరించే వేల?\nసాగరము నీ మనసు సంశయమ్మిం కేల?\nసాగర తరంగములు చంచలమ్మై తేలు\nరాగ-మయమౌ పలు వరాల సద్భావాలు!",
										"స్వర్ణమయ సంధ్య యది చంచలమ్మై పిల్చు\nవర్ణముల చిత్ర మది వైభవమ్మై నిల్చు\nకర్ణములు గీతికల కాకలీ-నాదంపు\nపూర్ణ-సుఖ మందె నహ బుద్బుదమ్మీ యింపు!",
										"కమలమిత్రుండు సురరాజగణ యుగంబు\nకమలశత్రునితోఁ జెంది కందళింప\nనమరుఁ బ్రావళ్ళు నర్థంబు నతిశయిల్ల\nనమల మగు నంతరాక్కర మబ్ధిసంఖ్య",
										"ఇనుఁ డొకండును నింద్రు లిద్దఱును నొక్క\nవనజవైరియుఁ గూడి వైభవ మొనర్ప\nగనకవస్త్రుని గృత్తకైటభుని గొల్తు\nరనుచుఁ జెప్పుదు రంతరాక్కర బుధులు."
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క చివరి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">ఒక సూర్య , రెండు ఇంద్ర , ఒక చంద్ర</span> గణములుండును.</li></ol></div>";
			References = new string[] { "https://groups.google.com/forum/#!topic/telugu-unicode/WCB3vugeOPA" };

			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Akkara;

			Rules = new object[][] { new object[] { Category.Surya, Category.Indra, Category.Indra, Category.Chandra } };
			Yati = new int[][] { new int[] { 3 } };//Last Letter of 3rd Gana .. A very Special Case  specific to this

			ReverseYati = true;//To indicate as a last char  of given gana

			Prasa = true;
			PrasaYati = false;
		}


	}
	public class alpaakkara : Rule
	{
		public alpaakkara()
		{

			Lines = 4;
			Threshold = 5;

			Name = "అల్పాక్కర";
			Identifier = "alpaakkara";
			Examples = new string[] {   "మీరిందు శంబరు మెచ్చిచూడ\nనారూఢి నేనొక్క హయము నెక్క\nచూరించి పోవన దుర్గభూమి\nభారంబుగా జొచ్చె నాజి వేగ",
										"సుమనఃపతియుగము సోముండును\nనెమకంగఁ బ్రావళ్ళు నిండిమీఱ\nగమనీయవిభవంబుగాంచునెప్డు\nరమణీయ మల్పాక్కరము కృతుల" ,
										"ఒగి నిద్దఱింద్రులు నొకవిధుండు\nజగతీధరుని పదాబ్జములు గొల్తు\nరగణితభక్తి నంచభినుతింప\nనెగడు నల్పాక్కర నియతితోడ."
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">రెండు ఇంద్ర , ఒక చంద్ర</span> గణములుండును.</li></ol></div>";


			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Akkara;

			Rules = new object[][] { new object[] { Category.Indra, Category.Indra, Category.Chandra } };
			Yati = new int[][] { new int[] { 3 } };


			Prasa = true;
			PrasaYati = false;
		}


	}
}