//---------------------------------------------------------------------------------------------
// <copyright file="Rule.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Util;


namespace Chandam.Rules
{
	public interface iP
	{
	}

	public class Example
	{
		string _author;
		string _reference;
		string _remarks;
		string _text;

		public string Reference { get { return this._reference; } set { this._reference = value; } }
		public string Author { get { return this._author; } set { this._author = value; } }
		public string Remarks { get { return this._remarks; } set { this._remarks = value; } }
		public string Text { get { return this._text; } set { this._text = value; } }
	}

	public class Rule : iP
	{
		string _RuleText;
		int _Lines;
		int _Threshold;


		string _Name;
		string _Identifier;


		string[] _Examples;
		Example[] _Examples2;
		string[] _References;

		int[][] _Yati;
		object[][] _Rules;

		PadyamType _PadyamType;
		PadyamSubType padyamSubType;
		RuleType _RuleType;
		YatiMode _YatiMode;
		Frequency _Frequency;//Default...
		RuleLanguage _language;

		bool _PrasaYati;
		bool _Prasa;
		bool _ReverseYati;
		bool _OnlyPrasaYati;
		bool _YatiRecycle;
		bool _AnthyaPrasa;
		bool infiniteLength;
		bool deferThresold;

		public bool YatiRecycle
		{
			get
			{
				return _YatiRecycle;
			}
#if SCRIPTSHARP
			set
#else
			protected set
#endif
			{
				_YatiRecycle = value;
			}
		}
		public bool ReverseYati
		{
			get
			{
				return _ReverseYati;
			}
#if SCRIPTSHARP
			set
#else
			protected set
#endif
			{
				_ReverseYati = value;
			}
		}
		public string RuleText
		{
			get
			{
				return _RuleText;
			}

#if SCRIPTSHARP
			set
#else
			protected set
#endif
			{
				_RuleText = value;
			}

		}

		public string[] References
		{
			get
			{
				return _References;
			}
			set
			{
				_References = value;
			}
		}
		public string ChandamName
		{
			get
			{
				if (this.PadyamSubType == PadyamSubType.DaMDakamu)
				{
					return "";
				}
				return Helper.ChandamName(CharLength);
			}
		}

		public int Lines
		{
			get
			{
				return _Lines;
			}
			set
			{
				_Lines = value;
			}
		}
		public int RelaxedMin
		{
			get
			{
				return MathHelper.Floor(Min * 0.9);
			}
		}
		public int RelaxedMax
		{
			get
			{
				return MathHelper.Ceil(Max * 1.1);
			}
		}
		public int Min
		{
			get
			{
				//When has rowwise rules then charlength could differ
				return Helper.MinCharLength(this.Rules, this.RuleType);

			}
		}
		public int Max
		{
			get
			{
				if (this.InfiniteLength)
					return 999999;
				return Helper.MaxCharLength(this.Rules, this.RuleType);
			}
		}
		public decimal ChandamNumber
		{
			get
			{
				if (this.RowWiseRules || this.PadyamSubType == PadyamSubType.DaMDakamu)
				{
					return -1;
				}
				return Helper.FindChandamNumber(this.Rules);
			}
		}
		public int CharLength
		{
			get
			{
				//When has rowwise rules then charlength could differ
				if (this.PadyamType != PadyamType.Vruttam || this.RowWiseRules || this.InfiniteLength)
				{
					return -1;
				}

				return Helper.CharLength(this.Rules);
			}
		}
		public int MatraLength
		{
			get
			{
				if (this.PadyamType != PadyamType.Vruttam || this.RowWiseRules || this.InfiniteLength)
				{
					return -1;
				}

				return Helper.MatraLength(this.Rules);
			}
		}
		public string Sequence
		{
			get
			{
				if (this.PadyamType != PadyamType.Vruttam || this.RowWiseRules || this.InfiniteLength)
				{
					return "";
				}
				return Helper.BuildSequence(this.Rules);
			}
		}

		public decimal ChandamOrder
		{
			get
			{
				if (this.PadyamType != PadyamType.Vruttam || this.RowWiseRules || this.InfiniteLength)
				{
					return -1;
				}

				decimal order = this.ChandamNumber;
				if (this.PadyamSubType == PadyamSubType.DaMDakamu && !this.InfiniteLength)
				{
					order = Helper.FindChandamNumber(this.Rules);
				}
				return Helper.GetOrder(this.CharLength, order);

			}
		}

		public string[] Notes
		{
			get
			{
				if (this.ChandamOrder < 0)
				{
					return new string[] { };
				}
				string[] Notes = Helper.BuildNotes(this.ChandamOrder - 1);
				return Notes;
			}
		}


		public string NotesSequence
		{
			get
			{
				string seq = "";
				for (int i = 0; i < Notes.Length; i++)
				{
					if (seq != "")
					{
						seq = seq + " ";
					}
					seq = seq + Notes[i];
				}
				return seq;
			}
		}


