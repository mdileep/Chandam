//---------------------------------------------------------------------------------------------
// <copyright file="StringUtil2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;

namespace Library.String
{
	public partial class StringPlus
	{
		public static string TrimEnd(string s, char c)
		{
			return s.TrimEnd(c);
		}
		public static char[] ToCharArray(string s)
		{
			return s.ToCharArray();
		}
		public static char CharAt(string MatchString, int index)
		{
			return MatchString[index];
		}
	}
}
