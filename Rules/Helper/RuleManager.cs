//---------------------------------------------------------------------------------------------
// <copyright file="RuleManager.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:35EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Chandam.Rules
{
	public class Manager
	{
		private static Dictionary<string, Rule> LoadedList = new Dictionary<string, Rule>();
#if SCRIPTSHARP

#else
		static Manager()
		{
			Manager.Register(TeluguRules.Rules);
		}
#endif

		public static void Register(Rule[] TeluguRules)
		{
			if (LoadedList != null)
			{
				foreach (Rule R in TeluguRules)
				{
					AddRule(R);
				}
			}
		}

		public static void Clear()
		{
			LoadedList = new Dictionary<string, Rule>();
		}


		public static void AddRule(Rule R)
		{
			LoadedList[R.Identifier] = R;
		}


		public static Rule FetchRule(string identifier)
		{
			if (!LoadedList.ContainsKey(identifier))
			{
				return null;
			}
			return LoadedList[identifier];
		}

		public static Rule[] Rules()
		{
			Rule[] List = new Rule[LoadedList.Count];
			int cnt = 0;
			foreach (string R in LoadedList.Keys)
			{
				List[cnt++] = LoadedList[R];
			}

			return List;
		}
	}
}
