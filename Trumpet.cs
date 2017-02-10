using System;
using System.Collections.Generic;
namespace Ochestra
{
	public class Trumpet : Instrument
	{
		public Trumpet()
		{
			// Trumpets can only play these notes C - G -  E - Bb - D
			Scale =  new Dictionary<Note,String> {  { Note.C,"paa" },
													{ Note.G,"pra" },
													{ Note.E,"praa"},
													{ Note.Bb,"pre"},
													{ Note.D,"pree"}};
		}

		public override string Play(Note note)
		{
			return (Scale.ContainsKey(note))? Scale[note] : "...";
		}
	}
}

