using System;
using System.Timers;
namespace Ochestra
{
	public class Conductor
	{
		int currentTab = 0;
		int currentNote = 0;

		StaffSheet currentlyPlaying;

		public int Tab 
		{ 
			get { return currentTab; }
		}

		public int Note
		{
			get { return currentNote; }
		}

		public void Equip(StaffSheet toPlay)
		{
			currentlyPlaying = toPlay;
		}

		public void Start()
		{
			Timer myTimer = new Timer();
			myTimer.Interval = 1000;
			myTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
			myTimer.Enabled = true;
		}

		private void OnTimedEvent(object sender, ElapsedEventArgs e)
		{
			currentNote++;
			if (currentNote > (int)currentlyPlaying.Signature)
			{
				currentTab++;
				currentNote = 0;
			}
		}

	}
}
