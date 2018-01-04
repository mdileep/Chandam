//---------------------------------------------------------------------------------------------
// <copyright file="R26.cs" company="Chandam-ఛందం">
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
	public class maMgaLamahaaSree : Rule
	{
		public maMgaLamahaaSree()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			YatiMode = YatiMode.CharPosition;
			PadyamSubType = PadyamSubType.Vruttam;

			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "భ,జ,స,న,భ,జ,స,న,గా".Split(',') };
			Yati = new int[][] { new int[] { 9, 17 } };


			Identifier = "maMgaLamahaaSree";
			Name = "మంగళమహాశ్రీ";
			Examples = new string[] {
										"చిత్తములఁ జూపులను జిత్తజుని తండ్రిపయిఁ జెంది గజదంతియతు లొందన్‌\nనృత్తములతోడఁ దరుణీమణులు గానరుచు లింపుగను మంగళమహాశ్రీ\nవృత్తములఁ బాడిరి సవృత్తకుచకుంభముల వింతజిగి యెంతయుఁ దలిర్పన్‌\nమత్తిలుచు నబ్భజసనంబు లిరుచోటులఁ దనర్పఁగఁ దుదన్‌ గగ మెలర్పన్‌.",
										"ఈ విధమునన్ విబుధు లేకతమ చిత్తముల; నేకతము లేక హరినీశున్\nభావమున నిల్పి తగు భాగవతయోగ పరి; పాకమున నొందుదరు వారిం\nదేవలదు దండనగతిం జనదు మాకు గుఱు; తింప నఘముల్దలఁగు మీఁదన్\nశ్రీవరుని చక్రము విశేషగతిఁ గాచు సుర; సేవితులు ముక్తిఁ గడుఁ బెద్దల్.",
										"చిత్తకభిదంఘ్రియుగ చింతన కళాధిగత జిష్ణు సమవైభవ విశేషా\nవిత్తరమణామరగవీ తరణిభూజలద విశ్రుత కరాంబురుహ గోష్ఠీ \nనృత్తమణిరంగతల నీతిమనురాజనిభనిర్భరదయారసపయేధీ\nమత్తగజయూధ మదమగ్నసిఖితాళిరవమాన్యగృహమంగళమహాశ్రీ "
									};
		}
	}
}
