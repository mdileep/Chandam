//---------------------------------------------------------------------------------------------
// <copyright file="IndicParser.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Util;
using System;


namespace Chandam.Indic
{
	public partial class IndicParser
	{
		iIndicCharSet _ic;

		public iIndicCharSet CharSet { get { return _ic; } set { _ic = value; } }

		public IndicParser()
		{

		}
		public IndicAkshar[] Split(string s)
		{
			IndicAkshar[] IA = null;
			try
			{
				string[] retVal = new string[s.Length];
				int cnt = 0;

				string lockedString = "";

				char lastChar = ' ';
				string lastCharNature = "a";
				bool released = false;
				for (int i = 0; i < s.Length; i++)
				{

					released = false;
					char currChar = StringPlus.CharAt(s, i);

					IndicChar I = _ic.NewChar;
					I.CharSet = CharSet;
					I.BaseChar = currChar;

					if (currChar == this.CharSet.Special2)
					{
						if (cnt >= 1)
						{
							retVal[cnt - 1] = retVal[cnt - 1] + currChar;
							continue;
						}
					}


					string currCharNature = I.CharNature;
					bool CanIRelase = CanRelease(currCharNature, lastCharNature);

					if (CanIRelase)
					{
						bool CanImmRelase = IsImmRelease(currCharNature);
						if (CanImmRelase)
						{
							if (lockedString != "")
							{
								retVal[cnt++] = lockedString;
							}
							lockedString = currChar.ToString();
							released = false;
						}
						else
						{
							#region NotImmRElease
							if (I.IsSpecialFinishing || I.IsNeutral)
							{
								#region SpecialCharFinishing
								if (lockedString == "")
								{
									try
									{
										retVal[cnt - 1] = retVal[cnt - 1] + lockedString + currChar;
									}
									catch
									{
										throw new Exception("Invalid Lang Char ");
									}

								}
								else
								{
									retVal[cnt++] = lockedString + currChar;
								}
								#endregion

							}
							else
							{
								if (!I.CanIgonre)
								{
									lockedString = lockedString + currChar;
									if (lockedString != "")
									{
										retVal[cnt++] = lockedString;
									}
								}
								else
								{
									if (lockedString != "")
									{
										retVal[cnt++] = lockedString;
									}
									retVal[cnt++] = currChar.ToString();
								}
							}
							lockedString = "";
							released = true;
							#endregion
						}
						lastChar = ' ';
						lastCharNature = currCharNature;

					}

					else
					{
						lastChar = currChar;
						lockedString = lockedString + currChar;
						lastCharNature = currCharNature;
					}
				}
				if (!released)
				{
					retVal[cnt++] = lockedString;
				}

				IA = new IndicAkshar[cnt];
				for (int i = 0; i < cnt; i++)
				{

					IA[i] = new IndicAkshar();
					IA[i].SetChars(retVal[i], this.CharSet);

				}

			}
			catch
			{

			}
			return IA;
		}
		private bool CanRelease(string CN, string PN)
		{
			bool res = false;
			if (CN == "a" || CN == "e")//a A e E
			{
				res = true;
			}

			if (CN == "s" || CN == "l") //kaa ka ki kI
			{
				res = true;
			}
			if (CN == "o") { res = true; }
			if (CN == "p") { res = false; }
			if (CN == "h" && PN == "h")
			{
				res = true;
			}
			if (PN == "y" || PN == "z" || PN == "n" || PN == "x") { res = true; }
			if (CN == "y" || CN == "z" || CN == "n" || CN == "x") { res = true; }

			if (CN == "h" && (PN == "a" || PN == "e"))
			{
				res = true;
			}
			return res;
		}
		private bool IsImmRelease(string CN)
		{

			bool res = false;
			if (CN == "h")
			{
				res = true;
			}
			if (CN == "a")
			{
				res = true;
			}
			if (CN == "e")
			{
				res = true;
			}
			if (CN == "x")
			{
				res = true;
			}

			if (CN == "p") { res = false; }

			return res;
		}

	}
}