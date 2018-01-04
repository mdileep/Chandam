//---------------------------------------------------------------------------------------------
// <copyright file="KannadaCharSet.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
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
	public class KannadaCharSet : iIndicCharSet
	{

		public IndicChar NewChar
		{
			get
			{
				return new IndicChar(this);
			}
		}

		public string NewLineSet
		{
			get
			{
				return "\n";
			}
		}
		public string SapceSet
		{
			get
			{
				return " ";
			}
		}
		public string IgnoreSet
		{
			get
			{
				return " \n";
			}
		}
		public string AchchuSet
		{
			get
			{
				return "ಅಆಇಈಉಊಋಎಏಌಐಒಓಔೠ";
			}
		}
		public string HalluSet
		{
			get
			{
				return "ಕಖಗಘ" +
			 "ಙಚಛಜಝಞ" +
			 "ಟಠಡಢಣ" +
			 "ತಥದಧನ" +
			 "ಪಫಬಭಮ" +
			 "ಯರಱಲಳವ" +
			 "ಶಷಸಹ";
			}
		}
		public string NumberSet
		{
			get
			{
				return "೦೧೨೩೪೫೬೭೮೯";
			}
		}
		public char PolluSet
		{
			get
			{
				return '್';
			}
		}
		public string SmallAchchuSet
		{
			get
			{
				return "ಅಇಉಋಎಌಒ";
			}
		}
		public char Reph
		{
			get
			{
				return 'ರ';
			}
		}
		public string SpecialFinishSet
		{
			get
			{
				return "ಂಃఽ";
			}
		}
		public string SpecialAkshar
		{
			get
			{
				return "ನ್,";
			}
		}
		public string SmallFinishingSet
		{
			get
			{
				return "ಿುೃೆೊ";
			}
		}
		public string FinishingSet
		{
			get
			{
				return "ಾಿೀುೂೃೄೆೇೈೊೋೌಂಃ";
			}
		}
		public string NeutralSet
		{
			get
			{
				return "Z";
			}
		}

		public int UnicodeFrom
		{
			get
			{
				return 3201;
			}
		}
		public int UnicodeTo
		{
			get
			{
				//return 3201 + 128;
				return 3399;
			}
		}

		public char Special2
		{
			get
			{
				return 'Z';//Why????
			}
		}
	}
}