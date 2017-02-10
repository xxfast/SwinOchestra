using System;
using System.Collections.Generic;
namespace Ochestra
{
	public interface TimeKeeper
	{
		List<InstrumentPlayer> Subscibers {get; set;}
		void Subscribe(InstrumentPlayer player);
		void Syncronize();
	}
}

