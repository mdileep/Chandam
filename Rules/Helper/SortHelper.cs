//---------------------------------------------------------------------------------------------
// <copyright file="SortHelper.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:35EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;


namespace Chandam.Rules
{
	public partial class SortHelper
	{
		public static Rule[] SortByName(Rule[] D)
		{
			List<Rule> Rules = new List<Rule>();
			Rules.AddRange(D);
			return SortByName2(Rules);
		}
		private static Rule[] SortByName2(List<Rule> L)
		{
			L.Sort(delegate (Rule a, Rule b)
		  {
			  return a.Name.CompareTo(b.Name);
		  });

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;
		}
		public static Rule[] SortByCharLength(List<Rule> L)
		{
			L.Sort(delegate (Rule a, Rule b)
		  {
			  return a.CharLength.CompareTo(b.CharLength);
		  });

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;
		}
	}
}
