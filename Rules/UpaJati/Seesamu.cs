//---------------------------------------------------------------------------------------------
// <copyright file="Seesamu.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.UpaJati.Seesamu
{
	public class seesaM : Rule
	{
		public seesaM()
		{
			Lines = 8;
			Threshold = 4;


			Name = "సీసం-పూర్వభాగము";
			Identifier = "seesaM";
			Examples = new string[] {
										"ఇంద్రగణములారునినగణంబులురెండు\nపాదపాదమునకు బరుగుచుండు\nఇంద్రగణములారునినగణంబులురెండు\nపాదపాదమునకు బరుగుచుండు",
										"కమలాక్షు నర్చించు కరములు కరములు;\nశ్రీనాథు వర్ణించు జిహ్వ జిహ్వ;\nసురరక్షకునిఁ జూచు చూడ్కులు చూడ్కులు;\nశేషశాయికి మ్రొక్కు శిరము శిరము;\nవిష్ణు నాకర్ణించు వీనులు వీనులు; \nమధువైరిఁ దవిలిన మనము మనము;\nభగవంతు వలగొను పదములు పదములు;\nపురుషోత్తముని మీఁది బుద్ధి బుద్ధి",
										"పందికై పోరాడ ఫాలాక్షుఁ డెవ్వని;\nబలమున నా కిచ్చెఁ బాశుపతము?\nనెవ్వని లావున నిమ్మేన దేవేంద్రు;\nపీఠార్థమున నుండ బెంపుఁ గంటిఁ?\nగాలకేయ నివాత కవచాదిదైత్యులఁ;\nజంపితి నెవ్వని సంస్మరించి?\nగోగ్రహణము నాఁడు కురుకులాంభోనిధిఁ;\nగడచితి నెవ్వని కరుణఁ జేసి?",
										"క్షితిపతి! నీ ప్రశ్న సిద్ధంబు మంచిది;\nయాత్మవేత్తలు మెత్తు రఖిలశుభద\nమాకర్ణనీయంబు లయుతసంఖ్యలు గల; \nవందు ముఖ్యం బిది యఖిల వరము\nగృహములలోపల గృహమేధులగు నరు;\nలాత్మతత్త్వము లేశమైన నెఱుఁగ\nరంగనారతుల నిద్రాసక్తిఁ జను రాత్రి;\n పోవుఁ గుటుంబార్థబుద్ధి నహము",
										"అంఘ్రిమూలమున మూలాధారచక్రంబుఁ;\nబీడించి ప్రాణంబు బిగియఁ బట్టి,\nనాభితలముఁ జేర్చి, నయముతో మెల్లన;\n హృత్సరోజము మీఁది కెగయఁ బట్టి,\nయటమీఁద నురమందు హత్తించి, క్రమ్మఱఁ;\n దాలు మూలమునకుఁ దఱిమి నిలిపి,\nమమతతో భ్రూయుగమధ్యంబు సేర్చి దృ;\n క్కర్ణ నాసాస్య మార్గములు మూసి,"
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">8</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> ఒకటవ , మూడవ , ఐదవ , ఏడవ పాదములందు <span class=\"gName\">  నాలుగు ఇంద్ర</span>  గణములుండును.</li><li> రెండవ , నాలుగవ , ఆరవ , ఎనిమిదవ  పాదములందు <span class=\"gName\">రెండు ఇంద్ర , రెండు సూర్య</span>  గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.UpaJati;
			PadyamSubType = PadyamSubType.Sisamu;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {
													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra},
													new object[]{Category.Indra ,Category.Indra , Category.Surya, Category.Surya},
													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra},
													new object[]{Category.Indra ,Category.Indra , Category.Surya, Category.Surya},

													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra},
													new object[]{Category.Indra ,Category.Indra , Category.Surya, Category.Surya},
													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra},
													new object[]{Category.Indra ,Category.Indra , Category.Surya, Category.Surya},
													};
			Yati = new int[][] { new int[] { 3 } };



			Prasa = false;
			PrasaYati = true;

		}
	}
	public class sarvalaghusIsamu : Rule
	{
		public sarvalaghusIsamu()
		{
			Lines = 8;
			Name = "సర్వలఘుసీసము-పూర్వభాగము";
			Identifier = "sarvalaghusIsamu";
			Examples = new string[] { "నవ వికచ సరసిరుహ నయనయుగ! నిజచరణ\nగగనచరనది జనిత! నిగమవినుత!\nజలధిసుత కుచకలశ లలిత మృగమద రుచిర\nపరిమళిత నిజహృదయ! ధరణిభరణ!\nద్రుహిణముఖ సురనికర విహిత నుతికలితగుణ!\nకటిఘటిత రుచిరతర కనకవసన!\nభుజగరిపు వరగమన! రజతగిరిపతివినుత!\nసతతజపరత! నియమసరణి చరిత!",
									"మృగమదము తిలకమును నగు మొగముచెలువమును \nనలఁతిపవడముఁ దెగడు నధరపుటము\nవలుదజఘనములు బొలుపలరుకనకపువలువ \n కలితకరచరణమణికటకములును\nవిరులతురుమును నమిలిపురిసొబగుమకరికము \n రచన నెసఁగిన చెవుల రవణములును\nకరకమలయుగళ ధృతి మురళియును ద్రివిధమగు \n నిలుకడయు నిటలతటి నెఱయు కురులు",

									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li> ఒకటవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> రెండవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> మూడవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> నాలుగవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> ఒకటవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li><li> రెండవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li><li> మూడవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li><li> నాలుగవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.UpaJati;
			PadyamSubType = PadyamSubType.Sisamu;
			RuleType = RuleType.SubType;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5},
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5, SubCategory.LaghuSurya,SubCategory.LaghuSurya},
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5},
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5, SubCategory.LaghuSurya,SubCategory.LaghuSurya},

									new object[]{SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5},
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5, SubCategory.LaghuSurya,SubCategory.LaghuSurya},
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5,SubCategory.Laghu5},
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5, SubCategory.LaghuSurya,SubCategory.LaghuSurya},
									};
			Yati = new int[][] {
									new int[] { 3 }
								};

			Threshold = 5;

			Prasa = false;
			PrasaYati = true;
		}
	}
	public class seesaM2 : Rule
	{

		public seesaM2()
		{
			Lines = 4;
			Name = "సీసం2-పూర్వభాగము";
			Identifier = "seesaM2";
			Examples = new string[] {

										"కమలాక్షు నర్చించు కరములు కరములు;శ్రీనాథు వర్ణించు జిహ్వ జిహ్వ;\nసురరక్షకునిఁ జూచు చూడ్కులు చూడ్కులు;శేషశాయికి మ్రొక్కు శిరము శిరము;\nవిష్ణు నాకర్ణించు వీనులు వీనులు; మధువైరిఁ దవిలిన మనము మనము;\nభగవంతు వలగొను పదములు పదములు;పురుషోత్తముని మీఁది బుద్ధి బుద్ధి",
										"పందికై పోరాడ ఫాలాక్షుఁ డెవ్వని; బలమున నా కిచ్చెఁ బాశుపతము? \nనెవ్వని లావున నిమ్మేన దేవేంద్రు; పీఠార్థమున నుండ బెంపుఁ గంటిఁ? \nగాలకేయ నివాత కవచాదిదైత్యులఁ; జంపితి నెవ్వని సంస్మరించి? \nగోగ్రహణము నాఁడు కురుకులాంభోనిధిఁ; గడచితి నెవ్వని కరుణఁ జేసి? ",
										"క్షితిపతి! నీ ప్రశ్న సిద్ధంబు మంచిది; యాత్మవేత్తలు మెత్తు రఖిలశుభద\nమాకర్ణనీయంబు లయుతసంఖ్యలు గల; వందు ముఖ్యం బిది యఖిల వరము\nగృహములలోపల గృహమేధులగు నరు; లాత్మతత్త్వము లేశమైన నెఱుఁగ\nరంగనారతుల నిద్రాసక్తిఁ జను రాత్రి; పోవుఁ గుటుంబార్థబుద్ధి నహము",
										"అంఘ్రిమూలమున మూలాధారచక్రంబుఁ; బీడించి ప్రాణంబు బిగియఁ బట్టి,\nనాభితలముఁ జేర్చి, నయముతో మెల్లన; హృత్సరోజము మీఁది కెగయఁ బట్టి,\nయటమీఁద నురమందు హత్తించి, క్రమ్మఱఁ; దాలు మూలమునకుఁ దఱిమి నిలిపి,\nమమతతో భ్రూయుగమధ్యంబు సేర్చి దృ; క్కర్ణ నాసాస్య మార్గములు మూసి,",

									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li> ప్రతి పాదమునందు <span class=\"gName\">3,5,7</span> వ గణముల యొక్క మొదటి అక్షరము యతి స్థానము</li>" +
						"<li> ఒకటవ పాదమునందు <span class=\"gName\">ఆరు ఇంద్ర , రెండు సూర్య</span>  గణములుండును.</li><li> రెండవ పాదమునందు <span class=\"gName\">ఆరు ఇంద్ర , రెండు సూర్య</span>  గణములుండును.</li><li> మూడవ పాదమునందు <span class=\"gName\">ఆరు ఇంద్ర , రెండు సూర్య</span>  గణములుండును.</li>" +
						"<li> నాలుగవ పాదమునందు <span class=\"gName\">ఆరు ఇంద్ర , రెండు సూర్య</span>  గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.UpaJati;
			PadyamSubType = PadyamSubType.Sisamu;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {
													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra,Category.Indra ,Category.Indra , Category.Surya, Category.Surya},
													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra,Category.Indra ,Category.Indra , Category.Surya, Category.Surya},

													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra,Category.Indra ,Category.Indra , Category.Surya, Category.Surya},
													new object[]{Category.Indra ,Category.Indra , Category.Indra, Category.Indra,Category.Indra ,Category.Indra , Category.Surya, Category.Surya},
													};
			Yati = new int[][] { new int[] { 3, 5, 7 } };
			YatiRecycle = true;
			Threshold = 4;
			Prasa = false;
			PrasaYati = true;

		}
	}
	public class sarvalaghusIsamu2 : Rule
	{
		public sarvalaghusIsamu2()
		{
			Lines = 4;
			Name = "సర్వలఘుసీసము2-పూర్వభాగము";
			Identifier = "sarvalaghusIsamu2";
			Examples = new string[] {
										"నవ వికచ సరసిరుహ నయనయుగ! నిజచరణగగనచరనది జనిత! నిగమవినుత!\nజలధిసుత కుచకలశ లలిత మృగమద రుచిరపరిమళిత నిజహృదయ! ధరణిభరణ!\nద్రుహిణముఖ సురనికర విహిత నుతికలితగుణ!కటిఘటిత రుచిరతర కనకవసన!\nభుజగరిపు వరగమన! రజతగిరిపతివినుత!సతతజపరత! నియమసరణి చరిత!" ,
										"మృగమదము తిలకమును నగు మొగముచెలువమును - నలఁతిపవడముఁ దెగడు నధరపుటము\nవలుదజఘనములు బొలుపలరుకనకపువలువ - కలితకరచరణమణికటకములును\nవిరులతురుమును నమిలిపురిసొబగుమకరికము - రచన నెసఁగిన చెవుల రవణములును\nకరకమలయుగళ ధృతి మురళియును ద్రివిధమగు - నిలుకడయు నిటలతటి నెఱయు కురులు",
										"జలజ హిత కుల కలశ జలధి హిమ కిరణునకు - దశరథుని తనయునకు నశికి హరికి;\nజనక సుత హృదయమున తనరు ప్రియ సదనునకు - జన హృదయ నిలయునకు సహృదయునకు;\nదివిజ గణ వినుతునకు; దితిజ గణ శమనునకు - జగదవన నిరతునకు జన హితునకు;\nభవ భయములను దొలచి; పరమ సుఖములనొసగు - పరమ పురుషునకు పురహర సఖునకు",
										"నిరతము భగవతి కరుణను రసనము సరసకవితలకు సదనమవద?\nతిరముగ కృపనిడి గురువులు నడుపగ కవితలు పొరలవె? కలము కదుప\nరసమయజగమున మసలుచు మురిసెడి శుకపికములవలె సుమధురముగ\nతెలుగున పదములు వెలువడు బుధజనవినుతికి సరిపడు విధముగ సుధి!",
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li> ఒకటవ పాదమునందు <span class=\"gName\">3,5,7</span> వ గణముల యొక్క మొదటి అక్షరము యతి స్థానము</li><li> రెండవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> మూడవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> నాలుగవ పాదమునందు <span class=\"gName\">3</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> ఒకటవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li><li> రెండవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li><li> మూడవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li><li> నాలుగవ పాదమునందు <span class=\"gName\">ఆరు ఐదు అక్షరముల గణములు , రెండు సూర్య</span>  గణములుండును.</li></ol></div>";

			PadyamType = PadyamType.UpaJati;
			PadyamSubType = PadyamSubType.Sisamu;
			RuleType = RuleType.SubType;
			YatiMode = YatiMode.GPosition;
			YatiRecycle = true;

			Rules = new object[][] {
									new object[]{SubCategory.Laghu5,SubCategory.Laghu5,
												SubCategory.Laghu5,SubCategory.Laghu5,
												SubCategory.Laghu5,SubCategory.Laghu5,
												SubCategory.LaghuSurya,SubCategory.LaghuSurya},
									};
			Yati = new int[][] { new int[] { 3, 5, 7 } };

			Threshold = 5;

			Prasa = false;
			PrasaYati = true;
		}
	}
}
