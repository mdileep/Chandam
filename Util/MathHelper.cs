//---------------------------------------------------------------------------------------------
// <copyright file="MathHelper.cs" company="Chandam-ఛందం">
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

namespace Chandam.Util
{
	public class MathHelper
	{
		public static int Ceil(double c)
		{
			return (int)Math.Ceiling(c);
		}
		public static int Floor(double c)
		{
			return (int)Math.Floor(c);
		}
	}
}

