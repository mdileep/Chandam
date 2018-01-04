//---------------------------------------------------------------------------------------------
// <copyright file="MatchResult.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:28EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Rules;
using System.Collections.Generic;


namespace Chandam.Core
{

	public class MatchResult
	{
		int _Score;
		int _Total;

		List<Errors> L;
		public MatchResult()
		{
			Errors = new List<Errors>();
		}
		public string ShowErrors(OutputFormat F)
		{
			switch (F)
			{
				case OutputFormat.Text:
					return BuildText();

				case OutputFormat.HTML:
				default:
					return BuildHTML();
			}


		}

		private string BuildText()
		{

			if (Score == Total || Total == 0)
			{
				return "";
			}

			string s = "";

			foreach (Errors E in L)
			{
				s = s + (E.Mismatch == Mismatch.Lines ? "" : (E.Line == -1) ? "" : E.Line.ToString() + " వ పాదము-") +
						(E.Mismatch == Mismatch.Lines ? "" : (E.Position == -1) ? "" : E.Position.ToString() + " వ స్థానము-") +
						 "తప్పు: " + Helper.MismatchString(E.Mismatch) + " - " +
						 "కావలసినది: " + E.Expected + " - " +
						 "ఉన్నది: " + E.Actual + "(" + E.Remarks + ")";
				s = s + "\n";
			}
			return s;
		}

		private string BuildHTML()
		{
			if (Score == Total || Total == 0)
			{
				return "";
			}
			string s = "<table cellspacing='0'  border='1'  class='errTab'><thead><tr><th>పాదము</th><th>స్థానము</th><th>తప్పు పేరు</th><th>కావలసినది(వి)</th><th>ఉన్నది(వి)</th></tr></thead><tbody>";

			foreach (Errors E in L)
			{
				s = s + "<tr>" +
						"<td>" + (E.Mismatch == Mismatch.Lines ? "" : (E.Line == -1) ? "" : E.Line.ToString()) + "</td>" +
						"<td>" + (E.Mismatch == Mismatch.Lines ? "" : (E.Position == -1) ? "" : E.Position.ToString()) + "</td>" +
						"<td>" + Helper.MismatchString(E.Mismatch) + "</td>" +
						"<td>" + E.Expected + "</td>" +
						"<td>" + E.Actual + "</td>" +
					"</tr>";
			}
			s = s + "</tbody></table>";
			return s;
		}

		public int Score
		{
			get
			{
				return _Score;
			}
			set
			{
				_Score = value;
			}
		}
		public int Total
		{
			get
			{
				return _Total;
			}
			set
			{
				_Total = value;
			}
		}
		public List<Errors> Errors
		{
			get
			{
				return L;
			}
			set
			{
				L = value;
			}
		}
		public bool IsMatched
		{
			get
			{
				return (Score == Total);
			}
		}
		public int Percentage
		{
			get
			{
				if (Total == 0)
				{
					return 0;
				}
				return (Score * 100) / Total;
			}
		}

		private Rule matchedFor;

		public Rule Rule
		{
			get
			{
				return matchedFor;
			}
			set
			{
				matchedFor = value;
			}
		}
	}
}
