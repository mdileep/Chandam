//---------------------------------------------------------------------------------------------
// <copyright file="SamplePoems.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Samples
{
	public static class SamplePoems
	{
		private static string[] _Poems;

		public static string[] Poems
		{
			get { return _Poems; }
		}

		public static string GetItem(int i)
		{
			return i > 0 && i < Poems.Length ? Poems[i] : Poems[0];
		}

		public static void Append(string[] Items)
		{
			if (Items == null || Items.Length == 0)
			{
				return;
			}
			if (_Poems == null)
			{
				_Poems = new string[] { };
			}
			string[] S = new string[_Poems.Length + Items.Length];
			for (int i = 0; i < _Poems.Length; i++)
			{
				S[i] = _Poems[i];
			}
			for (int i = 0; i < Items.Length; i++)
			{
				S[i + _Poems.Length] = Items[i];
			}
			_Poems = S;
		}
	}


}