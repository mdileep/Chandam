//---------------------------------------------------------------------------------------------
// <copyright file="Seq2BinaryMusic.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using System;
using System.Collections.Generic;
using System.IO;

namespace Verifier
{
	class Seq2BinaryMusic
	{
		public void Go()
		{
			Rule[] TelRules = Manager.Rules();
			foreach (Rule R in TelRules)
			{
				if (R.Sequence == "")
				{
					continue;
				}
				Console.WriteLine(R.Identifier);
				Go(R.Sequence, R.Identifier + "(" + R.Sequence.Replace("|", "I") + ")", "Music\\" + R.Identifier + ".mp3");
			}
			Go("IU-IU-IU-IU-IU-IU-IU-IU-IU", "Random", "Music\\test.mp3");
			//This music composition done by a Machine to demonstrates how the Chandassu(Indian Metrical Poetry) sequences can be composed to Tablar and Tabla Beats.  Visit http://chandam.apphb.com  and http://chandassu.org
		}

		public void Go(string seq, string Title, string output)
		{
			////http://www.tablaradio.com/

			//8 Beat Kaharwa 
			//8 Beat Bhajani
			//16 Beat Teentaal

			//7 Beat Roopak
			//14 Beat Deepchandi 

			//6 Beat Dadra 
			//12 Beats Ektaal

			//10 Beat Jhaptaal 


			List<string> Files = new List<string>();
			Files.Add(@"tabla\chimes.mp3");
			foreach (char s in seq)
			{
				switch (s)
				{
					case '|':
					case 'I':
						Files.Add(@"tabla\tablar3.mp3");
						//Files.Add(@"tabla\mp3\Dadra-Beats-3.mp3");
						break;
					case 'U':
						//Files.Add(@"tabla\mp3\tablal2.mp3");
						Files.Add(@"tabla\mp3\Dadra-Beats-2.mp3");
						break;
				}
			}
			Files.Add(@"tabla\chimes.mp3");

			if (!new FileInfo(output).Directory.Exists)
			{
				new FileInfo(output).Directory.Create();
			}
			Stream Output = new StreamWriter(output).BaseStream;
			CombineMP3.Combine(@"tabla\inject.bin", String.Format("Beats of {0} Chandassu", Title), Files.ToArray(), Output);
			Output.Close();

		}
	}
}
