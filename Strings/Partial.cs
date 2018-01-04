//---------------------------------------------------------------------------------------------
// <copyright file="Partial.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Indic
{

	//public partial class IndicParser
	//{
	//    public IndicParser(iIndicCharSet ICS) { _ic = ICS; }
	//}
	public partial class IndicChar
	{
		public IndicChar(iIndicCharSet CharSet, char C)
		{
			_Char = C; _cs = CharSet;
		}
	}
	public partial class TeluguAksharam
	{
		public TeluguAksharam(IndicChar[] C) { _ic = C; }
		public TeluguAksharam(IndicChar C) { _ic = new IndicChar[] { C }; }
		public TeluguAksharam(IndicAkshar C) { this.Chars = C.Chars; }
	}
	public partial class IndicAkshar
	{
		public IndicAkshar(IndicChar ic)
		{
			_ic = new IndicChar[] { ic };
		}

		public IndicAkshar(string s, iIndicCharSet cs)
		{
			SetChars(s, cs);
		}

		public IndicAkshar(IndicChar[] ic)
		{
			_ic = ic;
		}

	}
}
