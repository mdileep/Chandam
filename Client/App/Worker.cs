//---------------------------------------------------------------------------------------------
// <copyright file="Worker.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam;
using Chandam.Core;
using Chandam.Rules;
using Chandam.Rules.Vruttam;
using Chandam.Samples;
using MiriyamaApp.Labs;
using MiriyamApp.External;
using MiriyamApp.Social.Facebook;
using System;
using System.Collections;
using System.Html;


namespace MiriyamApp
{
	public static partial class Worker
	{

		public static void OnPrint()
		{
			StandardExport.PrintElemet("result");
		}

		public static void OnUnSubscribe()
		{
			OnSubscribe2(false);
		}

		public static void OnFeedback()
		{
			OverlayDialog OD = new OverlayDialog();

			OD.PreOKCallBack = delegate ()
			{

				if (!Util.IsEmailValid(Util.GetValue("fEmail")))
				{
					Window.Alert("Please provide a valid Email Address.");
					Document.GetElementById("fEmail").Focus();
					return false;
				}

				string content = "n=" + Util.GetValue("fName") + "&e=" + Util.GetValue("fEmail") + "&m=" + Util.GetValue("fMessage");

				Ajax.MakeCall("/Feedback.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
				{

					Worker.ShowNotification(Strings.FeedbackSucc);

				}), HTTPMethod.POST, content);

				return true;
			};

			OD.Title = "Feedback";
			OD.Content = "";

			Element Table = Document.CreateElement("table");
			Element Tbody = Document.CreateElement("tbody");
			Element TR0 = AddTextRow("Name", "fName");
			Element TR1 = AddEmailRow("Email", "fEmail");
			Element TR2 = AddLabelRow("Message");
			Element TR3 = AddTextAreaRow("fMessage", 3);


			Tbody.AppendChild(TR0);
			Tbody.AppendChild(TR1);
			Tbody.AppendChild(TR2);
			Tbody.AppendChild(TR3);
			Table.AppendChild(Tbody);

			Table.Style.Width = "100%";

			OD.InnerElement = Table;
			OD.Show();
		}

		private static Element AddLabelRow(string LabelText)
		{
			Element Row = Document.CreateElement("tr");
			Element Label = Document.CreateElement("td");
			Label.SetAttribute("colspan", 2);
			Label.InnerHTML = LabelText;
			Row.AppendChild(Label);
			return Row;
		}

		private static Element AddTextAreaRow(string Id, int rows)
		{
			Element E = Document.CreateElement("textarea");
			E.ID = Id;
			E.Style.Width = "80%";
			E.SetAttribute("rows", rows);

			Element Control = Document.CreateElement("td");
			Control.SetAttribute("colspan", 2);

			Control.AppendChild(E);

			Element Row = Document.CreateElement("tr");
			Row.AppendChild(Control);

			return Row;
		}

		private static Element AddTextRow(string LabelText, string Id)
		{
			return AddControlRow(LabelText, Id, "text");
		}

		private static Element AddControlRow(string LabelText, string Id, string type)
		{
			Element Row = Document.CreateElement("tr");
			Element Label = Document.CreateElement("td");
			Label.InnerHTML = LabelText;

			Element E = Document.CreateElement("input");
			E.SetAttribute("type", type);
			E.ID = Id;
			E.ClassName = "text";
			E.SetAttribute("placeholder", LabelText);

			Element Control = Document.CreateElement("td");
			Control.AppendChild(E);


			Row.AppendChild(Label);

			Row.AppendChild(Control);

			return Row;
		}
		private static Element AddEmailRow(string LabelText, string Id)
		{
			return AddControlRow(LabelText, Id, "email");

		}

