using System;
using System.Collections.Generic;

namespace Ochestra
{
	public class Composer
	{
		public Composer()
		{
		}

		public StaffSheet Compose(TimeSignature toCompose, int seed)
		{
			StaffSheet toReturn = new StaffSheet(TimeSignature.b44);
			Random rnd = new Random(seed);
			List<Note> notes = new List<Note>() { Note.C, Note.Db, Note.D, Note.Eb, Note.E, Note.F, Note.Gb, Note.G, Note.Ab, Note.A, Note.Bb, Note.B };
			for (int i = 0; i < 4; i++) for (int j = 0; j < 4; j++) toReturn.Tabs[i].Add( notes[rnd.Next(0, notes.Count)] );
			return toReturn;
		}
	}
}
