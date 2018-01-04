using System;

namespace Library.String
{
	//Aligning C# For Script#
	public  partial  class StringPlus
	{
		
		public  static bool Contains(string MatchString, string compare)
		{
			 return (MatchString.IndexOf(compare)>=0);
		}

		public  static bool IsMatched (string s2 , int index , char match)
		{
			return (StringPlus.CharAt ( s2 , 0 ) == match);
		}

		public  static bool EndsWith (string s , char c)
		{
			return CharAt ( s , s.Length - 1 ) == c;
		}

		public  static bool  StartsWith (string s , char  c)
		{
			return CharAt ( s , 0 ) == c;
		}
	}
}
