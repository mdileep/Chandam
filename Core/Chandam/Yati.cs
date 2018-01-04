//---------------------------------------------------------------------------------------------
// <copyright file="Yati.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Chandam.Core
{
	public class Yati
	{
		public string P1;
		public string PY1;
		public string YC;
		public List<string> P2;
		public List<string> PrasaYati;
		public List<string> PrevContext;

		public Yati()
		{
			P2 = new List<string>();
			Positions = new List<int>();
			PrasaYati = new List<string>();
			PrevContext = new List<string>();
		}
		public List<int> Positions;

	}
}
