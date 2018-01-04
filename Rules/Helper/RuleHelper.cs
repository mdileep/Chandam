//---------------------------------------------------------------------------------------------
// <copyright file="RuleHelper.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:35EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Chandam.Rules
{
	public partial class RuleHelper
	{
		/// <summary>
		/// Gets all the Rules 
		/// </summary>
		/// <param name="includeRare">Whether to include rarely used Rules</param>
		/// <returns></returns>
		public static List<Rule> GetAllRules(bool includeRare)
		{
			Rule[] Rules = Manager.Rules();

			List<Rule> L = new List<Rule>();
			foreach (Rule R in Rules)
			{
				if (includeRare)
				{
					L.Add(R);
				}
				else
				{
					if (R.Frequency == Frequency.Rare)
					{
						continue;
					}
					L.Add(R);
				}
			}
			return L;
		}


		public static List<Rule> GetAllRules2(int min, int max, int lines)
		{
			List<Rule> L = new List<Rule>();
			foreach (Rule R in Manager.Rules())
			{
				bool minFalls = (R.RelaxedMin <= min && min <= R.RelaxedMax);
				bool maxFalls = (R.RelaxedMin <= max && max <= R.RelaxedMax);


				if (lines == 1 && R.PadyamSubType == PadyamSubType.DaMDakamu && minFalls && maxFalls)//Not a good idea...
				{
					L.Add(R);
					continue;
				}

				if (R.PadyamSubType == PadyamSubType.DaMDakamu && R.Lines == 1)
				{
					continue;
				}

				if (minFalls && maxFalls)
				{
					L.Add(R);
				}
			}
			return L;
		}

		/// <summary>
		/// Gets all the Rules with given Padyam Sub Type
		/// </summary>
		/// <param name="C"></param>
		/// <returns></returns>
		public static Rule[] GetRules2(PadyamSubType C)
		{
			Rule[] Rules = Manager.Rules();
			List<Rule> L = new List<Rule>();

			foreach (Rule R in Rules)
			{
				if (R.PadyamSubType == C)
				{
					L.Add(R);
				}
			}

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;
		}
		/// <summary>
		/// Sama Vruttamulu with given length 
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public static Rule[] GetRules3(int l)
		{
			Rule[] Rules = Manager.Rules();
			List<Rule> L = new List<Rule>();

			foreach (Rule R in Rules)
			{
				if (R.PadyamType == PadyamType.Vruttam)
				{
					if (R.CharLength == l)
					{
						if (R.PadyamSubType == PadyamSubType.DaMDakamu || R.PadyamSubType == PadyamSubType.VishamaVruttam)
						{
							continue;
						}
						L.Add(R);
					}
				}
			}

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;


		}

		/// <summary>
		/// Sama Vruttamulu with more than given length 
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public static Rule[] GetRules4(int l)
		{
			Rule[] Rules = Manager.Rules();
			List<Rule> L = new List<Rule>();
			foreach (Rule R in Rules)
			{
				if (R.PadyamType == PadyamType.Vruttam)
				{
					if (R.CharLength >= l && R.PadyamSubType != PadyamSubType.DaMDakamu)
					{
						L.Add(R);
					}
				}
			}

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;

		}

		/// <summary>
		/// Gets are Rules with given Frquency
		/// </summary>
		/// <param name="Type"></param>
		/// <param name="frequency"></param>
		/// <returns></returns>
		public static Rule[] GetRules5(PadyamType Type, Frequency frequency)
		{
			Rule[] Rules = Manager.Rules();
			List<Rule> L = new List<Rule>();

			foreach (Rule R in Rules)
			{
				if (R.Frequency == frequency && R.PadyamType == Type)
				{
					L.Add(R);
				}
			}

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;
		}

		/// <summary>
		/// Sama Vruttamulu with given matra length 
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public static Rule[] GetRules6(int l)
		{
			Rule[] Rules = Manager.Rules();
			List<Rule> L = new List<Rule>();

			foreach (Rule R in Rules)
			{
				if (R.PadyamType == PadyamType.Vruttam)
				{
					if (R.MatraLength == l)
					{
						if (R.PadyamSubType == PadyamSubType.DaMDakamu || R.PadyamSubType == PadyamSubType.VishamaVruttam)
						{
							continue;
						}
						L.Add(R);
					}
				}


			}

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}

			return Rules2;


		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="SC"></param>
		/// <returns></returns>
		public static Rule[] GetRules7(SearchCriteria SC)
		{
			Rule[] Rules = Manager.Rules();
			List<Rule> L = new List<Rule>();

			foreach (Rule R in Rules)
			{
				if (SC.NameLike.Length > 0)
				{
					if (
							R.Identifier.IndexOf(SC.NameLike) >= 0 ||
							R.Name.IndexOf(SC.NameLike) >= 0
						//R.Name.IndexOf ( "," + SC.NameLike ) > 0  
						)
					{

					}
					else
					{
						continue;
					}
				}

				if (SC.CharLength > 0)
				{
					if (!(R.CharLength > 0 && R.Min <= SC.CharLength && SC.CharLength >= R.Max))
					{
						continue;
					}
				}

				if (SC.MatraLength >= 0)
				{
					if (!(R.MatraLength > 0 && R.MatraLength == SC.MatraLength))
					{
						continue;
					}
				}

				if (SC.MatraSreni.Length > 0)
				{
					if (!(R.MatraSeries.IndexOf(SC.MatraSreni) == 0))
					{
						continue;
					}
				}

				if (SC.PadyamType != PadyamType.Unspecified)
				{
					if (!(SC.PadyamType == R.PadyamType))
					{
						continue;
					}
				}


				L.Add(R);
			}

			Rule[] Rules2 = new Rule[L.Count];
			for (int i = 0; i < L.Count; i++)
			{
				Rules2[i] = L[i];
			}
			return SortHelper.SortByName(Rules2);
		}

		public static Rule[] GetMatraVruttams(int n)
		{
			Rule[] Rules = RuleHelper.GetRules6(n);
			return Rules;
		}
	}
}
