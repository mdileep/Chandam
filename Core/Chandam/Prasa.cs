//---------------------------------------------------------------------------------------------
// <copyright file="Prasa.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Core
{
	public class Prasa
	{
		private string _Symbol;
		public string Symbol
		{
			get
			{
				return _Symbol;
			}
			set
			{
				_Symbol = value;
			}
		}
		private string _Poorva;
		public string Poorva
		{
			get
			{
				return _Poorva;
			}
			set
			{
				_Poorva = value;
			}
		}
		private string _Value;
		public string Value
		{
			get
			{
				return _Value;
			}
			set
			{
				_Value = value;
			}
		}


		private bool _f;
		public bool IsAnthyaPrasa
		{
			get
			{
				return _f;
			}
			set
			{
				_f = value;
			}
		}

		public Prasa(string PoorvaSymbol, bool isAnthyaPrasa, string val, string PoorvaVal)
		{
			Symbol = PoorvaSymbol;
			IsAnthyaPrasa = isAnthyaPrasa;
			Value = val;
			Poorva = PoorvaVal;
		}
	}
}
