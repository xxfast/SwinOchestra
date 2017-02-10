using System;

namespace Ochestra
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to Swin-Ochestra!");


			//Composition
			Composer myBeethowen = new Composer();
			StaffSheet composition = myBeethowen.Compose(TimeSignature.b44,0);

			//Conductor 
			Conductor myConductor = new Conductor();

			//Fomation 
			Drummer bassDrummer = new Drummer(new Drum());
			Trumpeter myTrumpeter = new Trumpeter(new Trumpet());

			myConductor.Equip(composition);
			bassDrummer.Read(composition);
			myTrumpeter.Read(composition);

			bassDrummer.ListenTo(myConductor);
			myTrumpeter.ListenTo(myConductor);

			myConductor.Start();
		}
	}
}
