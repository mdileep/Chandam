using System;
using Chandam.Rules.Rare;
using Chandam.Core;
using Chandam.Rules;
using Library.Chandam.Labs;


public partial class Machine : System.Web.UI.Page
{
	protected void Page_Load (object sender , EventArgs e)
	{
		string s=new MachinePoem ( ).Build ( "nadeepraghOshamu" );
		Rule R= new nadeepraghOshamu( );
		
		Padyam P=new Padyam ( );
		P.MatchYati = true;
		P.MatchPrasa = true;
		MatchResult MR=  P.Match (s,R );

		result.InnerHtml = MR.ShowErrors ( OutputFormat.HTML );
		;

	}
	
}