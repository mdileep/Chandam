//---------------------------------------------------------------------------------------------
// <copyright file="CookieUtil.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
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
	public static class CookieUtil
	{
		public static string GetCookie(string key)
		{
			try
			{
				string s = Document.Cookie;
				string[] Items = s.Split(';');
				foreach (string Item in Items)
				{
					string[] KV = Item.Split('=');
					if (KV.Length == 2 && KV[0].Trim() == key.Trim())
					{
						return KV[1];
					}
				}

			}
			catch
			{
				return null;
			}
			return null;
		}
		public static void DeleteCookie(string key)
		{
			SetCookie(key, "", -1);
		}
		public static void SetCookie(string key, string value, int days)
		{
			try
			{
				Date dt = GetOffSetDate(days);
				Array a = new string[] { key + "=" + value, " expires=" + ((days != -1) ? dt.ToUTCString() : "-1") };
				string s = a.Join(";");
				Document.Cookie = s;
			}
			catch
			{

			}
		}

		private static Date GetOffSetDate(int days)
		{
			Date now = new Date();
			try
			{
				//Not a fool proof
				if (days >= 365)
				{
					int extra = (int)(now.GetFullYear() % 365);
					now.SetYear(now.GetFullYear() + extra);
				}
				if (days >= 30 && days < 365)
				{
					int extra = (int)(now.GetMonth() % 30);

					if (extra + now.GetMonth() > 12)
					{
						now.SetMonth(extra + now.GetMonth() - 12);
						now.SetYear(now.GetFullYear() + 1);
					}
				}
				if (days >= 0 && days < 30)
				{

					if (now.GetDate() + days > 30)
					{
						now.SetDate(days + now.GetDate() - 30);
						now.SetMonth((now.GetMonth() + 1) % 12);
					}
					else
					{
						now.SetDate(days + now.GetDate());//FEB??? 28,29
					}
				}
			}
			catch
			{
			}
			return now;
		}
	}
}
