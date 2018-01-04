//---------------------------------------------------------------------------------------------
// <copyright file="StringUtil.cs" company="Chandam-ఛందం">
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
	//Aligning C# For Script#
	public partial class StringPlus
	{

		public static bool Contains(string MatchString, string compare)
		{
			return (MatchString.IndexOf(compare) >= 0);
		}

		public static bool IsMatched(string s2, int index, char match)
		{
			return (StringPlus.CharAt(s2, 0) == match);
		}

		public static bool EndsWith(string s, char c)
		{
			return CharAt(s, s.Length - 1) == c;
		}

		public static bool StartsWith(string s, char c)
		{
			return CharAt(s, 0) == c;
		}
	}
}
