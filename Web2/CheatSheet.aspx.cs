using System;
using Chandam.Rules;

public partial class CheatSheetPage : System.Web.UI.Page
{
	protected void Page_Load (object sender , EventArgs e)
	{
		//cheatSheet.InnerHtml = CheatSheet.BuildCheatSheet ( false );
		string s=CheatSheet.BuildCheatSheet ( true,false );
		System.IO.File.WriteAllText (Server.MapPath("CheatSheet/CheatSheet.html"),s );

		s = "<html><head><style>br {mso-data-placement:same-cell;}</style></head><body>" + s + "</body></html>";
		s = s.Replace ( "<li>" , "" );
		s = s.Replace ( "</li>" , "<br/>" );
		s = s.Replace ( "<b>పద్య లక్షణములు:</b>" , "" );
		s = s.Replace ( "<ol>" , "" );
		s = s.Replace ( "</ol>" , "" );
		s = s.Replace ( "<span class=\"gName\">" , "" );
		s = s.Replace ( "</span>" , "" );
		s = s.Replace ( "<div>" , "" );
		s = s.Replace ( "</div>" , "" );
		System.IO.File.WriteAllText ( Server.MapPath ( "CheatSheet/CheatSheet.xls" ) , s );
	}
}
