using System;
using System.Collections.Generic;
using System.Text;
using Library.Chandam;

namespace Library.App
{
	public partial class CheatSheet
	{
		public static string BuildSansBook ()
		{
			string s2="<h1>అనుక్రమణిక</h1><ol>";
			string s="";
			
			s = s + "<h1>వృత్తములు</h1>";
			s2 = s2 + "<li>వృత్తములు</li><ol>";
			for ( int i=1 ; i <= 27 ; i++ )
			{
				string cName=Helper.ChandamName ( i ) + ( i <= 26 ? " (" + i + ")" : " (>26)" );
				Rule[] VRules= Helper.GetSanRules2 ( i );

				s = s + "<h1>" + cName + "</h1>";
				s = s + "<ol>";

				s2 = s2 + "<li>" + cName + "</li>";
				s2 = s2 + "<ol>";
				foreach ( Rule R in SortHelper.SortByName ( VRules ) )
				{
					s = s + "<li  id='" + R.Identifier + "'>";
					s = s + BuildHTMLRules ( R , true );
					s = s + "&nbsp; <a class='link' href='#TOP_" + R.Identifier + "'>[TOP]</a>";
					s = s + "</li>";
					s2 = s2 + "<li id='TOP_" + R.Identifier + "'><a class='identifier' href='#" + R.Identifier + "'>" + R.Name + "</a></li>";
				}
				s = s + "</ol>";
				s2 = s2 + "</ol>";
			}
			s2 = s2 + "</ol>";


			string[] F=new string[] { };
			
			F = SortByName4 ( "అసమ వృత్తములు" , PadyamSubType.VishamaVruttam );
			s = s + F[0];
			s2 = s2 + F[1];


			F = SortByName4 ( "అర్ధసమ వృత్తములు" , PadyamSubType.ArdhaVruttam );
			s = s + F[0];
			s2 = s2 + F[1];
			return s2 + s;
		}

		private static string[] SortByName4 (string head , PadyamSubType padyamSubType)
		{
			return SortByName3 ( head , padyamSubType , Helper.GetSansRules2 ( padyamSubType ) );
		}
	}
}
