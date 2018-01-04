//---------------------------------------------------------------------------------------------
// <copyright file="WorkerEvents.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:12EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using MiriyamaApp.Labs;
using System.Html;

namespace MiriyamApp
{
	public class WorkerEvents
	{
		public static void RegisterEvents()
		{
			RegisterSocialEvents();
			RegisterTools();
			RegisterSettings();
			RegisterCore();
			RegisterDesigner();
			RegisterSearch();
			RegisterMenuEvents();
			RegisterLab();
			RegisterFooter();
		}

		private static void RegisterFooter()
		{
			Util.RegisterClick("subscribe", delegate (ElementEvent e)
		 {
			 Worker.OnSubscribe();
		 });
			Util.RegisterClick("unSubscribe", delegate (ElementEvent e)
		 {
			 Worker.OnUnSubscribe();
		 });
			Util.RegisterClick("notification", delegate (ElementEvent e)
		 {
			 Worker.HideNotification();
		 });
			Util.RegisterClick("bulk", delegate (ElementEvent e)
		 {
			 Worker.ShowBulkCompute();
		 });

			Util.RegisterClick("feedback", delegate (ElementEvent e)
		 {
			 Worker.OnFeedback();
		 });

			Util.RegisterClick("req", delegate (ElementEvent e)
			{
				Worker.OnAppeal();
			});
		}


		private static void RegisterSocialEvents()
		{
			Util.RegisterClick("fbPost", delegate (ElementEvent e)
		 {
			 Worker.OnFBShare();
		 });

			Util.RegisterClick("permLink", delegate (ElementEvent e)
		 {
			 Worker.OnPermLink();
		 });
			Util.RegisterClick("twitterPost", delegate (ElementEvent e)
		 {
			 Worker.OnTwitterPost();
		 });
			Util.RegisterClick("print", delegate (ElementEvent e)
		 {
			 Worker.OnPrint();
		 });

		}

		private static void RegisterSearch()
		{
			Util.RegisterClick("Search", delegate (ElementEvent e)
		 {
			 Search.Go();
		 });
		}

		private static void RegisterLab()
		{
			Util.RegisterClick2(new string[] { "btnClear3", "btnClear4", "btnClear5" }, delegate (ElementEvent e)
	   {
		   Worker.OnClear();
	   });


			Util.RegisterClick("btnGenPadyam", delegate (ElementEvent e)
		 {
			 ChandamLab.WriteAPadyam();
		 });

			Util.RegisterClick("WhichG", delegate (ElementEvent e)
		 {
			 Worker.BuildGana();
		 });

			Util.RegisterClick("btnWVruttam", delegate (ElementEvent e)
		 {
			 Worker.BuildMatraVruttam();
		 });

			Util.RegisterClick("ReportPending", delegate (ElementEvent e)
		 {
			 Worker.PendingReport();
		 });


			Util.RegisterClick("HowMany", delegate (ElementEvent e)
		 {
			 Worker.HowMany();
		 });


			Util.RegisterClick("YCheck", delegate (ElementEvent e)
		 {
			 Worker.OnYatiCheck();
		 });
			Util.RegisterClick("PCheck", delegate (ElementEvent e)
		 {
			 Worker.OnPrasaCheck();
		 });
		}

		private static void RegisterDesigner()
		{

			Util.RegisterClick("create", delegate (ElementEvent e)
		 {
			 Designer.ShowDesigner();
		 });

			Util.RegisterClick("hideDesigner", delegate (ElementEvent e)
		 {
			 Designer.HideDesigner2();
		 });

			Util.RegisterChange("PadyamType", delegate (ElementEvent e)
		 {
			 Designer.OnPadyamTypeChange();
		 });

			Util.RegisterChange("GanaType", delegate (ElementEvent e)
		 {
			 Designer.OnGanaChange();
		 });


			Util.RegisterChange("hasSameRules", delegate (ElementEvent e)
		 {
			 Designer.OnSameRulesChanged();
		 });
			Util.RegisterChange("shareWithMe", delegate (ElementEvent e)
		 {
			 Designer.OnShareWithMe();
		 });

			Util.RegisterClick("Reset", delegate (ElementEvent e)
		 {
			 Worker.OnClear2();
		 });

			Util.RegisterClick("Share", delegate (ElementEvent e)
		 {
			 Designer.OnShare();
		 });


			Util.RegisterClick("btnCustomRules", delegate (ElementEvent e)
		 {
			 Designer.CustomRuleText();
		 });

			Util.RegisterClick("btnCreate", delegate (ElementEvent e)
		 {
			 Designer.CreateRule();
		 });

		}

