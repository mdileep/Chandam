//---------------------------------------------------------------------------------------------
// <copyright file="VariableLength.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace CreateAndPlayMIDI
{
	/// <summary>
	/// VariableLength is a static class providing functionality to write out standard MIDI Variable Length quantities.
	/// Two methods are available in this class, allowing programmers to directly output variable length quantities
	/// to a FileStream, or output them to a List of bytes.
	/// </summary>
	static class VariableLength
	{
		/// <summary>
		/// This function accepts an unsigned long (ulong) input and outputs, directly to a FileStream,
		/// a standard MIDI variable-length equivalent.
		/// </summary>
		/// <param name="objWriter">A FileStream to which the standard MIDI variable-length quantity will be written.</param>
		/// <param name="value">The value to be written as a variable-length quantity. Must be cast to an unsigned long (ulong).</param>
		public static void WriteVariableLength(MemoryStream objWriter, ulong value)
		{
			ulong buffer;
			int iterations;

			// for variable length quantities, determine the length of the output.
			// there can be a maximum of 4 bytes output.
			if (value < 0x80)
			{
				iterations = 1;
			}
			else if (value < 0x4000)
			{
				iterations = 2;
			}
			else if (value < 0x200000)
			{
				iterations = 3;
			}
			else
			{
				iterations = 4;
			}

			// calculate the variable length bytes, according to the MIDI specification.
			buffer = value & 0x7F;

			while ((value >>= 7) != 0)
			{
				buffer = buffer << 8;
				buffer |= ((value & 0x7F) | 0x80);
			}

			for (int x = 0; x < iterations; x++)
			{
				objWriter.WriteByte((byte)(buffer & 0xFF));
				buffer = buffer >> 8;
			}
		}

		/// <summary>
		/// This function accepts an unsigned long (ulong) input and outputs, directly to a List of bytes,
		/// a standard MIDI variable-length equivalent. The functionality is equivalent to the alternate WriteVariableLength() function.
		/// </summary>
		/// <param name="objWriter">A List of bytes to which the standard MIDI variable-length quantity will be written.</param>
		/// <param name="value">The value to be written as a variable-length quantity. Must be cast to an unsigned long (ulong).</param>
		public static void WriteVariableLength(List<byte> objWriter, ulong value)
		{
			ulong buffer;
			int iterations;

			if (value < 0x80)
			{
				iterations = 1;
			}
			else if (value < 0x4000)
			{
				iterations = 2;
			}
			else if (value < 0x200000)
			{
				iterations = 3;
			}
			else
			{
				iterations = 4;
			}

			buffer = value & 0x7F;

			while ((value >>= 7) != 0)
			{
				buffer = buffer << 8;
				buffer |= ((value & 0x7F) | 0x80);
			}

			for (int x = 0; x < iterations; x++)
			{
				objWriter.Add((byte)(buffer & 0xFF));
				buffer = buffer >> 8;
			}
		}
	}
}
