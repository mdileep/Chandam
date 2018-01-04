//---------------------------------------------------------------------------------------------
// <copyright file="Jati2Vruttam.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Diagnostics;

namespace Verifier
{
	class Jati2Vruttam
	{
		public void Go()
		{
			List<string> S1 = new List<string>() { "UI", "III" };
			List<string> S2 = new List<string>() { "UII", "IIII", "UIU", "IIIU", "UUI", "IIUI" };
			string patterns = "1~0";
			Go(patterns, S1, S2);
		}

		List<string> S1 = new List<string>();
		List<string> S2 = new List<string>();
		List<string> L = new List<string>();
		int x = 1;
		private void Go(string pattern, List<string> S1, List<string> S2)
		{
			Debugger.Break();
			this.S1 = S1;
			this.S2 = S2;
			BuildPatterns2(pattern);
			Debugger.Break();
		}

		private void BuildPatterns2(string pattern)
		{
			string[] groups = pattern.Split('~');
			BuildPatterns2("", groups);

		}

		private void BuildPatterns2(string prefix, string[] groups)
		{
			string v = groups[0];
			if (v == "0" || v == "1")
			{
				List<string> target = v == "0" ? S1 : S2;
				foreach (string s in target)
				{
					string newPattern = (prefix == "" ? "" : prefix + "-") + s;
					string[] x = RemoveFirst(groups);

					if (x == null)
					{
						Debug.WriteLine(newPattern);
						if (!L.Contains(newPattern))
						{
							L.Add(newPattern);
						}
						else
						{
							Debug.WriteLine("....");
						}
						continue;
					}

					BuildPatterns2(newPattern, x);
				}
			}
		}

		private string[] RemoveFirst(string[] groups)
		{
			if (groups.Length == 0 || groups.Length == 1)
			{
				return null;
			}

			string[] Output = new string[groups.Length - 1];
			for (int i = 1; i < groups.Length; i++)//i=1 not i=0;
			{

				Output[i - 1] = groups[i];
			}

			return Output;

		}

		private void BuildPatterns(string pattern)
		{
			string[] groups = pattern.Split('~');
			for (int i = 0; i < groups.Length; i++)
			{
				string v = groups[i];
				if (v == "0" || v == "1")
				{
					List<string> target = v == "0" ? S1 : S2;
					BuildSeries(pattern, i, target);
				}
			}
		}

		private void BuildSeries(string patterns, int g, List<string> target)
		{
			foreach (string s in target)
			{
				string v = patterns;
				string[] X = v.Split('~');
				X[g] = s;
				string newPattern = string.Join("~", X);

				if (("~" + newPattern + "~").Contains("~0~") || ("~" + newPattern + "~").Contains("~1~"))
				{
					BuildPatterns(newPattern);
				}
				else
				{
					if (!L.Contains(newPattern))
					{
						L.Add(newPattern);
						Debug.WriteLine((x++) + " " + newPattern);
					}
				}

			}
		}

	}
}
