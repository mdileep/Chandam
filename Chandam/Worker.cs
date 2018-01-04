//---------------------------------------------------------------------------------------------
// <copyright file="Worker.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Library.Chandam.Samples;
using System;
using System.IO;
using System.Text;

namespace Chandam
{
	class Worker
	{
		public void Start(string config)
		{
			Extractor E = new Extractor(config);
			FileInfo FI = new FileInfo(E.Data);
			if (!FI.Exists)
			{
				Console.WriteLine("Skipping as not found - " + FI.FullName);
				return;
			}
			SatakamData SD = E.Extract();

			string data = Satakam.Build(SD, E.Options, E.OO);

			File.WriteAllText(E.Output, data, Encoding.UTF8);
		}
	}
}
