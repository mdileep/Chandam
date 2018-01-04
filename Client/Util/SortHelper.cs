//---------------------------------------------------------------------------------------------
// <copyright file="SortHelper.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:38EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;


namespace Chandam.Rules
{

	public partial class SortHelper
	{
		public static Rule[] SortByCharLength(Rule[] D)
		{
			Array r = D.Slice(0);
			r.Sort(delegate (object r1, object r2)
			{
				Rule R1 = ((Rule)r1);
				Rule R2 = ((Rule)r2);

				int l1 = R1.CharLength;
				int l2 = R2.CharLength;

				return l1 < l2 ? -1 : l1 > l2 ? 1 : 0;

			});

			return (Rule[])r;
		}

		public static Rule[] SortByName(Rule[] D)
		{
			Array r = D.Slice(0);
			r.Sort(delegate (object r1, object r2)
			{
				int p = 0;

				Rule R1 = ((Rule)r1);
				Rule R2 = ((Rule)r2);

				int l1 = R1.Name.CharCodeAt(p);
				int l2 = R2.Name.CharCodeAt(p);
				p++;
				while (l1 == l2 && p <= R1.Name.Length && p <= R2.Name.Length)
				{
					l1 = R1.Name.CharCodeAt(p);
					l2 = R2.Name.CharCodeAt(p);
					p++;
				}

				return l1 < l2 ? -1 : l1 > l2 ? 1 : 0;

			});

			return (Rule[])r;
		}
	}

}
