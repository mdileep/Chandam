//---------------------------------------------------------------------------------------------
// <copyright file="SubscribersList.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using MongoDB.Driver;
using Server.Util.DB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Server
{
	public class ExtractServerData
	{
		string root = @"D:\Working\Chandam\Web\";
		public void Dump()
		{
			Subscribers();
			DumpMetrics();
			DumpMetrics2();
		}

		private void Subscribers()
		{
			string toFile = root + "Subscribers.txt";


			MongoLib.MongoUtil M = new MongoLib.MongoUtil();
			List<Subscription> List = M.Subscribers();
			StreamWriter sw = new StreamWriter(toFile);
			sw.WriteLine("Printed on " + DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));

			{
				string x = MakeRecord(new object[] { "EmailId", "Allow", "CreationTime", "Id" });
				sw.WriteLine(x);
			}
			foreach (Subscription S in List)
			{
				string x = MakeRecord(new object[] { S.EmailId, S.Allow, S.Id.CreationTime.ToString("yyyyMMdd"), S.Id });
				sw.WriteLine(x);
			}
			sw.Close();
		}
		private void DumpMetrics2()
		{
			string toFile = root + "Metrics2.txt";
			MongoLib.MongoUtil M = new MongoLib.MongoUtil();
			MongoCursor<Metric2> List = M.Metrics2();
			StreamWriter sw = new StreamWriter(toFile);
			sw.WriteLine("Printed on " + DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));

			{
				string x = MakeRecord(new object[] { "Name", "Total", "Count", "Id", "CreationTime" });
				sw.WriteLine(x);
			}
			foreach (Metric2 S in List)
			{
				string x = MakeRecord(new object[] { S.Name, S.Total, S.Count, S.Id, S.Id.CreationTime.ToString("yyyyMMdd HH:mm:ss") });
				sw.WriteLine(x);
			}
			sw.Close();
		}
		private void DumpMetrics()
		{
			string toFile = root + "Metrics.txt";
			MongoLib.MongoUtil M = new MongoLib.MongoUtil();
			MongoCursor<Metric> List = M.Metrics();
			StreamWriter sw = new StreamWriter(toFile);
			sw.WriteLine("Printed on " + DateTime.Now.ToString("yyyyMMdd HH:mm:ss"));

			{
				string x = MakeRecord(new object[] { "Date", "Time", "Hours", "Host", "IP", "Name", "Identifier", "Score", "Id", "CreationTime" });
				sw.WriteLine(x);
			}


			foreach (Metric S in List)
			{
				string x = MakeRecord(new object[] { S.Date, S.Time, S.Hours, S.Host, S.IP, S.Name, S.Identifier, S.Score, S.Id, S.Id.CreationTime.ToString("yyyyMMdd HH:mm:ss") });
				sw.WriteLine(x);
			}
			sw.Close();
		}

		private string MakeRecord(object[] list)
		{
			StringBuilder sb = new StringBuilder(); ;
			foreach (object o in list)
			{

				sb.Append((o == null ? "" : o.ToString()) + ",");
			}
			return sb.ToString().TrimEnd(',');
		}


	}
}