		public static void ShowBulkCompute()
		{
			OverlayDialog OD = new OverlayDialog();
			OD.Title = Strings.BulkCompute;
			OD.Content = Strings.BCOnRequest;
			OD.Show();

		}
		private static void OnSubscribe2(bool allow)
		{
			OverlayDialog OD = new OverlayDialog();
			OD.Title = allow ? Strings.Subscribe : Strings.UnSubscribe;
			OD.Content = "";
			OD.PostLoadCallback = delegate ()
			{
				Document.GetElementById("txtEmail").Focus();
			};

			OD.PreOKCallBack = delegate ()
			{
				if (!Util.IsEmailValid(Util.GetValue("txtEmail")))
				{
					Window.Alert(Strings.InvalidEmail);
					Document.GetElementById("txtEmail").Focus();
					return false;
				}
				string content = "g=" + (allow ? "1" : "0") + "&e=" + Util.GetValue("txtEmail");

				Ajax.MakeCall("/Subscribe.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
				{

					Worker.ShowNotification(allow ? Strings.SubscribtionSucc : Strings.UnSubscribtionSucc);

				}), HTTPMethod.POST, content);
				return true;

			};

			Element Div = Document.CreateElement("div");

			Element Span = Document.CreateElement("div");
			Span.InnerHTML = "Email:&nbsp;&nbsp;";

			Element E = Document.CreateElement("input");
			E.SetAttribute("type", "email");
			E.ID = "txtEmail";
			E.ClassName = "text";
			E.SetAttribute("placeholder", "Ex:m.dileep@gmail.com");

			Div.AppendChild(Span);
			Div.AppendChild(E);



