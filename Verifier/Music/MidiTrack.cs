//---------------------------------------------------------------------------------------------
// <copyright file="MidiTrack.cs" company="Chandam-ఛందం">
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
	/// MIDITrack represents one track of a standard MIDISong file. A MIDI track consists of multiple "Events".
	/// Events can be defined as swqitches of instruments, tempo / time signature settings, and song notes / rests.
	/// </summary>
	class MIDITrack
	{
		private String TrackName;
		public int TrackNumber;

		/// <summary>
		/// This list holds the event information for the track. Each event is itself
		/// a list of bytes.
		/// </summary>
		private List<List<byte>> Events;

		/// <summary>
		/// Constructor (standard).
		/// </summary>
		/// <param name="TrackNumber">The defined track number for the new track. This number will be used to refer to the track when adding events.</param>
		/// <param name="TrackName">The human-readable track name for the new track.</param>
		public MIDITrack(int TrackNumber, String TrackName)
		{
			// create a list of bytes that represents the track's human-readable name.
			List<byte> trackHeader = new List<byte>();

			// populate the local holder variables for the track's number and human-readable name.
			this.TrackNumber = TrackNumber;
			this.TrackName = TrackName;

			// instantiate the list of Events.
			Events = new List<List<byte>>();

			// populate the header event with the standard MIDI track header.
			trackHeader.Add(0x00);
			trackHeader.Add(0xFF);
			trackHeader.Add(0x03);

			// Write out the length of the track's human-readable name (as a string of characters). This is 
			// defined to be a variable length quantity.
			VariableLength.WriteVariableLength(trackHeader, (ulong)TrackName.Length);

			// Go through each character in the track's human-readable name. Write it out as an ASCII byte.
			for (int x = 0; x < TrackName.Length; x++)
			{
				trackHeader.Add((byte)TrackName[x]);
			}

			// add the track's name as an event.
			Events.Add(trackHeader);
		}

		/// <summary>
		/// SetTimeSignature(int, int, int) specifies the time signature of a given track. It is designed to take in standard, human-readable
		/// time signatures (e.g. 4/4 or 6/8). The human-readable time signatures are then translated into MIDI-format data packets.
		/// </summary>
		/// <param name="Numerator">The numerator of the human-readable time signature "fraction" (e.g. the "6" in 6/8).</param>
		/// <param name="Denominator">The denominator of the human-readable time signature "fraction" (e.g. the "8" in 6/8).</param>
		public void SetTimeSignature(int Numerator, int Denominator)
		{
			int midiDenominator;
			List<byte> newByteArray = new List<byte>();

			// the user enters a human-readable time signature denominator.
			// MIDI stores the denominator as a power of 2 (e.g. 4 is stored as 2, 8 is stored as 3, 16 is stored as 4, etc.)
			// To determine the MIDI denominator, a log base 2 operation must be carried out on the human-readable denominator.
			midiDenominator = (int)Math.Log(Denominator, 2);

			// time signature command is a non-MIDI event (starting with 0xFF).
			// it is type 0x58).
			// The 0x04 defines 4 bytes following the command header. The four bytes are as follows:
			// nn dd cc bb
			// nn: numerator of time signature "fraction" (6 in 6/8)
			// dd: The log base 2 of the denominator of the time signature fraction (log(2) of 8 in 6/8).
			// cc: The number of ticks in a metronome click. By default, this is defined as 24 (0x18).
			// bb: The number of 32nd note sin a quarter-note. By default, this is defined as 8 (0x08).
			newByteArray.Add(0x00);
			newByteArray.Add(0xFF);
			newByteArray.Add(0x58);
			newByteArray.Add(0x04);
			newByteArray.Add((byte)Numerator);
			newByteArray.Add((byte)midiDenominator);
			newByteArray.Add(0x18);
			newByteArray.Add(0x08);

			Events.Add(newByteArray);
		}

		/// <summary>
		/// SetTempo(int, int) sets the tempo (in beats per minute) of a given track.
		/// </summary>
		/// <param name="Tempo">The number of beats per minute that will define the "tempo" of the MIDI file. If this function is not called, 100 beats per minute is selected to be standard.</param>
		public void SetTempo(int Tempo)
		{
			int microsecondsPerQuarterNote;
			List<byte> newByteArray = new List<byte>();

			// as per the MIDI specification, tempo is stored in the number of microseconds per quarter note.
			// this function takes in a BeatsPerMinute (int Tempo). To find the number of microseconds per quarter note,
			// 60,000,000 must be divided by the number of beats per minute (one quarter note is defined as one beat).
			microsecondsPerQuarterNote = 60000000 / Tempo;

			// write out the Tempo command. The Tempo command is a non-MIDI event (starting with 0xFF).
			// The Tempo command is defined as command 0x51. The 0x03 declares that three bytes of data follow
			// the Tempo command header.
			// the 3 bytes of data are defined to be the quantity (microsecondsPerQuarterNote (see above)), staring with the
			// big-endian most significant byte (0xFF 00 00).
			newByteArray.Add(0x00);
			newByteArray.Add(0xFF);
			newByteArray.Add(0x51);
			newByteArray.Add(0x03);
			newByteArray.Add(((byte)((0xFF0000 & microsecondsPerQuarterNote) >> 16)));
			newByteArray.Add(((byte)((0xFF00 & microsecondsPerQuarterNote) >> 8)));
			newByteArray.Add(((byte)(0xFF & microsecondsPerQuarterNote)));

			Events.Add(newByteArray);
		}

		/// <summary>
		/// SetChannelInstrument(int, int, int) allows users to specify a MIDI-specific instrument for a given track.
		/// The MIDI instruments are defined by the MIDI specification. If not specified, the standard "grand piano" (MIDI instrument 1) is selected by default.
		/// </summary>
		/// <param name="Channel">The channel number to assign to the given instrument. MIDI has 16 channels. By default, each track is assigned its own channel from which to operate.</param>
		/// <param name="Instrument">The number (integer) of the MIDI instrument being assigned. See the MIDI specification for more information on the MIDI standard instruments.</param>
		public void SetChannelInstrument(int Channel, int Instrument)
		{
			List<byte> newByteArray = new List<byte>();

			// the MIDI instrument (program change) command is defined as a MIDI-event (no need for a leading 0xFF).
			// It is defined as 0xCX where "X" is the channel number (0x0 - 0xF) to which the given instrument will be tied.
			// the MIDI standard instrument number follows.
			newByteArray.Add(0x00);
			newByteArray.Add((byte)((0xC << 4) | (byte)Channel));
			newByteArray.Add((byte)Instrument);

			Events.Add(newByteArray);
		}

		/// <summary>
		/// AddNote(int, int, int, int) allows users to add playable notes to the MIDI file.
		/// </summary>
		/// <param name="nChannel">The track's channel (0 - 16) through which the note will be played.</param>
		/// <param name="nMidiNoteNumber">The MIDI note number (0 for low-C, etc.) that should be played. These note numbers are specified by the MIDI standard specification.</param>
		/// <param name="nDuration">The duration, in time ticks, that the note should be played before stopping. The timing is specified as below:
		/// 48: Whole Note
		/// 24: Half Note
		/// 12: Quarter Note
		/// 6: Eighth (1/8) Note
		/// 4: Tripolet Note
		/// 3: 1/16 Note
		/// -1: Rest
		/// </param>
		public void AddNote(int nChannel, int nMidiNoteNumber, int nDuration)
		{
			// It is useful to note here that the time of a MIDI file is cumulative. That is,
			// at any given point, an "offset" or time stamp of 0x00 means "presently" (the time when the last
			// event concluded.
			// Therefore, when adding a note, an initial time-stamp of 0x00 is used.
			// When stopping a note (ending a note), a duration is used as a time-stamp, representing the length of the note.

			// if the user entered a rest, start the note as being not-pressed.
			if (nMidiNoteNumber != -1)
			{
				AddNoteEvent(true, nChannel, nMidiNoteNumber, 0x00);
				AddNoteEvent(false, nChannel, nMidiNoteNumber, (byte)nDuration);
			}
			else
			// otherwise, start the note as being pressed.
			{
				AddNoteEvent(false, nChannel, 0, 0x00);
				AddNoteEvent(false, nChannel, 0, (byte)nDuration);
			}
		}

		/// <summary>
		/// AddNotes(int, int[], int[], int[]) allows programmers to add multiple simultaneous notes, being played on multiple channels. The AddNote() function (see above)
		/// allows the addition of one note, played by itself, for a given duration (1/4 note, 1/2 note, etc.). This function allows programmers
		/// to specify chords of multiple notes.
		/// </summary>
		/// <param name="nChannel">The track number's channels through which the multiple notes will be played.</param>
		/// <param name="nMidiNoteNumber">An array of standard MIDI note numbers (see the AddNote() function). The length of this array should match the length of the nDuration[] array.</param>
		/// <param name="nDuration">An array of note lengths (in time ticks) (see the AddNote() function above). The length of this array should match the length of the nMidiNoteNumber[] array. Note durations are defined as below:
		/// 48: Whole Note
		/// 24: Half Note
		/// 12: Quarter Note
		/// 6: Eighth (1/8) Note
		/// 4: Tripolet Note
		/// 3: 1/16 Note
		/// -1: Rest
		/// </param>
		public void AddNotes(int[] nChannel, int[] nMidiNoteNumber, int[] nDuration)
		{
			// It is useful to note here that the time of a MIDI file is cumulative. That is,
			// at any given point, an "offset" or time stamp of 0x00 means "presently" (the time when the last
			// event concluded.
			// Therefore, when adding a note, an initial time-stamp of 0x00 is used.
			// When stopping a note (ending a note), a duration is used as a time-stamp, representing the length of the note.

			int holder, counter, x;

			// first, we must order the instructions by duration (the ones that end farther in the future must be last).
			// below is code to perform a simple bubble sort.
			for (x = 0; x < nDuration.Length; x++)
			{
				for (int y = x + 1; y < nDuration.Length; y++)
				{
					if (nDuration[x] > nDuration[y])
					{
						// if the current item's duration is greater than its neighbor's duration
						// switch the two. As this loop executes, this will effectively "bubble" the notes with the
						// longest durations to the end of the array.
						holder = nDuration[x];
						nDuration[x] = nDuration[y];
						nDuration[y] = holder;

						holder = nMidiNoteNumber[x];
						nMidiNoteNumber[x] = nMidiNoteNumber[y];
						nMidiNoteNumber[y] = holder;
					}
				}
			}

			// go through each of the notes, now sorted. The code below is an exact
			// duplicate of the AddNote() function (above). If the note is a rest, start out with the note not-pressed.
			// Otherwise, we must start with the note pressed.
			for (x = 0; x < nMidiNoteNumber.Length; x++)
			{
				if (nMidiNoteNumber[x] == -1)
				{
					AddNoteEvent(false, nChannel[x], 0, 0x00);
				}
				else
				{
					AddNoteEvent(true, nChannel[x], nMidiNoteNumber[x], 0x00);
				}
			}

			// set a counter to the first note's duration. This will be the quickest
			// duration of the note array, as the note array was previously sorted.
			counter = nDuration[0];

			// stop the first note, as is done with the AddNote() function.
			if (nMidiNoteNumber[0] == -1)
			{
				AddNoteEvent(false, nChannel[0], 0, (byte)counter);
			}
			else
			{
				AddNoteEvent(false, nChannel[0], nMidiNoteNumber[0], (byte)counter);
			}

			// go through the rest of the notes. 
			// as each note is stopped, we update counter to reflect the note's duration.
			// This effectively allows us to have "simultaneous" notes of different durations.
			// If a quarter note and a half note are started simultaneously, the quarter note will end
			// before the half note, as the half note has a longer duration.
			for (x = 1; x < nMidiNoteNumber.Length; x++)
			{
				if (nMidiNoteNumber[x] == -1)
				{
					AddNoteEvent(false, nChannel[x], 0, (byte)counter);
				}
				else
				{
					AddNoteEvent(false, nChannel[x], nMidiNoteNumber[x], (byte)(nDuration[x] - counter));
				}
			}
		}

		/// <summary>
		/// AddNotes(int, int, int[], int[]) allows programmers to add multiple simultaneous notes. The AddNote() function (see above)
		/// allows the addition of one note, played by itself, for a given duration (1/4 note, 1/2 note, etc.). This function allows programmers
		/// to specify chords of multiple notes.
		/// </summary>
		/// <param name="nChannel">The track number's channel through which the multiple notes will be played.</param>
		/// <param name="nMidiNoteNumber">An array of standard MIDI note numbers (see the AddNote() function). The length of this array should match the length of the nDuration[] array.</param>
		/// <param name="nDuration">An array of note lengths (in time ticks) (see the AddNote() function above). The length of this array should match the length of the nMidiNoteNumber[] array. Note durations are defined as below:
		/// 48: Whole Note
		/// 24: Half Note
		/// 12: Quarter Note
		/// 6: Eighth (1/8) Note
		/// 4: Tripolet Note
		/// 3: 1/16 Note
		/// -1: Rest
		/// </param>
		public void AddNotes(int nChannel, int[] nMidiNoteNumber, int[] nDuration)
		{
			// It is useful to note here that the time of a MIDI file is cumulative. That is,
			// at any given point, an "offset" or time stamp of 0x00 means "presently" (the time when the last
			// event concluded.
			// Therefore, when adding a note, an initial time-stamp of 0x00 is used.
			// When stopping a note (ending a note), a duration is used as a time-stamp, representing the length of the note.

			int holder, counter, x;

			// first, we must order the instructions by duration (the ones that end farther in the future must be last).
			// below is code to perform a simple bubble sort.
			for (x = 0; x < nDuration.Length; x++)
			{
				for (int y = x + 1; y < nDuration.Length; y++)
				{
					if (nDuration[x] > nDuration[y])
					{
						// if the current item's duration is greater than its neighbor's duration
						// switch the two. As this loop executes, this will effectively "bubble" the notes with the
						// longest durations to the end of the array.
						holder = nDuration[x];
						nDuration[x] = nDuration[y];
						nDuration[y] = holder;

						holder = nMidiNoteNumber[x];
						nMidiNoteNumber[x] = nMidiNoteNumber[y];
						nMidiNoteNumber[y] = holder;
					}
				}
			}

			// go through each of the notes, now sorted. The code below is an exact
			// duplicate of the AddNote() function (above). If the note is a rest, start out with the note not-pressed.
			// Otherwise, we must start with the note pressed.
			for (x = 0; x < nMidiNoteNumber.Length; x++)
			{
				if (nMidiNoteNumber[x] == -1)
				{
					AddNoteEvent(false, nChannel, 0, 0x00);
				}
				else
				{
					AddNoteEvent(true, nChannel, nMidiNoteNumber[x], 0x00);
				}
			}

			// set a counter to the first note's duration. This will be the quickest
			// duration of the note array, as the note array was previously sorted.
			counter = nDuration[0];

			// stop the first note, as is done with the AddNote() function.
			if (nMidiNoteNumber[0] == -1)
			{
				AddNoteEvent(false, nChannel, 0, (byte)counter);
			}
			else
			{
				AddNoteEvent(false, nChannel, nMidiNoteNumber[0], (byte)counter);
			}

			// go through the rest of the notes. 
			// as each note is stopped, we update counter to reflect the note's duration.
			// This effectively allows us to have "simultaneous" notes of different durations.
			// If a quarter note and a half note are started simultaneously, the quarter note will end
			// before the half note, as the half note has a longer duration.
			for (x = 1; x < nMidiNoteNumber.Length; x++)
			{
				if (nMidiNoteNumber[x] == -1)
				{
					AddNoteEvent(false, nChannel, 0, (byte)counter);
				}
				else
				{
					AddNoteEvent(false, nChannel, nMidiNoteNumber[x], (byte)(nDuration[x] - counter));
				}
			}
		}

		/// <summary>
		/// AddNoteEvent() provides a workhorse method for the AddNote() and AddNotes() methods.
		/// Specifically, the AddNoteEvent method translates the specific notes into MIDI-format event commands.
		/// </summary>
		/// <param name="onOff">A boolean representing whether the note is beginning (analagous to a musician pressing a key) or if it is ending (analagous to a musician releasing a key). True is ON (pressing a key), and false is OFF (releasing a key).</param>
		/// <param name="nChannel">The track's channel through which the note event will be played.</param>
		/// <param name="nMidiNoteNumber">The note number (see MIDI specification for standard note numbers) that will be played or released.</param>
		/// <param name="offset">The time-tick offset after which this event will take place. A note is defined by the following sequence:
		/// 1. Call the AddNoteEvent() function with onOff defined as true for a given note, offset = 0.
		/// 2. Call the AddNoteEvent() function with onOff defined as false for a given note, offset = duration of note.
		/// The duration of the note can be found by viewing the documentation for the AddNote() and AddNotes() functions. A quarter-note is defined as 12 time-ticks.
		/// </param>
		private void AddNoteEvent(bool onOff, int nChannel, int nMidiNoteNumber, byte offset)
		{
			List<byte> newByteArray = new List<byte>();

			// write out the duration of the note as a variable length quantity.
			VariableLength.WriteVariableLength(newByteArray, offset);

			// newByteArray.Add(0xFF);

			// if the user selected true for onOff (note pressed), the 0x9X MIDI command must be used.
			// otherwise, the 0x8X MIDI command must be used.
			if (onOff == true)
			{
				newByteArray.Add((byte)((0x9 << 4) | (byte)nChannel));
			}
			else
			{
				newByteArray.Add((byte)((0x8 << 4) | (byte)nChannel));
			}

			// write out the standard MIDI note number that will be played, followed by its velocity.
			// the velocity is analogous to the pressure a musician would apply on a key. It is defined as 0x7F (full).
			newByteArray.Add((byte)nMidiNoteNumber);
			newByteArray.Add(0x7F);


			// write out the new event.
			Events.Add(newByteArray);
		}

		/// <summary>
		/// The Save() method outputs the contents of the Track in standard MIDI format.
		/// This function is called by the MIDISong class when its specific Save() function is called.
		/// </summary>
		/// <param name="objWriter">A FileStream representing a standard .mid or .midi file, opened by the calling code blocks.</param>
		public void Save(MemoryStream objWriter)
		{
			ulong chunkLength = 0;

			// count the total length of the track (in bytes).
			for (int x = 0; x < Events.Count; x++)
			{
				chunkLength += (ulong)Events[x].Count;
			}

			// count the room for the end of chunk header.
			chunkLength += 4;

			// write out the standard track header.
			objWriter.WriteByte(0x4D);
			objWriter.WriteByte(0x54);
			objWriter.WriteByte(0x72);
			objWriter.WriteByte(0x6B);

			// output four bytes of the track's length (in bytes), beginning with the
			// big-endian most significant (0xFF 00 00 00).
			objWriter.WriteByte((byte)((chunkLength & 0xFF000000) >> 24));
			objWriter.WriteByte((byte)((chunkLength & 0xFF0000) >> 16));
			objWriter.WriteByte((byte)((chunkLength & 0xFF00) >> 8));
			objWriter.WriteByte((byte)(chunkLength & 0xFF));

			// go through each event in the track and output the event's specific bytes
			// in order.
			for (int x = 0; x < Events.Count; x++)
			{
				for (int y = 0; y < Events[x].Count; y++)
				{
					objWriter.WriteByte((Events[x])[y]);
				}
			}

			// end of track marker.
			objWriter.WriteByte(0x00);
			objWriter.WriteByte(0xFF);
			objWriter.WriteByte(0x2F);
			objWriter.WriteByte(0x00);
		}

		/// <summary>
		/// GetName() is an accessor method that returns the track's human-readable name.
		/// </summary>
		/// <returns>The track's human-readable name (stored in the String TrackName)</returns>
		public string GetName()
		{
			return TrackName;
		}
	}
}
