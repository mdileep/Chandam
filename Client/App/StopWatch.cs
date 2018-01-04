//---------------------------------------------------------------------------------------------
// <copyright file="StopWatch.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Html;

namespace MiriyamApp
{
	public class StopWatch
	{
		static Date _Start;
		static int lastTicks;

		public static void Start()
		{
			_Start = new Date();
		}

		public static void ShowTicks(bool reset)
		{

			if (_Start == null)
				return;

			int sec = (new Date() - _Start);

			lastTicks = sec;

			if (reset)
			{
				_Start = null;
			}

			string res = (sec < 1000) ? sec + " మిల్లీ సెకన్లు" : (sec / (1000.0) + " సెకన్లు");
			Window.Document.GetElementById("timeTaken").InnerHTML = res;
		}
		public static int LastTicks
		{
			get
			{
				return lastTicks;
			}
		}


	}
}
