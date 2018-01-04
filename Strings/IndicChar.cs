//---------------------------------------------------------------------------------------------
// <copyright file="IndicChar.cs" company="Chandam-????">
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

	public partial class IndicChar
	{
		public string ToString2()
		{
			return _Char.ToString();
			//return base.ToString2();
		}

		private char _Char;
		public char BaseChar { get { return _Char; } set { _Char = value; } }
		private iIndicCharSet _cs;
		public iIndicCharSet CharSet { get { return _cs; } set { _cs = value; } }
		public IndicChar(iIndicCharSet cs)
		{
			_cs = cs;
		}

		public bool IsSpecialFinishing
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.SpecialFinishSet;
				//ret = MatchString.Contains(Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}
		}

		public bool IsLongFinishing
		{
			get
			{
				bool ret = false;
				if (!IsSpecialFinishing && !IsSmallFinishing && IsFinishing) { ret = true; }
				return ret;

			}
		}
		public bool IsPollu
		{
			get
			{
				bool ret = false;

				//ret = MatchString.Contains(Char.ToString2());
				//ret = StringPlus.Contains(MatchString, _Char.ToString());
				ret = (CharSet.PolluSet == _Char);
				return ret;
			}
		}
		public bool IsSmallFinishing
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.SmallFinishingSet;
				//ret = MatchString.Contains(Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}
		}
		public bool IsNeutral
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.NeutralSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}
		}
		public bool IsFinishing
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.FinishingSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}
		}
		public bool IsHallu
		{

			get
			{
				bool ret = false;
				string MatchString = CharSet.HalluSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}
		}
		public bool IsAchchu
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.AchchuSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}

		}
		public bool IsSmallAchchu
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.SmallAchchuSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}
		}
		public bool IsLongAchchu
		{
			get
			{
				bool ret = false;
				if (IsAchchu) { if (!IsSmallAchchu) { ret = true; } }
				return ret;
			}
		}
		public string CharNature
		{
			get
			{
				string ret = "x";
				if (CanIgonre) { ret = "y"; return ret; }
				if (IsSmallAchchu) { ret = "a"; return ret; }
				if (IsLongAchchu) { ret = "e"; return ret; }
				if (IsHallu) { ret = "h"; return ret; }
				if (IsPollu) { ret = "p"; return ret; }
				if (IsSpecialFinishing) { ret = "o"; return ret; }
				if (IsSmallFinishing) { ret = "s"; return ret; }
				if (IsLongFinishing) { ret = "l"; return ret; }
				if (IsNeutral) { ret = "z"; return ret; }
				if (IsNumber) { ret = "n"; return ret; }
				if (IsSpace) { ret = "y"; return ret; }
				return ret;
			}
		}
		public bool IsNumber
		{
			get
			{

				bool ret = false;
				string MatchString = CharSet.NumberSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;

			}
		}
		public bool IsSpace
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.SapceSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}

		}
		public bool IsNewLine
		{
			get
			{
				bool ret = false;
				string MatchString = CharSet.NewLineSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;
			}

		}
		public bool IsStranger
		{
			get { return (CharNature == "x") ? true : false; }
		}
		public bool CanIgonre
		{

			get
			{
				bool ret = false;
				string MatchString = CharSet.IgnoreSet;
				//ret = MatchString.Contains(_Char.ToString2());
				ret = StringPlus.Contains(MatchString, _Char.ToString());
				return ret;

			}

		}
		public bool IsValid { get { return !IsStranger; } }

	}
}