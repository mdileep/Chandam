//---------------------------------------------------------------------------------------------
// <copyright file="ScriptManager.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text;

namespace Server
{
	public class ScriptManager
	{

		Dictionary<string, object> dict;
		List<string> List;
		public ScriptManager()
		{
			dict = new Dictionary<string, object>();
			List = new List<string>();
		}
		public void AddScriptFile(string s)
		{
			List.Add(s);
		}
		internal void SetScriptVar(string var, object val)
		{
			dict.Add(var, val);
		}
		internal string Go()
		{
			StringBuilder s = new StringBuilder();
			if (dict.Keys.Count > 0)
			{
				s.Append("<script type=\"text/javascript\">");
				foreach (KeyValuePair<string, object> KVP in dict)
				{
					if (KVP.Value.GetType() == typeof(int))
					{
						s.Append("var " + KVP.Key + "= " + KVP.Value + ";");
					}
					else if (KVP.Value.GetType() == typeof(string))
					{
						s.Append("var " + KVP.Key + "= '" + KVP.Value + "';");//Encoding may be done...
					}
				}
				s.AppendLine("</script>");
			}
			foreach (string src in List)
			{
				s.Append("<script src=\"");
				s.Append(src);
				s.AppendLine("\" type=\"text/javascript\"></script>");
			}
			return s.ToString();
		}
	}
}
