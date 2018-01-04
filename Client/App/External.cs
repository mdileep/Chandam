//---------------------------------------------------------------------------------------------
// <copyright file="External.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:10EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using System.Runtime.CompilerServices;

namespace MiriyamApp.External
{
	[ScriptImport]
	[ScriptIgnoreNamespace]
	public class MatchOptions2
	{
		[ScriptField]
		public RuleLanguage Language { get { return RuleLanguage.Telugu; } set { } }

		[ScriptField]
		public bool ShowGV { get { return false; } set { } }

		[ScriptField]
		public bool MatchYati
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[ScriptField]
		public bool MatchPrasa
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[ScriptField]
		public bool AllowSantiPrasa
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[ScriptField]
		public bool QuickMatch
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[ScriptField]
		public bool IncludeRare
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[ScriptField]
		public bool ExperimenatalSandhi
		{
			get
			{
				return false;
			}
			set
			{
			}
		}
	}

	[ScriptImport]
	[ScriptIgnoreNamespace]
	public class Example
	{

	}


	[ScriptImport]
	[ScriptIgnoreNamespace]
	public class Rule2
	{
		[ScriptField]
		public string Name
		{
			get
			{
				return "";
			}
			set
			{
			}
		}


		[ScriptField]
		public string Identifier
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		[ScriptField]
		public string RuleText
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		[ScriptField]
		public int Lines
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[ScriptField]
		public int Threshold
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[ScriptField]
		public string[] Examples
		{
			get
			{
				return null;
			}
			set
			{

			}
		}

		[ScriptField]
		public object[][] Rules
		{
			get
			{
				return null;
			}
			set
			{

			}
		}

		[ScriptField]
		public PadyamType PadyamType
		{
			get
			{
				return PadyamType.Unspecified;
			}
			set
			{

			}
		}

		[ScriptField]
		public PadyamSubType PadyamSubType
		{
			get
			{
				return PadyamSubType.Other;
			}
			set
			{

			}
		}
		[ScriptField]
		public RuleType RuleType
		{
			get
			{
				return RuleType.Custom;
			}
			set
			{

			}
		}
		[ScriptField]
		public YatiMode YatiMode
		{
			get
			{
				return YatiMode.CharPosition;
			}
			set
			{

			}
		}

		[ScriptField]
		public int[][] Yati
		{
			get
			{
				return null;
			}
			set
			{

			}
		}

		[ScriptField]
		public bool PrasaYati { get { return false; } set { } }

		[ScriptField]
		public bool Prasa { get { return false; } set { } }

		[ScriptField]
		public bool ReverseYati { get { return false; } set { } }

		[ScriptField]
		public bool OnlyPrasaYati { get { return false; } set { } }

		[ScriptField]
		public bool YatiRecycle { get { return false; } set { } }

		[ScriptField]
		public bool AnthyaPrasa { get { return false; } set { } }

		[ScriptField]
		public RuleLanguage Language { get { return RuleLanguage.Telugu; } set { } }

		[ScriptField]
		public bool DeferThresold { get { return false; } set { } }

		[ScriptField]
		public bool InfiniteLength { get { return false; } set { } }

		[ScriptField]
		public Frequency Frequency
		{
			get { return Frequency.Frequent; }
			set { }
		}

		[ScriptField]
		public string[] References
		{
			get { return null; }
			set { }
		}
	}

	[ScriptIgnoreNamespace]
	[ScriptImport]
	public class Window2
	{
		[ScriptField]
		[ScriptAlias("Config.Language")]
		public static int Language { get { return 0; } set { } }

		[ScriptField]
		[ScriptAlias("Config.Mode")]
		public static LoadMode LoadMode { get { return LoadMode.Mixed; } set { } }

		[ScriptField]
		[ScriptAlias("Config.Loaded")]
		public static bool Loaded { get { return false; } set { } }

		[ScriptField]
		[ScriptAlias("Config.ExternalRules")]
		public static object Rules
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ScriptField]
		[ScriptAlias("Config.Samples")]
		public static object Samples
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[ScriptField]
		[ScriptAlias("Config.ExternalExamples")]
		public static object Examples
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}

	[ScriptIgnoreNamespace]
	[ScriptImport]
	public delegate void AjaxCallback(string err, string data, XHR xhr);

	[ScriptImport]
	[ScriptIgnoreNamespace]
	public class XHR
	{
		[ScriptField]
		public int Status
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}
	}

	[ScriptImport]
	[ScriptIgnoreNamespace]
	public static class Ajax
	{
		public static void MakeCall(string url, AjaxCallback T, string Method, string Data, bool async)
		{

		}

		public static void MakeCall(string url, AjaxCallback T, string Method, string Data)
		{

		}

		public static void MakeCall(string url, AjaxCallback T, string Method)
		{

		}

	}

}







