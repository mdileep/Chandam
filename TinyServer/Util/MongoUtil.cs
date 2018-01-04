//---------------------------------------------------------------------------------------------
// <copyright file="MongoUtil.cs" company="Chandam-ఛందం">
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
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Server.Util.DB;
using Server.Util.Secrets;
using System;
using System.Collections.Generic;

namespace MongoLib
{
	public class MongoUtil
	{
		MongoDatabase database;
		MongoServer server;
		MongoCollection<Metric> collection;
		MongoCollection<Metric2> collection2;
		MongoCollection<Subscription> emailCollection;
		public MongoUtil()
		{

			var url = new MongoUrl(Constants.ConnectionString);
			var client = new MongoClient(url);
			server = client.GetServer();
			database = server.GetDatabase(url.DatabaseName);
			collection = database.GetCollection<Metric>(Constants.RawCollection);
			collection2 = database.GetCollection<Metric2>(Constants.AggCollection);
			emailCollection = database.GetCollection<Subscription>(Constants.EmailCollection);
		}

		public List<MetricGroup> WeeklyActions()
		{
			var group = new BsonDocument
				{
					{ "$group",
						new BsonDocument
							{
								{ "_id",
									new BsonDocument
											 {
												 { "Name","$Name" }
											 }
								},
								{
									"Count", new BsonDocument
												 {
													 { "$sum", 1 }
												 }
								}
							}
				  }
				};
			var project = new BsonDocument
				{
					{
						"$project",
						new BsonDocument
							{
								{"_id", 0},
								{"Name","$_id.Name"},
								{"Count", 1},
							}
					}
				};
			var sort = new BsonDocument
				{
					{ "$sort",
						new BsonDocument
							{
								{ "Count", 1},

							}
				  }
				};
			var match = new BsonDocument
				{
					{
						"$match",
								 new BsonDocument   {
															{
																"Date", new BsonDocument
																	   {
																		   {
																				"$gt",  Convert.ToInt32 ( DateTime.Now.AddDays(-7).ToString ( "yyyyMMdd" ) )
																		   }
																	   }


															}
													}
					}
				};

			var pipeline = new[] { match, group, project, sort };
			var result = collection.Aggregate(pipeline);
			var Documents = result.ResultDocuments;
			List<MetricGroup> L = new List<MetricGroup>();
			foreach (BsonDocument doc in Documents)
			{
				MetricGroup M = new MetricGroup();
				M.Y = (int)doc["Count"];
				M.X = doc["Name"] == BsonNull.Value ? "" : (string)doc["Name"];
				L.Add(M);
			}
			return L;
		}
		public List<MetricGroup> WeeklyDetermine()
		{
			var group = new BsonDocument
				{
					{ "$group",
						new BsonDocument
							{
								{ "_id",
									new BsonDocument
											 {
												 { "Date","$Date" }


											 }
								},
								{
									"Count", new BsonDocument
												 {
													 { "$sum", 1 }
												 }
								}
							}
				  }
				};
			var project = new BsonDocument
				{
					{
						"$project",
						new BsonDocument
							{
								{"_id", 0},
								{"Date","$_id.Date"},
								{"Name", 1},
								{"Count", 1},
							}
					}
				};
			var sort = new BsonDocument
				{
					{ "$sort",
						new BsonDocument
							{
								{ "Date", 1},

							}
				  }
				};
			var match = new BsonDocument
				{
					{
						"$match",
								 new BsonDocument   {
															{
																"Date", new BsonDocument
																	   {
																		   {
																				"$gt",  Convert.ToInt32 ( DateTime.Now.AddDays(-7).ToString ( "yyyyMMdd" ) )
																		   }
																	   }


															},
															{
																"Name", new BsonDocument
																		{
																			{
																				"$in",  new BsonArray{"Determine","TryMatch"}
																			}
																		}
															}
													}
					}
				};

			var pipeline = new[] { match, group, project, sort };
			return GropUtil(pipeline);
		}
		private List<MetricGroup> GropUtil(BsonDocument[] pipeline)
		{
			var result = collection.Aggregate(pipeline);
			var Documents = result.ResultDocuments;
			List<MetricGroup> L = new List<MetricGroup>();
			foreach (BsonDocument doc in Documents)
			{
				MetricGroup M = new MetricGroup();
				M.Y = (int)doc["Count"];
				int X = (int)doc["Date"];
				M.X = (X % 100).ToString();
				L.Add(M);
			}
			return L;
		}
		public int Sum()
		{
			var group = new BsonDocument
				{
					{ "$group",
						new BsonDocument
							{
								{ "_id", ""
								},
								{
									"Count", new BsonDocument
												 {
													 { "$sum", "$Count" }
												 }
								}
							}
				  }
				};


			var match = new BsonDocument
				{
					{
						"$match",
						new BsonDocument
							{

								{"Name", new BsonDocument
												{
													{
															"$in",  new BsonArray{"Determine","TryMatch"}
													}
												}} ,

							}
					}
				};


			var pipeline = new[] { match, group };
			var result = collection2.Aggregate(pipeline);
			var Documents = result.ResultDocuments;
			foreach (BsonDocument doc in Documents)
			{
				int t = (int)doc["Count"];

				return t;
			}


			return 10000;

		}
		public void Add(Metric Metric)
		{
			collection.Insert(Metric);
		}
		public void Add(Metric2 metric2)
		{
			collection2.Insert(metric2);
		}
		public bool Exists(string name, string identifier)
		{
			var query = Query.And(Query.EQ("Name", name ?? ""),
									Query.EQ("Identifier", identifier ?? "")
								);
			Metric2 item = collection2.FindOne(query);
			return item != null;
		}
		public bool Update(Metric2 Metric)
		{
			var query = Query.And(Query.EQ("Name", Metric.Name), Query.EQ("Identifier", Metric.Identifier));
			var update = MongoDB.Driver.Builders.Update.Inc("Count", 1).Inc("Total", Metric.Total);
			var sortBy = SortBy.Descending("Name");
			FindAndModifyResult result = collection2.FindAndModify(query, sortBy, update, true);
			return result.Ok;
		}
		public void AddSubscription(Subscription subscription)
		{
			emailCollection.Insert(subscription);
		}
		public bool UpdateSubsription(Subscription subscription)
		{
			var query = Query.And(Query.EQ("Email", subscription.EmailId));
			var update = MongoDB.Driver.Builders.Update.Set("Allow", subscription.Allow);
			var sortBy = SortBy.Descending("Email");
			FindAndModifyResult result = emailCollection.FindAndModify(query, sortBy, update, true);
			return result.Ok;
		}

		public List<Subscription> Subscribers()
		{
			MongoCursor<Subscription> List = emailCollection.FindAll();
			List<Subscription> L = new List<Subscription>();
			foreach (Subscription M in List)
			{
				L.Add(M);
			}
			return L;
		}

		public bool EmailExists(string email)
		{
			var query = Query.EQ("Email", email ?? "");
			Subscription item = emailCollection.FindOne(query);
			return item != null;
		}

		public MongoCursor<Metric> Metrics()
		{
			return collection.FindAll();
		}

		public MongoCursor<Metric2> Metrics2()
		{
			return collection2.FindAll();
		}
	}
}
