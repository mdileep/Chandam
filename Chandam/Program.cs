//---------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:38EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;

namespace Chandam
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ForegroundColor = ConsoleColor.White;
			Console.Title = "Chandam © - ఛందం";
			StopWatch G = new StopWatch();
			G.Start();
			try
			{


				new Worker().Start(args.Length > 0 ? args[0] : "config.ini");


			}
			catch (Exception ex)
			{
				Console.WriteLine("Something Went wrong  sorry for the trouble.\nDetails:");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(ex.Message);
				Console.ForegroundColor = ConsoleColor.White;
			}


			Console.WriteLine("\n----------------------------------");
			G.Reset();

			//Console.Write("Press any key to enter...");
			//Console.ReadKey();
		}
	}
}
