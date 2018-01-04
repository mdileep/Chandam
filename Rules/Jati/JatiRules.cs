//---------------------------------------------------------------------------------------------
// <copyright file="JatiRules.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.Jati
{
	public class kandam : Rule
	{
		public kandam()
		{

			Lines = 4;
			Threshold = 4;


			Name = "కందం";
			Identifier = "kandam";
			Examples = new string[] {
									"పలికెడిది భాగవత మఁట,\nపలికించెడివాడు రామభద్రుం డఁట, నేఁ\nబలికిన భవహర మగునఁట,\nపలికెద, వేఱొండు గాథ బలుకఁగ నేలా?",
									"లోకంబులు లోకేశులు\nలోకస్థులుఁ దెగినఁ దుది నలోకం బగు పెం\nజీకటి కవ్వల నెవ్వం\nడే కాకృతి వెలుఁగు నతని నే సేవింతున్." ,
									"బలవంతుడనాకేమని\nపలువురతో నిగ్రహించి పలుకుట మేలా\nబలవంతమైన సర్పము\nచలి చీమల చేత చిక్కి చావదె సుమతీ" ,
									"కలఁ డందురు దీనుల యెడఁ\nగలఁ డందురు పరమయోగి గణముల పాలం\nగలఁ డందు రన్నిదిశలను\nగలఁడు కలం డనెడి వాఁడు గలఁడో లేఁడో?",
									"మకర మొకటి రవిఁ జొచ్చెను;\nమకరము మఱియొకటి ధనదు మాటున డాఁగెన్;\nమకరాలయమునఁ దిరిగెఁడు\nమకరంబులు కూర్మరాజు మఱువున కరిగెన్.",
									"ఇందు గలఁ డందు లేఁ డని\nసందేహము వలదు చక్రి సర్వోపగతుం\nడెం దెందు వెదకి చూచిన\nనందందే కలఁడు దానవాగ్రణి! వింటే."
									};
			RuleText = "<div><b>పద్య లక్షణములు:</b><ol><li><span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> రెండవ పాదమునందు <span class=\"gName\">4</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> నాలుగవ పాదమునందు <span class=\"gName\">4</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> ఒకటవ పాదమునందు <span class=\"gName\">మూడు 4 మాత్రల</span>  గణములుండును.</li><li> రెండవ పాదమునందు <span class=\"gName\">ఐదు 4 మాత్రల</span>  గణములుండును.</li><li> మూడవ పాదమునందు <span class=\"gName\">మూడు 4 మాత్రల</span>  గణములుండును.</li><li> నాలుగవ పాదమునందు <span class=\"gName\">ఐదు 4 మాత్రల</span>  గణములుండును.</li><li>6వ గణము <span class='gName'>నల</span> లేదా <span class='gName'>జ</span> కావలెను.</li><li>చివరి అక్షరం <span class='gName'>గురువు</span> కావలెను.</li><li>బేసి గణం <span class='gName'>జ</span> కూడదు</li></ol></div>";


			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Jati;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 4, 4, 4 }, new object[] { 4, 4, 4, 4, 4 }, new object[] { 4, 4, 4 }, new object[] { 4, 4, 4, 4, 4 } };
			Yati = new int[][] { new int[] { }, new int[] { 4 }, new int[] { }, new int[] { 4 } };

			Prasa = true;
			PrasaYati = false;

		}
	}
	public class utsaahamu : Rule
	{
		public utsaahamu()
		{

			Lines = 4;
			Threshold = 3;

			Name = "ఉత్సాహము";
			Identifier = "utsaahamu";
			Examples = new string[] {   "గజము దెరలి దాని కొఱలి కంప మొంది పాఱఁగా\nభజన నింద్రుఁ డంకుశమునఁ బట్టి బిట్టు నిల్పుచున్\nనిజసుధారసైకపాన నిర్ణ యార్ద్ర కరమునన్\nఋజత మీఱ నిమిఱె నదియు రీతి మెఱసి క్రమ్మఱన్.",
										"చారుదేష్ణుఁ డాగ్రహించి శత్రుభీషణోగ్ర దో \nస్సారదర్ప మేర్పడన్ నిశాత బాణకోటిచే \nదారుణప్రతాపసాల్వదండనాథమండలిన్ \nమారి రేఁగినట్లు పిల్కుమార్చి పేర్చి యార్చినన్. ",
										"కామరూపధారులుం  బ్ర కాశమాన  తేజులున్\nధీమతుల్  ప్రధాయుతుల్  సుధీరతావిరాజియుల్\nభీమవేగభూరిశౌర్య విక్రమేడ్యయూథపుల్\nభూమిశతసహస్రశతము  పుట్టి  క్రాలు  చుండఁ గన్",
										"సాహచర్య మమర సప్త సవితృవర్గమును సము\nత్సాహ మెక్క నొక్కగురుఁడు చరణములు భజింపఁగా\nనీహితప్రదానలీల లెసగుకమఠమూర్తి ను\nత్సాహరీతు లుల్లసిల్ల సంస్తుతింతు రచ్యుతున్.",
										"చలికి వణకె చేతు లిచట చలికి కాళ్ళు వణకెరా\nచలికి వణకె పెదవు లిచట చలికి నోరు వణకెరా\nచలికి వణకె నంగము లిట చలికి తనువు వణకెరా\nచలియు యింట చలియు బయట చలికి జగతి వణకెరా",
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li>ప్రతి పాదమునందు <span class=\"gName\">5</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">ఏడు సూర్య గణములు, చివర ఒక గురువు</span> ఉండును.</li></ol></div>";

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] { new object[] { Category.Surya , Category.Surya , Category.Surya ,
													Category.Surya , Category.Surya , Category.Surya ,
													Category.Surya ,Category.Guruvu } };
			Yati = new int[][] { new int[] { 5 } };


			Prasa = true;
			PrasaYati = false;



		}


	}
	public class taruvOja : Rule
	{
		public taruvOja()
		{

			Lines = 4;
			Threshold = 4;

			Name = "తరువోజ";
			Identifier = "taruvOja";
			Examples = new string[] {   "ఏ నెల్ల ప్రొద్దు నా యెడ లోనఁ దలఁతు నీయభిప్రాయంబ యిది దారుణంబు\nగాన వాకునకుఁ జుల్కన తేరనోపఁ గడఁగి పాండవుల నేకత మెట్టు లనుప\nగా నగు మఱి దీని గాంగేయవిదురకలశజాశ్వత్థామ గౌతముల్ బుద్ధి\nగా నొడంబడుదురె కాదయ్య యనినఁ గౌరవజ్యేష్ఠుండు ఘనుఁ డిట్టు లనియె.",
										"నలనామకంబులు నగణాంతములుగ నాలుగంఘ్రులయందు నాలుగుఁగూర్చి\nవళులు మూఁడెడలను వరుసతో నిల్ప వలయు మూఁడవగణవర్ణంబు మొదల\nనిలుపంగ నివ్విధి నిర్మించి విశ్వనృపతికి నిచ్చిన నింపుసొంపారుఁ\nదలకొని తగఁ బ్రాలు దంపెడిచోటఁ దరుణులచే సొంపుదనరుఁ దర్వోజ",
										"ఈ విల్లు మోపెట్టి యేను బాణముల నీ యంత్రమత్స్యంబు నేసిన వాఁడ\nభావజప్రతిముఁ డిబ్బాలకుఁ దగిన పతి యిది మునిశక్తిఁ బడసిన విద్య\nగావున మీ రిప్డుగావింపుఁ డిదియ ఘనతర కార్ముక కౌశలోన్నతియు\nలావును గలవారలకు నవసరము లలితయశంబుఁ గల్యాణంబుఁ బడయ.",
										"ధరణీశుఁ డుద్యతదండుఁ డై యుచిత దండవిధానంబుఁ దప్పక ధర్మ\nచరితులఁగా మహీజనుల రక్షించి సద్వృత్తుఁ డగునది సర్వవర్ణములు\nవరుసన తమతమ వర్ణధర్మముల వర్తిల్లుదురు గడవక దండభీతి\nనరిమిత్రవర్జితుఁ డై సమబుద్ధి యగు మహీవల్లభు ననుశాసనమున.",
										"వెండి వెన్నెల కాచి వెలుగు జాబిల్లి వెండి కొండను నిల్చె విశ్వేశుపైన\nపండు వెన్నెల తోడ పరవశంబిడక పండె పూవుగ తాను ఫాలాక్షుసిగను\nకొండ కోనల పైన కురిపించి సుధలు గుండెలో తా గ్రుచ్చ గునపాలునాకు\nఎండిపోవగ గుండె ఈనాడు ఇచట ఎండమావిగ మారెనీజీవితమ్ము ",

									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li> ప్రాస నియమం <span class=\"gName\">కలదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3,5,7</span> గణముల మొదటి అక్షరములు యతి స్థానములు.</li><li>ప్రతి పాదమునందు <span class=\"gName\">మూడు ఇంద్ర , ఒక సూర్య , మూడు ఇంద్ర , ఒక సూర్య</span> గణములుండును.</li></ol></div>";
			References = new string[] { "http://andhramahabharatam.blogspot.in/2006/06/16102.html" };

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] { new object[] { Category.Indra, Category.Indra, Category.Indra, Category.Surya, Category.Indra, Category.Indra, Category.Indra, Category.Surya } };
			Yati = new int[][] { new int[] { 3, 5, 7 } };


			Prasa = true;
			PrasaYati = false;
		}
	}
	public class tripadi : Rule
	{
		public tripadi()
		{

			Lines = 3;
			Threshold = 4;

			Name = "త్రిపది";
			Identifier = "tripadi";



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {
										new object[] { Category.Indra , Category.Indra , Category.Indra , Category.Indra  },
										new object[] { Category.Indra , Category.Indra , Category.Surya , Category.Surya  },
										new object[] { Category.Indra , Category.Indra , Category.Surya},
									};

			Yati = new int[][] { };
			Examples = new string[] { "త్రిపదికి నొకయంఘ్రి నింద్రులు నలువురు\nద్యుపతులిద్దఱు సూర్యులిర్వు రౌల \nద్యుపతిద్వయార్కులునౌల" };
			References = new string[] { "http://andhramahabharatam.blogspot.in/2006/06/16102.html" };

			Prasa = true;
			PrasaYati = false;
		}
	}
	public class tripadi2 : Rule
	{
		public tripadi2()
		{

			Lines = 3;
			Threshold = 4;

			Name = "త్రిపది2";
			Identifier = "tripadi2";
			Examples = new string[] {
										"త్రిపద నీయగమన్న ఇపుడు కాదనెదవా !\nత్రిపద పేరున్న దేవివయి\nకృపజూపవా కీరవాణి !",
										"మూడు పాదాలె నన్నేడిపిమ్చె నిటుల !\nవాడిపోవగ మోము యంత\nమూడు అంతయు మారి పోయె !",
										"కపట నాటకమాడు నిపుణత ఉమ్దని ,\nతపన నొమ్దగజేసి సుతను ,\nఇపుడు జారగ జేసినావ !",
										"ఏమి పాటులె తల్లి నీ మాట కొఱకిట !\nప్రేమ జూపగ రావె యన్న\nబాము లిచ్చెదవేమిటమ్మ !",
										"చాలు చాలులె ఆట, చాలులే నేటికి\nవేళ మీరినదెంతొ ! వెళ్ళి\nవాల వలెనె పాన్పు పైన .",
										"సరవిఁ బ్రాసమునొంది సురపతుల్‌ నలువురు\nహరియు గై కార్కులు కలియ\nజరగు నిప్పగిది యై త్రిపద.",
									};
			References = new string[] { };

			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {
										new object[] { Category.Indra , Category.Indra , Category.Indra , Category.Indra  },
										new object[] { Category.Indra , Category.Indra , Category.Surya },
										new object[] { Category.Indra , Category.Indra , Category.Surya},
									};
			Yati = new int[][] { };
			Prasa = true;
			PrasaYati = false;
		}
	}
	public class shaTpadamu : Rule
	{
		public shaTpadamu()
		{

			Lines = 6;
			Threshold = 5;


			Name = "షట్పదము";
			Identifier = "shaTpadamu";
			Examples = new string[] {
									"శ్రీ రామ! జయరామ!\nధీరాత్మ! నీ ప్రేమ	\nధారాళముగ గొన్న ధన్య సీత!\nకారుణ్యమును జూపి\nనీరూప మును జూపి\nకోరిన ముక్తిని కొలుపుమయ్య!" ,
									"మెఱియంగ నిద్దఱి\nద్దఱు సురేంద్రులు మూఁడు\nతెఱెఁగులన్‌ శశిఁగూడ నర్థంబులన్‌\nనెఱిఁ గ్రాలఁగా వళ్ళు\nదొఱఁగ షట్పదరీతి\nవఱలుఁ జక్రిపదాబ్జ వర్ణనంబు.",
									};



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][]  {   new object[] { Category.Indra , Category.Indra },
										new object[] { Category.Indra , Category.Indra },
										new object[] { Category.Indra , Category.Indra,Category.Chandra },
										new object[] { Category.Indra , Category.Indra },
										new object[] { Category.Indra , Category.Indra},
										new object[] { Category.Indra , Category.Indra ,Category.Chandra },
									};
			Yati = new int[][] { new int[] { }, new int[] { }, new int[] { 3 }, new int[] { }, new int[] { }, new int[] { 3 } };

			Prasa = false;
			PrasaYati = false;

		}
	}
}


