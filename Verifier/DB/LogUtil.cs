using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Framework.Utilities
{
	public class LogUtil
	{
		internal static void LogError (Exception ex , string select)
		{
			Console.WriteLine ( ex.Message );
			//TDO...
		}
	}
}
