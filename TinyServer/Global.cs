//---------------------------------------------------------------------------------------------
// <copyright file="Global.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Web;

namespace Server
{
	public class Global : HttpApplication
	{
		protected void Application_BeginRequest(object sender, EventArgs e)
		{
			//HttpContext context  = HttpContext.Current;
			//string path=context.Request.Path;
			//if ( path.Contains ( ".png" ) || path.Contains ( ".aspx" ) || path.Contains ( ".ashx" ) || path.Contains ( ".js" ) || path.Contains ( ".css" ) )
			//{
			//    return;
			//}

			//string[] Groups=path.Split ( '/' );
			//if ( Groups.Length > 2 )
			//{
			//    context.RewritePath ( "~/default.aspx?" + Groups[Groups.Length - 2] + "=" + Groups[Groups.Length - 1] );
			//}
		}
	}
}
