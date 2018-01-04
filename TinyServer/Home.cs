//---------------------------------------------------------------------------------------------
// <copyright file="Home.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using Server.Util;
using System;
using System.IO;
using System.Web.UI.HtmlControls;

namespace Server
{
	public class Home : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				InitUI();

				string key = null;
				string val = "";


				if (Request.QueryString.Count == 0)
				{
					val = "about";
				}
				else
				{
					key = Request.QueryString.AllKeys[0];
					val = Request.QueryString[key];
				}
				key = key ?? val;

				Content C = HandleMenuItems(key.ToLower());


				if (C == null)
				{
					C = Bind(key.ToLower(), val);
				}

				if (C != null && C.Downloadable)
				{
					Response.ContentType = "text/html";
					Response.WriteFile(Server.MapPath("~/" + C.Binder));
					Response.End();
					return;
				}

				ConfigUI2(key.ToLower());

				SetTarget(val);
				ConfigUI(C);

			}
			catch
			{
				SetTarget("");
			}
		}
		private void InitUI()
		{
			LabsPage.Visible = false;
			ChandamContainer.Visible = false;
			contentRow.Visible = false;
			mainRow.Visible = false;
			bannerWrapper.Visible = false;
			disclaimer.Visible = false;
			SearchPage.Visible = false;
		}
		private void ConfigUI2(string key)
		{
			switch (key)
			{
				case "lab":
					bannerWrapper.Visible = true;
					LabsPage.Visible = true;
					mainRow.Visible = true;
					disclaimer.Visible = true;
					break;
				case "chandam":
				case "p":
					bannerWrapper.Visible = true;
					ChandamContainer.Visible = true;
					mainRow.Visible = true;
					disclaimer.Visible = true;
					break;
				case "search":
					bannerWrapper.Visible = true;
					mainRow.Visible = true;
					disclaimer.Visible = true;
					SearchPage.Visible = true;
					break;
				case "cheatsheet":
				case "book":
				default:
					contentRow.Visible = true;
					break;
			}
		}

		private void SetTarget(string val)
		{
			ScriptManager SC = new ScriptManager();
			switch (val)
			{
				default:
				case "te":
					SC.AddScriptFile("/js/chandam.te.app.js");
					break;
				case "kn":
					SC.AddScriptFile("/js/chandam.kn.app.min.js");
					break;
			}

			Scripts.InnerHtml = SC.Go();
		}

		private Content Bind(string key, string val)
		{
			switch (key)
			{
				case "chandassu":
					return Chandassu(val);
			}
			return null;
		}



		private Content Chandassu(string val)
		{
			switch (val)
			{
				case "sans":
					{
						Content C = new Content();
						C.Title = "సంస్కృత ఛందస్సులు";
						C.KeyWords = "";
						C.Description = "";
						C.Binder = "Menu\\" + val + ".html";
						C.Related.Add(GetTel());
						return C;
					}
				case "tel":
					{
						Content C = new Content();
						C.Title = "తెలుగు ఛందస్సులు";
						C.KeyWords = "";
						C.Description = "";
						C.Binder = "Menu\\" + val + ".html";
						C.Related.Add(GetSans());
						return C;
					}
				default:

					return ShowRules(val);

			}
		}

		private HyperLink GetTel()
		{
			HyperLink Tel = new HyperLink();
			Tel.Title = "తెలుగు ఛందస్సులు";
			Tel.HREF = "?chandassu=tel";
			return Tel;
		}

		private HyperLink GetSans()
		{
			HyperLink Sans = new HyperLink();
			Sans.Title = "సంస్కృత ఛందస్సులు";
			Sans.HREF = "?chandassu=sans";
			return Sans;
		}

		private Content ShowRules(string identifier)
		{
			Rule R = Manager.FetchRule(identifier);
			if (R == null)
			{
				R = RuleHelper.GetRulesItem2(identifier);
				R.Language = RuleLanguage.Sanskrit;
				if (R == null)
				{
					return null;
				}
			}

			string s = CheatSheet.BuildRulesWithExamples(R);

			Content C = new Content();
			C.Binder = s;
			C.IsContent = true;
			C.Title = R.Name + " &mdash; " + GetLanaguage(R.Language);
			C.Description = R.Name + " ఛందస్సు లక్షణాలు,ఉదాహరణలు,స్వభావం";
			C.KeyWords = R.Name + ",ఛందస్సు," + R.Identifier;
			C.Related.Add(GetLangLink(R.Language));


			if (R.Language != RuleLanguage.Sanskrit)
			{
				C.Add("'" + R.Name + "' పద్య ఛందస్సులో వ్రాసిన పద్యాన్ని గణించండి.", "?chandam=" + R.Identifier);
			}

			return C;
		}

		private HyperLink GetLangLink(RuleLanguage ruleLanguage)
		{
			switch (ruleLanguage)
			{
				case RuleLanguage.Sanskrit: return GetSans();
				default:
				case RuleLanguage.Telugu: return GetTel();
			}
		}

		private string GetLanaguage(RuleLanguage ruleLanguage)
		{
			switch (ruleLanguage)
			{
				case RuleLanguage.Sanskrit: return "సంస్కృత ఛందస్సులు";
				default:
				case RuleLanguage.Telugu: return "తెలుగు ఛందస్సులు";
			}
		}
		private void ConfigUI(Content C)
		{
			if (C == null)
			{
				return;
			}
			if (C.Title != "")
			{
				H.Title = C.Title;
			}
			if (C.KeyWords != "")
			{
				keywords.Content = C.KeyWords;
			}
			if (C.Description != "")
			{
				description.Content = C.Description;
			}

			if (Holder4.Visible && C.Related != null && C.Related.Count > 0)
			{
				//related.Controls.Clear ( );
				foreach (HyperLink H in C.Related)
				{

					HtmlAnchor A = new HtmlAnchor();
					A.Title = H.Title;
					A.InnerText = H.Title;
					A.HRef = H.HREF;

					HtmlGenericControl li = new HtmlGenericControl("li");
					li.Controls.Add(A);
					related.Controls.AddAt(0, li);
				}
			}
			Holder.InnerHtml = C.IsContent ? C.Binder : File.ReadAllText(Server.MapPath(C.Binder));
		}
		private Content HandleMenuItems(string b)
		{
			Content C = new Content();
			C.Binder = "Menu\\" + b + ".html";

			switch (b)
			{
				case "chamdoraajam":
				case "chamdoratnaavali":
					C.Downloadable = true;
					break;
				case "about":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "తెలుగు ఛందస్సు నియమాలను , గణాల,యతి,ప్రాసల గణనను చేయగల ఒక  సాంకేతిక పరికరం";
					break;
				case "book":
					C.Title = "ఛందోరత్నావళి -తెలుగు ఛందస్సు పుస్తకం -343+ఛందస్సుల వివరణ,ఉదాహరణలతో";
					C.KeyWords = "పుస్తకం,ఉదాహరణ,వివరణ";
					C.Description = "ఛందోరత్నావళి అని పిలువబడే ఒక అద్బుతమైన ఛందస్సు పుస్తకం.343+ఛందస్సుల వివరణ,ఉదాహరణలు ఇందులో కలవు";
					break;
				case "search":
					C.Title = "తెలుగు ఛందస్సుల వెదుకులాట";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "pv":
					C.Title = "ప్రశంసలు-విమర్శలు";
					C.KeyWords = "ప్రశంసలు,విమర్శలు";
					C.Description = "ఛందం © పై వివిధ మాధ్యమాల ద్వారా వచ్చిన ప్రశంసలు మరియూ విమర్శలు";
					break;
				case "casestudy":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "cheatsheet":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "contact":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "credits":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "history":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "dedicated":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "faq":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "limitations":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "release":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				case "api":
					C.Title = "";
					C.KeyWords = "";
					C.Description = "";
					break;
				default:
					return null;
			}
			return C;
		}

		#region...
		protected HtmlMeta keywords;
		protected HtmlMeta description;
		protected HtmlHead H;
		protected HtmlGenericControl result;
		protected HtmlGenericControl ChandamContainer, SearchPage, LabsPage;
		protected HtmlGenericControl contentRow, mainRow, bannerWrapper;
		protected HtmlGenericControl Holder, Holder2, Holder3, Holder4, disclaimer, related;
		protected HtmlGenericControl Scripts;
		#endregion
	}
}
