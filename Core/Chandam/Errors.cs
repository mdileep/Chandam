//---------------------------------------------------------------------------------------------
// <copyright file="Errors.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;


namespace Chandam.Core
{
	public class Errors
	{
		string _Expected;
		string _Actual;
		int _line;
		Mismatch R;
		int _Position;
		public int Position
		{
			get
			{
				return _Position;
			}
			set
			{
				_Position = value;
			}
		}
		public Mismatch Mismatch
		{
			get
			{
				return R;
			}
			set
			{
				R = value;
			}
		}

		public int Line
		{
			set
			{
				_line = value;
			}
			get
			{
				return _line;
			}
		}
		public string Expected
		{
			get
			{
				return _Expected;
			}
			set
			{
				_Expected = value;
			}
		}
		public string Actual
		{
			get
			{
				return _Actual;
			}
			set
			{
				_Actual = value;
			}
		}


		private string remarks;

		public string Remarks
		{
			get
			{
				return remarks;
			}
			set
			{
				remarks = value;
			}
		}
	}
}
