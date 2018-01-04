//---------------------------------------------------------------------------------------------
// <copyright file="MenuItems.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using MiriyamaApp.Labs;
using MiriyamApp.External;
using MiriyamApp.Social.Facebook;
using System;
using System.Html;

namespace MiriyamApp
{

	public static class MenuItems
	{
		static bool ReqInProgress;
		private static void MakeStaticCall(string url)
		{
			if (ReqInProgress)
			{
				return;
			}
			ReqInProgress = true;
			Ajax.MakeCall(url + "?r=" + new Date().ToUTCString(), new AjaxCallback(delegate (string err, string data, XHR xhr)
   {
	   Window.Document.GetElementById("result").InnerHTML = data;
   }), HTTPMethod.GET);
			ReqInProgress = false;
		}

		public static void OnDedicatedTo()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/dedicated.html");
		}
		public static void OnFAQ()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/faq.html");
		}
		public static void OnLimitations()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/Limitations.html");
		}
		public static void OnCaseStudy()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/CaseStudy.html");
		}
		public static void OnReleaseNotes()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/Release.html");
		}
		public static void OnAbout()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/About.html");
		}
		public static void OnShowCredits()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/Credits.html");

		}
		public static void OnContact()
		{
			Worker.HideToolbar();
			MakeStaticCall("Menu/Contact.html");
		}
		internal static void OnShowLab()
		{
			Window.Document.GetElementById("result").InnerHTML = "";
			Worker.HideToolbar();
			ChandamLab.Init();

		}
		public static void OnCheatSheet()
		{
			Worker.HideToolbar();
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:blue;'>ఛందోరాజం</b> <b style='color:red;'>ముద్రణ జరుగుతోంది కొన్ని సెకన్లు ఓపిక పట్టండి.</b>";// (<i>Named after my Father <b>Sri M.Bapi Raju</b></i>)
			Script.SetTimeout(PrintCheatSheet, 200);
		}


		public static void OnBook()
		{
			Worker.HideToolbar();
			Window.Document.GetElementById("result").InnerHTML = "<b style='color:blue;'> ఛందోరత్నావళి</b> <b style='color:red;'>పుస్తకం ముద్రణ జరుగుతోంది కొన్ని సెకన్లు ఓపిక పట్టండి.</b>";//<i>Named after my Mother Smt. Vardhamana Venkata Ratnamma and my Grand father Sri. Miriyala Venkata Ratanam.</i>
			Script.SetTimeout(PrintBook, 200);
		}

		private static void PrintBook()
		{
			StopWatch.Start();

			string s = Business.BuildBook();
			Window.Document.GetElementById("result").InnerHTML = "<span class='err'>ఛందోరత్నావళి</span> <div>" + s + "</div>";


			StopWatch.ShowTicks(true);
			Metrics.Export2(Metric.Book, StopWatch.LastTicks);
		}

		private static void PrintCheatSheet()
		{
			StopWatch.Start();
			string s = Business.BuildCheatSheet();
			Window.Document.GetElementById("result").InnerHTML = "<span class='err'>ఛందోరాజం</span>" + s;
			Script.Literal("var s1=new SortableTable(document.getElementById('CheatSheet'),['Number','String', 'Number', 'String','Number','Number', 'String','String','String', 'String','String']);s1.sort(0,false)");
			Metrics.Export2(Metric.CheatSheet, StopWatch.LastTicks);
			StopWatch.ShowTicks(true);
		}

	}
}