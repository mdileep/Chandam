//---------------------------------------------------------------------------------------------
// <copyright file="CSWriter.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 20:53EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------


using Chandam.Rules;

namespace MiriyamApp
{

	public class CSWriter
	{
		public static string CodeIt(Rule R)
		{
			string template = @"public class {0} :Rule 
{ 
	public {0}()
	{ 
		Lines = {1};
		Threshold = {2};

		RuleType = {3};
		PadyamType = {4};
		PadyamSubType ={5};
		Frequency = Frequency.Rare;
		YatiMode = {6};

		Prasa = {7};
		PrasaYati = {8};
		AnthyaPrasa={9};
		InfiniteLength = {16};

		Rules = {10};
		Yati = {11};
		
		Identifier = {12};
		Name = {13};
		ShortName = {14};
		
		Examples = {15};
		
		References={17};
	}
}";

			CSWriter C = new CSWriter();
			string identifier = R.Identifier;
			string nm = R.Name;
			string s = template.Replace("{0}", identifier);
			s = s.Replace("{1}", R.Lines.ToString());
			s = s.Replace("{2}", Helper.CalcThreshold(R).ToString());
			s = s.Replace("{3}", C.CSRuleType(R.RuleType));
			s = s.Replace("{4}", C.CSPadyamType(R.PadyamType));
			s = s.Replace("{5}", C.CSPadyamSubType(R.PadyamSubType));
			s = s.Replace("{6}", C.CSYatiMode(R.YatiMode));
			s = s.Replace("{7}", C.CSBool(R.Prasa));
			s = s.Replace("{8}", C.CSBool(R.PrasaYati));
			s = s.Replace("{9}", C.CSBool(R.AnthyaPrasa));
			s = s.Replace("{10}", C.CSRules(R.Rules, R.RuleType));
			s = s.Replace("{11}", C.CSyati(R.Yati));
			s = s.Replace("{12}", C.CSString(identifier));
			s = s.Replace("{13}", C.CSString(nm));
			s = s.Replace("{14}", C.CSString(nm));
			s = s.Replace("{15}", C.CStringArray(R.Examples));
			s = s.Replace("{16}", C.CSBool(R.InfiniteLength));
			s = s.Replace("{17}", C.CStringArray(R.References));
			return s;
		}

		private string CSString(string s)
		{
			return "\"" + s + "\"";
		}

		public string CSRuleType(RuleType ruleType)
		{
			switch (ruleType)
			{
				case RuleType.Name:
					return "RuleType.Name";
				case RuleType.Type:
					return "RuleType.Type";
				case RuleType.Weight:
					return "RuleType.Weight";
			}

			return "";
		}

		public string RTS(string s)
		{
			//if ( s.IndexOf ( ' ' ) >= 0 )
			//{
			//    return s.Split ( ' ' )[1];
			//}
			return s;
		}

		internal string CSPadyamType(PadyamType padyamType)
		{
			switch (padyamType)
			{
				case PadyamType.Jati:
					return "PadyamType.Jati";
				case PadyamType.UpaJati:
					return "PadyamType.UpaJati";
				case PadyamType.Vruttam:
					return "PadyamType.Vruttam";
			}
			return "";
		}

		internal string CSPadyamSubType(PadyamSubType padyamSubType)
		{

			switch (padyamSubType)
			{
				case PadyamSubType.Vruttam:
					return "PadyamSubType.Vruttam";
				case PadyamSubType.ArdhaVruttam:
					return "PadyamSubType.ArdhaVruttam";
				case PadyamSubType.VishamaVruttam:
					return "PadyamSubType.VishamaVruttam";
			}
			return "//";
		}

		internal string CSYatiMode(YatiMode yatiMode)
		{
			switch (yatiMode)
			{
				case YatiMode.CharPosition:
					return "YatiMode.CharPosition";
				case YatiMode.GPosition:
					return "YatiMode.GPosition";
			}
			return "";
		}

		internal string CSBool(bool p)
		{
			return p ? "true" : "false";
		}

		internal string CSRules(object[][] p, RuleType rt)
		{
			switch (rt)
			{
				case RuleType.Name:
					return CStringArrayArray(p);
				case RuleType.Type:
					return CSTypeArrayArray(p);
				case RuleType.Weight:
					return CSWeightArrayArray(p);
			}
			return "";
		}

		private string CSWeightArrayArray(object[][] p)
		{
			string s = "new object[][]{\n";
			foreach (object[] row in p)
			{
				s = s + "new object[]{";
				foreach (object c in row)
				{
					s = s + c.ToString() + ",";
				}
				s = s + "},\n";
			}
			return s + "}";
		}

		private string CSTypeArrayArray(object[][] p)
		{
			string s = "new object[][]{\n";
			foreach (object[] row in p)
			{
				s = s + "new object[]{";
				foreach (object c in row)
				{
					s = s + GetCategory((Category)c) + ",";
				}
				s = s + "},\n";
			}
			return s + "}";
		}

		private string GetCategory(Category category)
		{
			switch (category)
			{
				case Category.Indra:
					return "Category.Indra";
				case Category.Surya:
					return "Category.Surya";
				case Category.Chandra:
					return "Category.Chandra";
				case Category.Guruvu:
					return "Category.Guruvu";
				case Category.Laghuvu:
					return "Category.Laghuvu";
			}
			return "";
		}

		private string CStringArrayArray(object[][] p)
		{
			string s = "new string[][]{";
			foreach (object[] row in p)
			{
				s = s + "new string[]{";
				foreach (object c in row)
				{
					s = s + "\"" + c.ToString() + "\",";
				}
				s = s + "},";
			}
			return s + "}";
		}

		internal string CSyati(int[][] p)
		{
			string s = "new int[][]{";
			foreach (int[] row in p)
			{
				s = s + "new int[]{";
				foreach (int c in row)
				{
					s = s + c.ToString() + ",";
				}
				s = s + "},";
			}
			return s + "}";
		}

		internal string CStringArray(string[] p)
		{
			string s = "new string[]{";
			foreach (string _p in p)
			{
				s = s + "\"" + _p.Replace("\n", "\\n") + "\",";
			}

			return s + "}";
		}


	}
}
