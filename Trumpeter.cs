using System;
namespace Ochestra
{
	public class Trumpeter : InstrumentPlayer
	{
		public Trumpeter(Trumpet toHold)
		{
			Hold(toHold);
		}

		public override string Play()
		{
			return Instrument.Play(Note.F) + " ... " + Instrument.Play(Note.F);
		}
	}
}

