//---------------------------------------------------------------------------------------------
// <copyright file="R25.cs" company="Chandam-ఛందం">
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
	public class saadhveevRttamu : Rule
	{
		public saadhveevRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,న,జ,న,స,న,న,భ,గ".Split(',') };

			Yati = new int[][] { new int[] { 8, 15, 22 } };


			Identifier = "saadhveevRttamu";
			Name = "సాధ్వీ";
			Examples = new string[] { "నారదసనకసనందనవినుత సనాథ భనజనసనాభగురుల్‌\nచారుశిఖరియతి శైల విరమణము క్ష్మాధర విరతియు సాధ్వియగున్‌.\nనారదసనకసనందనవినుత సనాథ భనజనసనాభగురుల్‌\nచారుశిఖరియతి శైల విరమణము క్ష్మాధర విరతియు సాధ్వియగున్‌."
									};
		}
	}
	public class chaarumati : Rule
	{
		public chaarumati()
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

			Rules = new string[][] { new string[] { "భ", "జ", "స", "న", "భ", "జ", "స", "న", "గ" } };
			Yati = new int[][] { new int[] { 13, 17 } };

			Identifier = "chaarumati";
			Name = "శతపత్ర (చారుమతి)";

			Examples = new string[] { "చారుమతి యొప్పును భజల్ సనభజల్ సనగసంగతి కవీంద్రవినుతా\nసారెకుఁ ద్రయోదశ సప్తదశ సద్యతి లసద్గతిని రంగనృపతీ\nచారుమతి యొప్పును భజల్ సనభజల్ సనగసంగతి కవీంద్రవినుతా\nసారెకుఁ ద్రయోదశ సప్తదశ సద్యతి లసద్గతిని రంగనృపతీ" };
		}
	}
	public class raajahaMsa : Rule
	{
		public raajahaMsa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "త,త,త,త,త,త,త,త,గ".Split(',') };

			Yati = new int[][] { new int[] { 13 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "raajahaMsa";
			Name = "రాజహంస";
			Examples = new string[] { };
		}
	}
	public class baMdhuramu : Rule
	{
		public baMdhuramu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,న,న,న,స,స,స,భ,భ,భ,గ".Split(',') };
			Yati = new int[][] { new int[] { 16 } };


			Identifier = "baMdhuramu";
			Name = "బంధురము";
			Examples = new string[] { "ఋభువులు దితితనయులు సమబలులై యెంతయు మత్సరముల్బెరయన్‌\nరభస మలరఁ గలశనిధిఁ దఱవఁగం గ్రక్కునఁ గవ్వపుఁగొండకు నీ\nప్రభు వనువుగఁ గుదురుగ నిలిచె ననం బంచదశాక్షరవిశ్రమమై\nప్రభ మిగులఁగ ననననసభభభగల్‌ బంధుర వృత్తము చెప్పఁదగున్‌." };
		}
	}
	public class bhaaskaravilasitamu : Rule
	{
		public bhaaskaravilasitamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,న,జ,య,భ,న,న,స,గ".Split(',') };
			Yati = new int[][] { new int[] { 13 } };


			Identifier = "bhaaskaravilasitamu";
			Name = "భాస్కరవిలసితము";
			Examples = new string[] {
										"గోపనికరముల నేలినవానిన్‌ గోవృషదనుజుల నడఁచినవానిన్‌\nగోపికలను బ్రమయించినవానిన్‌ గుబ్జకు విలసన మొసఁగినవానిన్‌\nగోపకులము వెలయించినవానిన్‌ గొల్చెద మని బుధు లినయతిఁ బల్కన్‌\nబ్రాపుగ భనజయభాశ్రిత నాసల్‌ భాస్కరవిలసితమగు గురుయుక్తిన్‌.",
									};
		}
	}

	public class bhujaMgavijRMbhitamu : Rule
	{
		public bhujaMgavijRMbhitamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "మ,మ,త,న,న,న,ర,స,వ".Split(',') };
			Yati = new int[][] { new int[] { 9, 19 } };


			Identifier = "bhujaMgavijRMbhitamu";
			Name = "భుజంగవిజృంభితము";
			Examples = new string[] {
										"స్వారాజారివ్రాతారాతీశశితపనసమనయన సర్వదా మునివందితా\nగౌరీశాద్యామర్త్యస్తుత్యా కమలభవజనక మధు కైటభాసురమర్దనా\nశ్రీరామాహృత్స్వామీ యంచున్‌ జెలఁగి మమతనననలఁ జెంద రేఫసలున్‌ లగన్‌\nఘోరాఘౌషూభిద్వేషిం బేర్కొనఁగ వసుదశయతియగున్‌ భుజంగవిజృంభితన్‌.",
										"భుజంగేశపర్యంక పూర్ణానురాగున్‌\nభుజంగప్రభూతాఖ్యఁ బూరించుచోటన్‌\nనిజంబై ప్రభూతావనీభృద్విరామం\nబజస్రంబుగాఁ గూర్ప యాద్వంద్వ మొప్పన్‌.",
									};
		}
	}

	public class malayajamu : Rule
	{
		public malayajamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,జ,న,స,న,న,భ,న,వ".Split(',') };
			Yati = new int[][] { new int[] { 8, 15, 22 } };


			Identifier = "malayajamu";
			Name = "మలయజము";
			Examples = new string[] {   "నళిన విలోచన నజనసనంబులు నభనగణంబులు నట లగమున్\nమలసి గిరిత్రయమహితయతుల్ తగి మలయజ వృత్తము మహి వెలయున్\nనళిన విలోచన నజనసనంబులు నభనగణంబులు నట లగమున్\nమలసి గిరిత్రయమహితయతుల్ తగి మలయజ వృత్తము మహి వెలయున్" ,
										"నలిన విలోచన నజనసనంబులు నభనగణంబులు నటలగమున్ \nమలనగిరిత్రయమహితయతుల్దగిమయలజవృత్తము మహివెలయున్ \nనలిన విలోచన నజనసనంబులు నభనగణంబులు నటలగమున్ \nమలనగిరిత్రయమహితయతుల్దగిమయలజవృత్తము మహివెలయున్ "
									};
		}
	}
}
/*public class siMdhuravRttamu : Rule
	{
		public siMdhuravRttamu ()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "న,న,న,న,స,భ,భ,భ,గ".Split ( ',' ) };

			Yati = new int[][] { new int[] { 12 } };

			PadyamSubType = PadyamSubType.Vruttam;

			Identifier = "siMdhuravRttamu";
			Name = "సింధుర";
						Examples = new string[] {
										"ఋభువులు దితితనయులు సమబలులై యెంతయు మత్సరముల్బెరయన్‌\nరభస మలరఁ గలశనిధిఁ దఱవఁగం గ్రక్కునఁ గవ్వపుఁగొండకు నీ\nప్రభు వనువుగఁ గుదురుగ నిలిచె ననం బంచదశాక్షరవిస్రమమై\nప్రబ మిగులఁగ ననననసభభభగల్‌ బంధుర వృత్తము చెప్పఁదగున్‌. "
									};
		}
	}*/
