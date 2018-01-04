//---------------------------------------------------------------------------------------------
// <copyright file="R22.cs" company="Chandam-ఛందం">
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
	public class bhadriNeevRttamu : Rule
	{
		public bhadriNeevRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,ర,న,ర,న,ర,న,గ".Split(',') };
			Yati = new int[][] { new int[] { 12 } };


			Identifier = "bhadriNeevRttamu";
			Name = "భద్రిణీ";
			Examples = new string[] {   "భాదిరనత్రయంబు గురు యుక్తమై గిరిశవిశ్రమప్రకటమై\nమేదిని నొప్పు భద్రిణికి నందు మేరునగధీర విశ్వనృపతీ\nభాదిరనత్రయంబు గురు యుక్తమై గిరిశవిశ్రమప్రకటమై\nమేదిని నొప్పు భద్రిణికి నందు మేరునగధీర విశ్వనృపతీ" ,

									};
		}
	}
	public class bhadrakamu : Rule
	{
		public bhadrakamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,ర,న,ర,న,ర,న,గ".Split(',') };
			Yati = new int[][] { new int[] { 12 } };


			Identifier = "bhadrakamu";
			Name = "భద్రకము-3";
			Examples = new string[] { "ఆది భఁజేసియవ్వలరనద్వయంబు నొగి మూఁడు తానకములన్‌\nబాదుకొనంగ నొక్కగురువొందఁ బై విరతి రుద్రసంఖ్య నిడినన్‌\nగాదనరాదు భద్రకమునాఁగ గాఢమగు వృత్త మొప్పుఁ గృతులన్\nశ్రీ దనరార నాశ్రితవితానచించితఫలప్రదాన నృహరీ!" };
		}
	}
	public class turagavalgitavRttamu : Rule
	{
		public turagavalgitavRttamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "న,న,న,న,స,జ,జ,గ".Split(',') };
			Yati = new int[][] { new int[] { 15 } };


			Identifier = "turagavalgitavRttamu";
			Name = "తురగవల్గిత (తురగ)";
			Examples = new string[] { "ననననసజజగలు తిథివిరమణంబగున్ దురగంబునన్\nగనలుచు నగరముపయి విడిసినఁ గాంచి తా నొకరుం డెదు\nర్కొని దవులకుఁ గొని చని గిరిగుహఁ గూర్కు నాముచికుందుచే\nతను యవనునిఁ బొరిగొని తని వసుధన్గణింతురు భూసురుల్.",
										"తరుణరవికరవికచసరసిజ దర్పమోచన లోచనా\nశరధినిరపధినిఖిలజలహృతి సాంద్రకంధరబంధురా\nగిరిమధనమధువిధురకర శ్రితకీరవాహనమోహనా\nస్ఫురద చిర రుచి రుచిరచిరరుచి పోషకాంబరడంబరా "
									};
		}
	}
	public class mahaasragdhara : Rule
	{
		public mahaasragdhara()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "mahaasragdhara";
			Name = "మహాస్రగ్ధర";
			Examples = new string[] {   "జయ భూపా! కృష్ణరాయా! జయ సరసగుణా! శత్రుగర్వాపహారీ!\nజయ ప్రాజ్ఞా! ఆంధ్రభోజా! జలజహితరుచా! సాహితీ సార్వభౌమా!\nజయ శ్రీవిష్ణుస్వరూపా! జయ సుకవివరా! సాక్షరానందమూర్తీ!\nజయ దేవేంద్రాభరాజత్ సకల విభవ! ధీసార తేజోనిధానా!",
										"అతిరౌద్రాకారకీలాయతదవదహనోగ్రాగ్ర సేనానిపీడా\nహతు లై నానావిధోపాయనములు గొని సౌహార్దవాంఛన్ జయశ్రీ\nశ్రితబాహుం గానఁగా వచ్చిరి సకలజగత్సేవ్యమానున్ మహేంద్ర\nప్రతిముం గౌరవ్యవంశప్రభు నఖిలమహీపాలు రాంబాలికేయున్.",
										"కనియెం దాలాంకుఁ డుద్యత్కటచటుల నటత్కాలదండాభశూలున్\nజనరక్తాసిక్తతాలున్ సమధిక సమరోత్సాహలోలుం గఠోరా\nశనితుల్యోదగ్ర దంష్ట్రా జనిత శిఖకణాచ్ఛాదితాశాంతరాళున్\nహననవ్యాపారశీలున్నతి దృఢఘనమస్తాస్థిమాలుం గరాళున్",
										"హరిపై సర్వాత్ముపై నత్యగణితగుణుపై నంతరంగంబు పర్వన్\nసరిమే నుప్పొంగఁ జావుం జయమును సరిగా సంతసంబందుచుం భీ\nకరుఁడై కాలాగ్ని పోలెం గనులుచుఁ గవిసెన్ గర్వదుర్వారుఁడై దు\nర్భరలీలన్ భూమి గంపింపఁగ దిశల ద్రువన్ భండనోద్దండవృత్తిన్.",
										"అతిశోకక్రోధవేగవ్యథితహృదయుఁడై యశ్వసాదిత్వవీరో\nద్ధతిఁ బ్రౌఢస్ఫుర్తి సెల్వొందఁగ సబళముఁ దద్గాత్రముం జొప్పెఁ బూఁచె\nన్శృతసోముం డల్లఁ బట్టెన్గురుసుతుఁ డదియున్ స్రుక్క చెన్నారనల్క\nన్ధృతఖడ్గుం డైనఁ జేయున్సిరముఁ దురగమున్వ్రేల్మడిం ద్రుంచి వైచెన్.",
										"శ్రుతసేనుం డప్డు కోపస్ఫురదరుణమరీచుల్ దలిర్పంగఁ జక్షు\nర్ద్వితయంబుం గెంపునం బొందినచెలువము సందీప్తఘోరంబుగా బె\nట్టతనిం జంచద్గదన్ వ్రేయఁగ నుఱక తదాస్యచ్ఛిదాస్ఫారకేళీ\nచుతురుండై యక్కుమారున్ జముకడ కనిచెం జండదోర్దర్ప మొప్పన్.",
										"వితతజ్యానాద మాశావితతి నినిచి దోర్వీర్య మేపార బాణ\nప్రతతిం దన్ముంప వీఁకం బలక జడియుచున్ బల్విడిం జేర్చి చంచ\nధ్గతిఁ గ్రీడం దంతిహేలాదళనరతమృగేంద్రస్ఫురన్మూర్తి దోఁపన్\nశ్రుతకీర్తిం గిట్టి కంఠత్రుటనవిలసనారూఢి నవ్విప్రుఁ డొప్పెన్.",
										"కొలిచెం బ్రోత్సాహవృత్తిం గుతలగగనముల్‌ గూడ రెండంఘ్రులం దా\nబలిఁ బాతాళంబు చేరం బనిచెఁ గడమకై బాపురే వామనుండ\nస్ఖలితాటోపాఢ్యుఁ డంచుం గరిగిరివిరమాకార మారన్‌ నతానో\nజ్జ్వలసోద్యద్రేఫయుగ్మాశ్రయగురుల మహాస్రగ్ధరం జెప్ప నొప్పున్‌.",
									};



			Prasa = true;
			PrasaYati = false;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "స త త న స ర ర గ".Split(' ') };
			Yati = new int[][] { new int[] { 9, 16 } };
		}
	}
	public class maanini : Rule
	{
		public maanini()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "maanini";
			Name = "మానిని (మదిరా , లతాకుసుమ , సంగతా)";
			Examples = new string[] {
										"కొన్నెలపువ్వును గోఱలపాఁగయుఁ గూర్చిన కెంజడ కొప్పునకున్‌\nవన్నె యొనర్చిన వాహిని యీతని వామపదంబున వ్రాలెననన్‌\nజెన్నుగ నద్రిభసేవ్యగురున్విలసిల్లు రసత్రయ చిత్రయతుల్‌\nపన్నుగఁ నొందఁ బ్రభాసురవిశ్రమ భంగిగ మానిని భవ్యమగున్‌.",
										"బంగరుచేలయుఁ బద్మనిఖాక్షులు బాహుచతుష్కము భవ్యవిభో\nత్సంగిత శంఖసుదన్శన శార్జగదాముఖ చిహ్నము తత్త్వ మునీ\nలాంగము నీనదియౌరసృజించు నిజాశిత దేహికినంతిక స\nద్రంగశయానుఁది రంబుగఁజూచికరంబిదివోచతురత్వమనున్"
									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;

			Prasa = true;
			PrasaYati = false;


			Rules = new string[][] { "భ భ భ భ భ భ భ గ".Split(' ') };
			Yati = new int[][] { new int[] { 7, 13, 19 } };
		}
	}
	public class madraka : Rule
	{
		public madraka()
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

			Rules = new string[][] { new string[] { "భ", "ర", "న", "ర", "స", "స", "న", "గ" } };
			Yati = new int[][] { new int[] { 11 } };

			Identifier = "madraka";
			Name = "మద్రక";

			Examples = new string[] { "దక్షిణదిక్కు పోయితిని చందనాగభుజంగవిషానలఝరీ\nకుక్షి గిరీంద్రమెక్కితిని దిక్కుడుఁ గవితాననిరూషితమతిన్\nదీక్ష నగస్త్యవాసము హసంతి దివ్యతపశ్ఛటఁ గాంచితి విరూ\nపాక్షుని వాలి నందు గని దీర్యదాశభయానఁ బలాయితుఁడనై" };
		}
	}
}
