//---------------------------------------------------------------------------------------------
// <copyright file="MIDIGenerator.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using CreateAndPlayMIDI;
using System;
using System.Collections.Generic;
using System.IO;

namespace Verifier
{
	class MidiGerator
	{
		internal void Go(string path)
		{
			string[] lines = File.ReadAllLines(path);

			for (int count = 0; count < lines.Length; count++)
			{

				if (count == 0)
				{
					continue;
				}
				string line = lines[count];
				string[] vals = line.Split(',');
				string notes = vals[6];
				int[] indexs = GetIndexs(notes);

				string num = vals[0].Trim().Split(' ')[0];
				string seq = vals[5].Replace("|", "I");
				string[] seq2 = notes.Split(' ');
				string identifier = vals[3];
				string notation = GetNotation(seq2);

				Console.WriteLine((count + 1) + " " + identifier);
				CreateMidi("Chandassu: " + identifier + " Sequence: " + seq + " Notation: " + notation, indexs,
								2,
								new int[] { 4, 5, 6, 127 },
								new int[] { 3, 6 },
							"midi\\" + num + "." + identifier + "." + seq + "." + notation);
			}
		}

		private void CreateMidi(string trackName, int[] notes, int tempo, int[] instruments, int[] durations, string fileName)
		{

			MIDISong song = new MIDISong();
			song.AddTrack(trackName);
			song.SetTimeSignature(0, 4, 4);
			song.SetTempo(0, m_nBeats[tempo]);

			for (int channel = 0; channel < instruments.Length; channel++)
			{
				song.SetChannelInstrument(0, channel, instruments[channel]);
				foreach (int duration in durations)
				{
					for (int i = 0; i < notes.Length; i++)
					{
						int noteNumber = notes[i];
						noteNumber += 12 * (6 + (channel % 2));
						song.AddNote(0, channel, noteNumber, duration);
					}
				}
			}


			try
			{
				MemoryStream ms = new MemoryStream();
				song.Save(ms);
				ms.Seek(0, SeekOrigin.Begin);
				byte[] src = ms.GetBuffer();
				byte[] dst = new byte[src.Length];
				for (int i = 0; i < src.Length; i++)
				{
					dst[i] = src[i];
				}
				ms.Close();
				FileInfo FI = new FileInfo(fileName + ".mid");
				if (!FI.Directory.Exists)
				{
					FI.Directory.Create();
				}
				FileStream objWriter = File.Create(FI.FullName);
				objWriter.Write(dst, 0, dst.Length);
				objWriter.Close();
				objWriter.Dispose();
				objWriter = null;

			}
			catch (Exception e)
			{
				throw e;
			}

		}

		private string GetNotation(string[] strings)
		{
			string[] Notations = new string[] { "C", "D", "E", "F", "G", "A", "B" };
			List<string> list = new List<string>();

			foreach (string str in strings)
			{
				int index = GetIndex2(str);
				list.Add(Notations[index]);
			}
			string s = String.Join("", list.ToArray());
			return s;
		}


		private int[] GetIndexs(string str)
		{
			List<int> list = new List<int>();
			foreach (string c in str.Split(' '))
			{
				list.Add(GetIndex(c));

			}

			return list.ToArray();
		}

		private int GetIndex(string c)
		{
			switch (c)
			{
				case "స":
					return 0;

				case "రి":
					return 2;

				case "గ":
					return 4;
				case "మ":
					return 5;

				case "ప":
					return 7;

				case "ద":
					return 9;


				case "ని":
					return 11;
				default:
					throw new Exception("");
			}
		}

		private int GetIndex2(string c)
		{
			switch (c)
			{
				case "స":
					return 0;

				case "రి":
					return 1;

				case "గ":
					return 2;
				case "మ":
					return 3;

				case "ప":
					return 4;

				case "ద":
					return 5;


				case "ని":
					return 6;
				default:
					throw new Exception("");
			}
		}

