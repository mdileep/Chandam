//---------------------------------------------------------------------------------------------
// <copyright file="R4.cs" company="Chandam-ఛందం">
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
	public class sukaaMti : Rule
	{
		public sukaaMti()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { "జ,గ".Split(',') };
			Yati = new int[][] { };


			Identifier = "sukaaMti";
			Name = "సుకాంతి (జయా , నగానితా , నగణికా , లాసినీ , విలాసినీ , కలా)";
			Examples = new string[] {   "జగంబులం\nదగున్ సుకాం\nతి గల్పిత\nప్రగల్భతన్",
										"అగున్‌ సుకాం\nతి గూర్పఁగా\nజగంబులన్‌\nజగత్పతీ." };
		}
	}
	public class vreeDa : Rule
	{
		public vreeDa()
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

			Rules = new string[][] { new string[] { "య", "గ" } };
			Yati = new int[][] { };

			Identifier = "vreeDa";
			Name = "వ్రీడ (వ్రీళ , క్రీడా)";
			Examples = new string[] { "సురారాతి\nస్ఫురత్సైన్యం\nబురోఽసృగ్ధా\nర రాదీయన్" };
		}
	}

	public class kanya : Rule
	{
		public kanya()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { new string[] { "మ", "గ" } };
			Yati = new int[][] { };


			Identifier = "kanya";
			Name = "కన్య";
			Examples = new string[] { "పొత్తై గాగా\nపత్తింగన్యా\nవృత్తంబయ్యెన్\nజిత్తంబరన్" };
		}
	}
	public class biMbamu : Rule
	{
		public biMbamu()
		{
			Lines = 4;
			Threshold = 3;

			RuleType = RuleType.Name;
			PadyamType = PadyamType.Vruttam;
			PadyamSubType = PadyamSubType.Vruttam;
			YatiMode = YatiMode.CharPosition;


			Prasa = true;
			PrasaYati = false;

			Rules = new string[][] { new string[] { "భ", "గ" } };
			Yati = new int[][] { };


			Identifier = "biMbamu";
			Name = "బింబము (వలా)";
			Examples = new string[] { "శ్రీకలితా\nస్తోక భగల్‌\nపైకొను బిం\nబాకృతికిన్‌.", "పంచిభకా\nరంబుగకా\nరంబునుగా\nబింబమగున్" };
		}
	}
}
