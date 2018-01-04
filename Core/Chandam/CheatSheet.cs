using System;
using System.Collections.Generic;
using Library.Chandam;


namespace Chandam.Core.App
{
	public partial class CheatSheet
	{
		
		public static string BuildBook ()
		{

			#region
			//foreach ( Rule R in SortHelper.OrderedRules ( ) )
			//{
			//    s=s+"<li>";
			//    s =s+ BuildHTMLRules ( R ,true);
			//    s = s + "</li>";
			//}
			#endregion

			//Why not going with a Loop...???
			//Should be Something Like this.
			//SortHelper.SortByName2 ( delegate (Rule R)
			//{
			//    return R.PadyamSubType == PadyamSubType.Jati;
			//} );

			string s2="<h1>అనుక్రమణిక</h1><ol>";
			string s="";

			string[] F=new string[] { };
			F = SortByName2 ( "జాతులు" , PadyamSubType.Jati );
			s = s + F[0];
			s2 = s2 + F[1];

			F = SortByName2 ( "అక్కరలు" , PadyamSubType.Akkara );
			s = s + F[0];
			s2 = s2 + F[1];

			F = SortByName2 ( "రగడలు" , PadyamSubType.Ragada );
			s = s + F[0];
			s2 = s2 + F[1];


			F = SortByName2 ( "ముత్యాలసరములు" , PadyamSubType.Ragada2 );
			s = s + F[0];
			s2 = s2 + F[1];

			F = SortByName2 ( "షట్పదలు" , PadyamSubType.Shatpada );
			s = s + F[0];
			s2 = s2 + F[1];



			F = SortByName2 ( "ఉప-జాతులు" , PadyamSubType.UpaJati );
			s = s + F[0];
			s2 = s2 + F[1];

			F = SortByName2 ( "ద్విపదలు" , PadyamSubType.Divpada );
			s = s + F[0];
			s2 = s2 + F[1];

			F = SortByName2 ( "సీసములు" , PadyamSubType.Divpada );
			s = s + F[0];
			s2 = s2 + F[1];



			s = s + "<h1>వృత్తములు</h1>";
			s2 = s2 + "<li>వృత్తములు</li><ol>";
			for ( int i=1 ; i <= 27 ; i++ )
			{
				string cName=Helper.ChandamName ( i ) + ( i <= 26 ? " (" + i + ")" : " (>26)" );
				Rule[] VRules= i <= 26 ? Helper.GetRules3 ( i ) : Helper.GetRules4 ( i );

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


			F = SortByName2 ( "దండకములు" , PadyamSubType.DaMDakamu );
			s = s + F[0];
			s2 = s2 + F[1];

			F = SortByName2 ( "అసమ వృత్తములు" , PadyamSubType.VishamaVruttam );
			s = s + F[0];
			s2 = s2 + F[1];

			s2 = s2 + "</ol>";
			return s2 + s;
		}

		private static string[] SortByName2 (string head , PadyamSubType padyamSubType)
		{

			return SortByName3 ( head , padyamSubType , Helper.GetRules2 ( padyamSubType ) );
	

			
		}

		private static string[] SortByName3 (string head , PadyamSubType padyamSubType , Rule[] rules)
		{
			string s="";
			string s2="";



			//if ( head != "" )
			{
				s = s + "<h1>" + head + "</h1>";
				s = s + "<ol>";

				s2 = s2 + "<li>" + head + "</li>";
				s2 = s2 + "<ol>";
			}

			foreach ( Rule R in SortHelper.SortByName ( rules ) )
			{

				s = s + "<li  id='" + R.Identifier + "'>";
				s = s + BuildHTMLRules ( R , true );
				s = s + "&nbsp; <a class='link' href='#TOP_" + R.Identifier + "'>[TOP]</a>";
				s = s + "</li>";
				s2 = s2 + "<li id='TOP_" + R.Identifier + "'><a class='identifier' href='#" + R.Identifier + "'>" + R.Name + "</a></li>";
			}


			//if ( head != "" )
			{
				s = s + "</ol>";
				s2 = s2 + "</ol>";
			}
			return new string[] { s , s2 };
		}

		public static string BuildRules (Rule R)
		{
			return BuildHTMLRules ( R , false );
		}

		public static string BuildRules2 (Rule R , bool useExample)
		{
			return BuildHTMLRules ( R , useExample );
		}

		public static string BuildRulesWithExamples (Rule R)
		{
			return BuildHTMLRules ( R , true );
		}

		public static string BuildCheatSheet (bool extended , bool fixedWidth)
		{
			return BuildCheatSheet2 ( extended , fixedWidth , SortHelper.OrderedRules ( ) );
		}

		public static string BuildCheatSheet2 (bool extended , bool fixedWidth , Rule[] Rules)
		{
			
			string s="<table id='CheatSheet' class='sort-table errTab2' cellspacing='0'  border='1'>";
			{
				if ( !extended )
				{
					s = s + "<colgroup><col /><col /><col /><col /><col /><col /><col /><col /><col /><col  /><col /></colgroup>";
				}

				string row="<thead><tr>";
				row = row + "<th" + ( fixedWidth ? " width=\"3%\" style=\"text-align:center\"" : "" ) + ">క్రమ సంఖ్య</th>";
				row = row + "<th" + ( fixedWidth ? " style=\"text-align:center\"" : "" ) + ">పేరు</th>";
				row = row + "<th" + ( fixedWidth ? " width=\"5%\" style=\"text-align:center\"" : "" ) + "><nobr>పాదాక్షరాల సంఖ్య</nobr></th>";
				row = row + "<th" + ( fixedWidth ? " width=\"3%\" style=\"text-align:center\"" : "" ) + "><nobr>మాత్రలు</nobr></th>";
				row = row + "<th" + ( fixedWidth ? " width=\"5%\" style=\"text-align:center\"" : "" ) + "><nobr>మాత్రా శ్రేణులు</nobr></th>";
				row = row + "<th" + ( fixedWidth ? " width=\"5%\" style=\"text-align:center\"" : "" ) + ">ఛందం</th>";
				row = row + "<th" + ( fixedWidth ? " width=\"3%\" style=\"text-align:center\"" : "" ) + ">ఎన్నోవ వృత్తం</th>";
				row = row + "<th" + ( fixedWidth ? " width=\"6%\" style=\"text-align:center\"" : "" ) + ">స్వభావం</th>";
				row = row + "<th" + ( fixedWidth ? " width=\"4%\" style=\"text-align:center\"" : "" ) + ">పాదాలు</th>";
				row = row + "<th" + ( fixedWidth ? " width=\"3%\" style=\"text-align:center\"" : "" ) + ">ప్రాస నియమం</th>";
				row = row + ( extended ? "<th><nobr>అంత్యప్రాస నియమం</nobr></th>" : "" );
				row = row + "<th" + ( fixedWidth ? " width=\"3%\" style=\"text-align:center\"" : "" ) + "><nobr>ప్రాస యతి</nobr></th>";
				row = row + "<th"+  ( fixedWidth ? " width=\"7%\" style=\"text-align:center\"" : "" )+">యతి మైత్రి</th>";
				row = row + "<th style=\"text-align:center\">లక్షణాలు(గణ )</th>";
				row = row + "<th style=\"text-align:center\">ఉదాహరణ</th>";

				if ( extended )
				{
					row = row + "<th>#</th>";
					row = row + "<th>లక్షణాలు</th>";
				}
				row = row + "</tr></thead>";
				s = s + row;
			}

			s = s + "<tbody>";
			int cnt=1;
			foreach ( Rule R in Rules )
			{
				//Debug2.AppendLine ( R.Name + "," + R.PadyamType + "," + R.PadyamSubType + "," + R.CharLength );
				string  ml	=( R.PadyamType == PadyamType.Vruttam && !R.InfiniteLength && !R.RowWiseRules ) ? R.MatraLength.ToString ( ) : "";
				string  mlSeries=  R.MatraSeries; //( R.PadyamType == PadyamType.Vruttam && !R.InfiniteLength && !R.RowWiseRules ) ? Helper.PossibleMatraSeries ( R.Sequence ) : "";
				string  l	=( R.PadyamType == PadyamType.Vruttam && !R.InfiniteLength && !R.RowWiseRules ) ? R.CharLength.ToString ( ) : "";
				string cName=( R.PadyamType == PadyamType.Vruttam && !R.InfiniteLength && !R.RowWiseRules ) ? R.ChandamName : "";
				string cNumber=( R.PadyamType == PadyamType.Vruttam && !R.InfiniteLength && !R.RowWiseRules && R.ChandamNumber != -1 ) ? R.ChandamNumber.ToString ( ) : "";
				string PadyamName=Helper.GetPadyamTypeString ( R.PadyamType , R.PadyamSubType );
				string ruleName=R.Name.Replace ( "(" , "<br/>&nbsp;" ).Replace ( "," , "<br/>&nbsp;" ).Replace ( ")" , "" );

				if ( R.CharLength == -1 && !R.InfiniteLength )
				{
					l = ( R.Min == R.Max ) ? R.Max.ToString ( ) : "<nobr>" + R.Min + " నుండి " + R.Max + "</nobr>";
				}

				if ( PadyamName != "" )
				{
					PadyamName = "<nobr>" + PadyamName + "</nobr>";
				}
				
				string row="<tr>";
				row = row + "<td>" + ( cnt++ ) + "</td>";
				row = row + "<td>" + ruleName + "</td>";
				row = row + "<td>" + l + "</td>";
				row = row + "<td>" + ml + "</td>";
				row = row + "<td>" + mlSeries + "</td>";

				row = row + "<td>" + cName + "</td>";
				row = row + "<td>" + cNumber + "</td>";

				row = row + "<td>" + PadyamName + "</td>";
				row = row + "<td>" + R.Lines + "</td>";
				row = row + "<td>" + ( R.Prasa ? "కలదు" : "లేదు" ) + ( ( R.AnthyaPrasa && !extended ? "<br/><nobr>అంత్యప్రాస కలదు</nobr>" : "" ) ) + "</td>";

				if ( extended )
				{
					row = row + "<td>" + ( R.AnthyaPrasa ? "కలదు" : "లేదు" ) + "</td>";
				}

				row = row + "<td>" + ( R.PrasaYati ? "కలదు" : "" ) + "</td>";
				row = row + "<td>" + GetYatiRules ( R.Rules , R.Yati , R.YatiMode , R.ReverseYati ) + "</td>";
				row = row + "<td>" + GetRules ( R.Rules , R.RuleType , R.InfiniteLength , R.RowWiseRules ) + "</td>";
				//row = row + "<td>" + ( R.Examples.Length > 0 ?   R.Examples[0].Replace ( "\n" , "<br/>" ) : "" ) + "</td>";
				row = row + "<td>" + ( R.Examples.Length > 0 ? TryMatch( R.Examples[0],R) : "" ) + "</td>";

				if ( extended )
				{
					row = row + "<td>" + ( R.Examples == null ? "" : R.Examples.Length.ToString ( ) ) + "</td>";
					row = row + "<td>" + ( R.RuleText == null ? "" : R.RuleText ) + "</td>";
				}
				row = row + "</tr>\n";
				s = s + row;
			}
			s = s + "</tbody>";
			s = s + "</table>";
			return s;
		}

		private static string GetYatiRules (object[][] Rules , int[][] Yati , YatiMode Mode , bool ReverseYati)
		{
			string s="";
			if ( Yati.Length == Rules.Length && Yati.Length > 1 )
			{
				for ( int i=0 ; i < Yati.Length ; i++ )
				{

					int[] LineRule =Yati[i];

					if ( Yati.Length > 1 )
					{
						if ( i == 0 )
						{
							s = s + "<ol class='rules'>";
						}
						s = s + "<li><nobr>";
					}
					if ( LineRule.Length > 0 )
					{
						s = s + GetPadamYatiText2 ( LineRule );
					}
					else
					{
						s = s + "--";
					}

					if ( LineRule.Length > 0 )
					{
						s = s + _YEnd ( Mode , ReverseYati , LineRule.Length );
					}

					if ( Yati.Length > 1 )
					{
						s = s + "</nobr></li>";

						if ( i == Yati.Length - 1 )
						{
							s = s + "</ol>";
						}
					}
				}
			}
			else
			{
				if ( Yati.Length > 0 && Yati[0].Length > 0 )
				{
					int[] LineRule =Yati[0];
					s = s + GetPadamYatiText2 ( LineRule );

					s = s + _YEnd ( Mode , ReverseYati , LineRule.Length );
				}
			}

			return s;
		}
		private static string _YEnd (YatiMode Mode , bool ReverseYati , int Length)
		{
			string s="";
			if ( Mode == YatiMode.GPosition )
			{
				if ( ReverseYati )
				{
					s = s + ( Length > 1 ? " గణముల చివరి అక్షరములు" : " వ గణము యొక్క చివరి అక్షరము" );
				}
				else
				{
					s = s + ( Length > 1 ? " గణముల మొదటి అక్షరములు" : " వ గణము యొక్క మొదటి అక్షరము" );
				}
			}

			if ( Mode == YatiMode.CharPosition )
			{
				s = s + ( Length > 1 ? " వ అక్షరములు" : " వ అక్షరము" );
			}
			return s;
		}

		private static string GetPadamYatiText2 (int[] LineRule)
		{
			string s="";
			for ( int r=0 ; r < LineRule.Length ; r++ )
			{
				s = s + LineRule[r].ToString ( );

				if ( r != LineRule.Length - 1 )
				{
					s = s + ",";
				}
			}
			return s;
		}
		private static string GetRules (object[][] Rules , RuleType RuleType , bool infiniteLength , bool RowWiseRules)
		{
			string s="";
			if ( RowWiseRules && Rules.Length != 1 )
			{
				s = s + "<ol  class='rules'>";
				for ( int i=0 ; i < Rules.Length ; i++ )
				{
					object[] LineRule =Rules[i];
					s = s + "<li><nobr>" + GetPadamRuleText ( RuleType , infiniteLength , LineRule ) + "</nobr></li>";
				}
				s = s + "</ol>";
			}
			else
			{
				object[] LineRule =Rules[0];
				s = s + "<nobr style='margin:5px;'>" + GetPadamRuleText ( RuleType , infiniteLength , LineRule ) + "</nobr>";
			}
			return s;
		}
		private static string GetPadamYatiText (int[] LineRule , YatiMode _YatiMode , bool ReverseYati)
		{
			if ( LineRule.Length == 0 )
			{
				return "";
			}

			string s="<span class='gName'>";

			for ( int i=0 ; i < LineRule.Length ; i++ )
			{
				int o= LineRule[i];
				s = s + o.ToString ( );

				if ( i != LineRule.Length - 1 )
				{
					s = s + ",";
				}
			}


			if ( _YatiMode == YatiMode.GPosition )
			{
				if ( ReverseYati )
				{
					s = s + ( LineRule.Length > 1 ? "</span> గణముల చివరి అక్షరములు" : "</span> వ గణము యొక్క చివరి అక్షరము" );
				}
				else
				{
					s = s + ( LineRule.Length > 1 ? "</span> గణముల మొదటి అక్షరములు" : "</span> వ గణము యొక్క మొదటి అక్షరము" );
				}
			}

			if ( _YatiMode == YatiMode.CharPosition )
			{
				s = s + ( LineRule.Length > 1 ? "</span> వ అక్షరములు" : "</span> వ అక్షరము" );
			}

			return s;
		}
		private static string GetPadamRuleText (RuleType ruleType , bool infiniteLength , object[] LineRule)
		{
			string s="";
			string prev="";
			int repeat =0;
			for ( int i=0 ; i < LineRule.Length ; i++ )
			{
				object o= LineRule[i];
				string curr=RuleText ( ruleType , o );

				if ( ruleType == RuleType.Name )
				{
					s = s + curr;

					if ( i != LineRule.Length - 1 )
					{
						s = s + " , ";
					}
					if ( infiniteLength && LineRule.Length - 2 >= 0 && i == LineRule.Length - 2 )
					{
						s = s.Remove ( s.Length - 2 , 2 );
						s = s + " ..... ";
					}
				}
				else
				{
					if ( prev != "" && prev != curr )
					{
						s = s + GetNumberText ( repeat ) + " " + prev;

						if ( i != LineRule.Length - 1 )
						{
							s = s + " , ";
						}

						repeat = 1;
						prev = curr;
						continue;
					}

					repeat++;
					prev = curr;
				}
			}

			if ( repeat > 0 )
			{
				if ( !s.EndsWith ( " , " ) && s.Length + 1 != 1 )//Script Sharp Fix
				{
					s = s + " , ";
				}

				s = s + GetNumberText ( repeat ) + " " + prev;
			}

			return s;
		}
		private static string GetNumberText (int num)
		{
			switch ( num )
			{
				case 1:
					return "ఒక";
				case 2:
					return "రెండు";

				case 3:
					return "మూడు";
				case 4:
					return "నాలుగు";

				case 5:
					return "ఐదు";

				case 6:
					return "ఆరు";

				case 7:
					return "ఏడు";

				case 8:
					return "ఎనిమిది";

				default:
					return num.ToString ( );
			}
		}
		private static string GetPadamName (int p)
		{
			switch ( p )
			{
				case 1:
					return "ఒకటవ";
				case 2:
					return "రెండవ";

				case 3:
					return "మూడవ";
				case 4:
					return "నాలుగవ";

				case 5:
					return "ఇదవ";

				case 6:
					return "ఆరవ";

				case 7:
					return "ఏడవ";

				case 8:
					return "ఎనిమిదవ";

				default:
					return "{తెలియదు}";
			}
		}
		private static string RuleText (RuleType ruleType , object o)
		{
			switch ( ruleType )
			{
				case RuleType.Name:
					{
						return GDefinition.GAlias ( ( string ) o );
					}
				case RuleType.Type:
					{
						Category Cat=( Category ) o;
						return Helper.CategoryString ( Cat );
					}
				case RuleType.SubType:
					{
						SubCategory Cat=( SubCategory ) o;
						return Helper.SubCategoryString ( Cat );
					}
				case RuleType.Weight:
					{
						int  Cat=( int ) o;
						return Cat.ToString ( ) + " మాత్రలు";
					}
				default:
					{
						return "తెలియదు";
					}
			}
		}


		public static string BuildHTMLRules (Rule R , bool includeExamples)
		{
			string s="<h2>" + R.ShortName + " పద్య లక్షణములు </h2>";
			s = s + "<ol>";

			if ( R.Alias != "" )
			{

				s = s + "<li>ఈ పద్య ఛందస్సుకే <span class='gName'>" + R.Alias + "</span> అనే ఇతర నామము" + ( R.Alias.IndexOf ( ',' ) > 0 ? "లు" : "" ) + " కూడా కల" + ( R.Alias.IndexOf ( ',' ) > 0 ? "వు" : "దు" ) + ".</li>";
			}
			s = s + "<li><span class='gName'>" + Helper.GetPadyamTypeString ( R.PadyamType , R.PadyamSubType ) + "</span> రకానికి చెందినది </li>";
			if ( R.PadyamType == PadyamType.Vruttam && !R.RowWiseRules && R.ChandamNumber != -1 )
			{
				s = s + "<li><span class='gName'>" + R.ChandamName + "</span> ఛందమునకు  చెందిన <span class='gName'>" + R.ChandamNumber + "</span> వ వృత్తము.</li>";
				s = s + "<li><span class='gName'>" + R.CharLength + "</span> అక్షరములు ఉండును.</li>";
			}


			if ( R.CharLength == -1 && !R.InfiniteLength )
			{
				s = s + "<li><span class='gName'>" + R.Min + "</span> నుండి <span class='gName'>" + R.Max + "</span> అక్షరములు ఉండును.</li>";
			}

			if ( R.PadyamType == PadyamType.Vruttam && !R.RowWiseRules && R.MatraLength != -1 )
			{
				s = s + "<li><span class='gName'>" + R.MatraLength + "</span> మాత్రలు ఉండును.</li>";
				s = s + "<li>";
				s = s + "<span class='gName'>మాత్రా శ్రేణి</span>: " + ColorFul ( R.Sequence );
				s = s + AvailableSerieses ( R.Sequence );
				s = s + "</li>";
			}

			#region Lines
			s = s + "<li><span class='gName'>" + R.Lines + "</span>" + ( ( R.Lines != 1 ) ? " పాదములు" : " పాదము" ) + " ఉండును." + "</li>";
			#endregion

			#region Prasa
			if ( R.Prasa )
			{
				s = s + "<li>ప్రాస నియమం <span class='gName'>కలదు</span>" + "</li>";
			}
			else
			{
				s = s + "<li>ప్రాస నియమం <span class='gName'>లేదు</span>" + "</li>";
			}

			if ( R.AnthyaPrasa )
			{
				s = s + "<li>అంత్య ప్రాస నియమం <span class='gName'>కలదు</span>" + "</li>";
			}

			if ( R.PrasaYati )
			{
				s = s + "<li>ప్రాస యతి నియమం <span class='gName'>కలదు</span>" + "</li>";
			}


			#endregion

			#region Yati
			if ( R.Yati.Length == R.Rules.Length && R.Yati.Length > 1 )
			{
				for ( int i=0 ; i < R.Yati.Length ; i++ )
				{
					int[] LineRule =R.Yati[i];
					string PadamName=GetPadamName ( i + 1 );
					if ( LineRule.Length > 0 )
					{
						s = s + "<li>" + PadamName + " పాదమునందు ";
						s = s + GetPadamYatiText ( LineRule , R.YatiMode , R.ReverseYati );
						s = s + ( ( LineRule.Length == 1 ) ? " యతి స్థానము</li>" : " యతి స్థానములు</li>" );
					}
				}
			}
			else
			{
				if ( R.Yati.Length > 0 && R.Yati[0].Length > 0 )
				{
					s = s + "<li>ప్రతి పాదమునందు ";
					s = s + GetPadamYatiText ( R.Yati[0] , R.YatiMode , R.ReverseYati );
					s = s + ( ( R.Yati[0].Length == 1 ) ? " యతి స్థానము</li>" : " యతి స్థానములు</li>" );
				}
			}
			#endregion



			if ( R.RowWiseRules )
			{
				s = s + "<li><span class='gName'>గణ లక్షణాలు :</span><ol>";
				for ( int i=0 ; i < R.Rules.Length ; i++ )
				{
					object[] LineRule =R.Rules[i];
					string PadamName=GetPadamName ( i + 1 );
					s = s + "<li>" + PadamName + " పాదమునందు <span class='gName'>";

					s = s + GetPadamRuleText ( R.RuleType , R.InfiniteLength , LineRule );

					s = s + "</span> గణములుండును.</li>";
				}
				s = s + "</ol></li>";
			}
			else
			{
				s = s + "<li>ప్రతి పాదమునందు <span class='gName'>";
				s = s + GetPadamRuleText ( R.RuleType , R.InfiniteLength , R.Rules[0] );
				s = s + "</span> గణములుండును.</li>";
			}
			if ( includeExamples )
			{

				s = s + "<li><span class='gName'>ఉదాహరణలు:</span>";
				if ( R.Examples.Length == 0 )
				{
					s = s + " అందుబాటులో లేవు. ";
				}

				s = s + "<ol>";
				foreach ( string ex in R.Examples )
				{
					//s = s + "<li>" +   ex.Replace ( "\n" , "<br/>" ) + "</li>";
					s = s + "<li>" + TryMatch ( ex , R ) + "</li>";
				}
				s = s + "</ol></li>";
			}
			s = s + "</ol>";
			return s;
		}
		
		private static string TryMatch(string s, Rule R)
		{
			if (s == null || s.Trim().Length == 0)
			{
				return "";
			}
			return s.Replace("\n", "<br/>");
		}

		/*private static string TryMatch (string s , Rule R)
		{
			if ( s == null || s.Trim ( ).Length == 0 )
			{
				return "";
			}

			Padyam P= new Padyam ( );
			MatchOptions Options = MatchOptions.TradtionalMatchSettings;
			P.MatchYati = Options.MatchYati;
			P.MatchPrasa = Options.MatchPrasa;
			P.AllowSantiPrasa = Options.AllowSantiPrasa;
			P.SandiMatch = Options.ExperimenatalSandhi;

			MatchResult MR= P.Match ( s , R );
			if ( MR.Total == 0 )
			{
				return "";
			}

			return P.Build2 ( MR );
		}*/

		private static string ColorFul (string series)
		{
			return series.Replace ( "|" , " <span class='laghu'>I</span> " ).Replace ( "U" , " <span class='guru'>U</span> " );
		}
		private static string MatraSreni2 (string Sequence , int x , int y)
		{
			string s = "";
			int tot = 0;
			int target=x;

			if ( Sequence.Length < target )
			{
				return "";
			}

			int done=0;
			for ( int i = 0 ; i < Sequence.Length ; i++ )
			{
				if ( tot > target )
				{
					return "";
				}

				if ( tot == target )
				{
					tot = 0;
					s = s + "-";
					target = ( target == x ) ? y : x;
					done++;
				}
				tot = tot + ( StringPlus.CharAt ( Sequence , i ) == '|' ? 1 : 2 );
				s = s + StringPlus.CharAt ( Sequence , i );
			}

			if ( tot > target || done < 2 )
			{
				return "";
			}

			return s;
		}
		public static string MatraSreni (string Sequence , int target)
		{
			string s = "";
			int tot = 0;

			if ( Sequence.Length < target )
			{
				return "";
			}

			for ( int i = 0 ; i < Sequence.Length ; i++ )
			{
				if ( tot > target )
				{
					return null;
				}

				if ( tot == target )
				{
					tot = 0;
					s = s + "-";
				}
				tot = tot + ( StringPlus.CharAt ( Sequence , i ) == '|' ? 1 : 2 );
				s = s + StringPlus.CharAt ( Sequence , i );
			}

			if ( tot > target )
			{
				return "";
			}
			return s;

		}
		private static string AvailableSerieses (string Sequence)
		{
			string temp="";
			string seq=Sequence.Replace ( "-" , "" );
			for ( int i=3 ; i <= 6 ; i++ )
			{
				string _m= MatraSreni ( seq , i );
				if ( _m == "" || _m == null )
				{
					continue;
				}
				temp = temp + "<li> " + MatraSreniName ( i ) + ": " + ColorFul ( _m ) + "</li>";
			}

			{
				foreach ( int[] D in new int[][] { new int[] { 3 , 4 } , new int[] { 3 , 5 } , new int[] { 4 , 5 } } )
				{
					int x=D[0];
					int y=D[1];
					string _m= MatraSreni2 ( seq , x , y );
					if ( _m != "" )
					{
						temp = temp + "<li> " + MatraSreniName2 ( x , y ) + ": " + ColorFul ( _m ) + "</li>";
					}


					x = D[1];
					y = D[0];
					_m = MatraSreni2 ( seq , x , y );
					if ( _m != "" )
					{
						temp = temp + "<li> " + MatraSreniName2 ( x , y ) + ": " + ColorFul ( _m ) + "</li>";
					}

				}

			}

			if ( temp != "" )
			{
				temp = "<ul>" + temp + "</ul>";
			}
			return temp;
		}
		private static string MatraSreniName2 (int x , int y)
		{
			return "మిశ్రగతి శ్రేణి (" + x + "-" + y + ") ";
		}
		private static string MatraSreniName (int n)
		{

			switch ( n )
			{
				case 3:
					return "త్రిమాత్రా శ్రేణి";
				case 4:
					return "చతుర్మాత్రా శ్రేణి";
				case 5:
					return "పంచమాత్రా శ్రేణి";
				case 6:
					return "షణ్మాత్రా శ్రేణి";
				default:
					return "";
			}
		}
	}
}
