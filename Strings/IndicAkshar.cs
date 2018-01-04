//---------------------------------------------------------------------------------------------
// <copyright file="IndicAkshar.cs" company="Chandam-????">
//    Copyright © 2013 - 2018 'Chandam-????' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Util;

namespace Chandam.Indic
{
	public partial class IndicAkshar
	{
		protected IndicChar[] _ic;
		public IndicAkshar() { }
		public void SetChars(string s, iIndicCharSet ic)
		{
			_ic = new IndicChar[s.Length];
			char[] _ca = StringPlus.ToCharArray(s);
			for (int i = 0; i < s.Length; i++)
			{
				_ic[i] = ic.NewChar;
				_ic[i].BaseChar = _ca[i];
			}
		}
		public IndicChar[] Chars
		{
			get
			{
				return _ic;
			}
			set
			{
				_ic = value;
			}
		}
		public bool IsCompoundChar
		{
			get
			{
				try
				{

					//for (int i = 0; i < _ic.Length; i++)
					if (_ic.Length >= 3)
					{
						IndicChar P0 = _ic[0];
						IndicChar P1 = _ic[1];
						IndicChar P2 = _ic[2];
						return (P0.IsHallu && P1.IsPollu && P2.IsHallu);
						//if (Chr.IsHallu ) { c++; }

						//if (c > 1)
						//{
						//    return true;
						//}
					}

				}
				catch
				{

				}
				return false;
			}
		}
		public int Length
		{
			get
			{
				return _ic.Length;
			}
		}
		public string ToString2()
		{
			string s = "";
			foreach (IndicChar C in _ic)
			{
				s = s + C.ToString2();
			}
			return s;
			//return base.ToString2();
		}
		public override string ToString()
		{
			return this.ToString2();
		}
		public bool IsValid
		{
			get
			{
				try
				{
					for (int i = 0; i < _ic.Length; i++)
					{
						IndicChar Chr = _ic[i];
						if (!Chr.IsValid)
						{
							return false;
						}
					}
					return true;
				}
				catch
				{
				}
				return false;
			}
		}
	}
}