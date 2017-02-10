using System;

namespace Ochestra
{
	using System.Collections.Generic;
	using Staff = System.Collections.Generic.List<Note>;

	public enum Note { C, Db, D, Eb, E, F, Gb, G, Ab, A, Bb, B}
	public enum TimeSignature { b24 = 2 , b34 = 3, b44 = 4 } 

	public class StaffSheet
	{
		private Staff[] tabs = new Staff[4];
		private TimeSignature signature;

		public TimeSignature Signature
		{
			get { return signature; }
			set { signature = value; }
		}

		public Staff[] Tabs
		{
			get { return tabs; }
			set { tabs = value; }
		}

		public StaffSheet(TimeSignature time)
		{
			Signature = time;
			init();
		}

		public StaffSheet()
		{
			init();
		}

		public void init()
		{
			for (int i = 0; i < 4; i++) Tabs[i] = new Staff();
		}
	}
}

