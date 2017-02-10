using System;
using System.Collections.Generic;
namespace Ochestra
{
	public abstract class Instrument
	{
		private String name;
		private Dictionary<Note, String> scale;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public Dictionary<Note, String> Scale
		{
			get { return scale; }
			set { scale = value; }
		}

		public String this[Note n]
		{
			get{ return scale[n]; }
			set{ scale[n] = value;}
		}

		public abstract String Play(Note note);
	}
}

