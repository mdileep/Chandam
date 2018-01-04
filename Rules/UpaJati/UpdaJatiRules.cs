//---------------------------------------------------------------------------------------------
// <copyright file="UpdaJatiRules.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules.UpaJati
{
	public class taeTageeti : Rule
	{
		public taeTageeti()
		{
			Lines = 4;
			Threshold = 4;


			Name = "తేటగీతి";
			Identifier = "taeTageeti";
			Examples = new string[] {
										"దేవదేవుని చింతించు దినము దినము;\nచక్రహస్తునిఁ బ్రకటించు చదువు చదువు;\nకుంభినీధవుఁ జెప్పెడి గురుఁడు గురుఁడు;\nతండ్రి! హరిఁ జేరు మనియెడి తండ్రి తండ్రి." ,
										"అరసి నిర్గుణబ్రహ్మంబు నాశ్రయించి\nవిధినిషేధ నివృత్తి సద్విమలమతులు\nసేయుచుందురు హరిగుణచింతనములు\nమానసంబుల నేప్రొద్దు మానవేంద్ర! ",
										"మంద గొందల మంద నమందవృష్టిఁ,\nగ్రందుకొనుఁ డంచు నింద్రుండు మందలింపఁ\nజండపవన సముద్ధూత చటుల విలయ\nసమయ సంవర్త కాభీల జలధరములు.",
										"భద్రమగుఁగాక! నీకు నో! పద్మగర్భ!\nవరము నిపు డిత్తు నెఱిఁగింపు వాంఛితంబు;\nదేవదేవుఁడ నగు నస్మదీయ పాద\nదర్శనం బవధి విపత్తిదశల కనఘ!",
										"చేతులారంగ శివునిఁ బూజింపఁడేని\nనోరు నొవ్వంగ హరికీర్తి నుడువఁడేని\nదయయు సత్యంబు లోనుగాఁ దలఁపఁడేనిఁ \nగలుగ నేటికిఁ దల్లుల కడుపుఁ జేటు.",
										"క్షితిని  గోశంబు లరసి వీక్షింపవలయుఁ\nబిదప నాలింపఁజనును గోవిదులఁ బ్రశ్న\nసేయఁదగుఁ గడుమదిని యోచింపుటొప్పు\nనెచట నెఱుఁగనిచో నేరమెంచఁగూడ\nదనుచు నే భావి లోకుల నభినుతింతు"
									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li>ప్రతి పాదమునందు <span class=\"gName\">4</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li>ప్రతి పాదమునందు <span class=\"gName\">ఒక సూర్య , రెండు ఇంద్ర , రెండు సూర్య</span> గణములుండును.</li></ol></div>";


			RuleType = RuleType.Type;
			PadyamType = PadyamType.UpaJati;
			PadyamSubType = PadyamSubType.UpaJati;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] { new object[] { Category.Surya ,Category.Indra , Category.Indra ,
													Category.Surya ,Category.Surya }
									};
			Yati = new int[][] { new int[] { 4 } };


			Prasa = false;
			PrasaYati = true;

		}
	}
	public class aaTaveladi : Rule
	{
		public aaTaveladi()
		{
			Lines = 4;

			Name = "ఆటవెలది";
			Identifier = "aaTaveladi";
			Examples = new string[] {
										"ఇనగణత్రయంబునింద్రద్వయంబును\nహంసపంచకంబు నాటి వెలది\nఇనగణత్రయంబునింద్రద్వయంబును\nహంసపంచకంబు నాటి వెలది" ,
										"జనుల కెల్ల శుభము సాంఖ్య యోగము; దాని\nవలన ధర్మనిష్టవలన నయిన\nనంత్యకాలమందు హరిచింత సేయుట\nపుట్టువులకు ఫలము భూవరేంద్ర!",
										"పవనములు జయించి పరిహృతసంగుఁడై\nయింద్రియముల గర్వమెల్ల మాపి\nహరి విశాలరూపమందుఁ జిత్తముఁ జేర్చి\nనిలుపవలయు బుద్ధి నెఱపి బుధుఁడు.",
										"పరమ భాగవతులు పాటించు పథ మిది\nయీ పథమున యోగి యేఁగెనేని\nమగుడి రాఁడు వాఁడు మఱి సంశయము లేదు\nకల్పశతము లైనఁ గౌరవేంద్ర!",
										"సుతుల హితుల విడిచి, చుట్టాల విడిచి, యి\nల్లాలి విడిచి, బహు బలాళి విడిచి\nరాజు హృదయ మిడియె రాజీవనయనుపై\nధనము విడిచి, జడ్డుఁదనము విడిచి.",
										"నీలకంధరునకు నీకు నాకు సనత్కు\nమార ముఖ్య సుతసమాజమునకు\nధర్మ సత్త్వ బుద్ధి తత్త్వములకు నీశ్వ\nరాత్మ వినుము పరమమైన నెలవు."


									};
			RuleText = "<div><b>పద్య లక్షణములు</b>:<ol><li> <span class=\"gName\">4</span> పాదములు ఉండును.</li><li>ప్రాస నియమం <span class=\"gName\">లేదు</span></li><li>ప్రతి పాదమునందు <span class=\"gName\">4</span> వ గణము యొక్క మొదటి అక్షరము యతి స్థానము</li><li> ఒకటవ పాదమునందు <span class=\"gName\">మూడు సూర్య , రెండు ఇంద్ర</span>  గణములుండును.</li><li> రెండవ పాదమునందు <span class=\"gName\"> ఐదు సూర్య</span>  గణములుండును.</li><li> మూడవ పాదమునందు <span class=\"gName\">మూడు సూర్య , రెండు ఇంద్ర</span>  గణములుండును.</li><li> నాలుగవ పాదమునందు <span class=\"gName\"> ఐదు సూర్య</span>  గణములుండును.</li></ol></div>";



			Prasa = false;
			PrasaYati = true;

			RuleType = RuleType.Type;
			PadyamType = PadyamType.UpaJati;
			PadyamSubType = PadyamSubType.UpaJati;
			YatiMode = YatiMode.GPosition;

			Rules = new object[][] {
														new object[]{Category.Surya ,Category.Surya ,Category.Surya, Category.Indra, Category.Indra },
														new object[]{Category.Surya ,Category.Surya , Category.Surya, Category.Surya,Category.Surya},
														new object[]{Category.Surya ,Category.Surya ,Category.Surya, Category.Indra, Category.Indra },
														new object[]{Category.Surya ,Category.Surya , Category.Surya, Category.Surya,Category.Surya},
														};

			Threshold = 4;
			Yati = new int[][] { new int[] { 4 } };
		}

	}

}

