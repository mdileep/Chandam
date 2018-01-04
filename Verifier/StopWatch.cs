//---------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Chandam-ఛందం">
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
using System.Threading;

namespace Verifier
{
	public class Music
	{



		public void Play()
		{
			int[] W = new int[]{523,
554,
587,
623,
656,
698,
734,
784,
831,
880,
932,
988};
			foreach (int w in W)
			{
				Console.Beep(w, 125 * 3);
				Thread.Sleep(60);
			}
		}
	}
	public class YatiGroups
	{
		public string y1;
		public string y2;

		public string Context
		{
			get;
			set;
		}
	}
	public class StopWatch
	{
		DateTime st;
		public void Start()
		{
			st = DateTime.Now;

		}
		public void Reset()
		{
			Console.WriteLine("Time taken (in Min):  " + (DateTime.Now - st).TotalMinutes.ToString("0.00"));
			st = DateTime.Now;
		}
	}
	public class _X
	{

		#region No Longer Valid
		//Console.Title = "Chandam-Minfier";
		//using(StreamWriter SW= new StreamWriter ( @"D:\Working\Chandam\Web\JS\minified.js",false, Encoding.UTF8))
		//{
		//    SW.Write(File.ReadAllText(@"D:\Working\Chandam\Web\JS\minified.template.js",Encoding.UTF8));
		//    SW.Write(File.ReadAllText(@"D:\Working\Chandam\Web\JS\MiriyamLib.min.js",Encoding.UTF8));
		//    SW.WriteLine(";");
		//    SW.Write(File.ReadAllText(@"D:\Working\Chandam\Web\JS\MiriyamApp.min.js",Encoding.UTF8));
		//    SW.WriteLine(";");
		//}


		//new MSeries ( ).Go ( );

		//new Sans ( ).Go ( );


		//string file="Chandam";

		//string htmlFile= file + ".html";
		//string s=SatakamData.EvaluateAllRules ( htmlFile );
		#endregion

		//Serialise ( "k.xml" , new kandam ( ) );
		//public static void Serialise (string file , Rule R)
		//{
		//    FileInfo FI= new FileInfo ( file );
		//    if ( !FI.Directory.Exists )
		//    {
		//        FI.Directory.Create ( );
		//    }

		//    XmlTextWriter w = new XmlTextWriter ( file , Encoding.UTF8 );
		//    w.Formatting = Formatting.Indented;
		//    w.WriteStartElement ( "Rule" );

		//    w.WriteAttributeString ( "Identifier" , R.Identifier );
		//    w.WriteAttributeString ( "Lines" , R.Lines.ToString ( ) );
		//    w.WriteAttributeString ( "Type" , R.PadyamType.ToString ( ) );

		//    if ( R.PadyamSubType != PadyamSubType.Other )
		//    {
		//        w.WriteAttributeString ( "SubType" , R.PadyamSubType.ToString ( ) );
		//    }
		//    if ( R.PadyamSubType != PadyamSubType.Other )
		//    {
		//        w.WriteAttributeString ( "SubType" , R.PadyamSubType.ToString ( ) );
		//    }

		//    w.WriteAttributeString ( "RuleType" , R.RuleType.ToString ( ) );

		//    if ( R.RowWiseRules )
		//    {
		//        string s ="";
		//        for ( int i=0 ; i < R.Rules.Length ; i++ )
		//        {
		//            object[] LineRule =R.Rules[i];
		//            s = s + GetPadamRuleText ( R.RuleType , LineRule );
		//        }
		//    }
		//    else
		//    {
		//        string s = GetPadamRuleText ( R.RuleType , R.Rules[0] );
		//    }


		//    w.WriteStartElement ( "RuleText" );
		//    w.WriteCData ( R.RuleText );
		//    w.WriteEndElement ( );

		//    w.WriteStartElement ( "Name" );
		//    w.WriteValue ( R.Name );
		//    w.WriteEndElement ( );

		//    w.WriteStartElement ( "ShortName" );
		//    w.WriteValue ( R.ShortName );
		//    w.WriteEndElement ( );


