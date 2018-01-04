using System;
using Library.Tests;

public partial class Sanity : System.Web.UI.Page
{
	

	protected void Page_Load (object sender , EventArgs e)
	{
		if ( Page.IsPostBack )
			return;

		
	
		string s= new SanityTest().Test3();
		s = s.Replace ( "\n" , "<br/>" );

		result.InnerHtml = s;		


		
	}

	
	
}







		//foreach ( Rule R in Helper.GetAllRules ( true ) )
		//{
		//    if ( R.GetType ( ).Name.ToLower() != R.Identifier.ToLower() )
		//    {
		//        s = s +R.GetType ( ).Name+"-"+ R.Identifier + "-" + R.Name + "<br/>";
		//    }

		
		//}
		//s = s + "-----------------------<br/>";

		//foreach ( Rule R in Helper.GetAllRules ( true ) )
		//{
		//    if ( Helper.GetRulesItem ( R.Identifier ) == null )
		//    {
		//        s = s + R.GetType ( ).Name + "-" + R.Identifier + "-" + R.Name + "<br/>";
		//    }
			
		//}
		//s = s + "-----------------------<br/>";
		//foreach ( Rule R in Helper.GetAllRules ( true ) )
		//{
		//    Rule R2=Helper.GetRulesItem ( R.Identifier );
		
		//    if (R2!=null && R2.GetType ( ) != R.GetType ( ) )
		//    {
		//        s = s + R.GetType ( ).Name + "-" + R.Identifier + "-" + R.Name + "<br/>";
		//    }
		//}

		//List<string> typelist = GetTypesInNamespace ( );
		//s = s + "Tot: "+typelist.Count+"<br/>";
		
		//if ( L.Count != typelist.Count )
		//{
		//    s = s + "Some items Missing....<br/>";
		//}

		//foreach ( string  _s in typelist )
		//{
		//    bool found=false;
		//    foreach ( Rule R in L )
		//    {
		//        if ( _s == R.Identifier )
		//        {
		//            found = true;
		//            break;	
		//        }
				
		//    }
		//    if ( !found )
		//    {
		//        s =s+ "Missed one: <b>" + _s + "</b> <br/>";
		//    }
		//}

		
		//    foreach ( Rule R in L )
		//{
		//    bool found=false;
		//    foreach ( string  _s in typelist )
		//    {
		//        if ( _s == R.Identifier )
		//        {
		//            found = true;
		//            break;
		//        }

		//    }
		//    if ( !found )
		//    {
		//        s = s + "Missed one: <b>" + R.Identifier + "</b> <br/>";
		//    }
		//}

		//foreach ( string   o in typelist )
		//{
		//    Rule R=Helper.GetRulesItem ( o);
		//    if ( R == null )
		//    {
		//        s = s + "<b>"+o + "</b> Not ok...<br/>";
		//    }
			
		//}



