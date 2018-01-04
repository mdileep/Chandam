using System;
using Chandam.Core;
using Chandam.Rules;
using Chandam.Rules.Jati;
using Chandam.Rules.Rare;



public partial class _Default : System.Web.UI.Page
{
	private void MostProbable()
	{
		string p = @"పలికెడిది భాగవత మఁట, 
పలికించెడివాడు రామభద్రుం డఁట, నేఁ
బలికిన భవహర మగునఁట, 
పలికెద, వేఱొండు గాథ బలుకఁగ నేలా?";
		Probable Pr = Padyam.MostProbable(p, MatchOptions.QucikMatchSettings);
		MatchResult MR = Pr.MatchResult;
		Padyam P = Pr.Padyam;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (Page.IsPostBack)
			return;

		MostProbable();

		//string p = @"ಉತ್ತರದಿಶಕುಬೋಯಿತಿ ಹಿಮವ ದುರ್ವಿಧರಮುನವಾಲಿಯೈ
		//ಕತ್ತಳಮನುಚುಬೋಯಿಪರುಗುನ ಗ್ರೌಂಚಗಿರಿಪಯಿವಾಲಿಯೈ
		//ಜೊತ್ತಿಲನಡುಗುದೋಯಿತುದಿಕೊಸಸೋಮಗಿರಿಪಯಿವಾಲಿಯೈ
		//ತತ್ತರಪಡುಚುವೇರುದೆಸಮದಿತಟ್ಟಕಮುಡುಗುಚುಂಡಗಾ.";









		//Rule R = new maththEbhaM();
		////string p = R.Examples[3];
		//Padyam P = new Padyam();
		//P.MatchYati = true;
		//P.MatchPrasa = true;
		//MatchResult MR = P.Match(p, R);





		string s = "";

		result.InnerHtml = s;

	}



	public class Custom : Rule
	{
		public Custom()
		{

			Lines = 4;
			Threshold = 4;


			Name = "Custom";
			Identifier = "dvipada";


			PadyamType = PadyamType.Jati;
			RuleType = RuleType.Type;
			YatiMode = YatiMode.GPosition;
			PadyamSubType = PadyamSubType.Divpada;

			Rules = new object[][] { new object[] { Category.Surya, Category.Indra, Category.Indra, Category.Surya } };
			Yati = new int[][] { new int[] { 3 } };


			Prasa = true;
			PrasaYati = false;



		}
	}

}