		private static void RegisterCore()
		{
			Util.RegisterClick("btnDetermine", delegate (ElementEvent e)
		 {
			 Worker.OnDetermine();
		 });

			Util.RegisterClick("btnScores", delegate (ElementEvent e)
		 {
			 Worker.OnScores();
		 });

			Util.RegisterClick("btnTry", delegate (ElementEvent e)
		 {
			 Worker.OnTryMatch();
		 });

			Util.RegisterClick("btnShowRules", delegate (ElementEvent e)
		 {
			 Worker.OnShowRules();
		 });

			Util.RegisterClick("btnSamples", delegate (ElementEvent e)
		 {
			 Worker.OnShowSamples();
		 });

			Util.RegisterClick("sort_a2z", delegate (ElementEvent e)
			{
				Worker.OnA2ZSort();
			});

			Util.RegisterClick("sort_g", delegate (ElementEvent e)
			{
				Worker.OnGroupSort();
			});
		}

		private static void RegisterSettings()
		{
			Util.RegisterChange("btnYatiCheck", delegate (ElementEvent e)
		 {
			 Worker.OnYatiCheckChange();
		 });

		}

		private static void RegisterMenuEvents()
		{
			/*Util.RegisterClick ( "logo" , delegate (ElementEvent e)
			{
				Worker.ShowLogo ( );
				Util.Prevent ( e );
			} );

			Util.RegisterClick ( "btnAbout" , delegate (ElementEvent e)
			{
				MenuItems.OnAbout ( );
				Util.Prevent ( e );
			} );
			Util.RegisterClick ( "btnDedicatedTo" , delegate (ElementEvent e)
			{
				MenuItems.OnDedicatedTo ( );
				Util.Prevent ( e );
			} );
			Util.RegisterClick ( "btnCredits" , delegate (ElementEvent e)
			{
				MenuItems.OnShowCredits ( );
				Util.Prevent ( e );
			} );
			Util.RegisterClick ( "btnLimitations" , delegate (ElementEvent e)
			{
				MenuItems.OnLimitations ( );
				Util.Prevent ( e );
			} );

			Util.RegisterClick ( "btnCaseStudies" , delegate (ElementEvent e)
			{
				MenuItems.OnCaseStudy ( );
				Util.Prevent ( e );
			} );*/

			/*Util.RegisterClick ( "learn" , delegate (ElementEvent e)
			{
				MenuItems.OnCheatSheet ( );
				Util.Prevent ( e );
			} );

			Util.RegisterClick ( "book" , delegate (ElementEvent e)
			{
				MenuItems.OnBook ( );
				Util.Prevent ( e );
			} );

			Util.RegisterClick ( "lab" , delegate (ElementEvent e)
			{
				MenuItems.OnShowLab ( );
				Util.Prevent ( e );
			} );

			Util.RegisterClick2 ( new string[] { "blog" , "blog2" } , delegate (ElementEvent e)
			{
				MenuItems.OnReleaseNotes ( );
				Util.Prevent ( e );
			} );

			

			Util.RegisterClick ( "btnContact" , delegate (ElementEvent e)
			{
				MenuItems.OnContact ( );
				Util.Prevent ( e );
			} );

			Util.RegisterClick ( "faq" , delegate (ElementEvent e)
			{
				MenuItems.OnFAQ ( );
				Util.Prevent ( e );
			} );*/
		}

		private static void RegisterTools()
		{

			Util.RegisterClick("btnRandom", delegate (ElementEvent e)
		 {
			 Worker.OnRandom();
		 });

			Util.RegisterClick("btnClear", delegate (ElementEvent e)
		 {
			 Worker.OnClear();
		 });
		}


	}

}