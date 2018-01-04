//---------------------------------------------------------------------------------------------
// <copyright file="iIndicCharSet.cs" company="Chandam-????">
//    Copyright © 2013 - 2018 'Chandam-????' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:36EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Indic
{

	public interface iIndicCharSet
	{
		char Reph
		{
			get;
		}
		char Special2
		{
			get;
		}
		string IgnoreSet
		{
			get;
		}
		string AchchuSet
		{
			get;
		}
		string HalluSet
		{
			get;
		}
		string NumberSet
		{
			get;
		}
		char PolluSet
		{
			get;
		}

		string SmallAchchuSet
		{
			get;
		}

		string SmallFinishingSet
		{
			get;
		}
		string FinishingSet
		{
			get;
		}

		string NeutralSet
		{
			get;
		}
		string SpecialFinishSet
		{
			get;
		}
		int UnicodeFrom
		{
			get;
		}
		int UnicodeTo
		{
			get;
		}

		string SapceSet
		{
			get;


		}
		string NewLineSet
		{
			get;
		}

		IndicChar NewChar { get; }
	}
}

//string SpecialAkshar { get;}
//string CharecterSet{get;}
//string LongAchchuSet{get;}
//string SmallHalluSet{get;}
//string LongHalluSet{get;}
//string LongFinishingSet{get;}  