		////    if ( R.References != null && R.References.Length > 0 )
		////    {
		////        w.WriteStartElement ( "References" );
		////        foreach ( string s in R.References )
		////        {
		////            w.WriteStartElement ( "Reference" );
		////            w.WriteCData ( s );
		////            w.WriteEndElement ( );
		////        }
		////        w.WriteEndElement ( );
		////    }

		////    if ( R.Examples.Length > 0 )
		////    {
		////        w.WriteStartElement ( "Samples" );
		////        foreach ( string s in R.Examples )
		////        {
		////            w.WriteStartElement ( "Sample" );
		////            w.WriteCData ( s );
		////            w.WriteEndElement ( );
		////        }
		////        w.WriteEndElement ( );
		////    }


		////    w.WriteEndElement ( );


		////    w.Close ( );
		////}

		//Console.Beep ( 658 , 125 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 990 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1188 , 250 );
		//                Console.Beep ( 1320 , 125 );
		//                Console.Beep ( 1188 , 125 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 990 , 250 );
		//                Console.Beep ( 880 , 500 );
		//                Console.Beep ( 880 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1188 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 990 , 750 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1188 , 500 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1056 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Thread.Sleep ( 250 );
		//                Console.Beep ( 1188 , 500 );
		//                Console.Beep ( 1408 , 250 );
		//                Console.Beep ( 1760 , 500 );
		//                Console.Beep ( 1584 , 250 );
		//                Console.Beep ( 1408 , 250 );
		//                Console.Beep ( 1320 , 750 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1188 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 990 , 500 );
		//                Console.Beep ( 990 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1188 , 500 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1056 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Thread.Sleep ( 500 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 990 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1188 , 250 );
		//                Console.Beep ( 1320 , 125 );
		//                Console.Beep ( 1188 , 125 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 990 , 250 );
		//                Console.Beep ( 880 , 500 );
		//                Console.Beep ( 880 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1188 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 990 , 750 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1188 , 500 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1056 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Thread.Sleep ( 250 );
		//                Console.Beep ( 1188 , 500 );
		//                Console.Beep ( 1408 , 250 );
		//                Console.Beep ( 1760 , 500 );
		//                Console.Beep ( 1584 , 250 );
		//                Console.Beep ( 1408 , 250 );
		//                Console.Beep ( 1320 , 750 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1188 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 990 , 500 );
		//                Console.Beep ( 990 , 250 );
		//                Console.Beep ( 1056 , 250 );
		//                Console.Beep ( 1188 , 500 );
		//                Console.Beep ( 1320 , 500 );
		//                Console.Beep ( 1056 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Console.Beep ( 880 , 500 );
		//                Thread.Sleep ( 500 );
		//                Console.Beep ( 660 , 1000 );
		//                Console.Beep ( 528 , 1000 );
		//                Console.Beep ( 594 , 1000 );
		//                Console.Beep ( 495 , 1000 );
		//                Console.Beep ( 528 , 1000 );
		//                Console.Beep ( 440 , 1000 );
		//                Console.Beep ( 419 , 1000 );
		//                Console.Beep ( 495 , 1000 );
		//                Console.Beep ( 660 , 1000 );
		//                Console.Beep ( 528 , 1000 );
		//                Console.Beep ( 594 , 1000 );
		//                Console.Beep ( 495 , 1000 );
		//                Console.Beep ( 528 , 500 );
		//                Console.Beep ( 660 , 500 );
		//                Console.Beep ( 880 , 1000 );
		//                Console.Beep ( 838 , 2000 );
		//                Console.Beep ( 660 , 1000 );
		//                Console.Beep ( 528 , 1000 );
		//                Console.Beep ( 594 , 1000 );
		//                Console.Beep ( 495 , 1000 );
		//                Console.Beep ( 528 , 1000 );
		//                Console.Beep ( 440 , 1000 );
		//                Console.Beep ( 419 , 1000 );
		//                Console.Beep ( 495 , 1000 );
		//                Console.Beep ( 660 , 1000 );
		//                Console.Beep ( 528 , 1000 );
		//                Console.Beep ( 594 , 1000 );
		//                Console.Beep ( 495 , 1000 );
		//                Console.Beep ( 528 , 500 );
		//                Console.Beep ( 660 , 500 );
		//                Console.Beep ( 880 , 1000 );
		//                Console.Beep ( 838 , 2000 );
	}
}
