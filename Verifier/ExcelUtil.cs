using System;
using System.Collections.Generic;
using System.Text;

namespace Verifier
{
	class ExcelUtil
	{

		public static void CreateXLS (List<Stats> List , string Path)
		{
			Excel.Application xlApp;
			Excel.Workbook xlWorkBook;
			Excel.Worksheet xlWorkSheet;
			object misValue = System.Reflection.Missing.Value;



			xlApp = new Excel.Application ( );
			xlWorkBook = xlApp.Workbooks.Add ( misValue );

			xlWorkSheet = ( Excel.Worksheet ) xlWorkBook.Worksheets.get_Item ( 1 );
			xlWorkSheet.Name = "Stats";


			// List of lists containing each line split by part
			List<List<string>> dataList = new List<List<string>> ( );




			int row = 1;
			int col = 1;
			xlWorkSheet.Cells[row , col++] = "File";
			xlWorkSheet.Cells[row , col++] = "Chapter";
			xlWorkSheet.Cells[row , col++] = "ChapterFromNumber";
			xlWorkSheet.Cells[row , col++] = "PoemNumber";
			xlWorkSheet.Cells[row , col++] = "MentionedPoem";
			xlWorkSheet.Cells[row , col++] = "Calculated";
			xlWorkSheet.Cells[row , col++] = "Percentage";
			xlWorkSheet.Cells[row , col++] = "Poem";
			xlWorkSheet.Cells[row , col++] = "Remarks";
			row++;

			foreach ( Stats S in List )
			{
				col = 1;
				xlWorkSheet.Cells[row , col++] = "'" + S.File;
				xlWorkSheet.Cells[row , col++] = S.Tilte;

				string[] X=S.Number.Split ( '-' );

				if ( X.Length == 3 )
				{
					xlWorkSheet.Cells[row , col++] = X[0];
					xlWorkSheet.Cells[row , col++] = X[1];
					xlWorkSheet.Cells[row , col++] = ReWrite ( X[2] );
				}
				else
				{
					xlWorkSheet.Cells[row , col++] = S.Number;
					xlWorkSheet.Cells[row , col++] = S.Number;
					xlWorkSheet.Cells[row , col++] = S.Number;
				}

				xlWorkSheet.Cells[row , col++] = S.Calculated;
				xlWorkSheet.Cells[row , col++] = S.Percentage;
				xlWorkSheet.Cells[row , col++] = S.Poem;
				xlWorkSheet.Cells[row , col++] = S.Remarks;

				row++;
			}


			xlWorkBook.SaveAs ( Path , Excel.XlFileFormat.xlWorkbookDefault , misValue , misValue , misValue , misValue , Excel.XlSaveAsAccessMode.xlExclusive , misValue , misValue , misValue , misValue , misValue );
			xlWorkBook.Close ( true , misValue , misValue );
			xlApp.Quit ( );

			//releaseObject ( xlWorkSheet );
			//releaseObject ( xlWorkBook );
			//releaseObject ( xlApp );

			//textBoxData.AppendText ( "\nData saved to .xls file (path : " + path + ")" );
		}

		public static string ReWrite (string p)
		{
			switch ( p )
			{

				default:
					return p;
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
					return "కంద";
				case "కవి.":
					return "కవిరాజ విరాజితము";
				case "చ.":
					return "చంపకమాల";
				case "త.":
					return "తరలము";
				case "తే.":
					return "తేటగీతి";
				case "మ.":
					return "మత్తేభము";
				case "మత్త.":
					return "మత్తకోకిల";
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
					return "శార్దూలము";
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
	}
}
