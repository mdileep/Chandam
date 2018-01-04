//---------------------------------------------------------------------------------------------
// <copyright file="Debug.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Util
{
	public class Debug2
	{
		public static void Write(string s)
		{
			System.Diagnostics.Debug.Write(s);
		}

		public static void AppendLine(string s)
		{
			System.Diagnostics.Debug.WriteLine(s);
		}
	}
}
