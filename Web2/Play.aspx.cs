using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Chandam.Rules;
using Library.Reports;

public partial class Play : System.Web.UI.Page
{
	protected void Page_Load (object sender , EventArgs e)
	{
		//Play1 ( );
		//Play2 ( );
		//Play3 ( );
		RuleHelper.GetRules5 (PadyamType.Vruttam, Frequency.Frequent);
	}

	private void Play3 ()
	{
		string s=   new ChandamReports ( ).PendingWork ( );
		result.InnerHtml = s;
	}
	private void Play2 ()
	{
		result.InnerHtml = Helper.BuildGana ( 10 , 345 );
		// మ , స , జ , గ
		// UUU ||U  |U| U
		// 000  110  101 0
		// #344
		// 101 011 000 -Binary 
		// 000 110 101 -Reorder
		// 000 110 101 0- With Filler
		// UUU 11U |U| U
		
		
	}

	private void Play1 ()
	{
		int[] arr=new int[] {1,0,0,
1,1,1,
0,0,1,
1,0,0,
0,0,0,
0,0,0,
0,0,0,
0,0,0,
1};
		double  tot=0;
		double  tot_invert=0;
		for ( int i=0 ; i < arr.Length ; i++ )
		{
			double mul=Math.Pow ( 2.0 , ( double ) i );
			int invert=1 - arr[i];

			tot_invert = tot_invert + ( invert * mul );
			tot = tot + ( arr[i] * mul );
		}
		double max=Math.Pow ( 2.0 , arr.Length );
		string s="<ol>";
		s = s + "<li> Total: " + tot + "</li>";
		s = s + "<li> Total With Invert: " + tot_invert + "</li>";
		s = s + "<li> Total With Invert+1: " + ( tot_invert + 1 ) + "</li>";
		s = s + "<li> Max possible: " + max + "</li>";
		s = s + "<li> Max -Invert: " + ( max - tot_invert ) + "</li>";
		s = s + "</ol>";
		result.InnerHtml = s;
	}
}
