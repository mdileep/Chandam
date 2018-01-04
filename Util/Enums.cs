//---------------------------------------------------------------------------------------------
// <copyright file="Enums.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:34EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

namespace Chandam.Rules
{
	public enum RuleLanguage
	{
		Telugu = 0,
		Kannada = 1,
		Sanskrit = 2,
		Hindi = 3,
		Malayalam = 4
	}

	public enum LoadMode
	{
		Internal = 0,
		External = 1,
		Mixed = 2
	}

	public enum PadyamSubType
	{
		Other = 0,

		Jati = 1,
		UpaJati = 2,
		Vruttam = 3,


		Akkara = 4,
		Divpada = 5,
		Sisamu = 6,

		Ragada = 7,
		Ragada2 = 8,//Derivative of Ragada but not acutal Ragada...
		Shatpada = 9,

		GenricVruttam = 10,
		VishamaVruttam = 11,
		ArdhaVruttam = 12,
		DaMDakamu = 13
	}

	public enum PadyamType
	{
		Vruttam = 0,
		Jati = 1,
		UpaJati = 2,
		Unspecified = 3
	}
	public enum RuleType
	{
		Name = 0,
		Type = 1,
		Type2 = 2,
		Weight = 3,
		SubType = 4,
		Custom = 5
	}
	public enum YatiMode
	{
		CharPosition = 0,
		GPosition = 1
	}
	public enum Frequency
	{
		Rare = 0,
		Frequent = 1
	}
	public enum Category
	{
		Surya = 0,
		Indra = 1,
		Chandra = 2,
		Guruvu = 3,
		Laghuvu = 4,
		Other = 5,
		Unknown = 6
	}
	public enum Category2
	{
		Brahma = 0,
		Vishnu = 1,
		Rudra = 2,
		Guruvu = 3,
		Laghuvu = 4,
		Other = 5,
		Unknown = 6
	}
	public enum SubCategory
	{
		Laghu5 = 0,
		LaghuSurya = 1,
		Unknown = 2
	}
	public enum Matra
	{
		One = 1,
		Two = 2,
		Four = 3,
		Other = 4
	}
	public enum Mismatch
	{
		Name = 0,
		Category = 1,
		Weight = 2,
		Yati = 3,
		Lines = 4,
		GCount = 5,
		Prasa = 6,
		NonGuruvu = 7,
		OddNonJa = 8,
		Sixth = 9,
		AnthyaPrasa = 10,
		PrasaPoorva = 11,
		AnthyaPrasaPoorva = 12,
		PrasaPoorvaBindu = 13,
		AnthyaPrasaPoorvaBindu = 14,
		PrasaPoorvaVisarga = 15,
		AnthyaPrasaPoorvaVisarga = 16,
		PrasaYati = 17
	}
	public enum OutputFormat
	{
		Text = 0,
		HTML = 1
	}
}