			OD.InnerElement = Div;
			OD.Show();


		}
		public static void HideNotification()
		{
			Element Notification = Document.GetElementById("notification");
			Notification.Style.Visibility = "hidden";
		}
		public static void ShowNotification(string message)
		{
			Element Notification = Document.GetElementById("notification");
			Notification.InnerHTML = message;
			Notification.Style.Visibility = "visible";
			Script.SetTimeout(delegate ()
			{
				HideNotification();
			}, 30000);
		}
		public static void OnSubscribe()
		{

			OnSubscribe2(true);
		}

		public static void OnPermLink()
		{
			if (Util.GetValue("txt").Length == 0)
			{
				return;
			}

			string content = "d=" + Util.GetValue("txt");

			Ajax.MakeCall("/Link.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
			{

				OverlayDialog OD = new OverlayDialog();
				OD.PostLoadCallback = delegate ()
				{

					Util.SetValue("txtPermLink", "http://chandam.apphb.com/?p=" + data);

					Util.RegisterClick("txtPermLink", delegate (ElementEvent e)
					{
						Script.Literal("document.getElementById('txtPermLink').focus()");
						Script.Literal("document.getElementById('txtPermLink').select()");
					});

					Script.Literal("document.getElementById('txtPermLink').click()");

				};

				OD.Title = Strings.PermLinkTitle;
				OD.Content = Util.GetValue("txt").Replace("\n", "<br/>");



				Element E = Document.CreateElement("textarea");
				E.SetAttribute("readonly", "1");
				E.SetAttribute("rows", "1");
				E.Style.Overflow = "hidden";
				E.Style.Width = "80%";
				E.ID = "txtPermLink";
				E.ClassName = "text";


				Element Span = Document.CreateElement("span");
				Span.InnerHTML = Strings.PermLinkDesc;


				Element Div = Document.CreateElement("div");
				Div.AppendChild(Document.CreateElement("hr"));
				Div.AppendChild(E);
				Div.AppendChild(Document.CreateElement("br"));
				Div.AppendChild(Span);



				OD.InnerElement = Div;
				OD.Show();




			}), HTTPMethod.POST, content, false);


		}
		public static void OnFBShare()
		{
			OverlayDialog OD = new OverlayDialog();
			OD.PreOKCallBack = delegate ()
			{
				string content = "d=" + Util.GetValue("txt");

				Ajax.MakeCall("/Link.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
				{
					FeedParams FP = new FeedParams();
					FP.Name = Strings.Title;
					FP.Caption = Strings.TagLine;
					FP.Description = Strings.StandardDesc;
					FP.Picture = "http://chandam.apphb.com/img/fbPreView.png?r" + new Date().ToUTCString();
					FP.Link = "http://chandam.apphb.com/?p=" + data;
					FP.Message = Util.GetValue("txt");
					FBUtil.Post(FP);
				}), HTTPMethod.POST, content, false);


				return true;

			};

			OD.Title = Strings.FBTitle;
			OD.Content = Util.GetValue("txt").Replace("\n", "<br/>");
			OD.Show();
		}
		public static void OnTwitterPost()
		{
			OverlayDialog OD = new OverlayDialog();
			OD.PreOKCallBack = delegate ()
			{
				string content = "d=" + Util.GetValue("txt");

				Ajax.MakeCall("/Link.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
				{
					string Link = "http://chandam.apphb.com/?p=" + data;
					string txt = Util.GetValue("txt");
					string brand = Strings.Brand;
					string more = " ...";
					string b = txt.Substring(0, 140 - (more.Length + brand.Length)) + more + brand + Link;

					//if ( txt.Length < 140 - ( brand.Length + more.Length ) )
					//{
					//    b = txt.Substring ( 0 , 140 - ( more.Length + brand.Length ) ) + brand + Link;
					//}

					Window.Open("https://twitter.com/intent/tweet?text=" + b.EncodeUri());
				}), HTTPMethod.POST, content, false);



				return true;
			};
			OD.Title = Strings.TwitterTitle;
			OD.Content = Util.GetValue("txt").Replace("\n", "<br/>");
			OD.Show();
		}
		public static void OnRandom()
		{
			Script.SetTimeout(delegate ()
			{
				Util.SetValue("txt", Business.GetRandomPoem());

				Metrics.Export2(Metric.Random, 0);

			}, 0);
		}

		public static void OnClear()
		{
			Script.SetTimeout(delegate ()
			{
				Util.SetValue("txt", "");
				Window.Document.GetElementById("result").InnerHTML = "";

				ClearLabs();
			}, 0);
		}

		private static void ClearLabs()
		{
			Util.SetValue("Group1", "");
			Util.SetValue("Group2", "");
		}

		public static void OnYatiCheckChange()
		{
			bool f = Util.IsChecked("btnYatiCheck");
			Window.Document.GetElementById("lblAllowSantiPrasa").Style.Display = f ? "inline" : "none";
			Window.Document.GetElementById("allowSantiPrasa").Style.Display = f ? "inline" : "none";
		}

		public static void OnLoadRare()
		{
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				SetList(true, true);//TODO..

				StopWatch.ShowTicks(true);

			}, 0);
		}

		public static void OnScores()
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>Determining Scores..</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				MatchOptions Options = Settings();

				string s = Business.Scores(Util.GetValue("txt"), Options);

				Window.Document.GetElementById("result").InnerHTML = s;
				Script.Literal("var s1=new SortableTable(document.getElementById('scores'),['Number','String','String', 'Number', 'Number', 'Number']);s1.sort(3,true);");

				StopWatch.ShowTicks(true);

				Metrics.Export2(Metric.Scores, StopWatch.LastTicks);
			}, 0);
		}

		public static void OnDetermine()
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>Detecting Best Match..</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();
				MatchOptions Options = Settings();
				Probable Pr = Business.Determine(Util.GetValue("txt"), Options);

				string s = Business.BuildResult2(Pr);
				Window.Document.GetElementById("result").InnerHTML = s;

				for (int i = 1; i <= 5; i++)
				{
					Element E = Document.GetElementById("candiate_" + i);
					if (E == null)
					{
						continue;
					}
					try
					{
						E.AddEventListener("click", delegate (ElementEvent e)
						{
							Element E3 = e.Target;
							SetClosedResult(E3);
						}, false);
					}
					catch
					{
						E.AttachEvent("onclick", new ElementEventHandler(delegate ()
						{
							Element E3 = Window.Event.SrcElement;
							SetClosedResult(E3);
						}));
					}
				}

				if (Pr != null && Pr.MatchResult != null && Pr.Rule != null)
				{
					Util.SetOption("list", Pr.Rule.Identifier);
				}

				string identifier = "";
				string score = "";
				if (Pr != null)
				{
					identifier = Pr.Rule.Identifier;
					score = Pr.MatchResult.Percentage.ToString();
				}

				Util.ScrollTo("main");

				StopWatch.ShowTicks(true);
				Metrics.Export2(Metric.Determine, StopWatch.LastTicks, identifier, score);

			}, 0);
		}

		private static void SetClosedResult(Element E3)
		{
			ElementAttribute att = null;

			if (E3.TagName.ToLowerCase() == "b")
			{
				E3 = E3.ParentNode;
			}

			att = E3.Attributes.GetNamedItem("data");

			if (att == null)
			{
				return;
			}

			Util.SetOption("list", att.Value);
		}

		public static void OnTryMatch()
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>Matching..</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				string v = Util.SelectedValue("list");
				MatchOptions Options = Settings();
				string s = Business.TryMatch(Util.GetValue("txt"), v, Options);
				Window.Document.GetElementById("result").InnerHTML = s;
				Util.ScrollTo("main");

				StopWatch.ShowTicks(true);
				Metrics.Export2(Metric.TryMatch, StopWatch.LastTicks, v);
			}, 0);
		}

		private static MatchOptions Settings()
		{
			MatchOptions Options = new MatchOptions();
			Options.MatchYati = Util.IsChecked("btnYatiCheck");
			Options.MatchPrasa = Util.IsChecked("btnYatiCheck");
			Options.AllowSantiPrasa = Util.IsChecked("allowSantiPrasa");
			Options.QuickMatch = Util.IsChecked("quickMatch");
			Options.ExperimenatalSandhi = Util.IsChecked("experimentalYati");
			Options.Language = Context.Language;
			SaveOptions(Options);
			return Options;
		}



		private static void SetOptions(MatchOptions Options)
		{
			try
			{
				Util.SetCheckedValue("btnYatiCheck", Options.MatchYati);
				Util.SetCheckedValue("btnYatiCheck", Options.MatchPrasa);

				Util.SetCheckedValue("allowSantiPrasa", Options.AllowSantiPrasa);
				Util.SetCheckedValue("quickMatch", Options.QuickMatch);
				Util.SetCheckedValue("experimentalYati", Options.ExperimenatalSandhi);
			}
			catch
			{

			}
		}

		private static void SaveOptions(MatchOptions Options)
		{
			try
			{
				int days = 30;
				CookieUtil.SetCookie("y", Options.MatchYati ? "1" : "0", days);
				CookieUtil.SetCookie("p", Options.MatchPrasa ? "1" : "0", days);
				CookieUtil.SetCookie("sp", Options.AllowSantiPrasa ? "1" : "0", days);
				CookieUtil.SetCookie("qm", Options.QuickMatch ? "1" : "0", days);
				CookieUtil.SetCookie("es", Options.ExperimenatalSandhi ? "1" : "0", days);

			}
			catch
			{

			}
		}

		private static MatchOptions RedOptions()
		{
			try
			{
				MatchOptions Options = new MatchOptions();

				//Options.QuickMatch = CookieUtil.GetCookie("qm") == "1" ? true : false;
				//Options.MatchYati = CookieUtil.GetCookie("y") == "1" ? true : false;
				//Options.MatchPrasa = CookieUtil.GetCookie("p") == "1" ? true : false;

				Options.AllowSantiPrasa = CookieUtil.GetCookie("sp") == "1" ? true : false;
				Options.ExperimenatalSandhi = CookieUtil.GetCookie("es") == "1" ? true : false;

				Options.MatchYati = true;
				Options.MatchPrasa = true;
				Options.QuickMatch = true;

				return Options;
			}
			catch
			{
			}
			return null;
		}

		public static void OnTryMatch2(Rule R)
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>Matching..</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				MatchOptions Options = Settings();
				string s = Business.TryMatch2(Util.GetValue("txt"), R, Options);
				Window.Document.GetElementById("result").InnerHTML = s;

				Util.ScrollTo("main");

				StopWatch.ShowTicks(true);
				Metrics.Export2(Metric.TryMatch2, StopWatch.LastTicks, s);
			}, 0);
		}

		public static void OnShowRules()
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>About to Show Rules...</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				Element E = Window.Document.GetElementById("list");
				string v = (string)Script.Literal("E.options[E.selectedIndex].value", null);

				string s = Business.Rules(v);
				Window.Document.GetElementById("result").InnerHTML = s;
				Util.ScrollTo("main");

				StopWatch.ShowTicks(true);
				Metrics.Export2(Metric.Rules, StopWatch.LastTicks, v);
			}, 0);
		}

		public static void OnShowRules2(Rule R)
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>About to Show Rules...</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				string s = Business.Rules2(R, false);
				Window.Document.GetElementById("result").InnerHTML = s;
				Util.ScrollTo("main");

				StopWatch.ShowTicks(true);
				Metrics.Export2(Metric.Rules2, StopWatch.LastTicks, s);

			}, 0);
		}

		public static void OnShowSamples()
		{
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:red;'>About to Show Examples...</b>";
			Script.SetTimeout(delegate ()
			{
				StopWatch.Start();

				Element E = Window.Document.GetElementById("list");
				string v = (string)Script.Literal("E.options[E.selectedIndex].value", null);
				string s = Business.Samples(v);
				Window.Document.GetElementById("result").InnerHTML = s;

				ElementCollection ListItems = Window.Document.GetElementsByTagName("li");
				for (int i = 0; i < ListItems.Length; i++)
				{
					Element E2 = ListItems[i];
					if (E2.ParentNode.ClassName == "poems")
					{
						try
						{
							E2.AddEventListener("click", delegate (ElementEvent e)
							{
								SetSample(e.Target);
							}, false);
						}
						catch
						{
							E2.AttachEvent("onclick", new ElementEventHandler(delegate ()
							{
								SetSample(Window.Event.SrcElement);
							}));
						}
					}
				}
				Util.ScrollTo("main");

				StopWatch.ShowTicks(true);
				Metrics.Export2(Metric.Samples, StopWatch.LastTicks, v);
			}, 0);
		}

		private static void SetSample(Element E3)
		{
			if (E3.TagName.ToUpperCase() == "I")
			{
				E3 = E3.ParentNode;
			}

			string txt = E3.InnerHTML;
			txt = Util.NoTags(txt);
			if (txt.IndexOf("~") > 0)
			{
				txt = txt.Substr(0, txt.IndexOf("~"));
			}
			SetText("txt", txt);
		}

		public static void HideToolbar()
		{
			Util.Hide("tc");
		}

		public static void ShowToolBar()
		{
			Util.SetVisible("tc");
		}

		public static void Ready()
		{
			//...
		}

		public static void Init()
		{
			StopWatch.Start();
			{
				if (Util.IsAvailable("bannerWrapper"))
				{
					PrepareDebugger();
					if (Util.IsAvailable("ChandamContainer"))
					{
						SetupChandam();
					}
					if (Util.IsAvailable("LabsPage"))
					{
						MenuItems.OnShowLab();
					}
					if (Util.IsAvailable("SearchPage"))
					{
						Search.Init();
					}
				}

				Incoming();
				ShowUI();
			}
			StopWatch.ShowTicks(true);
			Metrics.Export2(Metric.Load, StopWatch.LastTicks);
			Metrics.ShowStats();

		}

		private static void SetupChandam()
		{
			FBUtil.Init();//External First

			LoadRules();
			LoadSamples();
			LoadRandom();

			InitDesigner();
			InitList();
			ShowToolBar();
			InitNotification();
			InitRandom();

			RestoreOptions();
			ManageNotification();

		}

		private static void InitDesigner()
		{
			Designer.Init();
			Designer.HideDesigner();
		}

		private static void LoadRandom()
		{
			Business.InitRandomPoems();
		}
		public static void OnAppeal()
		{
			MakeNotice("/menu/notice_req.htm", "nw2", "నివేదన", 0, 1, true);
		}

		private static void ManageNotification()
		{
			try
			{
				//MakeNotice("/menu/notice_wl.htm", "nw1", "గమనిక", 0, 3, false);
				//MakeNotice("/menu/notice_req.htm", "nw2", "నివేదన", 60, 1, false);
			}
			catch
			{
			}
		}

		private static void MakeNotice(string url, string key, string title, int delay, int days, bool always)
		{
			if (!always)
			{
				bool flg = CookieUtil.GetCookie(key) == "1" ? true : false;
				if (flg)
				{
					return;
				}
			}
			Script.SetTimeout(delegate ()
			{
				Ajax.MakeCall(url, new AjaxCallback(delegate (string err, string data, XHR xhr)
				{
					if (string.IsNullOrEmpty(data))
					{
						return;
					}

					CookieUtil.SetCookie(key, "1", days);

					OverlayDialog OD = new OverlayDialog(title, data);
					OD.Id = key;
					OD.Show();

				}), HTTPMethod.GET);
			}, delay * 1000);
		}



		private static void RestoreOptions()
		{
			MatchOptions Options = RedOptions();
			if (Options != null)
			{
				SetOptions(Options);
			}
		}

		private static void InitList()
		{
			bool a2z = CookieUtil.GetCookie("a2z") == "1";
			if (a2z)
			{
				OnA2ZSort();
			}
			else
			{
				OnGroupSort();
			}
			Util.SetOption("list", "kandam");
		}

		private static void PrepareDebugger()
		{
			if (Window.Location.Href.ToString().IndexOf("localhost") > 0)
			{
				Window.Document.GetElementById("debug").Style.Display = "inline";
			}
		}

		private static void InitNotification()
		{
			Worker.ShowNotification(Strings.InitNotification);
			Util.SetDisplay("notification2");
		}

		private static void ShowUI()
		{
			//Nothing...
		}

		private static void Incoming()
		{
			Dictionary Q = Util.BuildQuery();
			if (Q == null || Q.Count == 0)
			{
				SetCurrent("btnAbout");
				return;
			}

			switch (Q.Keys[0])
			{
				case "p":
					{
						string p = Util.FindQuery("p");
						HandlePermLinks(p);
						SetChandam();
					}
					break;
				case "about"://Make it configurable..
					SetCurrent("btnAbout");
					break;
				case "credits":
					SetCurrent("btnCredits");
					break;
				case "dedicated":
					SetCurrent("btnDedicatedTo");
					break;
				case "cheatSheet":
					SetCurrent("learn");
					break;
				case "book":
					SetCurrent("book");
					break;
				case "chandassu":
					SetCurrent("chandassu");
					break;
				case "chandam":
					{
						SetChandam();

					}
					break;
				default:
					break;
			}
		}

		private static void SetChandam()
		{
			string identifier = Util.FindQuery("chandam");
			if (identifier != null)
			{
				Util.SetOption("list", identifier);
			}
			SetCurrent("logoH1");
		}

		public static void OnA2ZSort()
		{
			SetList2(false);
		}

		public static void OnGroupSort()
		{
			SetList2(true);
		}

		private static void SetList2(bool grouped)
		{
			Util.SetClass("sort_a2z", grouped ? "sub" : "sub2");
			Util.SetClass("sort_g", grouped ? "sub2" : "sub");
			//Script.SetTimeout(delegate()
			//{
			string curr = Util.SelectedValue("list");
			Worker.SetList(true, grouped);
			if (curr != null)
			{
				Util.SetOption("list", curr);
			}
			//},100);
			CookieUtil.SetCookie("a2z", grouped ? "0" : "1", 30);//Save Sort Options
		}

		private static void SetCurrent(string Id)
		{
			Util.SetClass(Id, "current-page-item");
		}

		private static void HandlePermLinks(string p)
		{
			if (string.IsNullOrEmpty(p))
			{
				return;
			}
			string content = "p=" + p;
			Ajax.MakeCall("/GLink.ashx?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
			{
				if (string.IsNullOrEmpty(data))
				{
					return;
				}
				Util.SetValue("txt", data);

			}), HTTPMethod.POST, content);

		}

		private static void InitRandom()
		{
			string count = Business.RandomPoemsCount.ToString();
			Document.GetElementById("RandomItems").InnerHTML = count;
			Document.GetElementById("btnRandom").Title = count + " కు పైగా ఉన్న పద్యాల నుండి ఒక యాదృచ్చిక పద్యం";
			//Util.SetValue ( "txt" , Business.GetRandomPoem ( ) );
		}

		public static void SetList(bool includeRare, bool grouped)
		{
			if (grouped)
			{
				LoadRules2.SetGroupedList(includeRare);
			}
			else
			{
				LoadRules2.SetSortedList(includeRare);
			}
		}

		public static void ShowLogo()
		{
			Window.Document.GetElementById("result").InnerHTML = "";
			ShowToolBar();
			HideLabs();
		}

		private static void HideLabs()
		{
			Element LabsPage = Window.Document.GetElementById("LabsPage");
			LabsPage.Style.Display = "none";
		}

		public static void OnClear2()
		{
			OnClear();
			Designer.Init();
		}

		public static void OnYatiCheck()
		{
			string s1 = Util.GetValue("Group1");
			string s2 = Util.GetValue("Group2");
			//bool allowSandhi=Util.IsChecked ( "allowSandhi2" );
			bool allowSandhi = false;
			Window.Document.GetElementById("result").InnerHTML = Business.CheckYati(s1, s2, allowSandhi);
		}

		public static void OnPrasaCheck()
		{
			string s1 = Util.GetValue("Group1");
			string s2 = Util.GetValue("Group2");
			bool allowSantiPrasa = Util.IsChecked("allowSantiPrasa2");
			Window.Document.GetElementById("result").InnerHTML = Business.CheckPrasa(s1, s2, allowSantiPrasa);
		}

		public static void HowMany()
		{
			string v = Util.SelectedValue("ChandamNames");
			int i = int.Parse(v);
			Window.Document.GetElementById("result").InnerHTML = "<span class='gName'>" + Helper.ChandamName(i) + "</span> ఛందమునకు  <span class='gName'>" + Math.Pow(2, i) + "</span> ఛందస్సులు పుట్టును.";
		}

		public static void BuildMatraVruttam()
		{
			string sn = Util.GetValue("txtVruttam");
			int n = 0;
			try
			{
				n = int.Parse(sn);
				if (Script.IsNaN(n))
				{
					Window.Document.GetElementById("result").InnerHTML = "";
					return;
				}
			}
			catch
			{
				Window.Document.GetElementById("result").InnerHTML = "";
				return;
			}
			ChandamLab.FindMatraVruttams(n);
		}

		public static void BuildGana()
		{
			string sc = Util.SelectedValue("ChandamNames");
			string sn = Util.GetValue("txtNumber");
			if (sc == "")
			{

			}

			int n = 0;
			int c = 0;

			try
			{
				n = int.Parse(sn);
				c = int.Parse(sc);
				if (Script.IsNaN(n) || Script.IsNaN(c))
				{
					Window.Document.GetElementById("result").InnerHTML = "";
					return;
				}
			}
			catch
			{
				Window.Document.GetElementById("result").InnerHTML = "";
				return;
			}
			Window.Document.GetElementById("result").InnerHTML = ChandamLab.BuildGana(c, n);
		}

		public static void PendingReport()
		{
			string s = new Library.Reports.ChandamReports().PendingWork();
			Window.Document.GetElementById("result").InnerHTML = s;
		}

		private static void LoadSamples()
		{
			if (Script.IsNullOrUndefined(Window2.Rules))
			{
				return;
			}
			string[] Rules2 = (string[])(Window2.Samples);
			SamplePoems.Append(Rules2);
		}

		public static void LoadRules()
		{
			LoadMode Mode2 = (LoadMode)Window2.LoadMode;
			switch (Mode2)
			{
				//case LoadMode.Internal:
				//    Register.Go();
				default:
				case LoadMode.External:
					MapRules.LoadExternalRules();
					break;
			}
			Manager.AddRule(new GenricVruttam());
		}

		private static void SetText(string id, string v)
		{
			Util.SetValue(id, v.ToUpperCase().Replace("<BR>", "\n").Replace("<BR />", "\n"));
			Util.SetFocus(id);
		}
	}
}

