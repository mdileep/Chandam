//---------------------------------------------------------------------------------------------
// <copyright file="MidiSong.cs" company="Chandam-ఛందం">
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
	/// MIDISong represents a standard MIDI Song, consisting of multiple Tracks of notes.
	/// </summary>
	public class MIDISong
	{
		/// <summary>
		/// A song contains a list of MIDITrack objects, representing the song's various tracks.
		/// </summary>
		private List<MIDITrack> Tracks;

		/// <summary>
		/// Asynchronous keeps track of whether the file has multiple tracks with multiple channels per track,
		/// or multiple tracks with a single channel per track. Asynchonous set to "false" indicates a MIDI file format 
		/// of 1, meaning multiple tracks, single channel per track.
		/// </summary>
		private bool asynchronous;

		/// <summary>
		/// Constructor (standard). Accepts no inputs.
		/// </summary>
		public MIDISong()
		{
			// instantiate the list of MIDITrack objects.
			Tracks = new List<MIDITrack>();
			asynchronous = false;
		}

		/// <summary>
		/// ContainsTrack(string) is a private method allowing the system to check if a 
		/// track of the same name has already been created. Note: this function is case sensitive.
		/// </summary>
		/// <param name="strName">A track name to check against the list of currently-created tracks.</param>
		/// <returns>Boolean: true if strName already exists in the list of tracks, false if strName does not exist.</returns>
		private bool ContainsTrack(string strName)
		{
			// go through each one of the tracks and check to see if its name matches strName.
			for (int x = 0; x < Tracks.Count; x++)
			{
				if (Tracks[x].GetName().Equals(strName))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// AddTrack(string) allows a user to add a new track to the MIDI file. It accepts a string, representing a 
		/// human-readable name for the track (e.g. "Track 1"),
		/// </summary>
		/// <param name="strName">A track name to tie with the newly-created track. This string should be human-readable.</param>
		/// <returns>Integer: The track number (ID) for the newly-created track. This track number will be used to reference the track when adding notes, setting tempos, etc.</returns>
		public int AddTrack(string strName)
		{
			// use ContainsTrack(string) to check if the track already exists. If it does not, it can be added.
			if (ContainsTrack(strName) == true)
			{
				throw (new Exception("Track of name " + strName + " already exists."));
			}

			// Add a new track to the list of tracks.
			Tracks.Add(new MIDITrack(Tracks.Count, strName));

			// Return the number of the newly-added track. Note how lists are similar to arrays in that they are zero-justified.
			return Tracks.Count - 1;
		}

		/// <summary>
		/// SetTimeSignature(int, int, int) specifies the time signature of a given track. It is designed to take in standard, human-readable
		/// time signatures (e.g. 4/4 or 6/8). The human-readable time signatures are then translated into MIDI-format data packets.
		/// </summary>
		/// <param name="nTrack">The track number (see AddTrack(string)) whose time signature is being specified.</param>
		/// <param name="nTimeSignatureNumerator">The numerator of the human-readable time signature "fraction" (e.g. the "6" in 6/8).</param>
		/// <param name="nTimeSignatureDenominator">The denominator of the human-readable time signature "fraction" (e.g. the "8" in 6/8).</param>
		public void SetTimeSignature(int nTrack, int nTimeSignatureNumerator, int nTimeSignatureDenominator)
		{
			// check to see if the user entered a valid track. If too few tracks exist (the user entered a track number outside of the
			// acceptable range), throw an error.
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			// select the applicable track from the list and call its specific SetTimeSignature function.
			Tracks[nTrack].SetTimeSignature(nTimeSignatureNumerator, nTimeSignatureDenominator);
		}

		/// <summary>
		/// SetTempo(int, int) sets the tempo (in beats per minute) of a given track.
		/// </summary>
		/// <param name="nTrack">The track number (see AddTrack(string)) whose tempo is being specified.</param>
		/// <param name="nBeatsPerMinute">The number of beats per minute that will define the "tempo" of the MIDI file. If this function is not called, 100 beats per minute is selected to be standard.</param>
		public void SetTempo(int nTrack, int nBeatsPerMinute)
		{
			// check to see if the user entered a valid track. If too few tracks exist (the user entered a track number outside of the
			// acceptable range), throw an error.
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			// select the applicable track from the list and call its specific SetTempo function.
			Tracks[nTrack].SetTempo(nBeatsPerMinute);
		}

		/// <summary>
		/// SetChannelInstrument(int, int, int) allows users to specify a MIDI-specific instrument for a given track.
		/// The MIDI instruments are defined by the MIDI specification. If not specified, the standard "grand piano" (MIDI instrument 1) is selected by default.
		/// </summary>
		/// <param name="nTrack">The track number (see AddTrack(string)) whose instrument is being specified.</param>
		/// <param name="nChannel">The channel number to assign to the given instrument. MIDI has 16 channels. By default, each track is assigned its own channel from which to operate.</param>
		/// <param name="nGeneralMidiNumber">The number (integer) of the MIDI instrument being assigned. See the MIDI specification for more information on the MIDI standard instruments.</param>
		public void SetChannelInstrument(int nTrack, int nChannel, int nGeneralMidiNumber)
		{
			// check to see if the user entered a valid track. If too few tracks exist (the user entered a track number outside of the
			// acceptable range), throw an error.
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			// check to see if the user entered a valid channel. Valid channels range from 0 - 16 (0x0 - 0xF hexadecimal). If the user
			// entered either a negative number or an integer value greater than 0xF, the channel is invalid; throw an error.
			if (nChannel > 0xF || nChannel < 0x0)
			{
				throw (new Exception("Invalid channel number. Channel number outside range of 0 - 15 (0x0 - 0xF)"));
			}

			// select the applicable track from the list and call its specific SetChannelInstrument function.
			Tracks[nTrack].SetChannelInstrument(nChannel, nGeneralMidiNumber);
		}

		/// <summary>
		/// AddNote(int, int, int, int) allows users to add playable notes to the MIDI file.
		/// </summary>
		/// <param name="nTrack">The track number (see AddTrack(string)) to which a note is being added.</param>
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
		public void AddNote(int nTrack, int nChannel, int nMidiNoteNumber, int nDuration)
		{
			// check to see if the user entered a valid track. If too few tracks exist (the user entered a track number outside of the
			// acceptable range), throw an error.
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			// check to see if the user entered a valid channel. Valid channels range from 0 - 16 (0x0 - 0xF hexadecimal). If the user
			// entered either a negative number or an integer value greater than 0xF, the channel is invalid; throw an error.
			if (nChannel > 0xF || nChannel < 0x0)
			{
				throw (new Exception("Invalid channel number. Channel number outside range of 0 - 15 (0x0 - 0xF)"));
			}

			// select the applicable track from the list and call its specific AddNote function.
			Tracks[nTrack].AddNote(nChannel, nMidiNoteNumber, nDuration);
		}

		/// <summary>
		/// AddNotes(int, int[], int[], int[]) allows programmers to add multiple simultaneous notes to multiple, simultaneous channels. The AddNote() function (see above)
		/// allows the addition of one note, played by itself, ofr a given duration (1/4 note, 1/2, etc.). This function allows programmers 
		/// the specify chords of multiple notes to be played on multiple channels.
		/// </summary>
		/// <param name="nTrack">The track number to which multiple notes are being added.</param>
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
		public void AddNotes(int nTrack, int[] nChannel, int[] nMidiNoteNumber, int[] nDuration)
		{
			// check to see if the user entered a valid track. If too few tracks exist (the user entered a track number outside of the
			// acceptable range), throw an error.
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			// check to see if the user entered a valid channel. Valid channels range from 0 - 16 (0x0 - 0xF hexadecimal). If the user
			// entered either a negative number or an integer value greater than 0xF, the channel is invalid; throw an error.
			for (int x = 0; x < nChannel.Length; x++)
			{
				if (nChannel[x] > 0xF || nChannel[x] < 0x0)
				{
					throw (new Exception("Invalid channel number " + nChannel[x] + ". Channel number outside range of 0 - 15 (0x0 - 0xF)"));
				}
			}

			asynchronous = true;

			// select the applicable track from the list, and call its specific AddNotes() function.
			Tracks[nTrack].AddNotes(nChannel, nMidiNoteNumber, nDuration);
		}

		/// <summary>
		/// AddNotes(int, int, int[], int[]) allows programmers to add multiple simultaneous notes. The AddNote() function (see above)
		/// allows the addition of one note, played by itself, for a given duration (1/4 note, 1/2 note, etc.). This function allows programmers
		/// to specify chords of multiple notes.
		/// </summary>
		/// <param name="nTrack">The track number to which multiple notes are being added.</param>
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
		public void AddNotes(int nTrack, int nChannel, int[] nMidiNoteNumber, int[] nDuration)
		{
			// check to see if the user entered a valid track. If too few tracks exist (the user entered a track number outside of the
			// acceptable range), throw an error.
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			// check to see if the user entered a valid channel. Valid channels range from 0 - 16 (0x0 - 0xF hexadecimal). If the user
			// entered either a negative number or an integer value greater than 0xF, the channel is invalid; throw an error.
			if (nChannel > 0xF || nChannel < 0x0)
			{
				throw (new Exception("Invalid channel number. Channel number outside range of 0 - 15 (0x0 - 0xF)"));
			}

			// select the applicable track from the list, and call its specific AddNotes() function.
			Tracks[nTrack].AddNotes(nChannel, nMidiNoteNumber, nDuration);
		}

		/// <summary>
		/// DeleteTrack(int nTrack) allows programmers to remove an already-specified track from the list of tracks. NOTE: the track numbers update, as in an ArrayList,
		/// when DeleteTrack() is called. Therefore, if a track listing contains Track 1, Track 2, and Track 3, and Track 1 is removed via the DeleteTrack() method, Tracks 2 and 3
		/// are renamed Tracks 1 and 2 to compensate for the removal.
		/// </summary>
		/// <param name="nTrack">The track number to be deleted.</param>
		public void DeleteTrack(int nTrack)
		{
			if (Tracks.Count < nTrack)
			{
				throw (new Exception("Track does not exist. Input nTrack invalid number."));
			}

			Tracks.RemoveAt(nTrack);

			// renumber the tracks currently in the list (reduce each by one).
			for (int x = nTrack; x < Tracks.Count; x++)
			{
				Tracks[x].TrackNumber--;
			}
		}

		/// <summary>
		/// Save() outputs a complete MIDI file. It accepts a FileStream that must be defined and instantiated by the calling code blocks.
		/// </summary>
		/// <param name="objWriter">A FileStream pointing to an open .mid or .midi file for output.</param>
		public void Save(MemoryStream objWriter)
		{
			// go back to the beginning of the file.
			objWriter.Seek(0, SeekOrigin.Begin);

			// write the MIDI header:
			objWriter.WriteByte(0x4D);
			objWriter.WriteByte(0x54);
			objWriter.WriteByte(0x68);
			objWriter.WriteByte(0x64);

			// write three bytes of 0x00.
			for (int x = 0; x < 3; x++)
			{
				objWriter.WriteByte(0x00);
			}

			// define the length of the MIDI header (always 0x6).
			objWriter.WriteByte(0x06);
			objWriter.WriteByte(0x00);

			// define the format of the file. If only one track, the file will be MIDI format 0.
			// if multiple tracks, the file will be MIDI format 1.
			if (Tracks.Count > 1)
			{
				if (asynchronous)
				{
					objWriter.WriteByte(0x02);
				}
				else
				{
					objWriter.WriteByte(0x01);
				}
			}
			else
			{
				objWriter.WriteByte(0x00);
			}

			if (Tracks.Count < 0x80)
			{
				objWriter.WriteByte(0x00);
			}

			// write out the number of tracks as a variable length quantity.
			VariableLength.WriteVariableLength(objWriter, (ulong)Tracks.Count);

			// write out the number of time-ticks (see AddNote() and AddNotes() methods) that define a quarter-note.
			// by design, this is defined to be 12 time-ticks.
			objWriter.WriteByte(0x00);
			VariableLength.WriteVariableLength(objWriter, 12);

			// go through each track in the list, and output its contents to the file.
			for (int x = 0; x < Tracks.Count; x++)
			{
				Tracks[x].Save(objWriter);
			}
		}
	}
}
