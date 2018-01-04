//---------------------------------------------------------------------------------------------
// <copyright file="SatakamData.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:37EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;


namespace Library.Chandam.Samples
{
	public partial class SatakamData
	{
		public string HeaderString
		{
			get
			{
				return GetMerged(Header);
			}
		}
		public string FooterString
		{
			get
			{
				return GetMerged(Footer);
			}
		}
		public Format Format
		{
			get;
			set;
		}
		public List<string> Footer
		{
			get;
			set;
		}
		public List<string> Header
		{
			get;
			set;
		}
		public string Title
		{
			get;
			set;
		}
		public List<Poem> Poems
		{
			get;
			set;
		}
		private string GetMerged(List<string> C)
		{
			if (Header == null)
				return "";
			string header = "";

			foreach (string s in C)
			{
				header = header + s + "\n";
			}
			return header;
		}
	}
}
