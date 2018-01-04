//---------------------------------------------------------------------------------------------
// <copyright file="R19.cs" company="Chandam-ఛందం">
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
	public class kavikaMThavibhooShaNa : Rule
	{
		public kavikaMThavibhooShaNa()
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

			Rules = new string[][] { new string[] { "స", "జ", "స", "స", "స", "జ", "గ" } };
			Yati = new int[][] { new int[] { 9 } };

			Identifier = "kavikaMThavibhooShaNa";
			Name = "కవికంఠభూషణ (కవికంఠవిభూషణ)";

			Examples = new string[] { "పొరపొచ్చెమున్నె మన మువ్వురు తల్లులు మువ్వురున్ రమా\nదరణీయమూర్తు లవదాతయశోనిధు లందు నాపయిన్\nదిరమైన  ప్రేమ నియతిం జనువారలు వారిలోననున్\nమఱియుం గడిందిగను మన్ననచేయున కైకకాదటే" };
		}
	}
	public class SaMbhu : Rule
	{
		public SaMbhu()
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

			Rules = new string[][] { new string[] { "స", "త", "య", "భ", "మ", "మ", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "SaMbhu";
			Name = "శంభు";

			Examples = new string[] { "శ్రితహృత్పంద్మాంతరసంస్స్పందాయితరేఖావిజ్ఞేయాకారా\nక్షితిభృత్కన్యాధరకాంతిశ్రీవివశీభూతాంతర్వాపారా\nప్రతనుప్రాణాంతరవర్తీ భూనతవల్లీరేఖోద్యత్పుష్పా\nమతి సంవిద్వేదనమర్మప్లావితభక్తాలీనిర్యద్భాష్పా" };
		}
	}
	public class Subhika : Rule
	{
		public Subhika()
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

			Rules = new string[][] { new string[] { "మ", "భ", "న", "న", "భ", "భ", "గ" } };
			Yati = new int[][] { new int[] { 13 } };

			Identifier = "Subhika";
			Name = "శుభిక";

			Examples = new string[] { "సూరిస్తుత్యా మభవనవిలసిత సూర్యయతిన్ శుభికా\nకారంబై యెల్లకృతుల వెలయును కల్పితభాగలన్\nసూరిస్తుత్యా మభవనవిలసిత సూర్యయతిన్ శుభికా\nకారంబై యెల్లకృతుల వెలయును కల్పితభాగలన్" };
		}
	}
	public class chaMdrakaLa : Rule
	{
		public chaMdrakaLa()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "ర,స,స,త,జ,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 11 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "chaMdrakaLa";
			Name = "చంద్రకళ";
			Examples = new string[] {
										"మున్నువిన్నది దేవరహస్యంబున్ దమకున్ వినిపింపగా\nనెన్నొసార్లు తలంచితిగానీ యేను వచింపనెలేదు నే\nడెన్నజెప్పకయున్నఫలంబొక్కంతయులేదుధరాధిపా\nమున్నుదేవయుగంబున వింటిన్ భూపభవత్సుత హేతువున్",
										"వీనులారఁ బ్రసిద్ధపదంబుల్‌ వేడుకఁ గూర్చి దిశాయతిన్‌\nగాన వచ్చి రపాతజజంబుల్‌ గల్గ దిటంబుగఁ జెప్పగన్‌\nజానకీవదనాంబుజ శశ్వత్సౌరభలోల మధువ్రతా\nదానవాంతక చంద్రకళా వృత్తంబు సభం గడు నొప్పగున్‌."
									};
		}
	}
	public class taralamu : Rule
	{
		public taralamu()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "taralamu";
			Name = "తరళము (ధ్రువకోకిల)";
			Examples = new string[] {   "పరమపూరుషుఁ డొక్కఁ డాఢ్యుఁడు పాలనోద్భవ నాశముల్\nసొరిదిఁ జేయు ముకుంద పద్మజ శూలి సంజ్ఞలఁ బ్రాకృత\nస్ఫురిత సత్త్వ రజస్తమంబులఁ బొందు నందు శుభస్థితుల్\nహరి చరాచరకోటి కిచ్చు ననంతసత్త్వ నిరూఢుఁడై.",
										"శుకుఁడు గోచియు లేక పైఁ జనఁ జూచి తోయములందు ల\nజ్జకుఁ జలింపక చీర లొల్లక చల్లులాడెడి దేవక\nన్యకలు, హా! శుక!, యంచు వెన్క జనంగ వ్యాసునిఁ జూచి యం\nశుకములన్ ధరియించి సిగ్గున స్రుక్కి రందఱు ధీనిధీ!",
										"నళినలోచన! నీవు నిక్కము నాకుఁ బుట్టెద వంచు నీ\nఖలుఁడు కంసుఁడు పెద్దకాలము కారయింట నడంచె; దు\nర్మలినచిత్తుని నాజ్ఞజేయుము; మమ్ముఁ గావుము భీతులన్;\nనులుసు లేక ఫలించె నోచిన నోము లెల్లను నీవయై.",
										"పసుపు లాడి యురోజకుంకుమ పంకశోభితలై లస\nద్వసనలై కచభారచంపకదామలై సులలామలై\nపసిఁడిమాడల కాంతు లఱ్ఱులఁ బర్వఁ దేరులమీఁద బెం\nపెసఁగ బాడిరి వ్రేత లా హరిహేల లింపగు నేలలన్.",
										"కడుపులోపల నున్న పాపఁడు కాలఁ దన్నినఁ గిన్కతో\nనడువఁ బోలునె క్రాఁగి తల్లికి? నాథ! సన్నము దొడ్డునై\nయడఁగి కారణ కార్యరూపమునైన యీ సకలంబు నీ\nకడుపులోనిదె గాదె? పాపఁడఁ గాక నే మఱి యెవ్వఁడన్?",
										"జలరుహాహిత సోదరీ ముఖ చంద్ర చంద్రిక లాదటన్‌\nగొలఁది మీఱఁగ లోచనంబులఁ గ్రోలి యొప్పు మహాసుఖిన్‌\nబలుకుచో నభరంబులుం బిదపన్‌ సజంబు జగంబులున్‌\nజెలువుగా దరళంబునోలి రచింతు రంధకజిద్యతిన్‌.",
									};



			Prasa = true;
			PrasaYati = false;

			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			RuleType = RuleType.Name;
			YatiMode = YatiMode.CharPosition;
			Frequency = Frequency.Frequent;


			Rules = new string[][] { "న భ ర స జ జ గ".Split(' ') };
			Yati = new int[][] { new int[] { 12 } };
		}
	}
	public class bhootilakamu : Rule
	{
		public bhootilakamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;
			Rules = new string[][] { "భ,భ,ర,స,జ,జ,గ".Split(',') };

			Yati = new int[][] { new int[] { 12 } };

			PadyamSubType = PadyamSubType.Vruttam;
			Identifier = "bhootilakamu";
			Name = "భూతిలకము";
			Examples = new string[] {
										"వాఁడె వధూమణి చూడవే ద్రిదివద్రుమంబు ధరిత్రికిన్‌\nబోఁడిమి దెచ్చిన శూరుఁ డీతనిఁ బోలలే రిల నెవ్వరున్‌\nవీఁ డధికుం డని భీమవిశ్రమవృత్తి భూతిలకం బగున్‌\nవేఁడి నుతింతురు భారసంబుల వెంట జాగము లొందఁగాన్‌.",
										"వెన్నెల లో విహరిమ్చ వెళ్ళగ వేడ్కగా విరితోటకున్\nకన్నుల ముమ్దర తోచె కాంతుల కల్కియై కనుపమ్డువై\nఅన్నుల మిన్నయె తాను అల్లన నాడుచున్ చిరుహాసమున్\nవెన్నెలె ఆడిన రీతి, పేర్మిని వీణతో నొక వేదికన్"
									};
		}
	}
	public class mEghavisphooritaM : Rule
	{
		public mEghavisphooritaM()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "mEghavisphooritaM";
			Name = "మేఘవిస్ఫూర్జితం";
			Examples = new string[] {   "స్థిరాంశుప్రస్విన్నామృతకరవియధ్ధేశచూడామనోజ్ఞా\nపురాళీప్రధ్వాసాధ్భుతరతభిజాబోగకేళీసమజ్ఞా\nమరుత్పాళీకేళీగిరికృతధనుర్మండలీలగ్నవిష్ణూ\nసరజ్జ్వాలాహాలాహలవిషమహాసహ్వరేఖాసహిష్ణూ",
										"రమానాథున్‌ నాథున్‌ యదుకులశిరోరమ్య రత్నాయమానున్‌\nసముద్యత్తేజిష్ణున్‌ దనుజయువతిస్ఫారహారాపహారున్‌\nమిముం బ్రీతిం బేర్కొం డ్రరుణవిరతిన్‌ మేఘవిస్ఫూర్జితాఖ్యన్‌\nగ్రమంబొప్పన్‌ బెద్దల్‌ యమనసములున్‌ రాగముల్గా ముకుందా!"
									};



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "య మ న స ర ర గ".Split(' ') };
			Yati = new int[][] { new int[] { 13 } };


			Prasa = true;
			PrasaYati = false;
		}
	}
	public class saardhoolaM : Rule
	{

		public saardhoolaM()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "saardhoolaM";
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			Name = "శార్దూలవిక్రీడితము";
			Examples = new string[]{
									"శ్రీ కైవల్య పదంబుఁ జేరుటకునై చింతించెదన్ లోక ర\nక్షైకారంభకు భక్త పాలనకళాసంరంభకున్ దానవో\nద్రేకస్తంభకుఁ గేళిలోలవిలసద్దృగ్జాలసంభూత నా\nనాకంజాతభవాండ కుంభకు మహానందాంగనాడింభకున్.",
									"పుట్టం బుట్ట, శరంబునన్ మొలవ నంభోయానపాత్రంబునన్\nనెట్టం గల్గను గాళిఁ గొల్వను బురాణింపన్ దొరంకొంటి మీఁ\nదెట్టే వెంటఁ జరింతుఁ దత్సరణి నా కీవమ్మ యో! యమ్మ మేల్\nపట్టున్ నాకగుమమ్మ నమ్మితిఁ జుమీ బ్రాహ్మీ! దయాంభోనిధీ!",
									"సూతా! యే యుగవేళ నేమిటికి నెచ్చోటన్ మునిశ్రేష్ఠు నే\nశ్రోతల్ గోరిరి? యేమి హేతువునకై, శోధించి లోకైక వి\nఖ్యాతిన్ వ్యాసుడుఁ మున్ను భాగవతముం గల్పించెఁ? దత్పుత్త్రుఁడే\nప్రీతిన్ రాజునకీ పురాణకథఁ జెప్పెం? జెప్పవే యంతయున్.",
									"తాటంకాచలనంబుతో,భుజనటద్దమ్మిల్ల బండంబుతో\nశాటీముక్త కుచంబుతో, సదృఢచంచత్కాంచితో, శీర్ణలా\nలాటాలేపముతో, మనోహరకరాలగ్నోత్తరీయంబుతో\nగోటీందుప్రభతో, సురోజభర సంకోచద్విలగ్నంబుతోన్",
									"ఊహ గలంగి జీవనపుటోలమునం బడి పోరుచున్ మహా\nమోహలతా నిహద్దపదమున్ విడిపించుకొనంగ లేక సం\nదేహముబోదు దేహి క్రియ దీనదశన్ గజ ముండె భీషణ\nగ్రాహదురంత దంత పరిఘట్టిత పాద ఖురాగ్ర శల్యమైన్" ,
									"లా వొక్కింతయు లేదు; ధైర్యము విలోలంబయ్యె; బ్రాణంబులున్\nఠావుల్ దప్పెను; మూర్ఛ వచ్ఛెఁ; దనువున్ డస్సెన్; శ్రమంబయ్యెడిన్;\nనీవే తప్ప నితఃపరం బెఱుఁగ; మన్నింపంద గున్ దీనునిన్;\nరావే! యీశ్వర! కావవే వరద! సంరక్షింపు భద్రాత్మకా!",
									"పద్మప్రోద్భవసన్నిభుల్‌ మసజసప్రవ్యక్త తాగంబులన్‌\nబద్మాప్తాంచితవిశ్రమంబుగ సముత్పాదింతు రుద్యన్మతిన్‌\nబద్మాక్షాయ నిజాంఘ్రిసంశ్రిత మహాపద్మాయ యోగీంద్ర హృ\nత్పద్మస్థాయ నమోస్తుతే యనుచు నీశార్దూలవిక్రీడితన్‌."
									};





			RuleType = RuleType.Name;
			Rules = new string[][] { "మ స జ స త త గ".Split(' ') };
			YatiMode = YatiMode.CharPosition;
			Yati = new int[][] { new int[] { 13 } };
			Prasa = true;
			PrasaYati = false;

		}
	}
}

/*
 public class bhootilakaM : Rule
	{
		public bhootilakaM ()
		{
			Lines = 4;
			Threshold = 3;

			Identifier = "bhootilakaM";
			Name = "భూతిలకం";
						Examples = new string[] { "వాఁడె వధూమణి చూడవే ద్రిదివద్రుమంబు ధరిత్రికిన్‌\nబోఁడిమి దెచ్చిన శూరుఁ డీతనిఁ బోలలే రిల నెవ్వరున్‌\nవీఁ డధికుం డని భీమవిశ్రమవృత్తి భూతిలకం బగున్‌\nవేఁడి నుతింతురు భారసంబుల వెంట జాగము లొందఁగాన్‌." };



			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;

			Rules = new string[][] { "భ భ ర స జ జ గ".Split ( ' ' ) };
			Yati = new int[][] { new int[] { 12 } };


			Prasa = true;
			PrasaYati = false;
		}
	}
 */
