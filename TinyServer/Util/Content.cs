//---------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Chandam-ఛందం">
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

namespace Server.Util
{
	public class HyperLink
	{
		public string HREF;
		public string Title;

	}
	public class Content
	{
		public string Binder;
		public bool IsContent;
		public string Title;
		public string KeyWords;
		public string Description;
		public bool Downloadable;
		public List<HyperLink> Related;

		public Content()
		{
			Related = new List<HyperLink>();
		}


		public void Add(string title, string href)
		{
			this.Related.Add(new HyperLink
			{
				Title = title,
				HREF = href
			});
		}
	}
}
