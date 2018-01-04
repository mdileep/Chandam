//---------------------------------------------------------------------------------------------
// <copyright file="CombineMP3.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using NAudio.Wave;
using System.IO;

namespace Verifier
{
	class CombineMP3
	{
		public static void Combine(string meta, string title, string[] inputFiles, Stream output)
		{
			foreach (string file in inputFiles)
			{
				Mp3FileReader reader = new Mp3FileReader(file);
				if ((output.Position == 0) && (reader.Id3v2Tag != null))
				{
					//File.WriteAllBytes(@"tabla\inject.bin", reader.Id3v2Tag.RawData);
					//output.Write(reader.Id3v2Tag.RawData, 0, reader.Id3v2Tag.RawData.Length);

					#region Set Title
					byte[] b = File.ReadAllBytes(meta);
					for (int i = 118; i <= 257; i++)
					{
						if (i - 118 < title.Length)
						{
							b[i] = (byte)title[i - 118];
						}
						else
						{
							b[i] = 0;
						}
					}
					#endregion

					output.Write(b, 0, b.Length);
				}
				Mp3Frame frame;
				while ((frame = reader.ReadNextFrame()) != null)
				{
					output.Write(frame.RawData, 0, frame.RawData.Length);
				}
			}
		}
	}
}
