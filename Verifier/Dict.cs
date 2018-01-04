//---------------------------------------------------------------------------------------------
// <copyright file="Dict.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:10EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Verifier
{
	public enum Lang
	{
		Hindi,
		English,
		Telugu,
		Quotes
	}

	public class Dict
	{

		internal static void BuildDict3()
		{
			string[] Lines = File.ReadAllLines("3dict.txt", Encoding.Unicode);
			int cnt = 1;
			List<string> Final = new List<string>();
			foreach (string Line in Lines)
			{
				string t = "";
				string e = "";
				string h = "";

				char lc = ' ';
				Lang last = Lang.Quotes;
				foreach (char c in Line)
				{
					if (c == '.') continue;
					int ci = (int)c;

					Lang Curr = FindLang(ci);
					if (Curr == Lang.Quotes)
					{
						switch (last)
						{
							case Lang.English:
								e = e + c;
								break;
							case Lang.Hindi:
								h = h + c;
								break;
							case Lang.Telugu:
								t = t + c;
								break;
						}
					}
					else
					{
						switch (Curr)
						{
							case Lang.English:
								e = e + c;
								break;
							case Lang.Hindi:
								h = h + c;
								break;
							case Lang.Telugu:
								t = t + c;
								break;
						}
					}
					lc = c;
					last = Curr;
				}
				if (t == "" || e == "" || h == "")
				{
					throw new Exception(cnt.ToString());
				}
				else
				{
					Final.Add(t.Trim() + "|" + e.Trim() + "|" + h.Trim());
				}
				cnt++;
			}
			StreamWriter sw = new StreamWriter("c:\\3dict.txt", false, Encoding.Unicode);
			foreach (string s in Final)
			{
				sw.WriteLine(s);
			}
			sw.Close();
		}

		private static Lang FindLang(int ci)
		{
			if (ci >= 0xC00 && ci <= 0xC7F)
			{
				return Lang.Telugu;
			}
			else if (ci >= 0x900 && ci <= 0x97F || (char)ci == '*')
			{
				return Lang.Hindi;
			}
			else if ((char)ci == ' ')
			{
				return Lang.Quotes;
			}
			else
			{
				return Lang.English;
			}
		}
	}
}
