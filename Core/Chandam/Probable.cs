//---------------------------------------------------------------------------------------------
// <copyright file="Probable.cs" company="Chandam-ఛందం">
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
	public class Probable
	{
		MatchResult _M;
		Padyam _P;
		Rule _R;
		List<MatchResult> _Candidates;

		public List<MatchResult> Candiates
		{
			get
			{
				return _Candidates;
			}
			set
			{
				_Candidates = value;
			}
		}
		public MatchResult MatchResult
		{
			get
			{
				return _M;
			}
			set
			{
				_M = value;
			}
		}
		public Padyam Padyam
		{
			get
			{
				return _P;
			}
			set
			{
				_P = value;
			}
		}
		public Rule Rule
		{
			get
			{
				return _R;
			}
			set
			{
				_R = value;
			}
		}
	}
}
