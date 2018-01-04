using System;
using System.Collections.Generic;
using System.Text;
using Library.Chandam;
using System.Xml;
using System.IO;

namespace Verifier
{
	class Work
	{

		private static void Do ()
		{
			for ( int i=6 ; i <= 6 ; i++ )
			{

				if ( i == 10 )
				{
					Do ( "10_1" );
					//Do ( "10_2" );
				}
				else
				{
					Do ( i.ToString ( ) );
				}
			}
		}

		private static void Do (string i)
		{
			//XmlTextWriter w = new XmlTextWriter ( "Stats\\Stats_" + i + ".xml" , Encoding.UTF8 );
			//w.Formatting = Formatting.Indented;
			//w.WriteStartElement ( "Stats" );
			List<Stats> Stats = new List<Stats> ( );

			int count=0;
			int err=0;
			int skipped=0;
			foreach ( FileInfo  FI in new DirectoryInfo ( "Poems" ).GetFiles ( i.ToString ( ) + "_*.xml" ) )
			{
				Console.WriteLine ( FI.FullName );

				//List<Poem> Errors= new List<Poem> ( );
				List<Poem> List=Poem.DeSerialise ( FI.FullName );
				foreach ( Poem P2 in List )
				{

					count++;
					if ( P2.Number.EndsWith ( "వ." ) || P2.Number.EndsWith ( "గ." ) || P2.Number.EndsWith ( "దం." ) )
					{

						Stats S= new Stats ( );
						S.Number = P2.Number;
						S.Prose = P2.Prose;
						S.Tilte = P2.Title;
						S.Poem = P2.Lines;
						S.File = FI.Name.Replace ( "_Poems.xml" , "" ).Replace ( "_" , "-" );

						Stats.Add ( S );
						//Append ( w , S );
						skipped++;
						continue;
					}


					Stats S2=Match2 ( P2.Lines );
					S2.Number = P2.Number;
					S2.Prose = P2.Prose;
					S2.Tilte = P2.Title;
					S2.File = FI.Name.Replace ( "_Poems.xml" , "" ).Replace ( "_" , "-" );
					//Append ( w , S2 );
					Stats.Add ( S2 );


					if ( !S2.HasMatach )
					{
						err++;
						//Errors.Add ( P2 );
					}

				}
				//if ( Errors.Count > 0 )
				//{
				//    Poem.Serialise (@"Errors\Errors_" + FI.Name , Errors );
				//}
			}
			//ExcelUtil.CreateXLS ( Stats , @"D:\Working\Chandam\Verifier\bin\Debug\" + "Stats\\Stats_" + i + ".xlsx" );
			//w.WriteEndElement ( );
			//w.Close ( );


			Console.WriteLine ( "----------------------------------" );

			Console.WriteLine ( "Verified.." + count );
			Console.WriteLine ( "Errors.." + err );
			Console.WriteLine ( "Skipped.." + skipped );

			Console.WriteLine ( "----------------------------------" );
			Console.WriteLine ( "" );
		}

		private static void Append (XmlTextWriter w , Stats F)
		{
			w.WriteStartElement ( "Padyam" );
			w.WriteAttributeString ( "File" , F.File );
			w.WriteAttributeString ( "Chapter" , F.Tilte );

			string[] X=F.Number.Split ( '-' );
			if ( X.Length == 3 )
			{
				w.WriteAttributeString ( "ChapterFromNumber" , X[0] );
				w.WriteAttributeString ( "PoemNumber" , X[1] );
				//w.WriteAttributeString ( "MentionedPoem" , ExcelUtil.ReWrite ( X[2] ) );
			}
			else
			{
				w.WriteAttributeString ( "Raw" , F.Number );
			}

			w.WriteAttributeString ( "Calculated" , F.Calculated );

			w.WriteAttributeString ( "Percentage" , F.Percentage );
			w.WriteStartElement ( "Poem " );
			w.WriteCData ( F.Poem );

			if ( F.Percentage != "100" )
			{
				w.WriteEndElement ( );
				w.WriteStartElement ( "Remarks " );
				w.WriteCData ( F.Remarks );
				w.WriteEndElement ( );
			}
			//w.WriteStartElement ( "Prose " );
			//w.WriteCData ( F.Prose );
			//w.WriteEndElement ( );
			w.WriteEndElement ( );
		}



		private static Stats Match2 (string p)
		{
			Stats S=  new Stats ( );

			Probable Pr=Padyam.MostProbable ( p );
			Padyam P= Pr.Padyam;
			MatchResult MR= Pr.MatchResult;
			Rule R=Pr.Rule;


			S.Poem = p;
			S.Calculated = R.Name;
			S.HasMatach = MR.IsMatched;
			S.Percentage = MR.Percentage.ToString ( );
			S.Remarks = MR.ShowErrors ( OutputFormat.Text );

			return S;

		}

		private static bool Match (string p1)
		{
			Probable Pr=Padyam.MostProbable ( p1 );
			Padyam P= Pr.Padyam;
			MatchResult MR= Pr.MatchResult;
			//Rule R=Pr.Rule;
			return MR.IsMatched;
		}
	}
}
#region Seesam Todo..
//string[] Lines=P2.Lines.TrimEnd('\n').Split ( '\n' );
//if ( Lines.Length> 12 )
//{
//    //string p1= "";
//    //for ( int i=0 ; i < 8 ; i++ )
//    //{
//    //    p1 = Lines[i]+((i==7)?"":"\n");
//    //}
//    //if ( !Match(p1) )
//    //{
//    //    err++;
//    //    Errors.Add ( P2 );
//    //}

//    //p1= "";
//    //for(int i=8;i<12;i++)
//    //{
//    //        p1 = Lines[i]+((i==11)?"":"\n");
//    //}

//    //if ( !Match ( p1 ) )
//    //{
//    //    err++;
//    //    Errors.Add ( P2 );
//    //}

//    skipped++;
//    continue;
//}

//private void Bulk ()
//{
//    StringBuilder sf= new StringBuilder ( );
//    StringBuilder ss= new StringBuilder ( );
//    int tot=0;
//    int fail=0;
//    foreach ( string s in PoemSamples.Poems )
//    {
//        Probable Finalist=Padyam.MostProbable ( s,false,false,false );
//        Padyam P1= Finalist.Padyam;
//        MatchResult MR= Finalist.MatchResult;
//        Rule R=Finalist.Rule;

//        StringBuilder Sb= new StringBuilder ( );
//        Sb.Append ( "<p>" );
//        Sb.Append ( "<Rule>" + Finalist.Rule.Name + "</Rule>" );
//        Sb.Append ( "<poem>" );
//        Sb.Append ( s );
//        Sb.Append ( "</poem>" );
//        Sb.Append ( "<score>" + MR.Percentage + "</score>" );
//        Sb.Append ( "</p>" );

//        tot++;
//        if ( MR.Percentage != 100 )
//        {
//            fail++;
//            sf.Append ( Sb.ToString ( ) );
//        }
//        else
//        {
//            ss.Append ( Sb.ToString ( ) );
//        }




//    }
//    File.WriteAllText ( Server.MapPath ( @"Content\Failed.xml" ) , sf.ToString ( ) );
//    File.WriteAllText ( Server.MapPath ( @"Content\Success.xml" ) , ss.ToString ( ) );
//    Response.Write ( fail + " failed of " + tot +"  ");
//}
#endregion