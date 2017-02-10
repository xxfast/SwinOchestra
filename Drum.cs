using System;
namespace Ochestra
{
	public class Drum : Instrument
	{
		public Drum()
		{
		}

		public override string Play(Note note)
		{
			return "*bom*";
		}
	}
}
