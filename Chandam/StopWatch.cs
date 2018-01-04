//---------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;

namespace Chandam
{
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
}
