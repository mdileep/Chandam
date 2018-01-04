using System;
using System.Collections.Generic;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Diagnostics;
using Library.Chandam;
using System.Text.RegularExpressions;
using Chandam.Core;
using Chandam.Rules;


namespace Verifier
{
	public class Worker
	{
		public static string Build2 (MatchResult MR , Rule R , Padyam P ,string lines, string number , string type,string skanda,string ghatta)
		{

			string x=P.Build2 ( MR );
			x = x.Replace ( "<b><u>" , "<B><U><Font html:Color=\"#0000FF\">" );
			x = x.Replace ( "</u></b>" , "</Font></U></B>" );
			string y=x.Replace ( "<b>" , "<B><Font html:Color=\"#FF0000\">" ).Replace ( "<u>" , "<U><Font html:Color=\"#0000FF\">" ).Replace ( "</b>" , "</Font></B>" ).Replace ( "</u>" , "</Font></U>" ).Replace ( "<br />" , "&#10;" );

			string e=MR.ShowErrors ( OutputFormat.Text ).Replace ( "\n" , "&#10;" );
			StringBuilder  sb= new StringBuilder ( );
			sb.AppendLine ( "<Cell><Data ss:Type=\"String\">" +skanda + "</Data></Cell>" );
			sb.AppendLine ( "<Cell><Data ss:Type=\"String\">" + ghatta + "</Data></Cell>" );
			sb.AppendLine ( "<Cell><Data ss:Type=\"String\">" + number + "</Data></Cell>" );
			sb.AppendLine ( "<Cell><Data ss:Type=\"String\">" + type + "</Data></Cell>" );
			sb.AppendLine ( "<Cell><Data ss:Type=\"String\">" + R.ShortName + "</Data></Cell>" );
			sb.AppendLine ( "<Cell><Data ss:Type=\"String\">" + MR.Percentage.ToString ( "0" ) + "</Data></Cell>" );
			sb.AppendLine ( "<Cell ss:StyleID=\"s62\"><ss:Data ss:Type=\"String\"   xmlns=\"http://www.w3.org/TR/REC-html40\">" + y + "</ss:Data></Cell>" );
			sb.AppendLine ( "<Cell ss:StyleID=\"s62\"><ss:Data ss:Type=\"String\"   xmlns=\"http://www.w3.org/TR/REC-html40\">" + e + "</ss:Data></Cell>" );
			return sb.ToString ( );
		}
		public static string Build2 (string s , string number , string type,string skanda,string ghatta,ref int score)
		{
			Probable Pr=Padyam.MostProbable ( s , MatchOptions.TradtionalMatchSettings );
			if ( Pr==null || Pr.MatchResult == null )
			{
				Debugger.Break ( );
				return "";
			}
			MatchResult MR= Pr.MatchResult;
			Rule R=Pr.Rule;
			Padyam P =Pr.Padyam;
			if ( Pr.MatchResult.Percentage != 100 )
			{
				score = 1;
			}
			score = 0;
			return Build2 ( MR , R , P ,s, number , type , skanda,ghatta );

		}
		public void Verify3 (string dir)
		{
			DirectoryInfo DI=new DirectoryInfo (dir);
			foreach ( FileInfo  FI in DI.GetFiles ( "*.xml" ) )
			{
				if ( FI.Name.Contains ( "_Result" ) )
				{
					continue;
				}
				Console.WriteLine ( FI.FullName );
				List<Poem> List=Poem.DeSerialise ( FI.FullName );
				StringBuilder content= new StringBuilder ( );
				content.Append ( File.ReadAllText ( dir+"/Template.txt" ) );

				content.AppendLine ( "<Worksheet ss:Name=\""+FI.Name+"\">" );
				content.AppendLine ( "<Table x:FullColumns=\"1\"  x:FullRows=\"1\" ss:DefaultRowHeight=\"15\"><Column ss:Index=\"7\" ss:AutoFitWidth=\"0\" ss:Width=\"300\"  /><Column ss:Index=\"8\" ss:AutoFitWidth=\"0\" ss:Width=\"450\"  />" );
				content.AppendLine ( "<Row  ss:Height=\"60\">" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Skanda</Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Ghatta</Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Number</Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Type </Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Type-Calculated </Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Percentage </Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Lines</Data></Cell>" );
				content.AppendLine ( "<Cell><Data ss:Type=\"String\">Errors</Data></Cell>" );
				content.AppendLine ( "</Row>" );
				int lc=1;
				foreach ( Poem P in List )
				//Poem P = List[0];
				{
					Console.WriteLine ( "Processing " + ( lc++) + " of " + List.Count );
					//if ( P.Skanda == "" )
					//{
					//    continue;
					//}
					count++;
					content.AppendLine ( "<Row ss:Height=\""+(Findlines(P.Lines)*15)+"\">" );
					if ( P.Type.StartsWith ( "వచనము" ) || P.Type.StartsWith ( "దం." ) || P.Type.StartsWith ( "వ." ) || P.Type.StartsWith ( "గ." ) )
					{
						skipped++;
						content.AppendLine ( "<Cell><Data ss:Type=\"String\">" + P.Skanda + "</Data></Cell>" );
						content.AppendLine ( "<Cell><Data ss:Type=\"String\">" + P.Ghatta + "</Data></Cell>" );
						content.AppendLine ( "<Cell><Data ss:Type=\"String\">" + P.Number + "</Data></Cell>");
						content.AppendLine ( "<Cell><Data ss:Type=\"String\">" + P.Type + "</Data></Cell>" );
						content.AppendLine ( "<Cell><Data ss:Type=\"String\"></Data></Cell>" );
						content.AppendLine ( "<Cell><Data ss:Type=\"String\"></Data></Cell>" );
						content.AppendLine ( "<Cell ss:StyleID=\"s62\"><Data ss:Type=\"String\">" + P.Lines + "</Data></Cell>" );
						
					}
					else
					{
						int hasError=0;
						content.AppendLine ( Build2 ( P.Lines , P.Number , P.Type,P.Skanda,P.Ghatta,ref hasError ) );
						err = err + hasError;
					}
					content.AppendLine ( "</Row>" );
				}
				content.AppendLine ( " </Table>" );
				content.AppendLine ( "</Worksheet>" );
				content.AppendLine ( "</Workbook>" );
				string j=FI.FullName + "_Result.xml";

				
				
				File.WriteAllText ( j , content.ToString ( ) , Encoding.Unicode );
			}




			Console.WriteLine ( "----------------------------------" );

			Console.WriteLine ( "Verified.." + count );
			Console.WriteLine ( "Errors.." + err );
			Console.WriteLine ( "Skipped.." + skipped );

			Console.WriteLine ( "----------------------------------" );
			Console.WriteLine ( "" );
		}

		private int Findlines (string p)
		{
			int cnt=0;
			try
			{
				foreach ( char a in p )
				{
					if ( a == '\n' )
					{
						cnt++;
					}
				}
			}
			catch
			{
				return 4;
			}
			return cnt+1;
		
		}


		public void ExtractYati ()
		{

			List<Poem> L=GetPoems ( );

			StreamWriter SW= new StreamWriter ( "Yati.txt" );
			foreach ( Poem P in L )
			{
				if ( P.Yatis != null )
				{
					foreach ( YatiGroups Y in P.Yatis )
					{
						SW.WriteLine ( Y.y1 + "|" + Y.y2 + "|" + Y.Context );
					}
					SW.Flush ( );
				}
			}
			SW.Close ( );
		}

		public  void Dump2 (string file)
		{
			FileInfo FI= new FileInfo ( file );
			
			Console.WriteLine ( "Opening..." + file );

			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;
			xlApp = new Excel.Application ( );
			xlWorkBook = xlApp.Workbooks.Open ( file );
			int w=xlWorkBook.Worksheets.Count;
			try
			{
				for ( int _w=1 ; _w <= w ; _w++ )
				{
					Console.WriteLine ( "\n Reading Sheet  : " + _w + " of " + w );

					xlWorkSheet = ( Excel.Worksheet ) xlWorkBook.Worksheets.get_Item ( _w );

					int columns = xlWorkSheet.UsedRange.Columns.Count;
					int rows=xlWorkSheet.UsedRange.Rows.Count;

					List<Poem> L= new List<Poem> ( );




					for ( int i=2 ; i < rows ; i++ )
					{
						Console.Write ( "\r Reading Row : " + i.ToString ( ) );

						Poem P= new Poem ( );

						for ( int j=columns ; j >= 1 ; j-- )
						{
							string curr="";
							{
								Excel.Range rng = ( Excel.Range ) xlWorkSheet.Cells[i , j];
								if ( rng.Value2 != null )
								{
									curr = rng.Value2.ToString ( );
								}
							}

							switch ( j )
							{
								//case 2:
								//    P.Number = curr;
								//    break;
								//case 3:
								//    P.Type = curr;
								//    break;
								//case 1:
								//    P.Skanda = curr;
								//    break;
								//case 4:
								//    P.Lines = curr;
								//    break;


								case 1:
									P.Skanda = curr;
									break;
								case 2:
									
									P.Ghatta = curr + " - " + P.Ghatta;
									break;
								case 3:
									P.Ghatta = curr;
									break;
								case 4:
									P.Number = curr;
									break;
								case 5:
									P.Type = curr;
									break;

								case 6:
									P.Lines = curr;
									break;
							}

						}
						L.Add ( P );

					}
					if ( L.Count > 0 )
					{
						Console.WriteLine ( "\r Dumping " + L.Count + " items to.." + FI.Directory.Name+"\\" + _w + ".xml" );
						Poem.Serialise ( FI.Directory.FullName+"\\" + xlWorkSheet.Name + ".xml" , L );
						Console.WriteLine ( "" );
					}
				}

			}
			catch ( Exception ex )
			{
				Console.WriteLine ( "Error: " + ex.Message );
			}

			finally
			{
				xlWorkBook.Close ( true , misValue , misValue );
				xlApp.Quit ( );
			}

			Console.WriteLine ( "" );

		}

		internal void Dump ()
		{
			Console.WriteLine ( "Reading..." );


			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;
			xlApp = new Excel.Application ( );
			xlWorkBook = xlApp.Workbooks.Open ( @"D:\Working\Chandam\poems4process.xlsx" );
			xlWorkSheet = ( Excel.Worksheet ) xlWorkBook.Worksheets.get_Item ( 1 );


			int columns = 8;
			//int rows =56280;
			int rows=100;

			try
			{
				List<Poem> L= new List<Poem> ( );

				Poem P= new Poem ( );
				string n1="";
				string n5="";
				string curr1="";
				string curr5="";

				for ( int i=1 ; i < rows ; i++ )
				{
					Console.Write ( "\r Checking Row : " + i.ToString ( ) );

					{
						Excel.Range rng =( Excel.Range ) xlWorkSheet.Cells[i , 1];
						if ( rng.Value2 != null )
						{
							curr1 = rng.Value2.ToString ( );
						}
						else
						{
							curr1 = null;
						}
					}
					{
						Excel.Range rng =( Excel.Range ) xlWorkSheet.Cells[i , 5];
						if ( rng.Value2 != null )
						{
							curr5 = rng.Value2.ToString ( );
						}
						else
						{
							curr5 = null;
						}
					}
					if ( curr1 == null && curr5 == null )
					{
						continue;
					}
					if ( curr5 != n5 )
					{
						if ( !String.IsNullOrEmpty ( P.Skanda ) )
						{
							L.Add ( P );
						}

						if ( n1 != curr1 )
						{
							if ( L.Count > 0 )
							{
								Console.WriteLine ( "\r Dumping " + L.Count + " items to.." + "2014\\" + n1 + ".xml" );
								Poem.Serialise ( "2014\\" + n1 + ".xml" , L );
								Console.WriteLine ( "" );
							}

							L = new List<Poem> ( );
						}

						P = new Poem ( );
						n5 = curr5;
						n1 = curr1;
						if ( String.IsNullOrEmpty ( curr5 ) )
						{
							continue;
						}
					}





					for ( int j=columns ; j >= 1 ; j-- )
					{

						string curr="";
						{
							Excel.Range rng = ( Excel.Range ) xlWorkSheet.Cells[i , j];
							if ( rng.Value2 != null )
							{
								curr = rng.Value2.ToString ( );
							}
						}


						switch ( j )
						{

							case 8:
								P.Number = curr;
								break;
							case 7:
								P.Lines = ( P.Lines != null ) ? ( P.Lines + "\n" ) + curr : curr;
								break;
							case 6:
								P.Type = curr;
								break;
							case 5:
								P.Number = curr;
								break;
							case 4:
								P.Skanda = curr;
								break;
							case 3:
								P.Title = curr;
								break;
							case 2:
								P.Ghatta = curr;
								break;
						}

					}

				}
				if ( L.Count > 0 )
				{
					Console.WriteLine ( "\r Dumping " + L.Count + " items to.." + "27Jan14\\" + n1 + ".xml" );
					Poem.Serialise ( "27Jan14\\" + n1 + ".xml" , L );
					Console.WriteLine ( "" );
				}

			}
			catch ( Exception ex )
			{
				Console.WriteLine ( "Error: " + ex.Message );
			}

			finally
			{
				xlWorkBook.Close ( true , misValue , misValue );
				xlApp.Quit ( );
			}

			Console.WriteLine ( "" );

		}
		internal void Verify ()
		{
			List<Poem> L=GetPoems ( );
			Verify ( L );
			#region...
			//for ( int i=1 ; i <=12 ; i++ )
			//{

			//    switch(i)
			//    {
			//        case 10:
			//            Verify ( "10.1");
			//            Verify ( "10.2" );
			//            break;
			//        case 5:
			//            Verify ( "5.1" );
			//            Verify ( "5.2" );
			//            break;
			//        default:
			//            Verify ( i.ToString ( ) );
			//            break;
			//    }
			//}
			#endregion

		}
		int count=1;
		int err=0;
		int skipped=0;
		public List<Poem> GetPoems ()
		{
			return GetPoems ( "*.xml" );
		}
		public List<Poem> GetPoems (string filter)
		{
			List<Poem> Stats = new List<Poem> ( );

			DirectoryInfo DI=new DirectoryInfo ( "27Jan14" );
			foreach ( FileInfo  FI in DI.GetFiles ( filter ) )
			{
				Console.WriteLine ( FI.FullName );


				List<Poem> List=Poem.DeSerialise ( FI.FullName );
				foreach ( Poem P2 in List )
				{

					//if ( String.IsNullOrEmpty ( P2.Skanda ) && String.IsNullOrEmpty ( P2.Type ) && String.IsNullOrEmpty ( P2.Lines ) )
					//{
					//    continue;
					//}

					Console.Write ( "\r Finding match for  " + count );
					count++;


					//if ( P2.Type.EndsWith ( "వ." ) || P2.Type.EndsWith ( "గ." ) || P2.Type.EndsWith ( "దం." ) )
					//{
					//    P2.Lines = P2.Lines.Replace ( "\n" , " " );
					//    Stats.Add ( P2 );
					//    skipped++;
					//    continue;
					//}

					string lines=P2.Lines;
					//if ( P2.Type.EndsWith ( "ససీ." ) || P2.Type.EndsWith ( "సీ." ) )
					//{
					//    lines = lines.Replace ( ";" , "\n" );
					//    lines = lines.Replace ( "\n\n" , "\n" );
					//    lines = lines.Replace ( "\n \n" , "\n" );
					//    lines = lines.TrimEnd ( ' ' , '\n' );
					//    if ( lines.Split ( '\n' ).Length != 8 )
					//    {
					//        Stats.Add ( P2 );
					//        skipped++;
					//        continue;
					//    }
					//}
					Poem S2=null;
					if ( P2.Type.StartsWith ( "వచనము" ) || P2.Type.StartsWith ( "దం." ) )
					{
						S2 = new Poem ( );
					}
					else
					{
						S2 = Match2 ( lines );
					}
					S2.Ghatta = P2.Ghatta;
					S2.Lines = P2.Lines;
					S2.Skanda = P2.Skanda;
					S2.Title = P2.Title;
					S2.Number = P2.Number;
					S2.Type = P2.Type;


					Stats.Add ( S2 );
					if ( !S2.HasMatach )
					{
						err++;

					}

				}

			}
			return Stats;
		}
		internal void Verify (List<Poem> Stats)
		{

			DirectoryInfo DI=new DirectoryInfo ( "27Jan14" );
			Export ( DI.FullName + "\\Tebha.xlsx" , Stats );


			Console.WriteLine ( "----------------------------------" );

			Console.WriteLine ( "Verified.." + count );
			Console.WriteLine ( "Errors.." + err );
			Console.WriteLine ( "Skipped.." + skipped );

			Console.WriteLine ( "----------------------------------" );
			Console.WriteLine ( "" );
		}
		public void Verify2 ()
		{
			DirectoryInfo DI=new DirectoryInfo ( "27Jan14" );
			foreach ( FileInfo  FI in DI.GetFiles ( "*.xml" ) )
			{
				Console.WriteLine ( FI.FullName );
				List<Poem> List=Poem.DeSerialise ( FI.FullName );

				string title="";
				string header="";
				string footer="";

				StringBuilder content= new StringBuilder ( );
				content.AppendLine ( "<ul  class='ol'>" );
				foreach ( Poem P in List )
				{
					content.AppendLine ( "<li>" );
					if ( P.Type.StartsWith ( "వచనము" ) || P.Type.StartsWith ( "దం." ) )
					{
						content.Append ( "<div style=' margin-top:10px;'>" );
						content.AppendLine ( "<div class='err10' style='clear:left;text-align:left;width:100%;'>" +P.Number+". "+ P.Type + "</div>" );
						content.AppendLine ( "<div style='clear:left;float:left;margin-left:10px;'><div class='Err22'>" );
						content.AppendLine ( P.Lines);
						content.AppendLine ( "</div></div>" );
						content.AppendLine ( "</div" );

					}
					else
					{
						content.AppendLine ( Build ( P.Lines,P.Number,P.Type ) );
					}


					content.AppendLine ( "<li>" );
				}
				content.AppendLine ( "</ul>" );


				StringBuilder sb= new StringBuilder ( );
				sb.AppendLine ( "<html>" );
				sb.AppendLine ( "<head>" );
				sb.AppendFormat ( "<title>{0}</title>" , title );
				sb.AppendLine ( "" );
				//sb.AppendLine ( @"<link href=""Chandam.css"" rel=""stylesheet"" type=""text/css"" />" );
				sb.AppendLine ( "<style>" );
				sb.AppendLine ( File.ReadAllText ( "Chandam.css" ) );
				sb.AppendLine ( "</style>" );
				sb.AppendLine ( "</head>" );
				sb.AppendLine ( "<body>" );
				sb.AppendFormat ( "<div class='title'>{0}</div>" , title );
				sb.AppendFormat ( "<div class='header'>{0}</div>" , header.Replace ( "\n" , "<br/>" ) );
				sb.AppendLine ( "" );

				sb.Append ( content.ToString ( ) );

				sb.AppendFormat ( "<div class='footer'>{0}</div>" , footer.Replace ( "\n" , "<br/>" ) );
				sb.AppendLine ( "</body>" );
				sb.AppendLine ( "</html>" );

				File.WriteAllText ( FI.FullName + "_y.html" , sb.ToString ( ),Encoding.Unicode );
			}




			Console.WriteLine ( "----------------------------------" );

			Console.WriteLine ( "Verified.." + count );
			Console.WriteLine ( "Errors.." + err );
			Console.WriteLine ( "Skipped.." + skipped );

			Console.WriteLine ( "----------------------------------" );
			Console.WriteLine ( "" );
		}

		public static string Build (string s,string number,string type)
		{
			Probable Pr=Padyam.MostProbable ( s , MatchOptions.QucikMatchSettings );
			if ( Pr.MatchResult == null )
			{
				Debugger.Break ( );
			}
			MatchResult MR= Pr.MatchResult;
			Rule R=Pr.Rule;
			Padyam P =Pr.Padyam;
			return Build ( MR , R , P ,number,type);

		}

		public static string Build (MatchResult MR , Rule R , Padyam P,string number,string type)
		{
			StringBuilder  sb= new StringBuilder ( );
			sb.Append ( "<div style=' margin-top:10px;'>" );
			if ( MR.Percentage != 100 )
			{
				sb.Append ( "<div class='err10' style='clear:left;text-align:left;width:100%;'>" +number+".  "+ R.ShortName );
				sb.AppendLine ( "-<i>" + type +"</i>");
				sb.Append ( ": <b style='color:red'>" + MR.Percentage.ToString ( "0" ) + "%</b>(" + MR.Score + "/" + MR.Total + ")" );
				
				sb.AppendLine ( "</div>" );

				sb.AppendLine ( "<div style='clear:left;float:left;width:50%;margin-right:10px;'>" );
				sb.AppendLine ( "<div style='margin:10px; text-align:left;'>" );
				sb.AppendLine ( "<div class='Err22'>" );
				sb.AppendLine ( P.Build2 ( MR ) );
				sb.AppendLine ( "</div>" );
				sb.AppendLine ( "<div class='err' style='text-align:right;'>దోషాలు</div>" );
				sb.AppendLine ( MR.ShowErrors ( OutputFormat.HTML ) );
				sb.AppendLine ( "</div>" );
				sb.AppendLine ( "</div>" );

				sb.AppendLine ( "<div style='float:left;width:40%;margin-left:10px;'><div class='err'  style='text-align:right;'>గణ విభజన</div>" );
				sb.AppendLine ( P.Build ( MR ) );
				sb.AppendLine ( "</div>" );
			}
			else
			{
				sb.AppendLine ( "<div class='err10' style='clear:left;text-align:left;width:100%;'>" + number + ".  " + R.ShortName + "</div>" );
				sb.AppendLine ( "<div style='clear:left;float:left;margin-left:10px;'><div class='Err22'>" );
				sb.AppendLine ( P.Build2 ( MR ) );
				sb.AppendLine ( "</div></div>" );
			}
			sb.AppendLine ( "</div" );
			return sb.ToString ( );
		}

		private void Export (string fileName , List<Poem> Stats)
		{
			Console.WriteLine ( "\nPreparing..." );


			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;

			xlApp = new Excel.Application ( );
			xlWorkBook = xlApp.Workbooks.Add ( misValue );


			try
			{



				//( ( Excel.Worksheet ) xlApp.ActiveWorkbook.Sheets[2] ).Delete ( );
				//( ( Excel.Worksheet ) xlApp.ActiveWorkbook.Sheets[3] ).Delete ( );

				xlWorkSheet = ( Excel.Worksheet ) xlWorkBook.Worksheets.get_Item ( 1 );

				xlWorkBook.SaveAs ( fileName , Excel.XlFileFormat.xlWorkbookDefault , misValue , misValue , misValue , misValue , Excel.XlSaveAsAccessMode.xlExclusive , misValue , misValue , misValue , misValue , misValue );

				int row=1;
				int col=1;

				xlWorkSheet.Cells[row , col++] = "Skanda No";
				xlWorkSheet.Cells[row , col++] = "Ghatta No";
				xlWorkSheet.Cells[row , col++] = "Ghatta";
				xlWorkSheet.Cells[row , col++] = "Poem Number";
				xlWorkSheet.Cells[row , col++] = "Mentioned";
				xlWorkSheet.Cells[row , col++] = "Calculated";
				xlWorkSheet.Cells[row , col++] = "Match Percentage";
				xlWorkSheet.Cells[row , col++] = "Poem";
				xlWorkSheet.Cells[row , col++] = "Remarks";
				xlWorkSheet.Cells[row , col++] = "Poem(With Markings)";
				row++;

				foreach ( Poem P in Stats )
				{


					col = 1;
					Console.Write ( "\r Processing " + row );
					xlWorkSheet.Cells[row , col++] = P.Skanda;
					xlWorkSheet.Cells[row , col++] = P.Ghatta;
					xlWorkSheet.Cells[row , col++] = P.Title;
					xlWorkSheet.Cells[row , col++] = P.Number;
					xlWorkSheet.Cells[row , col++] = ReWrite ( P.Type );
					xlWorkSheet.Cells[row , col++] = P.Calculated;
					xlWorkSheet.Cells[row , col++] = P.Percentage;
					xlWorkSheet.Cells[row , col++] = P.Lines;
					xlWorkSheet.Cells[row , col++] = P.Remarks;
					xlWorkSheet.Cells[row , col++] = P.MarkingText;

					#region
					//Excel.Range RF=( Excel.Range ) xlWorkSheet.Cells[row , col-1];
					//if ( P.BMarkings != null )
					//{
					//    foreach ( Range _R in P.BMarkings )
					//    {
					//        RF.get_Characters ( _R.From , _R.Length ).Font.Bold =true;
					//    }
					//}
					//if ( P.UMarkings != null )
					//{
					//    foreach ( Range _R in P.UMarkings )
					//    {
					//        RF.get_Characters ( _R.From , _R.Length ).Font.Underline = true;
					//    }
					//}
					//if ( RF.Value2 != null )
					//{
					//    int _index=RF.Value2.ToString ( ).IndexOf ( "<b>" );
					//    while ( _index != -1 && RF != null )
					//    {
					//        RF.get_Characters ( _index , 4 ).Text = "";
					//        _index = RF.Value2.ToString ( ).IndexOf ( "<b>" );
					//    }

					//    _index = RF.Value2.ToString ( ).IndexOf ( "<u>" );
					//    while ( _index != -1 && RF != null )
					//    {
					//        RF.get_Characters ( _index , 4 ).Text = "";
					//        _index = RF.Value2.ToString ( ).IndexOf ( "<u>" );
					//    }

					//    _index = RF.Value2.ToString ( ).IndexOf ( "</b>" );
					//    while ( _index != -1 && RF != null )
					//    {
					//        RF.get_Characters ( _index , 4 ).Text = "";
					//        _index = RF.Value2.ToString ( ).IndexOf ( "</b>" );
					//    }

					//    _index = RF.Value2.ToString ( ).IndexOf ( "</u>" );
					//    while ( _index != -1 && RF != null )
					//    {
					//        RF.get_Characters ( _index , 4 ).Text = "";
					//        _index = RF.Value2.ToString ( ).IndexOf ( "</b>" );
					//    }
					//}
					#endregion

					row++;
					if ( row % 1000 == 0 )
					{
						xlWorkBook.Save ( );
					}
				}

				xlWorkBook.Save ( );

				Console.Write ( " Little Styling.. " );
				{



					Excel.Range  rng =( Excel.Range ) xlWorkSheet.Cells[1 , 8];
					rng.EntireColumn.ColumnWidth = 60;

					rng = ( Excel.Range ) xlWorkSheet.Cells[1 , 9];
					rng.EntireColumn.ColumnWidth = 40;

					rng = ( Excel.Range ) xlWorkSheet.Cells[1 , 6];
					rng.EntireColumn.ColumnWidth = 20;

					rng = ( Excel.Range ) xlWorkSheet.Cells[1 , 5];
					rng.EntireColumn.ColumnWidth = 20;

					rng = ( Excel.Range ) xlWorkSheet.Cells[1 , 1];
					rng.EntireRow.RowHeight = 10;

					xlWorkBook.Save ( );
					rng = ( Excel.Range ) xlWorkSheet.get_Range ( "a1" ).EntireRow.EntireColumn;
					rng.EntireRow.RowHeight = 75;
					rng.EntireRow.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
					rng.EntireRow.HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft;
				}
				Console.WriteLine ( " Done" );
				Console.Write ( "About to Save..." );
				xlWorkBook.Save ( );
				Console.WriteLine ( "Done" );

			}
			catch ( Exception ex )
			{
				Console.WriteLine ( "Error: " + ex.Message );
			}

			finally
			{
				xlWorkBook.Close ( true , misValue , misValue );
				xlApp.Quit ( );
			}

			Console.WriteLine ( "" );
		}



		public static string ReWrite (string p)
		{
			switch ( p )
			{

				default:
					return p;
				case "భు.":
					return "భుజంగ ప్రయాతము";
				case "ఆ.":
					return "ఆటవెలది";
				case "ఇ.":
					return "ఇంద్రవ్రజము";
				case "ఉ.":
					return "ఉత్పలమాల";
				case "ఉత్సా.":
					return "ఉత్సాహవృత్తము";
				case "ఉపేం.":
					return "ఉపేంద్రవ్రజము";
				case "క.":
					return "కందం";
				case "కవి.":
					return "కవిరాజ విరాజితము";
				case "చ.":
					return "చంపకమాల";
				case "త.":
					return "తరళము";
				case "తే.":
					return "తేటగీతి";
				case "మ.":
					return "మత్తేభ విక్రీడితము";
				case "మత్త.":
					return "మత్తకోకిలము";
				case "మస్ర.":
					return "మహాస్రగ్దర";
				case "మా.":
					return "మాలిని";
				case "మాని.":
					return "మానినీ";
				case "లగ్రా.":
					return "లయగ్రాహి";
				case "లవి.":
					return "లయవిభాతి";
				case "వ.`":
					return "వచనము";
				case "వ.contineun":
					return "వచనము";
				case "శా.":
					return "శార్దూల విక్రీడితము";
				case "శ్లో.":
					return "శ్లోకము";
				case "ససీ.":
					return "సర్వలఘుసీసము";
				case "సీ.":
					return "సీసము";
				case "స్రగ్ద.":
					return "స్రగ్దర";

			}

		}


		private Poem Match2 (string p)
		{
			Poem S=  new Poem ( );

			Probable Pr=Padyam.MostProbable ( p , new MatchOptions ( ) );
			Padyam P= Pr.Padyam;

			P.MatchYati = true;
			P.MatchPrasa = true;
			P.AllowSantiPrasa = true;
			MatchResult MR= Pr.MatchResult;
			Rule R=Pr.Rule;

			S.Calculated = R.ShortName;
			S.HasMatach = MR.IsMatched;
			S.Percentage = MR.Percentage.ToString ( );
			S.Remarks = MR.ShowErrors ( OutputFormat.Text );

			string s= P.Build2 ( Pr.MatchResult );
			S.MarkingText = s;

			S.Yatis = ExtractYati ( s );


			return S;

		}

		private List<YatiGroups> ExtractYati (string s)
		{
			List<YatiGroups> L= new List<YatiGroups> ( );
			string strRegex = @"<u>(.*?)</u>";
			RegexOptions myRegexOptions = RegexOptions.None;
			Regex myRegex = new Regex ( strRegex , myRegexOptions );

			string lines= s.Replace ( "<br />" , "\n" );
			foreach ( string line in lines.Split ( '\n' ) )
			{
				int i=0;
				string temp="";
				foreach ( Match myMatch in myRegex.Matches ( line ) )
				{
					string t=myMatch.Groups[1].ToString ( );
					if ( i == 0 )
					{
						temp = t;
					}
					else
					{
						if ( !String.IsNullOrEmpty ( t ) && t != " " )
						{
							YatiGroups G= new YatiGroups ( );
							G.y1 = temp;
							G.y2 = t;
							G.Context = line;
							L.Add ( G );
						}
					}
					i++;
				}
			}

			return L;
		}



		//private List<Range> GetList (string tag , string s)
		//{
		//    List<Range> R= new List<Range> ( );
		//    int last=0;
		//    while ( last < s.Length && s.IndexOf ( "<" + tag + ">" , last ) != -1 )
		//    {
		//        int from =s.IndexOf ( "<" + tag + ">" , last );
		//        int to=s.IndexOf ( "</" + tag + ">" , last );

		//        Range _R= new Range ( );
		//        _R.From = from+1;
		//        _R.Length = to - from;

		//        R.Add ( _R );
		//        last = to + 4;
		//    }
		//    return R;
		//}



		internal void VerifyYati ()
		{
			Console.WriteLine ( "Yati Check..." );

			int s=0;
			int fa=0;
			char seperator='\t';
			StreamReader SR= new StreamReader ( "Yati.txt" );
			StreamWriter SS= new StreamWriter ( "Yati_Pass.txt" );
			StreamWriter SF= new StreamWriter ( "Yati_Fail.txt" );
			YatiPrasaChecker2  Y= new YatiPrasaChecker2 ( );
			while ( !SR.EndOfStream )
			{
				string line=SR.ReadLine ( );
				string[] j= line.Split ( seperator );
				if ( j.Length > 2 )
				{
					string y1= j[0];
					string y2= j[1];
					string y3= j[2];


					bool f=Y.IsYatiMatched ( y1 , y2 );
					if ( f )
					{
						SS.WriteLine ( y1 + "|" + y2 + "" );
						SS.Flush ( );
						s++;
					}
					else
					{
						SF.WriteLine ( y1 + "|" + y2 + "|" + y3 );
						SF.Flush ( );
						fa++;
					}
				}
			}
			SS.Close ( );
			SF.Close ( );
			Console.WriteLine ( "Pass: " + s.ToString ( ) );
			Console.WriteLine ( "Fail: " + fa.ToString ( ) );
			Console.WriteLine ( "Tot: " + ( s + fa ).ToString ( ) );
		}


	}
}

