//---------------------------------------------------------------------------------------------
// <copyright file="Constants.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Server.Util.Secrets
{
	public class Constants
	{
		//Consider moving to a Xml/JSON based Config File
		internal const string ConnectionString = "mongodb://****:***@****.mongolab.com:****/stats";
		internal const string RawCollection = "Chandam";
		internal const string AggCollection = "Agg";
		internal const string EmailCollection = "email";
		internal const string SaveCollection = "Save";
		internal const string DataConnectionString = "mongodb://****:***@****.mongolab.com:****/data";
		internal const string EmailUser = "****";
		internal const string EmailPwd = "****";
		internal const string EmailHost = "smtp.gmail.com";
		internal const int EmailPort = 587;
	}
}