		public Frequency Frequency
		{
			get
			{
				return _Frequency;
			}
			set
			{
				_Frequency = value;
			}
		}
		public PadyamType PadyamType
		{
			get
			{
				return _PadyamType;
			}
			set
			{
				_PadyamType = value;
			}
		}
		public YatiMode YatiMode
		{
			get
			{
				return _YatiMode;
			}
			set
			{
				_YatiMode = value;
			}
		}
		public RuleType RuleType
		{
			get
			{
				return _RuleType;
			}
			set
			{
				_RuleType = value;
			}
		}

		public bool RowWiseRules
		{
			get
			{
				return (this.Rules.Length == this.Lines && this.Lines != 1);
			}
		}
		public bool Prasa
		{
			get
			{
				return _Prasa;
			}
			set
			{
				_Prasa = value;
			}
		}
		public bool PrasaYati
		{
			get
			{
				return _PrasaYati;
			}
			set
			{
				_PrasaYati = value;
			}
		}
		public bool OnlyPrasaYati
		{
			get
			{
				return _OnlyPrasaYati;
			}
			set
			{
				_OnlyPrasaYati = value;
			}
		}
		public bool AnthyaPrasa
		{
			get
			{
				return _AnthyaPrasa;
			}
			set
			{
				_AnthyaPrasa = value;
			}
		}
		public object[][] Rules
		{
			get
			{
				return _Rules;
			}
			set
			{
				_Rules = value;
			}
		}
		public int[][] Yati
		{
			get
			{
				return _Yati;
			}
			set
			{
				_Yati = value;
			}
		}

		/// <summary>
		/// Examples (Deprecated)
		/// </summary>
		public string[] Examples
		{
			get
			{
				return _Examples;
			}
			set
			{
				_Examples = value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public Example[] Examples2
		{
			get
			{
				//Re visit this...

				if (_Examples == null)
				{
					_Examples = new string[] { };
				}

				if (_Examples2 == null || _Examples2.Length == 0)
				{
					_Examples2 = new Example[] { };
				}

				Example[] _Examples3 = new Example[_Examples.Length + _Examples2.Length];
				for (int i = 0; i < _Examples.Length; i++)
				{
					_Examples3[i] = new Example();
					_Examples3[i].Text = _Examples[i];
				}

				for (int i = 0; i < _Examples2.Length; i++)
				{
					_Examples3[_Examples.Length + i] = _Examples2[i];
				}

				return _Examples3;
			}
			set
			{
				_Examples2 = value;
			}
		}
		public string Name
		{
			get
			{
				return _Name;
			}
			set
			{
				_Name = value;
			}
		}
		public string ShortName
		{
			get
			{
				int l = Name.IndexOf("(");
				if (l > 0)
				{
					return Name.Substring(0, l);
				}
				return Name;
			}
		}
		public string Alias
		{
			get
			{
				int l1 = Name.IndexOf("(");
				int l2 = Name.IndexOf(")");

				if (l1 > 0 && l2 > 0)
				{
					try
					{
						return StringPlus.SubString(Name, l1 + 1, l2 - l1 - 1);
						//JavaScript Substring is buggy(Not exactly??) http://ariya.ofilabs.com/2014/02/javascript-string-substring-substr-slice.html
					}
					catch
					{
						return Name;
					}
				}
				return "";
			}
		}
		public string Identifier
		{
			get
			{
				return _Identifier;
			}
			set
			{
				_Identifier = value;
			}
		}
		public int Threshold
		{
			get
			{
				return _Threshold;
			}
			set
			{
				_Threshold = value;
			}
		}
		public bool InfiniteLength
		{
			get
			{
				return infiniteLength;
			}
			set
			{
				infiniteLength = value;
			}
		}
		public string MatraSeries
		{
			get
			{
				return (PadyamType == PadyamType.Vruttam && !InfiniteLength && !RowWiseRules) ? Helper.PossibleMatraSeries(Sequence) : "";
			}
		}
		public bool DeferThresold
		{
			get
			{
				return deferThresold;
			}
			set
			{
				deferThresold = value;
			}
		}

		public PadyamSubType PadyamSubType
		{
			get
			{
				return padyamSubType;
			}
			set
			{
				padyamSubType = value;
			}
		}
		public RuleLanguage Language
		{
			get
			{
				return _language;
			}
			set
			{
				_language = value;
			}
		}
		public Rule Clone()
		{
			Rule R = new Rule();
			R.AnthyaPrasa = this.AnthyaPrasa;

			R.DeferThresold = this.DeferThresold;
			R.Examples = this.Examples;
			R.Frequency = this.Frequency;
			R.Identifier = this.Identifier;
			R.InfiniteLength = this.InfiniteLength;
			R.Language = this.Language;
			R.Lines = this.Lines;

			R.Name = this.Name;
			R.OnlyPrasaYati = this.OnlyPrasaYati;
			R.PadyamSubType = this.PadyamSubType;
			R.PadyamType = this.PadyamType;
			R.Prasa = this.Prasa;
			R.PrasaYati = this.PrasaYati;
			R.References = this.References;

			R.ReverseYati = this.ReverseYati;

			R.Rules = this.Rules;
			R.RuleText = this.RuleText;

			R.RuleType = this.RuleType;


			R.Threshold = this.Threshold;
			R.Yati = this.Yati;
			R.YatiMode = this.YatiMode;
			R.YatiRecycle = this.YatiRecycle;
			return R;
		}
	}

}