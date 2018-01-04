//---------------------------------------------------------------------------------------------
// <copyright file="Page.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Html;

namespace MiriyamApp
{
	[ScriptModule]
	internal static class Page
	{
		static Page()
		{
			string url = Window.Location.Href.ToString().ToLowerCase();
			if (url.IndexOf("http://") == -1 && url.IndexOf("https://") == -1)
			{
				Document.GetElementById("body").InnerHTML = "<h2>Protocol is not supported.</h2>";
				return;
			}

			WorkerEvents.RegisterEvents();
			Worker.Init();
		}
	}
}






