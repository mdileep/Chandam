//---------------------------------------------------------------------------------------------
// <copyright file="Metric2.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using MongoDB.Bson;

namespace Server.Util.DB
{
	public class Metric2
	{
		public string Name
		{
			get;
			set;
		}
		public int Total
		{
			get;
			set;
		}
		public int Count
		{
			get;
			set;
		}
		public ObjectId Id
		{
			get;
			set;
		}
		public string Identifier
		{
			get;
			set;
		}
	}
}
