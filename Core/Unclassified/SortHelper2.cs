//---------------------------------------------------------------------------------------------
// <copyright file="SortHelper2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Chandam.Core
{
	public partial class SortHelper2
	{
		public static List<MatchResult> Top(List<MatchResult> L)
		{
			L.Sort(delegate (MatchResult a, MatchResult b)
			{
				return b.Percentage.CompareTo(a.Percentage);
			});
			return L;
		}
	}
}
