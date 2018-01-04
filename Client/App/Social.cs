//---------------------------------------------------------------------------------------------
// <copyright file="Social.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using MiriyamApp.External.Social.Facebook;

namespace MiriyamApp.Social.Facebook
{
	public static class FBUtil
	{
		public static void Post(FeedParams FP)
		{
			FBScope Scope = new FBScope();
			Scope.Scope = ScopeNames.PublishActions;
			FB.Login(delegate (FBResponse resp)
		  {
			  if (resp.Status == FBStatus.Connected)
			  {
				  FB.API(APINames.Feed, HTTPMethod.POST, FP, delegate (FBResponse response)
			   {
			   });
			  }
		  }, Scope);
		}

		public static void Init()
		{

		}
	}
	public static class HTTPMethod
	{
		public const string POST = "POST";
		public const string GET = "GET";
	}
	public static class APINames
	{
		public const string Feed = "/me/feed";
	}
	public static class FBStatus
	{
		public const string Connected = "connected";
		public const string NotAuthorized = "not_authorized";
	}
	public static class ScopeNames
	{
		public const string PublishActions = "publish_actions";
	}
	public class InitParams
	{
		public string AppId;
		public bool Status;
		public bool Cookie;
		public bool Xfbml;
	}
	public class FBScope
	{
		public string Scope;
	}
	public class FeedParams
	{
		public string Name;
		public string Link;
		public string Picture;
		public string Caption;
		public string Description;
		public string Message;
	}
}

