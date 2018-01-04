using Chandam.Core;
using Chandam.Rules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
//using Microsoft.Office.Interop.Word;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Verifier
{
	class Annamaya
	{

		public static void Go()
		{
			object s = @"D:\\Working\\Annamaya\x.docx";
			Start(ref s);
		}

		public static void Mallina()
		{
			string s = @"D:\Working\Annamaya\Mallina_Annamaya_Vol1.txt";

			List<string> kIrtanas = new List<string>();
			string temp = "";
			int lines = 0;
			foreach (string Line in File.ReadAllLines(s))
			{
				string curr = Line.Trim();
				if (curr.StartsWith("రేకు") && temp != "")
				{
					kIrtanas.Add(temp);
					Debug.WriteLine(lines);
					lines = 0;
					temp = "";
				}
				temp = temp == "" ? Line : (temp + Environment.NewLine + Line);
				lines++;
			}
			if (temp != "")
			{
				kIrtanas.Add(temp);
			}

			int cnt = 1;
			foreach (string k in kIrtanas)
			{


				string firstLine = k.Substring(0, k.IndexOf('\n', 2));
				firstLine = firstLine.Replace(Environment.NewLine, "");
				firstLine = firstLine.Trim();

				Regex r = new Regex("\t+");

				string v = r.Replace(firstLine, " ");
				v = new Regex(" +").Replace(v, " ");

				string[] Items = v.Split(' ');
				string filename = Items[Items.Length - 1];
				filename = filename.Trim();

				if (cnt.ToString() != filename.Replace("1-", ""))
				{
					Debug.WriteLine("HELLO");
				}
				File.WriteAllText(@"D:\Working\Annamaya\Mallina\" + filename + ".txt", k, Encoding.UTF8);

				cnt++;
			}

		}

		public static void Go2()
		{
			string target = @"D:\\Working\\Annamaya\1\\";
			foreach (FileInfo FI in new DirectoryInfo(target).GetFiles())
			{
				Debug.WriteLine(FI.FullName);
				string x = File.ReadAllText(FI.FullName);
				Go3(x);
			}
		}

		public static void Go3(string content)
		{
			content = content.Trim().Replace("-" + Environment.NewLine, Environment.NewLine);
			Regex regex = new Regex(@"[0-9\-]+", RegexOptions.Multiline);
			MatchCollection mc = regex.Matches(content);
			if (mc.Count > 1)
			{

				Debug.WriteLine("\t" + "Multiple Groups.");
				throw new Exception("Multiple Groups");
			}

			Match match = mc[0];
			int index = content.IndexOf(match.Value);
			string post = content.Substring(index + match.Value.Length);
			if (post.Length > 0)
			{
				Debug.WriteLine("\t" + "Text found Post Number");
				throw new Exception("Text found Post Number");
			}

		}
		public static void Start(ref object FileName)
		{
			//string target = "D:\\Working\\Annamaya\\1\\";
			//_Application oWord;
			//_Document oDoc;
			//oWord = new Application();
			//object missing = System.Reflection.Missing.Value;
			//oDoc = oWord.Documents.Open(ref FileName);
			//WdStatistic stat = WdStatistic.wdStatisticPages;
			//int PageNum = oDoc.ComputeStatistics(stat, ref missing);

			//for (int i = 1600; i < PageNum; i++)
			//{
			//	try
			//	{
			//		object what = WdGoToItem.wdGoToPage;
			//		object which = missing;
			//		object PageNo = i + 1;
			//		object name = missing;
			//		object Page = "\\Page";

			//		Debug.WriteLine("Page: " + PageNo);
			//		Console.WriteLine("Page: " + PageNo);



			//		oWord.Selection.GoTo(ref what, ref which, ref PageNo, ref name);
			//		Range range = oDoc.Bookmarks.get_Item(ref Page).Range;
			//		string txt = range.Text;
			//		txt = txt.Replace("\r", Environment.NewLine).Trim();

			//		Go3(txt);

			//		File.WriteAllText(target + "Page_" + (i + 1) + ".txt", txt, Encoding.UTF8);

			//	}
			//	catch
			//	{
			//		//Exit..
			//		i = PageNum + 1;

			//	}

			//}
			//oDoc.Close();
		}



		public static List<int> CalcMatras(string padyam)
		{
			Rule R = new AnnamayaChandam();
			Padyam P = new Padyam();

			P.MatchYati = false;
			P.MatchPrasa = false;
			P.AllowSantiPrasa = false;
			P.SandiMatch = false;
			MatchResult MR = P.Match(padyam, R);


			List<int> Matras = new List<int>();

			foreach (Errors E in MR.Errors)
			{
				if (E.Mismatch == Mismatch.Weight && E.Actual != "0")
				{
					Matras.Add(Convert.ToInt32(E.Actual));
				}
			}
			return Matras;
		}

		public static void CalcMatras2()
		{
			string folder = @"D:\Working\Annamaya\Mallina";
			string r1 = @"D:\Working\Annamaya\Mallina_Record_1.txt";
			string r2 = @"D:\Working\Annamaya\Mallina_Record_2.txt";

			foreach (FileInfo FI in new DirectoryInfo(folder).GetFiles())
			{

				Console.WriteLine("\rProcessing..." + FI.Name);

				string padyam = File.ReadAllText(FI.FullName);



				padyam = padyam.Substring(padyam.IndexOf('\n', 1) + 1);

				List<int> Matras = CalcMatras(padyam);
				List<int> Matras2 = TwoRowsAsSingle(Matras);


				string chapter = FI.Name.Split('-')[0];
				Record(r1, FI.Name, chapter, Matras);
				Record(r2, FI.Name, chapter, Matras2);

			}

		}


		public static void CalcMatras()
		{
			string folder = @"D:\Working\Annamaya\1";
			string r1 = @"D:\Working\Annamaya\Record_1.txt";
			string r2 = @"D:\Working\Annamaya\Record_2.txt";

			foreach (FileInfo FI in new DirectoryInfo(folder).GetFiles())
			{

				Console.WriteLine("\rProcessing..." + FI.Name);

				string padyam = File.ReadAllText(FI.FullName);

				padyam = padyam.Replace(Environment.NewLine + Environment.NewLine, Environment.NewLine);
				Regex regex = new Regex(@"[0-9\-]+", RegexOptions.Multiline);

				Match match = regex.Match(padyam.Replace("-" + Environment.NewLine, ""));
				string chapter = match.Value;
				if (chapter.Length == 1)
				{
					throw new Exception("ERRR");
				}
				padyam = regex.Replace(padyam, "");
				regex = new Regex(@"\(.*\)", RegexOptions.Multiline);
				padyam = regex.Replace(padyam, "");

				List<int> Matras = CalcMatras(padyam);
				List<int> Matras2 = TwoRowsAsSingle(Matras);



				Record(r1, FI.Name, chapter, Matras);
				Record(r2, FI.Name, chapter, Matras2);

			}

		}

		private static List<int> TwoRowsAsSingle(List<int> Matras)
		{
			//if (Matras.Count % 2 != 0)
			//{
			//    throw new Exception("Not even");
			//}

			List<int> Matras2 = new List<int>();
			int curr = 1; int tot = 0;
			foreach (int m in Matras)
			{
				tot = tot + m;
				if (curr % 2 == 0)
				{
					Matras2.Add(tot);
					tot = 0;
				}
				curr++;
			}

			if (tot != 0)
			{
				Matras2.Add(tot);
				// throw new Exception("Error");
			}
			return Matras2;
		}

		private static void Record(string r1, string Name, string chapter, List<int> Matras)
		{

			if (!new FileInfo(r1).Exists)
			{
				StreamWriter SW = new StreamWriter(r1, false, Encoding.UTF8);
				SW.WriteLine("File Name,Chapter,No,Total Lines,L1,L2,L3,L4,L5,L6,L7,L8");
				SW.Close();
			}
			else
			{


				//string[] s = chapter.Split('-');
				//if (s[0].Length == 0 || s[1].Length == 0)
				//{
				//    throw new Exception("EEEE");
				//}
				string[] s = Name.Split('-');
				StreamWriter SW = new StreamWriter(r1, true, Encoding.UTF8);
				//SW.Write(Name + "," + s[0] + ","+s[1].Replace(".txt","")+","+Matras.Count+",");
				SW.Write(Name + "," + chapter + "," + s[1].Replace(".txt", "") + "," + Matras.Count + ",");
				foreach (int matra in Matras)
				{
					SW.Write(matra + ",");
				}
				SW.WriteLine("");
				SW.Close();
			}

		}
	}


	public class AnnamayaChandam : Rule
	{
		public AnnamayaChandam()
		{

			Lines = 2;
			Threshold = 100;


			Name = "అన్నమయఛందం";
			Identifier = "annamayaChandam";



			PadyamType = PadyamType.Jati;
			PadyamSubType = PadyamSubType.Ragada;
			RuleType = RuleType.Weight;
			YatiMode = YatiMode.GPosition;



			Rules = new object[][] { new object[] { 100 } };
			Yati = new int[][] { new int[] { } };

			Prasa = false;
			PrasaYati = false;
			AnthyaPrasa = false;

		}
	}
}
