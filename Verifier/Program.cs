//---------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;

//Known Issues:
//1.Try a kavirajaviraajitam  with a line that has less gana in no.
//2.For the same  yati matching y1,y2,y3,y4==> y1 & y2 and y3 & y4 are groups.
namespace Verifier
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Title = "Chandam-Verifier";
			StopWatch G = new StopWatch();
			G.Start();
			try
			{
				StopWatch S = new StopWatch();
				S.Start();

				const string root = @"C:\Working\Chandam\Web\js\";
				new GenerateRulesJS(root).Go();

				//new Chandassu().BuildNotes();
				//new ExtractServerData().Dump();
				//new Chandassu().Analysis();
				//new Vruttam2Jati().Go();
				//new Jati2Vruttam2().Go();
				//new Jati2Vruttam2().Go3();
				//new PlayGround().Play();
				//new Seq2Music().Go();

				S.Reset();
			}
			catch (Exception ex)
			{

				Console.WriteLine(ex.Message);
				Console.ReadKey();
			}

			Console.WriteLine("----------------------------------");
			G.Reset();
			Console.WriteLine("----------------DONE--------------");
			Console.Write("Press any Key to Exit.....");
			Console.ReadKey();
			//Console.Beep ( );
		}
	}

}




//StreamWriter SW = new StreamWriter("ExampleStats.txt", false, Encoding.UTF8);
//List<Rule> Rules=RuleHelper.GetAllRules(true);
//foreach (Rule R in Rules)
//{
//    SW.WriteLine(R.ShortName + "," + R.ChandamName + "(" + R.CharLength + ")" + "," + R.Examples.Length + "," + Helper.GetPadyamTypeString(R.PadyamType, R.PadyamSubType));
//}

//SW.Close();
//string s = Converter.Convert(File.ReadAllText(@"Telugu.txt", Encoding.UTF8), Indic.Language.Telugu, Indic.Language.DevaNagari);
//File.WriteAllText(@"Hindi.txt", s, Encoding.UTF8);
//string s = "పీడి౦తు";
//Debug.WriteLine(s.Length);

//IndicParser P = new IndicParser(new DevanagariCharSet());
//IndicAkshar[] A = P.Split("(हिन्दी),");
//foreach (IndicAkshar a in A)
//{
//    Debug.WriteLine(a.ToString());
//}

//new DBWorker().DumpMeanings();
//string s=Converter.Convert(File.ReadAllText(@"D:\Working\Chandam\Strings\TeluguBase\TeluguCharSet.cs",Encoding.UTF8),Indic.Language.Telugu,Indic.Language.Kannda);
//File.WriteAllText(@"D:\Working\Chandam\Strings\KannadaBase\KannadaCharSet.cs", s,Encoding.UTF8);

//Annamaya.Mallina();
//Annamaya.Go();
//Annamaya.CalcMatras2();
//Annamaya.BuildDict3();
//new DBWorker().Go ( );
//new DBWorker ( ).GenerateXmls ( );
//SELECT id,first FROM potana.names;

//string insert="insert into names(first,id) values("SSSSS','12')";
//MySqlConnection conn=Connection.GetConnection2 ( ) ;
//conn.Open ( );
//DBUtil.ExecuteNonQuery2 ( insert , null , "potana" ,conn , null );
//conn.Close ( );


//	Downloads.All ( );
//SearchCriteria SC= new SearchCriteria ( );
//SC.CharLength = 0;
//SC.IncludeSans = false;
//SC.MatraLength = 0;
//SC.MatraSreni = "";
//SC.NameLike = "ఆ";
//SC.PadyamType = PadyamType.Unspecified;

//Rule[] R=Helper.GetRules7 ( SC );
//Console.WriteLine ( R.Length );

#region...
//string dir=@"D:\Working\Chandam\Verifier\bin\Debug\11-Apr-14";
//new Worker ( ).Dump2 ( dir + "\\PotanaExtras2.xlsx" );
//new Worker ( ).Verify3 (dir );
//new Worker ( ).ExtractYati ( );
//new Worker ( ).VerifyYati ( );
#endregion