//---------------------------------------------------------------------------------------------
// <copyright file="R24.cs" company="Chandam-ఛందం">
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
	public class krauMchapadaM : Rule
	{
		public krauMchapadaM()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "krauMchapadaM";
			Name = "క్రౌంచపదం (పంచశిర , కోకపదమ్)";
			Examples = new string[] { "కాంచనభూషాసంచయ మొప్పన్‌ ఘనకుచభరమునఁ గవు నసియాడన్‌\nజంచలనేత్రల్వంచనతోడన్‌ సముచితగతి వెనుచని తనుఁ గొల్వన్‌\nఅంచితలీలన్మించినశౌరిన్‌  హరిదిభపరిమితయతు లొనఁగూడన్‌\nముంచి రచింపం గ్రౌంచపదం బిమ్మొగి భమసభననముల నయలొందున్‌.",
									"చంచలవీచూసంచయలీలాసలలితతరళితజలరుహపాళీ\nసంచితహస్తోదంచితభంగీజనితమదనమతసరణిగుణవ్యా\nఖ్యాంచితగోష్ఠీసంచరణప్యత్యయసముచితహళహళికలతోరా\nయంచలు మ్రేయన్‌గొంచలుగూయన్ వ్యవహితపరరవమయినకొలంకున్ " };



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Rules = new string[][] { "భ మ స భ న న న య".Split(' ') };
			Yati = new int[][] { new int[] { 11, 19 } };


			Prasa = true;
			PrasaYati = false;
		}
	}

	public class sarasijamu : Rule
	{
		public sarasijamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "మ,త,య,న,న,న,న,స".Split(',') };
			Yati = new int[][] { new int[] { 10, 18 } };


			Identifier = "sarasijamu";
			Name = "సరసిజము";
			Examples = new string[] { "సంబంధించున్మత్యలు నానాసలు దశనిధియతి సరసిజమునకున్\nగంబూరన్బృందాటవిలోనం గవిసికొనిన సురకరువలి దనుజున్\nశంబాభీలంబై తగుముష్టిం జదిపిన యదుపతి స్తవముల ననురా\nగం బూరన్శోభిల్లఁగఁ బ్రాంచత్కవివరు లభినుతిఁ గఱపుదు రవనిన్.",
										"రమ్యత్వంబారఁగఁబెంపూర్జితముగ మణివిరచితమకుటములుం\nదారుంజూడన్ సారవిభూతిన్ ధరణిపులనిమిషదవనిభిలగుచున్ \nభూరిప్రీతిన్ సూరెలగొల్వన్ భువనవినుతమగు పొలుపువెలయ ము\nన్నీ రాజుండున్ దారుణదైవం బిటువఱు చునెతుది నితనిఁగటకటా "
									};
		}
	}

	public class ashTamoorti : Rule
	{
		public ashTamoorti()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "ashTamoorti";
			Name = "అష్టమూర్తి";
			Examples = new string[] { "శ్రీనాథున్‌ సరసిజాక్షున్‌ సితసరోజాతనాభున్‌ జితనిశాటవరేణ్యున్‌\nగానోదంచితరసజ్ఞుం గరిభయధ్వాంతభానున్‌ గనకవస్త్రవిలాసున్‌\nజానొందన్మనతయుక్తిన్‌ సరభజల్‌ యాంతమై కుంజరయతిద్వయ మొప్పం\nగా నిట్లొంపెసఁగఁ జెప్పెం గవిజనం బష్టమూర్తిన్‌ ఘనసమాగమరీతిన్‌.",
										"నాక్పృగ్వీవిధితినేగున్‌నతమహాసారమాగున్‌నగమహాకృతిజోగున్\nబాకారిప్రముఖసౌరప్రణతి గంభీరరేఖాప్రవిమలాధుతతేజః\nప్రాకారాంతరనిగూఢప్రచలనాభోగధర్మప్రసరణాంచితమూర్తిన్\nలోకాలోకకుధరాంభోలులితపర్యాయమూర్తిన్ లుఠనమంథరమూర్తిన్ " };


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "మ న త స ర భ జ య".Split(' ') };
			Yati = new int[][] { new int[] { 9, 17 } };
		}
	}
}