		//http://www.rickleinecker.com/Rick-Leinecker-Creating-And-Playing-Random-MIDI-Files.html
		int[][] Notes = new int[][]
		{
			//			C  C# D  D# E  F  F# G  G# A A# B
			new int[]{  0 ,1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10 ,11}, //-1
			new int[]{ 12 ,13 ,14 ,15 ,16 ,17 ,18 ,19 ,20 ,21 ,22 ,23},//0
			new int[]{ 24 ,25 ,26 ,27 ,28 ,29 ,30 ,31 ,32 ,33 ,34 ,35},//1
			new int[]{ 36 ,37 ,38 ,39 ,40 ,41 ,42 ,43 ,44 ,45 ,46 ,47},//2
			new int[]{ 48 ,49 ,50 ,51 ,52 ,53 ,54 ,55 ,56 ,57 ,58 ,59},//3
			new int[]{ 60 ,61 ,62 ,63 ,64 ,65 ,66 ,67 ,68 ,69 ,70 ,71},//4
			new int[]{ 72 ,73 ,74 ,75 ,76 ,77 ,78 ,79 ,80 ,81 ,82 ,83},//5
			new int[]{ 84 ,85 ,86 ,87 ,88 ,89 ,90 ,91 ,92 ,93 ,94 ,95},//6
			new int[]{ 96 ,97 ,98 ,99 ,100 ,101 ,102 ,103 ,104 ,105 ,106 ,107},//7
			new int[]{ 108 ,109 ,110 ,111 ,112 ,113 ,114 ,115 ,116 ,117 ,118 ,119},//8
			new int[]{ 120 ,121 ,122 ,123 ,124 ,125 ,126 ,127}//9
		};
		static int[] m_nBeats = { 72, 112, 150 };
		static string[] m_InstrumentNames =
		{
			"Acoustic Grand Piano",//0
			"Bright Acoustic Piano",//1
			"Electric Grand Piano",//2
			"Honky-tonk Piano",//3
			"Electric Piano 1",//4
			"Electric Piano 2",//5
			"Harpsichord",//6
			"Clavinet",//7
			"Celesta",//8
			"Glockenspiel",//9
			"Music Box",//10
			"Vibraphone",//11
			"Marimba",//12
			"Xylophone",//13
			"Tubular Bells",//14
			"Dulcimer",//15
			"Drawbar Organ",//16
			"Percussive Organ",//17
			"Rock Organ",//18
			"Church Organ",//19
			"Reed Organ",//20
			"Accordion",//21
			"Harmonica",//22
			"Tango Accordion",//23
			"Acoustic Guitar (nylon)",//24
			"Acoustic Guitar (steel)",//25
			"Electric Guitar (jazz)",//26
			"Electric Guitar (clean)",//27
			"Electric Guitar (muted)",//28
			"Overdriven Guitar",//29
			"Distortion Guitar",//30
			"Guitar harmonics",//31
			"Acoustic Bass",//32
			"Electric Bass (finger)",//33
			"Electric Bass (pick)",//34
			"Fretless Bass",//35
			"Slap Bass 1",//36
			"Slap Bass 2",//37
			"Synth Bass 1",//38
			"Synth Bass 2",//39
			"Violin",//40
			"Viola",//41
			"Cello",//42
			"Contrabass",//43
			"Tremolo Strings",//44
			"Pizzicato Strings",//45
			"Orchestral Harp",//46
			"Timpani",//47
			"String Ensemble 1",//48
			"String Ensemble 2",//49
			"Synth Strings 1",//50
			"Synth Strings 2",//51
			"Choir Aahs",//52
			"Voice Oohs",//53
			"Synth Choir",//54
			"Orchestra Hit",//55
			"Trumpet",//56
			"Trombone",//57
			"Tuba",//58
			"Muted Trumpet",//59
			"French Horn",//60
			"Brass Section",//61
			"Synth Brass 1",//62
			"Synth Brass 2",//63
			"Soprano Sax",//64
			"Alto Sax",//65
			"Tenor Sax",//66
			"Baritone Sax",//67
			"Oboe",//68
			"English Horn",//69
			"Bassoon",//70
			"Clarinet",//71
			"Piccolo",//72
			"Flute",//73
			"Recorder",//74
			"Pan Flute",//75
			"Blown Bottle",//76
			"Shakuhachi",//77
			"Whistle",//78
			"Ocarina",//79
			"Lead 1 (square)",//80
			"Lead 2 (sawtooth)",//81
			"Lead 3 (calliope)",//82
			"Lead 4 (chiff)",//83
			"Lead 5 (charang)",//84
			"Lead 6 (voice)",//85
			"Lead 7 (fifths)",//86
			"Lead 8 (bass + lead)",//87
			"Pad 1 (new age)",//88
			"Pad 2 (warm)",//89
			"Pad 3 (polysynth)",//90
			"Pad 4 (choir)",//91
			"Pad 5 (bowed)",//92
			"Pad 6 (metallic)",//93
			"Pad 7 (halo)",//94
			"Pad 8 (sweep)",//95
			"FX 1 (rain)",//96
			"FX 2 (soundtrack)",//97
			"FX 3 (crystal)",//98
			"FX 4 (atmosphere)",//99
			"FX 5 (brightness)",//100
			"FX 6 (goblins)",//101
			"FX 7 (echoes)",//102
			"FX 8 (sci-fi)",//103
			"Sitar",//104
			"Banjo",//105
			"Shamisen",//106
			"Koto",//107
			"Kalimba",//108
			"Bag pipe",//109
			"Fiddle",//110
			"Shanai",//111
			"Tinkle Bell",//112
			"Agogo",//113
			"Steel Drums",//114
			"Woodblock",//115
			"Taiko Drum",//116
			"Melodic Tom",//117
			"Synth Drum",//118
			"Reverse Cymbal",//119
			"Guitar Fret Noise",//120
			"Breath Noise",//121
			"Seashore",//122
			"Bird Tweet",//123
			"Telephone Ring",//124
			"Helicopter",//125
			"Applause",//126
			"Gunshot",//127
		};
	}
}
