//---------------------------------------------------------------------------------------------
// <copyright file="StringUtil2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:38EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Util
{
	public partial class StringPlus
	{
		public static string TrimEnd(string s, char c)
		{
			string s2 = s;
			while (s2.EndsWith(c))
			{
				s2 = s2.Substring(0, s2.Length - 1);
			}
			return s2;
		}

		public static char[] ToCharArray(string s)
		{
			char[] c = new char[s.Length];
			for (int i = 0; i < c.Length; i++)
			{
				c[i] = s.CharAt(i);
			}
			return c;
		}

		public static char CharAt(string MatchString, int index)
		{
			return MatchString.CharAt(index);
		}

		public static string SubString(string s, int startIndex, int length)
		{
			return s.Substr(startIndex, length);
		}
	}
}
