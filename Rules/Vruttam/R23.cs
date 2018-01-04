//---------------------------------------------------------------------------------------------
// <copyright file="R23.cs" company="Chandam-ఛందం">
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
	public class kaviraajaviraajitamu : Rule
	{
		public kaviraajaviraajitamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "kaviraajaviraajitamu";
			Name = "కవిరాజవిరాజితము (హంసగతి , మహాతరుణీదయిత , శ్రవణాభరణమ్)";
			Examples = new string[] {
										"సరససమాసవిలాసవిభాసము సాధునుతంబు  సుసంధిగమున్\nవరమధురోపనతార్థ సువాక్యనిబద్ధము యోగసమంజసమున్\nఖరదశకంఠవధాధికమున్ సుమనస్సుఖదంబు మునీరితమున్\nస్ఫురదురుసద్గుణభూషణభూషితమున్ గనుఁ డీ రఘురాము కథన్",
										"కమలదళంబులకైవడిఁ జెన్నగు కన్నులు జారుముఖప్రభలున్‌\nసమధికవృత్తకుచంబులు నొప్పఁగ శైలరసర్తు విశాలయతిన్‌\nసముచితనాన్వితషడ్జలగంబుల జానుగఁ బాడిరి చక్రధరున్‌\nరమణులు సొంపలరం గవిరాజవిరాజితమున్‌ బహురాగములన్‌.",
										"అనవుడునిట్లనునన్నరపాలునకాతఁడు మోక్షమునర్థిజగ\nజ్జనులకుఁబుట్తుటసన్మతిగోరివిశారదులాదరసంబృతులై\nయనఘసుదుస్తరమైనభవంబునకచ్చగునీయితి హాసముబో\nధనమహనీయవిధంబునఁజెప్పిరిదాత్తగుణాశ్రయతామహితా ",
										"స్థితిమతులై మనుజేంద్రు లనేకులుసింధువులైవిలసిల్లినభా\nరతకవిరాజ విరాజితమైన పురాకృత కావ్యమరంద మహో\nన్నతులనుకోర సనాతనశైలి ఘనంబుగ ఘంటమునాడుచుస\nత్కృతులిటజారెను ఋత్వి జుడైకృతికృత్య మిడన్ కవిహృద్యముగా. ~ శ్రీ పిరాట్ల వెంకట శివరామకృష్ణ ప్రసాద్ గారిచే విరచితం."
									};

			Prasa = true;
			PrasaYati = false;


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Rules = new string[][] { "న జ జ జ జ జ జ వ".Split(' ') };
			Yati = new int[][] { new int[] { 8, 14, 20 } };
		}
	}

	public class padmanaabhamu : Rule
	{
		public padmanaabhamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "త,త,త,త,త,త,త,గా".Split(',') };
			Yati = new int[][] { new int[] { 13 } };


			Identifier = "padmanaabhamu";
			Name = "పద్మనాభము";
			Examples = new string[] {   "మున్నెవ్వరున్‌ లేని కాలంబునన్‌ సృష్టి మూలంబుగాఁ బద్మగర్భుసృజించెన్‌\nమున్నీటిలోఁ బాఁపతల్పంబు పై వెన్ను మోపెం ద్రిలోకంబులుం గుక్షి నుండన్‌\nఎన్నంగ నీతం డనాద్యంతుఁ డంచున్‌ నిరీక్షింతు రెవ్వారి వాఁడెల్లనాఁడున్‌\nనన్నేలు నా నర్కవిశ్రాంతమై పద్మనాభం బగున్‌ సప్తతంబుల్గగంబున్‌.",
										"శ్రీరంగనాధప్రధన్ బద్మనాభుండు సృష్టిస్థి  తిందానెయై,స్రష్టకొల్వన్\nక్షీరాబ్ధి కన్యాప్రసేవాసుఖానందసిధ్ధింగనన్   శేషతల్పంబుపై\nనారూఢయోగప్రశాంతిన్ సువిశ్రాంతినాత్మాంతసంసృష్టిరక్షించుచున్ భ\nక్తారాధ్యదైవంబుగావైభవోపేతుఁడై వెల్గుధాత్రిన్ స్వలీలావిభూతిన్   "
									};
		}
	}

	public class aSvalalitamu : Rule
	{
		public aSvalalitamu()
		{
			Lines = 4;
			Threshold = 3;


			Identifier = "aSvalalitamu";
			Name = "అశ్వలలితము (అద్రితనయా)";
			Examples = new string[] {"ఇనవిరమంబునన్ నజభజంబులింపుగ భజంబులున్‌ భవములై\nచనఁ జననొప్పు నశ్వలలితంబు సత్కృతులఁ జెప్పఁగా విశదమై\nయనుపమవైభవోజ్జ్వల హరీ సహస్రకరదోర్విదారణచణా\nనినుఁగొనియాడ ధన్యుఁడు గదయ్య నీ కరుణ దాననంత మగుటన్‌.",
									"ఇరుదెసలందురజ్జువులుగట్టియిట్టటులలాగునట్టివెరవై\nతురగచయంబుఘోరఖరరాజి త్రోలఁగను ద్రాళ్ళు వ్రీలిచనినన్\nఖరతురగంబులంగ్రమమునేగిఘాఢముగగోడలందుఁడునగన్\nతిరిగిసురారిబాహువులుగాని దేహమునుగానిసుంతచెడదున్ "
									};


			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న జ భ జ భ జ భ వ".Split(' ') };
			Yati = new int[][] { new int[] { 13 } };
		}
	}
}
