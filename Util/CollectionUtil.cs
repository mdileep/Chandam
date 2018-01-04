//---------------------------------------------------------------------------------------------
// <copyright file="CollectionUtil.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Chandam.Util
{
	public class CollectionUtil2
	{
		public static List<string> Distinct(List<string> C1)
		{

			if (C1.Count == 1)
			{
				return C1;
			}

			List<string> O = new List<string>();

			foreach (string x in C1)
			{
				if (!Exists(O, x))
				{
					O.Add(x);
				}
			}

			return O;
		}
		public static bool Exists(List<string> O, string x)
		{
			foreach (string y in O)
			{
				if (x == y)
				{
					return true;
				}
			}
			return false;
		}
	}
}