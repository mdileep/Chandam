//---------------------------------------------------------------------------------------------
// <copyright file="IndicAkshar2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;


namespace Chandam.Indic
{
	public class Symbols
	{
		public const string GURUVU = "U";
		public const string LAGHUVU = "|";
	}

	public partial class IndicAkshar
	{
		private bool _alwaysGuruvu;
		private bool _reph;
		private bool _ChangePrev = false;
		public bool ChangePrev
		{
			get
			{
				return _ChangePrev;
			}
			private set
			{
				_ChangePrev = value;
			}
		}

		public bool AlwaysGuruvu
		{
			get
			{
				return _alwaysGuruvu;
			}
			private set
			{
				_alwaysGuruvu = value;
			}
		}

		public bool IsGuruvu { get { return CheckGuruvu(); } }
		public bool IsLaghuvu { get { return CheckLaghuvu(); } }
		public bool IsPolluEnder
		{
			get
			{
				try
				{
					char last = _ic[_ic.Length - 1].BaseChar;
					//char pollu = new TeluguCharSet().PolluSet;
					char pollu = _ic[_ic.Length - 1].CharSet.PolluSet;
					bool f = (last == pollu);
					if (f)
					{
						return true;
					}
					if (last == '‌' && _ic.Length - 2 >= 0 && _ic[_ic.Length - 2].BaseChar == pollu)
					{
						return true;
					}
					return false;
				}
				catch { return false; }
			}
		}

		private bool CheckLaghuvu()
		{
			return (GetSymbol() == Symbols.LAGHUVU);
		}

		private bool CheckGuruvu()
		{
			return (GetSymbol() == Symbols.GURUVU);
		}

		public bool RephEnable
		{
			get
			{
				return _reph;
			}
			set
			{
				_reph = value;
			}
		}

		private bool _CheckGuruvu()
		{
			try
			{
				int c = 0;
				foreach (IndicChar IC in _ic)
				{
					if (IC.IsPollu)
					{
						return true;
					}
					if (IC.IsHallu) { c++; }
					if (IC.IsSpecialFinishing) { AlwaysGuruvu = true; return true; }
					if (IC.IsLongFinishing) { AlwaysGuruvu = true; return true; }
					if (IC.IsLongAchchu) { AlwaysGuruvu = true; return true; }
					if (IC.IsStranger || IC.CanIgonre || IC.IsNumber || IC.IsNeutral) { throw new Exception("Not Applicable"); }
					if (c > 1)
					{
						return true;
					}
				}
			}
			catch { throw new Exception("I Can't Decide"); }
			return false;
		}

		public string GetSymbol()
		{
			try
			{
				//To be modified...
				int c = 0;
				string Symbol = "";
				#region When No items Return Balnk Symbol
				if (_ic.Length == 0)
				{
					Symbol = "";
					return Symbol;
				}
				#endregion

				#region Handle Single Achchu & Hallu.. Number, Stranger
				if (_ic.Length == 1)
				{
					if (_ic[0].IsNewLine)
					{
						return "\n";
					}
					if (_ic[0].IsSmallAchchu)
					{
						return Symbols.LAGHUVU;
					}
					if (_ic[0].IsLongAchchu)
					{
						return Symbols.GURUVU;
					}

					if (_ic[0].IsHallu)
					{
						return Symbols.LAGHUVU;
					}

					if (_ic[0].IsStranger || _ic[0].IsNumber)
					{
						Symbol = "?";
						return Symbol;
					}
				}
				#endregion

				#region More than One and  Has Special or Long Finishhing Return GURUVU  Can't determine whether it can change prec or not..
				if (_ic.Length == 2)
				{
					IndicChar Chr = _ic[1];
					if (Chr.IsSpecialFinishing || Chr.IsLongFinishing || Chr.IsLongAchchu)
					{
						AlwaysGuruvu = true;
						Symbol = Symbols.GURUVU;
						return Symbol;
					}
				}
				#endregion


				int p = 0;
				int lastPollu = -1;
				for (int i = 0; i < _ic.Length; i++)
				{
					IndicChar Chr = _ic[i];

					#region If Neutral Continue
					if (Chr.IsNeutral)
					{
						continue;
					}
					#endregion

					#region if Has Pollu Probable is GURUVU
					if (Chr.IsPollu)
					{
						Symbol = Symbols.GURUVU;
						p++;
						lastPollu = i;
						//return Symbol;
					}
					#endregion

					#region Count How many Hallu are there?
					if (Chr.IsHallu)
					{
						c++;
					}
					#endregion

					#region May be not part of Code Path Can be Removed later.
					if (Chr.IsStranger || Chr.IsNumber)
					{
						Symbol = "?";
						return Symbol;
					}
					if (Chr.IsSpecialFinishing)
					{
						ChangePrev = true;
						AlwaysGuruvu = true;
						if (RephEnable && lastPollu != -1 && this.Chars.Length > lastPollu + 1 && Chars[lastPollu + 1].BaseChar == Chr.CharSet.Reph)
						{
							ChangePrev = false;//Don't override if it's  'Reph'
						}
						Symbol = Symbols.GURUVU;
						return Symbol;
					}
					#endregion

					if (Chr.IsLongFinishing)
					{
						ChangePrev = true;
						AlwaysGuruvu = true;
						if (RephEnable && lastPollu != -1 && this.Chars.Length > lastPollu + 1 && Chars[lastPollu + 1].BaseChar == Chr.CharSet.Reph)
						{
							ChangePrev = false;//Don't override if it's  'Reph'
						}
						Symbol = Symbols.GURUVU;
						return Symbol;
					}

					if (Chr.IsLongAchchu)
					{
						ChangePrev = true;
						AlwaysGuruvu = true;
						if (RephEnable && lastPollu != -1 && this.Chars.Length > lastPollu + 1 && Chars[lastPollu + 1].BaseChar == Chr.CharSet.Reph)
						{
							ChangePrev = false;//Don't override if it's  'Reph'
						}
						Symbol = Symbols.GURUVU;
						return Symbol;
					}

					if (Chr.CanIgonre)
					{
						if (Chr.IsSpace)
						{
							Symbol = " ";
							return Symbol;
						}
						Symbol = "";
					}
				}

				#region if There are more than one Hallu then return LAGHUVU  Prev to be modified
				if (c > 1)
				{
					ChangePrev = true;//PrevChar Symbol will be overided
					if (RephEnable && lastPollu != -1 && this.Chars.Length > lastPollu + 1 && Chars[lastPollu + 1].BaseChar == Chars[lastPollu + 1].CharSet.Reph)
					{
						ChangePrev = false;//Don't override if it's  'Reph'
					}
					Symbol = Symbols.LAGHUVU;
					return Symbol;
				}
				#endregion

				if (!AlwaysGuruvu)
				{
					Symbol = Symbols.LAGHUVU;
					return Symbol;
				}
			}
			catch
			{
				return "?";
			}
			return Symbols.LAGHUVU;
		}
	}
}
