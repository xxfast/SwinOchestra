using NUnit.Framework;
using System;

namespace Ochestra
{
	[TestFixture()]
	public class DrummerTest
	{
		Drummer myDrummer;

		[SetUp()]
		public void init()
		{
			myDrummer = new Drummer(new Drum());
		}

		[Test()]
		public void TestPlay()
		{
			Assert.IsTrue(1<0);
		}
	}
}
