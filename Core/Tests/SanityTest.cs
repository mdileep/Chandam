//---------------------------------------------------------------------------------------------
// <copyright file="SanityTest.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using Chandam.Util;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;



namespace Library.Tests
{
	public class SanityTest
	{
		private string FindDuplicates()
		{
			StringBuilder Sb = new StringBuilder();
			Sb.AppendLine("<br/>Duplicates<br/><ol>");
			Type R = typeof(Rule);

			Type[] Types = GetTypes();
			foreach (Type T1 in Types)
			{
				foreach (Type T2 in Types)
				{
					if (T1.BaseType == R && T2.BaseType == R)
					{
						Rule R1 = (Rule)Activator.CreateInstance(T1);
						Rule R2 = (Rule)Activator.CreateInstance(T2);

						if (T1.FullName == T2.FullName)
						{
							continue;
						}
						if ((R1.PadyamType != PadyamType.Vruttam || R1.RowWiseRules || R1.InfiniteLength) &&
							 (R2.PadyamType != PadyamType.Vruttam || R2.RowWiseRules || R2.InfiniteLength)
							)
						{
							continue;
						}
						if (R1.CharLength == R2.CharLength && R1.ChandamNumber == R2.ChandamNumber)
						{
							//Sb.AppendLine ( R1.Identifier + "-" + R2.Identifier );
							//if ( T1.Namespace == "Library.Chandam.Sans" || T1.Namespace == "Library.Chandam.Tel" )
							{
								//Sb.Append ("<li>" +R1.Identifier +"-"+R2.Identifier+"</li>" );
								//Sb.AppendLine (  R1.Identifier + "-" + R2.Identifier );
								//if ( T1.Namespace == T2.Namespace )
								{
									//Sb.AppendLine ( T1.FullName + "-" + T2.FullName );
									Sb.AppendLine(R1.Name + "-" + R2.Name);
								}


							}
						}
					}
				}
			}
			Sb.Append("</ol>");
			return Sb.ToString();
		}
		public string Test()
		{
			StringBuilder Sb = new StringBuilder();
			Sb.AppendLine(FindDuplicates());

			return Sb.ToString();
		}
		public string Test2()
		{
			StringBuilder Sb = new StringBuilder();
			StringBuilder Sb2 = new StringBuilder();
			StringBuilder Sb3 = new StringBuilder();
			StringBuilder Sb4 = new StringBuilder();

			List<Rule> L = RuleHelper.GetAllRules(true);
			{

				Type R = typeof(Rule);
				Type[] Types = GetTypes();
				int count = 0;
				foreach (Type T in Types)
				{
					if (T.BaseType == R)
					{



						Rule R2 = (Rule)Activator.CreateInstance(T);



						if (R2.Identifier.ToLower() == "genricvruttam")
						{
							continue;
						}
						Debug2.AppendLine(R2.Name + "," + R2.PadyamType + "," + R2.PadyamSubType + "," + R2.CharLength);
						count++;


						int expected = Helper.CalcThreshold(R2);
						int actual = R2.Threshold;
						if (actual != expected)
						{
							Sb.AppendLine(R2.Name + "- Wrong Thresold- Expected: " + expected + "-Actual:" + actual);
						}
						foreach (string s in R2.Examples)
						{
							if (string.IsNullOrEmpty(s))
							{
								Sb.AppendLine(R2.Name + "- Has Blank Example.. " + R2.Identifier);
							}
						}

						if (R2.Identifier != T.Name)
						{
							Sb.AppendLine(T.Name + "- Wrong Identifier Actaul: " + R2.Identifier);

						}
						//if ( R2.ShortName != R2.Name )
						//{
						//    Sb.AppendLine ( R2.Name + "- Wrong Short Name Actaul: " + R2.ShortName );

						//}

						bool found = false;
						foreach (Rule R4 in L)
						{
							if (R2.GetType() == R4.GetType())
							{
								found = true;
							}
						}

						if (!found)
						{
							Sb.AppendLine(T.Name + "- Not found ");
							Sb3.Append("new " + T.Name + "(),");
						}


						Rule R3 = Manager.FetchRule(R2.Identifier);
						if (R3 == null)
						{
							Sb.AppendLine(T.Name + "- Get Item Not Exists");
							Sb2.AppendLine("case \"" + T.Name + "\": return  new " + T.Name + "();");
						}
						else
						{
							if (R2.GetType() != R3.GetType())
							{
								Sb.AppendLine(T.Name + "-  Wrong Get Item");
								Sb2.AppendLine("case \"" + T.Name + "\": return  new " + T.Name + "();");
							}
						}
					}
				}
				if (count != L.Count)
				{
					Sb.AppendLine("No. of Items are not matching...");
				}
				if (Sb.ToString() == "")
				{
					Sb.AppendLine("Perfect  and Total Items are " + count);
				}
			}
			Sb.Append(Sb2.ToString());
			Sb.Append(Sb3.ToString());

			return Sb.ToString();

		}
		public string Test3()
		{
			StringBuilder Sb = new StringBuilder();
			List<Rule> L = RuleHelper.GetAllRules(true);
			{

				Type R = typeof(Rule);
				Type[] Types = GetTypes();
				int count = 0;
				foreach (Type T in Types)
				{
					if (T.BaseType == R)
					{
						Rule R2 = (Rule)Activator.CreateInstance(T);
						if (R2.Identifier.ToLower() == "genricvruttam")
						{
							continue;
						}
						//Debug2.AppendLine ( R2.Name + "," + R2.PadyamType + "," + R2.PadyamSubType + "," + R2.CharLength );
						count++;

						if (T.Namespace == "Library.Chandam.Sans")
						{
							if (R2.Yati.Length >= 1)
							{
								Debug2.AppendLine(R2.Name);
								continue;
							}
							//Sb.AppendLine ( "case "+R2.Identifier+": return new " + R2.Identifier + "();" );
							Sb.AppendLine("new " + R2.Identifier + "(),");



						}
					}
				}
				return Sb.ToString();
			}
		}
		private Type[] GetTypes()
		{
			return Assembly.GetExecutingAssembly().GetTypes();
		}
	}
}

